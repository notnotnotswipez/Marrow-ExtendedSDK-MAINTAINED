using UnityEngine;

namespace SLZ.Bonelab.Obsolete
{
	public class TriggerSwitch : OnOffSwitch
	{
		public bool momentary;

		public int layer;

		public Collider col_Pin;

		public float voltage;

		private bool OnOff;

		public GameObject[] send_Objects;

		public void OnTriggerEnter(Collider other)
		{
		}

		public void OnTriggerExit(Collider other)
		{
		}

		public void CIRCUIT()
		{
		}

		public void NONCIRCUIT()
		{
		}
	}
}
