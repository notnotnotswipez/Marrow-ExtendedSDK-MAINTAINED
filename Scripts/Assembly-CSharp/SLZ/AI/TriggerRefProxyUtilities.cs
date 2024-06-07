using SLZ.Marrow.AI;

namespace SLZ.AI
{
	public static class TriggerRefProxyUtilities
	{
		public static float HostilityTowards(this TriggerRefProxy myTrp, TriggerRefProxy otherTrp)
		{
			return 0f;
		}

		public static bool IsHostileTowards(this TriggerRefProxy myTrp, TriggerRefProxy otherTrp, float hostileThreshold = 0.5f, bool neutralIsHostile = false)
		{
			return false;
		}
	}
}
