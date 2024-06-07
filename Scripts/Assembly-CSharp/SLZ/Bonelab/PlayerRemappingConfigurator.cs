using SLZ.VRMK;

namespace SLZ.Bonelab
{
	public class PlayerRemappingConfigurator : AvatarExtension
	{
		public PolyEllipse[] ellipses;

		protected override void Awake()
		{
		}

		private void LateUpdate()
		{
		}

		public override void OnWriteTransforms()
		{
		}

		public override void OnRefreshBodyMeasurements()
		{
		}

		public void UpdatePolyEllipse(int i, float front, float back, float side)
		{
		}
	}
}
