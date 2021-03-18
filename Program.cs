using System;

namespace SF4._5
{
    class Program
    {
        static void Main(string[] args)
        {
            (string Name, string LastName, string Login, int LoginLength, bool HasPet, string[] favcolors, double Age) User;
            string Animal;

            for (int k = 0; k <= 2; k++)
            {
                Console.WriteLine("Введите имя");
                User.Name = Console.ReadLine();

                Console.WriteLine("Введите фамилию");
                User.LastName = Console.ReadLine();

                Console.WriteLine("Введите логин");
                User.Login = Console.ReadLine();

                User.LoginLength = User.Login.Length;

                Console.WriteLine("Есть ли у вас животные? Да или Нет");
                Animal = Console.ReadLine();
                User.HasPet = (Animal == "Да");

                Console.WriteLine("Введите возраст пользователя");
                User.Age = double.Parse(Console.ReadLine());

                User.favcolors = new string[3];
                Console.WriteLine("Введите три любимых цвета пользователя");

                for (int i = 0; i <= 2; i++)
                {
                    Console.WriteLine("Введите цвет номер {0}", i);
                    User.favcolors[i] = Console.ReadLine();
                }

                Console.WriteLine("Пользователь: имя - {0}, фамилия - {1}, логин - {2}, длина логина - {3}, имеет пета? - {4}, любимые цвета - {5}, {6}, {7}, возраст - {8}.", User.Name, User.LastName, User.Login, User.LoginLength, User.HasPet, User.favcolors[0], User.favcolors[1], User.favcolors[2], User.Age);

                Console.WriteLine("");
            }
        }
    }
}
