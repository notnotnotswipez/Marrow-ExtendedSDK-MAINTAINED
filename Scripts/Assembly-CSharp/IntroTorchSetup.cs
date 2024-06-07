using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Marrow.Zones;
using UnityEngine;

public class IntroTorchSetup : SpawnDecorator
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CReactivateTimmer_003Ed__6 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

		public GameObject go;

		private UniTask.Awaiter _003C_003Eu__1;

		public void MoveNext()
		{
		}

		[DebuggerHidden]
		public void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	public Rigidbody attachPoint;

	public int index;

	private ConfigurableJoint _torchJoint;

	public override void OnSpawn(GameObject go)
	{
	}

	private void SetJoint(ConfigurableJoint joint, Rigidbody _connectedBody)
	{
	}

	public void BreakJoint()
	{
	}

	[AsyncStateMachine(typeof(_003CReactivateTimmer_003Ed__6))]
	private UniTaskVoid ReactivateTimmer(GameObject go)
	{
		return default(UniTaskVoid);
	}
}
