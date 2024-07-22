using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class ConeOfVision_Turret : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CCoVisionCheck_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ConeOfVision_Turret _003C_003E4__this;

			private int _003Ccount_003E5__2;

			private float _003CclosestDistanceSqr_003E5__3;

			private Collider _003CtargetCollider_003E5__4;

			private int _003Ci_003E5__5;

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
			public _003CCoVisionCheck_003Ed__19(int _003C_003E1__state)
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

		private Collider[] m_CollectedColliders;

		private Collider[] m_SortedColliders;

		private int m_MaxCollidersCollected;

		private int m_CoolidersCount;

		public float visionRadius;

		public float visionAngle;

		public Enemy_Turret turret;

		public LayerMask mask;

		[ColorUsage(true, true)]
		public Color idleColor;

		[ColorUsage(true, true)]
		public Color aggroColor;

		public Transform acquiredTarget;

		private Coroutine visionCheckCoroutine;

		public bool IsOverlapping
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		private void Awake()
		{
		}

		private void Update()
		{
		}

		private void VisionCheck()
		{
		}

		[IteratorStateMachine(typeof(_003CCoVisionCheck_003Ed__19))]
		private IEnumerator CoVisionCheck()
		{
			return null;
		}

		public void OnVisionEnter(Transform target)
		{
		}

		public void OnVisionExit()
		{
		}
	}
}
