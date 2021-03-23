using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FizzBuzz.Models
{
    public class Liczba
    {
        [Range(1,1000)]
        public int liczba { get; set; }
        
    }
}