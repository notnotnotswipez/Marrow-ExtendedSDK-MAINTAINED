using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace SLZ.Bonelab.SaveData
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum GraphicsQuality : sbyte
	{
		Custom = -1,
		Performance = 0,
		Low = 1,
		Medium = 2,
		High = 3,
		Ultra = 4
	}
}
