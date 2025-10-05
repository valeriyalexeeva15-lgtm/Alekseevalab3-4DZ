namespace Alekseevalab3_4DZ
{
    internal class Program
    {
        enum TrafficLight { Red, Yellow, Green }
        static void Main(string[] args)
        {
            //lab3
            //1
            TrafficLight current = TrafficLight.Green;
            TrafficLight next = TrafficLight.Red;

            Console.WriteLine($"После {current} будет {next}");
        }
    }
}
