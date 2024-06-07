using SLZ.Data;
using UnityEngine;

namespace SLZ.Interaction
{
	public class LadderVirtualController : MonoBehaviour
	{
		[Tooltip("The climbing direction of the ladder locally")]
		public Vector3 direction;

		[Tooltip("The facing direction of the ladder locally")]
		public Vector3 normal;

		public HandPose handPose;

		public PhysicMaterial ladderFeetPhysicMaterial;

		public float sideMemberOffset;

		public float sideMemberHeight;

		public float sideMemberWidth;

		public float sideMemberRadius;

		public float rungHeight;

		public float rungWidth;

		public float rungRadius;

		public float rungOffset;

		public int rungCount;

		public Transform firstRung;

		private InteractableHost host;

		private void Awake()
		{
		}

		[ContextMenu("GenerateGrips")]
		public void GenerateGrips()
		{
		}

		private void OnDrawGizmos()
		{
		}

		private void GenerateFeetCollider(Vector3 start, Vector3 end, Vector3 normal, float thickness, float width, GameObject gripContainer)
		{
		}

		private void GenerateGrip(Vector3 center, Quaternion rotation, GameObject gripContainer, float radius, float width)
		{
		}

		private void GenerateLadderGrips()
		{
		}

		public void GetLadderInfo(out LadderInfo info, LadderInfo.Source source)
		{
			info = default(LadderInfo);
		}

		private void FixedUpdate()
		{
		}
	}
}
