using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PuppetMasta;
using SLZ.Bonelab;
using SLZ.Bonelab.Obsolete;
using SLZ.Interaction;
using SLZ.Marrow.Data;
using SLZ.SFX;
using TMPro;
using UnityEngine;

public class CureMachinePowerable : Powerable
{
	[CompilerGenerated]
	private sealed class _003CCoWarmUp_003Ed__47 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CureMachinePowerable _003C_003E4__this;

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
		public _003CCoWarmUp_003Ed__47(int _003C_003E1__state)
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

		public void Reset()
		{
			throw new NotImplementedException();
		}

		public object Current { get; }

		object IEnumerator.Current => Current;

		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		bool IEnumerator.MoveNext()
		{
			return MoveNext();
		}

		public void Dispose()
		{
			throw new NotImplementedException();
		}
	}

	[CompilerGenerated]
	private sealed class _003CSmoothMoveAlongPoints_003Ed__53 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float duration;

		public CureMachinePowerable _003C_003E4__this;

		private float _003CstartTime_003E5__2;

		private float _003CendTime_003E5__3;

		private Vector3 _003CcurrStart_003E5__4;

		private Vector3 _003CcurrEnd_003E5__5;

		private float _003ClerpValTotal_003E5__6;

		private int _003CcurrPoint_003E5__7;

		private float _003ClastStartTime_003E5__8;

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
		public _003CSmoothMoveAlongPoints_003Ed__53(int _003C_003E1__state)
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

		public void Reset()
		{
			throw new NotImplementedException();
		}

		public object Current { get; }

		object IEnumerator.Current => Current;

		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		bool IEnumerator.MoveNext()
		{
			return MoveNext();
		}

		public void Dispose()
		{
			throw new NotImplementedException();
		}
	}

	[CompilerGenerated]
	private sealed class _003CCoDisableLR_003Ed__54 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float time;

		public CureMachinePowerable _003C_003E4__this;

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
		public _003CCoDisableLR_003Ed__54(int _003C_003E1__state)
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

		public void Reset()
		{
			throw new NotImplementedException();
		}

		public object Current { get; }

		object IEnumerator.Current => Current;

		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		bool IEnumerator.MoveNext()
		{
			return MoveNext();
		}

		public void Dispose()
		{
			throw new NotImplementedException();
		}
	}

	[CompilerGenerated]
	private sealed class _003CCoMoveCylinder_003Ed__58 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CureMachinePowerable _003C_003E4__this;

		private Vector3 _003CstartPos_003E5__2;

		private Vector3 _003CendPos_003E5__3;

		private float _003CstartTime_003E5__4;

		private float _003CendTime_003E5__5;

		private float _003CmoveLerp_003E5__6;

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
		public _003CCoMoveCylinder_003Ed__58(int _003C_003E1__state)
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

		public void Reset()
		{
			throw new NotImplementedException();
		}

		public object Current { get; }

		object IEnumerator.Current => Current;

		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		bool IEnumerator.MoveNext()
		{
			return MoveNext();
		}

		public void Dispose()
		{
			throw new NotImplementedException();
		}
	}

	[CompilerGenerated]
	private sealed class _003CCoCureAllEnemies_003Ed__59 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CureMachinePowerable _003C_003E4__this;

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
		public _003CCoCureAllEnemies_003Ed__59(int _003C_003E1__state)
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

		public void Reset()
		{
			throw new NotImplementedException();
		}

		public object Current { get; }

		object IEnumerator.Current => Current;

		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		bool IEnumerator.MoveNext()
		{
			return MoveNext();
		}

		public void Dispose()
		{
			throw new NotImplementedException();
		}
	}

	[SerializeField]
	private Arena_GameController AGC;

	[SerializeField]
	private List<CuredBrett> curedEnemyList;

	[SerializeField]
	private SubBehaviourFaceanim.FaceEvent[] curedFaceEvents;

	[SerializeField]
	private SubBehaviourFaceanim.FaceEvent[] gameOverFaceEvents;

	[SerializeField]
	private float lineTimeToDisable;

	[SerializeField]
	private int currBatteries;

	[SerializeField]
	private int totalBatteries;

	public int remainingBatteries;

	public float percentageComplete;

	[SerializeField]
	private GameObject[] batteryObjs;

	[SerializeField]
	private List<Transform> batterySpawns;

	[SerializeField]
	private List<Transform> easySpawns;

	[SerializeField]
	private List<Transform> medSpawns;

	[SerializeField]
	private List<Transform> hardSpawns;

	[SerializeField]
	private GameObject batteryLightObj;

	private LineRenderer lineRend;

	[SerializeField]
	private Spawnable friendlyFordSpawnableObject;

	[SerializeField]
	private Spawnable nullRatSpawnableObject;

	[SerializeField]
	private GameObject butterflyPrefab;

	[SerializeField]
	private Transform needleTip;

	[SerializeField]
	private List<Vector3> linePoints;

	[SerializeField]
	private Vector3 point1;

	[SerializeField]
	private Vector3 point2;

	[SerializeField]
	private Vector3 point3;

	[SerializeField]
	private Vector3 point4;

	[SerializeField]
	private GameObject batteryTextParent;

	[SerializeField]
	private TMP_Text batteryText;

	[SerializeField]
	private HeadSFX headSFX;

	[SerializeField]
	private AudioClip winClip;

	[SerializeField]
	private AudioClip confettiClip;

	[SerializeField]
	private AudioClip machineClip;

	[SerializeField]
	private AudioClip cureClip;

	[SerializeField]
	private Grip[] _grips;

	[SerializeField]
	private GameObject glowOrbObject;

	[SerializeField]
	private GameObject moveCylinderObj;

	[SerializeField]
	private GameObject[] glassObjs;

	[SerializeField]
	private ElectricInteractionVolume[] batteryVols;

	[SerializeField]
	private LightControlPowerable leverLightControl;

	[SerializeField]
	private GameObject leverObj;

	public bool isCuring;

	private Coroutine disRoutine;

	[SerializeField]
	private GameObject glowMoverObj;

	private Coroutine moveRoutine;

	[SerializeField]
	private AnimationCurve scaleCurve;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void Start()
	{
	}

	[IteratorStateMachine(typeof(_003CCoWarmUp_003Ed__47))]
	private IEnumerator CoWarmUp()
	{
		return null;
	}

	private void SpawnBattery()
	{
	}

	private void OnCure(Vector3 pos)
	{
	}

	[ContextMenu("TestSplineDraw")]
	public void TestSplineDraw()
	{
	}

	private void DrawCurvedSplineToTarget(Vector3 target, float timeToDisable)
	{
	}

	[ContextMenu("StartMove")]
	public void StartMove()
	{
	}

	[IteratorStateMachine(typeof(_003CSmoothMoveAlongPoints_003Ed__53))]
	private IEnumerator SmoothMoveAlongPoints(float duration)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CCoDisableLR_003Ed__54))]
	private IEnumerator CoDisableLR(float time)
	{
		return null;
	}

	public void DisableLineRend()
	{
	}

	public void ToggleBattery()
	{
	}

	private void OnBatteryVolChanged(ElectricInteractionVolume vol, IGrippable host)
	{
	}

	[IteratorStateMachine(typeof(_003CCoMoveCylinder_003Ed__58))]
	private IEnumerator CoMoveCylinder()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CCoCureAllEnemies_003Ed__59))]
	public IEnumerator CoCureAllEnemies()
	{
		return null;
	}

	public void LEVER(float voltage)
	{
	}

	public void DEBUG_CURE_ALL()
	{
	}

	[ContextMenu("TeleportBatToMachine")]
	public void TeleCurrBattToMachine()
	{
	}
}
