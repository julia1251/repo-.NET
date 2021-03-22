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
        public int Wynik(Liczba)
        {
                if (liczba % 3 == 0 && liczba % 5 == 0)
                {
                    Console.WriteLine("fizzbuzz");
                }
                else if (liczba % 3 == 0)
                {
                    Console.WriteLine("fizz");
                }
                else if (liczba % 5 == 0)
                {
                    Console.WriteLine("buzz");
                }
                else
                {
                    Console.WriteLine(liczba);
                }
        }
        public void OnGet()
        {
            if (string.IsNullOrWhiteSpace(Name))
            {
                Name = "User";
            }
            
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
