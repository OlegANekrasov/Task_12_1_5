using System;
using System.Threading;

namespace Task_12_1_5
{
    class Program
    {
        static void Main(string[] args)
        {
            User[] users = new User[]
            {
                new User() {Login = "Oleg", Name = "Олег", IsPremium = false},
                new User() {Login = "Ivan", Name = "Иван", IsPremium = true},
                new User() {Login = "Petr", Name = "Петр", IsPremium = true}
            };

            foreach (var user in users)
            {
                Console.WriteLine($"Здравствуйте, {user.Name}!");
                if(!user.IsPremium)
                {
                    ShowAds();
                }
            }
            
            Console.ReadKey();
        }

        static void ShowAds()
        {
            Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
            // Остановка на 1 с
            Thread.Sleep(1000);

            Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
            // Остановка на 2 с
            Thread.Sleep(2000);

            Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
            // Остановка на 3 с
            Thread.Sleep(3000);
        }
    }
}
