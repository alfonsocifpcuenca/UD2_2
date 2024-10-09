namespace Ejercicios_UD2_2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrayNumbers = new int[5];
            arrayNumbers[0] = GetIntFromUser("Introduce el primer número: ");
            arrayNumbers[1] = GetIntFromUser("Introduce el segundo número: ");
            arrayNumbers[2] = GetIntFromUser("Introduce el tercer número: ");
            arrayNumbers[3] = GetIntFromUser("Introduce el cuarto número: ");
            arrayNumbers[4] = GetIntFromUser("Introduce el quinto número: ");


            int result = 0;
            for (int i = 0; i < arrayNumbers.Length; i++)
            {
                result += arrayNumbers[i];
            }

            Console.WriteLine($"El resultado de sumar todos los elementos es: {result}");
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