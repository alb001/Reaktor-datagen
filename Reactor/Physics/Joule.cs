using System;

namespace Reactor.Physics
{
	public struct Joule
	{
		public readonly Double value;

		public Joule( Double value )
		{
			this.value = value;
		}

		public static implicit operator Joule( Double value )
		{
			return new Joule( value );
		}
	}
}

