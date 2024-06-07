using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class VRSInfoSwitch : MonoBehaviour
	{
		public TextMeshProUGUI VRSSupportMessage;

		[TextArea(4, 4)]
		public string VRSSupportedText;

		[TextArea(4, 4)]
		public string VRSUnsupportedText;

		[TextArea(4, 4)]
		public string RDMText;

		public GameObject Legend;

		public GameObject[] LegendItems;

		private bool isVRSSupported;

		private static Dictionary<int, int> shadingRate;

		private void OnEnable()
		{
		}

		public void UpdateMessages()
		{
		}
	}
}
