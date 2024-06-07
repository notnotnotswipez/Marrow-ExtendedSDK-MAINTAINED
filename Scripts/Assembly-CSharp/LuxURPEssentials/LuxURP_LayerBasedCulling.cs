using UnityEngine;

namespace LuxURPEssentials
{
	public class LuxURP_LayerBasedCulling : MonoBehaviour
	{
		[LuxURP_HelpBtn("h.2uxuzzrgrwpo", order = 0)]
		[Space(5f, order = 1)]
		public LayerMask SmallDetailsLayer;

		public float SmallDetailsDistance;

		public LayerMask MediumDetailsLayer;

		public float MediumDetailsDistance;

		private int GetLayerNumber(int LayerValue)
		{
			return 0;
		}

		private void OnEnable()
		{
		}
	}
}
