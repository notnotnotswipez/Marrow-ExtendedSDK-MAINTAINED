using SLZ.Marrow;
using UnityEngine;
namespace SLZ.Data
{
	public class HandPoseViewer : MonoBehaviour
	{
		public enum ViewerMode
		{
			View = 0,
			Edit = 1
		}

		public HandPose handPoseToLoadFrom;

		public ViewerMode mode;

		[Header("Edit")]
		[Range(0f, 5f)]
		public int radiusGroupId;

		[Range(0f, 18f)]
		public int poseId;

		[Header("View")]
		[Range(0f, 2f)]
		public float radius;

		[Range(-90f, 90f)]
		public float pitch;

		[Range(-90f, 90f)]
		public float roll;

		[Range(-90f, 90f)]
		public float yaw;

		public HandPose handPoseToSaveTo;

		public Grip grip;

		public HandPoseAnimator animator;

		private int _lastRadiusId;

		private int _lastPoseId;

		private float _lastPitch;

		private float _lastRoll;

		private float _lastYaw;

		private float _lastRadius;

		private ViewerMode _lastMode;

		private Quaternion leftHandSpace;

		private Quaternion rightHandSpace;

		[ContextMenu("LoadHandPose")]
		public void LoadHandPose()
		{
		}

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void UpdateArt()
		{
		}

		private void ApplyPose()
		{
		}

		[ContextMenu("SaveHandPose")]
		public void SaveHandPose()
		{
		}

		[ContextMenu("ExtrapolateHandleRotations")]
		public void ExtrapolateHandleRotations()
		{
		}

		private void SavePose()
		{
		}

		private float CheckEulerAngles(float e)
		{
			return 0f;
		}
	}
}
