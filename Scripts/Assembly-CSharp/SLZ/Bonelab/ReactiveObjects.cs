using UnityEngine;

namespace SLZ.Bonelab
{
	[RequireComponent(typeof(Renderer))]
	public class ReactiveObjects : MonoBehaviour
	{
		public Transform[] ReactiveTransforms;

		private Vector4[] extractedPositions;

		private Material TargetMat;

		private const int MaxCount = 32;

		private int clampCount;

		private int TrackedPosID;

		private int NumOfPosID;

		private void Start()
		{
		}

		private void Update()
		{
		}

		public void IntializeArray()
		{
		}
	}
}
