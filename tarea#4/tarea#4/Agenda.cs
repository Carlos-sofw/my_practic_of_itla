using System;
using System.Collections.Generic;
using System.Text;
using static tarea_4.Contact;

namespace tarea_4
{

    public class Agenda
    {
        private List<Contact> contacts = new List<Contact>();
        private int nextId = 1;


        public void AddContact()
        {
            Console.WriteLine("Vamos a agregar ese contacte que te trae loco.");

            Console.Write("Digite el Nombre: ");
            string name = Console.ReadLine();

            Console.Write("Digite el Teléfono: ");
            string phone = Console.ReadLine();

            Console.Write("Digite el Email: ");
            string email = Console.ReadLine();

            Console.Write("Digite la dirección: ");
            string address = Console.ReadLine();

            Contact newContact = new Contact(nextId, name, phone, email, address);

            contacts.Add(newContact);
            nextId++;
        }


        public void ViewContacts()
        {
            Console.WriteLine("Id   Nombre   Telefono   Email   Dirección");

            foreach (var YourContact in contacts)
            {
                Console.WriteLine($"{YourContact.Id}   {YourContact.Name}   {YourContact.Phone}   {YourContact.Email}   {YourContact.Address}");
            }
        }


        private Contact FindById(int id)
        {
            return contacts.FirstOrDefault(c => c.Id == id);
        }


        public void SearchContact()
        {
            Console.WriteLine("Digite un Id de Contacto Para Mostrar");

            if (!int.TryParse(Console.ReadLine(), out int id))
            {
                Console.WriteLine("Entrada inválida");
                return;
            }

            var c = FindById(id);

            if (c != null)
            {
                Console.WriteLine($"Nombre: {c.Name}");
                Console.WriteLine($"Teléfono: {c.Phone}");
                Console.WriteLine($"Email: {c.Email}");
                Console.WriteLine($"Dirección: {c.Address}");
            }
            else
            {
                Console.WriteLine("No encontrado");
            }
        }


        public void EditContact()
        {
            ViewContacts();

            Console.WriteLine("Digite un Id de Contacto Para Editar");

            if (!int.TryParse(Console.ReadLine(), out int id))
            {
                Console.WriteLine("Entrada inválida");
                return;
            }

            var c = FindById(id);

            if (c != null)
            {
                Console.Write($"El nombre es: {c.Name}, Nuevo: ");
                c.Name = Console.ReadLine();

                Console.Write($"El teléfono es: {c.Phone}, Nuevo: ");
                c.Phone = Console.ReadLine();

                Console.Write($"El email es: {c.Email}, Nuevo: ");
                c.Email = Console.ReadLine();

                Console.Write($"La dirección es: {c.Address}, Nueva: ");
                c.Address = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("No encontrado");
            }
        }

        
        public void DeleteContact()
        {
            ViewContacts();

            Console.WriteLine("Digite un Id de Contacto Para Eliminar");

            if (!int.TryParse(Console.ReadLine(), out int id))
            {
                Console.WriteLine("Entrada inválida");
                return;
            }

            var c = FindById(id);

            if (c != null)
            {
                Console.WriteLine("Seguro que desea eliminar? 1. Si, 2. No");

                if (int.TryParse(Console.ReadLine(), out int op) && op == 1)
                {
                    contacts.Remove(c);
                    Console.WriteLine("Eliminado");
                }
            }
            else
            {
                Console.WriteLine("No encontrado");
            }
        }
    }
}

