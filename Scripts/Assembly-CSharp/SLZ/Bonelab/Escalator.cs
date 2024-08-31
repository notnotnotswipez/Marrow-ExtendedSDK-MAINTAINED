using System;
using SLZ.Marrow.Circuits;
using SLZ.Marrow.Utilities;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class Escalator : ActuatorSocket
	{
		public float speed
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public void SetSpeed(float newValue)
		{
		}

		private void FixedUpdate()
		{
		}

		public Escalator()
		{
		}

		public float resetHalfThreshold;

		[SerializeField]
		private float _speed;

		private float _lastSpeed;

		public Rigidbody steps;

		public ConfigurableJoint topTransiton;

		public ConfigurableJoint topPlatform;

		public ConfigurableJoint botTransiton;

		public ConfigurableJoint botPlatform;

		public Transform beltRail;

		public Transform topRail;

		public Transform botRail;

		public Rigidbody topPlatRoll;

		public Rigidbody botPlatRoll;

		public Rigidbody topTranRoll;

		public Rigidbody botTranRoll;

		private ConfigurableJoint _stepsJoint;

		public Transform[] materialMill;

		public int[] materialElement;

		private Material[] _matMill;

		public Vector2 directionMill;

		private SimpleTransform topPlatRollInit;

		private SimpleTransform botPlatRollInit;

		private SimpleTransform topTranRollInit;

		private SimpleTransform botTranRollInit;

		private Rigidbody _topTranRb;

		private Rigidbody _botTranRb;
	}
}
