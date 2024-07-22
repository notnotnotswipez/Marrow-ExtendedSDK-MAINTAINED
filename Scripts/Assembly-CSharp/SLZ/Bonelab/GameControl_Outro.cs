using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Marrow.AI;
using SLZ.Marrow.Interaction;
using SLZ.Marrow.Warehouse;
using SLZ.Marrow.Zones;
using TMPro;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class GameControl_Outro : BonelabInternalGameControl
	{
		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CSequenceProgress_003Ed__49 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public int progress;

			public GameControl_Outro _003C_003E4__this;

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
		private struct _003CChangeChunk_003Ed__50 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public int progress;

			public GameControl_Outro _003C_003E4__this;

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
		private struct _003CLoadAvatarFromSaveDataAsync_003Ed__62 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public GameControl_Outro _003C_003E4__this;

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

		public Encounter[] Encounters;

		[Header("Chunks")]
		public SceneChunk Town;

		public SceneChunk Gap;

		public SceneChunk Windmill;

		public SceneChunk Tube;

		public SceneChunk TaxiStart;

		public SceneChunk VoidFloor;

		public SceneChunk EmptyFloor;

		public SceneChunk VoidG114;

		[Space(10f)]
		public MarrowEntity TaxiSequence;

		public ArmFinale ArmFinale;

		public GameObject VoidMenu;

		public GameObject windmill;

		public MarrowEntity holeStopper;

		[Tooltip("Used Internally, do not set in inspector")]
		public bool RightDoorIsClosed;

		[Tooltip("Used Internally, do not set in inspector")]
		public bool LeftDoorIsClosed;

		private IEnumerator WindmillAirlock;

		private Coroutine changeChunk;

		[Header("ArmCinematic")]
		public MarrowEntity[] ceilingtiles;

		public GameObject[] ceilingStaticObjects;

		public MarrowEntity JimmyArm;

		public float armDelay;

		private Coroutine _coArmDelay;

		public GameObject avatarTransform;

		public MeshFilter avatarMeshFilter;

		public TextMeshProUGUI avatarName;

		public float avatarMeshScaleTune;

		private AvatarCrate avatarCrate;

		public string buildTitle;

		public string buildState;

		private string buildDate;

		public TextMeshPro tmp_Title;

		public TextMeshPro tmp_BuildInfo;

		public AudioClip clip_menu;

		public AudioClip clip_kegen;

		public SpawnableCrateReference blueApollo;

		public HomeCleanupVolume homeCleanupVolume;

		public override void Awake()
		{
		}

		public override void Start()
		{
		}

		private void OnLevelLoad()
		{
		}

		public void WarmUpJimmyArm()
		{
		}

		private void ReachWindmill()
		{
		}

		private void ReachedTaxi()
		{
		}

		private void ArmHide()
		{
		}

		private void VoidDriving()
		{
		}

		private void DrivingEnd()
		{
		}

		public void LeashPlayerAtLevelEnd()
		{
		}

		public void CompleteGame()
		{
		}

		public void NonAsyncSequenceProgress(int progress)
		{
		}

		[AsyncStateMachine(typeof(_003CSequenceProgress_003Ed__49))]
		public UniTaskVoid SequenceProgress(int progress)
		{
			return default(UniTaskVoid);
		}

		[AsyncStateMachine(typeof(_003CChangeChunk_003Ed__50))]
		private UniTask ChangeChunk(int progress)
		{
			return default(UniTask);
		}

		public void ClosedLeftDoor()
		{
		}

		public void ClosedRightDoor()
		{
		}

		public void OpenedLeftDoor()
		{
		}

		public void OpenedRightDoor()
		{
		}

		public void RemoveObjects()
		{
		}

		public void TweenFogDensity(float _endDensity = 0.05f, float _durration = 1f)
		{
		}

		public void UnityFogDensity(float _density)
		{
		}

		public void BUTTON_QUICKPLAY()
		{
		}

		public void BUTTON_PLAYNEWGAME()
		{
		}

		public void BUTTON_PLAYHUB()
		{
		}

		public void BUTTON_PLAYCONTINUE()
		{
		}

		[AsyncStateMachine(typeof(_003CLoadAvatarFromSaveDataAsync_003Ed__62))]
		public UniTask LoadAvatarFromSaveDataAsync()
		{
			return default(UniTask);
		}

		private void SetPreviewMesh(AvatarCrate crate)
		{
		}

		public void PLAYMENUMUSIC(int song = 0)
		{
		}

		private void OnDestroy()
		{
		}
	}
}
