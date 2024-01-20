using System;

class Programa5
{
    public static void MainPrograma5()
    {
        Console.Write("Ingrese un numero entero de tres digitos: ");
        string entrada = Console.ReadLine();
        int numero;

        if (int.TryParse(entrada, out numero) && numero >= 100 && numero <= 999)
        {
            int primerDigito = numero / 100;
            int segundoDigito = (numero / 10) % 10;
            int tercerDigito = numero % 10;

            int mayorDigito = Math.Max(primerDigito, Math.Max(segundoDigito, tercerDigito));
            string posicion = "";

            if (mayorDigito == primerDigito)
            {
                posicion = "primera";
            }
            else if (mayorDigito == segundoDigito)
            {
                posicion = "segunda";
            }
            else
            {
                posicion = "tercera";
            }

            Console.WriteLine($"El digito mayor es {mayorDigito} en la {posicion} posicion.");
        }
        else
        {
            Console.WriteLine("El numero ingresado no es un numero entero de tres digitos.");
        }
    }
}
