using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace SLZ.Bonelab.SaveData
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum Difficulty : sbyte
	{
		EASY = 0,
		MEDIUM = 1,
		HARD = 2
	}
}
