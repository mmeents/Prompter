using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrompterV3.Models {
  public class Item:TreeNode {
    private int _typeId = 0;
    private int _statusId = 0;
    private int _itemRank = 0;
    private int _valueTypeId = 0;
    private string _promptTag = "";
    private string _template = "";
    private string _value = "";
    public bool Dirty = false;

    public Item() : base() { }
    public int Id { get; set; } = 0;
    public int OwnerId { get; set; } = 0;
    public int TypeId {
      get { return _typeId; }
      set {
        Dirty=true;
        _typeId=value;
        if(this.TypeId>= 100 && this.TypeId<=199) {
          this.ImageIndex=(int)Tii.Gift;
          this.SelectedImageIndex=(int)Tii.Gift;
        } else if(this.TypeId>=200&&this.TypeId<=299) {
          this.ImageIndex=(int)Tii.Label;
          this.SelectedImageIndex=(int)Tii.Label;
        } else if(this.TypeId>=300&&this.TypeId<=399) {
          this.ImageIndex=(int)Tii.Folder;
          this.SelectedImageIndex=(int)Tii.Folder;
        } else if(this.TypeId>=400&&this.TypeId<=499) {
          this.ImageIndex=(int)Tii.View;
          this.SelectedImageIndex=(int)Tii.View;
        } else if(this.TypeId>=500&&this.TypeId<=599) {
          this.ImageIndex=(int)Tii.Internal;
          this.SelectedImageIndex=(int)Tii.Internal;
        } else if(this.TypeId>=600&&this.TypeId<=699) {
          this.ImageIndex=(int)Tii.Table;
          this.SelectedImageIndex=(int)Tii.Table;
        } else if(this.TypeId>=700&&this.TypeId<=799) {
          this.ImageIndex=(int)Tii.News;
          this.SelectedImageIndex=(int)Tii.News;
        }
      }
    }
    public int StatusId { get { return _statusId; } set { _statusId=value; Dirty=true; } }
    public int ItemRank { get { return _itemRank; } set { _itemRank=value; Dirty=true; } }
    public string PromptTag { get { return _promptTag; } set { _promptTag=value; Dirty=true; } }
    public new string Text { get { return base.Text; } set { base.Text=value; Dirty=true; } }
    public string Template { get { return _template; } set { _template=value; Dirty=true; } }
    public int ValueTypeId { get { return _valueTypeId; } set { _valueTypeId=value; Dirty=true; } }
    public string Value { get { return _value; } set { _value = value; Dirty=true; } }
   

    public bool CanSwitchDown() {
      if(Parent==null) return false;
      var ImChildNo = Parent.Nodes.IndexOf(this);
      if(ImChildNo<0) return false;
      return ImChildNo<Parent.Nodes.Count-1;
    }
    public Item GetSwitchDownItem() {
      if(Parent==null) return null;
      var ImChildNo = Parent.Nodes.IndexOf(this);
      if(ImChildNo<0) return null;
      if(ImChildNo+1<=Parent.Nodes.Count-1) {
        return ((Item)Parent.Nodes[ImChildNo+1]);
      }
      return null;
    }
    public bool SwitchRankDown() {
      if(Parent==null) return false;
      var ImChildNo = Parent.Nodes.IndexOf(this);
      if(ImChildNo<0) return false;
      if(ImChildNo+1<=Parent.Nodes.Count-1) {
        var rank = ItemRank;
        ItemRank=((Item)Parent.Nodes[ImChildNo+1]).ItemRank;
        ((Item)Parent.Nodes[ImChildNo+1]).ItemRank=rank;
        return true;
      }
      return false;
    }

    public bool CanSwitchUp() {
      if(Parent==null) return false;
      return Parent.Nodes.IndexOf(this)>=1;
    }

    public Item GetSwitchUpItem() {
      if(Parent==null) return null;
      var ImChildNo = Parent.Nodes.IndexOf(this);
      if(ImChildNo<1) return null;
      return ((Item)Parent.Nodes[ImChildNo-1]);
    }

    public bool SwitchRankUp() {
      if(Parent==null) return false;
      var ImChildNo = Parent.Nodes.IndexOf(this);
      if(ImChildNo<1) return false;
      var rank = ItemRank;
      ItemRank=((Item)Parent.Nodes[ImChildNo-1]).ItemRank;
      ((Item)Parent.Nodes[ImChildNo-1]).ItemRank=rank;
      return false;
    }

    public string AsChunk() {
      string pt = string.IsNullOrEmpty( _promptTag ) ? "NULL" : _promptTag;
      string tt = string.IsNullOrEmpty( _template) ? "NULL" : _template;
      string tn = string.IsNullOrEmpty(base.Text) ? "NULL" : base.Text;
      string vc = string.IsNullOrEmpty(_value) ? "NULL" : _value;
      return $"{Id} {OwnerId} {_typeId} {_statusId} {_itemRank} {_valueTypeId} {pt.AsBase64Encoded()} {tn.AsBase64Encoded()} {tt.AsBase64Encoded()} {vc.AsBase64Encoded()}";
    }

    public Item FromChunk(string chunk) {
      string[] base1 = chunk.Parse(" ");
      Id=base1[0].AsInt();
      OwnerId=base1[1].AsInt();
      TypeId=base1[2].AsInt();
      _statusId=base1[3].AsInt();
      _itemRank=base1[4].AsInt();
      _valueTypeId=base1[5].AsInt();
      _promptTag=base1[6].AsBase64Decoded();
      if (_promptTag=="NULL") _promptTag="";
      base.Text=base1[7].AsBase64Decoded();
      if (base.Text=="NULL") base.Text="";
      _template=base1[8].AsBase64Decoded();
      if (_template=="NULL") _template="";
      _value=base1[9].AsBase64Decoded();
      if (_value=="NULL") _value="";
      Dirty=false;
      return this;
    }

    public Item AsClone() { 
      Item item = new Item();
      return item.FromChunk(AsChunk());
    }
  }

  public class Items:ConcurrentDictionary<int, Item> {
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
      if(this.Keys.Count>0) {
        max=this.Select(x => x.Value).Max(x => x.Id);
      }
      return max+1;
    }

    public ICollection<string> AsList { 
      get { 
        List<string> retList = new List<string>();
        foreach(Item i in Values) {
          retList.Add(i.AsChunk());
        }
        return retList;
      }  
      set{ 
        base.Clear();
        foreach(var x in value) {
          Item n = new Item().FromChunk(x);
          this[n.Id] = n;
        }
      } 
    } 
  }

  public class ItemCaster {
    private System.Windows.Forms.TreeView _tv;    
    private FilePackage _package;
    private Items _items;
    private Form1 _ownerForm;
    private Types _types;
    private bool _inUpdate = false;
    private CObject _runtimeLookup = new CObject();
    public bool InUpdate { 
      get { return _inUpdate; }
      set { 
        _inUpdate = value;
        if(!_inUpdate){
          _package.PackageItems=_items;
          _package.Save();
          DoSetRuntimeLookup();
        } 
      }
    }
    public ItemCaster(Form1 ownerform, System.Windows.Forms.TreeView tv, FilePackage package, Types types) 
    {
      _package= package;  
      _tv=tv;
      _ownerForm=ownerform;          
      _items= package.PackageItems;      
      _types= types;
    }

    public void DoSetRuntimeLookup() { 
      _runtimeLookup.Clear();
      foreach(int id in _items.Keys) {
        var promptTag = _items[id].PromptTag;
        if(promptTag.Length>0) {
          _runtimeLookup[promptTag].Value = id.AsString();
        }
      }
    }

    public string BuildTemplatedOutputForItem(Item item) {             
      CObject localNS = new CObject();
      if((item.Parent!=null)&&(item.Parent.Parent!=null)&&(item.Parent.Parent.Parent!=null)) {
        string parentItemsText = "1"; 
        localNS["[Parent3]"].Value=parentItemsText;
      } 
      if((item.Parent!=null)&&item.Parent.Parent!=null) {
        string parentItemsText = "1"; 
        localNS["[Parent2]"].Value=parentItemsText;
      } 
      if (item.Parent != null ) { 
        string parentItemsText = "1"; //BuildTemplatedOutputForItem((Item)item.Parent);
        localNS["[Parent]"].Value = parentItemsText;
      }
      localNS["[Name]"].Value = item.Text;
      localNS["[Value]"].Value = item.Value;
            
      if( item.Template.Length > 0) {
        string template = item.Template;
        string templateTag = template.GetNextTag();
        while(templateTag != "") {
          if(localNS.Contains(templateTag)) {
            string replaceValue = "";
            if(templateTag=="[Parent]") { 
              replaceValue = BuildTemplatedOutputForItem((Item)item.Parent);
            } else if(templateTag=="[Parent2]") {
              replaceValue=BuildTemplatedOutputForItem((Item)item.Parent.Parent);
            } else if(templateTag=="[Parent3]") {
              replaceValue=BuildTemplatedOutputForItem((Item)item.Parent.Parent.Parent);
            } else {
              replaceValue=localNS[templateTag].Value;
            }
            template=template.Replace(templateTag, replaceValue);
          } else {
            if(_runtimeLookup.Contains(templateTag)) {
              int id = _runtimeLookup[templateTag].Value.AsInt();
              string replaceValue = BuildTemplatedOutputForItem(_items[id]);
              template=template.Replace(templateTag, replaceValue);
            } else {
              template=template.Replace(templateTag, "");
            }
          }
          templateTag = template.GetNextTag();
        }                 
        return template.Replace("\"\"","\"");
      } 
      return item.Text;
    }

    public void LoadTreeviewItemsAsync(System.Windows.Forms.TreeView ownerItem, System.Windows.Forms.ProgressBar pb) {
      ownerItem.Nodes.Clear();
      decimal step = (pb.Maximum-pb.Value-1);
      int val = pb.Value;
      IEnumerable<Item> result = _items.GetChildrenItems(0);
      int rc = result.Count()+1;
      step=(step/rc);
      foreach(Item item in result) {
        ownerItem.Nodes.Add(LoadChildren(item));        
        if(val+Convert.ToInt32(step)<10000) {
          val=val+Convert.ToInt32(step);
          _ownerForm.SetInProgress(val);
        }
      }      
    }

    public Item LoadChildren(Item item) {
      var items = GetOwnersItemsAsync(item.Id);
      if(item.Nodes.Count>0) item.Nodes.Clear();
      foreach(Item it in items) {
        if (!item.Nodes.Contains(it)) item.Nodes.Add(it);
      }
      item.Dirty=false;
      return item;
    }

    public IEnumerable<Item> GetOwnersItemsAsync(int ownerItemId) {
      IEnumerable<Item> result = _items.GetChildrenItems(ownerItemId);
      List<Item> cloned = new List<Item>();
      foreach(Item i in result) {
        cloned.Add( i.AsClone()  ); 
      }
      return cloned;
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
      if(item.Id==0) {
        item.Id=_items.GetNextId();
      }
      _items[item.Id]=item;
      if(!InUpdate) { 
        _package.PackageItems = _items;      
        _package.Save();
        DoSetRuntimeLookup();
      }
      item.Dirty=false;
      return item;
    }

    private Item AddSubItemFromType(Item ownerItem, ItemType itemType) {
      
      int NextRank = ownerItem.Nodes.Count+1;
      int NextId = _items.GetNextId();
      Item dbs=new Item() {
          Id=NextId,
          OwnerId=ownerItem.Id,
          ItemRank=NextRank,
          StatusId=0,
          TypeId=itemType.TypeId,
          Template=itemType.Template,
          PromptTag=itemType.PromptTag.Replace("#", NextId.AsString()),
          Text=itemType.Name,
          ValueTypeId=0,
          Value = ""
        };
      if(ownerItem!=null) {
        ownerItem.Nodes.Add(dbs);
        ownerItem.Expand();
      }
      SaveItem(dbs);
      var components = _types.GetChildrenItemsNoDef(itemType.TypeId);      
      foreach(ItemType i in components) {
        AddSubItemFromType(dbs, i);
      }      
      
      
      return dbs;
    }
    public Item SaveNewItemFromType(Item ownerItem, ItemType itemType) {      
      Item dbs;
      int NextId = _items.GetNextId();
      if(ownerItem==null) {        
        dbs=new Item() {
          Id=NextId,
          OwnerId=0,
          ItemRank=1,
          StatusId=0,
          TypeId=itemType.TypeId,
          Text=itemType.Name,
          Template=itemType.Template,
          PromptTag=itemType.PromptTag.Replace("#", NextId.AsString()),
          ValueTypeId=0
        };
      } else {
        int NextRank = ownerItem.Nodes.Count+1;
        dbs=new Item() {
          Id=NextId,
          OwnerId=ownerItem.Id,
          ItemRank=NextRank,
          StatusId=0,
          TypeId=itemType.TypeId,
          Text=itemType.Name,
          Template=itemType.Template,
          PromptTag=itemType.PromptTag.Replace("#", NextId.AsString()),
          ValueTypeId=0
        };
      }
      if (dbs ==null) return null;
      SaveItem(dbs);
      this.InUpdate = true;
      var components = _types.GetChildrenItemsNoDef(itemType.TypeId);
      foreach(ItemType i in components) {
        AddSubItemFromType(dbs, i);
      }      
      if(ownerItem!=null) {
        ownerItem.Nodes.Add(dbs);
        ownerItem.Expand();
      }
      this.InUpdate = false;
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
          DragItem.OwnerId=0;
          SaveDragged=true;
        } else {
        }
      } else {
        if(!newOwnerItem.Nodes.Contains(DragItem)) {
          if(DragItem.Parent.Nodes.Contains(DragItem)) {
            DragItem.Parent.Nodes.Remove(DragItem);
          }
          newOwnerItem.Nodes.Add(DragItem);
          DragItem.OwnerId=newOwnerItem.Id;
          SaveDragged=true;
        }
      }
      if(SaveDragged) SaveItem(DragItem);
      return DragItem;
    }

    public Item SaveNewChildItemsFromText(Item ownerItem, ItemType itemType, string text) {
      Item curParent = ownerItem;
      string[] lines = text.Parse(Environment.NewLine);      
      this.InUpdate = true;
      int newItemType = itemType.TypeId;
      var components = _types.GetChildrenItemsNoDef(itemType.TypeId);
      if(lines.Count()>0) {
        foreach(string line in lines) {
          bool goneNested = false;
          if(line.Trim().Last<char>()==':') { 
            newItemType =itemType.TypeId;
            curParent = ownerItem;
            goneNested = true;
          }
          int newID = 0;
          int newItemRank = 0;          
          if(curParent!=null) { 
            newID =curParent.Id;
            newItemRank =curParent.Nodes.Count+1;          
          }
          Item dbs = new Item() {
            Id=_items.GetNextId(),
            OwnerId=newID,
            ItemRank=newItemRank,
            StatusId=0,
            TypeId=newItemType,
            Text=line,
            Template=itemType.Template,
            PromptTag=itemType.PromptTag.Replace("#", newID.AsString()),
            ValueTypeId=0
          };          
          if (curParent!=null) {
            curParent.Nodes.Add(dbs);
          } else {
            _tv.Nodes.Add(dbs);
          }         
          SaveItem(dbs);
          foreach(ItemType i in components) {
            AddSubItemFromType(dbs, i);
          }
          if (goneNested) {             
            curParent = dbs;
          }          
        }
        if(!(ownerItem==null)) {
          ownerItem.Expand();
        }
        
      }
      this.InUpdate = false;
      return ownerItem;
    }

    public void NestedRemoveItem(Item item) {
      if(item==null) return;
      if(item.Nodes.Count==0) {
        _items.Remove(item.Id);
      } else {
        foreach(Item cItem in item.Nodes) {
          NestedRemoveItem(cItem);
        }
      }
    }

    public void RemoveItem(Item item) {
      if(item==null) return;
      NestedRemoveItem(item);
      _package.PackageItems=_items;
      _=Task.Run(async () => await _package.SaveAsync().ConfigureAwait(false));
    }

  }

  public static class Ic {

    public static string GetOutputTextEditor(this Item it, Types types, ItemCaster caster) {
      return caster.BuildTemplatedOutputForItem(it).Nl();             
    }

    public static string GetChildContentText(this Item it, ItemCaster caster) {
      string s = "";
      foreach(Item c in it.Nodes) {
        s=s + (s==""? "" :Environment.NewLine) + caster.BuildTemplatedOutputForItem( c);
      }
      return s.Nl();
    }

    public static string GetChildContent(this Item it, ItemCaster caster) {
      StringBuilder s = new StringBuilder();
      if ((it.TypeId == (int)TnType.Project)||(it.TypeId == (int)TnType.Chapters)) { 
        s.Append( "<UL class=\"text2\">");
        foreach(Item c in it.Nodes) {
          s.Append( "<LI >"+caster.BuildTemplatedOutputForItem(c)+"<br/>"+ c.GetChildContent(caster)+"</LI>");
        }
        s.Append("</UL>");
      }else {        
        foreach(Item c in it.Nodes) {
          s.Append("<p class=\"text3\" style=\"padding-bottom:10px;\">");
          s.Append(c.Text );
          s.Append("</p>");
        }        
      }
      return s.ToString();
    }
    public static string GetRichTextEditor(this Item it, Types types, ItemCaster caster) {
      string pit = "";
      string gpit = "";
      string sit = caster.BuildTemplatedOutputForItem(it);
      if ((it.TypeId ==(int)TnType.Essay)) {

      } else {     
        if(it.OwnerId>0) {
          if(it.Parent!=null) {
            pit= caster.BuildTemplatedOutputForItem((Item)it.Parent);
            if(((Item)it.Parent).OwnerId>0&&it.Parent.Parent!=null) {
              gpit=caster.BuildTemplatedOutputForItem((Item)it.Parent.Parent);
            }
          }
        }
      }
      string s =  it.GetChildContent(caster);
      sit = $"<div class=\"text2\">{sit}</div><br/>";
      pit = pit == "" ? "" : $"<div class=\"text2\">{pit}</div><br/>\r\n";
      gpit = gpit==""?"": $"<div class=\"text2\">{gpit}</div><br/>\r\n";
      string sr = "<!DOCTYPE html>\r\n<html lang=\"en\">\r\n"+
        $"<head>\r\n  <meta charset=\"UTF-8\"/>\r\n  <title>{sit}</title>\r\n"+
        "<style>\r\n"+
        "  .text1 { font-family: 'Segoe UI', Arial, sans-serif; font-size: 16.2pt; }\r\n"+
        "  .text2 { font-family: 'Segoe UI', Arial, sans-serif; font-size: 14.2pt; }\r\n"+
        "  .text3 { font-family: 'Segoe UI', Arial, sans-serif; font-size: 12.2pt; }\r\n"+        
        "</style>\r\n"+
        "</head>\r\n"+
        $"<body>\r\n"+
          gpit+pit+sit + s +
        "</body>\r\n</html>";
      return sr;
    }
  }
}
