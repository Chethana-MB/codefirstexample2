using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codefirstexample2
{
    public class category
    {
        public int Id { set; get; }
        public string catename { set; get; }
    }
    public class Course
    {
        public int Id { set; get; }
        public string Title { set; get; }
        public string Description { set; get; }
        public float fullprice { set; get; }

        public category category { set; get; }
    }

    public class PlutoContext : DbContext
    {
        public DbSet<Course> Courses { set; get; }
        public DbSet<category> cats { set; get; }
    }



    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
