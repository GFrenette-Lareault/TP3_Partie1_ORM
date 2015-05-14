using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Model;
using DataLayer.EfEntityFramework;
using TP3_ORM.Controller;
using DataLayer;
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Pour voir les entrées des 3 tables appuyez sur 0,");
            Console.WriteLine("Pour voir la requête 1 appuyez sur 1,");
            Console.WriteLine("Pour voir la requête 2 appuyez sur 2,");
            Console.WriteLine("Pour voir la requête 3 appuyez sur 3,");
            Console.WriteLine("Pour voir la requête 4 appuyez sur 4,");
            Console.WriteLine("Pour peupler les tables appuyez sur 5 :");

            string resultat = Console.ReadLine();

            if (resultat == "0")
            {
                var context = new TutoratDbContext();

                var query =
                    from tutor in context.Tutors
                    from helped in context.HelpedStudents
                    from sessions in context.TutoringSessions
                    select new
                    {
                        TutorID = tutor.Id,
                        TutorLastName = tutor.LastName,
                        TutorFirstName = tutor.FirstName,
                        TutorEmailAdress = tutor.EmailAdress,

                        HelpedID = helped.Id,
                        HelpedLastName = helped.LastName,
                        HelpedFirstName = helped.FirstName,
                        HelpedEmailAdress = helped.EmailAdress,

                        SessionsId = sessions.Id,
                        SessionsTutorId = sessions.TutorId,
                        SessionsHelpedId = sessions.HelpedId,
                        SessionsTime = sessions.DateTimeSession,
                        SessionsLenght = sessions.LenghtSession
                    };
                foreach (var tuteurs in query)
                {
                    Console.WriteLine("TutorID : {0} Name : {1} {2} Email Adress : {3}",
                        tuteurs.TutorID, tuteurs.TutorFirstName, tuteurs.TutorLastName, tuteurs.TutorEmailAdress);
                }
                foreach (var helped in query)
                {
                    Console.WriteLine("HelpedID : {0} Name : {1} {2} Email Adress : {3}",
                        helped.HelpedID, helped.HelpedFirstName, helped.HelpedLastName, helped.HelpedEmailAdress);
                }
                foreach (var session in query)
                {
                    Console.WriteLine("SessionID : {0} TutorId : {1} HelpedId : {2} Time : {3} Lenght Session : {4}",
                        session.SessionsId, session.SessionsTutorId, session.SessionsHelpedId, session.SessionsTime, session.SessionsLenght);
                }
                Console.ReadLine();

            }
            else if (resultat == "1")
            {
                TutorController controller = new TutorController();
                controller.AfficherListeTuteurs();
            }
            else if (resultat == "4")
            {
                TutorController controller = new TutorController();
                controller.AfficherListTuteurs2Juin();
            }
            else if (resultat == "5")
            {
                var contextTutor = new EfEntityRepository<Tutor>();

                var tutorGB = new Tutor();
                tutorGB.LastName = "Bilodeau";
                tutorGB.FirstName = "Gary";
                tutorGB.EmailAdress = "bgary2@hotmail.com";
                contextTutor.Add(tutorGB);

                var tutorSG = new Tutor();
                tutorSG.LastName = "Gagnon";
                tutorSG.FirstName = "Samuel";
                tutorSG.EmailAdress = "samPP92@hotmail.com";
                contextTutor.Add(tutorSG);

                var tutorSimG = new Tutor();
                tutorSimG.LastName = "Gingras";
                tutorSimG.FirstName = "Simon";
                tutorSimG.EmailAdress = "ptitguy22@bell.net";
                contextTutor.Add(tutorSimG);

                var tutorER = new Tutor();
                tutorER.LastName = "Roy";
                tutorER.FirstName = "Éric";
                tutorER.EmailAdress = "eroy231@videotron.ca";
                contextTutor.Add(tutorER);

                var tutorCV = new Tutor();
                tutorCV.LastName = "Veilleux";
                tutorCV.FirstName = "Caroline";
                tutorCV.EmailAdress = "caro.koko@hotmail.com";
                contextTutor.Add(tutorCV);

                var tutorKT = new Tutor();
                tutorKT.LastName = "Tremblay";
                tutorKT.FirstName = "Karine";
                tutorKT.EmailAdress = "kar.tremblay@gmail.com";
                contextTutor.Add(tutorKT);

                var tutorLV = new Tutor();
                tutorLV.LastName = "Vézina";
                tutorLV.FirstName = "Louis";
                tutorLV.EmailAdress = "vl410Bd@gmail.com";
                contextTutor.Add(tutorLV);


                var contextHelpedStudent = new EfEntityRepository<HelpedStudent>();

                var helpedMA = new HelpedStudent();
                helpedMA.LastName = "Arsenault";
                helpedMA.FirstName = "Marc";
                helpedMA.EmailAdress = "marco.arso@hotmail.com";
                contextHelpedStudent.Add(helpedMA);

                var helpedEB = new HelpedStudent();
                helpedEB.LastName = "Boilard";
                helpedEB.FirstName = "Éric";
                helpedEB.EmailAdress = "eric.r.boilard@coop.com";
                contextHelpedStudent.Add(helpedEB);

                var helpedJCC = new HelpedStudent();
                helpedJCC.LastName = "Couture";
                helpedJCC.FirstName = "Jean-Christophe";
                helpedJCC.EmailAdress = "jc.couture.wilde@hotmail.com";
                contextHelpedStudent.Add(helpedJCC);

                var helpedJD = new HelpedStudent();
                helpedJD.LastName = "Desrosiers";
                helpedJD.FirstName = "Julianne";
                helpedJD.EmailAdress = "galypo13@hotmail.com";
                contextHelpedStudent.Add(helpedJD);

                var helpedLGA = new HelpedStudent();
                helpedLGA.LastName = "Grégoire-Allen";
                helpedLGA.FirstName = "Léo";
                helpedLGA.EmailAdress = "leoga@hotmail.com";
                contextHelpedStudent.Add(helpedLGA);

                var helpedFH = new HelpedStudent();
                helpedFH.LastName = "Hamel";
                helpedFH.FirstName = "François";
                helpedFH.EmailAdress = "fhamel@hotmail.com";
                contextHelpedStudent.Add(helpedFH);

                var helpedJL = new HelpedStudent();
                helpedJL.LastName = "Lepage";
                helpedJL.FirstName = "Jérémy";
                helpedJL.EmailAdress = "jlepage@hotmail.com";
                contextHelpedStudent.Add(helpedJL);

                var helpedNP = new HelpedStudent();
                helpedNP.LastName = "Poitras";
                helpedNP.FirstName = "Nicolas";
                helpedNP.EmailAdress = "npoitras@hotmail.com";
                contextHelpedStudent.Add(helpedNP);

                var helpedSRG = new HelpedStudent();
                helpedSRG.LastName = "Roy-Gagnon";
                helpedSRG.FirstName = "Samuel";
                helpedSRG.EmailAdress = "sroy@hotmail.com";
                contextHelpedStudent.Add(helpedSRG);

                var helpedBS = new HelpedStudent();
                helpedBS.LastName = "Simard";
                helpedBS.FirstName = "Benjamin";
                helpedBS.EmailAdress = "bsimard@hotmail.com";
                contextHelpedStudent.Add(helpedBS);

                var helpedSV = new HelpedStudent();
                helpedSV.LastName = "Vachon";
                helpedSV.FirstName = "Samuel";
                helpedSV.EmailAdress = "svachon@hotmail.com";
                contextHelpedStudent.Add(helpedSV);


                var contextSessions = new EfEntityRepository<TutoringSession>();

                var session = new TutoringSession();
                session.DateTimeSession = new DateTime(2015, 03, 16, 13, 00, 00);
                session.LenghtSession = 2;
                session.Helped = helpedLGA;
                session.HelpedId = helpedLGA.Id;
                session.Tutor = tutorCV;
                session.TutorId = tutorCV.Id;
                contextSessions.Add(session);

                var session1 = new TutoringSession();
                session1.DateTimeSession = new DateTime(2015, 03, 24, 10, 00, 00);
                session1.LenghtSession = 1;
                session1.Helped = helpedLGA;
                session1.HelpedId = helpedLGA.Id;
                session1.Tutor = tutorGB;
                session1.TutorId = tutorGB.Id;
                contextSessions.Add(session1);

                var session2 = new TutoringSession();
                session2.DateTimeSession = new DateTime(2015, 03, 25, 13, 00, 00);
                session2.LenghtSession = 1;
                session2.Helped = helpedEB;
                session2.HelpedId = helpedEB.Id;
                session2.Tutor = tutorER;
                session2.TutorId = tutorER.Id;
                contextSessions.Add(session2);

                var session3 = new TutoringSession();
                session3.DateTimeSession = new DateTime(2015, 04, 01, 12, 00, 00);
                session3.LenghtSession = 2;
                session3.Helped = helpedMA;
                session3.HelpedId = helpedMA.Id;
                session3.Tutor = tutorCV;
                session3.TutorId = tutorCV.Id;
                contextSessions.Add(session3);

                var session4 = new TutoringSession();
                session4.DateTimeSession = new DateTime(2015, 04, 01, 13, 00, 00);
                session4.LenghtSession = 1;
                session4.Helped = helpedEB;
                session4.HelpedId = helpedEB.Id;
                session4.Tutor = tutorSG;
                session4.TutorId = tutorSG.Id;
                contextSessions.Add(session4);

                var session5 = new TutoringSession();
                session5.DateTimeSession = new DateTime(2015, 04, 06, 16, 00, 00);
                session5.LenghtSession = 1;
                session5.Helped = helpedMA;
                session5.HelpedId = helpedMA.Id;
                session5.Tutor = tutorER;
                session5.TutorId = tutorER.Id;
                contextSessions.Add(session5);

                var session6 = new TutoringSession();
                session6.DateTimeSession = new DateTime(2015, 04, 08, 10, 00, 00);
                session6.LenghtSession = 1;
                session6.Helped = helpedFH;
                session6.HelpedId = helpedFH.Id;
                session6.Tutor = tutorER;
                session6.TutorId = tutorER.Id;
                contextSessions.Add(session6);

                var session7 = new TutoringSession();
                session7.DateTimeSession = new DateTime(2015, 04, 10, 10, 00, 00);
                session7.LenghtSession = 2;
                session7.Helped = helpedMA;
                session7.HelpedId = helpedMA.Id;
                session7.Tutor = tutorER;
                session7.TutorId = tutorER.Id;
                contextSessions.Add(session7);

                var session8 = new TutoringSession();
                session8.DateTimeSession = new DateTime(2015, 04, 29, 12, 00, 00);
                session8.LenghtSession = 1;
                session8.Helped = helpedSRG;
                session8.HelpedId = helpedSRG.Id;
                session8.Tutor = tutorCV;
                session8.TutorId = tutorCV.Id;
                contextSessions.Add(session8);

                var session9 = new TutoringSession();
                session9.DateTimeSession = new DateTime(2015, 05, 25, 13, 00, 00);
                session9.LenghtSession = 1;
                session9.Helped = helpedBS;
                session9.HelpedId = helpedBS.Id;
                session9.Tutor = tutorLV;
                session9.TutorId = tutorLV.Id;
                contextSessions.Add(session9);

                var session10 = new TutoringSession();
                session10.DateTimeSession = new DateTime(2015, 05, 27, 12, 00, 00);
                session10.LenghtSession = 2;
                session10.Helped = helpedBS;
                session10.HelpedId = helpedBS.Id;
                session10.Tutor = tutorCV;
                session10.TutorId = tutorCV.Id;
                contextSessions.Add(session10);

                var session11 = new TutoringSession();
                session11.DateTimeSession = new DateTime(2015, 05, 27, 13, 00, 00);
                session11.LenghtSession = 1;
                session11.Helped = helpedEB;
                session11.HelpedId = helpedEB.Id;
                session11.Tutor = tutorSimG;
                session11.TutorId = tutorSimG.Id;
                contextSessions.Add(session11);

                var session12 = new TutoringSession();
                session12.DateTimeSession = new DateTime(2015, 06, 01, 9, 00, 00);
                session12.LenghtSession = 1;
                session12.Helped = helpedJL;
                session12.HelpedId = helpedJL.Id;
                session12.Tutor = tutorLV;
                session12.TutorId = tutorLV.Id;
                contextSessions.Add(session12);

                var session13 = new TutoringSession();
                session13.DateTimeSession = new DateTime(2015, 06, 02, 9, 00, 00);
                session13.LenghtSession = 1;
                session13.Helped = helpedSV;
                session13.HelpedId = helpedSV.Id;
                session13.Tutor = tutorLV;
                session13.TutorId = tutorLV.Id;
                contextSessions.Add(session13);

                var session14 = new TutoringSession();
                session14.DateTimeSession = new DateTime(2015, 06, 02, 11, 00, 00);
                session14.LenghtSession = 1;
                session14.Helped = helpedEB;
                session14.HelpedId = helpedEB.Id;
                session14.Tutor = tutorLV;
                session14.TutorId = tutorLV.Id;
                contextSessions.Add(session14);

                var session15 = new TutoringSession();
                session15.DateTimeSession = new DateTime(2015, 06, 02, 13, 00, 00);
                session15.LenghtSession = 1;
                session15.Helped = helpedLGA;
                session15.HelpedId = helpedLGA.Id;
                session15.Tutor = tutorGB;
                session15.TutorId = tutorGB.Id;
                contextSessions.Add(session15);

                var session16 = new TutoringSession();
                session16.DateTimeSession = new DateTime(2015, 06, 02, 15, 00, 00);
                session16.LenghtSession = 1;
                session16.Helped = helpedSRG;
                session16.HelpedId = helpedSRG.Id;
                session16.Tutor = tutorER;
                session16.TutorId = tutorER.Id;
                contextSessions.Add(session16);

                var session17 = new TutoringSession();
                session17.DateTimeSession = new DateTime(2015, 06, 03, 13, 00, 00);
                session17.LenghtSession = 2;
                session17.Helped = helpedJL;
                session17.HelpedId = helpedJL.Id;
                session17.Tutor = tutorSimG;
                session17.TutorId = tutorSimG.Id;
                contextSessions.Add(session17);

                Console.WriteLine("Tables correctement peuplées");
            }

            Console.ReadLine();
            }
    }
