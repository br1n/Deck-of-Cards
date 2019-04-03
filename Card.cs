using System;
using System.Collections.Generic;

namespace DeckOfCards
{
    public class Card
    {
        string stringVal;
        int value; 
        string suit;
        public static string[] Suits = new string[4] {"Spades", "Hearts", "Diamonds", "Clubs"};
        public Card(string s, int val)
        {

            switch(val)
            {
                case 11:
                    stringVal = "Jack";
                    break;
                case 12:
                    stringVal = "Queen";
                    break;
                case 13:
                    stringVal = "King";
                    break;
                case 1:
                    stringVal = "Ace";
                    break;
                default:
                    stringVal = val.ToString();
                    break;
            }
            suit = s;
            value = val;
        }
        public void SayCard()
        {
            Console.WriteLine("The {0} of {1}", stringVal, suit);
        }
    }
}