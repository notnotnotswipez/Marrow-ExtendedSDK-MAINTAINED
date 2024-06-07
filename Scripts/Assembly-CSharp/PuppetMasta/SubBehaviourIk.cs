using System;
using RootMotion.FinalIK;
using SLZ.Marrow.PuppetMasta;
using UnityEngine;
using UnityEngine.Serialization;

namespace PuppetMasta
{
	[Serializable]
	public class SubBehaviourIk : SubBehaviourBase
	{
		public bool footIkOn;

		[FormerlySerializedAs("ikSolvers")]
		public IK[] footIkSolvers;

		public Transform[] toeTrans;

		[Range(0f, 1f)]
		public float curWeight;

		public IK[] armIkSolvers;

		public bool armIkActiveLf;

		public bool armIkActiveRt;

		public Transform lfHandTarget;

		public Transform rtHandTarget;

		public Transform lfHandAnim;

		public Transform rtHandAnim;

		[Header("Humonoid Constraints")]
		public bool isHuman;

		public Transform lfClav;

		public Transform lfAc;

		public Transform lfUpperTwist;

		public Transform lfTwist;

		public Transform lfWrist;

		public Transform lfHand;

		public Transform rtClav;

		public Transform rtAc;

		public Transform rtUpperTwist;

		public Transform rtTwist;

		public Transform rtWrist;

		public Transform rtHand;

		public Transform skinnedSpine1;

		public Transform neck1;

		public Transform neck2;

		public Transform neckTop;

		[Header("SpineIk")]
		public Transform spine1;

		public Transform spine2;

		public Transform spineTop;

		public Transform neck;

		public Transform head;

		public Transform eyeL;

		public Transform eyeR;

		public int lfShoulderMuscleIndex;

		public int rtShoulderMuscleIndex;

		private float _spineTwist;

		private float _headTwist;

		private bool _armLfIsOffset;

		private bool _armRtIsOffset;

		private float _armLfRotActiveTime;

		private float _armRtRotActiveTime;

		private float _quadT;

		private Vector3 _armLfOffset;

		private Vector3 _armRtOffset;

		private Quaternion _armLfOffsetQuat;

		private Quaternion _armRtOffsetQuat;

		private Quaternion _spineTopNeutral;

		public void Initiate(BehaviourBase b)
		{
		}

		public void Respawn()
		{
		}

		public void ProcessHumonoidConstraints()
		{
		}

		public void SpineTwist(Vector3 forwardDir, Vector3 worldTargetDir, bool active = true, bool headActive = true)
		{
		}

		public void Solve(float weight)
		{
		}

		public void SolveQuadrupedFrontFeet()
		{
		}

		public void SolveFeetIk()
		{
		}

		public void SolveArmIk()
		{
		}

		public void SetArmIk(Vector3 ikPosition, bool isRight = false, bool isOffset = false)
		{
		}

		public void SetArmIkRotation(Quaternion ikRotation, bool isRight = false)
		{
		}
	}
}
