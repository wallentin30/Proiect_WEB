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
    public class DetailsModel : PageModel
    {
        private readonly Proiect_WEB.Data.Proiect_WEBContext _context;

        public DetailsModel(Proiect_WEB.Data.Proiect_WEBContext context)
        {
            _context = context;
        }

        public Employee Employee { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Employee = await _context.Employee.FirstOrDefaultAsync(m => m.ID == id);

            if (Employee == null)
            {
                return NotFound();
            }
            ViewData["DepartamentID"] = new SelectList(_context.Set<Departament>(), "ID", "NumeDepartament");
            ViewData["StatusID"] = new SelectList(_context.Set<Status>(), "ID", "StatusAngajat");

            return Page();
        }
    }
}
