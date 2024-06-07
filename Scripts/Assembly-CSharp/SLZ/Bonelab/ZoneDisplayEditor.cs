using System;
using System.Collections.Generic;
using SLZ.Marrow.Zones;
using UnityEngine;

namespace SLZ.Bonelab
{
	[Serializable]
	public class ZoneDisplayEditor
	{
		public Zone zone;

		public List<NPC_Data> npcDataList;

		public List<ProfileSpawner> profileSpawnerList;

		public Rect zoneRect;

		public Rect[] rowRects;

		public int buttonCount;

		public int buttonBuffer;

		public int rowCount;

		public int rowMax;

		public int currRow;

		public bool showZoneDisplay;

		public bool showDebug;
	}
}
