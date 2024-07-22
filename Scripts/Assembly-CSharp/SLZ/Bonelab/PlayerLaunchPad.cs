using System;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class PlayerLaunchPad : MonoBehaviour
	{
		public struct LaunchData
		{
			public readonly Vector3 initialVelocity;

			public readonly float timeToTarget;

		}

		public Rigidbody[] playerBodies;

		public Rigidbody playerPelvisBody;

		public float launchableTime;

		public float coolDownDuration;

		public float agentDot;

		public float launchForceMult;

		public Transform launchTarget;

		public float linkDepth;

		public Action<Vector3> OnLaunchAction;

		public AudioClip launchClip;

		public void SubToPlayerJump(bool enable)
		{
		}

		public float CheckAgentDot(GameObject agentObj)
		{
			return 0f;
		}

		[ContextMenu("GetAllPlayerBodies")]
		public void GetAllPlayerBodies()
		{
		}

		public void LaunchPlayer()
		{
		}

		public LaunchData CalculateLaunchData(GameObject launchObj, float height, float gravity)
		{
			return default(LaunchData);
		}

		public void LaunchAudio()
		{
		}

		public void OnDrawGizmosSelected()
		{
		}
	}
}
