namespace Ejercicios_UD2_2_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduce una frase: ");
            string input = Console.ReadLine();

            Dictionary<char, int> charsCount = new Dictionary<char, int>();
            for (int i = 0; i < input.Length; i++)
            {
                if (charsCount.ContainsKey(input[i]))
                    charsCount[input[i]]++;
                else
                    charsCount[input[i]] = 1;
            }

            foreach  (KeyValuePair<char, int> charCount in charsCount)
            {
                Console.WriteLine($"{charCount.Key} => {charCount.Value}");
            }
        }
    }
}