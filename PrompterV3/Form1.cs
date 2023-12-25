using MessagePack;
using PrompterV3.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MessagePack.Formatters;
using MessagePack.ImmutableCollection;
using MessagePack.Resolvers;
using System.IO;
using System.Reflection.Emit;
using System.Net;
using PropertyGridEx;
using FastColoredTextBoxNS;

namespace PrompterV3 {
  public partial class Form1:Form {
    #region initialization
    private const string _appVerison = "3.0.0";
    private const string _defaultUrl = "https://mmeents.github.io/files/PrompterV200.ptv";
    private string _defaultDir = "C:\\ProgramData\\MMCommons";
    private string _defaultFile = "C:\\ProgramData\\MMCommons\\PrompterV301.pv3";    
    private string _defaultSettings = "C:\\ProgramData\\MMCommons\\PrompterSettings.pv3";
    private string _fileName;
    private string _folder;
    private FilePackage _settingsPack;
    private FilePackage _filePackage;
    private CObject _settings;
    private CryptoKey _key;
    private Types _types;
    private ItemCaster _itemCaster;
    private Item _inEditItem = null;
    private bool _inReorder = false;
    private bool _doPrompt = true;
    #endregion
    #region Form1 methods
    public Form1() {
      InitializeComponent();
      _types = new Types();
      _types.Load();
      _defaultDir=Environment.GetFolderPath(Environment.SpecialFolder.Desktop)+"\\PrompterFiles";
      if(!Directory.Exists(_defaultDir)) {
        Directory.CreateDirectory(_defaultDir);
      }
      _defaultFile=_defaultDir+"\\PrompterV301.pv3";
      _defaultSettings=_defaultDir+"\\PrompterSettings.pv3";      
      _settingsPack=new FilePackage(_defaultSettings, this);
      lbFocus.Text = "if empty right click outline for menu to add. Select item to focus.";
    }

    private void Form1_Shown(object sender, EventArgs e) {      
      _settings= _settingsPack.Settings;
      if(!_settings.Contains("MRUL")) {
        _settings["MRUL"] = new CObjectItem() { Key="MRUL", Value= _defaultFile };
      }
      SetLocationSettings();
      string MRUL = _settings["MRUL"].Value;
      edFileName.Items.Clear();
      edFileName.Items.AddRange(MRUL.Parse(Environment.NewLine));
      edFileName.Text = MRUL.ParseFirst(Environment.NewLine);
      Form1_Resize(null, null);
    }   

    private void Form1_Resize(object sender, EventArgs e) {
      tvBuilder.Height=splitContainer2.Panel1.Height-panel1.Height-2;
      SaveLocationSettings();
    }
    private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
      SaveLocationSettings();
    }
    private void SetLocationSettings() {
      if(_settings.Contains("FormTop")) {
        this.Top = _settings["FormTop"].Value.AsInt();
      }
      if(_settings.Contains("FormLeft")) {
        this.Left = _settings["FormLeft"].Value.AsInt();
      }
      if(_settings.Contains("FormHeight")) {
        this.Height = _settings["FormHeight"].Value.AsInt();
      }
      if(_settings.Contains("FormWidth")) {
        this.Width = _settings["FormWidth"].Value.AsInt();
      }
      if(_settings.Contains("Split1")) {
        this.splitContainer1.SplitterDistance = _settings["Split1"].Value.AsInt();
      }
      if(_settings.Contains("Split2")) {
        this.splitContainer2.SplitterDistance = _settings["Split2"].Value.AsInt();
      }
    }
    private void SaveLocationSettings() {
      if (_settings == null) return;
      if(!_settings.Contains("FormTop")) {
        _settings["FormTop"]=new CObjectItem() { Key="FormTop", Value=this.Top.AsString() };
      } else {
        _settings["FormTop"].Value=this.Top.AsString();
      }

      if(!_settings.Contains("FormLeft")) {
        _settings["FormLeft"]=new CObjectItem() { Key="FormLeft", Value=this.Left.AsString() };
      } else {
        _settings["FormLeft"].Value=this.Left.AsString();
      }

      if(!_settings.Contains("FormHeight")) {
        _settings["FormHeight"]=new CObjectItem() { Key="FormHeight", Value=this.Height.AsString() };
      } else {
        _settings["FormHeight"].Value = this.Height.AsString();
      }

      if(!_settings.Contains("FormWidth")) {
        _settings["FormWidth"]=new CObjectItem() { Key="FormWidth", Value=this.Width.AsString() };
      } else {
        _settings["FormWidth"].Value=this.Width.AsString();
      }

      if(!_settings.Contains("Split1")) {
        _settings["Split1"]=new CObjectItem() { Key="Split1", Value=this.splitContainer1.SplitterDistance.AsString() };
      } else {
        _settings["Split1"].Value=this.splitContainer1.SplitterDistance.AsString();
      }

      if(!_settings.Contains("Split2")) {
        _settings["Split2"]=new CObjectItem() { Key="Split2", Value=this.splitContainer2.SplitterDistance.AsString() };
      } else {
        _settings["Split2"].Value=this.splitContainer2.SplitterDistance.AsString();
      }
      _settingsPack.Settings=_settings;
      _settingsPack.Save();
    }

