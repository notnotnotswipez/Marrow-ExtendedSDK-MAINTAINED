using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SLZ.Bonelab.SaveData
{
	public sealed class DebugSettings
	{
		[JsonExtensionData]
		public IDictionary<string, JToken> AdditionalData
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		[JsonProperty("developer_mode")]
		public bool DeveloperMode
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public void FixFieldsIfNeeded()
		{
		}
	}
}
