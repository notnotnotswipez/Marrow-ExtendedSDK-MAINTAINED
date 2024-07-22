using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Marrow.Warehouse;
using SLZ.Marrow.Zones;
using UnityEngine;

public class NPC_Tracker : MonoBehaviour, ISpawnListenable
{
	[CompilerGenerated]
	private sealed class _003CCoWaitForSpawns_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public NPC_Tracker _003C_003E4__this;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

        public object Current => throw new NotImplementedException();

        [DebuggerHidden]
		public _003CCoWaitForSpawns_003Ed__6(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

        bool IEnumerator.MoveNext()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }

	[SerializeField]
	private CrateSpawner[] crateSpawners;

	public float registrationDelay;

	private List<GameObject> spawnedGoList;

	public List<NPC_Tracker_Data> npcDataList;

	private void OnEnable()
	{
	}

	private void SetupSpawnerRegistration()
	{
	}

	[IteratorStateMachine(typeof(_003CCoWaitForSpawns_003Ed__6))]
	private IEnumerator CoWaitForSpawns()
	{
		return null;
	}

	public void OnSpawn(GameObject go)
	{
	}

	private void RegisterSpawnedGOs()
	{
	}

	public void OnDespawn(GameObject go)
	{
	}

	[ContextMenu("GetAllCrateSpawners")]
	public void GetAllCrateSpawners()
	{
	}
}
