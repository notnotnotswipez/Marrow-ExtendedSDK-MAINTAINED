using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Data;
using SLZ.Marrow.Combat;
using SLZ.Marrow.Data;
using SLZ.Marrow.Utilities;
using UnityEngine;
using UnityEngine.EventSystems;

namespace SLZ.Combat
{
	public class ImpactProperties : ImpactPropertiesVariables, IAttackReceiver, IEventSystemHandler
	{
		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CRecieveAttackAsync_003Ed__14 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public ImpactProperties _003C_003E4__this;

			public Attack attack;

			private UniTask.Awaiter _003C_003Eu__1;

			public void MoveNext()
			{
			}

			[DebuggerHidden]
			public void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CSpawnImpactAsync_003Ed__15 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public ImpactProperties _003C_003E4__this;

			public Attack attack;

			private UniTask<SLZ.Marrow.Pool.Poolee>.Awaiter _003C_003Eu__1;

			public void MoveNext()
			{
			}

			[DebuggerHidden]
			public void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CSpawnDecalAsync_003Ed__16 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public ImpactProperties _003C_003E4__this;

			public Attack attack;

			public Quaternion rot;

			private UniTask<SLZ.Marrow.Pool.Poolee>.Awaiter _003C_003Eu__1;

			public void MoveNext()
			{
			}

			[DebuggerHidden]
			public void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		private static ComponentCache<ImpactProperties> _cache;

		[Header("References")]
		public Collider[] colliders;

		[SerializeField]
		[HideInInspector]
		public bool hasManager;

		[HideInInspector]
		[SerializeField]
		public bool ShowControls;

		[HideInInspector]
		[SerializeField]
		public ImpactPropertiesManager Manager;

		private bool setup;

		private bool _isDestroyed;

		public static ComponentCache<ImpactProperties> Cache => null;

		private void Awake()
		{
		}

		private void StaticFix()
		{
		}

		private void OnDestroy()
		{
		}

		public void UpdateMaterial()
		{
		}

		public void ReceiveAttack(Attack attack)
		{
		}

		[AsyncStateMachine(typeof(_003CRecieveAttackAsync_003Ed__14))]
		public UniTaskVoid RecieveAttackAsync(Attack attack)
		{
			return default(UniTaskVoid);
		}

		[AsyncStateMachine(typeof(_003CSpawnImpactAsync_003Ed__15))]
		private UniTaskVoid SpawnImpactAsync(Attack attack)
		{
			return default(UniTaskVoid);
		}

		[AsyncStateMachine(typeof(_003CSpawnDecalAsync_003Ed__16))]
		private UniTaskVoid SpawnDecalAsync(Attack attack, Quaternion rot)
		{
			return default(UniTaskVoid);
		}

		public void SpawnImpactVFX(Attack attack)
		{
		}

		private SurfaceData.MaterialLevel GetMaterialFromAttack(AttackType attackType)
		{
			return default(SurfaceData.MaterialLevel);
		}

		private SurfaceData.MaterialLevel randomizeLevel(SurfaceData.MaterialLevel[] levels)
		{
			return default(SurfaceData.MaterialLevel);
		}

		public void FindColliders(bool childColliders = false)
		{
		}

		public void FindRenderer()
		{
		}

		private void SetRenderer(Renderer renderer)
		{
		}

		public float GetMegaPascals()
		{
			return 0f;
		}
	}
}
