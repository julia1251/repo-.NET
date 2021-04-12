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
using FizzBuzz.Pages.Data;

namespace FizzBuzz.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly WyszukanieContext _context;

        public IndexModel(ILogger<IndexModel> logger, WyszukanieContext context)
        {
            _logger = logger;
            _context = context;
        }

        [BindProperty]

        public Liczba Liczba { get; set; }


        public string Wynik(int liczba)
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
                if((liczba % 3 != 0) && (liczba % 5 != 0))
                {
                    result = Convert.ToString(liczba);
                }
            return result;
        }
        public string wynik;

        public void OnGet()
        {
            
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                HttpContext.Session.SetString("SessionLiczba", JsonConvert.SerializeObject(Liczba));
                wynik = Wynik(Liczba.liczba);
                HttpContext.Session.SetString("Wynik", wynik);
                HttpContext.Session.SetString("Data", DateTime.Now.ToString());
                Liczba.Wynik = wynik;
                Liczba.DataWyszukania = DateTime.Now;
                _context.Liczby.Add(Liczba);
                _context.SaveChanges();

            }

            return Page();
        }

    }
}
