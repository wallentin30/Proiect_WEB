using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Proiect_WEB.Models;

namespace Proiect_WEB.Data
{
    public class Proiect_WEBContext : DbContext
    {
        public Proiect_WEBContext (DbContextOptions<Proiect_WEBContext> options)
            : base(options)
        {
        }

        public DbSet<Proiect_WEB.Models.Employee> Employee { get; set; }

        public DbSet<Proiect_WEB.Models.Departament> Departament { get; set; }

        public DbSet<Proiect_WEB.Models.Status> Status { get; set; }
    }
}
