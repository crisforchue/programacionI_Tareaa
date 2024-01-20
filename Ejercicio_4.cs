using System;

class Programa4
{
    public static void MainPrograma4()
    {
        Console.Write("(Cuarto ejercicio) Ingresa el primer numero entero de dos digitos: ");
        string entrada1 = Console.ReadLine();
        Console.Write("Ingresa el segundo numero entero de dos digitos: ");
        string entrada2 = Console.ReadLine();

        int numero1, numero2;

        if (int.TryParse(entrada1, out numero1) && numero1 >= 10 && numero1 <= 99 &&
            int.TryParse(entrada2, out numero2) && numero2 >= 10 && numero2 <= 99)
        {
            int suma = numero1 + numero2;
            bool esPar = suma % 2 == 0;

            Console.WriteLine($"La suma de {numero1} y {numero2} es {suma}, que {(esPar ? "es par" : "no es par")}.");
        }
        else
        {
            Console.WriteLine("Uno o ambos numeros ingresados no son numeros enteros de dos digitos.");
        }
    }
}
