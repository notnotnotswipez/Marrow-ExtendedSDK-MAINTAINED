using UnityEngine;

namespace Unity.MLAgents
{
	[DisallowMultipleComponent]
	public class TargetContact : MonoBehaviour
	{
		[Header("Detect Targets")]
		public bool touchingTarget;

		private const string k_Target = "target";

		private void OnCollisionEnter(Collision col)
		{
		}

		private void OnCollisionExit(Collision other)
		{
		}
	}
}
