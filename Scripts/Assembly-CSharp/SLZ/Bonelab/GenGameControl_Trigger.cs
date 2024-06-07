using System;
using SLZ.Marrow.AI;
using UnityEngine;
using UnityEngine.Events;

namespace SLZ.Bonelab
{
	public class GenGameControl_Trigger : MonoBehaviour
	{
		public bool disableOnTrigger;

		public bool ignoreEnemies;

		[HideInInspector]
		public Collider m_Collider;

		public UnityEvent OnPlayerEnter;

		public UnityEvent OnPlayerExit;

		public UnityEvent OnNPCEnter;

		public UnityEvent OnNPCExit;

		public Action<TriggerRefProxy> OnNPC_ProxyEnter;

		public Action<TriggerRefProxy> OnNPC_ProxyExit;

		private void Start()
		{
		}

		private void OnTriggerEnter(Collider other)
		{
		}

		private void OnTriggerExit(Collider other)
		{
		}

		private void TogglePlayerTrigger(bool enable = true)
		{
		}

		private void ToggleNPCTrigger(TriggerRefProxy proxy, bool enable = true)
		{
		}

		public void ToggleCollider(bool enable)
		{
		}
	}
}
