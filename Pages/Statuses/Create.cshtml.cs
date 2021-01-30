using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Proiect_WEB.Data;
using Proiect_WEB.Models;

namespace Proiect_WEB.Pages.Statuses
{
    public class CreateModel : PageModel
    {
        private readonly Proiect_WEB.Data.Proiect_WEBContext _context;

        public CreateModel(Proiect_WEB.Data.Proiect_WEBContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Status Status { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Status.Add(Status);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
