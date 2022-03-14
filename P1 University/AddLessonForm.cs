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
    public partial class AddLessonForm : Form
    {
        public AddLessonForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        bool select(Lesson lesson)
        {
            DB_C1 db = new DB_C1();
            foreach(var item in db.lessons)
            {
                if(item.title==lesson.title && item.lessonCode == lesson.lessonCode)
                {
                    return true;
                }
            }
            return false;
        }
        bool addLesson( Lesson lesson)
        {
            DB_C1 db = new DB_C1();
            if (!select(lesson))
            {
                db.lessons.Add(new Lesson
                {
                    lessonCode = lesson.lessonCode,
                    title = lesson.title,
                    field = lesson.field,
                    unitNum = lesson.unitNum
                });
                db.SaveChanges();
                return true;
            }
            return false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            #region code
            int i = Convert.ToInt32(textBox1.Text);
            i++;
            textBox1.Text = Convert.ToString(i);
            #endregion
            if (!addLesson(new Lesson
            {
                lessonCode = Convert.ToInt32(textBox1.Text),
                title = textBox2.Text,
                field = textBox3.Text,
                unitNum = Convert.ToInt16(textBox4.Text)
            }))
            {
                this.Text = "درس تکراری است";
            }
            else
            {
                this.Text = "درس اضافه شد";
                dataGridView1.DataSource = (new DB_C1().lessons).ToList();

            }
        }

        private void AddLessonForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = (new DB_C1().lessons).ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = (new DB_C1().lessons).ToList();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            dataGridView1.DataSource = (new DB_C1().lessons).ToList();

        }
    }
}
