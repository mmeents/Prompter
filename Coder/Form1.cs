using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Prompter.Models;
using System.Runtime.InteropServices;
using PropertyGridEx;
using static System.Net.Mime.MediaTypeNames;
using FastColoredTextBoxNS;

namespace Prompter {
  public partial class Form1:Form {

    private string _fileName;
    private string _folder;
    private CryptoKey _key;
    private Types _types;
    private ItemCaster _itemCaster;
    private Item _inEditItem = null;
    public Form1() {
      InitializeComponent();
    }

    private void logMsg(string msg) { 
      if (!edError.Visible) edError.Visible = true;
      edError.Text = msg+ Environment.NewLine+ edError.Text;
    }
    private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e) {
      if (e.TabPageIndex == 1) {
        try { 
          _fileName = edFileName.Text;
          int fnl = _fileName.ParseLast("\\").Length + 1;
          _folder = _fileName.Substring(0, _fileName.Length - fnl);
          string pw = edPassword.Text;
          _key = new CryptoKey();
          _key.SetCryptoKey(pw);      
          _itemCaster = new ItemCaster(tvBuilder, _key, _fileName);
          e.Cancel= (!(pw.Length>0)) || (!(Directory.Exists(_folder)));
        } catch (Exception ex) {
          logMsg(ex.Message);
          e.Cancel = true;
        }
      }
    }
    private void tabControl1_SelectedIndexChanged(object sender, EventArgs e) {
      this.Text = (tabControl1.SelectedIndex == 0) ? "Prompter Setup":$"Prompter {_fileName}";
      if (tabControl1.SelectedIndex == 1) {
        LoadtvTools();
        _itemCaster.LoadTreeviewItemsAsync(tvBuilder);
      }      
    }

    private void LoadtvTools() {
      _types=new Types();
      tvTools.Nodes.Clear();
      tvTools.Nodes.Add(_types[18]);
      tvTools.Nodes.Add(_types[19]);
      tvTools.Nodes.Add(_types[20]);
      tvTools.Nodes.Add(_types[21]);
      tvTools.Nodes.Add(_types[22]);
      tvTools.Nodes.Add(_types[23]);
    }

    private void button1_Click(object sender, EventArgs e) {
      if (edFileName.Text == "") { 
        odMain.InitialDirectory = Ext.MMCommonsFolder();
      } else {
        string s = edFileName.Text.ParseLast("/");
        odMain.InitialDirectory = edFileName.Text.Substring(0, s.Length);
      }
      DialogResult res = odMain.ShowDialog();
      if (res == DialogResult.OK) {
        edFileName.Text = odMain.FileName;
      }
    }

    private void button2_Click(object sender, EventArgs e) {
      tabControl1.SelectedIndex=1;
    }

    private void tvTools_ItemDrag(object sender, ItemDragEventArgs e) {
      if(e.Button==MouseButtons.Left) {
        DoDragDrop(e.Item, DragDropEffects.Copy);
      }
    }

    private void tvTools_DragOver(object sender, DragEventArgs e) {
      e.Effect = DragDropEffects.None;
    }

    private void tvBuilder_BeforeExpand(object sender, TreeViewCancelEventArgs e) {
      Item tn = (Item)e.Node;
      if(tn!=null) {
        var items = _itemCaster.GetOwnersItemsAsync(tn);
        e.Cancel=false;
      }
    }

    private void tvBuilder_ItemDrag(object sender, ItemDragEventArgs e) {
      if(e.Button==MouseButtons.Left) {
        DoDragDrop(e.Item, DragDropEffects.Move);
      }
    }
    private void tvBuilder_DragEnter(object sender, DragEventArgs e) {
      e.Effect= DragDropEffects.Move;
    }

