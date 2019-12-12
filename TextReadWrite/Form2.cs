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
    public partial class Form2 : Form
    {
        string[] line;
        string strfilename;
        string stats;
        public Form2(string STR_Value, string stat)
        {
            InitializeComponent();
            strfilename = STR_Value;
            stats = stat;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (stats == "Load") {
                line = File.ReadAllLines(strfilename);
                bunifuCheckBox1.Checked = bool.Parse(line[0]);
                bunifuCheckBox2.Checked = bool.Parse(line[1]);
                bunifuCheckBox3.Checked = bool.Parse(line[2]);
                bunifuCheckBox4.Checked = bool.Parse(line[3]);
                textBox1.Text = line[4];
                textBox2.Text = line[5];
                textBox3.Text = line[6];
                textBox4.Text = line[7];
                bunifuDropdown1.selectedIndex = Convert.ToInt32(line[8]);
            }
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
            this.Close();
        }
    }
}
