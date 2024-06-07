using UnityEngine;
using UnityEngine.Playables;

namespace SLZ.Bonelab
{
	public class SplineJointTimeline : MonoBehaviour
	{
		public SplineJoint splineJoint;

		public PlayableDirector playableDirector;

		public SplineBody timelineDriverBody;

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void OnCurveChanged()
		{
		}

		public static void ManualSetWithNotifications(PlayableDirector director, double time)
		{
		}
	}
}
