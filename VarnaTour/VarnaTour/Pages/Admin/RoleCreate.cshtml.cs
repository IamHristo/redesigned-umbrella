using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using VarnaTour.Data;
using VarnaTour.Models;

namespace VarnaTour.Pages.Admin
{
    public class RoleCreateModel : PageModel
    {
        private readonly VarnaTour.Data.ApplicationDbContext _context;

        public RoleCreateModel(VarnaTour.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public ProjectRole ProjectRole { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.ProjectRole.Add(ProjectRole);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
