using System;
using JetBrains.Annotations;
using SLZ.Marrow.Console;

namespace SLZ.Bonelab.Console
{
	[UsedImplicitly]
	internal class SceneDescriber : IObjectDescriber
	{
		public bool CanDescribe(Type type)
		{
			return false;
		}

		public bool TryDescribe(object obj, TokenParseContext context, out ObjectDescription description)
		{
			description = null;
			return false;
		}
	}
}
