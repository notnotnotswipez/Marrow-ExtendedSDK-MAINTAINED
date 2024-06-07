namespace MK.Glow
{
	internal interface IDimension
	{
		int width { get; }

		int height { get; }

		RenderDimension renderDimension { get; }
	}
}
