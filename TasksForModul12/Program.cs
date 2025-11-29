using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TasksForModul12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Hello!\n Please enter your Login...");

            string login = Console.ReadLine(); 

            User user = GetUserByLogin(login);

            if (user != null)
            {
                Console.WriteLine($"Hello, {user.Name}");

                if (!user.IsPremium)
                {
                    Console.WriteLine("Unfortunately, you don't have premium subscription :( ");
                    ShowAds();
                }
                else
                {
                    Console.WriteLine("We glad to see you! There will be no ads here!");
                }
            }
            else
            {
                Console.WriteLine($"There is't user with this Login :( \n Please try again...");
            }
        }

        public class User
        {
            public string Login { get; set; }
            public string Name { get; set; }
            public bool IsPremium { get; set; }
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

        static User GetUserByLogin(string login)
        {
            var users = new List<User>()
            {
                new User { Login = "user1", Name = "Egor", IsPremium = true},
                new User { Login = "user2", Name = "Gleb", IsPremium = false},
                new User { Login = "admin", Name = "Administrator", IsPremium = true}
            };
            return users.Find(u => u.Login.ToLower() == login.ToLower());
        }


    }
}
