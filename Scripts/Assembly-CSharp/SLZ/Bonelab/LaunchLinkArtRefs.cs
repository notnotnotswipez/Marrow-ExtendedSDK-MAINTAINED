using SLZ.Combat;
using SLZ.SFX;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class LaunchLinkArtRefs : MonoBehaviour
	{
		public GameObject forwardObjs;

		public GameObject reverseObjs;

		public Animator forwardArtAnim;

		public Animator reverseArtAnim;

		public MeshRenderer[] colorRends;

		public GameObject forwExplicitTriggerObj;

		public GameObject reverseExplicitTriggerObj;

		public GenericAttackReceiver[] genAttackRecievers;

		public GenGameControl_Trigger forwTrig;

		public GenGameControl_Trigger revTrig;

		public GameObject playerTargForw;

		public GameObject playerTargRev;

		[Header("ToggleLaunchPads")]
		public AmbientSFX forwAmbSFX;

		public AmbientSFX revAmbSFX;

		public ParticleSystem forwParticles;

		public ParticleSystem revParticles;

		public GameObject[] forwToggleObjs;

		public GameObject[] revToggleObjs;

		public Collider[] fwdCols;

		public Collider[] revCols;

		public Renderer forwRingRend;

		public Renderer revRingRend;

		public Material brightLampMat;

		public Material darkLampMat;
	}
}
