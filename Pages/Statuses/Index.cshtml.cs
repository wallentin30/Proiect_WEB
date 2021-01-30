using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Proiect_WEB.Data;
using Proiect_WEB.Models;

namespace Proiect_WEB.Pages.Statuses
{
    public class IndexModel : PageModel
    {
        private readonly Proiect_WEB.Data.Proiect_WEBContext _context;

        public IndexModel(Proiect_WEB.Data.Proiect_WEBContext context)
        {
            _context = context;
        }

        public IList<Status> Status { get;set; }

        public async Task OnGetAsync()
        {
            Status = await _context.Status.ToListAsync();
        }
    }
}
