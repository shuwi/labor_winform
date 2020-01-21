namespace LaborStackApp.Modal
{
    partial class ManagerInfoForm
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
            this.label14 = new System.Windows.Forms.Label();
            this.submit_button = new System.Windows.Forms.Button();
            this.reader_button = new System.Windows.Forms.Button();
            this.project_label = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.address_textBox = new System.Windows.Forms.TextBox();
            this.startTime_textBox = new System.Windows.Forms.TextBox();
            this.endTime_textBox = new System.Windows.Forms.TextBox();
            this.nationName_textBox = new System.Windows.Forms.TextBox();
            this.is_sue_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.workerName_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.idCardNumber_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.idcardNumber_pictureBox = new System.Windows.Forms.PictureBox();
            this.vispShoot = new AForge.Controls.VideoSourcePlayer();
            this.btnShoot = new System.Windows.Forms.Button();
            this.picbPreview = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.idcardNumber_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(39, 14);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 17);
            this.label14.TabIndex = 57;
            this.label14.Text = "证件照";
            // 
            // submit_button
            // 
            this.submit_button.BackColor = System.Drawing.Color.DodgerBlue;
            this.submit_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.submit_button.FlatAppearance.BorderSize = 0;
            this.submit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submit_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.submit_button.Location = new System.Drawing.Point(526, 295);
            this.submit_button.Name = "submit_button";
            this.submit_button.Size = new System.Drawing.Size(134, 36);
            this.submit_button.TabIndex = 56;
            this.submit_button.Text = "提交";
            this.submit_button.UseVisualStyleBackColor = false;
            this.submit_button.Click += new System.EventHandler(this.submit_button_Click);
            // 
            // reader_button
            // 
            this.reader_button.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.reader_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reader_button.FlatAppearance.BorderSize = 0;
            this.reader_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reader_button.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.reader_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.reader_button.Location = new System.Drawing.Point(370, 295);
            this.reader_button.Name = "reader_button";
            this.reader_button.Size = new System.Drawing.Size(118, 36);
            this.reader_button.TabIndex = 55;
            this.reader_button.Text = "证件读取";
            this.reader_button.UseVisualStyleBackColor = false;
            this.reader_button.Click += new System.EventHandler(this.reader_button_Click);
            // 
            // project_label
            // 
            this.project_label.AutoSize = true;
            this.project_label.Location = new System.Drawing.Point(439, 185);
            this.project_label.Name = "project_label";
            this.project_label.Size = new System.Drawing.Size(18, 17);
            this.project_label.TabIndex = 52;
            this.project_label.Text = "--";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(371, 185);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 17);
            this.label11.TabIndex = 51;
            this.label11.Text = "所在项目";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(51, 309);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 17);
            this.label8.TabIndex = 48;
            this.label8.Text = "民族";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 280);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 17);
            this.label7.TabIndex = 47;
            this.label7.Text = "发证机关";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 46;
            this.label6.Text = "结束日期";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 45;
            this.label5.Text = "开始日期";
            // 
            // address_textBox
            // 
            this.address_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.address_textBox.Enabled = false;
            this.address_textBox.Location = new System.Drawing.Point(98, 182);
            this.address_textBox.Name = "address_textBox";
            this.address_textBox.Size = new System.Drawing.Size(170, 23);
            this.address_textBox.TabIndex = 44;
            // 
            // startTime_textBox
            // 
            this.startTime_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.startTime_textBox.Enabled = false;
            this.startTime_textBox.Location = new System.Drawing.Point(98, 213);
            this.startTime_textBox.Name = "startTime_textBox";
            this.startTime_textBox.Size = new System.Drawing.Size(87, 23);
            this.startTime_textBox.TabIndex = 43;
            // 
            // endTime_textBox
            // 
            this.endTime_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.endTime_textBox.Enabled = false;
            this.endTime_textBox.Location = new System.Drawing.Point(98, 245);
            this.endTime_textBox.Name = "endTime_textBox";
            this.endTime_textBox.Size = new System.Drawing.Size(87, 23);
            this.endTime_textBox.TabIndex = 42;
            // 
            // nationName_textBox
            // 
            this.nationName_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nationName_textBox.Enabled = false;
            this.nationName_textBox.Location = new System.Drawing.Point(97, 308);
            this.nationName_textBox.Name = "nationName_textBox";
            this.nationName_textBox.Size = new System.Drawing.Size(87, 23);
            this.nationName_textBox.TabIndex = 41;
            // 
            // is_sue_textBox
            // 
            this.is_sue_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.is_sue_textBox.Enabled = false;
            this.is_sue_textBox.Location = new System.Drawing.Point(97, 277);
            this.is_sue_textBox.Name = "is_sue_textBox";
            this.is_sue_textBox.Size = new System.Drawing.Size(170, 23);
            this.is_sue_textBox.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 17);
            this.label3.TabIndex = 39;
            this.label3.Text = "地址";
            // 
            // workerName_textBox
            // 
            this.workerName_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.workerName_textBox.Enabled = false;
            this.workerName_textBox.Location = new System.Drawing.Point(98, 152);
            this.workerName_textBox.Name = "workerName_textBox";
            this.workerName_textBox.Size = new System.Drawing.Size(87, 23);
            this.workerName_textBox.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 17);
            this.label2.TabIndex = 37;
            this.label2.Text = "姓名";
            // 
            // idCardNumber_textBox
            // 
            this.idCardNumber_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idCardNumber_textBox.Enabled = false;
            this.idCardNumber_textBox.Location = new System.Drawing.Point(98, 121);
            this.idCardNumber_textBox.Name = "idCardNumber_textBox";
            this.idCardNumber_textBox.Size = new System.Drawing.Size(170, 23);
            this.idCardNumber_textBox.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 35;
            this.label1.Text = "身份证号";
            // 
            // idcardNumber_pictureBox
            // 
            this.idcardNumber_pictureBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.idcardNumber_pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.idcardNumber_pictureBox.Location = new System.Drawing.Point(99, 14);
            this.idcardNumber_pictureBox.Name = "idcardNumber_pictureBox";
            this.idcardNumber_pictureBox.Size = new System.Drawing.Size(86, 101);
            this.idcardNumber_pictureBox.TabIndex = 34;
            this.idcardNumber_pictureBox.TabStop = false;
            // 
            // vispShoot
            // 
            this.vispShoot.BackColor = System.Drawing.Color.WhiteSmoke;
            this.vispShoot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.vispShoot.BorderColor = System.Drawing.Color.Transparent;
            this.vispShoot.Location = new System.Drawing.Point(370, 14);
            this.vispShoot.Name = "vispShoot";
            this.vispShoot.Size = new System.Drawing.Size(134, 101);
            this.vispShoot.TabIndex = 31;
            this.vispShoot.Text = "加载中...";
            this.vispShoot.VideoSource = null;
            // 
            // btnShoot
            // 
            this.btnShoot.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnShoot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShoot.FlatAppearance.BorderSize = 0;
            this.btnShoot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShoot.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnShoot.Location = new System.Drawing.Point(370, 134);
            this.btnShoot.Name = "btnShoot";
            this.btnShoot.Size = new System.Drawing.Size(134, 30);
            this.btnShoot.TabIndex = 33;
            this.btnShoot.Text = "现场拍照";
            this.btnShoot.UseVisualStyleBackColor = false;
            this.btnShoot.Click += new System.EventHandler(this.btnShoot_Click);
            // 
            // picbPreview
            // 
            this.picbPreview.BackColor = System.Drawing.Color.White;
            this.picbPreview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picbPreview.Location = new System.Drawing.Point(526, 14);
            this.picbPreview.Name = "picbPreview";
            this.picbPreview.Size = new System.Drawing.Size(134, 101);
            this.picbPreview.TabIndex = 32;
            this.picbPreview.TabStop = false;
            // 
            // ManagerInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(694, 373);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.submit_button);
            this.Controls.Add(this.reader_button);
            this.Controls.Add(this.project_label);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.address_textBox);
            this.Controls.Add(this.startTime_textBox);
            this.Controls.Add(this.endTime_textBox);
            this.Controls.Add(this.nationName_textBox);
            this.Controls.Add(this.is_sue_textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.workerName_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.idCardNumber_textBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.idcardNumber_pictureBox);
            this.Controls.Add(this.vispShoot);
            this.Controls.Add(this.btnShoot);
            this.Controls.Add(this.picbPreview);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ManagerInfoForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "管理人员信息";
            this.Load += new System.EventHandler(this.ManagerInfoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.idcardNumber_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button submit_button;
        private System.Windows.Forms.Button reader_button;
        private System.Windows.Forms.Label project_label;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox address_textBox;
        private System.Windows.Forms.TextBox startTime_textBox;
        private System.Windows.Forms.TextBox endTime_textBox;
        private System.Windows.Forms.TextBox nationName_textBox;
        private System.Windows.Forms.TextBox is_sue_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox workerName_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox idCardNumber_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox idcardNumber_pictureBox;
        private AForge.Controls.VideoSourcePlayer vispShoot;
        private System.Windows.Forms.Button btnShoot;
        private System.Windows.Forms.PictureBox picbPreview;
    }
}