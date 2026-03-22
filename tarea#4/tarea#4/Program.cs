using tarea_4;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Mi Agenda Perrón");
        Console.WriteLine("Bienvenido a tu lista de contactes");

        Agenda AddressBook = new Agenda();

        bool running = true;

        while (running)
        {
            Console.Write("1. Agregar Contacto      ");
            Console.Write("2. Ver Contactos     ");
            Console.Write("3. Buscar Contactos      ");
            Console.Write("4. Modificar Contacto        ");
            Console.Write("5. Eliminar Contacto     ");
            Console.WriteLine("6. Salir");

            Console.Write("Elige una opción: ");

            if (!int.TryParse(Console.ReadLine(), out int choice))
            {
                Console.WriteLine("Opción inválida");
                continue;
            }

            switch (choice)
            {
                case 1:
                    AddressBook.AddContact();
                    break;
                case 2:
                    AddressBook.ViewContacts();
                    break;
                case 3:
                    AddressBook.SearchContact();
                    break;
                case 4:
                    AddressBook.EditContact();
                    break;
                case 5:
                    AddressBook.DeleteContact();
                    break;
                case 6:
                    running = false;
                    break;
                default:
                    Console.WriteLine("Opción no válida");
                    break;
            }
        }
    }
}