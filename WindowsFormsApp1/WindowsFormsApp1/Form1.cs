using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("HOP HOP SERHAT TOP SERHAT");

          

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("yeni_buton");

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Environment.Exit(-1);

        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(-1);
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("irob yazılım v1.0","",MessageBoxButtons.OK,MessageBoxIcon.Information);
            string a;

        }
    }
}
