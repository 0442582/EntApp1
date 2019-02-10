﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EntApp1.pages
{
    public class ws1Model : PageModel
    {
        public string[] MyTestArray { get; set; }
         = { "England", "Ireland", "Scotland", "Wales" };


        public string Message { get; set; }

        [BindProperty]
        public string firstname { get; set; }


        public void OnPost()
        {
            Message =
                String.Format("Hello {0}", firstname);
        }
    }
}