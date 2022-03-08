using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace JQuerySinglePageCrud.Models
{
    public class User
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        [MinLength(5)]
        [MaxLength(10)]
        public string Username { get; set; }

        public bool Active { get; set; }

        public string Location { get; set; }

        public string Phone { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public string Password { get; set; }

        public string PasswordSalt { get; set; }

    }
}
