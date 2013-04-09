using System;
using Reactor.Physics;
using Reactor.Design;

namespace Reactor
{
	public class DemiWater : Material, Coolant, Moderator
	{
		public DemiWater( Kilogram mass ) : base( mass )
		{
		}

	}
}

