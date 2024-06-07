using System;
using UnityEngine;

namespace SLZ.Combat
{
	[Serializable]
	public struct GibletEllipsoid
	{
		public Transform Ellipsoid;

		public GameObject[] InternalGiblets;
	}
}
