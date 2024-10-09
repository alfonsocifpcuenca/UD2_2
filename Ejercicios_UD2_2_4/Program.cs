namespace Ejercicios_UD2_2_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduce una frase: ");
            string input = Console.ReadLine();

            string[] palabras = input.Split(" ");
            Console.Write($"La frase introducida tiene {palabras.Length} palabras.");
        }
    }
}