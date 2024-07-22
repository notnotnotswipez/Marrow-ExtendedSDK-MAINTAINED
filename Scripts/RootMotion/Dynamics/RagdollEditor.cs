using System;
using UnityEngine;

namespace RootMotion.Dynamics
{
	// Token: 0x02000016 RID: 22
	[AddComponentMenu("Scripts/RootMotion.Dynamics/Ragdoll Manager/Ragdoll Editor")]
	[HelpURL("https://www.youtube.com/watch?v=y-luLRVmL7E&index=1&list=PLVxSIA1OaTOuE2SB9NUbckQ9r2hTg4mvL")]
	public class RagdollEditor : MonoBehaviour
	{
		// Token: 0x06000093 RID: 147 RVA: 0x00002242 File Offset: 0x00000442
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00002244 File Offset: 0x00000444
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00002246 File Offset: 0x00000446
		[ContextMenu("TUTORIAL VIDEO")]
		private void OpenTutorial()
		{
		}

		// Token: 0x04000064 RID: 100
		[HideInInspector]
		public Rigidbody selectedRigidbody;

		// Token: 0x04000065 RID: 101
		[HideInInspector]
		public Collider selectedCollider;

		// Token: 0x04000066 RID: 102
		[HideInInspector]
		public bool symmetry;

		// Token: 0x04000067 RID: 103
		[HideInInspector]
		public RagdollEditor.Mode mode;

		// Token: 0x0200007A RID: 122
		[Serializable]
		public enum Mode
		{
			// Token: 0x040003C3 RID: 963
			Colliders,
			// Token: 0x040003C4 RID: 964
			Joints
		}
	}
}
