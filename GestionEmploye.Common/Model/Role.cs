using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEmploye.Common.Model
{
    public class Role
    {
        [Key]
        public int IdRole { get; set; }
        public string Nom { get; set; }

        [ForeignKey("EmployeFk")]
        public ICollection<Employe> Employes { get; set; }
    }
}
