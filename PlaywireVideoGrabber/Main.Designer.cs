namespace PlaywireVideoGrabber
{
    partial class Linker
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
            this.LinkerStatus = new System.Windows.Forms.StatusStrip();
            this.LinkerStatusInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.LinkerMenu = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.RadioBtnHd = new System.Windows.Forms.RadioButton();
            this.RadioBtnStandard = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.BackgroundLinker = new System.ComponentModel.BackgroundWorker();
            this.LinkerProgress = new System.Windows.Forms.ProgressBar();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.BtnCheckUncheck = new System.Windows.Forms.Button();
            this.BtnRemoveSerial = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtCustomHeaders = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTemplateLinkBaseUrl = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTemplateRegex = new System.Windows.Forms.TextBox();
            this.txtTemplateDateFormat = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.LinkSize = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnAddSerial = new System.Windows.Forms.Button();
            this.TxtSerialTemplate = new System.Windows.Forms.TextBox();
            this.TxtSerialName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CheckedSerials = new System.Windows.Forms.CheckedListBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.TxtCustomUrlHeaders = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.checkCustomUrl = new System.Windows.Forms.CheckBox();
            this.txtCustomUrl = new System.Windows.Forms.TextBox();
            this.TextOutput = new System.Windows.Forms.RichTextBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.DateSelector = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.LinkerTab = new System.Windows.Forms.TabControl();
            this.LinkerStatus.SuspendLayout();
            this.LinkerMenu.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LinkSize)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.LinkerTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // LinkerStatus
            // 
            this.LinkerStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LinkerStatusInfo});
            this.LinkerStatus.Location = new System.Drawing.Point(0, 483);
            this.LinkerStatus.Name = "LinkerStatus";
            this.LinkerStatus.Size = new System.Drawing.Size(571, 22);
            this.LinkerStatus.TabIndex = 1;
            this.LinkerStatus.Text = "LinkerStatus";
            // 
            // LinkerStatusInfo
            // 
            this.LinkerStatusInfo.Name = "LinkerStatusInfo";
            this.LinkerStatusInfo.Size = new System.Drawing.Size(0, 17);
            // 
            // LinkerMenu
            // 
            this.LinkerMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.LinkerMenu.Location = new System.Drawing.Point(0, 0);
            this.LinkerMenu.Name = "LinkerMenu";
            this.LinkerMenu.Size = new System.Drawing.Size(571, 24);
            this.LinkerMenu.TabIndex = 2;
            this.LinkerMenu.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem1,
            this.aboutToolStripMenuItem1});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.helpToolStripMenuItem.Text = "Info";
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.helpToolStripMenuItem1.Text = "Help";
            this.helpToolStripMenuItem1.Click += new System.EventHandler(this.helpToolStripMenuItem1_Click);
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // RadioBtnHd
            // 
            this.RadioBtnHd.AutoSize = true;
            this.RadioBtnHd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RadioBtnHd.Location = new System.Drawing.Point(214, 13);
            this.RadioBtnHd.Name = "RadioBtnHd";
            this.RadioBtnHd.Size = new System.Drawing.Size(40, 17);
            this.RadioBtnHd.TabIndex = 2;
            this.RadioBtnHd.Text = "HD";
            this.RadioBtnHd.UseVisualStyleBackColor = true;
            this.RadioBtnHd.CheckedChanged += new System.EventHandler(this.VideoQualityChanged);
            // 
            // RadioBtnStandard
            // 
            this.RadioBtnStandard.AutoSize = true;
            this.RadioBtnStandard.Checked = true;
            this.RadioBtnStandard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RadioBtnStandard.Location = new System.Drawing.Point(123, 13);
            this.RadioBtnStandard.Name = "RadioBtnStandard";
            this.RadioBtnStandard.Size = new System.Drawing.Size(67, 17);
            this.RadioBtnStandard.TabIndex = 1;
            this.RadioBtnStandard.TabStop = true;
            this.RadioBtnStandard.Text = "Standard";
            this.RadioBtnStandard.UseVisualStyleBackColor = true;
            this.RadioBtnStandard.CheckedChanged += new System.EventHandler(this.VideoQualityChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Video Quality :";
            // 
            // BackgroundLinker
            // 
            this.BackgroundLinker.WorkerReportsProgress = true;
            this.BackgroundLinker.WorkerSupportsCancellation = true;
            // 
            // LinkerProgress
            // 
            this.LinkerProgress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LinkerProgress.Location = new System.Drawing.Point(5, 466);
            this.LinkerProgress.Name = "LinkerProgress";
            this.LinkerProgress.Size = new System.Drawing.Size(562, 14);
            this.LinkerProgress.Step = 1;
            this.LinkerProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.LinkerProgress.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.BtnCheckUncheck);
            this.tabPage2.Controls.Add(this.RadioBtnStandard);
            this.tabPage2.Controls.Add(this.BtnRemoveSerial);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.RadioBtnHd);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.CheckedSerials);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(562, 408);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Template";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // BtnCheckUncheck
            // 
            this.BtnCheckUncheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCheckUncheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCheckUncheck.Location = new System.Drawing.Point(283, 28);
            this.BtnCheckUncheck.Name = "BtnCheckUncheck";
            this.BtnCheckUncheck.Size = new System.Drawing.Size(126, 23);
            this.BtnCheckUncheck.TabIndex = 6;
            this.BtnCheckUncheck.Text = "Check/Uncheck All";
            this.BtnCheckUncheck.UseVisualStyleBackColor = true;
            this.BtnCheckUncheck.Click += new System.EventHandler(this.BtnCheckUncheck_Click);
            // 
            // BtnRemoveSerial
            // 
            this.BtnRemoveSerial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRemoveSerial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRemoveSerial.Location = new System.Drawing.Point(425, 28);
            this.BtnRemoveSerial.Name = "BtnRemoveSerial";
            this.BtnRemoveSerial.Size = new System.Drawing.Size(121, 23);
            this.BtnRemoveSerial.TabIndex = 5;
            this.BtnRemoveSerial.Text = "Remove Unchecked";
            this.BtnRemoveSerial.UseVisualStyleBackColor = true;
            this.BtnRemoveSerial.Click += new System.EventHandler(this.BtnRemoveSerial_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Select list of templates:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.TxtCustomHeaders);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtTemplateLinkBaseUrl);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtTemplateRegex);
            this.groupBox1.Controls.Add(this.txtTemplateDateFormat);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.LinkSize);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.BtnAddSerial);
            this.groupBox1.Controls.Add(this.TxtSerialTemplate);
            this.groupBox1.Controls.Add(this.TxtSerialName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(36, 227);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(510, 173);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add New Template";
            // 
            // TxtCustomHeaders
            // 
            this.TxtCustomHeaders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtCustomHeaders.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCustomHeaders.Location = new System.Drawing.Point(78, 124);
            this.TxtCustomHeaders.Name = "TxtCustomHeaders";
            this.TxtCustomHeaders.Size = new System.Drawing.Size(415, 20);
            this.TxtCustomHeaders.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 127);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Headers:";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(254, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Link Base Url:";
            // 
            // txtTemplateLinkBaseUrl
            // 
            this.txtTemplateLinkBaseUrl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtTemplateLinkBaseUrl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTemplateLinkBaseUrl.Location = new System.Drawing.Point(327, 98);
            this.txtTemplateLinkBaseUrl.Name = "txtTemplateLinkBaseUrl";
            this.txtTemplateLinkBaseUrl.Size = new System.Drawing.Size(166, 20);
            this.txtTemplateLinkBaseUrl.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Link Regex:";
            // 
            // txtTemplateRegex
            // 
            this.txtTemplateRegex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTemplateRegex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTemplateRegex.Location = new System.Drawing.Point(78, 98);
            this.txtTemplateRegex.Name = "txtTemplateRegex";
            this.txtTemplateRegex.Size = new System.Drawing.Size(173, 20);
            this.txtTemplateRegex.TabIndex = 11;
            // 
            // txtTemplateDateFormat
            // 
            this.txtTemplateDateFormat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTemplateDateFormat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTemplateDateFormat.Location = new System.Drawing.Point(78, 72);
            this.txtTemplateDateFormat.Name = "txtTemplateDateFormat";
            this.txtTemplateDateFormat.Size = new System.Drawing.Size(415, 20);
            this.txtTemplateDateFormat.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Date Format:";
            // 
            // LinkSize
            // 
            this.LinkSize.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LinkSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LinkSize.Location = new System.Drawing.Point(78, 149);
            this.LinkSize.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.LinkSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.LinkSize.Name = "LinkSize";
            this.LinkSize.Size = new System.Drawing.Size(48, 20);
            this.LinkSize.TabIndex = 6;
            this.LinkSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LinkSize.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "No of Links:";
            // 
            // BtnAddSerial
            // 
            this.BtnAddSerial.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BtnAddSerial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddSerial.Location = new System.Drawing.Point(389, 147);
            this.BtnAddSerial.Name = "BtnAddSerial";
            this.BtnAddSerial.Size = new System.Drawing.Size(104, 23);
            this.BtnAddSerial.TabIndex = 4;
            this.BtnAddSerial.Text = "Add/Update";
            this.BtnAddSerial.UseVisualStyleBackColor = true;
            this.BtnAddSerial.Click += new System.EventHandler(this.BtnAddSerial_Click);
            // 
            // TxtSerialTemplate
            // 
            this.TxtSerialTemplate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtSerialTemplate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtSerialTemplate.Location = new System.Drawing.Point(78, 46);
            this.TxtSerialTemplate.Name = "TxtSerialTemplate";
            this.TxtSerialTemplate.Size = new System.Drawing.Size(415, 20);
            this.TxtSerialTemplate.TabIndex = 3;
            // 
            // TxtSerialName
            // 
            this.TxtSerialName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtSerialName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtSerialName.Location = new System.Drawing.Point(78, 22);
            this.TxtSerialName.Name = "TxtSerialName";
            this.TxtSerialName.Size = new System.Drawing.Size(415, 20);
            this.TxtSerialName.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Template:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Title:";
            // 
            // CheckedSerials
            // 
            this.CheckedSerials.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CheckedSerials.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CheckedSerials.CheckOnClick = true;
            this.CheckedSerials.FormattingEnabled = true;
            this.CheckedSerials.Location = new System.Drawing.Point(36, 54);
            this.CheckedSerials.Name = "CheckedSerials";
            this.CheckedSerials.Size = new System.Drawing.Size(510, 167);
            this.CheckedSerials.TabIndex = 3;
            this.CheckedSerials.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.CheckedSerials_ItemCheck);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.TxtCustomUrlHeaders);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.checkCustomUrl);
            this.tabPage1.Controls.Add(this.txtCustomUrl);
            this.tabPage1.Controls.Add(this.TextOutput);
            this.tabPage1.Controls.Add(this.StartButton);
            this.tabPage1.Controls.Add(this.DateSelector);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(562, 408);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Output";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // TxtCustomUrlHeaders
            // 
            this.TxtCustomUrlHeaders.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCustomUrlHeaders.Enabled = false;
            this.TxtCustomUrlHeaders.Location = new System.Drawing.Point(110, 66);
            this.TxtCustomUrlHeaders.Name = "TxtCustomUrlHeaders";
            this.TxtCustomUrlHeaders.Size = new System.Drawing.Size(321, 20);
            this.TxtCustomUrlHeaders.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 69);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Custome Headers:";
            // 
            // checkCustomUrl
            // 
            this.checkCustomUrl.AutoSize = true;
            this.checkCustomUrl.Location = new System.Drawing.Point(12, 42);
            this.checkCustomUrl.Name = "checkCustomUrl";
            this.checkCustomUrl.Size = new System.Drawing.Size(80, 17);
            this.checkCustomUrl.TabIndex = 9;
            this.checkCustomUrl.Text = "Custom Url:";
            this.checkCustomUrl.UseVisualStyleBackColor = true;
            this.checkCustomUrl.CheckedChanged += new System.EventHandler(this.checkCustomUrl_CheckedChanged);
            // 
            // txtCustomUrl
            // 
            this.txtCustomUrl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCustomUrl.Enabled = false;
            this.txtCustomUrl.Location = new System.Drawing.Point(110, 40);
            this.txtCustomUrl.Name = "txtCustomUrl";
            this.txtCustomUrl.Size = new System.Drawing.Size(321, 20);
            this.txtCustomUrl.TabIndex = 8;
            // 
            // TextOutput
            // 
            this.TextOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextOutput.BackColor = System.Drawing.SystemColors.Window;
            this.TextOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextOutput.Location = new System.Drawing.Point(7, 92);
            this.TextOutput.Name = "TextOutput";
            this.TextOutput.ReadOnly = true;
            this.TextOutput.Size = new System.Drawing.Size(547, 310);
            this.TextOutput.TabIndex = 6;
            this.TextOutput.Text = "";
            this.TextOutput.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.TextOutput_LinkClicked);
            // 
            // StartButton
            // 
            this.StartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartButton.Location = new System.Drawing.Point(456, 64);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(98, 23);
            this.StartButton.TabIndex = 5;
            this.StartButton.Text = "Get links";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // DateSelector
            // 
            this.DateSelector.Cursor = System.Windows.Forms.Cursors.Default;
            this.DateSelector.Location = new System.Drawing.Point(110, 10);
            this.DateSelector.Name = "DateSelector";
            this.DateSelector.Size = new System.Drawing.Size(200, 20);
            this.DateSelector.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Date:";
            // 
            // LinkerTab
            // 
            this.LinkerTab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LinkerTab.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.LinkerTab.Controls.Add(this.tabPage1);
            this.LinkerTab.Controls.Add(this.tabPage2);
            this.LinkerTab.Location = new System.Drawing.Point(1, 27);
            this.LinkerTab.Name = "LinkerTab";
            this.LinkerTab.SelectedIndex = 0;
            this.LinkerTab.Size = new System.Drawing.Size(570, 437);
            this.LinkerTab.TabIndex = 5;
            // 
            // Linker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 505);
            this.Controls.Add(this.LinkerTab);
            this.Controls.Add(this.LinkerStatus);
            this.Controls.Add(this.LinkerMenu);
            this.Controls.Add(this.LinkerProgress);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.LinkerMenu;
            this.Name = "Linker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Playwire Video Grabber";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Linker_FormClosing);
            this.LinkerStatus.ResumeLayout(false);
            this.LinkerStatus.PerformLayout();
            this.LinkerMenu.ResumeLayout(false);
            this.LinkerMenu.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LinkSize)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.LinkerTab.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip LinkerStatus;
        private System.Windows.Forms.MenuStrip LinkerMenu;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        public System.ComponentModel.BackgroundWorker BackgroundLinker;
        private System.Windows.Forms.ProgressBar LinkerProgress;
        private System.Windows.Forms.ToolStripStatusLabel LinkerStatusInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton RadioBtnHd;
        private System.Windows.Forms.RadioButton RadioBtnStandard;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button BtnRemoveSerial;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTemplateRegex;
        private System.Windows.Forms.TextBox txtTemplateDateFormat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown LinkSize;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnAddSerial;
        private System.Windows.Forms.TextBox TxtSerialTemplate;
        private System.Windows.Forms.TextBox TxtSerialName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox CheckedSerials;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RichTextBox TextOutput;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.DateTimePicker DateSelector;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl LinkerTab;
        private System.Windows.Forms.TextBox txtCustomUrl;
        private System.Windows.Forms.CheckBox checkCustomUrl;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTemplateLinkBaseUrl;
        private System.Windows.Forms.Button BtnCheckUncheck;
        private System.Windows.Forms.TextBox TxtCustomHeaders;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtCustomUrlHeaders;
        private System.Windows.Forms.Label label11;
    }
}

