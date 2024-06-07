using UnityEngine;
using UnityEngine.Splines;

namespace SLZ.Bonelab
{
	public class SplineTimeline : MonoBehaviour
	{
		public SplineData<SplineTimelineNode> points;

		private SplineContainer splineContainer;

		public int Count => 0;

		public SplineContainer Container
		{
			get
			{
				return null;
			}
			set
			{
			}
		}
	}
}
