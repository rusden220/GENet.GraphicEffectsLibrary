using System;

namespace GENet.GraphicEffectsLibrary.Effects
{
	public class NoizeEffect:EffectBase
	{
		private Random _random;
		public NoizeEffect()
		{
			_random = new Random();
		}
		protected override void Effect(int index)
		{
			unsafe
			{
				
			}
		}
		public int NoizeLevelDown { get; set; }
		public int NoizeLevelUp { get; set; }
	}
}
