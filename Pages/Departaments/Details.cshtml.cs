﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Proiect_WEB.Data;
using Proiect_WEB.Models;

namespace Proiect_WEB.Pages.Departaments
{
    public class DetailsModel : PageModel
    {
        private readonly Proiect_WEB.Data.Proiect_WEBContext _context;

        public DetailsModel(Proiect_WEB.Data.Proiect_WEBContext context)
        {
            _context = context;
        }

        public Departament Departament { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Departament = await _context.Departament.FirstOrDefaultAsync(m => m.ID == id);

            if (Departament == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
