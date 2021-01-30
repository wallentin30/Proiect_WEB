using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proiect_WEB.Models
{
    public class Employee
    {
        public int ID { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }

        [Display(Name = "Data Angajarii")]
        [DataType(DataType.Date)]
        public DateTime DataAngajarii { get; set; }
        public int DepartamentID { get; set; }
        public Departament Departament { get; set; }

        [Column(TypeName = "decimal(6, 2)")]
        public decimal Salariu { get; set; }
        public string Oras { get; set; }
        public int StatusID { get; set; }
        public Status Status { get; set; }
    }
}
