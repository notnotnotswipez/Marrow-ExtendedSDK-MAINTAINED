using System;
using UnityEngine;

namespace SLZ.Bonelab.Obsolete
{
	[Obsolete("OLD POWERABLE SYSTEM - DO NOT USE!")]
	[AddComponentMenu(null)]
	public class Powerable_Joint : Powerable
	{
		[Header("VOLTAGE")]
		public bool isBinary;

		[Space(5f)]
		[Range(-1f, 1f)]
		public float cur_InputVoltage;

		private float att_Voltage;

		public float bufferAtt_Voltage;

		[Range(-1f, 1f)]
		[Space(5f)]
		public float min_InputVoltage;

		[Range(-1f, 1f)]
		public float max_InputVoltage;

		[SerializeField]
		private bool _warpOnStart;

		[Space(5f)]
		[Header("PRISMATIC JOINT CONTROL")]
		[SerializeField]
		private bool _varyTargetPosition;

		[SerializeField]
		private bool _targetPositionAddative;

		[SerializeField]
		private float _additiveTargetPosMultiplier;

		[SerializeField]
		private Vector3 _minPosition;

		[SerializeField]
		private Vector3 _maxPosition;

		[SerializeField]
		private bool _varyTargetVelocity;

		[SerializeField]
		private Vector3 _minVelocity;

		[SerializeField]
		private Vector3 _maxVelocity;

		[SerializeField]
		private bool _varyPrismaticDrive;

		[SerializeField]
		private Vector3 _xMinSpringDamperForce;

		[SerializeField]
		private Vector3 _xMaxSpringDamperForce;

		[SerializeField]
		private bool _varyPrismaticY;

		[SerializeField]
		private Vector3 _yMinSpringDamperForce;

		[SerializeField]
		private Vector3 _yMaxSpringDamperForce;

		[SerializeField]
		private bool _varyPrismaticZ;

		[SerializeField]
		private Vector3 _zMinSpringDamperForce;

		[SerializeField]
		private Vector3 _zMaxSpringDamperForce;

		[Header("ANGULAR JOINT CONTROL")]
		[SerializeField]
		private bool _varyTargetRotation;

		[SerializeField]
		private float _minDegreesX;

		[SerializeField]
		private float _maxDegreesX;

		[SerializeField]
		private bool _varyTargetAngVelocity;

		[SerializeField]
		private Vector3 _minAngVelocity;

		[SerializeField]
		private Vector3 _maxAngVelocity;

		[SerializeField]
		private bool _varyAngularDrive;

		[SerializeField]
		private Vector3 _xAngMinSpringDamperForce;

		[SerializeField]
		private Vector3 _xAngMaxSpringDamperForce;

		[SerializeField]
		private ConfigurableJoint jnt_this;

		private Rigidbody rb_this;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		public override void SwitchPowerOnOff(bool isOn)
		{
		}

		public void ToggleVoltage()
		{
		}

		public override void VoltageToObject(float voltage, int id = 0)
		{
		}

		private void SETJOINT(float voltage = 1f)
		{
		}

		private void WarpJoint()
		{
		}
	}
}
