using SLZ.Marrow;
using UnityEngine;

namespace SLZ.Interaction
{
	public class Slide : MonoBehaviour
	{
		[Tooltip("Axis is realtive to parent")]
		[Header("Options")]
		public Vector3 slideAxis;

		public float limit;

		[Header("References")]
		public Grip slideGrip;
	}
}
