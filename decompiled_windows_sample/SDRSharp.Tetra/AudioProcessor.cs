using SDRSharp.Radio;
using System;
using System.Runtime.CompilerServices;
using System.Threading;

namespace SDRSharp.Tetra
{
	public class AudioProcessor : IRealProcessor, IStreamProcessor, IBaseProcessor
	{
		// ⁪‏⁫‫‎⁪‫‍‌‌‫‭⁫‬‮‮⁯⁫‫‫‏‬⁮⁮​‭‫⁮⁪‍⁫‬​⁭⁬⁭‏‍⁮‫‮
		private double u206a‏⁫‫‎⁪‫‍‌‌‫‭⁫‬‮‮⁯⁫‫‫‏‬⁮⁮​‭‫⁮⁪‍⁫‬​⁭⁬⁭‏‍⁮‫‮;

		// ‏⁬⁫⁭‎‪​⁮‍‌‭‎‮‎⁫‍​⁫‪⁮‎⁪‮‌‬‫⁭‍⁮‬‌‌‌‬‮‬​‬‫‬‮
		private bool u200f⁬⁫⁭‎‪​⁮‍‌‭‎‮‎⁫‍​⁫‪⁮‎⁪‮‌‬‫⁭‍⁮‬‌‌‌‬‮‬​‬‫‬‮;

		public bool Enabled
		{
			get
			{
				return this.u200f⁬⁫⁭‎‪​⁮‍‌‭‎‮‎⁫‍​⁫‪⁮‎⁪‮‌‬‫⁭‍⁮‬‌‌‌‬‮‬​‬‫‬‮;
			}
			set
			{
				this.u200f⁬⁫⁭‎‪​⁮‍‌‭‎‮‎⁫‍​⁫‪⁮‎⁪‮‌‬‫⁭‍⁮‬‌‌‌‬‮‬​‬‫‬‮ = value;
			}
		}

		public double SampleRate
		{
			get
			{
				return JustDecompileGenerated_get_SampleRate();
			}
			set
			{
				JustDecompileGenerated_set_SampleRate(value);
			}
		}

		public double JustDecompileGenerated_get_SampleRate()
		{
			return this.u206a‏⁫‫‎⁪‫‍‌‌‫‭⁫‬‮‮⁯⁫‫‫‏‬⁮⁮​‭‫⁮⁪‍⁫‬​⁭⁬⁭‏‍⁮‫‮;
		}

		public void JustDecompileGenerated_set_SampleRate(double value)
		{
			this.u206a‏⁫‫‎⁪‫‍‌‌‫‭⁫‬‮‮⁯⁫‫‫‏‬⁮⁮​‭‫⁮⁪‍⁫‬​⁭⁬⁭‏‍⁮‫‮ = value;
		}

		// ‭‬⁫⁪⁯‭‎‍⁫‫‪⁪⁯⁯⁫​⁮⁪⁬⁭⁮⁫‮⁯‌​‪⁯⁮⁯‫⁭⁯⁮‪‮‬‎‬‬‮
		// privatescope
		internal static Delegate u202d‬⁫⁪⁯‭‎‍⁫‫‪⁪⁯⁯⁫​⁮⁪⁬⁭⁮⁫‮⁯‌​‪⁯⁮⁯‫⁭⁯⁮‪‮‬‎‬‬‮(Delegate @delegate, Delegate @delegate)
		{
			return Delegate.Combine(@delegate, @delegate);
		}

		// ‭‬‫⁭⁪⁮⁫⁯‏⁭⁬‬‏‌‌​‬​⁯‌⁭‮‌⁪‏‪⁮‏⁯‮‌‍⁮‍‏⁭⁬‍‬⁯‮
		// privatescope
		internal static Delegate u202d‬‫⁭⁪⁮⁫⁯‏⁭⁬‬‏‌‌​‬​⁯‌⁭‮‌⁪‏‪⁮‏⁯‮‌‍⁮‍‏⁭⁬‍‬⁯‮(Delegate @delegate, Delegate @delegate)
		{
			return Delegate.Remove(@delegate, @delegate);
		}

		public AudioProcessor()
		{
		}

