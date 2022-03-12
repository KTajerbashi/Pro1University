using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_University
{
    internal class Section
    {
        public int id { get; set; }
        public int LessonId { get; set; }
        public int teacherId { get; set; }
        public int day { get; set; }
        public DateTimeOffset lessonHR { get; set; }
        public int classNum { get; set; }

        public bool mergeLesTea(Section section, String lesson,String teacher)
        {
            if(lesson == teacher || lesson == "عمومی" || teacher=="عمومی")
            {
                DB_C1 dbc = new DB_C1();
                dbc.sections.Add(new Section
                {
                    LessonId = section.LessonId,
                    teacherId = section.teacherId,
                    day = section.day,
                    lessonHR = section.lessonHR,
                    classNum = section.classNum
                });
                dbc.SaveChanges();
                return true;

            }
            return false;
        }
        
    }
    
}
