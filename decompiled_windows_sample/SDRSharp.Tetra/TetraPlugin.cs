using SDRSharp.Common;
using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace SDRSharp.Tetra
{
	public class TetraPlugin : ISharpPlugin
	{
		// ‮‭‬‏‏‍​⁪⁮‭⁯⁭⁬‏‭⁫⁯‪‎⁭‮⁬‬‌⁭‎‭‍⁫‭​⁮⁯⁭‌⁫‏‎⁯‍‮
		private const string u202e‭‬‏‏‍​⁪⁮‭⁯⁭⁬‏‭⁫⁯‪‎⁭‮⁬‬‌⁭‎‭‍⁫‭​⁮⁯⁭‌⁫‏‎⁯‍‮ = "TETRA Demodulator";

		// ‪⁬‮⁬‬‮‏⁬‏⁯⁬​⁮​‌‫‍⁯‌⁬⁫‪⁬‬⁪⁪‫⁫⁭‎‍‫‫‬‮‬⁫⁯⁫‌‮
		private ISharpControl u202a⁬‮⁬‬‮‏⁬‏⁯⁬​⁮​‌‫‍⁯‌⁬⁫‪⁬‬⁪⁪‫⁫⁭‎‍‫‫‬‮‬⁫⁯⁫‌‮;

		// ‮‪⁬⁭‫‍‮⁭‬⁭‬‎‮​‫‬⁯‌‮⁪‬⁬‍⁪⁫​⁫⁭‬‌​‎‬‮​‬⁫⁮⁯‏‮
		private TetraPanel u202e‪⁬⁭‫‍‮⁭‬⁭‬‎‮​‫‬⁯‌‮⁪‬⁬‍⁪⁫​⁫⁭‬‌​‎‬‮​‬⁫⁮⁯‏‮;

		public string DisplayName
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return u003cModuleu003e.u202a‮‫‏‫‬‬‪⁫⁬​‏⁫⁭‍‪‪‎⁬​‪​‌⁮‮‌​⁫​⁬‪‫⁪⁯⁪‎‫⁭‎⁪‮<string>(-1378308762);
			}
		}

		public UserControl Gui
		{
			get
			{
				return this.u202e‪⁬⁭‫‍‮⁭‬⁭‬‎‮​‫‬⁯‌‮⁪‬⁬‍⁪⁫​⁫⁭‬‌​‎‬‮​‬⁫⁮⁯‏‮;
			}
		}

		// ‬⁫⁭‮⁭‌⁪⁫⁬⁫‫⁫‫⁯‭⁫⁯⁪‮‬⁯‌⁪‫‍⁭‮‍‬⁫‏⁭‎⁭⁭‮⁯‬‏⁯‮
		// privatescope
		internal static Type u202c⁫⁭‮⁭‌⁪⁫⁬⁫‫⁫‫⁯‭⁫⁯⁪‮‬⁯‌⁪‫‍⁭‮‍‬⁫‏⁭‎⁭⁭‮⁯‬‏⁯‮(ISharpControl sharpControl)
		{
			return sharpControl.get_SourceType();
		}

		// ‭‮‮​‏‎​⁯‬⁯‮⁭‬⁬‏⁯⁫‭⁪‌‫‭‫​⁪⁪‫⁮‫⁪⁪‭‮‮⁭‮‮‏⁭‮
		// privatescope
		internal static bool u202d‮‮​‏‎​⁯‬⁯‮⁭‬⁬‏⁯⁫‭⁪‌‫‭‫​⁪⁪‫⁮‫⁪⁪‭‮‮⁭‮‮‏⁭‮(Type type, Type type)
		{
			return type != type;
		}

		// ‪‍‍‏‪⁫​⁫‌‎‭​‭‮⁪⁯‌⁮‌‮‏‮⁭‪‫​‎‏‏‫‭‫‬‌​‭‭‭‎⁪‮
		// privatescope
		internal static string u202a‍‍‏‪⁫​⁫‌‎‭​‭‮⁪⁯‌⁮‌‮‏‮⁭‪‫​‎‏‏‫‭‫‬‌​‭‭‭‎⁪‮(MemberInfo memberInfo)
		{
			return memberInfo.Name;
		}

		// ‏‏⁪‪‌‪⁭‍⁭⁪‎⁫⁫⁯‬‏‍‏⁮⁭⁫⁬‍⁭​‭‏‪‎‮⁯⁫⁭‭​‍‍​‌‎‮
		// privatescope
		internal static bool u200f‏⁪‪‌‪⁭‍⁭⁪‎⁫⁫⁯‬‏‍‏⁮⁭⁫⁬‍⁭​‭‏‪‎‮⁯⁫⁭‭​‍‍​‌‎‮(string str, string str)
		{
			return str == str;
		}

		public TetraPlugin()
		{
		}

		public void Close()
		{
			int num;
			if (this.u202e‪⁬⁭‫‍‮⁭‬⁭‬‎‮​‫‬⁯‌‮⁪‬⁬‍⁪⁫​⁫⁭‬‌​‎‬‮​‬⁫⁮⁯‏‮ != null)
			{
				goto Label0;
			}
		Label1:
			num = -1404832571;
		Label3:
			int num1 = num ^ -766569614;
			uint num2 = (uint)num1;
			switch (num1 % 4)
			{
				case 0:
				{
					break;
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
					return;
				}
				default:
				{
					return;
				}
			}
		Label0:
			this.u202e‪⁬⁭‫‍‮⁭‬⁭‬‎‮​‫‬⁯‌‮⁪‬⁬‍⁪⁫​⁫⁭‬‌​‎‬‮​‬⁫⁮⁯‏‮.ServerControl(false);
			this.u202e‪⁬⁭‫‍‮⁭‬⁭‬‎‮​‫‬⁯‌‮⁪‬⁬‍⁪⁫​⁫⁭‬‌​‎‬‮​‬⁫⁮⁯‏‮.SaveSettings();
			this.u202e‪⁬⁭‫‍‮⁭‬⁭‬‎‮​‫‬⁯‌‮⁪‬⁬‍⁪⁫​⁫⁭‬‌​‎‬‮​‬⁫⁮⁯‏‮.DeleteRoleFile();
			num = -1214830265;
			goto Label3;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Initialize(ISharpControl control)
		{
			int num;
			int num1;
			this.u202a⁬‮⁬‬‮‏⁬‏⁯⁬​⁮​‌‫‍⁯‌⁬⁫‪⁬‬⁪⁪‫⁫⁭‎‍‫‫‬‮‬⁫⁯⁫‌‮ = control;
		Label1:
			uint num2 = -436151382;
			while (true)
			{
				uint num3 = (uint)(num2 ^ -464149328);
				uint num4 = num3;
				switch (num3 % 7)
				{
					case 0:
					{
						num = (!TetraPlugin.u202d‮‮​‏‎​⁯‬⁯‮⁭‬⁬‏⁯⁫‭⁪‌‫‭‫​⁪⁪‫⁮‫⁪⁪‭‮‮⁭‮‮‏⁭‮(TetraPlugin.u202c⁫⁭‮⁭‌⁪⁫⁬⁫‫⁫‫⁯‭⁫⁯⁪‮‬⁯‌⁪‫‍⁭‮‍‬⁫‏⁭‎⁭⁭‮⁯‬‏⁯‮(this.u202a⁬‮⁬‬‮‏⁬‏⁯⁬​⁮​‌‫‍⁯‌⁬⁫‪⁬‬⁪⁪‫⁫⁭‎‍‫‫‬‮‬⁫⁯⁫‌‮), null) ? 1584181874 : 471177441);
						num2 = num ^ num4 * -1908385763;
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
						break;
					}
					case 4:
					{
						this.u202e‪⁬⁭‫‍‮⁭‬⁭‬‎‮​‫‬⁯‌‮⁪‬⁬‍⁪⁫​⁫⁭‬‌​‎‬‮​‬⁫⁮⁯‏‮ = new TetraPanel(this.u202a⁬‮⁬‬‮‏⁬‏⁯⁬​⁮​‌‫‍⁯‌⁬⁫‪⁬‬⁪⁪‫⁫⁭‎‍‫‫‬‮‬⁫⁯⁫‌‮);
						num2 = -1513108368;
						continue;
					}
					case 5:
					{
						num2 = (uint)((TetraPlugin.u200f‏⁪‪‌‪⁭‍⁭⁪‎⁫⁫⁯‬‏‍‏⁮⁭⁫⁬‍⁭​‭‏‪‎‮⁯⁫⁭‭​‍‍​‌‎‮(TetraPlugin.u202a‍‍‏‪⁫​⁫‌‎‭​‭‮⁪⁯‌⁮‌‮‏‮⁭‪‫​‎‏‏‫‭‫‬‌​‭‭‭‎⁪‮(TetraPlugin.u202c⁫⁭‮⁭‌⁪⁫⁬⁫‫⁫‫⁯‭⁫⁯⁪‮‬⁯‌⁪‫‍⁭‮‍‬⁫‏⁭‎⁭⁭‮⁯‬‏⁯‮(this.u202a⁬‮⁬‬‮‏⁬‏⁯⁬​⁮​‌‫‍⁯‌⁬⁫‪⁬‬⁪⁪‫⁫⁭‎‍‫‫‬‮‬⁫⁯⁫‌‮)), u003cModuleu003e.u200d​‍⁮‏‭⁮⁪‌‪‬‬‬‪⁬⁭⁫⁫‬⁪⁬⁬⁬‏⁮⁭‌‍‏‍‏‎‬⁬​‪‎​‎⁭‮<string>(1224081765)) ? -1503742373 : -1780707709));
						int num5 = (int)num2;
						continue;
					}
					case 6:
					{
						num1 = (this.u202a⁬‮⁬‬‮‏⁬‏⁯⁬​⁮​‌‫‍⁯‌⁬⁫‪⁬‬⁪⁪‫⁫⁭‎‍‫‫‬‮‬⁫⁯⁫‌‮ == null ? -1795936938 : -132685197);
						num2 = num1 ^ num4 * 1706743967;
						continue;
					}
					default:
					{
						return;
					}
				}
			}
			return;
		}
	}
}