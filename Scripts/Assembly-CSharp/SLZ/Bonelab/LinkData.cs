using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Marrow.AI;
using SLZ.SFX;
using UnityEngine;
using UnityEngine.AI;

namespace SLZ.Bonelab
{
	[ExecuteInEditMode]
	public class LinkData : MonoBehaviour
	{
		public enum LinkType
		{
			CLIMB = 0,
			JUMP = 1,
			LAUNCH = 2,
			ZIPLINE_UP = 3,
			CLIMB_BARS = 4,
			SLIDE = 5,
			CLIMB_LEDGE = 6,
			ZIPLINE_DOWN = 7,
			ESCALATOR = 8
		}

		public struct LData
		{
			public Vector3 iVel;

			public float ttTarg;

		}

		[CompilerGenerated]
		private sealed class _003CCoMeasureError_003Ed__175 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float timeToTarg;

			public LinkData _003C_003E4__this;

			private float _003CstartTime_003E5__2;

			private float _003CendTime_003E5__3;

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
			public _003CCoMeasureError_003Ed__175(int _003C_003E1__state)
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

		public LinkType linkType;

		public int legAgentID;

		public int crabletAgentID;

		[SerializeField]
		private NavMeshLink[] allNavLinks;

		public NavMeshLink navLinkLeg;

		public NavMeshLink navLinkCrab;

		public AgentLinkControl currLinkAgent;

		public bool isOccupied;

		public float agentDot;

		public Vector3 startPosLocal;

		public Vector3 endPosLocal;

		public GameObject rotaterParentObj;

		public Transform edgeTarget;

		public Transform startRayTarget;

		public Transform endRayTarget;

		[Tooltip("Y local length")]
		public float edgeHeight;

		[Tooltip("X local length")]
		public float edgeWidth;

		[Tooltip("Z local length")]
		public float edgeDepth;

		public float chestHeight;

		public float chestDepth;

		public float kneeHeight;

		public float launchHeight;

		public float linkDepth;

		public float launchMag;

		public ConfigurableJoint linkJoint;

		private JointDrive jointDrive;

		public Transform crabTarget;

		public bool addFallForce;

		public bool repairLegHealth;

		[Header("Climb")]
		public bool isObstructed;

		public Transform leftHandTarget;

		public Transform rightHandTarget;

		public Transform leftKneeTarget;

		public Transform rightKneeTarget;

		public Transform leftHandTargetSecondary;

		public Transform rightHandTargetSecondary;

		public Transform headTarget;

		public float destArmTime;

		public Transform chestTargetPrimary;

		public Transform chestTargetSecondary;

		[Header("Slide")]
		public GameObject moverJointObj;

		public Rigidbody moverJointBody;

		public Transform chestPointStart;

		public Transform chestPointGoal;

		public bool ignoreLaunchTarget;

		public LayerMask startEndLayermask;

		private Vector3 lastLaunchTargPos;

		public Transform launchTarget;

		public float launchForce;

		public float launchForceMult;

		public float launchTime;

		public float crabJumpForce;

		public bool applyDragForce;

		public float correctivePerc;

		public Action<Vector3> OnLaunchAction;

		public GameObject playerTargForwObj;

		public GameObject playerTargRevObj;

		public MeshRenderer[] colorizedRends;

		public Material explicitMat;

		public Material autoMat;

		public GameObject autoTriggerForwObj;

		public GameObject autoTriggerRevObj;

		private Coroutine launchRoutine;

		public GameObject forwardObj;

		public GameObject reverseObj;

		[SerializeField]
		private float coolDownDuration;

		private float launchableTime;

		public Vector3[] launchLinePoints;

		public float yDragMult;

		public float xzDragMult;

		public float yDragMult_npc;

		public float xzDragMult_npc;

		private float unityDragVal;

		public LData launchData;

		public LData idealLaunchData;

		public float launchAngle;

		public Vector3[] positions;

		public Vector3[] dragPositions;

		private bool isPosArrayReversed;

		public int splineResolution;

		public int dragSplineResolution;

		private float perc;

		private int lerpValInt;

		private float sqrError;

		private Coroutine thrustRoutine;

		public bool applyConstForce;

		private bool displayAngle;

		private bool isDrawingError;

		private bool applyCorrectiveThrust;

		private Vector3 perfectPosition;

		public float thrustThreshold;

		public float failThreshold;

		public float thrustFactor;

		public float correctiveMin;

		public float correctiveMax;

		[SerializeField]
		[Header("Climb Bars")]
		private GameObject[] barObjs;

		public GameObject[] grabObjs;

		[Header("Zip Line")]
		public Transform zipSpawn;

		public GameObject zipStickPrefab;

		public float zipTime;

		public GenGameControl_Trigger zipTrigger;

		public ZipLinkManager zipManager;

		public ZipJointMover zipJointMover;

		public float lerpDistance;

		public TriggerRefProxy currProxy;

		public Vector3 startPoint;

		public Vector3 endPoint;

		public GameObject startRayObj;

		public GameObject endRayObj;

		public Mesh zipStickMesh;

		[Header("Escalator")]
		public Escalator escalator;

		public GameObject moverTargetParent;

		public GameObject moverTarget;

		public Transform startMoveTarget;

		public Transform endMoveTarget;

