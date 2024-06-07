using UnityEngine;

namespace Klak.Motion
{
	public class ConstantMotion : MonoBehaviour
	{
		public enum TranslationMode
		{
			Off = 0,
			XAxis = 1,
			YAxis = 2,
			ZAxis = 3,
			Vector = 4,
			Random = 5
		}

		public enum RotationMode
		{
			Off = 0,
			XAxis = 1,
			YAxis = 2,
			ZAxis = 3,
			Vector = 4,
			Random = 5
		}

		[SerializeField]
		private TranslationMode _translationMode;

		[SerializeField]
		private Vector3 _translationVector;

		[SerializeField]
		private float _translationSpeed;

		[SerializeField]
		private RotationMode _rotationMode;

		[SerializeField]
		private Vector3 _rotationAxis;

		[SerializeField]
		private float _rotationSpeed;

		[SerializeField]
		private bool _useLocalCoordinate;

		private MeshRenderer mesh;

		private bool isVis;

		private Vector3 _randomVectorT;

		private Vector3 _randomVectorR;

		private float dt;

		private int willRender;

		public TranslationMode translationMode
		{
			get
			{
				return default(TranslationMode);
			}
			set
			{
			}
		}

		public Vector3 translationVector
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public float translationSpeed
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public RotationMode rotationMode
		{
			get
			{
				return default(RotationMode);
			}
			set
			{
			}
		}

		public Vector3 rotationAxis
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public float rotationSpeed
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool useLocalCoordinate
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		private Vector3 TranslationVector => default(Vector3);

		private Vector3 RotationVector => default(Vector3);

		private void Start()
		{
		}

		public void OnWillRenderObject()
		{
		}
	}
}
