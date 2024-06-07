namespace SLZ.Rig
{
	public class MirrorControllerRig : ControllerRig
	{
		public RigManager mirrorTarget;

		public bool followTarget;

		public float safeDistance;

		private float _currentRotDelta;

		private float _currentRotVel;

		public override void OnAwake()
		{
		}

		public override void OnEarlyUpdate()
		{
		}

		public void ClearPath()
		{
		}

		public void EnableFollow(bool enabled)
		{
		}

		public void TempFollowRotation()
		{
		}

		public override void OnFixedUpdate(float deltaTime)
		{
		}

		public override void OnAfterFixedUpdate()
		{
		}
	}
}
