using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FizzBuzz.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace FizzBuzz.Pages.Data
{
    public class WyszukanieContext : IdentityDbContext<IdentityUser>
    {
        public WyszukanieContext(DbContextOptions options) : base(options) { }
        public DbSet<Liczba> Liczby { get; set; }
    }
}
