﻿namespace Prompter {
  partial class Form1 {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if(disposing&&(components!=null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.tabPage1 = new System.Windows.Forms.TabPage();
      this.edError = new System.Windows.Forms.TextBox();
      this.button2 = new System.Windows.Forms.Button();
      this.button1 = new System.Windows.Forms.Button();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.edPassword = new System.Windows.Forms.TextBox();
      this.edFileName = new System.Windows.Forms.TextBox();
      this.tabPage2 = new System.Windows.Forms.TabPage();
      this.scRoot = new System.Windows.Forms.SplitContainer();
      this.tvTools = new System.Windows.Forms.TreeView();
      this.imageList1 = new System.Windows.Forms.ImageList(this.components);
      this.panel1 = new System.Windows.Forms.Panel();
      this.scRoot2 = new System.Windows.Forms.SplitContainer();
      this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.odMain = new System.Windows.Forms.OpenFileDialog();
      this.panel3 = new System.Windows.Forms.Panel();
      this.props = new PropertyGridEx.PropertyGridEx();
      this.splitContainer1 = new System.Windows.Forms.SplitContainer();
      this.tabControl2 = new System.Windows.Forms.TabControl();
      this.tabPage3 = new System.Windows.Forms.TabPage();
      this.edOutput = new FastColoredTextBoxNS.FastColoredTextBox();
      this.tabPage4 = new System.Windows.Forms.TabPage();
      this.edInput = new FastColoredTextBoxNS.FastColoredTextBox();
      this.tvBuilder = new System.Windows.Forms.TreeView();
      this.panel2 = new System.Windows.Forms.Panel();
      this.parseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.label3 = new System.Windows.Forms.Label();
      this.btnPaste = new System.Windows.Forms.Button();
      this.btnClear = new System.Windows.Forms.Button();
      this.btnInput = new System.Windows.Forms.Button();
      this.cbPrompt = new System.Windows.Forms.CheckBox();
      this.tabControl1.SuspendLayout();
      this.tabPage1.SuspendLayout();
      this.tabPage2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.scRoot)).BeginInit();
      this.scRoot.Panel1.SuspendLayout();
      this.scRoot.Panel2.SuspendLayout();
      this.scRoot.SuspendLayout();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.scRoot2)).BeginInit();
      this.scRoot2.Panel1.SuspendLayout();
      this.scRoot2.Panel2.SuspendLayout();
      this.scRoot2.SuspendLayout();
      this.contextMenuStrip1.SuspendLayout();
      this.contextMenuStrip2.SuspendLayout();
      this.panel3.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      this.tabControl2.SuspendLayout();
      this.tabPage3.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.edOutput)).BeginInit();
      this.tabPage4.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.edInput)).BeginInit();
      this.panel2.SuspendLayout();
      this.SuspendLayout();
      // 
      // tabControl1
      // 
      this.tabControl1.Controls.Add(this.tabPage1);
      this.tabControl1.Controls.Add(this.tabPage2);
      this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tabControl1.Location = new System.Drawing.Point(0, 0);
      this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(1022, 854);
      this.tabControl1.TabIndex = 0;
      this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
      this.tabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Selecting);
      // 
      // tabPage1
      // 
      this.tabPage1.Controls.Add(this.edError);
      this.tabPage1.Controls.Add(this.button2);
      this.tabPage1.Controls.Add(this.button1);
      this.tabPage1.Controls.Add(this.label2);
      this.tabPage1.Controls.Add(this.label1);
      this.tabPage1.Controls.Add(this.edPassword);
      this.tabPage1.Controls.Add(this.edFileName);
      this.tabPage1.Location = new System.Drawing.Point(4, 32);
      this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.tabPage1.Size = new System.Drawing.Size(1012, 923);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "Setup";
      this.tabPage1.UseVisualStyleBackColor = true;
      // 
      // edError
      // 
      this.edError.Location = new System.Drawing.Point(89, 519);
      this.edError.Multiline = true;
      this.edError.Name = "edError";
      this.edError.Size = new System.Drawing.Size(809, 182);
      this.edError.TabIndex = 6;
      this.edError.Visible = false;
      this.edError.WordWrap = false;
      // 
      // button2
      // 
      this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.button2.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
      this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
      this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
      this.button2.Location = new System.Drawing.Point(376, 276);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(111, 45);
      this.button2.TabIndex = 5;
      this.button2.Text = "Open";
      this.button2.UseVisualStyleBackColor = false;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // button1
      // 
      this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
      this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
      this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
      this.button1.Location = new System.Drawing.Point(836, 109);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 30);
      this.button1.TabIndex = 4;
      this.button1.Text = "Open";
      this.button1.UseVisualStyleBackColor = false;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(85, 163);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(114, 23);
      this.label2.TabIndex = 3;
      this.label2.Text = "File Password:";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(68, 112);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(131, 23);
      this.label1.TabIndex = 2;
      this.label1.Text = "Coder data file: ";
      // 
      // edPassword
      // 
      this.edPassword.Location = new System.Drawing.Point(205, 163);
      this.edPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.edPassword.Name = "edPassword";
      this.edPassword.Size = new System.Drawing.Size(163, 30);
      this.edPassword.TabIndex = 1;
      this.edPassword.Text = "mm";
      // 
      // edFileName
      // 
      this.edFileName.Location = new System.Drawing.Point(205, 109);
      this.edFileName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.edFileName.Name = "edFileName";
      this.edFileName.Size = new System.Drawing.Size(625, 30);
      this.edFileName.TabIndex = 0;
      this.edFileName.Text = "C:\\ProgramData\\MMCommons\\Prompter001.cdf";
      // 
      // tabPage2
      // 
      this.tabPage2.Controls.Add(this.scRoot);
      this.tabPage2.Location = new System.Drawing.Point(4, 32);
      this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.tabPage2.Size = new System.Drawing.Size(1014, 818);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "Builder";
      this.tabPage2.UseVisualStyleBackColor = true;
      // 
      // scRoot
      // 
      this.scRoot.Dock = System.Windows.Forms.DockStyle.Fill;
      this.scRoot.Location = new System.Drawing.Point(3, 4);
      this.scRoot.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.scRoot.Name = "scRoot";
      // 
      // scRoot.Panel1
      // 
      this.scRoot.Panel1.Controls.Add(this.tvTools);
      this.scRoot.Panel1.Controls.Add(this.panel1);
      // 
      // scRoot.Panel2
      // 
      this.scRoot.Panel2.Controls.Add(this.scRoot2);
      this.scRoot.Size = new System.Drawing.Size(1008, 810);
      this.scRoot.SplitterDistance = 232;
      this.scRoot.TabIndex = 1;
      // 
      // tvTools
      // 
      this.tvTools.AllowDrop = true;
      this.tvTools.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tvTools.ImageIndex = 0;
      this.tvTools.ImageList = this.imageList1;
      this.tvTools.Location = new System.Drawing.Point(0, 88);
      this.tvTools.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.tvTools.Name = "tvTools";
      this.tvTools.SelectedImageIndex = 0;
      this.tvTools.Size = new System.Drawing.Size(232, 722);
      this.tvTools.TabIndex = 1;
      this.tvTools.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.tvTools_ItemDrag);
      this.tvTools.DragOver += new System.Windows.Forms.DragEventHandler(this.tvTools_DragOver);
      // 
      // imageList1
      // 
      this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
      this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
      this.imageList1.Images.SetKeyName(0, "collection-710-16.png");
      this.imageList1.Images.SetKeyName(1, "server-38-16.png");
      this.imageList1.Images.SetKeyName(2, "server-53-16.png");
      this.imageList1.Images.SetKeyName(3, "folder-457-16.png");
      this.imageList1.Images.SetKeyName(4, "coupon-316-16.png");
      this.imageList1.Images.SetKeyName(5, "data-331-16.png");
      this.imageList1.Images.SetKeyName(6, "gift-551-16 (1).png");
      this.imageList1.Images.SetKeyName(7, "find-228-16.png");
      this.imageList1.Images.SetKeyName(8, "scanning-92-16.png");
      this.imageList1.Images.SetKeyName(9, "news-773-16.png");
      this.imageList1.Images.SetKeyName(10, "lookup-61-16.png");
      this.imageList1.Images.SetKeyName(11, "gift-551-16.png");
      this.imageList1.Images.SetKeyName(12, "add-50-16.png");
      this.imageList1.Images.SetKeyName(13, "play-277-16.png");
      this.imageList1.Images.SetKeyName(14, "stop-62-16.png");
      this.imageList1.Images.SetKeyName(15, "delete-1203-16.png");
      this.imageList1.Images.SetKeyName(16, "label-387-16.png");
      this.imageList1.Images.SetKeyName(17, "share-978-16.png");
      this.imageList1.Images.SetKeyName(18, "set-up-1014-16.png");
      this.imageList1.Images.SetKeyName(19, "flame-_1_.ico");
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.btnPaste);
      this.panel1.Controls.Add(this.btnClear);
      this.panel1.Controls.Add(this.btnInput);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(232, 88);
      this.panel1.TabIndex = 0;
      // 
      // scRoot2
      // 
      this.scRoot2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.scRoot2.Location = new System.Drawing.Point(0, 0);
      this.scRoot2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.scRoot2.Name = "scRoot2";
      this.scRoot2.Orientation = System.Windows.Forms.Orientation.Horizontal;
      // 
      // scRoot2.Panel1
      // 
      this.scRoot2.Panel1.Controls.Add(this.splitContainer1);
      this.scRoot2.Panel1.Controls.Add(this.panel3);
      // 
      // scRoot2.Panel2
      // 
      this.scRoot2.Panel2.Controls.Add(this.props);
      this.scRoot2.Size = new System.Drawing.Size(772, 810);
      this.scRoot2.SplitterDistance = 596;
      this.scRoot2.TabIndex = 0;
      this.scRoot2.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.scRoot2_SplitterMoved);
      // 
      // contextMenuStrip1
      // 
      this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem,
            this.saveToolStripMenuItem});
      this.contextMenuStrip1.Name = "contextMenuStrip1";
      this.contextMenuStrip1.Size = new System.Drawing.Size(123, 52);
      this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
      // 
      // deleteToolStripMenuItem
      // 
      this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
      this.deleteToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
      this.deleteToolStripMenuItem.Text = "Delete";
      this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
      // 
      // saveToolStripMenuItem
      // 
      this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
      this.saveToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
      this.saveToolStripMenuItem.Text = "Save";
      // 
      // contextMenuStrip2
      // 
      this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.parseToolStripMenuItem});
      this.contextMenuStrip2.Name = "contextMenuStrip2";
      this.contextMenuStrip2.Size = new System.Drawing.Size(113, 100);
      this.contextMenuStrip2.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip2_Opening);
      // 
      // clearToolStripMenuItem
      // 
      this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
      this.clearToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
      this.clearToolStripMenuItem.Text = "Clear";
      this.clearToolStripMenuItem.Click += new System.EventHandler(this.btnClear_Click);
      // 
      // copyToolStripMenuItem
      // 
      this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
      this.copyToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
      this.copyToolStripMenuItem.Text = "Copy";
      this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
      // 
      // pasteToolStripMenuItem
      // 
      this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
      this.pasteToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
      this.pasteToolStripMenuItem.Text = "Paste";
      this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
      // 
      // odMain
      // 
      this.odMain.CheckFileExists = false;
      this.odMain.DefaultExt = "cdf";
      // 
      // panel3
      // 
      this.panel3.Controls.Add(this.label3);
      this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel3.Location = new System.Drawing.Point(0, 0);
      this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.panel3.Name = "panel3";
      this.panel3.Size = new System.Drawing.Size(772, 60);
      this.panel3.TabIndex = 2;
      // 
      // props
      // 
      // 
      // 
      // 
      this.props.DocCommentDescription.AutoEllipsis = true;
      this.props.DocCommentDescription.Cursor = System.Windows.Forms.Cursors.Default;
      this.props.DocCommentDescription.Location = new System.Drawing.Point(4, 29);
      this.props.DocCommentDescription.Margin = new System.Windows.Forms.Padding(32, 0, 32, 0);
      this.props.DocCommentDescription.Name = "";
      this.props.DocCommentDescription.Size = new System.Drawing.Size(764, 40);
      this.props.DocCommentDescription.TabIndex = 1;
      this.props.DocCommentImage = null;
      // 
      // 
      // 
      this.props.DocCommentTitle.Cursor = System.Windows.Forms.Cursors.Default;
      this.props.DocCommentTitle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
      this.props.DocCommentTitle.Location = new System.Drawing.Point(4, 4);
      this.props.DocCommentTitle.Margin = new System.Windows.Forms.Padding(32, 0, 32, 0);
      this.props.DocCommentTitle.Name = "";
      this.props.DocCommentTitle.Size = new System.Drawing.Size(764, 25);
      this.props.DocCommentTitle.TabIndex = 0;
      this.props.DocCommentTitle.UseMnemonic = false;
      this.props.Dock = System.Windows.Forms.DockStyle.Fill;
      this.props.Location = new System.Drawing.Point(0, 0);
      this.props.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
      this.props.Name = "props";
      this.props.Size = new System.Drawing.Size(772, 210);
      this.props.TabIndex = 1;
      // 
      // 
      // 
      this.props.ToolStrip.AccessibleName = "Property Grid";
      this.props.ToolStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar;
      this.props.ToolStrip.AllowMerge = false;
      this.props.ToolStrip.AutoSize = false;
      this.props.ToolStrip.CanOverflow = false;
      this.props.ToolStrip.Dock = System.Windows.Forms.DockStyle.None;
      this.props.ToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
      this.props.ToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.props.ToolStrip.Location = new System.Drawing.Point(0, 1);
      this.props.ToolStrip.Name = "";
      this.props.ToolStrip.Padding = new System.Windows.Forms.Padding(21, 0, 14, 0);
      this.props.ToolStrip.Size = new System.Drawing.Size(772, 31);
      this.props.ToolStrip.TabIndex = 1;
      this.props.ToolStrip.TabStop = true;
      this.props.ToolStrip.Text = "PropertyGridToolBar";
      this.props.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.props_PropertyValueChanged);
      // 
      // splitContainer1
      // 
      this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer1.Location = new System.Drawing.Point(0, 60);
      this.splitContainer1.Name = "splitContainer1";
      // 
      // splitContainer1.Panel1
      // 
      this.splitContainer1.Panel1.Controls.Add(this.panel2);
      this.splitContainer1.Panel1.Controls.Add(this.tvBuilder);
      // 
      // splitContainer1.Panel2
      // 
      this.splitContainer1.Panel2.Controls.Add(this.tabControl2);
      this.splitContainer1.Size = new System.Drawing.Size(772, 536);
      this.splitContainer1.SplitterDistance = 257;
      this.splitContainer1.TabIndex = 3;
      // 
      // tabControl2
      // 
      this.tabControl2.Controls.Add(this.tabPage3);
      this.tabControl2.Controls.Add(this.tabPage4);
      this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tabControl2.Location = new System.Drawing.Point(0, 0);
      this.tabControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.tabControl2.Name = "tabControl2";
      this.tabControl2.SelectedIndex = 0;
      this.tabControl2.Size = new System.Drawing.Size(511, 536);
      this.tabControl2.TabIndex = 4;
      this.tabControl2.SelectedIndexChanged += new System.EventHandler(this.tabControl2_SelectedIndexChanged);
      // 
      // tabPage3
      // 
      this.tabPage3.Controls.Add(this.edOutput);
      this.tabPage3.Location = new System.Drawing.Point(4, 32);
      this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.tabPage3.Name = "tabPage3";
      this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.tabPage3.Size = new System.Drawing.Size(503, 500);
      this.tabPage3.TabIndex = 0;
      this.tabPage3.Text = "Ouput";
      this.tabPage3.UseVisualStyleBackColor = true;
      // 
      // edOutput
      // 
      this.edOutput.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
      this.edOutput.AutoIndentCharsPatterns = "";
      this.edOutput.AutoScrollMinSize = new System.Drawing.Size(0, 21);
      this.edOutput.BackBrush = null;
      this.edOutput.CharHeight = 19;
      this.edOutput.CharWidth = 10;
      this.edOutput.CommentPrefix = "--";
      this.edOutput.ContextMenuStrip = this.contextMenuStrip2;
      this.edOutput.Cursor = System.Windows.Forms.Cursors.IBeam;
      this.edOutput.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
      this.edOutput.Dock = System.Windows.Forms.DockStyle.Fill;
      this.edOutput.Font = new System.Drawing.Font("Courier New", 10.2F);
      this.edOutput.IsReplaceMode = false;
      this.edOutput.LeftBracket = '(';
      this.edOutput.Location = new System.Drawing.Point(3, 4);
      this.edOutput.Name = "edOutput";
      this.edOutput.Paddings = new System.Windows.Forms.Padding(0, 2, 0, 0);
      this.edOutput.RightBracket = ')';
      this.edOutput.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
      this.edOutput.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("edOutput.ServiceColors")));
      this.edOutput.Size = new System.Drawing.Size(497, 492);
      this.edOutput.TabIndex = 0;
      this.edOutput.WordWrap = true;
      this.edOutput.Zoom = 100;
      // 
      // tabPage4
      // 
      this.tabPage4.Controls.Add(this.edInput);
      this.tabPage4.Location = new System.Drawing.Point(4, 32);
      this.tabPage4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.tabPage4.Name = "tabPage4";
      this.tabPage4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.tabPage4.Size = new System.Drawing.Size(758, 576);
      this.tabPage4.TabIndex = 1;
      this.tabPage4.Text = "Input";
      this.tabPage4.UseVisualStyleBackColor = true;
      // 
      // edInput
      // 
      this.edInput.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
      this.edInput.AutoIndentCharsPatterns = "\r\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;]+);\r\n^\\s*(case|default)\\s*[^:]" +
    "*(?<range>:)\\s*(?<range>[^;]+);\r\n";
      this.edInput.AutoScrollMinSize = new System.Drawing.Size(2, 21);
      this.edInput.BackBrush = null;
      this.edInput.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
      this.edInput.CharHeight = 19;
      this.edInput.CharWidth = 10;
      this.edInput.ContextMenuStrip = this.contextMenuStrip2;
      this.edInput.Cursor = System.Windows.Forms.Cursors.IBeam;
      this.edInput.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
      this.edInput.Dock = System.Windows.Forms.DockStyle.Fill;
      this.edInput.Font = new System.Drawing.Font("Courier New", 10.2F);
      this.edInput.IsReplaceMode = false;
      this.edInput.LeftBracket = '(';
      this.edInput.LeftBracket2 = '{';
      this.edInput.Location = new System.Drawing.Point(3, 4);
      this.edInput.Name = "edInput";
      this.edInput.Paddings = new System.Windows.Forms.Padding(0, 2, 0, 0);
      this.edInput.RightBracket = ')';
      this.edInput.RightBracket2 = '}';
      this.edInput.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
      this.edInput.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("edInput.ServiceColors")));
      this.edInput.Size = new System.Drawing.Size(752, 568);
      this.edInput.TabIndex = 0;
      this.edInput.Zoom = 100;
      // 
      // tvBuilder
      // 
      this.tvBuilder.AllowDrop = true;
      this.tvBuilder.ContextMenuStrip = this.contextMenuStrip1;
      this.tvBuilder.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.tvBuilder.ImageIndex = 0;
      this.tvBuilder.ImageList = this.imageList1;
      this.tvBuilder.Location = new System.Drawing.Point(0, -51);
      this.tvBuilder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.tvBuilder.Name = "tvBuilder";
      this.tvBuilder.SelectedImageIndex = 0;
      this.tvBuilder.Size = new System.Drawing.Size(257, 587);
      this.tvBuilder.TabIndex = 3;
      this.tvBuilder.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.tvBuilder_BeforeExpand);
      this.tvBuilder.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvBuilder_AfterSelect);
      this.tvBuilder.DragDrop += new System.Windows.Forms.DragEventHandler(this.tvBuilder_DragDrop);
      this.tvBuilder.DragEnter += new System.Windows.Forms.DragEventHandler(this.tvBuilder_DragEnter);
      this.tvBuilder.DragOver += new System.Windows.Forms.DragEventHandler(this.tvBuilder_DragOver);
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.cbPrompt);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel2.Location = new System.Drawing.Point(0, 0);
      this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(257, 28);
      this.panel2.TabIndex = 4;
      // 
      // parseToolStripMenuItem
      // 
      this.parseToolStripMenuItem.Name = "parseToolStripMenuItem";
      this.parseToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
      this.parseToolStripMenuItem.Text = "Parse";
      this.parseToolStripMenuItem.Click += new System.EventHandler(this.btnInput_Click);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(17, 19);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(55, 23);
      this.label3.TabIndex = 3;
      this.label3.Text = "label3";
      // 
      // btnPaste
      // 
      this.btnPaste.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnPaste.Location = new System.Drawing.Point(160, 11);
      this.btnPaste.Name = "btnPaste";
      this.btnPaste.Size = new System.Drawing.Size(69, 39);
      this.btnPaste.TabIndex = 5;
      this.btnPaste.Text = "Paste";
      this.btnPaste.UseVisualStyleBackColor = true;
      this.btnPaste.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
      // 
      // btnClear
      // 
      this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnClear.Location = new System.Drawing.Point(78, 12);
      this.btnClear.Name = "btnClear";
      this.btnClear.Size = new System.Drawing.Size(77, 38);
      this.btnClear.TabIndex = 4;
      this.btnClear.Text = "Clear";
      this.btnClear.UseVisualStyleBackColor = true;
      this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
      // 
      // btnInput
      // 
      this.btnInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnInput.Location = new System.Drawing.Point(3, 12);
      this.btnInput.Name = "btnInput";
      this.btnInput.Size = new System.Drawing.Size(69, 39);
      this.btnInput.TabIndex = 3;
      this.btnInput.Text = "Parse";
      this.btnInput.UseVisualStyleBackColor = true;
      this.btnInput.Visible = false;
      this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
      // 
      // cbPrompt
      // 
      this.cbPrompt.AutoSize = true;
      this.cbPrompt.Checked = true;
      this.cbPrompt.CheckState = System.Windows.Forms.CheckState.Checked;
      this.cbPrompt.Location = new System.Drawing.Point(20, -1);
      this.cbPrompt.Name = "cbPrompt";
      this.cbPrompt.Size = new System.Drawing.Size(164, 27);
      this.cbPrompt.TabIndex = 0;
      this.cbPrompt.Text = "Generate Prompt";
      this.cbPrompt.UseVisualStyleBackColor = true;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1022, 854);
      this.Controls.Add(this.tabControl1);
      this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.Name = "Form1";
      this.Text = "Prompter";
      this.Shown += new System.EventHandler(this.Form1_Shown);
      this.Resize += new System.EventHandler(this.Form1_Resize);
      this.tabControl1.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      this.tabPage1.PerformLayout();
      this.tabPage2.ResumeLayout(false);
      this.scRoot.Panel1.ResumeLayout(false);
      this.scRoot.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.scRoot)).EndInit();
      this.scRoot.ResumeLayout(false);
      this.panel1.ResumeLayout(false);
      this.scRoot2.Panel1.ResumeLayout(false);
      this.scRoot2.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.scRoot2)).EndInit();
      this.scRoot2.ResumeLayout(false);
      this.contextMenuStrip1.ResumeLayout(false);
      this.contextMenuStrip2.ResumeLayout(false);
      this.panel3.ResumeLayout(false);
      this.panel3.PerformLayout();
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
      this.splitContainer1.ResumeLayout(false);
      this.tabControl2.ResumeLayout(false);
      this.tabPage3.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.edOutput)).EndInit();
      this.tabPage4.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.edInput)).EndInit();
      this.panel2.ResumeLayout(false);
      this.panel2.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tabPage1;
    private System.Windows.Forms.TabPage tabPage2;
    private System.Windows.Forms.SplitContainer scRoot;
    private System.Windows.Forms.TreeView tvTools;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.SplitContainer scRoot2;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox edPassword;
    private System.Windows.Forms.TextBox edFileName;
    private System.Windows.Forms.OpenFileDialog odMain;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.TextBox edError;
    private System.Windows.Forms.ImageList imageList1;
    private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
    private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
    private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
    private System.Windows.Forms.Panel panel3;
    private PropertyGridEx.PropertyGridEx props;
    private System.Windows.Forms.SplitContainer splitContainer1;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.TreeView tvBuilder;
    private System.Windows.Forms.TabControl tabControl2;
    private System.Windows.Forms.TabPage tabPage3;
    private FastColoredTextBoxNS.FastColoredTextBox edOutput;
    private System.Windows.Forms.TabPage tabPage4;
    private FastColoredTextBoxNS.FastColoredTextBox edInput;
    private System.Windows.Forms.ToolStripMenuItem parseToolStripMenuItem;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Button btnPaste;
    private System.Windows.Forms.Button btnClear;
    private System.Windows.Forms.Button btnInput;
    private System.Windows.Forms.CheckBox cbPrompt;
  }
}

