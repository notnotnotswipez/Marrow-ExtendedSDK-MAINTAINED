using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Bonelab;
using SLZ.Bonelab.SaveData;
using SLZ.Marrow;
using SLZ.Marrow.Data;
using SLZ.Marrow.Warehouse;
using UnityEngine;
using UnityEngine.Events;

namespace SLZ.Props
{
	public class GachaCapsule : MonoBehaviour
	{
		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CPopFXAsync_003Ed__51 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public GachaCapsule _003C_003E4__this;

			public Spawnable effect;

			private void MoveNext()
			{
			}

            void IAsyncStateMachine.MoveNext()
            {
                throw new NotImplementedException();
            }

            [DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

            void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
                throw new NotImplementedException();
            }
        }

		[CompilerGenerated]
		private sealed class _003CDespawnTimmer_003Ed__52 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public GachaCapsule _003C_003E4__this;

			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

            public object Current => throw new NotImplementedException();

            [DebuggerHidden]
			public _003CDespawnTimmer_003Ed__52(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

            bool IEnumerator.MoveNext()
            {
                throw new NotImplementedException();
            }

            public void Reset()
            {
                throw new NotImplementedException();
            }

            public void Dispose()
            {
                throw new NotImplementedException();
            }
        }

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CSetPreviewMesh_003Ed__54 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public GachaCapsule _003C_003E4__this;

			private void MoveNext()
			{
			}

            void IAsyncStateMachine.MoveNext()
            {
                throw new NotImplementedException();
            }

            [DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

            void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
                throw new NotImplementedException();
            }
        }

		public SphereGrip grip;

		public ObjectDestructible objDestruct;

		public GenericCrateReference selectedCrate;

		public Transform previewMeshPosition;

		public Transform previewMeshSpin;

		public Transform previewMeshRock;

		public MeshFilter previewBounds;

		public MeshFilter previewMesh;

		public Transform previewPoint;

		public float previewMeshScaleTune;

		public float previewMeshSpinSpeed;

		public float previewMeshRockSpeed;

		public float previewMeshRockAmp;

		public AnimationCurve hapticsCurve;

		[SerializeField]
		[Range(0f, 1f)]
		private float amplitudeMin;

		[SerializeField]
		[Range(0f, 1f)]
		private float amplitudeMax;

		[SerializeField]
		[Range(0f, 2000f)]
		private float frequencyMin;

		[Range(0f, 2000f)]
		[SerializeField]
		private float frequencyMax;

		[SerializeField]
		private float separationMin;

		[SerializeField]
		private float separationMax;

		[SerializeField]
		private float lengthMin;

		[SerializeField]
		private float lengthMax;

		public float unlockDistance;

		public bool isAvatarGacha;

		[HideInInspector]
		public BonelabAvatarLevelGameControl gameControl;

		public UnityEvent gachaPopEvent;

		[SerializeField]
		private Spawnable vfxSpawnable;

		public Transform vfxPoint;

		public ParticleSystem arrowParticleSystem;

		private float time;

		private float lastHapticTime;

		private bool used;

		private InteractableHost host;

		[HideInInspector]
		public SpawnableCrate previewMeshCrate;

		private Hand lastHand;

		private Vector3 popPos;

		private Quaternion popRot;

		private bool doubleSpawnProtection;

		private static PlayerUnlocks u => null;

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

		private void OnHandAttachedUpdate(Hand hand)
		{
		}

		private void OnHandAttached(Hand hand)
		{
		}

		private void OnHandDetached(Hand hand)
		{
		}

		public void UnlockItemDest()
		{
		}

		private void UnlockItem()
		{
		}

		private void SendGachaToPullCord(PullCordDevice pcd)
		{
		}

		public void POPFX(Spawnable effect)
		{
		}

		[AsyncStateMachine(typeof(_003CPopFXAsync_003Ed__51))]
		private UniTaskVoid PopFXAsync(Spawnable effect)
		{
			return default(UniTaskVoid);
		}

		[IteratorStateMachine(typeof(_003CDespawnTimmer_003Ed__52))]
		private IEnumerator DespawnTimmer()
		{
			return null;
		}

		private void ReleasePreviewMesh()
		{
		}

		[AsyncStateMachine(typeof(_003CSetPreviewMesh_003Ed__54))]
		public UniTaskVoid SetPreviewMesh()
		{
			return default(UniTaskVoid);
		}
	}
}
