using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using FizzBuzz.Models;
using Microsoft.Extensions.Logging;


namespace FizzBuzz.Pages
{
    public class LiczbaModel : PageModel
    {
        private readonly ILogger<LiczbaModel> _logger;

        public LiczbaModel(ILogger<LiczbaModel> logger)
        {
            _logger = logger;
        }
        public Liczba Liczba { get; set; }
        public string SessionLiczba { get; private set; }

        public void OnGet()
        {
            var SessionLiczba =
            HttpContext.Session.GetString("SessionLiczba");
            if (SessionLiczba != null)
                Liczba =
                JsonConvert.DeserializeObject<Liczba>(SessionLiczba);
        }
    }
}
