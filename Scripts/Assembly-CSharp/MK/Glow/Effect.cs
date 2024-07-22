using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

namespace MK.Glow
{
	internal sealed class Effect
	{
		internal enum ShaderRenderPass
		{
			Presample = 0,
			Downsample = 1,
			Upsample = 2,
			Composite = 3,
			Debug = 4
		}

		internal enum MaterialKeywords
		{
			Bloom = 0,
			LensSurface = 1,
			LensFlare = 2,
			Glare1 = 3,
			DebugRawBloom = 4,
			DebugRawLensFlare = 5,
			DebugRawGlare = 6,
			DebugBloom = 7,
			DebugLensFlare = 8,
			DebugGlare = 9,
			DebugComposite = 10,
			LegacyBlit = 11,
			RenderPriorityQuality = 12,
			Natural = 13,
			Glare2 = 14,
			Glare3 = 15,
			Glare4 = 16,
			Null = 17,
			RenderPriorityBalanced = 18,
			HQAntiFlickerFilter = 19,
			ReadGamma = 20
		}

		internal struct Keyword
		{
			internal string name;

			internal bool enabled;

		}

		private static Resources _resources;

		private static readonly Vector2 _referenceResolution;

		private static readonly float _referenceAspectRatio;

		private static readonly Vector2 _selectiveWorkflowThreshold;

		private static readonly int _cArgBufferSize;

		private static readonly int _glareIterationsBase;

		private static readonly RenderDimension _directComputeSize;

		private static readonly float naturalIntensityMult;

		private static readonly string _selectiveReplacementTag;

		private static readonly string _selectiveGlowCameraObjectName;

		private GameObject _selectiveGlowCameraObject;

		private Camera _selectiveGlowCamera;

		private ComputeShaderVariants _presampleComputeVariants;

		private ComputeShaderVariants _downsampleComputeVariants;

		private ComputeShaderVariants _upsampleComputeVariants;

		private CommandBuffer _commandBuffer;

		private bool _finalBlit;

		private RenderTarget _selectiveRenderTarget;

		private MipBuffer _bloomDownsampleBuffer;

		private MipBuffer _bloomUpsampleBuffer;

		private MipBuffer _lensFlareDownsampleBuffer;

		private MipBuffer _lensFlareUpsampleBuffer;

		private MipBuffer _glareDownsampleBuffer0;

		private MipBuffer _glareDownsampleBuffer1;

		private MipBuffer _glareDownsampleBuffer2;

		private MipBuffer _glareDownsampleBuffer3;

		private MipBuffer _glareUpsampleBuffer0;

		private MipBuffer _glareUpsampleBuffer1;

		private MipBuffer _glareUpsampleBuffer2;

		private MipBuffer _glareUpsampleBuffer3;

		private RenderTexture TempRT;

		private RenderTarget _sourceFrameBuffer;

		private RenderTarget _destinationFrameBuffer;

		private Keyword[] _shaderKeywords;

		private bool _useGeometryShaders;

		private bool _useComputeShaders;

		private bool _useLensSurface;

		private bool _useLensFlare;

		private bool _useGlare;

		private List<RenderTarget> _renderTargetsBundle;

		private List<MaterialKeywords> _renderKeywordsBundle;

		private int _bloomIterations;

		private int _lensFlareIterations;

		private int _minIterations;

		private int _glareIterations;

		private int _currentRenderIndex;

		private float bloomUpsampleSpread;

		private float _lensFlareUpsampleSpread;

		private float _glareScatteringMult;

		private Vector2 _resolutionScale;

		private Vector2[] glareAngles;

		private RenderTextureFormat _renderTextureFormat;

		private ComputeShaderVariants.KeywordState computeShaderFeatures;

		private RenderContext[] _sourceContext;

		private RenderContext[] _renderContext;

		private RenderContext _selectiveRenderContext;

		private Camera _renderingCamera;

		private CameraData _cameraData;

		private RenderPipeline _renderPipeline;

		private static readonly int tempRTID;

		private static readonly int sourceTexID;

		private static readonly int scaleBiasID;

		private static readonly int scaleBiasRtID;

		private Material _renderMaterialNoGeometry;

		private Material _renderMaterialGeometry;

		public Material BlitMaterial;

		public Shader BlitShader;

		public LocalKeyword ProceduralKW;

		private float[] _cArgArray;

