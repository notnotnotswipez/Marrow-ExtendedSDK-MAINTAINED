using UnityEngine;

namespace SLZ.Bonelab
{
	[RequireComponent(typeof(TrailRenderer))]
	public class TrailTimescale : MonoBehaviour
	{
		[SerializeField]
		[HideInInspector]
		private TrailRenderer TR;

		[SerializeField]
		[Tooltip("Number of frames the trail will appear")]
		private float TrailSize;

		private void OnValidate()
		{
		}

		private void Update()
		{
		}
	}
}
