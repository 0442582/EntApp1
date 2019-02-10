using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EntApp1.pages
{
    public class greetingModel : PageModel
    {
        public string Message { get; set; } = "Hello";

        public void OnGet()
        {
            if (DateTime.Now.Hour >= 12)
            {
                Message = "Good Afternoon";
            }
            else
            {
                Message = "Good Morning";
            }
        }
    }
}