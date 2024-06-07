using TMPro;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class HubModule_InfoBoard : MonoBehaviour
	{
		private int displayState;

		[Header("WELCOME INFO")]
		public TextMeshProUGUI txt_boardName;

		public TextMeshProUGUI txt_buildInfo;

		public GameObject[] boards;

		public int startBoard;

		public string[] boardName;

		private string buildDate;

		public GameObject storyButton;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		public void UPDATEUI()
		{
		}

		public void PAGECHANGE(bool forward)
		{
		}
	}
}