		public unsafe void Process(float* buffer, int length)
		{
			if (this.u206c⁪‭‬⁮‬‫⁮⁮‌​⁯⁭⁮‮⁮‫‎‎‭⁮‏⁪‎‍⁯‪⁮‫‎​‪​⁪‏⁯‎‎‭‎‮ == null)
			{
				return;
			}
		Label1:
			int num = 1323954818;
			while (true)
			{
				int num1 = num ^ 82085660;
				uint num2 = (uint)num1;
				switch (num1 % 3)
				{
					case 0:
					{
						goto Label1;
					}
					case 1:
					{
						return;
					}
					case 2:
					{
						this.u206c⁪‭‬⁮‬‫⁮⁮‌​⁯⁭⁮‮⁮‫‎‎‭⁮‏⁪‎‍⁯‪⁮‫‎​‪​⁪‏⁯‎‎‭‎‮(buffer, this.u206a‏⁫‫‎⁪‫‍‌‌‫‭⁫‬‮‮⁯⁫‫‫‏‬⁮⁮​‭‫⁮⁪‍⁫‬​⁭⁬⁭‏‍⁮‫‮, length);
						num = (int)(num2 * -1156382747 ^ 281458935);
						continue;
					}
				}
			}
		}

		public event AudioProcessor.AudioReadyDelegate AudioReady
		{
			add
			{
				AudioProcessor.AudioReadyDelegate audioReadyDelegate = this.u206c⁪‭‬⁮‬‫⁮⁮‌​⁯⁭⁮‮⁮‫‎‎‭⁮‏⁪‎‍⁯‪⁮‫‎​‪​⁪‏⁯‎‎‭‎‮;
			Label0:
				int num = 225952332;
				while (true)
				{
					int num1 = num ^ 794399797;
					uint num2 = (uint)num1;
					switch (num1 % 3)
					{
						case 0:
						{
							goto Label0;
						}
						case 1:
						{
							return;
						}
						case 2:
						{
							AudioProcessor.AudioReadyDelegate audioReadyDelegate1 = audioReadyDelegate;
							AudioProcessor.AudioReadyDelegate audioReadyDelegate2 = (AudioProcessor.AudioReadyDelegate)AudioProcessor.u202d‬⁫⁪⁯‭‎‍⁫‫‪⁪⁯⁯⁫​⁮⁪⁬⁭⁮⁫‮⁯‌​‪⁯⁮⁯‫⁭⁯⁮‪‮‬‎‬‬‮(audioReadyDelegate1, value);
							audioReadyDelegate = Interlocked.CompareExchange<AudioProcessor.AudioReadyDelegate>(ref this.u206c⁪‭‬⁮‬‫⁮⁮‌​⁯⁭⁮‮⁮‫‎‎‭⁮‏⁪‎‍⁯‪⁮‫‎​‪​⁪‏⁯‎‎‭‎‮, audioReadyDelegate2, audioReadyDelegate1);
							num = ((object)audioReadyDelegate != (object)audioReadyDelegate1 ? 225952332 : 486433010);
							continue;
						}
					}
				}
			}
			remove
			{
				AudioProcessor.AudioReadyDelegate audioReadyDelegate = null;
				AudioProcessor.AudioReadyDelegate audioReadyDelegate1 = null;
				int num;
				AudioProcessor.AudioReadyDelegate audioReadyDelegate2 = this.u206c⁪‭‬⁮‬‫⁮⁮‌​⁯⁭⁮‮⁮‫‎‎‭⁮‏⁪‎‍⁯‪⁮‫‎​‪​⁪‏⁯‎‎‭‎‮;
			Label0:
				int num1 = 134698163;
				while (true)
				{
					int num2 = num1 ^ 1060118243;
					uint num3 = (uint)num2;
					switch (num2 % 5)
					{
						case 0:
						{
							goto Label0;
						}
						case 1:
						{
							audioReadyDelegate2 = Interlocked.CompareExchange<AudioProcessor.AudioReadyDelegate>(ref this.u206c⁪‭‬⁮‬‫⁮⁮‌​⁯⁭⁮‮⁮‫‎‎‭⁮‏⁪‎‍⁯‪⁮‫‎​‪​⁪‏⁯‎‎‭‎‮, audioReadyDelegate1, audioReadyDelegate);
							num = ((object)audioReadyDelegate2 != (object)audioReadyDelegate ? -1034791356 : -812844655);
							num1 = (int)(num ^ num3 * -727914311);
							continue;
						}
						case 2:
						{
							audioReadyDelegate1 = (AudioProcessor.AudioReadyDelegate)AudioProcessor.u202d‬‫⁭⁪⁮⁫⁯‏⁭⁬‬‏‌‌​‬​⁯‌⁭‮‌⁪‏‪⁮‏⁯‮‌‍⁮‍‏⁭⁬‍‬⁯‮(audioReadyDelegate, value);
							num1 = (int)(num3 * -767975650 ^ -1672080244);
							continue;
						}
						case 3:
						{
							return;
						}
						case 4:
						{
							audioReadyDelegate = audioReadyDelegate2;
							num1 = 1975277187;
							continue;
						}
					}
				}
			}
		}

		public delegate void AudioReadyDelegate(float* buffer, double samplerate, int length);
	}
}