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
    public class DetailsModel : PageModel
    {
        private readonly VarnaTour.Data.ApplicationDbContext _context;

        public DetailsModel(VarnaTour.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Beach Beach { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Beach = await _context.Beach.FirstOrDefaultAsync(m => m.ID == id);

            if (Beach == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
