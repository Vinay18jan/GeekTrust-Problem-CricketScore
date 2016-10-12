using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeekTrust
{
    public class P
    {
        public string PlayerName { get; set; }
        public int PlayerScore { get; set; }
        public int PlayerFacedBalls { get; set; }
    }

    public class Class1
    {
        public static void Main(string[] args)
        {
            int number = 0; int nextPlayer = 2; var result=0;List<int> res = new List<int>();
            List<string> players = new List<string>();
            players.Add("PlayerA");players.Add("PlayerB");players.Add("PlayerC");players.Add("PlayerD");

            List<P> p = new List<P>();
            p.Add(new P { PlayerName = "PlayerA", PlayerScore = 0, PlayerFacedBalls=0 });
            p.Add(new P { PlayerName = "PlayerB", PlayerScore = 0, PlayerFacedBalls = 0 });
            p.Add(new P { PlayerName = "PlayerC", PlayerScore = 0, PlayerFacedBalls = 0 });
            p.Add(new P { PlayerName = "PlayerD", PlayerScore = 0, PlayerFacedBalls = 0 });

            string PlayerA = "PlayerA"; string playerB = "PlayerB"; string playerName = PlayerA;
            Random random = new Random();
            for (int overs = 0; overs <=3 && number <= 40; overs++)
            {
                for (int ballsCount = 1; ballsCount <= 6 && number <= 40; ballsCount++)
                {
                    int num = (random.Next(0, 8));
                    if (num == 7 && nextPlayer<4)
                    {        
                        Console.WriteLine(overs + "." + ballsCount + " " + playerName + "  is out,");
                        p.Where(x => x.PlayerName == playerName).ToList().Sum(x => x.PlayerFacedBalls = x.PlayerFacedBalls + 1);
                        if (playerName == PlayerA)
                        {
                            PlayerA = players[nextPlayer++];
                            playerName = PlayerA;int a = number;
                        }
                        else
                        {
                            playerB = players[nextPlayer++];
                            playerName = playerB;
                        }

                        Console.Write(" Next Player is " + playerName);
                        Console.WriteLine();
                    }
                    else
                    {
                        if (nextPlayer >= 4)
                        {
                            Console.WriteLine(overs + "." + ballsCount + " " + playerName + "  is out");
                            p.Where(x => x.PlayerName == playerName).ToList().Sum(x => x.PlayerFacedBalls = x.PlayerFacedBalls + 1);
                            Console.WriteLine();
                            Console.WriteLine("Match Ended," + " you have lost by " + (40 - number) + " runs");
                            Console.WriteLine("Runs Scored " + number);

                            foreach (P item in p)
                            {
                                Console.WriteLine(item.PlayerName + " " + item.PlayerScore + "(" + item.PlayerFacedBalls + ")");
                            }
                            return;
                        }
                        if (num % 2 == 0 && num!=7)
                        {
                            Console.WriteLine(overs + "."+ballsCount + " " + playerName + " has scored " + num);
                            var  a = p.Where(x => x.PlayerName == playerName).ToList().Sum(x => x.PlayerScore = x.PlayerScore + num);
                            p.Where(x => x.PlayerName == playerName).ToList().Sum(x => x.PlayerFacedBalls = x.PlayerFacedBalls + 1);
                          // Console.WriteLine(playerName +" " + b);
                            number += num;
                            if (ballsCount == 6)
                            {
                                Console.WriteLine();
                                if (playerName == PlayerA)
                                {
                                    playerName = playerB;
                                }
                                else playerName = PlayerA;

                                Console.WriteLine();
                            }
                        }

                        else if (num % 2 == 1 && num != 7)
                        {
                            Console.WriteLine(overs + "." + ballsCount + " " + playerName + " has scored " + num);
                            var a= p.Where(x => x.PlayerName == playerName).ToList().Sum(x => x.PlayerScore = x.PlayerScore + num);
                            p.Where(x => x.PlayerName == playerName).ToList().Sum(x => x.PlayerFacedBalls = x.PlayerFacedBalls + 1);
                            //Console.WriteLine(playerName+" " + a);
                            number += num;
                            if (playerName == PlayerA)
                            {
                                playerName = playerB;
                            }
                            else playerName = PlayerA;
                        }                       
                    }
                }
            }

            Console.WriteLine("Runs Scored " + number);
            
            foreach (P item in p)
            {
                 Console.WriteLine(item.PlayerName + " " + item.PlayerScore+"("+item.PlayerFacedBalls+")");
            }
        }
    }
}


