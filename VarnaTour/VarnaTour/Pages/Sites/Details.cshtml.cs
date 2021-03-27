using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using VarnaTour.Data;
using VarnaTour.Models;

namespace VarnaTour.Pages.Sites
{
    public class DetailsModel : PageModel
    {
        private readonly VarnaTour.Data.ApplicationDbContext _context;

        public DetailsModel(VarnaTour.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Site Site { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Site = await _context.Site.FirstOrDefaultAsync(m => m.Id == id);

            if (Site == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
