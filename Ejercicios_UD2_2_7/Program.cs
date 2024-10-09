namespace Ejercicios_UD2_2_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] tablero = new int[5, 5];

            // Iniciamos el tablero a 0
            for (int i = 0; i < tablero.GetLength(0); i++)
            {
                for (int u = 0; u < tablero.GetLength(1); u++)
                {
                    tablero[i, u] = 0;
                }
            }

            PintarTablero(tablero);

            int coordX = GetIntFromUser("Introduce la coordenada X: ");
            int coordY = GetIntFromUser("Introduce la coordenada Y: ");

            tablero[coordY - 1, coordX - 1] = 1;
            
            PintarTablero(tablero);            
        }
        static int GetIntFromUser(string message)
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

        static void PintarTablero(int[,] tablero)
        {
            Console.WriteLine($"    1 2 3 4 5");
            Console.WriteLine($"    ---------");
            for (int i = 0; i < tablero.GetLength(0); i++)
            {
                Console.Write($"{i+1} | ");
                for (int u = 0; u < tablero.GetLength(1); u++)
                {
                    if (tablero[i,u] == 0)
                        Console.Write($"- ");
                    else
                        Console.Write($"x ");
                }
                Console.WriteLine();
            }
        }
    }
}