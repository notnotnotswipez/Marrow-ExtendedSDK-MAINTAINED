using System.Collections;
using SLZ.Marrow.Interaction;
using SLZ.Marrow.Zones;
using UnityEngine;

namespace SLZ.Bonelab
{
	[RequireComponent(typeof(Light))]
	public class lightGradientAnimation : ZoneLinkItem
	{
		public Light light;

		public Gradient gradient;

		public float animationTime;

		private IEnumerator changeColor;

		private bool updateColor;

		private void Reset()
		{
		}

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}


		private void Update()
		{
		}

	}
}
