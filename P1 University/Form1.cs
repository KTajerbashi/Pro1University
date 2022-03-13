using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P1_University
{

    public partial class MainForm1 : Form
    {
        public MainForm1()
        {
            InitializeComponent();
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            (new RegisterForm()).ShowDialog();
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = (new DB_C1().students).ToList();
        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            (new AddLessonForm()).ShowDialog();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            (new RegisterForm()).ShowDialog();
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = (new DB_C1().teachers).ToList();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            (new SectionControlForm()).ShowDialog();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = (new DB_C1().sections).ToList();

        }
    }
}
