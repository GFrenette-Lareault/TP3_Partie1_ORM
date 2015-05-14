using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP3_ORM.View;

namespace TP3_ORM.Controller
{
    public class TutorController
    {

        public void AfficherListeTuteurs()
        {
            TutorListView view = new TutorListView();

            view.ShowTutorList();
        }

        public void AfficherListTuteurs2Juin()
        {
            Tutor2Juin view = new Tutor2Juin();

            view.ShowTutorList();
        }
    }
}
