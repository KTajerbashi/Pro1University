using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_University
{
    internal class Teacher : Person
    {
        public String degree { get; set; }
        public bool select(Teacher teacher)
        {
            DB_C1 dbc1 = new DB_C1();
            foreach (var item in dbc1.students)
            {
                if (item.name == teacher.name && item.family == teacher.family && item.fatherName == teacher.fatherName)
                {
                    return true;
                }
            }
            return false;
        }
        public bool register(Teacher teacher)
        {
            DB_C1 dbc1 = new DB_C1();
            if (!select(teacher))
            {
                dbc1.teachers.Add(new Teacher
                {
                    name = teacher.name,
                    fatherName = teacher.fatherName,
                    family = teacher.family,
                    nationalID = teacher.nationalID,
                    phone = teacher.phone,
                    age = teacher.age,
                    address = teacher.address,
                    field = teacher.field,
                    degree = teacher.degree,
                });
                dbc1.SaveChanges();
                return true;

            }

            return false;
        }

    }
}
