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
    public partial class SelectionUnitForm : Form
    {
        public SelectionUnitForm()
        {
            InitializeComponent();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void SelectionUnitForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = (new DB_C1()).selectionUnits.ToList();
            dataGridView4.DataSource = (new DB_C1()).sections.ToList();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = (new DB_C1()).selectionUnits.ToList();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DB_C1 db = new DB_C1();
            int id = Convert.ToInt32( idtxt.Text);
            var stu = from i in db.students where i.id == id select i;
            var uni = from i in db.selectionUnits where i.studentId == id select i;
            dataGridView2.DataSource = stu.ToList();
            dataGridView1.DataSource = uni.ToList();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView4_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DB_C1 db = new DB_C1();
            lescodeTXT.Text = dataGridView4.CurrentRow.Cells[1].Value.ToString();
            teaCodeTxt.Text = dataGridView4.CurrentRow.Cells[2].Value.ToString();
            int idtea = Convert.ToInt16(teaCodeTxt.Text);
            var teacher = from i in db.teachers where i.id == idtea select i;
            dataGridView3.DataSource = teacher.ToList();
            int idLes = Convert.ToInt16(lescodeTXT.Text);
            var lesson = from i in db.lessons where i.id == idLes select i;
            dataGridView5.DataSource = lesson.ToList();

        }
    }
}
