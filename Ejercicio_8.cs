using System;

class Programa8
{
    public static void MainPrograma8()
    {
        Console.Write("Ingrese un numero entero de cinco digitos: ");
        string entrada = Console.ReadLine();
        int numero;

        if (int.TryParse(entrada, out numero) && numero >= 10000 && numero <= 99999)
        {
            string numeroComoCadena = numero.ToString();
            string numeroReverso = new string(numeroComoCadena.ToCharArray().Reverse().ToArray());

            if (numeroComoCadena == numeroReverso)
            {
                Console.WriteLine($"El numero {numero} es capicua.");
            }
            else
            {
                Console.WriteLine($"El numero {numero} no es capicua.");
            }
        }
        else
        {
            Console.WriteLine("El numero no es un numero entero de cinco digitos.");
        }
    }
}
