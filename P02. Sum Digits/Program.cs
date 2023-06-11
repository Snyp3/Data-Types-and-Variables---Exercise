namespace P02._Sum_Digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int sumOfDigits = 0;
            int leftNumber = 0;

            while (number > 0)
            {
                leftNumber = number % 10;
                sumOfDigits += leftNumber;
                number = number / 10;

            }
            
            Console.WriteLine(sumOfDigits);
        }
    }
}