using UnityEngine;

namespace SLZ.Bonelab
{
	[RequireComponent(typeof(SkinnedMeshRenderer))]
	public class TweenBlendshape : MonoBehaviour
	{
		[SerializeField]
		private SkinnedMeshRenderer skin;

		[SerializeField]
		private uint BlendTarget;

		public LeanTweenType tweenType;

		private void Reset()
		{
		}

		private void OnEnable()
		{
		}

		public void TweenOn(float time)
		{
		}

		public void TweenOff(float time)
		{
		}

		private void SetBlend(float currentBlend, float ratio)
		{
		}

		private void DisableMesh()
		{
		}

		private void EnableMesh()
		{
		}
	}
}
