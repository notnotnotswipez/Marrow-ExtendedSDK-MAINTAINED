using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

namespace SLZ.Bonelab
{
	public class CartMultiStop : MonoBehaviour
	{
		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CCoMoveTargetTransform_003Ed__12 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public CartMultiStop _003C_003E4__this;

			public int floor;

			public CancellationToken cts;

			private Vector3 _003CstartPos_003E5__2;

			private float _003Cdist_003E5__3;

			private float _003Ctime_003E5__4;

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

		[Header("Options")]
		public float maxSpeed;

		public AudioClip startClip;

		public AudioClip stopClip;

		[Header("References")]
		public Transform[] floorTransforms;

		public ConfigurableJoint joint;

		public Rigidbody rb;

		public UnityEvent StopAction;

		private int goalFloor;

		private CancellationTokenSource loopToken;

		private Vector3 targetPosition;

		public void Reset()
		{
		}

		public void Awake()
		{
		}

		[AsyncStateMachine(typeof(_003CCoMoveTargetTransform_003Ed__12))]
		private UniTaskVoid CoMoveTargetTransform(int floor, CancellationToken cts)
		{
			return default(UniTaskVoid);
		}

		public void Go(int floor)
		{
		}

		public void GoForward()
		{
		}

		public void GoBackward()
		{
		}
	}
}
