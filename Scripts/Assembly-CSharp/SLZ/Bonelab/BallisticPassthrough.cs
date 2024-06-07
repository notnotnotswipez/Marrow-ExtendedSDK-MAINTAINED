using UnityEngine;

namespace SLZ.Bonelab
{
	public class BallisticPassthrough : MonoBehaviour
	{
		public bool isPassthrough;

		public Vector3 Normal => default(Vector3);

		public bool Evaluate(RaycastHit hit)
		{
			return false;
		}
	}
}
