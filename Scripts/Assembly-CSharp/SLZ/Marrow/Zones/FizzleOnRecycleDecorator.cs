using System;
using SLZ.Marrow.Warehouse;
using UnityEngine;

namespace SLZ.Marrow.Zones
{
	[RequireComponent(typeof(CrateSpawner))]
	public class FizzleOnRecycleDecorator : MonoBehaviour, IRecycleListenable
	{
		private void Awake()
		{
		}

		public void OnRecycle(GameObject go)
		{
		}

		private void Reset()
		{
		}

		public FizzleOnRecycleDecorator()
		{
		}

		[HideInInspector]
		[SerializeField]
		protected CrateSpawner crateSpawner;
	}
}
