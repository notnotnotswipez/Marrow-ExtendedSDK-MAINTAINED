using SLZ.Data;
using UnityEngine;

namespace SLZ.Combat
{
	public abstract class ImpactPropertiesVariables : MonoBehaviour
	{
		public enum DecalType
		{
			mesh = 0,
			plane = 1,
			none = 2
		}

		[HideInInspector]
		public enum ModelType
		{
			Skinned = 0,
			Flat = 1,
			Model = 2,
			Ignore = 3,
			LightCone = 4
		}

		[Header("Options")]
		public SurfaceData surfaceData;

		public GameObject DecalMeshObj;

		public DecalType decalType;

		[Tooltip("Define type of target Mesh for Decal System")]
		[HideInInspector]
		public ModelType modelType;

		[HideInInspector]
		[Header("Particle Color")]
		public Color MainColor;

		[HideInInspector]
		public Color SecondaryColor;

		[HideInInspector]
		public float megaPascalModifier;
	}
}
