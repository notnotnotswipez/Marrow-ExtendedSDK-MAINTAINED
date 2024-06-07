using UnityEngine;

namespace SLZ.VRMK
{
	public class RealHeptaAvatar : Avatar
	{
		public float realWorldHeight;

		private float _heightDefault;

		private float _eyeHeightDefault;

		private float _heightPercentDefault;

		private float _eyeHeightPercentDefault;

		private float _c1HeightPercentDefault;

		private float _t1HeightPercentDefault;

		private float _sacrumHeightPercentDefault;

		private float _chestToShoulderPercDefault;

		private Vector3 _skullCameraLocalDefault;

		private Vector3 _cervicalHalfLocalDefault;

		private Vector3 _t7LocalDefault;

		private Vector3 _l1LocalDefault;

		private Vector3 _l3LocalDefault;

		private Vector3 _sacrumLocalDefault;

		private Vector3 _scLfLocalDefault;

		private Vector3 _acLfLocalDefault;

		private Vector3 _ghLfLocalDefault;

		private Vector3 _scRtLocalDefault;

		private Vector3 _acRtLocalDefault;

		private Vector3 _ghRtLocalDefault;

		private Vector3 _legUpperLfLocalDefault;

		private Vector3 _legUpperRtLocalDefault;

		private Vector3 _toeLfLocalDefault;

		private Vector3 _toeRtLocalDefault;

		private float _armUpperPercentDefault;

		private float _armLowerPercentDefault;

		private float _legUpperPercentDefault;

		private float _legLowerPercentDefault;

		private float _carpalPercentDefault;

		private float _toeHeightDefault;

		private float _tippyToeExtDefault;

		private Vector3 _spineT3ToS3PercentDefault;

		private Vector3 _sternumOffsetPercentDefault;

		private Vector3 _hipOffsetPercentDefault;

		private Vector2 _palmSizeDefault;

		private float _handSizeMultDefault;

		private Vector3 _palmLfPercDefault;

		private Vector3 _palmRtPercDefault;

		public void Awake()
		{
		}

		public void PrecomputeAvatar(float eyeHeight)
		{
		}

		public void RefreshBodyMeasurements(Avatar calibrationAvatar)
		{
		}

		public void SetPlayerWingspan(float wingspan, float height)
		{
		}

		public void SetPlayerInseam(float inseem, float height)
		{
		}

		public void RefreshBodyMeasurements()
		{
		}

		public override void OnDrawGizmosSelected()
		{
		}
	}
}
