using System;
using System.Runtime.CompilerServices;
using SLZ.Marrow.Pool;
using UnityEngine;
using UnityEngine.Events;

namespace SLZ.Marrow.PuppetMasta
{
	// Token: 0x020000D6 RID: 214
	public abstract class BehaviourBase : MonoBehaviour, IPoolable
	{
		// Token: 0x06000761 RID: 1889 RVA: 0x00003C22 File Offset: 0x00001E22
		public virtual void RestorePrefabState()
		{
		}

		// Token: 0x06000762 RID: 1890 RVA: 0x00003C24 File Offset: 0x00001E24
		public virtual void OnReactivate(int phase = 0)
		{
		}

		// Token: 0x06000763 RID: 1891 RVA: 0x00003C26 File Offset: 0x00001E26
		public virtual void Resurrect()
		{
		}

		// Token: 0x06000764 RID: 1892 RVA: 0x00003C28 File Offset: 0x00001E28
		public virtual void Freeze()
		{
		}

		// Token: 0x06000765 RID: 1893 RVA: 0x00003C2A File Offset: 0x00001E2A
		public virtual void Unfreeze()
		{
		}

		// Token: 0x06000766 RID: 1894 RVA: 0x00003C2C File Offset: 0x00001E2C
		public virtual void KillStart()
		{
		}

		// Token: 0x06000767 RID: 1895 RVA: 0x00003C2E File Offset: 0x00001E2E
		public virtual void KillEnd()
		{
		}

		// Token: 0x06000768 RID: 1896 RVA: 0x00003C30 File Offset: 0x00001E30
		public virtual void OnTeleport(Quaternion deltaRotation, Vector3 deltaPosition, Vector3 pivot, bool moveToTarget)
		{
		}

		// Token: 0x06000769 RID: 1897 RVA: 0x00003C32 File Offset: 0x00001E32
		public virtual void OnMuscleAdded(Muscle m)
		{
		}

		// Token: 0x0600076A RID: 1898 RVA: 0x00003C34 File Offset: 0x00001E34
		public virtual void OnMuscleRemoved(Muscle m)
		{
		}

		// Token: 0x0600076B RID: 1899 RVA: 0x00003C36 File Offset: 0x00001E36
		protected virtual void OnActivate()
		{
		}

		// Token: 0x0600076C RID: 1900 RVA: 0x00003C38 File Offset: 0x00001E38
		protected virtual void OnDeactivate()
		{
		}

		// Token: 0x0600076D RID: 1901 RVA: 0x00003C3A File Offset: 0x00001E3A
		protected virtual void OnInitiate()
		{
		}

		// Token: 0x0600076E RID: 1902 RVA: 0x00003C3C File Offset: 0x00001E3C
		protected virtual void OnFixedUpdate()
		{
		}

		// Token: 0x0600076F RID: 1903 RVA: 0x00003C3E File Offset: 0x00001E3E
		protected virtual void OnUpdate()
		{
		}

		// Token: 0x06000770 RID: 1904 RVA: 0x00003C40 File Offset: 0x00001E40
		protected virtual void OnLateUpdate()
		{
		}

		// Token: 0x06000771 RID: 1905 RVA: 0x00003C42 File Offset: 0x00001E42
		protected virtual void OnDrawGizmosBehaviour()
		{
		}

		// Token: 0x06000772 RID: 1906 RVA: 0x00003C44 File Offset: 0x00001E44
		protected virtual void OnFixTransformsBehaviour()
		{
		}

		// Token: 0x06000773 RID: 1907 RVA: 0x00003C46 File Offset: 0x00001E46
		protected virtual void OnReadBehaviour()
		{
		}

		// Token: 0x06000774 RID: 1908 RVA: 0x00003C48 File Offset: 0x00001E48
		protected virtual void OnWriteBehaviour()
		{
		}

		// Token: 0x06000775 RID: 1909 RVA: 0x00003C4A File Offset: 0x00001E4A
		protected virtual void OnMuscleHitBehaviour(MuscleHit hit)
		{
		}

		// Token: 0x06000776 RID: 1910 RVA: 0x00003C4C File Offset: 0x00001E4C
		protected virtual void OnMuscleCollisionBehaviour(MuscleCollision collision)
		{
		}

		// Token: 0x06000777 RID: 1911 RVA: 0x00003C4E File Offset: 0x00001E4E
		protected virtual void OnMuscleCollisionExitBehaviour(MuscleCollision collision)
		{
		}

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x06000778 RID: 1912 RVA: 0x00003C50 File Offset: 0x00001E50
		// (set) Token: 0x06000779 RID: 1913 RVA: 0x00003C53 File Offset: 0x00001E53
		public bool forceActive
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x0600077A RID: 1914 RVA: 0x00003C55 File Offset: 0x00001E55
		protected virtual void Awake()
		{
		}

