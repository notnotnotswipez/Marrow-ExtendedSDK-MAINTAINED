using System.Runtime.CompilerServices;
using SLZ.Marrow.VoidLogic;
using UnityEngine;

namespace SLZ.Bonelab.VoidLogic
{
	[Support(SupportFlags.CowboySupported, null)]
	[AddComponentMenu("VoidLogic/Bonelab/Internal Only/VoidLogic Transform Sensor One-off")]
	public class OneOffTransformSensor : MonoBehaviour, IVoidLogicSource, IVoidLogicNode, IVoidLogicSensor
	{
		public enum Measurement
		{
			DistanceMagnitude = 0,
			DistanceXMagnitude = 1,
			DistanceYMagnitude = 2,
			DistanceZMagnitude = 3,
			DistanceX = 4,
			DistanceY = 5,
			DistanceZ = 6,
			RotationEulerX = 7,
			RotationEulerY = 8,
			RotationEulerZ = 9
		}

		[SerializeField]
		private Transform _anchor;

		[SerializeField]
		private Transform _connectedTransform;

		[SerializeField]
		private Measurement _measurement;

		[SerializeField]
		private bool _negate;

		private static readonly PortMetadata _portMetadata;

		public VoidLogicSubgraph Subgraph
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public void ReadSensors(ref NodeState nodeState)
		{
			throw new System.NotImplementedException();
		}

		public void Calculate(ref NodeState nodeState)
		{
			throw new System.NotImplementedException();
		}

		public PortMetadata PortMetadata => default(PortMetadata);

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnDestroy()
		{
		}

		private void SLZ_002EMarrow_002EVoidLogic_002EIVoidLogicSensor_002EReadSensors(ref NodeState nodeState)
		{
		}

		[MethodImpl(256)]
		private float _wrap(float angleDegrees)
		{
			return 0f;
		}

		private void SLZ_002EMarrow_002EVoidLogic_002EIVoidLogicSource_002ECalculate(ref NodeState nodeState)
		{
		}
	}
}
