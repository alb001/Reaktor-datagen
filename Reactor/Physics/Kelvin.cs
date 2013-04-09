using System;

namespace Reactor.Physics
{
	public struct Kelvin
	{
		public readonly Double value;

		public Kelvin( Double value )
		{
			this.value = value;
		}

		public static implicit operator Kelvin( Double value )
		{
			return new Kelvin( value );
		}
	}
}

