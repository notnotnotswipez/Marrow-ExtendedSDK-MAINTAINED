using TMPro;
using UnityEngine;
using UnityEngine.Events;

namespace SLZ.Interaction
{
	public class MultiAuthenticator : MonoBehaviour
	{
		[Tooltip("Number of inputs required to activate")]
		public int requiredInputs;

		[SerializeField]
		private UnityEvent unlockEvent;

		[SerializeField]
		private UnityEvent lockEvent;

		[SerializeField]
		private TMP_Text[] totalInputTexts;

		[SerializeField]
		private TMP_Text[] activeInputTexts;

		private int currentInputs;

		public void InitTexts()
		{
		}

		public void AddCount()
		{
		}

		public void RemoveCount()
		{
		}

		private void CheckLock()
		{
		}
	}
}
