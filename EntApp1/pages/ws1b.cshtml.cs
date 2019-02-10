using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EntApp1.pages
{
    public class ws1bModel : PageModel
    {
        public int Number1 { get; set; }
        public int Number2 { get; set; }
        public string Message { get; set; }

        public void OnGet()
        {
            


        }

        public void OnPost(int number1, int number2)
        {
            int added = number1 + number2;
            int subtracted = number1 - number2;
            int multiplied = number1 * number2;
            int divided = number1 / number2;

            if (Request.Form["action"] == "add")
                Message = string.Format($"The sum of {number1} and {number2} is {added}");
            if (Request.Form["action"] == "subtract")
                Message = string.Format($"{number1} minus {number2} is {subtracted}");
            if (Request.Form["action"] == "multiply")
                Message = string.Format($"{number1} multiplied by {number2} is {multiplied}");
            if (Request.Form["action"] == "divide")
                Message = string.Format($"{number1} divided by {number2} is {divided}");
        }
    }
}