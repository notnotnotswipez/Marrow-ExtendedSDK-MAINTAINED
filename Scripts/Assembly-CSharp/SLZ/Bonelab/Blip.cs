using Cysharp.Threading.Tasks;
using SLZ.Marrow.Data;
using SLZ.Marrow.Pool;
using SLZ.Marrow.Utilities;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

namespace SLZ.Bonelab
{
	public class Blip : SpawnEvents
	{
		private static ComponentCache<Blip> _cache;

		[SerializeField]
		private Renderer[] Renderers;

		[SerializeField]
		private Spawnable fizzlerSpawnable;// = new Spawnable()
		//{
		//	crateRef = new SLZ.Marrow.Warehouse.SpawnableCrateReference("c1534c5a-8afb-4be3-89da-1f9546697a7a")
		//};

		[SerializeField]
		private Spawnable spawnSpawnable;// = new Spawnable()
		//{
		//	crateRef = new SLZ.Marrow.Warehouse.SpawnableCrateReference("fa534c5a83ee4ec6bd641fec424c4142.Spawnable.VFXUnblip")
		//};

		[Header("DO NOT SET IN INSPECTOR")]
		[HideInInspector]
		public Vector3 velocity;

		private bool isDestructible;

		[Header("DO NOT SET IN INSPECTOR")]
		[HideInInspector]
		public bool forceBlip;

		private bool sfxPlayed;

		public static ComponentCache<Blip> Cache => null;

		protected override void Awake()
		{
		}

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		public override void OnPoolDeInitialize()
		{
		}

		public void CallSpawnEffect()
		{
		}

		public void CallDespawnEffect()
		{
		}

		public UniTaskVoid FireEffectAsync(Spawnable effect, Color? color = null)
		{
			return default(UniTaskVoid);
		}

		private float GetVolumeSurface(Vector3 size)
		{
			return 0f;
		}

		public void CollectRenderers()
		{
			Renderers = gameObject.GetComponentsInChildren<Renderer>(false);
#if UNITY_EDITOR
			EditorUtility.SetDirty(this);
#endif
		}
	}

	
#if UNITY_EDITOR
	[CustomEditor(typeof(Blip))]
	[DisallowMultipleComponent]
	public class BlipEditor : Editor 
	{
	    public override void OnInspectorGUI()
	    {
			Blip behaviour = (Blip)target;

    	    if(GUILayout.Button("Validate"))
        	{
				behaviour.ValidateComponent();
        	}
    	    if(GUILayout.Button("Collect Renderers"))
        	{
				behaviour.CollectRenderers();
        	}
	
        	DrawDefaultInspector();
	    }
	}
#endif
}
