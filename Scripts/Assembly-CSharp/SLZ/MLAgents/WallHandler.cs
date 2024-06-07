using UnityEngine;

namespace SLZ.MLAgents
{
	public class WallHandler : MonoBehaviour
	{
		public GameObject TopWall;

		public GameObject BottomWall;

		public GameObject RightWall;

		public GameObject LeftWall;

		public GameObject Goal;

		[HideInInspector]
		public GameObject[] walls;

		private void Start()
		{
		}
	}
}