		// Token: 0x0600077B RID: 1915 RVA: 0x00003C57 File Offset: 0x00001E57
		public void Initiate()
		{
		}

		// Token: 0x0600077C RID: 1916 RVA: 0x00003C59 File Offset: 0x00001E59
		public void OnFixTransforms()
		{
		}

		// Token: 0x0600077D RID: 1917 RVA: 0x00003C5B File Offset: 0x00001E5B
		public void OnRead()
		{
		}

		// Token: 0x0600077E RID: 1918 RVA: 0x00003C5D File Offset: 0x00001E5D
		public void OnWrite()
		{
		}

		// Token: 0x0600077F RID: 1919 RVA: 0x00003C5F File Offset: 0x00001E5F
		public void OnMuscleHit(MuscleHit hit)
		{
		}

		// Token: 0x06000780 RID: 1920 RVA: 0x00003C61 File Offset: 0x00001E61
		public void OnMuscleCollision(MuscleCollision collision)
		{
		}

		// Token: 0x06000781 RID: 1921 RVA: 0x00003C63 File Offset: 0x00001E63
		public void OnMuscleCollisionExit(MuscleCollision collision)
		{
		}

		// Token: 0x06000782 RID: 1922 RVA: 0x00003C65 File Offset: 0x00001E65
		public void Activate()
		{
		}

		// Token: 0x06000783 RID: 1923 RVA: 0x00003C67 File Offset: 0x00001E67
		public void Deactivate()
		{
		}

		// Token: 0x06000784 RID: 1924 RVA: 0x00003C69 File Offset: 0x00001E69
		public void BehaviourFixedUpdate()
		{
		}

		// Token: 0x06000785 RID: 1925 RVA: 0x00003C6B File Offset: 0x00001E6B
		public void BehaviourUpdate()
		{
		}

		// Token: 0x06000786 RID: 1926 RVA: 0x00003C6D File Offset: 0x00001E6D
		public void BehaviourLateUpdate()
		{
		}

		// Token: 0x06000787 RID: 1927 RVA: 0x00003C6F File Offset: 0x00001E6F
		protected virtual void OnDrawGizmos()
		{
		}

		// Token: 0x06000788 RID: 1928 RVA: 0x00003C71 File Offset: 0x00001E71
		[ContextMenu("Get Animation Contact Point")]
		private void GetAnimContactPoint()
		{
		}

		// Token: 0x06000789 RID: 1929 RVA: 0x00003C73 File Offset: 0x00001E73
		private AnimationClip FindClipByName(string clipName)
		{
			return null;
		}

		// Token: 0x0600078A RID: 1930 RVA: 0x000072DC File Offset: 0x000054DC
		private Vector3 SampleAnimationClip(AnimationClip clip)
		{
			return default(Vector3);
		}

		// Token: 0x0600078B RID: 1931 RVA: 0x00003C76 File Offset: 0x00001E76
		protected void TranslateTargetToRootMuscle(float maintainY)
		{
		}

		// Token: 0x0600078C RID: 1932 RVA: 0x00003C78 File Offset: 0x00001E78
		protected void RemoveMusclesOfGroup(Muscle.Group group)
		{
		}

		// Token: 0x0600078D RID: 1933 RVA: 0x00003C7A File Offset: 0x00001E7A
		protected virtual void GroundTarget(LayerMask layers)
		{
		}

		// Token: 0x0600078E RID: 1934 RVA: 0x00003C7C File Offset: 0x00001E7C
		protected bool MusclesContainsGroup(Muscle.Group group)
		{
			return false;
		}

		// Token: 0x0600078F RID: 1935 RVA: 0x00003C7F File Offset: 0x00001E7F
		public virtual void OnPoolInitialize()
		{
		}

		// Token: 0x06000790 RID: 1936 RVA: 0x00003C81 File Offset: 0x00001E81
		public virtual void OnPoolSpawn()
		{
		}

		// Token: 0x06000791 RID: 1937 RVA: 0x00003C83 File Offset: 0x00001E83
		public virtual void OnPoolDeInitialize()
		{
		}

		// Token: 0x04000400 RID: 1024
		public PuppetMaster puppetMaster;

		// Token: 0x04000401 RID: 1025
		public BehaviourBase.BehaviourDelegate OnPreActivate;

		// Token: 0x04000402 RID: 1026
		public BehaviourBase.BehaviourDelegate OnPreInitiate;

		// Token: 0x04000403 RID: 1027
		public BehaviourBase.BehaviourDelegate OnPreFixedUpdate;

