using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prompter.Models {
  public enum TnType {
    Types = 1,
    Project = 18,
    Template = 19,

    // folders
    Chapters = 20,
    Chapter = 21,
    Section = 22,
    SubSection = 23,

  }

  public enum Tii {
    Internal = 0,
    Server = 1,
    Database = 2,
    Folder = 3,
    View = 4,
    Table = 5,
    Procedure = 6,
    Function = 7,
    Column = 8,
    News = 9,
    Search = 10,
    Gift = 11,
    Add = 12,
    Play = 13,
    Stop = 14,
    Delete = 15,
    Label = 16,
    Share = 17,
    Setup = 18,
    logo = 19
  }
  public class ItemType:TreeNode {
    public ItemType() { }
    private int _id;
    public int TypeId {
      get { return _id; }
      set {
        _id=value;
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
    public int OwnerTypeId { get; set; } = 0;
    public int CatagoryTypeId { get; set; } = 0;
    public int EditorTypeId { get; set; } = 0;
    public int TypeRank { get; set; } = 0;
    public int TypeEnum { get; set; } = 0;
    public new string Name { get { return base.Text; } set { base.Text=value; } }
    public bool Visible { get; set; } = false;
    public string Desc { get; set; } = "";
    public bool Readonly { get; set; } = false;

  }


  public class Types : ConcurrentDictionary<int, ItemType> {    
    public Types() : base() {      
      Load();
    }
    public void Load() {
      base.Clear();
      this[0]=new ItemType() { TypeId=0, OwnerTypeId=0, CatagoryTypeId=0, EditorTypeId=0, TypeRank=0, TypeEnum=0, Name="none", Visible=true, Readonly=true, Desc="" };

      this[1]=new ItemType() { TypeId=1, OwnerTypeId=1, CatagoryTypeId=0, EditorTypeId=10, TypeRank=1, TypeEnum=1, Visible=false, Readonly=true, Name="Internal", Desc="Root " };
      this[2]=new ItemType() { TypeId=2, OwnerTypeId=1, CatagoryTypeId=2, EditorTypeId=10, TypeRank=1, TypeEnum=1, Visible=false, Readonly=true, Name="CatagoryTypes", Desc="Catagory Type" };
      this[7]=new ItemType() {TypeId=7, OwnerTypeId=1, CatagoryTypeId=3, EditorTypeId=10, TypeRank=1, TypeEnum=1, Visible=false, Readonly=true, Name="EditorTypes", Desc="Editor Type" };
      this[17]=new ItemType() {TypeId=17, OwnerTypeId=1, CatagoryTypeId=4, EditorTypeId=10, TypeRank=1, TypeEnum=1, Visible=false, Readonly=true, Name="thisTypes", Desc="Model Type" };
      this[28]=new ItemType() {TypeId=28, OwnerTypeId=1, CatagoryTypeId=3, EditorTypeId=10, TypeRank=1, TypeEnum=1, Visible=false, Readonly=true, Name="Lookups", Desc="Lookup Editors" };

      this[3]=new ItemType() {TypeId=3, OwnerTypeId=2, CatagoryTypeId=3, EditorTypeId=10, TypeRank=1, TypeEnum=1, Visible=false, Readonly=true, Name="Internal", Desc="Catagory Internal" };
      this[4]=new ItemType() {TypeId=4, OwnerTypeId=2, CatagoryTypeId=4, EditorTypeId=10, TypeRank=2, TypeEnum=2, Visible=true, Readonly=true, Name="Display", Desc="Catagory Display" };

      this[8]=new ItemType() {TypeId=8, OwnerTypeId=7, CatagoryTypeId=3, EditorTypeId=8, TypeRank=1, TypeEnum=1, Visible=true, Readonly=true, Name="Int", Desc="The Int Editor " };
      this[9]=new ItemType() {TypeId=9, OwnerTypeId=7, CatagoryTypeId=3, EditorTypeId=9, TypeRank=2, TypeEnum=2, Visible=true, Readonly=true, Name="String", Desc="The String Editor" };
      this[10]=new ItemType() {TypeId=10, OwnerTypeId=7, CatagoryTypeId=3, EditorTypeId=10, TypeRank=0, TypeEnum=0, Visible=false, Readonly=true, Name="Hidden", Desc="The Hidden Editor" };
      this[11]=new ItemType() {TypeId=11, OwnerTypeId=7, CatagoryTypeId=3, EditorTypeId=11, TypeRank=3, TypeEnum=3, Visible=true, Readonly=true, Name="Lookup", Desc="The Lookup Editor" };
      this[12]=new ItemType() {TypeId=12, OwnerTypeId=7, CatagoryTypeId=3, EditorTypeId=12, TypeRank=4, TypeEnum=4, Visible=true, Readonly=true, Name="DateTime", Desc="The DateTime Editor" };
      this[13]=new ItemType() {TypeId=13, OwnerTypeId=7, CatagoryTypeId=3, EditorTypeId=13, TypeRank=5, TypeEnum=5, Visible=true, Readonly=true, Name="Bool", Desc="The Bool Editor" };
      this[14]=new ItemType() {TypeId=14, OwnerTypeId=7, CatagoryTypeId=3, EditorTypeId=14, TypeRank=6, TypeEnum=6, Visible=true, Readonly=true, Name="Color", Desc="The Color Editor" };
      this[15]=new ItemType() {TypeId=15, OwnerTypeId=7, CatagoryTypeId=3, EditorTypeId=15, TypeRank=7, TypeEnum=7, Visible=true, Readonly=true, Name="Filename", Desc="The Filename Editor" };
      this[16]=new ItemType() {TypeId=16, OwnerTypeId=7, CatagoryTypeId=3, EditorTypeId=16, TypeRank=8, TypeEnum=8, Visible=true, Readonly=true, Name="Password", Desc="The Password Editor" };
      this[42]=new ItemType() {TypeId=42, OwnerTypeId=7, CatagoryTypeId=3, EditorTypeId=42, TypeRank=9, TypeEnum=9, Visible=true, Readonly=true, Name="Decimal", Desc="The Decimal Editor" };


      this[18]=new ItemType() { TypeId=18, OwnerTypeId=17, CatagoryTypeId=4, EditorTypeId=9, TypeRank=1, TypeEnum=1, Visible=true, Readonly=false, Name="Project", Desc="Project Type" };
      this[19]=new ItemType() { TypeId=19, OwnerTypeId=18, CatagoryTypeId=4, EditorTypeId=9, TypeRank=1, TypeEnum=2, Visible=true, Readonly=false, Name="Template", Desc="Tempate Type" };
      this[20]=new ItemType() { TypeId=20, OwnerTypeId=19, CatagoryTypeId=4, EditorTypeId=9, TypeRank=1, TypeEnum=3, Visible=true, Readonly=false, Name="Chapters", Desc="Chapter Type" };
      this[21]=new ItemType() { TypeId=21, OwnerTypeId=20, CatagoryTypeId=4, EditorTypeId=9, TypeRank=1, TypeEnum=3, Visible=true, Readonly=false, Name="Chapter", Desc="Chapter Type" };
      this[22]=new ItemType() { TypeId=22, OwnerTypeId=21, CatagoryTypeId=4, EditorTypeId=9, TypeRank=2, TypeEnum=4, Visible=true, Readonly=false, Name="Section", Desc="Views Type" };
      this[23]=new ItemType() { TypeId=23, OwnerTypeId=22, CatagoryTypeId=4, EditorTypeId=9, TypeRank=3, TypeEnum=5, Visible=true, Readonly=false, Name="SubSection", Desc="Procedures Type" };


      this[29]=new ItemType() { TypeId=29, OwnerTypeId=28, CatagoryTypeId=3, EditorTypeId=11, TypeRank=1, TypeEnum=1, Visible=false, Readonly=true, Name="Table Columns", Desc="Table Column Type Lookup" };

      this[30]=new ItemType() { TypeId=30, OwnerTypeId=29, CatagoryTypeId=4, EditorTypeId=8, TypeRank=1, TypeEnum=1, Visible=false, Readonly=true, Name="int", Desc="int" };
      this[31]=new ItemType() { TypeId=31, OwnerTypeId=29, CatagoryTypeId=4, EditorTypeId=8, TypeRank=2, TypeEnum=2, Visible=false, Readonly=true, Name="bigint", Desc="bigint" };
      this[32]=new ItemType() { TypeId=32, OwnerTypeId=29, CatagoryTypeId=4, EditorTypeId=13, TypeRank=3, TypeEnum=3, Visible=false, Readonly=true, Name="bit", Desc="bit" };
      this[33]=new ItemType() { TypeId=33, OwnerTypeId=29, CatagoryTypeId=4, EditorTypeId=12, TypeRank=4, TypeEnum=4, Visible=false, Readonly=true, Name="datetime", Desc="datetime" };
      this[34]=new ItemType() { TypeId=34, OwnerTypeId=29, CatagoryTypeId=4, EditorTypeId=9, TypeRank=5, TypeEnum=5, Visible=false, Readonly=true, Name="zip", Desc="nvarchar(6)" };
      this[35]=new ItemType() { TypeId=35, OwnerTypeId=29, CatagoryTypeId=4, EditorTypeId=9, TypeRank=6, TypeEnum=6, Visible=false, Readonly=true, Name="phone", Desc="nvarchar(15)" };
      this[36]=new ItemType() { TypeId=36, OwnerTypeId=29, CatagoryTypeId=4, EditorTypeId=9, TypeRank=7, TypeEnum=7, Visible=false, Readonly=true, Name="name", Desc="nvarchar(100)" };
      this[37]=new ItemType() { TypeId=37, OwnerTypeId=29, CatagoryTypeId=4, EditorTypeId=9, TypeRank=8, TypeEnum=8, Visible=false, Readonly=true, Name="desc", Desc="nvarchar(max)" };
      this[38]=new ItemType() { TypeId=38, OwnerTypeId=29, CatagoryTypeId=4, EditorTypeId=42, TypeRank=9, TypeEnum=9, Visible=false, Readonly=true, Name="decimal 7x2", Desc="decimal(9,2)" };
      this[39]=new ItemType() { TypeId=39, OwnerTypeId=29, CatagoryTypeId=4, EditorTypeId=42, TypeRank=10, TypeEnum=10, Visible=false, Readonly=true, Name="decimal 17x2", Desc="decimal(19,2)" };
      this[40]=new ItemType() { TypeId=40, OwnerTypeId=29, CatagoryTypeId=4, EditorTypeId=42, TypeRank=11, TypeEnum=11, Visible=false, Readonly=true, Name="decimal 17x4", Desc="decimal(19,4)" };
      this[41]=new ItemType() { TypeId=41, OwnerTypeId=29, CatagoryTypeId=4, EditorTypeId=42, TypeRank=12, TypeEnum=12, Visible=false, Readonly=true, Name="decimal 17x8", Desc="decimal(19,8)" };

      this[43]=new ItemType() { TypeId=43, OwnerTypeId=28, CatagoryTypeId=3, EditorTypeId=11, TypeRank=1, TypeEnum=1, Visible=false, Readonly=true, Name="Prompt Types", Desc="Prompt Type Lookups" };

      this[44]=new ItemType() { TypeId=44, OwnerTypeId=43, CatagoryTypeId=4, EditorTypeId=9, TypeRank=1, TypeEnum=1, Visible=false, Readonly=true, Name="Tech Expository Hook", 
        Desc="brainstorm 10 story hooks for a Technical Expository of [NODE] " };      
      this[45]=new ItemType() { TypeId=45, OwnerTypeId=43, CatagoryTypeId=4, EditorTypeId=9, TypeRank=2, TypeEnum=2, Visible=false, Readonly=true, Name="Tech Review Details", 
        Desc= $"in context of '[PARENT]', based on the premise of [NODE], can we brainstorm 10 different threads of detail and order them by importance?" };
      this[46]=new ItemType() { TypeId=46, OwnerTypeId=43, CatagoryTypeId=4, EditorTypeId=9, TypeRank=3, TypeEnum=3, Visible=false, Readonly=true, Name="Expository Synopsis", 
        Desc=$"Given the following premise and ending, devise a detailed synopsis structured around \"[PARENT]\". Premise: [GRANDPARENT]. Ending: [NODE]." };
      this[47]=new ItemType() { TypeId=47, OwnerTypeId=43, CatagoryTypeId=4, EditorTypeId=9, TypeRank=4, TypeEnum=4, Visible=false, Readonly=true, Name="Child Template", Desc=String.Empty };
      this[48]=new ItemType() { TypeId=48, OwnerTypeId=43, CatagoryTypeId=4, EditorTypeId=9, TypeRank=5, TypeEnum=5, Visible=false, Readonly=true, Name="Creative Narrative Hook",
        Desc="brainstorm 10 story hooks for a Creative Narrative for [NODE] "
      };
      this[49]=new ItemType() {TypeId=49, OwnerTypeId=43, CatagoryTypeId=4, EditorTypeId=9, TypeRank=6, TypeEnum=6, Visible=false, Readonly=true, Name="Creative Narrative Endings",
        Desc=$"in context of '[PARENT]', based on the premise of [NODE], can we brainstorm 10 different endings?"
      };
      this[50]=new ItemType() {TypeId=50, OwnerTypeId=43, CatagoryTypeId=4, EditorTypeId=9, TypeRank=7, TypeEnum=7, Visible=false, Readonly=true, Name="Creative Synopsis",
        Desc=$"Given the following premise and ending, devise a detailed story synopsis structured around \"[PARENT]\". Premise: [GRANDPARENT]. Ending: [NODE]."
      };




    }
  
    public IEnumerable<ItemType> GetChildrenItems(int id) {
      return this.Select(x => x.Value).Where(x => ((x.OwnerTypeId==id)||(x.OwnerTypeId==0))).OrderBy(x => x.TypeRank);
    }

    public IEnumerable<ItemType> GetProjectTypes() {       
      return this.Select(x => x.Value).Where(x => (x.TypeId > 17 && x.TypeId< 29)).OrderBy(x => x.TypeId);  
    }
    public ItemType LoadSubtypes(ItemType item) {
      var items = GetOwnersTypes(item.TypeId);
      if(item.Nodes.Count>0) item.Nodes.Clear();
      foreach(ItemType it in items) {
        item.Nodes.Add(it);
      }
      return item;
    }

    public IEnumerable<ItemType> GetOwnersTypes(int ownerTypeId) {
      try {
        IEnumerable<ItemType> result=GetChildrenItems(ownerTypeId);        
        return result;
      } catch(Exception ex) {
        return null;
      }
    }
  }

}
