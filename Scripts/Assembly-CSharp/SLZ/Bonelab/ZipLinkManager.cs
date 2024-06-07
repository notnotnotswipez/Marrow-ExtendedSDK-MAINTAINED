using System.Collections.Generic;
using SLZ.Marrow.AI;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class ZipLinkManager : MonoBehaviour
	{
		public List<AgentLinkControl> agentList;

		public List<LinkData> downLinksList;

		public List<LinkData> upLinksList;

		public List<LinkData> linkList;

		public float delayedTime;

		public TriggerRefProxy playerProxy;

		public ZipLinkSetup zipLinkSetup;

		public GameObject partialLinkSetupPrefab;

		public int zipStickLength;

		private GameObject upPartialObj;

		private GameObject downPartialObj;

		private void Awake()
		{
		}

		public void ClaimZipDownLinks(AgentLinkControl agentController, LinkData linkData)
		{
		}

		public void ReleaseZipDownLinks(AgentLinkControl agentController)
		{
		}

		public void ClaimZipUpLinks(TriggerRefProxy proxy = null, AgentLinkControl agentController = null)
		{
		}

		public void ReleaseZipUpLinks()
		{
		}

		[ContextMenu("Create Zip Up Partial Link")]
		public void CreatePartialZipUpLink()
		{
		}

		[ContextMenu("Create Zip Down Partial Link")]
		public void CreatePartialZipDownLink()
		{
		}

		public LinkData CopyLinkData(LinkData ogLinkData, GameObject linkDataGO)
		{
			return null;
		}
	}
}
