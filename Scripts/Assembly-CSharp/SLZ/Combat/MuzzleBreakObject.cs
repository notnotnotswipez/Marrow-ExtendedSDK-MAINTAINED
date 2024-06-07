using UnityEngine;

namespace SLZ.Combat
{
	[CreateAssetMenu(fileName = "New Muzzle Break Value", menuName = "Variables/Muzzle Break Item", order = 3)]
	public class MuzzleBreakObject : ScriptableObject
	{
		public MuzzleBreakVariables muzzleBreakVariables;
	}
}
