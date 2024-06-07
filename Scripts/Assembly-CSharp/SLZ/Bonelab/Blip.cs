using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Marrow.Data;
using SLZ.Marrow.Pool;
using SLZ.Marrow.Utilities;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class Blip : SpawnEvents
	{
		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CFireEffectAsync_003Ed__16 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public Blip _003C_003E4__this;

			public Spawnable effect;

			public Color? color;

			private List<Mesh> _003CcachedMeshes_003E5__2;

			private List<Renderer> _003Crenderers_003E5__3;

			private UniTask<Poolee[]>.Awaiter _003C_003Eu__1;

			private UniTask.Awaiter _003C_003Eu__2;

			public void MoveNext()
			{
			}

			[DebuggerHidden]
			public void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		private static ComponentCache<Blip> _cache;

		[SerializeField]
		private Renderer[] Renderers;

		[SerializeField]
		private Spawnable fizzlerSpawnable;

		[SerializeField]
		private Spawnable spawnSpawnable;

		[Header("DO NOT SET IN INSPECTOR")]
		[HideInInspector]
		public Vector3 velocity;

		private bool isDestructible;

		[Header("DO NOT SET IN INSPECTOR")]
		[HideInInspector]
		public bool forceBlip;

		private bool sfxPlayed;

		public static ComponentCache<Blip> Cache => null;

		protected override void Awake()
		{
		}

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		public override void OnPoolDeInitialize()
		{
		}

		public void CallSpawnEffect()
		{
		}

		public void CallDespawnEffect()
		{
		}

		[AsyncStateMachine(typeof(_003CFireEffectAsync_003Ed__16))]
		public UniTaskVoid FireEffectAsync(Spawnable effect, Color? color = null)
		{
			return default(UniTaskVoid);
		}

		private float GetVolumeSurface(Vector3 size)
		{
			return 0f;
		}
	}
}
