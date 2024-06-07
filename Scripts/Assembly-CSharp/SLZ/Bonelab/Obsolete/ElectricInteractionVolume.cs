using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Interaction;
using UnityEngine;

namespace SLZ.Bonelab.Obsolete
{
	[AddComponentMenu(null)]
	[Obsolete("Superseded by VoidLogic")]
	public class ElectricInteractionVolume : InteractionVolume
	{
		[CompilerGenerated]
		private sealed class _003CCoElectricInteractionCooldown_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
		{

			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ElectricInteractionVolume _003C_003E4__this;

			public bool isInserted;

			public IGrippable host;

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
			public _003CCoElectricInteractionCooldown_003Ed__22(int _003C_003E1__state)
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

		public Transform targetPos;

		public Collider[] recieverColliders;

		public AudioClip[] insertClips;

		public AudioClip[] removeClips;

		public float volume;

		private bool m_isElectricInserted;

		[Space(10f)]
		[SerializeField]
		[Tooltip("The type of electronic this object takes")]
		private List<PowerSourceType> m_acceptedTypes;

		private PowerSocket m_powerSock;

		private PowerSource m_ps;

		private CylinderElectronicGrip m_cegHandle;

		private CylinderElectronicGrip m_cegBody;

		public static Action<ElectricInteractionVolume, IGrippable> OnVolumeChanged;

		public bool isElectricInserted => false;

		private void Start()
		{
		}

		private bool M_CanInsert(PowerSourceType type)
		{
			return false;
		}

		protected override void OnHoverStart(InteractableHost host)
		{
		}

		protected override void OnHoverEnd(InteractableHost host)
		{
		}

		protected override void OnHoverUpdate(InteractableHost host)
		{
		}

		private void M_InsertElectric(InteractableHost host)
		{
		}

		public void RemoveElectronic(IGrippable host, CylinderElectronicGrip grip)
		{
		}

		private void M_DestroyedPowerSource(InteractableHost host)
		{
		}

		[IteratorStateMachine(typeof(_003CCoElectricInteractionCooldown_003Ed__22))]
		private IEnumerator CoElectricInteractionCooldown(bool isInserted, IGrippable host)
		{
			return null;
		}

		private void DestroyedPSInteractionVolume()
		{
		}

		public void ExitInteractionVolume()
		{
		}
	}
}
