using UnityEngine;
using UnityEngine.UI;

namespace SLZ.Bonelab
{
	public class UITooltip : MonoBehaviour
	{
		private Transform hmdTrackedObject;

		public string tooltipText;

		public float circleScale;

		public GameObject myCircle;

		public bool isShown;

		public bool showOnlyOnce;

		private Text myText;

		private Animation myAnimation;

		public AnimationClip fadeInClip;

		public AnimationClip fadeOutClip;

		private bool hasBeenShown;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void Update()
		{
		}

		public void SetActive(bool state)
		{
		}

		public void Show(bool state)
		{
		}
	}
}
