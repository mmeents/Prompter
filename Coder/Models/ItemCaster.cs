using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prompter.Models {
  public class Item:TreeNode {
    private int _typeId = 0;
    private int _statusId = 0;
    private int _itemRank = 0;
    private int _valueTypeId = 0;

    public bool Dirty = false;
    public Item() : base() { }
    public int Id { get; set; } = 0;
    public int OwnerId { get; set; } = 0;
    public int TypeId {
      get { return _typeId; }
      set {
        Dirty=true;
        _typeId=value;
        switch(this.TypeId) {
          case (int)TnType.Project:
            this.ImageIndex=(int)Tii.Gift;
            this.SelectedImageIndex=(int)Tii.Gift;
            break;
          case (int)TnType.Template:
            this.ImageIndex=(int)Tii.Label;
            this.SelectedImageIndex=(int)Tii.Label;
            break;             
          case (int)TnType.Chapters:
            this.ImageIndex=(int)Tii.Folder;
            this.SelectedImageIndex=(int)Tii.Folder;
            break;
          case (int)TnType.Chapter:
            this.ImageIndex=(int)Tii.View;
            this.SelectedImageIndex=(int)Tii.View;
            break;
          case (int)TnType.Section:
            this.ImageIndex=(int)Tii.Internal;
            this.SelectedImageIndex=(int)Tii.Internal;
            break;
          case (int)TnType.SubSection:
            this.ImageIndex=(int)Tii.News;
            this.SelectedImageIndex=(int)Tii.News;
            break;
        }
      }
    }
    public int StatusId { get { return _statusId; } set { _statusId=value; Dirty=true; } }
    public int ItemRank { get { return _itemRank; } set { _itemRank=value; Dirty=true; } }
    public new string Text { get { return base.Text; } set { base.Text=value; Dirty=true; } }

    public int ValueTypeId { get { return _valueTypeId; } set { _valueTypeId=value; Dirty=true; } }

    public string AsChunk() {
      return $"{Id} {OwnerId} {_typeId} {_statusId} {_itemRank} {_valueTypeId} {base.Text.AsBase64Encoded()}".AsBase64Encoded();
    }
    public Item FromChunk(string chunk) {
      string base1 = chunk.AsBase64Decoded();
      Id=base1.ParseString(" ", 0).AsInt();
      OwnerId= base1.ParseString(" ", 1).AsInt();
      TypeId=base1.ParseString(" ", 2).AsInt();
      _statusId=base1.ParseString(" ", 3).AsInt();
      _itemRank=base1.ParseString(" ", 4).AsInt();
      _valueTypeId=base1.ParseString(" ", 5).AsInt();
      base.Text = base1.ParseString(" ", 6).AsBase64Decoded();    
      Dirty = false;
      return this;
    }
  }

  public class Items : ConcurrentDictionary<int, Item> { 
    public Items() : base() { }
    public virtual Boolean Contains(int id) {
      try {
        return !(base[id] is null);
      } catch {
        return false;
      }
    }
    public virtual new Item this[int id] {
      get { return Contains(id) ? base[id] : null; }
      set { if(value!=null) { base[id]=value; } else { Remove(id); } }
    }
    public virtual void Remove(int id) { if(Contains(id)) { _=base.TryRemove(id, out _); } }

    public IEnumerable<Item> GetChildrenItems(int id) {
      return this.Select(x => x.Value).Where(x => x.OwnerId==id).OrderBy(x => x.ItemRank);
    }
    public int GetNextId() { 
      int max = 0;
      if (this.Keys.Count > 0) { 
        max = this.Select(x=>x.Value).Max(x=>x.Id);
      }
      return max + 1;
    }
  }

  public class ItemCaster { 
    private TreeView _tv;
    private CryptoVars _cryptoVars;
    private Items _items;
    
    public ItemCaster(TreeView tv, CryptoKey key, string fileName) {
      _items = new Items();
      _cryptoVars=new CryptoVars();
      _tv = tv;
      _cryptoVars.FileName=fileName;
      _cryptoVars.SetKey(key);
      _cryptoVars.LoadValues();

      foreach(string k in _cryptoVars.Keys) { 
        Item x = new Item().FromChunk(_cryptoVars[k].Value);
        _items[x.Id] = x;        
      }
    }

    public void LoadTreeviewItemsAsync(System.Windows.Forms.TreeView ownerItem, ProgressBar pb) {      
      ownerItem.Nodes.Clear();
      decimal step = (pb.Maximum - pb.Value - 1); 
      IEnumerable<Item> result = _items.GetChildrenItems(0);
      int rc = result.Count();
      step = (rc==0 ? step : ( rc < step ?  step / rc : 1 ));
      foreach(Item item in result) {
        ownerItem.Nodes.Add(LoadChildren(item));
        if (pb.Value +Convert.ToInt32(step) < pb.Maximum) {
          pb.Value=pb.Value+Convert.ToInt32(step);
        }         
      }
      if (pb.Value +Convert.ToInt32(step) < pb.Maximum) {
          pb.Value=pb.Value+Convert.ToInt32(step);
        }
    }

    public Item LoadChildren(Item item) {
      var items = GetOwnersItemsAsync(item.Id);
      if(item.Nodes.Count>0) item.Nodes.Clear();
      foreach(Item it in items) {
        item.Nodes.Add(it);
      }
      item.Dirty=false;
      return item;
    }

    public IEnumerable<Item> GetOwnersItemsAsync(int ownerItemId) {
      IEnumerable<Item> result = _items.GetChildrenItems(ownerItemId);
      return result;
    }

    public Item GetOwnersItemsAsync(Item ownerItem) {
      foreach(Item item in ownerItem.Nodes) {
        ReloadChildren(LoadChildren(item));
      }
      return ownerItem;
    }

    public Item ReloadChildren(Item child) {
      List<Item> temp = new List<Item>();
      foreach(Item item in child.Nodes) {
        temp.Add(item);
      }
      foreach(Item item in temp) {
        child.Nodes.Remove(item);
        child.Nodes.Add(LoadChildren(item));
      }
      child.Dirty=false;
      return child;
    }

    public Item SaveItem(Item item) { 
      if(item==null) return null;
      if(item.Id ==0) {
        item.Id = _items.GetNextId();
      }
      _items[item.Id] = item;
      _cryptoVars[item.Id.AsString()].Value = item.AsChunk();
      item.Dirty=false;
      return item;
    }

    public Item SaveNewItemFromType(Item ownerItem, ItemType itemType) {
      Item dbs;
      if(ownerItem==null) {
        dbs=new Item() {
          Id=0,
          OwnerId=0,
          ItemRank=1,
          StatusId=0,
          TypeId=itemType.TypeId,
          Text=itemType.Name,
          ValueTypeId=0
        };
      } else {
        dbs=new Item() {
          Id=0,
          OwnerId=ownerItem.Id,
          ItemRank=ownerItem.Nodes.Count+1,
          StatusId=0,
          TypeId=itemType.TypeId,
          Text=itemType.Name,
          ValueTypeId=0
        };
      }
      SaveItem(dbs);
      if(ownerItem!=null) {        
        ownerItem.Nodes.Add(dbs);
        ownerItem.Expand();
      }
      return dbs;
    }

    public Item MoveItemSave(Item newOwnerItem, Item DragItem) {
      bool SaveDragged = false;
      if(newOwnerItem==null) {
        if(!_tv.Nodes.Contains(DragItem)) {
          if(DragItem.Parent.Nodes.Contains(DragItem)) {
            DragItem.Parent.Nodes.Remove(DragItem);
          }
          _tv.Nodes.Add(DragItem);
          DragItem.OwnerId = 0;
          SaveDragged=true;
        } else { 
        }        
      } else {
        if (!newOwnerItem.Nodes.Contains(DragItem)){
          if(DragItem.Parent.Nodes.Contains(DragItem)) {
            DragItem.Parent.Nodes.Remove(DragItem);
          }
          newOwnerItem.Nodes.Add(DragItem);
          DragItem.OwnerId = newOwnerItem.Id;
          SaveDragged = true;
        }         
      }
      if(SaveDragged) SaveItem(DragItem);      
      return DragItem;
    }

    public Item SaveNewChildItemsFromText(Item ownerItem, ItemType itemType, string text) {             
      string[] lines = text.Parse(Environment.NewLine);
      if (lines.Count() > 0) { 
        foreach (string line in lines) { 
          Item dbs = new Item() { 
            Id=0,
            OwnerId=ownerItem.Id,
            ItemRank= ownerItem.Nodes.Count+1,
            StatusId=0,
            TypeId=itemType.TypeId,
            Text=line,
            ValueTypeId =0
          };
          SaveItem(dbs);
          ownerItem.Nodes.Add(dbs );          
        }
        ownerItem.Expand();
      }
      return ownerItem;
    }

    public void RemoveItem(Item item) {
      if(item==null) return;
      if(item.Nodes.Count==0) {
        _cryptoVars.RemoveVar(item.Id.AsString());
        _items.Remove(item.Id);        
      }      
    }

  }

  public static class Ic {
    public static string GenerateSqlCreateTable(this Item tnTable, Types types) {
      string r = $"-- a table create {Cs.nl}Create Table {tnTable.Text}({Cs.nl}";
      foreach(Item tn in tnTable.Nodes) {
        if(tn.Text.ToLower()=="id") {
          r+="    "+tn.Text+" [int] NOT NULL IDENTITY(1,1),"+Cs.nl;
        } else {
          r+="    "+tn.Text+" "+types[tn.ValueTypeId].Desc+" NULL,"+Cs.nl;
        }
      }
      r+=$"    CONSTRAINT [PK_{tnTable.Text}_Id] PRIMARY KEY CLUSTERED ([ID]) {Cs.nl})";
      return r;
    }


    public static string GetSqlTypeFromStatusIdString(this int ValueTypeId, Types types) {
      return types[ValueTypeId].Desc;
    }

    public static string GenerateSQLAddUpdateStoredProc(this Item tnTable, Types types) {
      Item cn = tnTable;
      string nl = Environment.NewLine;
      string tblText = tnTable.Text;
      string tblTitle = tnTable.Text.RemoveChar('.');
      string sSQLParam1 = tnTable.GetSQLParamList(types);
      string sInsertListAsSQlParams = tnTable.GetSQLInsertListAsSQLParam();
      string sColList = tnTable.GetSQLColumnList(false);
      string sAssignColSQL = GetAssignChildSQLColList(tnTable);
      string sKeyType = "", sKey = "", sKeyB = "";
      Item keyCol;
      if(tnTable.Nodes.Count>0) {
        keyCol=(Item)tnTable.Nodes[0];
        sKey=keyCol.Text;
        sKeyB="["+sKey+"]";
        sKeyType=types[keyCol.ValueTypeId].Desc;
      }
      string sDefNullValue = Cs.SQLDefNullValueSQL(sKeyType);
      return
        "-- Add Update SQL Stored Proc for "+tblText+""+nl+
        "Create Procedure dbo.sp_AddUpdate"+tblTitle+" ("+nl+
        "  "+sSQLParam1+nl+
        ") as "+nl+
        "  set nocount on "+nl+
       $"  declare @a {sKeyType} set @a = case when (@{sKey}=0) then 0 else isnull((select "+sKeyB+" from "+tblText+
          " with(nolock) where "+sKeyB+" = @"+sKey+"), "+sDefNullValue+") end  "+nl+
        "  if (@a = "+sDefNullValue+") begin"+nl+
        "    Insert into "+tblText+" ("+nl+
        "      "+sColList+nl+
        "    ) values ("+nl+"      "+sInsertListAsSQlParams+")"+nl+
        "    set @a = @@Identity "+nl+
        "  end else begin"+nl+
        "    Update "+tblText+
             " set"+nl+sAssignColSQL+nl+
          "    where "+sKeyB+" = @a"+nl+
        "  end"+nl+
        "  select @a "+sKey+nl+"return";
    }

    public static string GenerateSQLStoredProc(this Item tnProc, Types types) {
      Item cn = tnProc;
      string tblText = tnProc.Text;
      string sSQLParam1 = tnProc.GetSQLParamList(types);
      string sSqlDeclare = tnProc.GetDeclareSQLParam(types);
      return
        "-- Add Update SQL Stored Proc for "+tblText+""+Cs.nl+
        "Create Procedure "+tblText+" ("+Cs.nl+
        "  "+sSQLParam1+Cs.nl+
        ") as "+Cs.nl+
        "  set nocount on "+Cs.nl+Cs.nl+
        "return"+Cs.nl+Cs.nl+
        "-- call to execute"+Cs.nl+
        sSqlDeclare+Cs.nl+
        $"Exec {tnProc.Text} {tnProc.GetSQLInsertListAsSQLParam(true)}";
    }

    public static string GenerateSQLFunction(this Item tnFunction, Types types) {
      Item cn = tnFunction;
      string tblText = tnFunction.Text;
      string sSQLParam1 = tnFunction.GetSQLParamList(types);
      return
        "-- Add Update SQL Stored Proc for "+tblText+""+Cs.nl+
        "Create Function "+tblText+" ("+Cs.nl+
        "  "+sSQLParam1+Cs.nl+
        ") as "+Cs.nl+
        "  "+Cs.nl+Cs.nl+
        "return";
    }

    public static string GetSQLParamList(this Item tnTable, Types types) {
      string sRes = "";
      foreach(Item tnColumn in tnTable.Nodes) {
        if(sRes=="") {
          sRes="@"+tnColumn.Text+$" {types[tnColumn.ValueTypeId].Desc}";
        } else {
          sRes=sRes+","+Environment.NewLine+"  @"+tnColumn.Text+$" {types[tnColumn.ValueTypeId].Desc}";
        }
      }
      return sRes;
    }

    public static string GetSQLInsertListAsSQLParam(this Item tnTable, bool IncludeFirstCol = false) {
      string sRes = ""; string sFTT = "true";
      foreach(Item tn in tnTable.Nodes) {
        if(sFTT=="true") {
          sFTT="false";
          if(IncludeFirstCol) {
            sRes="@"+tn.Text;
          }
        } else {
          if(sRes=="") {
            sRes="@"+tn.Text;
          } else {
            sRes=sRes+", @"+tn.Text;
          }
        }
      }
      return sRes;
    }

    public static string GetSQLColumnList(this Item tnTable, Boolean IncludeKeyField) {
      string sRes = ""; string sFTT = (IncludeKeyField ? "false" : "true");
      foreach(Item tn in tnTable.Nodes) {
        if(sFTT=="true") {
          sFTT="false";  // don't include the first Keyfield.
        } else {
          if(sRes=="") {
            sRes="["+tn.Text+"]";
          } else {
            sRes=sRes+", ["+tn.Text+"]";
          }
        }
      }
      return sRes;
    }

    public static string GetAssignChildSQLColList(this Item tnTable) {
      string sRes = ""; string sFTT = "true";
      foreach(Item tn in tnTable.Nodes) {
        string sCurCol = tn.Text;
        if(sFTT=="true") {
          sFTT="false";
        } else {
          if(sRes=="") {
            sRes="      ["+sCurCol+"] = @"+sCurCol;
          } else {
            sRes=sRes+","+Environment.NewLine+"      ["+sCurCol+"] = @"+sCurCol;
          }
        }
      }
      return sRes;
    }

    public static string GetDeclareSQLParam(this Item tnStProc) {
      string s = "";
      foreach(Item cn in tnStProc.Nodes) {
        s=s+"declare "+cn.Text+" set "+cn.Text.ParseFirst(" ")+" = "+Cs.SQLDefNullValueSQL(cn.Text.ParseLast(" "))+";"+Cs.nl;
      }
      return s;
    }
    public static string GetExecSQLStoredProcedure(this Item tnStProc) {
      return "--  the call to execute "+Cs.nl
        +GetDeclareSQLParam(tnStProc)+Cs.nl
        +$"Exec {tnStProc.Text} {tnStProc.GetSQLInsertListAsSQLParam(true)}";
    }

    public static string GetCSharpColAsProps(this Item cn, Types types) {
      string sRes = "";
      string nl = Environment.NewLine;
      foreach(Item tn in cn.Nodes) {
        string scol = tn.Text.AsUpperCaseFirstLetter();
        sRes=sRes+$"    public {Cs.GetCTypeFromSQLType(types[tn.ValueTypeId].Desc)} {scol}"+"{get; set;} = "+Cs.SQLDefNullValueCSharp(types[tn.ValueTypeId].Desc)+";"+nl;
      }
      return sRes;
    }

    public static string GenerateCSharpRepoLikeClassFromTable(this Item tnTable, Types types, bool IncludeNamespace = true) {
      Item cn = tnTable;
      string tblName = cn.Text;
      String sDB = cn.Parent.Parent.Text;
      string sColListb = cn.GetSQLColumnList(true);
      string nl = Environment.NewLine;
      string sFirstCol;
      string sKeyType = "", sKey = "";
      if(cn.Nodes.Count>0) {
        Item keyCol = (Item)cn.Nodes[0];
        sFirstCol=keyCol.Text;
        sKey=sFirstCol.AsLowerCaseFirstLetter();
        sKeyType=Cs.GetCTypeFromSQLType(types[keyCol.ValueTypeId].Desc);
      }
      string a = "";
      string d = "";
      for(Int32 i = 0; i<tnTable.Nodes.Count; i++) {
        Item iI = (Item)tnTable.Nodes[i];
        a=a+(a=="" ? "" : ", ")+$"{iI.Text.AsUpperCaseFirstLetter()} = {iI.Text.AsLowerCaseFirstLetter()}";
        d=d+(d=="" ? "" : ", ")+$"{Cs.GetCTypeFromSQLType(types[iI.ValueTypeId].Desc)} {iI.Text.AsLowerCaseFirstLetter()}";
      }
      string className = tblName.RemoveChar('.').AsUpperCaseFirstLetter();
      string classVarName = className.AsLowerCaseFirstLetter();
      return
        (IncludeNamespace ? Cs.GetNamespaceText(sDB) : "")+
        "  // C Entity Class "+nl+
       $"  public class {className}"+"{"+nl+
       $"    public {tblName.ParseLast(".")}()"+"{}"+nl+
               cn.GetCSharpColAsProps(types)+
        "  }"+nl+nl+
       $"  public class {className}Repository"+"{"+nl+
       $"    // C Dapper Load List of {className}"+nl+
       $"    public async Task<ActionResult> {className}IndexAsync()"+"{"+nl+
       $"      IEnumerable<{className}> result;"+nl+
        "      string connectionString = GetConnectionString();"+nl+
        "      using (SqlConnection connection = new SqlConnection(connectionString)) {"+nl+
       $"        result = await connection.QueryAsync<{className}>("+nl+
       $"          \"select {sColListb} from {tblName} \");"+nl+
        "      }"+nl+
        "      return Ok(result);"+nl+
        "    }"+nl+nl+
        "    // C Dapper Load single Item"+nl+
       $"    public async Task<ActionResult> {className}ItemAsync({sKeyType} {sKey})"+"{"+nl+
        "      string connectionString = GetConnectionString();"+nl+
       $"      {className} result;"+nl+
        "      using (SqlConnection connection = new SqlConnection(connectionString)) {"+nl+
        "        var param = new {"+sKey+"};"+nl+
       $"        result = await connection.QueryFirstOrDefaultAsync<{className}>("+nl+
       $"          \"select {sColListb} from {tblName} where {sKey} = @{sKey} \", param);"+nl+
        "      }"+nl+
        "      return Ok($\"{result.AsJson()}\");"+nl+
        "    }"+nl+nl+
        "    // C Dapper Edit via Add Update stored procdure"+nl+
       $"    public async Task<int> {className}EditAsync({className} {classVarName}) "+"{"+nl+
        "      string connectionString = GetConnectionString();"+nl+
       $"      int result = 0;"+nl+
        "      using (SqlConnection connection = new SqlConnection(connectionString)) {"+nl+
       $"        result = await connection.QueryFirstOrDefaultAsync<int>("+nl+
       $"          \"dbo.sp_AddUpdate{className}\", {classVarName}, commandType: CommandType.StoredProcedure);"+nl+
        "      }"+nl+
        "      return result;"+nl+
        "    }"+nl+nl+
        "    // C Dapper Edit via Add Update stored procdure x2"+nl+
       $"    public async Task<int> {className}Edit2Async({d}) "+"{"+nl+
        "      string connectionString = GetConnectionString();"+nl+
       $"      int result = 0;"+nl+
        "      using (SqlConnection connection = new SqlConnection(connectionString)) {"+nl+
       $"        {className} {classVarName} = new {className}(){{ {a} }};"+nl+
       $"        result = await connection.QueryFirstOrDefaultAsync<int>("+nl+
       $"          \"dbo.sp_AddUpdate{className}\", {classVarName}, commandType: CommandType.StoredProcedure);"+nl+
        "      }"+nl+
        "      return result;"+nl+
        "    }"+nl+nl+
        "    // C Dapper delete via Execute"+nl+
       $"    public async Task<ActionResult> {className}DeleteAsync({sKeyType}{sKey})"+"{"+nl+
        "      int result = 0;"+nl+
        "      string connectionString = GetConnectionString();"+nl+
        "      var param = new {"+$"{sKey}"+"};"+nl+
        "      using (SqlConnection connection = new SqlConnection(connectionString)) {"+nl+
        "        result = await connection.ExecuteAsync("+nl+
        "          \"delete from "+$"{tblName} where [{sKey}] = @{sKey} "+"\", param);"+nl+
        "      }"+nl+
        "      return Ok(result == 1);"+nl+
        "    }"+nl+
        "  }"+nl+
        (IncludeNamespace ? "}" : "");


    }

    public static string GenerateCSharpExecStoredProc(this Item tnStProc, Types types) {
      string sDBName = tnStProc.Parent.Text.ParseFirst(":");
      string a = "";
      string d = "";
      for(Int32 i = 0; i<tnStProc.Nodes.Count; i++) {
        a=a+(a=="" ? "" : ", ")+tnStProc.Nodes[i].Text.ParseString(" @", 0);
        d=d+(d=="" ? "" : ", ")+$"{Cs.GetCTypeFromSQLType(types[((Item)tnStProc.Nodes[i]).ValueTypeId].Desc)} {tnStProc.Nodes[i].Text.ParseFirst(" @")}";
      }
      string className = tnStProc.Text.ParseLast(".").AsUpperCaseFirstLetter();
      var s = "    // C Dapper Edit via Add Update stored procdure"+Cs.nl+
        $"    public async Task<ActionResult> Exec{className}Async({d}) "+"{"+Cs.nl+
        $"      string connectionString = Settings.GetConnectionString(\"{sDBName}\");"+Cs.nl+
        $"      {className}Result result;"+Cs.nl+
         "      var params = new {"+$"{a}"+"};"+Cs.nl+
         "      using (SqlConnection connection = new SqlConnection(connectionString)) {"+Cs.nl+
        $"        result = await connection.QueryAsync<{className}Result>(\"{tnStProc.Text.ParseFirst(" ")}\", params, commandType: CommandType.StoredProcedure);"+Cs.nl+
         "      }"+Cs.nl+
         "      return Ok(result.ToJson());"+Cs.nl+
         "    }"+Cs.nl+Cs.nl;
      return s;
    }

    public static string GetDeclareSQLParam(this Item tnStProc, Types types) {
      string s = "";
      foreach(Item cn in tnStProc.Nodes) {
        s=s+$"declare @{cn.Text} {types[cn.ValueTypeId].Desc} set @"+cn.Text+" = "+Cs.SQLDefNullValueSQL(types[cn.ValueTypeId].Desc)+";"+Cs.nl;
      }
      return s;
    }

  }

}
