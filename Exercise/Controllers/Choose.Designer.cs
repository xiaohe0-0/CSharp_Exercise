namespace Exercise.Controllers
{
    partial class Choose
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
            this.D = new System.Windows.Forms.RadioButton();
            this.C = new System.Windows.Forms.RadioButton();
            this.B = new System.Windows.Forms.RadioButton();
            this.A = new System.Windows.Forms.RadioButton();
            this.textBox = new System.Windows.Forms.TextBox();
            this.lab_num = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // D
            // 
            this.D.AutoSize = true;
            this.D.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.D.Location = new System.Drawing.Point(45, 222);
            this.D.Name = "D";
            this.D.Size = new System.Drawing.Size(97, 23);
            this.D.TabIndex = 12;
            this.D.TabStop = true;
            this.D.Text = "optionD";
            this.D.UseVisualStyleBackColor = true;
            // 
            // C
            // 
            this.C.AutoSize = true;
            this.C.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.C.Location = new System.Drawing.Point(45, 199);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(97, 23);
            this.C.TabIndex = 11;
            this.C.TabStop = true;
            this.C.Text = "optionC";
            this.C.UseVisualStyleBackColor = true;
            // 
            // B
            // 
            this.B.AutoSize = true;
            this.B.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.B.Location = new System.Drawing.Point(45, 175);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(97, 23);
            this.B.TabIndex = 10;
            this.B.TabStop = true;
            this.B.Text = "optionB";
            this.B.UseVisualStyleBackColor = true;
            // 
            // A
            // 
            this.A.AutoSize = true;
            this.A.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.A.Location = new System.Drawing.Point(45, 150);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(97, 23);
            this.A.TabIndex = 9;
            this.A.Text = "optionA";
            this.A.UseVisualStyleBackColor = true;
            // 
            // textBox
            // 
            this.textBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox.Location = new System.Drawing.Point(45, 11);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ReadOnly = true;
            this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox.Size = new System.Drawing.Size(302, 129);
            this.textBox.TabIndex = 8;
            this.textBox.TabStop = false;
            // 
            // lab_num
            // 
            this.lab_num.AutoSize = true;
            this.lab_num.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_num.Location = new System.Drawing.Point(2, 10);
            this.lab_num.Name = "lab_num";
            this.lab_num.Size = new System.Drawing.Size(28, 25);
            this.lab_num.TabIndex = 7;
            this.lab_num.Text = "1.";
            // 
            // Choose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.D);
            this.Controls.Add(this.C);
            this.Controls.Add(this.B);
            this.Controls.Add(this.A);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.lab_num);
            this.Name = "Choose";
            this.Size = new System.Drawing.Size(483, 367);
            this.Load += new System.EventHandler(this.Choose_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton D;
        private System.Windows.Forms.RadioButton C;
        private System.Windows.Forms.RadioButton B;
        private System.Windows.Forms.RadioButton A;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label lab_num;
    }
}
