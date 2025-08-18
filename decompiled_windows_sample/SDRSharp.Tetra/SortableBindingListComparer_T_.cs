using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;

namespace SDRSharp.Tetra
{
	public class SortableBindingListComparer<T> : IComparer<T>
	{
		// ‌‬‮‏⁯‬‍​‎‬‎‍‭‬⁮⁭‫‬‎⁯‎⁬‪‫‮‏‫⁭⁯⁮‬‬‍⁮‌⁪‎⁪​⁪‮
		private PropertyInfo u200c‬‮‏⁯‬‍​‎‬‎‍‭‬⁮⁭‫‬‎⁯‎⁬‪‫‮‏‫⁭⁯⁮‬‬‍⁮‌⁪‎⁪​⁪‮;

		// ‫‭⁯‍‭​‮‍‍‍‭⁮‭‌⁭‬‬‍‎⁬⁮‏‎⁬⁮‭⁮​‫‮‮⁮‌‭‬⁪‎⁯​⁮‮
		private ListSortDirection u202b‭⁯‍‭​‮‍‍‍‭⁮‭‌⁭‬‬‍‎⁬⁮‏‎⁬⁮‭⁮​‫‮‮⁮‌‭‬⁪‎⁯​⁮‮;

		// ⁪‪‪⁬‍‮⁫⁪‌⁯⁬⁮⁭‍‬‏‫‪‏⁭‭‬⁪‎‫⁭‌‌‭‮⁭⁫⁮‮‏​‮⁭‬‮
		// privatescope
		internal static Type u206a‪‪⁬‍‮⁫⁪‌⁯⁬⁮⁭‍‬‏‫‪‏⁭‭‬⁪‎‫⁭‌‌‭‮⁭⁫⁮‮‏​‮⁭‬‮(RuntimeTypeHandle runtimeTypeHandle)
		{
			return Type.GetTypeFromHandle(runtimeTypeHandle);
		}

		// ‬⁬‌⁮‫⁭‎‬‬⁫‌‫⁭⁯‭⁭⁯‌‫‫⁫‎​⁬⁫‎‫‌​‍⁯⁯‮⁮‎‌‏‏‫‫‮
		// privatescope
		internal PropertyInfo u202c⁬‌⁮‫⁭‎‬‬⁫‌‫⁭⁯‭⁭⁯‌‫‫⁫‎​⁬⁫‎‫‌​‍⁯⁯‮⁮‎‌‏‏‫‫‮(string str)
		{
			return this.GetProperty(str);
		}

		// ‍‮‬‫⁮⁭‮‏‭‏‮‬⁬⁭⁬‫‫‫⁯⁪‭‮‎‍⁯⁮‏⁭‎‬‫‏⁪‬‪⁭‫‍⁪‭‮
		// privatescope
		internal static object u200d‮‬‫⁮⁭‮‏‭‏‮‬⁬⁭⁬‫‫‫⁯⁪‭‮‎‍⁯⁮‏⁭‎‬‫‏⁪‬‪⁭‫‍⁪‭‮(PropertyInfo propertyInfo, object obj, object[] objArray)
		{
			return propertyInfo.GetValue(obj, objArray);
		}

		// ⁪‪⁪⁫‮⁯‭‪⁬⁫​‭⁭‌‪‎‬‭⁫⁮‮‏‫‭⁭‪⁪‍‎​​​⁮‎⁯‫⁪‍⁭‮‮
		// privatescope
		internal static int u206a‪⁪⁫‮⁯‭‪⁬⁫​‭⁭‌‪‎‬‭⁫⁮‮‏‫‭⁭‪⁪‍‎​​​⁮‎⁯‫⁪‍⁭‮‮(IComparable comparable, object obj)
		{
			return comparable.CompareTo(obj);
		}

