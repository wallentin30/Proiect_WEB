using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proiect_WEB.Models
{
    public class Status
    {
        public int ID { get; set; }
        [Display(Name = "Status Angajat")]
        public string StatusAngajat { get; set; }
        public ICollection<Employee> Employees { get; set; }
    }
}
