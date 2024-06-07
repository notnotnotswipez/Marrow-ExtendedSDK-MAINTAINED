using SLZ.Marrow.Pool;
using SLZ.Marrow.Utilities;
using UnityEngine;

namespace SLZ.Utilities
{
	[RequireComponent(typeof(Poolee))]
	public class DespawnOnJointBreak : MonoBehaviour
	{
		[ReadOnly(false)]
		public Poolee poolee;

		public void OnJointBreak(float breakForce)
		{
		}

		private void Reset()
		{
		}
	}
}
