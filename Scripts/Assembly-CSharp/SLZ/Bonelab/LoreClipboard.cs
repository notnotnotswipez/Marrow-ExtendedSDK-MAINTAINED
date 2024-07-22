using SLZ.Marrow;
using SLZ.SFX;
using TMPro;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class LoreClipboard : MonoBehaviour
	{
		public BoxGrip grip;

		public CylinderGrip bottomGrip;

		[Header("Text")]
		[Space(10f)]
		public string title;

		[TextArea(5, 20)]
		public string body;

		[Space(30f)]
		public TextMeshPro tmp_title;

		public TextMeshPro tmp_body;

		public TMP_FontAsset font_custom;

		private bool lefthand;

		private bool righthand;

		public bool useColor;

		public Color textColor;

		public AudioClip audioActivate;

		public AudioClip audioDeactivate;

		public SimpleSFX simpleSFX;

		private bool canPlayActivate;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnHandAttached(Hand hand)
		{
		}

		private void OnHandDetached(Hand hand)
		{
		}

		private void ActiveText(bool goActive = false)
		{
		}
	}
}
