namespace P04._Sum_of_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numChars = int.Parse(Console.ReadLine());
            int sumChars = 0;
            

            for (int i = 1; i <= numChars; i++)
            {
                char letters = char.Parse(Console.ReadLine());
                sumChars += (int)letters;            
            }
            
            Console.WriteLine($"The sum equals: {sumChars}");
        }
    }
}