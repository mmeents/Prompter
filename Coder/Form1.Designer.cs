namespace Prompter {
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
      this.edFileName = new System.Windows.Forms.ComboBox();
      this.edError = new System.Windows.Forms.TextBox();
      this.btnBuild = new System.Windows.Forms.Button();
      this.button1 = new System.Windows.Forms.Button();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.edPassword = new System.Windows.Forms.TextBox();
      this.tabPage2 = new System.Windows.Forms.TabPage();
      this.scRoot = new System.Windows.Forms.SplitContainer();
      this.tvTools = new System.Windows.Forms.TreeView();
      this.imageList1 = new System.Windows.Forms.ImageList(this.components);
      this.panel1 = new System.Windows.Forms.Panel();
      this.cbPrompt = new System.Windows.Forms.CheckBox();
      this.scRoot2 = new System.Windows.Forms.SplitContainer();
      this.splitContainer1 = new System.Windows.Forms.SplitContainer();
      this.panel2 = new System.Windows.Forms.Panel();
      this.pbMain = new System.Windows.Forms.ProgressBar();
      this.tvBuilder = new System.Windows.Forms.TreeView();
      this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.addTemplateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.moveUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.moveDownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
      this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.tabControl2 = new System.Windows.Forms.TabControl();
      this.tabPage3 = new System.Windows.Forms.TabPage();
      this.edOutput = new FastColoredTextBoxNS.FastColoredTextBox();
      this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.parseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.tabPage4 = new System.Windows.Forms.TabPage();
      this.edInput = new FastColoredTextBoxNS.FastColoredTextBox();
      this.panel3 = new System.Windows.Forms.Panel();
      this.btnClear = new System.Windows.Forms.Button();
      this.btnPaste = new System.Windows.Forms.Button();
      this.btnParse = new System.Windows.Forms.Button();
      this.label4 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.props = new PropertyGridEx.PropertyGridEx();
      this.odMain = new System.Windows.Forms.OpenFileDialog();
      this.pb2 = new System.Windows.Forms.ProgressBar();
      this.tabPage5 = new System.Windows.Forms.TabPage();
      this.wbOut = new System.Windows.Forms.WebBrowser();
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
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      this.panel2.SuspendLayout();
      this.contextMenuStrip1.SuspendLayout();
      this.tabControl2.SuspendLayout();
      this.tabPage3.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.edOutput)).BeginInit();
      this.contextMenuStrip2.SuspendLayout();
      this.tabPage4.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.edInput)).BeginInit();
      this.panel3.SuspendLayout();
      this.tabPage5.SuspendLayout();
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
      this.tabControl1.Size = new System.Drawing.Size(1007, 854);
      this.tabControl1.TabIndex = 0;
      this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
      this.tabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Selecting);
      // 
      // tabPage1
      // 
      this.tabPage1.Controls.Add(this.pb2);
      this.tabPage1.Controls.Add(this.edFileName);
      this.tabPage1.Controls.Add(this.edError);
      this.tabPage1.Controls.Add(this.btnBuild);
      this.tabPage1.Controls.Add(this.button1);
      this.tabPage1.Controls.Add(this.label2);
      this.tabPage1.Controls.Add(this.label1);
      this.tabPage1.Controls.Add(this.edPassword);
      this.tabPage1.Location = new System.Drawing.Point(4, 32);
      this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.tabPage1.Size = new System.Drawing.Size(999, 818);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "Setup";
      this.tabPage1.UseVisualStyleBackColor = true;
      // 
      // edFileName
      // 
      this.edFileName.FormattingEnabled = true;
      this.edFileName.Location = new System.Drawing.Point(205, 54);
      this.edFileName.Name = "edFileName";
      this.edFileName.Size = new System.Drawing.Size(625, 31);
      this.edFileName.TabIndex = 7;
      this.edFileName.Text = "C:\\ProgramData\\MMCommons\\PrompterV101.cdf";
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
      // btnBuild
      // 
      this.btnBuild.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.btnBuild.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
      this.btnBuild.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
      this.btnBuild.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
      this.btnBuild.Location = new System.Drawing.Point(419, 274);
      this.btnBuild.Name = "btnBuild";
      this.btnBuild.Size = new System.Drawing.Size(111, 45);
      this.btnBuild.TabIndex = 5;
      this.btnBuild.Text = "Open File";
      this.btnBuild.UseVisualStyleBackColor = false;
      this.btnBuild.Click += new System.EventHandler(this.btnBuildOpen_Click);
      // 
      // button1
      // 
      this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
      this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
      this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
      this.button1.Location = new System.Drawing.Point(836, 55);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(109, 30);
      this.button1.TabIndex = 4;
      this.button1.Text = "Browse";
      this.button1.UseVisualStyleBackColor = false;
      this.button1.Click += new System.EventHandler(this.btnBrowse_Click);
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
      this.label1.Location = new System.Drawing.Point(40, 57);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(159, 23);
      this.label1.TabIndex = 2;
      this.label1.Text = "Prompter Data file: ";
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
      // tabPage2
      // 
      this.tabPage2.Controls.Add(this.scRoot);
      this.tabPage2.Location = new System.Drawing.Point(4, 32);
      this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.tabPage2.Size = new System.Drawing.Size(999, 818);
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
      this.scRoot.Size = new System.Drawing.Size(993, 810);
      this.scRoot.SplitterDistance = 229;
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
      this.tvTools.Size = new System.Drawing.Size(229, 722);
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
      this.panel1.Controls.Add(this.cbPrompt);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(229, 88);
      this.panel1.TabIndex = 0;
      // 
      // cbPrompt
      // 
      this.cbPrompt.AutoSize = true;
      this.cbPrompt.Checked = true;
      this.cbPrompt.CheckState = System.Windows.Forms.CheckState.Checked;
      this.cbPrompt.Location = new System.Drawing.Point(14, 15);
      this.cbPrompt.Name = "cbPrompt";
      this.cbPrompt.Size = new System.Drawing.Size(164, 27);
      this.cbPrompt.TabIndex = 1;
      this.cbPrompt.Text = "Generate Prompt";
      this.cbPrompt.UseVisualStyleBackColor = true;
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
      this.scRoot2.Size = new System.Drawing.Size(760, 810);
      this.scRoot2.SplitterDistance = 596;
      this.scRoot2.TabIndex = 0;
      this.scRoot2.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.scRoot2_SplitterMoved);
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
      this.splitContainer1.Size = new System.Drawing.Size(760, 536);
      this.splitContainer1.SplitterDistance = 253;
      this.splitContainer1.TabIndex = 3;
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.pbMain);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel2.Location = new System.Drawing.Point(0, 0);
      this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(253, 28);
      this.panel2.TabIndex = 4;
      // 
      // pbMain
      // 
      this.pbMain.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pbMain.ForeColor = System.Drawing.Color.Blue;
      this.pbMain.Location = new System.Drawing.Point(0, 0);
      this.pbMain.Maximum = 10000;
      this.pbMain.Name = "pbMain";
      this.pbMain.Size = new System.Drawing.Size(253, 28);
      this.pbMain.TabIndex = 10;
      this.pbMain.Value = 500;
      // 
      // tvBuilder
      // 
      this.tvBuilder.AllowDrop = true;
      this.tvBuilder.ContextMenuStrip = this.contextMenuStrip1;
      this.tvBuilder.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.tvBuilder.FullRowSelect = true;
      this.tvBuilder.HideSelection = false;
      this.tvBuilder.ImageIndex = 0;
      this.tvBuilder.ImageList = this.imageList1;
      this.tvBuilder.LabelEdit = true;
      this.tvBuilder.Location = new System.Drawing.Point(0, -51);
      this.tvBuilder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.tvBuilder.Name = "tvBuilder";
      this.tvBuilder.SelectedImageIndex = 0;
      this.tvBuilder.Size = new System.Drawing.Size(253, 587);
      this.tvBuilder.TabIndex = 3;
      this.tvBuilder.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.tvBuilder_AfterLabelEdit);
      this.tvBuilder.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.tvBuilder_BeforeExpand);
      this.tvBuilder.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.tvBuilder_ItemDrag);
      this.tvBuilder.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvBuilder_AfterSelect);
      this.tvBuilder.DragDrop += new System.Windows.Forms.DragEventHandler(this.tvBuilder_DragDrop);
      this.tvBuilder.DragEnter += new System.Windows.Forms.DragEventHandler(this.tvBuilder_DragEnter);
      this.tvBuilder.DragOver += new System.Windows.Forms.DragEventHandler(this.tvBuilder_DragOver);
      // 
      // contextMenuStrip1
      // 
      this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTemplateToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.moveUpToolStripMenuItem,
            this.moveDownToolStripMenuItem,
            this.toolStripMenuItem1,
            this.deleteToolStripMenuItem});
      this.contextMenuStrip1.Name = "contextMenuStrip1";
      this.contextMenuStrip1.Size = new System.Drawing.Size(173, 130);
      this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
      // 
      // addTemplateToolStripMenuItem
      // 
      this.addTemplateToolStripMenuItem.Name = "addTemplateToolStripMenuItem";
      this.addTemplateToolStripMenuItem.Size = new System.Drawing.Size(172, 24);
      this.addTemplateToolStripMenuItem.Text = "Add Template";
      this.addTemplateToolStripMenuItem.Click += new System.EventHandler(this.addTemplateToolStripMenuItem_Click);
      // 
      // saveToolStripMenuItem
      // 
      this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
      this.saveToolStripMenuItem.Size = new System.Drawing.Size(172, 24);
      this.saveToolStripMenuItem.Text = "Save";
      this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
      // 
      // moveUpToolStripMenuItem
      // 
      this.moveUpToolStripMenuItem.Name = "moveUpToolStripMenuItem";
      this.moveUpToolStripMenuItem.Size = new System.Drawing.Size(172, 24);
      this.moveUpToolStripMenuItem.Text = "Move Up";
      this.moveUpToolStripMenuItem.Click += new System.EventHandler(this.moveUpToolStripMenuItem_Click);
      // 
      // moveDownToolStripMenuItem
      // 
      this.moveDownToolStripMenuItem.Name = "moveDownToolStripMenuItem";
      this.moveDownToolStripMenuItem.Size = new System.Drawing.Size(172, 24);
      this.moveDownToolStripMenuItem.Text = "Move Down";
      this.moveDownToolStripMenuItem.Click += new System.EventHandler(this.moveDownToolStripMenuItem_Click);
      // 
      // toolStripMenuItem1
      // 
      this.toolStripMenuItem1.Name = "toolStripMenuItem1";
      this.toolStripMenuItem1.Size = new System.Drawing.Size(169, 6);
      // 
      // deleteToolStripMenuItem
      // 
      this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
      this.deleteToolStripMenuItem.Size = new System.Drawing.Size(172, 24);
      this.deleteToolStripMenuItem.Text = "Delete";
      this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
      // 
      // tabControl2
      // 
      this.tabControl2.Controls.Add(this.tabPage3);
      this.tabControl2.Controls.Add(this.tabPage4);
      this.tabControl2.Controls.Add(this.tabPage5);
      this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tabControl2.Location = new System.Drawing.Point(0, 0);
      this.tabControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.tabControl2.Name = "tabControl2";
      this.tabControl2.SelectedIndex = 0;
      this.tabControl2.Size = new System.Drawing.Size(503, 536);
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
      this.tabPage3.Size = new System.Drawing.Size(495, 500);
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
      this.edOutput.Size = new System.Drawing.Size(489, 492);
      this.edOutput.TabIndex = 0;
      this.edOutput.WordWrap = true;
      this.edOutput.Zoom = 100;
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
      this.contextMenuStrip2.Size = new System.Drawing.Size(151, 100);
      this.contextMenuStrip2.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip2_Opening);
      // 
      // clearToolStripMenuItem
      // 
      this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
      this.clearToolStripMenuItem.Size = new System.Drawing.Size(150, 24);
      this.clearToolStripMenuItem.Text = "Clear";
      this.clearToolStripMenuItem.Click += new System.EventHandler(this.btnClear_Click);
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
      // parseToolStripMenuItem
      // 
      this.parseToolStripMenuItem.Name = "parseToolStripMenuItem";
      this.parseToolStripMenuItem.Size = new System.Drawing.Size(150, 24);
      this.parseToolStripMenuItem.Text = "Parse Input";
      this.parseToolStripMenuItem.Click += new System.EventHandler(this.btnParse_Click);
      // 
      // tabPage4
      // 
      this.tabPage4.Controls.Add(this.edInput);
      this.tabPage4.Location = new System.Drawing.Point(4, 32);
      this.tabPage4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.tabPage4.Name = "tabPage4";
      this.tabPage4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.tabPage4.Size = new System.Drawing.Size(495, 500);
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
      this.edInput.Size = new System.Drawing.Size(489, 492);
      this.edInput.TabIndex = 0;
      this.edInput.Zoom = 100;
      // 
      // panel3
      // 
      this.panel3.Controls.Add(this.btnClear);
      this.panel3.Controls.Add(this.btnPaste);
      this.panel3.Controls.Add(this.btnParse);
      this.panel3.Controls.Add(this.label4);
      this.panel3.Controls.Add(this.label3);
      this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel3.Location = new System.Drawing.Point(0, 0);
      this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.panel3.Name = "panel3";
      this.panel3.Size = new System.Drawing.Size(760, 60);
      this.panel3.TabIndex = 2;
      // 
      // btnClear
      // 
      this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnClear.Location = new System.Drawing.Point(535, 12);
      this.btnClear.Name = "btnClear";
      this.btnClear.Size = new System.Drawing.Size(77, 38);
      this.btnClear.TabIndex = 7;
      this.btnClear.Text = "Clear";
      this.btnClear.UseVisualStyleBackColor = true;
      this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
      // 
      // btnPaste
      // 
      this.btnPaste.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnPaste.Location = new System.Drawing.Point(618, 12);
      this.btnPaste.Name = "btnPaste";
      this.btnPaste.Size = new System.Drawing.Size(69, 39);
      this.btnPaste.TabIndex = 6;
      this.btnPaste.Text = "Paste";
      this.btnPaste.UseVisualStyleBackColor = true;
      this.btnPaste.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
      // 
      // btnParse
      // 
      this.btnParse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnParse.Location = new System.Drawing.Point(693, 12);
      this.btnParse.Name = "btnParse";
      this.btnParse.Size = new System.Drawing.Size(60, 39);
      this.btnParse.TabIndex = 5;
      this.btnParse.Text = "Parse";
      this.btnParse.UseVisualStyleBackColor = true;
      this.btnParse.Visible = false;
      this.btnParse.Click += new System.EventHandler(this.btnParse_Click);
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(16, 19);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(76, 23);
      this.label4.TabIndex = 4;
      this.label4.Text = "Focused:";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(89, 19);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(55, 23);
      this.label3.TabIndex = 3;
      this.label3.Text = "label3";
      // 
      // props
      // 
      // 
      // 
      // 
      this.props.DocCommentDescription.AutoEllipsis = true;
      this.props.DocCommentDescription.Cursor = System.Windows.Forms.Cursors.Default;
      this.props.DocCommentDescription.Location = new System.Drawing.Point(4, 29);
      this.props.DocCommentDescription.Margin = new System.Windows.Forms.Padding(72, 0, 72, 0);
      this.props.DocCommentDescription.Name = "";
      this.props.DocCommentDescription.Size = new System.Drawing.Size(752, 40);
      this.props.DocCommentDescription.TabIndex = 1;
      this.props.DocCommentImage = null;
      // 
      // 
      // 
      this.props.DocCommentTitle.Cursor = System.Windows.Forms.Cursors.Default;
      this.props.DocCommentTitle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
      this.props.DocCommentTitle.Location = new System.Drawing.Point(4, 4);
      this.props.DocCommentTitle.Margin = new System.Windows.Forms.Padding(72, 0, 72, 0);
      this.props.DocCommentTitle.Name = "";
      this.props.DocCommentTitle.Size = new System.Drawing.Size(752, 25);
      this.props.DocCommentTitle.TabIndex = 0;
      this.props.DocCommentTitle.UseMnemonic = false;
      this.props.Dock = System.Windows.Forms.DockStyle.Fill;
      this.props.Location = new System.Drawing.Point(0, 0);
      this.props.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
      this.props.Name = "props";
      this.props.Size = new System.Drawing.Size(760, 210);
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
      this.props.ToolStrip.Padding = new System.Windows.Forms.Padding(48, 0, 32, 0);
      this.props.ToolStrip.Size = new System.Drawing.Size(760, 31);
      this.props.ToolStrip.TabIndex = 1;
      this.props.ToolStrip.TabStop = true;
      this.props.ToolStrip.Text = "PropertyGridToolBar";
      this.props.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.props_PropertyValueChanged);
      // 
      // odMain
      // 
      this.odMain.CheckFileExists = false;
      this.odMain.DefaultExt = "cdf";
      // 
      // pb2
      // 
      this.pb2.ForeColor = System.Drawing.Color.Blue;
      this.pb2.Location = new System.Drawing.Point(122, 226);
      this.pb2.Maximum = 10000;
      this.pb2.Name = "pb2";
      this.pb2.Size = new System.Drawing.Size(708, 28);
      this.pb2.TabIndex = 11;
      this.pb2.Value = 500;
      this.pb2.Visible = false;
      // 
      // tabPage5
      // 
      this.tabPage5.Controls.Add(this.wbOut);
      this.tabPage5.Location = new System.Drawing.Point(4, 32);
      this.tabPage5.Name = "tabPage5";
      this.tabPage5.Size = new System.Drawing.Size(495, 500);
      this.tabPage5.TabIndex = 2;
      this.tabPage5.Text = "Viewer";
      this.tabPage5.UseVisualStyleBackColor = true;
      // 
      // wbOut
      // 
      this.wbOut.Dock = System.Windows.Forms.DockStyle.Fill;
      this.wbOut.Location = new System.Drawing.Point(0, 0);
      this.wbOut.MinimumSize = new System.Drawing.Size(20, 20);
      this.wbOut.Name = "wbOut";
      this.wbOut.Size = new System.Drawing.Size(495, 500);
      this.wbOut.TabIndex = 0;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1007, 854);
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
      this.panel1.PerformLayout();
      this.scRoot2.Panel1.ResumeLayout(false);
      this.scRoot2.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.scRoot2)).EndInit();
      this.scRoot2.ResumeLayout(false);
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
      this.splitContainer1.ResumeLayout(false);
      this.panel2.ResumeLayout(false);
      this.contextMenuStrip1.ResumeLayout(false);
      this.tabControl2.ResumeLayout(false);
      this.tabPage3.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.edOutput)).EndInit();
      this.contextMenuStrip2.ResumeLayout(false);
      this.tabPage4.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.edInput)).EndInit();
      this.panel3.ResumeLayout(false);
      this.panel3.PerformLayout();
      this.tabPage5.ResumeLayout(false);
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
    private System.Windows.Forms.OpenFileDialog odMain;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button btnBuild;
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
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Button btnParse;
    private System.Windows.Forms.Button btnClear;
    private System.Windows.Forms.Button btnPaste;
    private System.Windows.Forms.ToolStripMenuItem addTemplateToolStripMenuItem;
    private System.Windows.Forms.ComboBox edFileName;
    private System.Windows.Forms.ToolStripMenuItem moveUpToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem moveDownToolStripMenuItem;
    private System.Windows.Forms.CheckBox cbPrompt;
    private System.Windows.Forms.ProgressBar pbMain;
    private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
    private System.Windows.Forms.ProgressBar pb2;
    private System.Windows.Forms.TabPage tabPage5;
    private System.Windows.Forms.WebBrowser wbOut;
  }
}

