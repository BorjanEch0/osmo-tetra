using System;
using System.IO;
using System.IO.Pipes;
using System.Threading;

namespace Wireshark
{
	public class WiresharkSender
	{
		// ⁮⁫⁮‮⁭‎‬⁬‎⁬⁭‎‏‭‍‍‌‪⁬‪‎‪⁪‍‍‏​‍⁮⁭⁭⁬‬⁯⁪⁮‮⁮‎⁫‮
		private NamedPipeServerStream u206e⁫⁮‮⁭‎‬⁬‎⁬⁭‎‏‭‍‍‌‪⁬‪‎‪⁪‍‍‏​‍⁮⁭⁭⁬‬⁯⁪⁮‮⁮‎⁫‮;

		// ‮‮‭‮​⁯⁫‭‬‍⁭‪⁫‍‮‏‬‌⁫⁮‌‮‎⁮⁫⁪‎‮‮⁭‭‌⁬‬​‍‭‍⁮‭‮
		private bool u202e‮‭‮​⁯⁫‭‬‍⁭‪⁫‍‮‏‬‌⁫⁮‌‮‎⁮⁫⁪‎‮‮⁭‭‌⁬‬​‍‭‍⁮‭‮;

		// ​‮‏‮⁭‭​⁯⁪⁯‬‫‫‬‏⁯​‭‌‌‏⁫⁮⁫⁮⁬‬‫‍​‬‌​‏‍‌‬⁮⁭⁯‮
		private string u200b‮‏‮⁭‭​⁯⁪⁯‬‫‫‬‏⁯​‭‌‌‏⁫⁮⁫⁮⁬‬‫‍​‬‌​‏‍‌‬⁮⁭⁯‮;

		// ‌⁯‍‫‫⁮‪‬‪⁬⁪‪​⁭‍⁮​‮‮‬⁭‮‍⁭‌⁬‎‭​⁬⁪⁬⁫‎‪‫⁭‭⁯⁭‮
		private uint u200c⁯‍‫‫⁮‪‬‪⁬⁪‪​⁭‍⁮​‮‮‬⁭‮‍⁭‌⁬‎‭​⁬⁪⁬⁫‎‪‫⁭‭⁯⁭‮;

		// ‎‍⁭‍⁯‬⁮‪‫‍‎‪​⁪⁪⁯‎⁭‫‎⁫‮‮‪‮⁮⁮⁮⁭‪⁭‎‫‌‭​⁮‎⁯‎‮
		private object u200e‍⁭‍⁯‬⁮‪‫‍‎‪​⁪⁪⁯‎⁭‫‎⁫‮‮‪‮⁮⁮⁮⁭‪⁭‎‫‌‭​⁮‎⁯‎‮ = WiresharkSender.u206b‎‌⁪‪‫‏‫​⁪⁫⁯‎‌‭​⁮‬⁪⁭⁭‮‮‍⁫​⁪‭⁮⁮‬​⁫​⁮⁯‫⁪‫⁬‮();

		public bool isConnected
		{
			get
			{
				return this.u202e‮‭‮​⁯⁫‭‬‍⁭‪⁫‍‮‏‬‌⁫⁮‌‮‎⁮⁫⁪‎‮‮⁭‭‌⁬‬​‍‭‍⁮‭‮;
			}
		}

