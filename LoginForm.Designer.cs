namespace LaborStackApp
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.label1 = new System.Windows.Forms.Label();
            this.username_flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.username_pictureBox = new System.Windows.Forms.PictureBox();
            this.username_textBox = new System.Windows.Forms.TextBox();
            this.remember_me_checkBox = new System.Windows.Forms.CheckBox();
            this.signin_button = new System.Windows.Forms.Button();
            this.password_flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.password_pictureBox = new System.Windows.Forms.PictureBox();
            this.password_textBox = new System.Windows.Forms.TextBox();
            this.site_linkLabel = new System.Windows.Forms.LinkLabel();
            this.username_flowLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.username_pictureBox)).BeginInit();
            this.password_flowLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.password_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(132, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "建筑工人实名信息采集端";
            // 
            // username_flowLayoutPanel
            // 
            this.username_flowLayoutPanel.Controls.Add(this.username_pictureBox);
            this.username_flowLayoutPanel.Controls.Add(this.username_textBox);
            this.username_flowLayoutPanel.Location = new System.Drawing.Point(101, 46);
            this.username_flowLayoutPanel.Name = "username_flowLayoutPanel";
            this.username_flowLayoutPanel.Padding = new System.Windows.Forms.Padding(2);
            this.username_flowLayoutPanel.Size = new System.Drawing.Size(217, 32);
            this.username_flowLayoutPanel.TabIndex = 1;
            this.username_flowLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.username_flowLayoutPanel_Paint);
            // 
            // username_pictureBox
            // 
            this.username_pictureBox.BackColor = System.Drawing.Color.Transparent;
            this.username_pictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("username_pictureBox.BackgroundImage")));
            this.username_pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.username_pictureBox.Location = new System.Drawing.Point(5, 8);
            this.username_pictureBox.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.username_pictureBox.Name = "username_pictureBox";
            this.username_pictureBox.Size = new System.Drawing.Size(16, 16);
            this.username_pictureBox.TabIndex = 0;
            this.username_pictureBox.TabStop = false;
            // 
            // username_textBox
            // 
            this.username_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.username_textBox.Location = new System.Drawing.Point(27, 8);
            this.username_textBox.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.username_textBox.MaxLength = 20;
            this.username_textBox.Name = "username_textBox";
            this.username_textBox.Size = new System.Drawing.Size(180, 16);
            this.username_textBox.TabIndex = 1;
            // 
            // remember_me_checkBox
            // 
            this.remember_me_checkBox.AutoSize = true;
            this.remember_me_checkBox.Location = new System.Drawing.Point(103, 136);
            this.remember_me_checkBox.Name = "remember_me_checkBox";
            this.remember_me_checkBox.Size = new System.Drawing.Size(75, 21);
            this.remember_me_checkBox.TabIndex = 3;
            this.remember_me_checkBox.Text = "记住账户";
            this.remember_me_checkBox.UseVisualStyleBackColor = true;
            // 
            // signin_button
            // 
            this.signin_button.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.signin_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signin_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signin_button.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.signin_button.ForeColor = System.Drawing.Color.White;
            this.signin_button.Location = new System.Drawing.Point(101, 173);
            this.signin_button.Name = "signin_button";
            this.signin_button.Size = new System.Drawing.Size(217, 37);
            this.signin_button.TabIndex = 4;
            this.signin_button.Text = "登   录";
            this.signin_button.UseVisualStyleBackColor = false;
            this.signin_button.Click += new System.EventHandler(this.signin_button_Click);
            // 
            // password_flowLayoutPanel
            // 
            this.password_flowLayoutPanel.Controls.Add(this.password_pictureBox);
            this.password_flowLayoutPanel.Controls.Add(this.password_textBox);
            this.password_flowLayoutPanel.Location = new System.Drawing.Point(101, 89);
            this.password_flowLayoutPanel.Name = "password_flowLayoutPanel";
            this.password_flowLayoutPanel.Padding = new System.Windows.Forms.Padding(2);
            this.password_flowLayoutPanel.Size = new System.Drawing.Size(217, 32);
            this.password_flowLayoutPanel.TabIndex = 5;
            this.password_flowLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.password_flowLayoutPanel_Paint);
            // 
            // password_pictureBox
            // 
            this.password_pictureBox.BackColor = System.Drawing.Color.Transparent;
            this.password_pictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("password_pictureBox.BackgroundImage")));
            this.password_pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.password_pictureBox.Location = new System.Drawing.Point(5, 8);
            this.password_pictureBox.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.password_pictureBox.Name = "password_pictureBox";
            this.password_pictureBox.Size = new System.Drawing.Size(16, 16);
            this.password_pictureBox.TabIndex = 0;
            this.password_pictureBox.TabStop = false;
            // 
            // password_textBox
            // 
            this.password_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password_textBox.Location = new System.Drawing.Point(27, 8);
            this.password_textBox.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.password_textBox.MaxLength = 20;
            this.password_textBox.Name = "password_textBox";
            this.password_textBox.PasswordChar = '*';
            this.password_textBox.Size = new System.Drawing.Size(180, 16);
            this.password_textBox.TabIndex = 1;
            // 
            // site_linkLabel
            // 
            this.site_linkLabel.AutoSize = true;
            this.site_linkLabel.LinkColor = System.Drawing.Color.DeepSkyBlue;
            this.site_linkLabel.Location = new System.Drawing.Point(235, 136);
            this.site_linkLabel.Name = "site_linkLabel";
            this.site_linkLabel.Size = new System.Drawing.Size(80, 17);
            this.site_linkLabel.TabIndex = 6;
            this.site_linkLabel.TabStop = true;
            this.site_linkLabel.Text = "点击进入官网";
            this.site_linkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.site_linkLabel_LinkClicked);
            // 
            // LoginForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(412, 235);
            this.Controls.Add(this.site_linkLabel);
            this.Controls.Add(this.password_flowLayoutPanel);
            this.Controls.Add(this.signin_button);
            this.Controls.Add(this.remember_me_checkBox);
            this.Controls.Add(this.username_flowLayoutPanel);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登录";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.username_flowLayoutPanel.ResumeLayout(false);
            this.username_flowLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.username_pictureBox)).EndInit();
            this.password_flowLayoutPanel.ResumeLayout(false);
            this.password_flowLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.password_pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel username_flowLayoutPanel;
        private System.Windows.Forms.CheckBox remember_me_checkBox;
        private System.Windows.Forms.Button signin_button;
        private System.Windows.Forms.PictureBox username_pictureBox;
        private System.Windows.Forms.TextBox username_textBox;
        private System.Windows.Forms.FlowLayoutPanel password_flowLayoutPanel;
        private System.Windows.Forms.PictureBox password_pictureBox;
        private System.Windows.Forms.TextBox password_textBox;
        private System.Windows.Forms.LinkLabel site_linkLabel;
    }
}