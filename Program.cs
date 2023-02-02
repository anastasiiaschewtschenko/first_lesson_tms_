using System;

namespace MainClass
{
    class Program
    {
        static void Main()
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}, твой год рождения {1}", name, 2023 - age);

        }
    }
}