		// ⁭⁮‬‭‪‪‎‎‬⁭⁫⁯‍⁮⁪‍⁮‏‭‏⁪​⁯⁪‭‌⁭‍‬⁫‏⁫‫‍‭‫‍‎⁫‏‮
		private void u206d⁮‬‭‪‪‎‎‬⁭⁫⁯‍⁮⁪‍⁮‏‭‏⁪​⁯⁪‭‌⁭‍‬⁫‏⁫‫‍‭‫‍‎⁫‏‮()
		{
			byte[] numArray = null;
			try
			{
				this.u206e⁫⁮‮⁭‎‬⁬‎⁬⁭‎‏‭‍‍‌‪⁬‪‎‪⁪‍‍‏​‍⁮⁭⁭⁬‬⁯⁪⁮‮⁮‎⁫‮ = WiresharkSender.u200b‮‭⁮⁪‫‍‍⁯⁬‏‫⁪‌⁪‪‭⁪⁯‎‎‫⁯‭‭‮​​⁯‭⁪‭⁮‮‫‬⁫‮‫‭‮(this.u200b‮‏‮⁭‭​⁯⁪⁯‬‫‫‬‏⁯​‭‌‌‏⁫⁮⁫⁮⁬‬‫‍​‬‌​‏‍‌‬⁮⁭⁯‮, PipeDirection.Out, 1, PipeTransmissionMode.Byte, PipeOptions.Asynchronous);
			Label0:
				int num = -648385790;
				while (true)
				{
					int num1 = num ^ -1862174084;
					uint num2 = (uint)num1;
					switch (num1 % 5)
					{
						case 0:
						{
							goto Label0;
						}
						case 1:
						{
							WiresharkSender.u206d⁯‪‫⁮‏‌‌‮‌⁭​‪⁮⁬⁪⁭⁮‭‭⁯⁮‍‮‍⁪‫‎⁪‎‫⁪​‎⁯‌⁪‏‎‏‮(this.u206e⁫⁮‮⁭‎‬⁬‎⁬⁭‎‏‭‍‍‌‪⁬‪‎‪⁪‍‍‏​‍⁮⁭⁭⁬‬⁯⁪⁮‮⁮‎⁫‮);
							num = (int)(num2 * 514522107 ^ 255729989);
							continue;
						}
						case 2:
						{
							numArray = (new u202d‭‎‎‫‍⁪‎‪‎‎‫⁭‬‬‮‭‬‮⁫‮​‭‎⁪‍‌‮⁮‪‌‏‮⁭⁯⁮‮‍‍⁮‮(65535, this.u200c⁯‍‫‫⁮‪‬‪⁬⁪‪​⁭‍⁮​‮‮‬⁭‮‍⁭‌⁬‎‭​⁬⁪⁬⁫‎‪‫⁭‭⁯⁭‮)).u202d‬⁯‌⁯‍‏‪⁮‏‍⁬‍‏⁭‍⁫‭‍‫‍‫⁮⁬‍​⁪‬‫‪‍‪⁯⁮⁮‮⁯‌‭‪‮();
							num = (int)(num2 * 652075825 ^ -1514925401);
							continue;
						}
						case 3:
						{
							WiresharkSender.u202e‎‪‫⁭⁭⁪‭‬⁭‮‬⁯‬‌‎⁭​⁯⁬‬‪‫‮‎‍‮‮‪⁫‎‌⁪‪‏‏⁪‫‏⁬‮(this.u206e⁫⁮‮⁭‎‬⁬‎⁬⁭‎‏‭‍‍‌‪⁬‪‎‪⁪‍‍‏​‍⁮⁭⁭⁬‬⁯⁪⁮‮⁮‎⁫‮, numArray, 0, (int)numArray.Length);
							this.u202e‮‭‮​⁯⁫‭‬‍⁭‪⁫‍‮‏‬‌⁫⁮‌‮‎⁮⁫⁪‎‮‮⁭‭‌⁬‬​‍‭‍⁮‭‮ = true;
							num = (int)(num2 * 1647809761 ^ -1322097748);
							continue;
						}
						case 4:
						{
							goto Label1;
						}
					}
				}
			Label1:
			}
			catch (Exception exception)
			{
			}
		}

		// ‍⁮‭‍‍‮⁮‌‏‎⁮‎‬⁬‎‎‫‎‍⁭‫‌​‭‫‪⁮‌⁫‮‍⁪‏⁬⁫‭‬⁬⁯‏‮
		private uint u200d⁮‭‍‍‮⁮‌‏‎⁮‎‬⁬‎‎‫‎‍⁭‫‌​‭‫‪⁮‌⁫‮‍⁪‏⁬⁫‭‬⁬⁯‏‮(DateTime dateTime)
		{
			DateTime dateTime1 = new DateTime(1970, 1, 1);
			return (uint)(dateTime - dateTime1.ToLocalTime()).TotalSeconds;
		}

