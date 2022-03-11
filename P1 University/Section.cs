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
    }
}
