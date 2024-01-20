using System;

class Programa3
{
    public static void MainPrograma3()
    {
        Console.Write("(Tercer ejercicio) Ingresa un numero entero de dos digitos: ");
        string entrada = Console.ReadLine();
        int numero;

        if (int.TryParse(entrada, out numero) && numero >= 10 && numero <= 99)
        {
            int digito1 = numero / 10;
            int digito2 = numero % 10;

            bool EsPrimerDigitoPrimo = EsPrimo(digito1);
            bool EsSegDigitoPrimo = EsPrimo(digito2);

            Console.WriteLine($"El primer digito {(EsPrimerDigitoPrimo ? "es primo" : "no es primo")} y el segundo digito {(EsSegDigitoPrimo ? "es primo" : "no es primo")}.");
        }
        else
        {
            Console.WriteLine("El numero no es un numero entero de dos digitos.");
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
