using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace EMUeasyrun
{
    public partial class Form1 : Form
    {
        Form2 frm2 = new Form2();        
        
        public Form1()
            ///bshfghshg
            ///dafsdf
            ///gasdfga
        {
            InitializeComponent();
            frm2.button1.Click+=new EventHandler(this.l3);
            this.openFileDialog1.FileOk +=new CancelEventHandler(this.addl1);  
            this.openFileDialog2.FileOk+=new CancelEventHandler(this.addl2);
        }


        private void button1_Click(object sender, EventArgs e)
            /// dhgdfgh
            /// fgsdfg
            /// dfghdfgh

        {

        }

        private void l1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.ShowDialog();
           // this.openFileDialog1.FileOk += new CancelEventHandler(this.addl1);           
        }
        void addl1(object sender, EventArgs e)
        { this.listBox1.Items.AddRange(this.openFileDialog1.FileNames); }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void 目录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.folderBrowserDialog1.ShowDialog();
            DirectoryInfo dir = new DirectoryInfo(this.folderBrowserDialog1.SelectedPath);

						//foreach (FileInfo f in dir.GetFiles("*.*"))
            foreach (FileInfo f in dir.GetFiles())
			{
                this.listBox2.Items.Add(this.folderBrowserDialog1.SelectedPath+"\\"+f.Name);
            }  
        }

        private void 新增ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm2.f = 0;
            frm2.Show();            
        }
        public void l3(object sender, EventArgs e)
        {
            if (frm2.f == 0)
            {
                this.listBox3.Items.Add(frm2.re);
            }
            else if (frm2.f == 1)
            {
                this.listBox3.Items[this.listBox3.SelectedIndex] = frm2.re;
            }
            this.listBox3.Refresh();
        }

        private void 删除ToolStripMenuItem1_Click(object sender, EventArgs e)
        {   
            try{
             this.listBox1.Items.RemoveAt(this.listBox1.SelectedIndex);
           
            this.listBox1.Refresh();
            }catch{}
        }

        private void 删除ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
         this.listBox2.Items.RemoveAt(this.listBox2.SelectedIndex);
           
            this.listBox2.Refresh();
        }

        private void 删除ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
         this.listBox3.Items.RemoveAt(this.listBox3.SelectedIndex);
           
            this.listBox3.Refresh();
        }

        private void 文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.openFileDialog2.ShowDialog();
        }
        void addl2(object sender, EventArgs e)
        { this.listBox2.Items.AddRange(this.openFileDialog2.FileNames); }

        private void 修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            frm2.richTextBox1.Text = this.listBox3.Items[this.listBox3.SelectedIndex].ToString();            
            frm2.f= 1;
            frm2.Show();
            
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.删除ToolStripMenuItem3_Click(this, e);
        }

        private void 新增ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.新增ToolStripMenuItem_Click(this, e);
        }

        private void 编辑ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.修改ToolStripMenuItem_Click(this, e);
        }

        private void 添加ROM文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.文件ToolStripMenuItem_Click(this, e);
        }

        private void 添加ROMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.目录ToolStripMenuItem_Click(this, e);
        }

        private void 添加模拟ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.l1ToolStripMenuItem_Click(this, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.richTextBox1.Text.Length > 0 && this.richTextBox2.Text.Length > 0)
            {
                this.listBox4.Items.Add(this.richTextBox2.Text);
                this.listBox5.Items.Add(this.richTextBox1.Text);
            }
            else {
                MessageBox.Show("请确保你输入的命令不为空且输入了要添加命令到Fav的命名", "無效操作");				
            }
        }

        private void 删除ToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            int id = this.listBox4.SelectedIndex;
            this.listBox4.Items.RemoveAt(id);
            this.listBox5.Items.RemoveAt(id);
        }

        private void listBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.listBox4.SelectedIndex = this.listBox5.SelectedIndex;
        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.listBox5.SelectedIndex = this.listBox4.SelectedIndex;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ccc();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ccc();
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ccc();
        }
        void ccc()
        {
            string a = "";
            string b = "";
            string c = "";
            try { a = this.listBox1.SelectedItem.ToString(); }
            catch { }
            try { b = this.listBox2.SelectedItem.ToString(); }
            catch { }
            try { c = this.listBox3.SelectedItem.ToString(); }
            catch { }          
            this.richTextBox1.Text = a + "        " + b + " " + c;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(this.richTextBox1.Text.Substring(0, this.richTextBox1.Text.IndexOf("        ")), this.richTextBox1.Text.Substring(this.richTextBox1.Text.IndexOf("        "), this.richTextBox1.Text.Length - this.richTextBox1.Text.IndexOf("        ")));
            
            }
            catch { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string sl=this.listBox5.Items[this.listBox4.SelectedIndex].ToString();
                
                System.Diagnostics.Process.Start(sl.Substring(0, sl.IndexOf("        ")), sl.Substring(sl.IndexOf("        "), sl.Length - sl.IndexOf("        ")));
          
            }
            catch { }
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {FormClosingEventArgs ee=new FormClosingEventArgs(CloseReason.ApplicationExitCall,false);
            this.OnFormClosing(ee); 
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
                      
        }
        //string fa = Directory.GetCurrentDirectory();
        void listtofile(System.Windows.Forms.ListBox l, string filename)
        {
            string fa = Directory.GetCurrentDirectory();
                fa=fa+ "\\" + filename + ".ini";           
            FileStream input1 = new FileStream(fa, FileMode.Create, FileAccess.Write);
            System.Text.Encoding en1 = System.Text.Encoding.Default;
            StreamWriter sw = new StreamWriter(input1, en1);
            string ww = "";
            for (int i=0; i < l.Items.Count;i++)
            {
                ww = ww + l.Items[i].ToString() + "!!!!!!";
            }
            //ww.Replace("\\","\\\\");
            sw.Write(ww);
                sw.Close();
                input1.Close();
                input1.Dispose();
                sw.Dispose();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

                this.listtofile(this.listBox1, "l1");

                this.listtofile(this.listBox2, "l2");

                this.listtofile(this.listBox3, "l3");

                this.listtofile(this.listBox4, "l4");

                this.listtofile(this.listBox5, "l5");

        }

        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.listtofile(this.listBox1, "l1");

            this.listtofile(this.listBox2, "l2");

            this.listtofile(this.listBox3, "l3");

            this.listtofile(this.listBox4, "l4");

            this.listtofile(this.listBox5, "l5");
        }
        
    }
}