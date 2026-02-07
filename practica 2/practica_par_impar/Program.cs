    int typeNumber = 0;
        bool valido = false;

        while (!valido)
        {
            try
            {
                Console.Write("Ingrese un numero entero: ");
                typeNumber = Convert.ToInt32(Console.ReadLine()!);
                valido = true;
            }
            catch (Exception)
            {
                Console.WriteLine("Entrada de numero invalida:  favor de ingresarun numero entero");
            }
        }

        if (typeNumber % 2 == 0)
        {
            Console.WriteLine($"El numero {typeNumber} es PAR");
        }
        else
        {
            Console.WriteLine($"El numero {typeNumber} es IMPAR");
        }