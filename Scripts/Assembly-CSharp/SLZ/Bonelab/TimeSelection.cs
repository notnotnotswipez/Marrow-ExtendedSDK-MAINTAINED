using UnityEngine;

namespace SLZ.Bonelab
{
	public class TimeSelection : MonoBehaviour
	{
		public GameObject FullSpeed;

		public GameObject SlowSpeed;

		[SerializeField]
		private float slowTimeTrigger;

		private void OnEnable()
		{
		}
	}
}
