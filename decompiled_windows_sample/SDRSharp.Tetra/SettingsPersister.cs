using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace SDRSharp.Tetra
{
	public class SettingsPersister
	{
		// ‍‏⁮‎⁫‍‭‭‭‭‫⁮⁫⁬⁪‎‌‌‪⁪​‭‎⁬​‬‫‎⁪‪‌‬⁬‍‌⁮‫‬⁭‫‮
		private string u200d‏⁮‎⁫‍‭‭‭‭‫⁮⁫⁬⁪‎‌‌‪⁪​‭‎⁬​‬‫‎⁪‪‌‬⁬‍‌⁮‫‬⁭‫‮;

		// ‮⁭‫⁭⁫‍‪‪⁭⁮‍‎⁯⁬‏‍⁫​​‭⁪⁯⁮⁫‌‍‬⁭‫‮‫‬⁯‫‪‏‏‌‪‮‮
		private readonly string u202e⁭‫⁭⁫‍‪‪⁭⁮‍‎⁯⁬‏‍⁫​​‭⁪⁯⁮⁫‌‍‬⁭‫‮‫‬⁯‫‪‏‏‌‪‮‮;

		// ‌‌⁮‍​‪​‫​⁬⁯‍‏‭‏‏‍‫‮‮‫​‫‌‭‪⁭⁮⁮⁬​⁯‌⁫⁯‏‮⁮‪⁮‮
		private  u200c‌⁮‍​‪​‫​⁬⁯‍‏‭‏‏‍‫‮‮‫​‫‌‭‪⁭⁮⁮⁬​⁯‌⁫⁯‏‮⁮‪⁮‮<u0001>(string str)
		{
			 _u0001 = default();
			string str1 = SettingsPersister.u206c‫⁫‍‮⁮‬‭‎‭‫‮‭‫⁭‬‪‎⁫​‎‏‎‫‎‮⁭⁬​‬‍⁮‏‪‎‬⁫‪‎‎‮(this.u202e⁭‫⁭⁫‍‪‪⁭⁮‍‎⁯⁬‏‍⁫​​‭⁪⁯⁮⁫‌‍‬⁭‫‮‫‬⁯‫‪‏‏‌‪‮‮, str);
		Label0:
			int num = 518041691;
			while (true)
			{
				int num1 = num ^ 1643955793;
				uint num2 = (uint)num1;
				switch (num1 % 3)
				{
					case 0:
					{
						FileStream fileStream = SettingsPersister.u206d‌‬⁭‮‏‬​‪​⁮⁫⁮‍⁯⁮‏‫​⁯‪‌⁭‭‌⁭⁮⁮‏‬‍⁪‌⁬‭⁫⁫⁫‎⁮‮(str1, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
						try
						{
							_u0001 = ()SettingsPersister.u200c‫‎​‮‬‮‎‫⁭⁬⁫⁮‫⁮⁬‭‌⁭⁫⁭‪‪‫‍‏⁫⁬⁪‎‎⁮‮‭‏⁮‬‏⁯⁮‮(SettingsPersister.u206a‮​‪‎‮‫‬‮‍‭⁬⁯‮​‌‍‌‌‪⁯‫⁯‍‪⁮‍‮​⁯⁭‏‪⁮⁭‫‪‏⁫‭‮(SettingsPersister.u202a⁯‎⁭‌‌⁮⁮‌⁮‏⁬⁯‮‮⁭‌‏‬⁬‏‪‍‍​‬⁭‮‍⁮⁮⁬‏⁪​‍​‎​⁭‮(typeof(u0001).TypeHandle)), fileStream);
						}
						finally
						{
							if (fileStream == null)
							{
								goto Label1;
							}
						Label2:
							int num3 = 1053027390;
							while (true)
							{
								int num4 = num3 ^ 1643955793;
								num2 = (uint)num4;
								switch (num4 % 3)
								{
									case 0:
									{
										goto Label2;
									}
									case 1:
									{
										goto Label1;
									}
									case 2:
									{
										SettingsPersister.u202d​‏‫‬‪‏‎‫‫‫‫⁭‭‫⁪⁪‫⁭‬‬‪⁫‍‬‬‎‭​‭⁭⁮⁭‏⁯‎‍‭‪⁮‮(fileStream);
										num3 = (int)(num2 * -2029931622 ^ 860225409);
										continue;
									}
								}
							}
						Label1:
						}
						break;
					}
					case 1:
					{
						if (!SettingsPersister.u200d⁬‍⁭⁮⁭‏‮‫‍⁫⁮‬⁯​‪‏‏‎‭⁪⁭⁯‌⁭⁫⁪⁮‏‏⁫‎‭‪‭⁬‮‎‪⁮‮(str1))
						{
							 _u00011 = default();
						Label3:
							int num5 = 1361120897 ^ 1643955793;
							num2 = (uint)num5;
							switch (num5 % 3)
							{
								case 0:
								{
									goto Label3;
								}
								case 2:
								{
									return _u00011;
								}
							}
						}
						else
						{
							num = (int)(num2 * -1442635108 ^ 1701639999);
							continue;
						}
						break;
					}
					case 2:
					{
						goto Label0;
					}
					default:
					{
						goto case 0;
					}
				}
			}
			return _u0001;
		}

		// ⁭‬​‎‏‍‭​⁪‫‪‪⁭⁫⁭‫⁪‮⁪‭‍⁮‏​‌‮​‏‫‫⁬‏‎⁬‎⁭⁯⁮‪‎‮
		private void u206d‬​‎‏‍‭​⁪‫‪‪⁭⁫⁭‫⁪‮⁪‭‍⁮‏​‌‮​‏‫‫⁬‏‎⁬‎⁭⁯⁮‪‎‮<u0001>( _u0001, string str)
		{
			FileStream fileStream = SettingsPersister.u206c⁬⁫‫⁫‪‍⁮‪⁪⁯⁬‪‍⁫⁭‏‪⁮‬‬‮⁯‭⁪‬​‮‫​‍⁮‫‎‮⁯‮‫⁮⁮‮(SettingsPersister.u206c‫⁫‍‮⁮‬‭‎‭‫‮‭‫⁭‬‪‎⁫​‎‏‎‫‎‮⁭⁬​‬‍⁮‏‪‎‬⁫‪‎‎‮(this.u202e⁭‫⁭⁫‍‪‪⁭⁮‍‎⁯⁬‏‍⁫​​‭⁪⁯⁮⁫‌‍‬⁭‫‮‫‬⁯‫‪‏‏‌‪‮‮, str), FileMode.Create);
			try
			{
				SettingsPersister.u202c‫⁮‫⁮⁮⁭⁯⁬⁮⁪‭‮⁫⁫‌​⁬⁫⁫‫‬‭​‬‬⁫⁫⁪‎⁭‬⁭​‫‮‬⁫‎⁬‮(SettingsPersister.u206a‮​‪‎‮‫‬‮‍‭⁬⁯‮​‌‍‌‌‪⁯‫⁯‍‪⁮‍‮​⁯⁭‏‪⁮⁭‫‪‏⁫‭‮(_u0001.GetType()), fileStream, _u0001);
			}
			finally
			{
				if (fileStream == null)
				{
					goto Label0;
				}
			Label1:
				int num = 324814177;
				while (true)
				{
					int num1 = num ^ 614392042;
					uint num2 = (uint)num1;
					switch (num1 % 3)
					{
						case 0:
						{
							goto Label1;
						}
						case 1:
						{
							SettingsPersister.u202d​‏‫‬‪‏‎‫‫‫‫⁭‭‫⁪⁪‫⁭‬‬‪⁫‍‬‬‎‭​‭⁭⁮⁭‏⁯‎‍‭‪⁮‮(fileStream);
							num = (int)(num2 * -558571906 ^ 2018900214);
							continue;
						}
						case 2:
						{
							goto Label0;
						}
					}
				}
			Label0:
			}
		}

		// ⁭​‬‍‏⁪‌‮‭‫⁬‪‫⁫‬⁫‫‏‭‭‮‮⁮‬‎⁮⁮‫⁪⁬​​‭⁫⁭‭⁬​⁬⁮‮
		// privatescope
		internal static string u206d​‬‍‏⁪‌‮‭‫⁬‪‫⁫‬⁫‫‏‭‭‮‮⁮‬‎⁮⁮‫⁪⁬​​‭⁫⁭‭⁬​⁬⁮‮()
		{
			return Application.ExecutablePath;
		}

		// ⁮⁯‎‪⁪‮​‭‍‌⁪⁮⁯⁬‭‪‫‮⁫‎‫‪‏​⁮​‬⁭‏⁫‬‭⁯⁫‮⁯‮⁮‬‎‮
		// privatescope
		internal static string u206e⁯‎‪⁪‮​‭‍‌⁪⁮⁯⁬‭‪‫‮⁫‎‫‪‏​⁮​‬⁭‏⁫‬‭⁯⁫‮⁯‮⁮‬‎‮(string str)
		{
			return Path.GetDirectoryName(str);
		}

		// ⁬‫⁫‍‮⁮‬‭‎‭‫‮‭‫⁭‬‪‎⁫​‎‏‎‫‎‮⁭⁬​‬‍⁮‏‪‎‬⁫‪‎‎‮
		// privatescope
		internal static string u206c‫⁫‍‮⁮‬‭‎‭‫‮‭‫⁭‬‪‎⁫​‎‏‎‫‎‮⁭⁬​‬‍⁮‏‪‎‬⁫‪‎‎‮(string str, string str)
		{
			return Path.Combine(str, str);
		}

		// ‍⁬‍⁭⁮⁭‏‮‫‍⁫⁮‬⁯​‪‏‏‎‭⁪⁭⁯‌⁭⁫⁪⁮‏‏⁫‎‭‪‭⁬‮‎‪⁮‮
		// privatescope
		internal static bool u200d⁬‍⁭⁮⁭‏‮‫‍⁫⁮‬⁯​‪‏‏‎‭⁪⁭⁯‌⁭⁫⁪⁮‏‏⁫‎‭‪‭⁬‮‎‪⁮‮(string str)
		{
			return File.Exists(str);
		}

		// ⁭‌‬⁭‮‏‬​‪​⁮⁫⁮‍⁯⁮‏‫​⁯‪‌⁭‭‌⁭⁮⁮‏‬‍⁪‌⁬‭⁫⁫⁫‎⁮‮
		// privatescope
		internal static FileStream u206d‌‬⁭‮‏‬​‪​⁮⁫⁮‍⁯⁮‏‫​⁯‪‌⁭‭‌⁭⁮⁮‏‬‍⁪‌⁬‭⁫⁫⁫‎⁮‮(string str, FileMode fileMode, FileAccess fileAccess, FileShare fileShare)
		{
			return new FileStream(str, fileMode, fileAccess, fileShare);
		}

		// ‪⁯‎⁭‌‌⁮⁮‌⁮‏⁬⁯‮‮⁭‌‏‬⁬‏‪‍‍​‬⁭‮‍⁮⁮⁬‏⁪​‍​‎​⁭‮
		// privatescope
		internal static Type u202a⁯‎⁭‌‌⁮⁮‌⁮‏⁬⁯‮‮⁭‌‏‬⁬‏‪‍‍​‬⁭‮‍⁮⁮⁬‏⁪​‍​‎​⁭‮(RuntimeTypeHandle runtimeTypeHandle)
		{
			return Type.GetTypeFromHandle(runtimeTypeHandle);
		}

		// ⁪‮​‪‎‮‫‬‮‍‭⁬⁯‮​‌‍‌‌‪⁯‫⁯‍‪⁮‍‮​⁯⁭‏‪⁮⁭‫‪‏⁫‭‮
		// privatescope
		internal static XmlSerializer u206a‮​‪‎‮‫‬‮‍‭⁬⁯‮​‌‍‌‌‪⁯‫⁯‍‪⁮‍‮​⁯⁭‏‪⁮⁭‫‪‏⁫‭‮(Type type)
		{
			return new XmlSerializer(type);
		}

		// ‌‫‎​‮‬‮‎‫⁭⁬⁫⁮‫⁮⁬‭‌⁭⁫⁭‪‪‫‍‏⁫⁬⁪‎‎⁮‮‭‏⁮‬‏⁯⁮‮
		// privatescope
		internal static object u200c‫‎​‮‬‮‎‫⁭⁬⁫⁮‫⁮⁬‭‌⁭⁫⁭‪‪‫‍‏⁫⁬⁪‎‎⁮‮‭‏⁮‬‏⁯⁮‮(XmlSerializer xmlSerializer, Stream stream)
		{
			return xmlSerializer.Deserialize(stream);
		}

		// ‭​‏‫‬‪‏‎‫‫‫‫⁭‭‫⁪⁪‫⁭‬‬‪⁫‍‬‬‎‭​‭⁭⁮⁭‏⁯‎‍‭‪⁮‮
		// privatescope
		internal static void u202d​‏‫‬‪‏‎‫‫‫‫⁭‭‫⁪⁪‫⁭‬‬‪⁫‍‬‬‎‭​‭⁭⁮⁭‏⁯‎‍‭‪⁮‮(IDisposable disposable)
		{
			disposable.Dispose();
		}

		// ⁬⁬⁫‫⁫‪‍⁮‪⁪⁯⁬‪‍⁫⁭‏‪⁮‬‬‮⁯‭⁪‬​‮‫​‍⁮‫‎‮⁯‮‫⁮⁮‮
		// privatescope
		internal static FileStream u206c⁬⁫‫⁫‪‍⁮‪⁪⁯⁬‪‍⁫⁭‏‪⁮‬‬‮⁯‭⁪‬​‮‫​‍⁮‫‎‮⁯‮‫⁮⁮‮(string str, FileMode fileMode)
		{
			return new FileStream(str, fileMode);
		}

		// ‬‫⁮‫⁮⁮⁭⁯⁬⁮⁪‭‮⁫⁫‌​⁬⁫⁫‫‬‭​‬‬⁫⁫⁪‎⁭‬⁭​‫‮‬⁫‎⁬‮
		// privatescope
		internal static void u202c‫⁮‫⁮⁮⁭⁯⁬⁮⁪‭‮⁫⁫‌​⁬⁫⁫‫‬‭​‬‬⁫⁫⁪‎⁭‬⁭​‫‮‬⁫‎⁬‮(XmlSerializer xmlSerializer, Stream stream, object obj)
		{
			xmlSerializer.Serialize(stream, obj);
		}

		public SettingsPersister(string str)
		{
			this.u200d‏⁮‎⁫‍‭‭‭‭‫⁮⁫⁬⁪‎‌‌‪⁪​‭‎⁬​‬‫‎⁪‪‌‬⁬‍‌⁮‫‬⁭‫‮ = str;
			this.u202e⁭‫⁭⁫‍‪‪⁭⁮‍‎⁯⁬‏‍⁫​​‭⁪⁯⁮⁫‌‍‬⁭‫‮‫‬⁯‫‪‏‏‌‪‮‮ = SettingsPersister.u206e⁯‎‪⁪‮​‭‍‌⁪⁮⁯⁬‭‪‫‮⁫‎‫‪‏​⁮​‬⁭‏⁫‬‭⁯⁫‮⁯‮⁮‬‎‮(SettingsPersister.u206d​‬‍‏⁪‌‮‭‫⁬‪‫⁫‬⁫‫‏‭‭‮‮⁮‬‎⁮⁮‫⁪⁬​​‭⁫⁭‭⁬​⁬⁮‮());
		}

		public void PersistStored(TetraSettings entries)
		{
			this.u206d‬​‎‏‍‭​⁪‫‪‪⁭⁫⁭‫⁪‮⁪‭‍⁮‏​‌‮​‏‫‫⁬‏‎⁬‎⁭⁯⁮‪‎‮<TetraSettings>(entries, this.u200d‏⁮‎⁫‍‭‭‭‭‫⁮⁫⁬⁪‎‌‌‪⁪​‭‎⁬​‬‫‎⁪‪‌‬⁬‍‌⁮‫‬⁭‫‮);
		}

		public TetraSettings ReadStored()
		{
			TetraSettings tetraSetting;
			TetraSettings tetraSetting1 = this.u200c‌⁮‍​‪​‫​⁬⁯‍‏‭‏‏‍‫‮‮‫​‫‌‭‪⁭⁮⁮⁬​⁯‌⁫⁯‏‮⁮‪⁮‮<TetraSettings>(this.u200d‏⁮‎⁫‍‭‭‭‭‫⁮⁫⁬⁪‎‌‌‪⁪​‭‎⁬​‬‫‎⁪‪‌‬⁬‍‌⁮‫‬⁭‫‮);
			if (tetraSetting1 == null)
			{
				tetraSetting = new TetraSettings()
				{
					AlternativeCallListGeneration = true
				};
				return tetraSetting;
			}
		Label1:
			int num = -486340833 ^ -203391674;
			uint num1 = (uint)num;
			switch (num % 3)
			{
				case 1:
				{
					return tetraSetting1;
				}
				case 2:
				{
					goto Label1;
				}
			}
			tetraSetting = new TetraSettings()
			{
				AlternativeCallListGeneration = true
			};
			return tetraSetting;
		}
	}
}