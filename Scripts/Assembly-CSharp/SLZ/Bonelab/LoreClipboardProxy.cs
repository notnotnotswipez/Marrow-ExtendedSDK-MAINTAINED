using SLZ.Marrow.Zones;
using TMPro;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class LoreClipboardProxy : SpawnDecorator
	{
		[Space(10f)]
		[Header("Text")]
		public string title;

		[TextArea(5, 20)]
		public string body;

		[Space(30f)]
		public TMP_FontAsset font_custom;

		public bool useColor;

		public Color textColor;

		[Tooltip("Will default to prefab value if null")]
		public AudioClip audioActivateOverride;

		[Tooltip("Will default to prefab value if null")]
		public AudioClip audioDeactivateOverride;

	}
}
