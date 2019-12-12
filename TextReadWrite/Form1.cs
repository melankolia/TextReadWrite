using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace TextReadWrite
{
    public partial class Form1 : Form
    {
        OpenFileDialog openFile = new OpenFileDialog();
        string strfilename;
        string tempatsave = "";
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < textBox1.Text.Length; i++)
            {
                if (textBox1.Text[i].ToString() == "\\" || textBox1.Text[i].ToString() == "/")
                {
                    tempatsave += "";
                }
                else
                {
                   tempatsave += textBox1.Text[i];
                    MessageBox.Show(tempatsave);
                }
                
            }
            
            StreamWriter sw = new StreamWriter(Application.StartupPath + "\\Save\\" + tempatsave + ".txt");
            tempatsave = "";
            sw.WriteLine(bunifuCheckBox1.Checked);
            sw.WriteLine(bunifuCheckBox2.Checked);
            sw.WriteLine(bunifuCheckBox3.Checked);
            sw.WriteLine(bunifuCheckBox4.Checked);
            sw.WriteLine(textBox1.Text);
            sw.WriteLine(textBox2.Text);
            sw.WriteLine(textBox3.Text);
            sw.WriteLine(textBox4.Text);
            sw.WriteLine(bunifuDropdown1.selectedIndex.ToString());
            sw.Close();
            

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string stat = "Load";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                strfilename = openFile.FileName;
                this.Hide();
                Form2 f2 = new Form2(strfilename, stat);
                f2.ShowDialog();
                this.Close();
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            string stat = "New";
            this.Hide();
            Form2 f2 = new Form2(strfilename, stat);
            f2.ShowDialog();
            this.Close();
        }

    }
}
