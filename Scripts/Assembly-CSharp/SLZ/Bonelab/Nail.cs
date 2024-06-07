using System.Runtime.CompilerServices;
using SLZ.Marrow.Interaction;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class Nail : MonoBehaviour
	{
		public Rigidbody rb;

		public Rigidbody connectedRb;

		public Transform nailTran;

		public float breakforce;

		public MarrowJoint Joint
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		private void Reset()
		{
		}

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void MakeJoint()
		{
		}

		private void OnMarrowJointBreak(MarrowJoint joint)
		{
		}

		private void OnDestroy()
		{
		}
	}
}
