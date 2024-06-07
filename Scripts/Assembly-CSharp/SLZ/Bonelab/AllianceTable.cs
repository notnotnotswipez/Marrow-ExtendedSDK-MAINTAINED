using System.Collections.Generic;
using SLZ.Data;
using UnityEngine;

namespace SLZ.Bonelab
{
	[ExecuteAlways]
	[CreateAssetMenu(fileName = "NPC_Alliance_Table", menuName = "StressLevelZero / AllianceTable", order = 1)]
	public class AllianceTable : ScriptableObject
	{
		public List<AllianceData> allianceData;

		public Dictionary<string, float> allianceDict;

		public AllianceEntry[] entries;

		public AllianceEntry[] prevEntries;

		public AllianceData dataA;

		public AllianceData dataB;

		public void Awake()
		{
		}

		[ContextMenu("UpdateDictionary")]
		public void UpdateSpeciesDictionary()
		{
		}

		public int GetEntryCount()
		{
			return 0;
		}

		[ContextMenu("RESET DEFAULTS")]
		public void ResetDefaults()
		{
		}

		[ContextMenu("Create Data")]
		public void CreateData()
		{
		}

		[ContextMenu("CREATE MATRIX")]
		public void CreateMatrix()
		{
		}

		[ContextMenu("TestLookup")]
		public float TestLookup()
		{
			return 0f;
		}
	}
}
