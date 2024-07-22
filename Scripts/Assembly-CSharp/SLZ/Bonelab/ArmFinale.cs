using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Marrow;
using SLZ.Marrow.Data;
using SLZ.Marrow.Interaction;
using UnityEngine;
using UnityEngine.Playables;

namespace SLZ.Bonelab
{
	public class ArmFinale : MonoBehaviour
	{
		private enum ArmStage
		{
			Preshow = 0,
			Decent = 1,
			Hold = 2,
			Ascent = 3,
			Dropped = 4,
			Void = 5
		}

		[CompilerGenerated]
		private sealed class _003CCoTargetWindMill_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ArmFinale _003C_003E4__this;

			public float duration;

			public float deltaAngVel;

			private float _003Celapsed_003E5__2;

			private JointDrive _003Cdrive_003E5__3;

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
			public _003CCoTargetWindMill_003Ed__19(int _003C_003E1__state)
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

		public Rigidbody windmillBlades;

		public ConfigurableJoint windmillJoint;

		public PlayableDirector decent;

		public PlayableDirector ascent;

		public InteractableHostManager hostManager;

		public GameObject holeStopper;

		public SkinnedMeshRenderer armMesh;

		public Seat palmSeat;

		private RigManager _lastRmToDetatch;

		private int _attachedHandCount;

		[SerializeField]
		private List<MarrowBody> _ceilingTiles;

		private ConfigurableJoint[] _tileJoints;

		[SerializeField]
		private ConfigurableJointInfo _jointInfo;

		private ArmStage _armStage;

		private float _timer;

		public void GongHit()
		{
		}

		public void ReadyForAscent()
		{
		}

		public void ReadyForVoid()
		{
		}

		public void WindmillProjectRotation(float secondsFromNow)
		{
		}

		[IteratorStateMachine(typeof(_003CCoTargetWindMill_003Ed__19))]
		private IEnumerator CoTargetWindMill(float duration, float deltaAngVel)
		{
			return null;
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void OnHandAttached(InteractableHost host, Hand hand)
		{
		}

		private void OnHandDetached(InteractableHost host, Hand hand)
		{
		}

		private void BuildJoints()
		{
		}

		public void JointDestroyEvent(int tile)
		{
		}
	}
}
