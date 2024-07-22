using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000056 RID: 86
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Interaction System/Interaction Trigger")]
	[HelpURL("https://www.youtube.com/watch?v=-TDZpNjt2mk&index=15&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6")]
	public class InteractionTrigger : MonoBehaviour
	{
		// Token: 0x06000390 RID: 912 RVA: 0x00002A36 File Offset: 0x00000C36
		[ContextMenu("TUTORIAL VIDEO")]
		private void OpenTutorial4()
		{
		}

		// Token: 0x06000391 RID: 913 RVA: 0x00002A38 File Offset: 0x00000C38
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		// Token: 0x06000392 RID: 914 RVA: 0x00002A3A File Offset: 0x00000C3A
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		// Token: 0x06000393 RID: 915 RVA: 0x00002A3C File Offset: 0x00000C3C
		private void Start()
		{
		}

		// Token: 0x06000394 RID: 916 RVA: 0x00002A3E File Offset: 0x00000C3E
		public int GetBestRangeIndex(Transform character, Transform raycastFrom, RaycastHit raycastHit)
		{
			return 0;
		}

		// Token: 0x040002FE RID: 766
		[Tooltip("The valid ranges of the character's and/or it's camera's position for triggering interaction when the character is in contact with the collider of this trigger.")]
		public InteractionTrigger.Range[] ranges;

		// Token: 0x020000A2 RID: 162
		[Serializable]
		public class CharacterPosition
		{
			// Token: 0x17000082 RID: 130
			// (get) Token: 0x06000525 RID: 1317 RVA: 0x00003D34 File Offset: 0x00001F34
			public Vector3 offset3D
			{
				get
				{
					return default(Vector3);
				}
			}

			// Token: 0x17000083 RID: 131
			// (get) Token: 0x06000526 RID: 1318 RVA: 0x00003D4C File Offset: 0x00001F4C
			public Vector3 direction3D
			{
				get
				{
					return default(Vector3);
				}
			}

			// Token: 0x06000527 RID: 1319 RVA: 0x00002E94 File Offset: 0x00001094
			public bool IsInRange(Transform character, Transform trigger, out float error)
			{
				error = 0f;
				return false;
			}

			// Token: 0x04000510 RID: 1296
			[Tooltip("If false, will not care where the character stands, as long as it is in contact with the trigger collider.")]
			public bool use;

			// Token: 0x04000511 RID: 1297
			[Tooltip("The offset of the character's position relative to the trigger in XZ plane. Y position of the character is unlimited as long as it is contact with the collider.")]
			public Vector2 offset;

			// Token: 0x04000512 RID: 1298
			[Range(-180f, 180f)]
			[Tooltip("Angle offset from the default forward direction.")]
			public float angleOffset;

			// Token: 0x04000513 RID: 1299
			[Tooltip("Max angular offset of the character's forward from the direction of this trigger.")]
			[Range(0f, 180f)]
			public float maxAngle;

			// Token: 0x04000514 RID: 1300
			[Tooltip("Max offset of the character's position from this range's center.")]
			public float radius;

			// Token: 0x04000515 RID: 1301
			[Tooltip("If true, will rotate the trigger around it's Y axis relative to the position of the character, so the object can be interacted with from all sides.")]
			public bool orbit;

			// Token: 0x04000516 RID: 1302
			[Tooltip("Fixes the Y axis of the trigger to Vector3.up. This makes the trigger symmetrical relative to the object. For example a gun will be able to be picked up from the same direction relative to the barrel no matter which side the gun is resting on.")]
			public bool fixYAxis;
		}

		// Token: 0x020000A3 RID: 163
		[Serializable]
		public class CameraPosition
		{
			// Token: 0x06000529 RID: 1321 RVA: 0x00003D64 File Offset: 0x00001F64
			public Quaternion GetRotation()
			{
				return default(Quaternion);
			}

			// Token: 0x0600052A RID: 1322 RVA: 0x00002EA6 File Offset: 0x000010A6
			public bool IsInRange(Transform raycastFrom, RaycastHit hit, Transform trigger, out float error)
			{
				error = 0f;
				return false;
			}

			// Token: 0x04000517 RID: 1303
			[Tooltip("What the camera should be looking at to trigger the interaction? If null, this camera position will not be used.")]
			public Collider lookAtTarget;

			// Token: 0x04000518 RID: 1304
			[Tooltip("The direction from the lookAtTarget towards the camera (in lookAtTarget's space).")]
			public Vector3 direction;

			// Token: 0x04000519 RID: 1305
			[Tooltip("Max distance from the lookAtTarget to the camera.")]
			public float maxDistance;

			// Token: 0x0400051A RID: 1306
			[Range(0f, 180f)]
			[Tooltip("Max angle between the direction and the direction towards the camera.")]
			public float maxAngle;

			// Token: 0x0400051B RID: 1307
			[Tooltip("Fixes the Y axis of the trigger to Vector3.up. This makes the trigger symmetrical relative to the object.")]
			public bool fixYAxis;
		}

		// Token: 0x020000A4 RID: 164
		[Serializable]
		public class Range
		{
			// Token: 0x0600052C RID: 1324 RVA: 0x00002EB9 File Offset: 0x000010B9
			public bool IsInRange(Transform character, Transform raycastFrom, RaycastHit raycastHit, Transform trigger, out float maxError)
			{
				maxError = 0f;
				return false;
			}

			// Token: 0x0400051C RID: 1308
			[HideInInspector]
			[SerializeField]
			public string name;

			// Token: 0x0400051D RID: 1309
			[HideInInspector]
			[SerializeField]
			public bool show;

			// Token: 0x0400051E RID: 1310
			[Tooltip("The range for the character's position and rotation.")]
			public InteractionTrigger.CharacterPosition characterPosition;

			// Token: 0x0400051F RID: 1311
			[Tooltip("The range for the character camera's position and rotation.")]
			public InteractionTrigger.CameraPosition cameraPosition;

			// Token: 0x04000520 RID: 1312
			[Tooltip("Definitions of the interactions associated with this range.")]
			public InteractionTrigger.Range.Interaction[] interactions;

			// Token: 0x020000C1 RID: 193
			[Serializable]
			public class Interaction
			{
				// Token: 0x040005B5 RID: 1461
				[Tooltip("The InteractionObject to interact with.")]
				public InteractionObject interactionObject;

				// Token: 0x040005B6 RID: 1462
				[Tooltip("The effectors to interact with.")]
				public FullBodyBipedEffector[] effectors;
			}
		}
	}
}
