using System;

class Programa10
{
    public static void MainPrograma10()
    {
        Console.Write("Ingresa el primer numero: ");
        string entrada1 = Console.ReadLine();
        Console.Write("Ingresa el segundo numero: ");
        string entrada2 = Console.ReadLine();

        int numero1, numero2;

        if (int.TryParse(entrada1, out numero1) && int.TryParse(entrada2, out numero2))
        {
            if (Math.Abs(numero1 - numero2) <= 10)
            {
                int menor = Math.Min(numero1, numero2);
                int mayor = Math.Max(numero1, numero2);

                Console.WriteLine($"Los numeros enteros entre {menor} y {mayor} son:");

                for (int i = menor; i <= mayor; i++)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                Console.WriteLine("La diferencia entre los dos numeros es mayor");
            }
        }
        else
        {
            Console.WriteLine("Uno o ambos valores no son numeros enteros.");
        }
    }
}