		// Token: 0x04000404 RID: 1028
		public BehaviourBase.BehaviourDelegate OnPreUpdate;

		// Token: 0x04000405 RID: 1029
		public BehaviourBase.BehaviourDelegate OnPreLateUpdate;

		// Token: 0x04000406 RID: 1030
		public BehaviourBase.BehaviourDelegate OnPreDeactivate;

		// Token: 0x04000407 RID: 1031
		public BehaviourBase.BehaviourDelegate OnPreFixTransforms;

		// Token: 0x04000408 RID: 1032
		public BehaviourBase.BehaviourDelegate OnPreRead;

		// Token: 0x04000409 RID: 1033
		public BehaviourBase.BehaviourDelegate OnPreWrite;

		// Token: 0x0400040A RID: 1034
		public BehaviourBase.HitDelegate OnPreMuscleHit;

		// Token: 0x0400040B RID: 1035
		public BehaviourBase.CollisionDelegate OnPreMuscleCollision;

		// Token: 0x0400040C RID: 1036
		public BehaviourBase.CollisionDelegate OnPreMuscleCollisionExit;

		// Token: 0x0400040D RID: 1037
		public BehaviourBase.BehaviourDelegate OnHierarchyChanged;

		// Token: 0x0400040E RID: 1038
		public BehaviourBase.BehaviourDelegate OnPostActivate;

		// Token: 0x0400040F RID: 1039
		public BehaviourBase.BehaviourDelegate OnPostInitiate;

		// Token: 0x04000410 RID: 1040
		public BehaviourBase.BehaviourDelegate OnPostFixedUpdate;

		// Token: 0x04000411 RID: 1041
		public BehaviourBase.BehaviourDelegate OnPostUpdate;

		// Token: 0x04000412 RID: 1042
		public BehaviourBase.BehaviourDelegate OnPostLateUpdate;

		// Token: 0x04000413 RID: 1043
		public BehaviourBase.BehaviourDelegate OnPostDeactivate;

		// Token: 0x04000414 RID: 1044
		public BehaviourBase.BehaviourDelegate OnPostDrawGizmos;

		// Token: 0x04000415 RID: 1045
		public BehaviourBase.BehaviourDelegate OnPostFixTransforms;

		// Token: 0x04000416 RID: 1046
		public BehaviourBase.BehaviourDelegate OnPostRead;

		// Token: 0x04000417 RID: 1047
		public BehaviourBase.BehaviourDelegate OnPostWrite;

		// Token: 0x04000418 RID: 1048
		public BehaviourBase.HitDelegate OnPostMuscleHit;

		// Token: 0x04000419 RID: 1049
		public BehaviourBase.CollisionDelegate OnPostMuscleCollision;

		// Token: 0x0400041A RID: 1050
		public BehaviourBase.CollisionDelegate OnPostMuscleCollisionExit;

		// Token: 0x0400041B RID: 1051
		[HideInInspector]
		public bool deactivated;

		// Token: 0x0400041D RID: 1053
		private bool initiated;

		// Token: 0x0400041E RID: 1054
		public Poolee _poolee;

		// Token: 0x0400041F RID: 1055
		[Header("Contact Point Tool Variables")]
		public Animator contactAnimController;

		// Token: 0x04000420 RID: 1056
		private RuntimeAnimatorController _runtimeAnimatorController;

		// Token: 0x04000421 RID: 1057
		public string contactAnimName;

		// Token: 0x04000422 RID: 1058
		public HumanBodyBones contactBoneRef;

		// Token: 0x04000423 RID: 1059
		public int contactPointFrame;

		// Token: 0x02000230 RID: 560
		// (Invoke) Token: 0x06001113 RID: 4371
		public delegate void BehaviourDelegate();

		// Token: 0x02000231 RID: 561
		// (Invoke) Token: 0x06001117 RID: 4375
		public delegate void HitDelegate(MuscleHit hit);

		// Token: 0x02000232 RID: 562
		// (Invoke) Token: 0x0600111B RID: 4379
		public delegate void CollisionDelegate(MuscleCollision m);

		// Token: 0x02000233 RID: 563
		[Serializable]
		public struct PuppetEvent
		{
			// Token: 0x17000321 RID: 801
			// (get) Token: 0x0600111E RID: 4382 RVA: 0x000056E8 File Offset: 0x000038E8
			public bool switchBehaviour
			{
				get
				{
					return false;
				}
			}

			// Token: 0x0600111F RID: 4383 RVA: 0x000056EB File Offset: 0x000038EB
			public void Trigger(PuppetMaster puppetMaster, bool switchBehaviourEnabled = true)
			{
			}

