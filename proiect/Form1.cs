using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proiect
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bfs_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog(); // Shows Form2
        }

        private void ucs_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog(); // Shows Form3
        }

        private void dfs_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.ShowDialog(); // Shows Form4
        }

        private void dls_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.ShowDialog(); // Shows Form5
        }

        private void ids_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.ShowDialog(); // Shows Form6
        }

        private void mini_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            f7.ShowDialog(); // Shows Form7
        }

        private void alpha_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();
            f8.ShowDialog(); // Shows Form8
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
