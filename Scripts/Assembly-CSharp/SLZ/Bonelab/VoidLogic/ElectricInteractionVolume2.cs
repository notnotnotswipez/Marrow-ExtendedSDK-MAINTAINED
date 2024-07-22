using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Marrow;
using SLZ.Marrow.Interaction;
using SLZ.Marrow.VoidLogic;
using UnityEngine;

namespace SLZ.Bonelab.VoidLogic
{
	public class ElectricInteractionVolume2 : InteractionVolume
	{
		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CElectricInteractionCooldown_003Ed__15 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public ElectricInteractionVolume2 _003C_003E4__this;

			public IGrippable host;

			private UniTask.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

            void IAsyncStateMachine.MoveNext()
            {
                throw new System.NotImplementedException();
            }

            [DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

            void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
                throw new System.NotImplementedException();
            }
        }

		[SerializeField]
		private MarrowBody _marrowBody;

		public Transform targetPos;

		public Collider[] recieverColliders;

		public AudioClip[] insertClips;

		public AudioClip[] removeClips;

		private bool _isBatteryInserted;

		public PassthroughNode _powerPassthrough;

		private IVoidLogicSource _powerIn;

		private CylinderElectronicGrip2 _batteryHandleGrip;

		private CylinderElectronicGrip2 _batteryBodyGrip;

		protected override void OnHoverStart(InteractableHost host)
		{
		}

		protected override void OnHoverEnd(InteractableHost host)
		{
		}

		protected override void OnHoverUpdate(InteractableHost host)
		{
		}

		private void HandAttached(IGrippable host, CylinderElectronicGrip2 grip)
		{
		}

		private void RemoveElectronic(IGrippable host, CylinderElectronicGrip2 grip)
		{
		}

		[AsyncStateMachine(typeof(_003CElectricInteractionCooldown_003Ed__15))]
		private UniTaskVoid ElectricInteractionCooldown(IGrippable host)
		{
			return default(UniTaskVoid);
		}
	}
}
