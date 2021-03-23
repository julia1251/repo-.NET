using FizzBuzz.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace FizzBuzz.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        [BindProperty]

        public Liczba Liczba { get; set; }

        [BindProperty(SupportsGet = true)]


        public string Name { get; set; }
        

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
        public int liczba;
        public int Wynik()
        {
            string result = "";
                if (liczba % 3 == 0)
                {
                    result+="fizz";
                }
                if (liczba % 5 == 0)
                {
                    result+="buzz";
                }
                if(!(liczba % 3 == 0) && !(liczba % 5 == 0))
                {
                result = Convert.ToString(liczba);
                }
            return Convert.ToInt32(result);
        }
        public string wynik;
        public void OnGet()
        {
            if (string.IsNullOrWhiteSpace(Name))
            {
                Name = "User";
            }
            wynik = Convert.ToString(Wynik());
            HttpContext.Session.SetString("Wynik",JsonConvert.SerializeObject(wynik));
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                HttpContext.Session.SetString("SessionLiczba", JsonConvert.SerializeObject(Liczba));
                return RedirectToPage("./Ostatnio Szukane");
            }
            return Page();
        }

    }
}
