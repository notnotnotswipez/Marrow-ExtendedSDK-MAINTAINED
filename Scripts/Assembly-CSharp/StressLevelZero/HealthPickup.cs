using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Bonelab;
using SLZ.Marrow;
using SLZ.Marrow.Pool;
using UnityEngine;

namespace StressLevelZero
{
	public class HealthPickup : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CCoSetCollectable_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public HealthPickup _003C_003E4__this;

			public bool collect;

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
			public _003CCoSetCollectable_003Ed__19(int _003C_003E1__state)
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

		[CompilerGenerated]
		private sealed class _003CCoCollectAnimation_003Ed__27 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public HealthPickup _003C_003E4__this;

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
			public _003CCoCollectAnimation_003Ed__27(int _003C_003E1__state)
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

		[CompilerGenerated]
		private sealed class _003CCoTimedDespawn_003Ed__29 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float t;

			public HealthPickup _003C_003E4__this;

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
			public _003CCoTimedDespawn_003Ed__29(int _003C_003E1__state)
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

		public float healthPerc;

		[SerializeField]
		private AudioClip spawnAudioClip;

		[SerializeField]
		private AudioClip collectAudioClip;

		[SerializeField]
		private InteractableHost host;

		[SerializeField]
		private SphereCollider _col;

		[SerializeField]
		private WeaponSlot wSlot;

		[SerializeField]
		private MeshRenderer _rend;

		[SerializeField]
		private GameObject parentObj;

		[SerializeField]
		private GameObject artObj;

		public Poolee poolee;

		public Arena_GameController agc;

		private float despawnDelay;

		private Coroutine timerRoutine;

		private bool _isCollected;

		public SphereGrip sphereGrip;

		public bool isCollectable;

		public bool GetCollectionState()
		{
			return false;
		}

		public void SetCollectable(bool collect)
		{
		}

		public void SetCollectableDelayed(bool collect)
		{
		}

		[IteratorStateMachine(typeof(_003CCoSetCollectable_003Ed__19))]
		private IEnumerator CoSetCollectable(bool collect)
		{
			return null;
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnTriggerStay(Collider other)
		{
		}

		private void OnTriggerEnter(Collider other)
		{
		}

		public void SpawnAudio()
		{
		}

		public void SetSmallState()
		{
		}

		public void SetLargeState()
		{
		}

		[IteratorStateMachine(typeof(_003CCoCollectAnimation_003Ed__27))]
		private IEnumerator CoCollectAnimation()
		{
			return null;
		}

		public void InitTimer()
		{
		}

		[IteratorStateMachine(typeof(_003CCoTimedDespawn_003Ed__29))]
		private IEnumerator CoTimedDespawn(float t)
		{
			return null;
		}

		private void OnAddInventory()
		{
		}

		private void OnRemoveInventory()
		{
		}

		public void DespawnFX()
		{
		}

		public void OnDespawn(GameObject go)
		{
		}
	}
}
