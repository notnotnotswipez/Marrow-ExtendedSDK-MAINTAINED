using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Marrow.Data;
using SLZ.Marrow.Interaction;
using UnityEngine;
using UnityEngine.Events;

namespace SLZ.Bonelab
{
	public class ExtendedPrefabSpawner : MonoBehaviour
	{
		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CSpawnLoop_003Ed__26 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public ExtendedPrefabSpawner _003C_003E4__this;

			public float length;

			private float _003Ctime_003E5__2;

			private float _003ClastSpawn_003E5__3;

			private Cysharp.Threading.Tasks.YieldAwaitable.Awaiter _003C_003Eu__1;

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
		private struct _003CWaitForHibernation_003Ed__28 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public ExtendedPrefabSpawner _003C_003E4__this;

			private Cysharp.Threading.Tasks.YieldAwaitable.Awaiter _003C_003Eu__1;

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

		[Tooltip("Spawnable")]
		[SerializeField]
		private Spawnable[] spawnables;

		public bool spawnOnStart;

		public bool useSpawnEffect;

		public Vector3 spawnForce;

		public Vector3 spawnTorque;

		public Vector3 randomPositionVector;

		public Vector3 randomRotationVector;

		public bool randomForce;

		public Vector3 spawnForceLow;

		public Vector3 spawnForceHigh;

		public bool randomTorque;

		public Vector3 spawnTorqueLow;

		public Vector3 spawnTorqueHigh;

		public float frequencey;

		public bool useCoolDown;

		public bool useRestCoolDown;

		public UnityEvent spawnEvent;

		private float lastSpawnTime;

		private Rigidbody rb;

		private CancellationTokenSource spawnLoop;

		private MarrowEntity entity;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		public void StartSpawnLoop(float length = 10f)
		{
		}

		[ContextMenu("StartSpawnLoopContinuous")]
		public void StartSpawnLoopContinuous()
		{
		}

		[ContextMenu("StopSpawnLoop")]
		public void StartSpawnLoop()
		{
		}

		[AsyncStateMachine(typeof(_003CSpawnLoop_003Ed__26))]
		private UniTaskVoid SpawnLoop(float length, CancellationTokenSource cts)
		{
			return default(UniTaskVoid);
		}

		public void SpawnPrefab()
		{
		}

		[AsyncStateMachine(typeof(_003CWaitForHibernation_003Ed__28))]
		private UniTaskVoid WaitForHibernation()
		{
			return default(UniTaskVoid);
		}

		private void ApplyForce()
		{
		}
	}
}
