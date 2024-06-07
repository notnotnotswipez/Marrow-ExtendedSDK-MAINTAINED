using System.Collections.Generic;
using UnityEngine;

namespace SLZ.MLAgents
{
	public class WheelGraph : MonoBehaviour
	{
		private int eInd;

		private int aInd;

		public float normSlip;

		public float currentSlip;

		public float maxSlip;

		public float maxValue;

		public float eSlip;

		public float eValue;

		public float aSlip;

		public float aValue;

		public float stiffness;

		public int nbBins;

		public Dictionary<int, GameObject> nodeDict;

		public GameObject nodePrefab;

		public float graphXScale;

		public float graphYScale;

		public float nodeScale;

		public Material[] nodeMaterials;

		public MeshRenderer currentRenderer;

		public MeshRenderer previousRenderer;

		public WheelCollider wheelCollider;

		public bool isForwardSlip;

		public GameObject plane;

		public bool debugSlip;

		private void FillNodeDict()
		{
		}

		private void CalculateCurve()
		{
		}

		private void Awake()
		{
		}

		private void FixedUpdate()
		{
		}
	}
}
