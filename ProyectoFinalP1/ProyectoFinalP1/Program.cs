using TheGreatLogbook.BLL;
using TheGreatLogbook.Entities;

var bll = new BookBLL();

while (true)
{
    Console.Clear();
    Console.WriteLine("=== The Great Logbook ===");
    Console.WriteLine("1. Agregar Juego");
    Console.WriteLine("2. Lista de Juego");
    Console.WriteLine("3. Editar Juego");
    Console.WriteLine("4. Eliminar Juego");
    Console.WriteLine("5. Salir");

    Console.Write("Seleccione: ");
    int op = int.Parse(Console.ReadLine());

    switch (op)
    {
        case 1:
            Console.Write("Título: ");
            string title = Console.ReadLine();

            Console.Write("Genero: ");
            string author = Console.ReadLine();

            Console.Write("Precio: ");
            decimal price = decimal.Parse(Console.ReadLine());

            bll.AddBook(new Book { Title = title, Genero = author, Price = price });

            Console.WriteLine("Agregado!");
            Console.ReadKey();
            break;


        case 2:
            var books = bll.GetBooks();

            
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("TÍTULO".PadRight(20) + "GÉNERO".PadRight(20) + "PRECIO");
            Console.WriteLine(new string('-', 50));

            Console.ResetColor();

            
            foreach (var b in books)
            {
                Console.WriteLine(
                    b.Title.PadRight(20) +
                    b.Genero.PadRight(20) +
                    b.Price.ToString("0.00")
                );
            }

            Console.WriteLine("\nPresione cualquier tecla para continuar...");
            Console.ReadKey();
            break;

        case 3:
            Console.Write("ID a editar: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Nuevo título: ");
            string nt = Console.ReadLine();

            Console.Write("Nuevo Genero: ");
            string na = Console.ReadLine();

            Console.Write("Nuevo precio: ");
            decimal np = decimal.Parse(Console.ReadLine());

            bll.UpdateBook(new Book(id, nt, na, np));

            Console.WriteLine("Actualizado!");
            Console.Write("precione cualquier tecla para continuar..." );
            Console.ReadKey();
            break;

        case 4:
            Console.Write("ID a eliminar: ");
            int del = int.Parse(Console.ReadLine());

            bll.DeleteBook(del);

            Console.WriteLine("Eliminado!");
            Console.Write("precione cualquier tecla para continuar...");
            Console.ReadKey();
            break;

        case 5:
            return;
    }
}
