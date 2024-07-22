using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Bonelab.Obsolete;
using SLZ.Marrow;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class NavMeshDoor : MonoBehaviour
	{
		public enum DoorType
		{
			DoorA = 0,
			DoorB = 1,
			DoorC = 2,
			DoorD = 3,
			DoorE = 4
		}

		[CompilerGenerated]
		private sealed class _003CCoForceGarage_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float delay;

			public NavMeshDoor _003C_003E4__this;

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
			public _003CCoForceGarage_003Ed__10(int _003C_003E1__state)
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

		public DoorType doorType;

		[SerializeField]
		private bool isOpen;

		[SerializeField]
		private ObjectDestructible destructable;

		[SerializeField]
		private bool isDestructable;

		[SerializeField]
		private GarageDoor_Phys_Powerable garageDoor;

		[SerializeField]
		private bool forceOpenOnStart;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Start()
		{
		}

		[IteratorStateMachine(typeof(_003CCoForceGarage_003Ed__10))]
		private IEnumerator CoForceGarage(float delay)
		{
			return null;
		}

		private void ForceGarageDoorsOpen()
		{
		}

		private void OnDestructableBreak(ObjectDestructible dest)
		{
		}

		public void ToggleDoor()
		{
		}

		public void ToggleArea(bool open)
		{
		}
	}
}
