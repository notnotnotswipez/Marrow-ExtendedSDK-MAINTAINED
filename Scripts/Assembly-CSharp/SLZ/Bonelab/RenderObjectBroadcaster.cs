using UnityEngine;
using UnityEngine.Events;

namespace SLZ.Bonelab
{
	public class RenderObjectBroadcaster : MonoBehaviour
	{
		public UnityEvent RenderEvent;

		private void OnRenderObject()
		{
		}
	}
}
