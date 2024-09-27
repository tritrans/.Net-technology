
namespace CN.NET_Tuan03
{
    partial class b5_c2
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
            this.btn_load = new System.Windows.Forms.Button();
            this.cbo_dt = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_hienthi = new System.Windows.Forms.Button();
            this.lbl_kq = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_load
            // 
            this.btn_load.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_load.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_load.Location = new System.Drawing.Point(89, 25);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(201, 23);
            this.btn_load.TabIndex = 0;
            this.btn_load.Text = "LOAD DATA";
            this.btn_load.UseVisualStyleBackColor = false;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // cbo_dt
            // 
            this.cbo_dt.FormattingEnabled = true;
            this.cbo_dt.Location = new System.Drawing.Point(149, 82);
            this.cbo_dt.Name = "cbo_dt";
            this.cbo_dt.Size = new System.Drawing.Size(219, 24);
            this.cbo_dt.TabIndex = 1;
            this.cbo_dt.SelectedIndexChanged += new System.EventHandler(this.cbo_dt_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dân tộc";
            // 
            // btn_hienthi
            // 
            this.btn_hienthi.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_hienthi.Location = new System.Drawing.Point(149, 128);
            this.btn_hienthi.Name = "btn_hienthi";
            this.btn_hienthi.Size = new System.Drawing.Size(100, 30);
            this.btn_hienthi.TabIndex = 3;
            this.btn_hienthi.Text = "HIỂN THỊ";
            this.btn_hienthi.UseVisualStyleBackColor = false;
            this.btn_hienthi.Click += new System.EventHandler(this.btn_hienthi_Click);
            // 
            // lbl_kq
            // 
            this.lbl_kq.AutoSize = true;
            this.lbl_kq.Location = new System.Drawing.Point(192, 203);
            this.lbl_kq.Name = "lbl_kq";
            this.lbl_kq.Size = new System.Drawing.Size(60, 17);
            this.lbl_kq.TabIndex = 4;
            this.lbl_kq.Text = "Kết Quả";
            // 
            // b5_c2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 363);
            this.Controls.Add(this.lbl_kq);
            this.Controls.Add(this.btn_hienthi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbo_dt);
            this.Controls.Add(this.btn_load);
            this.Name = "b5_c2";
            this.Text = "b5_c2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.ComboBox cbo_dt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_hienthi;
        private System.Windows.Forms.Label lbl_kq;
    }
}