using System;

namespace Reactor.Physics
{
	public struct HeatCapacity
	{
		public readonly Double jouleperkelvin;

		public HeatCapacity( Double c )
		{
			this.jouleperkelvin = c;
		}

		public static implicit operator HeatCapacity( Double c )
		{
			return new HeatCapacity( c );
		}

		public static HeatCapacity operator *( HeatCapacity c, Kilogram mass )
		{
			return new HeatCapacity( c.jouleperkelvin * mass.value );
		}

		public static Kelvin operator /( Joule energy, HeatCapacity c )
		{
			return new Kelvin( energy.value / c.jouleperkelvin );
		}
	}
}

