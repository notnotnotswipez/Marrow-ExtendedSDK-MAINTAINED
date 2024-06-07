using UnityEngine;

namespace SLZ.Bonelab
{
	public class ToggleObjectOnBake : MonoBehaviour
	{
		[Header("This script turns on the object it is attached to during lightmap baking")]
		public bool ToggleOffOnBakeInstead;
	}
}
