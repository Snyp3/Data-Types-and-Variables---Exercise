namespace P03._Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());

            int capacityOfPeople = int.Parse(Console.ReadLine());

            int countCourses = 0;

            int courses =((int)Math.Ceiling ((double) numberOfPeople / capacityOfPeople));
            Console.WriteLine(courses);


        }
    }
}