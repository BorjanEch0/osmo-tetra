using System;
using System.Linq;
using System.Reflection;

namespace SDRSharp.Tetra
{
	public class Info
	{
		// ​⁭⁭⁪‬⁮⁬‎‪‭‬⁮‫‫​‪‪‬‎‎⁮‎⁬‭⁪​⁪‏‭‍⁮⁮⁯‭‫​‌⁭⁪⁮‮
		// privatescope
		internal static Assembly u200b⁭⁭⁪‬⁮⁬‎‪‭‬⁮‫‫​‪‪‬‎‎⁮‎⁬‭⁪​⁪‏‭‍⁮⁮⁯‭‫​‌⁭⁪⁮‮()
		{
			return Assembly.GetExecutingAssembly();
		}

		// ⁬⁫‏⁪⁭⁬‍‍⁭⁬‫​⁫‎‬⁬‍‎‌⁫‮⁫‭⁬⁪⁮‌⁭‌⁫‮⁪‍​​‎‫⁮‭‮‮
		// privatescope
		internal static Type u206c⁫‏⁪⁭⁬‍‍⁭⁬‫​⁫‎‬⁬‍‎‌⁫‮⁫‭⁬⁪⁮‌⁭‌⁫‮⁪‍​​‎‫⁮‭‮‮(RuntimeTypeHandle runtimeTypeHandle)
		{
			return Type.GetTypeFromHandle(runtimeTypeHandle);
		}

		// ‪‎‮‬‮‏‭​⁬‬⁪‍‎‌‬‮‎‪‌⁫‮‭​​‌⁫⁯​‪‎⁭⁪⁯⁭⁬‍‬‮⁮‪‮
		// privatescope
		internal static object[] u202a‎‮‬‮‏‭​⁬‬⁪‍‎‌‬‮‎‪‌⁫‮‭​​‌⁫⁯​‪‎⁭⁪⁯⁭⁬‍‬‮⁮‪‮(Assembly assembly, Type type, bool flag)
		{
			return assembly.GetCustomAttributes(type, flag);
		}

		// ⁪⁮⁪‫‭‌‌‌‌‪‭⁬‪⁮⁭‌‭‪⁯‫‮‪‍⁮‏⁪‭‏‬⁪‬‬⁯‏‪⁭‍​‌⁮‮
		// privatescope
		internal static string u206a⁮⁪‫‭‌‌‌‌‪‭⁬‪⁮⁭‌‭‪⁯‫‮‪‍⁮‏⁪‭‏‬⁪‬‬⁯‏‪⁭‍​‌⁮‮(AssemblyDescriptionAttribute assemblyDescriptionAttribute)
		{
			return assemblyDescriptionAttribute.Description;
		}

		// ‎‮⁭‭‍⁭‎‭‍⁯⁬‮⁭‎​‫‌‬⁫‪‏⁭⁪‪⁭‏‭‍‮⁮⁪‭⁪‎⁮‪‪‌‬⁪‮
		// privatescope
		internal static AssemblyName u200e‮⁭‭‍⁭‎‭‍⁯⁬‮⁭‎​‫‌‬⁫‪‏⁭⁪‪⁭‏‭‍‮⁮⁪‭⁪‎⁮‪‪‌‬⁪‮(Assembly assembly)
		{
			return assembly.GetName();
		}

		// ‌⁪‏⁫‪‍‮‎⁭‌⁮‫‪​‮‮⁮‎⁬⁪‌‎‏⁭⁮‭⁬‍⁫‪​‬⁬‪⁯⁭⁫‎‫‌‮
		// privatescope
		internal static Version u200c⁪‏⁫‪‍‮‎⁭‌⁮‫‪​‮‮⁮‎⁬⁪‌‎‏⁭⁮‭⁬‍⁫‪​‬⁬‪⁯⁭⁫‎‫‌‮(AssemblyName assemblyName)
		{
			return assemblyName.Version;
		}

		// ‫⁫‫‭⁬‌⁯‪⁪‎⁫‫⁮⁮‫⁮​⁭⁮⁭⁮⁭⁯⁬⁬‌‭‮‍⁫⁯⁬⁯⁪‮‪‭‫⁬‎‮
		// privatescope
		internal static string u202b⁫‫‭⁬‌⁯‪⁪‎⁫‫⁮⁮‫⁮​⁭⁮⁭⁮⁭⁯⁬⁬‌‭‮‍⁫⁯⁬⁯⁪‮‪‭‫⁬‎‮(object obj)
		{
			return obj.ToString();
		}

		public Info()
		{
		}

		public static string Title()
		{
			return Info.u206a⁮⁪‫‭‌‌‌‌‪‭⁬‪⁮⁭‌‭‪⁯‫‮‪‍⁮‏⁪‭‏‬⁪‬‬⁯‏‪⁭‍​‌⁮‮(Info.u202a‎‮‬‮‏‭​⁬‬⁪‍‎‌‬‮‎‪‌⁫‮‭​​‌⁫⁯​‪‎⁭⁪⁯⁭⁬‍‬‮⁮‪‮(Info.u200b⁭⁭⁪‬⁮⁬‎‪‭‬⁮‫‫​‪‪‬‎‎⁮‎⁬‭⁪​⁪‏‭‍⁮⁮⁯‭‫​‌⁭⁪⁮‮(), Info.u206c⁫‏⁪⁭⁬‍‍⁭⁬‫​⁫‎‬⁬‍‎‌⁫‮⁫‭⁬⁪⁮‌⁭‌⁫‮⁪‍​​‎‫⁮‭‮‮(typeof(AssemblyDescriptionAttribute).TypeHandle), false).OfType<AssemblyDescriptionAttribute>().FirstOrDefault<AssemblyDescriptionAttribute>());
		}

		public static string Version()
		{
			return Info.u202b⁫‫‭⁬‌⁯‪⁪‎⁫‫⁮⁮‫⁮​⁭⁮⁭⁮⁭⁯⁬⁬‌‭‮‍⁫⁯⁬⁯⁪‮‪‭‫⁬‎‮(Info.u200c⁪‏⁫‪‍‮‎⁭‌⁮‫‪​‮‮⁮‎⁬⁪‌‎‏⁭⁮‭⁬‍⁫‪​‬⁬‪⁯⁭⁫‎‫‌‮(Info.u200e‮⁭‭‍⁭‎‭‍⁯⁬‮⁭‎​‫‌‬⁫‪‏⁭⁪‪⁭‏‭‍‮⁮⁪‭⁪‎⁮‪‪‌‬⁪‮(Info.u200b⁭⁭⁪‬⁮⁬‎‪‭‬⁮‫‫​‪‪‬‎‎⁮‎⁬‭⁪​⁪‏‭‍⁮⁮⁯‭‫​‌⁭⁪⁮‮())));
		}
	}
}