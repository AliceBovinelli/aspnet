using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace WebApplication1.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Cognome { get; set; }
        public string? Email { get; set; }
        [Required]
        public Sesso Sesso { get; set; }
        [Range(0,150)]
        public int? Età { get; set; }
    }
}
