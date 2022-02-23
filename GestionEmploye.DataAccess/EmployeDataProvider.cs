using GestionEmploye.Common.Model;
using GestionEmploye.Common.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionEmploye.Common;
using System.Diagnostics;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace GestionEmploye.DataAccess
{
    public class EmployeDataProvider : IEmployeDataProvider
    {
        public IEnumerable<Employe> ChargerEmployes()
        {
            IEnumerable<Employe> res;

            res = new List<Employe>()
            {
                new Employe
                {
                    Id = 1,
                    Nom = "Cageot",
                    Prenom = "Roger",
                    DateEmbauche = new DateTime(2021, 10, 15),
                    EstPiloteDeLigne = false,
                    RoleId = 4
                },
                new Employe
                {
                    Id = 2,
                    Nom = "Dickinson",
                    Prenom = "Roger",
                    DateEmbauche = new DateTime(2021, 10, 14),
                    EstPiloteDeLigne = false,
                    RoleId = 3

                },
                new Employe
                {
                    Id = 3,
                    Nom = "Smith",
                    Prenom = "Adrian",
                    DateEmbauche = new DateTime(2021, 10, 13),
                    EstPiloteDeLigne = true,
                    RoleId = 2

                }
            };


                return res;
        }



    

        public IEnumerable<Role> ChargerRoles()
        {
            return new List<Role>
                {
                    new Role { IdRole = 1, Nom = "Chanteur" },
                    new Role { IdRole = 2, Nom = "Guitariste" },
                    new Role { IdRole = 3, Nom = "Bassiste" },
                    new Role { IdRole = 4, Nom = "Batteur" }
                };
        }


        public void SauvegarderEmploye(Employe employe)
        {
            Debug.WriteLine($"Employe sauvegardé : { employe.Nom}");

        }

    }
}
