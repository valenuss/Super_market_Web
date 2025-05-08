using System.ComponentModel.DataAnnotations;

namespace Super_Market_web.Models
{
    public class Provider
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string ContactEmail { get; set; }
    }
}