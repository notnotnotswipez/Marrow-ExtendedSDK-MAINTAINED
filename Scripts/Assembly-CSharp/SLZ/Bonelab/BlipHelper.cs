using System;
using System.Collections;
using SLZ.Marrow.Interaction;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class BlipHelper : MonoBehaviour
	{
		public void DESTROYOBJ()
		{
		}

		private IEnumerator DespawnCoroutine()
		{
			return null;
		}

		public BlipHelper()
		{
		}

		public float blipWaitTime;

		public MarrowEntity entity;

		private bool fired;
	}
}
