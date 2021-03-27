using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace VarnaTour.Areas.Identity.Pages.Account.Manage
{
    public class VirtualMapModel : PageModel
    {

        [TempData]
        public string StatusMessage { get; set; }

        public void OnGet()
        {
        }
    }
}
