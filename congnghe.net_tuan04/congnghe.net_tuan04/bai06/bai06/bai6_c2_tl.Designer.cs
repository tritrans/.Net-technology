namespace bai06
{
    partial class bai6_c2_tl
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
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_msv = new System.Windows.Forms.TextBox();
            this.txt_ht = new System.Windows.Forms.TextBox();
            this.lst_ds = new System.Windows.Forms.ListView();
            this.col_stt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_msv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cob_ht = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(168, 43);
            this.btn_them.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(100, 28);
            this.btn_them.TabIndex = 0;
            this.btn_them.Text = "Thêm ";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(363, 43);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(100, 28);
            this.btn_xoa.TabIndex = 1;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(564, 43);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(100, 28);
            this.btn_sua.TabIndex = 2;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(179, 97);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã SV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 160);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ho Tên";
            // 
            // txt_msv
            // 
            this.txt_msv.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_msv.Location = new System.Drawing.Point(237, 94);
            this.txt_msv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_msv.Name = "txt_msv";
            this.txt_msv.Size = new System.Drawing.Size(425, 27);
            this.txt_msv.TabIndex = 5;
            // 
            // txt_ht
            // 
            this.txt_ht.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ht.Location = new System.Drawing.Point(237, 156);
            this.txt_ht.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_ht.Name = "txt_ht";
            this.txt_ht.Size = new System.Drawing.Size(425, 27);
            this.txt_ht.TabIndex = 6;
            // 
            // lst_ds
            // 
            this.lst_ds.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_stt,
            this.col_msv,
            this.cob_ht});
            this.lst_ds.FullRowSelect = true;
            this.lst_ds.GridLines = true;
            this.lst_ds.HideSelection = false;
            this.lst_ds.Location = new System.Drawing.Point(168, 244);
            this.lst_ds.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lst_ds.Name = "lst_ds";
            this.lst_ds.Size = new System.Drawing.Size(576, 254);
            this.lst_ds.TabIndex = 7;
            this.lst_ds.UseCompatibleStateImageBehavior = false;
            this.lst_ds.View = System.Windows.Forms.View.Details;
            // 
            // col_stt
            // 
            this.col_stt.Text = "STT";
            // 
            // col_msv
            // 
            this.col_msv.Text = "Mã SV";
            // 
            // cob_ht
            // 
            this.cob_ht.Text = "Họ&tên";
            // 
            // bai6_c2_tl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.lst_ds);
            this.Controls.Add(this.txt_ht);
            this.Controls.Add(this.txt_msv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_them);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "bai6_c2_tl";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_msv;
        private System.Windows.Forms.TextBox txt_ht;
        private System.Windows.Forms.ListView lst_ds;
        private System.Windows.Forms.ColumnHeader col_stt;
        private System.Windows.Forms.ColumnHeader col_msv;
        private System.Windows.Forms.ColumnHeader cob_ht;
    }
}

