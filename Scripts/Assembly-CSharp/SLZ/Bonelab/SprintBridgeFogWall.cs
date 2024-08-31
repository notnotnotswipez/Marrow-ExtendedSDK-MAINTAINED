using System;
using System.Collections;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class SprintBridgeFogWall : MonoBehaviour
	{
		private void Awake()
		{
		}

		private void Start()
		{
		}

		private IEnumerator UpdateFog()
		{
			return null;
		}

		public SprintBridgeFogWall()
		{
		}

		public float PCFogValue;

		public float questFogValue;

		public float questCameraFarClip;

		private float fogValue;

		public GameObject skyObject;
	}
}
