using System;
using System.Collections.Generic;
using SLZ.Marrow.Utilities;
using Unity.Mathematics;
using UnityEngine;

namespace SLZ.Marrow.Interaction
{
	// Token: 0x0200014A RID: 330
	[RequireComponent(typeof(Rigidbody))]
	public class SplineJoint : MonoBehaviour
	{
		// Token: 0x17000206 RID: 518
		// (get) Token: 0x06000BEC RID: 3052 RVA: 0x00007D2C File Offset: 0x00005F2C
		private Quaternion AnchorRotation
		{
			get
			{
				return default(Quaternion);
			}
		}

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x06000BED RID: 3053 RVA: 0x00007D44 File Offset: 0x00005F44
		private Vector3 Size
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000208 RID: 520
		// (get) Token: 0x06000BEE RID: 3054 RVA: 0x00007D5C File Offset: 0x00005F5C
		private Vector3 FrontContact
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x06000BEF RID: 3055 RVA: 0x00007D74 File Offset: 0x00005F74
		private Vector3 RightContact
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x06000BF0 RID: 3056 RVA: 0x00004875 File Offset: 0x00002A75
		private void Reset()
		{
		}

		// Token: 0x06000BF1 RID: 3057 RVA: 0x00004877 File Offset: 0x00002A77
		private void Awake()
		{
		}

		// Token: 0x06000BF2 RID: 3058 RVA: 0x00004879 File Offset: 0x00002A79
		private void OnDisable()
		{
		}

		// Token: 0x06000BF3 RID: 3059 RVA: 0x0000487B File Offset: 0x00002A7B
		private void OnEnable()
		{
		}

		// Token: 0x06000BF4 RID: 3060 RVA: 0x0000487D File Offset: 0x00002A7D
		private void OnDestroy()
		{
		}

		// Token: 0x06000BF5 RID: 3061 RVA: 0x0000487F File Offset: 0x00002A7F
		public void SetAngularXDriveSpeed(float speed)
		{
		}

		// Token: 0x06000BF6 RID: 3062 RVA: 0x00004881 File Offset: 0x00002A81
		public void SetAngularXDrivePositionSpring(float springForce)
		{
		}

		// Token: 0x06000BF7 RID: 3063 RVA: 0x00004883 File Offset: 0x00002A83
		public void SetAngularXDrivePositionDamper(float damperForce)
		{
		}

		// Token: 0x06000BF8 RID: 3064 RVA: 0x00004885 File Offset: 0x00002A85
		public void SetAngularXDriveMaxForce(float maxForce)
		{
		}

		// Token: 0x06000BF9 RID: 3065 RVA: 0x00004887 File Offset: 0x00002A87
		public void SetYZDrivePositionSpring(float springForce)
		{
		}

		// Token: 0x06000BFA RID: 3066 RVA: 0x00004889 File Offset: 0x00002A89
		public void SetYZDrivePositionDamper(float damperForce)
		{
		}

		// Token: 0x06000BFB RID: 3067 RVA: 0x0000488B File Offset: 0x00002A8B
		public void SetYZDriveMaxForce(float maxForce)
		{
		}

		// Token: 0x06000BFC RID: 3068 RVA: 0x0000488D File Offset: 0x00002A8D
		public void SetLinearXDriveSpeed(float speed)
		{
		}

		// Token: 0x06000BFD RID: 3069 RVA: 0x0000488F File Offset: 0x00002A8F
		public void SetLinearXDrivePositionDamper(float damperForce)
		{
		}

		// Token: 0x06000BFE RID: 3070 RVA: 0x00004891 File Offset: 0x00002A91
		public void SetLinearXDriveMaxForce(float maxForce)
		{
		}

		// Token: 0x06000BFF RID: 3071 RVA: 0x00007D8C File Offset: 0x00005F8C
		private static quaternion SynthesizeRotation(float3 right, float3 up)
		{
			return default(quaternion);
		}

		// Token: 0x06000C00 RID: 3072 RVA: 0x00004893 File Offset: 0x00002A93
		private void Update()
		{
		}

		// Token: 0x06000C01 RID: 3073 RVA: 0x00004895 File Offset: 0x00002A95
		private void Solve()
		{
		}

		// Token: 0x06000C02 RID: 3074 RVA: 0x00004897 File Offset: 0x00002A97
		private void AttachToBackPoint(float3 position, quaternion rotation)
		{
		}

		// Token: 0x06000C03 RID: 3075 RVA: 0x00004899 File Offset: 0x00002A99
		private bool IsBodyInverted(quaternion anchorRotation, quaternion rotation)
		{
			return false;
		}

