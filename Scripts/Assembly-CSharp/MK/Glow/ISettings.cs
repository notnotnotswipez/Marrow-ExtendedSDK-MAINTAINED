using UnityEngine;

namespace MK.Glow
{
	internal interface ISettings
	{
		bool GetAllowGeometryShaders();

		bool GetAllowComputeShaders();

		RenderPriority GetRenderPriority();

		DebugView GetDebugView();

		Quality GetQuality();

		AntiFlickerMode GetAntiFlickerMode();

		Workflow GetWorkflow();

		LayerMask GetSelectiveRenderLayerMask();

		float GetAnamorphicRatio();

		float GetLumaScale();

		float GetBlooming();

		MinMaxRange GetBloomThreshold();

		float GetBloomScattering();

		float GetBloomIntensity();

		bool GetAllowLensSurface();

		Texture2D GetLensSurfaceDirtTexture();

		float GetLensSurfaceDirtIntensity();

		Texture2D GetLensSurfaceDiffractionTexture();

		float GetLensSurfaceDiffractionIntensity();

		bool GetAllowLensFlare();

		LensFlareStyle GetLensFlareStyle();

		float GetLensFlareGhostFade();

		float GetLensFlareGhostIntensity();

		MinMaxRange GetLensFlareThreshold();

		float GetLensFlareScattering();

		Texture2D GetLensFlareColorRamp();

		float GetLensFlareChromaticAberration();

		int GetLensFlareGhostCount();

		float GetLensFlareGhostDispersal();

		float GetLensFlareHaloFade();

		float GetLensFlareHaloIntensity();

		float GetLensFlareHaloSize();

		void SetLensFlareGhostFade(float fade);

		void SetLensFlareGhostCount(int count);

		void SetLensFlareGhostDispersal(float dispersal);

		void SetLensFlareHaloFade(float fade);

		void SetLensFlareHaloSize(float size);

		bool GetAllowGlare();

		float GetGlareBlend();

		float GetGlareIntensity();

		float GetGlareAngle();

		MinMaxRange GetGlareThreshold();

		int GetGlareStreaks();

		void SetGlareStreaks(int count);

		float GetGlareScattering();

		GlareStyle GetGlareStyle();

		float GetGlareSample0Scattering();

		float GetGlareSample0Angle();

		float GetGlareSample0Intensity();

		float GetGlareSample0Offset();

		void SetGlareSample0Scattering(float scattering);

		void SetGlareSample0Angle(float angle);

		void SetGlareSample0Intensity(float intensity);

		void SetGlareSample0Offset(float offset);

		float GetGlareSample1Scattering();

		float GetGlareSample1Angle();

		float GetGlareSample1Intensity();

		float GetGlareSample1Offset();

		void SetGlareSample1Scattering(float scattering);

		void SetGlareSample1Angle(float angle);

		void SetGlareSample1Intensity(float intensity);

		void SetGlareSample1Offset(float offset);

		float GetGlareSample2Scattering();

		float GetGlareSample2Angle();

		float GetGlareSample2Intensity();

		float GetGlareSample2Offset();

		void SetGlareSample2Scattering(float scattering);

		void SetGlareSample2Angle(float angle);

		void SetGlareSample2Intensity(float intensity);

		void SetGlareSample2Offset(float offset);

		float GetGlareSample3Scattering();

		float GetGlareSample3Angle();

		float GetGlareSample3Intensity();

		float GetGlareSample3Offset();

		void SetGlareSample3Scattering(float scattering);

		void SetGlareSample3Angle(float angle);

		void SetGlareSample3Intensity(float intensity);

		void SetGlareSample3Offset(float offset);
	}
}
