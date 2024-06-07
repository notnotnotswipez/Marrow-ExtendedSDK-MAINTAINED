using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Interaction;
using SLZ.Marrow.Interaction;
using SLZ.Marrow.Pool;
using SLZ.SFX;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class AntiGravCup : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CKinematicSet_003Ed__26 : IEnumerator<object>, IEnumerator, IDisposable
		{

			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public AntiGravCup _003C_003E4__this;

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

			[DebuggerHidden]
			public _003CKinematicSet_003Ed__26(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}



			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			public bool MoveNext()
			{
				throw new NotImplementedException();
			}

			public void Reset()
			{
				throw new NotImplementedException();
			}

			public object Current { get; }

			object IEnumerator.Current => Current;

			public void Dispose()
			{
				throw new NotImplementedException();
			}
		}

		[Header("Options")]
		public bool antiGravity;

		public float radius;

		public Vector3 halfExtents;

		public LayerMask effectedLayers;

		[Header("References")]
		public Grip triggerGrip;

		public Grip secondaryTriggerGrip;

		public Transform cupSurfaceTransform;

		private Collider[] colliders;

		private Rigidbody rb;

		private MarrowJoint joint;

		private GravGunSFX _sfx;

		private Coroutine _kinematic;

		private bool _triggerHeld;

		private bool _toggleGrab;

		private bool _blockRegrab;

		private bool _rbMounted;

		private Poolee _poolee;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void Start()
		{
		}

		private void OnRelease(GameObject despawnedObject)
		{
		}

		private void Update()
		{
		}

		private void OneHandedUpdate()
		{
		}

		private void TwoHandedUpdate()
		{
		}

		private void CheckForAttachment()
		{
		}

		private void AttachJoint(Rigidbody connectedBody, Vector3 impactPosition)
		{
		}

		[IteratorStateMachine(typeof(_003CKinematicSet_003Ed__26))]
		private IEnumerator KinematicSet()
		{
			return null;
		}
	}
}
