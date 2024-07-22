using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class CityBlock : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CStart_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public CityBlock _003C_003E4__this;

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
			public _003CStart_003Ed__21(int _003C_003E1__state)
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

		[CompilerGenerated]
		private sealed class _003CCalculate_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public CityBlock _003C_003E4__this;

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
			public _003CCalculate_003Ed__24(int _003C_003E1__state)
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

		[Header("PLAYER LOCATION")]
		public TextMeshProUGUI txt_playerPos;

		public TextMeshProUGUI txt_headingVector;

		public TextMeshProUGUI txt_timeToArrival;

		public TextMeshProUGUI txt_distance;

		public TextMeshProUGUI txt_blockLocation;

		public TextMeshProUGUI txt_location;

		public Vector3 blockLocation;

		public string location;

		public Transform beacon;

		[HideInInspector]
		public Transform entity;

		public string timeToArrival;

		[Header("META DIAGNOSTICS")]
		public TextMeshProUGUI txt_buildInfo;

		public TextMeshProUGUI txt_buildTitle;

		public string buildTitle;

		public string buildState;

		private string buildDate;

		[Header("PHYSICS DISPLAY")]
		public TextMeshProUGUI txt_timeStep;

		public TextMeshProUGUI txt_timeScale;

		public TextMeshProUGUI txt_gravity;

		public TextMeshProUGUI txt_particleCount;

		private void Awake()
		{
		}

		[IteratorStateMachine(typeof(_003CStart_003Ed__21))]
		private IEnumerator Start()
		{
			return null;
		}

		private void OnDisable()
		{
		}

		private void SetupPlayerReferencesAndStart()
		{
		}

		[IteratorStateMachine(typeof(_003CCalculate_003Ed__24))]
		public IEnumerator Calculate()
		{
			return null;
		}

		public void UPDATEDISPLAY()
		{
		}

		public void UPDATEDISPLAYONCE()
		{
		}
	}
}
