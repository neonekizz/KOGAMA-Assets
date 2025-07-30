using System.Collections.Generic;

namespace UGUI.Desktop.Scripts.EditMode.SettingsBoxes.Camera
{
	public struct PostProcessingSettings
	{
		public PostProcessingColorSettings colorSettings;

		public PostProcessingBloomSettings bloomSettings;

		public PostProcessingAmbientOcclusionSettings ambientOcclusionSettings;

		public PostProcessingDepthOfFieldSettings depthOfFieldSettings;

		public PostProcessingVignetteSettings vignetteSettings;

		public PostProcessingGrainSettings grainSettings;

		public PostProcessingLensDistortionSettings lensDistortionSettings;

		public PostProcessingSettings(Dictionary<object, object> data)
		{
			colorSettings = default(PostProcessingColorSettings);
			bloomSettings = default(PostProcessingBloomSettings);
			ambientOcclusionSettings = default(PostProcessingAmbientOcclusionSettings);
			depthOfFieldSettings = default(PostProcessingDepthOfFieldSettings);
			vignetteSettings = default(PostProcessingVignetteSettings);
			grainSettings = default(PostProcessingGrainSettings);
			lensDistortionSettings = default(PostProcessingLensDistortionSettings);
		}
	}
}
