using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SLZ.Bonelab.Obsolete
{
	public class GarageDoorPowerable : Powerable
	{
		public enum MOVINGSTATE
		{
			UP = 0,
			DOWN = 1,
			STOPPED_UP = 2,
			STOPPED_DOWN = 3
		}

		[CompilerGenerated]
		private sealed class _003CCoMoveUp_003Ed__34 : IEnumerator<object>, IEnumerator, IDisposable
		{

			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public GarageDoorPowerable _003C_003E4__this;

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
			public _003CCoMoveUp_003Ed__34(int _003C_003E1__state)
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

		[CompilerGenerated]
		private sealed class _003CCoMoveDown_003Ed__35 : IEnumerator<object>, IEnumerator, IDisposable
		{

			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public GarageDoorPowerable _003C_003E4__this;

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
			public _003CCoMoveDown_003Ed__35(int _003C_003E1__state)
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

		[Header("GARAGE REFS")]
		[Space(5f)]
		public bool isBinary;

		public GameObject GarageDoorParent;

		public Transform GarageTop;

		public Transform GarageBottom;

		[Space(5f)]
		[Header("MOVERATE")]
		[Range(0.005f, 0.015f)]
		[Tooltip("Used for the non-binary mode")]
		public float MinMoveRate;

		[Range(0.005f, 0.02f)]
		[Tooltip("Used for the non-binary mode")]
		public float MaxMoveRate;

		[Range(0.01f, 0.015f)]
		[Tooltip("Used when in binary mode")]
		public float ConstantMoveRate;

		[Range(75f, 200f)]
		[Tooltip("Speed multiplier to make sure movement rate is noticable")]
		public float Speed;

		[Range(0f, 0.2f)]
		[Header("Voltage Offset")]
		[Space(5f)]
		public float lowerOffSet;

		[Range(0f, 0.8f)]
		public float higherOffset;

		[Space(5f)]
		[Range(-1f, 1f)]
		public float min_InputVoltage;

		[Range(-1f, 1f)]
		public float max_InputVoltage;

		[Space(5f)]
		public float min_TargetVoltage;

		public float max_TargetVoltage;

		private float m_currVoltage;

		[Space(10f)]
		[Header("DEBUG")]
		public bool isDebugging;

		private float stored_Draw;

		private MOVINGSTATE m_moveState;

		private Coroutine MoveUp;

		private Coroutine MoveDown;

		private bool isCoRunning;

		public MOVINGSTATE MoveState
		{
			get
			{
				return default(MOVINGSTATE);
			}
			set
			{
			}
		}

		private void Start()
		{
		}

		public override void SwitchPowerOnOff(bool isOn)
		{
		}

		public override void VoltageToObject(float voltage, int id = 0)
		{
		}

		private void SetFloatGarageMove(float voltage)
		{
		}

		private void StopMoving()
		{
		}

		public void StopGarageDoorBttn()
		{
		}

		private void UpGargeDoorBttn()
		{
		}

		private void DownGarageDoorBttn()
		{
		}

		public void ContinueMovement()
		{
		}

		[IteratorStateMachine(typeof(_003CCoMoveUp_003Ed__34))]
		private IEnumerator CoMoveUp()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CCoMoveDown_003Ed__35))]
		private IEnumerator CoMoveDown()
		{
			return null;
		}

		private float SetMoveRate(float Voltage, bool up)
		{
			return 0f;
		}
	}
}
