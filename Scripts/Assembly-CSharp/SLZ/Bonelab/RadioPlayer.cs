using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Marrow.Audio;
using SLZ.Marrow.Interaction;
using SLZ.Marrow.Pool;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class RadioPlayer : MonoBehaviour, IPoolable, IMarrowEntityCullable
	{
		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CRadioUpdateLoop_003Ed__44 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public RadioPlayer _003C_003E4__this;

			public CancellationToken cancelToken;

			private UniTask.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

            void IAsyncStateMachine.MoveNext()
            {
                throw new System.NotImplementedException();
            }

            [DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

            void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
                throw new System.NotImplementedException();
            }
        }

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CFadeVolume_003Ed__45 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public RadioPlayer _003C_003E4__this;

			public float fadeTarget;

			public float fadeTime;

			public CancellationTokenSource cancellationSource;

			private float _003Ctime_003E5__2;

			private float _003CfadeTargetClamped_003E5__3;

			private float _003CstartVolume_003E5__4;

			private float _003CnormalizedFadeTime_003E5__5;

			private UniTask.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

            void IAsyncStateMachine.MoveNext()
            {
                throw new System.NotImplementedException();
            }

            [DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

            void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
                throw new System.NotImplementedException();
            }
        }

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003COverrideAsync_003Ed__46 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public RadioPlayer _003C_003E4__this;

			public CancellationToken cancelToken;

			private float _003Ctime_003E5__2;

			private UniTask.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

            void IAsyncStateMachine.MoveNext()
            {
                throw new System.NotImplementedException();
            }

            [DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

            void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
                throw new System.NotImplementedException();
            }
        }

		public MarrowEntity entity;

		public Poolee poolee;

		public RadioSong overrideClip;

		[Range(0f, 1f)]
		public float mainVolume;

		[Range(0f, 1f)]
		public float announcementVolume;

		[Range(0.1f, 10f)]
		public float sourceRadius;

		[Range(0.1f, 8f)]
		public float fadeTime;

		[HideInInspector]
		public RadioStation[] stations;

		public RadioStation? selectedStation;

		public RadioManager radioManager;

		public float desyncBufferTime;

		public float checkTime;

		public AnimationCurve duckCurve;

		[Range(0f, 4f)]
		public float duckTime;

		[Header("Do Not Set In Inspector")]
		public bool playAnnouncement;

		private int cur_station;

		private int cur_track;

		private float _lastTimeScale;

		private float volumeFadeMultiplier;

		private float volumeDuckMultiplier;

		private AudioPlayer mainAP;

		private AudioPlayer announcementAP;

		private CancellationTokenSource updateLoopCancelTokenSource;

		private CancellationTokenSource fadeCancelTokenSource;

		private CancellationTokenSource overrideCancelTokenSource;

		private float cashedBaseVolume;

		private bool cueFadeIn;

		private bool cueFadeOut;

		private bool announcementPlaying;

		private bool announcementPlayed;

		private float lastCheckTime;

		private AudioHighPassFilter mainHPF;

		private AudioHighPassFilter announcementHPF;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void Start()
		{
		}

		public void OnEntityCull()
		{
		}

		public void OnEntityUncull()
		{
		}

		public void OnPoolInitialize()
		{
		}

		public void OnPoolSpawn()
		{
		}

		public void OnPoolDeInitialize()
		{
		}

		public void MainTrigger(bool enter)
		{
		}

		public void AnnouncementTrigger(bool enter)
		{
		}

		public void PlayNextStation()
		{
		}

		[AsyncStateMachine(typeof(_003CRadioUpdateLoop_003Ed__44))]
		private UniTaskVoid RadioUpdateLoop(CancellationToken cancelToken)
		{
			return default(UniTaskVoid);
		}

		[AsyncStateMachine(typeof(_003CFadeVolume_003Ed__45))]
		private UniTaskVoid FadeVolume(float fadeTarget, float fadeTime, CancellationTokenSource cancellationSource)
		{
			return default(UniTaskVoid);
		}

		[AsyncStateMachine(typeof(_003COverrideAsync_003Ed__46))]
		private UniTaskVoid OverrideAsync(CancellationToken cancelToken)
		{
			return default(UniTaskVoid);
		}

		private void StopAndReleaseAll()
		{
		}
	}
}
