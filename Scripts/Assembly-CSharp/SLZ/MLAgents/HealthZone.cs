using UnityEngine;

namespace SLZ.MLAgents
{
	public class HealthZone : MonoBehaviour
	{
		[Tooltip("Reference to the master health these health events will update")]
		public VehicleHealth vehicleHealth;

		[Tooltip("How much normalized health this zone has left")]
		public float zoneHealth;

		[Tooltip("Max amount of normalized zone health")]
		public float maxZoneHealth;

		[Tooltip("Tag references of objects that can enter the zone and do damage")]
		public string[] damageDealerTags;

		[Tooltip("The amount of damage a tagged object will provide to the zone (needs to be in same order as tag array)")]
		public float[] tagDamages;

		private void Awake()
		{
		}

		private void OnTriggerEnter(Collider other)
		{
		}

		public void SubtractZoneHealth(float val)
		{
		}
	}
}
