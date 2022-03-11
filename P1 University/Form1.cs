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
        #region function
        bool select(Student student)
        {
            DB_C1 dbc1 = new DB_C1();
            foreach(var item in dbc1.students)
            {
                if(item.name == student.name && item.family==student.family && item.fatherName == student.fatherName)
                {
                    return true;
                }
            }
            return false;
        }
        bool register(Student student)
        {
            DB_C1 dbc1 = new DB_C1();
            if (!select(student) )
            {
                dbc1.students.Add(new Student
                {
                    studentCode=student.studentCode,
                    name = student.name,
                    fatherName=student.fatherName,
                    family=student.family,
                    nationalID=student.nationalID,
                    phone=student.phone,
                    age=student.age,
                    address=student.address,
                    field=student.field
                });
                dbc1.SaveChanges();
                this.Text = "ثبت نام شد";
                return true;

            }

                return false;
        }
        #endregion
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
