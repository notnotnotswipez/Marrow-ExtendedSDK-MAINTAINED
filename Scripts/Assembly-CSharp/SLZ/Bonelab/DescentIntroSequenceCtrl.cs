using SLZ.Marrow.VoidLogic;
using SLZ.VFX;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class DescentIntroSequenceCtrl : MonoBehaviour
	{
		public GameControl_Descent _gameControlDescent;

		[Header("ConfirmHeight")]
		public GameObject panel_PlayerHeight;

		public GameObject playerHeightUI;

		[Header("DieRollResult")]
		public GameObject avatarSpawnParticles;

		[Header("DieJointBreak")]
		public VFX_AuraHighlight dieAuraVFX;

		[Header("ConfirmAvatarButton")]
		public GameObject pedestal;

		public AudioClip pedestalDisolveSFX;

		public Transform pedestalDisolvePoint;

		public PowerSource powerConstellationParticles;

		public PowerSource powerWindParticles;

		public void ConfirmHeightSettings()
		{
		}

		public void DieRollResult()
		{
		}

		public void DieJointBreak()
		{
		}

		public void ConfirmAvatarButton()
		{
		}
	}
}
