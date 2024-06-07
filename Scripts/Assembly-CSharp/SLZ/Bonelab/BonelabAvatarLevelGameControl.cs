using SLZ.Marrow.Interaction;
using SLZ.Marrow.Warehouse;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class BonelabAvatarLevelGameControl : BonelabInternalGameControl
	{
		[SerializeField]
		private MarrowEntity nextButton;

		[SerializeField]
		private MarrowEntity[] startExtraButtons;

		[SerializeField]
		private MarrowEntity[] endExtraButtons;

		[SerializeField]
		private GenericCrateReference unlockCrate;

		[SerializeField]
		private CrateSpawner avatarGacha;

		[SerializeField]
		private bool waitForObjectiveComplete;

		[SerializeField]
		private bool placeAvatarGachaOnStart;

		public override void Start()
		{
		}

		protected void LevelSetup()
		{
		}

		public void ObjectiveComplete()
		{
		}

		public void GachaPopped()
		{
		}

		public override void DoLevelComplete()
		{
		}
	}
}
