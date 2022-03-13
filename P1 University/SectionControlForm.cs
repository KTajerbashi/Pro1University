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
            lescod.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            lesCodeTXT.Text = lescod.Text;
            lesNameTXT.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            nameLes.Text = lesNameTXT.Text;
            lesFieldTXT.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            fieldless.Text = lesFieldTXT.Text;
            lesGroTXT.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            unitTXT.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
        }

        private void saveBTN_Click(object sender, EventArgs e)
        {
            Section section = new Section();
            if(section.mergeLesTea(new Section
            {
                LessonId = Convert.ToInt32(lesCodeTXT.Text),
                teacherId = Convert.ToInt32(teacodTXT.Text),
                day = Convert.ToInt32(dayTXT.Text),
                lessonHR = Convert.ToDateTime(hourTXT.Text),
                classNum = Convert.ToInt32(ClassNumTXT.Text)
            }, lesFieldTXT.Text, teaFieTXT.Text))
            {
                this.Text = "عملیات با موفق ثبت شد";
            }
            else
            {
                this.Text = "این انتخاب اشتباه است";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DB_C1 db = new DB_C1();
            var les = from item in db.lessons where (item.title).Contains(lesNameTXT.Text) select item;
            dataGridView2.DataSource = les.ToList();
            var tea = from item in db.teachers where (item.name).Contains(teanameTXT.Text) select item;
            dataGridView1.DataSource = tea.ToList();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = (new DB_C1().teachers).ToList();
            dataGridView2.DataSource = (new DB_C1().lessons).ToList();
        }
    }
}
