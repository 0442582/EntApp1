using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EntApp1.pages
{
    public class taghelpplayModel : PageModel
    {
        [BindProperty]

        public int Number1 { get; set; }

        public int? Number2 { get; set; }

        public double Number3 { get; set; }

        public double? Number4 { get; set; }

        public decimal Number5 { get; set; }

        public decimal? Number6 { get; set; }

        public float Number7 { get; set; }

        public float? Number8 { get; set; }

        public string Name { get; set; }

        public DateTime timeofday { get; set; }

        public DateTime? timeofday1 { get; set; }

        public bool IsContactAllowed { get; set; }

        [BindProperty]
        public string Season { get; set; }

        public string Message { get; set; }

        public void OnGet()
        {

        }

        public void OnPost()
        {
            if (Request.Form["Season"] == "Spring")
                Message = string.Format("You have picked Spring");
            if (Request.Form["Season"] == "Summer")
                Message = string.Format("You have picked Summer");
            if (Request.Form["Season"] == "Autumn")
                Message = string.Format($"You have picked Autumn");
            if (Request.Form["Season"] == "Winter")
                Message = string.Format($"You have picked Winter");
        }









       
    }
}