using UnityEngine;

namespace SLZ.MLAgents
{
	public class ConeCheck : MonoBehaviour
	{
		public float force_coef;

		public GameObject emit_point;

		public float cast_length;

		public float max_radius;

		private Vector3 emit_pos;

		private Vector3 emit_axis;

		public string detected_tag;

		private void Start()
		{
		}

		private void OnDrawGizmos()
		{
		}

		private bool CheckInsideCone(Vector3 point)
		{
			return false;
		}

		public void ForcePush()
		{
		}

		private void FixedUpdate()
		{
		}
	}
}
