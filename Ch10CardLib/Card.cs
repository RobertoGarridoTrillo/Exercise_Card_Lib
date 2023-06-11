namespace Ch10CardLib
{
	public class Card
	{
		public readonly Rank rank;
		public readonly Suit suit;

		public Card(Suit newSuit, Rank newRank)
		{
			suit = newSuit;
			this.rank = newRank;
		}

		private Card()
		{
			throw new System.NotImplementedException();
		}

		public override string ToString()
		{
			return "The " + rank + " of " + suit + "s";
		}
	}
}