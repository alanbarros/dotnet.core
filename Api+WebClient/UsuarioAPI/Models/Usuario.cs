using System.ComponentModel.DataAnnotations;

namespace UsuarioAPI.Models
{
    public class Usuario
    {
        [Key]
        public long Id { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Username { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public override string ToString() {
            return string.Format($"{Username} - {Password}");
        }
    }
}