			// Token: 0x04000E71 RID: 3697
			[Tooltip("Another Puppet Behaviour to switch to on this event. This must be the exact Type of the the Behaviour, careful with spelling.")]
			public string switchToBehaviour;

			// Token: 0x04000E72 RID: 3698
			[Tooltip("Animations to cross-fade to on this event. This is separate from the UnityEvent below because UnityEvents can't handle calls with more than one parameter such as Animator.CrossFade.")]
			public BehaviourBase.AnimatorEvent[] animations;

			// Token: 0x04000E73 RID: 3699
			[Tooltip("The UnityEvent to invoke on this event.")]
			public UnityEvent unityEvent;

			// Token: 0x04000E74 RID: 3700
			private const string empty = "";
		}

		// Token: 0x02000234 RID: 564
		[Serializable]
		public class AnimatorEvent
		{
			// Token: 0x06001120 RID: 4384 RVA: 0x000056ED File Offset: 0x000038ED
			public void Initialize()
			{
			}

			// Token: 0x06001121 RID: 4385 RVA: 0x000056EF File Offset: 0x000038EF
			public void Activate(Animator animator)
			{
			}

			// Token: 0x04000E75 RID: 3701
			public string animationState;

			// Token: 0x04000E76 RID: 3702
			public float crossfadeTime;

			// Token: 0x04000E77 RID: 3703
			public int layer;

			// Token: 0x04000E78 RID: 3704
			public bool resetNormalizedTime;

			// Token: 0x04000E79 RID: 3705
			private bool _isInitialized;

			// Token: 0x04000E7A RID: 3706
			private int _hash;

			// Token: 0x04000E7B RID: 3707
			private const string empty = "";
		}

		// Token: 0x02000235 RID: 565
		[Serializable]
		public class TargetableAnimatorEvent
		{
			// Token: 0x06001123 RID: 4387 RVA: 0x000056F9 File Offset: 0x000038F9
			public void Initialize()
			{
			}

			// Token: 0x06001124 RID: 4388 RVA: 0x000056FB File Offset: 0x000038FB
			public void Activate(Animator animator)
			{
			}

			// Token: 0x06001125 RID: 4389 RVA: 0x00008854 File Offset: 0x00006A54
			public Vector3 ComputeTargetIkDelta(Vector3 targetLocal, Vector3 currentOffset, bool onFeet = true)
			{
				return default(Vector3);
			}

			// Token: 0x06001126 RID: 4390 RVA: 0x0000886C File Offset: 0x00006A6C
			public Vector3 ComputeCurrentIkDelta()
			{
				return default(Vector3);
			}

			// Token: 0x06001127 RID: 4391 RVA: 0x000056FD File Offset: 0x000038FD
			public float GetNormalTime()
			{
				return 0f;
			}

			// Token: 0x04000E7C RID: 3708
			public string animationState;

			// Token: 0x04000E7D RID: 3709
			public float crossfadeTime;

			// Token: 0x04000E7E RID: 3710
			public int layer;

			// Token: 0x04000E7F RID: 3711
			public float clipLength;

			// Token: 0x04000E80 RID: 3712
			public Vector3 localContactPoint;

			// Token: 0x04000E81 RID: 3713
			[Range(0f, 0.99f)]
			public float startIkNormalTime;

			// Token: 0x04000E82 RID: 3714
			[Range(0.01f, 0.99f)]
			public float contactPointNormalTime;

			// Token: 0x04000E83 RID: 3715
			public BehaviourBase.TargetableAnimatorEvent.TargetedLimb targetedLimb;

			// Token: 0x04000E84 RID: 3716
			public float limbStrengthMultiplier;

			// Token: 0x04000E85 RID: 3717
			public float spineStrengthMultiplier;

			// Token: 0x04000E86 RID: 3718
			private bool _isInitialized;

			// Token: 0x04000E87 RID: 3719
			private int _hash;

			// Token: 0x04000E88 RID: 3720
			private float _timeStarted;

			// Token: 0x04000E89 RID: 3721
			private float _divByClipLength;

			// Token: 0x04000E8A RID: 3722
			private float _divByPreContact;

			// Token: 0x04000E8B RID: 3723
			private float _divByPostContact;

			// Token: 0x04000E8C RID: 3724
			private Vector3 _ikDelta;

			// Token: 0x04000E8D RID: 3725
			private const string empty = "";

			// Token: 0x020002D9 RID: 729
			public enum TargetedLimb
			{
				// Token: 0x04001188 RID: 4488
				LeftArm,
				// Token: 0x04001189 RID: 4489
				RightArm,
				// Token: 0x0400118A RID: 4490
				LeftLeg,
				// Token: 0x0400118B RID: 4491
				RightLeg
			}
		}
	}
}
