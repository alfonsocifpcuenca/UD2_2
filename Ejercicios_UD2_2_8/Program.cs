namespace Ejercicios_UD2_2_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrayNumbers = new int[5];
            Console.WriteLine("Introduce los datos del array");
            for (int i = 0; i < arrayNumbers.Length; i++)
            {
                arrayNumbers[i] = GetIntFromUser($"Introduce el nº {(i + 1)}: ");
            }

            int[] arrayFinal = new int[5];
            arrayFinal[0] = arrayNumbers[arrayNumbers.Length - 1];
            for (int i = 1; i <= arrayNumbers.Length - 1; i++)
            {
                arrayFinal[i] = arrayNumbers[i - 1];
            }

            for(int i = 0; i < arrayFinal.Length; i++)
            {
                Console.WriteLine(arrayFinal[i]);
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