using SLZ.Marrow.Utilities;
using SLZ.VRMK;
using UnityEngine;

namespace SLZ.Rig
{
	public class HeptaRig : Rig
	{
		[SerializeField]
		[Header("HeptaRig")]
		protected AnimationCurve _t1UpOffsetCurve;

		[SerializeField]
		protected AnimationCurve _sacrumUpOffsetCurve;

		[SerializeField]
		protected AnimationCurve _neckTiltCurve;

		protected Vector3 _playerUp;

		[SerializeField]
		private AnimationCurve _elbowLimitCurve;

		private Quaternion _neutHumLf;

		private Quaternion _neutHumRt;

		private Quaternion _neutFemurLf;

		private Quaternion _neutFemurRt;

		private float _leftHandTwist;

		private float _rightHandTwist;

		private Quaternion _lastHandWorldLf;

		private Quaternion _lastHandWorldRt;

		private float _deviaHandLf;

		private float _deviaHandRt;

		private float _wristRelaxLerpLf;

		private float _wristRelaxVelLf;

		private float _wristRelaxLerpRt;

		private float _wristRelaxVelRt;

		private const float sDisplaceDegreesToXzMult = 0.00485f;

		private const float sDisplaceDegreesToYMult = 0.62f;

		protected const float accelLeanWeight = 0.33f;

		protected const float dragWeight = 2f;

		protected const float pACdProduct = 2f;

		protected Vector3 _velLerp;

		protected Vector3 _velLerpAccel;

		protected Vector3 _velSanGravNormal;

		protected float _velSanGravMag;

		protected float _accelSanGravMag;

		protected float _leanRetainer;

		protected float _leanVelocity;

		protected float _copToVelLerp;

		protected float _copToVelVel;

		protected float _angularVelocity;

		protected Vector3 _lastAngularFwd;

		public float leftHandDevia => 0f;

		public float rightHandDevia => 0f;

		protected SimpleTransform LimitSpineRotation(SimpleTransform from, SimpleTransform to, Vector4 rangeOfMotion, out float limitedTilt, out float limitedTwist, out float tiltRom, out float tiltDir, out Vector2 xzFromUp)
		{
			limitedTilt = default(float);
			limitedTwist = default(float);
			tiltRom = default(float);
			tiltDir = default(float);
			xzFromUp = default(Vector2);
			return default(SimpleTransform);
		}

		protected Vector3 LimitSpinePosition(Vector3 trackedOffsetLocal, float length, float limitedTilt, float limitedTwist, float tiltRom, float twistRom, Vector2 xzFromUp)
		{
			return default(Vector3);
		}

		protected SimpleTransform VerifyCervicalSpinePositional(SimpleTransform inHead, SimpleTransform inNeck, SimpleTransform inChest, SLZ.VRMK.Avatar avatar, out SimpleTransform neck)
		{
			neck = default(SimpleTransform);
			return default(SimpleTransform);
		}

		protected SimpleTransform VerifyThorLumbarSpinePositional(SimpleTransform inChest, SimpleTransform inSpine, SimpleTransform inPelvis, SLZ.VRMK.Avatar avatar, out SimpleTransform spine)
		{
			spine = default(SimpleTransform);
			return default(SimpleTransform);
		}

		protected SimpleTransform AimSpineTowardPelvis(SimpleTransform inHead, SimpleTransform inChest, Quaternion inSpine, SimpleTransform inPelvis, SimpleTransform pelvisTarget, SLZ.VRMK.Avatar avatar, out SimpleTransform outChest, out SimpleTransform outSpine, out SimpleTransform outNeck)
		{
			outChest = default(SimpleTransform);
			outSpine = default(SimpleTransform);
			outNeck = default(SimpleTransform);
			return default(SimpleTransform);
		}

		protected Vector3 ExtrapolateCervical(Quaternion skullRot, Quaternion chestRot, SLZ.VRMK.Avatar avatar, out Quaternion neckRot)
		{
			neckRot = default(Quaternion);
			return default(Vector3);
		}

