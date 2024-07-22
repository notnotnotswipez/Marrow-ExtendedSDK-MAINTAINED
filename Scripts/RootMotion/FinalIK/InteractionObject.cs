using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

namespace RootMotion.FinalIK
{
	// Token: 0x02000053 RID: 83
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Interaction System/Interaction Object")]
	[HelpURL("https://www.youtube.com/watch?v=r5jiZnsDH3M")]
	public class InteractionObject : MonoBehaviour
	{
		// Token: 0x0600032E RID: 814 RVA: 0x00002916 File Offset: 0x00000B16
		[ContextMenu("TUTORIAL VIDEO (PART 1: BASICS)")]
		private void OpenTutorial1()
		{
		}

		// Token: 0x0600032F RID: 815 RVA: 0x00002918 File Offset: 0x00000B18
		[ContextMenu("TUTORIAL VIDEO (PART 2: PICKING UP...)")]
		private void OpenTutorial2()
		{
		}

		// Token: 0x06000330 RID: 816 RVA: 0x0000291A File Offset: 0x00000B1A
		[ContextMenu("TUTORIAL VIDEO (PART 3: ANIMATION)")]
		private void OpenTutorial3()
		{
		}

		// Token: 0x06000331 RID: 817 RVA: 0x0000291C File Offset: 0x00000B1C
		[ContextMenu("TUTORIAL VIDEO (PART 4: TRIGGERS)")]
		private void OpenTutorial4()
		{
		}

		// Token: 0x06000332 RID: 818 RVA: 0x0000291E File Offset: 0x00000B1E
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		// Token: 0x06000333 RID: 819 RVA: 0x00002920 File Offset: 0x00000B20
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x06000334 RID: 820 RVA: 0x00002922 File Offset: 0x00000B22
		// (set) Token: 0x06000335 RID: 821 RVA: 0x00002929 File Offset: 0x00000B29
		public float length
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

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000336 RID: 822 RVA: 0x0000292B File Offset: 0x00000B2B
		// (set) Token: 0x06000337 RID: 823 RVA: 0x0000292E File Offset: 0x00000B2E
		public InteractionSystem lastUsedInteractionSystem
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06000338 RID: 824 RVA: 0x00002930 File Offset: 0x00000B30
		public void Initiate()
		{
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000339 RID: 825 RVA: 0x00002932 File Offset: 0x00000B32
		public Transform lookAtTarget
		{
			get
			{
				return null;
			}
		}

		// Token: 0x0600033A RID: 826 RVA: 0x00002935 File Offset: 0x00000B35
		public InteractionTarget GetTarget(FullBodyBipedEffector effectorType, InteractionSystem interactionSystem)
		{
			return null;
		}

		// Token: 0x0600033B RID: 827 RVA: 0x00002938 File Offset: 0x00000B38
		public bool CurveUsed(InteractionObject.WeightCurve.Type type)
		{
			return false;
		}

		// Token: 0x0600033C RID: 828 RVA: 0x0000293B File Offset: 0x00000B3B
		public InteractionTarget[] GetTargets()
		{
			return null;
		}

		// Token: 0x0600033D RID: 829 RVA: 0x0000293E File Offset: 0x00000B3E
		public Transform GetTarget(FullBodyBipedEffector effectorType, string tag)
		{
			return null;
		}

		// Token: 0x0600033E RID: 830 RVA: 0x00002941 File Offset: 0x00000B41
		public void OnStartInteraction(InteractionSystem interactionSystem)
		{
		}

		// Token: 0x0600033F RID: 831 RVA: 0x00002943 File Offset: 0x00000B43
		public void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, InteractionTarget target, float timer, float weight)
		{
		}

		// Token: 0x06000340 RID: 832 RVA: 0x00002945 File Offset: 0x00000B45
		public float GetValue(InteractionObject.WeightCurve.Type weightCurveType, InteractionTarget target, float timer)
		{
			return 0f;
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000341 RID: 833 RVA: 0x0000294C File Offset: 0x00000B4C
		public Transform targetsRoot
		{
			get
			{
				return null;
			}
		}

		// Token: 0x06000342 RID: 834 RVA: 0x0000294F File Offset: 0x00000B4F
		private void Awake()
		{
		}

		// Token: 0x06000343 RID: 835 RVA: 0x00002951 File Offset: 0x00000B51
		private void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, InteractionObject.WeightCurve.Type type, float value, float weight)
		{
		}

