using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SwingJointInverter : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CStartSequence_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SwingJointInverter _003C_003E4__this;

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
		public _003CStartSequence_003Ed__19(int _003C_003E1__state)
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

	public ConfigurableJoint configJoint;

	private JointDrive tempMotor;

	[SerializeField]
	private Rigidbody rb;

	public SwingJointManager sjm;

	public float base_slerp_spring;

	public float angle;

	public float limit_min;

	public float limit_max;

	public float vel;

	public float force_mod;

	public float damper_max;

	public float buffer_degrees;

	public float init_deg;

	public float delay_time;

	public bool hold;

	public void ToZero()
	{
	}

	public void ToTarget()
	{
	}

	public void SetRot()
	{
	}

	private void OnEnable()
	{
	}

	[IteratorStateMachine(typeof(_003CStartSequence_003Ed__19))]
	public IEnumerator StartSequence()
	{
		return null;
	}

	private void SetBaseSpring()
	{
	}

	private float EucNorm(float val)
	{
		return 0f;
	}

	private float MinMaxPolar(float val)
	{
		return 0f;
	}

	private void CheckTargetSwitch()
	{
	}

	private void FixedUpdate()
	{
	}
}