		protected SimpleTransform ExtrapolateThorLumbar(SimpleTransform inChest, Quaternion inSpineRot, Quaternion inPelvisRot, SLZ.VRMK.Avatar avatar, out SimpleTransform outSpine)
		{
			outSpine = default(SimpleTransform);
			return default(SimpleTransform);
		}

		protected SimpleTransform SolveChest(SLZ.VRMK.Avatar avatar, SimpleTransform head, Rig inRig, float deltaTime, out SimpleTransform outNeck)
		{
			outNeck = default(SimpleTransform);
			return default(SimpleTransform);
		}

		protected SimpleTransform SolveChest2(SLZ.VRMK.Avatar avatar, SimpleTransform head, SimpleTransform pelvis, Rig inRig, float limitedTwist, out SimpleTransform outNeck)
		{
			outNeck = default(SimpleTransform);
			return default(SimpleTransform);
		}

		protected Quaternion SolveT1ToHands(Rig inRig, SLZ.VRMK.Avatar avatar, SimpleTransform t1World, float suppressTwist = 1f)
		{
			return default(Quaternion);
		}

		protected SimpleTransform SolvePelvis(SLZ.VRMK.Avatar avatar, SimpleTransform chest, float deltaTime, out SimpleTransform spine)
		{
			spine = default(SimpleTransform);
			return default(SimpleTransform);
		}

		protected SimpleTransform SolvePelvis2(SLZ.VRMK.Avatar avatar, SimpleTransform chest, SimpleTransform pelvis, out SimpleTransform spine)
		{
			spine = default(SimpleTransform);
			return default(SimpleTransform);
		}

		protected void SolveClavicles(Rig inRig, SLZ.VRMK.Avatar avatar)
		{
		}

		protected void AdditiveClavicles(Rig inRig, SLZ.VRMK.Avatar avatar)
		{
		}

		protected (float, float) SolveArmReach(Vector3 axis, float handLocalMag, float armAngleRemap, float armLength, float clavicalLength, float fwdDegrees, float backDegrees, float upDegrees, float downDegrees, bool isLeft)
		{
			return default((float, float));
		}

		protected (float, float, Vector3) ExtractClavInRom(Vector3 shoulderLocal, Vector3 neutralDir, float fwdDegrees, float backDegrees, float upDegrees, float downDegrees, bool isLeft)
		{
			return default((float, float, Vector3));
		}

		protected (Vector3, Vector3) LimitHands(SLZ.VRMK.Avatar avatar, bool twoHanded = false)
		{
			return default((Vector3, Vector3));
		}

		private bool HandLimiter(float currentMag, float defaultMag, float minPerc, out float newLimbMag)
		{
			newLimbMag = default(float);
			return false;
		}

		protected SimpleTransform SolveFeetCenter(SimpleTransform head, SimpleTransform chest, SimpleTransform pelvis, SimpleTransform handLf, SimpleTransform handRt)
		{
			return default(SimpleTransform);
		}

		protected void ApplyArms(Vector3 elbowLfWorld, Vector3 elbowRtWorld, SLZ.VRMK.Avatar avatar)
		{
		}

		protected void SolveArms(SLZ.VRMK.Avatar avatar, float deltaTime, float elbowWeightLf, Vector3 trackedElbowDirLf, float elbowWeightRt, Vector3 trackedElbowDirRt)
		{
		}

		protected (Vector3, float, float) LimbTrigSolve(Vector3 limbVector3, float upperMag, float lowerMag)
		{
			return default((Vector3, float, float));
		}

		private float ElbowIsNot(Quaternion handRot, Vector3 elbowFwd, Vector3 elbowUp, Vector3 wristUp, Vector3 armVectorNormed, Vector3 shoulderDown, Quaternion neutralGlenhumeral, float elbowWeight, Vector3 trackedElbowRt, float deltaTime, ref Quaternion lastHandRot, ref float twistFloat, ref float wristRelaxLerp, ref float wristRelaxVel)
		{
			return 0f;
		}

