namespace TriangleNet.Tools
{
	public class Statistic
	{
		public static long InCircleCount;

		public static long InCircleAdaptCount;

		public static long CounterClockwiseCount;

		public static long CounterClockwiseAdaptCount;

		public static long Orient3dCount;

		public static long HyperbolaCount;

		public static long CircumcenterCount;

		public static long CircleTopCount;

		public static long RelocationCount;

		private double minEdge;

		private double maxEdge;

		private double minAspect;

		private double maxAspect;

		private double minArea;

		private double maxArea;

		private double minAngle;

		private double maxAngle;

		private int[] angleTable;

		private int[] minAngles;

		private int[] maxAngles;

		private static readonly int[] plus1Mod3;

		private static readonly int[] minus1Mod3;

		public double ShortestEdge => 0.0;

		public double LongestEdge => 0.0;

		public double ShortestAltitude => 0.0;

		public double LargestAspectRatio => 0.0;

		public double SmallestArea => 0.0;

		public double LargestArea => 0.0;

		public double SmallestAngle => 0.0;

		public double LargestAngle => 0.0;

		public int[] AngleHistogram => null;

		public int[] MinAngleHistogram => null;

		public int[] MaxAngleHistogram => null;

		private void GetAspectHistogram(Mesh mesh)
		{
		}

		public void Update(Mesh mesh, int sampleDegrees)
		{
		}
	}
}
