using System;
using System.Runtime.CompilerServices;
using SLZ.Interaction;
using SLZ.Marrow.Audio;
using SLZ.Marrow.Data;
using SLZ.Marrow.Interaction;
using UnityEngine;

namespace SLZ.Combat
{
	public class StabSlash : MonoBehaviour, IMarrowEntityCullable
	{
		[Serializable]
		public class StabPoint
		{
			[Serializable]
			public class StabJoint
			{
				public MarrowJoint joint;

				public Collider collider;

				public float megaPascals;

				public ImpactProperties iP;

				public bool firstFrame;

				public float depth;

				public float deepestDepth;

				public float velocity;

				public float damageBuffer;
			}

			public Transform pointTran;

			public Collider pointCollider;

			public float maxDepth;

			[Range(1f, 10f)]
			public float aspectRatio;

			public float stabBreakForce;

			[Range(0f, 1000f)]
			[Tooltip("Area in millimeters squared of the tip")]
			public float sharpness;

			public float depthResistanceMult;

			public float linearSpring;

			public float linearDamp;

			public float damage;

			public StabJoint[] stabJoints;

			public int impaleCount;

			private float _unStabDelay;

			private float _reStabTimer;

			[HideInInspector]
			public InteractableHost _host;

			[HideInInspector]
			public BladeAudio bAudio;

			[HideInInspector]
			public Rigidbody rb
			{
				[MethodImpl(256)]
				get
				{
					return null;
				}
			}

			public void SpawnStab(Transform tran, Collision c, float stabForce, ImpactProperties surfaceProperties)
			{
			}

			private void JointSetup(ConfigurableJointInfo info)
			{
			}

			public void UpdateStabs()
			{
			}

			private void UnStab(int i)
			{
			}
		}

		[Serializable]
		public class SlashBlade
		{
			[Serializable]
			public class BladeJoint
			{
				public MarrowJoint joint;

				public Collider collider;

				public float megaPascals;

				public ImpactProperties iP;

				public bool firstFrame;

				public float velocity;

				public float damageBuffer;
			}

			public Transform bladeTran;

			public Collider bladeCollider;

			public float bladeLength;

			public float maxDepth;

			public float bladeBreakForce;

			[Range(0f, 1000f)]
			public float sharpness;

			public float linearSpring;

			public float linearDamp;

			public float damage;

			public BladeJoint[] bladeJoints;

			public int impaleCount;

			private float _unSlashDelay;

			private float _reStabTimer;

			[HideInInspector]
			public InteractableHost _host;

			[HideInInspector]
			public BladeAudio bAudio;

			[HideInInspector]
			public Rigidbody rb => null;

			public virtual void SpawnSlash(GameObject obj, Collision c, float slashForce, Vector3 slashPressure, ImpactProperties surfaceProperties)
			{
			}

			public virtual void UpdateSlashes()
			{
			}

			private void UnSlash(int i)
			{
			}
		}

		[Serializable]
		public class BladeAudio
		{
			[Serializable]
			public class RelevantCollision
			{
				public Vector3 totalImpulse;

				public Rigidbody rigidbody;

				public float separation;

				public Vector3 relativeVelocity;

				public Vector3 point;

				public Vector3 normal;

				public Collider collider;

				public Collider colliderSelf;

				public ImpactProperties iP;
			}

			public AudioClip[] hiltImpactSoft;

			public AudioClip[] hiltImpactHard;

			public AudioClip[] bladeImpactSoft;

			public AudioClip[] bladeImpactHard;

			public AudioClip[] fleshCut;

			public AudioClip[] cardboardCut;

			public AudioClip[] woodCut;

			public AudioClip[] metalCut;

			public AudioClip[] cutEnd;

			public Transform whooshTran;

			public AudioClip whooshLoop;

			public Collider[] hiltColliders;

			public float bluntDamageMult;

			public float nativeImpactVelocity;

			public float impactVelocityThresh;

			public float cutAccelThresh;

			private ManagedAudioPlayer _mapImpact;

			private ManagedAudioPlayer _mapCut;

			private InteractableHost _host;

			private const float _velToVol = 0.25f;

			private float _minVelSquared;

			private float _cooldownTime;

			private float _nextImpactTime;

			private float _lastImpactImpulse;

			private bool _isEnter;

			private bool _collisionWithImpulse;

			private RelevantCollision _relCol;

			private float _highestImpulseSqrMag;

			public bool cooling => false;

			public void Initialize(InteractableHost host)
			{
			}

			public void CutEvent(Vector3 worldPos, float velocity, float accel, ImpactProperties iP)
			{
			}

			public void CutEnd(Vector3 worldPos, float velocity)
			{
			}

			public void CollectCollisions(Collision c, ImpactProperties iP, Rigidbody rb, bool isEnter)
			{
			}

			public void ProcessCollisionHaul(float fixedDeltaTime, Rigidbody rb)
			{
			}

			private bool CheckImpact(float impulse)
			{
				return false;
			}
		}

		public StabPoint[] stabPoints;

		public SlashBlade[] slashBlades;

		public BladeAudio bladeAudio;

		[SerializeField]
		private MarrowEntity _entity;

		[SerializeField]
		private InteractableHost _host;

		private float _fixedDeltaTime;

		private Rigidbody rb
		{
			[MethodImpl(256)]
			get
			{
				return null;
			}
		}

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void ProcessCollision(Collision c, bool isEnter = true)
		{
		}

		private void Start()
		{
		}

		private void FixedUpdate()
		{
		}

		private void Update()
		{
		}

		private void OnCollisionEnter(Collision c)
		{
		}

		private void OnCollisionStay(Collision c)
		{
		}

		public void OnEntityCull()
		{
		}

		public void OnEntityUncull()
		{
		}
	}
}
