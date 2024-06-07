using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Interaction;
using SLZ.Marrow.Utilities;
using UnityEngine;

namespace SLZ.Bonelab.Obsolete
{
	public class CylinderElectronicGrip : CylinderGrip
	{
		[CompilerGenerated]
		private sealed class _003CCoAnimateTo_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
		{

			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public SimpleTransform from;

			public SimpleTransform to;

			public float duration;

			public Transform source;

			private float _003Ctime_003E5__2;

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
			public _003CCoAnimateTo_003Ed__13(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			public bool MoveNext()
			{
				return false;
			}

			public void Reset()
			{
				throw new NotImplementedException();
			}

			public object Current { get; }

			object IEnumerator.Current => Current;

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			bool IEnumerator.MoveNext()
			{
				return MoveNext();
			}

			public void Dispose()
			{
				throw new NotImplementedException();
			}
		}

		[HideInInspector]
		public ElectricInteractionVolume interactionVolume;

		[Tooltip("Reference to the body grip to sync up")]
		public CylinderElectronicGrip BodyGrip;

		[Tooltip("Reference to the handle grip to sync up")]
		public CylinderElectronicGrip HandleGrip;

		public Transform powerSourceTransform;

		public Transform insertTransform;

		public Transform ejectTransform;

		[Header("COMPATIBLE")]
		[SerializeField]
		private PowerSourceType m_currentType;

		public PowerSourceType CurrentType
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected override void Start()
		{
		}

		public override void OnAttachedToHand(Hand hand)
		{
		}

		public void AnimateInsert(Vector3 localPos)
		{
		}

		[IteratorStateMachine(typeof(_003CCoAnimateTo_003Ed__13))]
		private IEnumerator CoAnimateTo(Transform source, SimpleTransform from, SimpleTransform to, float duration = 0.1f)
		{
			return null;
		}

		public void AnimateEject()
		{
		}

		public void SetInsertVolume(ElectricInteractionVolume eVol)
		{
		}
	}
}
