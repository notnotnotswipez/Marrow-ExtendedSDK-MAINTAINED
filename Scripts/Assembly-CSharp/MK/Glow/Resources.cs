using System;
using UnityEngine;

namespace MK.Glow
{
	[Serializable]
	public sealed class Resources : ScriptableObject
	{
		[SerializeField]
		private Texture2D _lensSurfaceDirtTextureDefault;

		[SerializeField]
		private Texture2D _lensSurfaceDiffractionTextureDefault;

		[SerializeField]
		private Texture2D _lensFlareColorRampDefault;

		[SerializeField]
		private Shader _selectiveRenderShader;

		[SerializeField]
		private Shader _sm20Shader;

		[SerializeField]
		private Shader _sm25Shader;

		[SerializeField]
		private Shader _sm30Shader;

		[SerializeField]
		private Shader _sm35Shader;

		[SerializeField]
		private Shader _sm40Shader;

		[SerializeField]
		private Shader _sm40GeometryShader;

		[SerializeField]
		private ComputeShader _computeShader;

		[SerializeField]
		private ComputeShader _computeShaderGles;

		internal Texture2D lensSurfaceDirtTextureDefault => null;

		internal Texture2D lensSurfaceDiffractionTextureDefault => null;

		internal Texture2D lensFlareColorRampDefault => null;

		internal Shader selectiveRenderShader => null;

		internal Shader sm20Shader => null;

		internal Shader sm25Shader => null;

		internal Shader sm30Shader => null;

		internal Shader sm35Shader => null;

		internal Shader sm40Shader => null;

		internal Shader sm40GeometryShader => null;

		internal ComputeShader computeShader => null;

		internal static void ResourcesNotAvailableWarning()
		{
		}

		internal static Resources LoadResourcesAsset()
		{
			return null;
		}
	}
}
