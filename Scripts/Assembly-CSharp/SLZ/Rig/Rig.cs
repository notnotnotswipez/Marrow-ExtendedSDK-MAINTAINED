using SLZ.Marrow.Utilities;
using SLZ.VRMK;
using UnityEngine;

namespace SLZ.Rig
{
	public class Rig : MonoBehaviour
	{
		public RigManager manager;

		[Header("Rig")]
		public Transform m_head;

		public Transform m_jaw;

		public Transform m_neck;

		public Transform m_chest;

		public Transform m_spine;

		public Transform m_pelvis;

		public Transform m_clavLf;

		public Transform m_shoulderLf;

		public Transform m_elbowLf;

		public Transform m_handLf;

		public Transform m_clavRt;

		public Transform m_shoulderRt;

		public Transform m_elbowRt;

		public Transform m_handRt;

		public Transform m_hipLf;

		public Transform m_kneeLf;

		public Transform m_footLf;

		public Transform m_hipRt;

		public Transform m_kneeRt;

		public Transform m_footRt;

		public Transform centerOfPressure;

		public Vector4 eyeGaze;

		protected SLZ.VRMK.Avatar _avatar;

		protected BodyPose _bodyPose;

		private RigWeights _rigWeights;

		public SLZ.VRMK.Avatar avatar => null;

		public BodyPose bodyPose
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public RigWeights rigWeights
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public virtual void Reset()
		{
		}

		public virtual void OnAwake()
		{
		}

		public virtual void OnRigEnable(bool reEnable)
		{
		}

		public virtual void OnStart()
		{
		}

		public virtual void OnEarlyUpdate()
		{
		}

		public virtual void OnFixedUpdate(float deltaTime)
		{
		}

		public virtual void OnAfterFixedUpdate()
		{
		}

		public virtual void OnUpdate()
		{
		}

		public virtual void OnLateUpdate()
		{
		}

		public virtual void OnRigDisable()
		{
		}

		public virtual void Teleport(SimpleTransform displace, bool zeroVelocity = false)
		{
		}

		public virtual void SetAvatar(SLZ.VRMK.Avatar avatar)
		{
		}

		protected Vector3 Gimbal(Vector3 target, ref Vector3 lastTarget, ref Vector3 gimbaledVelocity, ref Vector3 gimbalAccel, ref Vector3 gimbleOffset, float lerpRate, float deltaTime, float maxOffset = float.MaxValue, float smoothTime = 0.1f)
		{
			return default(Vector3);
		}

		protected float Gimbal(float target, ref float lastTarget, ref float gimbaledVelocity, ref float gimbalAccel, ref float gimbleOffset, float lerpRate, float deltaTime, float maxOffset = float.MaxValue, float smoothTime = 0.1f)
		{
			return 0f;
		}

		public bool PointInNeutralTorso(Vector3 pointLocalToSternum, SLZ.VRMK.Avatar avatar, out float t, out float yPercRemapped, out Vector2 sin, out Vector3 pointLocal, out Vector3 maxSoftDisplacement)
		{
			t = default(float);
			yPercRemapped = default(float);
			sin = default(Vector2);
			pointLocal = default(Vector3);
			maxSoftDisplacement = default(Vector3);
			return false;
		}

		public void SampleRigPose(ref Quaternion[] rigPose)
		{
		}

		public void BlendToSampledRigPose(Quaternion[] rigPose, float t)
		{
		}
	}
}
