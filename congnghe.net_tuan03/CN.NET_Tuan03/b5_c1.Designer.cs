
namespace CN.NET_Tuan03
{
    partial class b5_c1
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
            this.lst_t = new System.Windows.Forms.ListBox();
            this.lst_p = new System.Windows.Forms.ListBox();
            this.btn_t_p1 = new System.Windows.Forms.Button();
            this.btn_t_pn = new System.Windows.Forms.Button();
            this.btn_t_pall = new System.Windows.Forms.Button();
            this.btn_p_t1 = new System.Windows.Forms.Button();
            this.btn_p_tn = new System.Windows.Forms.Button();
            this.btn_p_tall = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lst_t
            // 
            this.lst_t.FormattingEnabled = true;
            this.lst_t.ItemHeight = 16;
            this.lst_t.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F"});
            this.lst_t.Location = new System.Drawing.Point(144, 99);
            this.lst_t.Name = "lst_t";
            this.lst_t.Size = new System.Drawing.Size(120, 260);
            this.lst_t.TabIndex = 0;
            // 
            // lst_p
            // 
            this.lst_p.FormattingEnabled = true;
            this.lst_p.ItemHeight = 16;
            this.lst_p.Location = new System.Drawing.Point(402, 99);
            this.lst_p.Name = "lst_p";
            this.lst_p.Size = new System.Drawing.Size(120, 260);
            this.lst_p.TabIndex = 1;
            // 
            // btn_t_p1
            // 
            this.btn_t_p1.Location = new System.Drawing.Point(297, 99);
            this.btn_t_p1.Name = "btn_t_p1";
            this.btn_t_p1.Size = new System.Drawing.Size(75, 23);
            this.btn_t_p1.TabIndex = 2;
            this.btn_t_p1.Text = ">";
            this.btn_t_p1.UseVisualStyleBackColor = true;
            this.btn_t_p1.Click += new System.EventHandler(this.btn_t_p1_Click);
            // 
            // btn_t_pn
            // 
            this.btn_t_pn.Location = new System.Drawing.Point(297, 148);
            this.btn_t_pn.Name = "btn_t_pn";
            this.btn_t_pn.Size = new System.Drawing.Size(75, 23);
            this.btn_t_pn.TabIndex = 3;
            this.btn_t_pn.Text = ">>";
            this.btn_t_pn.UseVisualStyleBackColor = true;
            this.btn_t_pn.Click += new System.EventHandler(this.btn_t_pn_Click);
            // 
            // btn_t_pall
            // 
            this.btn_t_pall.Location = new System.Drawing.Point(297, 192);
            this.btn_t_pall.Name = "btn_t_pall";
            this.btn_t_pall.Size = new System.Drawing.Size(75, 23);
            this.btn_t_pall.TabIndex = 4;
            this.btn_t_pall.Text = ">>>";
            this.btn_t_pall.UseVisualStyleBackColor = true;
            this.btn_t_pall.Click += new System.EventHandler(this.btn_t_pall_Click);
            // 
            // btn_p_t1
            // 
            this.btn_p_t1.Location = new System.Drawing.Point(297, 231);
            this.btn_p_t1.Name = "btn_p_t1";
            this.btn_p_t1.Size = new System.Drawing.Size(75, 23);
            this.btn_p_t1.TabIndex = 5;
            this.btn_p_t1.Text = "<";
            this.btn_p_t1.UseVisualStyleBackColor = true;
            this.btn_p_t1.Click += new System.EventHandler(this.btn_p_t1_Click);
            // 
            // btn_p_tn
            // 
            this.btn_p_tn.Location = new System.Drawing.Point(297, 279);
            this.btn_p_tn.Name = "btn_p_tn";
            this.btn_p_tn.Size = new System.Drawing.Size(75, 23);
            this.btn_p_tn.TabIndex = 6;
            this.btn_p_tn.Text = "<<";
            this.btn_p_tn.UseVisualStyleBackColor = true;
            this.btn_p_tn.Click += new System.EventHandler(this.btn_p_tn_Click);
            // 
            // btn_p_tall
            // 
            this.btn_p_tall.Location = new System.Drawing.Point(297, 336);
            this.btn_p_tall.Name = "btn_p_tall";
            this.btn_p_tall.Size = new System.Drawing.Size(75, 23);
            this.btn_p_tall.TabIndex = 7;
            this.btn_p_tall.Text = "<<<";
            this.btn_p_tall.UseVisualStyleBackColor = true;
            // 
            // b5_c1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_p_tall);
            this.Controls.Add(this.btn_p_tn);
            this.Controls.Add(this.btn_p_t1);
            this.Controls.Add(this.btn_t_pall);
            this.Controls.Add(this.btn_t_pn);
            this.Controls.Add(this.btn_t_p1);
            this.Controls.Add(this.lst_p);
            this.Controls.Add(this.lst_t);
            this.Name = "b5_c1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lst_t;
        private System.Windows.Forms.ListBox lst_p;
        private System.Windows.Forms.Button btn_t_p1;
        private System.Windows.Forms.Button btn_t_pn;
        private System.Windows.Forms.Button btn_t_pall;
        private System.Windows.Forms.Button btn_p_t1;
        private System.Windows.Forms.Button btn_p_tn;
        private System.Windows.Forms.Button btn_p_tall;
    }
}

