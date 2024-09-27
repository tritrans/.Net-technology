namespace bai06
{
    partial class bai6_cau01_tl
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_sv = new System.Windows.Forms.TextBox();
            this.txt_ht = new System.Windows.Forms.TextBox();
            this.cmb_dantoc = new System.Windows.Forms.ComboBox();
            this.lst_ds = new System.Windows.Forms.ListView();
            this.rdio_nam = new System.Windows.Forms.RadioButton();
            this.rdo_nu = new System.Windows.Forms.RadioButton();
            this.chk_anh = new System.Windows.Forms.CheckBox();
            this.chk_phap = new System.Windows.Forms.CheckBox();
            this.chk_hoa = new System.Windows.Forms.CheckBox();
            this.clm_ht = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clm_sv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clm_gt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clm_nn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clm_dt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(94, 415);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(75, 23);
            this.btn_them.TabIndex = 0;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(244, 415);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_xoa.TabIndex = 1;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(414, 415);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(75, 23);
            this.btn_sua.TabIndex = 2;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Họ tên :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mã SV:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Giới tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ngoại ngữ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Dân tộc";
            // 
            // txt_sv
            // 
            this.txt_sv.Location = new System.Drawing.Point(126, 86);
            this.txt_sv.Name = "txt_sv";
            this.txt_sv.Size = new System.Drawing.Size(276, 20);
            this.txt_sv.TabIndex = 8;
            this.txt_sv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_sv_KeyPress);
            // 
            // txt_ht
            // 
            this.txt_ht.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ht.Location = new System.Drawing.Point(126, 38);
            this.txt_ht.Name = "txt_ht";
            this.txt_ht.Size = new System.Drawing.Size(276, 20);
            this.txt_ht.TabIndex = 9;
            // 
            // cmb_dantoc
            // 
            this.cmb_dantoc.FormattingEnabled = true;
            this.cmb_dantoc.Location = new System.Drawing.Point(126, 221);
            this.cmb_dantoc.Name = "cmb_dantoc";
            this.cmb_dantoc.Size = new System.Drawing.Size(276, 21);
            this.cmb_dantoc.TabIndex = 10;
            // 
            // lst_ds
            // 
            this.lst_ds.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clm_ht,
            this.clm_sv,
            this.clm_gt,
            this.clm_nn,
            this.clm_dt});
            this.lst_ds.GridLines = true;
            this.lst_ds.HideSelection = false;
            this.lst_ds.Location = new System.Drawing.Point(71, 261);
            this.lst_ds.Name = "lst_ds";
            this.lst_ds.Size = new System.Drawing.Size(520, 134);
            this.lst_ds.TabIndex = 11;
            this.lst_ds.UseCompatibleStateImageBehavior = false;
            this.lst_ds.View = System.Windows.Forms.View.Details;
            this.lst_ds.SelectedIndexChanged += new System.EventHandler(this.lst_ds_SelectedIndexChanged);
            // 
            // rdio_nam
            // 
            this.rdio_nam.AutoSize = true;
            this.rdio_nam.Location = new System.Drawing.Point(162, 125);
            this.rdio_nam.Name = "rdio_nam";
            this.rdio_nam.Size = new System.Drawing.Size(47, 17);
            this.rdio_nam.TabIndex = 12;
            this.rdio_nam.TabStop = true;
            this.rdio_nam.Text = "Nam";
            this.rdio_nam.UseVisualStyleBackColor = true;
            // 
            // rdo_nu
            // 
            this.rdo_nu.AutoSize = true;
            this.rdo_nu.Location = new System.Drawing.Point(268, 125);
            this.rdo_nu.Name = "rdo_nu";
            this.rdo_nu.Size = new System.Drawing.Size(39, 17);
            this.rdo_nu.TabIndex = 13;
            this.rdo_nu.TabStop = true;
            this.rdo_nu.Text = "Nữ";
            this.rdo_nu.UseVisualStyleBackColor = true;
            // 
            // chk_anh
            // 
            this.chk_anh.AutoSize = true;
            this.chk_anh.Location = new System.Drawing.Point(162, 172);
            this.chk_anh.Name = "chk_anh";
            this.chk_anh.Size = new System.Drawing.Size(45, 17);
            this.chk_anh.TabIndex = 14;
            this.chk_anh.Text = "Anh";
            this.chk_anh.UseVisualStyleBackColor = true;
            // 
            // chk_phap
            // 
            this.chk_phap.AutoSize = true;
            this.chk_phap.Location = new System.Drawing.Point(268, 172);
            this.chk_phap.Name = "chk_phap";
            this.chk_phap.Size = new System.Drawing.Size(51, 17);
            this.chk_phap.TabIndex = 15;
            this.chk_phap.Text = "Pháp";
            this.chk_phap.UseVisualStyleBackColor = true;
            // 
            // chk_hoa
            // 
            this.chk_hoa.AutoSize = true;
            this.chk_hoa.Location = new System.Drawing.Point(376, 172);
            this.chk_hoa.Name = "chk_hoa";
            this.chk_hoa.Size = new System.Drawing.Size(46, 17);
            this.chk_hoa.TabIndex = 16;
            this.chk_hoa.Text = "Hoa";
            this.chk_hoa.UseVisualStyleBackColor = true;
            // 
            // clm_ht
            // 
            this.clm_ht.Text = "Họ tên";
            this.clm_ht.Width = 85;
            // 
            // clm_sv
            // 
            this.clm_sv.Text = "Mã SV";
            this.clm_sv.Width = 87;
            // 
            // clm_gt
            // 
            this.clm_gt.Text = "Giới tính";
            this.clm_gt.Width = 103;
            // 
            // clm_nn
            // 
            this.clm_nn.Text = "Ngoại ngữ";
            this.clm_nn.Width = 119;
            // 
            // clm_dt
            // 
            this.clm_dt.Text = "Dân tộc";
            this.clm_dt.Width = 205;
            // 
            // bai6_cau01_tl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chk_hoa);
            this.Controls.Add(this.chk_phap);
            this.Controls.Add(this.chk_anh);
            this.Controls.Add(this.rdo_nu);
            this.Controls.Add(this.rdio_nam);
            this.Controls.Add(this.lst_ds);
            this.Controls.Add(this.cmb_dantoc);
            this.Controls.Add(this.txt_ht);
            this.Controls.Add(this.txt_sv);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_them);
            this.Name = "bai6_cau01_tl";
            this.Text = "bai6_cau01_tl";
            this.Load += new System.EventHandler(this.bai6_cau01_tl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_sv;
        private System.Windows.Forms.TextBox txt_ht;
        private System.Windows.Forms.ComboBox cmb_dantoc;
        private System.Windows.Forms.ListView lst_ds;
        private System.Windows.Forms.RadioButton rdio_nam;
        private System.Windows.Forms.RadioButton rdo_nu;
        private System.Windows.Forms.CheckBox chk_anh;
        private System.Windows.Forms.CheckBox chk_phap;
        private System.Windows.Forms.CheckBox chk_hoa;
        private System.Windows.Forms.ColumnHeader clm_ht;
        private System.Windows.Forms.ColumnHeader clm_sv;
        private System.Windows.Forms.ColumnHeader clm_gt;
        private System.Windows.Forms.ColumnHeader clm_nn;
        private System.Windows.Forms.ColumnHeader clm_dt;
    }
}