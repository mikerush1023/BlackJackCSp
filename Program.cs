using System;
using System.Collections.Generic;
using System.Linq;
namespace BlackjackCS
{
    class Card
    {
        public string Name { get; set; }
        public int CardValue(string name)
        {
            if (name.Contains("Ace"))
            {
                return 11;
            }
            else if (name.Contains("2"))
            {
                return 2;
            }
            else if (name.Contains("3"))
            {
                return 3;
            }
            else if (name.Contains("4"))
            {
                return 4;
            }
            else if (name.Contains("5"))
            {
                return 5;
            }
            else if (name.Contains("6"))
            {
                return 6;
            }
            else if (name.Contains("7"))
            {
                return 7;
            }
            else if (name.Contains("8"))
            {
                return 8;
            }
            else if (name.Contains("9"))
            {
                return 9;
            }
            else
            {
                return 10;
            }
        }
    }
    class Program
    {
        static void Greeting()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("====Welcome to Blackjack ====");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }
        static int Value(string name)
        {
            if (name.Contains("Ace"))
            {
                return 11;
            }
            else if (name.Contains("2"))
            {
                return 2;
            }
            else if (name.Contains("3"))
            {
                return 3;
            }
            else if (name.Contains("4"))
            {
                return 4;
            }
            else if (name.Contains("5"))
            {
                return 5;
            }
            else if (name.Contains("6"))
            {
                return 6;
            }
            else if (name.Contains("7"))
            {
                return 7;
            }
            else if (name.Contains("8"))
            {
                return 8;
            }
            else if (name.Contains("9"))
            {
                return 9;
            }
            else
            {
                return 10;
            }
        }
        static void Main(string[] args)
        {
            Greeting();
            var index = 0;
            var deck = new List<string> { "King Clubs", "6 Hearts", "10 Spades", "9 Spades", "Ace Spades", "King Hearts", "5 Spades", "2 Hearts", "10 Hearts", "Ace Clubs", "2 Clubs", "3 Spades", "9 Clubs", "7 Diamonds", "King Diamonds", "7 Hearts", "3 Diamonds", "Jack Diamonds", "5 Diamonds", "4 Hearts", "10 Clubs", "King Spades", "8 Hearts", "4 Diamonds", "9 Diamonds", "6 Spades", "4 Clubs", "7 Clubs", "5 Clubs", "7 Spades", "Jack Spades", "2 Diamonds", "6 Diamonds", "10 Diamonds", "Queen Clubs", "Queen Hearts", "Ace Hearts", "Queen Diamonds", "3 Hearts", "Ace Diamonds", "Jack Clubs", "9 Hearts", "Queen Spades", "3 Clubs", "8 Diamonds", "Jack Hearts", "4 Spades", "8 Spades", "8 Clubs", "5 Hearts", "2 Spades", "6 Clubs" };
            var playerHand = new List<Card>();
            var houseHand = new List<Card>();
            Console.WriteLine($"Player has {deck[2]} & {deck[3]}");
            Console.WriteLine();
            var playerScore = Value(deck[2]) + Value(deck[3]);
            var houseScore = Value(deck[0]) + Value(deck[1]);
            var playerkeepHitting = true;
            var housekeepHitting = true;
            while (playerkeepHitting)
            {
                Console.WriteLine("Do you want to hit? yes|no");
                var answer = Console.ReadLine();
                if (answer == "yes")
                {
                    var newCard = new Card()
                    {
                        Name = deck[index]
                    };
                    Console.WriteLine(newCard.Name);
                    playerHand.Add(newCard);
                    playerScore += newCard.CardValue(newCard.Name);
                    if (playerScore > 21)
                    {
                        Console.WriteLine("House Wins");
                        playerkeepHitting = false;
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("House plays");
                    playerkeepHitting = false;
                }
                index++;
            }
            while (housekeepHitting && houseScore < 17)
            {
                var newCard = new Card()
                {
                    Name = deck[index]
                };
                Console.WriteLine(newCard.Name);
                houseHand.Add(newCard);
                houseScore += newCard.CardValue(newCard.Name);
                if (houseScore > 21)
                {
                    Console.WriteLine("Player Wins");
                }
                else if (houseScore > playerScore || houseScore == playerScore)

                {
                    Console.WriteLine("House Wins");
                }
                else
                {
                    Console.WriteLine("Player Wins");
                }
            }
            index++;
        }
    }
}





