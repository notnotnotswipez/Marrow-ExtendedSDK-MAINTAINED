using System.Collections.Generic;
using SLZ.Marrow;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class NavDestTrigger : MonoBehaviour
	{
		[SerializeField]
		private bool isObstructed;

		[SerializeField]
		private int destCount;

		[SerializeField]
		private int costModMult;

		[SerializeField]
		private ObjectDestructible defaultDestObj;

		[Header("LinkTrigger")]
		[SerializeField]
		private bool isLink;

		[SerializeField]
		private LinkData[] linkDatas;

		[SerializeField]
		[Header("NavMeshAreaTrigger")]
		private Arena_GameController gameController;

		[SerializeField]
		private string areaName;

		private HashSet<ObjectDestructible> destHash;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnDestruction(ObjectDestructible dest)
		{
		}

		private void OnTriggerEnter(Collider other)
		{
		}

		private void ToggleAreaOrLink()
		{
		}
	}
}
