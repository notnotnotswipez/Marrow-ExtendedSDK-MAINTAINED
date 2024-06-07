using SLZ.Marrow.Audio;

namespace SLZ.Bonelab.VoidLogic
{
	internal class AudioPlayerAndClipPair
	{
		public AudioPlayer AudioPlayer;

		public ClipPair ClipPair;

		public void Deconstruct(out AudioPlayer audioPlayer, out ClipPair clipPair)
		{
			audioPlayer = null;
			clipPair = default(ClipPair);
		}
	}
}
