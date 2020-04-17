using System;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int money;
            int bet;
            int choice;
            Console.Write("Введите ваш текущий капитал: ");
            money = int.Parse(Console.ReadLine());
            int i = 1;
            while ((i == 1) && (money > 0))
            {
                Console.Write("Введите вашу ставку: ");
                bet = int.Parse(Console.ReadLine());
                if (bet > money) throw new Exception("Неверное значение");
                Console.Write("Введите, на что вы ставите: 0 - чет, 1 - нечет: ");
                choice = int.Parse(Console.ReadLine());
                Random rand = new Random();
                int game = rand.Next(0, 1000);
                game = game % 2;
                if (game == choice)
                {
                    Console.WriteLine("Поздравляем! Вы выиграли!");
                    money = money + bet;
                }
                else
                {
                    Console.WriteLine("К сожалению, не в этот раз(((");
                    money = money - bet;
                }
                if (money > 0)
                {
                    Console.WriteLine("Желаете продолжить игру? Да - 1, нет – 0: ");
                    i = int.Parse(Console.ReadLine());
                }
                else break;
            }
        }
    }
}
