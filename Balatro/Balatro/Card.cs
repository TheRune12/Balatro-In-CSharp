using System.Collections.Generic;
using System.Text;

namespace Balatro
{
    class Card
    {
        Rank rank;
        Suit suit;

        public Card(Rank rank, Suit suit)
        {
            this.rank = rank;
            this.suit = suit;
        }

        public int PrintMe()
        {
            Console.WriteLine(this.rank.ToString() + this.suit);
            return 1;
        }
    }
}