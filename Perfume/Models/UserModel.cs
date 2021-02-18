using System;
using System.ComponentModel.DataAnnotations;

namespace Perfume.Models
{
    public class UserModel
    {

        [Key]
        public int Id { get; set; }

        [MaxLength(64, ErrorMessage = "Max 64 characters allowed!")]
        [Required]
        public string Name { get; set; }

        [MaxLength(64, ErrorMessage = "Max 64 characters allowed!")]
        [Required]
        public string Surname { get; set; }

        [MaxLength(64, ErrorMessage = "Max 64 characters allowed!")]
        [Required]
        public string Email { get; set; }

        [Required]
        public DateTime Date { get; set; }

        public UserModel()
        {
        }
    }
}
