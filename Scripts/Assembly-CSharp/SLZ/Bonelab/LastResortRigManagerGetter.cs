using System;
using System.Runtime.CompilerServices;
using SLZ.Rig;
using UnityEngine;

namespace SLZ.Bonelab
{
	[Obsolete("You had better know what you're doing, using this component!")]
	public class LastResortRigManagerGetter : MonoBehaviour
	{
		public RigManager RigManager
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

		public void ClearRigManager(bool areYouSure)
		{
		}

		public void ClearRigManagerAndImmediatelyTryToGetItAgain(bool areYouSure)
		{
		}

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		internal static bool TryGetRigManager_HACKY(out RigManager rigManager)
		{
			rigManager = null;
			return false;
		}

		private void SearchDesperatelyForRigManager()
		{
		}
	}
}
