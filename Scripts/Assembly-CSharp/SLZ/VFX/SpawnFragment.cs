using System.Collections.Generic;
using JetBrains.Annotations;
using SLZ.Marrow.Utilities;
using SLZ.SFX;
using UnityEngine;

namespace SLZ.VFX
{
	public class SpawnFragment : MarrowBehaviour
	{
		[SerializeField]
		private ImpactSFX _sfx;

		[SerializeField]
		public Renderer[] _renderer;

		[SerializeField]
		public ObjectDestructible _ObjectDestructible;

		private List<Material> cashedMats;

		private void Reset()
		{
		}

		public void UpdateFragmentPhysics(Vector3? velocity = null, Vector3? angularVelocity = null, float? mass = null, Vector3? worldCenter = null, float? explosiveForce = null)
		{
		}

		public void SetMaterial([CanBeNull] Material newMaterial)
		{
		}

		public void OverrideBlasterTint(Color color)
		{
		}

		[ContextMenu("Get Object Destructable")]
		public void getObjDest()
		{
		}

		public void EnableSound(float pitchMultiplier = 1f)
		{
		}
	}
}
