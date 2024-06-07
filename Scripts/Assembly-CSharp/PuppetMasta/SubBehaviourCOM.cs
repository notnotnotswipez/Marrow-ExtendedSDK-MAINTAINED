using System;
using System.Runtime.CompilerServices;
using SLZ.Marrow.PuppetMasta;
using UnityEngine;

namespace PuppetMasta
{
	[Serializable]
	public class SubBehaviourCOM : SubBehaviourBase
	{
		[Serializable]
		public enum Mode
		{
			FeetCentroid = 0,
			CenterOfPressure = 1
		}

		public Mode mode;

		public float velocityDamper;

		public float velocityLerpSpeed;

		public float velocityMax;

		public float centerOfPressureSpeed;

		public Vector3 offset;

		[HideInInspector]
		public bool[] groundContacts;

		[HideInInspector]
		public Vector3[] groundContactPoints;

		private LayerMask groundLayers;

		public Vector3 position
		{
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public Vector3 direction
		{
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public float angle
		{
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public Vector3 velocity
		{
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public Vector3 rbVelocity
		{
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public Vector3 centerOfPressure
		{
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public Quaternion rotation
		{
			[CompilerGenerated]
			get
			{
				return default(Quaternion);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public Quaternion inverseRotation
		{
			[CompilerGenerated]
			get
			{
				return default(Quaternion);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool isGrounded
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public float lastGroundedTime
		{
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public void Initiate(BehaviourBase behaviour, LayerMask groundLayers)
		{
		}

		private void OnHierarchyChanged()
		{
		}

		private void OnPreMuscleCollision(MuscleCollision c)
		{
		}

		private void OnPreMuscleCollisionExit(MuscleCollision c)
		{
		}

		private void OnPreActivate()
		{
		}

		private void OnPreLateUpdate()
		{
		}

		private void OnPreDeactivate()
		{
		}

		private Vector3 GetCollisionCOP(Collision collision)
		{
			return default(Vector3);
		}

		private bool IsGrounded()
		{
			return false;
		}

		private Vector3 GetCenterOfMass()
		{
			return default(Vector3);
		}

		private Vector3 GetCenterOfMassVelocity()
		{
			return default(Vector3);
		}

		private Vector3 GetVelocity()
		{
			return default(Vector3);
		}

		private Vector3 GetMomentum()
		{
			return default(Vector3);
		}

		private Vector3 GetCenterOfPressure()
		{
			return default(Vector3);
		}

		private Vector3 GetFeetCentroid()
		{
			return default(Vector3);
		}
	}
}
