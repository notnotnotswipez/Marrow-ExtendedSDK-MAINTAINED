using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Marrow.Audio;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class GeoManager : MonoBehaviour
	{
		public enum GeoState
		{
			CLEARED = 0,
			MOVING = 1,
			UP = 2,
			MOVING_TO_CLEAR = 3
		}

		[CompilerGenerated]
		private sealed class _003CCoDelayedMoveNext_003Ed__25 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float timeDelay;

			public GeoManager _003C_003E4__this;

			public int index;

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
			public _003CCoDelayedMoveNext_003Ed__25(int _003C_003E1__state)
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

		public GeoState geoState;

		public GeoMover activeGeoMover;

		[SerializeField]
		private AudioClip moveGeoClip;

		private ManagedAudioPlayer _mapLoop;

		public List<GeoMover> geoMoverList;

		[SerializeField]
		private GeoMover deathPitGeoMover;

		[SerializeField]
		private GeoMover deathPitFloorMover;

		public GameObject geoMoverPrefab;

		private int _currMoverIndex;

		public int currGeoIndex;

		public static Action OnMoveUpComplete;

		public Dictionary<string, int> geoDict;

		public Dictionary<string, GeoMover> geoMoverDict;

		public int moverIndex => 0;

		public void Awake()
		{
		}

		[ContextMenu("IncrementAndToggleGeo")]
		public void IncrementAndToggleGeo()
		{
		}

		public void IncrementGeoIndex()
		{
		}

		public void SelectGeo(string geoTitle)
		{
		}

		public void ClearCurrentGeo()
		{
		}

		public void ToggleGeo(int index)
		{
		}

		public void ToggleAudio(bool startPlaying, bool pitchShift = false)
		{
		}

		public void MoveUpComplete(GeoMover geoMover)
		{
		}

		public void MoveDownComplete(GeoMover geoMover)
		{
		}

		[IteratorStateMachine(typeof(_003CCoDelayedMoveNext_003Ed__25))]
		private IEnumerator CoDelayedMoveNext(float timeDelay, int index)
		{
			return null;
		}

		private void CleanupDecalsAndFragments()
		{
		}
	}
}
