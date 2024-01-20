using System;

class Programa9
{
    public static void MainPrograma9()
    {
        Console.Write("Ingresw un numero entero de cuatro digitos: ");
        string entrada = Console.ReadLine();
        int numero;

        if (int.TryParse(entrada, out numero) && numero >= 1000 && numero <= 9999)
        {
            int segundoDigito = (numero / 100) % 10;
            int penultimoDigito = (numero / 10) % 10;

            if (segundoDigito == penultimoDigito)
            {
                Console.WriteLine("El segundo digito y el penultimo digito del numero son iguales");
            }
            else
            {
                Console.WriteLine("El segundo digito y el penultimo digito  no son iguales.");
            }
        }
        else
        {
            Console.WriteLine("El numero  no es un numero entero de cuatro digitos.");
        }
    }
}
