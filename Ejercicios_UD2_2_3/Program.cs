namespace Ejercicios_UD2_2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrayNumbers = new int[5];

            for (int i = 0; i < arrayNumbers.Length; i++)
            {
                arrayNumbers[i] = GetIntFromUser($"Introduce el nº {(i + 1)}: ");
            }

            for (int i = (arrayNumbers.Length - 1); i >= 0; i--)
            {
                Console.WriteLine($"{arrayNumbers[i]}");
            }
        }
        public static int GetIntFromUser(string message)
        {
            int number = 0;
            bool isValid = false;

            while (isValid == false)
            {
                Console.Write(message);
                string input = Console.ReadLine();

                if (int.TryParse(input, out number))
                {
                    isValid = true;
                }
                else
                {
                    Console.WriteLine("El valor introducido no es correcto.");
                }
            }

            return number;
        }
    }
}