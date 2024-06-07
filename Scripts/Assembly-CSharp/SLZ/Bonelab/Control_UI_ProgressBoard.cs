using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Bonelab.SaveData;
using SLZ.Interaction;
using SLZ.Marrow.Audio;
using SLZ.SFX;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace SLZ.Bonelab
{
	public class Control_UI_ProgressBoard : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CBoardUpdateLoop_003Ed__56 : IEnumerator<object>, IEnumerator, IDisposable
		{
public void Reset(){}
public void Dispose(){}
public object Current { get; }
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Control_UI_ProgressBoard _003C_003E4__this;

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

			[DebuggerHidden]
			public _003CBoardUpdateLoop_003Ed__56(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			public bool MoveNext()
			{
				return false;
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		public CraneControlBox craneControlBox;

		public GameControl_Hub gcHub;

		public TextMeshPro promptBoardText;

		public string text_noBatteries;

		public string text_noPower;

		public string text_noKeysUnlocked;

		public string text_insertKeys;

		public string text_systemMasterKeyMissing;

		public string text_insertMasterKey;

		public string text_allInteractionComplete;

		public MeshRenderer[] progressionLight;

		public Material mat_lightOff;

		public Material mat_lightOn;

		public Material mat_lightBlue;

		public MeshRenderer[] jimmyKeyLights;

		public GameObject jimmyKeyHolo;

		public Material mat_jimmyLightOff;

		public Material mat_jimmyLightOn;

		public GameObject[] lightLinesINPUT;

		public GameObject[] lightLinesOUTPUT;

		public GameObject[] imageRing;

		public GameObject lightLine_gate;

		public GameObject lightLine_exit;

		public Transform[] realSphere;

		private Vector3[] realSpherePos;

		private Quaternion[] realSphereRot;

		public Transform[] uiSphere;

		public Transform[] realCrane;

		public Transform[] uiCrane;

		public Renderer uiCraneHook;

		public Transform realZero;

		public Transform localZero;

		public Transform gate_left;

		public Transform gate_right;

		public Image[] lockImages;

		public Sprite unlockSprite;

		public Color unlockColor;

		private Vector3 gate_left_start;

		private Vector3 gate_right_start;

		public Vector3 gate_left_end;

		public Vector3 gate_right_end;

		public Rigidbody[] keyCoreRbs;

		public Transform[] socketPos;

		public Transform[] uiSocketPos;

		public AudioClip[] craneIUSounds;

		public ParticleSystem[] confettiSocket;

		private SimpleSFX[] confettiSocket_sfx;

		public InteractableHost[] controlHosts;

		private IEnumerator boardUpdateLoop;

		private ManagedAudioPlayer _mapCraneUI;

		private int lastSocketIndex;

		private static PlayerProgression p => null;

		private void OnEnable()
		{
		}

		private void InitializeBoard()
		{
		}

		private void Start()
		{
		}

		[IteratorStateMachine(typeof(_003CBoardUpdateLoop_003Ed__56))]
		private IEnumerator BoardUpdateLoop()
		{
			return null;
		}

		public void UPDATEDBOARD()
		{
		}

		public void ACTIVATEBOARD()
		{
		}

		public void DEACTIVATEBOARD()
		{
		}

		public void BALLSACTIVE(int i)
		{
		}

		public void KEYINSERTED()
		{
		}

		public void RESETBALLS()
		{
		}

		private void CheckProgressLights()
		{
		}

		private void CheckLightLines()
		{
		}

		private void UpdateLockUI(int i)
		{
		}

		private void CheckSpheres()
		{
		}

		private void CheckCrane()
		{
		}

		public void CraneRBCollected(Rigidbody rb)
		{
		}

		public void CraneRBReleased(Rigidbody rb)
		{
		}

		public void CraneKeyLock(int i)
		{
		}

		private void HapticEvent(InteractableHost host, float duration, float frequency, float amplitude)
		{
		}

		private void ConfettiDelay()
		{
		}

		private void SwitchMats(Renderer ren, Material mat, Index i)
		{
		}

		private void CheckGate()
		{
		}

		public void CheckProgressText()
		{
		}
	}
}
