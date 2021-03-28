using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using VarnaTour.Data;
using VarnaTour.Models;

namespace VarnaTour.Pages.Beaches
{
    public class BeachesDetailsModel : PageModel
    {
        private readonly VarnaTour.Data.ApplicationDbContext _context;

        public BeachesDetailsModel(VarnaTour.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Beach> Beach { get;set; }

        public async Task OnGetAsync()
        {
            Beach = await _context.Beach.ToListAsync();
        }
    }
}
