using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using DataLayer.Model;

namespace TP3_ORM.View
{
    public class TutorListView
    {
        public TutorListView()
        {

        }

        public void ShowTutorList()
        {
            var context = new TutoratDbContext();

            var query =
                from tutor in context.Tutors
                select new
                {
                    TutorID = tutor.Id,
                    LastName = tutor.LastName,
                    FirstName = tutor.FirstName,
                    EmailAdress = tutor.EmailAdress
                };
            foreach (var tuteurs in query)
            {
                Console.WriteLine("TutorID : {0} Name : {1} {2} Email Adress : {3}",
                    tuteurs.TutorID, tuteurs.FirstName, tuteurs.LastName, tuteurs.EmailAdress);
            }
            Console.ReadLine();

        }
    }
}
