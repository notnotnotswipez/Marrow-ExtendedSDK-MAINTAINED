using SLZ.Interaction;
using SLZ.VRMK;
using UnityEngine;

namespace SLZ.Rig
{
	public class PhysSoftBody : MonoBehaviour
	{
		[SerializeField]
		private Rigidbody _armUpperLfRb;

		[SerializeField]
		private Rigidbody _armUpperRtRb;

		[SerializeField]
		private Rigidbody _forearmLfRb;

		[SerializeField]
		private Rigidbody _forearmRtRb;

		[SerializeField]
		private Rigidbody _breastLfRb;

		[SerializeField]
		private Rigidbody _breastRtRb;

		[SerializeField]
		private Rigidbody _abdomenLfRb;

		[SerializeField]
		private Rigidbody _abdomenRtRb;

		[SerializeField]
		private Rigidbody _groinLfRb;

		[SerializeField]
		private Rigidbody _groinRtRb;

		[SerializeField]
		private Rigidbody _buttLfRb;

		[SerializeField]
		private Rigidbody _buttRtRb;

		[SerializeField]
		private Rigidbody _thighLfRb;

		[SerializeField]
		private Rigidbody _thighRtRb;

		[SerializeField]
		private Rigidbody _softHandLfRb;

		[SerializeField]
		private Rigidbody _softHandRtRb;

		public Rigidbody headBridge;

		public Rigidbody chestBridge;

		public Rigidbody shoulderLfBridge;

		public Rigidbody shoulderRtBridge;

		public Rigidbody elbowLfBridge;

		public Rigidbody elbowRtBridge;

		public Rigidbody spineBridge;

		public Rigidbody pelvisBridge;

		public Rigidbody handLfBridge;

		public Rigidbody handRtBridge;

		public Rigidbody hipLfBridge;

		public Rigidbody hipRtBridge;

		public BoxCollider cHandLf;

		public BoxCollider cHandRt;

		public MeshCollider cUpperarmLf;

		public MeshCollider cUpperarmRt;

		public MeshCollider cforearmLf;

		public MeshCollider cforearmRt;

		public MeshCollider cBreastLf;

		public MeshCollider cBreastRt;

		public MeshCollider cButt_Lf;

		public MeshCollider cButt_Rt;

		public MeshCollider cThighLf;

		public MeshCollider cThighRt;

		[SerializeField]
		private Servo _upperArmLfServo;

		[SerializeField]
		private Servo _upperArmRtServo;

		[SerializeField]
		private Servo _forearmLfServo;

		[SerializeField]
		private Servo _forearmRtServo;

		[SerializeField]
		private Servo _breastLfServo;

		[SerializeField]
		private Servo _breastRtServo;

		[SerializeField]
		private Servo _abdomenLfServo;

		[SerializeField]
		private Servo _abdomenRtServo;

		[SerializeField]
		private Servo _groinLfServo;

		[SerializeField]
		private Servo _groinRtServo;

		[SerializeField]
		private Servo _buttLfServo;

		[SerializeField]
		private Servo _buttRtServo;

		[SerializeField]
		private Servo _thighLfServo;

		[SerializeField]
		private Servo _thighRtServo;

		[SerializeField]
		private Servo _deltoidLf;

		[SerializeField]
		private Servo _deltoidRt;

		[SerializeField]
		private Servo _forearmTwistLf;

		[SerializeField]
		private Servo _forearmTwistRt;

		[SerializeField]
		private SpringJoint _pectoralisLf;

		[SerializeField]
		private SpringJoint _pectoralisRt;

		[SerializeField]
		private Servo _gluteusLf;

		[SerializeField]
		private Servo _gluteusRt;

		public Rigidbody rbArmUpperLf => null;

		public Rigidbody rbArmUpperRt => null;

		public Rigidbody rbForearmLf => null;

		public Rigidbody rbForearmRt => null;

		public Rigidbody rbBreastLf => null;

		public Rigidbody rbBreastRt => null;

		public Rigidbody rbAbdomenLf => null;

		public Rigidbody rbAbdomenRt => null;

		public Rigidbody rbGroinLf => null;

		public Rigidbody rbGroinRt => null;

		public Rigidbody rbButtLf => null;

		public Rigidbody rbButtRt => null;

		public Rigidbody rbThighLf => null;

		public Rigidbody rbThighRt => null;

		public Rigidbody rbSoftHandLf => null;

		public Rigidbody rbSoftHandRt => null;

		public void OnAwakeInitialize()
		{
		}

		public void CalibrateTorsoColliders(SLZ.VRMK.Avatar avatar, PhysicsRig physRig)
		{
		}

		public void CalibrateJoints(SLZ.VRMK.Avatar avatar)
		{
		}

		public void UpdateKinematicBridges(PhysicsRig inRig)
		{
		}
	}
}