		// ⁫‎‌⁪‪‫‏‫​⁪⁫⁯‎‌‭​⁮‬⁪⁭⁭‮‮‍⁫​⁪‭⁮⁮‬​⁫​⁮⁯‫⁪‫⁬‮
		// privatescope
		internal static object u206b‎‌⁪‪‫‏‫​⁪⁫⁯‎‌‭​⁮‬⁪⁭⁭‮‮‍⁫​⁪‭⁮⁮‬​⁫​⁮⁯‫⁪‫⁬‮()
		{
			return new object();
		}

		// ⁫‌‫‮‬‌‌⁭⁪‭‏‏​‏​⁮⁪⁯⁭⁭‭‪⁮⁬⁪⁬‍⁭‮⁭‎‍⁮⁯⁯​⁮‏‭⁯‮
		// privatescope
		internal static Thread u206b‌‫‮‬‌‌⁭⁪‭‏‏​‏​⁮⁪⁯⁭⁭‭‪⁮⁬⁪⁬‍⁭‮⁭‎‍⁮⁯⁯​⁮‏‭⁯‮(ThreadStart threadStart)
		{
			return new Thread(threadStart);
		}

		// ⁪⁫⁫‪‮‎‍‫‮​‎‏‍⁫‫⁫⁫⁫‌⁬‬⁯‎‍‍‎⁪‌‬​‍‍⁭‎‭‎‍⁮‫‭‮
		// privatescope
		internal static void u206a⁫⁫‪‮‎‍‫‮​‎‏‍⁫‫⁫⁫⁫‌⁬‬⁯‎‍‍‎⁪‌‬​‍‍⁭‎‭‎‍⁮‫‭‮(Thread thread, bool flag)
		{
			thread.IsBackground = flag;
		}

		// ​‎‏‭⁬‌‍⁬​⁪‫‪⁯⁮⁭​‌‪‮⁪⁯⁯‬⁬​‪‎‫‫‭‍‏​‫‬⁭⁮‭‌⁪‮
		// privatescope
		internal static void u200b‎‏‭⁬‌‍⁬​⁪‫‪⁯⁮⁭​‌‪‮⁪⁯⁯‬⁬​‪‎‫‫‭‍‏​‫‬⁭⁮‭‌⁪‮(Thread thread)
		{
			thread.Start();
		}

		// ​‮‭⁮⁪‫‍‍⁯⁬‏‫⁪‌⁪‪‭⁪⁯‎‎‫⁯‭‭‮​​⁯‭⁪‭⁮‮‫‬⁫‮‫‭‮
		// privatescope
		internal static NamedPipeServerStream u200b‮‭⁮⁪‫‍‍⁯⁬‏‫⁪‌⁪‪‭⁪⁯‎‎‫⁯‭‭‮​​⁯‭⁪‭⁮‮‫‬⁫‮‫‭‮(string str, PipeDirection pipeDirection, int num, PipeTransmissionMode pipeTransmissionMode, PipeOptions pipeOption)
		{
			return new NamedPipeServerStream(str, pipeDirection, num, pipeTransmissionMode, pipeOption);
		}

		// ⁭⁯‪‫⁮‏‌‌‮‌⁭​‪⁮⁬⁪⁭⁮‭‭⁯⁮‍‮‍⁪‫‎⁪‎‫⁪​‎⁯‌⁪‏‎‏‮
		// privatescope
		internal static void u206d⁯‪‫⁮‏‌‌‮‌⁭​‪⁮⁬⁪⁭⁮‭‭⁯⁮‍‮‍⁪‫‎⁪‎‫⁪​‎⁯‌⁪‏‎‏‮(NamedPipeServerStream namedPipeServerStream)
		{
			namedPipeServerStream.WaitForConnection();
		}

