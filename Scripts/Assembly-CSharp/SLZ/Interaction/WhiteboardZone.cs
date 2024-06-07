using SLZ.Marrow.Interaction;
using SLZ.Marrow.Zones;
using UnityEngine;

namespace SLZ.Interaction
{
	public class WhiteboardZone : ZoneItem
	{
		public Vector2 size;

		public Vector3 normal;

		public Vector3 binormal;

		protected void OnEnter(MarrowEntity entity)
		{
		}

		protected void OnExit(MarrowEntity entity)
		{
		}

		private void OnDrawGizmos()
		{
		}
	}
}
