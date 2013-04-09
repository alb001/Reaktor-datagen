using System;
using Reactor.Design;

namespace Reactor
{
	public class Core
	{
		readonly Coolant Coolant;
		readonly Moderator Moderator;
		readonly Fuel[] Fuel;

		public Core ()
		{
			DemiWater mc = new DemiWater(250000);
			Coolant = mc;
			Moderator = mc;
		}
	}
}