		// ‮‎‪‫⁭⁭⁪‭‬⁭‮‬⁯‬‌‎⁭​⁯⁬‬‪‫‮‎‍‮‮‪⁫‎‌⁪‪‏‏⁪‫‏⁬‮
		// privatescope
		internal static void u202e‎‪‫⁭⁭⁪‭‬⁭‮‬⁯‬‌‎⁭​⁯⁬‬‪‫‮‎‍‮‮‪⁫‎‌⁪‪‏‏⁪‫‏⁬‮(Stream stream, byte[] numArray, int num, int num)
		{
			stream.Write(numArray, num, num);
		}

		// ⁪‫⁯‏⁬‏​⁫​⁭‫‮⁬‍‌‌⁯​‎⁮⁮‌‍⁯‭‌‫‫​⁪⁭‫⁮⁮⁭​⁪‫‪⁭‮
		// privatescope
		internal static void u206a‫⁯‏⁬‏​⁫​⁭‫‮⁬‍‌‌⁯​‎⁮⁮‌‍⁯‭‌‫‫​⁪⁭‫⁮⁮⁭​⁪‫‪⁭‮(Stream stream)
		{
			stream.Close();
		}

		// ‎‫‏‮⁬‫‪⁭‎‌‌⁮⁮‮⁯‬⁭‌​‬‮⁯‪​‏‫⁫‪⁬‍‮‎‍⁭‭‌‏‍⁫⁮‮
		// privatescope
		internal static void u200e‫‏‮⁬‫‪⁭‎‌‌⁮⁮‮⁯‬⁭‌​‬‮⁯‪​‏‫⁫‪⁬‍‮‎‍⁭‭‌‏‍⁫⁮‮(Stream stream)
		{
			stream.Dispose();
		}

		public WiresharkSender(string str, uint num)
		{
			this.u200b‮‏‮⁭‭​⁯⁪⁯‬‫‫‬‏⁯​‭‌‌‏⁫⁮⁫⁮⁬‬‫‍​‬‌​‏‍‌‬⁮⁭⁯‮ = str;
			this.u200c⁯‍‫‫⁮‪‬‪⁬⁪‪​⁭‍⁮​‮‮‬⁭‮‍⁭‌⁬‎‭​⁬⁪⁬⁫‎‪‫⁭‭⁯⁭‮ = num;
			Thread thread = WiresharkSender.u206b‌‫‮‬‌‌⁭⁪‭‏‏​‏​⁮⁪⁯⁭⁭‭‪⁮⁬⁪⁬‍⁭‮⁭‎‍⁮⁯⁯​⁮‏‭⁯‮(new ThreadStart(this.u206d⁮‬‭‪‪‎‎‬⁭⁫⁯‍⁮⁪‍⁮‏‭‏⁪​⁯⁪‭‌⁭‍‬⁫‏⁫‫‍‭‫‍‎⁫‏‮));
			WiresharkSender.u206a⁫⁫‪‮‎‍‫‮​‎‏‍⁫‫⁫⁫⁫‌⁬‬⁯‎‍‍‎⁪‌‬​‍‍⁭‎‭‎‍⁮‫‭‮(thread, true);
			WiresharkSender.u200b‎‏‭⁬‌‍⁬​⁪‫‪⁯⁮⁭​‌‪‮⁪⁯⁯‬⁬​‪‎‫‫‭‍‏​‫‬⁭⁮‭‌⁪‮(thread);
		}

		public bool SendToWireshark(byte[] buffer, int offset, int lenght)
		{
			return this.SendToWireshark(buffer, offset, lenght, DateTime.Now);
		}

