namespace MK.Glow
{
	internal static class PipelineProperties
	{
		internal static class ShaderProperties
		{
			internal class DefaultProperty
			{
				protected string _name;

				protected int _id;

				internal string name => null;

				internal int id => 0;

				internal DefaultProperty(string name)
				{
				}
			}

			internal sealed class CBufferProperty : DefaultProperty
			{
				private int _index;

				private int _size;

				internal int index => 0;

				internal int size => 0;

				internal CBufferProperty(string name, int index, int size)
					: base(null)
				{
				}
			}

			internal static readonly CBufferProperty screenSize;

			internal static readonly CBufferProperty singlePassStereoScale;

			internal static readonly CBufferProperty viewMatrix;

			internal static readonly DefaultProperty cArgBuffer;

			internal static readonly DefaultProperty sourceTex;

			internal static readonly DefaultProperty targetTex;

			internal static readonly DefaultProperty copyTargetTex;

			internal static readonly DefaultProperty bloomTex;

			internal static readonly DefaultProperty bloomTargetTex;

			internal static readonly CBufferProperty bloomSpread;

			internal static readonly CBufferProperty bloomThreshold;

			internal static readonly CBufferProperty lumaScale;

			internal static readonly CBufferProperty bloomIntensity;

			internal static readonly CBufferProperty blooming;

			internal static readonly DefaultProperty higherMipBloomTex;

			internal static readonly CBufferProperty resolutionScale;

			internal static readonly CBufferProperty renderTargetSize;

			internal static readonly DefaultProperty lensSurfaceDirtTex;

			internal static readonly DefaultProperty lensSurfaceDiffractionTex;

			internal static readonly CBufferProperty lensSurfaceDirtIntensity;

			internal static readonly CBufferProperty lensSurfaceDiffractionIntensity;

			internal static readonly CBufferProperty lensSurfaceDirtTexST;

			internal static readonly CBufferProperty lensFlareThreshold;

			internal static readonly CBufferProperty lensFlareGhostParams;

			internal static readonly CBufferProperty lensFlareHaloParams;

			internal static readonly DefaultProperty lensFlareTex;

			internal static readonly DefaultProperty lensFlareTargetTex;

			internal static readonly CBufferProperty lensFlareSpread;

			internal static readonly CBufferProperty lensFlareChromaticAberration;

			internal static readonly DefaultProperty lensFlareColorRamp;

			internal static readonly CBufferProperty glareThreshold;

			internal static readonly CBufferProperty glareBlend;

			internal static readonly CBufferProperty glareGlobalIntensity;

			internal static readonly CBufferProperty glareIntensity;

			internal static readonly CBufferProperty glareScattering;

			internal static readonly CBufferProperty glareDirection01;

			internal static readonly CBufferProperty glareDirection23;

			internal static readonly CBufferProperty glareOffset;

			internal static readonly DefaultProperty glare0Tex;

			internal static readonly DefaultProperty glare0TargetTex;

			internal static readonly DefaultProperty glare1Tex;

			internal static readonly DefaultProperty glare1TargetTex;

			internal static readonly DefaultProperty glare2Tex;

			internal static readonly DefaultProperty glare2TargetTex;

			internal static readonly DefaultProperty glare3Tex;

			internal static readonly DefaultProperty glare3TargetTex;
		}

		internal static class CommandBufferProperties
		{
			internal static readonly string commandBufferName;

			internal static readonly string selectiveRenderBuffer;

			internal static readonly string bloomDownsampleBuffer;

			internal static readonly string bloomUpsampleBuffer;

			internal static readonly string sourceBuffer;

			internal static readonly string glareDownsampleBuffer0;

			internal static readonly string glareDownsampleBuffer1;

			internal static readonly string glareDownsampleBuffer2;

			internal static readonly string glareDownsampleBuffer3;

			internal static readonly string glareUpsampleBuffer0;

			internal static readonly string glareUpsampleBuffer1;

			internal static readonly string glareUpsampleBuffer2;

			internal static readonly string glareUpsampleBuffer3;

			internal static readonly string lensFlareDownsampleBuffer;

			internal static readonly string lensFlareUpsampleBuffer;

			internal static readonly string sampleDownsample;

			internal static readonly string samplePreSample;

			internal static readonly string sampleUpsample;

			internal static readonly string sampleComposite;

			internal static readonly string sampleCreateBuffers;

			internal static readonly string sampleClearBuffers;

			internal static readonly string sampleSetup;

			internal static readonly string sampleCopySource;

			internal static readonly string sampleReplacement;

			internal static readonly string samplePrepare;
		}

		internal static readonly int renderBufferSize;

		internal static bool scriptableRenderPipelineActive => false;

		internal static bool xrEnabled => false;

		internal static bool singlePassStereoDoubleWideEnabled => false;

		internal static bool singlePassStereoInstancedEnabled => false;
	}
}
