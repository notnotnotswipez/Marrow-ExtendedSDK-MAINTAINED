using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Marrow;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;

namespace SLZ.Bonelab
{
	[RequireComponent(typeof(ConfigurableJoint))]
	public class DoorControl : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CSwingOverTime_003Ed__98 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float time;

			public DoorControl _003C_003E4__this;

			public bool lockOnComplete;

			private float _003CstartTime_003E5__2;

			private JointDrive _003CstartingDrive_003E5__3;

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
			public _003CSwingOverTime_003Ed__98(int _003C_003E1__state)
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

		[Header("GENERAL")]
		public bool FreeDoor;

		public DoorControl pairedDoor;

		public Vector3 axis_Link;

		public Vector3 axis_LinkSecondary;

		public bool navBlockEnemies;

		private Rigidbody rb_this;

		private Quaternion rot_initialize;

		private Quaternion offset_JointSpace;

		private bool DoorShut;

		private bool lastDoorShut;

		private bool DoorIsOffHinge;

		[Space(10f)]
		[Header("LOCK")]
		public float[] LockAngleLimits;

		public bool Lock_Locked;

		[HideInInspector]
		public bool Lock_Closed;

		public bool hasKey;

		private bool LockIsBroken;

		private bool LockHasShattered;

		public MeshRenderer lockRenderer;

		public Material noLock_Mat;

		public Material brokenLock_Mat;

		public Material locked_Mat;

		public Material unlocked_Mat;

		private bool initializedLocked;

		[Space(10f)]
		[Header("LINK")]
		public Rigidbody rb_parent;

		private ConfigurableJoint jnt_link;

		public Transform override_Anchor;

		public Transform hinge_Forward;

		public Transform hinge_Backward;

		private Vector3 _v3_hinge_FWD;

		private Vector3 _v3_hinge_FWD_connected;

		private Vector3 _v3_hinge_BWD;

		private Vector3 _v3_hinge_BWD_connected;

		[Space(3f)]
		public bool UsingThresholds;

		public int SpringLoc;

		public float[] SpringAngles;

		public float[] thr_SpringAngle_UP;

		public float[] thr_SpringAngle_DOWN;

		private Vector3 rot_target;

		public float SpringStrength;

		public float SpringDamper;

		public float SpringMaxForce;

		public bool LimitsOn;

		public float LimitMax;

		public float LimitMin;

		private float m_closedLimitMax;

		private float m_closedLimitMin;

		private float rb_velocity;

		private bool isClosedLimits;

		private bool isForwAnchor;

		[Header("KNOB")]
		[Space(10f)]
		public bool FlipLatch;

		public GameObject DoorKnob;

		private Rigidbody rb_DoorKnob;

		private ConfigurableJoint jnt_knob;

		private bool KnobLocked;

		[SerializeField]
		[Tooltip("This is the number added to the lowest x-angularThreshold and subtracted from the highest x-angularThreshold")]
		private float KnobThreshOffset;

		public float[] knob_UnlockAngles;

		public float knob_LimitMax;

		public float knob_LimitMin;

		public bool bool_springOpen;

		public int tar_springLoc;

		private bool canPlayKnobClick;

		private bool isFullLimit;

		public Grip[] grips;

		[Header("REFERENCES")]
		[Space(10f)]
		public Transform audioPosition_Hinge;

		public Transform audioPosition_Lock;

		[Space(3f)]
		public AudioClip[] clip_Knob;

		public AudioClip[] clip_Unlock;

		public AudioClip[] clip_ItsLocked;

		public AudioClip[] clip_SetLock;

		public AudioClip[] clip_Anchor;

		public AudioClip[] clip_Slam;

		[Space(5f)]
		private float lastLockAudioTime;

		public float lockAudioThresh;

		private float lastAnchorAudioTime;

		public float anchorAudioThresh;

		public float anchorAudioVolume;

		[Space(5f)]
		public OcclusionPortal occlusionPortal;

		public NavMeshObstacle navMeshObstacle;

		[Header("Events")]
		public UnityEvent onLocked;

		public UnityEvent onUnlocked;

		public UnityEvent onClosed;

		public UnityEvent onOpened;

		public UnityEvent onOpenedFirstTime;

		private bool hasBeenOpened;

		private HashSet<Hand> collisionHands;

		private HashSet<Hand> gripHands;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnDestroy()
		{
		}

		private void Start()
		{
		}

		private void SETANGLES()
		{
		}

		private void IgnoreCollisions()
		{
		}

		private void FixedUpdate()
		{
		}

		private void ToggleAnchor()
		{
		}

		public void DOORBROKEN()
		{
		}

		public void BREAKLOCK()
		{
		}

		public void KEYLOCKUNLOCK(bool isLocking)
		{
		}

		public void SWINGSHUTANDLOCK(float time)
		{
		}

		[IteratorStateMachine(typeof(_003CSwingOverTime_003Ed__98))]
		public IEnumerator SwingOverTime(float time = 1f, bool lockOnComplete = false)
		{
			return null;
		}

		private void UpdateLockLight()
		{
		}

		private void SetLink()
		{
		}

		private void RotTarget()
		{
		}

		private void SetLimits()
		{
		}

		private void CheckThresholds_Door(float cur_angle)
		{
		}

		private void CheckOpened(float cur_angle)
		{
		}

		public void SPRINGTOTARGET()
		{
		}

		public void KNOBLOCK(bool locking = true)
		{
		}

		private void SetKnobLimits(bool fullLimit)
		{
		}

		private void CheckKnobThresholds()
		{
		}

		public void OnCollisionEnter(Collision other)
		{
		}

		public void OnCollisionExit(Collision other)
		{
		}

		private void OnHandAttached(Hand hand)
		{
		}

		private void OnHandDetached(Hand hand)
		{
		}

		private void SFXDoorKnob()
		{
		}

		private void SFXDoorLocking(bool locking)
		{
		}

		private void SFXDoorIsAlreadyLocked()
		{
		}

		public void DoorAnchorSFX()
		{
		}

		private void DoorSlamSFX()
		{
		}

		private void SFXSend(AudioClip[] clipToPlay, Vector3 pos)
		{
		}

		private void UE_LOCKED(bool doorLock)
		{
		}

		private void UE_CLOSED(bool doorClosed)
		{
		}
	}
}
