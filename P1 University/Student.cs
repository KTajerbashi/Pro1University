using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_University
{
    internal class Student : Person
    {
        public int studentCode { get; set; }

        public bool select(Student student)
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

        public bool register(Student student)
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
                return true;

            }

            return false;
        }

        
    }
}
