using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proiect_WEB.Models
{
    public class Departament
    {
        public int ID { get; set; }
        [Display(Name = "Nume departament")]
        public string NumeDepartament { get; set; }
        public ICollection<Employee> Employees { get; set; }
    }
}