		protected void SolveLegs(SimpleTransform footstepLf, SimpleTransform footstepRt, SimpleTransform ankleLf, SimpleTransform ankleRt, Vector3 toeLf, Vector3 toeRt, float offsetLf = 0f, float offsetRt = 0f)
		{
		}

		protected void LimbLimit(float limbMag, float upperLength, float lowerLength, out float newLimbMag)
		{
			newLimbMag = default(float);
		}

		public void CalibratePlayerBodyScale(SLZ.VRMK.Avatar avatar)
		{
		}

		protected void ExtractProportions(Quaternion rootRotation, ref SimpleTransform palmLf, ref SimpleTransform palmRt, Rig inRig, SLZ.VRMK.Avatar avatar, ref BodyPose bodyPose)
		{
		}

		protected void ApplyProportions(Quaternion rootRotation, ref SimpleTransform palmLf, ref SimpleTransform palmRt, SLZ.VRMK.Avatar avatar, BodyPose bodyPose)
		{
		}

		protected void ExtractHandProximity(Quaternion rootRotation, ref SimpleTransform palmLf, ref SimpleTransform palmRt, SLZ.VRMK.Avatar avatar, Vector3 handLfBoundsPos, Vector3 handLfBoundsNeg, Vector3 handRtBoundsPos, Vector3 handRtBoundsNeg, ref BodyPose bodyPose)
		{
		}

		protected void ApplyHandProximity(Quaternion rootRotation, ref SimpleTransform palmLf, ref SimpleTransform palmRt, SLZ.VRMK.Avatar avatar, BodyPose bodyPose, Vector3 handLfBoundsPos, Vector3 handLfBoundsNeg, Vector3 handRtBoundsPos, Vector3 handRtBoundsNeg, float twoHanded)
		{
		}

		protected void ExtractTorsoProximity(Quaternion rootRotation, ref SimpleTransform palmLf, ref SimpleTransform palmRt, Rig inRig, SLZ.VRMK.Avatar avatar, Vector3 handLfBoundsPos, Vector3 handLfBoundsNeg, Vector3 handRtBoundsPos, Vector3 handRtBoundsNeg, ref BodyPose bodyPose)
		{
		}

		protected void ApplyTorsoProximity(Quaternion rootRotation, ref SimpleTransform palmLf, ref SimpleTransform palmRt, SLZ.VRMK.Avatar avatar, BodyPose bodyPose, Vector3 handLfBoundsPos, Vector3 handLfBoundsNeg, Vector3 handRtBoundsPos, Vector3 handRtBoundsNeg, float twoHanded = 0f)
		{
		}

		protected float GetSixAxisBoundsMag(Vector3 localNormedDirection, Vector3 boundsPositive, Vector3 boundsNegative)
		{
			return 0f;
		}

		protected bool PointInTorso(SimpleTransform pointWorld, Vector3 pointBoundsPos, Vector3 pointBoundsNeg, Vector3 pelFromChestNorm, float pelFromChestMag, SLZ.VRMK.Avatar player, SimpleTransform c1, SimpleTransform sternum, SimpleTransform spine, SimpleTransform pelvis, out float t, out float yPercRemapped, out Vector2 sin, out Quaternion spineRotInWorld, out Vector3 spineInPointNormed)
		{
			t = default(float);
			yPercRemapped = default(float);
			sin = default(Vector2);
			spineRotInWorld = default(Quaternion);
			spineInPointNormed = default(Vector3);
			return false;
		}

		protected SimpleTransform HandTorsoSpacewarp(ref SimpleTransform palm, Vector3 pointBoundsPos, Vector3 pointBoundsNeg, SLZ.VRMK.Avatar avatar, SimpleTransform head, SimpleTransform sternum, SimpleTransform spine, SimpleTransform hipCenter, Quaternion spineRot, float yPercRemapped, Vector2 sin, float t, Vector3 spineInPointNormed)
		{
			return default(SimpleTransform);
		}

		public void GenerateBasePose(float skullHeightWeight, ref BodyPose outPose)
		{
		}

		public void GenerateAdditivePose(BodyPose inPose, BodyPose basePose, ref BodyPose outPose)
		{
		}
	}
}
