using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestVocalcom.Models
{
    public class User
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public Sexe Sexe { get; set; }
    }
    public enum Sexe
    {
        male,
        female
    }
}
