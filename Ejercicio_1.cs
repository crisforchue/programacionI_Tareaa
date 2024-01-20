using System;

class Programa1
{
    public static void MainPrograma1()
    {
        Console.Write("(primer ejercicio) Ingresa un numero entero de dos digitos: ");
        string entrada = Console.ReadLine();
        int numero;

        if (int.TryParse(entrada, out numero) && numero >= 10 && numero <= 99)
        {
            int PrimerDigito = numero / 10;
            int SegundoDigito = numero % 10;
            int suma = PrimerDigito + SegundoDigito;

            Console.WriteLine($"La suma de los digitos de {numero} es {suma}.");
        }
        else
        {
            Console.WriteLine("No es un numero entero de dos digitos.");
        }
    }
}
