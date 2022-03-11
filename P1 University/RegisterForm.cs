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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }
        #region function
        bool select(Student student)
        {
            DB_C1 dbc1 = new DB_C1();
            foreach (var item in dbc1.students)
            {
                if (item.name == student.name && item.family == student.family && item.fatherName == student.fatherName)
                {
                    return true;
                }
            }
            return false;
        }
        bool register(Student student)
        {
            DB_C1 dbc1 = new DB_C1();
            if (!select(student))
            {
                dbc1.students.Add(new Student
                {
                    studentCode = student.studentCode,
                    name = student.name,
                    fatherName = student.fatherName,
                    family = student.family,
                    nationalID = student.nationalID,
                    phone = student.phone,
                    age = student.age,
                    address = student.address,
                    field = student.field
                });
                dbc1.SaveChanges();
                this.Text = "ثبت نام شد";
                return true;

            }

            return false;
        }
        #endregion
        private void save2btn_Click(object sender, EventArgs e)
        {
            if(register(new Student
            {
                name = nametxt.Text,
                family = familytxt.Text,
                fatherName = fathertxt.Text,
                phone = phonetxt.Text,
                address = addresstxt.Text,
                nationalID = Convert.ToInt32(nationaltxt.Text),
                field = fieldtxt.Text,
                age = Convert.ToByte(agetxt.Text),
                studentCode = 983310
            }))
            {
                MessageBox.Show("ثبت نام شدید");
            }
            else
            {
                MessageBox.Show("ثبت نام ناموفق");
            }
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Text = "خروج";
            this.Close();
        }
    }
}
