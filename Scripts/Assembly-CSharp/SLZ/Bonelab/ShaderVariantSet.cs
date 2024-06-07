using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

namespace SLZ.Bonelab
{
	public class ShaderVariantSet : ScriptableObject
	{
		[Serializable]
		public struct VariantList
		{
			public List<string> keywords;

			public List<Variant> variants;
		}

		[Serializable]
		public struct Variant : IEquatable<Variant>
		{
			public bool instanced;

			public int[] localKWIdx;

			public override int GetHashCode()
			{
				return 0;
			}

			public override bool Equals(object obj)
			{
				return false;
			}

			public bool Equals(Variant other)
			{
				return false;
			}
		}

		public SerializedDictionary<Shader, VariantList> Collection;
	}
}
