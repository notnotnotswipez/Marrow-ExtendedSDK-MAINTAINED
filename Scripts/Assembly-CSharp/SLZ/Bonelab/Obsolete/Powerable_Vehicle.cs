using UnityEngine;

namespace SLZ.Bonelab.Obsolete
{
	public class Powerable_Vehicle : Powerable
	{
		[Header("VOLTAGE")]
		public bool isBinary;

		[Space(5f)]
		[Range(-1f, 1f)]
		public float cur_InputVoltage;

		private float att_Voltage;

		[Space(5f)]
		[Range(-1f, 1f)]
		public float min_InputVoltage;

		[Range(-1f, 1f)]
		public float max_InputVoltage;

		[Space(5f)]
		public float min_TargetVoltage;

		public float max_TargetVoltage;

		[SerializeField]
		[Header("MOTOR CONTROL")]
		[Space(5f)]
		private float m_TargetVelocity;

		[SerializeField]
		private float m_MaxForce;

		[SerializeField]
		private float m_PositionDamper;

		public ConfigurableJoint jnt_to_rotate;

		private float stored_Draw;

		private float _totalVoltage;

		private bool _joystickRecieved;

		private Vector3 _joystickVel;

		private Vector3 _joystickForwardWorld;

		private void Start()
		{
		}

		public override void SwitchPowerOnOff(bool isOn)
		{
		}

		public override void VoltageToObject(float voltage, int id = 0)
		{
		}

		public override void Vector2InputToObject(Vector2 xyLocal, int id = 0)
		{
		}

		public void JOYSTICK(PropJoystick.JoystickData joyData)
		{
		}

		public float GetAttenuatedVoltage(int id = 0)
		{
			return 0f;
		}

		public Vector3 GetJoystickWorld(int id = 0)
		{
			return default(Vector3);
		}

		public float GetTotalVoltage()
		{
			return 0f;
		}

		public int GetTotalPowerSources()
		{
			return 0;
		}

		private void SETJOINT(float voltage = 1f)
		{
		}
	}
}
