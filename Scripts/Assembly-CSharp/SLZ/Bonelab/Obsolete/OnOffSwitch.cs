using UnityEngine;

namespace SLZ.Bonelab.Obsolete
{
	public class OnOffSwitch : MonoBehaviour
	{
		public Powerable[] ElectricalObj;

		private void Awake()
		{
		}

		public virtual void OnOffEvent(bool isOn)
		{
		}

		protected void OnDestroy()
		{
		}
	}
}
