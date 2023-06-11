namespace P09._Spice_Must_Flow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());
            int countDays = 0;
            int storageYield = 0;

            while (startingYield >= 100)
            {
               
                countDays++;
                storageYield += startingYield;
                storageYield -= 26;
                startingYield -= 10;
            }
            if (startingYield < 100 && storageYield > 26)
            {
                
                storageYield -= 26;
            }
            Console.WriteLine(countDays);
            Console.WriteLine(storageYield);

        }
    }
}