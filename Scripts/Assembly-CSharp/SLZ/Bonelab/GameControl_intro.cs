using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class GameControl_intro : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CStart_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public GameControl_intro _003C_003E4__this;

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
			public _003CStart_003Ed__14(int _003C_003E1__state)
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

		public string buildTitle;

		public string buildState;

		private string buildDate;

		public TextMeshProUGUI tmp_Title;

		public TextMeshProUGUI tmp_BuildInfo;

		public GameObject logoSLZ;

		public GameObject logoSabrelake;

		public GameObject canvasHeightCheck;

		public GameObject[] panelsHeightCheck;

		public GameObject canvasMainMenu;

		private bool m_waitForConfirm;

		private WaitForSeconds frameWait;

		public BodyVitals ctrl_bodyVitals;

		private void Awake()
		{
		}

		[IteratorStateMachine(typeof(_003CStart_003Ed__14))]
		private IEnumerator Start()
		{
			return null;
		}

		public void NEXTSTEP()
		{
		}

		public void Update()
		{
		}
	}
}
