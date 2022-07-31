using System;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake and Ladder");
            int pos = 0;
            Console.WriteLine("Player position is " + pos);


            Random random = new Random();
            int value = random.Next(1, 7);

            Console.WriteLine("The dice Value is " + value);
            pos = value;
            Console.WriteLine(" After the Dice roll, The position is " + pos);
        }
    }
}