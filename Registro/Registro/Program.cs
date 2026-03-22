class Program
{
    static void Main(string[] args)
    {
        Clinic Clinic = new Clinic();
        bool running = true;

        while (running)
        {
            Console.WriteLine(" SISTEMA DE Registro  ");
            Console.WriteLine("1. Registrar Paciente ");
            Console.WriteLine("2. Ver Pacientes ");
            Console.WriteLine("3. Buscar Paciente ");
            Console.WriteLine("4. Editar Paciente ");
            Console.WriteLine("5. Eliminar Paciente ");
            Console.WriteLine("6. Salir");

            Console.Write("Opcion: ");

            if (!int.TryParse(Console.ReadLine(), out int opcion))
            {
                Console.WriteLine("Entrada inválida");
                continue;
            }

            switch (opcion)
            {
                case 1:
                    Clinic.AddPatient();
                    break;
                case 2:
                    Clinic.ViewPatients();
                    break;
                case 3:
                    Clinic.SearchPatient();
                    break;
                case 4:
                    Clinic.EditPatient();
                    break;
                case 5:
                    Clinic.DeletePatient();
                    break;
                case 6:
                    Clinic.Exit();
                    break;
                default:
                    Console.WriteLine("Eres tarad@ o te  haces. vez esa opcion en el menu...");
                    break;
            }
        }
    }
}