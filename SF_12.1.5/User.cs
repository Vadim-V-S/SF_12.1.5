using System;
using System.Collections.Generic;
using System.Text;

namespace SF_12._1._5
{
    class User
    {
        public string Login { get; set; }
        public string Name { get; set; }
        public bool IsPremium { get; set; }

        public User[] user;

        int index;

        public User[] UsersList()
        {
            user = new[]
            {
                new User{Login = "andrew", Name ="Андрей", IsPremium = false},
                new User{Login = "mike", Name= "Михаил", IsPremium = false},
                new User{Login = "john", Name="Иван",IsPremium = true}
            };

            return user;
        }

        public void PrintLogins()
        {
            Console.WriteLine("* Зарегистрированные пользователи: ");
            foreach (var log in UsersList())
                Console.WriteLine("логин: {0}/ подписка: {1}", log.Login, log.IsPremium);

        }


        public string InputLogin()
        {
            Console.Write("\n\nВведите логин:\t");
            return Console.ReadLine();
        }

        public bool IsSuscribePremium(string login)
        {
            index = 0;
            while (user[index].Login != login)
            {
                index++;
            }

            return user[index].IsPremium;
        }

        public void Greetings()
        {
            Console.WriteLine("\nДобро пожаловать {0}", user[index].Name);
        }
    }
}

