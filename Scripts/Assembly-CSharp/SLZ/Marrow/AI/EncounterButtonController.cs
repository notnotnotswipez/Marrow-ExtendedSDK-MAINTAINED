using UnityEngine;

namespace SLZ.Marrow.AI
{
	public class EncounterButtonController : MonoBehaviour
	{
		public Encounter encounter;

		[ContextMenu("10X Encounter")]
		public void TenX()
		{
		}

		[ContextMenu("Add 10 Encounter")]
		public void Add10()
		{
		}

		[ContextMenu("Add 100")]
		public void Add100()
		{
		}
	}
}
