namespace LaborStackApp.Modal
{
    partial class TeamInfoForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.team_name_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.team_name_label = new System.Windows.Forms.Label();
            this.submit_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "名称";
            // 
            // team_name_textBox
            // 
            this.team_name_textBox.Location = new System.Drawing.Point(78, 12);
            this.team_name_textBox.Name = "team_name_textBox";
            this.team_name_textBox.Size = new System.Drawing.Size(178, 23);
            this.team_name_textBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "项目";
            // 
            // team_name_label
            // 
            this.team_name_label.AutoSize = true;
            this.team_name_label.Location = new System.Drawing.Point(78, 53);
            this.team_name_label.Name = "team_name_label";
            this.team_name_label.Size = new System.Drawing.Size(43, 17);
            this.team_name_label.TabIndex = 3;
            this.team_name_label.Text = "label3";
            // 
            // submit_button
            // 
            this.submit_button.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.submit_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.submit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submit_button.ForeColor = System.Drawing.Color.White;
            this.submit_button.Location = new System.Drawing.Point(78, 92);
            this.submit_button.Name = "submit_button";
            this.submit_button.Size = new System.Drawing.Size(164, 34);
            this.submit_button.TabIndex = 4;
            this.submit_button.Text = "提交";
            this.submit_button.UseVisualStyleBackColor = false;
            this.submit_button.Click += new System.EventHandler(this.submit_button_Click);
            // 
            // TeamInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(317, 159);
            this.Controls.Add(this.submit_button);
            this.Controls.Add(this.team_name_label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.team_name_textBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TeamInfoForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "班组";
            this.Load += new System.EventHandler(this.TeamInfoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox team_name_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label team_name_label;
        private System.Windows.Forms.Button submit_button;
    }
}