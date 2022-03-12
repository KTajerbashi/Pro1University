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
    public partial class SectionControlForm : Form
    {
        public SectionControlForm()
        {
            InitializeComponent();
        }

        private void SectionControlForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = (new DB_C1().teachers).ToList();
            dataGridView2.DataSource = (new DB_C1().lessons).ToList();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            teacodTXT.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            teaCTXT.Text = teacodTXT.Text;
            teanameTXT.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            teafamTXT.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            teaFieTXT.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void dataGridView2_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            

        }
    }
}
