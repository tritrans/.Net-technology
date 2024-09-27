namespace congnghe.net_tuan02
{
    partial class bai01
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
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rdo_cong = new System.Windows.Forms.RadioButton();
            this.rdo_tru = new System.Windows.Forms.RadioButton();
            this.rdo_nhan = new System.Windows.Forms.RadioButton();
            this.rdo_chia = new System.Windows.Forms.RadioButton();
            this.btn_tinh = new System.Windows.Forms.Button();
            this.btn_tt = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtKQ
            // 
            this.txtKQ.Enabled = false;
            this.txtKQ.Location = new System.Drawing.Point(146, 215);
            this.txtKQ.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.Size = new System.Drawing.Size(419, 22);
            this.txtKQ.TabIndex = 15;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(486, 141);
            this.txtB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(209, 22);
            this.txtB.TabIndex = 14;
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(112, 138);
            this.txtA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(199, 22);
            this.txtA.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "KẾT QUẢ :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(400, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "B=";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "A =";
            // 
            // rdo_cong
            // 
            this.rdo_cong.AutoSize = true;
            this.rdo_cong.Location = new System.Drawing.Point(71, 293);
            this.rdo_cong.Name = "rdo_cong";
            this.rdo_cong.Size = new System.Drawing.Size(60, 21);
            this.rdo_cong.TabIndex = 20;
            this.rdo_cong.TabStop = true;
            this.rdo_cong.Text = "cộng";
            this.rdo_cong.UseVisualStyleBackColor = true;
            // 
            // rdo_tru
            // 
            this.rdo_tru.AutoSize = true;
            this.rdo_tru.Location = new System.Drawing.Point(266, 293);
            this.rdo_tru.Name = "rdo_tru";
            this.rdo_tru.Size = new System.Drawing.Size(46, 21);
            this.rdo_tru.TabIndex = 21;
            this.rdo_tru.TabStop = true;
            this.rdo_tru.Text = "trừ";
            this.rdo_tru.UseVisualStyleBackColor = true;
            // 
            // rdo_nhan
            // 
            this.rdo_nhan.AutoSize = true;
            this.rdo_nhan.Location = new System.Drawing.Point(472, 293);
            this.rdo_nhan.Name = "rdo_nhan";
            this.rdo_nhan.Size = new System.Drawing.Size(61, 21);
            this.rdo_nhan.TabIndex = 22;
            this.rdo_nhan.TabStop = true;
            this.rdo_nhan.Text = "nhân";
            this.rdo_nhan.UseVisualStyleBackColor = true;
            // 
            // rdo_chia
            // 
            this.rdo_chia.AutoSize = true;
            this.rdo_chia.Location = new System.Drawing.Point(665, 293);
            this.rdo_chia.Name = "rdo_chia";
            this.rdo_chia.Size = new System.Drawing.Size(55, 21);
            this.rdo_chia.TabIndex = 23;
            this.rdo_chia.TabStop = true;
            this.rdo_chia.Text = "chia";
            this.rdo_chia.UseVisualStyleBackColor = true;
            // 
            // btn_tinh
            // 
            this.btn_tinh.ForeColor = System.Drawing.Color.Red;
            this.btn_tinh.Location = new System.Drawing.Point(164, 353);
            this.btn_tinh.Name = "btn_tinh";
            this.btn_tinh.Size = new System.Drawing.Size(75, 40);
            this.btn_tinh.TabIndex = 24;
            this.btn_tinh.Text = "Tính";
            this.btn_tinh.UseVisualStyleBackColor = true;
            this.btn_tinh.Click += new System.EventHandler(this.btn_tinh_Click);
            // 
            // btn_tt
            // 
            this.btn_tt.Location = new System.Drawing.Point(380, 353);
            this.btn_tt.Name = "btn_tt";
            this.btn_tt.Size = new System.Drawing.Size(75, 39);
            this.btn_tt.TabIndex = 25;
            this.btn_tt.Text = "Tiếp tục";
            this.btn_tt.UseVisualStyleBackColor = true;
            this.btn_tt.Click += new System.EventHandler(this.btn_tt_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(595, 353);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(75, 39);
            this.btn_thoat.TabIndex = 26;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // bai01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_tt);
            this.Controls.Add(this.btn_tinh);
            this.Controls.Add(this.rdo_chia);
            this.Controls.Add(this.rdo_nhan);
            this.Controls.Add(this.rdo_tru);
            this.Controls.Add(this.rdo_cong);
            this.Controls.Add(this.txtKQ);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "bai01";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
   
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtKQ;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdo_cong;
        private System.Windows.Forms.RadioButton rdo_tru;
        private System.Windows.Forms.RadioButton rdo_nhan;
        private System.Windows.Forms.RadioButton rdo_chia;
        private System.Windows.Forms.Button btn_tinh;
        private System.Windows.Forms.Button btn_tt;
        private System.Windows.Forms.Button btn_thoat;
    }
}

