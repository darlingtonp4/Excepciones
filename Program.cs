Operaciones operaciones = new Operaciones();
int opcion = 0;

do
{
    Console.WriteLine("");
    Console.WriteLine("*** Menú de Operaciones ***");
    Console.WriteLine("1. Sumar");
    Console.WriteLine("2. Restar");
    Console.WriteLine("3. Multiplicar");
    Console.WriteLine("4. Dividir");
    Console.WriteLine("5. Salir");
    Console.WriteLine("Seleccione una opción: ");

    try
    {
        opcion = int.Parse(Console.ReadLine());

        if (opcion >= 1 && opcion <= 4)
        {
            double num1, num2;

            Console.WriteLine("Ingrese el primer número: ");
            num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo número: ");
            num2 = double.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.WriteLine($"Resultado de la suma: {operaciones.Sumar(num1, num2)}");
                    break;
                case 2:
                    Console.WriteLine($"Resultado de la resta: {operaciones.Restar(num1, num2)}");
                    break;
                case 3:
                    Console.WriteLine($"Resultado multiplicar: {operaciones.Multiplicar(num1, num2)}");
                    break;
                case 4:
                    if (operaciones.Dividir(num1, num2) == 0)
                    {
                        Console.WriteLine("No se puede dividir por 0");
                    }
                    else
                        Console.WriteLine($"Resultado de la división: {operaciones.Dividir(num1, num2)}");

                    break;
            }
        }
        else if (opcion == 5)
        {
            Console.WriteLine("El proxgrama ha sido finalizado");
            break;
        }
        else
        {
            Console.WriteLine("Opción inválida. Ingrese un nuevo numero.");
        }
    }
    catch (FormatException)
    {
        Console.WriteLine("Entrada inválida. Por favor, ingrese un número válido.");
    }

    Console.WriteLine();
} while (true);
