using UnityEngine;
using UnityEngine.EventSystems;

namespace SLZ.Bonelab
{
	public class ButtonHoverClick : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerClickHandler
	{
		public Feedback_Tactile feedback_tactile;

		public Feedback_Audio feedback_audio;

		public bool confirmer;

		[Space(10f)]
		[Header("Leave empty unless override")]
		public int clipToPlay;

		public AudioClip clip_override_hover;

		public AudioClip clip_override_click;

		public AudioClip clip_override_confirmer;

		public AudioClip clip_override_deny;

		private void Awake()
		{
		}

		private void CheckRefs()
		{
		}

		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		public void OnPointerClick(PointerEventData eventData)
		{
		}

		public void HIGHLIGHT()
		{
		}

		public void CLICK()
		{
		}

		public void LOCKED()
		{
		}
	}
}
