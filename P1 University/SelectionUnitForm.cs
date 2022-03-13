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
            dataGridView4.DataSource = (new DB_C1()).sections.ToList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DB_C1 db = new DB_C1();
            int id = Convert.ToInt32( idtxt.Text);
            foreach (var i in db.students)
            {
                if (i.id == id)
                {
                    stuNmTxt.Text = i.name + " " + i.family;
                    stuFieTxt.Text = i.field;
                }
            }
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
            unitCode.Text = dataGridView4.CurrentRow.Cells[0].Value.ToString();
            int idtea = Convert.ToInt16(teaCodeTxt.Text);
            foreach(var item in db.teachers)
            {
                if(item.id == idtea)
                {
                    teaNameTXT.Text = item.name.ToString();
                    teaFieTXT.Text = item.field.ToString();
                }
            }
            int idLes = Convert.ToInt16(lescodeTXT.Text);
            foreach(var item in db.lessons)
            {
                if(item.id == idLes)
                {
                    lesFieTXT.Text = item.field.ToString();
                    lesNameTXT.Text = item.title.ToString();
                }
            }
            

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SelectionUnit selection1 = new SelectionUnit();
            if(selection1.selectionRegister(new SelectionUnit
            {
                studentId=Convert.ToInt32(idtxt.Text),
                sectionId= Convert.ToInt32(unitCode.Text),
                termNum= Convert.ToInt32(termNumTXT.Text),
                number=0
            }))
            {
                this.Text = "واحد انتخاب شد";
                dataGridView1.DataSource = (new DB_C1()).selectionUnits.ToList();

            }
            else
            {
                MessageBox.Show("واحد انتخاب نشد");
            }
        }
    }
}
