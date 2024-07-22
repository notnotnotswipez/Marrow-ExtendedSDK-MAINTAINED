using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Marrow.Data;
using SLZ.Marrow.Zones;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

namespace SLZ.Bonelab
{
	public class GameControl_Holodeck : BonelabGameControl
	{
		[Serializable]
		public class ProbePair
		{
			public Cubemap cubemap0;

			public Cubemap cubemap1;

			public SphericalHarmonicsL2 harmonics;
		}

		[CompilerGenerated]
		private sealed class _003CCycleMatOverTimeEditor_003Ed__33 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public GameControl_Holodeck _003C_003E4__this;

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
			public _003CCycleMatOverTimeEditor_003Ed__33(int _003C_003E1__state)
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
		private sealed class _003CCycleMatOverTime_003Ed__34 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public GameControl_Holodeck _003C_003E4__this;

			private Material[] _003Cmat2_003E5__2;

			private Material[] _003Cmat4_003E5__3;

			private int _003Ci_003E5__4;

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
			public _003CCycleMatOverTime_003Ed__34(int _003C_003E1__state)
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

		public GameObject UI;

		public Renderer[] wallPanels;

		public GameObject doorHide;

		public Renderer doorHideRenderer;

		public Image doorCheckImage;

		public Material[] wallMaterials;

		public GameObject[] lights;

		public float maxPanelTicTime;

		public ReflectionProbe[] probes;

		public ProbePair[] cubemaps;

		public AudioReverbData hugeRoomReverb;

		public AudioReverbData outsideReverb;

		public AudioReverbData voidReverb;

		public AudioClip shipAmbience;

		public AudioClip spaceAmbience;

		public AudioClip desertAmbience;

		public AudioClip beachAmbience;

		public AudioClip cityAmbience;

		public AudioClip stadiumAmbience;

		public AudioClip meadowAmbience;

		public AudioClip voidAmbience;

		public ZoneAmbience zoneAmbience0;

		public ZoneAmbience zoneAmbience1;

		private int materialIndex;

		private IEnumerator matCycle;

		public override void Awake()
		{
		}

		private new void Start()
		{
		}

		private void OnLevelLoad()
		{
		}

		[ContextMenu("CYCLEMATERIAL")]
		public void CYCLEMATERIAL()
		{
		}

		public void SELECTMATERIAL(int i)
		{
		}

		public void TOGGLEDOOR()
		{
		}

		private void SetSky(int materialIndex)
		{
		}

		[IteratorStateMachine(typeof(_003CCycleMatOverTimeEditor_003Ed__33))]
		private IEnumerator CycleMatOverTimeEditor()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CCycleMatOverTime_003Ed__34))]
		private IEnumerator CycleMatOverTime()
		{
			return null;
		}

		private void CueAmbience(AudioClip clipMain)
		{
		}

		[ContextMenu("Generate SphericalHarmonics")]
		public void GenerateSHs()
		{
		}

		private SphericalHarmonicsL2 AddCubemapToSH(Cubemap cubemap, int samplesPerFace)
		{
			return default(SphericalHarmonicsL2);
		}

		private static int FindFace(Vector3 dir)
		{
			return 0;
		}

		private static int GetTexelIndexFromDirection(Vector3 dir, int cubemap_size)
		{
			return 0;
		}

		private SphericalHarmonicsL2 NormalizeSH(SphericalHarmonicsL2 sh, int totalSamples)
		{
			return default(SphericalHarmonicsL2);
		}
	}
}
