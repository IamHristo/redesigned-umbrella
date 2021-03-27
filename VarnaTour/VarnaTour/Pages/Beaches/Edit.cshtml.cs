using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VarnaTour.Data;
using VarnaTour.Enums;
using VarnaTour.Models;

namespace VarnaTour.Pages.Beaches
{
    public class EditModel : PageModel
    {
        private readonly VarnaTour.Data.ApplicationDbContext _context;

        public EditModel(VarnaTour.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Beach Beach { get; set; }

        [BindProperty]
        public BeachType BeachType { get; set; }

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

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Beach).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BeachExists(Beach.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool BeachExists(int id)
        {
            return _context.Beach.Any(e => e.ID == id);
        }
    }
}
