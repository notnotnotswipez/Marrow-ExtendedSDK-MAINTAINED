using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Marrow;
using SLZ.Marrow.Data;
using SLZ.Marrow.Pool;
using UnityEngine;
using UnityEngine.Events;

namespace SLZ.Bonelab
{
	public class GeoMover : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CCoMoveGeo_003Ed__31 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public bool moveUp;

			public GeoMover _003C_003E4__this;

			private float _003CstartTime_003E5__2;

			private float _003CendTime_003E5__3;

			private float _003ClerpVal_003E5__4;

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
			public _003CCoMoveGeo_003Ed__31(int _003C_003E1__state)
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
		private sealed class _003CCoIncrementalMove_003Ed__33 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public GeoMover _003C_003E4__this;

			private float _003CstartTime_003E5__2;

			private float _003CendTime_003E5__3;

			private float _003ClerpVal_003E5__4;

			private Vector3 _003CstartPos_003E5__5;

			private Vector3 _003CendPos_003E5__6;

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
			public _003CCoIncrementalMove_003Ed__33(int _003C_003E1__state)
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
		private sealed class _003CCoSpawnBoxForest_003Ed__36 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public bool spawnRand;

			public GeoMover _003C_003E4__this;

			private GameObject[] _003C_003E7__wrap1;

			private int _003C_003E7__wrap2;

			private GameObject _003Cobj_003E5__4;

			private int _003CstackCount_003E5__5;

			private int _003Ci_003E5__6;

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
			public _003CCoSpawnBoxForest_003Ed__36(int _003C_003E1__state)
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

		public GeoManager geoManager;

		public bool isDeathPit;

		public bool isFloor;

		public bool isDynamic;

		public bool isBoxForest;

		public float moveUpDuration;

		[SerializeField]
		private float moveDownDuration;

		public Vector3 startPos;

		[SerializeField]
		private Vector3 endPos;

		private Coroutine moveRoutine;

		[SerializeField]
		private Spawnable spawnable;

		[SerializeField]
		private GameObject[] spawnPointObjs;

		[SerializeField]
		private GameObject[] boxForestSpawnObjs;

		[SerializeField]
		private int randBoxCount;

		[SerializeField]
		private int maxStackCount;

		private int edgeMaxStackCount;

		private int edgeThresh;

		[SerializeField]
		private List<ObjectDestructible> destList;

		[SerializeField]
		private List<Poolee> pooleeList;

		private HashSet<int> boxHash;

		[SerializeField]
		private LayerMask boxLayerMask;

		[SerializeField]
		private List<SpawnableGroup> spawnableGroups;

		public UnityEvent onMoveUpComplete;

		public UnityEvent onStartMoveDown;

		[Header("TimerJointVals")]
		private float spring;

		private float damper;

		private float maxForce;

		private Vector3 targetAngVel;

		public ConfigurableJoint timberJoint;

		public void Awake()
		{
		}

		public void MoveGeo(bool moveUp)
		{
		}

		[IteratorStateMachine(typeof(_003CCoMoveGeo_003Ed__31))]
		private IEnumerator CoMoveGeo(bool moveUp)
		{
			return null;
		}

		[ContextMenu("IncrementalMove")]
		public void IncrementGeo()
		{
		}

		[IteratorStateMachine(typeof(_003CCoIncrementalMove_003Ed__33))]
		private IEnumerator CoIncrementalMove()
		{
			return null;
		}

		public void SpawnDestructables()
		{
		}

		public void ClearDestructables()
		{
		}

		[IteratorStateMachine(typeof(_003CCoSpawnBoxForest_003Ed__36))]
		private IEnumerator CoSpawnBoxForest(bool spawnRand = true)
		{
			return null;
		}

		[ContextMenu("GetBoxSpawns")]
		public void GetBoxSpawns()
		{
		}

		public void CreateTimberJoint(GameObject timber)
		{
		}

		public void CleanupJoint()
		{
		}
	}
}
