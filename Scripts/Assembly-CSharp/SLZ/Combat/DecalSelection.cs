using SLZ.Marrow.Data;
using UnityEngine;

namespace SLZ.Combat
{
	public class DecalSelection : MonoBehaviour
	{
		public DecalMaterials decalMaterials;

		[SerializeField]
		private GameObject LightCone;

		[HideInInspector]
		public ImpactProperties SurfaceProperties;

		private void Awake()
		{
		}

		public void PickDecal()
		{
		}

		public void PickDecal(AttackType attackType)
		{
		}

		private void OnDisable()
		{
		}
	}
}
