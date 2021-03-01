using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MyMeals.Models
{
    public class ContactRequest
    {
        public ulong Id { get; set; }

        [Required, StringLength(48)]
        public string Email { get; set; }

        [Required, StringLength(400)]
        public string Message { get; set; }

    }
}
