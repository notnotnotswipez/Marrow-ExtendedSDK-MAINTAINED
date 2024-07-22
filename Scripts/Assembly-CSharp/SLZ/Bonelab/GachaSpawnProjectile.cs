using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Marrow.Data;
using SLZ.Marrow.Pool;
using UnityEngine;
using YieldAwaitable = Cysharp.Threading.Tasks.YieldAwaitable;

namespace SLZ.Bonelab
{
	public class GachaSpawnProjectile : SpawnEvents
	{
		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CAsyncSpawnProcedure_003Ed__8 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public GachaSpawnProjectile _003C_003E4__this;

			private float _003Ctime_003E5__2;

			private float _003CcurTime_003E5__3;

			private Vector3 _003CtargetVelocity_003E5__4;

			private Vector3 _003CtargetAngVelocity_003E5__5;

			private YieldAwaitable.Awaiter _003C_003Eu__1;

			private UniTask<Poolee>.Awaiter _003C_003Eu__2;

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

		public Rigidbody rb;

		public Spawnable spawnable;

		public MeshFilter previewMeshFilter;

		public Transform previewMeshTransform;

		public float startScale;

		public CurveData growAnim;

		private void OnDisable()
		{
		}

		public override void OnPoolInitialize()
		{
		}

		[AsyncStateMachine(typeof(_003CAsyncSpawnProcedure_003Ed__8))]
		private UniTaskVoid AsyncSpawnProcedure()
		{
			return default(UniTaskVoid);
		}
	}
}
