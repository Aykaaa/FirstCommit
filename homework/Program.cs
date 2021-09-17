using System;

namespace homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 2.1");
            Console.Write("Как Вас зовут?");
            string name = Console.ReadLine();
            Console.WriteLine("Здравствуйте, " + name + "!");

            Console.WriteLine("Упражнение 2.2");
            try
            {
                int num_1, num_2;
                Console.Write("Введите целое число: ");
                num_1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите еще одно целое число: ");
                num_2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(num_1 / num_2);
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("Домашнее задание 2.1");
            Console.Write("Введите букву: ");
            char letter = Convert.ToChar(Console.ReadLine());
            char nextChar = (char)(((int)letter) + 1);
            Console.WriteLine("Следующая буква: " + nextChar);






        }
    }
}
