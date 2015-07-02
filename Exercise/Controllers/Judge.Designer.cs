namespace Exercise.Controllers
{
    partial class Judge
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.F = new System.Windows.Forms.RadioButton();
            this.T = new System.Windows.Forms.RadioButton();
            this.textBox = new System.Windows.Forms.TextBox();
            this.lab_num = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // F
            // 
            this.F.AutoSize = true;
            this.F.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.F.Location = new System.Drawing.Point(56, 184);
            this.F.Name = "F";
            this.F.Size = new System.Drawing.Size(37, 23);
            this.F.TabIndex = 13;
            this.F.TabStop = true;
            this.F.Text = "F";
            this.F.UseVisualStyleBackColor = true;
            // 
            // T
            // 
            this.T.AutoSize = true;
            this.T.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.T.Location = new System.Drawing.Point(56, 159);
            this.T.Name = "T";
            this.T.Size = new System.Drawing.Size(37, 23);
            this.T.TabIndex = 12;
            this.T.TabStop = true;
            this.T.Text = "T";
            this.T.UseVisualStyleBackColor = true;
            // 
            // textBox
            // 
            this.textBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox.Location = new System.Drawing.Point(56, 20);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ReadOnly = true;
            this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox.Size = new System.Drawing.Size(302, 129);
            this.textBox.TabIndex = 11;
            this.textBox.TabStop = false;
            // 
            // lab_num
            // 
            this.lab_num.AutoSize = true;
            this.lab_num.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_num.Location = new System.Drawing.Point(4, 20);
            this.lab_num.Name = "lab_num";
            this.lab_num.Size = new System.Drawing.Size(28, 25);
            this.lab_num.TabIndex = 14;
            this.lab_num.Text = "1.";
            // 
            // Judge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lab_num);
            this.Controls.Add(this.F);
            this.Controls.Add(this.T);
            this.Controls.Add(this.textBox);
            this.Name = "Judge";
            this.Size = new System.Drawing.Size(427, 340);
            this.Load += new System.EventHandler(this.Judge_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton F;
        private System.Windows.Forms.RadioButton T;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label lab_num;
    }
}
