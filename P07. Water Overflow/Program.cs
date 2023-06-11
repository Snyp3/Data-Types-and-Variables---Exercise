namespace P07._Water_Overflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int addLittersTimes = int.Parse(Console.ReadLine());
            int totalLiters = 0;
            for (int i = 0; i < addLittersTimes; i++)
            {
                int addLiters = int.Parse(Console.ReadLine());
                totalLiters += addLiters;

                if (totalLiters > 255)
                {
                    Console.WriteLine("Insufficient capacity!");
                    totalLiters -= addLiters;
                    continue;
                }
            }
            Console.WriteLine(totalLiters);
        }
    }
}