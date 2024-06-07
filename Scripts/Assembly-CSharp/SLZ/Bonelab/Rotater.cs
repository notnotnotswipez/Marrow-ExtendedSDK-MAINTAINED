using UnityEngine;
using UnityEngine.Serialization;

namespace SLZ.Bonelab
{
	public class Rotater : MonoBehaviour
	{
		[FormerlySerializedAs("m_EulerSpeed")]
		public Vector3 EulerSpeed;

		[SerializeField]
		private bool localSpace;

		private void Update()
		{
		}
	}
}
