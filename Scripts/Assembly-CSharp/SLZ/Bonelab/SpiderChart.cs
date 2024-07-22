using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.VRMK;
using TMPro;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class SpiderChart : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CUpdateLoop_003Ed__41 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public SpiderChart _003C_003E4__this;

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
			public _003CUpdateLoop_003Ed__41(int _003C_003E1__state)
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

		public GameObject chart;

		public GameObject background;

		public float targetHeight;

		public float targetMass;

		public float targetAgility;

		public float targetSpeed;

		public float targetStrengthUpper;

		public float targetStrengthLower;

		public float targetVitality;

		public float targetIntelligence;

		public float agilityHighTune;

		public float speedHighTune;

		public float strengthUpperHighTune;

		public float strengthLowerHighTune;

		public float vitalityHighTune;

		public float intelligenceHighTune;

		private float height;

		private float mass;

		private float agility;

		private float speed;

		private float strengthUpper;

		private float strengthLower;

		private float vitality;

		private float intelligence;

		private float velHeight;

		private float velMass;

		private float velAgility;

		private float velSpeed;

		private float velStrengthUpper;

		private float velStrengthLower;

		private float velVitality;

		private float velIntelligence;

		public float smoothTime;

		public TextMeshProUGUI statText;

		private bool isInRange;

		private Material chartMat;

		private IEnumerator updateLoop;

		public SLZ.VRMK.Avatar previewAvatar;

		private void Start()
		{
		}

		public void STARTCHART()
		{
		}

		public void STOPCHART()
		{
		}

		[IteratorStateMachine(typeof(_003CUpdateLoop_003Ed__41))]
		private IEnumerator UpdateLoop()
		{
			return null;
		}

		public void UPDATESTATS(SLZ.VRMK.Avatar avatar, Transform previewTransform)
		{
		}
	}
}
