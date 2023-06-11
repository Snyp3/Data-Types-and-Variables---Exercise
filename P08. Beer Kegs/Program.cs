namespace P08._Beer_Kegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countKegs = int.Parse(Console.ReadLine());
            double biggestKeg = 0;
            string biggestModel = string.Empty;

            for (int i = 0; i < countKegs; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double volume = Math.PI * Math.Pow(radius, 2) * height;

                if (volume >  biggestKeg)
                {
                    biggestKeg = volume;
                    biggestModel = model;
                }
                
            }

            Console.WriteLine(biggestModel);
        }
    }
}