using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cysharp.Threading.Tasks;
using JetBrains.Annotations;
using Newtonsoft.Json.Linq;
using SLZ.ModIO;
using SLZ.ModIO.WebSockets;
using UnityEngine;

namespace SLZ.Marrow.Forklift
{
	// Token: 0x0200017F RID: 383
	public class ModIOManager : MonoBehaviour
	{
		// Token: 0x14000003 RID: 3
		// (add) Token: 0x06000E5C RID: 3676 RVA: 0x00004F7C File Offset: 0x0000317C
		// (remove) Token: 0x06000E5D RID: 3677 RVA: 0x00004F7E File Offset: 0x0000317E
		public event ModIOManager.LoginSequenceHandler BeginUserInitiatedLogin
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x06000E5E RID: 3678 RVA: 0x00004F80 File Offset: 0x00003180
		// (remove) Token: 0x06000E5F RID: 3679 RVA: 0x00004F82 File Offset: 0x00003182
		public event ModIOManager.UserCodePromptHandler RequestUserCodeEntry
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x06000E60 RID: 3680 RVA: 0x00004F84 File Offset: 0x00003184
		// (remove) Token: 0x06000E61 RID: 3681 RVA: 0x00004F86 File Offset: 0x00003186
		public event ModIOManager.LoginSequenceHandler CompleteUserInitiatedLogin
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x06000E62 RID: 3682 RVA: 0x00004F88 File Offset: 0x00003188
		// (remove) Token: 0x06000E63 RID: 3683 RVA: 0x00004F8A File Offset: 0x0000318A
		public event ModIOManager.LoginSequenceHandler FailUserInitiatedLogin
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x170002D3 RID: 723
		// (get) Token: 0x06000E64 RID: 3684 RVA: 0x00004F8C File Offset: 0x0000318C
		private static string ModIOSettingsPath
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170002D4 RID: 724
		// (get) Token: 0x06000E65 RID: 3685 RVA: 0x00004F8F File Offset: 0x0000318F
		// (set) Token: 0x06000E66 RID: 3686 RVA: 0x00004F92 File Offset: 0x00003192
		public string ModIOApiKey
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

		// Token: 0x170002D5 RID: 725
		// (get) Token: 0x06000E67 RID: 3687 RVA: 0x00004F94 File Offset: 0x00003194
		// (set) Token: 0x06000E68 RID: 3688 RVA: 0x00004F97 File Offset: 0x00003197
		public int ModIOGameId
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170002D6 RID: 726
		// (get) Token: 0x06000E69 RID: 3689 RVA: 0x00004F99 File Offset: 0x00003199
		// (set) Token: 0x06000E6A RID: 3690 RVA: 0x00004F9C File Offset: 0x0000319C
		public bool IsLoggedIn
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170002D7 RID: 727
		// (get) Token: 0x06000E6B RID: 3691 RVA: 0x00004F9E File Offset: 0x0000319E
		// (set) Token: 0x06000E6C RID: 3692 RVA: 0x00004FA1 File Offset: 0x000031A1
		public ModIOAPI ModIOAPI
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

		// Token: 0x170002D8 RID: 728
		// (get) Token: 0x06000E6D RID: 3693 RVA: 0x00004FA3 File Offset: 0x000031A3
		// (set) Token: 0x06000E6E RID: 3694 RVA: 0x00004FA6 File Offset: 0x000031A6
		public ModIOWebSocketAPI ModIOWebSocketAPI
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

		// Token: 0x170002D9 RID: 729
		// (get) Token: 0x06000E6F RID: 3695 RVA: 0x00004FA8 File Offset: 0x000031A8
		// (set) Token: 0x06000E70 RID: 3696 RVA: 0x00004FAB File Offset: 0x000031AB
		[CanBeNull]
		public JObject ModSettingsJSON
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

		// Token: 0x06000E71 RID: 3697 RVA: 0x00004FAD File Offset: 0x000031AD
		private void OnEnable()
		{
		}

		// Token: 0x06000E72 RID: 3698 RVA: 0x00004FAF File Offset: 0x000031AF
		private void OnDisable()
		{
		}

		// Token: 0x06000E73 RID: 3699 RVA: 0x00008254 File Offset: 0x00006454
		public UniTask<bool> LoadAndCheckLogin(CancellationToken cancellationToken)
		{
			return default(UniTask<bool>);
		}

		// Token: 0x06000E74 RID: 3700 RVA: 0x0000826C File Offset: 0x0000646C
		public UniTaskVoid LogIn(CancellationToken cancellationToken)
		{
			return default(UniTaskVoid);
		}

		// Token: 0x06000E75 RID: 3701 RVA: 0x00004FB1 File Offset: 0x000031B1
		private Task ApiOnMessageReceived(Message message)
		{
			return null;
		}

		// Token: 0x06000E76 RID: 3702 RVA: 0x00008284 File Offset: 0x00006484
		private UniTask ApiOnMessageReceivedUT(Message message)
		{
			return default(UniTask);
		}

		// Token: 0x06000E77 RID: 3703 RVA: 0x0000829C File Offset: 0x0000649C
		private UniTask<bool> ValidateAccessToken(string accessToken, CancellationToken cancellationToken)
		{
			return default(UniTask<bool>);
		}

		// Token: 0x06000E78 RID: 3704 RVA: 0x000082B4 File Offset: 0x000064B4
		private static UniTask<JObject> LoadModSettings(CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<JObject>);
		}

		// Token: 0x06000E79 RID: 3705 RVA: 0x00004FB4 File Offset: 0x000031B4
		private static RequestContext _oneOffRequestContext(string apiKey, string accessToken)
		{
			return null;
		}

		// Token: 0x04000A14 RID: 2580
		private CancellationTokenSource _enableCTS;

		// Token: 0x04000A15 RID: 2581
		private CancellationTokenSource _receiveLoopCTS;

		// Token: 0x02000297 RID: 663
		// (Invoke) Token: 0x060013CA RID: 5066
		public delegate UniTask LoginSequenceHandler();

		// Token: 0x02000298 RID: 664
		// (Invoke) Token: 0x060013CE RID: 5070
		public delegate UniTask UserCodePromptHandler(DeviceLoginResponseContext loginResponseContext);
	}
}
