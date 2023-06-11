using System.Numerics;
using System.Runtime.CompilerServices;

namespace _10._Poke_Mon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pokePower = int.Parse(Console.ReadLine()); //  N
            int distansTarget = int.Parse(Console.ReadLine()); // M
            int exhaustionFactor = int.Parse(Console.ReadLine());// Y
            int countTargets = 0;
            double halfPokePower = pokePower * 0.5;

            while (pokePower >= distansTarget)
            {
                pokePower -= distansTarget;
                countTargets++;

                
                    if (pokePower == halfPokePower && exhaustionFactor != 0)
                    {

                        pokePower /= exhaustionFactor;
                        
                    }
                

            }
            Console.WriteLine(pokePower);
            Console.WriteLine(countTargets);
        }
    }
}