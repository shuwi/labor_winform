namespace LaborStackApp.Modal
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.workerData_backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.app_statusStrip = new System.Windows.Forms.StatusStrip();
            this.sys_status_toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.site_linkLabel = new System.Windows.Forms.LinkLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.team_dataGridView = new System.Windows.Forms.DataGridView();
            this.del_team_button = new System.Windows.Forms.Button();
            this.team_modify_button = new System.Windows.Forms.Button();
            this.team_add_button = new System.Windows.Forms.Button();
            this.group_flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.groupname_search_textBox = new System.Windows.Forms.TextBox();
            this.group_search_pictureBox = new System.Windows.Forms.PictureBox();
            this.group_projects_comboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.workers_dataGridView = new System.Windows.Forms.DataGridView();
            this.workers_projects_comboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.worker_del_button = new System.Windows.Forms.Button();
            this.workers_modify_button = new System.Windows.Forms.Button();
            this.worker_add_button = new System.Windows.Forms.Button();
            this.worker_flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.worker_search_keyword_textBox = new System.Windows.Forms.TextBox();
            this.worker_search_pictureBox = new System.Windows.Forms.PictureBox();
            this.workers_pageUserControl = new LaborStackApp.Toolkits.PageUserControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.manager_dataGridView = new System.Windows.Forms.DataGridView();
            this.manager_comboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.manager_del_button = new System.Windows.Forms.Button();
            this.manager_modify_button = new System.Windows.Forms.Button();
            this.manager_add_button = new System.Windows.Forms.Button();
            this.manager_flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.manager_search_textBox = new System.Windows.Forms.TextBox();
            this.manager_search_pictureBox = new System.Windows.Forms.PictureBox();
            this.manager_pageUserControl = new LaborStackApp.Toolkits.PageUserControl();
            this.mainForm_ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.group_backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.manager_backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.app_statusStrip.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.team_dataGridView)).BeginInit();
            this.group_flowLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.group_search_pictureBox)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workers_dataGridView)).BeginInit();
            this.worker_flowLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.worker_search_pictureBox)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.manager_dataGridView)).BeginInit();
            this.manager_flowLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.manager_search_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // workerData_backgroundWorker
            // 
            this.workerData_backgroundWorker.WorkerReportsProgress = true;
            this.workerData_backgroundWorker.WorkerSupportsCancellation = true;
            this.workerData_backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.workerData_backgroundWorker_DoWork);
            // 
            // app_statusStrip
            // 
            this.app_statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sys_status_toolStripStatusLabel});
            this.app_statusStrip.Location = new System.Drawing.Point(0, 498);
            this.app_statusStrip.Name = "app_statusStrip";
            this.app_statusStrip.Size = new System.Drawing.Size(882, 25);
            this.app_statusStrip.SizingGrip = false;
            this.app_statusStrip.TabIndex = 0;
            this.app_statusStrip.Text = "statusStrip1";
            // 
            // sys_status_toolStripStatusLabel
            // 
            this.sys_status_toolStripStatusLabel.BackColor = System.Drawing.Color.Transparent;
            this.sys_status_toolStripStatusLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.sys_status_toolStripStatusLabel.Margin = new System.Windows.Forms.Padding(4);
            this.sys_status_toolStripStatusLabel.Name = "sys_status_toolStripStatusLabel";
            this.sys_status_toolStripStatusLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.sys_status_toolStripStatusLabel.Size = new System.Drawing.Size(68, 17);
            this.sys_status_toolStripStatusLabel.Text = "系统已就绪";
            // 
            // site_linkLabel
            // 
            this.site_linkLabel.AutoSize = true;
            this.site_linkLabel.BackColor = System.Drawing.SystemColors.Control;
            this.site_linkLabel.LinkColor = System.Drawing.Color.DimGray;
            this.site_linkLabel.Location = new System.Drawing.Point(971, 503);
            this.site_linkLabel.Name = "site_linkLabel";
            this.site_linkLabel.Size = new System.Drawing.Size(56, 17);
            this.site_linkLabel.TabIndex = 1;
            this.site_linkLabel.TabStop = true;
            this.site_linkLabel.Text = "访问官网";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.ItemSize = new System.Drawing.Size(120, 25);
            this.tabControl1.Location = new System.Drawing.Point(-5, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(897, 488);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.team_dataGridView);
            this.tabPage1.Controls.Add(this.del_team_button);
            this.tabPage1.Controls.Add(this.team_modify_button);
            this.tabPage1.Controls.Add(this.team_add_button);
            this.tabPage1.Controls.Add(this.group_flowLayoutPanel);
            this.tabPage1.Controls.Add(this.group_projects_comboBox);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(889, 455);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "班组列表";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // team_dataGridView
            // 
            this.team_dataGridView.AllowUserToAddRows = false;
            this.team_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.team_dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.team_dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.team_dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.team_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.team_dataGridView.GridColor = System.Drawing.SystemColors.ControlLight;
            this.team_dataGridView.Location = new System.Drawing.Point(16, 64);
            this.team_dataGridView.Name = "team_dataGridView";
            this.team_dataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.team_dataGridView.RowTemplate.Height = 23;
            this.team_dataGridView.Size = new System.Drawing.Size(855, 373);
            this.team_dataGridView.TabIndex = 6;
            // 
            // del_team_button
            // 
            this.del_team_button.BackColor = System.Drawing.Color.Crimson;
            this.del_team_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.del_team_button.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.del_team_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.del_team_button.ForeColor = System.Drawing.Color.White;
            this.del_team_button.Location = new System.Drawing.Point(767, 13);
            this.del_team_button.Name = "del_team_button";
            this.del_team_button.Size = new System.Drawing.Size(104, 30);
            this.del_team_button.TabIndex = 5;
            this.del_team_button.Text = "删除";
            this.del_team_button.UseVisualStyleBackColor = false;
            this.del_team_button.Click += new System.EventHandler(this.del_team_button_Click);
            // 
            // team_modify_button
            // 
            this.team_modify_button.BackColor = System.Drawing.Color.YellowGreen;
            this.team_modify_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.team_modify_button.FlatAppearance.BorderColor = System.Drawing.Color.YellowGreen;
            this.team_modify_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.team_modify_button.ForeColor = System.Drawing.Color.White;
            this.team_modify_button.Location = new System.Drawing.Point(647, 13);
            this.team_modify_button.Name = "team_modify_button";
            this.team_modify_button.Size = new System.Drawing.Size(104, 30);
            this.team_modify_button.TabIndex = 4;
            this.team_modify_button.Text = "修改";
            this.team_modify_button.UseVisualStyleBackColor = false;
            this.team_modify_button.Click += new System.EventHandler(this.team_modify_button_Click);
            // 
            // team_add_button
            // 
            this.team_add_button.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.team_add_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.team_add_button.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.team_add_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.team_add_button.ForeColor = System.Drawing.Color.White;
            this.team_add_button.Location = new System.Drawing.Point(527, 13);
            this.team_add_button.Name = "team_add_button";
            this.team_add_button.Size = new System.Drawing.Size(104, 30);
            this.team_add_button.TabIndex = 3;
            this.team_add_button.Text = "添加";
            this.team_add_button.UseVisualStyleBackColor = false;
            this.team_add_button.Click += new System.EventHandler(this.team_add_button_Click);
            // 
            // group_flowLayoutPanel
            // 
            this.group_flowLayoutPanel.Controls.Add(this.groupname_search_textBox);
            this.group_flowLayoutPanel.Controls.Add(this.group_search_pictureBox);
            this.group_flowLayoutPanel.Location = new System.Drawing.Point(316, 14);
            this.group_flowLayoutPanel.Name = "group_flowLayoutPanel";
            this.group_flowLayoutPanel.Size = new System.Drawing.Size(193, 28);
            this.group_flowLayoutPanel.TabIndex = 2;
            this.group_flowLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.group_flowLayoutPanel_Paint);
            // 
            // groupname_search_textBox
            // 
            this.groupname_search_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.groupname_search_textBox.Location = new System.Drawing.Point(3, 6);
            this.groupname_search_textBox.Margin = new System.Windows.Forms.Padding(3, 6, 2, 3);
            this.groupname_search_textBox.Name = "groupname_search_textBox";
            this.groupname_search_textBox.Size = new System.Drawing.Size(164, 16);
            this.groupname_search_textBox.TabIndex = 0;
            // 
            // group_search_pictureBox
            // 
            this.group_search_pictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("group_search_pictureBox.BackgroundImage")));
            this.group_search_pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.group_search_pictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.group_search_pictureBox.Location = new System.Drawing.Point(172, 6);
            this.group_search_pictureBox.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.group_search_pictureBox.Name = "group_search_pictureBox";
            this.group_search_pictureBox.Size = new System.Drawing.Size(16, 16);
            this.group_search_pictureBox.TabIndex = 1;
            this.group_search_pictureBox.TabStop = false;
            this.group_search_pictureBox.Click += new System.EventHandler(this.group_search_pictureBox_Click);
            // 
            // group_projects_comboBox
            // 
            this.group_projects_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.group_projects_comboBox.FormattingEnabled = true;
            this.group_projects_comboBox.Location = new System.Drawing.Point(75, 15);
            this.group_projects_comboBox.Name = "group_projects_comboBox";
            this.group_projects_comboBox.Size = new System.Drawing.Size(226, 25);
            this.group_projects_comboBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "所在项目";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.workers_dataGridView);
            this.tabPage2.Controls.Add(this.workers_projects_comboBox);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.worker_del_button);
            this.tabPage2.Controls.Add(this.workers_modify_button);
            this.tabPage2.Controls.Add(this.worker_add_button);
            this.tabPage2.Controls.Add(this.worker_flowLayoutPanel);
            this.tabPage2.Controls.Add(this.workers_pageUserControl);
            this.tabPage2.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(889, 455);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "工人列表";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // workers_dataGridView
            // 
            this.workers_dataGridView.AllowUserToAddRows = false;
            this.workers_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.workers_dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.workers_dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.workers_dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.workers_dataGridView.ColumnHeadersHeight = 30;
            this.workers_dataGridView.GridColor = System.Drawing.SystemColors.ControlLight;
            this.workers_dataGridView.Location = new System.Drawing.Point(13, 64);
            this.workers_dataGridView.Name = "workers_dataGridView";
            this.workers_dataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.workers_dataGridView.RowTemplate.Height = 45;
            this.workers_dataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.workers_dataGridView.Size = new System.Drawing.Size(858, 323);
            this.workers_dataGridView.TabIndex = 13;
            // 
            // workers_projects_comboBox
            // 
            this.workers_projects_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.workers_projects_comboBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.workers_projects_comboBox.FormattingEnabled = true;
            this.workers_projects_comboBox.Location = new System.Drawing.Point(75, 15);
            this.workers_projects_comboBox.Name = "workers_projects_comboBox";
            this.workers_projects_comboBox.Size = new System.Drawing.Size(226, 25);
            this.workers_projects_comboBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "所在项目";
            // 
            // worker_del_button
            // 
            this.worker_del_button.BackColor = System.Drawing.Color.Crimson;
            this.worker_del_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.worker_del_button.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.worker_del_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.worker_del_button.ForeColor = System.Drawing.Color.White;
            this.worker_del_button.Location = new System.Drawing.Point(767, 13);
            this.worker_del_button.Name = "worker_del_button";
            this.worker_del_button.Size = new System.Drawing.Size(104, 30);
            this.worker_del_button.TabIndex = 11;
            this.worker_del_button.Text = "删除";
            this.worker_del_button.UseVisualStyleBackColor = false;
            this.worker_del_button.Click += new System.EventHandler(this.worker_del_button_Click);
            // 
            // workers_modify_button
            // 
            this.workers_modify_button.BackColor = System.Drawing.Color.YellowGreen;
            this.workers_modify_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.workers_modify_button.FlatAppearance.BorderColor = System.Drawing.Color.YellowGreen;
            this.workers_modify_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.workers_modify_button.ForeColor = System.Drawing.Color.White;
            this.workers_modify_button.Location = new System.Drawing.Point(647, 13);
            this.workers_modify_button.Name = "workers_modify_button";
            this.workers_modify_button.Size = new System.Drawing.Size(104, 30);
            this.workers_modify_button.TabIndex = 10;
            this.workers_modify_button.Text = "修改";
            this.workers_modify_button.UseVisualStyleBackColor = false;
            this.workers_modify_button.Click += new System.EventHandler(this.workers_modify_button_Click);
            // 
            // worker_add_button
            // 
            this.worker_add_button.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.worker_add_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.worker_add_button.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.worker_add_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.worker_add_button.ForeColor = System.Drawing.Color.White;
            this.worker_add_button.Location = new System.Drawing.Point(527, 13);
            this.worker_add_button.Name = "worker_add_button";
            this.worker_add_button.Size = new System.Drawing.Size(104, 30);
            this.worker_add_button.TabIndex = 9;
            this.worker_add_button.Text = "添加";
            this.worker_add_button.UseVisualStyleBackColor = false;
            this.worker_add_button.Click += new System.EventHandler(this.worker_add_button_Click);
            // 
            // worker_flowLayoutPanel
            // 
            this.worker_flowLayoutPanel.Controls.Add(this.worker_search_keyword_textBox);
            this.worker_flowLayoutPanel.Controls.Add(this.worker_search_pictureBox);
            this.worker_flowLayoutPanel.Location = new System.Drawing.Point(316, 14);
            this.worker_flowLayoutPanel.Name = "worker_flowLayoutPanel";
            this.worker_flowLayoutPanel.Size = new System.Drawing.Size(193, 28);
            this.worker_flowLayoutPanel.TabIndex = 8;
            this.worker_flowLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.worker_flowLayoutPanel_Paint);
            // 
            // worker_search_keyword_textBox
            // 
            this.worker_search_keyword_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.worker_search_keyword_textBox.Location = new System.Drawing.Point(3, 6);
            this.worker_search_keyword_textBox.Margin = new System.Windows.Forms.Padding(3, 6, 2, 3);
            this.worker_search_keyword_textBox.Name = "worker_search_keyword_textBox";
            this.worker_search_keyword_textBox.Size = new System.Drawing.Size(164, 16);
            this.worker_search_keyword_textBox.TabIndex = 0;
            this.mainForm_ToolTip.SetToolTip(this.worker_search_keyword_textBox, "输入工人姓名或身份证号码查询");
            // 
            // worker_search_pictureBox
            // 
            this.worker_search_pictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("worker_search_pictureBox.BackgroundImage")));
            this.worker_search_pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.worker_search_pictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.worker_search_pictureBox.Location = new System.Drawing.Point(172, 6);
            this.worker_search_pictureBox.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.worker_search_pictureBox.Name = "worker_search_pictureBox";
            this.worker_search_pictureBox.Size = new System.Drawing.Size(16, 16);
            this.worker_search_pictureBox.TabIndex = 1;
            this.worker_search_pictureBox.TabStop = false;
            this.mainForm_ToolTip.SetToolTip(this.worker_search_pictureBox, "点击查询");
            this.worker_search_pictureBox.Click += new System.EventHandler(this.worker_search_pictureBox_Click);
            // 
            // workers_pageUserControl
            // 
            this.workers_pageUserControl.BackColor = System.Drawing.Color.White;
            this.workers_pageUserControl.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.workers_pageUserControl.Location = new System.Drawing.Point(202, 403);
            this.workers_pageUserControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.workers_pageUserControl.Name = "workers_pageUserControl";
            this.workers_pageUserControl.PageIndex = 1;
            this.workers_pageUserControl.PageSize = 20;
            this.workers_pageUserControl.RecordCount = 0;
            this.workers_pageUserControl.Size = new System.Drawing.Size(669, 45);
            this.workers_pageUserControl.TabIndex = 12;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.manager_dataGridView);
            this.tabPage3.Controls.Add(this.manager_comboBox);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.manager_del_button);
            this.tabPage3.Controls.Add(this.manager_modify_button);
            this.tabPage3.Controls.Add(this.manager_add_button);
            this.tabPage3.Controls.Add(this.manager_flowLayoutPanel);
            this.tabPage3.Controls.Add(this.manager_pageUserControl);
            this.tabPage3.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(889, 455);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "管理人员列表";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // manager_dataGridView
            // 
            this.manager_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.manager_dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.manager_dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.manager_dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.manager_dataGridView.ColumnHeadersHeight = 30;
            this.manager_dataGridView.GridColor = System.Drawing.SystemColors.ControlLight;
            this.manager_dataGridView.Location = new System.Drawing.Point(15, 61);
            this.manager_dataGridView.Name = "manager_dataGridView";
            this.manager_dataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.manager_dataGridView.RowTemplate.Height = 45;
            this.manager_dataGridView.Size = new System.Drawing.Size(858, 323);
            this.manager_dataGridView.TabIndex = 19;
            // 
            // manager_comboBox
            // 
            this.manager_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.manager_comboBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.manager_comboBox.FormattingEnabled = true;
            this.manager_comboBox.Location = new System.Drawing.Point(75, 15);
            this.manager_comboBox.Name = "manager_comboBox";
            this.manager_comboBox.Size = new System.Drawing.Size(226, 25);
            this.manager_comboBox.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "所在项目";
            // 
            // manager_del_button
            // 
            this.manager_del_button.BackColor = System.Drawing.Color.Crimson;
            this.manager_del_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.manager_del_button.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.manager_del_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manager_del_button.ForeColor = System.Drawing.Color.White;
            this.manager_del_button.Location = new System.Drawing.Point(767, 13);
            this.manager_del_button.Name = "manager_del_button";
            this.manager_del_button.Size = new System.Drawing.Size(104, 30);
            this.manager_del_button.TabIndex = 17;
            this.manager_del_button.Text = "删除";
            this.manager_del_button.UseVisualStyleBackColor = false;
            this.manager_del_button.Click += new System.EventHandler(this.manager_del_button_Click);
            // 
            // manager_modify_button
            // 
            this.manager_modify_button.BackColor = System.Drawing.Color.YellowGreen;
            this.manager_modify_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.manager_modify_button.FlatAppearance.BorderColor = System.Drawing.Color.YellowGreen;
            this.manager_modify_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manager_modify_button.ForeColor = System.Drawing.Color.White;
            this.manager_modify_button.Location = new System.Drawing.Point(647, 13);
            this.manager_modify_button.Name = "manager_modify_button";
            this.manager_modify_button.Size = new System.Drawing.Size(104, 30);
            this.manager_modify_button.TabIndex = 16;
            this.manager_modify_button.Text = "修改";
            this.manager_modify_button.UseVisualStyleBackColor = false;
            this.manager_modify_button.Click += new System.EventHandler(this.manager_modify_button_Click);
            // 
            // manager_add_button
            // 
            this.manager_add_button.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.manager_add_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.manager_add_button.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.manager_add_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manager_add_button.ForeColor = System.Drawing.Color.White;
            this.manager_add_button.Location = new System.Drawing.Point(527, 13);
            this.manager_add_button.Name = "manager_add_button";
            this.manager_add_button.Size = new System.Drawing.Size(104, 30);
            this.manager_add_button.TabIndex = 15;
            this.manager_add_button.Text = "添加";
            this.manager_add_button.UseVisualStyleBackColor = false;
            this.manager_add_button.Click += new System.EventHandler(this.manager_add_button_Click);
            // 
            // manager_flowLayoutPanel
            // 
            this.manager_flowLayoutPanel.Controls.Add(this.manager_search_textBox);
            this.manager_flowLayoutPanel.Controls.Add(this.manager_search_pictureBox);
            this.manager_flowLayoutPanel.Location = new System.Drawing.Point(316, 14);
            this.manager_flowLayoutPanel.Name = "manager_flowLayoutPanel";
            this.manager_flowLayoutPanel.Size = new System.Drawing.Size(193, 28);
            this.manager_flowLayoutPanel.TabIndex = 14;
            this.manager_flowLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.manager_flowLayoutPanel_Paint);
            // 
            // manager_search_textBox
            // 
            this.manager_search_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.manager_search_textBox.Location = new System.Drawing.Point(3, 6);
            this.manager_search_textBox.Margin = new System.Windows.Forms.Padding(3, 6, 2, 3);
            this.manager_search_textBox.Name = "manager_search_textBox";
            this.manager_search_textBox.Size = new System.Drawing.Size(164, 16);
            this.manager_search_textBox.TabIndex = 0;
            this.mainForm_ToolTip.SetToolTip(this.manager_search_textBox, "请输入管理人员姓名或身份证号查询");
            // 
            // manager_search_pictureBox
            // 
            this.manager_search_pictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("manager_search_pictureBox.BackgroundImage")));
            this.manager_search_pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.manager_search_pictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.manager_search_pictureBox.Location = new System.Drawing.Point(172, 6);
            this.manager_search_pictureBox.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.manager_search_pictureBox.Name = "manager_search_pictureBox";
            this.manager_search_pictureBox.Size = new System.Drawing.Size(16, 16);
            this.manager_search_pictureBox.TabIndex = 1;
            this.manager_search_pictureBox.TabStop = false;
            this.manager_search_pictureBox.Click += new System.EventHandler(this.manager_search_pictureBox_Click);
            // 
            // manager_pageUserControl
            // 
            this.manager_pageUserControl.BackColor = System.Drawing.Color.White;
            this.manager_pageUserControl.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.manager_pageUserControl.Location = new System.Drawing.Point(202, 403);
            this.manager_pageUserControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.manager_pageUserControl.Name = "manager_pageUserControl";
            this.manager_pageUserControl.PageIndex = 1;
            this.manager_pageUserControl.PageSize = 20;
            this.manager_pageUserControl.RecordCount = 0;
            this.manager_pageUserControl.Size = new System.Drawing.Size(669, 45);
            this.manager_pageUserControl.TabIndex = 18;
            // 
            // group_backgroundWorker
            // 
            this.group_backgroundWorker.WorkerReportsProgress = true;
            this.group_backgroundWorker.WorkerSupportsCancellation = true;
            this.group_backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.group_backgroundWorker_DoWork);
            // 
            // manager_backgroundWorker
            // 
            this.manager_backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.manager_backgroundWorker_DoWork);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(882, 523);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.site_linkLabel);
            this.Controls.Add(this.app_statusStrip);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "建筑工人实名信息采集端";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.app_statusStrip.ResumeLayout(false);
            this.app_statusStrip.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.team_dataGridView)).EndInit();
            this.group_flowLayoutPanel.ResumeLayout(false);
            this.group_flowLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.group_search_pictureBox)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workers_dataGridView)).EndInit();
            this.worker_flowLayoutPanel.ResumeLayout(false);
            this.worker_flowLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.worker_search_pictureBox)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.manager_dataGridView)).EndInit();
            this.manager_flowLayoutPanel.ResumeLayout(false);
            this.manager_flowLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.manager_search_pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker workerData_backgroundWorker;
        private System.Windows.Forms.StatusStrip app_statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel sys_status_toolStripStatusLabel;
        private System.Windows.Forms.LinkLabel site_linkLabel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.FlowLayoutPanel group_flowLayoutPanel;
        private System.Windows.Forms.TextBox groupname_search_textBox;
        private System.Windows.Forms.PictureBox group_search_pictureBox;
        private System.Windows.Forms.ComboBox group_projects_comboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button del_team_button;
        private System.Windows.Forms.Button team_modify_button;
        private System.Windows.Forms.Button team_add_button;
        private System.Windows.Forms.DataGridView team_dataGridView;
        private System.Windows.Forms.ComboBox workers_projects_comboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button worker_del_button;
        private System.Windows.Forms.Button workers_modify_button;
        private System.Windows.Forms.Button worker_add_button;
        private System.Windows.Forms.FlowLayoutPanel worker_flowLayoutPanel;
        private System.Windows.Forms.TextBox worker_search_keyword_textBox;
        private System.Windows.Forms.PictureBox worker_search_pictureBox;
        private Toolkits.PageUserControl workers_pageUserControl;
        private System.Windows.Forms.DataGridView workers_dataGridView;
        private System.Windows.Forms.ComboBox manager_comboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button manager_del_button;
        private System.Windows.Forms.Button manager_modify_button;
        private System.Windows.Forms.Button manager_add_button;
        private System.Windows.Forms.FlowLayoutPanel manager_flowLayoutPanel;
        private System.Windows.Forms.TextBox manager_search_textBox;
        private System.Windows.Forms.PictureBox manager_search_pictureBox;
        private System.Windows.Forms.DataGridView manager_dataGridView;
        private Toolkits.PageUserControl manager_pageUserControl;
        private System.Windows.Forms.ToolTip mainForm_ToolTip;
        private System.ComponentModel.BackgroundWorker group_backgroundWorker;
        private System.ComponentModel.BackgroundWorker manager_backgroundWorker;
    }
}