		// Token: 0x06000C04 RID: 3076 RVA: 0x0000489C File Offset: 0x00002A9C
		private void CalculateTwoPointContact(float3 worldPos, out float3 frontPosition, out float3 backPosition, out quaternion lookRotation, out quaternion frontRotation, out quaternion backRotation, out int frontIndex, out bool isFrontCapped, out bool isBackCapped)
		{
			frontPosition = default(float3);
			backPosition = default(float3);
			lookRotation = default(quaternion);
			frontRotation = default(quaternion);
			backRotation = default(quaternion);
			frontIndex = 0;
			isFrontCapped = default(bool);
			isBackCapped = default(bool);
		}

		// Token: 0x06000C05 RID: 3077 RVA: 0x000048DC File Offset: 0x00002ADC
		private void Attach()
		{
		}

		// Token: 0x06000C06 RID: 3078 RVA: 0x000048DE File Offset: 0x00002ADE
		private void RefreshContactConfig()
		{
		}

		// Token: 0x06000C07 RID: 3079 RVA: 0x00007DA4 File Offset: 0x00005FA4
		public SimpleTransform GetContactOriginInWorld()
		{
			return default(SimpleTransform);
		}

		// Token: 0x06000C08 RID: 3080 RVA: 0x000048E0 File Offset: 0x00002AE0
		public void PlaceOnSpline()
		{
		}

		// Token: 0x06000C09 RID: 3081 RVA: 0x000048E2 File Offset: 0x00002AE2
		public void SetPolyLine(PolyLine polyline)
		{
		}

		// Token: 0x04000744 RID: 1860
		private static float3 _right;

		// Token: 0x04000745 RID: 1861
		private static float3 _up;

		// Token: 0x04000746 RID: 1862
		private static float3 _forward;

		// Token: 0x04000747 RID: 1863
		[Header("Configuration")]
		[SerializeField]
		private ContactCount _contactCount;

		// Token: 0x04000748 RID: 1864
		[SerializeField]
		private Vector3 _axis;

		// Token: 0x04000749 RID: 1865
		[SerializeField]
		private Vector3 _secondaryAxis;

		// Token: 0x0400074A RID: 1866
		[SerializeField]
		private Vector2 _size;

		// Token: 0x0400074B RID: 1867
		[SerializeField]
		private Vector3 _anchor;

		// Token: 0x0400074C RID: 1868
		[SerializeField]
		[Space(15f)]
		private float _linearXDriveSpeed;

		// Token: 0x0400074D RID: 1869
		[SerializeField]
		private DampenContactDrive _linearXDrive;

		// Token: 0x0400074E RID: 1870
		[Space(15f)]
		[SerializeField]
		[Tooltip("Sets rotational twist motion on the configured axis")]
		private ConfigurableJointMotion _angularXMotion;

		// Token: 0x0400074F RID: 1871
		[Range(-177f, 177f)]
		[SerializeField]
		private float _angularXMinLimit;

		// Token: 0x04000750 RID: 1872
		[Range(-177f, 177f)]
		[SerializeField]
		private float _angularXMaxLimit;

		// Token: 0x04000751 RID: 1873
		[SerializeField]
		private float _angularXDriveSpeed;

		// Token: 0x04000752 RID: 1874
		[SerializeField]
		private SpringContactDrive _angularXDrive;

		// Token: 0x04000753 RID: 1875
		[SerializeField]
		[Space(15f)]
		private SplineJointMotion _linearYZMotion;

		// Token: 0x04000754 RID: 1876
		[SerializeField]
		private SoftSplineJointLimit _linearYZLimit;

		// Token: 0x04000755 RID: 1877
		[SerializeField]
		private SpringContactDrive _linearYZDrive;

		// Token: 0x04000756 RID: 1878
		[SerializeField]
		[Space(15f)]
		[Tooltip("Sets rotational swing motion on the configured axis")]
		private ConfigurableJointMotion _angularYZMotion;

		// Token: 0x04000757 RID: 1879
		[Range(0f, 177f)]
		[SerializeField]
		private float _angularYZLimit;

		// Token: 0x04000758 RID: 1880
		[SerializeField]
		private SpringContactDrive _angularYZDrive;

		// Token: 0x04000759 RID: 1881
		[Header("References")]
		[SerializeField]
		private Rigidbody _rigidbody;

		// Token: 0x0400075A RID: 1882
		[SerializeField]
		private PolyLine polyLine;

		// Token: 0x0400075B RID: 1883
		private List<Contact> _contacts;

		// Token: 0x0400075C RID: 1884
		private int _curSplineIndex;
	}
}
