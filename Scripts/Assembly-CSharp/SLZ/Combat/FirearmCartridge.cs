using SLZ.Marrow.Pool;
using SLZ.Marrow.Utilities;
using SLZ.SFX;
using UnityEngine;

namespace SLZ.Combat
{
	public class FirearmCartridge : MarrowBehaviour, IPoolable
	{
		[SerializeField]
		private Poolee _poolee;

		public ShellSFX shellSfx;

		[SerializeField]
		private Renderer[] renderers;

		public float startSpeed;

		public float startAxisSpeed;

		private bool _isStatic;

		private void Reset()
		{
		}

		protected void Awake()
		{
		}

		public void Despawn()
		{
		}

		public void OnPoolInitialize()
		{
		}

		public void OnPoolSpawn()
		{
		}

		public void OnPoolDeInitialize()
		{
		}

		public void SetRenderActive(bool isActive)
		{
		}

		public void ForceInDirection(Vector3 startDirection, Vector3 startRotationAxis, Rigidbody hostRigidbody)
		{
		}

		public void MakeStatic()
		{
		}

		public void MakeDynamic()
		{
		}
	}
}
