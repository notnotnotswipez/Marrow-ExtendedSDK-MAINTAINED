using UnityEngine;

namespace SLZ.Bonelab
{
	public class RendererGroup : MonoBehaviour
	{
		public Renderer[] group;

		public GameObject hidBox;

		[SerializeField]
		private LayerMask LayerFilter;

		private void Start()
		{
		}

		public void GROUPENABLED()
		{
		}

		public void GROUPDISABLED()
		{
		}

		public void SHOWMODULE()
		{
		}

		public void HIDEMODULE()
		{
		}
	}
}
