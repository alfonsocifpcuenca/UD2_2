namespace Ejercicios_UD2_2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrayNumbers = new int[10];

            for (int i = 0; i < arrayNumbers.Length; i++)
            {
                arrayNumbers[i] = GetIntFromUser($"Introduce el nº {(i + 1)}: ");
            }

            for (int i = 0; i < arrayNumbers.Length; i++)
            {
                if (arrayNumbers[i] % 2 == 0)
                    Console.WriteLine($"El número {arrayNumbers[i]} es par.");
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