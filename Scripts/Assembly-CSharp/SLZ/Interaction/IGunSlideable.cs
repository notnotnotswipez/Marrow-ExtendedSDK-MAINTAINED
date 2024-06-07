using System;

namespace SLZ.Interaction
{
	public interface IGunSlideable
	{
		Action OnSlideGrabbed { get; set; }

		Action OnSlideReleased { get; set; }

		Action<float> OnSlideUpdate { get; set; }

		Action OnSlidePulled { get; set; }

		Action OnSlideReturned { get; set; }
	}
}