		private ComputeBuffer _cArgsComputeBuffer;

		private RenderDimension _computeThreadGroups;

		private Settings _settings;

		private RenderTarget sourceFrameBuffer => default(RenderTarget);

		internal int currentRenderIndex => 0;

		internal RenderTextureFormat renderTextureFormat => default(RenderTextureFormat);

		internal Material renderMaterialNoGeometry => null;

		private GameObject selectiveGlowCameraObject => null;

		private Camera selectiveGlowCamera => null;

		internal Effect()
		{
		}

		internal void Enable(RenderPipeline renderPipeline, Shader shaderOverwrite = null, Shader shaderGeometryOverwrite = null)
		{
		}

		~Effect()
		{
		}

		internal void Disable()
		{
		}

		private void PrepareScattering(float Scattering, float scale, ref int iterations, ref float spread)
		{
		}

		private void UpdateRenderBuffers()
		{
		}

		private void SetupSelectiveGlowCamera()
		{
		}

		private void CheckFeatureSupport()
		{
		}

		private void BeginProfileSample(string text)
		{
		}

		private void EndProfileSample(string text)
		{
		}

		internal void Build(RenderTarget source, RenderTarget destination, Settings settings, CommandBuffer cmd, CameraData cameraData, Camera renderingCamera = null, bool finalBlit = true)
		{
		}

		private void UpdateConstantBuffers()
		{
		}

		private void SetKeyword(MaterialKeywords keyword, bool enable)
		{
		}

		private Vector2 AngleToDirection(float angleDegree)
		{
			return default(Vector2);
		}

		private float ConvertGammaValue(float gammaSpacedValue)
		{
			return 0f;
		}

		private Vector4 ConvertGammaValue(Vector4 gammaSpacedVector)
		{
			return default(Vector4);
		}

		private void UpdateComputeShaderThreadGroups(RenderDimension renderDimension)
		{
		}

		private void UpdateRenderIndex(int v)
		{
		}

		private void UpdateRenderIndex(ComputeShaderVariants variants, ComputeShaderVariants.KeywordState features)
		{
		}

		private void AttachCArgBufferToComputeKernel()
		{
		}

		private void SetFloat(PipelineProperties.ShaderProperties.CBufferProperty property, float value, bool forcePixelShader = false)
		{
		}

		private void SetVector(PipelineProperties.ShaderProperties.CBufferProperty property, Vector4 value, bool forcePixelShader = false)
		{
		}

		private void SetVector(PipelineProperties.ShaderProperties.CBufferProperty property, Vector3 value, bool forcePixelShader = false)
		{
		}

		private void SetVector(PipelineProperties.ShaderProperties.CBufferProperty property, Vector2 value, bool forcePixelShader = false)
		{
		}

		private void SetTexture(PipelineProperties.ShaderProperties.DefaultProperty property, RenderTarget rt, bool forcePixelShader = false)
		{
		}

		private void SetTexture(PipelineProperties.ShaderProperties.DefaultProperty property, Texture tex, bool forcePixelShader = false)
		{
		}

		private void PrepareDraw(int variant, RenderDimension renderDimension, bool forcePixelShader = false)
		{
		}

		private void PrepareDraw(int materialPass, ComputeShaderVariants variants, bool enableBloom, bool enableLensflare, bool enableGlare, RenderDimension renderDimension)
		{
		}

		private void Draw(RenderDimension dimension, bool forcePixelShader = false)
		{
		}

		private MaterialKeywords GetGlareKeyword(int streaks)
		{
			return default(MaterialKeywords);
		}

		private void DisableRenderKeywords()
		{
		}

		private void DisableDebugKeywords()
		{
		}

		private void SetRenderPriority()
		{
		}

		private void SetReadGamma()
		{
		}

		private void PreSample()
		{
		}

		private void Downsample()
		{
		}

		private void Upsample()
		{
		}

		private void Blit(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, int passIndex = 0, RenderBufferLoadAction colorLoadAction = RenderBufferLoadAction.Load, RenderBufferStoreAction colorStoreAction = RenderBufferStoreAction.Store, RenderBufferLoadAction depthLoadAction = RenderBufferLoadAction.DontCare, RenderBufferStoreAction depthStoreAction = RenderBufferStoreAction.DontCare)
		{
		}

		private void Composite()
		{
		}

		internal void AfterCompositeCleanup()
		{
		}
	}
}
