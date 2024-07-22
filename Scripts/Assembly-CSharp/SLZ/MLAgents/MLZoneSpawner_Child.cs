using System;
using System.Runtime.CompilerServices;
using SLZ.Marrow.AI;
using UnityEngine;

namespace SLZ.MLAgents
{
	public class MLZoneSpawner_Child : MonoBehaviour
	{
		public delegate void OnAutoAgroDelegate(Behaviour newVal, TriggerRefProxy trp);

		[Header("Status Section")]
		[Tooltip("Indicates if the zone is enabled")]
		public bool zoneActive;

		[Tooltip("Destroy object entirely on despawn or use asset pool")]
		public bool destroyOnDespawn;

		private bool _deathEventSent;

		private int _dead_;

		private int _total_;

		private Coroutine _emitterCoroutine;

		[Tooltip("The model manager that this spawner is associated with")]
		[Header("Inference Section")]
		public BarracudaModelManagerMono bmm;

		[Tooltip("Scriptable object that holds model manager/spawner variable and model references")]
		public ModelManagerConfig bmmConfig;

		public bool setNbAgentsInManager;

		[Tooltip("# of model layers to execute per inference step")]
		public int nbNetworkSlices;

		[Tooltip("Shape of action mask = to number of actcions the agent can take")]
		public int actionMaskSize;

		[Tooltip("Use BMM Config values for spawner values")]
		public bool overrideSpawnVals;

		[Tooltip("Whether to initialize bmm on Start()")]
		public bool bmmInitOnStart;

		[Tooltip("Set behaviour of spawned agent to agro")]
		public bool autoAgroOnSpawn;

		private Transform initialTarget;

		private InferenceAgent temp_agent;

		[HideInInspector]
		public bool engineRunning;

		[HideInInspector]
		public bool agentsSpawned;

		[Tooltip("Delay is necessary for destruction events on objects that can be gripped")]
		public bool delayedDestruction;

		public int destroyFrames;

		private Action<GameObject> setParentAction;

		[Header("MISC Section")]
		public Transform spawnReferenceTrans;

		public bool randomizeSpawnOnSphere;

		public GameObject[] waypointObjects;

		private Vector3 spawnPosition;

		private Vector3 spawnRotation;

		public int _Alive
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public event OnAutoAgroDelegate OnAutoAgro
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}
	}
}
