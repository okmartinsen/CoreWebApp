using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CoreWebApp.Pages
{
    public class AboutModel : PageModel
    {
        public string SiteInfo { get; set; }

        public void OnGet()
        {
            SiteInfo = "About this site";
        }


    }
}
