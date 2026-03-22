
using System;
using System.Collections.Generic;
using System.Linq;

public class Clinic
{
    private List<Patient> patients = new List<Patient>();
    private int nextId = 1;

    public void AddPatient()
    {
        Console.WriteLine("Registro de nuevo paciente");

        Console.Write("Nombre: ");
        string name = Console.ReadLine();

        Console.Write("Edad: ");
        int age = int.Parse(Console.ReadLine());

        Console.Write("Enfermedad: ");
        string disease = Console.ReadLine();

        Console.Write("Teléfono: ");
        string phone = Console.ReadLine();

        Patient paciente = new Patient(nextId, name, age, disease, phone);
        patients.Add(paciente);
        nextId++;

        //Console.Clear();
    }


    public void ViewPatients()
    {
        Console.WriteLine("\nID | Nombre | Edad | Enfermedad | Teléfono");

        foreach (var View in patients)
        {
            Console.WriteLine($"{View.Id} | {View.Name} | {View.Age} | {View.Disease} | {View.Phone}");
        }

    }

    public Patient FindById(int id)
    {
        return patients.FirstOrDefault(paciente => paciente.Id == id);
    }


    public void SearchPatient()
    {
        Console.Write("Digite ID: ");

        if (!int.TryParse(Console.ReadLine(), out int id))
        {
            Console.WriteLine("Entrada inválida");
            return;
        }

        var paciente = FindById(id);

        if (paciente != null)
        {
            Console.WriteLine($"Nombre: {paciente.Name}");
            Console.WriteLine($"Edad: {paciente.Age}");
            Console.WriteLine($"Enfermedad: {paciente.Disease}");
            Console.WriteLine($"Teléfono: {paciente.Phone}");
        }
        else
        {
            Console.WriteLine("El paciente no encontrado");
        }

        Console.Clear();
    }

    public void EditPatient()
    {
        ViewPatients();

        Console.Write("Digite ID a editar: ");

        if (!int.TryParse(Console.ReadLine(), out int id))
        {
            Console.WriteLine("Entrada inválida");
            return;
        }



        var EditPacient = FindById(id);

        if (EditPacient != null)
        {
            Console.Write("Nuevo nombre: ");
            EditPacient.Name = Console.ReadLine();

            Console.Write("Nueva edad: ");
            EditPacient.Age = int.Parse(Console.ReadLine());

            Console.Write("Nueva enfermedad: ");
            EditPacient.Disease = Console.ReadLine();

            Console.Write("Nuevo teléfono: ");
            EditPacient.Phone = Console.ReadLine();

            Console.WriteLine("Paciente editado correctamente");
        }
        else
        {
            Console.WriteLine("Paciente no encontrado");
        }



        Console.Clear();
    }


    public void DeletePatient()
    {
        ViewPatients();

        Console.Write("Digite ID a eliminar: ");

        if (!int.TryParse(Console.ReadLine(), out int id))
        {
            Console.WriteLine("Entrada inválida");
            return;
        }

        // validando Confirmación de eliminación
        var p2 = FindById(id);

        if (p2 != null)
        {
            Console.Write("Seguro? 1=Sí / 2=No: ");

            if (int.TryParse(Console.ReadLine(), out int op) && op == 1)
            {
                patients.Remove(p2);
                Console.WriteLine("Paciente eliminado");
                Console.Write("Precione cualquier tecla para continuar");

                Console.ReadKey();
                Console.Clear();
            }
        }
        else
        {
            Console.WriteLine("Paciente no encontrado");
            Console.ReadKey();
            Console.Clear();
        }
    }

    public void Exit()
    {
        Console.WriteLine("Favor de seleccionar 1 para confirmar o  caulquier tecla para cancelar ?");

        if(int.TryParse(Console.ReadLine(), out int op) && op == 1)
        {
            Console.WriteLine("Gracias por usar el sistema de registro, hasta luego!");
            Environment.Exit(0);
        }

        else
        {
            Console.WriteLine("Operación cancelada, regresando al menú...");
        }

        Console.ReadKey();
        Console.Clear();

    }

}