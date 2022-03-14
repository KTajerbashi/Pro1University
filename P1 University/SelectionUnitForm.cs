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

        private void SelectionUnitForm_Load(object sender, EventArgs e)
        {
            dataGridView4.DataSource = (new DB_C1()).sections.ToList();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            dataGridView4.DataSource = (new DB_C1()).sections.ToList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DB_C1 db = new DB_C1();
            if (idtxt.Text.Length == 0 && lescodeTXT.Text.Length == 0 && teaCodeTxt.Text.Length == 0)
            {
                this.Text = "فیلد خالی است";
            }
            else
            {
                int Sid = Convert.ToInt32(idtxt.Text);
                
                foreach (var i in db.students)
                {
                    if (i.id == Sid)
                    {
                        stuNmTxt.Text = i.name + " " + i.family;
                        stuFieTxt.Text = i.field;
                        break;
                    }
                }
                
            }

            

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
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
                    teaNameTXT.Text = item.name.ToString() + " " + item.family.ToString();
                //    teaFieTXT.Text = item.field.ToString();
                }
            }
            int idLes = Convert.ToInt16(lescodeTXT.Text);
            foreach(var item in db.lessons)
            {
                if(item.id == idLes)
                {
                 //   lesFieTXT.Text = item.field.ToString();
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
            }
            else
            {
                MessageBox.Show("واحد انتخاب نشد");
            }
            
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            DB_C1 db = new DB_C1();

            if (lescodeTXT.Text.Length == 0 && teaCodeTxt.Text.Length == 0)
            {
                this.Text = "فید خالی است";
            }
            else
            {
                
                if(lescodeTXT.Text.Length == 0)
                {//لیست دروس ارایه شده توسط استاد
                    List<Int32> list = new List<Int32>();
                    List<Lesson> lesson = new List<Lesson>();
                    foreach (var item in db.sections)
                    {
                        if(item.teacherId == Convert.ToInt16(teaCodeTxt.Text))
                        {
                            list.Add(item.LessonId);
                        }
                        
                    }
                    foreach(var item in db.lessons)
                    {
                        foreach(var i in list)
                        {
                            if (item.id == i)
                            {
                                lesson.Add(item);
                            }
                        }
                    }
                    dataGridView1.DataSource = lesson.ToList();
                }
                else
                {
                    List<Int32> list = new List<Int32>();
                    List<Teacher> teacher = new List<Teacher>();
                    foreach (var item in db.sections)
                    {
                        if (item.LessonId == Convert.ToInt16(lescodeTXT.Text))
                        {
                            list.Add(item.teacherId);
                        }

                    }
                    foreach (var item in db.teachers)
                    {
                        foreach (var i in list)
                        {
                            if (item.id == i)
                            {
                                teacher.Add(item);
                            }
                        }
                    }
                    dataGridView1.DataSource = teacher.ToList();
                }
            }

            
        }

        

       
    }
}
