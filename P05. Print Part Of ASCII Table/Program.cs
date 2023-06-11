namespace P05._Print_Part_Of_ASCII_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int last = int.Parse(Console.ReadLine());

            for (; first <= last; first++)
            {
                Console.Write($"{(char)first} ");
            }
        }
    }
}