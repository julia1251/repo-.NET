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
    public class OstatnieModel : PageModel
    {
        private readonly ILogger<OstatnieModel> _logger;
        private readonly WyszukanieContext _context;

        public OstatnieModel(ILogger<OstatnieModel> logger, WyszukanieContext context)
        {
            _logger = logger;
            _context = context;
        }
        public IList<Liczba> Liczby { get; set; }

        public void OnGet()
        {
            Liczby = _context.Liczby.OrderByDescending(m => m.DataWyszukania).Take(10).ToList();
        }

    }
}