		public GenGameControl_Trigger compTrigger;

		public ConfigurableJoint headJoint;

		public ConfigurableJoint chestJoint;

		public ConfigurableJoint leftHandJoint;

		public ConfigurableJoint rightHandJoint;

		public ConfigurableJoint leftElbowJoint;

		public ConfigurableJoint rightElbowJoint;

		public ConfigurableJoint leftFootJoint;

		public ConfigurableJoint rightFootJoint;

		public ConfigurableJoint leftKneeJoint;

		public ConfigurableJoint rightKneeJoint;

		public Color chestColor;

		private static Color headColor;

		private static Color leftHandColor;

		private static Color rightHandColor;

		private static Color leftElbowColor;

		private static Color rightElbowColor;

		public GameObject climbingBarsPrefab;

		public LinkDataManager linkDataManager;

		public bool disableOnLinkCompletion;

		[Header("ToggleLaunchPads")]
		public AmbientSFX forwAmbSFX;

		public AmbientSFX revAmbSFX;

		public Collider forwTrig;

		public Collider revTrig;

		public Collider forwFXTrig;

		public Collider revFXTrig;

		public Collider[] fwdTrigCols;

		public Collider[] revTrigCols;

		public GameObject[] forwToggleObjs;

		public GameObject[] revToggleObjs;

		public Material brightLampMat;

		public Material darkLampMat;

		public Renderer forwLampRingRend;

		public Renderer revLampRingRend;

		private bool isSubbedToJump;

		public bool isDrawingSim;

		public GameObject simLaunchObj;

		private float avgDrag;

		private float npcDrag;

		private float playerDrag;

		public bool drawPlayer;

		[ContextMenu("CreateStartEndPoints")]
		public void CreateStartEndPoints()
		{
		}

		public void SetStartEndPoints()
		{
		}

		[ContextMenu("CreateEdgeObjectsByType")]
		public void CreateEdgeObjectsByType()
		{
		}

		public void CreateSingleEdgeObjects()
		{
		}

		public void CreateClimbLedgeObjects()
		{
		}

		public void CreateSlideObjects()
		{
		}

		public void OffsetBarGrabObjects()
		{
		}

		private void CreateJumpObjects()
		{
		}

		private void CreateLaunchObjects()
		{
		}

		private void CreateClimbBarObjects()
		{
		}

		private void CreateZipObjects()
		{
		}

		public void CreateMoverJoint(float driveSForce = -1f, float driveMForce = -1f)
		{
		}

		public void UpdateMoverJointDrive(float driveSForce, float driveMForce)
		{
		}

		[ContextMenu("SetExplicitStartAndEnd")]
		public void SetExplicitStartAndEndLaunchPoints()
		{
		}

		public void RotateLinkTargets(bool isForward)
		{
		}

		public float CheckAgentDot(GameObject agentObj)
		{
			return 0f;
		}

		public void LaunchAudio(bool isForw)
		{
		}

		public void ToggleBiDirectional()
		{
		}

		public void OnZipOccupied()
		{
		}

		public void ClaimLink(AgentLinkControl currAgent)
		{
		}

		public void ReleaseLink()
		{
		}

		public void TogglePlayerTarget(bool enable)
		{
		}

		public void PlayerAttack()
		{
		}

		[ContextMenu("LaunchPlayer")]
		public void LaunchPlayer()
		{
		}

		public void ToggleReversePositionArray()
		{
		}

		[IteratorStateMachine(typeof(_003CCoMeasureError_003Ed__175))]
		private IEnumerator CoMeasureError(float timeToTarg)
		{
			return null;
		}

		private void FixedUpdate()
		{
		}

		public LData CalculateLaunchData(GameObject launchObj, float height, float gravity)
		{
			return default(LData);
		}

		public LData CalcInitialVelocity(GameObject launchObj, Vector3 target, float height, bool multDrag = true, bool isNPC = false)
		{
			return default(LData);
		}

		public float CalcAdjusttedTOF(GameObject launchObj, Vector3 target, float height)
		{
			return 0f;
		}

		[ContextMenu("FindMaxHeight")]
		public void DisplayMaxHeight()
		{
		}

		public Vector2 FindMaxHeight()
		{
			return default(Vector2);
		}

		[ContextMenu("TelePlayerToLinkStart")]
		public void TelePlayerToLinkStart()
		{
		}

		[ContextMenu("TelePlayerToLinkEnd")]
		public void TelePlayerToLinkEnd()
		{
		}

		public void SubToPlayerJump(bool enable)
		{
		}

		[ContextMenu("ToggleLaunchPadOn")]
		public void ToggleLaunchPadOn()
		{
		}

		[ContextMenu("ToggleLaunchPadOff")]
		public void ToggleLaunchPadOff()
		{
		}

		public void ToggleLaunchPadLink(bool enable)
		{
		}

		[ContextMenu("ApplyToAllLedgeLinks")]
		public void ApplySettingsToAllLedgeLinks()
		{
		}

		[ContextMenu("DrawEditorPath")]
		public void DrawEditorPath()
		{
		}

		[ContextMenu("DrawEditorPathWithPlayerBody")]
		public void DrawEditorPathWithPlayerBody()
		{
		}

		private void DrawEditorIdealPath(GameObject launchObj)
		{
		}
	}
}
