using Unity.MLAgents.Sensors;
using UnityEngine;

namespace SLZ.MLAgents
{
	public class TurretBufferManager : MonoBehaviour
	{
		public BoxCollider buffer_collider;

		public TurretAgent agent;

		private int npc_mask;

		public BufferSensorComponent turret_buffer;

		private Vector3 temp_pos;

		private bool m_Started;

		private void Start()
		{
		}

		public void CallBufferSensor()
		{
		}

		private void OnDrawGizmos()
		{
		}
	}
}
