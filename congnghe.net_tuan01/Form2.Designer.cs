
namespace congnghe.net
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.btnC = new System.Windows.Forms.Button();
            this.btnT = new System.Windows.Forms.Button();
            this.btnN = new System.Windows.Forms.Button();
            this.btnCh = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "A =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(274, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "B=";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 105);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "KẾT QUẢ :";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(58, 40);
            this.txtA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(150, 20);
            this.txtA.TabIndex = 3;
            this.txtA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtA_KeyPress);
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(338, 42);
            this.txtB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(158, 20);
            this.txtB.TabIndex = 4;
            this.txtB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtB_KeyPress);
            // 
            // txtKQ
            // 
            this.txtKQ.Location = new System.Drawing.Point(83, 102);
            this.txtKQ.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.Size = new System.Drawing.Size(315, 20);
            this.txtKQ.TabIndex = 5;
            // 
            // btnC
            // 
            this.btnC.Location = new System.Drawing.Point(44, 147);
            this.btnC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(56, 30);
            this.btnC.TabIndex = 6;
            this.btnC.Text = "Cộng";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnT
            // 
            this.btnT.Location = new System.Drawing.Point(187, 147);
            this.btnT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnT.Name = "btnT";
            this.btnT.Size = new System.Drawing.Size(56, 30);
            this.btnT.TabIndex = 7;
            this.btnT.Text = "Trừ";
            this.btnT.UseVisualStyleBackColor = true;
            this.btnT.Click += new System.EventHandler(this.btnT_Click);
            // 
            // btnN
            // 
            this.btnN.Location = new System.Drawing.Point(338, 152);
            this.btnN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnN.Name = "btnN";
            this.btnN.Size = new System.Drawing.Size(56, 30);
            this.btnN.TabIndex = 8;
            this.btnN.Text = "Nhân ";
            this.btnN.UseVisualStyleBackColor = true;
            this.btnN.Click += new System.EventHandler(this.btnN_Click);
            // 
            // btnCh
            // 
            this.btnCh.Location = new System.Drawing.Point(482, 152);
            this.btnCh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCh.Name = "btnCh";
            this.btnCh.Size = new System.Drawing.Size(56, 30);
            this.btnCh.TabIndex = 9;
            this.btnCh.Text = "Chia";
            this.btnCh.UseVisualStyleBackColor = true;
            this.btnCh.Click += new System.EventHandler(this.btnCh_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnCh);
            this.Controls.Add(this.btnN);
            this.Controls.Add(this.btnT);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.txtKQ);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cộng trừ nhân chia ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtKQ;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnT;
        private System.Windows.Forms.Button btnN;
        private System.Windows.Forms.Button btnCh;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}