    private void tvBuilder_DragOver(object sender, DragEventArgs e) {      
      if(e.Data!=null) {
        ItemType sn = (ItemType)e.Data.GetData(typeof(ItemType));
        if(sn!=null) { // this is copy from tvtools.
          Point targetPt = tvBuilder.PointToClient(new Point(e.X, e.Y));
          Item tn = (Item)tvBuilder.GetNodeAt(targetPt);
          if(tn!=null) {
            e.Effect=DragDropEffects.None;
            if(!tn.IsExpanded) tn.Expand();

            if(sn.TypeId==(int)TnType.Template&& ( tn.TypeId==(int)TnType.Project || tn.TypeId==(int)TnType.Template)) e.Effect=DragDropEffects.Copy;
            if(sn.TypeId==(int)TnType.Chapters&&tn.TypeId==(int)TnType.Project) e.Effect=DragDropEffects.Copy;
            if(sn.TypeId==(int)TnType.Chapter&&tn.TypeId==(int)TnType.Chapters) e.Effect=DragDropEffects.Copy;
            if(sn.TypeId==(int)TnType.Section&&tn.TypeId==(int)TnType.Chapter) e.Effect=DragDropEffects.Copy;
            if(sn.TypeId==(int)TnType.SubSection&& (tn.TypeId==(int)TnType.Section)||(tn.TypeId==(int)TnType.SubSection)) e.Effect=DragDropEffects.Copy;

          } else {
            if(sn.TypeId==(int)TnType.Project) {
              e.Effect=DragDropEffects.Copy;
            } else {
              e.Effect=DragDropEffects.None;
            }
          }
        } else {  // this is copy with tvBuilder
          Item sni = (Item)e.Data.GetData(typeof(Item));
          if (sni !=null) {
            Point targetPt = tvBuilder.PointToClient(new Point(e.X, e.Y));
            Item tn = (Item)tvBuilder.GetNodeAt(targetPt);
            if (tn != sni) { 
              if(tn!=null) {
                e.Effect=DragDropEffects.None;
                if(!tn.IsExpanded) tn.Expand();
                if(sni.TypeId==(int)TnType.Template&&(tn.TypeId==(int)TnType.Project||tn.TypeId==(int)TnType.Template)) e.Effect=DragDropEffects.Move;
                if(sni.TypeId==(int)TnType.Chapters&&tn.TypeId==(int)TnType.Project) e.Effect=DragDropEffects.Move;
                if(sni.TypeId==(int)TnType.Chapter&&tn.TypeId==(int)TnType.Chapters) e.Effect=DragDropEffects.Move;
                if(sni.TypeId==(int)TnType.Section&&tn.TypeId==(int)TnType.Chapter) e.Effect=DragDropEffects.Move;
                if(sni.TypeId==(int)TnType.SubSection&&(tn.TypeId==(int)TnType.Section)||(tn.TypeId==(int)TnType.SubSection)) e.Effect=DragDropEffects.Move;

              } else {
                if(sni.TypeId==(int)TnType.Project) {
                  e.Effect=DragDropEffects.Move;
                } else {
                  e.Effect=DragDropEffects.None;
                }
              }
            }
          }
        }
      }
    }