		public bool SendToWireshark(byte[] buffer, int offset, int lenght, DateTime date)
		{
			uint num = 0;
			uint ticks = 0;
			DateTime dateTime = new DateTime(date.Ticks / (long)10000000 * (long)10000000);
		Label1:
			int num1 = 1092045383;
			while (true)
			{
				int num2 = num1 ^ 1663287244;
				uint num3 = (uint)num2;
				switch (num2 % 4)
				{
					case 0:
					{
						ticks = (uint)((date.Ticks - dateTime.Ticks) / (long)10);
						num1 = (int)(num3 * -1924772266 ^ 2025089897);
						continue;
					}
					case 1:
					{
						return this.SendToWireshark(buffer, offset, lenght, num, ticks);
					}
					case 2:
					{
						goto Label1;
					}
					case 3:
					{
						num = this.u200d⁮‭‍‍‮⁮‌‏‎⁮‎‬⁬‎‎‫‎‍⁭‫‌​‭‫‪⁮‌⁫‮‍⁪‏⁬⁫‭‬⁬⁯‏‮(date);
						num1 = (int)(num3 * 575555303 ^ -1596025183);
						continue;
					}
				}
			}
			return this.SendToWireshark(buffer, offset, lenght, num, ticks);
		}

		public bool SendToWireshark(byte[] buffer, int offset, int lenght, uint date_sec, uint date_usec)
		{
			u206d​⁪‫‌⁭‬⁯‏‌⁪‪‬‬‬‪⁯⁬‪‪‌‏‌‎‪‫‏‍‭‬‎⁪⁪‎‬⁯⁭‎⁫‏‮ _⁭​⁪‫‌⁭‬⁯‏‌⁪‪‬‬‬‪⁯⁬‪‪‌‏‌‎‪‫‏‍‭‬‎⁪⁪‎‬⁯⁭‎⁫‏‮ = new u206d​⁪‫‌⁭‬⁯‏‌⁪‪‬‬‬‪⁯⁬‪‪‌‏‌‎‪‫‏‍‭‬‎⁪⁪‎‬⁯⁭‎⁫‏‮();
			bool flag;
			uint num;
			int num1;
			if (this.u202e‮‭‮​⁯⁫‭‬‍⁭‪⁫‍‮‏‬‌⁫⁮‌‮‎⁮⁫⁪‎‮‮⁭‭‌⁬‬​‍‭‍⁮‭‮)
			{
				goto Label0;
			}
		Label5:
			num1 = -316841466;
		Label7:
			while (true)
			{
				int num2 = num1 ^ -1565065104;
				num = (uint)num2;
				switch (num2 % 8)
				{
					case 0:
					{
						return false;
					}
					case 1:
					{
						break;
					}
					case 2:
					{
						num1 = ((int)buffer.Length < offset + lenght ? -625515344 : -1864896684);
						continue;
					}
					case 4:
					{
						_⁭​⁪‫‌⁭‬⁯‏‌⁪‪‬‬‬‪⁯⁬‪‪‌‏‌‎‪‫‏‍‭‬‎⁪⁪‎‬⁯⁭‎⁫‏‮ = new u206d​⁪‫‌⁭‬⁯‏‌⁪‪‬‬‬‪⁯⁬‪‪‌‏‌‎‪‫‏‍‭‬‎⁪⁪‎‬⁯⁭‎⁫‏‮((uint)lenght, date_sec, date_usec);
						num1 = -871820453;
						continue;
					}
					case 5:
					{
						return false;
					}
					case 6:
					{
						return false;
					}
					case 7:
					{
						goto Label5;
					}
					default:
					{
						goto Label2;
					}
				}
			}
		Label0:
			num1 = (buffer == null ? -817597099 : -166755902);
			goto Label7;
		Label2:
			byte[] numArray = _⁭​⁪‫‌⁭‬⁯‏‌⁪‪‬‬‬‪⁯⁬‪‪‌‏‌‎‪‫‏‍‭‬‎⁪⁪‎‬⁯⁭‎⁫‏‮.u202d‬⁯‌⁯‍‏‪⁮‏‍⁬‍‏⁭‍⁫‭‍‫‍‫⁮⁬‍​⁪‬‫‪‍‪⁯⁮⁮‮⁯‌‭‪‮();
			try
			{
				WiresharkSender.u202e‎‪‫⁭⁭⁪‭‬⁭‮‬⁯‬‌‎⁭​⁯⁬‬‪‫‮‎‍‮‮‪⁫‎‌⁪‪‏‏⁪‫‏⁬‮(this.u206e⁫⁮‮⁭‎‬⁬‎⁬⁭‎‏‭‍‍‌‪⁬‪‎‪⁪‍‍‏​‍⁮⁭⁭⁬‬⁯⁪⁮‮⁮‎⁫‮, numArray, 0, (int)numArray.Length);
				WiresharkSender.u202e‎‪‫⁭⁭⁪‭‬⁭‮‬⁯‬‌‎⁭​⁯⁬‬‪‫‮‎‍‮‮‪⁫‎‌⁪‪‏‏⁪‫‏⁬‮(this.u206e⁫⁮‮⁭‎‬⁬‎⁬⁭‎‏‭‍‍‌‪⁬‪‎‪⁪‍‍‏​‍⁮⁭⁭⁬‬⁯⁪⁮‮⁮‎⁫‮, buffer, offset, lenght);
				return true;
			}
			catch (IOException oException)
			{
				this.u202e‮‭‮​⁯⁫‭‬‍⁭‪⁫‍‮‏‬‌⁫⁮‌‮‎⁮⁫⁪‎‮‮⁭‭‌⁬‬​‍‭‍⁮‭‮ = false;
				WiresharkSender.u206a‫⁯‏⁬‏​⁫​⁭‫‮⁬‍‌‌⁯​‎⁮⁮‌‍⁯‭‌‫‫​⁪⁭‫⁮⁮⁭​⁪‫‪⁭‮(this.u206e⁫⁮‮⁭‎‬⁬‎⁬⁭‎‏‭‍‍‌‪⁬‪‎‪⁪‍‍‏​‍⁮⁭⁭⁬‬⁯⁪⁮‮⁮‎⁫‮);
			Label10:
				int num3 = -517649618;
				while (true)
				{
					int num4 = num3 ^ -1565065104;
					num = (uint)num4;
					switch (num4 % 3)
					{
						case 0:
						{
							goto Label9;
						}
						case 1:
						{
							WiresharkSender.u200e‫‏‮⁬‫‪⁭‎‌‌⁮⁮‮⁯‬⁭‌​‬‮⁯‪​‏‫⁫‪⁬‍‮‎‍⁭‭‌‏‍⁫⁮‮(this.u206e⁫⁮‮⁭‎‬⁬‎⁬⁭‎‏‭‍‍‌‪⁬‪‎‪⁪‍‍‏​‍⁮⁭⁭⁬‬⁯⁪⁮‮⁮‎⁫‮);
							Thread thread = WiresharkSender.u206b‌‫‮‬‌‌⁭⁪‭‏‏​‏​⁮⁪⁯⁭⁭‭‪⁮⁬⁪⁬‍⁭‮⁭‎‍⁮⁯⁯​⁮‏‭⁯‮(new ThreadStart(this.u206d⁮‬‭‪‪‎‎‬⁭⁫⁯‍⁮⁪‍⁮‏‭‏⁪​⁯⁪‭‌⁭‍‬⁫‏⁫‫‍‭‫‍‎⁫‏‮));
							WiresharkSender.u206a⁫⁫‪‮‎‍‫‮​‎‏‍⁫‫⁫⁫⁫‌⁬‬⁯‎‍‍‎⁪‌‬​‍‍⁭‎‭‎‍⁮‫‭‮(thread, true);
							WiresharkSender.u200b‎‏‭⁬‌‍⁬​⁪‫‪⁯⁮⁭​‌‪‮⁪⁯⁯‬⁬​‪‎‫‫‭‍‏​‫‬⁭⁮‭‌⁪‮(thread);
							num3 = (int)(num * 1342195925 ^ 153870519);
							continue;
						}
						case 2:
						{
							goto Label10;
						}
					}
				}
			Label9:
				flag = false;
			}
			catch (Exception exception)
			{
				flag = false;
			}
			return flag;
		}
	}
}