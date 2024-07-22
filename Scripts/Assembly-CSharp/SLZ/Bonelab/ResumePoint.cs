using System;
using UnityEngine;
using UnityEngine.Events;

namespace SLZ.Bonelab
{
	[Serializable]
	public struct ResumePoint
	{
		[Tooltip("Spawn point location")]
		public Transform spawnLocation;

		[Tooltip("Spawn point location for item held in left hand when saving partial progress")]
		public Transform leftHandItem;

		[Tooltip("Spawn point location for item held in right hand when saving partial progress")]
		public Transform rightHandItem;

		[Tooltip("Set the checkpoint you want enabled for if the player dies immediately on spawn")]
		public ZoneCheckpoint checkpoint;

		[Tooltip("Game Objects to be disabled on this progression point")]
		[Header("Spawners deactive all previous spawners")]
		public GameObject[] disableObjects;

		[Tooltip("Game Objects to be enabled on this progression point")]
		public GameObject[] enableObjects;

		[Tooltip("Callbacks to invoke when the resume point is reached")]
		public UnityEvent OnReachedResumePoint;
	}
}