    private void tvBuilder_DragDrop(object sender, DragEventArgs e) {
      Point targetPt = tvBuilder.PointToClient(new Point(e.X, e.Y));
      Item tn = (Item)tvBuilder.GetNodeAt(targetPt);
      if(tn!=null&&e.Data!=null) {

        ItemType draggedNode = (ItemType)e.Data.GetData(typeof(ItemType));
        if (draggedNode !=null) { 
          if        (draggedNode.TypeId==(int)TnType.Template&& (tn.TypeId==(int)TnType.Project||tn.TypeId==(int)TnType.Template)) {
            var nn = _itemCaster.SaveNewItemFromType(tn, draggedNode);
          } else if((draggedNode.TypeId==(int)TnType.SubSection)&&(tn.TypeId==(int)TnType.Section||tn.TypeId == (int)TnType.SubSection)) {
            var nn = _itemCaster.SaveNewItemFromType(tn, draggedNode);
          } else if((draggedNode.TypeId==(int)TnType.Section&&tn.TypeId==(int)TnType.Chapter)) {
            var fnn=_itemCaster.SaveNewItemFromType(tn, draggedNode);
          } else if((draggedNode.TypeId==(int)TnType.Chapters&&tn.TypeId==(int)TnType.Project)) {
            var fnn = _itemCaster.SaveNewItemFromType(tn, draggedNode);
          } else if((draggedNode.TypeId==(int)TnType.Chapter&&tn.TypeId==(int)TnType.Chapters)) {
            var fnn = _itemCaster.SaveNewItemFromType(tn, draggedNode);
          }
        } else {

          Item dragNode = (Item)e.Data.GetData(typeof(Item));
          if(dragNode!=null) {
            if(dragNode.TypeId==(int)TnType.Template&&(tn.TypeId==(int)TnType.Project||tn.TypeId==(int)TnType.Template)) {
              var nn = _itemCaster.MoveItemSave(tn, dragNode);
            } else if((dragNode.TypeId==(int)TnType.SubSection)&&(tn.TypeId==(int)TnType.Section||tn.TypeId==(int)TnType.SubSection)) {
              var nn = _itemCaster.MoveItemSave(tn, dragNode);
            } else if((dragNode.TypeId==(int)TnType.Section&&tn.TypeId==(int)TnType.Chapter)) {
              var fnn = _itemCaster.MoveItemSave(tn, dragNode);
            } else if((dragNode.TypeId==(int)TnType.Chapters&&tn.TypeId==(int)TnType.Project)) {
              var fnn = _itemCaster.MoveItemSave(tn, dragNode);
            } else if((dragNode.TypeId==(int)TnType.Chapter&&tn.TypeId==(int)TnType.Chapters)) {
              var fnn = _itemCaster.MoveItemSave(tn, dragNode);
            }
          } 

        }
      } else {
        if(e.Data!=null) {
          ItemType draggedNode = (ItemType)e.Data.GetData(typeof(ItemType));
          if(draggedNode!=null) {
            if(draggedNode.TypeId==(int)TnType.Project) {
              var newItem = _itemCaster.SaveNewItemFromType(null, draggedNode);
              tvBuilder.Nodes.Add(newItem);
            }
          } 
        }
      }
    }

    private void tvBuilder_AfterSelect(object sender, TreeViewEventArgs e) {
      if(e?.Node==null) return;
      _inEditItem=(Item)e.Node;
      if(_inEditItem==null) return;      
      ResetPropEditors(_inEditItem);
    }

    private void ResetPropEditors(Item item) {
      props.SelectedObject=item;
      props.ShowCustomProperties=true;

      props.Item.Clear();
      if(
          item.TypeId==(int)TnType.Project||
          item.TypeId==(int)TnType.Template||
          item.TypeId==(int)TnType.Chapters||
          item.TypeId==(int)TnType.Chapter||
          item.TypeId==(int)TnType.Section||
          item.TypeId==(int)TnType.SubSection          
      ) {
        ItemType it = _types[item.TypeId];
        ItemType itCat = _types[it.CatagoryTypeId];
        var cp = new PropertyGridEx.CustomProperty("Name", item.Text, it.Readonly, itCat.Text, it.Desc, it.Visible);
        props.Item.Add(cp);

        var al = _types.GetChildrenItems(43).ToArray<ItemType>();                        
        var customProperty = new PropertyGridEx.CustomProperty() {
          Name="Prompt", Category=itCat.Text, Description=it.Desc, Value=_types[item.ValueTypeId].Name,
          DisplayMember="Text", ValueMember="TypeId", Datasource=al, Visible=true, IsReadOnly=false, IsDropdownResizable=true
        };
        props.Item.Add(customProperty);
      }     

      props.Refresh();

      if(_inEditItem != null) {         
        PopulateEditors(_inEditItem);        
      }
      ResetbtnInputVisibility();
    }
    private void props_PropertyValueChanged(object s, PropertyValueChangedEventArgs e) {
      if(_inEditItem!=null) {
        foreach(CustomProperty y in props.Item) {
          if(y.Name=="Name") {
            if(Convert.ToString(y.Value)!=_inEditItem.Name) {
              _inEditItem.Text=Convert.ToString(y.Value);
            }
          } else if(y.Name=="Prompt") {
            if(Convert.ToInt32(y.SelectedValue)!=_inEditItem.ValueTypeId) {
              _inEditItem.ValueTypeId=Convert.ToInt32(y.SelectedValue);
            }
          }
        }
        if(_inEditItem.Dirty) {
          _itemCaster.SaveItem( _inEditItem );          
          PopulateEditors(_inEditItem);          
        }
      }
    }

