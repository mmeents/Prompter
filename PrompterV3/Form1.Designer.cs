namespace PrompterV3 {
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
      this.btnBuild = new System.Windows.Forms.Button();
      this.pb2 = new System.Windows.Forms.ProgressBar();
      this.btnBrowse = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.edFileName = new System.Windows.Forms.ComboBox();
      this.tabPage2 = new System.Windows.Forms.TabPage();
      this.panel4 = new System.Windows.Forms.Panel();
      this.lbFocus = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.splitContainer1 = new System.Windows.Forms.SplitContainer();
      this.splitContainer2 = new System.Windows.Forms.SplitContainer();
      this.tvBuilder = new System.Windows.Forms.TreeView();
      this.msBuilder = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.addTemplateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.projectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.essayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.templateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.moveUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.moveDownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
      this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.imageList1 = new System.Windows.Forms.ImageList(this.components);
      this.panel1 = new System.Windows.Forms.Panel();
      this.pbMain = new System.Windows.Forms.ProgressBar();
      this.tabControl3 = new System.Windows.Forms.TabControl();
      this.tabPage5 = new System.Windows.Forms.TabPage();
      this.edInput = new FastColoredTextBoxNS.FastColoredTextBox();
      this.msEditors = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.parseInputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.asTemplateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.asEssayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.asEssayTopicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.asThesisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.asThesisClaimsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.AsClaimsEvidenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.tabPage6 = new System.Windows.Forms.TabPage();
      this.edOutputText = new FastColoredTextBoxNS.FastColoredTextBox();
      this.tabPage7 = new System.Windows.Forms.TabPage();
      this.wbOut = new System.Windows.Forms.WebBrowser();
      this.tabControl2 = new System.Windows.Forms.TabControl();
      this.tabPage3 = new System.Windows.Forms.TabPage();
      this.props = new PropertyGridEx.PropertyGridEx();
      this.tabPage4 = new System.Windows.Forms.TabPage();
      this.edError2 = new System.Windows.Forms.TextBox();
      this.odMain = new System.Windows.Forms.OpenFileDialog();
      this.asThesisTopicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.lbFocusNotes = new System.Windows.Forms.Label();
      this.tabControl1.SuspendLayout();
      this.tabPage1.SuspendLayout();
      this.tabPage2.SuspendLayout();
      this.panel4.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
      this.splitContainer2.Panel1.SuspendLayout();
      this.splitContainer2.Panel2.SuspendLayout();
      this.splitContainer2.SuspendLayout();
      this.msBuilder.SuspendLayout();
      this.panel1.SuspendLayout();
      this.tabControl3.SuspendLayout();
      this.tabPage5.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.edInput)).BeginInit();
      this.msEditors.SuspendLayout();
      this.tabPage6.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.edOutputText)).BeginInit();
      this.tabPage7.SuspendLayout();
      this.tabControl2.SuspendLayout();
      this.tabPage3.SuspendLayout();
      this.tabPage4.SuspendLayout();
      this.SuspendLayout();
      // 
      // tabControl1
      // 
      this.tabControl1.Controls.Add(this.tabPage1);
      this.tabControl1.Controls.Add(this.tabPage2);
      this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tabControl1.Location = new System.Drawing.Point(0, 0);
      this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.tabControl1.Multiline = true;
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(908, 608);
      this.tabControl1.TabIndex = 1;
      this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
      this.tabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Selecting);
      // 
      // tabPage1
      // 
      this.tabPage1.Controls.Add(this.edError);
      this.tabPage1.Controls.Add(this.btnBuild);
      this.tabPage1.Controls.Add(this.pb2);
      this.tabPage1.Controls.Add(this.btnBrowse);
      this.tabPage1.Controls.Add(this.label1);
      this.tabPage1.Controls.Add(this.edFileName);
      this.tabPage1.Location = new System.Drawing.Point(4, 29);
      this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.tabPage1.Size = new System.Drawing.Size(900, 575);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "Setup";
      this.tabPage1.UseVisualStyleBackColor = true;
      // 
      // edError
      // 
      this.edError.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.edError.Location = new System.Drawing.Point(12, 156);
      this.edError.Multiline = true;
      this.edError.Name = "edError";
      this.edError.Size = new System.Drawing.Size(877, 411);
      this.edError.TabIndex = 16;
      this.edError.Visible = false;
      this.edError.WordWrap = false;
      // 
      // btnBuild
      // 
      this.btnBuild.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.btnBuild.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
      this.btnBuild.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
      this.btnBuild.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
      this.btnBuild.Location = new System.Drawing.Point(155, 69);
      this.btnBuild.Name = "btnBuild";
      this.btnBuild.Size = new System.Drawing.Size(111, 45);
      this.btnBuild.TabIndex = 13;
      this.btnBuild.Text = "Open File";
      this.btnBuild.UseVisualStyleBackColor = false;
      this.btnBuild.Click += new System.EventHandler(this.btnBuild_Click);
      // 
      // pb2
      // 
      this.pb2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.pb2.ForeColor = System.Drawing.Color.Blue;
      this.pb2.Location = new System.Drawing.Point(155, 83);
      this.pb2.Maximum = 10000;
      this.pb2.Name = "pb2";
      this.pb2.Size = new System.Drawing.Size(655, 31);
      this.pb2.TabIndex = 12;
      this.pb2.Value = 500;
      this.pb2.Visible = false;
      // 
      // btnBrowse
      // 
      this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnBrowse.Location = new System.Drawing.Point(814, 14);
      this.btnBrowse.Name = "btnBrowse";
      this.btnBrowse.Size = new System.Drawing.Size(75, 31);
      this.btnBrowse.TabIndex = 4;
      this.btnBrowse.Text = "Browse";
      this.btnBrowse.UseVisualStyleBackColor = true;
      this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(8, 18);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(141, 20);
      this.label1.TabIndex = 3;
      this.label1.Text = "Project File to open:";
      // 
      // edFileName
      // 
      this.edFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.edFileName.FormattingEnabled = true;
      this.edFileName.Location = new System.Drawing.Point(155, 15);
      this.edFileName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.edFileName.Name = "edFileName";
      this.edFileName.Size = new System.Drawing.Size(655, 28);
      this.edFileName.TabIndex = 2;
      // 
      // tabPage2
      // 
      this.tabPage2.Controls.Add(this.panel4);
      this.tabPage2.Controls.Add(this.splitContainer1);
      this.tabPage2.Location = new System.Drawing.Point(4, 29);
      this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.tabPage2.Size = new System.Drawing.Size(900, 575);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "Outline";
      this.tabPage2.UseVisualStyleBackColor = true;
      // 
      // panel4
      // 
      this.panel4.Controls.Add(this.lbFocusNotes);
      this.panel4.Controls.Add(this.lbFocus);
      this.panel4.Controls.Add(this.label2);
      this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel4.Location = new System.Drawing.Point(3, 4);
      this.panel4.Name = "panel4";
      this.panel4.Size = new System.Drawing.Size(894, 50);
      this.panel4.TabIndex = 1;
      // 
      // lbFocus
      // 
      this.lbFocus.AutoSize = true;
      this.lbFocus.Location = new System.Drawing.Point(83, 4);
      this.lbFocus.Name = "lbFocus";
      this.lbFocus.Size = new System.Drawing.Size(59, 20);
      this.lbFocus.TabIndex = 1;
      this.lbFocus.Text = "lbFocus";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(10, 4);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(66, 20);
      this.label2.TabIndex = 0;
      this.label2.Text = "Focused:";
      // 
      // splitContainer1
      // 
      this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.splitContainer1.Location = new System.Drawing.Point(3, 49);
      this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.splitContainer1.Name = "splitContainer1";
      this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
      // 
      // splitContainer1.Panel1
      // 
      this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
      // 
      // splitContainer1.Panel2
      // 
      this.splitContainer1.Panel2.Controls.Add(this.tabControl2);
      this.splitContainer1.Panel2.Resize += new System.EventHandler(this.Form1_Resize);
      this.splitContainer1.Size = new System.Drawing.Size(891, 522);
      this.splitContainer1.SplitterDistance = 327;
      this.splitContainer1.TabIndex = 0;
      this.splitContainer1.Resize += new System.EventHandler(this.Form1_Resize);
      // 
      // splitContainer2
      // 
      this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer2.Location = new System.Drawing.Point(0, 0);
      this.splitContainer2.Name = "splitContainer2";
      // 
      // splitContainer2.Panel1
      // 
      this.splitContainer2.Panel1.Controls.Add(this.tvBuilder);
      this.splitContainer2.Panel1.Controls.Add(this.panel1);
      // 
      // splitContainer2.Panel2
      // 
      this.splitContainer2.Panel2.Controls.Add(this.tabControl3);
      this.splitContainer2.Panel2.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
      this.splitContainer2.Size = new System.Drawing.Size(891, 327);
      this.splitContainer2.SplitterDistance = 393;
      this.splitContainer2.TabIndex = 0;
      // 
      // tvBuilder
      // 
      this.tvBuilder.AllowDrop = true;
      this.tvBuilder.ContextMenuStrip = this.msBuilder;
      this.tvBuilder.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.tvBuilder.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tvBuilder.FullRowSelect = true;
      this.tvBuilder.HideSelection = false;
      this.tvBuilder.ImageIndex = 0;
      this.tvBuilder.ImageList = this.imageList1;
      this.tvBuilder.LabelEdit = true;
      this.tvBuilder.Location = new System.Drawing.Point(0, 37);
      this.tvBuilder.Name = "tvBuilder";
      this.tvBuilder.SelectedImageIndex = 0;
      this.tvBuilder.Size = new System.Drawing.Size(393, 290);
      this.tvBuilder.TabIndex = 1;
      this.tvBuilder.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.tvBuilder_AfterLabelEdit);
      this.tvBuilder.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.tvBuilder_BeforeExpand);
      this.tvBuilder.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.tvBuilder_ItemDrag);
      this.tvBuilder.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvBuilder_AfterSelect);
      this.tvBuilder.DragDrop += new System.Windows.Forms.DragEventHandler(this.tvBuilder_DragDrop);
      this.tvBuilder.DragEnter += new System.Windows.Forms.DragEventHandler(this.tvBuilder_DragEnter);
      this.tvBuilder.DragOver += new System.Windows.Forms.DragEventHandler(this.tvBuilder_DragOver);
      // 
      // msBuilder
      // 
      this.msBuilder.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.msBuilder.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTemplateToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.moveUpToolStripMenuItem,
            this.moveDownToolStripMenuItem,
            this.toolStripMenuItem1,
            this.deleteToolStripMenuItem});
      this.msBuilder.Name = "contextMenuStrip1";
      this.msBuilder.Size = new System.Drawing.Size(159, 130);
      this.msBuilder.Opening += new System.ComponentModel.CancelEventHandler(this.msBuilder_Opening);
      // 
      // addTemplateToolStripMenuItem
      // 
      this.addTemplateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projectToolStripMenuItem,
            this.essayToolStripMenuItem,
            this.templateToolStripMenuItem});
      this.addTemplateToolStripMenuItem.Name = "addTemplateToolStripMenuItem";
      this.addTemplateToolStripMenuItem.Size = new System.Drawing.Size(158, 24);
      this.addTemplateToolStripMenuItem.Text = "Add";
      this.addTemplateToolStripMenuItem.Click += new System.EventHandler(this.addTemplateToolStripMenuItem_Click);
      // 
      // projectToolStripMenuItem
      // 
      this.projectToolStripMenuItem.Name = "projectToolStripMenuItem";
      this.projectToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
      this.projectToolStripMenuItem.Text = "Project";
      this.projectToolStripMenuItem.Click += new System.EventHandler(this.projectToolStripMenuItem_Click);
      // 
      // essayToolStripMenuItem
      // 
      this.essayToolStripMenuItem.Name = "essayToolStripMenuItem";
      this.essayToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
      this.essayToolStripMenuItem.Text = "Essay";
      this.essayToolStripMenuItem.Click += new System.EventHandler(this.essayToolStripMenuItem_Click);
      // 
      // templateToolStripMenuItem
      // 
      this.templateToolStripMenuItem.Name = "templateToolStripMenuItem";
      this.templateToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
      this.templateToolStripMenuItem.Text = "Template";
      this.templateToolStripMenuItem.Click += new System.EventHandler(this.templateToolStripMenuItem_Click);
      // 
      // saveToolStripMenuItem
      // 
      this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
      this.saveToolStripMenuItem.Size = new System.Drawing.Size(158, 24);
      this.saveToolStripMenuItem.Text = "Save";
      this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
      // 
      // moveUpToolStripMenuItem
      // 
      this.moveUpToolStripMenuItem.Name = "moveUpToolStripMenuItem";
      this.moveUpToolStripMenuItem.Size = new System.Drawing.Size(158, 24);
      this.moveUpToolStripMenuItem.Text = "Move Up";
      this.moveUpToolStripMenuItem.Click += new System.EventHandler(this.moveUpToolStripMenuItem_Click);
      // 
      // moveDownToolStripMenuItem
      // 
      this.moveDownToolStripMenuItem.Name = "moveDownToolStripMenuItem";
      this.moveDownToolStripMenuItem.Size = new System.Drawing.Size(158, 24);
      this.moveDownToolStripMenuItem.Text = "Move Down";
      this.moveDownToolStripMenuItem.Click += new System.EventHandler(this.moveDownToolStripMenuItem_Click);
      // 
      // toolStripMenuItem1
      // 
      this.toolStripMenuItem1.Name = "toolStripMenuItem1";
      this.toolStripMenuItem1.Size = new System.Drawing.Size(155, 6);
      // 
      // deleteToolStripMenuItem
      // 
      this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
      this.deleteToolStripMenuItem.Size = new System.Drawing.Size(158, 24);
      this.deleteToolStripMenuItem.Text = "Delete";
      this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
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
      this.panel1.Controls.Add(this.pbMain);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(393, 31);
      this.panel1.TabIndex = 0;
      // 
      // pbMain
      // 
      this.pbMain.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pbMain.ForeColor = System.Drawing.Color.Blue;
      this.pbMain.Location = new System.Drawing.Point(0, 0);
      this.pbMain.Maximum = 10000;
      this.pbMain.Name = "pbMain";
      this.pbMain.Size = new System.Drawing.Size(393, 31);
      this.pbMain.TabIndex = 11;
      this.pbMain.Value = 500;
      this.pbMain.Visible = false;
      // 
      // tabControl3
      // 
      this.tabControl3.Controls.Add(this.tabPage5);
      this.tabControl3.Controls.Add(this.tabPage6);
      this.tabControl3.Controls.Add(this.tabPage7);
      this.tabControl3.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tabControl3.Location = new System.Drawing.Point(0, 6);
      this.tabControl3.Name = "tabControl3";
      this.tabControl3.SelectedIndex = 0;
      this.tabControl3.Size = new System.Drawing.Size(494, 321);
      this.tabControl3.TabIndex = 0;
      this.tabControl3.Resize += new System.EventHandler(this.Form1_Resize);
      // 
      // tabPage5
      // 
      this.tabPage5.Controls.Add(this.edInput);
      this.tabPage5.Location = new System.Drawing.Point(4, 29);
      this.tabPage5.Margin = new System.Windows.Forms.Padding(0);
      this.tabPage5.Name = "tabPage5";
      this.tabPage5.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
      this.tabPage5.Size = new System.Drawing.Size(486, 288);
      this.tabPage5.TabIndex = 0;
      this.tabPage5.Text = "Input Text";
      this.tabPage5.UseVisualStyleBackColor = true;
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
      this.edInput.AutoScrollMinSize = new System.Drawing.Size(31, 18);
      this.edInput.BackBrush = null;
      this.edInput.CharHeight = 18;
      this.edInput.CharWidth = 10;
      this.edInput.ContextMenuStrip = this.msEditors;
      this.edInput.Cursor = System.Windows.Forms.Cursors.IBeam;
      this.edInput.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
      this.edInput.Dock = System.Windows.Forms.DockStyle.Fill;
      this.edInput.Font = new System.Drawing.Font("Courier New", 9.75F);
      this.edInput.IsReplaceMode = false;
      this.edInput.Location = new System.Drawing.Point(0, 3);
      this.edInput.Name = "edInput";
      this.edInput.Paddings = new System.Windows.Forms.Padding(0);
      this.edInput.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
      this.edInput.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("edInput.ServiceColors")));
      this.edInput.Size = new System.Drawing.Size(486, 285);
      this.edInput.TabIndex = 0;
      this.edInput.Zoom = 100;
      // 
      // msEditors
      // 
      this.msEditors.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.msEditors.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.parseInputToolStripMenuItem});
      this.msEditors.Name = "msEditors";
      this.msEditors.Size = new System.Drawing.Size(151, 100);
      this.msEditors.Opening += new System.ComponentModel.CancelEventHandler(this.msEditors_Opening);
      // 
      // copyToolStripMenuItem
      // 
      this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
      this.copyToolStripMenuItem.Size = new System.Drawing.Size(150, 24);
      this.copyToolStripMenuItem.Text = "Copy";
      this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
      // 
      // pasteToolStripMenuItem
      // 
      this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
      this.pasteToolStripMenuItem.Size = new System.Drawing.Size(150, 24);
      this.pasteToolStripMenuItem.Text = "Paste";
      this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
      // 
      // clearToolStripMenuItem
      // 
      this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
      this.clearToolStripMenuItem.Size = new System.Drawing.Size(150, 24);
      this.clearToolStripMenuItem.Text = "Clear";
      this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
      // 
      // parseInputToolStripMenuItem
      // 
      this.parseInputToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asTemplateToolStripMenuItem,
            this.asEssayToolStripMenuItem,
            this.asEssayTopicToolStripMenuItem,
            this.asThesisToolStripMenuItem,
            this.asThesisTopicToolStripMenuItem,
            this.asThesisClaimsToolStripMenuItem,
            this.AsClaimsEvidenceToolStripMenuItem});
      this.parseInputToolStripMenuItem.Name = "parseInputToolStripMenuItem";
      this.parseInputToolStripMenuItem.Size = new System.Drawing.Size(150, 24);
      this.parseInputToolStripMenuItem.Text = "Parse Input";
      this.parseInputToolStripMenuItem.Click += new System.EventHandler(this.parseInputToolStripMenuItem_Click);
      // 
      // asTemplateToolStripMenuItem
      // 
      this.asTemplateToolStripMenuItem.Name = "asTemplateToolStripMenuItem";
      this.asTemplateToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
      this.asTemplateToolStripMenuItem.Text = "As Template";
      this.asTemplateToolStripMenuItem.Click += new System.EventHandler(this.asTemplateToolStripMenuItem_Click);
      // 
      // asEssayToolStripMenuItem
      // 
      this.asEssayToolStripMenuItem.Name = "asEssayToolStripMenuItem";
      this.asEssayToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
      this.asEssayToolStripMenuItem.Text = "As Essay";
      this.asEssayToolStripMenuItem.Click += new System.EventHandler(this.asEssayToolStripMenuItem_Click);
      // 
      // asEssayTopicToolStripMenuItem
      // 
      this.asEssayTopicToolStripMenuItem.Name = "asEssayTopicToolStripMenuItem";
      this.asEssayTopicToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
      this.asEssayTopicToolStripMenuItem.Text = "As Essay Topic";
      this.asEssayTopicToolStripMenuItem.Click += new System.EventHandler(this.asEssayTopicToolStripMenuItem_Click);
      // 
      // asThesisToolStripMenuItem
      // 
      this.asThesisToolStripMenuItem.Name = "asThesisToolStripMenuItem";
      this.asThesisToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
      this.asThesisToolStripMenuItem.Text = "As Thesis";
      this.asThesisToolStripMenuItem.Click += new System.EventHandler(this.asThesisToolStripMenuItem_Click);
      // 
      // asThesisClaimsToolStripMenuItem
      // 
      this.asThesisClaimsToolStripMenuItem.Name = "asThesisClaimsToolStripMenuItem";
      this.asThesisClaimsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
      this.asThesisClaimsToolStripMenuItem.Text = "As Thesis Claims";
      this.asThesisClaimsToolStripMenuItem.Click += new System.EventHandler(this.asThesisClaimsToolStripMenuItem_Click);
      // 
      // AsClaimsEvidenceToolStripMenuItem
      // 
      this.AsClaimsEvidenceToolStripMenuItem.Name = "AsClaimsEvidenceToolStripMenuItem";
      this.AsClaimsEvidenceToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
      this.AsClaimsEvidenceToolStripMenuItem.Text = "As Claims Evidence";
      this.AsClaimsEvidenceToolStripMenuItem.Click += new System.EventHandler(this.AsClaimsEvidenceToolStripMenuItem_Click);
      // 
      // tabPage6
      // 
      this.tabPage6.Controls.Add(this.edOutputText);
      this.tabPage6.Location = new System.Drawing.Point(4, 29);
      this.tabPage6.Margin = new System.Windows.Forms.Padding(0);
      this.tabPage6.Name = "tabPage6";
      this.tabPage6.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
      this.tabPage6.Size = new System.Drawing.Size(486, 288);
      this.tabPage6.TabIndex = 1;
      this.tabPage6.Text = "Output Text";
      this.tabPage6.UseVisualStyleBackColor = true;
      // 
      // edOutputText
      // 
      this.edOutputText.AutoCompleteBracketsList = new char[] {
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
      this.edOutputText.AutoScrollMinSize = new System.Drawing.Size(0, 18);
      this.edOutputText.BackBrush = null;
      this.edOutputText.CharHeight = 18;
      this.edOutputText.CharWidth = 10;
      this.edOutputText.ContextMenuStrip = this.msEditors;
      this.edOutputText.Cursor = System.Windows.Forms.Cursors.IBeam;
      this.edOutputText.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
      this.edOutputText.Dock = System.Windows.Forms.DockStyle.Fill;
      this.edOutputText.IsReplaceMode = false;
      this.edOutputText.Location = new System.Drawing.Point(0, 3);
      this.edOutputText.Name = "edOutputText";
      this.edOutputText.Paddings = new System.Windows.Forms.Padding(0);
      this.edOutputText.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
      this.edOutputText.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("edOutputText.ServiceColors")));
      this.edOutputText.Size = new System.Drawing.Size(486, 285);
      this.edOutputText.TabIndex = 0;
      this.edOutputText.WordWrap = true;
      this.edOutputText.Zoom = 100;
      // 
      // tabPage7
      // 
      this.tabPage7.Controls.Add(this.wbOut);
      this.tabPage7.Location = new System.Drawing.Point(4, 29);
      this.tabPage7.Name = "tabPage7";
      this.tabPage7.Size = new System.Drawing.Size(486, 288);
      this.tabPage7.TabIndex = 2;
      this.tabPage7.Text = "Browser";
      this.tabPage7.UseVisualStyleBackColor = true;
      // 
      // wbOut
      // 
      this.wbOut.Dock = System.Windows.Forms.DockStyle.Fill;
      this.wbOut.Location = new System.Drawing.Point(0, 0);
      this.wbOut.MinimumSize = new System.Drawing.Size(20, 20);
      this.wbOut.Name = "wbOut";
      this.wbOut.Size = new System.Drawing.Size(486, 288);
      this.wbOut.TabIndex = 0;
      // 
      // tabControl2
      // 
      this.tabControl2.Alignment = System.Windows.Forms.TabAlignment.Bottom;
      this.tabControl2.Controls.Add(this.tabPage3);
      this.tabControl2.Controls.Add(this.tabPage4);
      this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tabControl2.Location = new System.Drawing.Point(0, 0);
      this.tabControl2.Name = "tabControl2";
      this.tabControl2.SelectedIndex = 0;
      this.tabControl2.Size = new System.Drawing.Size(891, 191);
      this.tabControl2.TabIndex = 0;
      // 
      // tabPage3
      // 
      this.tabPage3.Controls.Add(this.props);
      this.tabPage3.Location = new System.Drawing.Point(4, 4);
      this.tabPage3.Name = "tabPage3";
      this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage3.Size = new System.Drawing.Size(883, 158);
      this.tabPage3.TabIndex = 0;
      this.tabPage3.Text = "Properties";
      this.tabPage3.UseVisualStyleBackColor = true;
      // 
      // props
      // 
      // 
      // 
      // 
      this.props.DocCommentDescription.AutoEllipsis = true;
      this.props.DocCommentDescription.Cursor = System.Windows.Forms.Cursors.Default;
      this.props.DocCommentDescription.Location = new System.Drawing.Point(4, 32);
      this.props.DocCommentDescription.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
      this.props.DocCommentDescription.Name = "";
      this.props.DocCommentDescription.Size = new System.Drawing.Size(0, 61);
      this.props.DocCommentDescription.TabIndex = 1;
      this.props.DocCommentImage = null;
      // 
      // 
      // 
      this.props.DocCommentTitle.Cursor = System.Windows.Forms.Cursors.Default;
      this.props.DocCommentTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
      this.props.DocCommentTitle.Location = new System.Drawing.Point(4, 5);
      this.props.DocCommentTitle.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
      this.props.DocCommentTitle.Name = "";
      this.props.DocCommentTitle.Size = new System.Drawing.Size(0, 22);
      this.props.DocCommentTitle.TabIndex = 0;
      this.props.DocCommentTitle.UseMnemonic = false;
      this.props.Dock = System.Windows.Forms.DockStyle.Fill;
      this.props.HelpVisible = false;
      this.props.Location = new System.Drawing.Point(3, 3);
      this.props.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.props.Name = "props";
      this.props.Size = new System.Drawing.Size(877, 152);
      this.props.TabIndex = 0;
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
      this.props.ToolStrip.Padding = new System.Windows.Forms.Padding(5, 0, 1, 0);
      this.props.ToolStrip.Size = new System.Drawing.Size(877, 31);
      this.props.ToolStrip.TabIndex = 1;
      this.props.ToolStrip.TabStop = true;
      this.props.ToolStrip.Text = "PropertyGridToolBar";
      this.props.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.props_PropertyValueChanged);
      // 
      // tabPage4
      // 
      this.tabPage4.Controls.Add(this.edError2);
      this.tabPage4.Location = new System.Drawing.Point(4, 4);
      this.tabPage4.Name = "tabPage4";
      this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage4.Size = new System.Drawing.Size(883, 219);
      this.tabPage4.TabIndex = 1;
      this.tabPage4.Text = "Log";
      this.tabPage4.UseVisualStyleBackColor = true;
      // 
      // edError2
      // 
      this.edError2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.edError2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.edError2.Location = new System.Drawing.Point(3, 3);
      this.edError2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.edError2.Multiline = true;
      this.edError2.Name = "edError2";
      this.edError2.Size = new System.Drawing.Size(877, 213);
      this.edError2.TabIndex = 2;
      // 
      // odMain
      // 
      this.odMain.CheckFileExists = false;
      this.odMain.DefaultExt = "pv3";
      this.odMain.Filter = "PrompterV3|*.pv3";
      this.odMain.Title = "Open Archive";
      // 
      // asThesisTopicToolStripMenuItem
      // 
      this.asThesisTopicToolStripMenuItem.Name = "asThesisTopicToolStripMenuItem";
      this.asThesisTopicToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
      this.asThesisTopicToolStripMenuItem.Text = "As Essay Thesis Topic";
      this.asThesisTopicToolStripMenuItem.Click += new System.EventHandler(this.asThesisTopicToolStripMenuItem_Click);
      // 
      // lbFocusNotes
      // 
      this.lbFocusNotes.AutoSize = true;
      this.lbFocusNotes.Location = new System.Drawing.Point(10, 24);
      this.lbFocusNotes.Name = "lbFocusNotes";
      this.lbFocusNotes.Size = new System.Drawing.Size(89, 20);
      this.lbFocusNotes.TabIndex = 2;
      this.lbFocusNotes.Text = "Focus Notes";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(908, 608);
      this.Controls.Add(this.tabControl1);
      this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.Name = "Form1";
      this.Text = "PrompterV3";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
      this.Shown += new System.EventHandler(this.Form1_Shown);
      this.Resize += new System.EventHandler(this.Form1_Resize);
      this.tabControl1.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      this.tabPage1.PerformLayout();
      this.tabPage2.ResumeLayout(false);
      this.panel4.ResumeLayout(false);
      this.panel4.PerformLayout();
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
      this.splitContainer1.ResumeLayout(false);
      this.splitContainer2.Panel1.ResumeLayout(false);
      this.splitContainer2.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
      this.splitContainer2.ResumeLayout(false);
      this.msBuilder.ResumeLayout(false);
      this.panel1.ResumeLayout(false);
      this.tabControl3.ResumeLayout(false);
      this.tabPage5.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.edInput)).EndInit();
      this.msEditors.ResumeLayout(false);
      this.tabPage6.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.edOutputText)).EndInit();
      this.tabPage7.ResumeLayout(false);
      this.tabControl2.ResumeLayout(false);
      this.tabPage3.ResumeLayout(false);
      this.tabPage4.ResumeLayout(false);
      this.tabPage4.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion
    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tabPage1;
    private System.Windows.Forms.TabPage tabPage2;
    private System.Windows.Forms.SplitContainer splitContainer1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.ComboBox edFileName;
    private System.Windows.Forms.Panel panel4;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label lbFocus;
    private System.Windows.Forms.SplitContainer splitContainer2;
    private System.Windows.Forms.TabControl tabControl2;
    private System.Windows.Forms.TabPage tabPage3;
    private System.Windows.Forms.TabPage tabPage4;
    private PropertyGridEx.PropertyGridEx props;
    private System.Windows.Forms.TreeView tvBuilder;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.TabControl tabControl3;
    private System.Windows.Forms.TabPage tabPage5;
    private System.Windows.Forms.TabPage tabPage6;
    private System.Windows.Forms.Button btnBrowse;
    private System.Windows.Forms.TextBox edError2;
    private FastColoredTextBoxNS.FastColoredTextBox edInput;
    private FastColoredTextBoxNS.FastColoredTextBox edOutputText;
    private System.Windows.Forms.TabPage tabPage7;
    private System.Windows.Forms.ProgressBar pbMain;
    private System.Windows.Forms.OpenFileDialog odMain;
    private System.Windows.Forms.ProgressBar pb2;
    private System.Windows.Forms.Button btnBuild;
    private System.Windows.Forms.TextBox edError;
    private System.Windows.Forms.ImageList imageList1;
    private System.Windows.Forms.ContextMenuStrip msBuilder;
    private System.Windows.Forms.ToolStripMenuItem addTemplateToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem moveUpToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem moveDownToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    private System.Windows.Forms.WebBrowser wbOut;
    private System.Windows.Forms.ContextMenuStrip msEditors;
    private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem parseInputToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem asTemplateToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem essayToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem projectToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem templateToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem asEssayToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem asEssayTopicToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem asThesisToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem asThesisClaimsToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem AsClaimsEvidenceToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem asThesisTopicToolStripMenuItem;
    private System.Windows.Forms.Label lbFocusNotes;
  }
}

