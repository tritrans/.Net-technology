namespace bai06
{
    partial class bai3
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cậpNhậtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhậpHọcViênMớiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chuyểnSangLớpBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chuyểnSangLớpAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaHọcViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kếtThúcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grblopA = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.grblopA.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cậpNhậtToolStripMenuItem,
            this.kếtThúcToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cậpNhậtToolStripMenuItem
            // 
            this.cậpNhậtToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhậpHọcViênMớiToolStripMenuItem,
            this.chuyểnSangLớpBToolStripMenuItem,
            this.chuyểnSangLớpAToolStripMenuItem,
            this.xóaHọcViênToolStripMenuItem});
            this.cậpNhậtToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cậpNhậtToolStripMenuItem.Name = "cậpNhậtToolStripMenuItem";
            this.cậpNhậtToolStripMenuItem.Size = new System.Drawing.Size(99, 26);
            this.cậpNhậtToolStripMenuItem.Text = "&Cập nhật";
            // 
            // nhậpHọcViênMớiToolStripMenuItem
            // 
            this.nhậpHọcViênMớiToolStripMenuItem.Name = "nhậpHọcViênMớiToolStripMenuItem";
            this.nhậpHọcViênMớiToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.nhậpHọcViênMớiToolStripMenuItem.Text = "Nhập học viên mới";
            this.nhậpHọcViênMớiToolStripMenuItem.Click += new System.EventHandler(this.nhậpHọcViênMớiToolStripMenuItem_Click);
            // 
            // chuyểnSangLớpBToolStripMenuItem
            // 
            this.chuyểnSangLớpBToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chuyểnSangLớpBToolStripMenuItem.Name = "chuyểnSangLớpBToolStripMenuItem";
            this.chuyểnSangLớpBToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.chuyểnSangLớpBToolStripMenuItem.Text = "Chuyển sang lớp B";
            // 
            // chuyểnSangLớpAToolStripMenuItem
            // 
            this.chuyểnSangLớpAToolStripMenuItem.Name = "chuyểnSangLớpAToolStripMenuItem";
            this.chuyểnSangLớpAToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.chuyểnSangLớpAToolStripMenuItem.Text = "Chuyển sang lớp A";
            // 
            // xóaHọcViênToolStripMenuItem
            // 
            this.xóaHọcViênToolStripMenuItem.Name = "xóaHọcViênToolStripMenuItem";
            this.xóaHọcViênToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.xóaHọcViênToolStripMenuItem.Text = "Xóa học viên";
            // 
            // kếtThúcToolStripMenuItem
            // 
            this.kếtThúcToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kếtThúcToolStripMenuItem.Name = "kếtThúcToolStripMenuItem";
            this.kếtThúcToolStripMenuItem.Size = new System.Drawing.Size(93, 26);
            this.kếtThúcToolStripMenuItem.Text = "&Kết thúc";
            // 
            // grblopA
            // 
            this.grblopA.Controls.Add(this.listBox1);
            this.grblopA.Location = new System.Drawing.Point(35, 52);
            this.grblopA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grblopA.Name = "grblopA";
            this.grblopA.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grblopA.Size = new System.Drawing.Size(267, 233);
            this.grblopA.TabIndex = 1;
            this.grblopA.TabStop = false;
            this.grblopA.Text = "LỚP A";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "A ",
            "B",
            "C"});
            this.listBox1.Location = new System.Drawing.Point(8, 30);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(235, 164);
            this.listBox1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBox2);
            this.groupBox2.Location = new System.Drawing.Point(352, 52);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(267, 233);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "LỚP B";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Items.AddRange(new object[] {
            "D",
            "E",
            "F"});
            this.listBox2.Location = new System.Drawing.Point(8, 27);
            this.listBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(249, 180);
            this.listBox2.TabIndex = 0;
            // 
            // bai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grblopA);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "bai3";
            this.Text = "Quản lý học viên";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grblopA.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cậpNhậtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhậpHọcViênMớiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kếtThúcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chuyểnSangLớpBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chuyểnSangLớpAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaHọcViênToolStripMenuItem;
        private System.Windows.Forms.GroupBox grblopA;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
    }
}