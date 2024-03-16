using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderGame
{
    public class singlePlayerGame
    {
        public string name;
        public singlePlayerGame()
        {
            Console.WriteLine("Enter the name\n ");
            string name = Console.ReadLine();
            this.name = name;



        }

        public void playingTheGame()
        {
            // roll the dice and it will give the value between 1 - 6
            Random r = new Random();
            int roll = r.Next(1, 7);

            int position = 0;
            int positionStatus = 0;
            int numberOfTimesDieRolled = 0;
            Boolean gameStatus = true;
            while (gameStatus)
            {


                position = position + roll;
                // it will call the function to decide noplay, snale , ladder 
                if (!(position >= 94))
                {
                    position = decidingtheStatus(position);

                }
                //it will ensure that player win only when position is 100
                if (position == 100)
                {
                    Console.WriteLine($"{this.name}  win the game ");
                    gameStatus = false;
                    break;
                }
                // this will ensure that position will not go above 100
                if (position > 100)
                {
                    position = position - roll;
                }
                // this will count the number of times dice is rolled 
                numberOfTimesDieRolled++;
                Console.WriteLine($"the position of {this.name} is {position}");
            }
            Console.WriteLine($"the number of time die rolled is {numberOfTimesDieRolled}");
        }
        public int decidingtheStatus(int position)
        {

            Random r = new Random();
            int status = r.Next(0, 3);
            int change = 0;
            if (status == 0)
            {
                return position - change;
            }
            else if (status == 1)
            {
                if (position <= 95)
                {
                    return position - snakeLength();
                }

                else
                {
                    return position;
                }
            }
            else
            {
                if (position <= 64)
                {

                    return position + ladderLength();


                }
                else return position;


            }
        }

        public int snakeLength()
        {
            Random r = new Random();
            return r.Next(0, 12);

        }

        public int ladderLength()
        {
            Random r = new Random();
            return r.Next(0, 13);
        }


    }

}