    private void contextMenuStrip1_Opening(object sender, CancelEventArgs e) {
      if (_inEditItem == null) { e.Cancel = true; return; }      
      if (_inEditItem.Dirty ) {
        saveToolStripMenuItem.Enabled = true;
      } else { 
        saveToolStripMenuItem.Enabled = false;       
      }
      if(_inEditItem.Nodes.Count==0) {
        deleteToolStripMenuItem.Enabled = true;
      } else {  
        deleteToolStripMenuItem.Enabled = false; 
      }
    }

    private void deleteToolStripMenuItem_Click(object sender, EventArgs e) {
      if(_inEditItem==null) return;
      Item item = _inEditItem;
      //DialogResult dr = MessageBox.Show($"Delete {item.Text} ", "Confirm Delete", MessageBoxButtons.OKCancel);
      //if(dr==DialogResult.OK) {
        Item ParentItem = (Item)item.Parent;        
        ParentItem.Nodes.Remove(item);
        _itemCaster.RemoveItem(item);
        tvBuilder.SelectedNode=ParentItem;
      //}
    }

    private void btnClear_Click(object sender, EventArgs e) {
      FastColoredTextBox ed = tabControl2.SelectedIndex==0 ? edOutput : edInput;
      ed.Text = "";
    }

    public void PopulateEditors(Item it) {
      ProcessEditOut(it);
      ResetbtnInputVisibility();
      label3.Text = (_inEditItem==null) ? "" : _inEditItem.Text;
    }
    private void ResetbtnInputVisibility() {
      btnParse.Visible=(tabControl2.SelectedIndex==1);
      btnParse.Enabled=(_inEditItem!=null)&&(edInput.Text.Length>0)&&(
        _inEditItem.TypeId==(int)TnType.Template
        ||_inEditItem.TypeId==(int)TnType.Chapters
        ||_inEditItem.TypeId==(int)TnType.Chapter
        ||_inEditItem.TypeId==(int)TnType.Section
        ||_inEditItem.TypeId==(int)TnType.SubSection
      );
    }

    private void tabControl2_SelectedIndexChanged(object sender, EventArgs e) {
      ResetbtnInputVisibility();
    }

    private void btnParse_Click(object sender, EventArgs e) {
      if(_inEditItem==null) { return; }
      string content = edInput.Text;
      int dropTypeId = _inEditItem.TypeId;
      if(dropTypeId==(int)TnType.Project||dropTypeId==(int)TnType.Template) {
        _=_itemCaster.SaveNewChildItemsFromText(_inEditItem, _types[(int)TnType.Template], content);
      } else if(dropTypeId==(int)TnType.Chapters) {
        _=_itemCaster.SaveNewChildItemsFromText(_inEditItem, _types[(int)TnType.Chapter], content);
      } else if(dropTypeId==(int)TnType.Chapter) {
        _=_itemCaster.SaveNewChildItemsFromText(_inEditItem, _types[(int)TnType.Section], content);
      } else if(dropTypeId==(int)TnType.Section||dropTypeId==(int)TnType.SubSection) {
        _=_itemCaster.SaveNewChildItemsFromText(_inEditItem, _types[(int)TnType.SubSection], content);
      }
    }

