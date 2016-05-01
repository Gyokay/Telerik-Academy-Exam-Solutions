using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Card_Wars
{
    class Program
    {
        static void Main(string[] args)
        {
            long N = long.Parse(Console.ReadLine());

            BigInteger playerOneGeneralScore = 0;
            long playerOneGamesWon = 0;

            BigInteger playerTwoGeneralScore = 0;
            long playerTwoGamesWon = 0;

            bool isX = false;

            for (int games = 0; games < N; games++)
            {
                BigInteger playerOneHandStrength = 0;
                BigInteger playerTwoHandStrength = 0;

                string playerOneHand = "";
                for (int playe1 = 0; playe1 < 3; playe1++)
                {
                    string nextCard = Console.ReadLine();

                    if (nextCard == "10")
                    {
                        playerOneHand += '0';
                    }
                    else
                    {
                        playerOneHand += nextCard;
                    }
                }

                string playerTwoHand = "";
                for (int player2 = 0; player2 < 3; player2++)
                {
                    string nextCard = Console.ReadLine();

                    if (nextCard == "10")
                    {
                        playerTwoHand += '0';
                    }
                    else
                    {
                        playerTwoHand += nextCard;
                    }
                }

                if (playerOneHand.Contains('X') && playerTwoHand.Contains('X'))
                {
                    playerOneGeneralScore += 50;
                    playerTwoGeneralScore += 50;
                }
                else if (playerOneHand.Contains('X'))
                {
                    Console.WriteLine("X card drawn! Player one wins the match!");
                    isX = true;
                    break;
                }
                else if (playerTwoHand.Contains('X'))
                {
                    Console.WriteLine("X card drawn! Player two wins the match!");
                    isX = true;
                    break;
                }

                for (int i = 0; i < 3; i++)
                {
                    switch (playerOneHand[i])
                    {
                        case '2': playerOneHandStrength += 10; break;
                        case '3': playerOneHandStrength += 9; break;
                        case '4': playerOneHandStrength += 8; break;
                        case '5': playerOneHandStrength += 7; break;
                        case '6': playerOneHandStrength += 6; break;
                        case '7': playerOneHandStrength += 5; break;
                        case '8': playerOneHandStrength += 4; break;
                        case '9': playerOneHandStrength += 3; break;
                        case '0': playerOneHandStrength += 2; break;
                        case 'A': playerOneHandStrength += 1; break;
                        case 'J': playerOneHandStrength += 11; break;
                        case 'Q': playerOneHandStrength += 12; break;
                        case 'K': playerOneHandStrength += 13; break;
                    }
                }

                for (int i = 0; i < 3; i++)
                {
                    switch (playerTwoHand[i])
                    {
                        case '2': playerTwoHandStrength += 10; break;
                        case '3': playerTwoHandStrength += 9; break;
                        case '4': playerTwoHandStrength += 8; break;
                        case '5': playerTwoHandStrength += 7; break;
                        case '6': playerTwoHandStrength += 6; break;
                        case '7': playerTwoHandStrength += 5; break;
                        case '8': playerTwoHandStrength += 4; break;
                        case '9': playerTwoHandStrength += 3; break;
                        case '0': playerTwoHandStrength += 2; break;
                        case 'A': playerTwoHandStrength += 1; break;
                        case 'J': playerTwoHandStrength += 11; break;
                        case 'Q': playerTwoHandStrength += 12; break;
                        case 'K': playerTwoHandStrength += 13; break;
                    }
                }

                if (playerOneHandStrength > playerTwoHandStrength)
                {
                    playerOneGeneralScore += playerOneHandStrength;
                    playerOneGamesWon++;
                }
                else if (playerTwoHandStrength > playerOneHandStrength)
                {
                    playerTwoGeneralScore += playerTwoHandStrength;
                    playerTwoGamesWon++;
                }

                long countPlayerOne = playerOneHand.Count(x => x == 'Z');
                if (countPlayerOne > 0)
                {
                    playerOneGeneralScore *= ((long)(Math.Pow(2, countPlayerOne)));
                }

                long countPlayerTwo = playerTwoHand.Count(x => x == 'Z');
                if (countPlayerTwo > 0)
                {
                    playerTwoGeneralScore *= ((long)(Math.Pow(2, countPlayerTwo)));
                }


                countPlayerOne = playerOneHand.Count(x => x == 'Y');
                if (countPlayerOne > 0)
                {
                    playerOneGeneralScore -= (200 * countPlayerOne);
                }

                countPlayerTwo = playerTwoHand.Count(x => x == 'Y');
                if (countPlayerTwo > 0)
                {
                    playerTwoGeneralScore -= (200 * countPlayerTwo);
                }

            }

            if (playerOneGeneralScore > playerTwoGeneralScore && !isX)
            {
                Console.WriteLine("First player wins!");
                Console.WriteLine("{0}: {1}", "Score", playerOneGeneralScore);
                Console.WriteLine("Games won: {0}", playerOneGamesWon);
            }
            else if (playerTwoGeneralScore > playerOneGeneralScore && !isX)
            {
                Console.WriteLine("Second player wins!");
                Console.WriteLine("{0}: {1}", "Score", playerTwoGeneralScore);
                Console.WriteLine("Games won: {0}", playerTwoGamesWon);
            }
            else if (playerOneGeneralScore == playerTwoGeneralScore && !isX)
            {
                Console.WriteLine("It's a tie!");
                Console.WriteLine("{0}: {1}", "Score", playerTwoGeneralScore);
            }
        }
    }
}
