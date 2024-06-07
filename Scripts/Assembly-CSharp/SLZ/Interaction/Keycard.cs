using UnityEngine;

namespace SLZ.Interaction
{
	public class Keycard : MonoBehaviour
	{
		[EnumFlags]
		public KeycardReceiver.Code code;
	}
}