		// Token: 0x06000344 RID: 836 RVA: 0x00002953 File Offset: 0x00000B53
		private Transform GetTarget(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		// Token: 0x06000345 RID: 837 RVA: 0x00002956 File Offset: 0x00000B56
		private int GetWeightCurveIndex(InteractionObject.WeightCurve.Type weightCurveType)
		{
			return 0;
		}

		// Token: 0x06000346 RID: 838 RVA: 0x00002959 File Offset: 0x00000B59
		private int GetMultiplierIndex(InteractionObject.WeightCurve.Type weightCurveType)
		{
			return 0;
		}

		// Token: 0x06000347 RID: 839 RVA: 0x0000295C File Offset: 0x00000B5C
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		// Token: 0x06000348 RID: 840 RVA: 0x0000295E File Offset: 0x00000B5E
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		// Token: 0x040002D3 RID: 723
		[Tooltip("If the Interaction System has a 'Look At' LookAtIK component assigned, will use it to make the character look at the specified Transform. If unassigned, will look at this GameObject.")]
		public Transform otherLookAtTarget;

		// Token: 0x040002D4 RID: 724
		[Tooltip("The root Transform of the InteractionTargets. If null, will use this GameObject. GetComponentsInChildren<InteractionTarget>() will be used at initiation to find all InteractionTargets associated with this InteractionObject.")]
		public Transform otherTargetsRoot;

		// Token: 0x040002D5 RID: 725
		[Tooltip("If assigned, all PositionOffset channels will be applied in the rotation space of this Transform. If not, they will be in the rotation space of the character.")]
		public Transform positionOffsetSpace;

		// Token: 0x040002D6 RID: 726
		public InteractionObject.WeightCurve[] weightCurves;

		// Token: 0x040002D7 RID: 727
		public InteractionObject.Multiplier[] multipliers;

		// Token: 0x040002D8 RID: 728
		public InteractionObject.InteractionEvent[] events;

		// Token: 0x040002DB RID: 731
		private InteractionTarget[] targets;

		// Token: 0x0200009A RID: 154
		[Serializable]
		public class InteractionEvent
		{
			// Token: 0x06000514 RID: 1300 RVA: 0x00002E4C File Offset: 0x0000104C
			public void Activate(Transform t)
			{
			}

			// Token: 0x040004F9 RID: 1273
			[Tooltip("The time of the event since interaction start.")]
			public float time;

			// Token: 0x040004FA RID: 1274
			[Tooltip("If true, the interaction will be paused on this event. The interaction can be resumed by InteractionSystem.ResumeInteraction() or InteractionSystem.ResumeAll;")]
			public bool pause;

			// Token: 0x040004FB RID: 1275
			[Tooltip("If true, the object will be parented to the effector bone on this event. Note that picking up like this can be done by only a single effector at a time. If you wish to pick up an object with both hands, see the Interaction PickUp2Handed demo scene.")]
			public bool pickUp;

			// Token: 0x040004FC RID: 1276
			[Tooltip("The animations called on this event.")]
			public InteractionObject.AnimatorEvent[] animations;

			// Token: 0x040004FD RID: 1277
			[Tooltip("The messages sent on this event using GameObject.SendMessage().")]
			public InteractionObject.Message[] messages;

			// Token: 0x040004FE RID: 1278
			[Tooltip("The UnityEvent to invoke on this event.")]
			public UnityEvent unityEvent;
		}

		// Token: 0x0200009B RID: 155
		[Serializable]
		public class Message
		{
			// Token: 0x06000516 RID: 1302 RVA: 0x00002E56 File Offset: 0x00001056
			public void Send(Transform t)
			{
			}

			// Token: 0x040004FF RID: 1279
			[Tooltip("The name of the function called.")]
			public string function;

			// Token: 0x04000500 RID: 1280
			[Tooltip("The recipient game object.")]
			public GameObject recipient;

			// Token: 0x04000501 RID: 1281
			private const string empty = "";
		}

		// Token: 0x0200009C RID: 156
		[Serializable]
		public class AnimatorEvent
		{
			// Token: 0x06000518 RID: 1304 RVA: 0x00002E60 File Offset: 0x00001060
			public void Activate(bool pickUp)
			{
			}

			// Token: 0x06000519 RID: 1305 RVA: 0x00002E62 File Offset: 0x00001062
			private void Activate(Animator animator)
			{
			}

			// Token: 0x0600051A RID: 1306 RVA: 0x00002E64 File Offset: 0x00001064
			private void Activate(Animation animation)
			{
			}

			// Token: 0x04000502 RID: 1282
			[Tooltip("The Animator component that will receive the AnimatorEvents.")]
			public Animator animator;

			// Token: 0x04000503 RID: 1283
			[Tooltip("The Animation component that will receive the AnimatorEvents (Legacy).")]
			public Animation animation;

			// Token: 0x04000504 RID: 1284
			[Tooltip("The name of the animation state.")]
			public string animationState;

			// Token: 0x04000505 RID: 1285
			[Tooltip("The crossfading time.")]
			public float crossfadeTime;

			// Token: 0x04000506 RID: 1286
			[Tooltip("The layer of the animation state (if using Legacy, the animation state will be forced to this layer).")]
			public int layer;

			// Token: 0x04000507 RID: 1287
			[Tooltip("Should the animation always start from 0 normalized time?")]
			public bool resetNormalizedTime;

			// Token: 0x04000508 RID: 1288
			private const string empty = "";
		}

		// Token: 0x0200009D RID: 157
		[Serializable]
		public class WeightCurve
		{
			// Token: 0x0600051C RID: 1308 RVA: 0x00002E6E File Offset: 0x0000106E
			public float GetValue(float timer)
			{
				return 0f;
			}

			// Token: 0x04000509 RID: 1289
			[Tooltip("The type of the curve (InteractionObject.WeightCurve.Type).")]
			public InteractionObject.WeightCurve.Type type;

			// Token: 0x0400050A RID: 1290
			[Tooltip("The weight curve.")]
			public AnimationCurve curve;

			// Token: 0x020000C0 RID: 192
			[Serializable]
			public enum Type
			{
				// Token: 0x040005AA RID: 1450
				PositionWeight,
				// Token: 0x040005AB RID: 1451
				RotationWeight,
				// Token: 0x040005AC RID: 1452
				PositionOffsetX,
				// Token: 0x040005AD RID: 1453
				PositionOffsetY,
				// Token: 0x040005AE RID: 1454
				PositionOffsetZ,
				// Token: 0x040005AF RID: 1455
				Pull,
				// Token: 0x040005B0 RID: 1456
				Reach,
				// Token: 0x040005B1 RID: 1457
				RotateBoneWeight,
				// Token: 0x040005B2 RID: 1458
				Push,
				// Token: 0x040005B3 RID: 1459
				PushParent,
				// Token: 0x040005B4 RID: 1460
				PoserWeight
			}
		}

		// Token: 0x0200009E RID: 158
		[Serializable]
		public class Multiplier
		{
			// Token: 0x0600051E RID: 1310 RVA: 0x00002E7D File Offset: 0x0000107D
			public float GetValue(InteractionObject.WeightCurve weightCurve, float timer)
			{
				return 0f;
			}

			// Token: 0x0400050B RID: 1291
			[Tooltip("The curve type to multiply.")]
			public InteractionObject.WeightCurve.Type curve;

			// Token: 0x0400050C RID: 1292
			[Tooltip("The multiplier of the curve's value.")]
			public float multiplier;

			// Token: 0x0400050D RID: 1293
			[Tooltip("The resulting value will be applied to this channel.")]
			public InteractionObject.WeightCurve.Type result;
		}
	}
}
