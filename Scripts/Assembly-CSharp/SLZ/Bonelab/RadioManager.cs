using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

namespace SLZ.Bonelab
{
	public class RadioManager : MonoBehaviour
	{
		[Serializable]
		public struct StationData
		{
			public RadioStation stationOJ;

			public RadioSong currentSong;

			public RadioSong alertOverride;

			public RadioSong queuedTrack;

			public int currentTrackIndex;

			public float currentRunningPosition;
		}

		[Serializable]
		public class OnRadioOverrideEvent : UnityEvent<RadioSong>
		{
			public OnRadioOverrideEvent()
			{
				
			}
		}

		[CompilerGenerated]
		private sealed class _003CAnnouncementOverride_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float delay;

			public RadioManager _003C_003E4__this;

			public RadioSong overrideClip;

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
			public _003CAnnouncementOverride_003Ed__18(int _003C_003E1__state)
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

		public bool radioOn;

		private static RadioManager _rmInstance;

		public List<RadioPlayer> radios;

		public RadioStation[] stations;

		[HideInInspector]
		public List<StationData> stationDatas;

		[HideInInspector]
		public List<RadioPlayer> radioPlayers;

		private StationData cur_stationData;

		[SerializeField]
		public OnRadioOverrideEvent onRadioOverrideEvent;

		public static RadioManager RadioManagerInstance => null;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		public void Update()
		{
		}

		private void IterateStationTime()
		{
		}

		public void PlayOverride(RadioSong overrideClip)
		{
		}

		public void PlayAnnouncementOverride(RadioSong overrideClip, float delay)
		{
		}

		[IteratorStateMachine(typeof(_003CAnnouncementOverride_003Ed__18))]
		private IEnumerator AnnouncementOverride(RadioSong overrideClip, float delay)
		{
			return null;
		}
	}
}
