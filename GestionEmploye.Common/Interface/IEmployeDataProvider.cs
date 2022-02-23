using GestionEmploye.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEmploye.Common.Interface
{
    public interface IEmployeDataProvider
    {
        IEnumerable<Employe> ChargerEmployes();
        void SauvegarderEmploye(Employe employe);
        IEnumerable<Role> ChargerRoles();
    }
}