    public void SetInProgress(int ProgressPercent) {
      if(ProgressPercent==0) {
        if(pbMain.Visible) pbMain.Visible=false;
        if(pb2.Visible) pb2.Visible=false;
        if(!tvBuilder.Enabled) tvBuilder.Enabled=true;
        if(!props.Enabled) props.Enabled=true;
      } else {
        if(!pbMain.Visible) pbMain.Visible=true;
        if(!pb2.Visible) pb2.Visible=true;
        if(!tvBuilder.Enabled) tvBuilder.Enabled=false;
        if(!props.Enabled) props.Enabled=false;
      }
      System.Windows.Forms.Application.DoEvents();
      pbMain.Value=ProgressPercent;
      System.Windows.Forms.Application.DoEvents();
      pb2.Value=ProgressPercent;
      System.Windows.Forms.Application.DoEvents();
    }
    
    delegate void SetLogMsgCallback(string msg);
    public void LogMsg(string msg) {
      if(this.edError.InvokeRequired) {
        SetLogMsgCallback d = new SetLogMsgCallback(LogMsg);
        this.BeginInvoke(d, new object[] {msg});
      }
      else {
        if(!edError.Visible) edError.Visible=true;
        this.edError.Text = msg+Environment.NewLine+edError.Text;
        this.edError2.Text = msg+Environment.NewLine+edError.Text;
      }
    }

    #endregion
    #region tabControl1 Methods and File Browse 
    private void btnBrowse_Click(object sender, EventArgs e) {
      if(edFileName.Text=="") {
        odMain.InitialDirectory=_defaultDir;
      } else {
        string s = edFileName.Text.ParseLast("\\");
        odMain.InitialDirectory=edFileName.Text.Substring(0, edFileName.Text.Length - s.Length);
      }
      DialogResult res = odMain.ShowDialog();
      if(res==DialogResult.OK) {
        _settings=_settingsPack.Settings;
        if(!_settings.Contains("MRUL")) {
          _settings["MRUL"]=new CObjectItem() { Key="MRUL", Value=_defaultSettings };
        }
        _settings["MRUL"].Value=odMain.FileName+Environment.NewLine+_settings["MRUL"].Value;
        _settingsPack.Settings = _settings;
        _settingsPack.Save();
        edFileName.Text=odMain.FileName;        
      }
    }

