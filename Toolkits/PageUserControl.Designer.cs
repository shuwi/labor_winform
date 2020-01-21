namespace LaborStackApp.Toolkits
{
    partial class PageUserControl
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.currentLabel = new System.Windows.Forms.Label();
            this.lblTotalCount = new System.Windows.Forms.Label();
            this.linkFirst = new System.Windows.Forms.Button();
            this.linkPrevious = new System.Windows.Forms.Button();
            this.linkNext = new System.Windows.Forms.Button();
            this.linkLast = new System.Windows.Forms.Button();
            this.txtPageNum = new System.Windows.Forms.TextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.txtPageSize = new System.Windows.Forms.TextBox();
            this.userControl_ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "每页";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "条记录";
            // 
            // currentLabel
            // 
            this.currentLabel.AutoSize = true;
            this.currentLabel.Location = new System.Drawing.Point(173, 11);
            this.currentLabel.Name = "currentLabel";
            this.currentLabel.Size = new System.Drawing.Size(35, 17);
            this.currentLabel.TabIndex = 2;
            this.currentLabel.Text = "0 / 0";
            // 
            // lblTotalCount
            // 
            this.lblTotalCount.AutoSize = true;
            this.lblTotalCount.Location = new System.Drawing.Point(229, 12);
            this.lblTotalCount.Name = "lblTotalCount";
            this.lblTotalCount.Size = new System.Drawing.Size(63, 17);
            this.lblTotalCount.TabIndex = 3;
            this.lblTotalCount.Text = "共0条记录";
            // 
            // linkFirst
            // 
            this.linkFirst.BackColor = System.Drawing.Color.Transparent;
            this.linkFirst.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkFirst.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.linkFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.linkFirst.Font = new System.Drawing.Font("Consolas", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkFirst.Location = new System.Drawing.Point(321, 8);
            this.linkFirst.Name = "linkFirst";
            this.linkFirst.Size = new System.Drawing.Size(35, 26);
            this.linkFirst.TabIndex = 5;
            this.linkFirst.Text = "<<";
            this.userControl_ToolTip.SetToolTip(this.linkFirst, "回首页");
            this.linkFirst.UseVisualStyleBackColor = false;
            this.linkFirst.Click += new System.EventHandler(this.linkFirst_Click);
            // 
            // linkPrevious
            // 
            this.linkPrevious.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkPrevious.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.linkPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.linkPrevious.Font = new System.Drawing.Font("Consolas", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkPrevious.Location = new System.Drawing.Point(364, 8);
            this.linkPrevious.Name = "linkPrevious";
            this.linkPrevious.Size = new System.Drawing.Size(35, 26);
            this.linkPrevious.TabIndex = 6;
            this.linkPrevious.Text = "<";
            this.userControl_ToolTip.SetToolTip(this.linkPrevious, "上一页");
            this.linkPrevious.UseVisualStyleBackColor = true;
            this.linkPrevious.Click += new System.EventHandler(this.linkPrevious_Click);
            // 
            // linkNext
            // 
            this.linkNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkNext.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.linkNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.linkNext.Font = new System.Drawing.Font("Consolas", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkNext.Location = new System.Drawing.Point(407, 8);
            this.linkNext.Name = "linkNext";
            this.linkNext.Size = new System.Drawing.Size(35, 26);
            this.linkNext.TabIndex = 7;
            this.linkNext.Text = ">";
            this.userControl_ToolTip.SetToolTip(this.linkNext, "下一页");
            this.linkNext.UseVisualStyleBackColor = true;
            this.linkNext.Click += new System.EventHandler(this.linkNext_Click);
            // 
            // linkLast
            // 
            this.linkLast.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLast.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.linkLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.linkLast.Font = new System.Drawing.Font("Consolas", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLast.Location = new System.Drawing.Point(451, 8);
            this.linkLast.Name = "linkLast";
            this.linkLast.Size = new System.Drawing.Size(35, 26);
            this.linkLast.TabIndex = 8;
            this.linkLast.Text = ">>";
            this.userControl_ToolTip.SetToolTip(this.linkLast, "尾页");
            this.linkLast.UseVisualStyleBackColor = true;
            this.linkLast.Click += new System.EventHandler(this.linkLast_Click);
            // 
            // txtPageNum
            // 
            this.txtPageNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPageNum.Location = new System.Drawing.Point(498, 9);
            this.txtPageNum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPageNum.Name = "txtPageNum";
            this.txtPageNum.Size = new System.Drawing.Size(57, 23);
            this.txtPageNum.TabIndex = 9;
            this.userControl_ToolTip.SetToolTip(this.txtPageNum, "输入跳转页码");
            // 
            // btnGo
            // 
            this.btnGo.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnGo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGo.FlatAppearance.BorderColor = System.Drawing.Color.DarkTurquoise;
            this.btnGo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGo.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnGo.ForeColor = System.Drawing.Color.White;
            this.btnGo.Location = new System.Drawing.Point(568, 8);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(55, 26);
            this.btnGo.TabIndex = 12;
            this.btnGo.Text = "跳转";
            this.btnGo.UseVisualStyleBackColor = false;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // txtPageSize
            // 
            this.txtPageSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPageSize.Location = new System.Drawing.Point(51, 8);
            this.txtPageSize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPageSize.Name = "txtPageSize";
            this.txtPageSize.Size = new System.Drawing.Size(57, 23);
            this.txtPageSize.TabIndex = 13;
            // 
            // PageUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.txtPageSize);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.txtPageNum);
            this.Controls.Add(this.linkLast);
            this.Controls.Add(this.linkNext);
            this.Controls.Add(this.linkPrevious);
            this.Controls.Add(this.linkFirst);
            this.Controls.Add(this.lblTotalCount);
            this.Controls.Add(this.currentLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PageUserControl";
            this.Size = new System.Drawing.Size(648, 45);
            this.Load += new System.EventHandler(this.PageUserControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label currentLabel;
        private System.Windows.Forms.Label lblTotalCount;
        private System.Windows.Forms.Button linkFirst;
        private System.Windows.Forms.Button linkPrevious;
        private System.Windows.Forms.Button linkNext;
        private System.Windows.Forms.Button linkLast;
        private System.Windows.Forms.TextBox txtPageNum;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.TextBox txtPageSize;
        private System.Windows.Forms.ToolTip userControl_ToolTip;
    }
}
