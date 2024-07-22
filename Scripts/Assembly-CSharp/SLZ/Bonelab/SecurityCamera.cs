using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Marrow.Interaction;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class SecurityCamera : MonoBehaviour, IMarrowEntityCullable
	{
		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CIndicateSaveAsync_003Ed__24 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public SecurityCamera _003C_003E4__this;

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

		[Header("Camera Body")]
		public MarrowEntity entity;

		public Rigidbody cameraRb;

		public float cameraUpdateDot;

		public float cameraMoveSpeed;

		[Header("Camera FX")]
		public AudioClip cameraFlashSFX;

		public GameObject flashCone;

		public float flashActiveTime;

		public ParticleSystem particles;

		[Tooltip("The material to assign on save start")]
		public Material material;

		[Tooltip("Assumes there is only one material on each renderer and that it will be swapped to the new material")]
		public MeshRenderer[] renderers;

		private Quaternion lastGoalRot;

		private Quaternion goalRot;

		private Vector3 goalVec;

		private float lastoffsetDot;

		private float timeTick;

		private float lerpTime;

		private float offsetDot;

		private bool firstLoop;

		private void Reset()
		{
		}

		private void Awake()
		{
		}

		public void OnEntityCull()
		{
		}

		public void OnEntityUncull()
		{
		}

		private void Update()
		{
		}

		public void IndicateSave()
		{
		}

		[AsyncStateMachine(typeof(_003CIndicateSaveAsync_003Ed__24))]
		public UniTaskVoid IndicateSaveAsync()
		{
			return default(UniTaskVoid);
		}
	}
}
