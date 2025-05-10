namespace Super_Market_web.Models
{
    public class Category
    {
        public int Id { get; set; } //sera la llave primaria

        public string Name { get; set; }

        public string? Description { get; set; }

        public Icollection<Product> Products { get; set; } //propiedad de navegacion
    }
}
