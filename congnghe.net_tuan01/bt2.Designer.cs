
namespace congnghe.net
{
    partial class bt2
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
            this.txt_ba = new System.Windows.Forms.TextBox();
            this.txt_bb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_kq = new System.Windows.Forms.TextBox();
            this.btn_cong = new System.Windows.Forms.Button();
            this.btn_tru = new System.Windows.Forms.Button();
            this.btn_nhan = new System.Windows.Forms.Button();
            this.btn_chia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "a=";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(343, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "b=";
            // 
            // txt_ba
            // 
            this.txt_ba.Location = new System.Drawing.Point(166, 81);
            this.txt_ba.Name = "txt_ba";
            this.txt_ba.Size = new System.Drawing.Size(100, 22);
            this.txt_ba.TabIndex = 2;
            // 
            // txt_bb
            // 
            this.txt_bb.Location = new System.Drawing.Point(442, 84);
            this.txt_bb.Name = "txt_bb";
            this.txt_bb.Size = new System.Drawing.Size(100, 22);
            this.txt_bb.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "KẾT QUẢ";
           
            // 
            // txt_kq
            // 
            this.txt_kq.Location = new System.Drawing.Point(166, 146);
            this.txt_kq.Name = "txt_kq";
            this.txt_kq.Size = new System.Drawing.Size(376, 22);
            this.txt_kq.TabIndex = 5;
           
            // 
            // btn_cong
            // 
            this.btn_cong.Location = new System.Drawing.Point(72, 230);
            this.btn_cong.Name = "btn_cong";
            this.btn_cong.Size = new System.Drawing.Size(75, 23);
            this.btn_cong.TabIndex = 6;
            this.btn_cong.Text = "Cộng";
            this.btn_cong.UseVisualStyleBackColor = true;
            this.btn_cong.Click += new System.EventHandler(this.btn_cong_Click);
            // 
            // btn_tru
            // 
            this.btn_tru.Location = new System.Drawing.Point(221, 230);
            this.btn_tru.Name = "btn_tru";
            this.btn_tru.Size = new System.Drawing.Size(75, 23);
            this.btn_tru.TabIndex = 7;
            this.btn_tru.Text = "Trừ";
            this.btn_tru.UseVisualStyleBackColor = true;
            // 
            // btn_nhan
            // 
            this.btn_nhan.Location = new System.Drawing.Point(388, 230);
            this.btn_nhan.Name = "btn_nhan";
            this.btn_nhan.Size = new System.Drawing.Size(75, 23);
            this.btn_nhan.TabIndex = 8;
            this.btn_nhan.Text = "Nhân";
            this.btn_nhan.UseVisualStyleBackColor = true;
            // 
            // btn_chia
            // 
            this.btn_chia.Location = new System.Drawing.Point(542, 230);
            this.btn_chia.Name = "btn_chia";
            this.btn_chia.Size = new System.Drawing.Size(75, 23);
            this.btn_chia.TabIndex = 9;
            this.btn_chia.Text = "Chia";
            this.btn_chia.UseVisualStyleBackColor = true;
            // 
            // bt2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_chia);
            this.Controls.Add(this.btn_nhan);
            this.Controls.Add(this.btn_tru);
            this.Controls.Add(this.btn_cong);
            this.Controls.Add(this.txt_kq);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_bb);
            this.Controls.Add(this.txt_ba);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "bt2";
            this.Text = "Cộng trừ nhân chia ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_ba;
        private System.Windows.Forms.TextBox txt_bb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_kq;
        private System.Windows.Forms.Button btn_cong;
        private System.Windows.Forms.Button btn_tru;
        private System.Windows.Forms.Button btn_nhan;
        private System.Windows.Forms.Button btn_chia;
    }
}