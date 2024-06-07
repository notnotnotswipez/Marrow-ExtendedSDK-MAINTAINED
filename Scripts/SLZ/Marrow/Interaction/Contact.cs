using System;
using SLZ.Marrow.Utilities;
using Unity.Mathematics;
using UnityEngine;

namespace SLZ.Marrow.Interaction
{
	// Token: 0x02000143 RID: 323
	public class Contact
	{
		// Token: 0x17000204 RID: 516
		// (get) Token: 0x06000BC0 RID: 3008 RVA: 0x00007D14 File Offset: 0x00005F14
		public SimpleTransform Transform
		{
			get
			{
				return default(SimpleTransform);
			}
		}

		// Token: 0x06000BC1 RID: 3009 RVA: 0x00004799 File Offset: 0x00002999
		public Contact(Rigidbody hostBody, Vector3 anchorPosition, Quaternion anchorRotation, ConfigurableJointMotion twistMotion = ConfigurableJointMotion.Free, float twistMinLimit = 0f, float twistMaxLimit = 0f, ConfigurableJointMotion swingMotion = ConfigurableJointMotion.Free, float swingLimit = 0f, SplineJointMotion linearYZMotion = SplineJointMotion.Locked, float limit = 0f, float bounciness = 0f, float contactDistance = 0f)
		{
		}

		// Token: 0x06000BC2 RID: 3010 RVA: 0x000047A1 File Offset: 0x000029A1
		public void Disable()
		{
		}

		// Token: 0x06000BC3 RID: 3011 RVA: 0x000047A3 File Offset: 0x000029A3
		public void Enable()
		{
		}

		// Token: 0x06000BC4 RID: 3012 RVA: 0x000047A5 File Offset: 0x000029A5
		public void Destroy()
		{
		}

		// Token: 0x06000BC5 RID: 3013 RVA: 0x000047A7 File Offset: 0x000029A7
		public void SetPositionAndRotation(Vector3 position, Quaternion rotation)
		{
		}

		// Token: 0x06000BC6 RID: 3014 RVA: 0x000047A9 File Offset: 0x000029A9
		public void LimitDirection(float limit, bool isForward = true)
		{
		}

		// Token: 0x06000BC7 RID: 3015 RVA: 0x000047AB File Offset: 0x000029AB
		public void FreeDirection()
		{
		}

		// Token: 0x06000BC8 RID: 3016 RVA: 0x000047AD File Offset: 0x000029AD
		public void SwingTwistSpringStabilization()
		{
		}

		// Token: 0x06000BC9 RID: 3017 RVA: 0x000047AF File Offset: 0x000029AF
		public void WakeUp()
		{
		}

		// Token: 0x06000BCA RID: 3018 RVA: 0x000047B1 File Offset: 0x000029B1
		public void SetAngularXDriveSpeed(float speed)
		{
		}

		// Token: 0x06000BCB RID: 3019 RVA: 0x000047B3 File Offset: 0x000029B3
		public void SetAngularXDrivePositionSpring(float springForce)
		{
		}

		// Token: 0x06000BCC RID: 3020 RVA: 0x000047B5 File Offset: 0x000029B5
		public void SetAngularXDrivePositionDamper(float damperForce)
		{
		}

		// Token: 0x06000BCD RID: 3021 RVA: 0x000047B7 File Offset: 0x000029B7
		public void SetAngularXDriveMaxForce(float maximumForce)
		{
		}

		// Token: 0x06000BCE RID: 3022 RVA: 0x000047B9 File Offset: 0x000029B9
		public void SetAngularYZDrivePositionSpring(float springForce)
		{
		}

		// Token: 0x06000BCF RID: 3023 RVA: 0x000047BB File Offset: 0x000029BB
		public void SetAngularYZDrivePositionDamper(float damperForce)
		{
		}

		// Token: 0x06000BD0 RID: 3024 RVA: 0x000047BD File Offset: 0x000029BD
		public void SetAngularYZDriveMaxForce(float maximumForce)
		{
		}

		// Token: 0x06000BD1 RID: 3025 RVA: 0x000047BF File Offset: 0x000029BF
		public void SetLinearXDriveSpeed(float speed)
		{
		}

		// Token: 0x06000BD2 RID: 3026 RVA: 0x000047C1 File Offset: 0x000029C1
		public void SetLinearXDrivePositionDamper(float damperForce)
		{
		}

		// Token: 0x06000BD3 RID: 3027 RVA: 0x000047C3 File Offset: 0x000029C3
		public void SetLinearXDriveMaxForce(float maximumForce)
		{
		}

		// Token: 0x06000BD4 RID: 3028 RVA: 0x000047C5 File Offset: 0x000029C5
		public void SetLinearYZDrivePositionSpring(float springForce)
		{
		}

		// Token: 0x06000BD5 RID: 3029 RVA: 0x000047C7 File Offset: 0x000029C7
		public void SetLinearYZDrivePositionDamper(float damperForce)
		{
		}

		// Token: 0x06000BD6 RID: 3030 RVA: 0x000047C9 File Offset: 0x000029C9
		public void SetLinearYZDriveMaxForce(float maximumForce)
		{
		}

		// Token: 0x04000723 RID: 1827
		private static readonly float CONTACT_UPDATE_DISTANCE_SQR;

		// Token: 0x04000724 RID: 1828
		private readonly Rigidbody _rigidbody;

		// Token: 0x04000725 RID: 1829
		private readonly Rigidbody _hostBody;

		// Token: 0x04000726 RID: 1830
		private readonly ConfigurableJoint _joint;

		// Token: 0x04000727 RID: 1831
		private readonly Vector3 _anchorPosition;

		// Token: 0x04000728 RID: 1832
		private readonly quaternion _anchorRotation;

		// Token: 0x04000729 RID: 1833
		private readonly quaternion _startRotation;

		// Token: 0x0400072A RID: 1834
		private readonly quaternion _worldToJointSpace;

		// Token: 0x0400072B RID: 1835
		private Quaternion _disabledRotation;
	}
}
