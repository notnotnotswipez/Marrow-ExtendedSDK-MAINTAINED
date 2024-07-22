using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Marrow.Interaction;
using UnityEngine;

namespace SLZ.Bonelab
{
	[Obsolete("Uses obsolete zone components")]
	public class HeadTitlesTrigger : MonoBehaviour
	{
		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CDelayedSENDTITLES_async_003Ed__16 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public HeadTitlesTrigger _003C_003E4__this;

			public MarrowEntity entity;

			private UniTask.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

            void IAsyncStateMachine.MoveNext()
            {
                throw new NotImplementedException();
            }

            [DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

            void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
                throw new NotImplementedException();
            }
        }

		public AudioClip clipToPlay;

		public string string_Title;

		public string string_SubTitle;

		public Sprite spriteToDisplay;

		public float bufferTime;

		[Tooltip("delay in seconds till headtitle starts")]
		public float startDelay;

		[Header("LEVEL TRIGGER")]
		public bool isLevel;

		public Sprite[] levelSprites;

		[Header("AVATAR LEVEL TRIGGER")]
		public bool isAvatarLevel;

		public Sprite spriteA;

		public Sprite spriteB;

		public Sprite spriteC;

		public Sprite spriteD;

		private float timeToSend;

		private string currentTag;

		public void DelayedSENDTITLES(MarrowEntity entity)
		{
		}

		[AsyncStateMachine(typeof(_003CDelayedSENDTITLES_async_003Ed__16))]
		private UniTaskVoid DelayedSENDTITLES_async(MarrowEntity entity)
		{
			return default(UniTaskVoid);
		}

		public void SENDTITLES(MarrowEntity entity)
		{
		}
	}
}
