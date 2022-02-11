using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Squad55.Models
{
    [Table("Usuarios")]
    public class Usuario
    {
        public int Id { get; set;}
        [Required]
        [MaxLength(100)]
        public string Nome { get; set; }
        [Required]
        [MaxLength(50)]
        public string Login { get; set; }
        [Required]
        public DateTime Nascimento { get; set; }
        [Required]
        [MaxLength(100)]
        public string Senha { get; set; }
    }
}