namespace Ejercicios_UD2_2_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numberList = new List<int>();

            for (int i = 1; i <= 10; i++)
            {
                numberList.Add(GetIntFromUser($"Introduce el nº {(i)}: "));
            }

            int max = numberList.Max();
            int min = numberList.Min();

            Console.WriteLine($"De los números introducidos el mayor es {max} y el meno {min}");
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