namespace Exercise
{
    partial class Form_Con
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_next = new System.Windows.Forms.Button();
            this.panel_con = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(157, 272);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(75, 23);
            this.btn_next.TabIndex = 14;
            this.btn_next.Text = "下一题";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // panel_con
            // 
            this.panel_con.Location = new System.Drawing.Point(13, 13);
            this.panel_con.Name = "panel_con";
            this.panel_con.Size = new System.Drawing.Size(368, 253);
            this.panel_con.TabIndex = 15;
            // 
            // Form_Con
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 307);
            this.Controls.Add(this.panel_con);
            this.Controls.Add(this.btn_next);
            this.Name = "Form_Con";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "测试";
            this.Load += new System.EventHandler(this.Form_Choose_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Panel panel_con;

    }
}

