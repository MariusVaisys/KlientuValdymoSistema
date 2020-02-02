using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace KlientuValdymoSistema.Model
{
    public class Klientas
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Vardas { get; set; }

        [Required]
        [StringLength(50)]
        public string Pavarde { get; set; }

        
        [StringLength(50)]
        public string Email { get; set; }
    }
}
