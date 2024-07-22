using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

namespace RootMotion.FinalIK
{
	// Token: 0x02000054 RID: 84
	[HelpURL("https://www.youtube.com/watch?v=r5jiZnsDH3M")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Interaction System/Interaction System")]
	public class InteractionSystem : MonoBehaviour
	{
		// Token: 0x0600034A RID: 842 RVA: 0x00002968 File Offset: 0x00000B68
		[ContextMenu("TUTORIAL VIDEO (PART 1: BASICS)")]
		private void OpenTutorial1()
		{
		}

		// Token: 0x0600034B RID: 843 RVA: 0x0000296A File Offset: 0x00000B6A
		[ContextMenu("TUTORIAL VIDEO (PART 2: PICKING UP...)")]
		private void OpenTutorial2()
		{
		}

		// Token: 0x0600034C RID: 844 RVA: 0x0000296C File Offset: 0x00000B6C
		[ContextMenu("TUTORIAL VIDEO (PART 3: ANIMATION)")]
		private void OpenTutorial3()
		{
		}

		// Token: 0x0600034D RID: 845 RVA: 0x0000296E File Offset: 0x00000B6E
		[ContextMenu("TUTORIAL VIDEO (PART 4: TRIGGERS)")]
		private void OpenTutorial4()
		{
		}

		// Token: 0x0600034E RID: 846 RVA: 0x00002970 File Offset: 0x00000B70
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		// Token: 0x0600034F RID: 847 RVA: 0x00002972 File Offset: 0x00000B72
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000350 RID: 848 RVA: 0x00002974 File Offset: 0x00000B74
		public bool inInteraction
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06000351 RID: 849 RVA: 0x00002977 File Offset: 0x00000B77
		public bool IsInInteraction(FullBodyBipedEffector effectorType)
		{
			return false;
		}

		// Token: 0x06000352 RID: 850 RVA: 0x0000297A File Offset: 0x00000B7A
		public bool IsPaused(FullBodyBipedEffector effectorType)
		{
			return false;
		}

		// Token: 0x06000353 RID: 851 RVA: 0x0000297D File Offset: 0x00000B7D
		public bool IsPaused()
		{
			return false;
		}

		// Token: 0x06000354 RID: 852 RVA: 0x00002980 File Offset: 0x00000B80
		public bool IsInSync()
		{
			return false;
		}

		// Token: 0x06000355 RID: 853 RVA: 0x00002983 File Offset: 0x00000B83
		public bool StartInteraction(FullBodyBipedEffector effectorType, InteractionObject interactionObject, bool interrupt)
		{
			return false;
		}

		// Token: 0x06000356 RID: 854 RVA: 0x00002986 File Offset: 0x00000B86
		public bool PauseInteraction(FullBodyBipedEffector effectorType)
		{
			return false;
		}

		// Token: 0x06000357 RID: 855 RVA: 0x00002989 File Offset: 0x00000B89
		public bool ResumeInteraction(FullBodyBipedEffector effectorType)
		{
			return false;
		}

		// Token: 0x06000358 RID: 856 RVA: 0x0000298C File Offset: 0x00000B8C
		public bool StopInteraction(FullBodyBipedEffector effectorType)
		{
			return false;
		}

		// Token: 0x06000359 RID: 857 RVA: 0x0000298F File Offset: 0x00000B8F
		public void PauseAll()
		{
		}

		// Token: 0x0600035A RID: 858 RVA: 0x00002991 File Offset: 0x00000B91
		public void ResumeAll()
		{
		}

		// Token: 0x0600035B RID: 859 RVA: 0x00002993 File Offset: 0x00000B93
		public void StopAll()
		{
		}

		// Token: 0x0600035C RID: 860 RVA: 0x00002995 File Offset: 0x00000B95
		public InteractionObject GetInteractionObject(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		// Token: 0x0600035D RID: 861 RVA: 0x00002998 File Offset: 0x00000B98
		public float GetProgress(FullBodyBipedEffector effectorType)
		{
			return 0f;
		}

		// Token: 0x0600035E RID: 862 RVA: 0x0000299F File Offset: 0x00000B9F
		public float GetMinActiveProgress()
		{
			return 0f;
		}

		// Token: 0x0600035F RID: 863 RVA: 0x000029A6 File Offset: 0x00000BA6
		public bool TriggerInteraction(int index, bool interrupt)
		{
			return false;
		}

		// Token: 0x06000360 RID: 864 RVA: 0x000029A9 File Offset: 0x00000BA9
		public bool TriggerInteraction(int index, bool interrupt, out InteractionObject interactionObject)
		{
			interactionObject = null;
			return false;
		}

		// Token: 0x06000361 RID: 865 RVA: 0x000029AF File Offset: 0x00000BAF
		public bool TriggerInteraction(int index, bool interrupt, out InteractionTarget interactionTarget)
		{
			interactionTarget = null;
			return false;
		}

		// Token: 0x06000362 RID: 866 RVA: 0x000029B5 File Offset: 0x00000BB5
		public InteractionTrigger.Range GetClosestInteractionRange()
		{
			return null;
		}

		// Token: 0x06000363 RID: 867 RVA: 0x000029B8 File Offset: 0x00000BB8
		public InteractionObject GetClosestInteractionObjectInRange()
		{
			return null;
		}

		// Token: 0x06000364 RID: 868 RVA: 0x000029BB File Offset: 0x00000BBB
		public InteractionTarget GetClosestInteractionTargetInRange()
		{
			return null;
		}

		// Token: 0x06000365 RID: 869 RVA: 0x000029BE File Offset: 0x00000BBE
		public InteractionObject[] GetClosestInteractionObjectsInRange()
		{
			return null;
		}

		// Token: 0x06000366 RID: 870 RVA: 0x000029C1 File Offset: 0x00000BC1
		public InteractionTarget[] GetClosestInteractionTargetsInRange()
		{
			return null;
		}

		// Token: 0x06000367 RID: 871 RVA: 0x000029C4 File Offset: 0x00000BC4
		public bool TriggerEffectorsReady(int index)
		{
			return false;
		}

		// Token: 0x06000368 RID: 872 RVA: 0x000029C7 File Offset: 0x00000BC7
		public InteractionTrigger.Range GetTriggerRange(int index)
		{
			return null;
		}

		// Token: 0x06000369 RID: 873 RVA: 0x000029CA File Offset: 0x00000BCA
		public int GetClosestTriggerIndex()
		{
			return 0;
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x0600036A RID: 874 RVA: 0x000029CD File Offset: 0x00000BCD
		// (set) Token: 0x0600036B RID: 875 RVA: 0x000029D0 File Offset: 0x00000BD0
		public FullBodyBipedIK ik
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x0600036C RID: 876 RVA: 0x000029D2 File Offset: 0x00000BD2
		// (set) Token: 0x0600036D RID: 877 RVA: 0x000029D5 File Offset: 0x00000BD5
		public List<InteractionTrigger> triggersInRange
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

		// Token: 0x0600036E RID: 878 RVA: 0x000029D7 File Offset: 0x00000BD7
		private void Start()
		{
		}

		// Token: 0x0600036F RID: 879 RVA: 0x000029D9 File Offset: 0x00000BD9
		private void InteractionPause(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		// Token: 0x06000370 RID: 880 RVA: 0x000029DB File Offset: 0x00000BDB
		private void InteractionResume(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		// Token: 0x06000371 RID: 881 RVA: 0x000029DD File Offset: 0x00000BDD
		private void InteractionStop(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		// Token: 0x06000372 RID: 882 RVA: 0x000029DF File Offset: 0x00000BDF
		private void LookAtInteraction(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		// Token: 0x06000373 RID: 883 RVA: 0x000029E1 File Offset: 0x00000BE1
		public void OnTriggerEnter(Collider c)
		{
		}

		// Token: 0x06000374 RID: 884 RVA: 0x000029E3 File Offset: 0x00000BE3
		public void OnTriggerExit(Collider c)
		{
		}

		// Token: 0x06000375 RID: 885 RVA: 0x000029E5 File Offset: 0x00000BE5
		private bool ContactIsInRange(int index, out int bestRangeIndex)
		{
			bestRangeIndex = 0;
			return false;
		}

		// Token: 0x06000376 RID: 886 RVA: 0x000029EF File Offset: 0x00000BEF
		private void OnDrawGizmosSelected()
		{
		}

		// Token: 0x06000377 RID: 887 RVA: 0x000029F1 File Offset: 0x00000BF1
		private void Update()
		{
		}

		// Token: 0x06000378 RID: 888 RVA: 0x000029F3 File Offset: 0x00000BF3
		private void Raycasting()
		{
		}

		// Token: 0x06000379 RID: 889 RVA: 0x000029F5 File Offset: 0x00000BF5
		private void UpdateTriggerEventBroadcasting()
		{
		}

		// Token: 0x0600037A RID: 890 RVA: 0x000029F7 File Offset: 0x00000BF7
		private void UpdateEffectors()
		{
		}

		// Token: 0x0600037B RID: 891 RVA: 0x000029F9 File Offset: 0x00000BF9
		private void OnPreFBBIK()
		{
		}

		// Token: 0x0600037C RID: 892 RVA: 0x000029FB File Offset: 0x00000BFB
		private void OnPostFBBIK()
		{
		}

		// Token: 0x0600037D RID: 893 RVA: 0x000029FD File Offset: 0x00000BFD
		private void OnFixTransforms()
		{
		}

		// Token: 0x0600037E RID: 894 RVA: 0x000029FF File Offset: 0x00000BFF
		private void OnDestroy()
		{
		}

		// Token: 0x0600037F RID: 895 RVA: 0x00002A01 File Offset: 0x00000C01
		private bool IsValid(bool log)
		{
			return false;
		}

		// Token: 0x06000380 RID: 896 RVA: 0x00002A04 File Offset: 0x00000C04
		private bool TriggerIndexIsValid(int index)
		{
			return false;
		}

		// Token: 0x06000381 RID: 897 RVA: 0x00002A07 File Offset: 0x00000C07
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		// Token: 0x06000382 RID: 898 RVA: 0x00002A09 File Offset: 0x00000C09
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		// Token: 0x040002DC RID: 732
		[Tooltip("If not empty, only the targets with the specified tag will be used by this Interaction System.")]
		public string targetTag;

		// Token: 0x040002DD RID: 733
		[Tooltip("The fade in time of the interaction.")]
		public float fadeInTime;

		// Token: 0x040002DE RID: 734
		[Tooltip("The master speed for all interactions.")]
		public float speed;

		// Token: 0x040002DF RID: 735
		[Tooltip("If > 0, lerps all the FBBIK channels used by the Interaction System back to their default or initial values when not in interaction.")]
		public float resetToDefaultsSpeed;

		// Token: 0x040002E0 RID: 736
		[FormerlySerializedAs("collider")]
		[Tooltip("The collider that registers OnTriggerEnter and OnTriggerExit events with InteractionTriggers.")]
		[Header("Triggering")]
		public Collider characterCollider;

		// Token: 0x040002E1 RID: 737
		[FormerlySerializedAs("camera")]
		[Tooltip("Will be used by Interaction Triggers that need the camera's position. Assign the first person view character camera.")]
		public Transform FPSCamera;

		// Token: 0x040002E2 RID: 738
		[Tooltip("The layers that will be raycasted from the camera (along camera.forward). All InteractionTrigger look at target colliders should be included.")]
		public LayerMask camRaycastLayers;

		// Token: 0x040002E3 RID: 739
		[Tooltip("Max distance of raycasting from the camera.")]
		public float camRaycastDistance;

		// Token: 0x040002E5 RID: 741
		private List<InteractionTrigger> inContact;

		// Token: 0x040002E6 RID: 742
		private List<int> bestRangeIndexes;

		// Token: 0x040002E7 RID: 743
		public InteractionSystem.InteractionDelegate OnInteractionStart;

		// Token: 0x040002E8 RID: 744
		public InteractionSystem.InteractionDelegate OnInteractionPause;

		// Token: 0x040002E9 RID: 745
		public InteractionSystem.InteractionDelegate OnInteractionPickUp;

		// Token: 0x040002EA RID: 746
		public InteractionSystem.InteractionDelegate OnInteractionResume;

		// Token: 0x040002EB RID: 747
		public InteractionSystem.InteractionDelegate OnInteractionStop;

		// Token: 0x040002EC RID: 748
		public InteractionSystem.InteractionEventDelegate OnInteractionEvent;

		// Token: 0x040002ED RID: 749
		public RaycastHit raycastHit;

		// Token: 0x040002EE RID: 750
		[Tooltip("Reference to the FBBIK component.")]
		[Space(10f)]
		[SerializeField]
		private FullBodyBipedIK fullBody;

		// Token: 0x040002EF RID: 751
		[Tooltip("Handles looking at the interactions.")]
		public InteractionLookAt lookAt;

		// Token: 0x040002F0 RID: 752
		private InteractionEffector[] interactionEffectors;

		// Token: 0x040002F1 RID: 753
		private bool initiated;

		// Token: 0x040002F2 RID: 754
		private Collider lastCollider;

		// Token: 0x040002F3 RID: 755
		private Collider c;

		// Token: 0x0200009F RID: 159
		// (Invoke) Token: 0x06000521 RID: 1313
		public delegate void InteractionDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject);

		// Token: 0x020000A0 RID: 160
		// (Invoke) Token: 0x06000523 RID: 1315
		public delegate void InteractionEventDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject, InteractionObject.InteractionEvent interactionEvent);
	}
}
