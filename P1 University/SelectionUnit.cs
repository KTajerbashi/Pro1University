using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_University
{
    internal class SelectionUnit
    {
        public int id { get; set; }
        public int sectionId { get; set; }
        public int studentId { get; set; }
        public int termNum { get; set; }
        public float number { get; set; }

        public bool selectionRegister(SelectionUnit selectionUnit)
        {
            DB_C1 db = new DB_C1();
            //foreach(var item in db.selectionUnits)
            //{
            //    if (item.studentId == stID)
            //    {
            //        return false;
            //    }
            //}
            if (selectionUnit.studentId > 0)
            {
                db.selectionUnits.Add(new SelectionUnit
                {
                    sectionId = selectionUnit.sectionId,
                    studentId = selectionUnit.studentId,
                    termNum = selectionUnit.termNum,
                    number = selectionUnit.number
                });
                db.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
