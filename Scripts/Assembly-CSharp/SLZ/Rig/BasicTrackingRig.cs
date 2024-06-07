using UnityEngine;
using UnityEngine.Rendering;

namespace SLZ.Rig
{
	public class BasicTrackingRig : MonoBehaviour
	{
		public Transform head;

		public Transform left;

		public Transform right;

		public Transform vrRoot;

		private bool _zeroTrack;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnBeginCameraRendering(ScriptableRenderContext ctx, Camera camera)
		{
		}
	}
}
