using System;

namespace Game
{
    class Program
    {
        public
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake and Ladder");
            int pos = 0;
            int position;
            Console.WriteLine("Player position is " + pos);

            for ( pos = 0; pos < 100;)
            {
                Random random = new Random();
                int value = random.Next(1, 7);
                position = value + pos;
                Console.WriteLine(" After the Dice roll, The position is " + position);
                if((position==19)) //ladder for 19 to 48
                {
                    position = 48;
                    Console.WriteLine("You got a ladder and now you are jumped to 48");
                }
                if ((pos==63)) //ladder for 63 to 86
                    {
                    position = 86;
                    Console.WriteLine("You got a ladder and now you are jumped to 86");
                }
                if ((pos == 29)) //ladder for 29 to 92
                {
                    position = 92;
                    Console.WriteLine("You got a ladder and now you are jumped to 92");
                }
                if ((pos == 79)) //snake for 79 to 22
                        {
                    position = 22;
                    Console.WriteLine("You got a snake bite and now you are moved to 22");
                }
                pos = position;
                if(pos>100)
                {
                    pos = 100;
                }

            }
            Console.WriteLine("The player Won the game");
        }
    }
}