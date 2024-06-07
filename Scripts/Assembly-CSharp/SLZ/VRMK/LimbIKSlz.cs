using RootMotion.FinalIK;
using UnityEngine;

namespace SLZ.VRMK
{
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Limb IK")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page7.html")]
	public class LimbIKSlz : IK
	{
		public IKSolverLimbSlz solver;

		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		public override IKSolver GetIKSolver()
		{
			return null;
		}
	}
}
