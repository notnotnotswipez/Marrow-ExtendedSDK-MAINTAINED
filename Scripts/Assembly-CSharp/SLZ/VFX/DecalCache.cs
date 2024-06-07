using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Data;
using SLZ.Marrow.Pool;
using SLZ.Marrow.Utilities;
using UnityEngine;

namespace SLZ.VFX
{
	[RequireComponent(typeof(DecalProjector))]
	public class DecalCache : MonoBehaviour
	{
		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CDelayedDespawn_003Ed__9 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public DecalCache _003C_003E4__this;

			private UniTask.Awaiter _003C_003Eu__1;

			public void MoveNext()
			{
			}

			[DebuggerHidden]
			public void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		private static ComponentCache<DecalCache> _cache;

		[SerializeField]
		private DecalProjector _decalProjector;

		private Poolee poolee;

		public static ComponentCache<DecalCache> Cache => null;

		private void Reset()
		{
		}

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnDisable()
		{
		}

		[AsyncStateMachine(typeof(_003CDelayedDespawn_003Ed__9))]
		private UniTaskVoid DelayedDespawn()
		{
			return default(UniTaskVoid);
		}

		public void SetColliderColorAndCreate(Collider hitCollider, Color color)
		{
		}

		public void SetVariablesAndCreate(SurfaceData.MaterialLevel decalMaterialLevel, Collider hitCollider, Color colorTint)
		{
		}
	}
}
