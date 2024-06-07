using UnityEngine;

namespace SLZ.MLAgents
{
	public class ForceReader : MonoBehaviour
	{
		[SerializeField]
		private string tagToDetect;

		private void OnCollisionEnter(Collision col)
		{
		}
	}
}
