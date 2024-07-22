using UnityEngine;

namespace SLZ.Bonelab
{
	[RequireComponent(typeof(Renderer))]
	public class PlatformMaterial : MonoBehaviour
	{
		[SerializeField]
		private Renderer TargetRenderer;

		[SerializeField]
		[Space(20f)]
		private Material Android;

		[SerializeField]
		private Material PC;

		private void Awake()
		{
		}

		private void Reset()
		{
		}
	}
}
