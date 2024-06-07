using System;
using System.Threading;
using Cysharp.Threading.Tasks;
using SLZ.Marrow.Interaction;
using SLZ.Marrow.Zones;
using UltEvents;
using UnityEngine;

namespace SLZ.Marrow.AI
{
	// Token: 0x020001BB RID: 443
	public class Encounter : ZoneLinkItem
	{
		// Token: 0x06000FC0 RID: 4032 RVA: 0x00005389 File Offset: 0x00003589
		protected void Awake()
		{
		}

		// Token: 0x06000FC1 RID: 4033 RVA: 0x0000538B File Offset: 0x0000358B
		private void Start()
		{
		}

		// Token: 0x06000FC2 RID: 4034 RVA: 0x0000538D File Offset: 0x0000358D
		private void OnDestroy()
		{
		}

		// Token: 0x06000FC3 RID: 4035 RVA: 0x0000538F File Offset: 0x0000358F
		protected void OnEnter(MarrowEntity activatorEntity)
		{
		}

		// Token: 0x06000FC4 RID: 4036 RVA: 0x00005391 File Offset: 0x00003591
		protected void OnExit(MarrowEntity activatorEntity)
		{
		}

		// Token: 0x06000FC5 RID: 4037 RVA: 0x00005393 File Offset: 0x00003593
		[ContextMenu("StartEncounter")]
		public void StartEncounter()
		{
		}

		// Token: 0x06000FC6 RID: 4038 RVA: 0x00005395 File Offset: 0x00003595
		public void StartEncounter(MarrowEntity activatorEntity)
		{
		}

		// Token: 0x06000FC7 RID: 4039 RVA: 0x00005397 File Offset: 0x00003597
		public void WarmupEncounter()
		{
		}

		// Token: 0x06000FC8 RID: 4040 RVA: 0x00005399 File Offset: 0x00003599
		private void StartGroupEncounter(int groupID)
		{
		}

		// Token: 0x06000FC9 RID: 4041 RVA: 0x0000539B File Offset: 0x0000359B
		[ContextMenu("ForceStopAndReset")]
		public void ForceStopContext()
		{
		}

		// Token: 0x06000FCA RID: 4042 RVA: 0x0000539D File Offset: 0x0000359D
		public void ForceStopAndReset(bool killAll = true)
		{
		}

		// Token: 0x06000FCB RID: 4043 RVA: 0x0000539F File Offset: 0x0000359F
		[ContextMenu("ForceStopAndComplete")]
		public void ForceStopCompContext()
		{
		}

		// Token: 0x06000FCC RID: 4044 RVA: 0x000053A1 File Offset: 0x000035A1
		public void ForceStopAndComplete(bool killAll = true)
		{
		}

		// Token: 0x06000FCD RID: 4045 RVA: 0x000053A3 File Offset: 0x000035A3
		[ContextMenu("PauseEncounter")]
		public void PauseEncounter()
		{
		}

		// Token: 0x06000FCE RID: 4046 RVA: 0x000053A5 File Offset: 0x000035A5
		private void AwardGroupCompletion(SpawnGroup group)
		{
		}

		// Token: 0x06000FCF RID: 4047 RVA: 0x000053A7 File Offset: 0x000035A7
		public void MentalAllEncounter(MarrowEntity entity)
		{
		}

		// Token: 0x06000FD0 RID: 4048 RVA: 0x000053A9 File Offset: 0x000035A9
		public void CompleteEncounter()
		{
		}

		// Token: 0x06000FD1 RID: 4049 RVA: 0x00008584 File Offset: 0x00006784
		private UniTaskVoid WarmupLoop(SpawnGroup group)
		{
			return default(UniTaskVoid);
		}

		// Token: 0x06000FD2 RID: 4050 RVA: 0x0000859C File Offset: 0x0000679C
		private UniTaskVoid EncounterLoop(SpawnGroup group, CancellationToken ct)
		{
			return default(UniTaskVoid);
		}

		// Token: 0x04000B68 RID: 2920
		public Encounter.SpawnOrder spawnOrder;

		// Token: 0x04000B69 RID: 2921
		public SpawnGroup[] spawnGroups;

		// Token: 0x04000B6A RID: 2922
		[Header("Encounter Music")]
		public AudioClip encounterMusic;

		// Token: 0x04000B6B RID: 2923
		[Range(0f, 1f)]
		public float volume;

		// Token: 0x04000B6C RID: 2924
		public bool loop;

		// Token: 0x04000B6D RID: 2925
		[Range(0f, 10f)]
		public float fadeInTime;

		// Token: 0x04000B6E RID: 2926
		[Range(0f, 10f)]
		public float fadeOutTime;

		// Token: 0x04000B6F RID: 2927
		private CancellationTokenSource[] _spawnCTSs;

		// Token: 0x04000B70 RID: 2928
		private int completeCount;

		// Token: 0x04000B71 RID: 2929
		private bool _complete;

		// Token: 0x04000B72 RID: 2930
		private bool _isEncounterActive;

		// Token: 0x04000B73 RID: 2931
		public UltEvent OnComplete;

		// Token: 0x04000B74 RID: 2932
		private bool isWarmed;

		// Token: 0x04000B75 RID: 2933
		private MarrowEntity playerEntity;

		// Token: 0x04000B76 RID: 2934
		[HideInInspector]
		public static bool encounterPasted;

		// Token: 0x04000B77 RID: 2935
		public Action OnEncounterReset;

		// Token: 0x020002C5 RID: 709
		public enum SpawnOrder
		{
			// Token: 0x0400112C RID: 4396
			PARALLEL,
			// Token: 0x0400112D RID: 4397
			SERIES
		}
	}
}