    private void btnBuild_Click(object sender, EventArgs e) {
      tabControl1.SelectedIndex=1;
    }
    private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e) {
      if(e.TabPageIndex==0) {
        edError2.Text="";
        props.Item.Clear();
        props.Refresh();
        lbFocus.Text="Select Node to focus";
      } else if(e.TabPageIndex==1) {
        try {
          _fileName=edFileName.Text;
          int fnl = _fileName.ParseLast("\\").Length+1;
          _folder=_fileName.Substring(0, _fileName.Length-fnl);

          if(!File.Exists(edFileName.Text)) {
            if(!Directory.Exists(_defaultDir)) {
              Directory.CreateDirectory(_defaultDir);
            }
            //if(edFileName.Text==_defaultFile) {
            //  WebClient client = new WebClient();
            //  client.DownloadFile(_defaultUrl, _defaultFile);
           // }
          }          
          SetInProgress(3000);          
          _filePackage=new FilePackage( _fileName, this);
          SetInProgress(6000);
          _itemCaster=new ItemCaster(this, tvBuilder, _filePackage, _types);
          e.Cancel=(!(Directory.Exists(_folder)));
        } catch(Exception ex) {
          LogMsg(ex.Message);
          e.Cancel=true;
          SetInProgress(0);
        }
      }
    }

    private void tabControl1_SelectedIndexChanged(object sender, EventArgs e) {
      this.Text=(tabControl1.SelectedIndex==0) ? $"PrompterV{_appVerison} Pick file and type password." : $"PrompterV{_appVerison} file:{_fileName}";
      if(tabControl1.SelectedIndex==1) {
        SetInProgress(6000);        
        _itemCaster.LoadTreeviewItemsAsync(tvBuilder, pbMain);
        SetLocationSettings();
        SetInProgress(0);
      }
      if(tabControl1.SelectedIndex==0) {
        if(pb2.Visible) pb2.Visible=false;
      }
    }
    #endregion
    #region tvBuilder methods
    private void tvBuilder_BeforeExpand(object sender, TreeViewCancelEventArgs e) {
      Item tn = (Item)e.Node;
      if(tn!=null) {
        var items = _itemCaster.GetOwnersItemsAsync(tn);
        e.Cancel=false;
      }
    }

    private void tvBuilder_AfterSelect(object sender, TreeViewEventArgs e) {
      if(!_inReorder) {
        try {
          if(e?.Node==null) return;
          _inEditItem=(Item)e.Node;
          if(_inEditItem==null) return;
          SetInProgress(9500);
          ResetPropEditors(_inEditItem);
        } finally {
          SetInProgress(0);
        }
      }
    }

    private void tvBuilder_AfterLabelEdit(object sender, NodeLabelEditEventArgs e) {
      try {
        if(_inEditItem!=(Item)e.Node) {
          _inEditItem=(Item)e.Node;
        }
        if(_inEditItem==null||e.Label==null) {
          e.CancelEdit=true;
          return;
        }
        if(_inEditItem.Text!=e.Label) { _inEditItem.Text=e.Label; }
        if(_inEditItem.Dirty) _itemCaster.SaveItem(_inEditItem);
        SetInProgress(9500);
        ResetPropEditors(_inEditItem);
      } finally {
        SetInProgress(0);
      }
    }
    private void tvBuilder_ItemDrag(object sender, ItemDragEventArgs e) {
      if(e.Button==MouseButtons.Left) {
        DoDragDrop(e.Item, DragDropEffects.Move);
      }
    }

    private void tvBuilder_DragEnter(object sender, DragEventArgs e) {
      e.Effect=DragDropEffects.Move;
    }

    private void tvBuilder_DragOver(object sender, DragEventArgs e) {
      if(e.Data!=null) {        
        Item sni = (Item)e.Data.GetData(typeof(Item));
        if(sni!=null) {
          Point targetPt = tvBuilder.PointToClient(new Point(e.X, e.Y));
          Item tn = (Item)tvBuilder.GetNodeAt(targetPt);
          if(tn!=sni) {
            if(tn!=null) {
              e.Effect=DragDropEffects.Move;
              if(!tn.IsExpanded) tn.Expand();
            } else {
              if((sni.TypeId>=(int)TnType.Project)&&(sni.TypeId<=199)) {
                e.Effect=DragDropEffects.Move;
              } else {
                e.Effect=DragDropEffects.None;
              }
            }
          }
        }        
      }
    }

    private void tvBuilder_DragDrop(object sender, DragEventArgs e) {
      try {
        Point targetPt = tvBuilder.PointToClient(new Point(e.X, e.Y));
        Item tn = (Item)tvBuilder.GetNodeAt(targetPt);
        SetInProgress(9500);
        if(tn!=null&&e.Data!=null) {         
          Item dragNode = (Item)e.Data.GetData(typeof(Item));
          if(dragNode!=null) { 
            var fnn = _itemCaster.MoveItemSave(tn, dragNode);            
          }          
        }
      } finally {
        SetInProgress(0);
      }
    }

    #endregion    
    #region tvBuilder Menus Items
    private void msBuilder_Opening(object sender, CancelEventArgs e) {
      if(_inEditItem==null) { 
        if (!projectToolStripMenuItem.Available) projectToolStripMenuItem.Available = true;
        if (essayToolStripMenuItem.Visible) essayToolStripMenuItem.Available=false;
        if (templateToolStripMenuItem.Available) templateToolStripMenuItem.Available=false;
        saveToolStripMenuItem.Enabled=false;
        deleteToolStripMenuItem.Enabled=false;
        moveUpToolStripMenuItem.Enabled=false;
        moveDownToolStripMenuItem.Enabled=false;
        templateToolStripMenuItem.Enabled = false;
        return;
      }

      if(projectToolStripMenuItem.Available) projectToolStripMenuItem.Available=false;
      if(!essayToolStripMenuItem.Available) essayToolStripMenuItem.Available=true;
      if(!templateToolStripMenuItem.Available) templateToolStripMenuItem.Available=true;

      templateToolStripMenuItem.Enabled = true;
      if(_inEditItem.Dirty) {
        saveToolStripMenuItem.Enabled=true;
      } else {
        saveToolStripMenuItem.Enabled=false;
      }
      //if(_inEditItem.Nodes.Count==0) {
        deleteToolStripMenuItem.Enabled=true;
      //} else {
      //  deleteToolStripMenuItem.Enabled=false;
     // }

      if(_inEditItem.CanSwitchUp()) {
        moveUpToolStripMenuItem.Enabled=true;
      } else {
        moveUpToolStripMenuItem.Enabled=false;
      }
      if(_inEditItem.CanSwitchDown()) {
        moveDownToolStripMenuItem.Enabled=true;
      } else {
        moveDownToolStripMenuItem.Enabled=false;
      }
    }
    private void addTemplateToolStripMenuItem_Click(object sender, EventArgs e) {
    }

    private void projectToolStripMenuItem_Click(object sender, EventArgs e) {
      _=_itemCaster.SaveNewChildItemsFromText(_inEditItem, _types[(int)TnType.Project], "Project");      
    }

    private void essayToolStripMenuItem_Click(object sender, EventArgs e) {      
      _inReorder = true;
      try { 
      _=_itemCaster.SaveNewItemFromType(_inEditItem, _types[(int)TnType.Essay]);                      
      } finally { 
        _inReorder = false;
      }
    }

    private void templateToolStripMenuItem_Click(object sender, EventArgs e) {
      _inReorder=true;
      try {
        _=_itemCaster.SaveNewItemFromType(_inEditItem, _types[(int)TnType.Template]);
      } finally {
        _inReorder=false;
      }
    }
    private void moveUpToolStripMenuItem_Click(object sender, EventArgs e) {
      if(_inEditItem==null) return;
      if(!_inEditItem.CanSwitchUp()) return;
      var otherItem = _inEditItem.GetSwitchUpItem();
      _inEditItem.SwitchRankUp();
      if(_inEditItem.Dirty) { _itemCaster.SaveItem(_inEditItem); }
      if(otherItem!=null&&otherItem.Dirty) _itemCaster.SaveItem(otherItem);

      var opItem = _inEditItem;
      _inReorder=true;
      try {
        var parentItem = (Item)_inEditItem.Parent;
        var otherItemIndex = parentItem.Nodes.IndexOf(otherItem);
        if(otherItemIndex>=0) {
          parentItem.Nodes.Remove(opItem);
          parentItem.Nodes.Insert(otherItemIndex, opItem);
        }
      } finally {
        _inReorder=false;
      }
      tvBuilder.SelectedNode=opItem;
    }

    private void moveDownToolStripMenuItem_Click(object sender, EventArgs e) {
      if(_inEditItem==null) return;
      if(!_inEditItem.CanSwitchDown()) return;
      var otherItem = _inEditItem.GetSwitchDownItem();
      _inEditItem.SwitchRankDown();
      if(_inEditItem.Dirty) { _itemCaster.SaveItem(_inEditItem); }
      if(otherItem!=null&&otherItem.Dirty) _itemCaster.SaveItem(otherItem);
      var opItem = _inEditItem;
      _inReorder=true;
      try {
        var parentItem = (Item)_inEditItem.Parent;
        var inEditIndex = parentItem.Nodes.IndexOf(opItem);
        if(inEditIndex>=0) {
          parentItem.Nodes.RemoveAt(inEditIndex);
          parentItem.Nodes.Insert(inEditIndex+1, opItem);
        }
      } finally {
        _inReorder=false;
      }
      tvBuilder.SelectedNode=opItem;

    }

    private void deleteToolStripMenuItem_Click(object sender, EventArgs e) {
      if(_inEditItem==null) return;
      try {
        Item item = _inEditItem;
        Item ParentItem = (Item)item.Parent;
        SetInProgress(9500);
        if(ParentItem != null){ 
          ParentItem.Nodes.Remove(item);
          tvBuilder.SelectedNode=ParentItem;
        }
        _itemCaster.RemoveItem(item);        
      } finally {
        SetInProgress(0);
      }
    }

    private void saveToolStripMenuItem_Click(object sender, EventArgs e) {
      if(_inEditItem==null) return;
      if(_inEditItem.Dirty) {
        try {
          SetInProgress(9500);
          _itemCaster.SaveItem(_inEditItem);
        } finally {
          SetInProgress(0);
        }
      }
    }
    #endregion
    #region Props editor
    private void ResetPropEditors(Item item) {
      props.SelectedObject=item;
      props.ShowCustomProperties=true;

      props.Item.Clear();
      if( item != null) {

        ItemType it = _types[item.TypeId];
        ItemType itCat = _types[it.CatagoryTypeId];
        props.Item.Add("Rank", item.ItemRank, false, itCat.Name, "Rank determins the sibling order", true);

        var cp = new PropertyGridEx.CustomProperty("Name", item.Text, it.IsReadonly, itCat.Name, it.Desc, it.Visible);
        props.Item.Add(cp);
                
        var pt = _types.GetProjectTypes().ToArray<ItemType>();
        var customProperty2 = new PropertyGridEx.CustomProperty() {
          Name="Type", Category=itCat.Name, Description="Type on object", Value=_types[item.TypeId].Name,
          DisplayMember="Name", ValueMember="TypeId", Datasource=pt, Visible=true, IsReadOnly=false, IsDropdownResizable=true
        };
        props.Item.Add(customProperty2);

        cp=new PropertyGridEx.CustomProperty("Tag", item.PromptTag, it.IsReadonly, itCat.Name, it.Desc, it.Visible);
        props.Item.Add(cp);

        cp=new PropertyGridEx.CustomProperty("Template", item.Template, it.IsReadonly, itCat.Name, it.Desc, it.Visible);
        props.Item.Add(cp);

      }

      props.Refresh();
      props.MoveSplitterTo(Convert.ToInt32(props.Width*0.2));

      if(_inEditItem!=null) {
        PopulateEditors(_inEditItem);
      }
    }
    private void props_PropertyValueChanged(object s, PropertyValueChangedEventArgs e) {
      if(_inEditItem!=null) {
        foreach(CustomProperty y in props.Item) {
          if(y.Name=="Name") {
            if(Convert.ToString(y.Value)!=_inEditItem.Name) {
              _inEditItem.Text=Convert.ToString(y.Value);
            }
            //    } else if(y.Name=="Prompt") {
            //      if(Convert.ToInt32(y.SelectedValue)!=_inEditItem.ValueTypeId) {
            //        _inEditItem.ValueTypeId=Convert.ToInt32(y.SelectedValue);
            //      }
          } else if(y.Name=="Rank") {
            if(Convert.ToInt32(y.Value)>0&&Convert.ToInt32(y.Value)!=_inEditItem.ItemRank) {
              _inEditItem.ItemRank=Convert.ToInt32(y.Value);
            }
          } else if(y.Name=="Type") {
            int newtypeId = Convert.ToInt32(y.SelectedValue);
            if(newtypeId!=0&&newtypeId!=_inEditItem.TypeId) {
              _inEditItem.TypeId=Convert.ToInt32(y.SelectedValue);
            }
          } else if(y.Name=="Tag") {
            if(Convert.ToString(y.Value)!=_inEditItem.PromptTag) {
              _inEditItem.PromptTag=Convert.ToString(y.Value);
            }
          } else if(y.Name=="Template") {
            if(Convert.ToString(y.Value)!=_inEditItem.Template) {
              _inEditItem.Template=Convert.ToString(y.Value);
            }
          }
        }
        if(_inEditItem.Dirty) {
          try {
            SetInProgress(9500);
            _itemCaster.SaveItem(_inEditItem);
            PopulateEditors(_inEditItem);
          } finally {
            SetInProgress(0);
          }
        }
      }
    }
    #endregion
    #region msEditor Events
    private void msEditors_Opening(object sender, CancelEventArgs e) {
      bool inInputTab = tabControl3.SelectedIndex==0;
      FastColoredTextBox ed = inInputTab ? edInput : edOutputText;
      string selection = ed.SelectedText;
      copyToolStripMenuItem.Enabled = selection.Length > 0;
      pasteToolStripMenuItem.Enabled =inInputTab;
      clearToolStripMenuItem.Enabled = ed.Text.Length > 0;
      parseInputToolStripMenuItem.Enabled = (_inEditItem!=null)&&(edInput.Text.Length>0);
      if(!asTemplateToolStripMenuItem.Available) asTemplateToolStripMenuItem.Available = true;
      if(asEssayToolStripMenuItem.Available) asEssayToolStripMenuItem.Available = false;
      if(_inEditItem==null) { return; }
      if (_inEditItem.TypeId==(int)TnType.Essay) {
        if (!asEssayTopicToolStripMenuItem.Available) asEssayTopicToolStripMenuItem.Available = true;
      } else {
        if(!asEssayTopicToolStripMenuItem.Available) asEssayTopicToolStripMenuItem.Available=false;
      }
      if ((_inEditItem.TypeId==(int)TnType.BrainstormThesisStatement)||(_inEditItem.TypeId==(int)TnType.EssayTopic)) {
        if(!asThesisToolStripMenuItem.Available) asThesisToolStripMenuItem.Available = true;
      } else {
        if(asThesisToolStripMenuItem.Available) asThesisToolStripMenuItem.Available=false;
      }
      if((_inEditItem.TypeId==(int)TnType.EssayThesisTopic) ||(_inEditItem.TypeId==(int)TnType.BrainstormThesisTopic)||(_inEditItem.TypeId==(int)TnType.EssayTopic)) {
        if (!asThesisTopicToolStripMenuItem.Available) asThesisTopicToolStripMenuItem.Available = true;
      } else {
        if(asThesisTopicToolStripMenuItem.Available) asThesisTopicToolStripMenuItem.Available=false;
      }
      if((_inEditItem.TypeId==(int)TnType.EssayThesisTopic)||(_inEditItem.TypeId==(int)TnType.BrainstormThesisClaims)) {
        if(!asThesisClaimsToolStripMenuItem.Available) asThesisClaimsToolStripMenuItem.Available=true;
      } else {
        if(asThesisClaimsToolStripMenuItem.Available) asThesisClaimsToolStripMenuItem.Available=false;
      }
      if((_inEditItem.TypeId==(int)TnType.EssayThesisClaims)||(_inEditItem.TypeId==(int)TnType.BrainstormClaimsEvidence)) {
        if(!AsClaimsEvidenceToolStripMenuItem.Available) AsClaimsEvidenceToolStripMenuItem.Available=true;
      } else {
        if(AsClaimsEvidenceToolStripMenuItem.Available) AsClaimsEvidenceToolStripMenuItem.Available=false;
      }      
    }

 

    private void copyToolStripMenuItem_Click(object sender, EventArgs e) {
      FastColoredTextBox ed = tabControl3.SelectedIndex==0 ? edInput : edOutputText;
      if(ed.SelectedText.Length==0) ed.SelectAll();
      Clipboard.SetText(ed.SelectedText);
    }

    private void pasteToolStripMenuItem_Click(object sender, EventArgs e) {
        string x = Clipboard.GetText();
        string[] lines = x.Parse(Environment.NewLine);
        StringBuilder sb = new StringBuilder();
        foreach(string line in lines) {
          if (line.Length>0) sb.AppendLine(line);          
        }
        edInput.Text= sb.ToString();
    }

    private void clearToolStripMenuItem_Click(object sender, EventArgs e) {
      edInput.Text = "";  
    }

    private void parseInputToolStripMenuItem_Click(object sender, EventArgs e) {

    }

    private void asTemplateToolStripMenuItem_Click(object sender, EventArgs e) {
      if(_inEditItem==null) { return; }
      try {
        string content = edInput.Text;
        int dropTypeId = _inEditItem.TypeId;
        SetInProgress(9500);        
        _=_itemCaster.SaveNewChildItemsFromText(_inEditItem, _types[(int)TnType.Template], content);       
      } finally {
        SetInProgress(0);
      }
    }

    private void asEssayToolStripMenuItem_Click(object sender, EventArgs e) {
      if(_inEditItem==null) { return; }
      try {
        string content = edInput.Text;
        int dropTypeId = _inEditItem.TypeId;
        SetInProgress(9500);
        _=_itemCaster.SaveNewChildItemsFromText(_inEditItem, _types[(int)TnType.Essay], content);
      } finally {
        SetInProgress(0);
      }
    }

    private void asEssayTopicToolStripMenuItem_Click(object sender, EventArgs e) {
      if(_inEditItem==null) { return; }
      try {
        string content = edInput.Text;
        int dropTypeId = _inEditItem.TypeId;
        SetInProgress(9500);
        _=_itemCaster.SaveNewChildItemsFromText(_inEditItem, _types[(int)TnType.EssayTopic], content);
      } finally {
        SetInProgress(0);
      }
    }

    private void asThesisToolStripMenuItem_Click(object sender, EventArgs e) {
      if(_inEditItem==null) { return; }
      try {
        string content = edInput.Text;
        int dropTypeId = _inEditItem.TypeId;
        SetInProgress(9500);
        _=_itemCaster.SaveNewChildItemsFromText(_inEditItem, _types[(int)TnType.EssayThesis], content);
      } finally {
        SetInProgress(0);
      }
    }

    private void asThesisTopicToolStripMenuItem_Click(object sender, EventArgs e) {
      if(_inEditItem==null) { return; }
      try {
        string content = edInput.Text;
        int dropTypeId = _inEditItem.TypeId;
        SetInProgress(9500);
        _=_itemCaster.SaveNewChildItemsFromText(_inEditItem, _types[(int)TnType.EssayThesisTopic], content);
      } finally {
        SetInProgress(0);
      }
    }

    private void asThesisClaimsToolStripMenuItem_Click(object sender, EventArgs e) {
      if(_inEditItem==null) { return; }
      try {
        string content = edInput.Text;
        int dropTypeId = _inEditItem.TypeId;
        SetInProgress(9500);
        _=_itemCaster.SaveNewChildItemsFromText(_inEditItem, _types[(int)TnType.EssayThesisClaims], content);
      } finally {
        SetInProgress(0);
      }
    }

    private void AsClaimsEvidenceToolStripMenuItem_Click(object sender, EventArgs e) {
      if(_inEditItem==null) { return; }
      try {
        string content = edInput.Text;
        int dropTypeId = _inEditItem.TypeId;
        SetInProgress(9500);
        _=_itemCaster.SaveNewChildItemsFromText(_inEditItem, _types[(int)TnType.ThesisCliamsEvidence], content);
      } finally {
        SetInProgress(0);
      }
    }

    #endregion
    public void PopulateEditors(Item it) {
      ProcessEditOut(it);
      lbFocus.Text=(_inEditItem==null) ? "" : _inEditItem.Text;
      lbFocusNotes.Text =(_inEditItem==null) ? "" : _types[ _inEditItem.TypeId].Desc;
    }
    public void ProcessEditOut(Item it) {
      //draw tree to outputs
      wbOut.DocumentText=it.GetRichTextEditor(_types, _itemCaster);      
      edOutputText.Text =it.GetOutputTextEditor(_types, _itemCaster);
    }


  }
}
