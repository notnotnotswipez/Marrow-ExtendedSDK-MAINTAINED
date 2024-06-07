using SLZ.Marrow.Utilities;
using SLZ.Rig;
using UnityEngine;

namespace SLZ.VRMK
{
	public class PlayerAvatarArt : MonoBehaviour
	{
		[SerializeField]
		private OpenControllerRig _openCtrlRig;

		[Header("Third Person Camera")]
		public float scale;

		private bool _cleanUpCameraOffset;

		private bool _tpsCamEnabled;

		private Vector3 _storedTranPos;

		private float _storedTranScale;

		private Quaternion _storedTranRot;

		private SimpleTransform _tpcCachedLocation;

		private Vector3 _pausedCamPosition;

		private Vector3 _pausedScale;

		private SimpleTransform _pausedVRRootT;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void OnPreAvatarEarlyUpdate()
		{
		}

		public void OnPostAvatarArt()
		{
		}

		public void SetAvatar()
		{
		}

		public void EnableHead()
		{
		}

		public void DisableHead()
		{
		}

		public void EnableHair()
		{
		}

		public void DisableHair()
		{
		}

		private void UpdateAvatarHead()
		{
		}

		private void ThirdPersonCameraUpdate()
		{
		}

		private void OnSpawnStateChanged(bool isPaused)
		{
		}
	}
}
