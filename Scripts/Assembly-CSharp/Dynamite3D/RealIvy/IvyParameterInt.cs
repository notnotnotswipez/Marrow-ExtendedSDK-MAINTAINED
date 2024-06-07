using System;

namespace Dynamite3D.RealIvy
{
	[Serializable]
	public class IvyParameterInt : IvyParameter
	{
		public IvyParameterInt(int value)
		{
		}

		public override void UpdateValue(float value)
		{
		}

		public static implicit operator int(IvyParameterInt intParameter)
		{
			return 0;
		}

		public static implicit operator IvyParameterInt(int intValue)
		{
			return null;
		}
	}
}
