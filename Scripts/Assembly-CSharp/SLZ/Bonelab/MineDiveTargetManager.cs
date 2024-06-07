using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

namespace SLZ.Bonelab
{
	public class MineDiveTargetManager : MonoBehaviour
	{
		[SerializeField]
		private MineDiveTarget[] mineDiveTargets;

		[SerializeField]
		private int targetsHit;

		[SerializeField]
		private int totalScore;

		public TMP_Text[] totalText;

		[SerializeField]
		private int practiceScore;

		public TMP_Text practiceText;

		[SerializeField]
		private bool isSingleScore;

		private HashSet<MineDiveTarget> targetHash;

		public int scoreToTop;

		public UnityEvent topTarget;

		private void OnEnable()
		{
		}

		[ContextMenu("GrabAllMineTargets")]
		public void GrabAllTargets()
		{
		}

		private void TargetHit(MineDiveTarget target)
		{
		}

		private void UpdateDisplays()
		{
		}
	}
}
