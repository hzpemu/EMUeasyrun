using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EMUeasyrun
{
   public partial class Form2 : Form
    {
       public int f = 0;
        public string re="";
        public Form2()
        {
            InitializeComponent();
           
        }

        public void button1_Click(object sender, EventArgs e)
        {
            if (this.richTextBox1.Text.Length > 0)
            {
                re = this.richTextBox1.Text;
               //
            }
            this.Hide();
            this.richTextBox1.Text = "";
        }
    }
}