﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _7.CardWarsBatka
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool player1HasXCard = false;
            bool player2HasXCard = false;
            int player1GamesWon = 0;
            int player2GamesWon = 0;
            BigInteger player1TotalScore = 0;
            BigInteger player2TotalScore = 0;

            for (int i = 0; i < n; i++)
            {
                int player1HandScore = 0;
                int player2HandScore = 0;

                for (int j = 0; j < 3; j++)
                {
                    string card = Console.ReadLine();
                    switch (card)
                    {
                        case "A": player1HandScore += 1; break;
                        case "K": player1HandScore += 13; break;
                        case "Q": player1HandScore += 12; break;
                        case "J": player1HandScore += 11; break;
                        case "X": player1HasXCard = true; break;
                        case "Y": player1TotalScore -= 200; break;
                        case "Z": player1TotalScore *= 2; break;
                        default: player1HandScore += (12 - int.Parse(card)); break;
                    }
                }

                for (int k = 0; k < 3; k++)
                {
                    string card = Console.ReadLine();
                    switch (card)
                    {
                        case "A": player2HandScore += 1; break;
                        case "K": player2HandScore += 13; break;
                        case "Q": player2HandScore += 12; break;
                        case "J": player2HandScore += 11; break;
                        case "X": player2HasXCard = true; break;
                        case "Y": player2TotalScore -= 200; break;
                        case "Z": player2TotalScore *= 2; break;
                        default: player2HandScore += (12 - int.Parse(card)); break;
                    }
                }

                if (player1HandScore > player2HandScore)
                {
                    player1TotalScore += player1HandScore;
                    ++player1GamesWon;
                }
                else if (player1HandScore < player2HandScore)
                {
                    player2TotalScore += player2HandScore;
                    ++player2GamesWon;
                }
                if (player1HasXCard && player2HasXCard)
                {
                    player1TotalScore += 50;
                    player2TotalScore += 50;
                }
                else if (player1HasXCard)
                {
                    Console.WriteLine("X card drawn! Player one wins the match!");
                    return;
                }
                else if (player2HasXCard)
                {
                    Console.WriteLine("X card drawn! Player two wins the match!");
                    return;
                }
            }



            if (player2TotalScore == player1TotalScore)
            {
                Console.WriteLine(@"It's a tie!
Score: {0}", player1TotalScore);
            }
            else if (player1TotalScore > player2TotalScore)
            {
                Console.WriteLine(@"First player wins!
Score: {0}
Games won: {1}", player1TotalScore, player1GamesWon);
            }
            else if (player2TotalScore > player1TotalScore)
            {
                Console.WriteLine(@"Second player wins!
Score: {0}
Games won: {1}", player2TotalScore, player2GamesWon);
            }
        }
    }
}
