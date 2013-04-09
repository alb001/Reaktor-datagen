using System;
using Reactor.Physics;

namespace Reactor
{
	public abstract class Material : Coo
	{
		public readonly Kilogram Mass;

		public Material( Kilogram mass )
		{
			this.Mass = mass;
		}

		public Kelvin Temperature{ get; private set; }
		
		public static readonly HeatCapacity HeatCapacity; 
		
		public void Energise( Joule Q )
		{
			Temperature = Q / ( DemiWater.HeatCapacity * Mass );
		}
	}
}

