using System;
using System.Runtime.CompilerServices;
using Unity.MLAgents;
using UnityEngine;

namespace SLZ.MLAgents
{
	public class Contestant : MonoBehaviour
	{
		public delegate void CheckpointCompletedDelegate(Contestant contestant, int cp_ind, float currentCpTime);

		public delegate void WrongCheckpointDelegate();

		public delegate void TimeoutDelegate(Contestant contestant, int cp_ind);

		[Tooltip("Vehicle class reference")]
		[Header("Vehicle Section")]
		public BaseVehicle baseVehicle;

		[Tooltip("Game Object reference")]
		public GameObject vehicle;

		[Tooltip("Used for lineup calculation")]
		[Header("Contestant Section")]
		public int contestantNumber;

		[Tooltip("Not used yet")]
		public int team_id;

		[Header("Checkpoint Section")]
		[Tooltip("Amount of time the contestant has been on current checkpoint")]
		public float currentCpTime;

		[Tooltip("Checkpoint this contestant is on")]
		public int cp_ind;

		public bool cp_lockout;

		[Tooltip("Total amount of time a contestant have before its reset (this value set to zero on success event)")]
		public float cpTimeOut;

		[Tooltip("Reset if checkpoint timer has finished")]
		public bool use_timeout;

		[Tooltip("For stats collection and early stopping")]
		[Header("Statistics Section")]
		public int concurrent_incorrect;

		[Tooltip("For stats collection")]
		public int nb_wrong_cps;

		[Tooltip("For stats collection")]
		public int nb_fails;

		public EnvironmentParameters envParams;

		public CheckpointCompletedDelegate checkpointCompletedDelegate;

		public WrongCheckpointDelegate wrongCheckpointDelegate;

		public TimeoutDelegate timeoutDelegate;

		public event Action ContestantRegistered
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action TimeoutEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public virtual void Respawn()
		{
		}

		public virtual void SoftReset()
		{
		}

		public void RegisterSuccess()
		{
		}

		protected virtual void TimeoutTicker()
		{
		}

		public virtual void HandleCheckpoint(CheckPoint temp_cp)
		{
		}
	}
}
