using SLZ.Interaction;
using SLZ.VRMK;
using UnityEngine;

namespace SLZ.Rig
{
	public class PhysTorso : MonoBehaviour
	{
		[SerializeField]
		private float _spineForceMult;

		[SerializeField]
		private float _spineInternalMult;

		public bool shutdown;

		[SerializeField]
		public float _linearDamperMult;

		[SerializeField]
		public float _slerpDamperMult;

		private float _lastLinearDamperMult;

		private float _lastSlerpDamperMult;

		private float _lastSpineForceMult;

		[SerializeField]
		private Rigidbody _headRb;

		[SerializeField]
		private Rigidbody _neckRb;

		[SerializeField]
		private Rigidbody _chestRb;

		[SerializeField]
		private Rigidbody _spineRb;

		[SerializeField]
		private Rigidbody _pelvisRb;

		[SerializeField]
		private Servo _headChestServo;

		[SerializeField]
		private Servo _headPelServo;

		[SerializeField]
		private Servo _chestPelServo;

		[SerializeField]
		private Servo _headNeckServo;

		[SerializeField]
		private Servo _neckChestServo;

		[SerializeField]
		private Servo _chestSpineServo;

		[SerializeField]
		private Servo _spinePelServo;

		public MeshCollider cPelvis;

		public MeshCollider cSpineLow;

		public MeshCollider cSpine;

		public MeshCollider cChest;

		public MeshCollider cHead;

		public CapsuleCollider neckCol;

		public Grip gPelvis;

		public Grip gSpine;

		public Grip gChest;

		public Grip gHead;

		public CylinderGrip gNeck;

		[SerializeField]
		private PhysicMaterial _naturalFriction;

		[SerializeField]
		private PhysicMaterial _lowFriction;

		public float spineInternalMult
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public Rigidbody rbHead => null;

		public Rigidbody rbNeck => null;

		public Rigidbody rbChest => null;

		public Rigidbody rbSpine => null;

		public Rigidbody rbPelvis => null;

		public void OnAwakeInitialize()
		{
		}

		public void CalibrateTorsoColliders(SLZ.VRMK.Avatar avatar)
		{
		}

		public void CalibrateJoints(SLZ.VRMK.Avatar avatar)
		{
		}

		public void CalibrateTorsoGrips(SLZ.VRMK.Avatar avatar)
		{
		}

		public void EarlyUpdateSpineJoints()
		{
		}

		public void UpdateSpineTargets(Rig inRig, float deltaTime)
		{
		}

		public void UpdateSpineDrives(float slerpForceMult, float slerpSpringMult, float slerpDampMult, float linearForceMult, float linearSpringMult, float linearDampMult)
		{
		}

		public void ZeroTargets()
		{
		}

		public void SetTorsoMass(float torsoMass)
		{
		}

		public Vector3 GetTorsoMomentum(out float totalMass)
		{
			totalMass = default(float);
			return default(Vector3);
		}

		public void IgnoreWholeTorsoColliders(Collider collider, bool ignore = true)
		{
		}

		public void IgnoreWholeTorsoColliders(Collider[] collider, bool ignore = true)
		{
		}

		public void SetFrictionNatural()
		{
		}

		public void SetFrictionLow()
		{
		}
	}
}
