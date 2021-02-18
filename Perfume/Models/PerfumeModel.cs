using System;
using System.ComponentModel.DataAnnotations;

namespace Perfume.Models
{
    public class PerfumeModel
    {

        [Key]
        public int Id { get; set; }

        [MaxLength(256,ErrorMessage ="Max 256 characters allowed!")]
        [Required]
        public string Name { get; set; }

        [MaxLength(256, ErrorMessage = "Max 256 characters allowed!")]
        [Required]
        public string Brand { get; set; }

        [MaxLength(256, ErrorMessage = "Max 256 characters allowed!")]
        public string Model { get; set; }

        [MaxLength(512,ErrorMessage ="Max 512 characters allowed!")]
        public string Description { get; set; }

        [Required(ErrorMessage ="This field required!")]
        public double Volume { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        [Required(ErrorMessage = "This field required!")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Currency required!")]
        public string Currency { get; set; }

        [Required]
        public DateTime Date { get; set; }

        public PerfumeModel()
        {
        }
    }
}
