using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SLZ.Marrow.PuppetMasta
{
	// Token: 0x020000E6 RID: 230
	public class PressureSensor : MonoBehaviour
	{
		// Token: 0x17000193 RID: 403
		// (get) Token: 0x06000892 RID: 2194 RVA: 0x00007594 File Offset: 0x00005794
		// (set) Token: 0x06000893 RID: 2195 RVA: 0x00003F67 File Offset: 0x00002167
		public Vector3 center
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

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x06000894 RID: 2196 RVA: 0x00003F69 File Offset: 0x00002169
		// (set) Token: 0x06000895 RID: 2197 RVA: 0x00003F6C File Offset: 0x0000216C
		public bool inContact
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x06000896 RID: 2198 RVA: 0x000075AC File Offset: 0x000057AC
		// (set) Token: 0x06000897 RID: 2199 RVA: 0x00003F6E File Offset: 0x0000216E
		public Vector3 bottom
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

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x06000898 RID: 2200 RVA: 0x00003F70 File Offset: 0x00002170
		// (set) Token: 0x06000899 RID: 2201 RVA: 0x00003F73 File Offset: 0x00002173
		public Rigidbody r
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

		// Token: 0x0600089A RID: 2202 RVA: 0x00003F75 File Offset: 0x00002175
		private void Awake()
		{
		}

		// Token: 0x0600089B RID: 2203 RVA: 0x00003F77 File Offset: 0x00002177
		private void OnCollisionEnter(Collision c)
		{
		}

		// Token: 0x0600089C RID: 2204 RVA: 0x00003F79 File Offset: 0x00002179
		private void OnCollisionStay(Collision c)
		{
		}

		// Token: 0x0600089D RID: 2205 RVA: 0x00003F7B File Offset: 0x0000217B
		private void OnCollisionExit(Collision c)
		{
		}

		// Token: 0x0600089E RID: 2206 RVA: 0x00003F7D File Offset: 0x0000217D
		private void FixedUpdate()
		{
		}

		// Token: 0x0600089F RID: 2207 RVA: 0x00003F7F File Offset: 0x0000217F
		private void LateUpdate()
		{
		}

		// Token: 0x060008A0 RID: 2208 RVA: 0x00003F81 File Offset: 0x00002181
		private void ProcessCollision(Collision c)
		{
		}

		// Token: 0x060008A1 RID: 2209 RVA: 0x00003F83 File Offset: 0x00002183
		private void OnDrawGizmos()
		{
		}

		// Token: 0x04000568 RID: 1384
		public bool visualize;

		// Token: 0x04000569 RID: 1385
		public LayerMask layers;

		// Token: 0x0400056E RID: 1390
		private bool fixedFrame;

		// Token: 0x0400056F RID: 1391
		private Vector3 P;

		// Token: 0x04000570 RID: 1392
		private int count;
	}
}
