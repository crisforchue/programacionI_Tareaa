using System;

class Programa2
{
    public static void MainPrograma2()
    {
        Console.Write("(Segundo ejercicio) Ingresa un numero entero de dos digitos: ");
        string entrada = Console.ReadLine();
        int numero;

        if (int.TryParse(entrada, out numero) && numero >= -99 && numero <= 99)
        {
            bool EsNegativo = numero < 0;
            bool EsPrimo = EsPrimo(Math.Abs(numero));

            Console.WriteLine($"El numero {numero} es {(EsNegativo ? "negativo" : "positivo")} y {(EsPrimo ? "es primo" : "no es primo")}.");
        }
        else
        {
            Console.WriteLine("El numero ingresado no es un numero entero de dos digitos.");
        }
    }

    static bool EsPrimo(int numero)
    {
        if (numero < 2) return false;

        for (int i = 2; i * i <= numero; i++)
        {
            if (numero % i == 0) return false;
        }

        return true;
    }
}
