namespace TheGreatLogbook.Entities
{
    public class Book : BaseEntity
    {
        public string Title { get; set; }
        public string Genero { get; set; }
        public decimal Price { get; set; }

        // Constructor vacío
        public Book() { }

        // Constructor con parámetros
        public Book(int id, string title, string Genero, decimal price)
        {
            Id = id;
            Title = title;
            this.Genero = Genero;
            Price = price;
        }

        public override string GetInfo()
        {
            return $"{Id} | {Title} | {Genero} | {Price}";
        }
    }
}