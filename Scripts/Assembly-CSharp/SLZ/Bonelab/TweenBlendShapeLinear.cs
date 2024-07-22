using UnityEngine;

namespace SLZ.Bonelab
{
	public class TweenBlendShapeLinear : MonoBehaviour
	{
		[SerializeField]
		private SkinnedMeshRenderer _skin;

		[SerializeField]
		private uint _blendTarget;

		private bool _isLerping;

		private bool _disableOnComplete;

		private float _duration;

		private float _startTime;

		private float _from;

		private float _to;

		private void Update()
		{
		}

		private void OnLerpComplete()
		{
		}

		public void TweenOn(float time)
		{
		}

		public void TweenOff(float time)
		{
		}

		private void SetBlend(float currentBlend)
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
