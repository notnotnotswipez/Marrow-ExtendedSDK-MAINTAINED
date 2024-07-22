using UnityEngine;

namespace SLZ.VRMK
{
	public class MirrorFollow : MonoBehaviour
	{
		[Header("THIS SCRIPT IS ONLY USED FOR THE INTRO MIRROR.\nIF USED ELSEWHERE IN THE GAME, IT WILL CAUSE PROBLEMS.\n")]
		[HideInInspector]
		public Transform transformToMirror;

		public Transform mirrorPlane;

		private bool _hasPelvis;

		private void Awake()
		{
		}

		private void GetPelvis()
		{
		}

		public Vector3 ReflectZAxis(Vector3 worldPosition, Transform reflectTran)
		{
			return default(Vector3);
		}

		private void LateUpdate()
		{
		}
	}
}
