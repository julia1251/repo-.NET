using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FizzBuzz.Models;
using Microsoft.EntityFrameworkCore;


namespace FizzBuzz.Pages.Data
{
    public class WyszukanieContext : DbContext
    {
        public WyszukanieContext(DbContextOptions options) : base(options) { }
        public DbSet<Liczba> Liczby { get; set; }
    }
}
