using UnityEngine;
using UnityEngine.Rendering.Universal;

namespace SLZ.Bonelab
{
	public class Control_Player : MonoBehaviour
	{
		public UIRig uiRig;

		[HideInInspector]
		public float stored_offset_Sitting;

		public RigScreenOptions rigScreen;

		public UniversalRenderPipelineAsset CustomPipelineAsset;

		public bool toolTipDisplay
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public int physicsUpdateRate => 0;

		public void OnEnable()
		{
		}

		private void Startup()
		{
		}

		public void STANDING()
		{
		}

		public void SendHeight()
		{
		}

		public void UpdateSpectator()
		{
		}

		public void SEND_GRAPHICS()
		{
		}

		public void SEND_VITALS()
		{
		}

		public void AUDIOUPDATE()
		{
		}

		public void SEND_BODYLOG_VITALS()
		{
		}
	}
}
