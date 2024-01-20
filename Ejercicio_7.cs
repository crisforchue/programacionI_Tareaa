using System;

class Programa7
{
    public static void MainPrograma7()
    {
        int numeroMayor = int.MinValue;
        int numero;

        for (int i = 0; i < 3; i++)
        {
            Console.Write($"Ingresa el numero {i + 1}: ");
            string entrada = Console.ReadLine();

            if (int.TryParse(entrada, out numero))
            {
                if (numero > numeroMayor)
                {
                    numeroMayor = numero;
                }
            }
            else
            {
                Console.WriteLine("El valor ingresado no es un numero entero.");
                return;
            }
        }

        Console.WriteLine($"El numero mayor es {numeroMayor}.");
    }
}
