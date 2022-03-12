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
        
        private void save2btn_Click(object sender, EventArgs e)
        {

            if (MainCodeTXT.Text == "121212")
            {
                Teacher teacher= new Teacher();
                if (teacher.register(new Teacher
                {
                    name = nametxt.Text,
                    family = familytxt.Text,
                    fatherName = fathertxt.Text,
                    phone = phonetxt.Text,
                    address = addresstxt.Text,
                    nationalID = Convert.ToInt32(nationaltxt.Text),
                    field = fieldtxt.Text,
                    age = Convert.ToByte(agetxt.Text),
                    degree=degreeTXT.Text

                }))
                {
                    MessageBox.Show("استاد ثبت نام شد");
                    this.Text = "ثبت نام شدید";
                }
                else
                {
                    this.Text = "اطلاعات اضافه نشد";
                    MessageBox.Show("ثبت نام ناموفق");
                }
            }
            else if (MainCodeTXT.Text == "111111")
            {
                Student student = new Student();
                if (student.register(new Student
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
                    MessageBox.Show("دانشجو ثبت نام شد");
                    this.Text="ثبت نام شدید";
                }
                else
                {
                    this.Text = "اطلاعات اضافه نشد";

                    MessageBox.Show("ثبت نام ناموفق");
                }
            }
            
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Text = "خروج";
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Text = "ثبت اطلاعات هویت";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Text = "ثبت اطلاعات تکمیلی";

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Text = "ثبت اطلاعات رشته تحصیلی";

        }

        private void save1btn_Click(object sender, EventArgs e)
        {
            this.Text = "کد تایید شد";
            
        }
    }
}
