using UnityEngine;

namespace Klak.Motion
{
	public class BrownianMotion : MonoBehaviour
	{
		[SerializeField]
		private bool _enablePositionNoise;

		[SerializeField]
		private bool _enableRotationNoise;

		[SerializeField]
		private float _positionFrequency;

		[SerializeField]
		private float _rotationFrequency;

		[SerializeField]
		private float _positionAmplitude;

		[SerializeField]
		private float _rotationAmplitude;

		[SerializeField]
		private Vector3 _positionScale;

		[SerializeField]
		private Vector3 _rotationScale;

		[SerializeField]
		[Range(0f, 8f)]
		private int _positionFractalLevel;

		[SerializeField]
		[Range(0f, 8f)]
		private int _rotationFractalLevel;

		private const float _fbmNorm = 1.3333334f;

		private Vector3 _initialPosition;

		private Quaternion _initialRotation;

		private float[] _time;

		public bool enablePositionNoise
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool enableRotationNoise
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float positionFrequency
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float rotationFrequency
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float positionAmplitude
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float rotationAmplitude
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public Vector3 positionScale
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public Vector3 rotationScale
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public int positionFractalLevel
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int rotationFractalLevel
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public void Rehash()
		{
		}

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void Update()
		{
		}
	}
}
