using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Bonelab.SaveData;
using SLZ.Marrow.VoidLogic;
using SLZ.Marrow.Warehouse;
using TMPro;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class GauntletElevator : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CDoorDelayCoroutine_003Ed__35 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float delay;

			public GauntletElevator _003C_003E4__this;

			public bool open;

			public bool playDing;

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
			public _003CDoorDelayCoroutine_003Ed__35(int _003C_003E1__state)
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

		[Header("Elevator Floor Control Panel")]
		public TextMeshProUGUI cur_floorNumberDisplay;

		public TextMeshProUGUI cur_floorTitleDisplay;

		public TextMeshProUGUI[] floorNumberText;

		public Color color_normalFloor;

		public Color color_goToFloor;

		public string[] floorNumberString;

		public string[] floorNameString;

		private int currentFloor;

		private int desiredFloor;

		public AudioClip clip_positive;

		public AudioClip clip_negative;

		public float timeToTravel;

		public bool openDoorsOnStart;

		public float opeenDoorsOnStartDelay;

		public bool isHubElevator;

		public bool bigAnomaly_A;

		public bool bigAnomaly_B;

		[Header("Level Crates for Floors")]
		public LevelCrateReference[] floorLevel;

		private LevelCrateReference _loadcrate;

		public LevelCrateReference loadScreenLevel;

		public bool[] canTravelToLevel;

		[Header("Door Control")]
		public PowerSource doorPower;

		private bool delayPassed;

		private IEnumerator doorDelayCoroutine;

		private static PlayerProgression Progression => null;

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		public void UPDATEPANELDISPLAY()
		{
		}

		public void DesiredFloorCheck()
		{
		}

		public void CurrentFloorCheck()
		{
		}

		public void LOADTARGETLEVEL(int levelToLoad)
		{
		}

		private void DelayLevelLoad()
		{
		}

		public void SIMULATIONEXITBUTTON()
		{
		}

		public void OPENCLOSEDOORWITHDELAY(bool open, bool playDing, float delay = 0f)
		{
		}

		[IteratorStateMachine(typeof(_003CDoorDelayCoroutine_003Ed__35))]
		private IEnumerator DoorDelayCoroutine(bool open, bool playDing, float delay = 0f)
		{
			return null;
		}

		public void OPENCLOSEDOOR(bool open = true)
		{
		}

		public void PLAYDING(bool positive = true)
		{
		}

		private void AudioDing(AudioClip clipToPlay)
		{
		}

		private void ElevatorLevelSetup(int _currentLevel)
		{
		}
	}
}
