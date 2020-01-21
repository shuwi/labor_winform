namespace LaborStackApp.Modal
{
    partial class WorkerInfoForm
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
            this.vispShoot = new AForge.Controls.VideoSourcePlayer();
            this.picbPreview = new System.Windows.Forms.PictureBox();
            this.btnShoot = new System.Windows.Forms.Button();
            this.idcardNumber_pictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.idCardNumber_textBox = new System.Windows.Forms.TextBox();
            this.workerName_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.is_sue_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nationName_textBox = new System.Windows.Forms.TextBox();
            this.endTime_textBox = new System.Windows.Forms.TextBox();
            this.startTime_textBox = new System.Windows.Forms.TextBox();
            this.address_textBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.team_comboBox = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.project_label = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.workerType_comboBox = new System.Windows.Forms.ComboBox();
            this.reader_button = new System.Windows.Forms.Button();
            this.submit_button = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picbPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idcardNumber_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // vispShoot
            // 
            this.vispShoot.BackColor = System.Drawing.Color.WhiteSmoke;
            this.vispShoot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.vispShoot.BorderColor = System.Drawing.Color.Transparent;
            this.vispShoot.Location = new System.Drawing.Point(413, 12);
            this.vispShoot.Name = "vispShoot";
            this.vispShoot.Size = new System.Drawing.Size(134, 101);
            this.vispShoot.TabIndex = 0;
            this.vispShoot.Text = "加载中...";
            this.vispShoot.VideoSource = null;
            // 
            // picbPreview
            // 
            this.picbPreview.BackColor = System.Drawing.Color.White;
            this.picbPreview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picbPreview.Location = new System.Drawing.Point(569, 12);
            this.picbPreview.Name = "picbPreview";
            this.picbPreview.Size = new System.Drawing.Size(134, 101);
            this.picbPreview.TabIndex = 1;
            this.picbPreview.TabStop = false;
            // 
            // btnShoot
            // 
            this.btnShoot.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnShoot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShoot.FlatAppearance.BorderSize = 0;
            this.btnShoot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShoot.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnShoot.Location = new System.Drawing.Point(413, 132);
            this.btnShoot.Name = "btnShoot";
            this.btnShoot.Size = new System.Drawing.Size(134, 30);
            this.btnShoot.TabIndex = 2;
            this.btnShoot.Text = "现场拍照";
            this.btnShoot.UseVisualStyleBackColor = false;
            this.btnShoot.Click += new System.EventHandler(this.btnShoot_Click);
            // 
            // idcardNumber_pictureBox
            // 
            this.idcardNumber_pictureBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.idcardNumber_pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.idcardNumber_pictureBox.Location = new System.Drawing.Point(142, 12);
            this.idcardNumber_pictureBox.Name = "idcardNumber_pictureBox";
            this.idcardNumber_pictureBox.Size = new System.Drawing.Size(86, 101);
            this.idcardNumber_pictureBox.TabIndex = 3;
            this.idcardNumber_pictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "身份证号";
            // 
            // idCardNumber_textBox
            // 
            this.idCardNumber_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idCardNumber_textBox.Enabled = false;
            this.idCardNumber_textBox.Location = new System.Drawing.Point(141, 119);
            this.idCardNumber_textBox.Name = "idCardNumber_textBox";
            this.idCardNumber_textBox.Size = new System.Drawing.Size(170, 23);
            this.idCardNumber_textBox.TabIndex = 5;
            // 
            // workerName_textBox
            // 
            this.workerName_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.workerName_textBox.Enabled = false;
            this.workerName_textBox.Location = new System.Drawing.Point(141, 150);
            this.workerName_textBox.Name = "workerName_textBox";
            this.workerName_textBox.Size = new System.Drawing.Size(87, 23);
            this.workerName_textBox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "姓名";
            // 
            // is_sue_textBox
            // 
            this.is_sue_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.is_sue_textBox.Enabled = false;
            this.is_sue_textBox.Location = new System.Drawing.Point(140, 275);
            this.is_sue_textBox.Name = "is_sue_textBox";
            this.is_sue_textBox.Size = new System.Drawing.Size(170, 23);
            this.is_sue_textBox.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "地址";
            // 
            // nationName_textBox
            // 
            this.nationName_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nationName_textBox.Enabled = false;
            this.nationName_textBox.Location = new System.Drawing.Point(140, 306);
            this.nationName_textBox.Name = "nationName_textBox";
            this.nationName_textBox.Size = new System.Drawing.Size(87, 23);
            this.nationName_textBox.TabIndex = 11;
            // 
            // endTime_textBox
            // 
            this.endTime_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.endTime_textBox.Enabled = false;
            this.endTime_textBox.Location = new System.Drawing.Point(141, 243);
            this.endTime_textBox.Name = "endTime_textBox";
            this.endTime_textBox.Size = new System.Drawing.Size(87, 23);
            this.endTime_textBox.TabIndex = 12;
            // 
            // startTime_textBox
            // 
            this.startTime_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.startTime_textBox.Enabled = false;
            this.startTime_textBox.Location = new System.Drawing.Point(141, 211);
            this.startTime_textBox.Name = "startTime_textBox";
            this.startTime_textBox.Size = new System.Drawing.Size(87, 23);
            this.startTime_textBox.TabIndex = 13;
            // 
            // address_textBox
            // 
            this.address_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.address_textBox.Enabled = false;
            this.address_textBox.Location = new System.Drawing.Point(141, 180);
            this.address_textBox.Name = "address_textBox";
            this.address_textBox.Size = new System.Drawing.Size(170, 23);
            this.address_textBox.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "开始日期";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(70, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "结束日期";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(70, 278);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "发证机关";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(94, 307);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "民族";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(414, 213);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 17);
            this.label9.TabIndex = 20;
            this.label9.Text = "所属班组";
            // 
            // team_comboBox
            // 
            this.team_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.team_comboBox.FormattingEnabled = true;
            this.team_comboBox.Location = new System.Drawing.Point(485, 209);
            this.team_comboBox.Name = "team_comboBox";
            this.team_comboBox.Size = new System.Drawing.Size(218, 25);
            this.team_comboBox.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(414, 183);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 17);
            this.label11.TabIndex = 24;
            this.label11.Text = "所在项目";
            // 
            // project_label
            // 
            this.project_label.AutoSize = true;
            this.project_label.Location = new System.Drawing.Point(482, 183);
            this.project_label.Name = "project_label";
            this.project_label.Size = new System.Drawing.Size(18, 17);
            this.project_label.TabIndex = 25;
            this.project_label.Text = "--";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(414, 244);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 17);
            this.label13.TabIndex = 26;
            this.label13.Text = "所属工种";
            // 
            // workerType_comboBox
            // 
            this.workerType_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.workerType_comboBox.FormattingEnabled = true;
            this.workerType_comboBox.Location = new System.Drawing.Point(485, 241);
            this.workerType_comboBox.Name = "workerType_comboBox";
            this.workerType_comboBox.Size = new System.Drawing.Size(218, 25);
            this.workerType_comboBox.TabIndex = 27;
            // 
            // reader_button
            // 
            this.reader_button.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.reader_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reader_button.FlatAppearance.BorderSize = 0;
            this.reader_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reader_button.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.reader_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.reader_button.Location = new System.Drawing.Point(413, 293);
            this.reader_button.Name = "reader_button";
            this.reader_button.Size = new System.Drawing.Size(118, 36);
            this.reader_button.TabIndex = 28;
            this.reader_button.Text = "证件读取";
            this.reader_button.UseVisualStyleBackColor = false;
            this.reader_button.Click += new System.EventHandler(this.reader_button_Click);
            // 
            // submit_button
            // 
            this.submit_button.BackColor = System.Drawing.Color.DodgerBlue;
            this.submit_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.submit_button.FlatAppearance.BorderSize = 0;
            this.submit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submit_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.submit_button.Location = new System.Drawing.Point(569, 293);
            this.submit_button.Name = "submit_button";
            this.submit_button.Size = new System.Drawing.Size(134, 36);
            this.submit_button.TabIndex = 29;
            this.submit_button.Text = "提交";
            this.submit_button.UseVisualStyleBackColor = false;
            this.submit_button.Click += new System.EventHandler(this.submit_button_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(82, 12);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 17);
            this.label14.TabIndex = 30;
            this.label14.Text = "证件照";
            // 
            // WorkerInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(736, 365);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.submit_button);
            this.Controls.Add(this.reader_button);
            this.Controls.Add(this.workerType_comboBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.project_label);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.team_comboBox);
            this.Controls.Add(this.label9);
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
            this.Name = "WorkerInfoForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "工人信息";
            this.Load += new System.EventHandler(this.WorkerInfoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picbPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idcardNumber_pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AForge.Controls.VideoSourcePlayer vispShoot;
        private System.Windows.Forms.Button btnShoot;
        private System.Windows.Forms.PictureBox idcardNumber_pictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idCardNumber_textBox;
        private System.Windows.Forms.TextBox workerName_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox is_sue_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nationName_textBox;
        private System.Windows.Forms.TextBox endTime_textBox;
        private System.Windows.Forms.TextBox startTime_textBox;
        private System.Windows.Forms.TextBox address_textBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox team_comboBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label project_label;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox workerType_comboBox;
        private System.Windows.Forms.Button reader_button;
        private System.Windows.Forms.Button submit_button;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox picbPreview;
    }
}