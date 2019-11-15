using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace website.Pages
{
    public class IndexModel : PageModel
    {
        private int randomnum1;

        [BindProperty] public int randomnum { get => randomnum1; set => randomnum1 = value; }
        public void OnGet()
        {
            Random eple = new Random();
            randomnum = eple.Next(32, 87);
        }
    }
}
