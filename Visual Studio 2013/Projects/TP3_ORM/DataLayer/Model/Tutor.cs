using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DataLayer.Model
{
    public class Tutor : Entity
    {
        public Tutor()
        {
            this.Sessions = new HashSet<TutoringSession>();
        }
        public string EmailAdress { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ICollection<TutoringSession> Sessions { get; set; }
    }
}
