using SLZ.Marrow;
using SLZ.Marrow.AI;
using SLZ.Marrow.Data;
using SLZ.Marrow.Interaction;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class LinkDataManager : MonoBehaviour
	{
		public MarrowEntity playerEntity;

		public RigManager rigManager;

		public Rigidbody playerPelvisRB;

		public Rigidbody[] playerRBs;

		public TriggerRefProxy playerProxy;

		public LaunchHelper launchHelper;

		public AudioClip launchClip;

		public AudioClip enableTargClip;

		public AudioClip disableTargClip;

		public GameObject climbLinkPrefab;

		public GameObject jumpLinkPrefab;

		public GameObject launchLinkPrefab;

		public GameObject launchLinkArtPrefab;

		public GameObject slideLinkPrefab;

		public GameObject climbBarLinkPrefab;

		public GameObject climbLedgeLinkPrefab;

		public GameObject zipLinePrefab;

		public GameObject partialZipLinkPrefab;

		public Spawnable zipStickSpawnable;

		public GameObject zipJointMoverPrefab;

		public GameObject zipMechPrefab;

		public GameObject zipMechGripPrefab;

		public GameObject zipBarPrefab;

		public void Awake()
		{
		}

		private void GetPlayerEntity()
		{
		}
	}
}
