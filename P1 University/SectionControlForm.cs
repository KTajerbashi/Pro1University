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
            dataGridViewStudent.DataSource = (new DB_C1().lessons).ToList();
            dataGridViewTeacher.DataSource = (new DB_C1().teachers).ToList();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DB_C1 db = new DB_C1();
            
        }
    }
}
