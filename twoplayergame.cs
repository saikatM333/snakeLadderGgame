using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadderGame
{
    public  class twoplayergame
    {

        public string player1;
        public string player2;
        public twoplayergame()
        {
            Console.WriteLine("Enter the name of player \n ");
            string player1 = Console.ReadLine();
            this.player1 = player1;
            Console.WriteLine("Enter the name of second player \n ");
            string player2 = Console.ReadLine();
            this.player2 = player2;



        }

        public void playingTheGame()
        {
            // roll the dice and it will give the value between 1 - 6
            

            int position1 = 0;
            int positionStatus1 = 0;
            int numberOfTimesDieRolled1 = 0;
            int position2 = 0;
            int positionStatus2 = 0;
            int numberOfTimesDieRolled2 = 0;
            Boolean gameStatus = true;
            Random r = new Random();
            Random r1 = new Random();
            while (gameStatus)
            {
              
                int roll1 = r.Next(1, 7);
                int roll2 = r1.Next(1, 7);

                position1 = position1 + roll1;
                position2 = position2 + roll2;
                // it will call the function to decide noplay, snale , ladder 
                if (!(position1 >= 94))
                {
                    position1 = decidingtheStatus(position1);

                }
                if (!(position2 >= 94))
                {
                    position1 = decidingtheStatus(position2);

                }
                //it will ensure that player win only when position is 100
                if (position1 == 100 || position2==100)
                {
                    if (position1 == 100)
                    {
                        Console.WriteLine($"{player1}  win the game ");
                    }
                    if (position2 == 100)
                    {
                        Console.WriteLine($"{player2}  win the game ");
                    }
                    gameStatus = false;
                    break;
                }
                // this will ensure that position will not go above 100
                if (position1 > 100 || position2>100)
                {
                    position1 = position1 - roll1;
                    position2 = position2 - roll2;
                }
                // this will count the number of times dice is rolled 
                numberOfTimesDieRolled1++;
                numberOfTimesDieRolled2++;
                Console.WriteLine($"the position of {this.player1 } is {position1}");
                Console.WriteLine($"the position of {this.player2} is {position2}");

            }
            Console.WriteLine($"the number of time die rolled is {numberOfTimesDieRolled1}");
            Console.WriteLine($"the number of time die rolled is {numberOfTimesDieRolled2}");

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
