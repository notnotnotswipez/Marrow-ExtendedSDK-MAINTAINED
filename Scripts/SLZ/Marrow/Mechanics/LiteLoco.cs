using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using SLZ.Marrow.Audio;
using SLZ.Marrow.Utilities;
using UnityEngine;

namespace SLZ.Marrow.Mechanics
{
	// Token: 0x020000F5 RID: 245
	public class LiteLoco : MonoBehaviour
	{
		// Token: 0x170001AC RID: 428
		// (get) Token: 0x06000970 RID: 2416 RVA: 0x0000769C File Offset: 0x0000589C
		// (set) Token: 0x06000971 RID: 2417 RVA: 0x0000419B File Offset: 0x0000239B
		public Vector3 accelOffset
		{
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06000972 RID: 2418 RVA: 0x0000419D File Offset: 0x0000239D
		public void Initiate(HashSet<Rigidbody> selfRbs)
		{
		}

		// Token: 0x06000973 RID: 2419 RVA: 0x0000419F File Offset: 0x0000239F
		public void Reset(Vector3 initialVelocity)
		{
		}

		// Token: 0x06000974 RID: 2420 RVA: 0x000041A1 File Offset: 0x000023A1
		public void SetStep(int stepGroup, int foot, Vector3 positionWorld, Quaternion rotationWorld)
		{
		}

		// Token: 0x06000975 RID: 2421 RVA: 0x000041A3 File Offset: 0x000023A3
		public void SetStance(int stepGroup, int foot, Vector3 positionLocal, float rotationOffset = 0f)
		{
		}

		// Token: 0x06000976 RID: 2422 RVA: 0x000041A5 File Offset: 0x000023A5
		public float GetMuscleUsage(int stepGroup, int step)
		{
			return 0f;
		}

		// Token: 0x06000977 RID: 2423 RVA: 0x000041AC File Offset: 0x000023AC
		public void UpdateLiteLoco(Vector3 worldVelocity, float rotDelta, bool accelOffsetY = true)
		{
		}

		// Token: 0x06000978 RID: 2424 RVA: 0x000041AE File Offset: 0x000023AE
		public void UpdateStepgroupPelvis(Vector3 localPos, Quaternion localRot, int stepGroup = 0)
		{
		}

		// Token: 0x04000607 RID: 1543
		[Range(0f, 1f)]
		[Tooltip("Used for blending in/out of procedural locomotion.")]
		public float weight;

		// Token: 0x04000608 RID: 1544
		public Transform root;

		// Token: 0x04000609 RID: 1545
		public Transform neutralRoot;

		// Token: 0x0400060A RID: 1546
		public LiteLoco.StepGroup[] stepGroups;

		// Token: 0x0400060B RID: 1547
		private Vector3 _velocity;

		// Token: 0x0200025C RID: 604
		[Serializable]
		public class StepGroup
		{
			// Token: 0x1700032D RID: 813
			// (get) Token: 0x0600116E RID: 4462 RVA: 0x000057B9 File Offset: 0x000039B9
			public int _Gear
			{
				get
				{
					return 0;
				}
			}

			// Token: 0x0600116F RID: 4463 RVA: 0x000057BC File Offset: 0x000039BC
			public void Initiate(HashSet<Rigidbody> selfRbs, LiteLoco.StepGroup sisterGroup = null)
			{
			}

			// Token: 0x06001170 RID: 4464 RVA: 0x000057BE File Offset: 0x000039BE
			public void Reset()
			{
			}

			// Token: 0x06001171 RID: 4465 RVA: 0x000057C0 File Offset: 0x000039C0
			public void SetStep(int step, Vector3 position, Quaternion rotation, bool isWorld = false)
			{
			}

			// Token: 0x06001172 RID: 4466 RVA: 0x000057C2 File Offset: 0x000039C2
			public void SetStance(int step, Vector3 position, float rotationOffset = 0f)
			{
			}

			// Token: 0x06001173 RID: 4467 RVA: 0x000057C4 File Offset: 0x000039C4
			public float GetMuscleUsage(int step)
			{
				return 0f;
			}

			// Token: 0x06001174 RID: 4468 RVA: 0x000057CB File Offset: 0x000039CB
			public void Solve(Transform root, Vector3 localPos, Quaternion localRot, float weight, Vector3 accelOffset, float accelMag, float rotDelta, float deltaTime)
			{
			}

			// Token: 0x06001175 RID: 4469 RVA: 0x000057CD File Offset: 0x000039CD
			private bool CanStep()
			{
				return false;
			}

			// Token: 0x06001176 RID: 4470 RVA: 0x000057D0 File Offset: 0x000039D0
			public void UpdateAnimCycle(float stepRate, float deltaTime)
			{
			}

			// Token: 0x04000F43 RID: 3907
			public Transform pelvis;

			// Token: 0x04000F44 RID: 3908
			public int sisterStepGroup;

			// Token: 0x04000F45 RID: 3909
			public float legLength;

			// Token: 0x04000F46 RID: 3910
			[Tooltip("Tries to maintain this distance between the legs.")]
			public AnimationCurve FootXVCurve;

			// Token: 0x04000F47 RID: 3911
			[SerializeField]
			private int _gear;

			// Token: 0x04000F48 RID: 3912
			public bool computeAnimCycle;

			// Token: 0x04000F49 RID: 3913
			public bool visualizeAnimCycle;

			// Token: 0x04000F4A RID: 3914
			public float animCycle;

			// Token: 0x04000F4B RID: 3915
			public LiteLoco.Gear[] gears;

			// Token: 0x04000F4C RID: 3916
			public LiteLoco.Grounder grounder;

			// Token: 0x04000F4D RID: 3917
			public LiteLoco.Footstep[] footsteps;

			// Token: 0x04000F4E RID: 3918
			private bool wasStepping;

			// Token: 0x04000F4F RID: 3919
			private float _lastAnimCycle;
		}

		// Token: 0x0200025D RID: 605
		[Serializable]
		public class Gear
		{
			// Token: 0x04000F50 RID: 3920
			[Tooltip("Velocity Threshold to upshift to next gear if existent")]
			public float upshiftVel;

			// Token: 0x04000F51 RID: 3921
			[Tooltip("Velocity Threshold to downshift to previous gear if existent")]
			public float downshiftVel;

			// Token: 0x04000F52 RID: 3922
			[Range(0f, 1f)]
			[Tooltip("Percentage of previous step completion before another can be triggered 0-1f")]
			public float stepProgressThreshold;

			// Token: 0x04000F53 RID: 3923
			[Range(0f, 1f)]
			[Tooltip("Blend of how much step is behind and in front of neutral point")]
			public float stepfromtoWeight;

			// Token: 0x04000F54 RID: 3924
			public float minStepThreshold;

			// Token: 0x04000F55 RID: 3925
			public AnimationCurve StepRateVCurve;

			// Token: 0x04000F56 RID: 3926
			[Tooltip("The height of the foot by normalized step progress (0 - 1).")]
			public AnimationCurve stepHeight;

			// Token: 0x04000F57 RID: 3927
			public AnimationCurve StepZInterp;

			// Token: 0x04000F58 RID: 3928
			public AnimationCurve StepAnkleBend;

			// Token: 0x04000F59 RID: 3929
			public AnimationCurve MuscleUsage;
		}

		// Token: 0x0200025E RID: 606
		[Serializable]
		public class Grounder
		{
			// Token: 0x06001179 RID: 4473 RVA: 0x000057E2 File Offset: 0x000039E2
			public void SetSelfRbs(HashSet<Rigidbody> selfRbs)
			{
			}

			// Token: 0x0600117A RID: 4474 RVA: 0x000057E4 File Offset: 0x000039E4
			public float GetWorldY(Vector3 origin)
			{
				return 0f;
			}

			// Token: 0x04000F5A RID: 3930
			[Tooltip("Layers to ground the character to. Make sure to exclude the layer of the character controller.")]
			public LayerMask layers;

			// Token: 0x04000F5B RID: 3931
			[Tooltip("Max step height. Maximum vertical distance of Grounding from the root of the character.")]
			public float maxStep;

			// Token: 0x04000F5C RID: 3932
			[Tooltip("The speed of moving the feet up/down.")]
			public float footSpeed;

			// Token: 0x04000F5D RID: 3933
			private HashSet<Rigidbody> _selfRbs;
		}

		// Token: 0x0200025F RID: 607
		[Serializable]
		public class Footstep
		{
			// Token: 0x1700032E RID: 814
			// (get) Token: 0x0600117C RID: 4476 RVA: 0x000057F3 File Offset: 0x000039F3
			public bool isStepping
			{
				get
				{
					return false;
				}
			}

			// Token: 0x1700032F RID: 815
			// (get) Token: 0x0600117D RID: 4477 RVA: 0x000057F6 File Offset: 0x000039F6
			// (set) Token: 0x0600117E RID: 4478 RVA: 0x000057FD File Offset: 0x000039FD
			public float stepProgress
			{
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000330 RID: 816
			// (get) Token: 0x0600117F RID: 4479 RVA: 0x000057FF File Offset: 0x000039FF
			// (set) Token: 0x06001180 RID: 4480 RVA: 0x00005806 File Offset: 0x00003A06
			public float grounderOffset
			{
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x06001181 RID: 4481 RVA: 0x00005808 File Offset: 0x00003A08
			public Footstep(LiteLoco.Grounder g, Transform hipTran, Transform footTran, Transform neutralTran)
			{
			}

			// Token: 0x06001182 RID: 4482 RVA: 0x00005810 File Offset: 0x00003A10
			private void ProcessesDefaults()
			{
			}

			// Token: 0x06001183 RID: 4483 RVA: 0x00005812 File Offset: 0x00003A12
			public void Initiate(LiteLoco.Grounder g, LiteLoco.Footstep sisterStep = null)
			{
			}

			// Token: 0x06001184 RID: 4484 RVA: 0x00005814 File Offset: 0x00003A14
			public void Reset(Vector3 position, Quaternion rotation, bool isWorld = false)
			{
			}

			// Token: 0x06001185 RID: 4485 RVA: 0x00005816 File Offset: 0x00003A16
			public void SetStance(Vector3 positionLocal, float rotationOff = 0f)
			{
			}

			// Token: 0x06001186 RID: 4486 RVA: 0x00005818 File Offset: 0x00003A18
			public void PrepStep(Transform root, LiteLoco.Gear gear, Vector3 localPos, Quaternion localRot, float stepRateUpdate, Vector3 accelOffset, float rotDelta, float neutralX, float deltaTime)
			{
			}

			// Token: 0x06001187 RID: 4487 RVA: 0x0000581A File Offset: 0x00003A1A
			public float CalculateStepDistance(LiteLoco.Gear gear, float legLength, float bestValue, float accelMag)
			{
				return 0f;
			}

			// Token: 0x06001188 RID: 4488 RVA: 0x00005821 File Offset: 0x00003A21
			public void StartStep(float stepRateUpdate)
			{
			}

			// Token: 0x06001189 RID: 4489 RVA: 0x00005823 File Offset: 0x00003A23
			public void Update(LiteLoco.Gear gear, float velocityMag, float weight, float dtTime)
			{
			}

			// Token: 0x0600118A RID: 4490 RVA: 0x00005825 File Offset: 0x00003A25
			public float CheckGround()
			{
				return 0f;
			}

			// Token: 0x0600118B RID: 4491 RVA: 0x0000582C File Offset: 0x00003A2C
			private void SetPhysMat(bool isLifted)
			{
			}

			// Token: 0x04000F5E RID: 3934
			private float _stepRate;

			// Token: 0x04000F5F RID: 3935
			private Vector3 _positionLocal;

			// Token: 0x04000F61 RID: 3937
			private Vector3 _stepFromLocal;

			// Token: 0x04000F62 RID: 3938
			private Vector3 _stepToLocal;

			// Token: 0x04000F63 RID: 3939
			private float _stepToRot;

			// Token: 0x04000F64 RID: 3940
			private float _stepFromRot;

			// Token: 0x04000F65 RID: 3941
			private float _rotationFloat;

			// Token: 0x04000F66 RID: 3942
			public Transform hip;

			// Token: 0x04000F67 RID: 3943
			public Transform foot;

			// Token: 0x04000F68 RID: 3944
			public Transform neutralTarget;

			// Token: 0x04000F69 RID: 3945
			public float rotationOffset;

			// Token: 0x04000F6A RID: 3946
			public Collider footCollider;

			// Token: 0x04000F6B RID: 3947
			public PhysicMaterial liftedMat;

			// Token: 0x04000F6C RID: 3948
			public FootstepSFX stepSfx;

			// Token: 0x04000F6D RID: 3949
			private Vector3 _localVelocity;

			// Token: 0x04000F6E RID: 3950
			private Vector3 _stepLz;

			// Token: 0x04000F6F RID: 3951
			private LiteLoco.Footstep _sisterStep;

			// Token: 0x04000F70 RID: 3952
			private PhysicMaterial _groundedMat;

			// Token: 0x04000F71 RID: 3953
			private bool _isLifted;

			// Token: 0x04000F73 RID: 3955
			private bool _hasCachedDefaults;

			// Token: 0x04000F74 RID: 3956
			private SimpleTransform _defaultHipT;

			// Token: 0x04000F75 RID: 3957
			private SimpleTransform _defaultFootT;

			// Token: 0x04000F76 RID: 3958
			private SimpleTransform _defaultNeutral;

			// Token: 0x04000F77 RID: 3959
			private LiteLoco.Grounder grounder;

			// Token: 0x04000F78 RID: 3960
			private float _lerpedGrounderOffset;
		}
	}
}
