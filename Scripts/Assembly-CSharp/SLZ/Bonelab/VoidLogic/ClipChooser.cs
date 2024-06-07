using System;
using System.Runtime.CompilerServices;
using SLZ.Marrow.VoidLogic;

namespace SLZ.Bonelab.VoidLogic
{
	[Serializable]
	public class ClipChooser
	{
		private Random _random;

		public ClipSelectBehavior SelectBehavior
		{
			[CompilerGenerated]
			get
			{
				return default(ClipSelectBehavior);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public ClipDispatchBehavior DispatchBehavior
		{
			[CompilerGenerated]
			get
			{
				return default(ClipDispatchBehavior);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public ClipPair[] AudioClips
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int ClipIndex
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int RandomSeed
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool TryChooseClip(EdgeType edgeType, out ClipPair clipPair)
		{
			clipPair = default(ClipPair);
			return false;
		}

		public virtual bool TryChooseClip(EdgeType edgeType, float selectedIndex, out ClipPair clipPair)
		{
			clipPair = default(ClipPair);
			return false;
		}
	}
}
