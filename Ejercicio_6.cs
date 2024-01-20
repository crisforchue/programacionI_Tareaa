using System;

class Programa6
{
    public static void MainPrograma6()
    {
        Console.Write("Ingresa un numero entero de tres digitos: ");
        string entrada = Console.ReadLine();
        int numero;

        if (int.TryParse(entrada, out numero) && numero >= 100 && numero <= 999)
        {
            int primerDigito = numero / 100;
            int segundoDigito = (numero / 10) % 10;
            int tercerDigito = numero % 10;

            bool esMultiplo = EsMultiplo(primerDigito, segundoDigito, tercerDigito);

            Console.WriteLine($"El numero {numero} {(esMultiplo ? "tiene" : "no tiene")} un digito que es multiplo de los otros.");
        }
        else
        {
            Console.WriteLine("El numero ingresado no es un numero entero de tres digitos.");
        }
    }

    static bool EsMultiplo(int a, int b, int c)
    {
        return (a != 0 && b % a == 0) || (a != 0 && c % a == 0) ||
               (b != 0 && a % b == 0) || (b != 0 && c % b == 0) ||
               (c != 0 && a % c == 0) || (c != 0 && b % c == 0);
    }
}
