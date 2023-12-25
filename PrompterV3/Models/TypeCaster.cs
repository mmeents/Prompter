using MessagePack;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrompterV3.Models {

  public enum TnType {
    Types = 1,

    Project = 100,
    Essay=120,
    EssayTopic = 125,
    Template = 200,   
    
    BrainstormThesisStatement = 225,
    EssayThesis = 230,

    Chapters = 300,
    Chapter = 400,
    BrainstormTitle = 325,
    BrainstormThesisTopic = 330,
    EssayTitle = 415,
    EssayThesisTopic = 420,
    BrainstormThesisClaims = 435,
    EssayThesisClaims = 440,
    BrainstormClaimsEvidence = 445,
    ThesisCliamsEvidence = 450,
    BuildEssay = 469,
    Section = 500,
    SubSection = 600

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

  public class ItemType {
    public ItemType()  { }

    public ItemType(int typeId, int ownerTypeId, int catagoryTypeId, int editorTypeId, 
      int typeRank, string name, bool visible, string desc, bool isReadonly) : base() {       
      TypeId = typeId;
      OwnerTypeId = ownerTypeId;
      CatagoryTypeId = catagoryTypeId;
      EditorTypeId = editorTypeId;
      TypeRank = typeRank;
      Name = name;
      Visible = visible;
      Desc = desc;
      IsReadonly = isReadonly;
    }

    private int _id;

    public int TypeId {
      get { return _id; }
      set { _id=value;  }
    }

    public int OwnerTypeId { get; set; } = 0;
    public int CatagoryTypeId { get; set; } = 0;
    public int EditorTypeId { get; set; } = 0;
    public int TypeRank { get; set; } = 0;
    public string Name { get; set; } = "";
    public bool Visible { get; set; } = false;
    public string Desc { get; set; } = "";
    public bool IsReadonly { get; set; } = false;
    public string PromptTag = "";
    public string Template { get; set; } = "";

  }

  public class Types : ConcurrentDictionary<int, ItemType> {

   
    public Types() : base() {      
    }
    public void Load() {
      base.Clear();
      this[0]=new ItemType() { TypeId=0, OwnerTypeId=0, CatagoryTypeId=0, EditorTypeId=0, TypeRank=0, Name="none", Visible=true, IsReadonly=true, Desc="" };

      this[1]=new ItemType() { TypeId=1, OwnerTypeId=1, CatagoryTypeId=0, EditorTypeId=20, TypeRank=1, Visible=false, IsReadonly=true, Name="Internal", Desc="Root " };
      this[2]=new ItemType() { TypeId=2, OwnerTypeId=1, CatagoryTypeId=10, EditorTypeId=20, TypeRank=1, Visible=false, IsReadonly=true, Name="CatagoryTypes", Desc="Catagory Types" };
      this[3]=new ItemType() { TypeId=3, OwnerTypeId=1, CatagoryTypeId=10, EditorTypeId=20, TypeRank=1, Visible=false, IsReadonly=true, Name="EditorTypes", Desc="Editor Types" };
      this[4]=new ItemType() { TypeId=4, OwnerTypeId=1, CatagoryTypeId=10, EditorTypeId=20, TypeRank=1, Visible=false, IsReadonly=true, Name="ModelTypes", Desc="Prompter Types" };

      this[10]=new ItemType() { TypeId=10, OwnerTypeId=2, CatagoryTypeId=10, EditorTypeId=20, TypeRank=1, Visible=false, IsReadonly=true, Name="Internal", Desc="Catagory Internal" };
      this[11]=new ItemType() { TypeId=11, OwnerTypeId=2, CatagoryTypeId=11, EditorTypeId=20, TypeRank=2, Visible=true, IsReadonly=true, Name="Display", Desc="Catagory Display" };

      this[20]=new ItemType() { TypeId=20, OwnerTypeId=3, CatagoryTypeId=10, EditorTypeId=20, TypeRank=0, Visible=false, IsReadonly=false, Name="Hidden", Desc="The Hidden Editor" };
      this[21]=new ItemType() { TypeId=21, OwnerTypeId=3, CatagoryTypeId=11, EditorTypeId=21, TypeRank=1, Visible=true, IsReadonly=false, Name="Int", Desc="The Int Editor " };
      this[22]=new ItemType() { TypeId=22, OwnerTypeId=3, CatagoryTypeId=11, EditorTypeId=22, TypeRank=2, Visible=true, IsReadonly=false, Name="String", Desc="The String Editor" };      
      this[23]=new ItemType() { TypeId=23, OwnerTypeId=3, CatagoryTypeId=11, EditorTypeId=23, TypeRank=3, Visible=true, IsReadonly=false, Name="Lookup", Desc="The Lookup Editor" };
      this[24]=new ItemType() { TypeId=24, OwnerTypeId=3, CatagoryTypeId=11, EditorTypeId=24, TypeRank=4, Visible=true, IsReadonly=false, Name="DateTime", Desc="The DateTime Editor" };
      this[25]=new ItemType() { TypeId=25, OwnerTypeId=3, CatagoryTypeId=11, EditorTypeId=25, TypeRank=5, Visible=true, IsReadonly=false, Name="Bool", Desc="The Bool Editor" };
      this[26]=new ItemType() { TypeId=26, OwnerTypeId=3, CatagoryTypeId=11, EditorTypeId=26, TypeRank=9, Visible=true, IsReadonly=false, Name="Decimal", Desc="The Decimal Editor" };
      this[27]=new ItemType() { TypeId=27, OwnerTypeId=3, CatagoryTypeId=11, EditorTypeId=27, TypeRank=6, Visible=true, IsReadonly=false, Name="Color", Desc="The Color Editor" };
      this[28]=new ItemType() { TypeId=28, OwnerTypeId=3, CatagoryTypeId=11, EditorTypeId=28, TypeRank=7, Visible=true, IsReadonly=false, Name="Filename", Desc="The Filename Editor" };
      this[29]=new ItemType() { TypeId=29, OwnerTypeId=3, CatagoryTypeId=11, EditorTypeId=29, TypeRank=8, Visible=true, IsReadonly=false, Name="Password", Desc="The Password Editor" };

      this[100]=new ItemType() { TypeId=100, OwnerTypeId=4, CatagoryTypeId=11, EditorTypeId=22, TypeRank=1,  Visible=true, IsReadonly=false,
        Name="Project", Desc="Project Type" };      

      this[200]=new ItemType() { TypeId=200, OwnerTypeId=4, CatagoryTypeId=11, EditorTypeId=22, TypeRank=1,  Visible=true, IsReadonly=false,
        Name="Template", Desc="Tempate Type" };
      

      this[300]=new ItemType() { TypeId=300, OwnerTypeId=4, CatagoryTypeId=11, EditorTypeId=22, TypeRank=1,  Visible=true, IsReadonly=false, 
        Name="Chapters", Desc="Chapter Type" };

      this[400]=new ItemType() { TypeId=400, OwnerTypeId=300, CatagoryTypeId=11, EditorTypeId=22, TypeRank=1,  Visible=true, IsReadonly=false, 
        Name="Chapter", Desc="Chapter Type" };

      this[115]=new ItemType() {
        TypeId=115, OwnerTypeId=4, CatagoryTypeId=11, EditorTypeId=22, TypeRank=1, Visible=true, IsReadonly=false,
        Name="Essay Thesis", Desc="Essay Project Type", PromptTag="[Essay]", Template="[Name]"
      };

      this[105]=new ItemType() { TypeId=105, OwnerTypeId=4, CatagoryTypeId=11, EditorTypeId=22, TypeRank=1, Visible=true, IsReadonly=false, 
        Name="Essay", Desc="Essay Project Type", PromptTag="[Essay]", Template="[Name]" };
        
        this[210]=new ItemType() { TypeId=210, OwnerTypeId=105, CatagoryTypeId=11, EditorTypeId=22, TypeRank=1, Visible=true, IsReadonly=false, 
          Name="Thesis", PromptTag="[EssayThesis]", Template="[Name]", Desc="The thesis statement is the main argument or point of the essay."
        };
        //  this[402]=new ItemType() { TypeId=402, OwnerTypeId=210, CatagoryTypeId=11, EditorTypeId=22, TypeRank=2, Visible=true, IsReadonly=false, 
        //    Name="Topic", PromptTag="[EssayThesisTopic]", Template="[Name]", Desc="Thesis Topic: The thesis statement should identify the topic of the essay."
        //  };
            this[510]=new ItemType() { TypeId=510, OwnerTypeId=402, CatagoryTypeId=11, EditorTypeId=22, TypeRank=1, Visible=true, IsReadonly=false, 
              Name="Brainstorm Topics", PromptTag="", Template="Brainstorm 10 Essay Thesis Topics for \"[EssayThesisTopic]\"", 
              Desc="Thesis Topic: The thesis statement should identify the topic of the essay."
            };
          this[403]=new ItemType() { TypeId=403, OwnerTypeId=4, CatagoryTypeId=11, EditorTypeId=22, TypeRank=3, Visible=true, IsReadonly=false, 
            Name="Claim", Template="10 most interesting thesis claims for topic: [EssayThesisTopic]; Thesis: [EssayThesis]",
            Desc="Thesis Cliams: The thesis statement should make a claim about the topic. This claim can be an argument, an interpretation, or an analysis." };

          this[404]=new ItemType() { TypeId=404, OwnerTypeId=4, CatagoryTypeId=11, EditorTypeId=22, TypeRank=4, Visible=true, IsReadonly=false, 
            Name="Evidence", Template="10 best examples of thesis evidence for \"[Claim1]\" given topic: [EssayThesisTopic]; Thesis: [EssayThesis];",
            Desc="Thesis Evidence: The thesis statement should be supported by evidence from the essay. This evidence can come from primary or secondary sources."};

        this[209]=new ItemType() { TypeId=209, OwnerTypeId=105, CatagoryTypeId=11, EditorTypeId=22, TypeRank=2, Visible=true, IsReadonly=false, 
          Name="Essay Title", PromptTag="[EssayTitle]", Template="[Name]", Desc="The thesis title will be name of essay." };

          this[401]=new ItemType() { TypeId=401, OwnerTypeId=209, CatagoryTypeId=11, EditorTypeId=22, TypeRank=1, Visible=true, IsReadonly=false, 
            Name="Brainstorm Essay Title", Desc="Brainstorm Essay title", Template="Brainstorm 10 Essay Titles for [EssayThesis]" };

        this[405]=new ItemType() { TypeId=405, OwnerTypeId=105, CatagoryTypeId=11, EditorTypeId=22, TypeRank=5, Visible=true, IsReadonly=false, 
          Name="Build Essay", Desc="Essay Introduction",
          Template="Write 500 word essay with introduction, body and conclusion titled \"[EssayTitle]\" Thesis: [EssayThesis]; "+
            "topic: [EssayThesisTopic]; with thesis claims: \"[Claim1]\", \"[Claim2]\"; and evidence: \"[Evidence1]\", \"[Evidence2]\"; "
        };

      
      this[120]=new ItemType() {
        TypeId=120, OwnerTypeId=4, CatagoryTypeId=11, EditorTypeId=22, TypeRank=1, Visible=true, IsReadonly=false,
        Name="Brainstorm Essay", PromptTag="", Template="Brainstorm 10 Essay Thesis Topics for \"[Parent]\"",
        Desc="To build Essay, needs Thesis Topics, Thesis statement with claims and evidence."
      };

      this[125]=new ItemType() {
        TypeId=125, OwnerTypeId=4, CatagoryTypeId=11, EditorTypeId=22, TypeRank=2, Visible=true, IsReadonly=false,
        Name="Essay Thesis Topic", PromptTag="[EssayThesisTopic#]", Template="[Name]", Desc="Thesis Topic: The thesis statement should identify the topic of the essay."
      };

      this[225]=new ItemType() {
        TypeId=225, OwnerTypeId=125, CatagoryTypeId=11, EditorTypeId=22, TypeRank=1, Visible=true, IsReadonly=false,
        Name="Brainstorm Thesis", PromptTag="", Template="Brainstorm 10 essay thesis statements for \"[Parent]\"",
        Desc="Thesis Topic: The thesis statement should identify the topic of the essay."
      };

      this[230]=new ItemType() {
        TypeId=230, OwnerTypeId=4, CatagoryTypeId=11, EditorTypeId=22, TypeRank=1, Visible=true, IsReadonly=false,
        Name="Thesis", PromptTag="[EssayThesis#]", Template="[Name]", Desc="The thesis statement is the main argument or point of the essay."
      };

      this[325]=new ItemType() {
        TypeId=325, OwnerTypeId=230, CatagoryTypeId=11, EditorTypeId=22, TypeRank=1, Visible=true, IsReadonly=false,
        Name="Brainstorm Title", PromptTag="", Template="Brainstorm 10 essay titles for an essay with thesis: \"[Parent]\"",
        Desc="Essay Titles: Search for a essay title"
      };

      this[330]=new ItemType() {
        TypeId=330, OwnerTypeId=230, CatagoryTypeId=11, EditorTypeId=22, TypeRank=1, Visible=true, IsReadonly=false,
        Name="Brainstorm Topics", PromptTag="", Template="Brainstorm 10 Essay Thesis Topics for \"[Parent]\"",
        Desc="Thesis Topic: The thesis statement should identify the topic of the essay."
      };

      this[415]=new ItemType() {
        TypeId=415, OwnerTypeId=4, CatagoryTypeId=11, EditorTypeId=22, TypeRank=2, Visible=true, IsReadonly=false,
        Name="Essay Title", PromptTag="[EssayTitle#]", Template="[Name]",
        Desc="Essay Title Option"
      };

      this[420]=new ItemType() {
        TypeId=420, OwnerTypeId=4, CatagoryTypeId=11, EditorTypeId=22, TypeRank=2, Visible=true, IsReadonly=false,
        Name="Essay Thesis Topic", PromptTag="[EssayThesisTopic#]", Template="[Name]", 
        Desc="Thesis Topic: The thesis statement should identify the topic of the essay."
      };

      this[435]=new ItemType() {
        TypeId=435, OwnerTypeId=420, CatagoryTypeId=11, EditorTypeId=22, TypeRank=3, Visible=true, IsReadonly=false,
        Name="Brainstorm Claims", Template="10 most interesting thesis claims for topic: [Parent]; Thesis: [Parent3]",
        Desc="Thesis Cliams: The thesis statement should make a claim about the topic. This claim can be an argument, an interpretation, or an analysis."
      };

      this[440]=new ItemType() {
        TypeId=440, OwnerTypeId=4, CatagoryTypeId=11, EditorTypeId=22, TypeRank=3, Visible=true, IsReadonly=false,
        Name="Claims", Template="", PromptTag="[Claim#]",
        Desc="Thesis Cliams: The thesis statement should make a claim about the topic. This claim can be an argument, an interpretation, or an analysis."
      };


      this[445]=new ItemType() {
        TypeId=445, OwnerTypeId=440, CatagoryTypeId=11, EditorTypeId=22, TypeRank=4, Visible=true, IsReadonly=false,
        Name="Brainstrom Evidence", Template="10 best examples of thesis evidence for \"[Parent]\" given topic: [Parent2];",
        Desc="Thesis Evidence: The thesis statement should be supported by evidence from the essay. This evidence can come from primary or secondary sources."
      };

      this[450]=new ItemType() {
        TypeId=450, OwnerTypeId=4, CatagoryTypeId=11, EditorTypeId=22, TypeRank=4, Visible=true, IsReadonly=false,
        Name="Thesis Evidence", Template="", PromptTag="[Evidence#]",
        Desc="Thesis Evidence: The thesis statement should be supported by evidence from the essay. This evidence can come from primary or secondary sources."
      };

      this[469]=new ItemType() {
        TypeId=469, OwnerTypeId=105, CatagoryTypeId=11, EditorTypeId=22, TypeRank=5, Visible=true, IsReadonly=false,
        Name="Build Essay", Desc="Request to write the Essay, confirm size, title, thesis, claims and evidence for it.",
        Template="Write 500 word essay with introduction, body and conclusion titled \"[EssayTitle]\" Thesis: [EssayThesis]; "+
            "topic: [EssayThesisTopic]; with thesis claims: \"[Claim1]\", \"[Claim2]\"; and evidence: \"[Evidence1]\", \"[Evidence2]\"; "
      };

      this[500]=new ItemType() { TypeId=500, OwnerTypeId=400, CatagoryTypeId=11, EditorTypeId=22, TypeRank=2,  Visible=true, IsReadonly=false, Name="Section", Desc="Views Type" };
      this[600]=new ItemType() { TypeId=600, OwnerTypeId=500, CatagoryTypeId=11, EditorTypeId=22, TypeRank=3,  Visible=true, IsReadonly=false, Name="SubSection", Desc="Procedures Type" };


    }
    public IEnumerable<ItemType> GetChildrenItemsNoDef(int id) {
      return this.Select(x => x.Value).Where(x => x.OwnerTypeId==id).OrderBy(x => x.TypeRank);
    }
    public IEnumerable<ItemType> GetChildrenItems(int id) {
      return this.Select(x => x.Value).Where(x => ((x.OwnerTypeId==id)||(x.OwnerTypeId==0))).OrderBy(x => x.TypeRank);
    }

    public IEnumerable<ItemType> GetProjectTypes() {
      return this.Select(x => x.Value).Where(x => (x.TypeId>99)&&(x.TypeId<1000)).OrderBy(x => x.TypeId);
    }    

    public IEnumerable<ItemType> GetOwnersTypes(int ownerTypeId) {
      try {
        IEnumerable<ItemType> result = GetChildrenItems(ownerTypeId);
        return result;
      } catch(Exception ex) {
        return null;
     }
    }

    public virtual Boolean Contains(int id) {
      try {
        return !(base[id] is null);
      } catch {
        return false;
      }
    }
    public virtual new ItemType this[int id] {
      get { return Contains(id) ? base[id] : base.Values.First<ItemType>(x => x.TypeId>id); }
      set { if(value!=null) { base[id]=value; } else { Remove(id); } }
    }

    public virtual void Remove(int id) { if(Contains(id)) { _=base.TryRemove(id, out _); } }
  }

 
}
