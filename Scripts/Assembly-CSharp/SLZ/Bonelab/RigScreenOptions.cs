using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Bonelab.SaveData;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class RigScreenOptions : ScreenOptions
	{
		[CompilerGenerated]
		private sealed class _003CStartingLogic_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
public void Reset(){}
public void Dispose(){}
public object Current { get; }
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public RigScreenOptions _003C_003E4__this;

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
			public _003CStartingLogic_003Ed__10(int _003C_003E1__state)
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

		[Header("Spectator settings")]
		public float tiltAngle;

		public EyeTarget eyeTarget;

		public SpectatorCameraMode cameraMode;

		private Vector3 SpecCamLocalpos;

		[Header("References")]
		public Camera cam;

		public Transform TargetTransform;

		public Camera OverlayCam;

		private void Start()
		{
		}

		private void GetMainCam()
		{
		}

		private void startCo()
		{
		}

		[IteratorStateMachine(typeof(_003CStartingLogic_003Ed__10))]
		private IEnumerator StartingLogic()
		{
			return null;
		}

		private SpectatorSettings GetSettings()
		{
			return null;
		}

		public void SetCameraLocation(EyeTarget location)
		{
		}

		public void SetPassthroughLocation(EyeTarget location)
		{
		}

		public void SetSpectatorCamera(SpectatorCameraMode mode, EyeTarget location)
		{
		}

		private void RenderOverlay()
		{
		}

		private void TurnOffOverlayCam()
		{
		}

		[ContextMenu("Enable Fisheye")]
		public void EnableFisheye()
		{
		}
	}
}
