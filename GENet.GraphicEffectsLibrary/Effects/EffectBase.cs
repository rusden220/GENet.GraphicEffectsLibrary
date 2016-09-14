using System;
using System.Drawing;
using System.Collections.Generic;
using System.Threading;

namespace GENet.GraphicEffectsLibrary.Effects
{
	//just try
	
	/// <summary>
	/// Contain all data to apply an effects
	/// </summary>
	public class EffectData
	{
		/// <summary>
		/// Contain bitmap for processing
		/// </summary>
		public Bitmap OriginalBitmap { get; set; }
		/// <summary>
		/// Contain result bitmap after apply an effects
		/// </summary>
		public Bitmap ResultBitmap { get; set; }	
		//or better in Point
		private List<int> _listOfIndexToApply;//contains a list of indexes to apply the effect. if == null - not used
	}

	/// <summary>
	/// Base class for apply image effect
	/// </summary>
	public abstract class EffectBase
	{
		protected EffectData _effectData;// set by the caller

		public virtual void ApplyEffect()
		{

		}
		/// <summary>
		/// apply effect as parallel
		/// takes all cpu core's
		/// </summary>
		public virtual void ApplyEffectAsParallel()
		{
			ApplyEffectAsParallel(Environment.ProcessorCount);
		}
		/// <summary>
		/// apply effect as parallel
		/// uses the specified number of cores
		/// </summary>
		/// <param name="processorCount">number of cores</param>
		public virtual void ApplyEffectAsParallel(int processorCount)
		{
			
		}
		/// <summary>
		/// apply filter for one in pointer
		/// </summary>
		/// <param name="index"></param>
		protected abstract void Effect(int index);
		/// <summary>
		/// apply filter for block in pointer
		/// </summary>
		/// <param name="index"></param>
		/// <param name="length"></param>
		protected void ApplyEffectsBlock(int index, int length)
		{
			for (int i = index; i < length; i += 4)
			{
				Effect(i);
			}
		}
	}
}
