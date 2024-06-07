using System;
using System.Runtime.CompilerServices;

namespace TriangleNet
{
	public class Configuration
	{
		public Func<IPredicates> Predicates
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Func<TrianglePool> TrianglePool
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Configuration()
		{
		}

		public Configuration(Func<IPredicates> predicates)
		{
		}

		public Configuration(Func<IPredicates> predicates, Func<TrianglePool> trianglePool)
		{
		}
	}
}
