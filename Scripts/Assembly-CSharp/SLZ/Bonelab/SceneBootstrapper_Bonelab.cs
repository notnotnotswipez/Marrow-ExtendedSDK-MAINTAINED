using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Bonelab.SaveData;
using SLZ.Marrow.Warehouse;
using TMPro;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class SceneBootstrapper_Bonelab : MonoBehaviour
	{
		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CStart_003Ed__8 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public SceneBootstrapper_Bonelab _003C_003E4__this;

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

		public LevelCrateReference ShaderPrewarmCrateRef;

		public LevelCrateReference MenuHollowCrateRef;

		public LevelCrateReference VoidG114CrateRef;

		public TextMeshProUGUI tmp;

		public GameObject Overlay2d;

		public Mesh ReplacementCube;

		private static PlayerProgression p => null;

		[AsyncStateMachine(typeof(_003CStart_003Ed__8))]
		private UniTaskVoid Start()
		{
			return default(UniTaskVoid);
		}

		private void UpdateLog(string msg)
		{
		}
	}
}
