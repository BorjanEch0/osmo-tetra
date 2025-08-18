using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace SDRSharp.Tetra
{
	public class SortableBindingList<T> : BindingList<T>
	{
		// ⁮‬⁪⁯‬⁯⁫⁫‌‍⁭⁪‭⁫‭⁫‌​⁯​‫⁭​‪‎‎​‬‏‪‬⁭‏‬‌‎‭​‪‏‮
		private bool u206e‬⁪⁯‬⁯⁫⁫‌‍⁭⁪‭⁫‭⁫‌​⁯​‫⁭​‪‎‎​‬‏‪‬⁭‏‬‌‎‭​‪‏‮;

		// ‌‬‮‏⁯‬‍​‎‬‎‍‭‬⁮⁭‫‬‎⁯‎⁬‪‫‮‏‫⁭⁯⁮‬‬‍⁮‌⁪‎⁪​⁪‮
		private PropertyDescriptor u200c‬‮‏⁯‬‍​‎‬‎‍‭‬⁮⁭‫‬‎⁯‎⁬‪‫‮‏‫⁭⁯⁮‬‬‍⁮‌⁪‎⁪​⁪‮;

		// ‫‭⁯‍‭​‮‍‍‍‭⁮‭‌⁭‬‬‍‎⁬⁮‏‎⁬⁮‭⁮​‫‮‮⁮‌‭‬⁪‎⁯​⁮‮
		private ListSortDirection u202b‭⁯‍‭​‮‍‍‍‭⁮‭‌⁭‬‬‍‎⁬⁮‏‎⁬⁮‭⁮​‫‮‮⁮‌‭‬⁪‎⁯​⁮‮;

		protected override bool IsSortedCore
		{
			get
			{
				return this.u206e‬⁪⁯‬⁯⁫⁫‌‍⁭⁪‭⁫‭⁫‌​⁯​‫⁭​‪‎‎​‬‏‪‬⁭‏‬‌‎‭​‪‏‮;
			}
		}

		protected override ListSortDirection SortDirectionCore
		{
			get
			{
				return this.u202b‭⁯‍‭​‮‍‍‍‭⁮‭‌⁭‬‬‍‎⁬⁮‏‎⁬⁮‭⁮​‫‮‮⁮‌‭‬⁪‎⁯​⁮‮;
			}
		}

		protected override PropertyDescriptor SortPropertyCore
		{
			get
			{
				return this.u200c‬‮‏⁯‬‍​‎‬‎‍‭‬⁮⁭‫‬‎⁯‎⁬‪‫‮‏‫⁭⁯⁮‬‬‍⁮‌⁪‎⁪​⁪‮;
			}
		}

		protected override bool SupportsSortingCore
		{
			get
			{
				return true;
			}
		}

		// ⁪​‏‭‪⁯‭​‎‎‌‌‬‏‌⁫‬‎⁭⁮‮​⁬‎⁪‫⁫‬‫‎​‬‭‮‭⁫⁮‏‍‎‮
		// privatescope
		internal static string u206a​‏‭‪⁯‭​‎‎‌‌‬‏‌⁫‬‎⁭⁮‮​⁬‎⁪‫⁫‬‫‎​‬‭‮‭⁫⁮‏‍‎‮(MemberDescriptor memberDescriptor)
		{
			return memberDescriptor.Name;
		}

		// ⁮‏⁯⁭‮⁬‏⁪‬‮‭⁪‪‎⁭⁬‏⁯‮‫‪‍‎⁮‬⁭⁭⁬‮‮‌‏‫‪‎‎⁯⁯‪‍‮
		// privatescope
		internal static ListChangedEventArgs u206e‏⁯⁭‮⁬‏⁪‬‮‭⁪‪‎⁭⁬‏⁯‮‫‪‍‎⁮‬⁭⁭⁬‮‮‌‏‫‪‎‎⁯⁯‪‍‮(ListChangedType listChangedType, int num)
		{
			return new ListChangedEventArgs(listChangedType, num);
		}

		public SortableBindingList()
		{
		}

		protected override void ApplySortCore(PropertyDescriptor property, ListSortDirection direction)
		{
			SortableBindingListComparer<T> sortableBindingListComparer = null;
			int num;
			List<T> items = (List<T>)base.Items;
		Label0:
			int num1 = 820608074;
			while (true)
			{
				int num2 = num1 ^ 2107925495;
				uint num3 = (uint)num2;
				switch (num2 % 10)
				{
					case 0:
					{
						goto Label0;
					}
					case 1:
					{
						items.Sort(sortableBindingListComparer);
						num1 = (int)(num3 * 423498523 ^ 97663685);
						continue;
					}
					case 2:
					{
						this.u206e‬⁪⁯‬⁯⁫⁫‌‍⁭⁪‭⁫‭⁫‌​⁯​‫⁭​‪‎‎​‬‏‪‬⁭‏‬‌‎‭​‪‏‮ = false;
						num1 = 1249899941;
						continue;
					}
					case 3:
					{
						this.u206e‬⁪⁯‬⁯⁫⁫‌‍⁭⁪‭⁫‭⁫‌​⁯​‫⁭​‪‎‎​‬‏‪‬⁭‏‬‌‎‭​‪‏‮ = true;
						num1 = (int)(num3 * 1957102310 ^ 291047540);
						continue;
					}
					case 4:
					{
						return;
					}
					case 5:
					{
						num1 = (int)(num3 * -958135502 ^ 442976271);
						continue;
					}
					case 6:
					{
						this.u200c‬‮‏⁯‬‍​‎‬‎‍‭‬⁮⁭‫‬‎⁯‎⁬‪‫‮‏‫⁭⁯⁮‬‬‍⁮‌⁪‎⁪​⁪‮ = property;
						this.u202b‭⁯‍‭​‮‍‍‍‭⁮‭‌⁭‬‬‍‎⁬⁮‏‎⁬⁮‭⁮​‫‮‮⁮‌‭‬⁪‎⁯​⁮‮ = direction;
						num1 = 15539620;
						continue;
					}
					case 7:
					{
						this.OnListChanged(SortableBindingList<T>.u206e‏⁯⁭‮⁬‏⁪‬‮‭⁪‪‎⁭⁬‏⁯‮‫‪‍‎⁮‬⁭⁭⁬‮‮‌‏‫‪‎‎⁯⁯‪‍‮(ListChangedType.Reset, -1));
						num1 = (int)(num3 * 1778610823 ^ -1680588526);
						continue;
					}
					case 8:
					{
						sortableBindingListComparer = new SortableBindingListComparer<T>(SortableBindingList<T>.u206a​‏‭‪⁯‭​‎‎‌‌‬‏‌⁫‬‎⁭⁮‮​⁬‎⁪‫⁫‬‫‎​‬‭‮‭⁫⁮‏‍‎‮(property), direction);
						num1 = (int)(num3 * -1823621733 ^ 31606116);
						continue;
					}
					case 9:
					{
						num = (items == null ? -509301320 : -333324658);
						num1 = (int)(num ^ num3 * -1443026121);
						continue;
					}
				}
			}
		}
	}
}