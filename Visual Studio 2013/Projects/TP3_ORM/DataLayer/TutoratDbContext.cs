using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using DataLayer.Model;
namespace DataLayer
{
    public class TutoratDbContext : DbContext
    {
        public DbSet<Tutor> Tutors { get; set; }
        public DbSet<HelpedStudent> HelpedStudents { get; set; }
        public DbSet<TutoringSession> TutoringSessions { get; set; }
    }
}
