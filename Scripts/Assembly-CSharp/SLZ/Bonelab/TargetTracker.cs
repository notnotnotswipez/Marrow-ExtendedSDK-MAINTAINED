using System;
using SLZ.Marrow.Combat;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;

namespace SLZ.Bonelab
{
	public class TargetTracker : MonoBehaviour, IAttackReceiver, IEventSystemHandler
	{
		public int score;

		public int minScore;

		public UnityEvent OnBullseye;

		public UnityEvent OnMinScore;

		public Action<int> OnScore;

		public void Bullseye()
		{
		}

		public void AddScore(int targetScore)
		{
		}

		public void ClearScore()
		{
		}

		public void ReceiveAttack(Attack attack)
		{
		}
	}
}
