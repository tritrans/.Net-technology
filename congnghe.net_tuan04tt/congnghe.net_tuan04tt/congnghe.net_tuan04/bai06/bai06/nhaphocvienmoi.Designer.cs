namespace bai06
{
    partial class nhaphocvienmoi
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
            this.label2 = new System.Windows.Forms.Label();
            this.btn_cn = new System.Windows.Forms.Button();
            this.btn_huy = new System.Windows.Forms.Button();
            this.txt_ht = new System.Windows.Forms.TextBox();
            this.cbo_lop = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lớp";
            // 
            // btn_cn
            // 
            this.btn_cn.Location = new System.Drawing.Point(41, 158);
            this.btn_cn.Name = "btn_cn";
            this.btn_cn.Size = new System.Drawing.Size(75, 23);
            this.btn_cn.TabIndex = 2;
            this.btn_cn.Text = "Update";
            this.btn_cn.UseVisualStyleBackColor = true;
            this.btn_cn.Click += new System.EventHandler(this.btn_cn_Click);
            // 
            // btn_huy
            // 
            this.btn_huy.Location = new System.Drawing.Point(174, 158);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(75, 23);
            this.btn_huy.TabIndex = 3;
            this.btn_huy.Text = "Cancel";
            this.btn_huy.UseVisualStyleBackColor = true;
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click);
            // 
            // txt_ht
            // 
            this.txt_ht.Location = new System.Drawing.Point(83, 34);
            this.txt_ht.Name = "txt_ht";
            this.txt_ht.Size = new System.Drawing.Size(121, 20);
            this.txt_ht.TabIndex = 4;
            // 
            // cbo_lop
            // 
            this.cbo_lop.FormattingEnabled = true;
            this.cbo_lop.Items.AddRange(new object[] {
            "A",
            "B"});
            this.cbo_lop.Location = new System.Drawing.Point(83, 80);
            this.cbo_lop.Name = "cbo_lop";
            this.cbo_lop.Size = new System.Drawing.Size(121, 21);
            this.cbo_lop.TabIndex = 5;
            this.cbo_lop.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // nhaphocvienmoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 234);
            this.Controls.Add(this.cbo_lop);
            this.Controls.Add(this.txt_ht);
            this.Controls.Add(this.btn_huy);
            this.Controls.Add(this.btn_cn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "nhaphocvienmoi";
            this.Text = "Nhập học viên mới";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_cn;
        private System.Windows.Forms.Button btn_huy;
        private System.Windows.Forms.TextBox txt_ht;
        private System.Windows.Forms.ComboBox cbo_lop;
    }
}