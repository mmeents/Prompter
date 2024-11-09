using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using System.Windows.Forms;

namespace PrompterV3.Models {
  public class Item : TreeNode {
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
        Dirty = true;
        _typeId = value;
        if (this.TypeId >= 100 && this.TypeId <= 199) {
          this.ImageIndex = (int)Tii.Gift;
          this.SelectedImageIndex = (int)Tii.Gift;
        } else if (this.TypeId >= 200 && this.TypeId <= 299) {
          this.ImageIndex = (int)Tii.Label;
          this.SelectedImageIndex = (int)Tii.Label;
        } else if (this.TypeId >= 300 && this.TypeId <= 399) {
          this.ImageIndex = (int)Tii.Folder;
          this.SelectedImageIndex = (int)Tii.Folder;
        } else if (this.TypeId >= 400 && this.TypeId <= 499) {
          this.ImageIndex = (int)Tii.View;
          this.SelectedImageIndex = (int)Tii.View;
        } else if (this.TypeId >= 500 && this.TypeId <= 599) {
          this.ImageIndex = (int)Tii.Internal;
          this.SelectedImageIndex = (int)Tii.Internal;
        } else if (this.TypeId >= 600 && this.TypeId <= 699) {
          this.ImageIndex = (int)Tii.Table;
          this.SelectedImageIndex = (int)Tii.Table;
        } else if (this.TypeId >= 700 && this.TypeId <= 799) {
          this.ImageIndex = (int)Tii.News;
          this.SelectedImageIndex = (int)Tii.News;
        }
      }
    }
    public int StatusId { get { return _statusId; } set { _statusId = value; Dirty = true; } }
    public int ItemRank { get { return _itemRank; } set { _itemRank = value; Dirty = true; } }
    public string PromptTag { get { return _promptTag; } set { _promptTag = value; Dirty = true; } }
    public new string Text { get { return base.Text; } set { base.Text = value; Dirty = true; } }
    public string Template { get { return _template; } set { _template = value; Dirty = true; } }
    public int ValueTypeId { get { return _valueTypeId; } set { _valueTypeId = value; Dirty = true; } }
    public string Value { get { return _value; } set { _value = value; Dirty = true; } }


    public bool CanSwitchDown() {
      if (Parent == null) return false;
      var ImChildNo = Parent.Nodes.IndexOf(this);
      if (ImChildNo < 0) return false;
      return ImChildNo < Parent.Nodes.Count - 1;
    }
    public Item GetSwitchDownItem() {
      if (Parent == null) return null;
      var ImChildNo = Parent.Nodes.IndexOf(this);
      if (ImChildNo < 0) return null;
      if (ImChildNo + 1 <= Parent.Nodes.Count - 1) {
        return ((Item)Parent.Nodes[ImChildNo + 1]);
      }
      return null;
    }
    public bool SwitchRankDown() {
      if (Parent == null) return false;
      var ImChildNo = Parent.Nodes.IndexOf(this);
      if (ImChildNo < 0) return false;
      if (ImChildNo + 1 <= Parent.Nodes.Count - 1) {
        var rank = ItemRank;
        ItemRank = ((Item)Parent.Nodes[ImChildNo + 1]).ItemRank;
        ((Item)Parent.Nodes[ImChildNo + 1]).ItemRank = rank;
        return true;
      }
      return false;
    }

    public bool CanSwitchUp() {
      if (Parent == null) return false;
      return Parent.Nodes.IndexOf(this) >= 1;
    }

    public Item GetSwitchUpItem() {
      if (Parent == null) return null;
      var ImChildNo = Parent.Nodes.IndexOf(this);
      if (ImChildNo < 1) return null;
      return ((Item)Parent.Nodes[ImChildNo - 1]);
    }

    public bool SwitchRankUp() {
      if (Parent == null) return false;
      var ImChildNo = Parent.Nodes.IndexOf(this);
      if (ImChildNo < 1) return false;
      var rank = ItemRank;
      ItemRank = ((Item)Parent.Nodes[ImChildNo - 1]).ItemRank;
      ((Item)Parent.Nodes[ImChildNo - 1]).ItemRank = rank;
      return false;
    }

    public string AsChunk() {
      string pt = string.IsNullOrEmpty(_promptTag) ? "NULL" : _promptTag;
      string tt = string.IsNullOrEmpty(_template) ? "NULL" : _template;
      string tn = string.IsNullOrEmpty(base.Text) ? "NULL" : base.Text;
      string vc = string.IsNullOrEmpty(_value) ? "NULL" : _value;
      return $"{Id} {OwnerId} {_typeId} {_statusId} {_itemRank} {_valueTypeId} {pt.AsBase64Encoded()} {tn.AsBase64Encoded()} {tt.AsBase64Encoded()} {vc.AsBase64Encoded()}";
    }

    public Item FromChunk(string chunk) {
      string[] base1 = chunk.Parse(" ");
      Id = base1[0].AsInt();
      OwnerId = base1[1].AsInt();
      TypeId = base1[2].AsInt();
      _statusId = base1[3].AsInt();
      _itemRank = base1[4].AsInt();
      _valueTypeId = base1[5].AsInt();
      _promptTag = base1[6].AsBase64Decoded();
      if (_promptTag == "NULL") _promptTag = "";
      base.Text = base1[7].AsBase64Decoded();
      if (base.Text == "NULL") base.Text = "";
      _template = base1[8].AsBase64Decoded();
      if (_template == "NULL") _template = "";
      _value = base1[9].AsBase64Decoded();
      if (_value == "NULL") _value = "";
      Dirty = false;
      return this;
    }

    public Item AsClone() {
      Item item = new Item();
      return item.FromChunk(AsChunk());
    }
  }

}
