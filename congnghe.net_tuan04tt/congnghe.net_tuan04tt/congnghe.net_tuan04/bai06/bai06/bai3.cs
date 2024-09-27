using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai06
{
    public partial class bai3 : Form
    {
        public bai3()
        {
            InitializeComponent();
        }

        private void nhậpHọcViênMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
             nhaphocvienmoi n = new nhaphocvienmoi();
            
            
            if(n.ShowDialog()==DialogResult.OK)
            {
                if(n.lop==grblopA.Text) 
                    listBox1.Items.Add(n.hoten);
                else
                    listBox1.Items.Add(n.hoten);
            }    
        }
    }
}
