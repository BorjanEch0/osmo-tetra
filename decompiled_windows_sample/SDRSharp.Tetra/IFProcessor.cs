using SDRSharp.Radio;
using System;
using System.Runtime.CompilerServices;
using System.Threading;

namespace SDRSharp.Tetra
{
	public class IFProcessor : IStreamProcessor, IBaseProcessor, IIQProcessor
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

		// ‭⁮⁭⁭⁬‪⁪​‬⁯‏⁪⁪⁪⁭⁬⁮⁬‭⁪‮‎‌⁫‏⁬‏‍⁫‬‎‍‫⁭⁮⁯⁫⁬​‍‮
		// privatescope
		internal static Delegate u202d⁮⁭⁭⁬‪⁪​‬⁯‏⁪⁪⁪⁭⁬⁮⁬‭⁪‮‎‌⁫‏⁬‏‍⁫‬‎‍‫⁭⁮⁯⁫⁬​‍‮(Delegate @delegate, Delegate @delegate)
		{
			return Delegate.Combine(@delegate, @delegate);
		}

		// ‫‭‮‬⁯‎⁯‬⁬‬‬‎‮‬‌‫‭⁯‌‎⁮⁬‬‌‬‏​‭‭‮​‫‏‮‮‮⁪‬⁫‏‮
		// privatescope
		internal static Delegate u202b‭‮‬⁯‎⁯‬⁬‬‬‎‮‬‌‫‭⁯‌‎⁮⁬‬‌‬‏​‭‭‮​‫‏‮‮‮⁪‬⁫‏‮(Delegate @delegate, Delegate @delegate)
		{
			return Delegate.Remove(@delegate, @delegate);
		}

		public IFProcessor()
		{
		}

		public unsafe void Process(Complex* buffer, int length)
		{
			if (this.u206a⁮‫​⁮‪‌‫⁯⁬‬⁬‫‏⁭⁮⁪‬⁮‭⁫‏‭⁬‮‮‮‎‎​⁬‍‬⁬‍⁫‮‏​‫‮ == null)
			{
				return;
			}
		Label1:
			int num = -1767629000;
			while (true)
			{
				int num1 = num ^ -2129557337;
				uint num2 = (uint)num1;
				switch (num1 % 3)
				{
					case 0:
					{
						goto Label1;
					}
					case 1:
					{
						this.u206a⁮‫​⁮‪‌‫⁯⁬‬⁬‫‏⁭⁮⁪‬⁮‭⁫‏‭⁬‮‮‮‎‎​⁬‍‬⁬‍⁫‮‏​‫‮(buffer, this.u206a‏⁫‫‎⁪‫‍‌‌‫‭⁫‬‮‮⁯⁫‫‫‏‬⁮⁮​‭‫⁮⁪‍⁫‬​⁭⁬⁭‏‍⁮‫‮, length);
						num = (int)(num2 * 1812919738 ^ -1868002477);
						continue;
					}
					case 2:
					{
						return;
					}
				}
			}
		}

		public event IFProcessor.IQReadyDelegate IQReady
		{
			add
			{
				IFProcessor.IQReadyDelegate qReadyDelegate = null;
				IFProcessor.IQReadyDelegate qReadyDelegate1 = null;
				int num;
				IFProcessor.IQReadyDelegate qReadyDelegate2 = this.u206a⁮‫​⁮‪‌‫⁯⁬‬⁬‫‏⁭⁮⁪‬⁮‭⁫‏‭⁬‮‮‮‎‎​⁬‍‬⁬‍⁫‮‏​‫‮;
			Label1:
				int num1 = -938850846;
				while (true)
				{
					int num2 = num1 ^ -1454219505;
					uint num3 = (uint)num2;
					switch (num2 % 5)
					{
						case 0:
						{
							qReadyDelegate1 = (IFProcessor.IQReadyDelegate)IFProcessor.u202d⁮⁭⁭⁬‪⁪​‬⁯‏⁪⁪⁪⁭⁬⁮⁬‭⁪‮‎‌⁫‏⁬‏‍⁫‬‎‍‫⁭⁮⁯⁫⁬​‍‮(qReadyDelegate, value);
							num1 = (int)(num3 * -756878611 ^ -1444930663);
							continue;
						}
						case 1:
						{
							return;
						}
						case 2:
						{
							goto Label1;
						}
						case 3:
						{
							qReadyDelegate = qReadyDelegate2;
							num1 = -296036912;
							continue;
						}
						case 4:
						{
							qReadyDelegate2 = Interlocked.CompareExchange<IFProcessor.IQReadyDelegate>(ref this.u206a⁮‫​⁮‪‌‫⁯⁬‬⁬‫‏⁭⁮⁪‬⁮‭⁫‏‭⁬‮‮‮‎‎​⁬‍‬⁬‍⁫‮‏​‫‮, qReadyDelegate1, qReadyDelegate);
							num = ((object)qReadyDelegate2 != (object)qReadyDelegate ? 972378451 : 819853873);
							num1 = (int)(num ^ num3 * -1073047075);
							continue;
						}
					}
				}
			}
			remove
			{
				IFProcessor.IQReadyDelegate qReadyDelegate = null;
				IFProcessor.IQReadyDelegate qReadyDelegate1 = null;
				int num;
				IFProcessor.IQReadyDelegate qReadyDelegate2 = this.u206a⁮‫​⁮‪‌‫⁯⁬‬⁬‫‏⁭⁮⁪‬⁮‭⁫‏‭⁬‮‮‮‎‎​⁬‍‬⁬‍⁫‮‏​‫‮;
			Label1:
				int num1 = -530485687;
				while (true)
				{
					int num2 = num1 ^ -392492125;
					uint num3 = (uint)num2;
					switch (num2 % 6)
					{
						case 0:
						{
							return;
						}
						case 1:
						{
							num = ((object)qReadyDelegate2 != (object)qReadyDelegate ? 2049852113 : 673459393);
							num1 = (int)(num ^ num3 * 1001143640);
							continue;
						}
						case 2:
						{
							qReadyDelegate = qReadyDelegate2;
							num1 = -1295542521;
							continue;
						}
						case 3:
						{
							qReadyDelegate2 = Interlocked.CompareExchange<IFProcessor.IQReadyDelegate>(ref this.u206a⁮‫​⁮‪‌‫⁯⁬‬⁬‫‏⁭⁮⁪‬⁮‭⁫‏‭⁬‮‮‮‎‎​⁬‍‬⁬‍⁫‮‏​‫‮, qReadyDelegate1, qReadyDelegate);
							num1 = (int)(num3 * 514275443 ^ -623163389);
							continue;
						}
						case 4:
						{
							qReadyDelegate1 = (IFProcessor.IQReadyDelegate)IFProcessor.u202b‭‮‬⁯‎⁯‬⁬‬‬‎‮‬‌‫‭⁯‌‎⁮⁬‬‌‬‏​‭‭‮​‫‏‮‮‮⁪‬⁫‏‮(qReadyDelegate, value);
							num1 = (int)(num3 * -722172700 ^ -2022580752);
							continue;
						}
						case 5:
						{
							goto Label1;
						}
					}
				}
			}
		}

		public delegate void IQReadyDelegate(Complex* buffer, double samplerate, int length);
	}
}