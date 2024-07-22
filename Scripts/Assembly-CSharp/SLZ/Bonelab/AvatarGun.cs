using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Marrow;
using SLZ.Marrow.Audio;
using SLZ.Marrow.Data;
using SLZ.Marrow.Warehouse;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class AvatarGun : MonoBehaviour
	{
		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CLoadFavoriteAvatars_003Ed__27 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public AvatarGun _003C_003E4__this;

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

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CSwapAvatar_003Ed__28 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public RigManager targetRig;

			public AvatarCrateReference avatarCrateRef;

			public AvatarGun _003C_003E4__this;

			private UniTask<bool>.Awaiter _003C_003Eu__1;

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

		public Grip triggerGrip;

		public Transform firePoint;

		public GameObject selectorKnob;

		public LayerMask playerLayerMask;

		[Header("Avatars")]
		public AvatarCrateReference[] avatarCrates;

		private AvatarCrateReference initialAvatar;

		private AvatarCrateReference lastAvatar;

		private int avatarIndex;

		[SerializeField]
		[Header("VFX")]
		private Spawnable vfxBlasterSpawnable;

		[SerializeField]
		private Spawnable avatarBlaster;

		public GameObject laser;

		[Header("Audio")]
		public AudioClip[] fireSFX;

		public AudioClip[] misfireSFX;

		public AudioClip[] modeSFX;

		private ManagedAudioPlayer _map;

		private int choice;

		private RigManager rigManager;

		public LayerMask collisionLayers;

		public float effectiveRange;

		private List<string> defaultFavoriteAvatarsBarcodes;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnTriggerGripAttached(Hand hand)
		{
		}

		private void OnTriggerGripDetached(Hand hand)
		{
		}

		private void OnTriggerGripUpdate(Hand hand)
		{
		}

		[AsyncStateMachine(typeof(_003CLoadFavoriteAvatars_003Ed__27))]
		private UniTaskVoid LoadFavoriteAvatars()
		{
			return default(UniTaskVoid);
		}

		[AsyncStateMachine(typeof(_003CSwapAvatar_003Ed__28))]
		private UniTaskVoid SwapAvatar(AvatarCrateReference avatarCrateRef, RigManager targetRig)
		{
			return default(UniTaskVoid);
		}

		private void PlayParticles(SkinnedMeshRenderer[] meshs)
		{
		}

		private float GetVolumeSurface(Vector3 size)
		{
			return 0f;
		}
	}
}
