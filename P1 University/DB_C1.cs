using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace P1_University
{
    internal class DB_C1 : DbContext
    {
        public DB_C1():base("CSDB")
        {

        }
        public DbSet<Student> students { set; get; }
        public DbSet<Teacher> teachers { set; get; }
        public DbSet<Lesson> lessons { set; get; }
        public DbSet<SelectionUnit> selectionUnits { set; get; }
        public DbSet<Section> sections { set; get; }
    }
}
