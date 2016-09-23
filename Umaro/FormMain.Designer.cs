namespace Umaro
{
    partial class FormMain
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pgFrameInfo = new System.Windows.Forms.PropertyGrid();
            this.cntMain = new System.Windows.Forms.SplitContainer();
            this.lblPreview = new System.Windows.Forms.Label();
            this.zbPreview = new Umaro.ZoomBox();
            this.pnlCanvas = new Umaro.PanelNoFocusScroll();
            this.zbMain = new Umaro.ZoomBox();
            this.cntSidebar = new System.Windows.Forms.SplitContainer();
            this.tabSidebarTop = new Umaro.FlatTabControl(this.components);
            this.tabAnimations = new System.Windows.Forms.TabPage();
            this.pnlAnimControls = new System.Windows.Forms.Panel();
            this.btnAnimPrevFrame = new System.Windows.Forms.Button();
            this.btnAnimNextFrame = new System.Windows.Forms.Button();
            this.btnAnimPlayPause = new System.Windows.Forms.Button();
            this.btnAnimStop = new System.Windows.Forms.Button();
            this.lvAnimations = new System.Windows.Forms.ListView();
            this.clnAnimName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAddAnim = new System.Windows.Forms.Button();
            this.btnRemoveAnim = new System.Windows.Forms.Button();
            this.tabFrames = new System.Windows.Forms.TabPage();
            this.btnAddFrame = new System.Windows.Forms.Button();
            this.lblAnimName = new System.Windows.Forms.Label();
            this.btnRemoveFrame = new System.Windows.Forms.Button();
            this.lvFrames = new System.Windows.Forms.ListView();
            this.lblSizeCross = new System.Windows.Forms.Label();
            this.txtFrameWidth = new System.Windows.Forms.TextBox();
            this.lblFrameSize = new System.Windows.Forms.Label();
            this.txtFrameHeight = new System.Windows.Forms.TextBox();
            this.tabIcons = new System.Windows.Forms.ImageList(this.components);
            this.pnlBorder = new System.Windows.Forms.Panel();
            this.resizeGripForm = new Umaro.ResizeGrip();
            this.lblTitle = new System.Windows.Forms.Label();
            this.sStrip = new System.Windows.Forms.StatusStrip();
            this.tsLblCopyright = new System.Windows.Forms.ToolStripStatusLabel();
            this.headerMenuMain = new Umaro.HeaderMenu(this.components);
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.plainTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.plainTextToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pNGWithMetadataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUmaroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ofDiag = new System.Windows.Forms.OpenFileDialog();
            this.tmrRefresh = new System.Windows.Forms.Timer(this.components);
            this.tmrPreview = new System.Windows.Forms.Timer(this.components);
            this.saveXmlDlg = new System.Windows.Forms.SaveFileDialog();
            this.openXmlDlg = new System.Windows.Forms.OpenFileDialog();
            this.saveTextDialog = new System.Windows.Forms.SaveFileDialog();
            this.openTextDlg = new System.Windows.Forms.OpenFileDialog();
            this.savePNGDialog = new System.Windows.Forms.SaveFileDialog();
            this.importPNGWithMetadataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openPNGDialog = new System.Windows.Forms.OpenFileDialog();
            this.cntMain.Panel1.SuspendLayout();
            this.cntMain.Panel2.SuspendLayout();
            this.cntMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zbPreview)).BeginInit();
            this.pnlCanvas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zbMain)).BeginInit();
            this.cntSidebar.Panel1.SuspendLayout();
            this.cntSidebar.Panel2.SuspendLayout();
            this.cntSidebar.SuspendLayout();
            this.tabSidebarTop.SuspendLayout();
            this.tabAnimations.SuspendLayout();
            this.pnlAnimControls.SuspendLayout();
            this.tabFrames.SuspendLayout();
            this.pnlBorder.SuspendLayout();
            this.sStrip.SuspendLayout();
            this.headerMenuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(16, 16);
            this.button1.TabIndex = 0;
            this.button1.Text = "-";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(16, 16);
            this.button2.TabIndex = 0;
            this.button2.Text = "-";
            // 
            // pgFrameInfo
            // 
            this.pgFrameInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.pgFrameInfo.CategoryForeColor = System.Drawing.Color.Gray;
            this.pgFrameInfo.CommandsDisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(133)))), ((int)(((byte)(133)))));
            this.pgFrameInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pgFrameInfo.HelpBackColor = System.Drawing.Color.Black;
            this.pgFrameInfo.HelpVisible = false;
            this.pgFrameInfo.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.pgFrameInfo.Location = new System.Drawing.Point(0, 0);
            this.pgFrameInfo.Name = "pgFrameInfo";
            this.pgFrameInfo.PropertySort = System.Windows.Forms.PropertySort.NoSort;
            this.pgFrameInfo.Size = new System.Drawing.Size(201, 166);
            this.pgFrameInfo.TabIndex = 2;
            this.pgFrameInfo.ToolbarVisible = false;
            this.pgFrameInfo.ViewBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.pgFrameInfo.ViewForeColor = System.Drawing.Color.WhiteSmoke;
            this.pgFrameInfo.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.pgFrameInfo_PropertyValueChanged);
            // 
            // cntMain
            // 
            this.cntMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cntMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.cntMain.Location = new System.Drawing.Point(1, 26);
            this.cntMain.Name = "cntMain";
            // 
            // cntMain.Panel1
            // 
            this.cntMain.Panel1.Controls.Add(this.lblPreview);
            this.cntMain.Panel1.Controls.Add(this.zbPreview);
            this.cntMain.Panel1.Controls.Add(this.pnlCanvas);
            this.cntMain.Panel1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 27);
            // 
            // cntMain.Panel2
            // 
            this.cntMain.Panel2.Controls.Add(this.cntSidebar);
            this.cntMain.Panel2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 27);
            this.cntMain.Size = new System.Drawing.Size(704, 394);
            this.cntMain.SplitterDistance = 499;
            this.cntMain.TabIndex = 3;
            // 
            // lblPreview
            // 
            this.lblPreview.AutoSize = true;
            this.lblPreview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.lblPreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPreview.ForeColor = System.Drawing.Color.Gray;
            this.lblPreview.Location = new System.Drawing.Point(1, 2);
            this.lblPreview.Name = "lblPreview";
            this.lblPreview.Size = new System.Drawing.Size(52, 13);
            this.lblPreview.TabIndex = 2;
            this.lblPreview.Text = "Preview";
            // 
            // zbPreview
            // 
            this.zbPreview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.zbPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.zbPreview.ControlsOnParent = false;
            this.zbPreview.Image = null;
            this.zbPreview.InitialImage = null;
            this.zbPreview.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
            this.zbPreview.Location = new System.Drawing.Point(0, 0);
            this.zbPreview.MinimumSize = new System.Drawing.Size(160, 160);
            this.zbPreview.Name = "zbPreview";
            this.zbPreview.Resizable = true;
            this.zbPreview.Size = new System.Drawing.Size(162, 162);
            this.zbPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.zbPreview.TabIndex = 1;
            this.zbPreview.TabStop = false;
            this.zbPreview.Text = "+";
            // 
            // pnlCanvas
            // 
            this.pnlCanvas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCanvas.AutoScroll = true;
            this.pnlCanvas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlCanvas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.pnlCanvas.Controls.Add(this.zbMain);
            this.pnlCanvas.Location = new System.Drawing.Point(0, 0);
            this.pnlCanvas.Name = "pnlCanvas";
            this.pnlCanvas.Size = new System.Drawing.Size(499, 394);
            this.pnlCanvas.TabIndex = 3;
            // 
            // zbMain
            // 
            this.zbMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.zbMain.ControlsOnParent = true;
            this.zbMain.Image = null;
            this.zbMain.InitialImage = null;
            this.zbMain.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
            this.zbMain.Location = new System.Drawing.Point(0, 0);
            this.zbMain.Name = "zbMain";
            this.zbMain.Resizable = false;
            this.zbMain.Size = new System.Drawing.Size(320, 183);
            this.zbMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.zbMain.TabIndex = 0;
            this.zbMain.TabStop = false;
            this.zbMain.Text = "+";
            this.zbMain.Paint += new System.Windows.Forms.PaintEventHandler(this.zbMain_Paint);
            this.zbMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.zbMain_MouseDown);
            this.zbMain.MouseMove += new System.Windows.Forms.MouseEventHandler(this.zbMain_MouseMove);
            // 
            // cntSidebar
            // 
            this.cntSidebar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cntSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.cntSidebar.Location = new System.Drawing.Point(0, 0);
            this.cntSidebar.Name = "cntSidebar";
            this.cntSidebar.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // cntSidebar.Panel1
            // 
            this.cntSidebar.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.cntSidebar.Panel1.Controls.Add(this.tabSidebarTop);
            // 
            // cntSidebar.Panel2
            // 
            this.cntSidebar.Panel2.Controls.Add(this.pgFrameInfo);
            this.cntSidebar.Size = new System.Drawing.Size(201, 394);
            this.cntSidebar.SplitterDistance = 224;
            this.cntSidebar.TabIndex = 0;
            // 
            // tabSidebarTop
            // 
            this.tabSidebarTop.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.tabSidebarTop.Controls.Add(this.tabAnimations);
            this.tabSidebarTop.Controls.Add(this.tabFrames);
            this.tabSidebarTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabSidebarTop.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabSidebarTop.ImageList = this.tabIcons;
            this.tabSidebarTop.Location = new System.Drawing.Point(0, 0);
            this.tabSidebarTop.Name = "tabSidebarTop";
            this.tabSidebarTop.Padding = new System.Drawing.Point(0, 3);
            this.tabSidebarTop.SelectedIndex = 0;
            this.tabSidebarTop.Size = new System.Drawing.Size(201, 224);
            this.tabSidebarTop.TabBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.tabSidebarTop.TabIndex = 3;
            this.tabSidebarTop.SelectedIndexChanged += new System.EventHandler(this.tabSidebarTop_SelectedIndexChanged);
            // 
            // tabAnimations
            // 
            this.tabAnimations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.tabAnimations.Controls.Add(this.pnlAnimControls);
            this.tabAnimations.Controls.Add(this.lvAnimations);
            this.tabAnimations.Controls.Add(this.btnAddAnim);
            this.tabAnimations.Controls.Add(this.btnRemoveAnim);
            this.tabAnimations.ForeColor = System.Drawing.Color.White;
            this.tabAnimations.ImageIndex = 0;
            this.tabAnimations.Location = new System.Drawing.Point(4, 25);
            this.tabAnimations.Name = "tabAnimations";
            this.tabAnimations.Padding = new System.Windows.Forms.Padding(3);
            this.tabAnimations.Size = new System.Drawing.Size(193, 195);
            this.tabAnimations.TabIndex = 0;
            this.tabAnimations.Text = "Animations";
            this.tabAnimations.UseVisualStyleBackColor = true;
            // 
            // pnlAnimControls
            // 
            this.pnlAnimControls.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAnimControls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.pnlAnimControls.Controls.Add(this.btnAnimPrevFrame);
            this.pnlAnimControls.Controls.Add(this.btnAnimNextFrame);
            this.pnlAnimControls.Controls.Add(this.btnAnimPlayPause);
            this.pnlAnimControls.Controls.Add(this.btnAnimStop);
            this.pnlAnimControls.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.pnlAnimControls.Location = new System.Drawing.Point(91, 164);
            this.pnlAnimControls.Name = "pnlAnimControls";
            this.pnlAnimControls.Size = new System.Drawing.Size(96, 25);
            this.pnlAnimControls.TabIndex = 1;
            // 
            // btnAnimPrevFrame
            // 
            this.btnAnimPrevFrame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btnAnimPrevFrame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnimPrevFrame.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btnAnimPrevFrame.Image = global::Umaro.Properties.Resources.anim_prev;
            this.btnAnimPrevFrame.Location = new System.Drawing.Point(49, 1);
            this.btnAnimPrevFrame.Name = "btnAnimPrevFrame";
            this.btnAnimPrevFrame.Size = new System.Drawing.Size(22, 22);
            this.btnAnimPrevFrame.TabIndex = 3;
            this.btnAnimPrevFrame.UseVisualStyleBackColor = false;
            this.btnAnimPrevFrame.Click += new System.EventHandler(this.btnAnimPrevFrame_Click);
            // 
            // btnAnimNextFrame
            // 
            this.btnAnimNextFrame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btnAnimNextFrame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnimNextFrame.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btnAnimNextFrame.Image = global::Umaro.Properties.Resources.anim_next;
            this.btnAnimNextFrame.Location = new System.Drawing.Point(73, 1);
            this.btnAnimNextFrame.Name = "btnAnimNextFrame";
            this.btnAnimNextFrame.Size = new System.Drawing.Size(22, 22);
            this.btnAnimNextFrame.TabIndex = 2;
            this.btnAnimNextFrame.UseVisualStyleBackColor = false;
            this.btnAnimNextFrame.Click += new System.EventHandler(this.btnAnimNextFrame_Click);
            // 
            // btnAnimPlayPause
            // 
            this.btnAnimPlayPause.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btnAnimPlayPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnimPlayPause.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btnAnimPlayPause.Image = global::Umaro.Properties.Resources.anim_play;
            this.btnAnimPlayPause.Location = new System.Drawing.Point(25, 1);
            this.btnAnimPlayPause.Name = "btnAnimPlayPause";
            this.btnAnimPlayPause.Size = new System.Drawing.Size(22, 22);
            this.btnAnimPlayPause.TabIndex = 1;
            this.btnAnimPlayPause.UseVisualStyleBackColor = false;
            this.btnAnimPlayPause.Click += new System.EventHandler(this.btnAnimPlayPause_Click);
            // 
            // btnAnimStop
            // 
            this.btnAnimStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btnAnimStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnimStop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btnAnimStop.Image = global::Umaro.Properties.Resources.anim_stop;
            this.btnAnimStop.Location = new System.Drawing.Point(1, 1);
            this.btnAnimStop.Name = "btnAnimStop";
            this.btnAnimStop.Size = new System.Drawing.Size(22, 22);
            this.btnAnimStop.TabIndex = 0;
            this.btnAnimStop.UseVisualStyleBackColor = false;
            this.btnAnimStop.Click += new System.EventHandler(this.btnAnimStop_Click);
            // 
            // lvAnimations
            // 
            this.lvAnimations.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvAnimations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.lvAnimations.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvAnimations.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clnAnimName});
            this.lvAnimations.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lvAnimations.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvAnimations.Location = new System.Drawing.Point(1, 1);
            this.lvAnimations.MultiSelect = false;
            this.lvAnimations.Name = "lvAnimations";
            this.lvAnimations.Size = new System.Drawing.Size(190, 157);
            this.lvAnimations.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvAnimations.TabIndex = 6;
            this.lvAnimations.UseCompatibleStateImageBehavior = false;
            this.lvAnimations.View = System.Windows.Forms.View.Details;
            this.lvAnimations.SelectedIndexChanged += new System.EventHandler(this.lvAnimations_SelectedIndexChanged);
            // 
            // clnAnimName
            // 
            this.clnAnimName.Text = "Name";
            this.clnAnimName.Width = 150;
            // 
            // btnAddAnim
            // 
            this.btnAddAnim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddAnim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.btnAddAnim.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnAddAnim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAnim.Image = global::Umaro.Properties.Resources.AddMark_10580;
            this.btnAddAnim.Location = new System.Drawing.Point(4, 163);
            this.btnAddAnim.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddAnim.Name = "btnAddAnim";
            this.btnAddAnim.Size = new System.Drawing.Size(28, 28);
            this.btnAddAnim.TabIndex = 4;
            this.btnAddAnim.UseVisualStyleBackColor = false;
            this.btnAddAnim.Click += new System.EventHandler(this.btnAddAnim_Click);
            // 
            // btnRemoveAnim
            // 
            this.btnRemoveAnim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemoveAnim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.btnRemoveAnim.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnRemoveAnim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveAnim.Image = global::Umaro.Properties.Resources.Clearallrequests_8816;
            this.btnRemoveAnim.Location = new System.Drawing.Point(34, 163);
            this.btnRemoveAnim.Margin = new System.Windows.Forms.Padding(0);
            this.btnRemoveAnim.Name = "btnRemoveAnim";
            this.btnRemoveAnim.Size = new System.Drawing.Size(28, 28);
            this.btnRemoveAnim.TabIndex = 5;
            this.btnRemoveAnim.UseVisualStyleBackColor = false;
            this.btnRemoveAnim.Click += new System.EventHandler(this.btnRemoveAnim_Click);
            // 
            // tabFrames
            // 
            this.tabFrames.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.tabFrames.Controls.Add(this.btnAddFrame);
            this.tabFrames.Controls.Add(this.lblAnimName);
            this.tabFrames.Controls.Add(this.btnRemoveFrame);
            this.tabFrames.Controls.Add(this.lvFrames);
            this.tabFrames.Controls.Add(this.lblSizeCross);
            this.tabFrames.Controls.Add(this.txtFrameWidth);
            this.tabFrames.Controls.Add(this.lblFrameSize);
            this.tabFrames.Controls.Add(this.txtFrameHeight);
            this.tabFrames.ForeColor = System.Drawing.Color.White;
            this.tabFrames.ImageIndex = 1;
            this.tabFrames.Location = new System.Drawing.Point(4, 25);
            this.tabFrames.Name = "tabFrames";
            this.tabFrames.Padding = new System.Windows.Forms.Padding(3);
            this.tabFrames.Size = new System.Drawing.Size(193, 195);
            this.tabFrames.TabIndex = 1;
            this.tabFrames.Text = "Frames";
            // 
            // btnAddFrame
            // 
            this.btnAddFrame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddFrame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.btnAddFrame.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnAddFrame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddFrame.Image = global::Umaro.Properties.Resources.AddMark_10580;
            this.btnAddFrame.Location = new System.Drawing.Point(4, 163);
            this.btnAddFrame.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddFrame.Name = "btnAddFrame";
            this.btnAddFrame.Size = new System.Drawing.Size(28, 28);
            this.btnAddFrame.TabIndex = 26;
            this.btnAddFrame.UseVisualStyleBackColor = false;
            this.btnAddFrame.Click += new System.EventHandler(this.btnAddFrame_Click);
            // 
            // lblAnimName
            // 
            this.lblAnimName.AutoSize = true;
            this.lblAnimName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.lblAnimName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAnimName.ForeColor = System.Drawing.Color.White;
            this.lblAnimName.Location = new System.Drawing.Point(3, 3);
            this.lblAnimName.Margin = new System.Windows.Forms.Padding(0);
            this.lblAnimName.Name = "lblAnimName";
            this.lblAnimName.Size = new System.Drawing.Size(11, 13);
            this.lblAnimName.TabIndex = 21;
            this.lblAnimName.Text = "-";
            // 
            // btnRemoveFrame
            // 
            this.btnRemoveFrame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemoveFrame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.btnRemoveFrame.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnRemoveFrame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveFrame.Image = global::Umaro.Properties.Resources.Clearallrequests_8816;
            this.btnRemoveFrame.Location = new System.Drawing.Point(34, 163);
            this.btnRemoveFrame.Margin = new System.Windows.Forms.Padding(0);
            this.btnRemoveFrame.Name = "btnRemoveFrame";
            this.btnRemoveFrame.Size = new System.Drawing.Size(28, 28);
            this.btnRemoveFrame.TabIndex = 27;
            this.btnRemoveFrame.UseVisualStyleBackColor = false;
            this.btnRemoveFrame.Click += new System.EventHandler(this.btnRemoveFrame_Click);
            // 
            // lvFrames
            // 
            this.lvFrames.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvFrames.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.lvFrames.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvFrames.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lvFrames.Location = new System.Drawing.Point(1, 19);
            this.lvFrames.MultiSelect = false;
            this.lvFrames.Name = "lvFrames";
            this.lvFrames.Size = new System.Drawing.Size(190, 139);
            this.lvFrames.TabIndex = 20;
            this.lvFrames.UseCompatibleStateImageBehavior = false;
            this.lvFrames.View = System.Windows.Forms.View.List;
            this.lvFrames.SelectedIndexChanged += new System.EventHandler(this.lvFrames_SelectedIndexChanged);
            // 
            // lblSizeCross
            // 
            this.lblSizeCross.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSizeCross.AutoSize = true;
            this.lblSizeCross.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.lblSizeCross.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSizeCross.ForeColor = System.Drawing.Color.Gray;
            this.lblSizeCross.Location = new System.Drawing.Point(147, 169);
            this.lblSizeCross.Name = "lblSizeCross";
            this.lblSizeCross.Size = new System.Drawing.Size(13, 13);
            this.lblSizeCross.TabIndex = 25;
            this.lblSizeCross.Text = "x";
            // 
            // txtFrameWidth
            // 
            this.txtFrameWidth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFrameWidth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txtFrameWidth.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFrameWidth.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtFrameWidth.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtFrameWidth.Location = new System.Drawing.Point(119, 169);
            this.txtFrameWidth.Name = "txtFrameWidth";
            this.txtFrameWidth.Size = new System.Drawing.Size(26, 16);
            this.txtFrameWidth.TabIndex = 22;
            this.txtFrameWidth.Text = "16";
            this.txtFrameWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblFrameSize
            // 
            this.lblFrameSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFrameSize.AutoSize = true;
            this.lblFrameSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.lblFrameSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFrameSize.ForeColor = System.Drawing.Color.Gray;
            this.lblFrameSize.Location = new System.Drawing.Point(84, 171);
            this.lblFrameSize.Name = "lblFrameSize";
            this.lblFrameSize.Size = new System.Drawing.Size(35, 13);
            this.lblFrameSize.TabIndex = 24;
            this.lblFrameSize.Text = "Size:";
            // 
            // txtFrameHeight
            // 
            this.txtFrameHeight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFrameHeight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txtFrameHeight.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFrameHeight.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtFrameHeight.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtFrameHeight.Location = new System.Drawing.Point(160, 169);
            this.txtFrameHeight.Name = "txtFrameHeight";
            this.txtFrameHeight.Size = new System.Drawing.Size(26, 16);
            this.txtFrameHeight.TabIndex = 23;
            this.txtFrameHeight.Text = "16";
            this.txtFrameHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tabIcons
            // 
            this.tabIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("tabIcons.ImageStream")));
            this.tabIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.tabIcons.Images.SetKeyName(0, "Animation_10763.png");
            this.tabIcons.Images.SetKeyName(1, "Frame_12655.png");
            // 
            // pnlBorder
            // 
            this.pnlBorder.BackColor = System.Drawing.Color.Black;
            this.pnlBorder.Controls.Add(this.resizeGripForm);
            this.pnlBorder.Controls.Add(this.lblTitle);
            this.pnlBorder.Controls.Add(this.sStrip);
            this.pnlBorder.Controls.Add(this.headerMenuMain);
            this.pnlBorder.Controls.Add(this.cntMain);
            this.pnlBorder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBorder.Location = new System.Drawing.Point(3, 3);
            this.pnlBorder.Name = "pnlBorder";
            this.pnlBorder.Padding = new System.Windows.Forms.Padding(1);
            this.pnlBorder.Size = new System.Drawing.Size(706, 444);
            this.pnlBorder.TabIndex = 3;
            // 
            // resizeGripForm
            // 
            this.resizeGripForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.resizeGripForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.resizeGripForm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("resizeGripForm.BackgroundImage")));
            this.resizeGripForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.resizeGripForm.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.resizeGripForm.Location = new System.Drawing.Point(689, 427);
            this.resizeGripForm.Name = "resizeGripForm";
            this.resizeGripForm.Size = new System.Drawing.Size(16, 16);
            this.resizeGripForm.TabIndex = 7;
            this.resizeGripForm.Target = this;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTitle.Location = new System.Drawing.Point(322, 6);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(43, 13);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Umaro";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sStrip
            // 
            this.sStrip.AutoSize = false;
            this.sStrip.BackColor = System.Drawing.Color.Black;
            this.sStrip.BackgroundImage = global::Umaro.Properties.Resources.toolbar_back;
            this.sStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsLblCopyright});
            this.sStrip.Location = new System.Drawing.Point(1, 423);
            this.sStrip.Name = "sStrip";
            this.sStrip.Size = new System.Drawing.Size(704, 20);
            this.sStrip.SizingGrip = false;
            this.sStrip.Stretch = false;
            this.sStrip.TabIndex = 4;
            // 
            // tsLblCopyright
            // 
            this.tsLblCopyright.BackColor = System.Drawing.Color.Transparent;
            this.tsLblCopyright.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tsLblCopyright.ForeColor = System.Drawing.Color.Gray;
            this.tsLblCopyright.Name = "tsLblCopyright";
            this.tsLblCopyright.Size = new System.Drawing.Size(345, 15);
            this.tsLblCopyright.Text = "Umaro - a sprite animation tool © RawByte Interactive, 2016";
            // 
            // headerMenuMain
            // 
            this.headerMenuMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.headerMenuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.xToolStripMenuItem,
            this.oToolStripMenuItem,
            this.minStripMenuItem});
            this.headerMenuMain.Location = new System.Drawing.Point(1, 1);
            this.headerMenuMain.Name = "headerMenuMain";
            this.headerMenuMain.Size = new System.Drawing.Size(704, 24);
            this.headerMenuMain.TabIndex = 8;
            this.headerMenuMain.Target = this;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.importToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imageToolStripMenuItem,
            this.xMLToolStripMenuItem,
            this.plainTextToolStripMenuItem,
            this.importPNGWithMetadataToolStripMenuItem});
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.importToolStripMenuItem.Text = "Import...";
            // 
            // imageToolStripMenuItem
            // 
            this.imageToolStripMenuItem.Name = "imageToolStripMenuItem";
            this.imageToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.imageToolStripMenuItem.Text = "Image";
            this.imageToolStripMenuItem.Click += new System.EventHandler(this.loadImageToolStripMenuItem_Click);
            // 
            // xMLToolStripMenuItem
            // 
            this.xMLToolStripMenuItem.Name = "xMLToolStripMenuItem";
            this.xMLToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.xMLToolStripMenuItem.Text = "XML";
            this.xMLToolStripMenuItem.Click += new System.EventHandler(this.loadXMLToolStripMenuItem_Click);
            // 
            // plainTextToolStripMenuItem
            // 
            this.plainTextToolStripMenuItem.Name = "plainTextToolStripMenuItem";
            this.plainTextToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.plainTextToolStripMenuItem.Text = "Plain text";
            this.plainTextToolStripMenuItem.Click += new System.EventHandler(this.plainTextToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xMLToolStripMenuItem1,
            this.plainTextToolStripMenuItem1,
            this.pNGWithMetadataToolStripMenuItem});
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exportToolStripMenuItem.Text = "Export...";
            // 
            // xMLToolStripMenuItem1
            // 
            this.xMLToolStripMenuItem1.Name = "xMLToolStripMenuItem1";
            this.xMLToolStripMenuItem1.Size = new System.Drawing.Size(166, 22);
            this.xMLToolStripMenuItem1.Text = "XML";
            this.xMLToolStripMenuItem1.Click += new System.EventHandler(this.exportXMLToolStripMenuItem_Click);
            // 
            // plainTextToolStripMenuItem1
            // 
            this.plainTextToolStripMenuItem1.Name = "plainTextToolStripMenuItem1";
            this.plainTextToolStripMenuItem1.Size = new System.Drawing.Size(166, 22);
            this.plainTextToolStripMenuItem1.Text = "Plain text";
            this.plainTextToolStripMenuItem1.Click += new System.EventHandler(this.exportPlainTextToolStripMenuItem_Click);
            // 
            // pNGWithMetadataToolStripMenuItem
            // 
            this.pNGWithMetadataToolStripMenuItem.Name = "pNGWithMetadataToolStripMenuItem";
            this.pNGWithMetadataToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.pNGWithMetadataToolStripMenuItem.Text = "PNG with Metadata";
            this.pNGWithMetadataToolStripMenuItem.Click += new System.EventHandler(this.pNGWithMetadataToolStripMenuItem_Click_1);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutUmaroToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutUmaroToolStripMenuItem
            // 
            this.aboutUmaroToolStripMenuItem.Name = "aboutUmaroToolStripMenuItem";
            this.aboutUmaroToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.aboutUmaroToolStripMenuItem.Text = "About Umaro";
            this.aboutUmaroToolStripMenuItem.Click += new System.EventHandler(this.aboutUmaroToolStripMenuItem_Click);
            // 
            // xToolStripMenuItem
            // 
            this.xToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.xToolStripMenuItem.Image = global::Umaro.Properties.Resources.window_close;
            this.xToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.xToolStripMenuItem.Name = "xToolStripMenuItem";
            this.xToolStripMenuItem.Size = new System.Drawing.Size(21, 20);
            this.xToolStripMenuItem.Click += new System.EventHandler(this.btnWindowClose_Click);
            // 
            // oToolStripMenuItem
            // 
            this.oToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.oToolStripMenuItem.Image = global::Umaro.Properties.Resources.window_maximize;
            this.oToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.oToolStripMenuItem.Name = "oToolStripMenuItem";
            this.oToolStripMenuItem.Size = new System.Drawing.Size(21, 20);
            this.oToolStripMenuItem.Click += new System.EventHandler(this.btnWindowMinMax_Click);
            // 
            // minStripMenuItem
            // 
            this.minStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.minStripMenuItem.Image = global::Umaro.Properties.Resources.window_minimize;
            this.minStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.minStripMenuItem.Name = "minStripMenuItem";
            this.minStripMenuItem.Size = new System.Drawing.Size(21, 20);
            this.minStripMenuItem.Click += new System.EventHandler(this.btnWindowMinimize_Click);
            // 
            // ofDiag
            // 
            this.ofDiag.Filter = "Images|*.png;*.jpg;*.gif";
            // 
            // tmrRefresh
            // 
            this.tmrRefresh.Enabled = true;
            this.tmrRefresh.Interval = 500;
            this.tmrRefresh.Tick += new System.EventHandler(this.tmrRefresh_Tick);
            // 
            // tmrPreview
            // 
            this.tmrPreview.Interval = 10;
            this.tmrPreview.Tick += new System.EventHandler(this.tmrPreview_Tick);
            // 
            // saveXmlDlg
            // 
            this.saveXmlDlg.Filter = "XML Files|*.xml";
            // 
            // openXmlDlg
            // 
            this.openXmlDlg.Filter = "XML Files|*.xml";
            // 
            // saveTextDialog
            // 
            this.saveTextDialog.Filter = "Text Files|*.txt";
            // 
            // openTextDlg
            // 
            this.openTextDlg.Filter = "Text Files|*.txt";
            // 
            // savePNGDialog
            // 
            this.savePNGDialog.Filter = "PNG Files|*.png";
            // 
            // importPNGWithMetadataToolStripMenuItem
            // 
            this.importPNGWithMetadataToolStripMenuItem.Name = "importPNGWithMetadataToolStripMenuItem";
            this.importPNGWithMetadataToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.importPNGWithMetadataToolStripMenuItem.Text = "PNG with Metadata";
            this.importPNGWithMetadataToolStripMenuItem.Click += new System.EventHandler(this.importPNGWithMetadataToolStripMenuItem_Click);
            // 
            // openPNGDialog
            // 
            this.openPNGDialog.Filter = "PNG Files|*.png";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(712, 450);
            this.Controls.Add(this.pnlBorder);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.headerMenuMain;
            this.MinimumSize = new System.Drawing.Size(600, 300);
            this.Name = "FormMain";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Umaro";
            this.cntMain.Panel1.ResumeLayout(false);
            this.cntMain.Panel1.PerformLayout();
            this.cntMain.Panel2.ResumeLayout(false);
            this.cntMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.zbPreview)).EndInit();
            this.pnlCanvas.ResumeLayout(false);
            this.pnlCanvas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zbMain)).EndInit();
            this.cntSidebar.Panel1.ResumeLayout(false);
            this.cntSidebar.Panel2.ResumeLayout(false);
            this.cntSidebar.ResumeLayout(false);
            this.tabSidebarTop.ResumeLayout(false);
            this.tabAnimations.ResumeLayout(false);
            this.pnlAnimControls.ResumeLayout(false);
            this.tabFrames.ResumeLayout(false);
            this.tabFrames.PerformLayout();
            this.pnlBorder.ResumeLayout(false);
            this.pnlBorder.PerformLayout();
            this.sStrip.ResumeLayout(false);
            this.sStrip.PerformLayout();
            this.headerMenuMain.ResumeLayout(false);
            this.headerMenuMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private ZoomBox zbMain;
        private System.Windows.Forms.PropertyGrid pgFrameInfo;
        private System.Windows.Forms.SplitContainer cntMain;
        private System.Windows.Forms.SplitContainer cntSidebar;
        private System.Windows.Forms.StatusStrip sStrip;
        private ZoomBox zbPreview;
        private System.Windows.Forms.Label lblPreview;
        private System.Windows.Forms.Panel pnlBorder;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ToolStripStatusLabel tsLblCopyright;
        private System.Windows.Forms.ImageList tabIcons;
        private System.Windows.Forms.OpenFileDialog ofDiag;
        private System.Windows.Forms.Timer tmrRefresh;
        private System.Windows.Forms.Timer tmrPreview;
        private System.Windows.Forms.SaveFileDialog saveXmlDlg;
        private System.Windows.Forms.OpenFileDialog openXmlDlg;
        private System.Windows.Forms.Label lblSizeCross;
        private System.Windows.Forms.Label lblFrameSize;
        private System.Windows.Forms.TextBox txtFrameHeight;
        private System.Windows.Forms.TextBox txtFrameWidth;
        private System.Windows.Forms.Label lblAnimName;
        private System.Windows.Forms.ListView lvFrames;
        private System.Windows.Forms.ListView lvAnimations;
        private System.Windows.Forms.ColumnHeader clnAnimName;
        private System.Windows.Forms.Button btnAddAnim;
        private System.Windows.Forms.Button btnRemoveAnim;
        private System.Windows.Forms.Button btnAddFrame;
        private System.Windows.Forms.Button btnRemoveFrame;
        private ResizeGrip resizeGripForm;
        private System.Windows.Forms.SaveFileDialog saveTextDialog;
        private System.Windows.Forms.OpenFileDialog openTextDlg;
        private HeaderMenu headerMenuMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem plainTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xMLToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem plainTextToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutUmaroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minStripMenuItem;
        private FlatTabControl tabSidebarTop;
        private System.Windows.Forms.TabPage tabAnimations;
        private System.Windows.Forms.TabPage tabFrames;
        private PanelNoFocusScroll pnlCanvas;
        private System.Windows.Forms.Panel pnlAnimControls;
        private System.Windows.Forms.Button btnAnimStop;
        private System.Windows.Forms.Button btnAnimPrevFrame;
        private System.Windows.Forms.Button btnAnimNextFrame;
        private System.Windows.Forms.Button btnAnimPlayPause;
        private System.Windows.Forms.ToolStripMenuItem pNGWithMetadataToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog savePNGDialog;
        private System.Windows.Forms.ToolStripMenuItem importPNGWithMetadataToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openPNGDialog;
    }
}

