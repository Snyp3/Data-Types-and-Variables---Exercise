using System.Numerics;

namespace P11._Snowballs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int snowBallsMade = int.Parse(Console.ReadLine());
            BigInteger snowBallValue = 0;
            BigInteger bestSnowBallValue = 0;
            
            int bestSnowBallQuality = 0;
            int bestSnowBallSnow = 0;
            int bestSnowBallTime = 0;
            for (int i = 1; i <= snowBallsMade; i++)
            {
                int snowBallSnow = int.Parse(Console.ReadLine());
                int snowBallTime = int.Parse(Console.ReadLine());
                int snowBallQuality = int.Parse(Console.ReadLine());

                snowBallValue = BigInteger.Pow(snowBallSnow / snowBallTime, snowBallQuality);

                if (snowBallValue > bestSnowBallValue)
                {
                    bestSnowBallValue = snowBallValue;
                    bestSnowBallQuality = snowBallQuality;
                    bestSnowBallTime = snowBallTime;
                    bestSnowBallSnow = snowBallSnow;


                }
            }


            Console.WriteLine($"{bestSnowBallSnow} : {bestSnowBallTime} = {bestSnowBallValue} ({bestSnowBallQuality})");
        }
    }
}