    private void contextMenuStrip2_Opening(object sender, CancelEventArgs e) {
      FastColoredTextBox ed = tabControl2.SelectedIndex == 0 ? edOutput : edInput ; 
      string selection = ed.SelectedText;
      copyToolStripMenuItem.Enabled = true;
      pasteToolStripMenuItem.Enabled = true;
      parseToolStripMenuItem.Enabled = (_inEditItem!=null)&&(edInput.Text.Length>0)&&(
        _inEditItem.TypeId==(int)TnType.Template
        ||_inEditItem.TypeId==(int)TnType.Chapters
        ||_inEditItem.TypeId==(int)TnType.Chapter
        ||_inEditItem.TypeId==(int)TnType.Section
        ||_inEditItem.TypeId==(int)TnType.SubSection
      );
    }

    private void copyToolStripMenuItem_Click(object sender, EventArgs e) {
      FastColoredTextBox ed = tabControl2.SelectedIndex==0 ?  edOutput: edInput;
      if (ed.SelectedText.Length == 0) ed.SelectAll();
      Clipboard.SetText(ed.SelectedText);
    }

    private void pasteToolStripMenuItem_Click(object sender, EventArgs e) {
      if (tabControl2.SelectedIndex ==0) {
        edOutput.Text = Clipboard.GetText();
      } else {
        edInput.Text=Clipboard.GetText();
      }                  
      ResetbtnInputVisibility();
    }

    private void ProcessEditOut(Item it) {
      if (cbPrompt.Checked &&it.ValueTypeId>0) { 
        string promptTemplate = _types[it.ValueTypeId].Desc;
        if (promptTemplate ==String.Empty && it.ValueTypeId==47) {  // 47 is current node is template.
          promptTemplate = it.Text;
        }
        string GrandParent="", Parent="", Node = "";
        if(it.OwnerId>0) {
          if(it.Parent!=null) {
            Parent= it.Parent.Text;
            if(((Item)it.Parent).OwnerId>0&&it.Parent.Parent!=null) {
              GrandParent=it.Parent.Parent.Text;
            }
          }
        }        
        edOutput.Text = promptTemplate.Replace("[NODE]", it.Text).Replace("[PARENT]", Parent).Replace("[GRANDPARENT]", GrandParent);
      } else { 
        string s = it.Text+Cs.nl+Cs.nl;
        if (it.OwnerId > 0) { 
          if (it.Parent !=null) { 
            s = it.Parent.Text + Cs.nl+Cs.nl+s;
            if (((Item)it.Parent).OwnerId > 0 && it.Parent.Parent !=null) { 
              s = it.Parent.Parent.Text + Cs.nl+Cs.nl + s;
            }
          }
        }      
        string tag = "";
        foreach(Item c in it.Nodes) {
          if (c.ValueTypeId !=47) {  // templates dont print here.
            string childContent = GetChildContent(c);
            if(c.Text[0]=='[') {
              tag = c.Text.Insert(1,"/");          
              s = s + Cs.nl+ c.Text+Cs.nl+childContent+Cs.nl+tag;
            } else {
              s= s + Cs.nl + c.Text+Cs.nl+childContent+Cs.nl;
            }
            s= s+Cs.nl;
          }
        }
        edOutput.Text = s+Cs.nl;
      }
    }

    private string GetChildContent(Item it) { 
      string s = "";
      foreach(Item c in it.Nodes) {
        s = s + (s=="" ? c.Text:Cs.nl+c.Text);
      }
      return s;
    }

    private void Form1_Resize(object sender, EventArgs e) {
      tvBuilder.Height = splitContainer1.Height - panel2.Height - 2;
    }

    private void Form1_Shown(object sender, EventArgs e) {
      Form1_Resize(null, null);
    }

    private void scRoot2_SplitterMoved(object sender, SplitterEventArgs e) {
      tvBuilder.Height=splitContainer1.Height-panel2.Height-2;
    }


  }
}
