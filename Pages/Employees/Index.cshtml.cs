using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Proiect_WEB.Data;
using Proiect_WEB.Models;

namespace Proiect_WEB.Pages.Employees
{
    public class IndexModel : PageModel
    {
        private readonly Proiect_WEB.Data.Proiect_WEBContext _context;

        public IndexModel(Proiect_WEB.Data.Proiect_WEBContext context)
        {
            _context = context;
        }

        public IList<Employee> Employee { get;set; }

        public async Task OnGetAsync()
        {
            Employee = await _context.Employee.Include(b => b.Departament).ToListAsync();
            Employee = await _context.Employee.Include(b => b.Status).ToListAsync();
        }
    }
}
