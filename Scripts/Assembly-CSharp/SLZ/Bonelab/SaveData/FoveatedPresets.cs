using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace SLZ.Bonelab.SaveData
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum FoveatedPresets : sbyte
	{
		Custom = -1,
		Disabled = 0,
		Wide = 1,
		Medium = 2,
		Narrow = 3
	}
}
