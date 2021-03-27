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
    public class IndexModel : PageModel
    {
        private readonly VarnaTour.Data.ApplicationDbContext _context;

        public IndexModel(VarnaTour.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Site> Site { get;set; }

        public async Task OnGetAsync()
        {
            Site = await _context.Site.ToListAsync();
        }
    }
}
