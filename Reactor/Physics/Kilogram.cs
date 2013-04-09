using System;

namespace Reactor.Physics
{
	public struct Kilogram
	{
		public readonly double value;

		public Kilogram( Double value )
		{
			this.value = value;
		}

		public static implicit operator Kilogram( Double value )
		{
			return new Kilogram( value );
		}
	}
}

