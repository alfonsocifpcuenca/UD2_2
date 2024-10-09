namespace Ejercicios_UD2_2_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrayNumbers = new int[5];
            Console.WriteLine("Introduce los datos del primer array");
            for (int i = 0; i < arrayNumbers.Length; i++)
            {
                arrayNumbers[i] = GetIntFromUser($"Introduce el nº {(i + 1)}: ");
            }

            int[] arrayNumbersTwo = new int[5];
            Console.WriteLine("Introduce los datos del segundo array");
            for (int i = 0; i < arrayNumbersTwo.Length; i++)
            {
                arrayNumbersTwo[i] = GetIntFromUser($"Introduce el nº {(i + 1)}: ");
            }

            int[] arrayMerged = new int[10];
            arrayMerged = arrayNumbers.Concat(arrayNumbersTwo).ToArray();

            for (int i = 0; i < arrayMerged.Length; i++)
            {
                Console.WriteLine(arrayMerged[i]);
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