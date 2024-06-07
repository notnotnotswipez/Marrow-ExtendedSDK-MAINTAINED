using System.Runtime.CompilerServices;

namespace MK.Glow
{
	internal struct RenderDimension : IDimension
	{
		public int width
		{
			[CompilerGenerated]
			readonly get
			{
				return 0;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int height
		{
			[CompilerGenerated]
			readonly get
			{
				return 0;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public RenderDimension renderDimension => default(RenderDimension);

		public RenderDimension(int width, int height)
		{
		}
	}
}
