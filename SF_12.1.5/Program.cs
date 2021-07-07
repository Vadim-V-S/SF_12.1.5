using System;
using System.Threading;

namespace SF_12._1._5
{
    class Program
    {

        static User user = new User();

        static void Main(string[] args)
        {
            user.PrintLogins();


            if (!user.IsSuscribePremium(user.InputLogin()))
            {
                ShowAds();
            }
            user.Greetings();


            Console.ReadKey();
        }

       
        static void ShowAds()
        {
            Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
            Thread.Sleep(1000);

            Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
            Thread.Sleep(2000);

            Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу");
            Thread.Sleep(3000);
        }
    }
}
