namespace MyMediaPlayer
{
	partial class frmMain
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
			this.lvPlaylist = new System.Windows.Forms.ListView();
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.playToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
			this.propertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.addFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.themeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.defaultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.darkThemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.label1 = new System.Windows.Forms.Label();
			this.lbName = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lbDuration = new System.Windows.Forms.Label();
			this.lbBirate = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.lbSize = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.lbFilePath = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.btPlay = new System.Windows.Forms.Button();
			this.btPause = new System.Windows.Forms.Button();
			this.btPrevious = new System.Windows.Forms.Button();
			this.btNext = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.lblVolume = new System.Windows.Forms.Label();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.lbCurrDuration = new System.Windows.Forms.Label();
			this.timer3 = new System.Windows.Forms.Timer(this.components);
			this.timer2 = new System.Windows.Forms.Timer(this.components);
			this.pbLeft = new System.Windows.Forms.ProgressBar();
			this.pbRight = new System.Windows.Forms.ProgressBar();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
			this.spectrum1 = new MyMediaPlayer.Spectrum();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.lbPlaying = new System.Windows.Forms.Label();
			this.hScrollBar1 = new MetroFramework.Controls.MetroTrackBar();
			this.tbVolume = new MetroFramework.Controls.MetroTrackBar();
			this.contextMenuStrip1.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.SuspendLayout();
			// 
			// lvPlaylist
			// 
			this.lvPlaylist.AllowDrop = true;
			this.lvPlaylist.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lvPlaylist.BackColor = System.Drawing.Color.White;
			this.lvPlaylist.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lvPlaylist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
			this.lvPlaylist.ContextMenuStrip = this.contextMenuStrip1;
			this.lvPlaylist.ForeColor = System.Drawing.Color.Black;
			this.lvPlaylist.FullRowSelect = true;
			this.lvPlaylist.GridLines = true;
			this.lvPlaylist.HideSelection = false;
			this.lvPlaylist.Location = new System.Drawing.Point(14, 258);
			this.lvPlaylist.MultiSelect = false;
			this.lvPlaylist.Name = "lvPlaylist";
			this.lvPlaylist.Size = new System.Drawing.Size(520, 255);
			this.lvPlaylist.TabIndex = 0;
			this.lvPlaylist.UseCompatibleStateImageBehavior = false;
			this.lvPlaylist.View = System.Windows.Forms.View.Details;
			this.lvPlaylist.SelectedIndexChanged += new System.EventHandler(this.lvPlaylist_SelectedIndexChanged);
			this.lvPlaylist.DragDrop += new System.Windows.Forms.DragEventHandler(this.lvPlaylist_DragDrop);
			this.lvPlaylist.DragEnter += new System.Windows.Forms.DragEventHandler(this.lvPlaylist_DragEnter);
			this.lvPlaylist.DoubleClick += new System.EventHandler(this.playToolStripMenuItem_Click);
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Playing";
			this.columnHeader4.Width = 45;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Name";
			this.columnHeader1.Width = 300;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Duration";
			this.columnHeader2.Width = 80;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Bitrate";
			this.columnHeader3.Width = 80;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playToolStripMenuItem,
            this.toolStripMenuItem2,
            this.propertiesToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(128, 54);
			// 
			// playToolStripMenuItem
			// 
			this.playToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.playToolStripMenuItem.Name = "playToolStripMenuItem";
			this.playToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
			this.playToolStripMenuItem.Text = "Play";
			this.playToolStripMenuItem.Click += new System.EventHandler(this.playToolStripMenuItem_Click);
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(124, 6);
			// 
			// propertiesToolStripMenuItem
			// 
			this.propertiesToolStripMenuItem.Name = "propertiesToolStripMenuItem";
			this.propertiesToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
			this.propertiesToolStripMenuItem.Text = "Properties";
			this.propertiesToolStripMenuItem.Click += new System.EventHandler(this.propertiesToolStripMenuItem_Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(548, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripMenuItem1,
            this.addFolderToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
			this.openToolStripMenuItem.Text = "Open";
			this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(129, 6);
			// 
			// addFolderToolStripMenuItem
			// 
			this.addFolderToolStripMenuItem.Name = "addFolderToolStripMenuItem";
			this.addFolderToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
			this.addFolderToolStripMenuItem.Text = "Add Folder";
			this.addFolderToolStripMenuItem.Click += new System.EventHandler(this.addFolderToolStripMenuItem_Click);
			// 
			// settingToolStripMenuItem
			// 
			this.settingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.themeToolStripMenuItem});
			this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
			this.settingToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
			this.settingToolStripMenuItem.Text = "Setting";
			// 
			// themeToolStripMenuItem
			// 
			this.themeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.defaultToolStripMenuItem,
            this.darkThemeToolStripMenuItem});
			this.themeToolStripMenuItem.Name = "themeToolStripMenuItem";
			this.themeToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
			this.themeToolStripMenuItem.Text = "Theme";
			// 
			// defaultToolStripMenuItem
			// 
			this.defaultToolStripMenuItem.Name = "defaultToolStripMenuItem";
			this.defaultToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
			this.defaultToolStripMenuItem.Text = "Default";
			this.defaultToolStripMenuItem.Click += new System.EventHandler(this.defaultToolStripMenuItem_Click);
			// 
			// darkThemeToolStripMenuItem
			// 
			this.darkThemeToolStripMenuItem.Name = "darkThemeToolStripMenuItem";
			this.darkThemeToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
			this.darkThemeToolStripMenuItem.Text = "Dark theme";
			this.darkThemeToolStripMenuItem.Click += new System.EventHandler(this.darkThemeToolStripMenuItem_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(10, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(50, 15);
			this.label1.TabIndex = 2;
			this.label1.Text = "Name : ";
			// 
			// lbName
			// 
			this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbName.Location = new System.Drawing.Point(78, 12);
			this.lbName.Name = "lbName";
			this.lbName.Size = new System.Drawing.Size(430, 15);
			this.lbName.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(10, 32);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(63, 15);
			this.label2.TabIndex = 4;
			this.label2.Text = "Duration : ";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(10, 52);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(48, 15);
			this.label3.TabIndex = 5;
			this.label3.Text = "Birate : ";
			// 
			// lbDuration
			// 
			this.lbDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbDuration.Location = new System.Drawing.Point(75, 32);
			this.lbDuration.Name = "lbDuration";
			this.lbDuration.Size = new System.Drawing.Size(430, 15);
			this.lbDuration.TabIndex = 6;
			// 
			// lbBirate
			// 
			this.lbBirate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbBirate.Location = new System.Drawing.Point(72, 52);
			this.lbBirate.Name = "lbBirate";
			this.lbBirate.Size = new System.Drawing.Size(433, 15);
			this.lbBirate.TabIndex = 7;
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Transparent;
			this.groupBox1.Controls.Add(this.lbSize);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.lbFilePath);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.lbName);
			this.groupBox1.Controls.Add(this.lbDuration);
			this.groupBox1.Controls.Add(this.lbBirate);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Location = new System.Drawing.Point(12, 27);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(524, 129);
			this.groupBox1.TabIndex = 8;
			this.groupBox1.TabStop = false;
			// 
			// lbSize
			// 
			this.lbSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbSize.Location = new System.Drawing.Point(75, 93);
			this.lbSize.Name = "lbSize";
			this.lbSize.Size = new System.Drawing.Size(433, 15);
			this.lbSize.TabIndex = 11;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(10, 93);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(61, 15);
			this.label6.TabIndex = 10;
			this.label6.Text = "File size  :";
			// 
			// lbFilePath
			// 
			this.lbFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbFilePath.Location = new System.Drawing.Point(75, 72);
			this.lbFilePath.Name = "lbFilePath";
			this.lbFilePath.Size = new System.Drawing.Size(433, 15);
			this.lbFilePath.TabIndex = 9;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(10, 72);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(60, 15);
			this.label5.TabIndex = 8;
			this.label5.Text = "File path :";
			// 
			// btPlay
			// 
			this.btPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btPlay.Image = global::MyMediaPlayer.Properties.Resources.play;
			this.btPlay.Location = new System.Drawing.Point(13, 162);
			this.btPlay.Name = "btPlay";
			this.btPlay.Size = new System.Drawing.Size(60, 24);
			this.btPlay.TabIndex = 9;
			this.btPlay.UseVisualStyleBackColor = true;
			this.btPlay.Click += new System.EventHandler(this.btPlay_Click);
			// 
			// btPause
			// 
			this.btPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btPause.Image = global::MyMediaPlayer.Properties.Resources.pasue;
			this.btPause.Location = new System.Drawing.Point(79, 163);
			this.btPause.Name = "btPause";
			this.btPause.Size = new System.Drawing.Size(60, 23);
			this.btPause.TabIndex = 10;
			this.btPause.UseVisualStyleBackColor = true;
			this.btPause.Click += new System.EventHandler(this.btPause_Click);
			// 
			// btPrevious
			// 
			this.btPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btPrevious.Image = global::MyMediaPlayer.Properties.Resources.previous;
			this.btPrevious.Location = new System.Drawing.Point(146, 163);
			this.btPrevious.Name = "btPrevious";
			this.btPrevious.Size = new System.Drawing.Size(60, 23);
			this.btPrevious.TabIndex = 11;
			this.btPrevious.UseVisualStyleBackColor = true;
			this.btPrevious.Click += new System.EventHandler(this.btPrevious_Click);
			// 
			// btNext
			// 
			this.btNext.BackColor = System.Drawing.Color.Transparent;
			this.btNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btNext.Image = global::MyMediaPlayer.Properties.Resources.next;
			this.btNext.Location = new System.Drawing.Point(212, 163);
			this.btNext.Name = "btNext";
			this.btNext.Size = new System.Drawing.Size(60, 23);
			this.btNext.TabIndex = 12;
			this.btNext.UseVisualStyleBackColor = false;
			this.btNext.Click += new System.EventHandler(this.btNext_Click);
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(278, 164);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(25, 23);
			this.label4.TabIndex = 13;
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblVolume
			// 
			this.lblVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblVolume.Location = new System.Drawing.Point(495, 164);
			this.lblVolume.Name = "lblVolume";
			this.lblVolume.Size = new System.Drawing.Size(36, 23);
			this.lblVolume.TabIndex = 15;
			this.lblVolume.Text = "70";
			this.lblVolume.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// toolTip1
			// 
			this.toolTip1.AutomaticDelay = 0;
			// 
			// lbCurrDuration
			// 
			this.lbCurrDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbCurrDuration.Location = new System.Drawing.Point(472, 222);
			this.lbCurrDuration.Name = "lbCurrDuration";
			this.lbCurrDuration.Size = new System.Drawing.Size(67, 23);
			this.lbCurrDuration.TabIndex = 17;
			this.lbCurrDuration.Text = "00:00";
			this.lbCurrDuration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// timer3
			// 
			this.timer3.Interval = 1000;
			this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
			// 
			// timer2
			// 
			this.timer2.Interval = 50;
			this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
			// 
			// pbLeft
			// 
			this.pbLeft.Location = new System.Drawing.Point(427, 545);
			this.pbLeft.Name = "pbLeft";
			this.pbLeft.Size = new System.Drawing.Size(112, 20);
			this.pbLeft.TabIndex = 19;
			// 
			// pbRight
			// 
			this.pbRight.Location = new System.Drawing.Point(427, 571);
			this.pbRight.Name = "pbRight";
			this.pbRight.Size = new System.Drawing.Size(112, 20);
			this.pbRight.TabIndex = 20;
			// 
			// comboBox1
			// 
			this.comboBox1.Enabled = false;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(427, 601);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(112, 21);
			this.comboBox1.TabIndex = 21;
			// 
			// chart1
			// 
			chartArea1.Name = "ChartArea1";
			this.chart1.ChartAreas.Add(chartArea1);
			this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.chart1.Location = new System.Drawing.Point(3, 3);
			this.chart1.Name = "chart1";
			this.chart1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.chart1.Size = new System.Drawing.Size(405, 74);
			this.chart1.TabIndex = 22;
			this.chart1.Text = "chart1";
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(6, 523);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(419, 106);
			this.tabControl1.TabIndex = 23;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.elementHost1);
			this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(411, 80);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Spectrum";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// elementHost1
			// 
			this.elementHost1.BackColor = System.Drawing.Color.Transparent;
			this.elementHost1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.elementHost1.Location = new System.Drawing.Point(3, 3);
			this.elementHost1.Name = "elementHost1";
			this.elementHost1.Size = new System.Drawing.Size(405, 74);
			this.elementHost1.TabIndex = 0;
			this.elementHost1.Text = "elementHost1";
			this.elementHost1.Child = this.spectrum1;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.chart1);
			this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(411, 80);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Chart";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// lbPlaying
			// 
			this.lbPlaying.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbPlaying.Location = new System.Drawing.Point(12, 200);
			this.lbPlaying.Name = "lbPlaying";
			this.lbPlaying.Size = new System.Drawing.Size(520, 15);
			this.lbPlaying.TabIndex = 24;
			// 
			// hScrollBar1
			// 
			this.hScrollBar1.BackColor = System.Drawing.Color.Transparent;
			this.hScrollBar1.LargeChange = 1;
			this.hScrollBar1.Location = new System.Drawing.Point(15, 222);
			this.hScrollBar1.Maximum = 300;
			this.hScrollBar1.MouseWheelBarPartitions = 1;
			this.hScrollBar1.Name = "hScrollBar1";
			this.hScrollBar1.Size = new System.Drawing.Size(462, 23);
			this.hScrollBar1.TabIndex = 28;
			this.hScrollBar1.Text = "metroTrackBar1";
			this.hScrollBar1.Value = 0;
			this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
			// 
			// tbVolume
			// 
			this.tbVolume.BackColor = System.Drawing.Color.Transparent;
			this.tbVolume.Location = new System.Drawing.Point(319, 164);
			this.tbVolume.Name = "tbVolume";
			this.tbVolume.Size = new System.Drawing.Size(170, 23);
			this.tbVolume.TabIndex = 29;
			this.tbVolume.Text = "metroTrackBar1";
			this.tbVolume.Scroll += new System.Windows.Forms.ScrollEventHandler(this.tbVolume_Scroll);
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(548, 635);
			this.Controls.Add(this.tbVolume);
			this.Controls.Add(this.hScrollBar1);
			this.Controls.Add(this.lbPlaying);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.pbRight);
			this.Controls.Add(this.pbLeft);
			this.Controls.Add(this.lbCurrDuration);
			this.Controls.Add(this.lblVolume);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btNext);
			this.Controls.Add(this.btPrevious);
			this.Controls.Add(this.btPause);
			this.Controls.Add(this.btPlay);
			this.Controls.Add(this.lvPlaylist);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.Name = "frmMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "My Media Player";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.contextMenuStrip1.ResumeLayout(false);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.ListView lvPlaylist;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem addFolderToolStripMenuItem;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lbName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lbDuration;
		private System.Windows.Forms.Label lbBirate;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btPlay;
		private System.Windows.Forms.Button btPause;
		private System.Windows.Forms.Button btPrevious;
		private System.Windows.Forms.Button btNext;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lblVolume;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.Label lbCurrDuration;
		private System.Windows.Forms.Timer timer3;
		private System.Windows.Forms.Timer timer2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label lbFilePath;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label lbSize;
		private System.Windows.Forms.ProgressBar pbLeft;
		private System.Windows.Forms.ProgressBar pbRight;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem propertiesToolStripMenuItem;
		private System.Windows.Forms.Integration.ElementHost elementHost1;
		private Spectrum spectrum1;
		private System.Windows.Forms.ToolStripMenuItem playToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem themeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem darkThemeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem defaultToolStripMenuItem;
		private System.Windows.Forms.Label lbPlaying;
		public System.Windows.Forms.ColumnHeader columnHeader4;
		private MetroFramework.Controls.MetroTrackBar hScrollBar1;
		private MetroFramework.Controls.MetroTrackBar tbVolume;
	}
}

