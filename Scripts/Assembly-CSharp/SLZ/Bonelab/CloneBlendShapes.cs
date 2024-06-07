using UnityEngine;

namespace SLZ.Bonelab
{
	[RequireComponent(typeof(SkinnedMeshRenderer))]
	public class CloneBlendShapes : MonoBehaviour
	{
		public SkinnedMeshRenderer SourceSkinnedRnd;

		public SkinnedMeshRenderer[] TargetSkinnedRnds;

		private int blendCount;

		private void Awake()
		{
		}

		private void Update()
		{
		}

		private void Reset()
		{
		}
	}
}
