using UnityEngine;

namespace SLZ.Interaction
{
	public class Key : MonoBehaviour
	{
		[EnumFlags]
		public KeyReceiver.Code code;
	}
}
