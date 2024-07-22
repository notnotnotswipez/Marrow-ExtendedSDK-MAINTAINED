using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Marrow.Data;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class SplashFX : MonoBehaviour
	{
		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CRegAsync_003Ed__6 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public SplashFX _003C_003E4__this;

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

		public float VelocityThreshold;

		public float ImpulseThreshold;

		public Spawnable SpawnableVFX;

		private void OnCollisionEnter(Collision collision)
		{
		}

		public void ImpactVFX(Collision collision)
		{
		}

		private void Awake()
		{
		}

		[AsyncStateMachine(typeof(_003CRegAsync_003Ed__6))]
		public UniTaskVoid RegAsync()
		{
			return default(UniTaskVoid);
		}
	}
}
