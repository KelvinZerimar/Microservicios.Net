using System.ComponentModel.DataAnnotations;

namespace PlatformsService.Dtos
{   
    public class PlatformCreateDto{
        [Required]
        public string? name { get; set; }

        [Required]
        public string? Publisher { get; set; }

        [Required]
        public string? Cost { get; set; }
    }
}