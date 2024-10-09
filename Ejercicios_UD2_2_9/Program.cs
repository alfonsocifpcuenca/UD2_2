namespace Ejercicios_UD2_2_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduce una frase: ");
            string input = Console.ReadLine();

            Console.Write("Palabra que deseas sustituir: ");
            string inputToReplace = Console.ReadLine();

            Console.Write("Palabra por la que deseas sustituir: ");
            string inputForReplace = Console.ReadLine();

            string[] palabras = input.Split(" ");

            for(int i = 0; i < palabras.Length; i++)
            {
                if (palabras[i] == inputToReplace)
                    palabras[i] = inputForReplace;
            }

            string result = string.Join(" ", palabras);

            Console.Write($"{result}");
        }
    }
}