		public SortableBindingListComparer(string str, ListSortDirection listSortDirection)
		{
			this.u200c‬‮‏⁯‬‍​‎‬‎‍‭‬⁮⁭‫‬‎⁯‎⁬‪‫‮‏‫⁭⁯⁮‬‬‍⁮‌⁪‎⁪​⁪‮ = SortableBindingListComparer<T>.u206a‪‪⁬‍‮⁫⁪‌⁯⁬⁮⁭‍‬‏‫‪‏⁭‭‬⁪‎‫⁭‌‌‭‮⁭⁫⁮‮‏​‮⁭‬‮(typeof(T).TypeHandle).u202c⁬‌⁮‫⁭‎‬‬⁫‌‫⁭⁯‭⁭⁯‌‫‫⁫‎​⁬⁫‎‫‌​‍⁯⁯‮⁮‎‌‏‏‫‫‮(str);
			this.u202b‭⁯‍‭​‮‍‍‍‭⁮‭‌⁭‬‬‍‎⁬⁮‏‎⁬⁮‭⁮​‫‮‮⁮‌‭‬⁪‎⁯​⁮‮ = listSortDirection;
		}

		public int Compare(T x, T y)
		{
			int num;
			IComparable comparable = (IComparable)SortableBindingListComparer<T>.u200d‮‬‫⁮⁭‮‏‭‏‮‬⁬⁭⁬‫‫‫⁯⁪‭‮‎‍⁯⁮‏⁭‎‬‫‏⁪‬‪⁭‫‍⁪‭‮(this.u200c‬‮‏⁯‬‍​‎‬‎‍‭‬⁮⁭‫‬‎⁯‎⁬‪‫‮‏‫⁭⁯⁮‬‬‍⁮‌⁪‎⁪​⁪‮, x, null);
			IComparable comparable1 = (IComparable)SortableBindingListComparer<T>.u200d‮‬‫⁮⁭‮‏‭‏‮‬⁬⁭⁬‫‫‫⁯⁪‭‮‎‍⁯⁮‏⁭‎‬‫‏⁪‬‪⁭‫‍⁪‭‮(this.u200c‬‮‏⁯‬‍​‎‬‎‍‭‬⁮⁭‫‬‎⁯‎⁬‪‫‮‏‫⁭⁯⁮‬‬‍⁮‌⁪‎⁪​⁪‮, y, null);
		Label1:
			int num1 = 977014197;
			while (true)
			{
				int num2 = num1 ^ 278165498;
				uint num3 = (uint)num2;
				switch (num2 % 4)
				{
					case 0:
					{
						break;
					}
					case 1:
					{
						return SortableBindingListComparer<T>.u206a‪⁪⁫‮⁯‭‪⁬⁫​‭⁭‌‪‎‬‭⁫⁮‮‏‫‭⁭‪⁪‍‎​​​⁮‎⁯‫⁪‍⁭‮‮(comparable1, comparable);
					}
					case 2:
					{
						goto Label1;
					}
					case 3:
					{
						num = (this.u202b‭⁯‍‭​‮‍‍‍‭⁮‭‌⁭‬‬‍‎⁬⁮‏‎⁬⁮‭⁮​‫‮‮⁮‌‭‬⁪‎⁯​⁮‮ != ListSortDirection.Ascending ? -1536200995 : -169199760);
						num1 = (int)(num ^ num3 * 1281553286);
						continue;
					}
					default:
					{
						return SortableBindingListComparer<T>.u206a‪⁪⁫‮⁯‭‪⁬⁫​‭⁭‌‪‎‬‭⁫⁮‮‏‫‭⁭‪⁪‍‎​​​⁮‎⁯‫⁪‍⁭‮‮(comparable1, comparable);
					}
				}
			}
			return SortableBindingListComparer<T>.u206a‪⁪⁫‮⁯‭‪⁬⁫​‭⁭‌‪‎‬‭⁫⁮‮‏‫‭⁭‪⁪‍‎​​​⁮‎⁯‫⁪‍⁭‮‮(comparable, comparable1);
			return SortableBindingListComparer<T>.u206a‪⁪⁫‮⁯‭‪⁬⁫​‭⁭‌‪‎‬‭⁫⁮‮‏‫‭⁭‪⁪‍‎​​​⁮‎⁯‫⁪‍⁭‮‮(comparable1, comparable);
		}
	}
}