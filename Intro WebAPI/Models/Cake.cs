using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Intro_WebAPI.Models
{
    public class Cake
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [StringLength(100, MinimumLength = 10, ErrorMessage = "Ingredients must contain at least 10 characters!")]
        public string Ingredients { get; set; }
        public string Inventor { get; set; }
        public double Calories { get; set; }
    }
}
