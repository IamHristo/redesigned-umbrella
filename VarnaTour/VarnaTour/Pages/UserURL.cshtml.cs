using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using Microsoft.AspNetCore.Identity;

namespace VarnaTour.Pages
{
    public class UserURLModel : PageModel
    {
        [BindProperty]
        public int ID { get; set; }

        [BindProperty]
        public string UserName { get; set; }


        public void OnGet(int id)
        {
            ID = id;
            var user = this.User.Identity;
            UserName = user.Name;
        }
    }
}
