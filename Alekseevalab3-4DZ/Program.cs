namespace Alekseevalab3_4DZ
{
    internal class Program
    {
        //enum TrafficLight { Red, Yellow, Green }
        //enum OrderStatus { New, Processing, Shipped, Delivered }

        static void Main(string[] args)
        {
            //lab3
            //1
            //TrafficLight current = TrafficLight.Green;
            //TrafficLight next = TrafficLight.Red;

            //Console.WriteLine($"После {current} будет {next}");
            //2
            //CheckCancel(OrderStatus.New);
            //CheckCancel(OrderStatus.Processing);
            //CheckCancel(OrderStatus.Shipped);
            //CheckCancel(OrderStatus.Delivered);
            //3
            //for (int i = 10; i >= 1; i--)
            //    Console.WriteLine(i);
            //4
            //for (int i = 1; i <= 10; i++)
            //    Console.WriteLine($"5 * {i} = {5 * i}");
            //5
            //for (int i = 0; i < 10; i++)
            //    Console.WriteLine("Запомни: всего одна ошибка и ты ошибся.");
            //6
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i <= n; i++)
                Console.WriteLine($"Квадрат числа {i} равен {i * i}");

        }
        //static void CheckCancel(OrderStatus status)
        //{
        //    if (status == OrderStatus.New || status == OrderStatus.Processing)
        //        Console.WriteLine($"Заказ со статусом {status} можно отменить");
        //    else
        //        Console.WriteLine($"Заказ со статусом {status} нельзя отменить");
        //}

    }
}
