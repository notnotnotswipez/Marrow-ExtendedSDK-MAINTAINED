using UnityEngine;

namespace ECE
{
	public struct EasyColliderProperties
	{
		public bool IsTrigger;

		public int Layer;

		public PhysicMaterial PhysicMaterial;

		public COLLIDER_ORIENTATION Orientation;

		public GameObject AttachTo;

		public EasyColliderProperties(bool isTrigger, int layer, PhysicMaterial physicMaterial, GameObject attachTo, COLLIDER_ORIENTATION orientation = COLLIDER_ORIENTATION.NORMAL)
		{
			this.IsTrigger = false;
			this.Layer = -1;
			this.PhysicMaterial = null;
			this.Orientation = COLLIDER_ORIENTATION.NORMAL;
			this.AttachTo = null;
		}
	}
}
