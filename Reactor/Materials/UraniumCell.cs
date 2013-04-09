using System;
using Reactor.Physics;
using Reactor.Design;

namespace Reactor
{
	public class UraniumCell : Material, Fuel
	{
		public UraniumCell( Kilogram mass ) : base( mass )
		{
		}
	}
}

