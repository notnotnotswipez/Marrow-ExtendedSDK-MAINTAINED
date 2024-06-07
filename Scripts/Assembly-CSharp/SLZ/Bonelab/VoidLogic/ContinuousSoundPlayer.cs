using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Algorithms.Unity;
using SLZ.Marrow.VoidLogic;
using UnityEngine;

namespace SLZ.Bonelab.VoidLogic
{
	[AddComponentMenu("VoidLogic/Bonelab/Sinks/VoidLogic Continuous Sound Player")]
	[Obsolete("This interface is not yet considered stable. Use at your own risk!")]
	[Support(SupportFlags.CowboySupported, "It's unclear how exactly we want to properly support playing sound. This component is allowed without endorsement until we have an answer for that.")]
	public class ContinuousSoundPlayer : MonoBehaviour, IVoidLogicSink, IVoidLogicNode
	{
		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CManagedUpdate_003Ed__54 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public CancellationToken cancellationSource;

			public ContinuousSoundPlayer _003C_003E4__this;

			private UniTask.Awaiter _003C_003Eu__1;


			public void MoveNext()
			{
				throw new NotImplementedException();
			}

			public void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				throw new NotImplementedException();
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CDoAStart_003Ed__55 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public ContinuousSoundPlayer _003C_003E4__this;

			public EdgeType edgeType;

			private UniTask.Awaiter _003C_003Eu__1;


			public void MoveNext()
			{
				throw new NotImplementedException();
			}

			public void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				throw new NotImplementedException();
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CSpawnAndPlayAudio_003Ed__56 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public ContinuousSoundPlayer _003C_003E4__this;

			public ClipPair chosenClipPair;

			private UniTask<GameObject>.Awaiter _003C_003Eu__1;


			public void MoveNext()
			{
				throw new NotImplementedException();
			}

			public void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				throw new NotImplementedException();
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CFadeVolume_003Ed__59 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public ContinuousSoundPlayer _003C_003E4__this;

			public float fadeTarget;

			public float fadeTime;

			public CancellationTokenSource cancellationSource;

			private float _003Ctime_003E5__2;

			private float _003CfadeTargetClamped_003E5__3;

			private float _003CstartVolume_003E5__4;

			private float _003CnormalizedFadeTime_003E5__5;

			private UniTask.Awaiter _003C_003Eu__1;


			public void MoveNext()
			{
				throw new NotImplementedException();
			}

			public void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				throw new NotImplementedException();
			}
		}

		[Tooltip("Previous node(s) in the chain")]
		[SerializeField]
		[Interface(typeof(IVoidLogicSource), false)]
		private MonoBehaviour[] _previous;

		private float _volumeMultiplier;

		private float _pitchMultiplier;

		private float _volumeFaderMultiplier;

		private AudioPlayerAndClipPair _audioPlayer;

		private bool shouldBeAwake;

		private bool cueFadeIn;

		private EdgeType lastStartEdgeType;

		private CancellationTokenSource managedUpdateCancelToken;

		private CancellationTokenSource fadeCancelToken;

		private static readonly PortMetadata _portMetadata;

		public PortMetadata PortMetadata { get; }

		public VoidLogicSubgraph Subgraph
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

		public ClipChooser ClipChooser
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

		public Transform AudioPlacementOverride
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

		public float SourceRadius
		{
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public float Volume
		{
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public float FadeTime
		{
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public float SpacialBlend
		{
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int MaximumQueueDepth
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

		private EdgeDetector StartEdgeDetector
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

		private EdgeDetector ResetEdgeDetector
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

		public int InputCount => 0;

		private PortMetadata SLZ_002EMarrow_002EVoidLogic_002EIVoidLogicNode_002EPortMetadata => default(PortMetadata);

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnDestroy()
		{
		}

		[AsyncStateMachine(typeof(_003CManagedUpdate_003Ed__54))]
		private UniTaskVoid ManagedUpdate(CancellationToken cancellationSource)
		{
			return default(UniTaskVoid);
		}

		[AsyncStateMachine(typeof(_003CDoAStart_003Ed__55))]
		private UniTask DoAStart(EdgeType edgeType)
		{
			return default(UniTask);
		}

		[AsyncStateMachine(typeof(_003CSpawnAndPlayAudio_003Ed__56))]
		private UniTask SpawnAndPlayAudio(EdgeType edgeType, ClipPair chosenClipPair)
		{
			return default(UniTask);
		}

		private UniTask<GameObject> SpawnAudioPlayerAsync(Vector3 position = default(Vector3))
		{
			return default(UniTask<GameObject>);
		}

		private void OnAudioSourceDespawned(GameObject go)
		{
		}

		[AsyncStateMachine(typeof(_003CFadeVolume_003Ed__59))]
		private UniTaskVoid FadeVolume(float fadeTarget, float fadeTime, CancellationTokenSource cancellationSource)
		{
			return default(UniTaskVoid);
		}

		private void OnTriggerEnter(Collider c)
		{
		}

		private void OnTriggerExit(Collider c)
		{
		}

		public bool TryGetInputAtIndex(uint idx, out IVoidLogicSource input)
		{
			input = null;
			return false;
		}

		public bool TrySetInputAtIndex(uint idx, IVoidLogicSource input)
		{
			return false;
		}
	}
}
