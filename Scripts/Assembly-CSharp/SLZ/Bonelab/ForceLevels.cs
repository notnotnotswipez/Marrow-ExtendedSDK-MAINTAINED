using UnityEngine;

namespace SLZ.Bonelab
{
	public class ForceLevels : MonoBehaviour
	{
		[Header("Oculus Settings")]
		[SerializeField]
		private OVRPlugin.ColorSpace QuestColorSpace;

		private void Awake()
		{
		}
	}

	public class OVRPlugin
	{
		public class ColorSpace
		{
		}
	}
}
