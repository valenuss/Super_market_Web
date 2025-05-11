using System.ComponentModel.DataAnnotations.Schema;

namespace Super_Market_web.Models
{
    public class Product
    {
        public int Id { get; set; } //sera la llave primaria

        public string Name { get; set; }

        [Column(TypeName = "decimal(18,2)")]

        public decimal Price { get; set; }

        public int stock { get; set; }

        public int CategoryId { get; set; } //sera la llave foranea

    }
}
