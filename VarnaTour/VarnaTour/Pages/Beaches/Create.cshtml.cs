using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using VarnaTour.Data;
using VarnaTour.Enums;
using VarnaTour.Models;

namespace VarnaTour.Pages.Beaches
{
    public class CreateModel : PageModel
    {
        private readonly VarnaTour.Data.ApplicationDbContext _context;

        public CreateModel(VarnaTour.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Beach Beach { get; set; }

        [BindProperty]
        public BeachType BeachTypeName { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Beach.Add(Beach);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
