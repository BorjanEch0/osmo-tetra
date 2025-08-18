using SDRSharp.Common;
using SDRSharp.Radio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace SDRSharp.Tetra
{
	public class TetraPanel : UserControl
	{
		// ‌⁫⁯⁬‪‌‬‭‫‭​‪​⁯‮⁪‫⁫⁯⁪‏‌⁬⁮‬‌‬⁭‭⁮⁯‮‬⁮‏‫⁯​‭‏‮
		private IContainer u200c⁫⁯⁬‪‌‬‭‫‭​‪​⁯‮⁪‫⁫⁯⁪‏‌⁬⁮‬‌‬⁭‭⁮⁯‮‬⁮‏‫⁯​‭‏‮;

		// ‎⁫​‭⁪‫‏‬‮⁭⁬‌‏⁮⁮​‍‍‎‍‭‍‎​‪‪‭⁪‏‎⁬‎‍‫‮​⁬⁮⁯‫‮
		private Panel u200e⁫​‭⁪‫‏‬‮⁭⁬‌‏⁮⁮​‍‍‎‍‭‍‎​‪‪‭⁪‏‎⁬‎‍‫‮​⁬⁮⁯‫‮;

		// ‮⁪‍‍⁫⁪‪‍‌‏⁪⁪⁫⁪‎‮‭‌⁭‬‪⁮​‭⁯⁯‌‮⁪⁬‮⁬⁬​‮‏⁯⁯‌‏‮
		private System.Windows.Forms.Timer u202e⁪‍‍⁫⁪‪‍‌‏⁪⁪⁫⁪‎‮‭‌⁭‬‪⁮​‭⁯⁯‌‮⁪⁬‮⁬⁬​‮‏⁯⁯‌‏‮;

		// ‬⁭‎‫‮‌⁯⁮‍‎⁪⁪⁬‭⁮‏‎‌‌‎‌⁯‪‮⁯‌⁮‌‭⁯‎‍‌⁪‍‭‏⁪‬‮
		private CheckBox u202c⁭‎‫‮‌⁯⁮‍‎⁪⁪⁬‭⁮‏‎‌‌‎‌⁯‪‮⁯‌⁮‌‭⁯‎‍‌⁪‍‭‏⁪‬‮;

		// ‍‌‏‪‍‭⁯‎⁫⁪⁮⁮‍‮⁪⁫⁮⁬‎⁭⁫⁬‭‎⁯‪‍‏‌⁭⁯⁯‬‫‌‭⁮‬‭⁭‮
		private Display u200d‌‏‪‍‭⁯‎⁫⁪⁮⁮‍‮⁪⁫⁮⁬‎⁭⁫⁬‭‎⁯‪‍‏‌⁭⁯⁯‬‫‌‭⁮‬‭⁭‮;

		// ⁪⁭‫⁬⁯‌‎⁯‬‍​‏‎‌‏⁯‏⁮‬⁯⁮‎⁯⁬‌‪⁯⁬⁭⁬​‭​‌​‎⁫⁪‭‍‮
		private GroupBox u206a⁭‫⁬⁯‌‎⁯‬‍​‏‎‌‏⁯‏⁮‬⁯⁮‎⁯⁬‌‪⁯⁬⁭⁬​‭​‌​‎⁫⁪‭‍‮;

		// ⁪‎‪⁮​‮⁭‭⁪‎⁪‏‌‎‌‎⁮⁫‬‭‍⁭⁭‫‏⁫​‬‪⁪‮⁮‏‏⁭⁬‌⁪⁯‭‮
		private GroupBox u206a‎‪⁮​‮⁭‭⁪‎⁪‏‌‎‌‎⁮⁫‬‭‍⁭⁭‫‏⁫​‬‪⁪‮⁮‏‏⁭⁬‌⁪⁯‭‮;

		// ‍‮⁪⁭⁭‍⁯‮‭‏‏⁭‬‫⁮⁯‬⁫‬‪⁫‎⁭‭​⁫‪⁬⁮⁫‍⁭​⁭‌⁪​⁪‭⁯‮
		private GroupBox u200d‮⁪⁭⁭‍⁯‮‭‏‏⁭‬‫⁮⁯‬⁫‬‪⁫‎⁭‭​⁫‪⁬⁮⁫‍⁭​⁭‌⁪​⁪‭⁯‮;

		// ⁬‫‍⁯⁫⁬⁬‎‮‎‭‎⁭⁪‍‏⁯‬​⁪‪⁯⁪​⁪‪‫‏⁮‏‍⁮⁮‫​‭⁬⁪⁮‍‮
		private Label u206c‫‍⁯⁫⁬⁬‎‮‎‭‎⁭⁪‍‏⁯‬​⁪‪⁯⁪​⁪‪‫‏⁮‏‍⁮⁮‫​‭⁬⁪⁮‍‮;

		// ⁮⁬‬‭⁫‏⁪⁬⁬⁪⁬‏⁬⁯‍‌⁮‮⁪⁬‍⁭⁯⁮‭‌‏⁬⁭‍‎‌⁭​‬⁯‏⁮‌‍‮
		private System.Windows.Forms.Timer u206e⁬‬‭⁫‏⁪⁬⁬⁪⁬‏⁬⁯‍‌⁮‮⁪⁬‍⁭⁯⁮‭‌‏⁬⁭‍‎‌⁭​‬⁯‏⁮‌‍‮;

		// ​‏⁭⁯⁮⁬‭‮⁭⁯‮​‏‭⁬⁮‫⁬⁬‬‮‏‏‎‮⁫⁬⁭⁮​​⁮⁪⁭⁭​‫‫‮
		private RadioButton u200b‏⁭⁯⁮⁬‭‮⁭⁯‮​‏‭⁬⁮‫⁬⁬‬‮‏‏‎‮⁫⁬⁭⁮​​⁮⁪⁭⁭​‫‫‮;

		// ‮⁮‍‍⁮‎⁪⁫⁫‍‮‭‬‍⁪‪‮⁭‬⁫⁯‪⁯​⁪‬‫​⁬‭‭⁯‫‎⁮‏​​‬‎‮
		private RadioButton u202e⁮‍‍⁮‎⁪⁫⁫‍‮‭‬‍⁪‪‮⁭‬⁫⁯‪⁯​⁪‬‫​⁬‭‭⁯‫‎⁮‏​​‬‎‮;

		// ‏‫‮⁭⁭‬‌‪⁭‭‭‬⁮‪‮⁬⁬​⁮⁫‍⁮‍​⁮‫‪‮‎⁪⁬‎⁮⁭⁯⁯⁮‮‪⁭‮
		private RadioButton u200f‫‮⁭⁭‬‌‪⁭‭‭‬⁮‪‮⁬⁬​⁮⁫‍⁮‍​⁮‫‪‮‎⁪⁬‎⁮⁭⁯⁯⁮‮‪⁭‮;

		// ⁭‏‪‫‍⁪‪⁬‌⁪‌‪‭⁫‫‎‍⁯‎‬‭⁪⁯​⁪⁮‬​‌​‎‌⁪‭⁮‏‌‫‫⁯‮
		private RadioButton u206d‏‪‫‍⁪‪⁬‌⁪‌‪‭⁫‫‎‍⁯‎‬‭⁪⁯​⁪⁮‬​‌​‎‌⁪‭⁮‏‌‫‫⁯‮;

		// ‎‮⁯​⁬⁫‍⁭⁯⁪‪⁫‭⁯‬⁭‫‭⁭⁫‮⁮‏⁫‮‫‭‍‫​⁭‏⁮⁯‎‭⁯‫⁯⁮‮
		private Button u200e‮⁯​⁬⁫‍⁭⁯⁪‪⁫‭⁯‬⁭‫‭⁭⁫‮⁮‏⁫‮‫‭‍‫​⁭‏⁮⁯‎‭⁯‫⁯⁮‮;

		// ‎‎⁭‏‎‪‎‍‬⁭⁮⁬‍⁭‮​⁪‮‏‍⁪‎‫⁮‫⁭⁯⁪‌‌​‌⁬‫‏‬‍⁯⁮‭‮
		private CheckBox u200e‎⁭‏‎‪‎‍‬⁭⁮⁬‍⁭‮​⁪‮‏‍⁪‎‫⁮‫⁭⁯⁪‌‌​‌⁬‫‏‬‍⁯⁮‭‮;

		// ⁭‫⁭‮⁯​⁫‬‍‪‍⁬⁭⁭‍‎‬‮⁪‫‫‍‎⁫​⁪‪​‮⁬‌​‬‮⁪‬‮⁫⁬⁫‮
		private Label u206d‫⁭‮⁯​⁫‬‍‪‍⁬⁭⁭‍‎‬‮⁪‫‫‍‎⁫​⁪‪​‮⁬‌​‬‮⁪‬‮⁫⁬⁫‮;

		// ‫‫‭‪⁯⁯⁮‎⁫⁫⁮‫⁪⁯⁮⁭⁫‎‏⁮⁭‭⁪‌⁯⁪⁪‍⁯⁯‌⁫‪‮⁭‌⁪‎‬⁫‮
		private Label u202b‫‭‪⁯⁯⁮‎⁫⁫⁮‫⁪⁯⁮⁭⁫‎‏⁮⁭‭⁪‌⁯⁪⁪‍⁯⁯‌⁫‪‮⁭‌⁪‎‬⁫‮;

		// ⁪‮​‫‪‪⁬‫‏⁬⁯‫‏⁬‌​⁪‮​‌⁬‏‍‎‍‌⁬⁮⁫‍⁪⁭‎‭‌⁭⁫⁬‏⁮‮
		private Label u206a‮​‫‪‪⁬‫‏⁬⁯‫‏⁬‌​⁪‮​‌⁬‏‍‎‍‌⁬⁮⁫‍⁪⁭‎‭‌⁭⁫⁬‏⁮‮;

		// ⁬‍‍‌‬‪‮‪‮⁪‎⁬‍‭⁪‫‌‬‪⁫‫‫‫‪⁮‮‬⁮⁬⁪‫⁭‫‌⁪‮‪⁭⁭⁮‮
		private Label u206c‍‍‌‬‪‮‪‮⁪‎⁬‍‭⁪‫‌‬‪⁫‫‫‫‪⁮‮‬⁮⁬⁪‫⁭‫‌⁪‮‪⁭⁭⁮‮;

		// ⁭‪⁪‌⁭‌‫⁭‌⁪​‭⁫‎‪‭‌⁬‍‎‌‮‍‌‬‍‬⁬‏⁫‏‫‏‏‎‭‬‍‪⁫‮
		private Label u206d‪⁪‌⁭‌‫⁭‌⁪​‭⁫‎‪‭‌⁬‍‎‌‮‍‌‬‍‬⁬‏⁫‏‫‏‏‎‭‬‍‪⁫‮;

		// ‮⁬⁬​‫⁪‍‍‏‌‏‬‌⁫‮⁫⁮‏⁬‭‭⁬‏⁫⁪‬‎⁪⁪‪‪‏‫⁮‭‪⁭‬‎‪‮
		private Label u202e⁬⁬​‫⁪‍‍‏‌‏‬‌⁫‮⁫⁮‏⁬‭‭⁬‏⁫⁪‬‎⁪⁪‪‪‏‫⁮‭‪⁭‬‎‪‮;

		// ‪‌⁯‌⁮‍‎‏⁭‌‮‭‌‏‎⁬⁯⁭‌‎⁪‪⁪‎⁪‏⁯⁪⁯​‪⁭‭‫⁬​⁭⁯⁯⁬‮
		private Label u202a‌⁯‌⁮‍‎‏⁭‌‮‭‌‏‎⁬⁯⁭‌‎⁪‪⁪‎⁪‏⁯⁪⁯​‪⁭‭‫⁬​⁭⁯⁯⁬‮;

		// ‎​⁭⁯​‏‏‎‭⁮‍‮⁬‪‮‪⁮‫⁭‏‍⁬‍‎‏‪‫‪‮⁪‍⁫‮‍⁪‬‏‭‮‏‮
		private Label u200e​⁭⁯​‏‏‎‭⁮‍‮⁬‪‮‪⁮‫⁭‏‍⁬‍‎‏‪‫‪‮⁪‍⁫‮‍⁪‬‏‭‮‏‮;

		// ‍‌‎‪⁯⁯⁫‭‬‬‭‎​‍‮⁯‮‌‬‪‭​⁮⁭⁬‏‏‫⁪‏⁭⁬‏⁮⁮‬⁯‏‭‍‮
		private Label u200d‌‎‪⁯⁯⁫‭‬‬‭‎​‍‮⁯‮‌‬‪‭​⁮⁭⁬‏‏‫⁪‏⁭⁬‏⁮⁮‬⁯‏‭‍‮;

		// ‌⁭‫‪⁮⁪⁬‭⁬⁮‌⁬⁭‌‍‎⁫‮‭‍⁮‬‮⁫‫⁮⁬‮‬⁬‭⁯⁫‍‪⁪⁯‏​⁭‮
		private Label u200c⁭‫‪⁮⁪⁬‭⁬⁮‌⁬⁭‌‍‎⁫‮‭‍⁮‬‮⁫‫⁮⁬‮‬⁬‭⁯⁫‍‪⁪⁯‏​⁭‮;

		// ‮‭‭‮​⁬⁯‎⁫​‬‏‌⁮⁮‮⁮⁬⁭‮⁯⁯‏‬‎​‎‍‏⁭⁮‏‬‫⁪‍‬‫‪‬‮
		private Button u202e‭‭‮​⁬⁯‎⁫​‬‏‌⁮⁮‮⁮⁬⁭‮⁯⁯‏‬‎​‎‍‏⁭⁮‏‬‫⁪‍‬‫‪‬‮;

		// ‏‏⁪‪⁪‪⁯‪‌⁬‎‪‬‫⁯‭‬‌⁯‏⁮⁫‪⁯‬⁪⁭⁭‪‪‌‍‭‎⁭⁫⁯⁯​‏‮
		private Label u200f‏⁪‪⁪‪⁯‪‌⁬‎‪‬‫⁯‭‬‌⁯‏⁮⁫‪⁯‬⁪⁭⁭‪‪‌‍‭‎⁭⁫⁯⁯​‏‮;

		// ‪‪‌⁫⁫‭⁬⁭⁫⁯⁮‪​‮⁮‮‍‌⁪⁬‭‮‬‬⁮‫‪‫‮‍‮​‏‌‍‌​​‬‪‮
		private Label u202a‪‌⁫⁫‭⁬⁭⁫⁯⁮‪​‮⁮‮‍‌⁪⁬‭‮‬‬⁮‫‪‫‮‍‮​‏‌‍‌​​‬‪‮;

		// ⁯⁯⁭‫‍⁪‬‭⁮‪⁯⁭‮‌‭‪‏⁯‫‪‎‪⁯⁫⁪‌‭‪‌‫⁮‭⁪‍‏‌‪‬‏‫‮
		private Label u206f⁯⁭‫‍⁪‬‭⁮‪⁯⁭‮‌‭‪‏⁯‫‪‎‪⁯⁫⁪‌‭‪‌‫⁮‭⁪‍‏‌‪‬‏‫‮;

		// ‪‎‎‭⁭⁬‎⁬‏⁫⁬⁯‫‎‬‪‏⁬‪‬‭‌‪‌‎⁯‪‪‫​‪​⁮‫‭‌⁮​⁪⁬‮
		private Label u202a‎‎‭⁭⁬‎⁬‏⁫⁬⁯‫‎‬‪‏⁬‪‬‭‌‪‌‎⁯‪‪‫​‪​⁮‫‭‌⁮​⁪⁬‮;

		// ⁬‮⁫⁫⁭⁬‍‮​‮⁭⁭⁭⁭⁪‪‪⁬‬⁫⁮‌​‎⁬‭‫‏‏⁮‍‍​⁯‎⁬‪⁬‏⁫‮
		private Label u206c‮⁫⁫⁭⁬‍‮​‮⁭⁭⁭⁭⁪‪‪⁬‬⁫⁮‌​‎⁬‭‫‏‏⁮‍‍​⁯‎⁬‪⁬‏⁫‮;

		// ‪⁫⁫⁪‎⁯⁭‬‬⁬​‮‍⁭‮‌⁭‌‏‎‭‫‌‏‏⁫⁬‮⁬‌⁭​⁫⁯‫⁮⁭‬‏‏‮
		private Label u202a⁫⁫⁪‎⁯⁭‬‬⁬​‮‍⁭‮‌⁭‌‏‎‭‫‌‏‏⁫⁬‮⁬‌⁭​⁫⁯‫⁮⁭‬‏‏‮;

		// ‫‫‌‍⁭‎‮⁮‍‮‎‏⁮‭‌⁭⁫‮⁮‭‎‏⁮⁮‌‌‫‬‪⁬⁬‏‌‭‌‫‌‭‭⁭‮
		private NumericUpDown u202b‫‌‍⁭‎‮⁮‍‮‎‏⁮‭‌⁭⁫‮⁮‭‎‏⁮⁮‌‌‫‬‪⁬⁬‏‌‭‌‫‌‭‭⁭‮;

		// ⁮‬‮​⁮‌⁭​‍‍⁪‌‏‭‬‏‎⁪⁬‫‬⁬⁪‍‌‪​‭⁬⁫⁬‪‭⁬⁪​⁪⁪​⁪‮
		private Label u206e‬‮​⁮‌⁭​‍‍⁪‌‏‭‬‏‎⁪⁬‫‬⁬⁪‍‌‪​‭⁬⁫⁬‪‭⁬⁪​⁪⁪​⁪‮;

		// ‫⁭‎‭‭‏⁮⁮‮‮‍⁫⁫‎‏‏‌‬‏‬‭‮‪‌⁪‎‏⁫‫‬‬‏‎⁫⁬⁯‌⁭⁪‪‮
		private Label u202b⁭‎‭‭‏⁮⁮‮‮‍⁫⁫‎‏‏‌‬‏‬‭‮‪‌⁪‎‏⁫‫‬‬‏‎⁫⁬⁯‌⁭⁪‪‮;

		// ‏‏⁯‭‌⁫‌‏⁪‫‬‎‫⁫‮‫‎‬‭‪⁪‫⁮‫‍‎‎⁪⁭⁬⁯⁪‬‎‮⁫⁪‎‭‌‮
		private Label u200f‏⁯‭‌⁫‌‏⁪‫‬‎‫⁫‮‫‎‬‭‪⁪‫⁮‫‍‎‎⁪⁭⁬⁯⁪‬‎‮⁫⁪‎‭‌‮;

		// ‍⁪‮‬⁭​​⁫⁪⁯⁫‬‏⁮⁭​‭‬‏‏⁭⁯‫‌‮‎⁫⁫‏‮⁮⁬⁫‮⁮⁪⁯‭‎‫‮
		private Label u200d⁪‮‬⁭​​⁫⁪⁯⁫‬‏⁮⁭​‭‬‏‏⁭⁯‫‌‮‎⁫⁫‏‮⁮⁬⁫‮⁮⁪⁯‭‎‫‮;

		// ‮⁭​⁬‎​⁬⁮​⁬‬‫‎⁫‬‌​⁬⁪⁮​⁫⁬⁫⁪‎‍⁭⁭‬‬‪‎‍‬⁪‍‍​‍‮
		private LinkLabel u202e⁭​⁬‎​⁬⁮​⁬‬‫‎⁫‬‌​⁬⁪⁮​⁫⁬⁫⁪‎‍⁭⁭‬‬‪‎‍‬⁪‍‍​‍‮;

		// ⁫⁭‍‏⁮‪‎‪‎⁬‌⁪⁬⁯‎‬⁫⁬‭⁪⁯‍⁭⁮‪‍⁬‬⁭‮‭⁯​‏‪⁮​​‎⁭‮
		private Label u206b⁭‍‏⁮‪‎‪‎⁬‌⁪⁬⁯‎‬⁫⁬‭⁪⁯‍⁭⁮‪‍⁬‬⁭‮‭⁯​‏‪⁮​​‎⁭‮;

		// ‍‎‫‎‪​‍‏‍⁯‫⁬⁮‌‫⁭‏​​‏⁫‬⁬‎‭‍⁫‌⁬‬⁬‬⁬‏‎⁮​‬⁫⁪‮
		private System.Windows.Forms.Timer u200d‎‫‎‪​‍‏‍⁯‫⁬⁮‌‫⁭‏​​‏⁫‬⁬‎‭‍⁫‌⁬‬⁬‬⁬‏‎⁮​‬⁫⁪‮;

		// ‮‪⁬⁫⁬⁭‪‏‌‏‫‫⁬⁭‌‭‮⁭⁭‬‪⁭⁭‬‌‮⁮⁭⁫‌‬⁯⁫‪‭‎‭‎‍⁫‮
		private Label u202e‪⁬⁫⁬⁭‪‏‌‏‫‫⁬⁭‌‭‮⁭⁭‬‪⁭⁭‬‌‮⁮⁭⁫‌‬⁯⁫‪‭‎‭‎‍⁫‮;

		// ‌‫‌‪‌‌‏​⁯⁪​‫⁪⁮⁯‫‍⁪⁫⁪‮⁬⁬‭⁯‌‫⁯‫‪‏‭‏⁭⁬‌‫‬⁪⁬‮
		private Label u200c‫‌‪‌‌‏​⁯⁪​‫⁪⁮⁯‫‍⁪⁫⁪‮⁬⁬‭⁯‌‫⁯‫‪‏‭‏⁭⁬‌‫‬⁪⁬‮;

		// ‪‪‬⁭‮⁬⁫‫⁬‮‏‪‪‭‎‌‫‪‍⁭‏⁮⁬‭⁪⁯‍‍⁭‪‏‫‮​⁪⁭⁪‪‬‮
		private Label u202a‪‬⁭‮⁬⁫‫⁬‮‏‪‪‭‎‌‫‪‍⁭‏⁮⁬‭⁪⁯‍‍⁭‪‏‫‮​⁪⁭⁪‪‬‮;

		// ‫⁪⁭‍‎⁭‮⁮‭⁮⁪‬⁯⁭‎‌⁫‮‮⁪‍⁯‎‍‫⁫‪‪‎‪‬‍‎‮‍⁭‍⁭‎⁬‮
		private Label u202b⁪⁭‍‎⁭‮⁮‭⁮⁪‬⁯⁭‎‌⁫‮‮⁪‍⁯‎‍‫⁫‪‪‎‪‬‍‎‮‍⁭‍⁭‎⁬‮;

		// ⁪⁯‏⁯​‫‬⁬‌⁮​⁯‬‌‭⁯‪⁬⁯⁮‌‫⁫⁫‍‎‎⁫⁮‫‍‍‪​‮‍‮‭⁬‏‮
		private NumericUpDown u206a⁯‏⁯​‫‬⁬‌⁮​⁯‬‌‭⁯‪⁬⁯⁮‌‫⁫⁫‍‎‎⁫⁮‫‍‍‪​‮‍‮‭⁬‏‮;

		// ‏‍‮‏‌‏‌‍‍⁪⁫⁯⁭‫⁮⁫‫⁯‏‫⁪‍‫⁮‮⁪⁫‍‭‍⁫‏‍⁫‍‌⁪⁫⁪⁭‮
		private NumericUpDown u200f‍‮‏‌‏‌‍‍⁪⁫⁯⁭‫⁮⁫‫⁯‏‫⁪‍‫⁮‮⁪⁫‍‭‍⁫‏‍⁫‍‌⁪⁫⁪⁭‮;

		// ‪‪⁮​‏‫‮‫⁭⁯⁭‬⁯‎‭​‎⁬‭⁬‬‬‬‌⁪‍⁪​‎‍⁯​‍⁯⁫‎‍⁪‎‭‮
		private NumericUpDown u202a‪⁮​‏‫‮‫⁭⁯⁭‬⁯‎‭​‎⁬‭⁬‬‬‬‌⁪‍⁪​‎‍⁯​‍⁯⁫‎‍⁪‎‭‮;

		// ⁮‬​⁯⁫‍‎​‮⁬⁮‍‫‪‬‌‌‭⁯⁫‮‫‮⁭‮‫‪‫⁮‫⁪‏‏‏‫‏‭⁬⁬‍‮
		private CheckBox u206e‬​⁯⁫‍‎​‮⁬⁮‍‫‪‬‌‌‭⁯⁫‮‫‮⁭‮‫‪‫⁮‫⁪‏‏‏‫‏‭⁬⁬‍‮;

		// ⁮​‏‫⁮‏⁯​‬‭⁯‮‪⁭‭⁮​‭⁯⁯‮‎‏​‌‮​⁫‬‍‎‏‭⁯‎‏‬⁫⁭‏‮
		private System.Windows.Forms.Timer u206e​‏‫⁮‏⁯​‬‭⁯‮‪⁭‭⁮​‭⁯⁯‮‎‏​‌‮​⁫‬‍‎‏‭⁯‎‏‬⁫⁭‏‮;

		// ‏⁫⁭⁬​‮‫‭‪‬‏⁯‭‎‭⁫‌⁬⁮‭‮‌‮⁫⁫‭‎‪‎‎​⁫‎⁮⁭⁯⁫‌‮‫‮
		private Label u200f⁫⁭⁬​‮‫‭‪‬‏⁯‭‎‭⁫‌⁬⁮‭‮‌‮⁫⁫‭‎‪‎‎​⁫‎⁮⁭⁯⁫‌‮‫‮;

		// ‌‎‏⁪⁭⁬⁫‎⁭‪⁫⁫‮​⁯‫‪‏‮‮‬‬⁬‍⁭⁯‪⁪⁫⁬‬⁫‬‍⁮‍⁭‪‭⁪‮
		private Label u200c‎‏⁪⁭⁬⁫‎⁭‪⁫⁫‮​⁯‫‪‏‮‮‬‬⁬‍⁭⁯‪⁪⁫⁬‬⁫‬‍⁮‍⁭‪‭⁪‮;

		// ‍‭‍‭⁪‬⁭‎⁬‍‬⁭‍‍‌⁬⁫‍‬‫‏⁯⁭‍⁮‎⁪⁪⁫⁬⁯‭‏⁪‮‫‭⁯⁪⁪‮
		private ToolTip u200d‭‍‭⁪‬⁭‎⁬‍‬⁭‍‍‌⁬⁫‍‬‫‏⁯⁭‍⁮‎⁪⁪⁫⁬⁯‭‏⁪‮‫‭⁯⁪⁪‮;

		// ‌‎‎‪‎‮‎⁫‭‪⁯⁬⁪⁬‏‮‏‪‫‏⁯⁪​⁬‫⁯⁪‎‪‏‫‮⁯‏‪‭‬‏‪‮
		private Label u200c‎‎‪‎‮‎⁫‭‪⁯⁬⁪⁬‏‮‏‪‫‏⁯⁪​⁬‫⁯⁪‎‪‏‫‮⁯‏‪‭‬‏‪‮;

		// ⁮⁭‫‬‫⁪‭‍‏⁫⁭​​‏‌‭⁭⁫‏⁮⁪‏‎‫⁯‭⁯‍⁮​‫‫⁪⁮⁫‎‬‫‌⁯‮
		private System.Windows.Forms.Timer u206e⁭‫‬‫⁪‭‍‏⁫⁭​​‏‌‭⁭⁫‏⁮⁪‏‎‫⁯‭⁯‍⁮​‫‫⁪⁮⁫‎‬‫‌⁯‮;

		// ‌‍‍⁮⁯⁭⁬‪⁮‍‭‍‍​​⁮⁮​‭‭⁮‫⁮‌‫⁭​‍‫‌‬⁫‏‏⁯‪⁭⁮‫⁭‮
		private const float u200c‍‍⁮⁯⁭⁬‪⁮‍‭‍‍​​⁮⁮​‭‭⁮‫⁮‌‫⁭​‍‫‌‬⁫‏‏⁯‪⁭⁮‫⁭‮ = 6.2831855f;

		// ‬‮⁬‏‮⁪‬‎⁯‎⁭‏⁭‭‭⁫⁪‎‫⁬​⁭⁪⁭‪‬‍⁬‮‏‎‮‍‮⁪⁯‮‬‭‍‮
		private const float u202c‮⁬‏‮⁪‬‎⁯‎⁭‏⁭‭‭⁫⁪‎‫⁬​⁭⁪⁭‪‬‍⁬‮‏‎‮‍‮⁪⁯‮‬‭‍‮ = 3.1415927f;

		// ‏⁬⁫​​‏‎⁪‍‏​‍‪⁯⁭​⁪‮‎⁪‭‌‎⁬‏‏‎‍‪⁯⁬⁪​⁯‬‬⁬​‍‍‮
		private const float u200f⁬⁫​​‏‎⁪‍‏​‍‪⁯⁭​⁪‮‎⁪‭‌‎⁬‏‏‎‍‪⁯⁬⁪​⁯‬‬⁬​‍‍‮ = 1.5707964f;

		// ⁬‍‎‫⁬‪‏​‫⁬‫⁫‏‪⁭⁭⁯‌⁭‫⁬‌⁬⁬‍​⁬‌‪‏‏​⁪‮‏‫‭‎‬⁪‮
		private const float u206c‍‎‫⁬‪‏​‫⁬‫⁫‏‪⁭⁭⁯‌⁭‫⁬‌⁬⁬‍​⁬‌‪‏‏​⁪‮‏‫‭‎‬⁪‮ = 0.7853982f;

		// ‮‌⁯​‎‏‌⁬​⁬‬‫‭‌‬‍‪‍⁫‎⁭​⁬‏‎‌⁪⁪⁭‮⁬⁮‌‏‍‌‮⁯⁮‮
		private const float u202e‌⁯​‎‏‌⁬​⁬‬‫‭‌‬‍‪‍⁫‎⁭​⁬‏‎‌⁪⁪⁭‮⁬⁮‌‏‍‌‮⁯⁮‮ = 9.536743E-07f;

		// ⁪⁬‏⁯‎⁪‏⁪⁭‫‬​⁯‫‌⁬⁯⁬‫‫‏‭‎⁭⁫‭⁪⁪‪‌‬⁭‬​‎‭⁪‍⁬⁪‮
		private const int u206a⁬‏⁯‎⁪‏⁪⁭‫‬​⁯‫‌⁬⁯⁬‫‫‏‭‎⁭⁫‭⁪⁪‪‌‬⁭‬​‎‭⁪‍⁬⁪‮ = 510;

		// ​‍⁮‎‭⁫⁮⁮⁬⁮​‬⁫⁭‬⁮‎‪‬⁭‫‎‫⁭⁭⁮‮‍‌⁮‬‌‫‭⁫⁮⁮⁬‮‍‮
		private const int u200b‍⁮‎‭⁫⁮⁮⁬⁮​‬⁫⁭‬⁮‎‪‬⁭‫‎‫⁭⁭⁮‮‍‌⁮‬‌‫‭⁫⁮⁮⁬‮‍‮ = 255;

		// ⁮‍⁮⁭⁪‌‭​‌​‬‌⁮‫‎⁮⁬‫⁯‭‍⁫‭‬‫‌‫‬⁮⁬⁭‪⁭⁪‫‍​⁫‍‪‮
		private const int u206e‍⁮⁭⁪‌‭​‌​‬‌⁮‫‎⁮⁬‫⁯‭‍⁫‭‬‫‌‫‬⁮⁬⁭‪⁭⁪‫‍​⁫‍‪‮ = 27;

		// ⁫⁯⁫⁪⁫‪⁯‪⁫‭⁮⁬‭‌‏⁪‫⁫⁮‮‏⁫⁯‌‫​‭⁯⁯‍‍⁪‬⁫‎⁮‎⁯⁯⁫‮
		private const int u206b⁯⁫⁪⁫‪⁯‪⁫‭⁮⁬‭‌‏⁪‫⁫⁮‮‏⁫⁯‌‫​‭⁯⁯‍‍⁪‬⁫‎⁮‎⁯⁯⁫‮ = 4096;

		// ⁮‫‏⁮⁮‌⁬‎‭‭⁮⁫‬‌‭⁮⁬⁫⁪‪‪‌‪‫‍‬⁫⁯‪⁬‏‮‏​‍⁯‏‭‪⁪‮
		private const int u206e‫‏⁮⁮‌⁬‎‭‭⁮⁫‬‌‭⁮⁬⁫⁪‪‪‌‪‫‍‬⁫⁯‪⁬‏‮‏​‍⁯‏‭‪⁪‮ = 90;

		// ‪⁬‮⁬‬‮‏⁬‏⁯⁬​⁮​‌‫‍⁯‌⁬⁫‪⁬‬⁪⁪‫⁫⁭‎‍‫‫‬‮‬⁫⁯⁫‌‮
		private ISharpControl u202a⁬‮⁬‬‮‏⁬‏⁯⁬​⁮​‌‫‍⁯‌⁬⁫‪⁬‬⁪⁪‫⁫⁭‎‍‫‫‬‮‬⁫⁯⁫‌‮;

		// ‌‭‫⁮‪‭‮‍‏‎⁮​‫‬‫‮⁪⁭‏⁯⁪⁮⁭⁪‫​‏‮‌‪‬‫‭‬⁫‬‮‫‭⁯‮
		private IFProcessor u200c‭‫⁮‪‭‮‍‏‎⁮​‫‬‫‮⁪⁭‏⁯⁪⁮⁭⁪‫​‏‮‌‪‬‫‭‬⁫‬‮‫‭⁯‮;

		// ⁪‏‏‍‎⁫‫‍‮‌⁫​‪‫‍‫⁭‮‫‎‫‌⁫‬​‫‪⁫‭‪‫‭⁬⁫‎‭⁮⁮⁮‮
		private u200c⁯⁯⁬‮‌‎⁫‌⁯‍‭⁮⁫‍‫‎‬‪⁮⁭‌⁮‭⁪⁬‌⁯⁯‮‫‪⁮‎‎⁯‍‭‏‌‮ u206a‏‏‍‎⁫‫‍‮‌⁫​‪‫‍‫⁭‮‫‎‫‌⁫‬​‫‪⁫‭‪‫‭⁬⁫‎‭⁮⁮⁮‮;

		// ⁬‪‌‭‏⁯​‫⁫⁫‬‫‍‪⁯‫‏‫⁪⁯⁫​‮‍‫‭‎‍‏‪‎⁬⁭‬​⁭​‎⁫⁪‮
		private u202a‍‎‎‪‍⁬⁭‬‌‎⁬‎‭‪‬‬​⁭⁬⁮‏‏‪‏‏‏‬⁬‭⁫​‎‎‭‎​‎‬⁬‮ u206c‪‌‭‏⁯​‫⁫⁫‬‫‍‪⁯‫‏‫⁪⁯⁫​‮‍‫‭‎‍‏‪‎⁬⁭‬​⁭​‎⁫⁪‮;

		// ⁭‫‏‎‭‭⁮‭‮‌⁮‮‍‎⁬⁮‍⁯​⁯⁮⁮‬⁪‍‎⁫⁮⁫‭‏‌⁮⁯‍⁫⁫‬‮⁮‮
		private Thread u206d‫‏‎‭‭⁮‭‮‌⁮‮‍‎⁬⁮‍⁯​⁯⁮⁮‬⁪‍‎⁫⁮⁫‭‏‌⁮⁯‍⁫⁫‬‮⁮‮;

		// ⁪‌‭‪‍‪⁯⁯⁫‭​‪⁭⁮‫⁮⁬⁮‌⁭⁭‎‎⁭‌‏⁭⁯⁫‎‎⁯‍‫⁮⁯‮‎‬⁬‮
		private u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮ u206a‌‭‪‍‪⁯⁯⁫‭​‪⁭⁮‫⁮⁬⁮‌⁭⁭‎‎⁭‌‏⁭⁯⁫‎‎⁯‍‫⁮⁯‮‎‬⁬‮;

		// ‌‫‏‫⁫‍⁪⁫⁬‭‭​⁭‏‌⁯⁭⁯‎⁯‬⁯‮​​‭‏‎⁫⁯‍⁬⁪‪‎‬⁯‌‏‮‮
		private u206b‭⁯​​⁬‫‍⁮‌‌‪⁫⁭‮⁪‫‪‬‭‫⁫⁭⁮‭‎⁮‭⁪‎⁪⁪⁭‏‬⁯⁮‮‌‪‮ u200c‫‏‫⁫‍⁪⁫⁬‭‭​⁭‏‌⁯⁭⁯‎⁯‬⁯‮​​‭‏‎⁫⁯‍⁬⁪‪‎‬⁯‌‏‮‮;

		// ⁮‪‭‎⁫‌‎‍⁬⁮‏‬​‬​⁮⁯​‎⁮‌‮‬‌‍‭⁫⁮​‎‎‏‪⁮⁬‭‌‌‎⁯‮
		private ComplexFifoStream u206e‪‭‎⁫‌‎‍⁬⁮‏‬​‬​⁮⁯​‎⁮‌‮‬‌‍‭⁫⁮​‎‎‏‪⁮⁬‭‌‌‎⁯‮;

		// ​⁭‎‪‫​‫‫⁬‮⁭‭​⁮⁫‎‌‮‫⁫‬​‎‌⁪‫‎⁯⁯⁭‭‏⁭‭‮⁭⁯‍‪‮
		private UnsafeBuffer u200b⁭‎‪‫​‫‫⁬‮⁭‭​⁮⁫‎‌‮‫⁫‬​‎‌⁪‫‎⁯⁯⁭‭‏⁭‭‮⁭⁯‍‪‮;

		// ‭⁭⁮‭‏‫‭‎​‭‌⁪‬‬‭‪⁭‍​⁬‪⁪‮‌‎⁬‪‪‮⁮‏‎‍⁫⁮‬⁭‭⁮‬‮
		private unsafe float* u202d⁭⁮‭‏‫‭‎​‭‌⁪‬‬‭‪⁭‍​⁬‪⁪‮‌‎⁬‪‪‮⁮‏‎‍⁫⁮‬⁭‭⁮‬‮;

		// ⁪‏⁮‪⁬‪⁯‫​‭‬‪‬⁯​‎‌⁬⁭‍‬‭‪‮​‌‌⁭⁫‫​‏‏⁬⁮‎​‬‏‏‮
		private UnsafeBuffer u206a‏⁮‪⁬‪⁯‫​‭‬‪‬⁯​‎‌⁬⁭‍‬‭‪‮​‌‌⁭⁫‫​‏‏⁬⁮‎​‬‏‏‮;

		// ‪‍‌⁮⁮‫⁪⁫‪‌‫‌‌⁮⁬⁪‫‎⁫‍⁬‭‎‌‫‮⁪‎‬⁬‭‎‫​⁮​​⁬‌‭‮
		private unsafe float* u202a‍‌⁮⁮‫⁪⁫‪‌‫‌‌⁮⁬⁪‫‎⁫‍⁬‭‎‌‫‮⁪‎‬⁬‭‎‫​⁮​​⁬‌‭‮;

		// ‪‫‭⁫‌‪⁬⁮‏‌‌‬‫​‌⁫⁬‫‍⁬‭‪‌⁮‪‭⁯⁮⁫​⁮⁯‭⁭⁪‬‪‮‪‎‮
		private UnsafeBuffer u202a‫‭⁫‌‪⁬⁮‏‌‌‬‫​‌⁫⁬‫‍⁬‭‪‌⁮‪‭⁯⁮⁫​⁮⁯‭⁭⁪‬‪‮‪‎‮;

		// ‎⁬‏‭​⁪​⁬⁯​‬‏‫⁭‌‫‎‏‏‬‏‏⁯⁯⁪​‏⁪⁬‭‏‍⁪‪⁬⁪⁪⁪⁪⁭‮
		private unsafe float* u200e⁬‏‭​⁪​⁬⁯​‬‏‫⁭‌‫‎‏‏‬‏‏⁯⁯⁪​‏⁪⁬‭‏‍⁪‪⁬⁪⁪⁪⁪⁭‮;

		// ⁮‍⁫‬⁪​‌‪⁮⁪‎⁯‏‍‍‎‪‬‏‬⁫⁯⁫⁯‍‮‫⁬‫⁫⁯⁬‪‬‌​‌⁫⁬⁭‮
		private Resampler u206e‍⁫‬⁪​‌‪⁮⁪‎⁯‏‍‍‎‪‬‏‬⁫⁯⁫⁯‍‮‫⁬‫⁫⁯⁬‪‬‌​‌⁫⁬⁭‮;

		// ‬⁯⁯‏⁫‭‪‍‎⁫⁫‎⁯⁭‮‪⁪‌⁫‫⁭‎‪‌‎⁮‮⁬⁪⁯‪⁬‌‮‫⁫‏⁪‪‮‮
		private FloatFifoStream u202c⁯⁯‏⁫‭‪‍‎⁫⁫‎⁯⁭‮‪⁪‌⁫‫⁭‎‪‌‎⁮‮⁬⁪⁯‪⁬‌‮‫⁫‏⁪‪‮‮;

		// ⁬⁫‭⁫‌‭‏⁯⁮‭‍‪‌⁬​‌‪‎⁯‏​⁭‌⁫⁯⁪⁮⁯⁬‌‫‍⁭‎‪​⁬​⁪‭‮
		private double u206c⁫‭⁫‌‭‏⁯⁮‭‍‪‌⁬​‌‪‎⁯‏​⁭‌⁫⁯⁪⁮⁯⁬‌‫‍⁭‎‪​⁬​⁪‭‮;

		// ⁮⁪‎‮‫‎‌⁪‏‪‫‌‏‮⁫⁯‌‪‍‪‪‍⁭‬⁮‮⁬⁪‌⁫‌⁯‪⁭‏‎‫‪⁯‭‮
		private Thread u206e⁪‎‮‫‎‌⁪‏‪‫‌‏‮⁫⁯‌‪‍‪‪‍⁭‬⁮‮⁬⁪‌⁫‌⁯‪⁭‏‎‫‪⁯‭‮;

		// ⁬‍‪‍‌‏⁯‬⁪‪​⁪⁮⁮⁫‎⁪⁯​‪⁭‍⁭‌‮‍⁬⁬‮‫‪⁯⁫‮‎‮‍‎⁭‮
		private bool u206c‍‪‍‌‏⁯‬⁪‪​⁪⁮⁮⁫‎⁪⁯​‪⁭‍⁭‌‮‍⁬⁬‮‫‪⁯⁫‮‎‮‍‎⁭‮;

		// ‍⁭⁬⁭‫⁪⁮‏‏‌⁬⁮‮‎‎⁪‮‬⁪⁫⁫‬‍⁯⁯⁭‮⁪‌‮‬​‬​‮⁮⁬‭‮‏‮
		private double u200d⁭⁬⁭‫⁪⁮‏‏‌⁬⁮‮‎‎⁪‮‬⁪⁫⁫‬‍⁯⁯⁭‮⁪‌‮‬​‬​‮⁮⁬‭‮‏‮;

		// ⁮⁮⁫‏‪⁮⁪‏‭‬​⁯⁫‍⁬‬⁮⁭​‌‏‍⁫​⁪⁮⁭‮⁮‭⁮⁭​​‍‌⁭‬‌⁬‮
		private bool u206e⁮⁫‏‪⁮⁪‏‭‬​⁯⁫‍⁬‬⁮⁭​‌‏‍⁫​⁪⁮⁭‮⁮‭⁮⁭​​‍‌⁭‬‌⁬‮;

		// ⁬⁮⁯‌​⁭‎​⁯​‪‬⁫​‮‬‎⁯⁭⁪⁪⁫‏⁮‫‭⁪⁭⁬⁪⁭⁫⁪⁫‭⁫⁮‪⁯‍‮
		private int u206c⁮⁯‌​⁭‎​⁯​‪‬⁫​‮‬‎⁯⁭⁪⁪⁫‏⁮‫‭⁪⁭⁬⁪⁭⁫⁪⁫‭⁫⁮‪⁯‍‮;

		// ‪⁯‭⁫​⁯⁮⁯‬​‫‌​⁯⁮‬‬⁭⁪⁯⁫⁯⁬⁫‮⁪⁯‌‭‏⁭‌‬​‏‏‍⁫⁭⁪‮
		private bool u202a⁯‭⁫​⁯⁮⁯‬​‫‌​⁯⁮‬‬⁭⁪⁯⁫⁯⁬⁫‮⁪⁯‌‭‏⁭‌‬​‏‏‍⁫⁭⁪‮;

		// ‍‫⁪‭‏‮⁮‮‪⁭⁫​‍‫⁬​‏‍⁫‭⁫‭‪‫⁪‌⁪​⁪⁭‎‏‮‭‌⁬⁫‏‮‮
		private UnsafeBuffer u200d‫⁪‭‏‮⁮‮‪⁭⁫​‍‫⁬​‏‍⁫‭⁫‭‪‫⁪‌⁪​⁪⁭‎‏‮‭‌⁬⁫‏‮‮;

		// ⁯⁪‌​⁮‌‫‪⁮⁫⁭‍‍⁭‮‏‌‬‫‬‬⁮​‏​⁭​⁮‭‮‌‬‏​​⁮​⁪⁯‭‮
		private unsafe byte* u206f⁪‌​⁮‌‫‪⁮⁫⁭‍‍⁭‮‏‌‬‫‬‬⁮​‏​⁭​⁮‭‮‌‬‏​​⁮​⁪⁯‭‮;

		// ⁫⁫​‬⁫‏‪‏‍‏‍​⁪⁯‌‭‭‍‪‮⁮⁯⁬‎‮‎⁪⁭‮​⁭‍‪⁪‮⁮​⁭⁯‫‮
		private UnsafeBuffer u206b⁫​‬⁫‏‪‏‍‏‍​⁪⁯‌‭‭‍‪‮⁮⁯⁬‎‮‎⁪⁭‮​⁭‍‪⁪‮⁮​⁭⁯‫‮;

		// ‏⁯‬‮⁫‪‬‪‮‍⁮⁮⁭⁯⁫‬‪⁮⁭‍⁮⁮‏‬⁬‏‭‫⁯⁯‎‏⁪‬‬‬‮⁮‎‏‮
		private unsafe float* u200f⁯‬‮⁫‪‬‪‮‍⁮⁮⁭⁯⁫‬‪⁮⁭‍⁮⁮‏‬⁬‏‭‫⁯⁯‎‏⁪‬‬‬‮⁮‎‏‮;

		// ⁯‫‍⁫‍‭‍‫⁯‍‭‌⁭⁪⁬⁪‭‫‌‌⁯‮​​⁯‫‬⁭⁯‌⁭⁫‏‫​‬‪⁭⁪⁬‮
		private bool u206f‫‍⁫‍‭‍‫⁯‍‭‌⁭⁪⁬⁪‭‫‌‌⁯‮​​⁯‫‬⁭⁯‌⁭⁫‏‫​‬‪⁭⁪⁬‮;

		// ‌⁪⁯⁭⁪​​‭‭⁬⁫‪‍⁪⁫⁬‬‌​⁯‭⁯‮‏⁮⁯‭⁫‮‍⁫⁭‬‎‎‏‪‪‏‎‮
		private u206a‭⁫⁪‏⁫‬‏⁬​‏‌‏​⁬‫‮⁯⁫‎‌‮‫‎‮‎‬⁪​‍⁮‏‭‌‌⁬‌⁯‎⁪‮ u200c⁪⁯⁭⁪​​‭‭⁬⁫‪‍⁪⁫⁬‬‌​⁯‭⁯‮‏⁮⁯‭⁫‮‍⁫⁭‬‎‎‏‪‪‏‎‮ = new u206a‭⁫⁪‏⁫‬‏⁬​‏‌‏​⁬‫‮⁯⁫‎‌‮‫‎‮‎‬⁪​‍⁮‏‭‌‌⁬‌⁯‎⁪‮();

		// ​‍⁯⁪‌‍‍‎‪⁯⁮⁪‬⁯⁮⁮‍⁫‫⁭⁯​⁮⁮‫⁫‪‭‪⁪‪⁬⁫‬‎‌‎⁬‎⁫‮
		private TetraSettings u200b‍⁯⁪‌‍‍‎‪⁯⁮⁪‬⁯⁮⁮‍⁫‫⁭⁯​⁮⁮‫⁫‪‭‪⁪‪⁬⁫‬‎‌‎⁬‎⁫‮;

		// ⁯‬⁪​‮‌⁮‪‫‍⁪⁭‫‎⁪⁫‌⁮⁮‍‍⁮‌⁫⁪‬‏⁮‎‭⁬‭‍⁫⁬‮⁭⁪‎‬‮
		private SettingsPersister u206f‬⁪​‮‌⁮‪‫‍⁪⁭‫‎⁪⁫‌⁮⁮‍‍⁮‌⁫⁪‬‏⁮‎‭⁬‭‍⁫⁬‮⁭⁪‎‬‮;

		// ‫⁭‮‮‌⁮‍⁪‭‮⁯‍​‬⁯⁫⁪⁬⁮⁮‎‫⁬⁬‌⁬‮⁮‍​‫​‫‌⁬​‌‪‮
		private u200f⁭‏‫‪‪‎‍⁫‏⁬⁮‫‫‌⁪⁭‌⁬⁫‍⁮⁭‌‎⁮⁫⁪⁪‬‪⁫⁮‫⁭‬⁮‪‌‪‮ u202b⁭‮‮‌⁮‍⁪‭‮⁯‍​‬⁯⁫⁪⁬⁮⁮‎‫⁬⁬‌⁬‮⁮‍​‫​‫‌⁬​‌‪‮;

		// ⁪⁬⁬‮⁫‎‫⁮⁭‍‪⁮⁮‮​​⁯​‫‭‬⁬⁯‮⁪‫⁭‎⁫‏⁬⁭‪⁭⁫‏‫‏⁬‫‮
		private FileStream u206a⁬⁬‮⁫‎‫⁮⁭‍‪⁮⁮‮​​⁯​‫‭‬⁬⁯‮⁪‫⁭‎⁫‏⁬⁭‪⁭⁫‏‫‏⁬‫‮;

		// ‎‫⁯​‍⁯‎‬‫‭⁯‮‎‍‌‭⁪⁭⁮‎⁯⁫‬‌‌⁬‪‏‫‏⁮‌‭​‬‮⁪‌⁬‍‮
		private bool u200e‫⁯​‍⁯‎‬‫‭⁯‮‎‍‌‭⁪⁭⁮‎⁯⁫‬‌‌⁬‪‏‫‏⁮‌‭​‬‮⁪‌⁬‍‮;

		// ⁮‫‫​‮⁫‮⁬‎‫​‭‬⁭‫⁫⁪‬‭⁫⁫‫‌⁪‏⁪⁫‍‍​⁯⁯⁭‏‫‪⁫‮⁫⁪‮
		private bool u206e‫‫​‮⁫‮⁬‎‫​‭‬⁭‫⁫⁪‬‭⁫⁫‫‌⁪‏⁪⁫‍‍​⁯⁯⁭‏‫‪⁫‮⁫⁪‮;

		// ⁯‫⁪​⁯‍‎‬⁬‏⁯‫⁭⁪‫‌⁬⁯‬⁭‭‪⁬​⁯‏‍‍‍⁪⁫⁭⁯⁯‪‎‌‭‍⁮‮
		private int u206f‫⁪​⁯‍‎‬⁬‏⁯‫⁭⁪‫‌⁬⁯‬⁭‭‪⁬​⁯‏‍‍‍⁪⁫⁭⁯⁯‪‎‌‭‍⁮‮;

		// ‎⁯⁭​‮‫‬⁫‏‭‮⁪⁯‭⁮‎⁯⁫‍⁪​‭‬⁮‫​‭​⁭‪‪​⁫‭‌‎‌​‭‬‮
		private short[] u200e⁯⁭​‮‫‬⁫‏‭‮⁪⁯‭⁮‎⁯⁫‍⁪​‭‬⁮‫​‭​⁭‪‪​⁫‭‌‎‌​‭‬‮ = new short[276];

		// ‭⁪​⁮⁫⁭⁪‏‮‍⁮⁭⁭⁪‍‌‎⁬⁪⁭‮‪‎⁮⁫‭⁮‍‌⁮‏‪‫⁮‭‎‌‏‪⁭‮
		private short[] u202d⁪​⁮⁫⁭⁪‏‮‍⁮⁭⁭⁪‍‌‎⁬⁪⁭‮‪‎⁮⁫‭⁮‍‌⁮‏‪‫⁮‭‎‌‏‪⁭‮ = new short[480];

		// ‬⁪​‬‫⁫‭⁫‪‫⁪⁭‮⁮⁫‫‭⁮‬‌‎‬⁮⁭⁭‭‪‪‮‌‬‪⁫​‮⁬‍⁪‍‏‮
		private AudioProcessor u202c⁪​‬‫⁫‭⁫‪‫⁪⁭‮⁮⁫‫‭⁮‬‌‎‬⁮⁭⁭‭‪‪‮‌‬‪⁫​‮⁬‍⁪‍‏‮;

		// ⁯‌‏‪‫‏‮⁫‮‭⁯⁯⁮‎⁭‏‪‎⁮⁮⁬​‪‍⁬‭‬⁮​‬⁮‍‬‍‍‬‪‮​‪‮
		private bool u206f‌‏‪‫‏‮⁫‮‭⁯⁯⁮‎⁭‏‪‎⁮⁮⁬​‪‍⁬‭‬⁮​‬⁮‍‬‍‍‬‪‮​‪‮;

		// ‮‫⁮‭‏‎⁭⁪⁮‪‪⁫‬‮‭‭⁯‭‫​‫‭‮‭‪‫‭‍‎⁯‫‬‪‫​‎‌‎​‍‮
		private bool u202e‫⁮‭‏‎⁭⁪⁮‪‪⁫‬‮‭‭⁯‭‫​‫‭‮‭‪‫‭‍‎⁯‫‬‪‫​‎‌‎​‍‮;

		// ‌⁫⁪‫‮‏‫⁮⁯‬⁮​‎⁯‪‪‭​‬‫‭⁫⁭‏‪‫‪‫⁫‌⁭‮‌‪‍‭⁫‬⁭⁭‮
		private bool u200c⁫⁪‫‮‏‫⁮⁯‬⁮​‎⁯‪‪‭​‬‫‭⁫⁭‏‪‫‪‫⁫‌⁭‮‌‪‍‭⁫‬⁭⁭‮;

		// ​‎⁪⁫‬⁬‭‌⁫‌​⁭‪‮‮‫‎‫‫‏‌‏‌‫‬‬​⁫⁭‮‮​⁮⁯​⁭‎​‫‍‮
		private bool u200b‎⁪⁫‬⁬‭‌⁫‌​⁭‪‮‮‫‎‫‫‏‌‏‌‫‬‬​⁫⁭‮‮​⁮⁯​⁭‎​‫‍‮;

		// ‌⁪‌⁯‪‏⁭​‮⁮‫⁪⁫‮‪‎‭⁭⁭‮⁬‍⁪⁫‏‍‎‭​‭‍‫⁭‪⁬​‪‏‬⁮‮
		private bool u200c⁪‌⁯‪‏⁭​‮⁮‫⁪⁫‮‪‎‭⁭⁭‮⁬‍⁪⁫‏‍‎‭​‭‍‫⁭‪⁬​‪‏‬⁮‮;

		// ‮‍⁪⁪⁯⁫‮⁬‪⁬‪‍​‍⁬‍⁬⁫‬‌‌‬‬⁭‬‪‮‬‬⁬⁮‍‏​‪‫​⁬⁫‌‮
		private bool u202e‍⁪⁪⁯⁫‮⁬‪⁬‪‍​‍⁬‍⁬⁫‬‌‌‬‬⁭‬‪‮‬‬⁬⁮‍‏​‪‫​⁬⁫‌‮;

		// ‏‍⁫‍​⁫⁫⁫‏‮‎‪⁯‬⁭⁬⁪⁪⁯⁪⁮⁬⁮‫‍⁯⁭‎⁬‍‎‫⁫‏⁭⁯​​⁫‭‮
		private bool u200f‍⁫‍​⁫⁫⁫‏‮‎‪⁯‬⁭⁬⁪⁪⁯⁪⁮⁬⁮‫‍⁯⁭‎⁬‍‎‫⁫‏⁭⁯​​⁫‭‮;

		// ‬‬‬‮⁮⁯‮‏‮‬‍‬‏‪‭⁬‪⁮⁭⁭⁭‎⁭‎‭⁫​‪⁫‫‎⁫‬‌‌⁬⁪‌‪⁯‮
		private bool u202c‬‬‮⁮⁯‮‏‮‬‍‬‏‪‭⁬‪⁮⁭⁭⁭‎⁭‎‭⁫​‪⁫‫‎⁫‬‌‌⁬⁪‌‪⁯‮;

		// ‍‮‌⁯‏⁪‌⁯⁯‭‪‪⁪‌​‫‏‮⁬‪‮‏‬‬⁫⁪‍‍‌⁪⁬‫‮⁬⁬‪⁫⁭⁯⁬‮
		private bool u200d‮‌⁯‏⁪‌⁯⁯‭‪‪⁪‌​‫‏‮⁬‪‮‏‬‬⁫⁪‍‍‌⁪⁬‫‮⁬⁬‪⁫⁭⁯⁬‮;

		// ⁯‮‫‮‌‎⁮​‍⁮‬‏‮⁪‭‍‌‌‎⁯‮‪⁯‍‏⁯⁬‎‮‏‌⁫‏⁪‮‮⁬‏⁮‪‮
		private bool u206f‮‫‮‌‎⁮​‍⁮‬‏‮⁪‭‍‌‌‎⁯‮‪⁯‍‏⁯⁬‎‮‏‌⁫‏⁪‮‮⁬‏⁮‪‮;

		// ‫⁬‌‎⁬⁪⁪⁯‮⁬‎⁮⁬⁮​‮⁬‍‎⁬⁬‭‏​⁫⁫‎‭‬⁮‎‌⁯⁯⁬⁬⁬​‍⁭‮
		private bool u202b⁬‌‎⁬⁪⁪⁯‮⁬‎⁮⁬⁮​‮⁬‍‎⁬⁬‭‏​⁫⁫‎‭‬⁮‎‌⁯⁯⁬⁬⁬​‍⁭‮;

		// ​‪‭⁫‮‍⁫‫‫⁬⁬‌⁮⁭‪‍⁬‏‪⁫⁬⁫‮‪⁫‌‎‌⁫⁬‏⁫‬⁮‌⁮⁯‌⁪‪‮
		private int u200b‪‭⁫‮‍⁫‫‫⁬⁬‌⁮⁭‪‍⁬‏‪⁫⁬⁫‮‪⁫‌‎‌⁫⁬‏⁫‬⁮‌⁮⁯‌⁪‪‮;

		// ‬⁮​⁬⁭‭⁪‍‏‭⁭⁫‎⁬‭‍‍‭⁭⁪‍‭‎⁭⁯⁭‭‭‮‮⁭‌⁪​⁬‮⁯⁬⁫‏‮
		private int u202c⁮​⁬⁭‭⁪‍‏‭⁭⁫‎⁬‭‍‍‭⁭⁪‍‭‎⁭⁯⁭‭‭‮‮⁭‌⁪​⁬‮⁯⁬⁫‏‮;

		// ‎‭‌‭‫⁯‏​‭⁮​‪​‏‭‌‭‌‎⁮⁮‫⁭‬‏‪‫⁫‏⁬⁫‍⁫⁬⁪‬‏⁫‎‪‮
		private int u200e‭‌‭‫⁯‏​‭⁮​‪​‏‭‌‭‌‎⁮⁮‫⁭‬‏‪‫⁫‏⁬⁫‍⁫⁬⁪‬‏⁫‎‪‮;

		// ‬‌⁯‌‍‏‍‬​‌‬⁪​‏⁫⁫⁭​‭‮‮⁭⁪​​​⁫‮‮‍​‫⁯​⁫⁮‫‬‭⁭‮
		private int u202c‌⁯‌‍‏‍‬​‌‬⁪​‏⁫⁫⁭​‭‮‮⁭⁪​​​⁫‮‮‍​‫⁯​⁫⁮‫‬‭⁭‮;

		// ⁮​‮⁪⁯⁭⁬‌‭‪‍‌‮⁬‭‏‫‫‬⁮⁭‎⁮​‫‍‎‪⁫‏‍‎‫‏‬⁪⁮‍​⁪‮
		private NetInfoWindow u206e​‮⁪⁯⁭⁬‌‭‪‍‌‮⁬‭‏‫‫‬⁮⁭‎⁮​‫‍‎‪⁫‏‍‎‫‏‬⁪⁮‍​⁪‮;

		// ⁪⁯‭⁮‬‌‎‌‬‍⁪‮⁭‍⁪‭⁭‮⁫‭⁯‍‍‍⁮‎‪‭⁪‫‪‭‪​‪⁮⁭‌‪⁭‮
		private List<Dictionary<GlobalNames, int>> u206a⁯‭⁮‬‌‎‌‬‍⁪‮⁭‍⁪‭⁭‮⁫‭⁯‍‍‍⁮‎‪‭⁪‫‪‭‪​‪⁮⁭‌‪⁭‮ = new List<Dictionary<GlobalNames, int>>();

		// ⁪‍⁮‮​⁮‭⁬⁯‎‬⁯‏‭⁪​‬‏⁮‮‬‍‫‫‪‬⁪‪⁭⁯‫‭‏⁫‎‭‫‎⁪‬‮
		private Dictionary<GlobalNames, int> u206a‍⁮‮​⁮‭⁬⁯‎‬⁯‏‭⁪​‬‏⁮‮‬‍‫‫‪‬⁪‪⁭⁯‫‭‏⁫‎‭‫‎⁪‬‮ = new Dictionary<GlobalNames, int>();

		// ‬‍⁪‎‪‏⁭⁮‫‎⁭‪⁮‍​‏‮‫‏‪‎‮‮‪​‮‌⁯‌⁪⁭‍‌‍​‪‫‎‪⁫‮
		private Dictionary<GlobalNames, int> u202c‍⁪‎‪‏⁭⁮‫‎⁭‪⁮‍​‏‮‫‏‪‎‮‮‪​‮‌⁯‌⁪⁭‍‌‍​‪‫‎‪⁫‮ = new Dictionary<GlobalNames, int>();

		// ⁯‍‫⁫‍⁭​‮⁯⁯‮​⁭‏‏‏⁪‎‫⁬⁫⁪⁬⁫⁬⁯⁪​‌⁭‪⁫‏⁪⁮‍‬‮‎‏‮
		private CurrentLoad[] u206f‍‫⁫‍⁭​‮⁯⁯‮​⁭‏‏‏⁪‎‫⁬⁫⁪⁬⁫⁬⁯⁪​‌⁭‪⁫‏⁪⁮‍‬‮‎‏‮ = new CurrentLoad[4];

		// ⁮‍⁫⁫‪⁬⁪‬⁮​‭‮‬⁭‫‏⁮⁫‌‮‍​‎⁫⁫⁭‮‪‫‮⁯​‪​‎‬​‍⁬⁬‮
		private int u206e‍⁫⁫‪⁬⁪‬⁮​‭‮‬⁭‫‏⁮⁫‌‮‍​‎⁫⁫⁭‮‪‫‮⁯​‪​‎‬​‍⁬⁬‮;

		// ‭‍⁮⁬‍‫‮⁮⁯‏‭​‭‍​‌⁮‫⁫⁮‪‏‬⁭‎​​‬‮‫⁪‍‎‌‭‎⁫‪‏‭‮
		private int u202d‍⁮⁬‍‫‮⁮⁯‏‭​‭‍​‌⁮‫⁫⁮‪‏‬⁭‎​​‬‮‫⁪‍‎‌‭‎⁫‪‏‭‮;

		// ⁭⁭⁯‭⁬‍⁭⁪‫‫⁭⁪⁬‏‮​‌‏​⁭⁯⁮‪⁭⁫⁫⁭‍‍‪‭‎‮‭⁯​‎⁮⁬‮‮
		private int u206d⁭⁯‭⁬‍⁭⁪‫‫⁭⁪⁬‏‮​‌‏​⁭⁯⁮‪⁭⁫⁫⁭‍‍‪‭‎‮‭⁯​‎⁮⁬‮‮;

		// ‌‏‭‬⁮‎​⁯⁯‮‏‪⁫⁯​⁭‫‏‌⁬‬⁯‪‬‍‭‫‮⁫‮‭‏‌​⁮‌⁯⁫⁭⁮‮
		private int u200c‏‭‬⁮‎​⁯⁯‮‏‪⁫⁯​⁭‫‏‌⁬‬⁯‪‬‍‭‫‮⁫‮‭‏‌​⁮‌⁯⁫⁭⁮‮;

		// ‭‪⁮⁭‮⁯‮‏‌⁯‭⁬⁯⁫‮‌‍⁯⁫‏‏‪‌‬⁬‍⁬‭​⁭‏‫⁮⁬‌​‮‎‪⁬‮
		private int u202d‪⁮⁭‮⁯‮‏‌⁯‭⁬⁯⁫‮‌‍⁯⁫‏‏‪‌‬⁬‍⁬‭​⁭‏‫⁮⁬‌​‮‎‪⁬‮;

		// ‬‭‭‌‍‌⁫‭‬‌⁬⁭​⁮‮⁮‬⁬‎‪‍⁮‏‪⁭‫‬‮⁯⁬‪‬‬‫‎‮⁫‮‫‮
		private int u202c‭‭‌‍‌⁫‭‬‌⁬⁭​⁮‮⁮‬⁬‎‪‍⁮‏‪⁭‫‬‮⁯⁬‪‬‬‫‎‮⁫‮‫‮;

		// ‫⁮⁯⁭‫⁫‏⁬‎⁭⁮⁭‮⁭‭‏‎‍‭‫⁪⁫⁬‎⁭⁯‍⁬‌‎​⁬⁭⁪⁮‍‬‭⁯⁮‮
		private int u202b⁮⁯⁭‫⁫‏⁬‎⁭⁮⁭‮⁭‭‏‎‍‭‫⁪⁫⁬‎⁭⁯‍⁬‌‎​⁬⁭⁪⁮‍‬‭⁯⁮‮;

		// ⁭⁪⁮‮⁬‍‮⁯‌‌​⁭‍​‭‎‮‬⁭⁮⁯⁪‬‎⁭⁯‍⁪⁯⁫‮⁮⁮‫⁯‎⁭​‫‮
		private int u206d⁪⁮‮⁬‍‮⁯‌‌​⁭‍​‭‎‮‬⁭⁮⁯⁪‬‎⁭⁯‍⁪⁯⁫‮⁮⁮‫⁯‎⁭​‫‮;

		// ⁪‮⁬‮⁬‪⁫⁪⁪‫‭⁪⁬​‌⁭‍⁮‌‮‫‫‬⁭⁫⁭⁬⁮⁮⁫​‪‏‮‮‮​⁫‎⁫‮
		private int u206a‮⁬‮⁬‪⁫⁪⁪‫‭⁪⁬​‌⁭‍⁮‌‮‫‫‬⁭⁫⁭⁬⁮⁮⁫​‪‏‮‮‮​⁫‎⁫‮;

		// ‫⁬⁪‫⁭⁪‪‎⁮⁬⁪⁪‎⁭‬‪‭⁯‫‬⁭‮‎‎⁫‪‍⁬‌⁪⁪⁫‍‌‪‬‮‎‏‭‮
		private int u202b⁬⁪‫⁭⁪‪‎⁮⁬⁪⁪‎⁭‬‪‭⁯‫‬⁭‮‎‎⁫‪‍⁬‌⁪⁪⁫‍‌‪‬‮‎‏‭‮;

		// ‫​‭⁭‭⁫​​‍‎⁭‬‏​⁫‮‏⁬‭‎‪‬⁮⁭‌⁬⁮‍⁪⁯⁪‌‍⁬‫⁭⁭⁪⁫⁫‮
		private long u202b​‭⁭‭⁫​​‍‎⁭‬‏​⁫‮‏⁬‭‎‪‬⁮⁭‌⁬⁮‍⁪⁯⁪‌‍⁬‫⁭⁭⁪⁫⁫‮;

		// ⁮‬‪⁭‌‌⁫‍⁪⁮‌⁮‪⁭‭⁫‏​‮‎⁫‪‌⁯‎‍‏‎⁪‮‪‬‫‎⁫‮⁮‏‌‭‮
		private int u206e‬‪⁭‌‌⁫‍⁪⁮‌⁮‪⁭‭⁫‏​‮‎⁫‪‌⁯‎‍‏‎⁪‮‪‬‫‎⁫‮⁮‏‌‭‮;

		// ⁪‪⁭‎⁪‌‎‭⁭‎‏‬‪‏⁫‭‪⁫‍⁬⁫⁪‏⁪⁫​⁮‫⁯⁮‎⁭‪⁭‏‍⁮⁪‎⁬‮
		private bool u206a‪⁭‎⁪‌‎‭⁭‎‏‬‪‏⁫‭‪⁫‍⁬⁫⁪‏⁪⁫​⁮‫⁯⁮‎⁭‪⁭‏‍⁮⁪‎⁬‮;

		// ‪⁮‍⁫‬⁭‌⁬⁫⁭​‭‭⁫‍‮⁬⁮⁬‎‏‮‭​⁪‏‪‌⁭‭‪‭‍⁪‪‌⁭‫⁪⁬‮
		private bool u202a⁮‍⁫‬⁭‌⁬⁫⁭​‭‭⁫‍‮⁬⁮⁬‎‏‮‭​⁪‏‪‌⁭‭‪‭‍⁪‪‌⁭‫⁪⁬‮;

		// ‏‪‍⁫⁭⁮‌‏⁭‍‏‭‪⁫‭⁮⁭‫‪‫⁬⁬‮⁫⁫​⁮‎⁪‪⁪‍⁬‮⁬‪‪‌‍⁬‮
		private SortedDictionary<int, CallsEntry> u200f‪‍⁫⁭⁮‌‏⁭‍‏‭‪⁫‭⁮⁭‫‪‫⁬⁬‮⁫⁫​⁮‎⁪‪⁪‍⁬‮⁬‪‪‌‍⁬‮ = new SortedDictionary<int, CallsEntry>();

		// ‏⁯⁫‮⁭​⁮⁫⁭‬‌‮‍‭‮‮‭⁭⁮⁮‍‫‭⁯⁪⁯⁬‬⁬⁬‮‬⁬⁪⁮⁫‪​​‮‮
		private Dictionary<int, NetworkEntry> u200f⁯⁫‮⁭​⁮⁫⁭‬‌‮‍‭‮‮‭⁭⁮⁮‍‫‭⁯⁪⁯⁬‬⁬⁬‮‬⁬⁪⁮⁫‪​​‮‮ = new Dictionary<int, NetworkEntry>();

		// ​​⁭‎⁬‎⁯‍‌⁬⁪⁭‭⁯‏‬‪‫‮⁪⁫⁬⁭⁭⁪⁭‌⁮⁪⁯⁫⁮‏‎⁫⁭‪‌⁬‭‮
		private int u200b​⁭‎⁬‎⁯‍‌⁬⁪⁭‭⁯‏‬‪‫‮⁪⁫⁬⁭⁭⁪⁭‌⁮⁪⁯⁫⁮‏‎⁫⁭‪‌⁬‭‮;

		// ‪‏‮‏‌⁬⁫‫⁯‭‏‪‎⁯‫‍‮‬⁮⁪⁪‭‭⁯‭⁫‮‏‪⁬​‬‎‮⁬​‫‮⁮⁮‮
		private bool u202a‏‮‏‌⁬⁫‫⁯‭‏‪‎⁯‫‍‮‬⁮⁪⁪‭‭⁯‭⁫‮‏‪⁬​‬‎‮⁬​‫‮⁮⁮‮;

		// ‍⁮⁪‭‍‭‮‮‌‍⁭‏⁬‎‏‪‮‎‎​‮‌⁬⁯‏​‎‮⁬⁭​⁭⁫‌‌‭‭‭‍‮
		private const string u200d⁮⁪‭‍‭‮‮‌‍⁭‏⁬‎‏‪‮‎‎​‮‌⁬⁯‏​‎‮⁬⁭​⁭⁫‌‌‭‭‭‍‮ = "date + time + mcc + mnc + la + cc + carrier + slot + callid + group + tx + encryption + duplex";

		// ⁯⁮​⁪‮⁮​⁮⁫‬⁪‮⁪‫⁬‌‏⁪‌⁪⁪‫⁪⁯⁫‏‍⁫‭⁭‎⁭‌‫⁯⁭⁬‮‌‪‮
		private const string u206f⁮​⁪‮⁮​⁮⁫‬⁪‮⁪‫⁬‌‏⁪‌⁪⁪‫⁪⁯⁫‏‍⁫‭⁭‎⁭‌‫⁯⁭⁬‮‌‪‮ = "date \\ frequency \\ mcc \"_\" mnc \"_\" la";

		// ⁪‌‬‪‎‪‍‬‍⁬⁫‍‬⁯‌⁪⁫‪‭‌‎‏‪⁭⁭‎‍‎‪‬⁫‫⁪‏‮​⁮⁮‪⁫‮
		private const string u206a‌‬‪‎‪‍‬‍⁬⁫‍‬⁯‌⁪⁫‪‭‌‎‏‪⁭⁭‎‍‎‪‬⁫‫⁪‏‮​⁮⁮‪⁫‮ = " ; ";

		// ‏‭⁯‌‎⁫‏‪⁪‭‏‫‍⁫‪‏‌​‫​‮⁪‎‮⁬⁭⁯‮​‌‭‬⁮‍⁪​⁬‌‏⁪‮
		private bool u200f‭⁯‌‎⁫‏‪⁪‭‏‫‍⁫‪‏‌​‫​‮⁪‎‮⁬⁭⁯‮​‌‭‬⁮‍⁪​⁬‌‏⁪‮;

		// ​‫⁭‫‌‬‫⁯‬‬⁮‪‮‎‌⁮‫‭⁪‬‭​‫‭⁯⁪‭​⁫⁫‬‮⁯‎⁭‫‫⁬‎‬‮
		private int u200b‫⁭‫‌‬‫⁯‬‬⁮‪‮‎‌⁮‫‭⁪‬‭​‫‭⁯⁪‭​⁫⁫‬‮⁯‎⁭‫‫⁬‎‬‮;

		// ⁫⁭‭‍⁬‮⁮‪⁫​‌‪‪⁪‪‬‮‬‫‫‌⁯⁬‌​‎⁪‎‌‮‫‎‮⁯⁭‮​‭‮‌‮
		private float u206b⁭‭‍⁬‮⁮‪⁫​‌‪‪⁪‪‬‮‬‫‫‌⁯⁬‌​‎⁪‎‌‮‫‎‮⁯⁭‮​‭‮‌‮;

		// ⁬‮‍⁯‌⁯‏⁪‌‎‌​‎⁮‭⁭⁮⁬‫‬⁮‍⁪⁭‮⁮⁯⁪⁪‍‫‍‫‮⁮‭‍‌‌⁬‮
		private int u206c‮‍⁯‌⁯‏⁪‌‎‌​‎⁮‭⁭⁮⁬‫‬⁮‍⁪⁭‮⁮⁯⁪⁪‍‫‍‫‮⁮‭‍‌‌⁬‮;

		// ‮​‍⁫‪⁫⁭‭⁮⁭‌‌⁭‫‌‭‌‪⁭⁮⁬​‬‫‎⁫‎‏‮‌‎‬‮‎⁮‬‫‪⁮⁪‮
		private double u202e​‍⁫‪⁫⁭‭⁮⁭‌‌⁭‫‌‭‌‪⁭⁮⁬​‬‫‎⁫‎‏‮‌‎‬‮‎⁮‬‫‪⁮⁪‮;

		// ‭‬‮⁬⁫‌​⁫‫⁭‮‍‌⁯‪⁭⁬⁭⁬⁮⁪‪​⁯⁮⁮‮‏‫‌⁬‏⁬‌⁫​‮⁭⁬‬‮
		private double u202d‬‮⁬⁫‌​⁫‫⁭‮‍‌⁯‪⁭⁬⁭⁬⁮⁪‪​⁯⁮⁮‮‏‫‌⁬‏⁬‌⁫​‮⁭⁬‬‮;

		// ​‌⁪‬‮‭‪⁮‍‭⁯‬‍⁭⁫‍‬​⁫⁭⁬‏⁭‎⁪⁬‭‫‬⁭⁪‭​⁮⁭‏‎‎‏‎‮
		private float u200b‌⁪‬‮‭‪⁮‍‭⁯‬‍⁭⁫‍‬​⁫⁭⁬‏⁭‎⁪⁬‭‫‬⁭⁪‭​⁮⁭‏‎‎‏‎‮;

		// ‎‮‌‪‍⁫‍​⁫⁮‎‮‫⁮‫‪⁮‏⁪​⁪⁯‫‮‬⁬‭‪‭⁫‬⁬‭​⁪‭‪⁮‫⁫‮
		private bool u200e‮‌‪‍⁫‍​⁫⁮‎‮‫⁮‫‪⁮‏⁪​⁪⁯‫‮‬⁬‭‪‭⁫‬⁬‭​⁪‭‪⁮‫⁫‮;

		// ‍‎‫⁯​‮‪‫‌⁪‎‬‌‏⁭​‎‬‌‬⁪‪‬⁮‍⁬‪‌‎‍​⁫‭⁬⁪⁮‍‌‮‬‮
		private const int u200d‎‫⁯​‮‪‫‌⁪‎‬‌‏⁭​‎‬‌‬⁪‪‬⁮‍⁬‪‌‎‍​⁫‭⁬⁪⁮‍‌‮‬‮ = 20000;

		// ‮‬‍‮‏​⁭‎‫⁮⁬‏⁪‫⁯‎⁭‎‌⁫‪‪‫‮⁬‭‫⁯‌⁬‬‭⁪‭⁬‮‭⁪⁪‬‮
		private int u202e‬‍‮‏​⁭‎‫⁮⁬‏⁪‫⁯‎⁭‎‌⁫‪‪‫‮⁬‭‫⁯‌⁬‬‭⁪‭⁬‮‭⁪⁪‬‮;

		// ‪⁮​⁮‪‫‏‬⁮⁬‌‍⁫‏‬‬⁬⁬‌⁮‍⁫⁭‏​⁪‌⁮⁯⁬‍⁮‬⁮‎‌‏‬‎‭‮
		private int u202a⁮​⁮‪‫‏‬⁮⁬‌‍⁫‏‬‬⁬⁬‌⁮‍⁫⁭‏​⁪‌⁮⁯⁬‍⁮‬⁮‎‌‏‬‎‭‮;

		// ⁪‬‎⁬‪‮‪⁭⁯⁭‬‏​​⁮‮‎‌‫⁬⁭‪‍⁯‌‭‎⁯‮​⁭⁫‪⁮⁮‮‪‫‏‍‮
		private int u206a‬‎⁬‪‮‪⁭⁯⁭‬‏​​⁮‮‎‌‫⁬⁭‪‍⁯‌‭‎⁯‮​⁭⁫‪⁮⁮‮‪‫‏‍‮;

		// ⁬⁭⁭‍⁮​⁮⁪⁮‍‍‌‍‪‭‬‫⁪‪‍​⁯‪‌⁪⁭‎‏⁮‭‪⁫⁫⁭‭‏‪⁭​⁭‮
		private bool u206c⁭⁭‍⁮​⁮⁪⁮‍‍‌‍‪‭‬‫⁪‪‍​⁯‪‌⁪⁭‎‏⁮‭‪⁫⁫⁭‭‏‪⁭​⁭‮;

		// ⁫⁫‍‬‌⁭‌⁭‪‪⁪​‪⁭⁫‍‬‫⁪⁯‬⁫‏‌⁪‪‫⁭‬‌⁫‬⁫⁭⁬‏⁭⁬‎‌‮
		private string u206b⁫‍‬‌⁭‌⁭‪‪⁪​‪⁭⁫‍‬‫⁪⁯‬⁫‏‌⁪‪‫⁭‬‌⁫‬⁫⁭⁬‏⁭⁬‎‌‮;

		// ‮‭⁪⁮‌⁬⁭‌‎‬‌‍‪‌‫‪‬‬‌‎‬‭‬‫‪‍⁯‪⁪‏‪‎‪⁮‫‮‌‪⁪⁫‮
		private bool u202e‭⁪⁮‌⁬⁭‌‎‬‌‍‪‌‫‪‬‬‌‎‬‭‬‫‪‍⁯‪⁪‏‪‎‪⁮‫‮‌‪⁪⁫‮;

		// ‍⁯‮‬⁫⁪‎‏‮‍‌‬‏‍⁫‭⁪‮⁭‪⁫⁭‍⁯‏⁯‏⁫‌⁫‮‫‏‎​‏‏‎‎‮
		private int u200d⁯‮‬⁫⁪‎‏‮‍‌‬‏‍⁫‭⁪‮⁭‪⁫⁭‍⁯‏⁯‏⁫‌⁫‮‫‏‎​‏‏‎‎‮;

		// ‎‮⁪‪​‮‍‌​‍‍‍​‌⁬⁪⁮⁯‫⁭⁬‬‭‪‫‭⁫⁪⁭⁬⁮‫⁬‍‫‬⁭‬⁫‮‮
		private Color u200e‮⁪‪​‮‍‌​‍‍‍​‌⁬⁪⁮⁯‫⁭⁬‬‭‪‫‭⁫⁪⁭⁬⁮‫⁬‍‫‬⁭‬⁫‮‮ = TetraPanel.u202b​‌⁭‭‏⁬⁭⁫‏‏‮⁭‏‪‌⁮‮‎‍⁬⁪‭​⁯‫‌‮⁫‫​‍⁭‍‭‌‭‭‎⁯‮();

		// ‬‌‌‌‭⁫⁭‭‏​‏‍⁪‪‭‍⁮​‬⁭‏‌‫⁭‍⁭⁫⁫⁬‪‍⁬‬⁭⁮‬⁪‌‮‭‮
		private Color u202c‌‌‌‭⁫⁭‭‏​‏‍⁪‪‭‍⁮​‬⁭‏‌‫⁭‍⁭⁫⁫⁬‪‍⁬‬⁭⁮‬⁪‌‮‭‮ = TetraPanel.u202b⁬⁫‮‎⁭⁯‮‎​‏​‎⁯⁯⁫‭⁭‍‭⁯‎‏⁫⁯‎⁯‫⁮‬⁭⁮‍⁪‭⁬⁮⁯‏‮();

		// ⁫‫‪‪‮‭‪⁯‎⁬⁪⁪‪‪‎‭⁫⁫‌‌⁪‫‎⁪‏‫‏⁬‌‎⁭‏‎⁪⁯​‬‌⁯‮‮
		private Color u206b‫‪‪‮‭‪⁯‎⁬⁪⁪‪‪‎‭⁫⁫‌‌⁪‫‎⁪‏‫‏⁬‌‎⁭‏‎⁪⁯​‬‌⁯‮‮ = TetraPanel.u202b​‌⁭‭‏⁬⁭⁫‏‏‮⁭‏‪‌⁮‮‎‍⁬⁪‭​⁯‫‌‮⁫‫​‍⁭‍‭‌‭‭‎⁯‮();

		// ‫‫⁫‮‌‏⁬‫‪‍‍⁫‏‫⁮‬‏⁭‫⁯‫⁯⁯‏‌‫‭⁯⁯‎⁪⁬⁮⁪⁬‎⁪⁪⁬‪‮
		private Color u202b‫⁫‮‌‏⁬‫‪‍‍⁫‏‫⁮‬‏⁭‫⁯‫⁯⁯‏‌‫‭⁯⁯‎⁪⁬⁮⁪⁬‎⁪⁪⁬‪‮ = TetraPanel.u202b⁬⁫‮‎⁭⁯‮‎​‏​‎⁯⁯⁫‭⁭‍‭⁯‎‏⁫⁯‎⁯‫⁮‬⁭⁮‍⁪‭⁬⁮⁯‏‮();

		// ‏‬‍‎⁭⁫‬⁪‍⁯‎‎‭‭⁯‍‏⁫⁭‌⁫⁬⁬‫‫‏‎​⁬⁪⁪‫‍⁬⁬‏⁬​‪⁯‮
		private Color u200f‬‍‎⁭⁫‬⁪‍⁯‎‎‭‭⁯‍‏⁫⁭‌⁫⁬⁬‫‫‏‎​⁬⁪⁪‫‍⁬⁬‏⁬​‪⁯‮ = TetraPanel.u202b​‌⁭‭‏⁬⁭⁫‏‏‮⁭‏‪‌⁮‮‎‍⁬⁪‭​⁯‫‌‮⁫‫​‍⁭‍‭‌‭‭‎⁯‮();

		// ⁪‭⁮‭‬‮⁯‌⁪‭⁭‌‮⁫⁪​⁭⁬‮‍‮‪‍‭‭⁯‭​⁮‫‫‍⁮‍‬⁫‌‬⁫‭‮
		private Color u206a‭⁮‭‬‮⁯‌⁪‭⁭‌‮⁫⁪​⁭⁬‮‍‮‪‍‭‭⁯‭​⁮‫‫‍⁮‍‬⁫‌‬⁫‭‮ = TetraPanel.u200c‭⁫‫‮‌⁯‭⁫⁯⁫‬⁫⁮⁪‮‏⁫‮‬‬⁬‌⁫⁪⁪⁪⁮⁫‌⁪⁭⁭‍‫‭⁪⁬‬‮‮();

		// ‭‪⁮‌​⁫⁫⁮‪‬​‮‪‌⁮⁬‮‫‎⁬‌‭‍‮​​‎⁯​‫⁭⁫⁯‎⁫‏‪⁯​‮‮
		private bool u202d‪⁮‌​⁫⁫⁮‪‬​‮‪‌⁮⁬‮‫‎⁬‌‭‍‮​​‎⁯​‫⁭⁫⁯‎⁫‏‪⁯​‮‮;

		// ⁪‎‎⁪​‏‫⁮‍⁪⁯‏⁭‌‮​‍‪⁬‮⁮⁮‎⁫‭⁫⁬⁪‮‭‍⁫‫‬‭‮‍‏​‌‮
		private bool u206a‎‎⁪​‏‫⁮‍⁪⁯‏⁭‌‮​‍‪⁬‮⁮⁮‎⁫‭⁫⁬⁪‮‭‍⁫‫‬‭‮‍‏​‌‮;

		// ‬​⁪⁭‎​‌⁯⁮‌⁫‌⁪⁭⁯‪⁯‮​⁭⁭‬⁭‬‮⁪⁫‭‭⁭‫‌‏‪‫‍⁫‫⁮‪‮
		private string u202c​⁪⁭‎​‌⁯⁮‌⁫‌⁪⁭⁯‪⁯‮​⁭⁭‬⁭‬‮⁪⁫‭‭⁭‫‌‏‪‫‍⁫‫⁮‪‮;

		// ‎⁯⁪‫‪​‎‌‭⁪‍⁮⁮⁭‌‭‫‌‎⁬‫⁯⁬‮‫⁫‭⁪⁭‭⁬⁬‌⁪‏⁮‌⁮‫‎‮
		private bool u200e⁯⁪‫‪​‎‌‭⁪‍⁮⁮⁭‌‭‫‌‎⁬‫⁯⁬‮‫⁫‭⁪⁭‭⁬⁬‌⁪‏⁮‌⁮‫‎‮;

		// ‎⁫‭‎⁬⁮‎‍⁯‍⁪​‍⁫⁭⁫‍‫‫​⁫⁪⁬​⁬⁬‌‎‎​‫‏⁪‪‫‌⁪‏‮‮
		private AutomaticGainControl u200e⁫‭‎⁬⁮‎‍⁯‍⁪​‍⁫⁭⁫‍‫‫​⁫⁪⁬​⁬⁬‌‎‎​‫‏⁪‪‫‌⁪‏‮‮;

		// ⁪⁯‍⁬‍‍⁫‍​⁬‌‍⁫‎‏‎‍‍‪⁫⁫⁬​⁮⁬⁮‫‫‍⁮⁫‪⁮‪‏⁪⁬⁪‮‬‮
		private AutomaticGainControl u206a⁯‍⁬‍‍⁫‍​⁬‌‍⁫‎‏‎‍‍‪⁫⁫⁬​⁮⁬⁮‫‫‍⁮⁫‪⁮‪‏⁪⁬⁪‮‬‮;

		// ⁭‮‪⁪‪‫⁬‮⁫⁬‌⁯‭⁬‭⁯‫⁫⁭​⁬⁪‍‌‏⁬​⁮⁯‬⁫⁫⁮⁯⁮‭‫⁭⁬⁫‮
		private AutomaticGainControl u206d‮‪⁪‪‫⁬‮⁫⁬‌⁯‭⁬‭⁯‫⁫⁭​⁬⁪‍‌‏⁬​⁮⁯‬⁫⁫⁮⁯⁮‭‫⁭⁬⁫‮;

		// ⁭‍‌⁬⁫⁯‌‬⁭⁮‭⁯⁯⁪⁫‍‍‎‎‌‭‏‎⁮‬‪‌⁮⁮⁯⁮‍⁮‬‎‍‮‬‬‎‮
		private AutomaticGainControl u206d‍‌⁬⁫⁯‌‬⁭⁮‭⁯⁯⁪⁫‍‍‎‎‌‭‏‎⁮‬‪‌⁮⁮⁯⁮‍⁮‬‎‍‮‬‬‎‮;

		// ⁭‎⁬‪⁭‪‏‪​⁮‎⁪​⁮‪‍‎‮⁫⁪‍⁮⁭‫‫‭‭⁮⁫‎‎⁬⁪⁬‪‏⁫⁬‬‪‮
		private FirFilter u206d‎⁬‪⁭‪‏‪​⁮‎⁪​⁮‪‍‎‮⁫⁪‍⁮⁭‫‫‭‭⁮⁫‎‎⁬⁪⁬‪‏⁫⁬‬‪‮;

		// ⁭⁬‪​‍‎⁭‬‎‍⁭‫⁫⁬‪​​‌‪‌⁪⁪‫‮‮​​‎‪⁪‬‭‫⁮‌‪‪‪⁮⁯‮
		private FirFilter u206d⁬‪​‍‎⁭‬‎‍⁭‫⁫⁬‪​​‌‪‌⁪⁪‫‮‮​​‎‪⁪‬‭‫⁮‌‪‪‪⁮⁯‮;

		// ⁮‫⁯‍⁫‎‪‪⁪⁮‮​‭‫‭⁯‍⁪‎⁯‌‎⁭‎‪⁪‫‫‌⁫‏‍‏⁬⁪‪‏‌‮‬‮
		private FirFilter u206e‫⁯‍⁫‎‪‪⁪⁮‮​‭‫‭⁯‍⁪‎⁯‌‎⁭‎‪⁪‫‫‌⁫‏‍‏⁬⁪‪‏‌‮‬‮;

		// ‪‏‪⁫‬⁭‏‫‫‬‎‍‎⁮‮‍‫⁯‫⁪⁭‫‎‬⁫‪⁪‫‮‫‭‫⁪⁯‪⁫‪⁯‌⁯‮
		private FirFilter u202a‏‪⁫‬⁭‏‫‫‬‎‍‎⁮‮‍‫⁯‫⁪⁭‫‎‬⁫‪⁪‫‮‫‭‫⁪⁯‪⁫‪⁯‌⁯‮;

		// ⁭‫‎‭‭‬‬‎‪⁯‬⁭‭⁫‌‮‬⁬‍‍⁭‪‭‫‭‌‌⁭‮‫‮⁭‮⁫‎⁪‪‍⁯⁭‮
		private UnsafeBuffer u206d‫‎‭‭‬‬‎‪⁯‬⁭‭⁫‌‮‬⁬‍‍⁭‪‭‫‭‌‌⁭‮‫‮⁭‮⁫‎⁪‪‍⁯⁭‮;

		// ⁯⁪⁯‬⁫⁯‭⁫⁫‍⁯⁬‏‭‮‭‪⁫‬‎‌⁯⁪‭‏⁭​⁫‏⁬⁮‏⁭‫‏⁮‫⁫​‭‮
		private unsafe Complex* u206f⁪⁯‬⁫⁯‭⁫⁫‍⁯⁬‏‭‮‭‪⁫‬‎‌⁯⁪‭‏⁭​⁫‏⁬⁮‏⁭‫‏⁮‫⁫​‭‮;

		// ‎‫⁭‪‪‎‫⁭‪​‬‬‎‮‎⁮‪‏⁬‍⁬⁭⁪​‭⁭‫‮‮‏‬⁭‪‫‍‫⁯‭⁮⁪‮
		private UnsafeBuffer u200e‫⁭‪‪‎‫⁭‪​‬‬‎‮‎⁮‪‏⁬‍⁬⁭⁪​‭⁭‫‮‮‏‬⁭‪‫‍‫⁯‭⁮⁪‮;

		// ⁪‫⁯‍‎⁫​‫⁯⁫‬⁫‭‫​‫​​⁯‭⁫‎⁭⁫‬‎⁭⁪‬‍‍‏‎⁫⁫⁯⁮⁪‮‏‮
		private unsafe float* u206a‫⁯‍‎⁫​‫⁯⁫‬⁫‭‫​‫​​⁯‭⁫‎⁭⁫‬‎⁭⁪‬‍‍‏‎⁫⁫⁯⁮⁪‮‏‮;

		// ‌⁫⁯⁮​⁮‍‬⁮⁮‏⁯⁫‎‍‏​‏‪‍‪​‌⁬‪‌‪‬‪⁯‭​⁫​⁯⁭‪‪⁬⁪‮
		private UnsafeBuffer u200c⁫⁯⁮​⁮‍‬⁮⁮‏⁯⁫‎‍‏​‏‪‍‪​‌⁬‪‌‪‬‪⁯‭​⁫​⁯⁭‪‪⁬⁪‮;

		// ‫⁭‍‌⁯‮‏⁪⁪‎‫‍​‍⁪‎‮⁬‪⁯⁯⁬⁮‏‫⁮⁫‏‮‪‫⁯⁯‪⁯‪‪‬⁮‭‮
		private unsafe float* u202b⁭‍‌⁯‮‏⁪⁪‎‫‍​‍⁪‎‮⁬‪⁯⁯⁬⁮‏‫⁮⁫‏‮‪‫⁯⁯‪⁯‪‪‬⁮‭‮;

		// ⁪⁮⁫‪‎‏⁪⁯⁭‌‮⁬‭‫‪‎‫‎‌‍⁬‏⁬‮⁪⁬‪‬⁭⁪‬‫‌‌‫⁫‎‌⁫‫‮
		private FloatFifoStream u206a⁮⁫‪‎‏⁪⁯⁭‌‮⁬‭‫‪‎‫‎‌‍⁬‏⁬‮⁪⁬‪‬⁭⁪‬‫‌‌‫⁫‎‌⁫‫‮;

		// ⁫​‫‌‬​⁫‎‫⁫​⁫‬‎⁪⁭‮⁫⁭‪‮‏‍‮‫‫‪‫‎‎⁬⁮‪‍⁫⁪​‮‭⁯‮
		private Thread u206b​‫‌‬​⁫‎‫⁫​⁫‬‎⁪⁭‮⁫⁭‪‮‏‍‮‫‫‪‫‎‎⁬⁮‪‍⁫⁪​‮‭⁯‮;

		// ‪​‪‎​‌‬‍‮‎‮⁮⁭‍‏‍​‬‪⁯⁪⁫‭‫⁫‭‬‬⁭‎‪⁫‏‍‮‮‎‮‫‍‮
		private int u202a​‪‎​‌‬‍‮‎‮⁮⁭‍‏‍​‬‪⁯⁪⁫‭‫⁫‭‬‬⁭‎‪⁫‏‍‮‮‎‮‫‍‮;

		public static int CurrentDmoCommunicationType;

		public int LastConfigWindowTab;

		public static int _currentDestination_SSI
		{
			get;
			set;
		}

		public static int _currentDestination_SSI_type
		{
			get;
			set;
		}

		public static int _currentSource_SSI
		{
			get;
			set;
		}

		public static int _currentSource_SSI_type
		{
			get;
			set;
		}

		public static int BroadcastPort
		{
			get;
			set;
		}

		public string CallInfo
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				// 
				// Current member / type: System.Void SDRSharp.Tetra.TetraPanel::set_CallInfo(System.String)
				// File path: C:\SDRSharp\Plugins\Tetra\SDRSharp.Tetra.dll
				// 
				// Product version: 0.0.0.0
				// Exception in: System.Void set_CallInfo(System.String)
				// 
				// Not supported type System.Object.
				//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.GetTypeIndex(TypeDefinition type) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 684
				//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.GetContainingType(TypeDefinition leftType, TypeDefinition rightType) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 608
				//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.GetExpressionType() in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 492
				//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.get_ExpressionType() in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 414
				//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.AddAssignmentCastIfNeeded(Expression expr) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\TypeInference\TypeInferer.cs:line 112
				//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.FixAssignmentInList(IList`1 expressionList, Expression value) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\TypeInference\TypeInferer.cs:line 75
				//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.AddCasts() in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\TypeInference\TypeInferer.cs:line 38
				//    at Telerik.JustDecompiler.Decompiler.ExpressionDecompilerStep.Process(DecompilationContext theContext, BlockStatement body) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\ExpressionDecompilerStep.cs:line 68
				//    at Telerik.JustDecompiler.Decompiler.DecompilationPipeline.RunInternal(MethodBody body, BlockStatement block, ILanguage language) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\DecompilationPipeline.cs:line 100
				//    at Telerik.JustDecompiler.Decompiler.DecompilationPipeline.Run(MethodBody body, ILanguage language) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\DecompilationPipeline.cs:line 67
				//    at Telerik.JustDecompiler.Decompiler.PropertyDecompiler.DecompileMethod(MethodBody body, MethodSpecificContext& methodContext) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\PropertyDecompiler.cs:line 347
				// 
				// mailto: JustDecompilePublicFeedback@telerik.com

			}
		}

		public string CallInfoTXer
		{
			set
			{
				SortedDictionary<int, CallsEntry> nums = null;
				uint num;
				int num1;
				int num2;
				int num3;
				string[] strArrays = TetraPanel.u206c‬‬‫‬⁭‭​‮‮‫⁫‍‫⁪‪‏‪⁭‪⁮⁭⁯⁯⁮‫‍‍⁫⁭‮‍‌‬‍‍‮⁯⁮‭‮(value, new char[] { '|' });
				int num4 = TetraPanel.u200f‫⁪⁬​⁯‍‍‌⁭⁪⁯⁪⁬‭‬⁯‎⁯‎⁪⁬⁯​‪⁬⁬‮‫‎‌‭‬‬‪‍‫⁬⁯⁮‮(strArrays[0]);
				int num5 = TetraPanel.u200f‫⁪⁬​⁯‍‍‌⁭⁪⁯⁪⁬‭‬⁯‎⁯‎⁪⁬⁯​‪⁬⁬‮‫‎‌‭‬‬‪‍‫⁬⁯⁮‮(strArrays[1]);
				if (num4 == 0)
				{
					goto Label0;
				}
			Label1:
				num1 = -165363823;
			Label5:
				while (true)
				{
					int num6 = num1 ^ -1892813784;
					num = (uint)num6;
					switch (num6 % 6)
					{
						case 0:
						{
							num5 = 1;
							num1 = (int)(num * -1436661727 ^ -443799543);
							continue;
						}
						case 1:
						{
							break;
						}
						case 2:
						{
							goto Label1;
						}
						case 3:
						{
							num2 = (num5 != 0 ? -408250268 : -82681595);
							num1 = (int)(num2 ^ num * -1716505793);
							continue;
						}
						case 5:
						{
							nums = this.u200f‪‍⁫⁭⁮‌‏⁭‍‏‭‪⁫‭⁮⁭‫‪‫⁬⁬‮⁫⁫​⁮‎⁪‪⁪‍⁬‮⁬‪‪‌‍⁬‮;
							num1 = (int)(num * 1537229766 ^ -1359905626);
							continue;
						}
						default:
						{
							goto Label2;
						}
					}
				}
			Label0:
				if (this.u200b‍⁯⁪‌‍‍‎‪⁯⁮⁪‬⁯⁮⁮‍⁫‫⁭⁯​⁮⁮‫⁫‪‭‪⁪‪⁬⁫‬‎‌‎⁬‎⁫‮.IsCc)
				{
					return;
				}
				num1 = -408298715;
				goto Label5;
			Label2:
				bool flag = false;
				try
				{
					TetraPanel.u200b‭⁭​⁬‪⁫‌‏⁬‎⁮‬‮‏⁭⁭‫‪‬‏⁪⁪‪‌‌‮​‭‍‪‪‏‬⁯‍‬‏⁯⁯‮(nums, ref flag);
				Label6:
					int num7 = -427620000;
					while (true)
					{
						int num8 = num7 ^ -1892813784;
						num = (uint)num8;
						switch (num8 % 5)
						{
							case 0:
							{
								goto Label6;
							}
							case 1:
							{
								goto Label7;
							}
							case 2:
							{
								this.u200f‪‍⁫⁭⁮‌‏⁭‍‏‭‪⁫‭⁮⁭‫‪‫⁬⁬‮⁫⁫​⁮‎⁪‪⁪‍⁬‮⁬‪‪‌‍⁬‮[num4].TXer = num5;
								num7 = (int)(num * 2025363626 ^ -134044321);
								continue;
							}
							case 3:
							{
								this.u200f‪‍⁫⁭⁮‌‏⁭‍‏‭‪⁫‭⁮⁭‫‪‫⁬⁬‮⁫⁫​⁮‎⁪‪⁪‍⁬‮⁬‪‪‌‍⁬‮[num4].WatchDog = 0;
								num7 = (int)(num * -1214904988 ^ 630275068);
								continue;
							}
							case 4:
							{
								num3 = (!this.u200f‪‍⁫⁭⁮‌‏⁭‍‏‭‪⁫‭⁮⁭‫‪‫⁬⁬‮⁫⁫​⁮‎⁪‪⁪‍⁬‮⁬‪‪‌‍⁬‮.ContainsKey(num4) ? -479458016 : -1231810482);
								num7 = (int)(num3 ^ num * 843549650);
								continue;
							}
						}
					}
				Label7:
				}
				finally
				{
					if (!flag)
					{
						goto Label8;
					}
				Label9:
					int num9 = -1910717285;
					while (true)
					{
						int num10 = num9 ^ -1892813784;
						num = (uint)num10;
						switch (num10 % 3)
						{
							case 0:
							{
								goto Label9;
							}
							case 1:
							{
								TetraPanel.u206b‭‍‫‭‪‌⁯⁫‌⁫‌‮‮‌‏⁪⁪​⁯‎‭⁫‪⁯⁭‭‎‏‍‌​‍‪⁮⁪‫‫‍‍‮(nums);
								num9 = (int)(num * 1912948721 ^ -405069476);
								continue;
							}
							case 2:
							{
								goto Label8;
							}
						}
					}
				Label8:
				}
			}
		}

		public static int ChangeCarrier
		{
			get;
			set;
		}

		public static bool ChangeFrequency
		{
			get;
			set;
		}

		public static int CurrentCallId
		{
			get;
			set;
		}

		public static int CurrentCarrier
		{
			get;
			set;
		}

		public static bool DmoMode
		{
			get;
			set;
		}

		public static bool ElementVerbosity
		{
			get;
			set;
		}

		public string GetSysInfo
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				int num;
				string str = u003cModuleu003e.u200f⁫‌​⁬‌‎‎‏‍‍⁫‎​‌‬⁯‬‫‭‎‏​‌​⁪‭‬⁬‮⁬​‌⁬⁪‫‫‎⁪⁮‮<string>(-1289513592);
				if (!this.u202a⁮‍⁫‬⁭‌⁬⁫⁭​‭‭⁫‍‮⁬⁮⁬‎‏‮‭​⁪‏‪‌⁭‭‪‭‍⁪‪‌⁭‫⁪⁬‮)
				{
					return str;
				}
			Label1:
				int num1 = -810043683;
				while (true)
				{
					int num2 = num1 ^ -860764389;
					uint num3 = (uint)num2;
					switch (num2 % 4)
					{
						case 0:
						{
							goto Label1;
						}
						case 1:
						{
							str = TetraPanel.u206b⁬⁮⁭⁬​⁫‫‍⁯‎‪‎‏⁯⁪‎‪‎‎‫⁪‌‌⁯‬‎⁪⁫‫‬‪‭‬⁬‫⁮⁪‪⁯‮(new object[] { this.u206d⁭⁯‭⁬‍⁭⁪‫‫⁭⁪⁬‏‮​‌‏​⁭⁯⁮‪⁭⁫⁫⁭‍‍‪‭‎‮‭⁯​‎⁮⁬‮‮, u003cModuleu003e.u200d​‍⁮‏‭⁮⁪‌‪‬‬‬‪⁬⁭⁫⁫‬⁪⁬⁬⁬‏⁮⁭‌‍‏‍‏‎‬⁬​‪‎​‎⁭‮<string>(-1959663536), this.u202d‍⁮⁬‍‫‮⁮⁯‏‭​‭‍​‌⁮‫⁫⁮‪‏‬⁭‎​​‬‮‫⁪‍‎‌‭‎⁫‪‏‭‮, u003cModuleu003e.u200d​‍⁮‏‭⁮⁪‌‪‬‬‬‪⁬⁭⁫⁫‬⁪⁬⁬⁬‏⁮⁭‌‍‏‍‏‎‬⁬​‪‎​‎⁭‮<string>(-1959663536), this.u200c‏‭‬⁮‎​⁯⁯‮‏‪⁫⁯​⁭‫‏‌⁬‬⁯‪‬‍‭‫‮⁫‮‭‏‌​⁮‌⁯⁫⁭⁮‮ });
							num1 = -1356210340;
							continue;
						}
						case 2:
						{
							num = (this.u206a‪⁭‎⁪‌‎‭⁭‎‏‬‪‏⁫‭‪⁫‍⁬⁫⁪‏⁪⁫​⁮‫⁯⁮‎⁭‪⁭‏‍⁮⁪‎⁬‮ ? -1315870392 : -1714412426);
							num1 = (int)(num ^ num3 * 672846119);
							continue;
						}
						case 3:
						{
							return str;
						}
					}
				}
				return str;
			}
		}

		public static int GssiDisplayType
		{
			get;
			set;
		}

		public static bool IgnoreEncodedData
		{
			get;
			set;
		}

		public static bool IsSDRPlay
		{
			get;
			set;
		}

		public static bool IsTttUsed
		{
			get;
			set;
		}

		public static bool LogMM
		{
			get;
			set;
		}

		public string NetInfoPosition
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				int num;
				string empty = string.Empty;
				if (!this.u200b‍⁯⁪‌‍‍‎‪⁯⁮⁪‬⁯⁮⁮‍⁫‫⁭⁯​⁮⁮‫⁫‪‭‪⁪‪⁬⁫‬‎‌‎⁬‎⁫‮.IsCc)
				{
					goto Label0;
				}
			Label2:
				num = -396687686;
			Label4:
				while (true)
				{
					int num1 = num ^ -1624092493;
					uint num2 = (uint)num1;
					switch (num1 % 9)
					{
						case 0:
						{
							empty = TetraPanel.u206e⁮⁫‏‮‌‪⁫‏‌‌⁬‮⁫‬⁬‫⁪‎⁫⁬‎​‮‎⁪⁭‬⁬​⁫‫‍​‎⁮⁯‪‫‪‮(empty, TetraPanel.u200d‪​⁭‭⁭‮‭⁪‪​⁫‪⁯‮⁬⁫⁯‪⁬⁬​‬⁯‍⁪‭‪⁭‪‍⁪‭⁮‮⁫‏‭‍⁭‮(this.u206e​‮⁪⁯⁭⁬‌‭‪‍‌‮⁬‭‏‫‫‬⁮⁭‎⁮​‫‍‎‪⁫‏‍‎‫‏‬⁪⁮‍​⁪‮), u003cModuleu003e.u200d​‍⁮‏‭⁮⁪‌‪‬‬‬‪⁬⁭⁫⁫‬⁪⁬⁬⁬‏⁮⁭‌‍‏‍‏‎‬⁬​‪‎​‎⁭‮<string>(-1959663536));
							num = -698359294;
							continue;
						}
						case 1:
						{
							empty = TetraPanel.u206a‬‍‬‍​‏‫‍‎‌‪⁭‍‭⁯‮‫⁪‮‮‫⁮⁮‪⁮‌‎‎⁬⁬‬‍‌‎‎‬⁭‍‌‮(empty, u003cModuleu003e.u200e‏‌‬⁮‪‭⁭‭⁭‎​‏‌‭‭‭⁭⁬⁯⁫‍‮‫⁯‌‮‏​‬⁫⁯⁮⁫‮‪⁫‬⁮⁬‮<string>(-788886354));
							num = -1454548643;
							continue;
						}
						case 2:
						{
							num = (int)(num2 * 814455306 ^ 1567665381);
							continue;
						}
						case 3:
						{
							break;
						}
						case 4:
						{
							empty = TetraPanel.u206e⁮⁫‏‮‌‪⁫‏‌‌⁬‮⁫‬⁬‫⁪‎⁫⁬‎​‮‎⁪⁭‬⁬​⁫‫‍​‎⁮⁯‪‫‪‮(empty, TetraPanel.u202a‫⁬‮‬‍‫⁮⁬‫⁭‮‭⁭‪‌‎‎‏‎⁬‏⁯‏‍⁮‭⁯​‌⁮⁬‬⁪‭‏⁮‪‏‌‮(this.u206e​‮⁪⁯⁭⁬‌‭‪‍‌‮⁬‭‏‫‫‬⁮⁭‎⁮​‫‍‎‪⁫‏‍‎‫‏‬⁪⁮‍​⁪‮), u003cModuleu003e.u200e‏‌‬⁮‪‭⁭‭⁭‎​‏‌‭‭‭⁭⁬⁯⁫‍‮‫⁯‌‮‏​‬⁫⁯⁮⁫‮‪⁫‬⁮⁬‮<string>(-421459766));
							empty = TetraPanel.u206e⁮⁫‏‮‌‪⁫‏‌‌⁬‮⁫‬⁬‫⁪‎⁫⁬‎​‮‎⁪⁭‬⁬​⁫‫‍​‎⁮⁯‪‫‪‮(empty, TetraPanel.u202c⁯⁭‮⁬​‎⁭⁯‮‌‭‫‌⁭⁪‪‍‮⁭⁯‬‪⁪⁪‍⁪‬⁬‭‌⁪⁪​⁯⁯‮⁮⁭‏‮(this.u206e​‮⁪⁯⁭⁬‌‭‪‍‌‮⁬‭‏‫‫‬⁮⁭‎⁮​‫‍‎‪⁫‏‍‎‫‏‬⁪⁮‍​⁪‮), u003cModuleu003e.u200e‏‌‬⁮‪‭⁭‭⁭‎​‏‌‭‭‭⁭⁬⁯⁫‍‮‫⁯‌‮‏​‬⁫⁯⁮⁫‮‪⁫‬⁮⁬‮<string>(-421459766));
							num = -199612456;
							continue;
						}
						case 5:
						{
							return empty;
						}
						case 6:
						{
							empty = TetraPanel.u206a‍⁯‪‌⁮⁭⁬‏‍​‏‮‏‌‏‫‭‌‌​⁬⁪⁭⁭⁪‍‭⁯⁪‬‏‎‫⁪‍⁮⁮‬‪‮(empty, (int)TetraPanel.u202d‎⁮‫‍‬​⁭⁪⁮‪‪⁯‪⁯⁯‭‪‫⁯⁮⁫⁯‮‍‎‪‏‪‮‪⁮​⁮​‬‪‬‎⁯‮(this.u206e​‮⁪⁯⁭⁬‌‭‪‍‌‮⁬‭‏‫‫‬⁮⁭‎⁮​‫‍‎‪⁫‏‍‎‫‏‬⁪⁮‍​⁪‮));
							num = (int)(num2 * -570706645 ^ 61207957);
							continue;
						}
						case 7:
						{
							empty = TetraPanel.u206e⁮⁫‏‮‌‪⁫‏‌‌⁬‮⁫‬⁬‫⁪‎⁫⁬‎​‮‎⁪⁭‬⁬​⁫‫‍​‎⁮⁯‪‫‪‮(empty, TetraPanel.u202b‏‫‬⁫‪⁯‮⁬⁯​‫‬‏⁯‪⁮‎‎⁭‬⁫‮‫‬⁪⁮⁭‍‎‪⁯‭⁭‭⁮‏⁮‎‫‮(this.u206e​‮⁪⁯⁭⁬‌‭‪‍‌‮⁬‭‏‫‫‬⁮⁭‎⁮​‫‍‎‪⁫‏‍‎‫‏‬⁪⁮‍​⁪‮), u003cModuleu003e.u202a‮‫‏‫‬‬‪⁫⁬​‏⁫⁭‍‪‪‎⁬​‪​‌⁮‮‌​⁫​⁬‪‫⁪⁯⁪‎‫⁭‎⁪‮<string>(1891866089));
							num = -1134592520;
							continue;
						}
						case 8:
						{
							goto Label2;
						}
						default:
						{
							return empty;
						}
					}
				}
			Label0:
				string str = empty;
				empty = TetraPanel.u206a‬‍‬‍​‏‫‍‎‌‪⁭‍‭⁯‮‫⁪‮‮‫⁮⁮‪⁮‌‎‎⁬⁬‬‍‌‎‎‬⁭‍‌‮(str, u003cModuleu003e.u206f⁮​‌‪‮‎‭‏‮‎⁮⁮‮⁬⁫‍‍⁪‍⁫⁮‏​‎⁬⁯⁪‪‍⁪⁮‎⁬⁪⁫​⁮⁪⁮‮<string>(2048335957));
				num = -866573399;
				goto Label4;
				return empty;
			}
			set
			{
				string[] strArrays = TetraPanel.u206c‬‬‫‬⁭‭​‮‮‫⁫‍‫⁪‪‏‪⁭‪⁮⁭⁯⁯⁮‫‍‍⁫⁭‮‍‌‬‍‍‮⁯⁮‭‮(value, new char[] { '|' });
			Label1:
				int num = 1146179123;
				while (true)
				{
					int num1 = num ^ 1168281273;
					uint num2 = (uint)num1;
					switch (num1 % 5)
					{
						case 0:
						{
							TetraPanel.u200e​⁬‪‎‫⁬‎‫⁪‌‎‭‪‎⁯‎‍‭⁮‏‍‫‏‎⁪‬‪‭‫​‬‮⁫‫‌‮⁯‌‏‮(this.u206e​‮⁪⁯⁭⁬‌‭‪‍‌‮⁬‭‏‫‫‬⁮⁭‎⁮​‫‍‎‪⁫‏‍‎‫‏‬⁪⁮‍​⁪‮, TetraPanel.u200f‫⁪⁬​⁯‍‍‌⁭⁪⁯⁪⁬‭‬⁯‎⁯‎⁪⁬⁯​‪⁬⁬‮‫‎‌‭‬‬‪‍‫⁬⁯⁮‮(strArrays[3]));
							TetraPanel.u202e‏​‮‮‏⁬⁬⁪‌‬‏‎​‮‎‍‬‪⁫⁮⁫⁪‭⁮‏‬​‭⁬⁮‪‏‮⁮‏⁮‍‏‌‮(this.u206e​‮⁪⁯⁭⁬‌‭‪‍‌‮⁬‭‏‫‫‬⁮⁭‎⁮​‫‍‎‪⁫‏‍‎‫‏‬⁪⁮‍​⁪‮, (FormWindowState)TetraPanel.u200f‫⁪⁬​⁯‍‍‌⁭⁪⁯⁪⁬‭‬⁯‎⁯‎⁪⁬⁯​‪⁬⁬‮‫‎‌‭‬‬‪‍‫⁬⁯⁮‮(strArrays[4]));
							num = (int)(num2 * 2024808203 ^ -941063617);
							continue;
						}
						case 1:
						{
							TetraPanel.u200c⁫‫‪​‍⁪‌⁯‏‍‏‌‍⁫‬‍⁫‎⁯​‍‫​‎⁯⁮⁮‌‬‮⁬‮⁮‎‌⁪‍​⁫‮(this.u206e​‮⁪⁯⁭⁬‌‭‪‍‌‮⁬‭‏‫‫‬⁮⁭‎⁮​‫‍‎‪⁫‏‍‎‫‏‬⁪⁮‍​⁪‮, TetraPanel.u200f‫⁪⁬​⁯‍‍‌⁭⁪⁯⁪⁬‭‬⁯‎⁯‎⁪⁬⁯​‪⁬⁬‮‫‎‌‭‬‬‪‍‫⁬⁯⁮‮(strArrays[2]));
							num = (int)(num2 * 2119587327 ^ 1690836676);
							continue;
						}
						case 2:
						{
							return;
						}
						case 3:
						{
							goto Label1;
						}
						case 4:
						{
							TetraPanel.u206d‬⁫‎‬‍⁪‬‏⁪‏‭‪‫‏‫⁬⁪‬⁭⁫‬⁫⁫‍⁯⁪⁯‌‍‪⁬‎‫‏‪⁭⁯‍‮‮(this.u206e​‮⁪⁯⁭⁬‌‭‪‍‌‮⁬‭‏‫‫‬⁮⁭‎⁮​‫‍‎‪⁫‏‍‎‫‏‬⁪⁮‍​⁪‮, TetraPanel.u200f‫⁪⁬​⁯‍‍‌⁭⁪⁯⁪⁬‭‬⁯‎⁯‎⁪⁬⁯​‪⁬⁬‮‫‎‌‭‬‬‪‍‫⁬⁯⁮‮(strArrays[0]));
							TetraPanel.u200f‌⁯​‌‏‭⁭‎⁯‌⁮‫⁬⁯‎⁫‍‌‬⁯‮‪⁯‏‍‭‍‎​‎‌⁬​‫‮⁬‪‌‌‮(this.u206e​‮⁪⁯⁭⁬‌‭‪‍‌‮⁬‭‏‫‫‬⁮⁭‎⁮​‫‍‎‪⁫‏‍‎‫‏‬⁪⁮‍​⁪‮, TetraPanel.u200f‫⁪⁬​⁯‍‍‌⁭⁪⁯⁪⁬‭‬⁯‎⁯‎⁪⁬⁯​‪⁬⁬‮‫‎‌‭‬‬‪‍‫⁬⁯⁮‮(strArrays[1]));
							num = (int)(num2 * -564748613 ^ 914200339);
							continue;
						}
					}
				}
			}
		}

		public int NetInfoTitle
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				int num;
				string empty = string.Empty;
			Label0:
				uint num1 = -533029515;
				while (true)
				{
					uint num2 = (uint)(num1 ^ -253232160);
					uint num3 = num2;
					switch (num2 % 8)
					{
						case 0:
						{
							goto Label0;
						}
						case 1:
						{
							num1 = (uint)((value == 1 ? -854311574 : -778122564));
							int num4 = (int)num1;
							continue;
						}
						case 2:
						{
							TetraPanel.u206d‫‫‫⁮‮‌​‍⁫‭‎‬​⁭‬⁫‪‌‍‍‎‮⁫‬⁭⁫‫‎⁯‏‌‮‮⁬‮⁬⁪‮(this.u206e​‮⁪⁯⁭⁬‌‭‪‍‌‮⁬‭‏‫‫‬⁮⁭‎⁮​‫‍‎‪⁫‏‍‎‫‏‬⁪⁮‍​⁪‮, u003cModuleu003e.u206f⁮​‌‪‮‎‭‏‮‎⁮⁮‮⁬⁫‍‍⁪‍⁫⁮‏​‎⁬⁯⁪‪‍⁪⁮‎⁬⁪⁫​⁮⁪⁮‮<string>(-146398733));
							num1 = -778122564;
							continue;
						}
						case 3:
						{
							TetraPanel.u206d‫‫‫⁮‮‌​‍⁫‭‎‬​⁭‬⁫‪‌‍‍‎‮⁫‬⁭⁫‫‎⁯‏‌‮‮⁬‮⁬⁪‮(this.u206e​‮⁪⁯⁭⁬‌‭‪‍‌‮⁬‭‏‫‫‬⁮⁭‎⁮​‫‍‎‪⁫‏‍‎‫‏‬⁪⁮‍​⁪‮, u003cModuleu003e.u200e‏‌‬⁮‪‭⁭‭⁭‎​‏‌‭‭‭⁭⁬⁯⁫‍‮‫⁯‌‮‏​‬⁫⁯⁮⁫‮‪⁫‬⁮⁬‮<string>(205484477));
							num1 = -884264057;
							continue;
						}
						case 4:
						{
							num1 = (uint)((value != 2 ? -884264057 : -275335365));
							int num5 = (int)num1;
							continue;
						}
						case 5:
						{
							num = (value == 0 ? 1826921665 : 1200060350);
							num1 = num ^ num3 * 1788142467;
							continue;
						}
						case 6:
						{
							TetraPanel.u206d‫‫‫⁮‮‌​‍⁫‭‎‬​⁭‬⁫‪‌‍‍‎‮⁫‬⁭⁫‫‎⁯‏‌‮‮⁬‮⁬⁪‮(this.u206e​‮⁪⁯⁭⁬‌‭‪‍‌‮⁬‭‏‫‫‬⁮⁭‎⁮​‫‍‎‪⁫‏‍‎‫‏‬⁪⁮‍​⁪‮, u003cModuleu003e.u200f⁫‌​⁬‌‎‎‏‍‍⁫‎​‌‬⁯‬‫‭‎‏​‌​⁪‭‬⁬‮⁬​‌⁬⁪‫‫‎⁪⁮‮<string>(-1337879167));
							num1 = -1260197247;
							continue;
						}
						case 7:
						{
							return;
						}
					}
				}
			}
		}

		public bool OpenNetInfoWindow
		{
			set
			{
				if (!value)
				{
					return;
				}
			Label1:
				int num = -1751622749;
				while (true)
				{
					int num1 = num ^ -1474481522;
					uint num2 = (uint)num1;
					switch (num1 % 3)
					{
						case 0:
						{
							return;
						}
						case 1:
						{
							TetraPanel.u200d⁯⁬​‮‎‪⁯‌⁬‬⁫⁬⁯⁭‬‍‫⁫‎‍​‬‫⁪‏⁮‮​‬‭⁪‮⁭⁪‮‎‫⁪‏‮(this, new Action(() => this.u200b⁮⁪‌⁭‪‭‌​‍‭‏‍‬​‌⁪‬‫‪‪⁮​⁬‎​‫‌⁯⁬​⁬‌‫‭⁮⁪‌‎⁯‮(true)));
							num = (int)(num2 * -1944490254 ^ -1822035863);
							continue;
						}
						case 2:
						{
							goto Label1;
						}
					}
				}
			}
		}

		public static string SdrSharpRole
		{
			get;
			set;
		}

		public int SdrSharpTitle
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				// 
				// Current member / type: System.Void SDRSharp.Tetra.TetraPanel::set_SdrSharpTitle(System.Int32)
				// File path: C:\SDRSharp\Plugins\Tetra\SDRSharp.Tetra.dll
				// 
				// Product version: 0.0.0.0
				// Exception in: System.Void set_SdrSharpTitle(System.Int32)
				// 
				// Not supported type System.Object.
				//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.GetTypeIndex(TypeDefinition type) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 684
				//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.GetContainingType(TypeDefinition leftType, TypeDefinition rightType) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 608
				//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.GetExpressionType() in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 492
				//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.get_ExpressionType() in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 414
				//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.AddAssignmentCastIfNeeded(Expression expr) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\TypeInference\TypeInferer.cs:line 112
				//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.FixAssignmentInList(IList`1 expressionList, Expression value) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\TypeInference\TypeInferer.cs:line 75
				//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.AddCasts() in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\TypeInference\TypeInferer.cs:line 38
				//    at Telerik.JustDecompiler.Decompiler.ExpressionDecompilerStep.Process(DecompilationContext theContext, BlockStatement body) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\ExpressionDecompilerStep.cs:line 68
				//    at Telerik.JustDecompiler.Decompiler.DecompilationPipeline.RunInternal(MethodBody body, BlockStatement block, ILanguage language) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\DecompilationPipeline.cs:line 100
				//    at Telerik.JustDecompiler.Decompiler.DecompilationPipeline.Run(MethodBody body, ILanguage language) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\DecompilationPipeline.cs:line 67
				//    at Telerik.JustDecompiler.Decompiler.PropertyDecompiler.DecompileMethod(MethodBody body, MethodSpecificContext& methodContext) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\PropertyDecompiler.cs:line 347
				// 
				// mailto: JustDecompilePublicFeedback@telerik.com

			}
		}

		public static bool SdsShowBinaryString
		{
			get;
			set;
		}

		public static bool ShowEncryptedCallDetails
		{
			get;
			set;
		}

		public static bool Sndcp_service_available
		{
			get;
			set;
		}

		public static bool StrongerBusrtDetection
		{
			get;
			set;
		}

		public int TcpReset
		{
			get
			{
				return -1;
			}
			set
			{
				this.ServerControl(false);
			Label0:
				int num = 1607317611;
				while (true)
				{
					int num1 = num ^ 1746154500;
					uint num2 = (uint)num1;
					switch (num1 % 3)
					{
						case 0:
						{
							goto Label0;
						}
						case 1:
						{
							this.ServerControl(true);
							num = (int)(num2 * -10955215 ^ 1108365470);
							continue;
						}
						case 2:
						{
							return;
						}
					}
				}
			}
		}

		public int TimeSlot
		{
			get
			{
				// 
				// Current member / type: System.Int32 SDRSharp.Tetra.TetraPanel::get_TimeSlot()
				// File path: C:\SDRSharp\Plugins\Tetra\SDRSharp.Tetra.dll
				// 
				// Product version: 0.0.0.0
				// Exception in: System.Int32 get_TimeSlot()
				// 
				// Not supported type System.Object.
				//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.GetTypeIndex(TypeDefinition type) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 684
				//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.GetContainingType(TypeDefinition leftType, TypeDefinition rightType) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 608
				//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.GetExpressionType() in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 492
				//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.get_ExpressionType() in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 414
				//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.AddAssignmentCastIfNeeded(Expression expr) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\TypeInference\TypeInferer.cs:line 112
				//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.FixAssignmentInList(IList`1 expressionList, Expression value) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\TypeInference\TypeInferer.cs:line 75
				//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.AddCasts() in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\TypeInference\TypeInferer.cs:line 38
				//    at Telerik.JustDecompiler.Decompiler.ExpressionDecompilerStep.Process(DecompilationContext theContext, BlockStatement body) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\ExpressionDecompilerStep.cs:line 68
				//    at Telerik.JustDecompiler.Decompiler.DecompilationPipeline.RunInternal(MethodBody body, BlockStatement block, ILanguage language) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\DecompilationPipeline.cs:line 100
				//    at Telerik.JustDecompiler.Decompiler.DecompilationPipeline.Run(MethodBody body, ILanguage language) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\DecompilationPipeline.cs:line 67
				//    at Telerik.JustDecompiler.Decompiler.PropertyDecompiler.DecompileMethod(MethodBody body, MethodSpecificContext& methodContext) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\PropertyDecompiler.cs:line 347
				// 
				// mailto: JustDecompilePublicFeedback@telerik.com

			}
			set
			{
				// 
				// Current member / type: System.Void SDRSharp.Tetra.TetraPanel::set_TimeSlot(System.Int32)
				// File path: C:\SDRSharp\Plugins\Tetra\SDRSharp.Tetra.dll
				// 
				// Product version: 0.0.0.0
				// Exception in: System.Void set_TimeSlot(System.Int32)
				// 
				// Not supported type System.Object.
				//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.GetTypeIndex(TypeDefinition type) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 684
				//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.GetContainingType(TypeDefinition leftType, TypeDefinition rightType) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 608
				//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.GetExpressionType() in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 492
				//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.get_ExpressionType() in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 414
				//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.AddAssignmentCastIfNeeded(Expression expr) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\TypeInference\TypeInferer.cs:line 112
				//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.FixAssignmentInList(IList`1 expressionList, Expression value) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\TypeInference\TypeInferer.cs:line 75
				//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.AddCasts() in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\TypeInference\TypeInferer.cs:line 38
				//    at Telerik.JustDecompiler.Decompiler.ExpressionDecompilerStep.Process(DecompilationContext theContext, BlockStatement body) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\ExpressionDecompilerStep.cs:line 68
				//    at Telerik.JustDecompiler.Decompiler.DecompilationPipeline.RunInternal(MethodBody body, BlockStatement block, ILanguage language) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\DecompilationPipeline.cs:line 100
				//    at Telerik.JustDecompiler.Decompiler.DecompilationPipeline.Run(MethodBody body, ILanguage language) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\DecompilationPipeline.cs:line 67
				//    at Telerik.JustDecompiler.Decompiler.PropertyDecompiler.DecompileMethod(MethodBody body, MethodSpecificContext& methodContext) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\PropertyDecompiler.cs:line 347
				// 
				// mailto: JustDecompilePublicFeedback@telerik.com

			}
		}

		public int TttInit
		{
			set
			{
				// 
				// Current member / type: System.Void SDRSharp.Tetra.TetraPanel::set_TttInit(System.Int32)
				// File path: C:\SDRSharp\Plugins\Tetra\SDRSharp.Tetra.dll
				// 
				// Product version: 0.0.0.0
				// Exception in: System.Void set_TttInit(System.Int32)
				// 
				// Not supported type System.Object.
				//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.GetTypeIndex(TypeDefinition type) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 684
				//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.GetContainingType(TypeDefinition leftType, TypeDefinition rightType) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 608
				//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.GetExpressionType() in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 492
				//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.get_ExpressionType() in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 414
				//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.AddAssignmentCastIfNeeded(Expression expr) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\TypeInference\TypeInferer.cs:line 112
				//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.FixAssignmentInList(IList`1 expressionList, Expression value) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\TypeInference\TypeInferer.cs:line 75
				//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.AddCasts() in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\TypeInference\TypeInferer.cs:line 38
				//    at Telerik.JustDecompiler.Decompiler.ExpressionDecompilerStep.Process(DecompilationContext theContext, BlockStatement body) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\ExpressionDecompilerStep.cs:line 68
				//    at Telerik.JustDecompiler.Decompiler.DecompilationPipeline.RunInternal(MethodBody body, BlockStatement block, ILanguage language) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\DecompilationPipeline.cs:line 100
				//    at Telerik.JustDecompiler.Decompiler.DecompilationPipeline.Run(MethodBody body, ILanguage language) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\DecompilationPipeline.cs:line 67
				//    at Telerik.JustDecompiler.Decompiler.PropertyDecompiler.DecompileMethod(MethodBody body, MethodSpecificContext& methodContext) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\PropertyDecompiler.cs:line 347
				// 
				// mailto: JustDecompilePublicFeedback@telerik.com

			}
		}

		public bool TttRole
		{
			get
			{
				return this.u200b‍⁯⁪‌‍‍‎‪⁯⁮⁪‬⁯⁮⁮‍⁫‫⁭⁯​⁮⁮‫⁫‪‭‪⁪‪⁬⁫‬‎‌‎⁬‎⁫‮.IsCc;
			}
		}

		public int UsageMarker1
		{
			get
			{
				return this.u202e‬‍‮‏​⁭‎‫⁮⁬‏⁪‫⁯‎⁭‎‌⁫‪‪‫‮⁬‭‫⁯‌⁬‬‭⁪‭⁬‮‭⁪⁪‬‮;
			}
			set
			{
				this.u202e‬‍‮‏​⁭‎‫⁮⁬‏⁪‫⁯‎⁭‎‌⁫‪‪‫‮⁬‭‫⁯‌⁬‬‭⁪‭⁬‮‭⁪⁪‬‮ = value;
			}
		}

		public int UsageMarker2
		{
			get
			{
				return this.u202a⁮​⁮‪‫‏‬⁮⁬‌‍⁫‏‬‬⁬⁬‌⁮‍⁫⁭‏​⁪‌⁮⁯⁬‍⁮‬⁮‎‌‏‬‎‭‮;
			}
			set
			{
				this.u202a⁮​⁮‪‫‏‬⁮⁬‌‍⁫‏‬‬⁬⁬‌⁮‍⁫⁭‏​⁪‌⁮⁯⁬‍⁮‬⁮‎‌‏‬‎‭‮ = value;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		// ‎‬‌⁮⁬‌​⁯⁯⁯⁮‬⁭‏‬⁮‍⁯‏⁬⁯‍⁫⁭⁭⁬​⁬​‌‭⁯⁫‫‏‏‭⁫‏‪‮
		private void u200e‬‌⁮⁬‌​⁯⁯⁯⁮‬⁭‏‬⁮‍⁯‏⁬⁯‍⁫⁭⁭⁬​⁬​‌‭⁯⁫‫‏‏‭⁫‏‪‮()
		{
			this.u200c⁫⁯⁬‪‌‬‭‫‭​‪​⁯‮⁪‫⁫⁯⁪‏‌⁬⁮‬‌‬⁭‭⁮⁯‮‬⁮‏‫⁯​‭‏‮ = TetraPanel.u202e‍‬‎‫‪​⁭⁪‮⁯⁯‬⁮‏‫⁭‭‬‏‪⁯⁪⁫​⁬‌⁫‍⁮‌‌‮‌‬‏‎‪​⁫‮();
		Label1:
			int num = 1431990961;
			while (true)
			{
				int num1 = num ^ 1916928102;
				uint num2 = (uint)num1;
				switch (num1 % 326)
				{
					case 0:
					{
						TetraPanel.u202e‎‫‪⁮‏‪‎​⁬‮‎⁪⁪⁫‭⁯‌‏‬​‏⁫⁭‬⁫‎‬⁯‎⁪‏⁮​‍⁯⁫⁮⁯‫‮(this.u200d‮⁪⁭⁭‍⁯‮‭‏‏⁭‬‫⁮⁯‬⁫‬‪⁫‎⁭‭​⁫‪⁬⁮⁫‍⁭​⁭‌⁪​⁪‭⁯‮);
						TetraPanel.u206a‪⁭​⁫‮‍‬‭⁬‮‬‫‪⁬‎‌‭⁬‬‭‪‌‫⁮⁫⁫‪‍⁭⁬​‌⁪⁪⁯‮​‫‬‮(this.u202b‫‌‍⁭‎‮⁮‍‮‎‏⁮‭‌⁭⁫‮⁮‭‎‏⁮⁮‌‌‫‬‪⁬⁬‏‌‭‌‫‌‭‭⁭‮);
						num = (int)(num2 * -1423024399 ^ 1762360475);
						continue;
					}
					case 1:
					{
						TetraPanel.u206e⁪‏‏​‍⁮‫⁬⁬⁯⁫⁯‏⁬⁮‫‫⁬⁬‭‫‌‌⁭‎​‭⁭‍⁬‏‏⁮‫⁮‭‮‎‪‮(this.u200f‫‮⁭⁭‬‌‪⁭‭‭‬⁮‪‮⁬⁬​⁮⁫‍⁮‍​⁮‫‪‮‎⁪⁬‎⁮⁭⁯⁯⁮‮‪⁭‮, u003cModuleu003e.u206f⁮​‌‪‮‎‭‏‮‎⁮⁮‮⁬⁫‍‍⁪‍⁫⁮‏​‎⁬⁯⁪‪‍⁪⁮‎⁬⁪⁫​⁮⁪⁮‮<string>(424438018));
						num = 1150014008;
						continue;
					}
					case 2:
					{
						TetraPanel.u206b⁬‪‍‭⁮⁪‌‭⁯⁪⁪‏‌‪⁯⁭‮​‭‏‌⁮⁯⁪‪‬​⁮⁯‮⁫⁮‪‪‫‍⁪⁬‎‮(this.u200d‌‏‪‍‭⁯‎⁫⁪⁮⁮‍‮⁪⁫⁮⁬‎⁭⁫⁬‭‎⁯‪‍‏‌⁭⁯⁯‬‫‌‭⁮‬‭⁭‮, 27);
						TetraPanel.u206e⁮⁭‎⁮⁪‮‌‏‫‫‌⁮⁬‮⁫⁮⁪⁫⁪‬‪​⁭⁯‭⁬‌‍‭⁪⁮‪⁯‎‬‪⁪‍⁯‮(this.u200d‌‏‪‍‭⁯‎⁫⁪⁮⁮‍‮⁪⁫⁮⁬‎⁭⁫⁬‭‎⁯‪‍‏‌⁭⁯⁯‬‫‌‭⁮‬‭⁭‮, new EventHandler(this.u206e‬‭⁫‎​‬⁪⁬‪‎‮‪‪‌‮‭‮⁬⁬​⁫‍‎‫⁫‌‪⁭⁯‏‌‍‪‬⁫‏⁭‮‍‮));
						num = (int)(num2 * -968183498 ^ 2086475675);
						continue;
					}
					case 3:
					{
						TetraPanel.u202c⁭⁫‪‏⁬⁭⁭​​⁪⁫‬‍⁪⁫⁭⁬‮‌⁭‫‮‭​⁫‌⁪‎‏⁪‫‮‌​‌‍⁮⁮⁮‮(this.u206e‬​⁯⁫‍‎​‮⁬⁮‍‫‪‬‌‌‭⁯⁫‮‫‮⁭‮‫‪‫⁮‫⁪‏‏‏‫‏‭⁬⁬‍‮, new System.Drawing.Size(51, 17));
						num = (int)(num2 * -428989672 ^ 804978343);
						continue;
					}
					case 4:
					{
						TetraPanel.u200e‭⁭‌‪‫​⁯⁫⁫‪⁯‍⁯⁯⁭‎⁫‮⁮​​‭‎‮‍‏‎‎⁪‌⁫‬‮⁮‌⁮‏⁭⁪‮(this.u202b⁭‎‭‭‏⁮⁮‮‮‍⁫⁫‎‏‏‌‬‏‬‭‮‪‌⁪‎‏⁫‫‬‬‏‎⁫⁬⁯‌⁭⁪‪‮, true);
						TetraPanel.u202b‏‏‬‎‮‫​‍​⁭‬‬‭‮⁫⁯‭⁪‬‎‫‫‎⁬‪‍‎⁪⁪‮‌‮‌‏⁯‌‍​‌‮(this.u202b⁭‎‭‭‏⁮⁮‮‮‍⁫⁫‎‏‏‌‬‏‬‭‮‪‌⁪‎‏⁫‫‬‬‏‎⁫⁬⁯‌⁭⁪‪‮, TetraPanel.u202c‫‭‪‌‌⁬‌⁬‌‪‬‏‌‍⁯⁪‮⁪‮‌‪⁪⁯‭⁮‪‪⁪‬‭​‬‭‮‍‭‌‍‮(u003cModuleu003e.u200e‏‌‬⁮‪‭⁭‭⁭‎​‏‌‭‭‭⁭⁬⁯⁫‍‮‫⁯‌‮‏​‬⁫⁯⁮⁫‮‪⁫‬⁮⁬‮<string>(507840788), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0));
						TetraPanel.u202b‎⁯‫‮⁬‏‪⁫‍⁫‭​⁭‎​‎‮⁬‍‏‏‎⁯​⁭⁫‏‫‌‌‪‪​‬⁬⁭‫⁮‮‮(this.u202b⁭‎‭‭‏⁮⁮‮‮‍⁫⁫‎‏‏‌‬‏‬‭‮‪‌⁪‎‏⁫‫‬‬‏‎⁫⁬⁯‌⁭⁪‪‮, new Point(90, 74));
						TetraPanel.u206e⁪‏‏​‍⁮‫⁬⁬⁯⁫⁯‏⁬⁮‫‫⁬⁬‭‫‌‌⁭‎​‭⁭‍⁬‏‏⁮‫⁮‭‮‎‪‮(this.u202b⁭‎‭‭‏⁮⁮‮‮‍⁫⁫‎‏‏‌‬‏‬‭‮‪‌⁪‎‏⁫‫‬‬‏‎⁫⁬⁯‌⁭⁪‪‮, u003cModuleu003e.u200d​‍⁮‏‭⁮⁪‌‪‬‬‬‪⁬⁭⁫⁫‬⁪⁬⁬⁬‏⁮⁭‌‍‏‍‏‎‬⁬​‪‎​‎⁭‮<string>(-307521123));
						num = 215127453;
						continue;
					}
					case 5:
					{
						TetraPanel.u200f‍​‍⁯‏‫‫‏‮⁬​‎⁬‍‪⁪‎‫‌‮‎‪‌‌‮⁪⁪‌‭⁭‮⁭​‎⁭⁪‬⁮‎‮(this.u206e⁭‫‬‫⁪‭‍‏⁫⁭​​‏‌‭⁭⁫‏⁮⁪‏‎‫⁯‭⁯‍⁮​‫‫⁪⁮⁫‎‬‫‌⁯‮, new EventHandler(this.u206a‎‎‪‬‭‎‌‮⁫⁫⁪‫‭⁫‏‪‫‪⁮‎‍⁪⁭‌‍‮‬‫‪‭⁮​⁭‪‎‏⁮​‬‮));
						num = (int)(num2 * -1170006672 ^ 2046297081);
						continue;
					}
					case 6:
					{
						this.u202e⁬⁬​‫⁪‍‍‏‌‏‬‌⁫‮⁫⁮‏⁬‭‭⁬‏⁫⁪‬‎⁪⁪‪‪‏‫⁮‭‪⁭‬‎‪‮ = TetraPanel.u200b‬‌⁯‫‪⁪⁯​‭‬‌‭⁯⁮⁮‏​‪‬⁯‭‪​⁫‮​‪‬‬​‌‏⁬⁪‪‏⁪‏⁬‮();
						this.u202a‌⁯‌⁮‍‎‏⁭‌‮‭‌‏‎⁬⁯⁭‌‎⁪‪⁪‎⁪‏⁯⁪⁯​‪⁭‭‫⁬​⁭⁯⁯⁬‮ = TetraPanel.u200b‬‌⁯‫‪⁪⁯​‭‬‌‭⁯⁮⁮‏​‪‬⁯‭‪​⁫‮​‪‬‬​‌‏⁬⁪‪‏⁪‏⁬‮();
						this.u200e​⁭⁯​‏‏‎‭⁮‍‮⁬‪‮‪⁮‫⁭‏‍⁬‍‎‏‪‫‪‮⁪‍⁫‮‍⁪‬‏‭‮‏‮ = TetraPanel.u200b‬‌⁯‫‪⁪⁯​‭‬‌‭⁯⁮⁮‏​‪‬⁯‭‪​⁫‮​‪‬‬​‌‏⁬⁪‪‏⁪‏⁬‮();
						num = (int)(num2 * 1676993626 ^ -1111707070);
						continue;
					}
					case 7:
					{
						TetraPanel.u206e⁪‏‏​‍⁮‫⁬⁬⁯⁫⁯‏⁬⁮‫‫⁬⁬‭‫‌‌⁭‎​‭⁭‍⁬‏‏⁮‫⁮‭‮‎‪‮(this.u202c⁭‎‫‮‌⁯⁮‍‎⁪⁪⁬‭⁮‏‎‌‌‎‌⁯‪‮⁯‌⁮‌‭⁯‎‍‌⁪‍‭‏⁪‬‮, u003cModuleu003e.u200e‏‌‬⁮‪‭⁭‭⁭‎​‏‌‭‭‭⁭⁬⁯⁫‍‮‫⁯‌‮‏​‬⁫⁯⁮⁫‮‪⁫‬⁮⁬‮<string>(-573068488));
						num = 1800903284;
						continue;
					}
					case 8:
					{
						this.u202b‫‭‪⁯⁯⁮‎⁫⁫⁮‫⁪⁯⁮⁭⁫‎‏⁮⁭‭⁪‌⁯⁪⁪‍⁯⁯‌⁫‪‮⁭‌⁪‎‬⁫‮ = TetraPanel.u200b‬‌⁯‫‪⁪⁯​‭‬‌‭⁯⁮⁮‏​‪‬⁯‭‪​⁫‮​‪‬‬​‌‏⁬⁪‪‏⁪‏⁬‮();
						num = (int)(num2 * -816547068 ^ 523573041);
						continue;
					}
					case 9:
					{
						TetraPanel.u202d‏⁭⁫‮‫​‎‪⁫⁯‏⁮‫​‮‌⁮‬⁬‌⁮⁬‏⁭‏⁮‌⁮‮⁮‭‌‫‏⁪‎⁮‏‎‮(TetraPanel.u206a‬⁯⁭⁫‍⁪‫⁬⁭⁬⁮‫‏‍⁫‫‌⁪‪‌​⁭⁮‍‌‬⁯‭⁪‭⁮‏⁮‪​‍⁭⁫⁫‮(this.u200d‮⁪⁭⁭‍⁯‮‭‏‏⁭‬‫⁮⁯‬⁫‬‪⁫‎⁭‭​⁫‪⁬⁮⁫‍⁭​⁭‌⁪​⁪‭⁯‮), this.u202e⁮‍‍⁮‎⁪⁫⁫‍‮‭‬‍⁪‪‮⁭‬⁫⁯‪⁯​⁪‬‫​⁬‭‭⁯‫‎⁮‏​​‬‎‮);
						num = (int)(num2 * -108927088 ^ -1626216204);
						continue;
					}
					case 10:
					{
						TetraPanel.u206a‏⁫‫​‏⁪⁬⁪‪⁪⁬‬⁫⁯‎‪⁯‫‎⁯‪‭‎‮‪‎⁮⁯‭⁯‎⁮⁮‪‭⁫‬⁫⁬‮(this.u200f⁫⁭⁬​‮‫‭‪‬‏⁯‭‎‭⁫‌⁬⁮‭‮‌‮⁫⁫‭‎‪‎‎​⁫‎⁮⁭⁯⁫‌‮‫‮, false);
						num = (int)(num2 * -1486006302 ^ -1734744083);
						continue;
					}
					case 11:
					{
						TetraPanel.u200f‍​‍⁯‏‫‫‏‮⁬​‎⁬‍‪⁪‎‫‌‮‎‪‌‌‮⁪⁪‌‭⁭‮⁭​‎⁭⁪‬⁮‎‮(this.u200d‎‫‎‪​‍‏‍⁯‫⁬⁮‌‫⁭‏​​‏⁫‬⁬‎‭‍⁫‌⁬‬⁬‬⁬‏‎⁮​‬⁫⁪‮, new EventHandler(this.u200b‍​‏‎‏‌⁯⁪⁭⁮⁪‫⁫​‏⁮‍⁯⁪⁭‪‭⁭⁬‮⁬⁯‌‎⁫‭‍‍‍⁪‬‮⁫‮‮));
						TetraPanel.u202b‪​⁯⁪⁬⁬‭‍⁪‫‪​‮‍‭‎‍⁯‫‭⁮‭​⁯​‍⁬‌‭‭⁯⁭‭‬‍‭‎‎⁭‮(this.u206e​‏‫⁮‏⁯​‬‭⁯‮‪⁭‭⁮​‭⁯⁯‮‎‏​‌‮​⁫‬‍‎‏‭⁯‎‏‬⁫⁭‏‮, 30);
						TetraPanel.u200f‍​‍⁯‏‫‫‏‮⁬​‎⁬‍‪⁪‎‫‌‮‎‪‌‌‮⁪⁪‌‭⁭‮⁭​‎⁭⁪‬⁮‎‮(this.u206e​‏‫⁮‏⁯​‬‭⁯‮‪⁭‭⁮​‭⁯⁯‮‎‏​‌‮​⁫‬‍‎‏‭⁯‎‏‬⁫⁭‏‮, new EventHandler(this.u200e​‎​⁮⁬‮​⁯⁭‏​‮‌‮‭‏‌⁫‎‫‫‌⁭​‍‭⁫​‭⁭‮‌⁭‍⁮‬⁫‮⁯‮));
						num = (int)(num2 * -764087390 ^ 259950358);
						continue;
					}
					case 12:
					{
						TetraPanel.u206b⁬‪‍‭⁮⁪‌‭⁯⁪⁪‏‌‪⁯⁭‮​‭‏‌⁮⁯⁪‪‬​⁮⁯‮⁫⁮‪‪‫‍⁪⁬‎‮(this.u200e‎⁭‏‎‪‎‍‬⁭⁮⁬‍⁭‮​⁪‮‏‍⁪‎‫⁮‫⁭⁯⁪‌‌​‌⁬‫‏‬‍⁯⁮‭‮, 60);
						num = (int)(num2 * 468630048 ^ 169097185);
						continue;
					}
					case 13:
					{
						TetraPanel.u202e⁯‮​‏‬⁭‬⁯⁯⁭‎⁯‮‎​‮⁪⁮‭‌⁮⁭‬‫⁭⁭‮‮⁯‪‫⁭⁬‌⁭‬‏⁬‬‮(this.u200b‏⁭⁯⁮⁬‭‮⁭⁯‮​‏‭⁬⁮‫⁬⁬‬‮‏‏‎‮⁫⁬⁭⁮​​⁮⁪⁭⁭​‫‫‮, new EventHandler(this.u206c‮‭‬‬‭‮‭‌‍‪‮⁬⁪⁬​‌‏⁪‍⁮⁫‭‬⁮⁪⁪‎‍‫⁪‬⁬‮⁯‏‮​‪‭‮));
						num = (int)(num2 * 1362515362 ^ 315527789);
						continue;
					}
					case 14:
					{
						TetraPanel.u206e⁪‏‏​‍⁮‫⁬⁬⁯⁫⁯‏⁬⁮‫‫⁬⁬‭‫‌‌⁭‎​‭⁭‍⁬‏‏⁮‫⁮‭‮‎‪‮(this.u202a‎‎‭⁭⁬‎⁬‏⁫⁬⁯‫‎‬‪‏⁬‪‬‭‌‪‌‎⁯‪‪‫​‪​⁮‫‭‌⁮​⁪⁬‮, u003cModuleu003e.u202a‮‫‏‫‬‬‪⁫⁬​‏⁫⁭‍‪‪‎⁬​‪​‌⁮‮‌​⁫​⁬‪‫⁪⁯⁪‎‫⁭‎⁪‮<string>(892197655));
						num = 707864418;
						continue;
					}
					case 15:
					{
						TetraPanel.u206d‫‫‫⁮‮‌​‍⁫‭‎‬​⁭‬⁫‪‌‍‍‎‮⁫‬⁭⁫‫‎⁯‏‌‮‮⁬‮⁬⁪‮(this.u200c‫‌‪‌‌‏​⁯⁪​‫⁪⁮⁯‫‍⁪⁫⁪‮⁬⁬‭⁯‌‫⁯‫‪‏‭‏⁭⁬‌‫‬⁪⁬‮, u003cModuleu003e.u202a‮‫‏‫‬‬‪⁫⁬​‏⁫⁭‍‪‪‎⁬​‪​‌⁮‮‌​⁫​⁬‪‫⁪⁯⁪‎‫⁭‎⁪‮<string>(1609488626));
						TetraPanel.u200e‭⁭‌‪‫​⁯⁫⁫‪⁯‍⁯⁯⁭‎⁫‮⁮​​‭‎‮‍‏‎‎⁪‌⁫‬‮⁮‌⁮‏⁭⁪‮(this.u202a‪‬⁭‮⁬⁫‫⁬‮‏‪‪‭‎‌‫‪‍⁭‏⁮⁬‭⁪⁯‍‍⁭‪‏‫‮​⁪⁭⁪‪‬‮, true);
						TetraPanel.u202b‏‏‬‎‮‫​‍​⁭‬‬‭‮⁫⁯‭⁪‬‎‫‫‎⁬‪‍‎⁪⁪‮‌‮‌‏⁯‌‍​‌‮(this.u202a‪‬⁭‮⁬⁫‫⁬‮‏‪‪‭‎‌‫‪‍⁭‏⁮⁬‭⁪⁯‍‍⁭‪‏‫‮​⁪⁭⁪‪‬‮, TetraPanel.u202c‫‭‪‌‌⁬‌⁬‌‪‬‏‌‍⁯⁪‮⁪‮‌‪⁪⁯‭⁮‪‪⁪‬‭​‬‭‮‍‭‌‍‮(u003cModuleu003e.u200d​‍⁮‏‭⁮⁪‌‪‬‬‬‪⁬⁭⁫⁫‬⁪⁬⁬⁬‏⁮⁭‌‍‏‍‏‎‬⁬​‪‎​‎⁭‮<string>(2136952738), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0));
						TetraPanel.u202b‎⁯‫‮⁬‏‪⁫‍⁫‭​⁭‎​‎‮⁬‍‏‏‎⁯​⁭⁫‏‫‌‌‪‪​‬⁬⁭‫⁮‮‮(this.u202a‪‬⁭‮⁬⁫‫⁬‮‏‪‪‭‎‌‫‪‍⁭‏⁮⁬‭⁪⁯‍‍⁭‪‏‫‮​⁪⁭⁪‪‬‮, new Point(71, 469));
						num = 129935;
						continue;
					}
					case 16:
					{
						TetraPanel.u206b⁬‪‍‭⁮⁪‌‭⁯⁪⁪‏‌‪⁯⁭‮​‭‏‌⁮⁯⁪‪‬​⁮⁯‮⁫⁮‪‪‫‍⁪⁬‎‮(this.u200f‏⁪‪⁪‪⁯‪‌⁬‎‪‬‫⁯‭‬‌⁯‏⁮⁫‪⁯‬⁪⁭⁭‪‪‌‍‭‎⁭⁫⁯⁯​‏‮, 71);
						TetraPanel.u206d‫‫‫⁮‮‌​‍⁫‭‎‬​⁭‬⁫‪‌‍‍‎‮⁫‬⁭⁫‫‎⁯‏‌‮‮⁬‮⁬⁪‮(this.u200f‏⁪‪⁪‪⁯‪‌⁬‎‪‬‫⁯‭‬‌⁯‏⁮⁫‪⁯‬⁪⁭⁭‪‪‌‍‭‎⁭⁫⁯⁯​‏‮, u003cModuleu003e.u206f⁮​‌‪‮‎‭‏‮‎⁮⁮‮⁬⁫‍‍⁪‍⁫⁮‏​‎⁬⁯⁪‪‍⁪⁮‎⁬⁪⁫​⁮⁪⁮‮<string>(-1160869617));
						num = 1061730592;
						continue;
					}
					case 17:
					{
						TetraPanel.u202b‏‏‬‎‮‫​‍​⁭‬‬‭‮⁫⁯‭⁪‬‎‫‫‎⁬‪‍‎⁪⁪‮‌‮‌‏⁯‌‍​‌‮(this.u200f⁫⁭⁬​‮‫‭‪‬‏⁯‭‎‭⁫‌⁬⁮‭‮‌‮⁫⁫‭‎‪‎‎​⁫‎⁮⁭⁯⁫‌‮‫‮, TetraPanel.u202c‫‭‪‌‌⁬‌⁬‌‪‬‏‌‍⁯⁪‮⁪‮‌‪⁪⁯‭⁮‪‪⁪‬‭​‬‭‮‍‭‌‍‮(u003cModuleu003e.u206f⁮​‌‪‮‎‭‏‮‎⁮⁮‮⁬⁫‍‍⁪‍⁫⁮‏​‎⁬⁯⁪‪‍⁪⁮‎⁬⁪⁫​⁮⁪⁮‮<string>(125941577), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0));
						TetraPanel.u202b‎⁯‫‮⁬‏‪⁫‍⁫‭​⁭‎​‎‮⁬‍‏‏‎⁯​⁭⁫‏‫‌‌‪‪​‬⁬⁭‫⁮‮‮(this.u200f⁫⁭⁬​‮‫‭‪‬‏⁯‭‎‭⁫‌⁬⁮‭‮‌‮⁫⁫‭‎‪‎‎​⁫‎⁮⁭⁯⁫‌‮‫‮, new Point(1, 485));
						num = 1499684653;
						continue;
					}
					case 18:
					{
						TetraPanel.u202c⁭⁫‪‏⁬⁭⁭​​⁪⁫‬‍⁪⁫⁭⁬‮‌⁭‫‮‭​⁫‌⁪‎‏⁪‫‮‌​‌‍⁮⁮⁮‮(this.u200c‎‏⁪⁭⁬⁫‎⁭‪⁫⁫‮​⁯‫‪‏‮‮‬‬⁬‍⁭⁯‪⁪⁫⁬‬⁫‬‍⁮‍⁭‪‭⁪‮, new System.Drawing.Size(0, 13));
						TetraPanel.u206b⁬‪‍‭⁮⁪‌‭⁯⁪⁪‏‌‪⁯⁭‮​‭‏‌⁮⁯⁪‪‬​⁮⁯‮⁫⁮‪‪‫‍⁪⁬‎‮(this.u200c‎‏⁪⁭⁬⁫‎⁭‪⁫⁫‮​⁯‫‪‏‮‮‬‬⁬‍⁭⁯‪⁪⁫⁬‬⁫‬‍⁮‍⁭‪‭⁪‮, 86);
						num = (int)(num2 * 1203893099 ^ -206568127);
						continue;
					}
					case 19:
					{
						TetraPanel.u206b⁬‪‍‭⁮⁪‌‭⁯⁪⁪‏‌‪⁯⁭‮​‭‏‌⁮⁯⁪‪‬​⁮⁯‮⁫⁮‪‪‫‍⁪⁬‎‮(this.u202e⁬⁬​‫⁪‍‍‏‌‏‬‌⁫‮⁫⁮‏⁬‭‭⁬‏⁫⁪‬‎⁪⁪‪‪‏‫⁮‭‪⁭‬‎‪‮, 64);
						num = (int)(num2 * -649227664 ^ 1036617015);
						continue;
					}
					case 20:
					{
						TetraPanel.u202b‏‏‬‎‮‫​‍​⁭‬‬‭‮⁫⁯‭⁪‬‎‫‫‎⁬‪‍‎⁪⁪‮‌‮‌‏⁯‌‍​‌‮(this.u200d‮⁪⁭⁭‍⁯‮‭‏‏⁭‬‫⁮⁯‬⁫‬‪⁫‎⁭‭​⁫‪⁬⁮⁫‍⁭​⁭‌⁪​⁪‭⁯‮, TetraPanel.u202c‫‭‪‌‌⁬‌⁬‌‪‬‏‌‍⁯⁪‮⁪‮‌‪⁪⁯‭⁮‪‪⁪‬‭​‬‭‮‍‭‌‍‮(u003cModuleu003e.u206f⁮​‌‪‮‎‭‏‮‎⁮⁮‮⁬⁫‍‍⁪‍⁫⁮‏​‎⁬⁯⁪‪‍⁪⁮‎⁬⁪⁫​⁮⁪⁮‮<string>(125941577), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0));
						num = 1781752621;
						continue;
					}
					case 21:
					{
						TetraPanel.u200e​⁮⁯‮⁭‬‭⁫⁭⁬‌‭‎⁬⁬⁮⁬‭‬⁮‭‏⁫‫​‮‌‬⁪​‮⁮‪‪⁭‮⁪‍⁮‮(this.u200e⁫​‭⁪‫‏‬‮⁭⁬‌‏⁮⁮​‍‍‎‍‭‍‎​‪‪‭⁪‏‎⁬‎‍‫‮​⁬⁮⁯‫‮, AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
						num = (int)(num2 * 1231453238 ^ -7539762);
						continue;
					}
					case 22:
					{
						TetraPanel.u202b‏‏‬‎‮‫​‍​⁭‬‬‭‮⁫⁯‭⁪‬‎‫‫‎⁬‪‍‎⁪⁪‮‌‮‌‏⁯‌‍​‌‮(this.u206c‫‍⁯⁫⁬⁬‎‮‎‭‎⁭⁪‍‏⁯‬​⁪‪⁯⁪​⁪‪‫‏⁮‏‍⁮⁮‫​‭⁬⁪⁮‍‮, TetraPanel.u202c‫‭‪‌‌⁬‌⁬‌‪‬‏‌‍⁯⁪‮⁪‮‌‪⁪⁯‭⁮‪‪⁪‬‭​‬‭‮‍‭‌‍‮(u003cModuleu003e.u200d​‍⁮‏‭⁮⁪‌‪‬‬‬‪⁬⁭⁫⁫‬⁪⁬⁬⁬‏⁮⁭‌‍‏‍‏‎‬⁬​‪‎​‎⁭‮<string>(2136952738), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0));
						TetraPanel.u200c⁪‏‏⁫‌⁭‭⁪‮⁯⁫‬‏‍‬⁮⁮‍‌‎‮⁪‌⁮⁭⁮⁫‮‬⁪‭⁬⁮⁮⁫‫‌‌‏‮(this.u206c‫‍⁯⁫⁬⁬‎‮‎‭‎⁭⁪‍‏⁯‬​⁪‪⁯⁪​⁪‪‫‏⁮‏‍⁮⁮‫​‭⁬⁪⁮‍‮, Color.Red);
						num = 2087018365;
						continue;
					}
					case 23:
					{
						this.u200c‎‎‪‎‮‎⁫‭‪⁯⁬⁪⁬‏‮‏‪‫‏⁯⁪​⁬‫⁯⁪‎‪‏‫‮⁯‏‪‭‬‏‪‮ = TetraPanel.u200b‬‌⁯‫‪⁪⁯​‭‬‌‭⁯⁮⁮‏​‪‬⁯‭‪​⁫‮​‪‬‬​‌‏⁬⁪‪‏⁪‏⁬‮();
						this.u206a‎‪⁮​‮⁭‭⁪‎⁪‏‌‎‌‎⁮⁫‬‭‍⁭⁭‫‏⁫​‬‪⁪‮⁮‏‏⁭⁬‌⁪⁯‭‮ = TetraPanel.u200b‏‌​‍‬⁮‭‍⁬⁬⁪​⁫⁬⁭‭⁪‪‎‏‏⁮‏‏‌‭​⁮‍‬⁮‪⁪​‬‮‏‪‮();
						this.u206b⁭‍‏⁮‪‎‪‎⁬‌⁪⁬⁯‎‬⁫⁬‭⁪⁯‍⁭⁮‪‍⁬‬⁭‮‭⁯​‏‪⁮​​‎⁭‮ = TetraPanel.u200b‬‌⁯‫‪⁪⁯​‭‬‌‭⁯⁮⁮‏​‪‬⁯‭‪​⁫‮​‪‬‬​‌‏⁬⁪‪‏⁪‏⁬‮();
						num = (int)(num2 * 125800974 ^ -68319295);
						continue;
					}
					case 24:
					{
						TetraPanel.u206d‍‍⁯‌​⁪‬⁮⁮‪‮⁬⁭‎⁪‍‮‬‎​⁬‮⁬⁬⁪‬‏⁪‌⁫⁭‎⁭⁬‏‪‌⁭‍‮(this, new System.Drawing.Size(229, 536));
						num = (int)(num2 * 1402250946 ^ -1731737713);
						continue;
					}
					case 25:
					{
						this.u200c⁭‫‪⁮⁪⁬‭⁬⁮‌⁬⁭‌‍‎⁫‮‭‍⁮‬‮⁫‫⁮⁬‮‬⁬‭⁯⁫‍‪⁪⁯‏​⁭‮ = TetraPanel.u200b‬‌⁯‫‪⁪⁯​‭‬‌‭⁯⁮⁮‏​‪‬⁯‭‪​⁫‮​‪‬‬​‌‏⁬⁪‪‏⁪‏⁬‮();
						num = (int)(num2 * 1676183737 ^ -190749873);
						continue;
					}
					case 26:
					{
						TetraPanel.u202d‏⁭⁫‮‫​‎‪⁫⁯‏⁮‫​‮‌⁮‬⁬‌⁮⁬‏⁭‏⁮‌⁮‮⁮‭‌‫‏⁪‎⁮‏‎‮(TetraPanel.u206a‬⁯⁭⁫‍⁪‫⁬⁭⁬⁮‫‏‍⁫‫‌⁪‪‌​⁭⁮‍‌‬⁯‭⁪‭⁮‏⁮‪​‍⁭⁫⁫‮(this.u206a⁭‫⁬⁯‌‎⁯‬‍​‏‎‌‏⁯‏⁮‬⁯⁮‎⁯⁬‌‪⁯⁬⁭⁬​‭​‌​‎⁫⁪‭‍‮), this.u200c‫‌‪‌‌‏​⁯⁪​‫⁪⁮⁯‫‍⁪⁫⁪‮⁬⁬‭⁯‌‫⁯‫‪‏‭‏⁭⁬‌‫‬⁪⁬‮);
						TetraPanel.u202d‏⁭⁫‮‫​‎‪⁫⁯‏⁮‫​‮‌⁮‬⁬‌⁮⁬‏⁭‏⁮‌⁮‮⁮‭‌‫‏⁪‎⁮‏‎‮(TetraPanel.u206a‬⁯⁭⁫‍⁪‫⁬⁭⁬⁮‫‏‍⁫‫‌⁪‪‌​⁭⁮‍‌‬⁯‭⁪‭⁮‏⁮‪​‍⁭⁫⁫‮(this.u206a⁭‫⁬⁯‌‎⁯‬‍​‏‎‌‏⁯‏⁮‬⁯⁮‎⁯⁬‌‪⁯⁬⁭⁬​‭​‌​‎⁫⁪‭‍‮), this.u202a‪‬⁭‮⁬⁫‫⁬‮‏‪‪‭‎‌‫‪‍⁭‏⁮⁬‭⁪⁯‍‍⁭‪‏‫‮​⁪⁭⁪‪‬‮);
						num = (int)(num2 * 1045198031 ^ -1764285500);
						continue;
					}
					case 27:
					{
						TetraPanel.u200f⁪⁪⁫⁭‏‮‌‬⁭‍​‭‫⁭⁮‫‍‏⁫⁭⁯​⁪‌‮‍⁭​⁫⁮⁫‫‌‭⁬⁫‬​‪‮(this.u200e‎⁭‏‎‪‎‍‬⁭⁮⁬‍⁭‮​⁪‮‏‍⁪‎‫⁮‫⁭⁯⁪‌‌​‌⁬‫‏‬‍⁯⁮‭‮, new EventHandler(this.u206f‮⁫‫‏‎‮⁯⁪‎⁮​‏⁬⁭‏‍‮⁯⁭‌⁬⁯‬⁮⁯⁪⁪‌⁫⁯‍‍​⁫‎⁫‭‏⁬‮));
						TetraPanel.u200e‭⁭‌‪‫​⁯⁫⁫‪⁯‍⁯⁯⁭‎⁫‮⁮​​‭‎‮‍‏‎‎⁪‌⁫‬‮⁮‌⁮‏⁭⁪‮(this.u200b‏⁭⁯⁮⁬‭‮⁭⁯‮​‏‭⁬⁮‫⁬⁬‬‮‏‏‎‮⁫⁬⁭⁮​​⁮⁪⁭⁭​‫‫‮, true);
						TetraPanel.u202b‏‏‬‎‮‫​‍​⁭‬‬‭‮⁫⁯‭⁪‬‎‫‫‎⁬‪‍‎⁪⁪‮‌‮‌‏⁯‌‍​‌‮(this.u200b‏⁭⁯⁮⁬‭‮⁭⁯‮​‏‭⁬⁮‫⁬⁬‬‮‏‏‎‮⁫⁬⁭⁮​​⁮⁪⁭⁭​‫‫‮, TetraPanel.u202c‫‭‪‌‌⁬‌⁬‌‪‬‏‌‍⁯⁪‮⁪‮‌‪⁪⁯‭⁮‪‪⁪‬‭​‬‭‮‍‭‌‍‮(u003cModuleu003e.u200d​‍⁮‏‭⁮⁪‌‪‬‬‬‪⁬⁭⁫⁫‬⁪⁬⁬⁬‏⁮⁭‌‍‏‍‏‎‬⁬​‪‎​‎⁭‮<string>(2136952738), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0));
						num = 1231874571;
						continue;
					}
					case 28:
					{
						TetraPanel.u206b⁬‪‍‭⁮⁪‌‭⁯⁪⁪‏‌‪⁯⁭‮​‭‏‌⁮⁯⁪‪‬​⁮⁯‮⁫⁮‪‪‫‍⁪⁬‎‮(this.u206d‏‪‫‍⁪‪⁬‌⁪‌‪‭⁫‫‎‍⁯‎‬‭⁪⁯​⁪⁮‬​‌​‎‌⁪‭⁮‏‌‫‫⁯‮, 54);
						num = (int)(num2 * -1772954304 ^ -2055887509);
						continue;
					}
					case 29:
					{
						TetraPanel.u206e⁪‏‏​‍⁮‫⁬⁬⁯⁫⁯‏⁬⁮‫‫⁬⁬‭‫‌‌⁭‎​‭⁭‍⁬‏‏⁮‫⁮‭‮‎‪‮(this.u202a‪‬⁭‮⁬⁫‫⁬‮‏‪‪‭‎‌‫‪‍⁭‏⁮⁬‭⁪⁯‍‍⁭‪‏‫‮​⁪⁭⁪‪‬‮, u003cModuleu003e.u206f⁮​‌‪‮‎‭‏‮‎⁮⁮‮⁬⁫‍‍⁪‍⁫⁮‏​‎⁬⁯⁪‪‍⁪⁮‎⁬⁪⁫​⁮⁪⁮‮<string>(-564715062));
						num = 556859928;
						continue;
					}
					case 30:
					{
						TetraPanel.u202d‏⁭⁫‮‫​‎‪⁫⁯‏⁮‫​‮‌⁮‬⁬‌⁮⁬‏⁭‏⁮‌⁮‮⁮‭‌‫‏⁪‎⁮‏‎‮(TetraPanel.u206a‬⁯⁭⁫‍⁪‫⁬⁭⁬⁮‫‏‍⁫‫‌⁪‪‌​⁭⁮‍‌‬⁯‭⁪‭⁮‏⁮‪​‍⁭⁫⁫‮(this.u206a⁭‫⁬⁯‌‎⁯‬‍​‏‎‌‏⁯‏⁮‬⁯⁮‎⁯⁬‌‪⁯⁬⁭⁬​‭​‌​‎⁫⁪‭‍‮), this.u200f‏⁯‭‌⁫‌‏⁪‫‬‎‫⁫‮‫‎‬‭‪⁪‫⁮‫‍‎‎⁪⁭⁬⁯⁪‬‎‮⁫⁪‎‭‌‮);
						TetraPanel.u202d‏⁭⁫‮‫​‎‪⁫⁯‏⁮‫​‮‌⁮‬⁬‌⁮⁬‏⁭‏⁮‌⁮‮⁮‭‌‫‏⁪‎⁮‏‎‮(TetraPanel.u206a‬⁯⁭⁫‍⁪‫⁬⁭⁬⁮‫‏‍⁫‫‌⁪‪‌​⁭⁮‍‌‬⁯‭⁪‭⁮‏⁮‪​‍⁭⁫⁫‮(this.u206a⁭‫⁬⁯‌‎⁯‬‍​‏‎‌‏⁯‏⁮‬⁯⁮‎⁯⁬‌‪⁯⁬⁭⁬​‭​‌​‎⁫⁪‭‍‮), this.u206d‪⁪‌⁭‌‫⁭‌⁪​‭⁫‎‪‭‌⁬‍‎‌‮‍‌‬‍‬⁬‏⁫‏‫‏‏‎‭‬‍‪⁫‮);
						TetraPanel.u202d‏⁭⁫‮‫​‎‪⁫⁯‏⁮‫​‮‌⁮‬⁬‌⁮⁬‏⁭‏⁮‌⁮‮⁮‭‌‫‏⁪‎⁮‏‎‮(TetraPanel.u206a‬⁯⁭⁫‍⁪‫⁬⁭⁬⁮‫‏‍⁫‫‌⁪‪‌​⁭⁮‍‌‬⁯‭⁪‭⁮‏⁮‪​‍⁭⁫⁫‮(this.u206a⁭‫⁬⁯‌‎⁯‬‍​‏‎‌‏⁯‏⁮‬⁯⁮‎⁯⁬‌‪⁯⁬⁭⁬​‭​‌​‎⁫⁪‭‍‮), this.u202a⁫⁫⁪‎⁯⁭‬‬⁬​‮‍⁭‮‌⁭‌‏‎‭‫‌‏‏⁫⁬‮⁬‌⁭​⁫⁯‫⁮⁭‬‏‏‮);
						TetraPanel.u202d‏⁭⁫‮‫​‎‪⁫⁯‏⁮‫​‮‌⁮‬⁬‌⁮⁬‏⁭‏⁮‌⁮‮⁮‭‌‫‏⁪‎⁮‏‎‮(TetraPanel.u206a‬⁯⁭⁫‍⁪‫⁬⁭⁬⁮‫‏‍⁫‫‌⁪‪‌​⁭⁮‍‌‬⁯‭⁪‭⁮‏⁮‪​‍⁭⁫⁫‮(this.u206a⁭‫⁬⁯‌‎⁯‬‍​‏‎‌‏⁯‏⁮‬⁯⁮‎⁯⁬‌‪⁯⁬⁭⁬​‭​‌​‎⁫⁪‭‍‮), this.u200e‮⁯​⁬⁫‍⁭⁯⁪‪⁫‭⁯‬⁭‫‭⁭⁫‮⁮‏⁫‮‫‭‍‫​⁭‏⁮⁯‎‭⁯‫⁯⁮‮);
						num = (int)(num2 * -380935044 ^ -2072540305);
						continue;
					}
					case 31:
					{
						TetraPanel.u202b‏‏‬‎‮‫​‍​⁭‬‬‭‮⁫⁯‭⁪‬‎‫‫‎⁬‪‍‎⁪⁪‮‌‮‌‏⁯‌‍​‌‮(this.u202b‫‌‍⁭‎‮⁮‍‮‎‏⁮‭‌⁭⁫‮⁮‭‎‏⁮⁮‌‌‫‬‪⁬⁬‏‌‭‌‫‌‭‭⁭‮, TetraPanel.u202c‫‭‪‌‌⁬‌⁬‌‪‬‏‌‍⁯⁪‮⁪‮‌‪⁪⁯‭⁮‪‪⁪‬‭​‬‭‮‍‭‌‍‮(u003cModuleu003e.u202a‮‫‏‫‬‬‪⁫⁬​‏⁫⁭‍‪‪‎⁬​‪​‌⁮‮‌​⁫​⁬‪‫⁪⁯⁪‎‫⁭‎⁪‮<string>(1627927687), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0));
						TetraPanel.u202b‎⁯‫‮⁬‏‪⁫‍⁫‭​⁭‎​‎‮⁬‍‏‏‎⁯​⁭⁫‏‫‌‌‪‪​‬⁬⁭‫⁮‮‮(this.u202b‫‌‍⁭‎‮⁮‍‮‎‏⁮‭‌⁭⁫‮⁮‭‎‏⁮⁮‌‌‫‬‪⁬⁬‏‌‭‌‫‌‭‭⁭‮, new Point(128, 109));
						num = 1377583883;
						continue;
					}
					case 32:
					{
						this.u200c‎‏⁪⁭⁬⁫‎⁭‪⁫⁫‮​⁯‫‪‏‮‮‬‬⁬‍⁭⁯‪⁪⁫⁬‬⁫‬‍⁮‍⁭‪‭⁪‮ = TetraPanel.u200b‬‌⁯‫‪⁪⁯​‭‬‌‭⁯⁮⁮‏​‪‬⁯‭‪​⁫‮​‪‬‬​‌‏⁬⁪‪‏⁪‏⁬‮();
						num = (int)(num2 * -2137095417 ^ -1800221728);
						continue;
					}
					case 33:
					{
						TetraPanel.u202d‏⁭⁫‮‫​‎‪⁫⁯‏⁮‫​‮‌⁮‬⁬‌⁮⁬‏⁭‏⁮‌⁮‮⁮‭‌‫‏⁪‎⁮‏‎‮(TetraPanel.u206a‬⁯⁭⁫‍⁪‫⁬⁭⁬⁮‫‏‍⁫‫‌⁪‪‌​⁭⁮‍‌‬⁯‭⁪‭⁮‏⁮‪​‍⁭⁫⁫‮(this.u206a⁭‫⁬⁯‌‎⁯‬‍​‏‎‌‏⁯‏⁮‬⁯⁮‎⁯⁬‌‪⁯⁬⁭⁬​‭​‌​‎⁫⁪‭‍‮), this.u206e‬​⁯⁫‍‎​‮⁬⁮‍‫‪‬‌‌‭⁯⁫‮‫‮⁭‮‫‪‫⁮‫⁪‏‏‏‫‏‭⁬⁬‍‮);
						TetraPanel.u202d‏⁭⁫‮‫​‎‪⁫⁯‏⁮‫​‮‌⁮‬⁬‌⁮⁬‏⁭‏⁮‌⁮‮⁮‭‌‫‏⁪‎⁮‏‎‮(TetraPanel.u206a‬⁯⁭⁫‍⁪‫⁬⁭⁬⁮‫‏‍⁫‫‌⁪‪‌​⁭⁮‍‌‬⁯‭⁪‭⁮‏⁮‪​‍⁭⁫⁫‮(this.u206a⁭‫⁬⁯‌‎⁯‬‍​‏‎‌‏⁯‏⁮‬⁯⁮‎⁯⁬‌‪⁯⁬⁭⁬​‭​‌​‎⁫⁪‭‍‮), this.u202c⁭‎‫‮‌⁯⁮‍‎⁪⁪⁬‭⁮‏‎‌‌‎‌⁯‪‮⁯‌⁮‌‭⁯‎‍‌⁪‍‭‏⁪‬‮);
						num = (int)(num2 * 1532425982 ^ 788568927);
						continue;
					}
					case 34:
					{
						TetraPanel.u206d‫‫‫⁮‮‌​‍⁫‭‎‬​⁭‬⁫‪‌‍‍‎‮⁫‬⁭⁫‫‎⁯‏‌‮‮⁬‮⁬⁪‮(this.u202c⁭‎‫‮‌⁯⁮‍‎⁪⁪⁬‭⁮‏‎‌‌‎‌⁯‪‮⁯‌⁮‌‭⁯‎‍‌⁪‍‭‏⁪‬‮, u003cModuleu003e.u200e‏‌‬⁮‪‭⁭‭⁭‎​‏‌‭‭‭⁭⁬⁯⁫‍‮‫⁯‌‮‏​‬⁫⁯⁮⁫‮‪⁫‬⁮⁬‮<string>(-1554953665));
						TetraPanel.u200c‏⁫‬‭‌‪⁮‬⁮‏‪⁭‍‪⁯‫⁬⁫⁭‭‮‬‬⁪⁫‏⁭‏⁮⁫​⁫⁬‪‌‫⁭‭‍‮(this.u202c⁭‎‫‮‌⁯⁮‍‎⁪⁪⁬‭⁮‏‎‌‌‎‌⁯‪‮⁯‌⁮‌‭⁯‎‍‌⁪‍‭‏⁪‬‮, true);
						TetraPanel.u200f⁪⁪⁫⁭‏‮‌‬⁭‍​‭‫⁭⁮‫‍‏⁫⁭⁯​⁪‌‮‍⁭​⁫⁮⁫‫‌‭⁬⁫‬​‪‮(this.u202c⁭‎‫‮‌⁯⁮‍‎⁪⁪⁬‭⁮‏‎‌‌‎‌⁯‪‮⁯‌⁮‌‭⁯‎‍‌⁪‍‭‏⁪‬‮, new EventHandler(this.u206a‏⁫⁯⁫⁬‎⁫‍‌⁫‭⁫‫⁪‍​​‏⁪‫​⁪⁪‎‏⁭‫⁭‍⁫⁭‫⁫⁫‎‪⁫⁪‬‮));
						num = 160001974;
						continue;
					}
					case 35:
					{
						TetraPanel.u206d‫‫‫⁮‮‌​‍⁫‭‎‬​⁭‬⁫‪‌‍‍‎‮⁫‬⁭⁫‫‎⁯‏‌‮‮⁬‮⁬⁪‮(this.u202e⁬⁬​‫⁪‍‍‏‌‏‬‌⁫‮⁫⁮‏⁬‭‭⁬‏⁫⁪‬‎⁪⁪‪‪‏‫⁮‭‪⁭‬‎‪‮, u003cModuleu003e.u200f⁫‌​⁬‌‎‎‏‍‍⁫‎​‌‬⁯‬‫‭‎‏​‌​⁪‭‬⁬‮⁬​‌⁬⁪‫‫‎⁪⁮‮<string>(1939131891));
						TetraPanel.u200e‭⁭‌‪‫​⁯⁫⁫‪⁯‍⁯⁯⁭‎⁫‮⁮​​‭‎‮‍‏‎‎⁪‌⁫‬‮⁮‌⁮‏⁭⁪‮(this.u202a‌⁯‌⁮‍‎‏⁭‌‮‭‌‏‎⁬⁯⁭‌‎⁪‪⁪‎⁪‏⁯⁪⁯​‪⁭‭‫⁬​⁭⁯⁯⁬‮, true);
						TetraPanel.u202b‏‏‬‎‮‫​‍​⁭‬‬‭‮⁫⁯‭⁪‬‎‫‫‎⁬‪‍‎⁪⁪‮‌‮‌‏⁯‌‍​‌‮(this.u202a‌⁯‌⁮‍‎‏⁭‌‮‭‌‏‎⁬⁯⁭‌‎⁪‪⁪‎⁪‏⁯⁪⁯​‪⁭‭‫⁬​⁭⁯⁯⁬‮, TetraPanel.u202c‫‭‪‌‌⁬‌⁬‌‪‬‏‌‍⁯⁪‮⁪‮‌‪⁪⁯‭⁮‪‪⁪‬‭​‬‭‮‍‭‌‍‮(u003cModuleu003e.u200f⁫‌​⁬‌‎‎‏‍‍⁫‎​‌‬⁯‬‫‭‎‏​‌​⁪‭‬⁬‮⁬​‌⁬⁪‫‫‎⁪⁮‮<string>(-285035864), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0));
						num = 546061922;
						continue;
					}
					case 36:
					{
						TetraPanel.u206e⁪‏‏​‍⁮‫⁬⁬⁯⁫⁯‏⁬⁮‫‫⁬⁬‭‫‌‌⁭‎​‭⁭‍⁬‏‏⁮‫⁮‭‮‎‪‮(this.u202b‫‭‪⁯⁯⁮‎⁫⁫⁮‫⁪⁯⁮⁭⁫‎‏⁮⁭‭⁪‌⁯⁪⁪‍⁯⁯‌⁫‪‮⁭‌⁪‎‬⁫‮, u003cModuleu003e.u200f⁫‌​⁬‌‎‎‏‍‍⁫‎​‌‬⁯‬‫‭‎‏​‌​⁪‭‬⁬‮⁬​‌⁬⁪‫‫‎⁪⁮‮<string>(1320204459));
						num = 1529290549;
						continue;
					}
					case 37:
					{
						TetraPanel.u202d‏⁭⁫‮‫​‎‪⁫⁯‏⁮‫​‮‌⁮‬⁬‌⁮⁬‏⁭‏⁮‌⁮‮⁮‭‌‫‏⁪‎⁮‏‎‮(TetraPanel.u206a‬⁯⁭⁫‍⁪‫⁬⁭⁬⁮‫‏‍⁫‫‌⁪‪‌​⁭⁮‍‌‬⁯‭⁪‭⁮‏⁮‪​‍⁭⁫⁫‮(this.u200d‮⁪⁭⁭‍⁯‮‭‏‏⁭‬‫⁮⁯‬⁫‬‪⁫‎⁭‭​⁫‪⁬⁮⁫‍⁭​⁭‌⁪​⁪‭⁯‮), this.u200e‎⁭‏‎‪‎‍‬⁭⁮⁬‍⁭‮​⁪‮‏‍⁪‎‫⁮‫⁭⁯⁪‌‌​‌⁬‫‏‬‍⁯⁮‭‮);
						TetraPanel.u202d‏⁭⁫‮‫​‎‪⁫⁯‏⁮‫​‮‌⁮‬⁬‌⁮⁬‏⁭‏⁮‌⁮‮⁮‭‌‫‏⁪‎⁮‏‎‮(TetraPanel.u206a‬⁯⁭⁫‍⁪‫⁬⁭⁬⁮‫‏‍⁫‫‌⁪‪‌​⁭⁮‍‌‬⁯‭⁪‭⁮‏⁮‪​‍⁭⁫⁫‮(this.u200d‮⁪⁭⁭‍⁯‮‭‏‏⁭‬‫⁮⁯‬⁫‬‪⁫‎⁭‭​⁫‪⁬⁮⁫‍⁭​⁭‌⁪​⁪‭⁯‮), this.u200b‏⁭⁯⁮⁬‭‮⁭⁯‮​‏‭⁬⁮‫⁬⁬‬‮‏‏‎‮⁫⁬⁭⁮​​⁮⁪⁭⁭​‫‫‮);
						num = (int)(num2 * -1322320579 ^ -763019258);
						continue;
					}
					case 38:
					{
						TetraPanel.u206b⁬‪‍‭⁮⁪‌‭⁯⁪⁪‏‌‪⁯⁭‮​‭‏‌⁮⁯⁪‪‬​⁮⁯‮⁫⁮‪‪‫‍⁪⁬‎‮(this.u202a‪‬⁭‮⁬⁫‫⁬‮‏‪‪‭‎‌‫‪‍⁭‏⁮⁬‭⁪⁯‍‍⁭‪‏‫‮​⁪⁭⁪‪‬‮, 81);
						num = (int)(num2 * -1319352034 ^ 520499851);
						continue;
					}
					case 39:
					{
						TetraPanel.u206b‪‫⁫​⁬‪‍‫‏⁭​⁫⁬‮‬‍⁮‮‍‬‬‬‭‬‍‮⁭‍‏‌⁬⁭‬‫⁬‏⁬⁫‌‮(this.u202b‫‌‍⁭‎‮⁮‍‮‎‏⁮‭‌⁭⁫‮⁮‭‎‏⁮⁮‌‌‫‬‪⁬⁬‏‌‭‌‫‌‭‭⁭‮, new decimal(new int[] { 10, 0, 0, -2147483648 }));
						TetraPanel.u206e⁪‏‏​‍⁮‫⁬⁬⁯⁫⁯‏⁬⁮‫‫⁬⁬‭‫‌‌⁭‎​‭⁭‍⁬‏‏⁮‫⁮‭‮‎‪‮(this.u202b‫‌‍⁭‎‮⁮‍‮‎‏⁮‭‌⁭⁫‮⁮‭‎‏⁮⁮‌‌‫‬‪⁬⁬‏‌‭‌‫‌‭‭⁭‮, u003cModuleu003e.u200d​‍⁮‏‭⁮⁪‌‪‬‬‬‪⁬⁭⁫⁫‬⁪⁬⁬⁬‏⁮⁭‌‍‏‍‏‎‬⁬​‪‎​‎⁭‮<string>(-483153141));
						num = 1312036401;
						continue;
					}
					case 40:
					{
						TetraPanel.u206d‫‫‫⁮‮‌​‍⁫‭‎‬​⁭‬⁫‪‌‍‍‎‮⁫‬⁭⁫‫‎⁯‏‌‮‮⁬‮⁬⁪‮(this.u206e‬‮​⁮‌⁭​‍‍⁪‌‏‭‬‏‎⁪⁬‫‬⁬⁪‍‌‪​‭⁬⁫⁬‪‭⁬⁪​⁪⁪​⁪‮, u003cModuleu003e.u200f⁫‌​⁬‌‎‎‏‍‍⁫‎​‌‬⁯‬‫‭‎‏​‌​⁪‭‬⁬‮⁬​‌⁬⁪‫‫‎⁪⁮‮<string>(-1722575853));
						num = 2096686307;
						continue;
					}
					case 41:
					{
						TetraPanel.u206e⁪‏‏​‍⁮‫⁬⁬⁯⁫⁯‏⁬⁮‫‫⁬⁬‭‫‌‌⁭‎​‭⁭‍⁬‏‏⁮‫⁮‭‮‎‪‮(this.u200d‌‎‪⁯⁯⁫‭‬‬‭‎​‍‮⁯‮‌‬‪‭​⁮⁭⁬‏‏‫⁪‏⁭⁬‏⁮⁮‬⁯‏‭‍‮, u003cModuleu003e.u202a‮‫‏‫‬‬‪⁫⁬​‏⁫⁭‍‪‪‎⁬​‪​‌⁮‮‌​⁫​⁬‪‫⁪⁯⁪‎‫⁭‎⁪‮<string>(-445421422));
						num = 326485896;
						continue;
					}
					case 42:
					{
						TetraPanel.u200e‭⁭‌‪‫​⁯⁫⁫‪⁯‍⁯⁯⁭‎⁫‮⁮​​‭‎‮‍‏‎‎⁪‌⁫‬‮⁮‌⁮‏⁭⁪‮(this.u206d‪⁪‌⁭‌‫⁭‌⁪​‭⁫‎‪‭‌⁬‍‎‌‮‍‌‬‍‬⁬‏⁫‏‫‏‏‎‭‬‍‪⁫‮, true);
						num = (int)(num2 * -812776639 ^ -554305996);
						continue;
					}
					case 43:
					{
						TetraPanel.u202c⁭⁫‪‏⁬⁭⁭​​⁪⁫‬‍⁪⁫⁭⁬‮‌⁭‫‮‭​⁫‌⁪‎‏⁪‫‮‌​‌‍⁮⁮⁮‮(this.u202e‪⁬⁫⁬⁭‪‏‌‏‫‫⁬⁭‌‭‮⁭⁭‬‪⁭⁭‬‌‮⁮⁭⁫‌‬⁯⁫‪‭‎‭‎‍⁫‮, new System.Drawing.Size(54, 13));
						num = (int)(num2 * -827723675 ^ 689812187);
						continue;
					}
					case 44:
					{
						TetraPanel.u206d‫‫‫⁮‮‌​‍⁫‭‎‬​⁭‬⁫‪‌‍‍‎‮⁫‬⁭⁫‫‎⁯‏‌‮‮⁬‮⁬⁪‮(this.u202e⁭​⁬‎​⁬⁮​⁬‬‫‎⁫‬‌​⁬⁪⁮​⁫⁬⁫⁪‎‍⁭⁭‬‬‪‎‍‬⁪‍‍​‍‮, u003cModuleu003e.u200d​‍⁮‏‭⁮⁪‌‪‬‬‬‪⁬⁭⁫⁫‬⁪⁬⁬⁬‏⁮⁭‌‍‏‍‏‎‬⁬​‪‎​‎⁭‮<string>(-825417628));
						TetraPanel.u202d⁮⁮⁪⁭‭⁫⁭‮‫⁬‏⁭‏‬‎​‌‎​⁬⁪⁭‬‫⁫‌‫‮‮‭‪‬​⁭‭⁪⁬⁬‍‮(this.u202e⁭​⁬‎​⁬⁮​⁬‬‫‎⁫‬‌​⁬⁪⁮​⁫⁬⁫⁪‎‍⁭⁭‬‬‪‎‍‬⁪‍‍​‍‮, new LinkLabelLinkClickedEventHandler(this.u206d‭⁭⁭‭‏‌‮⁪‫‪⁫‌‌‍‍‭‬⁭⁪‭​⁮⁮‫⁯​⁬⁬‬⁮‪‪⁫‌‬‭⁮‭‍‮));
						num = 2034368124;
						continue;
					}
					case 45:
					{
						TetraPanel.u200c‏⁫‬‭‌‪⁮‬⁮‏‪⁭‍‪⁯‫⁬⁫⁭‭‮‬‬⁪⁫‏⁭‏⁮⁫​⁫⁬‪‌‫⁭‭‍‮(this.u200e‮⁯​⁬⁫‍⁭⁯⁪‪⁫‭⁯‬⁭‫‭⁭⁫‮⁮‏⁫‮‫‭‍‫​⁭‏⁮⁯‎‭⁯‫⁯⁮‮, false);
						TetraPanel.u206e⁮⁭‎⁮⁪‮‌‏‫‫‌⁮⁬‮⁫⁮⁪⁫⁪‬‪​⁭⁯‭⁬‌‍‭⁪⁮‪⁯‎‬‪⁪‍⁯‮(this.u200e‮⁯​⁬⁫‍⁭⁯⁪‪⁫‭⁯‬⁭‫‭⁭⁫‮⁮‏⁫‮‫‭‍‫​⁭‏⁮⁯‎‭⁯‫⁯⁮‮, new EventHandler(this.u202b‬⁬‍⁯⁫‫‍‪‌​‮‏‪⁭‭⁮⁭‫‬‭⁪‫‏‪‮‪‪‬‫⁯‬‎‭⁬​‮‎⁭‮));
						num = (int)(num2 * 162660709 ^ -863711309);
						continue;
					}
					case 46:
					{
						TetraPanel.u202e⁯‭⁪‪⁬‮‬‍‭⁪⁭⁯⁯‌⁫⁫‭‎⁯‭⁭⁪‌‮‪‏⁮‮⁭‫‎⁭‬‏‏‫‌⁪‌‮(this.u206a⁯‏⁯​‫‬⁬‌⁮​⁯‬‌‭⁯‪⁬⁯⁮‌‫⁫⁫‍‎‎⁫⁮‫‍‍‪​‮‍‮‭⁬‏‮, new decimal(new int[] { 500, 0, 0, 0 }));
						num = (int)(num2 * -711802649 ^ 498546120);
						continue;
					}
					case 47:
					{
						TetraPanel.u202d‏⁭⁫‮‫​‎‪⁫⁯‏⁮‫​‮‌⁮‬⁬‌⁮⁬‏⁭‏⁮‌⁮‮⁮‭‌‫‏⁪‎⁮‏‎‮(TetraPanel.u206a‬⁯⁭⁫‍⁪‫⁬⁭⁬⁮‫‏‍⁫‫‌⁪‪‌​⁭⁮‍‌‬⁯‭⁪‭⁮‏⁮‪​‍⁭⁫⁫‮(this.u200d‮⁪⁭⁭‍⁯‮‭‏‏⁭‬‫⁮⁯‬⁫‬‪⁫‎⁭‭​⁫‪⁬⁮⁫‍⁭​⁭‌⁪​⁪‭⁯‮), this.u206c‮⁫⁫⁭⁬‍‮​‮⁭⁭⁭⁭⁪‪‪⁬‬⁫⁮‌​‎⁬‭‫‏‏⁮‍‍​⁯‎⁬‪⁬‏⁫‮);
						TetraPanel.u202d‏⁭⁫‮‫​‎‪⁫⁯‏⁮‫​‮‌⁮‬⁬‌⁮⁬‏⁭‏⁮‌⁮‮⁮‭‌‫‏⁪‎⁮‏‎‮(TetraPanel.u206a‬⁯⁭⁫‍⁪‫⁬⁭⁬⁮‫‏‍⁫‫‌⁪‪‌​⁭⁮‍‌‬⁯‭⁪‭⁮‏⁮‪​‍⁭⁫⁫‮(this.u200d‮⁪⁭⁭‍⁯‮‭‏‏⁭‬‫⁮⁯‬⁫‬‪⁫‎⁭‭​⁫‪⁬⁮⁫‍⁭​⁭‌⁪​⁪‭⁯‮), this.u200c⁭‫‪⁮⁪⁬‭⁬⁮‌⁬⁭‌‍‎⁫‮‭‍⁮‬‮⁫‫⁮⁬‮‬⁬‭⁯⁫‍‪⁪⁯‏​⁭‮);
						num = (int)(num2 * -1751289192 ^ -695877444);
						continue;
					}
					case 48:
					{
						TetraPanel.u200e‭⁭‌‪‫​⁯⁫⁫‪⁯‍⁯⁯⁭‎⁫‮⁮​​‭‎‮‍‏‎‎⁪‌⁫‬‮⁮‌⁮‏⁭⁪‮(this.u200c⁭‫‪⁮⁪⁬‭⁬⁮‌⁬⁭‌‍‎⁫‮‭‍⁮‬‮⁫‫⁮⁬‮‬⁬‭⁯⁫‍‪⁪⁯‏​⁭‮, true);
						num = (int)(num2 * 1493864552 ^ 1524254656);
						continue;
					}
					case 49:
					{
						TetraPanel.u202d‏⁭⁫‮‫​‎‪⁫⁯‏⁮‫​‮‌⁮‬⁬‌⁮⁬‏⁭‏⁮‌⁮‮⁮‭‌‫‏⁪‎⁮‏‎‮(TetraPanel.u206a‬⁯⁭⁫‍⁪‫⁬⁭⁬⁮‫‏‍⁫‫‌⁪‪‌​⁭⁮‍‌‬⁯‭⁪‭⁮‏⁮‪​‍⁭⁫⁫‮(this.u206a⁭‫⁬⁯‌‎⁯‬‍​‏‎‌‏⁯‏⁮‬⁯⁮‎⁯⁬‌‪⁯⁬⁭⁬​‭​‌​‎⁫⁪‭‍‮), this.u202e‪⁬⁫⁬⁭‪‏‌‏‫‫⁬⁭‌‭‮⁭⁭‬‪⁭⁭‬‌‮⁮⁭⁫‌‬⁯⁫‪‭‎‭‎‍⁫‮);
						num = (int)(num2 * 213021504 ^ -2122642556);
						continue;
					}
					case 50:
					{
						TetraPanel.u206d‫‫‫⁮‮‌​‍⁫‭‎‬​⁭‬⁫‪‌‍‍‎‮⁫‬⁭⁫‫‎⁯‏‌‮‮⁬‮⁬⁪‮(this.u206a⁭‫⁬⁯‌‎⁯‬‍​‏‎‌‏⁯‏⁮‬⁯⁮‎⁯⁬‌‪⁯⁬⁭⁬​‭​‌​‎⁫⁪‭‍‮, u003cModuleu003e.u202a‮‫‏‫‬‬‪⁫⁬​‏⁫⁭‍‪‪‎⁬​‪​‌⁮‮‌​⁫​⁬‪‫⁪⁯⁪‎‫⁭‎⁪‮<string>(-792986992));
						TetraPanel.u206f‮⁫⁯⁪‌‏⁭‏‌⁫⁯⁬‬⁭⁬⁬⁯⁮⁭⁮‮⁯⁯‬⁭⁬‏‌⁭⁬⁯⁪‫‮​‮‍⁫‍‮(this.u206a⁭‫⁬⁯‌‎⁯‬‍​‏‎‌‏⁯‏⁮‬⁯⁮‎⁯⁬‌‪⁯⁬⁭⁬​‭​‌​‎⁫⁪‭‍‮, new PaintEventHandler(this.u200d‎‏‬⁯⁭⁫‎⁮‫‎⁯‬‬⁫‬⁭​‭⁭‏‬‏⁮‫⁮‪⁯‪⁭‮‎‍‌‎​⁬‭‍‬‮));
						num = 1149659504;
						continue;
					}
					case 51:
					{
						TetraPanel.u206d‫‫‫⁮‮‌​‍⁫‭‎‬​⁭‬⁫‪‌‍‍‎‮⁫‬⁭⁫‫‎⁯‏‌‮‮⁬‮⁬⁪‮(this.u202b⁭‎‭‭‏⁮⁮‮‮‍⁫⁫‎‏‏‌‬‏‬‭‮‪‌⁪‎‏⁫‫‬‬‏‎⁫⁬⁯‌⁭⁪‪‮, u003cModuleu003e.u206f⁮​‌‪‮‎‭‏‮‎⁮⁮‮⁬⁫‍‍⁪‍⁫⁮‏​‎⁬⁯⁪‪‍⁪⁮‎⁬⁪⁫​⁮⁪⁮‮<string>(783897682));
						TetraPanel.u200e‭⁭‌‪‫​⁯⁫⁫‪⁯‍⁯⁯⁭‎⁫‮⁮​​‭‎‮‍‏‎‎⁪‌⁫‬‮⁮‌⁮‏⁭⁪‮(this.u200f‏⁯‭‌⁫‌‏⁪‫‬‎‫⁫‮‫‎‬‭‪⁪‫⁮‫‍‎‎⁪⁭⁬⁯⁪‬‎‮⁫⁪‎‭‌‮, true);
						num = 251603170;
						continue;
					}
					case 52:
					{
						TetraPanel.u202c⁭⁫‪‏⁬⁭⁭​​⁪⁫‬‍⁪⁫⁭⁬‮‌⁭‫‮‭​⁫‌⁪‎‏⁪‫‮‌​‌‍⁮⁮⁮‮(this.u200f‍‮‏‌‏‌‍‍⁪⁫⁯⁭‫⁮⁫‫⁯‏‫⁪‍‫⁮‮⁪⁫‍‭‍⁫‏‍⁫‍‌⁪⁫⁪⁭‮, new System.Drawing.Size(48, 20));
						num = (int)(num2 * -1542255506 ^ 853095563);
						continue;
					}
					case 53:
					{
						return;
					}
					case 54:
					{
						TetraPanel.u202b‎⁯‫‮⁬‏‪⁫‍⁫‭​⁭‎​‎‮⁬‍‏‏‎⁯​⁭⁫‏‫‌‌‪‪​‬⁬⁭‫⁮‮‮(this.u202a‪⁮​‏‫‮‫⁭⁯⁭‬⁯‎‭​‎⁬‭⁬‬‬‬‌⁪‍⁪​‎‍⁯​‍⁯⁫‎‍⁪‎‭‮, new Point(8, 446));
						TetraPanel.u202a‭‮⁬⁪⁯⁫‎⁬⁭‏⁯⁫⁪​⁭‏‏⁫‫⁯‍‮‫⁮‮​‍‮‪‫⁫​⁭‏⁮​⁭⁯‪‮(this.u202a‪⁮​‏‫‮‫⁭⁯⁭‬⁯‎‭​‎⁬‭⁬‬‬‬‌⁪‍⁪​‎‍⁯​‍⁯⁫‎‍⁪‎‭‮, new decimal(new int[4]));
						TetraPanel.u206b‪‫⁫​⁬‪‍‫‏⁭​⁫⁬‮‬‍⁮‮‍‬‬‬‭‬‍‮⁭‍‏‌⁬⁭‬‫⁬‏⁬⁫‌‮(this.u202a‪⁮​‏‫‮‫⁭⁯⁭‬⁯‎‭​‎⁬‭⁬‬‬‬‌⁪‍⁪​‎‍⁯​‍⁯⁫‎‍⁪‎‭‮, new decimal(new int[] { 100, 0, 0, -2147483648 }));
						num = (int)(num2 * -355790990 ^ -1462610325);
						continue;
					}
					case 55:
					{
						TetraPanel.u202a⁫⁬‭‏⁪‌⁬‏⁫​‎⁮‏‭‌‎‌⁯⁮‪‍‭⁪‏⁪‌‎⁬‮‏⁫‏‬⁫⁭⁫⁭‫⁪‮(this.u200b‏⁭⁯⁮⁬‭‮⁭⁯‮​‏‭⁬⁮‫⁬⁬‬‮‏‏‎‮⁫⁬⁭⁮​​⁮⁪⁭⁭​‫‫‮, true);
						num = (int)(num2 * -1904407564 ^ -645846589);
						continue;
					}
					case 56:
					{
						TetraPanel.u200e‭⁭‌‪‫​⁯⁫⁫‪⁯‍⁯⁯⁭‎⁫‮⁮​​‭‎‮‍‏‎‎⁪‌⁫‬‮⁮‌⁮‏⁭⁪‮(this.u206c‍‍‌‬‪‮‪‮⁪‎⁬‍‭⁪‫‌‬‪⁫‫‫‫‪⁮‮‬⁮⁬⁪‫⁭‫‌⁪‮‪⁭⁭⁮‮, true);
						TetraPanel.u202b‏‏‬‎‮‫​‍​⁭‬‬‭‮⁫⁯‭⁪‬‎‫‫‎⁬‪‍‎⁪⁪‮‌‮‌‏⁯‌‍​‌‮(this.u206c‍‍‌‬‪‮‪‮⁪‎⁬‍‭⁪‫‌‬‪⁫‫‫‫‪⁮‮‬⁮⁬⁪‫⁭‫‌⁪‮‪⁭⁭⁮‮, TetraPanel.u202c‫‭‪‌‌⁬‌⁬‌‪‬‏‌‍⁯⁪‮⁪‮‌‪⁪⁯‭⁮‪‪⁪‬‭​‬‭‮‍‭‌‍‮(u003cModuleu003e.u200e‏‌‬⁮‪‭⁭‭⁭‎​‏‌‭‭‭⁭⁬⁯⁫‍‮‫⁯‌‮‏​‬⁫⁯⁮⁫‮‪⁫‬⁮⁬‮<string>(507840788), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0));
						TetraPanel.u202b‎⁯‫‮⁬‏‪⁫‍⁫‭​⁭‎​‎‮⁬‍‏‏‎⁯​⁭⁫‏‫‌‌‪‪​‬⁬⁭‫⁮‮‮(this.u206c‍‍‌‬‪‮‪‮⁪‎⁬‍‭⁪‫‌‬‪⁫‫‫‫‪⁮‮‬⁮⁬⁪‫⁭‫‌⁪‮‪⁭⁭⁮‮, new Point(6, 56));
						TetraPanel.u206e⁪‏‏​‍⁮‫⁬⁬⁯⁫⁯‏⁬⁮‫‫⁬⁬‭‫‌‌⁭‎​‭⁭‍⁬‏‏⁮‫⁮‭‮‎‪‮(this.u206c‍‍‌‬‪‮‪‮⁪‎⁬‍‭⁪‫‌‬‪⁫‫‫‫‪⁮‮‬⁮⁬⁪‫⁭‫‌⁪‮‪⁭⁭⁮‮, u003cModuleu003e.u200e‏‌‬⁮‪‭⁭‭⁭‎​‏‌‭‭‭⁭⁬⁯⁫‍‮‫⁯‌‮‏​‬⁫⁯⁮⁫‮‪⁫‬⁮⁬‮<string>(1347002077));
						num = 632998295;
						continue;
					}
					case 57:
					{
						this.u200e⁫​‭⁪‫‏‬‮⁭⁬‌‏⁮⁮​‍‍‎‍‭‍‎​‪‪‭⁪‏‎⁬‎‍‫‮​⁬⁮⁯‫‮ = TetraPanel.u206a⁪‬‍‍‭⁬⁫‬‮​‌‌‮⁯⁪‭⁭‪‮⁯‭‏‌‮⁫​‏⁮⁬‏⁬‬​‭⁯‬⁯‬‍‮();
						this.u206a⁭‫⁬⁯‌‎⁯‬‍​‏‎‌‏⁯‏⁮‬⁯⁮‎⁯⁬‌‪⁯⁬⁭⁬​‭​‌​‎⁫⁪‭‍‮ = TetraPanel.u200b‏‌​‍‬⁮‭‍⁬⁬⁪​⁫⁬⁭‭⁪‪‎‏‏⁮‏‏‌‭​⁮‍‬⁮‪⁪​‬‮‏‪‮();
						num = (int)(num2 * 1104388607 ^ -1356868386);
						continue;
					}
					case 58:
					{
						TetraPanel.u200e‭⁭‌‪‫​⁯⁫⁫‪⁯‍⁯⁯⁭‎⁫‮⁮​​‭‎‮‍‏‎‎⁪‌⁫‬‮⁮‌⁮‏⁭⁪‮(this.u206c‫‍⁯⁫⁬⁬‎‮‎‭‎⁭⁪‍‏⁯‬​⁪‪⁯⁪​⁪‪‫‏⁮‏‍⁮⁮‫​‭⁬⁪⁮‍‮, true);
						num = (int)(num2 * 762453086 ^ 1052115618);
						continue;
					}
					case 59:
					{
						TetraPanel.u200c‏⁫‬‭‌‪⁮‬⁮‏‪⁭‍‪⁯‫⁬⁫⁭‭‮‬‬⁪⁫‏⁭‏⁮⁫​⁫⁬‪‌‫⁭‭‍‮(this.u206e‬​⁯⁫‍‎​‮⁬⁮‍‫‪‬‌‌‭⁯⁫‮‫‮⁭‮‫‪‫⁮‫⁪‏‏‏‫‏‭⁬⁬‍‮, true);
						num = (int)(num2 * 2094075269 ^ 254604398);
						continue;
					}
					case 60:
					{
						TetraPanel.u202d‏⁭⁫‮‫​‎‪⁫⁯‏⁮‫​‮‌⁮‬⁬‌⁮⁬‏⁭‏⁮‌⁮‮⁮‭‌‫‏⁪‎⁮‏‎‮(TetraPanel.u206a‬⁯⁭⁫‍⁪‫⁬⁭⁬⁮‫‏‍⁫‫‌⁪‪‌​⁭⁮‍‌‬⁯‭⁪‭⁮‏⁮‪​‍⁭⁫⁫‮(this.u206a⁭‫⁬⁯‌‎⁯‬‍​‏‎‌‏⁯‏⁮‬⁯⁮‎⁯⁬‌‪⁯⁬⁭⁬​‭​‌​‎⁫⁪‭‍‮), this.u202e‭‭‮​⁬⁯‎⁫​‬‏‌⁮⁮‮⁮⁬⁭‮⁯⁯‏‬‎​‎‍‏⁭⁮‏‬‫⁪‍‬‫‪‬‮);
						num = (int)(num2 * -1158022509 ^ -1003187835);
						continue;
					}
					case 61:
					{
						TetraPanel.u206b⁬‪‍‭⁮⁪‌‭⁯⁪⁪‏‌‪⁯⁭‮​‭‏‌⁮⁯⁪‪‬​⁮⁯‮⁫⁮‪‪‫‍⁪⁬‎‮(this.u202a‪‌⁫⁫‭⁬⁭⁫⁯⁮‪​‮⁮‮‍‌⁪⁬‭‮‬‬⁮‫‪‫‮‍‮​‏‌‍‌​​‬‪‮, 70);
						TetraPanel.u206d‫‫‫⁮‮‌​‍⁫‭‎‬​⁭‬⁫‪‌‍‍‎‮⁫‬⁭⁫‫‎⁯‏‌‮‮⁬‮⁬⁪‮(this.u202a‪‌⁫⁫‭⁬⁭⁫⁯⁮‪​‮⁮‮‍‌⁪⁬‭‮‬‬⁮‫‪‫‮‍‮​‏‌‍‌​​‬‪‮, u003cModuleu003e.u206f⁮​‌‪‮‎‭‏‮‎⁮⁮‮⁬⁫‍‍⁪‍⁫⁮‏​‎⁬⁯⁪‪‍⁪⁮‎⁬⁪⁫​⁮⁪⁮‮<string>(445359012));
						num = 374586435;
						continue;
					}
					case 62:
					{
						TetraPanel.u202c⁭⁫‪‏⁬⁭⁭​​⁪⁫‬‍⁪⁫⁭⁬‮‌⁭‫‮‭​⁫‌⁪‎‏⁪‫‮‌​‌‍⁮⁮⁮‮(this.u206d‫⁭‮⁯​⁫‬‍‪‍⁬⁭⁭‍‎‬‮⁪‫‫‍‎⁫​⁪‪​‮⁬‌​‬‮⁪‬‮⁫⁬⁫‮, new System.Drawing.Size(34, 13));
						TetraPanel.u206b⁬‪‍‭⁮⁪‌‭⁯⁪⁪‏‌‪⁯⁭‮​‭‏‌⁮⁯⁪‪‬​⁮⁯‮⁫⁮‪‪‫‍⁪⁬‎‮(this.u206d‫⁭‮⁯​⁫‬‍‪‍⁬⁭⁭‍‎‬‮⁪‫‫‍‎⁫​⁪‪​‮⁬‌​‬‮⁪‬‮⁫⁬⁫‮, 49);
						num = (int)(num2 * -512394810 ^ 147057626);
						continue;
					}
					case 63:
					{
						TetraPanel.u206e‏‪⁯‏⁯‫‭​⁮‮‮‌⁫⁪⁪‪⁮‪​‫⁯⁪‬‍‬‬⁮⁬⁭⁪​‭‎‌​‫​‌⁪‮(this.u202a‪⁮​‏‫‮‫⁭⁯⁭‬⁯‎‭​‎⁬‭⁬‬‬‬‌⁪‍⁪​‎‍⁯​‍⁯⁫‎‍⁪‎‭‮, HorizontalAlignment.Right);
						num = (int)(num2 * -1863200071 ^ 1554630173);
						continue;
					}
					case 64:
					{
						this.u206e⁭‫‬‫⁪‭‍‏⁫⁭​​‏‌‭⁭⁫‏⁮⁪‏‎‫⁯‭⁯‍⁮​‫‫⁪⁮⁫‎‬‫‌⁯‮ = TetraPanel.u202a⁭‌⁭‏‪⁭‎⁬‌⁪‫‏​‎⁯‍‭⁭‮‏‎⁪‏⁭‎⁪⁪⁫‫‭⁫‍‌‬⁫‭​‌‍‮(this.u200c⁫⁯⁬‪‌‬‭‫‭​‪​⁯‮⁪‫⁫⁯⁪‏‌⁬⁮‬‌‬⁭‭⁮⁯‮‬⁮‏‫⁯​‭‏‮);
						TetraPanel.u206e⁪‫‮‫⁮⁭‏‏‮‏‍⁭‬‏⁯​‬‍‌‎‫‍‬⁮⁮‫⁭⁯​‭‬⁯‌⁮⁮⁭‭‍⁬‮(this.u200e⁫​‭⁪‫‏‬‮⁭⁬‌‏⁮⁮​‍‍‎‍‭‍‎​‪‪‭⁪‏‎⁬‎‍‫‮​⁬⁮⁯‫‮);
						num = (int)(num2 * -1097835627 ^ -1054276458);
						continue;
					}
					case 65:
					{
						TetraPanel.u206e⁪‏‏​‍⁮‫⁬⁬⁯⁫⁯‏⁬⁮‫‫⁬⁬‭‫‌‌⁭‎​‭⁭‍⁬‏‏⁮‫⁮‭‮‎‪‮(this.u200d‌‏‪‍‭⁯‎⁫⁪⁮⁮‍‮⁪⁫⁮⁬‎⁭⁫⁬‭‎⁯‪‍‏‌⁭⁯⁯‬‫‌‭⁮‬‭⁭‮, u003cModuleu003e.u206f⁮​‌‪‮‎‭‏‮‎⁮⁮‮⁬⁫‍‍⁪‍⁫⁮‏​‎⁬⁯⁪‪‍⁪⁮‎⁬⁪⁫​⁮⁪⁮‮<string>(-225297030));
						TetraPanel.u202c⁭⁫‪‏⁬⁭⁭​​⁪⁫‬‍⁪⁫⁭⁬‮‌⁭‫‮‭​⁫‌⁪‎‏⁪‫‮‌​‌‍⁮⁮⁮‮(this.u200d‌‏‪‍‭⁯‎⁫⁪⁮⁮‍‮⁪⁫⁮⁬‎⁭⁫⁬‭‎⁯‪‍‏‌⁭⁯⁯‬‫‌‭⁮‬‭⁭‮, new System.Drawing.Size(202, 148));
						num = 406129420;
						continue;
					}
					case 66:
					{
						TetraPanel.u206b⁬‪‍‭⁮⁪‌‭⁯⁪⁪‏‌‪⁯⁭‮​‭‏‌⁮⁯⁪‪‬​⁮⁯‮⁫⁮‪‪‫‍⁪⁬‎‮(this.u200e‮⁯​⁬⁫‍⁭⁯⁪‪⁫‭⁯‬⁭‫‭⁭⁫‮⁮‏⁫‮‫‭‍‫​⁭‏⁮⁯‎‭⁯‫⁯⁮‮, 59);
						num = (int)(num2 * -1477426707 ^ 2072648941);
						continue;
					}
					case 67:
					{
						TetraPanel.u206e⁪‏‏​‍⁮‫⁬⁬⁯⁫⁯‏⁬⁮‫‫⁬⁬‭‫‌‌⁭‎​‭⁭‍⁬‏‏⁮‫⁮‭‮‎‪‮(this.u202e‭‭‮​⁬⁯‎⁫​‬‏‌⁮⁮‮⁮⁬⁭‮⁯⁯‏‬‎​‎‍‏⁭⁮‏‬‫⁪‍‬‫‪‬‮, u003cModuleu003e.u202a‮‫‏‫‬‬‪⁫⁬​‏⁫⁭‍‪‪‎⁬​‪​‌⁮‮‌​⁫​⁬‪‫⁪⁯⁪‎‫⁭‎⁪‮<string>(1682954670));
						num = 1378623832;
						continue;
					}
					case 68:
					{
						TetraPanel.u202c⁭⁫‪‏⁬⁭⁭​​⁪⁫‬‍⁪⁫⁭⁬‮‌⁭‫‮‭​⁫‌⁪‎‏⁪‫‮‌​‌‍⁮⁮⁮‮(this.u202a‎‎‭⁭⁬‎⁬‏⁫⁬⁯‫‎‬‪‏⁬‪‬‭‌‪‌‎⁯‪‪‫​‪​⁮‫‭‌⁮​⁪⁬‮, new System.Drawing.Size(13, 13));
						num = (int)(num2 * -810841206 ^ 1476456809);
						continue;
					}
					case 69:
					{
						TetraPanel.u200e‭⁭‌‪‫​⁯⁫⁫‪⁯‍⁯⁯⁭‎⁫‮⁮​​‭‎‮‍‏‎‎⁪‌⁫‬‮⁮‌⁮‏⁭⁪‮(this.u200c‎‏⁪⁭⁬⁫‎⁭‪⁫⁫‮​⁯‫‪‏‮‮‬‬⁬‍⁭⁯‪⁪⁫⁬‬⁫‬‍⁮‍⁭‪‭⁪‮, true);
						num = (int)(num2 * 1271420146 ^ 1840541590);
						continue;
					}
					case 70:
					{
						TetraPanel.u206b⁬‪‍‭⁮⁪‌‭⁯⁪⁪‏‌‪⁯⁭‮​‭‏‌⁮⁯⁪‪‬​⁮⁯‮⁫⁮‪‪‫‍⁪⁬‎‮(this.u202c⁭‎‫‮‌⁯⁮‍‎⁪⁪⁬‭⁮‏‎‌‌‎‌⁯‪‮⁯‌⁮‌‭⁯‎‍‌⁪‍‭‏⁪‬‮, 0);
						num = (int)(num2 * 509328437 ^ -1012063648);
						continue;
					}
					case 71:
					{
						TetraPanel.u200e‭⁭‌‪‫​⁯⁫⁫‪⁯‍⁯⁯⁭‎⁫‮⁮​​‭‎‮‍‏‎‎⁪‌⁫‬‮⁮‌⁮‏⁭⁪‮(this.u206b⁭‍‏⁮‪‎‪‎⁬‌⁪⁬⁯‎‬⁫⁬‭⁪⁯‍⁭⁮‪‍⁬‬⁭‮‭⁯​‏‪⁮​​‎⁭‮, true);
						num = (int)(num2 * 494211539 ^ 1941033093);
						continue;
					}
					case 72:
					{
						TetraPanel.u202b‬⁫‌‪⁯⁭‪⁮‏‪⁭⁪‌‪⁬⁪‭⁬‮‬‭⁫‫⁯‭‫‫‎‎‮‎‏⁮⁯‪‌‭⁫‌‮(this.u200d‮⁪⁭⁭‍⁯‮‭‏‏⁭‬‫⁮⁯‬⁫‬‪⁫‎⁭‭​⁫‪⁬⁮⁫‍⁭​⁭‌⁪​⁪‭⁯‮, false);
						num = (int)(num2 * 191569051 ^ 1615928268);
						continue;
					}
					case 73:
					{
						TetraPanel.u202b‏‏‬‎‮‫​‍​⁭‬‬‭‮⁫⁯‭⁪‬‎‫‫‎⁬‪‍‎⁪⁪‮‌‮‌‏⁯‌‍​‌‮(this.u206a‎‪⁮​‮⁭‭⁪‎⁪‏‌‎‌‎⁮⁫‬‭‍⁭⁭‫‏⁫​‬‪⁪‮⁮‏‏⁭⁬‌⁪⁯‭‮, TetraPanel.u202c‫‭‪‌‌⁬‌⁬‌‪‬‏‌‍⁯⁪‮⁪‮‌‪⁪⁯‭⁮‪‪⁪‬‭​‬‭‮‍‭‌‍‮(u003cModuleu003e.u206f⁮​‌‪‮‎‭‏‮‎⁮⁮‮⁬⁫‍‍⁪‍⁫⁮‏​‎⁬⁯⁪‪‍⁪⁮‎⁬⁪⁫​⁮⁪⁮‮<string>(125941577), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0));
						num = 1524398923;
						continue;
					}
					case 74:
					{
						TetraPanel.u202d‏⁭⁫‮‫​‎‪⁫⁯‏⁮‫​‮‌⁮‬⁬‌⁮⁬‏⁭‏⁮‌⁮‮⁮‭‌‫‏⁪‎⁮‏‎‮(TetraPanel.u206a‬⁯⁭⁫‍⁪‫⁬⁭⁬⁮‫‏‍⁫‫‌⁪‪‌​⁭⁮‍‌‬⁯‭⁪‭⁮‏⁮‪​‍⁭⁫⁫‮(this.u206a⁭‫⁬⁯‌‎⁯‬‍​‏‎‌‏⁯‏⁮‬⁯⁮‎⁯⁬‌‪⁯⁬⁭⁬​‭​‌​‎⁫⁪‭‍‮), this.u206a⁯‏⁯​‫‬⁬‌⁮​⁯‬‌‭⁯‪⁬⁯⁮‌‫⁫⁫‍‎‎⁫⁮‫‍‍‪​‮‍‮‭⁬‏‮);
						num = (int)(num2 * 1156774869 ^ -1435130448);
						continue;
					}
					case 75:
					{
						TetraPanel.u206c‎⁫​‌‎​⁯⁮‮⁪⁬‌⁯‍⁫‬‍​⁮‫‮‌‍‪‫‎‭⁬⁯⁪‎‭⁫‫‏⁮‏‮⁫‮(this.u206a⁯‏⁯​‫‬⁬‌⁮​⁯‬‌‭⁯‪⁬⁯⁮‌‫⁫⁫‍‎‎⁫⁮‫‍‍‪​‮‍‮‭⁬‏‮);
						num = (int)(num2 * -6018692 ^ 1432118363);
						continue;
					}
					case 76:
					{
						TetraPanel.u202c⁭⁫‪‏⁬⁭⁭​​⁪⁫‬‍⁪⁫⁭⁬‮‌⁭‫‮‭​⁫‌⁪‎‏⁪‫‮‌​‌‍⁮⁮⁮‮(this.u200c‎‎‪‎‮‎⁫‭‪⁯⁬⁪⁬‏‮‏‪‫‏⁯⁪​⁬‫⁯⁪‎‪‏‫‮⁯‏‪‭‬‏‪‮, new System.Drawing.Size(70, 13));
						num = (int)(num2 * 29737310 ^ -872440357);
						continue;
					}
					case 77:
					{
						TetraPanel.u202b‎⁯‫‮⁬‏‪⁫‍⁫‭​⁭‎​‎‮⁬‍‏‏‎⁯​⁭⁫‏‫‌‌‪‪​‬⁬⁭‫⁮‮‮(this.u202c⁭‎‫‮‌⁯⁮‍‎⁪⁪⁬‭⁮‏‎‌‌‎‌⁯‪‮⁯‌⁮‌‭⁯‎‍‌⁪‍‭‏⁪‬‮, new Point(9, 0));
						num = (int)(num2 * 2141079703 ^ -411841774);
						continue;
					}
					case 78:
					{
						TetraPanel.u202b‎⁯‫‮⁬‏‪⁫‍⁫‭​⁭‎​‎‮⁬‍‏‏‎⁯​⁭⁫‏‫‌‌‪‪​‬⁬⁭‫⁮‮‮(this.u206d‫⁭‮⁯​⁫‬‍‪‍⁬⁭⁭‍‎‬‮⁪‫‫‍‎⁫​⁪‪​‮⁬‌​‬‮⁪‬‮⁫⁬⁫‮, new Point(6, 74));
						num = (int)(num2 * 2003563496 ^ 689659297);
						continue;
					}
					case 79:
					{
						TetraPanel.u202c⁭⁫‪‏⁬⁭⁭​​⁪⁫‬‍⁪⁫⁭⁬‮‌⁭‫‮‭​⁫‌⁪‎‏⁪‫‮‌​‌‍⁮⁮⁮‮(this.u200d‮⁪⁭⁭‍⁯‮‭‏‏⁭‬‫⁮⁯‬⁫‬‪⁫‎⁭‭​⁫‪⁬⁮⁫‍⁭​⁭‌⁪​⁪‭⁯‮, new System.Drawing.Size(209, 136));
						TetraPanel.u206b⁬‪‍‭⁮⁪‌‭⁯⁪⁪‏‌‪⁯⁭‮​‭‏‌⁮⁯⁪‪‬​⁮⁯‮⁫⁮‪‪‫‍⁪⁬‎‮(this.u200d‮⁪⁭⁭‍⁯‮‭‏‏⁭‬‫⁮⁯‬⁫‬‪⁫‎⁭‭​⁫‪⁬⁮⁫‍⁭​⁭‌⁪​⁪‭⁯‮, 44);
						TetraPanel.u200f⁪​‬‍‏‭‭‏‫⁬‬‭‮⁯‫⁫⁯⁫‪‌‌‌‪‍⁪‏‎‌‬⁮⁬⁫⁬⁬⁮‪⁮⁬‪‮(this.u200d‮⁪⁭⁭‍⁯‮‭‏‏⁭‬‫⁮⁯‬⁫‬‪⁫‎⁭‭​⁫‪⁬⁮⁫‍⁭​⁭‌⁪​⁪‭⁯‮, false);
						num = (int)(num2 * -668190307 ^ -2036458055);
						continue;
					}
					case 80:
					{
						TetraPanel.u202d‏⁭⁫‮‫​‎‪⁫⁯‏⁮‫​‮‌⁮‬⁬‌⁮⁬‏⁭‏⁮‌⁮‮⁮‭‌‫‏⁪‎⁮‏‎‮(TetraPanel.u206a‬⁯⁭⁫‍⁪‫⁬⁭⁬⁮‫‏‍⁫‫‌⁪‪‌​⁭⁮‍‌‬⁯‭⁪‭⁮‏⁮‪​‍⁭⁫⁫‮(this.u206a⁭‫⁬⁯‌‎⁯‬‍​‏‎‌‏⁯‏⁮‬⁯⁮‎⁯⁬‌‪⁯⁬⁭⁬​‭​‌​‎⁫⁪‭‍‮), this.u202b⁪⁭‍‎⁭‮⁮‭⁮⁪‬⁯⁭‎‌⁫‮‮⁪‍⁯‎‍‫⁫‪‪‎‪‬‍‎‮‍⁭‍⁭‎⁬‮);
						num = (int)(num2 * 778290547 ^ -1316549376);
						continue;
					}
					case 81:
					{
						TetraPanel.u202d‏⁭⁫‮‫​‎‪⁫⁯‏⁮‫​‮‌⁮‬⁬‌⁮⁬‏⁭‏⁮‌⁮‮⁮‭‌‫‏⁪‎⁮‏‎‮(TetraPanel.u206a‬⁯⁭⁫‍⁪‫⁬⁭⁬⁮‫‏‍⁫‫‌⁪‪‌​⁭⁮‍‌‬⁯‭⁪‭⁮‏⁮‪​‍⁭⁫⁫‮(this.u206a⁭‫⁬⁯‌‎⁯‬‍​‏‎‌‏⁯‏⁮‬⁯⁮‎⁯⁬‌‪⁯⁬⁭⁬​‭​‌​‎⁫⁪‭‍‮), this.u200f⁫⁭⁬​‮‫‭‪‬‏⁯‭‎‭⁫‌⁬⁮‭‮‌‮⁫⁫‭‎‪‎‎​⁫‎⁮⁭⁯⁫‌‮‫‮);
						TetraPanel.u202b‎⁯‫‮⁬‏‪⁫‍⁫‭​⁭‎​‎‮⁬‍‏‏‎⁯​⁭⁫‏‫‌‌‪‪​‬⁬⁭‫⁮‮‮(this.u206a⁭‫⁬⁯‌‎⁯‬‍​‏‎‌‏⁯‏⁮‬⁯⁮‎⁯⁬‌‪⁯⁬⁭⁬​‭​‌​‎⁫⁪‭‍‮, new Point(3, 0));
						TetraPanel.u206e⁪‏‏​‍⁮‫⁬⁬⁯⁫⁯‏⁬⁮‫‫⁬⁬‭‫‌‌⁭‎​‭⁭‍⁬‏‏⁮‫⁮‭‮‎‪‮(this.u206a⁭‫⁬⁯‌‎⁯‬‍​‏‎‌‏⁯‏⁮‬⁯⁮‎⁯⁬‌‪⁯⁬⁭⁬​‭​‌​‎⁫⁪‭‍‮, u003cModuleu003e.u206f⁮​‌‪‮‎‭‏‮‎⁮⁮‮⁬⁫‍‍⁪‍⁫⁮‏​‎⁬⁯⁪‪‍⁪⁮‎⁬⁪⁫​⁮⁪⁮‮<string>(-1158538330));
						num = 813593725;
						continue;
					}
					case 82:
					{
						TetraPanel.u206e⁪‫‮‫⁮⁭‏‏‮‏‍⁭‬‏⁯​‬‍‌‎‫‍‬⁮⁮‫⁭⁯​‭‬⁯‌⁮⁮⁭‭‍⁬‮(this.u206a⁭‫⁬⁯‌‎⁯‬‍​‏‎‌‏⁯‏⁮‬⁯⁮‎⁯⁬‌‪⁯⁬⁭⁬​‭​‌​‎⁫⁪‭‍‮);
						num = (int)(num2 * -1183923029 ^ -1736710507);
						continue;
					}
					case 83:
					{
						TetraPanel.u206e⁪‏‏​‍⁮‫⁬⁬⁯⁫⁯‏⁬⁮‫‫⁬⁬‭‫‌‌⁭‎​‭⁭‍⁬‏‏⁮‫⁮‭‮‎‪‮(this.u200c⁭‫‪⁮⁪⁬‭⁬⁮‌⁬⁭‌‍‎⁫‮‭‍⁮‬‮⁫‫⁮⁬‮‬⁬‭⁯⁫‍‪⁪⁯‏​⁭‮, u003cModuleu003e.u200d​‍⁮‏‭⁮⁪‌‪‬‬‬‪⁬⁭⁫⁫‬⁪⁬⁬⁬‏⁮⁭‌‍‏‍‏‎‬⁬​‪‎​‎⁭‮<string>(-1857823163));
						num = 731106953;
						continue;
					}
					case 84:
					{
						TetraPanel.u202c⁭⁫‪‏⁬⁭⁭​​⁪⁫‬‍⁪⁫⁭⁬‮‌⁭‫‮‭​⁫‌⁪‎‏⁪‫‮‌​‌‍⁮⁮⁮‮(this.u200e‮⁯​⁬⁫‍⁭⁯⁪‪⁫‭⁯‬⁭‫‭⁭⁫‮⁮‏⁫‮‫‭‍‫​⁭‏⁮⁯‎‭⁯‫⁯⁮‮, new System.Drawing.Size(69, 23));
						num = (int)(num2 * 1875522918 ^ 1174590638);
						continue;
					}
					case 85:
					{
						TetraPanel.u206b⁬‪‍‭⁮⁪‌‭⁯⁪⁪‏‌‪⁯⁭‮​‭‏‌⁮⁯⁪‪‬​⁮⁯‮⁫⁮‪‪‫‍⁪⁬‎‮(this.u202e⁮‍‍⁮‎⁪⁫⁫‍‮‭‬‍⁪‪‮⁭‬⁫⁯‪⁯​⁪‬‫​⁬‭‭⁯‫‎⁮‏​​‬‎‮, 56);
						TetraPanel.u202a⁫⁬‭‏⁪‌⁬‏⁫​‎⁮‏‭‌‎‌⁯⁮‪‍‭⁪‏⁪‌‎⁬‮‏⁫‏‬⁫⁭⁫⁭‫⁪‮(this.u202e⁮‍‍⁮‎⁪⁫⁫‍‮‭‬‍⁪‪‮⁭‬⁫⁯‪⁯​⁪‬‫​⁬‭‭⁯‫‎⁮‏​​‬‎‮, true);
						num = (int)(num2 * -1148335330 ^ 1587055484);
						continue;
					}
					case 86:
					{
						TetraPanel.u202c⁭⁫‪‏⁬⁭⁭​​⁪⁫‬‍⁪⁫⁭⁬‮‌⁭‫‮‭​⁫‌⁪‎‏⁪‫‮‌​‌‍⁮⁮⁮‮(this.u202a‪‬⁭‮⁬⁫‫⁬‮‏‪‪‭‎‌‫‪‍⁭‏⁮⁬‭⁪⁯‍‍⁭‪‏‫‮​⁪⁭⁪‪‬‮, new System.Drawing.Size(56, 13));
						num = (int)(num2 * 80675925 ^ 11041154);
						continue;
					}
					case 87:
					{
						this.u202e⁮‍‍⁮‎⁪⁫⁫‍‮‭‬‍⁪‪‮⁭‬⁫⁯‪⁯​⁪‬‫​⁬‭‭⁯‫‎⁮‏​​‬‎‮ = TetraPanel.u206e⁮⁬⁫‏⁯‪​⁬‭​⁫‭‬⁯⁬‫⁪​⁮⁪⁪‏⁬⁯‍‫⁮⁭‌⁭⁮‪⁭⁯‬‬‍‭‪‮();
						this.u200f‫‮⁭⁭‬‌‪⁭‭‭‬⁮‪‮⁬⁬​⁮⁫‍⁮‍​⁮‫‪‮‎⁪⁬‎⁮⁭⁯⁯⁮‮‪⁭‮ = TetraPanel.u206e⁮⁬⁫‏⁯‪​⁬‭​⁫‭‬⁯⁬‫⁪​⁮⁪⁪‏⁬⁯‍‫⁮⁭‌⁭⁮‪⁭⁯‬‬‍‭‪‮();
						num = (int)(num2 * 1440199276 ^ -1313002871);
						continue;
					}
					case 88:
					{
						TetraPanel.u202b‏‏‬‎‮‫​‍​⁭‬‬‭‮⁫⁯‭⁪‬‎‫‫‎⁬‪‍‎⁪⁪‮‌‮‌‏⁯‌‍​‌‮(this.u200c⁭‫‪⁮⁪⁬‭⁬⁮‌⁬⁭‌‍‎⁫‮‭‍⁮‬‮⁫‫⁮⁬‮‬⁬‭⁯⁫‍‪⁪⁯‏​⁭‮, TetraPanel.u202c‫‭‪‌‌⁬‌⁬‌‪‬‏‌‍⁯⁪‮⁪‮‌‪⁪⁯‭⁮‪‪⁪‬‭​‬‭‮‍‭‌‍‮(u003cModuleu003e.u202a‮‫‏‫‬‬‪⁫⁬​‏⁫⁭‍‪‪‎⁬​‪​‌⁮‮‌​⁫​⁬‪‫⁪⁯⁪‎‫⁭‎⁪‮<string>(1627927687), 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0));
						num = 389842280;
						continue;
					}
					case 89:
					{
						this.u202e⁭​⁬‎​⁬⁮​⁬‬‫‎⁫‬‌​⁬⁪⁮​⁫⁬⁫⁪‎‍⁭⁭‬‬‪‎‍‬⁪‍‍​‍‮ = TetraPanel.u200f‭‏⁬⁪‎⁬‌⁬‌⁬‫⁪⁬‏‭‮‍‪​‎⁮‎‎⁬⁪‬⁭‎‌‬‮‪‬⁫⁬‮‬‪⁮‮();
						this.u202b⁭‎‭‭‏⁮⁮‮‮‍⁫⁫‎‏‏‌‬‏‬‭‮‪‌⁪‎‏⁫‫‬‬‏‎⁫⁬⁯‌⁭⁪‪‮ = TetraPanel.u200b‬‌⁯‫‪⁪⁯​‭‬‌‭⁯⁮⁮‏​‪‬⁯‭‪​⁫‮​‪‬‬​‌‏⁬⁪‪‏⁪‏⁬‮();
						this.u200f‏⁯‭‌⁫‌‏⁪‫‬‎‫⁫‮‫‎‬‭‪⁪‫⁮‫‍‎‎⁪⁭⁬⁯⁪‬‎‮⁫⁪‎‭‌‮ = TetraPanel.u200b‬‌⁯‫‪⁪⁯​‭‬‌‭⁯⁮⁮‏​‪‬⁯‭‪​⁫‮​‪‬‬​‌‏⁬⁪‪‏⁪‏⁬‮();
						this.u206d‪⁪‌⁭‌‫⁭‌⁪​‭⁫‎‪‭‌⁬‍‎‌‮‍‌‬‍‬⁬‏⁫‏‫‏‏‎‭‬‍‪⁫‮ = TetraPanel.u200b‬‌⁯‫‪⁪⁯​‭‬‌‭⁯⁮⁮‏​‪‬⁯‭‪​⁫‮​‪‬‬​‌‏⁬⁪‪‏⁪‏⁬‮();
						num = (int)(num2 * -839728092 ^ 177677412);
						continue;
					}
					case 90:
					{
						TetraPanel.u202d‏⁭⁫‮‫​‎‪⁫⁯‏⁮‫​‮‌⁮‬⁬‌⁮⁬‏⁭‏⁮‌⁮‮⁮‭‌‫‏⁪‎⁮‏‎‮(TetraPanel.u206a‬⁯⁭⁫‍⁪‫⁬⁭⁬⁮‫‏‍⁫‫‌⁪‪‌​⁭⁮‍‌‬⁯‭⁪‭⁮‏⁮‪​‍⁭⁫⁫‮(this.u200d‮⁪⁭⁭‍⁯‮‭‏‏⁭‬‫⁮⁯‬⁫‬‪⁫‎⁭‭​⁫‪⁬⁮⁫‍⁭​⁭‌⁪​⁪‭⁯‮), this.u200f‏⁪‪⁪‪⁯‪‌⁬‎‪‬‫⁯‭‬‌⁯‏⁮⁫‪⁯‬⁪⁭⁭‪‪‌‍‭‎⁭⁫⁯⁯​‏‮);
						num = (int)(num2 * 50236196 ^ 1849998713);
						continue;
					}
					case 91:
					{
						TetraPanel.u206e⁪‏‏​‍⁮‫⁬⁬⁯⁫⁯‏⁬⁮‫‫⁬⁬‭‫‌‌⁭‎​‭⁭‍⁬‏‏⁮‫⁮‭‮‎‪‮(this.u206d‫⁭‮⁯​⁫‬‍‪‍⁬⁭⁭‍‎‬‮⁪‫‫‍‎⁫​⁪‪​‮⁬‌​‬‮⁪‬‮⁫⁬⁫‮, u003cModuleu003e.u200e‏‌‬⁮‪‭⁭‭⁭‎​‏‌‭‭‭⁭⁬⁯⁫‍‮‫⁯‌‮‏​‬⁫⁯⁮⁫‮‪⁫‬⁮⁬‮<string>(732543488));
						num = 197857980;
						continue;
					}
					case 92:
					{
						this.u206c‮⁫⁫⁭⁬‍‮​‮⁭⁭⁭⁭⁪‪‪⁬‬⁫⁮‌​‎⁬‭‫‏‏⁮‍‍​⁯‎⁬‪⁬‏⁫‮ = TetraPanel.u200b‬‌⁯‫‪⁪⁯​‭‬‌‭⁯⁮⁮‏​‪‬⁯‭‪​⁫‮​‪‬‬​‌‏⁬⁪‪‏⁪‏⁬‮();
						num = (int)(num2 * 1914896731 ^ 1780180689);
						continue;
					}
					case 93:
					{
						TetraPanel.u202a‬​‍⁬‮‫‪⁯‎‫⁮⁭⁯‎‌⁭⁭‍‏‮‫‭‮‏‎‭⁮‮⁯‮⁬⁮‍‍‍⁭‫‮‪‮(this.u206c‍‍‌‬‪‮‪‮⁪‎⁬‍‭⁪‫‌‬‪⁫‫‫‫‪⁮‮‬⁮⁬⁪‫⁭‫‌⁪‮‪⁭⁭⁮‮, new EventHandler(this.u206a‮‌⁫‫‎⁬​⁮‌‏⁫‌⁫⁫⁪‫⁬‍⁫‫‎‬⁮⁬‫⁬‮‎‏⁫⁭‌⁪‌⁪‮‎‍‬‮));
						num = (int)(num2 * -1775888940 ^ 80310036);
						continue;
					}
					case 94:
					{
						this.u206d‫⁭‮⁯​⁫‬‍‪‍⁬⁭⁭‍‎‬‮⁪‫‫‍‎⁫​⁪‪​‮⁬‌​‬‮⁪‬‮⁫⁬⁫‮ = TetraPanel.u200b‬‌⁯‫‪⁪⁯​‭‬‌‭⁯⁮⁮‏​‪‬⁯‭‪​⁫‮​‪‬‬​‌‏⁬⁪‪‏⁪‏⁬‮();
						num = (int)(num2 * -777477159 ^ 1184170058);
						continue;
					}
					case 95:
					{
						TetraPanel.u202b‎⁯‫‮⁬‏‪⁫‍⁫‭​⁭‎​‎‮⁬‍‏‏‎⁯​⁭⁫‏‫‌‌‪‪​‬⁬⁭‫⁮‮‮(this.u200e⁫​‭⁪‫‏‬‮⁭⁬‌‏⁮⁮​‍‍‎‍‭‍‎​‪‪‭⁪‏‎⁬‎‍‫‮​⁬⁮⁯‫‮, new Point(3, 3));
						TetraPanel.u206e⁪‏‏​‍⁮‫⁬⁬⁯⁫⁯‏⁬⁮‫‫⁬⁬‭‫‌‌⁭‎​‭⁭‍⁬‏‏⁮‫⁮‭‮‎‪‮(this.u200e⁫​‭⁪‫‏‬‮⁭⁬‌‏⁮⁮​‍‍‎‍‭‍‎​‪‪‭⁪‏‎⁬‎‍‫‮​⁬⁮⁯‫‮, u003cModuleu003e.u206f⁮​‌‪‮‎‭‏‮‎⁮⁮‮⁬⁫‍‍⁪‍⁫⁮‏​‎⁬⁯⁪‪‍⁪⁮‎⁬⁪⁫​⁮⁪⁮‮<string>(742976091));
						num = 1466959029;
						continue;
					}
					case 96:
					{
						TetraPanel.u206d‫‫‫⁮‮‌​‍⁫‭‎‬​⁭‬⁫‪‌‍‍‎‮⁫‬⁭⁫‫‎⁯‏‌‮‮⁬‮⁬⁪‮(this.u206d‫⁭‮⁯​⁫‬‍‪‍⁬⁭⁭‍‎‬‮⁪‫‫‍‎⁫​⁪‪​‮⁬‌​‬‮⁪‬‮⁫⁬⁫‮, u003cModuleu003e.u200d​‍⁮‏‭⁮⁪‌‪‬‬‬‪⁬⁭⁫⁫‬⁪⁬⁬⁬‏⁮⁭‌‍‏‍‏‎‬⁬​‪‎​‎⁭‮<string>(-1254798070));
						num = 798336551;
						continue;
					}
					case 97:
					{
						TetraPanel.u202c⁭⁫‪‏⁬⁭⁭​​⁪⁫‬‍⁪⁫⁭⁬‮‌⁭‫‮‭​⁫‌⁪‎‏⁪‫‮‌​‌‍⁮⁮⁮‮(this.u206a⁭‫⁬⁯‌‎⁯‬‍​‏‎‌‏⁯‏⁮‬⁯⁮‎⁯⁬‌‪⁯⁬⁭⁬​‭​‌​‎⁫⁪‭‍‮, new System.Drawing.Size(220, 501));
						num = (int)(num2 * -233582059 ^ 1421504947);
						continue;
					}
					case 98:
					{
						TetraPanel.u200e‭⁭‌‪‫​⁯⁫⁫‪⁯‍⁯⁯⁭‎⁫‮⁮​​‭‎‮‍‏‎‎⁪‌⁫‬‮⁮‌⁮‏⁭⁪‮(this.u200f⁫⁭⁬​‮‫‭‪‬‏⁯‭‎‭⁫‌⁬⁮‭‮‌‮⁫⁫‭‎‪‎‎​⁫‎⁮⁭⁯⁫‌‮‫‮, true);
						num = (int)(num2 * -91311598 ^ -1853372241);
						continue;
					}
					case 99:
					{
						TetraPanel.u206a‬⁪‏⁭‏‫‬‎⁪‬⁮‪⁭‪​‪‍⁮⁪⁭⁮⁫‮‎‭‍‮‎‎⁪⁮‮‫‎⁫⁫‌⁯‌‮(this.u202b‫‌‍⁭‎‮⁮‍‮‎‏⁮‭‌⁭⁫‮⁮‭‎‏⁮⁮‌‌‫‬‪⁬⁬‏‌‭‌‫‌‭‭⁭‮, new EventHandler(this.u200c‎‎⁬‏‪‎‌⁭⁯‮⁭‭‪‎⁯⁪⁫‏‫⁬​‬⁪‭‪⁬‫‭⁮‮‏‏‍⁪⁫⁬​‍⁮‮));
						num = (int)(num2 * 473198285 ^ -1585358921);
						continue;
					}
					case 100:
					{
						TetraPanel.u206e⁪‏‏​‍⁮‫⁬⁬⁯⁫⁯‏⁬⁮‫‫⁬⁬‭‫‌‌⁭‎​‭⁭‍⁬‏‏⁮‫⁮‭‮‎‪‮(this.u202e⁭​⁬‎​⁬⁮​⁬‬‫‎⁫‬‌​⁬⁪⁮​⁫⁬⁫⁪‎‍⁭⁭‬‬‪‎‍‬⁪‍‍​‍‮, u003cModuleu003e.u202a‮‫‏‫‬‬‪⁫⁬​‏⁫⁭‍‪‪‎⁬​‪​‌⁮‮‌​⁫​⁬‪‫⁪⁯⁪‎‫⁭‎⁪‮<string>(-268040165));
						TetraPanel.u202c⁭⁫‪‏⁬⁭⁭​​⁪⁫‬‍⁪⁫⁭⁬‮‌⁭‫‮‭​⁫‌⁪‎‏⁪‫‮‌​‌‍⁮⁮⁮‮(this.u202e⁭​⁬‎​⁬⁮​⁬‬‫‎⁫‬‌​⁬⁪⁮​⁫⁬⁫⁪‎‍⁭⁭‬‬‪‎‍‬⁪‍‍​‍‮, new System.Drawing.Size(38, 13));
						num = 1025088324;
						continue;
					}
					case 101:
					{
						TetraPanel.u202c⁭⁫‪‏⁬⁭⁭​​⁪⁫‬‍⁪⁫⁭⁬‮‌⁭‫‮‭​⁫‌⁪‎‏⁪‫‮‌​‌‍⁮⁮⁮‮(this.u206d‏‪‫‍⁪‪⁬‌⁪‌‪‭⁫‫‎‍⁯‎‬‭⁪⁯​⁪⁮‬​‌​‎‌⁪‭⁮‏‌‫‫⁯‮, new System.Drawing.Size(73, 17));
						num = (int)(num2 * -1923368978 ^ 1378328286);
						continue;
					}
					case 102:
					{
						TetraPanel.u206d‫‫‫⁮‮‌​‍⁫‭‎‬​⁭‬⁫‪‌‍‍‎‮⁫‬⁭⁫‫‎⁯‏‌‮‮⁬‮⁬⁪‮(this.u202e⁮‍‍⁮‎⁪⁫⁫‍‮‭‬‍⁪‪‮⁭‬⁫⁯‪⁯​⁪‬‫​⁬‭‭⁯‫‎⁮‏​​‬‎‮, u003cModuleu003e.u202a‮‫‏‫‬‬‪⁫⁬​‏⁫⁭‍‪‪‎⁬​‪​‌⁮‮‌​⁫​⁬‪‫⁪⁯⁪‎‫⁭‎⁪‮<string>(-1826592170));
						TetraPanel.u200c‏⁫‬‭‌‪⁮‬⁮‏‪⁭‍‪⁯‫⁬⁫⁭‭‮‬‬⁪⁫‏⁭‏⁮⁫​⁫⁬‪‌‫⁭‭‍‮(this.u202e⁮‍‍⁮‎⁪⁫⁫‍‮‭‬‍⁪‪‮⁭‬⁫⁯‪⁯​⁪‬‫​⁬‭‭⁯‫‎⁮‏​​‬‎‮, true);
						num = 796155055;
						continue;
					}
					case 103:
					{
						TetraPanel.u206e⁪‏‏​‍⁮‫⁬⁬⁯⁫⁯‏⁬⁮‫‫⁬⁬‭‫‌‌⁭‎​‭⁭‍⁬‏‏⁮‫⁮‭‮‎‪‮(this.u206c‮⁫⁫⁭⁬‍‮​‮⁭⁭⁭⁭⁪‪‪⁬‬⁫⁮‌​‎⁬‭‫‏‏⁮‍‍​⁯‎⁬‪⁬‏⁫‮, u003cModuleu003e.u200f⁫‌​⁬‌‎‎‏‍‍⁫‎​‌‬⁯‬‫‭‎‏​‌​⁪‭‬⁬‮⁬​‌⁬⁪‫‫‎⁪⁮‮<string>(-109490846));
						num = 1857383184;
						continue;
					}
					case 104:
					{
						TetraPanel.u202d‏⁭⁫‮‫​‎‪⁫⁯‏⁮‫​‮‌⁮‬⁬‌⁮⁬‏⁭‏⁮‌⁮‮⁮‭‌‫‏⁪‎⁮‏‎‮(TetraPanel.u206a‬⁯⁭⁫‍⁪‫⁬⁭⁬⁮‫‏‍⁫‫‌⁪‪‌​⁭⁮‍‌‬⁯‭⁪‭⁮‏⁮‪​‍⁭⁫⁫‮(this.u200d‮⁪⁭⁭‍⁯‮‭‏‏⁭‬‫⁮⁯‬⁫‬‪⁫‎⁭‭​⁫‪⁬⁮⁫‍⁭​⁭‌⁪​⁪‭⁯‮), this.u200e​⁭⁯​‏‏‎‭⁮‍‮⁬‪‮‪⁮‫⁭‏‍⁬‍‎‏‪‫‪‮⁪‍⁫‮‍⁪‬‏‭‮‏‮);
						num = (int)(num2 * -611765707 ^ 817354767);
						continue;
					}
					case 105:
					{
						TetraPanel.u200e‭⁭‌‪‫​⁯⁫⁫‪⁯‍⁯⁯⁭‎⁫‮⁮​​‭‎‮‍‏‎‎⁪‌⁫‬‮⁮‌⁮‏⁭⁪‮(this.u202e⁮‍‍⁮‎⁪⁫⁫‍‮‭‬‍⁪‪‮⁭‬⁫⁯‪⁯​⁪‬‫​⁬‭‭⁯‫‎⁮‏​​‬‎‮, true);
						TetraPanel.u202b‏‏‬‎‮‫​‍​⁭‬‬‭‮⁫⁯‭⁪‬‎‫‫‎⁬‪‍‎⁪⁪‮‌‮‌‏⁯‌‍​‌‮(this.u202e⁮‍‍⁮‎⁪⁫⁫‍‮‭‬‍⁪‪‮⁭‬⁫⁯‪⁯​⁪‬‫​⁬‭‭⁯‫‎⁮‏​​‬‎‮, TetraPanel.u202c‫‭‪‌‌⁬‌⁬‌‪‬‏‌‍⁯⁪‮⁪‮‌‪⁪⁯‭⁮‪‪⁪‬‭​‬‭‮‍‭‌‍‮(u003cModuleu003e.u200d​‍⁮‏‭⁮⁪‌‪‬‬‬‪⁬⁭⁫⁫‬⁪⁬⁬⁬‏⁮⁭‌‍‏‍‏‎‬⁬​‪‎​‎⁭‮<string>(2136952738), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0));
						num = 1095902607;
						continue;
					}
					case 106:
					{
						TetraPanel.u202b‏‏‬‎‮‫​‍​⁭‬‬‭‮⁫⁯‭⁪‬‎‫‫‎⁬‪‍‎⁪⁪‮‌‮‌‏⁯‌‍​‌‮(this.u206f⁯⁭‫‍⁪‬‭⁮‪⁯⁭‮‌‭‪‏⁯‫‪‎‪⁯⁫⁪‌‭‪‌‫⁮‭⁪‍‏‌‪‬‏‫‮, TetraPanel.u202c‫‭‪‌‌⁬‌⁬‌‪‬‏‌‍⁯⁪‮⁪‮‌‪⁪⁯‭⁮‪‪⁪‬‭​‬‭‮‍‭‌‍‮(u003cModuleu003e.u200d​‍⁮‏‭⁮⁪‌‪‬‬‬‪⁬⁭⁫⁫‬⁪⁬⁬⁬‏⁮⁭‌‍‏‍‏‎‬⁬​‪‎​‎⁭‮<string>(2136952738), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0));
						TetraPanel.u202b‎⁯‫‮⁬‏‪⁫‍⁫‭​⁭‎​‎‮⁬‍‏‏‎⁯​⁭⁫‏‫‌‌‪‪​‬⁬⁭‫⁮‮‮(this.u206f⁯⁭‫‍⁪‬‭⁮‪⁯⁭‮‌‭‪‏⁯‫‪‎‪⁯⁫⁪‌‭‪‌‫⁮‭⁪‍‏‌‪‬‏‫‮, new Point(82, 71));
						TetraPanel.u206e⁪‏‏​‍⁮‫⁬⁬⁯⁫⁯‏⁬⁮‫‫⁬⁬‭‫‌‌⁭‎​‭⁭‍⁬‏‏⁮‫⁮‭‮‎‪‮(this.u206f⁯⁭‫‍⁪‬‭⁮‪⁯⁭‮‌‭‪‏⁯‫‪‎‪⁯⁫⁪‌‭‪‌‫⁮‭⁪‍‏‌‪‬‏‫‮, u003cModuleu003e.u200e‏‌‬⁮‪‭⁭‭⁭‎​‏‌‭‭‭⁭⁬⁯⁫‍‮‫⁯‌‮‏​‬⁫⁯⁮⁫‮‪⁫‬⁮⁬‮<string>(312532277));
						TetraPanel.u202c⁭⁫‪‏⁬⁭⁭​​⁪⁫‬‍⁪⁫⁭⁬‮‌⁭‫‮‭​⁫‌⁪‎‏⁪‫‮‌​‌‍⁮⁮⁮‮(this.u206f⁯⁭‫‍⁪‬‭⁮‪⁯⁭‮‌‭‪‏⁯‫‪‎‪⁯⁫⁪‌‭‪‌‫⁮‭⁪‍‏‌‪‬‏‫‮, new System.Drawing.Size(13, 13));
						num = 906872263;
						continue;
					}
					case 107:
					{
						TetraPanel.u202c⁭⁫‪‏⁬⁭⁭​​⁪⁫‬‍⁪⁫⁭⁬‮‌⁭‫‮‭​⁫‌⁪‎‏⁪‫‮‌​‌‍⁮⁮⁮‮(this.u202b‫‌‍⁭‎‮⁮‍‮‎‏⁮‭‌⁭⁫‮⁮‭‎‏⁮⁮‌‌‫‬‪⁬⁬‏‌‭‌‫‌‭‭⁭‮, new System.Drawing.Size(47, 20));
						num = (int)(num2 * 1331770481 ^ -1821899485);
						continue;
					}
					case 108:
					{
						TetraPanel.u202d‏⁭⁫‮‫​‎‪⁫⁯‏⁮‫​‮‌⁮‬⁬‌⁮⁬‏⁭‏⁮‌⁮‮⁮‭‌‫‏⁪‎⁮‏‎‮(TetraPanel.u206a‬⁯⁭⁫‍⁪‫⁬⁭⁬⁮‫‏‍⁫‫‌⁪‪‌​⁭⁮‍‌‬⁯‭⁪‭⁮‏⁮‪​‍⁭⁫⁫‮(this.u200d‮⁪⁭⁭‍⁯‮‭‏‏⁭‬‫⁮⁯‬⁫‬‪⁫‎⁭‭​⁫‪⁬⁮⁫‍⁭​⁭‌⁪​⁪‭⁯‮), this.u200f‫‮⁭⁭‬‌‪⁭‭‭‬⁮‪‮⁬⁬​⁮⁫‍⁮‍​⁮‫‪‮‎⁪⁬‎⁮⁭⁯⁯⁮‮‪⁭‮);
						num = (int)(num2 * 444308742 ^ -2109784021);
						continue;
					}
					case 109:
					{
						this.u200d‌‏‪‍‭⁯‎⁫⁪⁮⁮‍‮⁪⁫⁮⁬‎⁭⁫⁬‭‎⁯‪‍‏‌⁭⁯⁯‬‫‌‭⁮‬‭⁭‮ = new Display();
						num = (int)(num2 * -756999711 ^ -119424747);
						continue;
					}
					case 110:
					{
						this.u202a‪‌⁫⁫‭⁬⁭⁫⁯⁮‪​‮⁮‮‍‌⁪⁬‭‮‬‬⁮‫‪‫‮‍‮​‏‌‍‌​​‬‪‮ = TetraPanel.u200b‬‌⁯‫‪⁪⁯​‭‬‌‭⁯⁮⁮‏​‪‬⁯‭‪​⁫‮​‪‬‬​‌‏⁬⁪‪‏⁪‏⁬‮();
						num = (int)(num2 * -1124049794 ^ -1008422472);
						continue;
					}
					case 111:
					{
						TetraPanel.u206e⁪‏‏​‍⁮‫⁬⁬⁯⁫⁯‏⁬⁮‫‫⁬⁬‭‫‌‌⁭‎​‭⁭‍⁬‏‏⁮‫⁮‭‮‎‪‮(this.u202e⁮‍‍⁮‎⁪⁫⁫‍‮‭‬‍⁪‪‮⁭‬⁫⁯‪⁯​⁪‬‫​⁬‭‭⁯‫‎⁮‏​​‬‎‮, u003cModuleu003e.u202a‮‫‏‫‬‬‪⁫⁬​‏⁫⁭‍‪‪‎⁬​‪​‌⁮‮‌​⁫​⁬‪‫⁪⁯⁪‎‫⁭‎⁪‮<string>(1719821391));
						num = 1803899337;
						continue;
					}
					case 112:
					{
						TetraPanel.u202b‏‏‬‎‮‫​‍​⁭‬‬‭‮⁫⁯‭⁪‬‎‫‫‎⁬‪‍‎⁪⁪‮‌‮‌‏⁯‌‍​‌‮(this.u206b⁭‍‏⁮‪‎‪‎⁬‌⁪⁬⁯‎‬⁫⁬‭⁪⁯‍⁭⁮‪‍⁬‬⁭‮‭⁯​‏‪⁮​​‎⁭‮, TetraPanel.u202c‫‭‪‌‌⁬‌⁬‌‪‬‏‌‍⁯⁪‮⁪‮‌‪⁪⁯‭⁮‪‪⁪‬‭​‬‭‮‍‭‌‍‮(u003cModuleu003e.u206f⁮​‌‪‮‎‭‏‮‎⁮⁮‮⁬⁫‍‍⁪‍⁫⁮‏​‎⁬⁯⁪‪‍⁪⁮‎⁬⁪⁫​⁮⁪⁮‮<string>(125941577), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0));
						TetraPanel.u202b‎⁯‫‮⁬‏‪⁫‍⁫‭​⁭‎​‎‮⁬‍‏‏‎⁯​⁭⁫‏‫‌‌‪‪​‬⁬⁭‫⁮‮‮(this.u206b⁭‍‏⁮‪‎‪‎⁬‌⁪⁬⁯‎‬⁫⁬‭⁪⁯‍⁭⁮‪‍⁬‬⁭‮‭⁯​‏‪⁮​​‎⁭‮, new Point(123, 0));
						TetraPanel.u206e⁪‏‏​‍⁮‫⁬⁬⁯⁫⁯‏⁬⁮‫‫⁬⁬‭‫‌‌⁭‎​‭⁭‍⁬‏‏⁮‫⁮‭‮‎‪‮(this.u206b⁭‍‏⁮‪‎‪‎⁬‌⁪⁬⁯‎‬⁫⁬‭⁪⁯‍⁭⁮‪‍⁬‬⁭‮‭⁯​‏‪⁮​​‎⁭‮, u003cModuleu003e.u200f⁫‌​⁬‌‎‎‏‍‍⁫‎​‌‬⁯‬‫‭‎‏​‌​⁪‭‬⁬‮⁬​‌⁬⁪‫‫‎⁪⁮‮<string>(-2108723676));
						num = 93265412;
						continue;
					}
					case 113:
					{
						TetraPanel.u202b‏‏‬‎‮‫​‍​⁭‬‬‭‮⁫⁯‭⁪‬‎‫‫‎⁬‪‍‎⁪⁪‮‌‮‌‏⁯‌‍​‌‮(this.u202a⁫⁫⁪‎⁯⁭‬‬⁬​‮‍⁭‮‌⁭‌‏‎‭‫‌‏‏⁫⁬‮⁬‌⁭​⁫⁯‫⁮⁭‬‏‏‮, TetraPanel.u202c‫‭‪‌‌⁬‌⁬‌‪‬‏‌‍⁯⁪‮⁪‮‌‪⁪⁯‭⁮‪‪⁪‬‭​‬‭‮‍‭‌‍‮(u003cModuleu003e.u206f⁮​‌‪‮‎‭‏‮‎⁮⁮‮⁬⁫‍‍⁪‍⁫⁮‏​‎⁬⁯⁪‪‍⁪⁮‎⁬⁪⁫​⁮⁪⁮‮<string>(125941577), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0));
						TetraPanel.u202b‎⁯‫‮⁬‏‪⁫‍⁫‭​⁭‎​‎‮⁬‍‏‏‎⁯​⁭⁫‏‫‌‌‪‪​‬⁬⁭‫⁮‮‮(this.u202a⁫⁫⁪‎⁯⁭‬‬⁬​‮‍⁭‮‌⁭‌‏‎‭‫‌‏‏⁫⁬‮⁬‌⁭​⁫⁯‫⁮⁭‬‏‏‮, new Point(89, 56));
						num = 422556196;
						continue;
					}
					case 114:
					{
						TetraPanel.u206e⁪‫‮‫⁮⁭‏‏‮‏‍⁭‬‏⁯​‬‍‌‎‫‍‬⁮⁮‫⁭⁯​‭‬⁯‌⁮⁮⁭‭‍⁬‮(this.u200d‮⁪⁭⁭‍⁯‮‭‏‏⁭‬‫⁮⁯‬⁫‬‪⁫‎⁭‭​⁫‪⁬⁮⁫‍⁭​⁭‌⁪​⁪‭⁯‮);
						TetraPanel.u206c‎⁫​‌‎​⁯⁮‮⁪⁬‌⁯‍⁫‬‍​⁮‫‮‌‍‪‫‎‭⁬⁯⁪‎‭⁫‫‏⁮‏‮⁫‮(this.u202b‫‌‍⁭‎‮⁮‍‮‎‏⁮‭‌⁭⁫‮⁮‭‎‏⁮⁮‌‌‫‬‪⁬⁬‏‌‭‌‫‌‭‭⁭‮);
						TetraPanel.u206e⁪‫‮‫⁮⁭‏‏‮‏‍⁭‬‏⁯​‬‍‌‎‫‍‬⁮⁮‫⁭⁯​‭‬⁯‌⁮⁮⁭‭‍⁬‮(this.u206a‎‪⁮​‮⁭‭⁪‎⁪‏‌‎‌‎⁮⁫‬‭‍⁭⁭‫‏⁫​‬‪⁪‮⁮‏‏⁭⁬‌⁪⁯‭‮);
						TetraPanel.u206a⁫‌⁭‌‬‬‎‌‭‫‍‎⁫⁬⁪​‎‬‏⁭‭‎⁬‍‭‪‫‏‬⁫⁬‫⁯⁯​‬‪​‬‮(this);
						num = (int)(num2 * 1510378573 ^ 2091794477);
						continue;
					}
					case 115:
					{
						TetraPanel.u202e‎‫‪⁮‏‪‎​⁬‮‎⁪⁪⁫‭⁯‌‏‬​‏⁫⁭‬⁫‎‬⁯‎⁪‏⁮​‍⁯⁫⁮⁯‫‮(this.u206a‎‪⁮​‮⁭‭⁪‎⁪‏‌‎‌‎⁮⁫‬‭‍⁭⁭‫‏⁫​‬‪⁪‮⁮‏‏⁭⁬‌⁪⁯‭‮);
						num = (int)(num2 * -1911103506 ^ 1310135392);
						continue;
					}
					case 116:
					{
						TetraPanel.u202b‏‏‬‎‮‫​‍​⁭‬‬‭‮⁫⁯‭⁪‬‎‫‫‎⁬‪‍‎⁪⁪‮‌‮‌‏⁯‌‍​‌‮(this.u200f‏⁯‭‌⁫‌‏⁪‫‬‎‫⁫‮‫‎‬‭‪⁪‫⁮‫‍‎‎⁪⁭⁬⁯⁪‬‎‮⁫⁪‎‭‌‮, TetraPanel.u202c‫‭‪‌‌⁬‌⁬‌‪‬‏‌‍⁯⁪‮⁪‮‌‪⁪⁯‭⁮‪‪⁪‬‭​‬‭‮‍‭‌‍‮(u003cModuleu003e.u202a‮‫‏‫‬‬‪⁫⁬​‏⁫⁭‍‪‪‎⁬​‪​‌⁮‮‌​⁫​⁬‪‫⁪⁯⁪‎‫⁭‎⁪‮<string>(1627927687), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0));
						TetraPanel.u202b‎⁯‫‮⁬‏‪⁫‍⁫‭​⁭‎​‎‮⁬‍‏‏‎⁯​⁭⁫‏‫‌‌‪‪​‬⁬⁭‫⁮‮‮(this.u200f‏⁯‭‌⁫‌‏⁪‫‬‎‫⁫‮‫‎‬‭‪⁪‫⁮‫‍‎‎⁪⁭⁬⁯⁪‬‎‮⁫⁪‎‭‌‮, new Point(89, 38));
						num = 1480336680;
						continue;
					}
					case 117:
					{
						TetraPanel.u206e⁪‏‏​‍⁮‫⁬⁬⁯⁫⁯‏⁬⁮‫‫⁬⁬‭‫‌‌⁭‎​‭⁭‍⁬‏‏⁮‫⁮‭‮‎‪‮(this.u202a‪⁮​‏‫‮‫⁭⁯⁭‬⁯‎‭​‎⁬‭⁬‬‬‬‌⁪‍⁪​‎‍⁯​‍⁯⁫‎‍⁪‎‭‮, u003cModuleu003e.u206f⁮​‌‪‮‎‭‏‮‎⁮⁮‮⁬⁫‍‍⁪‍⁫⁮‏​‎⁬⁯⁪‪‍⁪⁮‎⁬⁪⁫​⁮⁪⁮‮<string>(-2129756336));
						num = 282731831;
						continue;
					}
					case 118:
					{
						TetraPanel.u206b⁬‪‍‭⁮⁪‌‭⁯⁪⁪‏‌‪⁯⁭‮​‭‏‌⁮⁯⁪‪‬​⁮⁯‮⁫⁮‪‪‫‍⁪⁬‎‮(this.u200b‏⁭⁯⁮⁬‭‮⁭⁯‮​‏‭⁬⁮‫⁬⁬‬‮‏‏‎‮⁫⁬⁭⁮​​⁮⁪⁭⁭​‫‫‮, 57);
						num = (int)(num2 * -1232564674 ^ -1894687509);
						continue;
					}
					case 119:
					{
						TetraPanel.u206c‎⁫​‌‎​⁯⁮‮⁪⁬‌⁯‍⁫‬‍​⁮‫‮‌‍‪‫‎‭⁬⁯⁪‎‭⁫‫‏⁮‏‮⁫‮(this.u200f‍‮‏‌‏‌‍‍⁪⁫⁯⁭‫⁮⁫‫⁯‏‫⁪‍‫⁮‮⁪⁫‍‭‍⁫‏‍⁫‍‌⁪⁫⁪⁭‮);
						num = (int)(num2 * -306872135 ^ 70704055);
						continue;
					}
					case 120:
					{
						TetraPanel.u202b‪​⁯⁪⁬⁬‭‍⁪‫‪​‮‍‭‎‍⁯‫‭⁮‭​⁯​‍⁬‌‭‭⁯⁭‭‬‍‭‎‎⁭‮(this.u200d‎‫‎‪​‍‏‍⁯‫⁬⁮‌‫⁭‏​​‏⁫‬⁬‎‭‍⁫‌⁬‬⁬‬⁬‏‎⁮​‬⁫⁪‮, 1000);
						num = (int)(num2 * -592110383 ^ -1657386537);
						continue;
					}
					case 121:
					{
						TetraPanel.u206d‫‫‫⁮‮‌​‍⁫‭‎‬​⁭‬⁫‪‌‍‍‎‮⁫‬⁭⁫‫‎⁯‏‌‮‮⁬‮⁬⁪‮(this.u202e‪⁬⁫⁬⁭‪‏‌‏‫‫⁬⁭‌‭‮⁭⁭‬‪⁭⁭‬‌‮⁮⁭⁫‌‬⁯⁫‪‭‎‭‎‍⁫‮, u003cModuleu003e.u200d​‍⁮‏‭⁮⁪‌‪‬‬‬‪⁬⁭⁫⁫‬⁪⁬⁬⁬‏⁮⁭‌‍‏‍‏‎‬⁬​‪‎​‎⁭‮<string>(-661122553));
						TetraPanel.u200e‭⁭‌‪‫​⁯⁫⁫‪⁯‍⁯⁯⁭‎⁫‮⁮​​‭‎‮‍‏‎‎⁪‌⁫‬‮⁮‌⁮‏⁭⁪‮(this.u200c‫‌‪‌‌‏​⁯⁪​‫⁪⁮⁯‫‍⁪⁫⁪‮⁬⁬‭⁯‌‫⁯‫‪‏‭‏⁭⁬‌‫‬⁪⁬‮, true);
						num = 162299308;
						continue;
					}
					case 122:
					{
						TetraPanel.u206d‫‫‫⁮‮‌​‍⁫‭‎‬​⁭‬⁫‪‌‍‍‎‮⁫‬⁭⁫‫‎⁯‏‌‮‮⁬‮⁬⁪‮(this.u200d⁪‮‬⁭​​⁫⁪⁯⁫‬‏⁮⁭​‭‬‏‏⁭⁯‫‌‮‎⁫⁫‏‮⁮⁬⁫‮⁮⁪⁯‭‎‫‮, u003cModuleu003e.u200e‏‌‬⁮‪‭⁭‭⁭‎​‏‌‭‭‭⁭⁬⁯⁫‍‮‫⁯‌‮‏​‬⁫⁯⁮⁫‮‪⁫‬⁮⁬‮<string>(1772434054));
						num = 268573831;
						continue;
					}
					case 123:
					{
						TetraPanel.u202c⁭⁫‪‏⁬⁭⁭​​⁪⁫‬‍⁪⁫⁭⁬‮‌⁭‫‮‭​⁫‌⁪‎‏⁪‫‮‌​‌‍⁮⁮⁮‮(this.u206c‍‍‌‬‪‮‪‮⁪‎⁬‍‭⁪‫‌‬‪⁫‫‫‫‪⁮‮‬⁮⁬⁪‫⁭‫‌⁪‮‪⁭⁭⁮‮, new System.Drawing.Size(23, 13));
						TetraPanel.u206b⁬‪‍‭⁮⁪‌‭⁯⁪⁪‏‌‪⁯⁭‮​‭‏‌⁮⁯⁪‪‬​⁮⁯‮⁫⁮‪‪‫‍⁪⁬‎‮(this.u206c‍‍‌‬‪‮‪‮⁪‎⁬‍‭⁪‫‌‬‪⁫‫‫‫‪⁮‮‬⁮⁬⁪‫⁭‫‌⁪‮‪⁭⁭⁮‮, 53);
						TetraPanel.u206d‫‫‫⁮‮‌​‍⁫‭‎‬​⁭‬⁫‪‌‍‍‎‮⁫‬⁭⁫‫‎⁯‏‌‮‮⁬‮⁬⁪‮(this.u206c‍‍‌‬‪‮‪‮⁪‎⁬‍‭⁪‫‌‬‪⁫‫‫‫‪⁮‮‬⁮⁬⁪‫⁭‫‌⁪‮‪⁭⁭⁮‮, u003cModuleu003e.u202a‮‫‏‫‬‬‪⁫⁬​‏⁫⁭‍‪‪‎⁬​‪​‌⁮‮‌​⁫​⁬‪‫⁪⁯⁪‎‫⁭‎⁪‮<string>(-1298971363));
						num = 709820789;
						continue;
					}
					case 124:
					{
						TetraPanel.u202c⁭⁫‪‏⁬⁭⁭​​⁪⁫‬‍⁪⁫⁭⁬‮‌⁭‫‮‭​⁫‌⁪‎‏⁪‫‮‌​‌‍⁮⁮⁮‮(this.u202a⁫⁫⁪‎⁯⁭‬‬⁬​‮‍⁭‮‌⁭‌‏‎‭‫‌‏‏⁫⁬‮⁬‌⁭​⁫⁯‫⁮⁭‬‏‏‮, new System.Drawing.Size(44, 13));
						TetraPanel.u206b⁬‪‍‭⁮⁪‌‭⁯⁪⁪‏‌‪⁯⁭‮​‭‏‌⁮⁯⁪‪‬​⁮⁯‮⁫⁮‪‪‫‍⁪⁬‎‮(this.u202a⁫⁫⁪‎⁯⁭‬‬⁬​‮‍⁭‮‌⁭‌‏‎‭‫‌‏‏⁫⁬‮⁬‌⁭​⁫⁯‫⁮⁭‬‏‏‮, 60);
						TetraPanel.u206d‫‫‫⁮‮‌​‍⁫‭‎‬​⁭‬⁫‪‌‍‍‎‮⁫‬⁭⁫‫‎⁯‏‌‮‮⁬‮⁬⁪‮(this.u202a⁫⁫⁪‎⁯⁭‬‬⁬​‮‍⁭‮‌⁭‌‏‎‭‫‌‏‏⁫⁬‮⁬‌⁭​⁫⁯‫⁮⁭‬‏‏‮, u003cModuleu003e.u200d​‍⁮‏‭⁮⁪‌‪‬‬‬‪⁬⁭⁫⁫‬⁪⁬⁬⁬‏⁮⁭‌‍‏‍‏‎‬⁬​‪‎​‎⁭‮<string>(-566294362));
						num = 472824975;
						continue;
					}
					case 125:
					{
						TetraPanel.u202d‏⁭⁫‮‫​‎‪⁫⁯‏⁮‫​‮‌⁮‬⁬‌⁮⁬‏⁭‏⁮‌⁮‮⁮‭‌‫‏⁪‎⁮‏‎‮(TetraPanel.u206a‬⁯⁭⁫‍⁪‫⁬⁭⁬⁮‫‏‍⁫‫‌⁪‪‌​⁭⁮‍‌‬⁯‭⁪‭⁮‏⁮‪​‍⁭⁫⁫‮(this.u206a⁭‫⁬⁯‌‎⁯‬‍​‏‎‌‏⁯‏⁮‬⁯⁮‎⁯⁬‌‪⁯⁬⁭⁬​‭​‌​‎⁫⁪‭‍‮), this.u200d‮⁪⁭⁭‍⁯‮‭‏‏⁭‬‫⁮⁯‬⁫‬‪⁫‎⁭‭​⁫‪⁬⁮⁫‍⁭​⁭‌⁪​⁪‭⁯‮);
						TetraPanel.u202d‏⁭⁫‮‫​‎‪⁫⁯‏⁮‫​‮‌⁮‬⁬‌⁮⁬‏⁭‏⁮‌⁮‮⁮‭‌‫‏⁪‎⁮‏‎‮(TetraPanel.u206a‬⁯⁭⁫‍⁪‫⁬⁭⁬⁮‫‏‍⁫‫‌⁪‪‌​⁭⁮‍‌‬⁯‭⁪‭⁮‏⁮‪​‍⁭⁫⁫‮(this.u206a⁭‫⁬⁯‌‎⁯‬‍​‏‎‌‏⁯‏⁮‬⁯⁮‎⁯⁬‌‪⁯⁬⁭⁬​‭​‌​‎⁫⁪‭‍‮), this.u206a‎‪⁮​‮⁭‭⁪‎⁪‏‌‎‌‎⁮⁫‬‭‍⁭⁭‫‏⁫​‬‪⁪‮⁮‏‏⁭⁬‌⁪⁯‭‮);
						TetraPanel.u202d‏⁭⁫‮‫​‎‪⁫⁯‏⁮‫​‮‌⁮‬⁬‌⁮⁬‏⁭‏⁮‌⁮‮⁮‭‌‫‏⁪‎⁮‏‎‮(TetraPanel.u206a‬⁯⁭⁫‍⁪‫⁬⁭⁬⁮‫‏‍⁫‫‌⁪‪‌​⁭⁮‍‌‬⁯‭⁪‭⁮‏⁮‪​‍⁭⁫⁫‮(this.u206a⁭‫⁬⁯‌‎⁯‬‍​‏‎‌‏⁯‏⁮‬⁯⁮‎⁯⁬‌‪⁯⁬⁭⁬​‭​‌​‎⁫⁪‭‍‮), this.u206c‫‍⁯⁫⁬⁬‎‮‎‭‎⁭⁪‍‏⁯‬​⁪‪⁯⁪​⁪‪‫‏⁮‏‍⁮⁮‫​‭⁬⁪⁮‍‮);
						num = (int)(num2 * 1009568382 ^ 1541516921);
						continue;
					}
					case 126:
					{
						TetraPanel.u206d‫‫‫⁮‮‌​‍⁫‭‎‬​⁭‬⁫‪‌‍‍‎‮⁫‬⁭⁫‫‎⁯‏‌‮‮⁬‮⁬⁪‮(this.u202e‭‭‮​⁬⁯‎⁫​‬‏‌⁮⁮‮⁮⁬⁭‮⁯⁯‏‬‎​‎‍‏⁭⁮‏‬‫⁪‍‬‫‪‬‮, u003cModuleu003e.u200f⁫‌​⁬‌‎‎‏‍‍⁫‎​‌‬⁯‬‫‭‎‏​‌​⁪‭‬⁬‮⁬​‌⁬⁪‫‫‎⁪⁮‮<string>(-2015150883));
						num = 1650454121;
						continue;
					}
					case 127:
					{
						TetraPanel.u206b⁬‪‍‭⁮⁪‌‭⁯⁪⁪‏‌‪⁯⁭‮​‭‏‌⁮⁯⁪‪‬​⁮⁯‮⁫⁮‪‪‫‍⁪⁬‎‮(this.u202b⁭‎‭‭‏⁮⁮‮‮‍⁫⁫‎‏‏‌‬‏‬‭‮‪‌⁪‎‏⁫‫‬‬‏‎⁫⁬⁯‌⁭⁪‪‮, 68);
						num = (int)(num2 * 471685532 ^ 757348545);
						continue;
					}
					case 128:
					{
						TetraPanel.u202d‏⁭⁫‮‫​‎‪⁫⁯‏⁮‫​‮‌⁮‬⁬‌⁮⁬‏⁭‏⁮‌⁮‮⁮‭‌‫‏⁪‎⁮‏‎‮(TetraPanel.u206a‬⁯⁭⁫‍⁪‫⁬⁭⁬⁮‫‏‍⁫‫‌⁪‪‌​⁭⁮‍‌‬⁯‭⁪‭⁮‏⁮‪​‍⁭⁫⁫‮(this.u200e⁫​‭⁪‫‏‬‮⁭⁬‌‏⁮⁮​‍‍‎‍‭‍‎​‪‪‭⁪‏‎⁬‎‍‫‮​⁬⁮⁯‫‮), this.u206a⁭‫⁬⁯‌‎⁯‬‍​‏‎‌‏⁯‏⁮‬⁯⁮‎⁯⁬‌‪⁯⁬⁭⁬​‭​‌​‎⁫⁪‭‍‮);
						num = (int)(num2 * -94929570 ^ 147382721);
						continue;
					}
					case 129:
					{
						TetraPanel.u202c⁭⁫‪‏⁬⁭⁭​​⁪⁫‬‍⁪⁫⁭⁬‮‌⁭‫‮‭​⁫‌⁪‎‏⁪‫‮‌​‌‍⁮⁮⁮‮(this.u200f‏⁪‪⁪‪⁯‪‌⁬‎‪‬‫⁯‭‬‌⁯‏⁮⁫‪⁯‬⁪⁭⁭‪‪‌‍‭‎⁭⁫⁯⁯​‏‮, new System.Drawing.Size(36, 13));
						num = (int)(num2 * -1824563634 ^ 760775234);
						continue;
					}
					case 130:
					{
						TetraPanel.u202d‏⁭⁫‮‫​‎‪⁫⁯‏⁮‫​‮‌⁮‬⁬‌⁮⁬‏⁭‏⁮‌⁮‮⁮‭‌‫‏⁪‎⁮‏‎‮(TetraPanel.u206a‬⁯⁭⁫‍⁪‫⁬⁭⁬⁮‫‏‍⁫‫‌⁪‪‌​⁭⁮‍‌‬⁯‭⁪‭⁮‏⁮‪​‍⁭⁫⁫‮(this.u206a⁭‫⁬⁯‌‎⁯‬‍​‏‎‌‏⁯‏⁮‬⁯⁮‎⁯⁬‌‪⁯⁬⁭⁬​‭​‌​‎⁫⁪‭‍‮), this.u200f‍‮‏‌‏‌‍‍⁪⁫⁯⁭‫⁮⁫‫⁯‏‫⁪‍‫⁮‮⁪⁫‍‭‍⁫‏‍⁫‍‌⁪⁫⁪⁭‮);
						TetraPanel.u202d‏⁭⁫‮‫​‎‪⁫⁯‏⁮‫​‮‌⁮‬⁬‌⁮⁬‏⁭‏⁮‌⁮‮⁮‭‌‫‏⁪‎⁮‏‎‮(TetraPanel.u206a‬⁯⁭⁫‍⁪‫⁬⁭⁬⁮‫‏‍⁫‫‌⁪‪‌​⁭⁮‍‌‬⁯‭⁪‭⁮‏⁮‪​‍⁭⁫⁫‮(this.u206a⁭‫⁬⁯‌‎⁯‬‍​‏‎‌‏⁯‏⁮‬⁯⁮‎⁯⁬‌‪⁯⁬⁭⁬​‭​‌​‎⁫⁪‭‍‮), this.u202a‪⁮​‏‫‮‫⁭⁯⁭‬⁯‎‭​‎⁬‭⁬‬‬‬‌⁪‍⁪​‎‍⁯​‍⁯⁫‎‍⁪‎‭‮);
						TetraPanel.u202d‏⁭⁫‮‫​‎‪⁫⁯‏⁮‫​‮‌⁮‬⁬‌⁮⁬‏⁭‏⁮‌⁮‮⁮‭‌‫‏⁪‎⁮‏‎‮(TetraPanel.u206a‬⁯⁭⁫‍⁪‫⁬⁭⁬⁮‫‏‍⁫‫‌⁪‪‌​⁭⁮‍‌‬⁯‭⁪‭⁮‏⁮‪​‍⁭⁫⁫‮(this.u206a⁭‫⁬⁯‌‎⁯‬‍​‏‎‌‏⁯‏⁮‬⁯⁮‎⁯⁬‌‪⁯⁬⁭⁬​‭​‌​‎⁫⁪‭‍‮), this.u202e⁭​⁬‎​⁬⁮​⁬‬‫‎⁫‬‌​⁬⁪⁮​⁫⁬⁫⁪‎‍⁭⁭‬‬‪‎‍‬⁪‍‍​‍‮);
						num = (int)(num2 * 1538672162 ^ 1702250850);
						continue;
					}
					case 131:
					{
						TetraPanel.u206d‫‫‫⁮‮‌​‍⁫‭‎‬​⁭‬⁫‪‌‍‍‎‮⁫‬⁭⁫‫‎⁯‏‌‮‮⁬‮⁬⁪‮(this.u200e‎⁭‏‎‪‎‍‬⁭⁮⁬‍⁭‮​⁪‮‏‍⁪‎‫⁮‫⁭⁯⁪‌‌​‌⁬‫‏‬‍⁯⁮‭‮, u003cModuleu003e.u202a‮‫‏‫‬‬‪⁫⁬​‏⁫⁭‍‪‪‎⁬​‪​‌⁮‮‌​⁫​⁬‪‫⁪⁯⁪‎‫⁭‎⁪‮<string>(-697617114));
						num = 403512245;
						continue;
					}
					case 132:
					{
						TetraPanel.u202c⁭⁫‪‏⁬⁭⁭​​⁪⁫‬‍⁪⁫⁭⁬‮‌⁭‫‮‭​⁫‌⁪‎‏⁪‫‮‌​‌‍⁮⁮⁮‮(this.u200d‌‎‪⁯⁯⁫‭‬‬‭‎​‍‮⁯‮‌‬‪‭​⁮⁭⁬‏‏‫⁪‏⁭⁬‏⁮⁮‬⁯‏‭‍‮, new System.Drawing.Size(13, 13));
						num = (int)(num2 * -1781298237 ^ -1419691672);
						continue;
					}
					case 133:
					{
						TetraPanel.u206b⁬‪‍‭⁮⁪‌‭⁯⁪⁪‏‌‪⁯⁭‮​‭‏‌⁮⁯⁪‪‬​⁮⁯‮⁫⁮‪‪‫‍⁪⁬‎‮(this.u206a‎‪⁮​‮⁭‭⁪‎⁪‏‌‎‌‎⁮⁫‬‭‍⁭⁭‫‏⁫​‬‪⁪‮⁮‏‏⁭⁬‌⁪⁯‭‮, 42);
						num = (int)(num2 * -2131477367 ^ 1776839631);
						continue;
					}
					case 134:
					{
						TetraPanel.u202c⁭⁫‪‏⁬⁭⁭​​⁪⁫‬‍⁪⁫⁭⁬‮‌⁭‫‮‭​⁫‌⁪‎‏⁪‫‮‌​‌‍⁮⁮⁮‮(this.u200f‫‮⁭⁭‬‌‪⁭‭‭‬⁮‪‮⁬⁬​⁮⁫‍⁮‍​⁮‫‪‮‎⁪⁬‎⁮⁭⁯⁯⁮‮‪⁭‮, new System.Drawing.Size(73, 17));
						TetraPanel.u206b⁬‪‍‭⁮⁪‌‭⁯⁪⁪‏‌‪⁯⁭‮​‭‏‌⁮⁯⁪‪‬​⁮⁯‮⁫⁮‪‪‫‍⁪⁬‎‮(this.u200f‫‮⁭⁭‬‌‪⁭‭‭‬⁮‪‮⁬⁬​⁮⁫‍⁮‍​⁮‫‪‮‎⁪⁬‎⁮⁭⁯⁯⁮‮‪⁭‮, 55);
						TetraPanel.u202a⁫⁬‭‏⁪‌⁬‏⁫​‎⁮‏‭‌‎‌⁯⁮‪‍‭⁪‏⁪‌‎⁬‮‏⁫‏‬⁫⁭⁫⁭‫⁪‮(this.u200f‫‮⁭⁭‬‌‪⁭‭‭‬⁮‪‮⁬⁬​⁮⁫‍⁮‍​⁮‫‪‮‎⁪⁬‎⁮⁭⁯⁯⁮‮‪⁭‮, true);
						num = (int)(num2 * 1917148109 ^ 1710805570);
						continue;
					}
					case 135:
					{
						TetraPanel.u206c‬​‍⁬‪‍​‭‌⁮‫‮⁭‫‮⁯⁯‎‌‎⁮​‪‮⁬‭⁪‪⁭‍‏⁪‍‮⁬‬‏‎‮(this, new EventHandler(this.u206f⁪⁫‪‎⁮⁫⁭‏⁯‬‮⁪⁬⁪‍‌‭‭‭⁮⁫‏‮‌⁫‎‎⁪​‬⁬‏‪‫​⁮⁫⁮⁮‮));
						num = (int)(num2 * 666401295 ^ 1891255551);
						continue;
					}
					case 136:
					{
						TetraPanel.u200f‍​‍⁯‏‫‫‏‮⁬​‎⁬‍‪⁪‎‫‌‮‎‪‌‌‮⁪⁪‌‭⁭‮⁭​‎⁭⁪‬⁮‎‮(this.u202e⁪‍‍⁫⁪‪‍‌‏⁪⁪⁫⁪‎‮‭‌⁭‬‪⁮​‭⁯⁯‌‮⁪⁬‮⁬⁬​‮‏⁯⁯‌‏‮, new EventHandler(this.u200e‍​‭‎⁮‏‮​‫⁫‪⁪‬⁫‏⁫‍‭⁫‮⁭⁪‫‭⁬⁬‌‎⁯⁬‌⁭⁬‬⁫‮‬⁬‎‮));
						num = (int)(num2 * 2116073154 ^ 1900686966);
						continue;
					}
					case 137:
					{
						this.u200f‍‮‏‌‏‌‍‍⁪⁫⁯⁭‫⁮⁫‫⁯‏‫⁪‍‫⁮‮⁪⁫‍‭‍⁫‏‍⁫‍‌⁪⁫⁪⁭‮ = TetraPanel.u202a⁪⁭⁬​‍⁮⁪‮⁬‍‌⁮‍⁯‮⁫‪⁪‏⁪‍⁮‮⁬​‏‮⁪⁬⁯‌‏​‭⁭‫‭⁬‮‮();
						num = (int)(num2 * -992026550 ^ 1470647568);
						continue;
					}
					case 138:
					{
						TetraPanel.u206c‎⁫​‌‎​⁯⁮‮⁪⁬‌⁯‍⁫‬‍​⁮‫‮‌‍‪‫‎‭⁬⁯⁪‎‭⁫‫‏⁮‏‮⁫‮(this.u202a‪⁮​‏‫‮‫⁭⁯⁭‬⁯‎‭​‎⁬‭⁬‬‬‬‌⁪‍⁪​‎‍⁯​‍⁯⁫‎‍⁪‎‭‮);
						num = (int)(num2 * -1212025213 ^ -1115286186);
						continue;
					}
					case 139:
					{
						TetraPanel.u202a⁫⁬‭‏⁪‌⁬‏⁫​‎⁮‏‭‌‎‌⁯⁮‪‍‭⁪‏⁪‌‎⁬‮‏⁫‏‬⁫⁭⁫⁭‫⁪‮(this.u206d‏‪‫‍⁪‪⁬‌⁪‌‪‭⁫‫‎‍⁯‎‬‭⁪⁯​⁪⁮‬​‌​‎‌⁪‭⁮‏‌‫‫⁯‮, true);
						TetraPanel.u206d‫‫‫⁮‮‌​‍⁫‭‎‬​⁭‬⁫‪‌‍‍‎‮⁫‬⁭⁫‫‎⁯‏‌‮‮⁬‮⁬⁪‮(this.u206d‏‪‫‍⁪‪⁬‌⁪‌‪‭⁫‫‎‍⁯‎‬‭⁪⁯​⁪⁮‬​‌​‎‌⁪‭⁮‏‌‫‫⁯‮, u003cModuleu003e.u200e‏‌‬⁮‪‭⁭‭⁭‎​‏‌‭‭‭⁭⁬⁯⁫‍‮‫⁯‌‮‏​‬⁫⁯⁮⁫‮‪⁫‬⁮⁬‮<string>(1789342589));
						TetraPanel.u200c‏⁫‬‭‌‪⁮‬⁮‏‪⁭‍‪⁯‫⁬⁫⁭‭‮‬‬⁪⁫‏⁭‏⁮⁫​⁫⁬‪‌‫⁭‭‍‮(this.u206d‏‪‫‍⁪‪⁬‌⁪‌‪‭⁫‫‎‍⁯‎‬‭⁪⁯​⁪⁮‬​‌​‎‌⁪‭⁮‏‌‫‫⁯‮, false);
						TetraPanel.u202e⁯‮​‏‬⁭‬⁯⁯⁭‎⁯‮‎​‮⁪⁮‭‌⁮⁭‬‫⁭⁭‮‮⁯‪‫⁭⁬‌⁭‬‏⁬‬‮(this.u206d‏‪‫‍⁪‪⁬‌⁪‌‪‭⁫‫‎‍⁯‎‬‭⁪⁯​⁪⁮‬​‌​‎‌⁪‭⁮‏‌‫‫⁯‮, new EventHandler(this.u202c⁫‭‪⁭⁮‪‭⁭⁭‏⁪⁯⁭‮‫‮‪⁫‪‍‎⁭‌⁭⁬‌‪​⁭⁪⁫‮⁫​⁬‌‬⁬⁭‮));
						TetraPanel.u200e‭⁭‌‪‫​⁯⁫⁫‪⁯‍⁯⁯⁭‎⁫‮⁮​​‭‎‮‍‏‎‎⁪‌⁫‬‮⁮‌⁮‏⁭⁪‮(this.u200c‎‎‪‎‮‎⁫‭‪⁯⁬⁪⁬‏‮‏‪‫‏⁯⁪​⁬‫⁯⁪‎‪‏‫‮⁯‏‪‭‬‏‪‮, true);
						num = 1312193527;
						continue;
					}
					case 140:
					{
						TetraPanel.u206e⁪‏‏​‍⁮‫⁬⁬⁯⁫⁯‏⁬⁮‫‫⁬⁬‭‫‌‌⁭‎​‭⁭‍⁬‏‏⁮‫⁮‭‮‎‪‮(this.u200e​⁭⁯​‏‏‎‭⁮‍‮⁬‪‮‪⁮‫⁭‏‍⁬‍‎‏‪‫‪‮⁪‍⁫‮‍⁪‬‏‭‮‏‮, u003cModuleu003e.u206f⁮​‌‪‮‎‭‏‮‎⁮⁮‮⁬⁫‍‍⁪‍⁫⁮‏​‎⁬⁯⁪‪‍⁪⁮‎⁬⁪⁫​⁮⁪⁮‮<string>(-1841812239));
						num = 1649786209;
						continue;
					}
					case 141:
					{
						TetraPanel.u200e​⁮⁯‮⁭‬‭⁫⁭⁬‌‭‎⁬⁬⁮⁬‭‬⁮‭‏⁫‫​‮‌‬⁪​‮⁮‪‪⁭‮⁪‍⁮‮(this.u206a‎‪⁮​‮⁭‭⁪‎⁪‏‌‎‌‎⁮⁫‬‭‍⁭⁭‫‏⁫​‬‪⁪‮⁮‏‏⁭⁬‌⁪⁯‭‮, AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
						num = (int)(num2 * 1943604374 ^ 80534181);
						continue;
					}
					case 142:
					{
						TetraPanel.u202b‏‏‬‎‮‫​‍​⁭‬‬‭‮⁫⁯‭⁪‬‎‫‫‎⁬‪‍‎⁪⁪‮‌‮‌‏⁯‌‍​‌‮(this.u202a‎‎‭⁭⁬‎⁬‏⁫⁬⁯‫‎‬‪‏⁬‪‬‭‌‪‌‎⁯‪‪‫​‪​⁮‫‭‌⁮​⁪⁬‮, TetraPanel.u202c‫‭‪‌‌⁬‌⁬‌‪‬‏‌‍⁯⁪‮⁪‮‌‪⁪⁯‭⁮‪‪⁪‬‭​‬‭‮‍‭‌‍‮(u003cModuleu003e.u200d​‍⁮‏‭⁮⁪‌‪‬‬‬‪⁬⁭⁫⁫‬⁪⁬⁬⁬‏⁮⁭‌‍‏‍‏‎‬⁬​‪‎​‎⁭‮<string>(2136952738), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0));
						TetraPanel.u202b‎⁯‫‮⁬‏‪⁫‍⁫‭​⁭‎​‎‮⁬‍‏‏‎⁯​⁭⁫‏‫‌‌‪‪​‬⁬⁭‫⁮‮‮(this.u202a‎‎‭⁭⁬‎⁬‏⁫⁬⁯‫‎‬‪‏⁬‪‬‭‌‪‌‎⁯‪‪‫​‪​⁮‫‭‌⁮​⁪⁬‮, new Point(82, 54));
						num = 123920802;
						continue;
					}
					case 143:
					{
						this.u202a‪‬⁭‮⁬⁫‫⁬‮‏‪‪‭‎‌‫‪‍⁭‏⁮⁬‭⁪⁯‍‍⁭‪‏‫‮​⁪⁭⁪‪‬‮ = TetraPanel.u200b‬‌⁯‫‪⁪⁯​‭‬‌‭⁯⁮⁮‏​‪‬⁯‭‪​⁫‮​‪‬‬​‌‏⁬⁪‪‏⁪‏⁬‮();
						this.u202b⁪⁭‍‎⁭‮⁮‭⁮⁪‬⁯⁭‎‌⁫‮‮⁪‍⁯‎‍‫⁫‪‪‎‪‬‍‎‮‍⁭‍⁭‎⁬‮ = TetraPanel.u200b‬‌⁯‫‪⁪⁯​‭‬‌‭⁯⁮⁮‏​‪‬⁯‭‪​⁫‮​‪‬‬​‌‏⁬⁪‪‏⁪‏⁬‮();
						this.u206a⁯‏⁯​‫‬⁬‌⁮​⁯‬‌‭⁯‪⁬⁯⁮‌‫⁫⁫‍‎‎⁫⁮‫‍‍‪​‮‍‮‭⁬‏‮ = TetraPanel.u202a⁪⁭⁬​‍⁮⁪‮⁬‍‌⁮‍⁯‮⁫‪⁪‏⁪‍⁮‮⁬​‏‮⁪⁬⁯‌‏​‭⁭‫‭⁬‮‮();
						num = (int)(num2 * -2089136986 ^ -1439080817);
						continue;
					}
					case 144:
					{
						TetraPanel.u206e⁪‏‏​‍⁮‫⁬⁬⁯⁫⁯‏⁬⁮‫‫⁬⁬‭‫‌‌⁭‎​‭⁭‍⁬‏‏⁮‫⁮‭‮‎‪‮(this.u200d⁪‮‬⁭​​⁫⁪⁯⁫‬‏⁮⁭​‭‬‏‏⁭⁯‫‌‮‎⁫⁫‏‮⁮⁬⁫‮⁮⁪⁯‭‎‫‮, u003cModuleu003e.u200d​‍⁮‏‭⁮⁪‌‪‬‬‬‪⁬⁭⁫⁫‬⁪⁬⁬⁬‏⁮⁭‌‍‏‍‏‎‬⁬​‪‎​‎⁭‮<string>(1057799323));
						TetraPanel.u202c⁭⁫‪‏⁬⁭⁭​​⁪⁫‬‍⁪⁫⁭⁬‮‌⁭‫‮‭​⁫‌⁪‎‏⁪‫‮‌​‌‍⁮⁮⁮‮(this.u200d⁪‮‬⁭​​⁫⁪⁯⁫‬‏⁮⁭​‭‬‏‏⁭⁯‫‌‮‎⁫⁫‏‮⁮⁬⁫‮⁮⁪⁯‭‎‫‮, new System.Drawing.Size(38, 13));
						TetraPanel.u206b⁬‪‍‭⁮⁪‌‭⁯⁪⁪‏‌‪⁯⁭‮​‭‏‌⁮⁯⁪‪‬​⁮⁯‮⁫⁮‪‪‫‍⁪⁬‎‮(this.u200d⁪‮‬⁭​​⁫⁪⁯⁫‬‏⁮⁭​‭‬‏‏⁭⁯‫‌‮‎⁫⁫‏‮⁮⁬⁫‮⁮⁪⁯‭‎‫‮, 69);
						num = 1497932974;
						continue;
					}
					case 145:
					{
						this.u200d‮⁪⁭⁭‍⁯‮‭‏‏⁭‬‫⁮⁯‬⁫‬‪⁫‎⁭‭​⁫‪⁬⁮⁫‍⁭​⁭‌⁪​⁪‭⁯‮ = TetraPanel.u200b‏‌​‍‬⁮‭‍⁬⁬⁪​⁫⁬⁭‭⁪‪‎‏‏⁮‏‏‌‭​⁮‍‬⁮‪⁪​‬‮‏‪‮();
						num = (int)(num2 * 1882607561 ^ 1761338305);
						continue;
					}
					case 146:
					{
						TetraPanel.u202b‏‏‬‎‮‫​‍​⁭‬‬‭‮⁫⁯‭⁪‬‎‫‫‎⁬‪‍‎⁪⁪‮‌‮‌‏⁯‌‍​‌‮(this.u200c‎‏⁪⁭⁬⁫‎⁭‪⁫⁫‮​⁯‫‪‏‮‮‬‬⁬‍⁭⁯‪⁪⁫⁬‬⁫‬‍⁮‍⁭‪‭⁪‮, TetraPanel.u202c‫‭‪‌‌⁬‌⁬‌‪‬‏‌‍⁯⁪‮⁪‮‌‪⁪⁯‭⁮‪‪⁪‬‭​‬‭‮‍‭‌‍‮(u003cModuleu003e.u200f⁫‌​⁬‌‎‎‏‍‍⁫‎​‌‬⁯‬‫‭‎‏​‌​⁪‭‬⁬‮⁬​‌⁬⁪‫‫‎⁪⁮‮<string>(-285035864), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0));
						num = 462877954;
						continue;
					}
					case 147:
					{
						TetraPanel.u202b‏‏‬‎‮‫​‍​⁭‬‬‭‮⁫⁯‭⁪‬‎‫‫‎⁬‪‍‎⁪⁪‮‌‮‌‏⁯‌‍​‌‮(this.u202a‪⁮​‏‫‮‫⁭⁯⁭‬⁯‎‭​‎⁬‭⁬‬‬‬‌⁪‍⁪​‎‍⁯​‍⁯⁫‎‍⁪‎‭‮, TetraPanel.u202c‫‭‪‌‌⁬‌⁬‌‪‬‏‌‍⁯⁪‮⁪‮‌‪⁪⁯‭⁮‪‪⁪‬‭​‬‭‮‍‭‌‍‮(u003cModuleu003e.u200d​‍⁮‏‭⁮⁪‌‪‬‬‬‪⁬⁭⁫⁫‬⁪⁬⁬⁬‏⁮⁭‌‍‏‍‏‎‬⁬​‪‎​‎⁭‮<string>(2136952738), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0));
						num = 507334474;
						continue;
					}
					case 148:
					{
						TetraPanel.u206e⁪‏‏​‍⁮‫⁬⁬⁯⁫⁯‏⁬⁮‫‫⁬⁬‭‫‌‌⁭‎​‭⁭‍⁬‏‏⁮‫⁮‭‮‎‪‮(this.u200b‏⁭⁯⁮⁬‭‮⁭⁯‮​‏‭⁬⁮‫⁬⁬‬‮‏‏‎‮⁫⁬⁭⁮​​⁮⁪⁭⁭​‫‫‮, u003cModuleu003e.u200d​‍⁮‏‭⁮⁪‌‪‬‬‬‪⁬⁭⁫⁫‬⁪⁬⁬⁬‏⁮⁭‌‍‏‍‏‎‬⁬​‪‎​‎⁭‮<string>(718222257));
						num = 785251291;
						continue;
					}
					case 149:
					{
						TetraPanel.u200e‭⁭‌‪‫​⁯⁫⁫‪⁯‍⁯⁯⁭‎⁫‮⁮​​‭‎‮‍‏‎‎⁪‌⁫‬‮⁮‌⁮‏⁭⁪‮(this.u202b‫‭‪⁯⁯⁮‎⁫⁫⁮‫⁪⁯⁮⁭⁫‎‏⁮⁭‭⁪‌⁯⁪⁪‍⁯⁯‌⁫‪‮⁭‌⁪‎‬⁫‮, true);
						num = (int)(num2 * -438878498 ^ 23477923);
						continue;
					}
					case 150:
					{
						TetraPanel.u200e‭⁭‌‪‫​⁯⁫⁫‪⁯‍⁯⁯⁭‎⁫‮⁮​​‭‎‮‍‏‎‎⁪‌⁫‬‮⁮‌⁮‏⁭⁪‮(this.u202a‪‌⁫⁫‭⁬⁭⁫⁯⁮‪​‮⁮‮‍‌⁪⁬‭‮‬‬⁮‫‪‫‮‍‮​‏‌‍‌​​‬‪‮, true);
						TetraPanel.u202b‏‏‬‎‮‫​‍​⁭‬‬‭‮⁫⁯‭⁪‬‎‫‫‎⁬‪‍‎⁪⁪‮‌‮‌‏⁯‌‍​‌‮(this.u202a‪‌⁫⁫‭⁬⁭⁫⁯⁮‪​‮⁮‮‍‌⁪⁬‭‮‬‬⁮‫‪‫‮‍‮​‏‌‍‌​​‬‪‮, TetraPanel.u202c‫‭‪‌‌⁬‌⁬‌‪‬‏‌‍⁯⁪‮⁪‮‌‪⁪⁯‭⁮‪‪⁪‬‭​‬‭‮‍‭‌‍‮(u003cModuleu003e.u200e‏‌‬⁮‪‭⁭‭⁭‎​‏‌‭‭‭⁭⁬⁯⁫‍‮‫⁯‌‮‏​‬⁫⁯⁮⁫‮‪⁫‬⁮⁬‮<string>(507840788), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0));
						TetraPanel.u202b‎⁯‫‮⁬‏‪⁫‍⁫‭​⁭‎​‎‮⁬‍‏‏‎⁯​⁭⁫‏‫‌‌‪‪​‬⁬⁭‫⁮‮‮(this.u202a‪‌⁫⁫‭⁬⁭⁫⁯⁮‪​‮⁮‮‍‌⁪⁬‭‮‬‬⁮‫‪‫‮‍‮​‏‌‍‌​​‬‪‮, new Point(82, 88));
						TetraPanel.u206e⁪‏‏​‍⁮‫⁬⁬⁯⁫⁯‏⁬⁮‫‫⁬⁬‭‫‌‌⁭‎​‭⁭‍⁬‏‏⁮‫⁮‭‮‎‪‮(this.u202a‪‌⁫⁫‭⁬⁭⁫⁯⁮‪​‮⁮‮‍‌⁪⁬‭‮‬‬⁮‫‪‫‮‍‮​‏‌‍‌​​‬‪‮, u003cModuleu003e.u200e‏‌‬⁮‪‭⁭‭⁭‎​‏‌‭‭‭⁭⁬⁯⁫‍‮‫⁯‌‮‏​‬⁫⁯⁮⁫‮‪⁫‬⁮⁬‮<string>(-169046071));
						num = 225577397;
						continue;
					}
					case 151:
					{
						TetraPanel.u200e​⁮⁯‮⁭‬‭⁫⁭⁬‌‭‎⁬⁬⁮⁬‭‬⁮‭‏⁫‫​‮‌‬⁪​‮⁮‪‪⁭‮⁪‍⁮‮(this.u200e‮⁯​⁬⁫‍⁭⁯⁪‪⁫‭⁯‬⁭‫‭⁭⁫‮⁮‏⁫‮‫‭‍‫​⁭‏⁮⁯‎‭⁯‫⁯⁮‮, AnchorStyles.Top | AnchorStyles.Right);
						num = (int)(num2 * 1002188664 ^ 1177469971);
						continue;
					}
					case 152:
					{
						TetraPanel.u206e⁪‏‏​‍⁮‫⁬⁬⁯⁫⁯‏⁬⁮‫‫⁬⁬‭‫‌‌⁭‎​‭⁭‍⁬‏‏⁮‫⁮‭‮‎‪‮(this.u206a⁯‏⁯​‫‬⁬‌⁮​⁯‬‌‭⁯‪⁬⁯⁮‌‫⁫⁫‍‎‎⁫⁮‫‍‍‪​‮‍‮‭⁬‏‮, u003cModuleu003e.u206f⁮​‌‪‮‎‭‏‮‎⁮⁮‮⁬⁫‍‍⁪‍⁫⁮‏​‎⁬⁯⁪‪‍⁪⁮‎⁬⁪⁫​⁮⁪⁮‮<string>(-1517997994));
						TetraPanel.u202c⁭⁫‪‏⁬⁭⁭​​⁪⁫‬‍⁪⁫⁭⁬‮‌⁭‫‮‭​⁫‌⁪‎‏⁪‫‮‌​‌‍⁮⁮⁮‮(this.u206a⁯‏⁯​‫‬⁬‌⁮​⁯‬‌‭⁯‪⁬⁯⁮‌‫⁫⁫‍‎‎⁫⁮‫‍‍‪​‮‍‮‭⁬‏‮, new System.Drawing.Size(48, 20));
						num = 218624563;
						continue;
					}
					case 153:
					{
						TetraPanel.u202b‎⁯‫‮⁬‏‪⁫‍⁫‭​⁭‎​‎‮⁬‍‏‏‎⁯​⁭⁫‏‫‌‌‪‪​‬⁬⁭‫⁮‮‮(this.u206a‮​‫‪‪⁬‫‏⁬⁯‫‏⁬‌​⁪‮​‌⁬‏‍‎‍‌⁬⁮⁫‍⁪⁭‎‭‌⁭⁫⁬‏⁮‮, new Point(6, 20));
						num = (int)(num2 * -494035567 ^ -942295084);
						continue;
					}
					case 154:
					{
						TetraPanel.u200f⁪​‬‍‏‭‭‏‫⁬‬‭‮⁯‫⁫⁯⁫‪‌‌‌‪‍⁪‏‎‌‬⁮⁬⁫⁬⁬⁮‪⁮⁬‪‮(this.u206a‎‪⁮​‮⁭‭⁪‎⁪‏‌‎‌‎⁮⁫‬‭‍⁭⁭‫‏⁫​‬‪⁪‮⁮‏‏⁭⁬‌⁪⁯‭‮, false);
						TetraPanel.u206d‫‫‫⁮‮‌​‍⁫‭‎‬​⁭‬⁫‪‌‍‍‎‮⁫‬⁭⁫‫‎⁯‏‌‮‮⁬‮⁬⁪‮(this.u206a‎‪⁮​‮⁭‭⁪‎⁪‏‌‎‌‎⁮⁫‬‭‍⁭⁭‫‏⁫​‬‪⁪‮⁮‏‏⁭⁬‌⁪⁯‭‮, u003cModuleu003e.u200e‏‌‬⁮‪‭⁭‭⁭‎​‏‌‭‭‭⁭⁬⁯⁫‍‮‫⁯‌‮‏​‬⁫⁯⁮⁫‮‪⁫‬⁮⁬‮<string>(-2011560705));
						TetraPanel.u206f‮⁫⁯⁪‌‏⁭‏‌⁫⁯⁬‬⁭⁬⁬⁯⁮⁭⁮‮⁯⁯‬⁭⁬‏‌⁭⁬⁯⁪‫‮​‮‍⁫‍‮(this.u206a‎‪⁮​‮⁭‭⁪‎⁪‏‌‎‌‎⁮⁫‬‭‍⁭⁭‫‏⁫​‬‪⁪‮⁮‏‏⁭⁬‌⁪⁯‭‮, new PaintEventHandler(this.u206d‏⁮‬‫‮⁯‪‮‎‍‌‪⁭‬‏⁬‎‫⁭‌⁫‪⁯‎⁮‍‫⁮⁪‏‮⁪⁫⁫⁯⁮‌​⁭‮));
						num = 1042136510;
						continue;
					}
					case 155:
					{
						TetraPanel.u200c‏⁫‬‭‌‪⁮‬⁮‏‪⁭‍‪⁯‫⁬⁫⁭‭‮‬‬⁪⁫‏⁭‏⁮⁫​⁫⁬‪‌‫⁭‭‍‮(this.u202e‭‭‮​⁬⁯‎⁫​‬‏‌⁮⁮‮⁮⁬⁭‮⁯⁯‏‬‎​‎‍‏⁭⁮‏‬‫⁪‍‬‫‪‬‮, false);
						TetraPanel.u206e⁮⁭‎⁮⁪‮‌‏‫‫‌⁮⁬‮⁫⁮⁪⁫⁪‬‪​⁭⁯‭⁬‌‍‭⁪⁮‪⁯‎‬‪⁪‍⁯‮(this.u202e‭‭‮​⁬⁯‎⁫​‬‏‌⁮⁮‮⁮⁬⁭‮⁯⁯‏‬‎​‎‍‏⁭⁮‏‬‫⁪‍‬‫‪‬‮, new EventHandler(this.u206c‫‫​​‎⁯‫‫‭‍⁭‌‎⁮⁮‌‌⁭‮‎‎⁫‮‏‪‫‍⁯⁮⁮⁬‮‌⁪⁫⁮‭‬‌‮));
						num = (int)(num2 * -622955296 ^ -1100760948);
						continue;
					}
					case 156:
					{
						TetraPanel.u202b‎⁯‫‮⁬‏‪⁫‍⁫‭​⁭‎​‎‮⁬‍‏‏‎⁯​⁭⁫‏‫‌‌‪‪​‬⁬⁭‫⁮‮‮(this.u200c⁭‫‪⁮⁪⁬‭⁬⁮‌⁬⁭‌‍‎⁫‮‭‍⁮‬‮⁫‫⁮⁬‮‬⁬‭⁯⁫‍‪⁪⁯‏​⁭‮, new Point(148, 17));
						num = (int)(num2 * -566699469 ^ 314912071);
						continue;
					}
					case 157:
					{
						TetraPanel.u202d‏⁭⁫‮‫​‎‪⁫⁯‏⁮‫​‮‌⁮‬⁬‌⁮⁬‏⁭‏⁮‌⁮‮⁮‭‌‫‏⁪‎⁮‏‎‮(TetraPanel.u206a‬⁯⁭⁫‍⁪‫⁬⁭⁬⁮‫‏‍⁫‫‌⁪‪‌​⁭⁮‍‌‬⁯‭⁪‭⁮‏⁮‪​‍⁭⁫⁫‮(this.u206a⁭‫⁬⁯‌‎⁯‬‍​‏‎‌‏⁯‏⁮‬⁯⁮‎⁯⁬‌‪⁯⁬⁭⁬​‭​‌​‎⁫⁪‭‍‮), this.u206c‍‍‌‬‪‮‪‮⁪‎⁬‍‭⁪‫‌‬‪⁫‫‫‫‪⁮‮‬⁮⁬⁪‫⁭‫‌⁪‮‪⁭⁭⁮‮);
						num = (int)(num2 * 578281449 ^ -1724990398);
						continue;
					}
					case 158:
					{
						TetraPanel.u200e‭⁭‌‪‫​⁯⁫⁫‪⁯‍⁯⁯⁭‎⁫‮⁮​​‭‎‮‍‏‎‎⁪‌⁫‬‮⁮‌⁮‏⁭⁪‮(this.u206e‬​⁯⁫‍‎​‮⁬⁮‍‫‪‬‌‌‭⁯⁫‮‫‮⁭‮‫‪‫⁮‫⁪‏‏‏‫‏‭⁬⁬‍‮, true);
						TetraPanel.u202b‏‏‬‎‮‫​‍​⁭‬‬‭‮⁫⁯‭⁪‬‎‫‫‎⁬‪‍‎⁪⁪‮‌‮‌‏⁯‌‍​‌‮(this.u206e‬​⁯⁫‍‎​‮⁬⁮‍‫‪‬‌‌‭⁯⁫‮‫‮⁭‮‫‪‫⁮‫⁪‏‏‏‫‏‭⁬⁬‍‮, TetraPanel.u202c‫‭‪‌‌⁬‌⁬‌‪‬‏‌‍⁯⁪‮⁪‮‌‪⁪⁯‭⁮‪‪⁪‬‭​‬‭‮‍‭‌‍‮(u003cModuleu003e.u206f⁮​‌‪‮‎‭‏‮‎⁮⁮‮⁬⁫‍‍⁪‍⁫⁮‏​‎⁬⁯⁪‪‍⁪⁮‎⁬⁪⁫​⁮⁪⁮‮<string>(125941577), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0));
						num = 431882444;
						continue;
					}
					case 159:
					{
						TetraPanel.u202c⁭⁫‪‏⁬⁭⁭​​⁪⁫‬‍⁪⁫⁭⁬‮‌⁭‫‮‭​⁫‌⁪‎‏⁪‫‮‌​‌‍⁮⁮⁮‮(this.u202a‪‌⁫⁫‭⁬⁭⁫⁯⁮‪​‮⁮‮‍‌⁪⁬‭‮‬‬⁮‫‪‫‮‍‮​‏‌‍‌​​‬‪‮, new System.Drawing.Size(13, 13));
						num = (int)(num2 * -1787880108 ^ 160415115);
						continue;
					}
					case 160:
					{
						TetraPanel.u202b‎⁯‫‮⁬‏‪⁫‍⁫‭​⁭‎​‎‮⁬‍‏‏‎⁯​⁭⁫‏‫‌‌‪‪​‬⁬⁭‫⁮‮‮(this.u200e‮⁯​⁬⁫‍⁭⁯⁪‪⁫‭⁯‬⁭‫‭⁭⁫‮⁮‏⁫‮‫‭‍‫​⁭‏⁮⁯‎‭⁯‫⁯⁮‮, new Point(143, 99));
						num = (int)(num2 * -498784004 ^ 44134782);
						continue;
					}
					case 161:
					{
						TetraPanel.u206b⁬‪‍‭⁮⁪‌‭⁯⁪⁪‏‌‪⁯⁭‮​‭‏‌⁮⁯⁪‪‬​⁮⁯‮⁫⁮‪‪‫‍⁪⁬‎‮(this.u200c‎‎‪‎‮‎⁫‭‪⁯⁬⁪⁬‏‮‏‪‫‏⁯⁪​⁬‫⁯⁪‎‪‏‫‮⁯‏‪‭‬‏‪‮, 74);
						num = (int)(num2 * 951715047 ^ -1804331290);
						continue;
					}
					case 162:
					{
						TetraPanel.u202b‎⁯‫‮⁬‏‪⁫‍⁫‭​⁭‎​‎‮⁬‍‏‏‎⁯​⁭⁫‏‫‌‌‪‪​‬⁬⁭‫⁮‮‮(this.u206e‬​⁯⁫‍‎​‮⁬⁮‍‫‪‬‌‌‭⁯⁫‮‫‮⁭‮‫‪‫⁮‫⁪‏‏‏‫‏‭⁬⁬‍‮, new Point(96, 0));
						TetraPanel.u206e⁪‏‏​‍⁮‫⁬⁬⁯⁫⁯‏⁬⁮‫‫⁬⁬‭‫‌‌⁭‎​‭⁭‍⁬‏‏⁮‫⁮‭‮‎‪‮(this.u206e‬​⁯⁫‍‎​‮⁬⁮‍‫‪‬‌‌‭⁯⁫‮‫‮⁭‮‫‪‫⁮‫⁪‏‏‏‫‏‭⁬⁬‍‮, u003cModuleu003e.u200d​‍⁮‏‭⁮⁪‌‪‬‬‬‪⁬⁭⁫⁫‬⁪⁬⁬⁬‏⁮⁭‌‍‏‍‏‎‬⁬​‪‎​‎⁭‮<string>(1573008407));
						num = 993285795;
						continue;
					}
					case 163:
					{
						TetraPanel.u202d‏⁭⁫‮‫​‎‪⁫⁯‏⁮‫​‮‌⁮‬⁬‌⁮⁬‏⁭‏⁮‌⁮‮⁮‭‌‫‏⁪‎⁮‏‎‮(TetraPanel.u206a‬⁯⁭⁫‍⁪‫⁬⁭⁬⁮‫‏‍⁫‫‌⁪‪‌​⁭⁮‍‌‬⁯‭⁪‭⁮‏⁮‪​‍⁭⁫⁫‮(this.u200d‮⁪⁭⁭‍⁯‮‭‏‏⁭‬‫⁮⁯‬⁫‬‪⁫‎⁭‭​⁫‪⁬⁮⁫‍⁭​⁭‌⁪​⁪‭⁯‮), this.u202a‪‌⁫⁫‭⁬⁭⁫⁯⁮‪​‮⁮‮‍‌⁪⁬‭‮‬‬⁮‫‪‫‮‍‮​‏‌‍‌​​‬‪‮);
						TetraPanel.u202d‏⁭⁫‮‫​‎‪⁫⁯‏⁮‫​‮‌⁮‬⁬‌⁮⁬‏⁭‏⁮‌⁮‮⁮‭‌‫‏⁪‎⁮‏‎‮(TetraPanel.u206a‬⁯⁭⁫‍⁪‫⁬⁭⁬⁮‫‏‍⁫‫‌⁪‪‌​⁭⁮‍‌‬⁯‭⁪‭⁮‏⁮‪​‍⁭⁫⁫‮(this.u200d‮⁪⁭⁭‍⁯‮‭‏‏⁭‬‫⁮⁯‬⁫‬‪⁫‎⁭‭​⁫‪⁬⁮⁫‍⁭​⁭‌⁪​⁪‭⁯‮), this.u206f⁯⁭‫‍⁪‬‭⁮‪⁯⁭‮‌‭‪‏⁯‫‪‎‪⁯⁫⁪‌‭‪‌‫⁮‭⁪‍‏‌‪‬‏‫‮);
						num = (int)(num2 * -1806191651 ^ 2003780431);
						continue;
					}
					case 164:
					{
						TetraPanel.u202b‏⁪​⁬⁯‫⁯‍‪⁯‪⁪‭⁫‎‍‎‬‬‌‫⁯⁮⁭⁭‮‭‌‏⁯‬‫‮‏‫‫⁮‮‫‮(this.u206c‍‍‌‬‪‮‪‮⁪‎⁬‍‭⁪‫‌‬‪⁫‫‫‫‪⁮‮‬⁮⁬⁪‫⁭‫‌⁪‮‪⁭⁭⁮‮, new EventHandler(this.u200d⁫⁭‍‪‭‮‮‎⁬​⁭‌⁬⁭‬‬‫‎‫‪‎⁬‎‌‪⁭‎‍⁯⁯⁪⁯⁮⁮‍‏‬‭‫‮));
						TetraPanel.u200e‭⁭‌‪‫​⁯⁫⁫‪⁯‍⁯⁯⁭‎⁫‮⁮​​‭‎‮‍‏‎‎⁪‌⁫‬‮⁮‌⁮‏⁭⁪‮(this.u206d‫⁭‮⁯​⁫‬‍‪‍⁬⁭⁭‍‎‬‮⁪‫‫‍‎⁫​⁪‪​‮⁬‌​‬‮⁪‬‮⁫⁬⁫‮, true);
						TetraPanel.u202b‏‏‬‎‮‫​‍​⁭‬‬‭‮⁫⁯‭⁪‬‎‫‫‎⁬‪‍‎⁪⁪‮‌‮‌‏⁯‌‍​‌‮(this.u206d‫⁭‮⁯​⁫‬‍‪‍⁬⁭⁭‍‎‬‮⁪‫‫‍‎⁫​⁪‪​‮⁬‌​‬‮⁪‬‮⁫⁬⁫‮, TetraPanel.u202c‫‭‪‌‌⁬‌⁬‌‪‬‏‌‍⁯⁪‮⁪‮‌‪⁪⁯‭⁮‪‪⁪‬‭​‬‭‮‍‭‌‍‮(u003cModuleu003e.u200e‏‌‬⁮‪‭⁭‭⁭‎​‏‌‭‭‭⁭⁬⁯⁫‍‮‫⁯‌‮‏​‬⁫⁯⁮⁫‮‪⁫‬⁮⁬‮<string>(507840788), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0));
						num = 1151238030;
						continue;
					}
					case 165:
					{
						TetraPanel.u200e​⁮⁯‮⁭‬‭⁫⁭⁬‌‭‎⁬⁬⁮⁬‭‬⁮‭‏⁫‫​‮‌‬⁪​‮⁮‪‪⁭‮⁪‍⁮‮(this.u206c‫‍⁯⁫⁬⁬‎‮‎‭‎⁭⁪‍‏⁯‬​⁪‪⁯⁪​⁪‪‫‏⁮‏‍⁮⁮‫​‭⁬⁪⁮‍‮, AnchorStyles.Top | AnchorStyles.Right);
						num = (int)(num2 * 1835528488 ^ 318215302);
						continue;
					}
					case 166:
					{
						TetraPanel.u202b‪​⁯⁪⁬⁬‭‍⁪‫‪​‮‍‭‎‍⁯‫‭⁮‭​⁯​‍⁬‌‭‭⁯⁭‭‬‍‭‎‎⁭‮(this.u206e⁬‬‭⁫‏⁪⁬⁬⁪⁬‏⁬⁯‍‌⁮‮⁪⁬‍⁭⁯⁮‭‌‏⁬⁭‍‎‌⁭​‬⁯‏⁮‌‍‮, 30);
						TetraPanel.u200f‍​‍⁯‏‫‫‏‮⁬​‎⁬‍‪⁪‎‫‌‮‎‪‌‌‮⁪⁪‌‭⁭‮⁭​‎⁭⁪‬⁮‎‮(this.u206e⁬‬‭⁫‏⁪⁬⁬⁪⁬‏⁬⁯‍‌⁮‮⁪⁬‍⁭⁯⁮‭‌‏⁬⁭‍‎‌⁭​‬⁯‏⁮‌‍‮, new EventHandler(this.u202b⁪⁬⁫‏‭​⁭‏‭⁭⁫​‫⁪‌⁮⁯‭⁯⁪‏‪‎⁫‫​⁫‭⁯‎⁭⁯‏⁯⁪⁬⁭‍⁭‮));
						num = (int)(num2 * 1042668865 ^ 81220209);
						continue;
					}
					case 167:
					{
						TetraPanel.u206e⁪‏‏​‍⁮‫⁬⁬⁯⁫⁯‏⁬⁮‫‫⁬⁬‭‫‌‌⁭‎​‭⁭‍⁬‏‏⁮‫⁮‭‮‎‪‮(this.u200f⁫⁭⁬​‮‫‭‪‬‏⁯‭‎‭⁫‌⁬⁮‭‮‌‮⁫⁫‭‎‪‎‎​⁫‎⁮⁭⁯⁫‌‮‫‮, u003cModuleu003e.u202a‮‫‏‫‬‬‪⁫⁬​‏⁫⁭‍‪‪‎⁬​‪​‌⁮‮‌​⁫​⁬‪‫⁪⁯⁪‎‫⁭‎⁪‮<string>(-764398208));
						TetraPanel.u202c⁭⁫‪‏⁬⁭⁭​​⁪⁫‬‍⁪⁫⁭⁬‮‌⁭‫‮‭​⁫‌⁪‎‏⁪‫‮‌​‌‍⁮⁮⁮‮(this.u200f⁫⁭⁬​‮‫‭‪‬‏⁯‭‎‭⁫‌⁬⁮‭‮‌‮⁫⁫‭‎‪‎‎​⁫‎⁮⁭⁯⁫‌‮‫‮, new System.Drawing.Size(37, 13));
						TetraPanel.u206b⁬‪‍‭⁮⁪‌‭⁯⁪⁪‏‌‪⁯⁭‮​‭‏‌⁮⁯⁪‪‬​⁮⁯‮⁫⁮‪‪‫‍⁪⁬‎‮(this.u200f⁫⁭⁬​‮‫‭‪‬‏⁯‭‎‭⁫‌⁬⁮‭‮‌‮⁫⁫‭‎‪‎‎​⁫‎⁮⁭⁯⁫‌‮‫‮, 85);
						TetraPanel.u206d‫‫‫⁮‮‌​‍⁫‭‎‬​⁭‬⁫‪‌‍‍‎‮⁫‬⁭⁫‫‎⁯‏‌‮‮⁬‮⁬⁪‮(this.u200f⁫⁭⁬​‮‫‭‪‬‏⁯‭‎‭⁫‌⁬⁮‭‮‌‮⁫⁫‭‎‪‎‎​⁫‎⁮⁭⁯⁫‌‮‫‮, u003cModuleu003e.u200e‏‌‬⁮‪‭⁭‭⁭‎​‏‌‭‭‭⁭⁬⁯⁫‍‮‫⁯‌‮‏​‬⁫⁯⁮⁫‮‪⁫‬⁮⁬‮<string>(801214585));
						num = 1424185560;
						continue;
					}
					case 168:
					{
						TetraPanel.u202d‏⁭⁫‮‫​‎‪⁫⁯‏⁮‫​‮‌⁮‬⁬‌⁮⁬‏⁭‏⁮‌⁮‮⁮‭‌‫‏⁪‎⁮‏‎‮(TetraPanel.u206a‬⁯⁭⁫‍⁪‫⁬⁭⁬⁮‫‏‍⁫‫‌⁪‪‌​⁭⁮‍‌‬⁯‭⁪‭⁮‏⁮‪​‍⁭⁫⁫‮(this.u206a⁭‫⁬⁯‌‎⁯‬‍​‏‎‌‏⁯‏⁮‬⁯⁮‎⁯⁬‌‪⁯⁬⁭⁬​‭​‌​‎⁫⁪‭‍‮), this.u206a‮​‫‪‪⁬‫‏⁬⁯‫‏⁬‌​⁪‮​‌⁬‏‍‎‍‌⁬⁮⁫‍⁪⁭‎‭‌⁭⁫⁬‏⁮‮);
						num = (int)(num2 * -1224560662 ^ -2081592290);
						continue;
					}
					case 169:
					{
						this.u206d‏‪‫‍⁪‪⁬‌⁪‌‪‭⁫‫‎‍⁯‎‬‭⁪⁯​⁪⁮‬​‌​‎‌⁪‭⁮‏‌‫‫⁯‮ = TetraPanel.u206e⁮⁬⁫‏⁯‪​⁬‭​⁫‭‬⁯⁬‫⁪​⁮⁪⁪‏⁬⁯‍‫⁮⁭‌⁭⁮‪⁭⁯‬‬‍‭‪‮();
						num = (int)(num2 * 2105804928 ^ -1763654211);
						continue;
					}
					case 170:
					{
						TetraPanel.u206d‫‫‫⁮‮‌​‍⁫‭‎‬​⁭‬⁫‪‌‍‍‎‮⁫‬⁭⁫‫‎⁯‏‌‮‮⁬‮⁬⁪‮(this.u202b⁪⁭‍‎⁭‮⁮‭⁮⁪‬⁯⁭‎‌⁫‮‮⁪‍⁯‎‍‫⁫‪‪‎‪‬‍‎‮‍⁭‍⁭‎⁬‮, u003cModuleu003e.u200e‏‌‬⁮‪‭⁭‭⁭‎​‏‌‭‭‭⁭⁬⁯⁫‍‮‫⁯‌‮‏​‬⁫⁯⁮⁫‮‪⁫‬⁮⁬‮<string>(-1440801905));
						TetraPanel.u202b‏‏‬‎‮‫​‍​⁭‬‬‭‮⁫⁯‭⁪‬‎‫‫‎⁬‪‍‎⁪⁪‮‌‮‌‏⁯‌‍​‌‮(this.u206a⁯‏⁯​‫‬⁬‌⁮​⁯‬‌‭⁯‪⁬⁯⁮‌‫⁫⁫‍‎‎⁫⁮‫‍‍‪​‮‍‮‭⁬‏‮, TetraPanel.u202c‫‭‪‌‌⁬‌⁬‌‪‬‏‌‍⁯⁪‮⁪‮‌‪⁪⁯‭⁮‪‪⁪‬‭​‬‭‮‍‭‌‍‮(u003cModuleu003e.u206f⁮​‌‪‮‎‭‏‮‎⁮⁮‮⁬⁫‍‍⁪‍⁫⁮‏​‎⁬⁯⁪‪‍⁪⁮‎⁬⁪⁫​⁮⁪⁮‮<string>(125941577), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0));
						TetraPanel.u202b‎⁯‫‮⁬‏‪⁫‍⁫‭​⁭‎​‎‮⁬‍‏‏‎⁯​⁭⁫‏‫‌‌‪‪​‬⁬⁭‫⁮‮‮(this.u206a⁯‏⁯​‫‬⁬‌⁮​⁯‬‌‭⁯‪⁬⁯⁮‌‫⁫⁫‍‎‎⁫⁮‫‍‍‪​‮‍‮‭⁬‏‮, new Point(148, 446));
						num = 1108646044;
						continue;
					}
					case 171:
					{
						TetraPanel.u202c⁭⁫‪‏⁬⁭⁭​​⁪⁫‬‍⁪⁫⁭⁬‮‌⁭‫‮‭​⁫‌⁪‎‏⁪‫‮‌​‌‍⁮⁮⁮‮(this.u200b‏⁭⁯⁮⁬‭‮⁭⁯‮​‏‭⁬⁮‫⁬⁬‬‮‏‏‎‮⁫⁬⁭⁮​​⁮⁪⁭⁭​‫‫‮, new System.Drawing.Size(73, 17));
						num = (int)(num2 * 1068736319 ^ -407428087);
						continue;
					}
					case 172:
					{
						this.u202b‫‌‍⁭‎‮⁮‍‮‎‏⁮‭‌⁭⁫‮⁮‭‎‏⁮⁮‌‌‫‬‪⁬⁬‏‌‭‌‫‌‭‭⁭‮ = TetraPanel.u202a⁪⁭⁬​‍⁮⁪‮⁬‍‌⁮‍⁯‮⁫‪⁪‏⁪‍⁮‮⁬​‏‮⁪⁬⁯‌‏​‭⁭‫‭⁬‮‮();
						num = (int)(num2 * -642721369 ^ -1198619292);
						continue;
					}
					case 173:
					{
						TetraPanel.u202d‏⁭⁫‮‫​‎‪⁫⁯‏⁮‫​‮‌⁮‬⁬‌⁮⁬‏⁭‏⁮‌⁮‮⁮‭‌‫‏⁪‎⁮‏‎‮(TetraPanel.u206a‬⁯⁭⁫‍⁪‫⁬⁭⁬⁮‫‏‍⁫‫‌⁪‪‌​⁭⁮‍‌‬⁯‭⁪‭⁮‏⁮‪​‍⁭⁫⁫‮(this.u200d‮⁪⁭⁭‍⁯‮‭‏‏⁭‬‫⁮⁯‬⁫‬‪⁫‎⁭‭​⁫‪⁬⁮⁫‍⁭​⁭‌⁪​⁪‭⁯‮), this.u206d‏‪‫‍⁪‪⁬‌⁪‌‪‭⁫‫‎‍⁯‎‬‭⁪⁯​⁪⁮‬​‌​‎‌⁪‭⁮‏‌‫‫⁯‮);
						num = (int)(num2 * -398471329 ^ 440953224);
						continue;
					}
					case 174:
					{
						TetraPanel.u202b‏‏‬‎‮‫​‍​⁭‬‬‭‮⁫⁯‭⁪‬‎‫‫‎⁬‪‍‎⁪⁪‮‌‮‌‏⁯‌‍​‌‮(this.u200f‍‮‏‌‏‌‍‍⁪⁫⁯⁭‫⁮⁫‫⁯‏‫⁪‍‫⁮‮⁪⁫‍‭‍⁫‏‍⁫‍‌⁪⁫⁪⁭‮, TetraPanel.u202c‫‭‪‌‌⁬‌⁬‌‪‬‏‌‍⁯⁪‮⁪‮‌‪⁪⁯‭⁮‪‪⁪‬‭​‬‭‮‍‭‌‍‮(u003cModuleu003e.u206f⁮​‌‪‮‎‭‏‮‎⁮⁮‮⁬⁫‍‍⁪‍⁫⁮‏​‎⁬⁯⁪‪‍⁪⁮‎⁬⁪⁫​⁮⁪⁮‮<string>(125941577), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0));
						TetraPanel.u202b‎⁯‫‮⁬‏‪⁫‍⁫‭​⁭‎​‎‮⁬‍‏‏‎⁯​⁭⁫‏‫‌‌‪‪​‬⁬⁭‫⁮‮‮(this.u200f‍‮‏‌‏‌‍‍⁪⁫⁯⁭‫⁮⁫‫⁯‏‫⁪‍‫⁮‮⁪⁫‍‭‍⁫‏‍⁫‍‌⁪⁫⁪⁭‮, new Point(75, 447));
						num = 519513424;
						continue;
					}
					case 175:
					{
						TetraPanel.u202c⁭⁫‪‏⁬⁭⁭​​⁪⁫‬‍⁪⁫⁭⁬‮‌⁭‫‮‭​⁫‌⁪‎‏⁪‫‮‌​‌‍⁮⁮⁮‮(this.u202a‪⁮​‏‫‮‫⁭⁯⁭‬⁯‎‭​‎⁬‭⁬‬‬‬‌⁪‍⁪​‎‍⁯​‍⁯⁫‎‍⁪‎‭‮, new System.Drawing.Size(48, 20));
						TetraPanel.u206b⁬‪‍‭⁮⁪‌‭⁯⁪⁪‏‌‪⁯⁭‮​‭‏‌⁮⁯⁪‪‬​⁮⁯‮⁫⁮‪‪‫‍⁪⁬‎‮(this.u202a‪⁮​‏‫‮‫⁭⁯⁭‬⁯‎‭​‎⁬‭⁬‬‬‬‌⁪‍⁪​‎‍⁯​‍⁯⁫‎‍⁪‎‭‮, 77);
						num = (int)(num2 * 1731578864 ^ 566734507);
						continue;
					}
					case 176:
					{
						TetraPanel.u202d‏⁭⁫‮‫​‎‪⁫⁯‏⁮‫​‮‌⁮‬⁬‌⁮⁬‏⁭‏⁮‌⁮‮⁮‭‌‫‏⁪‎⁮‏‎‮(TetraPanel.u206a‬⁯⁭⁫‍⁪‫⁬⁭⁬⁮‫‏‍⁫‫‌⁪‪‌​⁭⁮‍‌‬⁯‭⁪‭⁮‏⁮‪​‍⁭⁫⁫‮(this.u200d‮⁪⁭⁭‍⁯‮‭‏‏⁭‬‫⁮⁯‬⁫‬‪⁫‎⁭‭​⁫‪⁬⁮⁫‍⁭​⁭‌⁪​⁪‭⁯‮), this.u202e⁬⁬​‫⁪‍‍‏‌‏‬‌⁫‮⁫⁮‏⁬‭‭⁬‏⁫⁪‬‎⁪⁪‪‪‏‫⁮‭‪⁭‬‎‪‮);
						num = (int)(num2 * -120260103 ^ 1430508497);
						continue;
					}
					case 177:
					{
						TetraPanel.u200e‭⁭‌‪‫​⁯⁫⁫‪⁯‍⁯⁯⁭‎⁫‮⁮​​‭‎‮‍‏‎‎⁪‌⁫‬‮⁮‌⁮‏⁭⁪‮(this.u206f⁯⁭‫‍⁪‬‭⁮‪⁯⁭‮‌‭‪‏⁯‫‪‎‪⁯⁫⁪‌‭‪‌‫⁮‭⁪‍‏‌‪‬‏‫‮, true);
						num = (int)(num2 * -431381145 ^ -1979417257);
						continue;
					}
					case 178:
					{
						this.u200d‌‎‪⁯⁯⁫‭‬‬‭‎​‍‮⁯‮‌‬‪‭​⁮⁭⁬‏‏‫⁪‏⁭⁬‏⁮⁮‬⁯‏‭‍‮ = TetraPanel.u200b‬‌⁯‫‪⁪⁯​‭‬‌‭⁯⁮⁮‏​‪‬⁯‭‪​⁫‮​‪‬‬​‌‏⁬⁪‪‏⁪‏⁬‮();
						this.u200e‎⁭‏‎‪‎‍‬⁭⁮⁬‍⁭‮​⁪‮‏‍⁪‎‫⁮‫⁭⁯⁪‌‌​‌⁬‫‏‬‍⁯⁮‭‮ = TetraPanel.u202b⁬‮‍‪‏⁬‌‭‏⁭⁮‪‌⁬⁯⁯⁮‪⁭‌‬⁪‎‮‪‭‭‪​‭‭⁭⁪⁭‪⁬⁯​‬‮();
						num = (int)(num2 * -1052294652 ^ -1667081725);
						continue;
					}
					case 179:
					{
						TetraPanel.u202b‏‏‬‎‮‫​‍​⁭‬‬‭‮⁫⁯‭⁪‬‎‫‫‎⁬‪‍‎⁪⁪‮‌‮‌‏⁯‌‍​‌‮(this.u202c⁭‎‫‮‌⁯⁮‍‎⁪⁪⁬‭⁮‏‎‌‌‎‌⁯‪‮⁯‌⁮‌‭⁯‎‍‌⁪‍‭‏⁪‬‮, TetraPanel.u202c‫‭‪‌‌⁬‌⁬‌‪‬‏‌‍⁯⁪‮⁪‮‌‪⁪⁯‭⁮‪‪⁪‬‭​‬‭‮‍‭‌‍‮(u003cModuleu003e.u202a‮‫‏‫‬‬‪⁫⁬​‏⁫⁭‍‪‪‎⁬​‪​‌⁮‮‌​⁫​⁬‪‫⁪⁯⁪‎‫⁭‎⁪‮<string>(1627927687), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0));
						num = 2127012939;
						continue;
					}
					case 180:
					{
						this.u206c‫‍⁯⁫⁬⁬‎‮‎‭‎⁭⁪‍‏⁯‬​⁪‪⁯⁪​⁪‪‫‏⁮‏‍⁮⁮‫​‭⁬⁪⁮‍‮ = TetraPanel.u200b‬‌⁯‫‪⁪⁯​‭‬‌‭⁯⁮⁮‏​‪‬⁯‭‪​⁫‮​‪‬‬​‌‏⁬⁪‪‏⁪‏⁬‮();
						num = (int)(num2 * 1539856306 ^ -879370706);
						continue;
					}
					case 181:
					{
						TetraPanel.u206e⁪‏‏​‍⁮‫⁬⁬⁯⁫⁯‏⁬⁮‫‫⁬⁬‭‫‌‌⁭‎​‭⁭‍⁬‏‏⁮‫⁮‭‮‎‪‮(this.u206a‮​‫‪‪⁬‫‏⁬⁯‫‏⁬‌​⁪‮​‌⁬‏‍‎‍‌⁬⁮⁫‍⁪⁭‎‭‌⁭⁫⁬‏⁮‮, u003cModuleu003e.u200f⁫‌​⁬‌‎‎‏‍‍⁫‎​‌‬⁯‬‫‭‎‏​‌​⁪‭‬⁬‮⁬​‌⁬⁪‫‫‎⁪⁮‮<string>(-739506680));
						TetraPanel.u202c⁭⁫‪‏⁬⁭⁭​​⁪⁫‬‍⁪⁫⁭⁬‮‌⁭‫‮‭​⁫‌⁪‎‏⁪‫‮‌​‌‍⁮⁮⁮‮(this.u206a‮​‫‪‪⁬‫‏⁬⁯‫‏⁬‌​⁪‮​‌⁬‏‍‎‍‌⁬⁮⁫‍⁪⁭‎‭‌⁭⁫⁬‏⁮‮, new System.Drawing.Size(33, 13));
						num = 1438640924;
						continue;
					}
					case 182:
					{
						TetraPanel.u200e‭⁭‌‪‫​⁯⁫⁫‪⁯‍⁯⁯⁭‎⁫‮⁮​​‭‎‮‍‏‎‎⁪‌⁫‬‮⁮‌⁮‏⁭⁪‮(this.u200f‏⁪‪⁪‪⁯‪‌⁬‎‪‬‫⁯‭‬‌⁯‏⁮⁫‪⁯‬⁪⁭⁭‪‪‌‍‭‎⁭⁫⁯⁯​‏‮, true);
						num = (int)(num2 * 801157387 ^ 1782661235);
						continue;
					}
					case 183:
					{
						TetraPanel.u206e⁪‏‏​‍⁮‫⁬⁬⁯⁫⁯‏⁬⁮‫‫⁬⁬‭‫‌‌⁭‎​‭⁭‍⁬‏‏⁮‫⁮‭‮‎‪‮(this.u200e‎⁭‏‎‪‎‍‬⁭⁮⁬‍⁭‮​⁪‮‏‍⁪‎‫⁮‫⁭⁯⁪‌‌​‌⁬‫‏‬‍⁯⁮‭‮, u003cModuleu003e.u206f⁮​‌‪‮‎‭‏‮‎⁮⁮‮⁬⁫‍‍⁪‍⁫⁮‏​‎⁬⁯⁪‪‍⁪⁮‎⁬⁪⁫​⁮⁪⁮‮<string>(-1663135686));
						TetraPanel.u202c⁭⁫‪‏⁬⁭⁭​​⁪⁫‬‍⁪⁫⁭⁬‮‌⁭‫‮‭​⁫‌⁪‎‏⁪‫‮‌​‌‍⁮⁮⁮‮(this.u200e‎⁭‏‎‪‎‍‬⁭⁮⁬‍⁭‮​⁪‮‏‍⁪‎‫⁮‫⁭⁯⁪‌‌​‌⁬‫‏‬‍⁯⁮‭‮, new System.Drawing.Size(45, 17));
						num = 1523160496;
						continue;
					}
					case 184:
					{
						this.u202e⁪‍‍⁫⁪‪‍‌‏⁪⁪⁫⁪‎‮‭‌⁭‬‪⁮​‭⁯⁯‌‮⁪⁬‮⁬⁬​‮‏⁯⁯‌‏‮ = TetraPanel.u202a⁭‌⁭‏‪⁭‎⁬‌⁪‫‏​‎⁯‍‭⁭‮‏‎⁪‏⁭‎⁪⁪⁫‫‭⁫‍‌‬⁫‭​‌‍‮(this.u200c⁫⁯⁬‪‌‬‭‫‭​‪​⁯‮⁪‫⁫⁯⁪‏‌⁬⁮‬‌‬⁭‭⁮⁯‮‬⁮‏‫⁯​‭‏‮);
						this.u206e⁬‬‭⁫‏⁪⁬⁬⁪⁬‏⁬⁯‍‌⁮‮⁪⁬‍⁭⁯⁮‭‌‏⁬⁭‍‎‌⁭​‬⁯‏⁮‌‍‮ = TetraPanel.u202a⁭‌⁭‏‪⁭‎⁬‌⁪‫‏​‎⁯‍‭⁭‮‏‎⁪‏⁭‎⁪⁪⁫‫‭⁫‍‌‬⁫‭​‌‍‮(this.u200c⁫⁯⁬‪‌‬‭‫‭​‪​⁯‮⁪‫⁫⁯⁪‏‌⁬⁮‬‌‬⁭‭⁮⁯‮‬⁮‏‫⁯​‭‏‮);
						this.u200d‎‫‎‪​‍‏‍⁯‫⁬⁮‌‫⁭‏​​‏⁫‬⁬‎‭‍⁫‌⁬‬⁬‬⁬‏‎⁮​‬⁫⁪‮ = TetraPanel.u202a⁭‌⁭‏‪⁭‎⁬‌⁪‫‏​‎⁯‍‭⁭‮‏‎⁪‏⁭‎⁪⁪⁫‫‭⁫‍‌‬⁫‭​‌‍‮(this.u200c⁫⁯⁬‪‌‬‭‫‭​‪​⁯‮⁪‫⁫⁯⁪‏‌⁬⁮‬‌‬⁭‭⁮⁯‮‬⁮‏‫⁯​‭‏‮);
						this.u206e​‏‫⁮‏⁯​‬‭⁯‮‪⁭‭⁮​‭⁯⁯‮‎‏​‌‮​⁫‬‍‎‏‭⁯‎‏‬⁫⁭‏‮ = TetraPanel.u202a⁭‌⁭‏‪⁭‎⁬‌⁪‫‏​‎⁯‍‭⁭‮‏‎⁪‏⁭‎⁪⁪⁫‫‭⁫‍‌‬⁫‭​‌‍‮(this.u200c⁫⁯⁬‪‌‬‭‫‭​‪​⁯‮⁪‫⁫⁯⁪‏‌⁬⁮‬‌‬⁭‭⁮⁯‮‬⁮‏‫⁯​‭‏‮);
						num = (int)(num2 * 1768356595 ^ -1634026132);
						continue;
					}
					case 185:
					{
						TetraPanel.u202c⁭⁫‪‏⁬⁭⁭​​⁪⁫‬‍⁪⁫⁭⁬‮‌⁭‫‮‭​⁫‌⁪‎‏⁪‫‮‌​‌‍⁮⁮⁮‮(this.u202e⁮‍‍⁮‎⁪⁫⁫‍‮‭‬‍⁪‪‮⁭‬⁫⁯‪⁯​⁪‬‫​⁬‭‭⁯‫‎⁮‏​​‬‎‮, new System.Drawing.Size(73, 17));
						num = (int)(num2 * 672839972 ^ 864016189);
						continue;
					}
					case 186:
					{
						TetraPanel.u206e⁪‏‏​‍⁮‫⁬⁬⁯⁫⁯‏⁬⁮‫‫⁬⁬‭‫‌‌⁭‎​‭⁭‍⁬‏‏⁮‫⁮‭‮‎‪‮(this.u202a⁫⁫⁪‎⁯⁭‬‬⁬​‮‍⁭‮‌⁭‌‏‎‭‫‌‏‏⁫⁬‮⁬‌⁭​⁫⁯‫⁮⁭‬‏‏‮, u003cModuleu003e.u200d​‍⁮‏‭⁮⁪‌‪‬‬‬‪⁬⁭⁫⁫‬⁪⁬⁬⁬‏⁮⁭‌‍‏‍‏‎‬⁬​‪‎​‎⁭‮<string>(-996024831));
						num = 1269088796;
						continue;
					}
					case 187:
					{
						TetraPanel.u206b⁬‪‍‭⁮⁪‌‭⁯⁪⁪‏‌‪⁯⁭‮​‭‏‌⁮⁯⁪‪‬​⁮⁯‮⁫⁮‪‪‫‍⁪⁬‎‮(this.u206c‫‍⁯⁫⁬⁬‎‮‎‭‎⁭⁪‍‏⁯‬​⁪‪⁯⁪​⁪‪‫‏⁮‏‍⁮⁮‫​‭⁬⁪⁮‍‮, 45);
						num = (int)(num2 * -856824191 ^ 1302253135);
						continue;
					}
					case 188:
					{
						TetraPanel.u202b‎⁯‫‮⁬‏‪⁫‍⁫‭​⁭‎​‎‮⁬‍‏‏‎⁯​⁭⁫‏‫‌‌‪‪​‬⁬⁭‫⁮‮‮(this.u202e‪⁬⁫⁬⁭‪‏‌‏‫‫⁬⁭‌‭‮⁭⁭‬‪⁭⁭‬‌‮⁮⁭⁫‌‬⁯⁫‪‭‎‭‎‍⁫‮, new Point(138, 17));
						TetraPanel.u206e⁪‏‏​‍⁮‫⁬⁬⁯⁫⁯‏⁬⁮‫‫⁬⁬‭‫‌‌⁭‎​‭⁭‍⁬‏‏⁮‫⁮‭‮‎‪‮(this.u202e‪⁬⁫⁬⁭‪‏‌‏‫‫⁬⁭‌‭‮⁭⁭‬‪⁭⁭‬‌‮⁮⁭⁫‌‬⁯⁫‪‭‎‭‎‍⁫‮, u003cModuleu003e.u200e‏‌‬⁮‪‭⁭‭⁭‎​‏‌‭‭‭⁭⁬⁯⁫‍‮‫⁯‌‮‏​‬⁫⁯⁮⁫‮‪⁫‬⁮⁬‮<string>(800353452));
						num = 1154873337;
						continue;
					}
					case 189:
					{
						TetraPanel.u206b⁬‪‍‭⁮⁪‌‭⁯⁪⁪‏‌‪⁯⁭‮​‭‏‌⁮⁯⁪‪‬​⁮⁯‮⁫⁮‪‪‫‍⁪⁬‎‮(this.u202a‎‎‭⁭⁬‎⁬‏⁫⁬⁯‫‎‬‪‏⁬‪‬‭‌‪‌‎⁯‪‪‫​‪​⁮‫‭‌⁮​⁪⁬‮, 68);
						num = (int)(num2 * 1275063379 ^ -1806289938);
						continue;
					}
					case 190:
					{
						TetraPanel.u200e‭⁭‌‪‫​⁯⁫⁫‪⁯‍⁯⁯⁭‎⁫‮⁮​​‭‎‮‍‏‎‎⁪‌⁫‬‮⁮‌⁮‏⁭⁪‮(this.u200d⁪‮‬⁭​​⁫⁪⁯⁫‬‏⁮⁭​‭‬‏‏⁭⁯‫‌‮‎⁫⁫‏‮⁮⁬⁫‮⁮⁪⁯‭‎‫‮, true);
						num = (int)(num2 * -1837617532 ^ 890518762);
						continue;
					}
					case 191:
					{
						TetraPanel.u202b‏‏‬‎‮‫​‍​⁭‬‬‭‮⁫⁯‭⁪‬‎‫‫‎⁬‪‍‎⁪⁪‮‌‮‌‏⁯‌‍​‌‮(this.u200e​⁭⁯​‏‏‎‭⁮‍‮⁬‪‮‪⁮‫⁭‏‍⁬‍‎‏‪‫‪‮⁪‍⁫‮‍⁪‬‏‭‮‏‮, TetraPanel.u202c‫‭‪‌‌⁬‌⁬‌‪‬‏‌‍⁯⁪‮⁪‮‌‪⁪⁯‭⁮‪‪⁪‬‭​‬‭‮‍‭‌‍‮(u003cModuleu003e.u200d​‍⁮‏‭⁮⁪‌‪‬‬‬‪⁬⁭⁫⁫‬⁪⁬⁬⁬‏⁮⁭‌‍‏‍‏‎‬⁬​‪‎​‎⁭‮<string>(2136952738), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0));
						TetraPanel.u202b‎⁯‫‮⁬‏‪⁫‍⁫‭​⁭‎​‎‮⁬‍‏‏‎⁯​⁭⁫‏‫‌‌‪‪​‬⁬⁭‫⁮‮‮(this.u200e​⁭⁯​‏‏‎‭⁮‍‮⁬‪‮‪⁮‫⁭‏‍⁬‍‎‏‪‫‪‮⁪‍⁫‮‍⁪‬‏‭‮‏‮, new Point(138, 54));
						num = 2021050420;
						continue;
					}
					case 192:
					{
						TetraPanel.u202b‏‏‬‎‮‫​‍​⁭‬‬‭‮⁫⁯‭⁪‬‎‫‫‎⁬‪‍‎⁪⁪‮‌‮‌‏⁯‌‍​‌‮(this.u200d‌‎‪⁯⁯⁫‭‬‬‭‎​‍‮⁯‮‌‬‪‭​⁮⁭⁬‏‏‫⁪‏⁭⁬‏⁮⁮‬⁯‏‭‍‮, TetraPanel.u202c‫‭‪‌‌⁬‌⁬‌‪‬‏‌‍⁯⁪‮⁪‮‌‪⁪⁯‭⁮‪‪⁪‬‭​‬‭‮‍‭‌‍‮(u003cModuleu003e.u206f⁮​‌‪‮‎‭‏‮‎⁮⁮‮⁬⁫‍‍⁪‍⁫⁮‏​‎⁬⁯⁪‪‍⁪⁮‎⁬⁪⁫​⁮⁪⁮‮<string>(125941577), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0));
						num = 648026502;
						continue;
					}
					case 193:
					{
						TetraPanel.u200f⁪⁪⁫⁭‏‮‌‬⁭‍​‭‫⁭⁮‫‍‏⁫⁭⁯​⁪‌‮‍⁭​⁫⁮⁫‫‌‭⁬⁫‬​‪‮(this.u206e‬​⁯⁫‍‎​‮⁬⁮‍‫‪‬‌‌‭⁯⁫‮‫‮⁭‮‫‪‫⁮‫⁪‏‏‏‫‏‭⁬⁬‍‮, new EventHandler(this.u206d‏​⁮‎‍‬⁭⁫​⁬​‪⁮‎⁭‫​⁪‫‫‫‍‬​⁬‬‍‭⁮⁫⁮⁭⁯‏‏⁫⁭​⁭‮));
						num = (int)(num2 * 299351086 ^ 2061978760);
						continue;
					}
					case 194:
					{
						TetraPanel.u202e⁯‭⁪‪⁬‮‬‍‭⁪⁭⁯⁯‌⁫⁫‭‎⁯‭⁭⁪‌‮‪‏⁮‮⁭‫‎⁭‬‏‏‫‌⁪‌‮(this.u202a‪⁮​‏‫‮‫⁭⁯⁭‬⁯‎‭​‎⁬‭⁬‬‬‬‌⁪‍⁪​‎‍⁯​‍⁯⁫‎‍⁪‎‭‮, new decimal(new int[] { 40, 0, 0, -2147483648 }));
						TetraPanel.u200e‭⁭‌‪‫​⁯⁫⁫‪⁯‍⁯⁯⁭‎⁫‮⁮​​‭‎‮‍‏‎‎⁪‌⁫‬‮⁮‌⁮‏⁭⁪‮(this.u202e⁭​⁬‎​⁬⁮​⁬‬‫‎⁫‬‌​⁬⁪⁮​⁫⁬⁫⁪‎‍⁭⁭‬‬‪‎‍‬⁪‍‍​‍‮, true);
						num = (int)(num2 * -497192869 ^ 862255323);
						continue;
					}
					case 195:
					{
						TetraPanel.u200e‭⁭‌‪‫​⁯⁫⁫‪⁯‍⁯⁯⁭‎⁫‮⁮​​‭‎‮‍‏‎‎⁪‌⁫‬‮⁮‌⁮‏⁭⁪‮(this.u200e​⁭⁯​‏‏‎‭⁮‍‮⁬‪‮‪⁮‫⁭‏‍⁬‍‎‏‪‫‪‮⁪‍⁫‮‍⁪‬‏‭‮‏‮, true);
						num = (int)(num2 * -1709145796 ^ -2062953363);
						continue;
					}
					case 196:
					{
						TetraPanel.u206b⁬‪‍‭⁮⁪‌‭⁯⁪⁪‏‌‪⁯⁭‮​‭‏‌⁮⁯⁪‪‬​⁮⁯‮⁫⁮‪‪‫‍⁪⁬‎‮(this.u200d‌‎‪⁯⁯⁫‭‬‬‭‎​‍‮⁯‮‌‬‪‭​⁮⁭⁬‏‏‫⁪‏⁭⁬‏⁮⁮‬⁯‏‭‍‮, 61);
						num = (int)(num2 * -543446346 ^ 1049352817);
						continue;
					}
					case 197:
					{
						TetraPanel.u206b⁬‪‍‭⁮⁪‌‭⁯⁪⁪‏‌‪⁯⁭‮​‭‏‌⁮⁯⁪‪‬​⁮⁯‮⁫⁮‪‪‫‍⁪⁬‎‮(this.u206f⁯⁭‫‍⁪‬‭⁮‪⁯⁭‮‌‭‪‏⁯‫‪‎‪⁯⁫⁪‌‭‪‌‫⁮‭⁪‍‏‌‪‬‏‫‮, 69);
						TetraPanel.u206d‫‫‫⁮‮‌​‍⁫‭‎‬​⁭‬⁫‪‌‍‍‎‮⁫‬⁭⁫‫‎⁯‏‌‮‮⁬‮⁬⁪‮(this.u206f⁯⁭‫‍⁪‬‭⁮‪⁯⁭‮‌‭‪‏⁯‫‪‎‪⁯⁫⁪‌‭‪‌‫⁮‭⁪‍‏‌‪‬‏‫‮, u003cModuleu003e.u200f⁫‌​⁬‌‎‎‏‍‍⁫‎​‌‬⁯‬‫‭‎‏​‌​⁪‭‬⁬‮⁬​‌⁬⁪‫‫‎⁪⁮‮<string>(1939131891));
						num = 331722306;
						continue;
					}
					case 198:
					{
						TetraPanel.u200e‭⁭‌‪‫​⁯⁫⁫‪⁯‍⁯⁯⁭‎⁫‮⁮​​‭‎‮‍‏‎‎⁪‌⁫‬‮⁮‌⁮‏⁭⁪‮(this.u202a‎‎‭⁭⁬‎⁬‏⁫⁬⁯‫‎‬‪‏⁬‪‬‭‌‪‌‎⁯‪‪‫​‪​⁮‫‭‌⁮​⁪⁬‮, true);
						num = (int)(num2 * 849999346 ^ 507287964);
						continue;
					}
					case 199:
					{
						TetraPanel.u202d‏⁭⁫‮‫​‎‪⁫⁯‏⁮‫​‮‌⁮‬⁬‌⁮⁬‏⁭‏⁮‌⁮‮⁮‭‌‫‏⁪‎⁮‏‎‮(TetraPanel.u206a‬⁯⁭⁫‍⁪‫⁬⁭⁬⁮‫‏‍⁫‫‌⁪‪‌​⁭⁮‍‌‬⁯‭⁪‭⁮‏⁮‪​‍⁭⁫⁫‮(this.u206a⁭‫⁬⁯‌‎⁯‬‍​‏‎‌‏⁯‏⁮‬⁯⁮‎⁯⁬‌‪⁯⁬⁭⁬​‭​‌​‎⁫⁪‭‍‮), this.u206d‫⁭‮⁯​⁫‬‍‪‍⁬⁭⁭‍‎‬‮⁪‫‫‍‎⁫​⁪‪​‮⁬‌​‬‮⁪‬‮⁫⁬⁫‮);
						TetraPanel.u202d‏⁭⁫‮‫​‎‪⁫⁯‏⁮‫​‮‌⁮‬⁬‌⁮⁬‏⁭‏⁮‌⁮‮⁮‭‌‫‏⁪‎⁮‏‎‮(TetraPanel.u206a‬⁯⁭⁫‍⁪‫⁬⁭⁬⁮‫‏‍⁫‫‌⁪‪‌​⁭⁮‍‌‬⁯‭⁪‭⁮‏⁮‪​‍⁭⁫⁫‮(this.u206a⁭‫⁬⁯‌‎⁯‬‍​‏‎‌‏⁯‏⁮‬⁯⁮‎⁯⁬‌‪⁯⁬⁭⁬​‭​‌​‎⁫⁪‭‍‮), this.u202b‫‭‪⁯⁯⁮‎⁫⁫⁮‫⁪⁯⁮⁭⁫‎‏⁮⁭‭⁪‌⁯⁪⁪‍⁯⁯‌⁫‪‮⁭‌⁪‎‬⁫‮);
						num = (int)(num2 * -1794235154 ^ 1081355906);
						continue;
					}
					case 200:
					{
						TetraPanel.u202b‎⁯‫‮⁬‏‪⁫‍⁫‭​⁭‎​‎‮⁬‍‏‏‎⁯​⁭⁫‏‫‌‌‪‪​‬⁬⁭‫⁮‮‮(this.u200c‎‎‪‎‮‎⁫‭‪⁯⁬⁪⁬‏‮‏‪‫‏⁯⁪​⁬‫⁯⁪‎‪‏‫‮⁯‏‪‭‬‏‪‮, new Point(1, 19));
						num = (int)(num2 * 311898105 ^ 1353026588);
						continue;
					}
					case 201:
					{
						TetraPanel.u202b‬⁫‌‪⁯⁭‪⁮‏‪⁭⁪‌‪⁬⁪‭⁬‮‬‭⁫‫⁯‭‫‫‎‎‮‎‏⁮⁯‪‌‭⁫‌‮(this.u206a‎‪⁮​‮⁭‭⁪‎⁪‏‌‎‌‎⁮⁫‬‭‍⁭⁭‫‏⁫​‬‪⁪‮⁮‏‏⁭⁬‌⁪⁯‭‮, false);
						num = (int)(num2 * -574040341 ^ -208215002);
						continue;
					}
					case 202:
					{
						TetraPanel.u202e‎‫‪⁮‏‪‎​⁬‮‎⁪⁪⁫‭⁯‌‏‬​‏⁫⁭‬⁫‎‬⁯‎⁪‏⁮​‍⁯⁫⁮⁯‫‮(this.u206a⁭‫⁬⁯‌‎⁯‬‍​‏‎‌‏⁯‏⁮‬⁯⁮‎⁯⁬‌‪⁯⁬⁭⁬​‭​‌​‎⁫⁪‭‍‮);
						num = (int)(num2 * -2141235154 ^ 26769919);
						continue;
					}
					case 203:
					{
						TetraPanel.u202c‬​‪‌‭‏‫⁬‪‭‮⁬⁪⁯⁪⁭‎‭​‪‭⁯‏⁪​⁫‪⁬‌‏⁯⁪‫‬‬⁪⁮⁭‍‮(this.u200d‎‫‎‪​‍‏‍⁯‫⁬⁮‌‫⁭‏​​‏⁫‬⁬‎‭‍⁫‌⁬‬⁬‬⁬‏‎⁮​‬⁫⁪‮, true);
						num = (int)(num2 * 299634978 ^ 1692651706);
						continue;
					}
					case 204:
					{
						TetraPanel.u202c⁭⁫‪‏⁬⁭⁭​​⁪⁫‬‍⁪⁫⁭⁬‮‌⁭‫‮‭​⁫‌⁪‎‏⁪‫‮‌​‌‍⁮⁮⁮‮(this.u206b⁭‍‏⁮‪‎‪‎⁬‌⁪⁬⁯‎‬⁫⁬‭⁪⁯‍⁭⁮‪‍⁬‬⁭‮‭⁯​‏‪⁮​​‎⁭‮, new System.Drawing.Size(28, 13));
						TetraPanel.u206b⁬‪‍‭⁮⁪‌‭⁯⁪⁪‏‌‪⁯⁭‮​‭‏‌⁮⁯⁪‪‬​⁮⁯‮⁫⁮‪‪‫‍⁪⁬‎‮(this.u206b⁭‍‏⁮‪‎‪‎⁬‌⁪⁬⁯‎‬⁫⁬‭⁪⁯‍⁭⁮‪‍⁬‬⁭‮‭⁯​‏‪⁮​​‎⁭‮, 85);
						TetraPanel.u206d‫‫‫⁮‮‌​‍⁫‭‎‬​⁭‬⁫‪‌‍‍‎‮⁫‬⁭⁫‫‎⁯‏‌‮‮⁬‮⁬⁪‮(this.u206b⁭‍‏⁮‪‎‪‎⁬‌⁪⁬⁯‎‬⁫⁬‭⁪⁯‍⁭⁮‪‍⁬‬⁭‮‭⁯​‏‪⁮​​‎⁭‮, u003cModuleu003e.u202a‮‫‏‫‬‬‪⁫⁬​‏⁫⁭‍‪‪‎⁬​‪​‌⁮‮‌​⁫​⁬‪‫⁪⁯⁪‎‫⁭‎⁪‮<string>(1339667468));
						TetraPanel.u200e​⁮⁯‮⁭‬‭⁫⁭⁬‌‭‎⁬⁬⁮⁬‭‬⁮‭‏⁫‫​‮‌‬⁪​‮⁮‪‪⁭‮⁪‍⁮‮(this.u200d‌‏‪‍‭⁯‎⁫⁪⁮⁮‍‮⁪⁫⁮⁬‎⁭⁫⁬‭‎⁯‪‍‏‌⁭⁯⁯‬‫‌‭⁮‬‭⁭‮, AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
						num = 315211670;
						continue;
					}
					case 205:
					{
						TetraPanel.u202b‪​⁯⁪⁬⁬‭‍⁪‫‪​‮‍‭‎‍⁯‫‭⁮‭​⁯​‍⁬‌‭‭⁯⁭‭‬‍‭‎‎⁭‮(this.u202e⁪‍‍⁫⁪‪‍‌‏⁪⁪⁫⁪‎‮‭‌⁭‬‪⁮​‭⁯⁯‌‮⁪⁬‮⁬⁬​‮‏⁯⁯‌‏‮, 30);
						num = (int)(num2 * 602301872 ^ 84681900);
						continue;
					}
					case 206:
					{
						this.u206e‬‮​⁮‌⁭​‍‍⁪‌‏‭‬‏‎⁪⁬‫‬⁬⁪‍‌‪​‭⁬⁫⁬‪‭⁬⁪​⁪⁪​⁪‮ = TetraPanel.u200b‬‌⁯‫‪⁪⁯​‭‬‌‭⁯⁮⁮‏​‪‬⁯‭‪​⁫‮​‪‬‬​‌‏⁬⁪‪‏⁪‏⁬‮();
						num = (int)(num2 * -341946279 ^ 1944443150);
						continue;
					}
					case 207:
					{
						TetraPanel.u202b‏‏‬‎‮‫​‍​⁭‬‬‭‮⁫⁯‭⁪‬‎‫‫‎⁬‪‍‎⁪⁪‮‌‮‌‏⁯‌‍​‌‮(this.u202e⁭​⁬‎​⁬⁮​⁬‬‫‎⁫‬‌​⁬⁪⁮​⁫⁬⁫⁪‎‍⁭⁭‬‬‪‎‍‬⁪‍‍​‍‮, TetraPanel.u202c‫‭‪‌‌⁬‌⁬‌‪‬‏‌‍⁯⁪‮⁪‮‌‪⁪⁯‭⁮‪‪⁪‬‭​‬‭‮‍‭‌‍‮(u003cModuleu003e.u200d​‍⁮‏‭⁮⁪‌‪‬‬‬‪⁬⁭⁫⁫‬⁪⁬⁬⁬‏⁮⁭‌‍‏‍‏‎‬⁬​‪‎​‎⁭‮<string>(2136952738), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0));
						TetraPanel.u202b‎⁯‫‮⁬‏‪⁫‍⁫‭​⁭‎​‎‮⁬‍‏‏‎⁯​⁭⁫‏‫‌‌‪‪​‬⁬⁭‫⁮‮‮(this.u202e⁭​⁬‎​⁬⁮​⁬‬‫‎⁫‬‌​⁬⁪⁮​⁫⁬⁫⁪‎‍⁭⁭‬‬‪‎‍‬⁪‍‍​‍‮, new Point(123, 38));
						num = 725193508;
						continue;
					}
					case 208:
					{
						TetraPanel.u202d‏⁭⁫‮‫​‎‪⁫⁯‏⁮‫​‮‌⁮‬⁬‌⁮⁬‏⁭‏⁮‌⁮‮⁮‭‌‫‏⁪‎⁮‏‎‮(TetraPanel.u206a‬⁯⁭⁫‍⁪‫⁬⁭⁬⁮‫‏‍⁫‫‌⁪‪‌​⁭⁮‍‌‬⁯‭⁪‭⁮‏⁮‪​‍⁭⁫⁫‮(this.u200d‮⁪⁭⁭‍⁯‮‭‏‏⁭‬‫⁮⁯‬⁫‬‪⁫‎⁭‭​⁫‪⁬⁮⁫‍⁭​⁭‌⁪​⁪‭⁯‮), this.u202b‫‌‍⁭‎‮⁮‍‮‎‏⁮‭‌⁭⁫‮⁮‭‎‏⁮⁮‌‌‫‬‪⁬⁬‏‌‭‌‫‌‭‭⁭‮);
						num = (int)(num2 * 1554548435 ^ -171731830);
						continue;
					}
					case 209:
					{
						TetraPanel.u202c⁭⁫‪‏⁬⁭⁭​​⁪⁫‬‍⁪⁫⁭⁬‮‌⁭‫‮‭​⁫‌⁪‎‏⁪‫‮‌​‌‍⁮⁮⁮‮(this.u202b⁭‎‭‭‏⁮⁮‮‮‍⁫⁫‎‏‏‌‬‏‬‭‮‪‌⁪‎‏⁫‫‬‬‏‎⁫⁬⁯‌⁭⁪‪‮, new System.Drawing.Size(31, 13));
						num = (int)(num2 * -1835469880 ^ 960910651);
						continue;
					}
					case 210:
					{
						TetraPanel.u202c‏‫‬⁭‍‏‏‍‪‭‪‏‭⁭‍‍‮‏‪‍‭⁪‬⁪‌‍⁭⁭⁯‌⁪⁯‌⁬‌⁬⁬‎‎‮(this, false);
						num = (int)(num2 * 1403632134 ^ 2133719509);
						continue;
					}
					case 211:
					{
						TetraPanel.u200c‏⁫‬‭‌‪⁮‬⁮‏‪⁭‍‪⁯‫⁬⁫⁭‭‮‬‬⁪⁫‏⁭‏⁮⁫​⁫⁬‪‌‫⁭‭‍‮(this.u200b‏⁭⁯⁮⁬‭‮⁭⁯‮​‏‭⁬⁮‫⁬⁬‬‮‏‏‎‮⁫⁬⁭⁮​​⁮⁪⁭⁭​‫‫‮, false);
						num = (int)(num2 * -1456757502 ^ 1559780063);
						continue;
					}
					case 212:
					{
						TetraPanel.u206b⁬‪‍‭⁮⁪‌‭⁯⁪⁪‏‌‪⁯⁭‮​‭‏‌⁮⁯⁪‪‬​⁮⁯‮⁫⁮‪‪‫‍⁪⁬‎‮(this.u202e‪⁬⁫⁬⁭‪‏‌‏‫‫⁬⁭‌‭‮⁭⁭‬‪⁭⁭‬‌‮⁮⁭⁫‌‬⁯⁫‪‭‎‭‎‍⁫‮, 1);
						num = (int)(num2 * 1807812797 ^ -395236633);
						continue;
					}
					case 213:
					{
						TetraPanel.u206d‫‫‫⁮‮‌​‍⁫‭‎‬​⁭‬⁫‪‌‍‍‎‮⁫‬⁭⁫‫‎⁯‏‌‮‮⁬‮⁬⁪‮(this.u202a‎‎‭⁭⁬‎⁬‏⁫⁬⁯‫‎‬‪‏⁬‪‬‭‌‪‌‎⁯‪‪‫​‪​⁮‫‭‌⁮​⁪⁬‮, u003cModuleu003e.u202a‮‫‏‫‬‬‪⁫⁬​‏⁫⁭‍‪‪‎⁬​‪​‌⁮‮‌​⁫​⁬‪‫⁪⁯⁪‎‫⁭‎⁪‮<string>(-692536552));
						TetraPanel.u200e‭⁭‌‪‫​⁯⁫⁫‪⁯‍⁯⁯⁭‎⁫‮⁮​​‭‎‮‍‏‎‎⁪‌⁫‬‮⁮‌⁮‏⁭⁪‮(this.u206c‮⁫⁫⁭⁬‍‮​‮⁭⁭⁭⁭⁪‪‪⁬‬⁫⁮‌​‎⁬‭‫‏‏⁮‍‍​⁯‎⁬‪⁬‏⁫‮, true);
						TetraPanel.u202b‏‏‬‎‮‫​‍​⁭‬‬‭‮⁫⁯‭⁪‬‎‫‫‎⁬‪‍‎⁪⁪‮‌‮‌‏⁯‌‍​‌‮(this.u206c‮⁫⁫⁭⁬‍‮​‮⁭⁭⁭⁭⁪‪‪⁬‬⁫⁮‌​‎⁬‭‫‏‏⁮‍‍​⁯‎⁬‪⁬‏⁫‮, TetraPanel.u202c‫‭‪‌‌⁬‌⁬‌‪‬‏‌‍⁯⁪‮⁪‮‌‪⁪⁯‭⁮‪‪⁪‬‭​‬‭‮‍‭‌‍‮(u003cModuleu003e.u202a‮‫‏‫‬‬‪⁫⁬​‏⁫⁭‍‪‪‎⁬​‪​‌⁮‮‌​⁫​⁬‪‫⁪⁯⁪‎‫⁭‎⁪‮<string>(1627927687), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0));
						TetraPanel.u202b‎⁯‫‮⁬‏‪⁫‍⁫‭​⁭‎​‎‮⁬‍‏‏‎⁯​⁭⁫‏‫‌‌‪‪​‬⁬⁭‫⁮‮‮(this.u206c‮⁫⁫⁭⁬‍‮​‮⁭⁭⁭⁭⁪‪‪⁬‬⁫⁮‌​‎⁬‭‫‏‏⁮‍‍​⁯‎⁬‪⁬‏⁫‮, new Point(82, 37));
						num = 1020051443;
						continue;
					}
					case 214:
					{
						TetraPanel.u206a‪⁭​⁫‮‍‬‭⁬‮‬‫‪⁬‎‌‭⁬‬‭‪‌‫⁮⁫⁫‪‍⁭⁬​‌⁪⁪⁯‮​‫‬‮(this.u200f‍‮‏‌‏‌‍‍⁪⁫⁯⁭‫⁮⁫‫⁯‏‫⁪‍‫⁮‮⁪⁫‍‭‍⁫‏‍⁫‍‌⁪⁫⁪⁭‮);
						num = (int)(num2 * 94822802 ^ -2034502367);
						continue;
					}
					case 215:
					{
						TetraPanel.u202c⁭⁫‪‏⁬⁭⁭​​⁪⁫‬‍⁪⁫⁭⁬‮‌⁭‫‮‭​⁫‌⁪‎‏⁪‫‮‌​‌‍⁮⁮⁮‮(this.u202b‫‭‪⁯⁯⁮‎⁫⁫⁮‫⁪⁯⁮⁭⁫‎‏⁮⁭‭⁪‌⁯⁪⁪‍⁯⁯‌⁫‪‮⁭‌⁪‎‬⁫‮, new System.Drawing.Size(34, 13));
						TetraPanel.u206b⁬‪‍‭⁮⁪‌‭⁯⁪⁪‏‌‪⁯⁭‮​‭‏‌⁮⁯⁪‪‬​⁮⁯‮⁫⁮‪‪‫‍⁪⁬‎‮(this.u202b‫‭‪⁯⁯⁮‎⁫⁫⁮‫⁪⁯⁮⁭⁫‎‏⁮⁭‭⁪‌⁯⁪⁪‍⁯⁯‌⁫‪‮⁭‌⁪‎‬⁫‮, 48);
						TetraPanel.u206d‫‫‫⁮‮‌​‍⁫‭‎‬​⁭‬⁫‪‌‍‍‎‮⁫‬⁭⁫‫‎⁯‏‌‮‮⁬‮⁬⁪‮(this.u202b‫‭‪⁯⁯⁮‎⁫⁫⁮‫⁪⁯⁮⁭⁫‎‏⁮⁭‭⁪‌⁯⁪⁪‍⁯⁯‌⁫‪‮⁭‌⁪‎‬⁫‮, u003cModuleu003e.u200e‏‌‬⁮‪‭⁭‭⁭‎​‏‌‭‭‭⁭⁬⁯⁫‍‮‫⁯‌‮‏​‬⁫⁯⁮⁫‮‪⁫‬⁮⁬‮<string>(491754314));
						TetraPanel.u202a‬​‍⁬‮‫‪⁯‎‫⁮⁭⁯‎‌⁭⁭‍‏‮‫‭‮‏‎‭⁮‮⁯‮⁬⁮‍‍‍⁭‫‮‪‮(this.u202b‫‭‪⁯⁯⁮‎⁫⁫⁮‫⁪⁯⁮⁭⁫‎‏⁮⁭‭⁪‌⁯⁪⁪‍⁯⁯‌⁫‪‮⁭‌⁪‎‬⁫‮, new EventHandler(this.u200f⁬‌‍⁬‏‫​⁯‬⁭‬‎‎⁪‎‮​⁪⁮‭⁬⁬‪⁮‪⁪‪‬‮⁮​‫‮‭‬‎‍⁯⁬‮));
						TetraPanel.u202b‏⁪​⁬⁯‫⁯‍‪⁯‪⁪‭⁫‎‍‎‬‬‌‫⁯⁮⁭⁭‮‭‌‏⁯‬‫‮‏‫‫⁮‮‫‮(this.u202b‫‭‪⁯⁯⁮‎⁫⁫⁮‫⁪⁯⁮⁭⁫‎‏⁮⁭‭⁪‌⁯⁪⁪‍⁯⁯‌⁫‪‮⁭‌⁪‎‬⁫‮, new EventHandler(this.u202a‮‎⁮‏​‫‮‬⁬⁬‌⁫​‮⁪‎‬‍‮⁮‏⁯⁬‎‭⁬⁮‫⁪‭‎‏‮‪​‎‮⁮‍‮));
						TetraPanel.u200e‭⁭‌‪‫​⁯⁫⁫‪⁯‍⁯⁯⁭‎⁫‮⁮​​‭‎‮‍‏‎‎⁪‌⁫‬‮⁮‌⁮‏⁭⁪‮(this.u206a‮​‫‪‪⁬‫‏⁬⁯‫‏⁬‌​⁪‮​‌⁬‏‍‎‍‌⁬⁮⁫‍⁪⁭‎‭‌⁭⁫⁬‏⁮‮, true);
						TetraPanel.u202b‏‏‬‎‮‫​‍​⁭‬‬‭‮⁫⁯‭⁪‬‎‫‫‎⁬‪‍‎⁪⁪‮‌‮‌‏⁯‌‍​‌‮(this.u206a‮​‫‪‪⁬‫‏⁬⁯‫‏⁬‌​⁪‮​‌⁬‏‍‎‍‌⁬⁮⁫‍⁪⁭‎‭‌⁭⁫⁬‏⁮‮, TetraPanel.u202c‫‭‪‌‌⁬‌⁬‌‪‬‏‌‍⁯⁪‮⁪‮‌‪⁪⁯‭⁮‪‪⁪‬‭​‬‭‮‍‭‌‍‮(u003cModuleu003e.u200d​‍⁮‏‭⁮⁪‌‪‬‬‬‪⁬⁭⁫⁫‬⁪⁬⁬⁬‏⁮⁭‌‍‏‍‏‎‬⁬​‪‎​‎⁭‮<string>(2136952738), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0));
						num = 1476336717;
						continue;
					}
					case 216:
					{
						TetraPanel.u202d‏⁭⁫‮‫​‎‪⁫⁯‏⁮‫​‮‌⁮‬⁬‌⁮⁬‏⁭‏⁮‌⁮‮⁮‭‌‫‏⁪‎⁮‏‎‮(TetraPanel.u206a‬⁯⁭⁫‍⁪‫⁬⁭⁬⁮‫‏‍⁫‫‌⁪‪‌​⁭⁮‍‌‬⁯‭⁪‭⁮‏⁮‪​‍⁭⁫⁫‮(this.u206a⁭‫⁬⁯‌‎⁯‬‍​‏‎‌‏⁯‏⁮‬⁯⁮‎⁯⁬‌‪⁯⁬⁭⁬​‭​‌​‎⁫⁪‭‍‮), this.u202b⁭‎‭‭‏⁮⁮‮‮‍⁫⁫‎‏‏‌‬‏‬‭‮‪‌⁪‎‏⁫‫‬‬‏‎⁫⁬⁯‌⁭⁪‪‮);
						num = (int)(num2 * 501602178 ^ -1580294644);
						continue;
					}
					case 217:
					{
						TetraPanel.u200c‏⁫‬‭‌‪⁮‬⁮‏‪⁭‍‪⁯‫⁬⁫⁭‭‮‬‬⁪⁫‏⁭‏⁮⁫​⁫⁬‪‌‫⁭‭‍‮(this.u200e‎⁭‏‎‪‎‍‬⁭⁮⁬‍⁭‮​⁪‮‏‍⁪‎‫⁮‫⁭⁯⁪‌‌​‌⁬‫‏‬‍⁯⁮‭‮, true);
						num = (int)(num2 * -29642068 ^ 1327421433);
						continue;
					}
					case 218:
					{
						TetraPanel.u202b‏‏‬‎‮‫​‍​⁭‬‬‭‮⁫⁯‭⁪‬‎‫‫‎⁬‪‍‎⁪⁪‮‌‮‌‏⁯‌‍​‌‮(this.u206d‪⁪‌⁭‌‫⁭‌⁪​‭⁫‎‪‭‌⁬‍‎‌‮‍‌‬‍‬⁬‏⁫‏‫‏‏‎‭‬‍‪⁫‮, TetraPanel.u202c‫‭‪‌‌⁬‌⁬‌‪‬‏‌‍⁯⁪‮⁪‮‌‪⁪⁯‭⁮‪‪⁪‬‭​‬‭‮‍‭‌‍‮(u003cModuleu003e.u206f⁮​‌‪‮‎‭‏‮‎⁮⁮‮⁬⁫‍‍⁪‍⁫⁮‏​‎⁬⁯⁪‪‍⁪⁮‎⁬⁪⁫​⁮⁪⁮‮<string>(125941577), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0));
						TetraPanel.u202b‎⁯‫‮⁬‏‪⁫‍⁫‭​⁭‎​‎‮⁬‍‏‏‎⁯​⁭⁫‏‫‌‌‪‪​‬⁬⁭‫⁮‮‮(this.u206d‪⁪‌⁭‌‫⁭‌⁪​‭⁫‎‪‭‌⁬‍‎‌‮‍‌‬‍‬⁬‏⁫‏‫‏‏‎‭‬‍‪⁫‮, new Point(88, 20));
						num = 1394500200;
						continue;
					}
					case 219:
					{
						TetraPanel.u202d‏⁭⁫‮‫​‎‪⁫⁯‏⁮‫​‮‌⁮‬⁬‌⁮⁬‏⁭‏⁮‌⁮‮⁮‭‌‫‏⁪‎⁮‏‎‮(TetraPanel.u206a‬⁯⁭⁫‍⁪‫⁬⁭⁬⁮‫‏‍⁫‫‌⁪‪‌​⁭⁮‍‌‬⁯‭⁪‭⁮‏⁮‪​‍⁭⁫⁫‮(this.u200d‮⁪⁭⁭‍⁯‮‭‏‏⁭‬‫⁮⁯‬⁫‬‪⁫‎⁭‭​⁫‪⁬⁮⁫‍⁭​⁭‌⁪​⁪‭⁯‮), this.u200d‌‎‪⁯⁯⁫‭‬‬‭‎​‍‮⁯‮‌‬‪‭​⁮⁭⁬‏‏‫⁪‏⁭⁬‏⁮⁮‬⁯‏‭‍‮);
						num = (int)(num2 * 1340218339 ^ 599879080);
						continue;
					}
					case 220:
					{
						TetraPanel.u206b⁬‪‍‭⁮⁪‌‭⁯⁪⁪‏‌‪⁯⁭‮​‭‏‌⁮⁯⁪‪‬​⁮⁯‮⁫⁮‪‪‫‍⁪⁬‎‮(this.u206e‬‮​⁮‌⁭​‍‍⁪‌‏‭‬‏‎⁪⁬‫‬⁬⁪‍‌‪​‭⁬⁫⁬‪‭⁬⁪​⁪⁪​⁪‮, 73);
						num = (int)(num2 * 229590242 ^ 1189687746);
						continue;
					}
					case 221:
					{
						TetraPanel.u202d‏⁭⁫‮‫​‎‪⁫⁯‏⁮‫​‮‌⁮‬⁬‌⁮⁬‏⁭‏⁮‌⁮‮⁮‭‌‫‏⁪‎⁮‏‎‮(TetraPanel.u206a‬⁯⁭⁫‍⁪‫⁬⁭⁬⁮‫‏‍⁫‫‌⁪‪‌​⁭⁮‍‌‬⁯‭⁪‭⁮‏⁮‪​‍⁭⁫⁫‮(this.u206a‎‪⁮​‮⁭‭⁪‎⁪‏‌‎‌‎⁮⁫‬‭‍⁭⁭‫‏⁫​‬‪⁪‮⁮‏‏⁭⁬‌⁪⁯‭‮), this.u206b⁭‍‏⁮‪‎‪‎⁬‌⁪⁬⁯‎‬⁫⁬‭⁪⁯‍⁭⁮‪‍⁬‬⁭‮‭⁯​‏‪⁮​​‎⁭‮);
						TetraPanel.u202d‏⁭⁫‮‫​‎‪⁫⁯‏⁮‫​‮‌⁮‬⁬‌⁮⁬‏⁭‏⁮‌⁮‮⁮‭‌‫‏⁪‎⁮‏‎‮(TetraPanel.u206a‬⁯⁭⁫‍⁪‫⁬⁭⁬⁮‫‏‍⁫‫‌⁪‪‌​⁭⁮‍‌‬⁯‭⁪‭⁮‏⁮‪​‍⁭⁫⁫‮(this.u206a‎‪⁮​‮⁭‭⁪‎⁪‏‌‎‌‎⁮⁫‬‭‍⁭⁭‫‏⁫​‬‪⁪‮⁮‏‏⁭⁬‌⁪⁯‭‮), this.u200d‌‏‪‍‭⁯‎⁫⁪⁮⁮‍‮⁪⁫⁮⁬‎⁭⁫⁬‭‎⁯‪‍‏‌⁭⁯⁯‬‫‌‭⁮‬‭⁭‮);
						num = (int)(num2 * -1308565239 ^ -1550282244);
						continue;
					}
					case 222:
					{
						this.u200f‏⁪‪⁪‪⁯‪‌⁬‎‪‬‫⁯‭‬‌⁯‏⁮⁫‪⁯‬⁪⁭⁭‪‪‌‍‭‎⁭⁫⁯⁯​‏‮ = TetraPanel.u200b‬‌⁯‫‪⁪⁯​‭‬‌‭⁯⁮⁮‏​‪‬⁯‭‪​⁫‮​‪‬‬​‌‏⁬⁪‪‏⁪‏⁬‮();
						num = (int)(num2 * -1104372353 ^ -2129282338);
						continue;
					}
					case 223:
					{
						TetraPanel.u200c⁪‏‏⁫‌⁭‭⁪‮⁯⁫‬‏‍‬⁮⁮‍‌‎‮⁪‌⁮⁭⁮⁫‮‬⁪‭⁬⁮⁮⁫‫‌‌‏‮(this.u206a‎‪⁮​‮⁭‭⁪‎⁪‏‌‎‌‎⁮⁫‬‭‍⁭⁭‫‏⁫​‬‪⁪‮⁮‏‏⁭⁬‌⁪⁯‭‮, Color.FromArgb(1, 1, 1));
						TetraPanel.u202b‎⁯‫‮⁬‏‪⁫‍⁫‭​⁭‎​‎‮⁬‍‏‏‎⁯​⁭⁫‏‫‌‌‪‪​‬⁬⁭‫⁮‮‮(this.u206a‎‪⁮​‮⁭‭⁪‎⁪‏‌‎‌‎⁮⁫‬‭‍⁭⁭‫‏⁫​‬‪⁪‮⁮‏‏⁭⁬‌⁪⁯‭‮, new Point(5, 270));
						num = (int)(num2 * -1531335816 ^ -112107272);
						continue;
					}
					case 224:
					{
						TetraPanel.u202b‏‏‬‎‮‫​‍​⁭‬‬‭‮⁫⁯‭⁪‬‎‫‫‎⁬‪‍‎⁪⁪‮‌‮‌‏⁯‌‍​‌‮(this.u200f‫‮⁭⁭‬‌‪⁭‭‭‬⁮‪‮⁬⁬​⁮⁫‍⁮‍​⁮‫‪‮‎⁪⁬‎⁮⁭⁯⁯⁮‮‪⁭‮, TetraPanel.u202c‫‭‪‌‌⁬‌⁬‌‪‬‏‌‍⁯⁪‮⁪‮‌‪⁪⁯‭⁮‪‪⁪‬‭​‬‭‮‍‭‌‍‮(u003cModuleu003e.u202a‮‫‏‫‬‬‪⁫⁬​‏⁫⁭‍‪‪‎⁬​‪​‌⁮‮‌​⁫​⁬‪‫⁪⁯⁪‎‫⁭‎⁪‮<string>(1627927687), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0));
						TetraPanel.u202b‎⁯‫‮⁬‏‪⁫‍⁫‭​⁭‎​‎‮⁬‍‏‏‎⁯​⁭⁫‏‫‌‌‪‪​‬⁬⁭‫⁮‮‮(this.u200f‫‮⁭⁭‬‌‪⁭‭‭‬⁮‪‮⁬⁬​⁮⁫‍⁮‍​⁮‫‪‮‎⁪⁬‎⁮⁭⁯⁯⁮‮‪⁭‮, new Point(3, 52));
						num = 1269789805;
						continue;
					}
					case 225:
					{
						TetraPanel.u206d‏⁬‪‪‭⁪‏⁯⁭‌‍⁬‮‮⁪‪‬⁯‪⁬⁯‫‫‫‫​⁯‫‭‌‬⁫⁫⁮⁫⁯‪‍⁪‮(this, new EventHandler(this.u202a‍‪⁫‫‏‭⁭⁯‌‪⁬‭​‬‬⁬⁫⁪‭‪‏⁪⁫‬‮⁫‎‏‫⁬‮⁭‎‍‫‌‌‮⁫‮));
						num = (int)(num2 * 686890236 ^ -1568382855);
						continue;
					}
					case 226:
					{
						TetraPanel.u206e⁪‏‏​‍⁮‫⁬⁬⁯⁫⁯‏⁬⁮‫‫⁬⁬‭‫‌‌⁭‎​‭⁭‍⁬‏‏⁮‫⁮‭‮‎‪‮(this.u200c‫‌‪‌‌‏​⁯⁪​‫⁪⁮⁯‫‍⁪⁫⁪‮⁬⁬‭⁯‌‫⁯‫‪‏‭‏⁭⁬‌‫‬⁪⁬‮, u003cModuleu003e.u200f⁫‌​⁬‌‎‎‏‍‍⁫‎​‌‬⁯‬‫‭‎‏​‌​⁪‭‬⁬‮⁬​‌⁬⁪‫‫‎⁪⁮‮<string>(-1092474658));
						TetraPanel.u202c⁭⁫‪‏⁬⁭⁭​​⁪⁫‬‍⁪⁫⁭⁬‮‌⁭‫‮‭​⁫‌⁪‎‏⁪‫‮‌​‌‍⁮⁮⁮‮(this.u200c‫‌‪‌‌‏​⁯⁪​‫⁪⁮⁯‫‍⁪⁫⁪‮⁬⁬‭⁯‌‫⁯‫‪‏‭‏⁭⁬‌‫‬⁪⁬‮, new System.Drawing.Size(62, 13));
						TetraPanel.u206b⁬‪‍‭⁮⁪‌‭⁯⁪⁪‏‌‪⁯⁭‮​‭‏‌⁮⁯⁪‪‬​⁮⁯‮⁫⁮‪‪‫‍⁪⁬‎‮(this.u200c‫‌‪‌‌‏​⁯⁪​‫⁪⁮⁯‫‍⁪⁫⁪‮⁬⁬‭⁯‌‫⁯‫‪‏‭‏⁭⁬‌‫‬⁪⁬‮, 82);
						num = 1356481829;
						continue;
					}
					case 227:
					{
						this.u206a‮​‫‪‪⁬‫‏⁬⁯‫‏⁬‌​⁪‮​‌⁬‏‍‎‍‌⁬⁮⁫‍⁪⁭‎‭‌⁭⁫⁬‏⁮‮ = TetraPanel.u200b‬‌⁯‫‪⁪⁯​‭‬‌‭⁯⁮⁮‏​‪‬⁯‭‪​⁫‮​‪‬‬​‌‏⁬⁪‪‏⁪‏⁬‮();
						num = (int)(num2 * 1567209933 ^ -263894428);
						continue;
					}
					case 228:
					{
						TetraPanel.u202a‭‮⁬⁪⁯⁫‎⁬⁭‏⁯⁫⁪​⁭‏‏⁫‫⁯‍‮‫⁮‮​‍‮‪‫⁫​⁭‏⁮​⁭⁯‪‮(this.u206a⁯‏⁯​‫‬⁬‌⁮​⁯‬‌‭⁯‪⁬⁯⁮‌‫⁫⁫‍‎‎⁫⁮‫‍‍‪​‮‍‮‭⁬‏‮, new decimal(new int[] { 2000, 0, 0, 0 }));
						TetraPanel.u206b‪‫⁫​⁬‪‍‫‏⁭​⁫⁬‮‬‍⁮‮‍‬‬‬‭‬‍‮⁭‍‏‌⁬⁭‬‫⁬‏⁬⁫‌‮(this.u206a⁯‏⁯​‫‬⁬‌⁮​⁯‬‌‭⁯‪⁬⁯⁮‌‫⁫⁫‍‎‎⁫⁮‫‍‍‪​‮‍‮‭⁬‏‮, new decimal(new int[] { 10, 0, 0, 0 }));
						num = (int)(num2 * -2105148443 ^ -1727264436);
						continue;
					}
					case 229:
					{
						TetraPanel.u200e‭⁭‌‪‫​⁯⁫⁫‪⁯‍⁯⁯⁭‎⁫‮⁮​​‭‎‮‍‏‎‎⁪‌⁫‬‮⁮‌⁮‏⁭⁪‮(this.u200f‫‮⁭⁭‬‌‪⁭‭‭‬⁮‪‮⁬⁬​⁮⁫‍⁮‍​⁮‫‪‮‎⁪⁬‎⁮⁭⁯⁯⁮‮‪⁭‮, true);
						num = (int)(num2 * -321008332 ^ -142033482);
						continue;
					}
					case 230:
					{
						TetraPanel.u202e⁯‭⁪‪⁬‮‬‍‭⁪⁭⁯⁯‌⁫⁫‭‎⁯‭⁭⁪‌‮‪‏⁮‮⁭‫‎⁭‬‏‏‫‌⁪‌‮(this.u202b‫‌‍⁭‎‮⁮‍‮‎‏⁮‭‌⁭⁫‮⁮‭‎‏⁮⁮‌‌‫‬‪⁬⁬‏‌‭‌‫‌‭‭⁭‮, new decimal(new int[] { 1, 0, 0, -2147483648 }));
						num = (int)(num2 * 2132456770 ^ -531106879);
						continue;
					}
					case 231:
					{
						TetraPanel.u200f⁪​‬‍‏‭‭‏‫⁬‬‭‮⁯‫⁫⁯⁫‪‌‌‌‪‍⁪‏‎‌‬⁮⁬⁫⁬⁬⁮‪⁮⁬‪‮(this.u206a⁭‫⁬⁯‌‎⁯‬‍​‏‎‌‏⁯‏⁮‬⁯⁮‎⁯⁬‌‪⁯⁬⁭⁬​‭​‌​‎⁫⁪‭‍‮, false);
						num = (int)(num2 * -1355655266 ^ 1295202544);
						continue;
					}
					case 232:
					{
						TetraPanel.u206a‏⁫‫​‏⁪⁬⁪‪⁪⁬‬⁫⁯‎‪⁯‫‎⁯‪‭‎‮‪‎⁮⁯‭⁯‎⁮⁮‪‭⁫‬⁫⁬‮(this.u200c‎‎‪‎‮‎⁫‭‪⁯⁬⁪⁬‏‮‏‪‫‏⁯⁪​⁬‫⁯⁪‎‪‏‫‮⁯‏‪‭‬‏‪‮, false);
						num = (int)(num2 * -2039308746 ^ -1157181979);
						continue;
					}
					case 233:
					{
						TetraPanel.u206b⁬‪‍‭⁮⁪‌‭⁯⁪⁪‏‌‪⁯⁭‮​‭‏‌⁮⁯⁪‪‬​⁮⁯‮⁫⁮‪‪‫‍⁪⁬‎‮(this.u206a⁯‏⁯​‫‬⁬‌⁮​⁯‬‌‭⁯‪⁬⁯⁮‌‫⁫⁫‍‎‎⁫⁮‫‍‍‪​‮‍‮‭⁬‏‮, 79);
						num = (int)(num2 * 817345214 ^ 104844201);
						continue;
					}
					case 234:
					{
						TetraPanel.u202b‬⁫‌‪⁯⁭‪⁮‏‪⁭⁪‌‪⁬⁪‭⁬‮‬‭⁫‫⁯‭‫‫‎‎‮‎‏⁮⁯‪‌‭⁫‌‮(this.u200e⁫​‭⁪‫‏‬‮⁭⁬‌‏⁮⁮​‍‍‎‍‭‍‎​‪‪‭⁪‏‎⁬‎‍‫‮​⁬⁮⁯‫‮, false);
						num = (int)(num2 * -2049827335 ^ 541742389);
						continue;
					}
					case 235:
					{
						TetraPanel.u206d‫‫‫⁮‮‌​‍⁫‭‎‬​⁭‬⁫‪‌‍‍‎‮⁫‬⁭⁫‫‎⁯‏‌‮‮⁬‮⁬⁪‮(this.u200d‌‎‪⁯⁯⁫‭‬‬‭‎​‍‮⁯‮‌‬‪‭​⁮⁭⁬‏‏‫⁪‏⁭⁬‏⁮⁮‬⁯‏‭‍‮, u003cModuleu003e.u200d​‍⁮‏‭⁮⁪‌‪‬‬‬‪⁬⁭⁫⁫‬⁪⁬⁬⁬‏⁮⁭‌‍‏‍‏‎‬⁬​‪‎​‎⁭‮<string>(2105561653));
						num = 1252852291;
						continue;
					}
					case 236:
					{
						this.u200f⁫⁭⁬​‮‫‭‪‬‏⁯‭‎‭⁫‌⁬⁮‭‮‌‮⁫⁫‭‎‪‎‎​⁫‎⁮⁭⁯⁫‌‮‫‮ = TetraPanel.u200b‬‌⁯‫‪⁪⁯​‭‬‌‭⁯⁮⁮‏​‪‬⁯‭‪​⁫‮​‪‬‬​‌‏⁬⁪‪‏⁪‏⁬‮();
						num = (int)(num2 * 667030069 ^ 510989616);
						continue;
					}
					case 237:
					{
						TetraPanel.u202b‏⁪​⁬⁯‫⁯‍‪⁯‪⁪‭⁫‎‍‎‬‬‌‫⁯⁮⁭⁭‮‭‌‏⁯‬‫‮‏‫‫⁮‮‫‮(this.u206a‮​‫‪‪⁬‫‏⁬⁯‫‏⁬‌​⁪‮​‌⁬‏‍‎‍‌⁬⁮⁫‍⁪⁭‎‭‌⁭⁫⁬‏⁮‮, new EventHandler(this.u200d‏‫⁫‬‬‬‪​‮‭⁭‏‬‬‫​‪⁫⁭⁭‫⁪‎‎⁫‪⁯‍⁫⁭⁭⁮‬‎⁪‪⁪‪‬‮));
						TetraPanel.u202e​‍‌‌⁮⁫‫‍⁯⁯⁯⁬‫⁪‎⁪⁬‫⁮‎⁯‭​​‭‌‎​‍‮⁯⁪⁪⁪‫⁬‬‏⁫‮(this.u202e‭‭‮​⁬⁯‎⁫​‬‏‌⁮⁮‮⁮⁬⁭‮⁯⁯‏‬‎​‎‍‏⁭⁮‏‬‫⁪‍‬‫‪‬‮, FlatStyle.Flat);
						TetraPanel.u202b‏‏‬‎‮‫​‍​⁭‬‬‭‮⁫⁯‭⁪‬‎‫‫‎⁬‪‍‎⁪⁪‮‌‮‌‏⁯‌‍​‌‮(this.u202e‭‭‮​⁬⁯‎⁫​‬‏‌⁮⁮‮⁮⁬⁭‮⁯⁯‏‬‎​‎‍‏⁭⁮‏‬‫⁪‍‬‫‪‬‮, TetraPanel.u202c‫‭‪‌‌⁬‌⁬‌‪‬‏‌‍⁯⁪‮⁪‮‌‪⁪⁯‭⁮‪‪⁪‬‭​‬‭‮‍‭‌‍‮(u003cModuleu003e.u202a‮‫‏‫‬‬‪⁫⁬​‏⁫⁭‍‪‪‎⁬​‪​‌⁮‮‌​⁫​⁬‪‫⁪⁯⁪‎‫⁭‎⁪‮<string>(1627927687), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0));
						TetraPanel.u202b‎⁯‫‮⁬‏‪⁫‍⁫‭​⁭‎​‎‮⁬‍‏‏‎⁯​⁭⁫‏‫‌‌‪‪​‬⁬⁭‫⁮‮‮(this.u202e‭‭‮​⁬⁯‎⁫​‬‏‌⁮⁮‮⁮⁬⁭‮⁯⁯‏‬‎​‎‍‏⁭⁮‏‬‫⁪‍‬‫‪‬‮, new Point(6, 99));
						num = 1133146123;
						continue;
					}
					case 238:
					{
						TetraPanel.u206b⁬‪‍‭⁮⁪‌‭⁯⁪⁪‏‌‪⁯⁭‮​‭‏‌⁮⁯⁪‪‬​⁮⁯‮⁫⁮‪‪‫‍⁪⁬‎‮(this.u206a⁭‫⁬⁯‌‎⁯‬‍​‏‎‌‏⁯‏⁮‬⁯⁮‎⁯⁬‌‪⁯⁬⁭⁬​‭​‌​‎⁫⁪‭‍‮, 0);
						num = (int)(num2 * -118892215 ^ 47010327);
						continue;
					}
					case 239:
					{
						TetraPanel.u206d‫‫‫⁮‮‌​‍⁫‭‎‬​⁭‬⁫‪‌‍‍‎‮⁫‬⁭⁫‫‎⁯‏‌‮‮⁬‮⁬⁪‮(this.u200e‮⁯​⁬⁫‍⁭⁯⁪‪⁫‭⁯‬⁭‫‭⁭⁫‮⁮‏⁫‮‫‭‍‫​⁭‏⁮⁯‎‭⁯‫⁯⁮‮, u003cModuleu003e.u206f⁮​‌‪‮‎‭‏‮‎⁮⁮‮⁬⁫‍‍⁪‍⁫⁮‏​‎⁬⁯⁪‪‍⁪⁮‎⁬⁪⁫​⁮⁪⁮‮<string>(1209596741));
						num = 1410393763;
						continue;
					}
					case 240:
					{
						TetraPanel.u202b‎⁯‫‮⁬‏‪⁫‍⁫‭​⁭‎​‎‮⁬‍‏‏‎⁯​⁭⁫‏‫‌‌‪‪​‬⁬⁭‫⁮‮‮(this.u206e‬‮​⁮‌⁭​‍‍⁪‌‏‭‬‏‎⁪⁬‫‬⁬⁪‍‌‪​‭⁬⁫⁬‪‭⁬⁪​⁪⁪​⁪‮, new Point(6, 111));
						TetraPanel.u206e⁪‏‏​‍⁮‫⁬⁬⁯⁫⁯‏⁬⁮‫‫⁬⁬‭‫‌‌⁭‎​‭⁭‍⁬‏‏⁮‫⁮‭‮‎‪‮(this.u206e‬‮​⁮‌⁭​‍‍⁪‌‏‭‬‏‎⁪⁬‫‬⁬⁪‍‌‪​‭⁬⁫⁬‪‭⁬⁪​⁪⁪​⁪‮, u003cModuleu003e.u202a‮‫‏‫‬‬‪⁫⁬​‏⁫⁭‍‪‪‎⁬​‪​‌⁮‮‌​⁫​⁬‪‫⁪⁯⁪‎‫⁭‎⁪‮<string>(1088285371));
						TetraPanel.u202c⁭⁫‪‏⁬⁭⁭​​⁪⁫‬‍⁪⁫⁭⁬‮‌⁭‫‮‭​⁫‌⁪‎‏⁪‫‮‌​‌‍⁮⁮⁮‮(this.u206e‬‮​⁮‌⁭​‍‍⁪‌‏‭‬‏‎⁪⁬‫‬⁬⁪‍‌‪​‭⁬⁫⁬‪‭⁬⁪​⁪⁪​⁪‮, new System.Drawing.Size(94, 13));
						num = 776948164;
						continue;
					}
					case 241:
					{
						TetraPanel.u206d‫‫‫⁮‮‌​‍⁫‭‎‬​⁭‬⁫‪‌‍‍‎‮⁫‬⁭⁫‫‎⁯‏‌‮‮⁬‮⁬⁪‮(this.u200c⁭‫‪⁮⁪⁬‭⁬⁮‌⁬⁭‌‍‎⁫‮‭‍⁮‬‮⁫‫⁮⁬‮‬⁬‭⁯⁫‍‪⁪⁯‏​⁭‮, u003cModuleu003e.u200f⁫‌​⁬‌‎‎‏‍‍⁫‎​‌‬⁯‬‫‭‎‏​‌​⁪‭‬⁬‮⁬​‌⁬⁪‫‫‎⁪⁮‮<string>(-1137425793));
						TetraPanel.u200e‭⁭‌‪‫​⁯⁫⁫‪⁯‍⁯⁯⁭‎⁫‮⁮​​‭‎‮‍‏‎‎⁪‌⁫‬‮⁮‌⁮‏⁭⁪‮(this.u202e⁬⁬​‫⁪‍‍‏‌‏‬‌⁫‮⁫⁮‏⁬‭‭⁬‏⁫⁪‬‎⁪⁪‪‪‏‫⁮‭‪⁭‬‎‪‮, true);
						TetraPanel.u202b‏‏‬‎‮‫​‍​⁭‬‬‭‮⁫⁯‭⁪‬‎‫‫‎⁬‪‍‎⁪⁪‮‌‮‌‏⁯‌‍​‌‮(this.u202e⁬⁬​‫⁪‍‍‏‌‏‬‌⁫‮⁫⁮‏⁬‭‭⁬‏⁫⁪‬‎⁪⁪‪‪‏‫⁮‭‪⁭‬‎‪‮, TetraPanel.u202c‫‭‪‌‌⁬‌⁬‌‪‬‏‌‍⁯⁪‮⁪‮‌‪⁪⁯‭⁮‪‪⁪‬‭​‬‭‮‍‭‌‍‮(u003cModuleu003e.u202a‮‫‏‫‬‬‪⁫⁬​‏⁫⁭‍‪‪‎⁬​‪​‌⁮‮‌​⁫​⁬‪‫⁪⁯⁪‎‫⁭‎⁪‮<string>(1627927687), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0));
						TetraPanel.u202b‎⁯‫‮⁬‏‪⁫‍⁫‭​⁭‎​‎‮⁬‍‏‏‎⁯​⁭⁫‏‫‌‌‪‪​‬⁬⁭‫⁮‮‮(this.u202e⁬⁬​‫⁪‍‍‏‌‏‬‌⁫‮⁫⁮‏⁬‭‭⁬‏⁫⁪‬‎⁪⁪‪‪‏‫⁮‭‪⁭‬‎‪‮, new Point(138, 88));
						TetraPanel.u206e⁪‏‏​‍⁮‫⁬⁬⁯⁫⁯‏⁬⁮‫‫⁬⁬‭‫‌‌⁭‎​‭⁭‍⁬‏‏⁮‫⁮‭‮‎‪‮(this.u202e⁬⁬​‫⁪‍‍‏‌‏‬‌⁫‮⁫⁮‏⁬‭‭⁬‏⁫⁪‬‎⁪⁪‪‪‏‫⁮‭‪⁭‬‎‪‮, u003cModuleu003e.u200f⁫‌​⁬‌‎‎‏‍‍⁫‎​‌‬⁯‬‫‭‎‏​‌​⁪‭‬⁬‮⁬​‌⁬⁪‫‫‎⁪⁮‮<string>(-390379947));
						TetraPanel.u202c⁭⁫‪‏⁬⁭⁭​​⁪⁫‬‍⁪⁫⁭⁬‮‌⁭‫‮‭​⁫‌⁪‎‏⁪‫‮‌​‌‍⁮⁮⁮‮(this.u202e⁬⁬​‫⁪‍‍‏‌‏‬‌⁫‮⁫⁮‏⁬‭‭⁬‏⁫⁪‬‎⁪⁪‪‪‏‫⁮‭‪⁭‬‎‪‮, new System.Drawing.Size(13, 13));
						num = 1709382863;
						continue;
					}
					case 242:
					{
						TetraPanel.u202b‎⁯‫‮⁬‏‪⁫‍⁫‭​⁭‎​‎‮⁬‍‏‏‎⁯​⁭⁫‏‫‌‌‪‪​‬⁬⁭‫⁮‮‮(this.u200c‎‏⁪⁭⁬⁫‎⁭‪⁫⁫‮​⁯‫‪‏‮‮‬‬⁬‍⁭⁯‪⁪⁫⁬‬⁫‬‍⁮‍⁭‪‭⁪‮, new Point(213, 482));
						num = (int)(num2 * -420548290 ^ 503233442);
						continue;
					}
					case 243:
					{
						TetraPanel.u202d‏⁭⁫‮‫​‎‪⁫⁯‏⁮‫​‮‌⁮‬⁬‌⁮⁬‏⁭‏⁮‌⁮‮⁮‭‌‫‏⁪‎⁮‏‎‮(TetraPanel.u206a‬⁯⁭⁫‍⁪‫⁬⁭⁬⁮‫‏‍⁫‫‌⁪‪‌​⁭⁮‍‌‬⁯‭⁪‭⁮‏⁮‪​‍⁭⁫⁫‮(this.u206a⁭‫⁬⁯‌‎⁯‬‍​‏‎‌‏⁯‏⁮‬⁯⁮‎⁯⁬‌‪⁯⁬⁭⁬​‭​‌​‎⁫⁪‭‍‮), this.u200c‎‏⁪⁭⁬⁫‎⁭‪⁫⁫‮​⁯‫‪‏‮‮‬‬⁬‍⁭⁯‪⁪⁫⁬‬⁫‬‍⁮‍⁭‪‭⁪‮);
						num = (int)(num2 * 89292494 ^ -1194370075);
						continue;
					}
					case 244:
					{
						this.u200d‭‍‭⁪‬⁭‎⁬‍‬⁭‍‍‌⁬⁫‍‬‫‏⁯⁭‍⁮‎⁪⁪⁫⁬⁯‭‏⁪‮‫‭⁯⁪⁪‮ = TetraPanel.u200f‭‎⁫‎‏‫‫⁭​‪‫⁯‌‎‫‮‬⁯⁯‍‭‎‌‌‌⁫‏⁮⁬​⁮‭‌​⁮⁭⁮⁯⁭‮(this.u200c⁫⁯⁬‪‌‬‭‫‭​‪​⁯‮⁪‫⁫⁯⁪‏‌⁬⁮‬‌‬⁭‭⁮⁯‮‬⁮‏‫⁯​‭‏‮);
						num = (int)(num2 * -1478964344 ^ 344275176);
						continue;
					}
					case 245:
					{
						TetraPanel.u202b‎⁯‫‮⁬‏‪⁫‍⁫‭​⁭‎​‎‮⁬‍‏‏‎⁯​⁭⁫‏‫‌‌‪‪​‬⁬⁭‫⁮‮‮(this.u202e⁮‍‍⁮‎⁪⁫⁫‍‮‭‬‍⁪‪‮⁭‬⁫⁯‪⁯​⁪‬‫​⁬‭‭⁯‫‎⁮‏​​‬‎‮, new Point(3, 69));
						num = (int)(num2 * 1032525976 ^ -1001529227);
						continue;
					}
					case 246:
					{
						TetraPanel.u206c‭‬‬⁮⁪⁮‬‎⁭⁫‪​⁯‭‌‪‫​‬‌⁯‭⁪⁪⁮‬⁬‏⁮‏‏‬‎‌‮⁮⁭⁬⁪‮(this, System.Windows.Forms.AutoScaleMode.Font);
						TetraPanel.u202d‏⁭⁫‮‫​‎‪⁫⁯‏⁮‫​‮‌⁮‬⁬‌⁮⁬‏⁭‏⁮‌⁮‮⁮‭‌‫‏⁪‎⁮‏‎‮(TetraPanel.u206f‍‭⁪‮‍‎‌⁫‫‏‍‮‫‫⁯‏‏‍‍‫‬⁪‫​‬⁯⁯⁭‮‌‍⁬‍‍‌‬‪‍‬‮(this), this.u200e⁫​‭⁪‫‏‬‮⁭⁬‌‏⁮⁮​‍‍‎‍‭‍‎​‪‪‭⁪‏‎⁬‎‍‫‮​⁬⁮⁯‫‮);
						num = (int)(num2 * 587027417 ^ -2118789639);
						continue;
					}
					case 247:
					{
						TetraPanel.u200c⁪‏‏⁫‌⁭‭⁪‮⁯⁫‬‏‍‬⁮⁮‍‌‎‮⁪‌⁮⁭⁮⁫‮‬⁪‭⁬⁮⁮⁫‫‌‌‏‮(this.u200c‎‎‪‎‮‎⁫‭‪⁯⁬⁪⁬‏‮‏‪‫‏⁯⁪​⁬‫⁯⁪‎‪‏‫‮⁯‏‪‭‬‏‪‮, Color.Blue);
						num = (int)(num2 * -164599111 ^ 1331027801);
						continue;
					}
					case 248:
					{
						TetraPanel.u200e‭⁭‌‪‫​⁯⁫⁫‪⁯‍⁯⁯⁭‎⁫‮⁮​​‭‎‮‍‏‎‎⁪‌⁫‬‮⁮‌⁮‏⁭⁪‮(this.u202c⁭‎‫‮‌⁯⁮‍‎⁪⁪⁬‭⁮‏‎‌‌‎‌⁯‪‮⁯‌⁮‌‭⁯‎‍‌⁪‍‭‏⁪‬‮, true);
						num = (int)(num2 * 1174318773 ^ 969060641);
						continue;
					}
					case 249:
					{
						TetraPanel.u202b‏‏‬‎‮‫​‍​⁭‬‬‭‮⁫⁯‭⁪‬‎‫‫‎⁬‪‍‎⁪⁪‮‌‮‌‏⁯‌‍​‌‮(this.u202b‫‭‪⁯⁯⁮‎⁫⁫⁮‫⁪⁯⁮⁭⁫‎‏⁮⁭‭⁪‌⁯⁪⁪‍⁯⁯‌⁫‪‮⁭‌⁪‎‬⁫‮, TetraPanel.u202c‫‭‪‌‌⁬‌⁬‌‪‬‏‌‍⁯⁪‮⁪‮‌‪⁪⁯‭⁮‪‪⁪‬‭​‬‭‮‍‭‌‍‮(u003cModuleu003e.u202a‮‫‏‫‬‬‪⁫⁬​‏⁫⁭‍‪‪‎⁬​‪​‌⁮‮‌​⁫​⁬‪‫⁪⁯⁪‎‫⁭‎⁪‮<string>(1627927687), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0));
						TetraPanel.u202b‎⁯‫‮⁬‏‪⁫‍⁫‭​⁭‎​‎‮⁬‍‏‏‎⁯​⁭⁫‏‫‌‌‪‪​‬⁬⁭‫⁮‮‮(this.u202b‫‭‪⁯⁯⁮‎⁫⁫⁮‫⁪⁯⁮⁭⁫‎‏⁮⁭‭⁪‌⁯⁪⁪‍⁯⁯‌⁫‪‮⁭‌⁪‎‬⁫‮, new Point(6, 38));
						num = 1088581210;
						continue;
					}
					case 250:
					{
						TetraPanel.u202c⁭⁫‪‏⁬⁭⁭​​⁪⁫‬‍⁪⁫⁭⁬‮‌⁭‫‮‭​⁫‌⁪‎‏⁪‫‮‌​‌‍⁮⁮⁮‮(this.u202e‭‭‮​⁬⁯‎⁫​‬‏‌⁮⁮‮⁮⁬⁭‮⁯⁯‏‬‎​‎‍‏⁭⁮‏‬‫⁪‍‬‫‪‬‮, new System.Drawing.Size(69, 23));
						TetraPanel.u206b⁬‪‍‭⁮⁪‌‭⁯⁪⁪‏‌‪⁯⁭‮​‭‏‌⁮⁯⁪‪‬​⁮⁯‮⁫⁮‪‪‫‍⁪⁬‎‮(this.u202e‭‭‮​⁬⁯‎⁫​‬‏‌⁮⁮‮⁮⁬⁭‮⁯⁯‏‬‎​‎‍‏⁭⁮‏‬‫⁪‍‬‫‪‬‮, 66);
						num = (int)(num2 * -2020569175 ^ 838304230);
						continue;
					}
					case 251:
					{
						TetraPanel.u200e‭⁭‌‪‫​⁯⁫⁫‪⁯‍⁯⁯⁭‎⁫‮⁮​​‭‎‮‍‏‎‎⁪‌⁫‬‮⁮‌⁮‏⁭⁪‮(this.u200e‎⁭‏‎‪‎‍‬⁭⁮⁬‍⁭‮​⁪‮‏‍⁪‎‫⁮‫⁭⁯⁪‌‌​‌⁬‫‏‬‍⁯⁮‭‮, true);
						TetraPanel.u202e​‍‌‌⁮⁫‫‍⁯⁯⁯⁬‫⁪‎⁪⁬‫⁮‎⁯‭​​‭‌‎​‍‮⁯⁪⁪⁪‫⁬‬‏⁫‮(this.u200e‎⁭‏‎‪‎‍‬⁭⁮⁬‍⁭‮​⁪‮‏‍⁪‎‫⁮‫⁭⁯⁪‌‌​‌⁬‫‏‬‍⁯⁮‭‮, FlatStyle.Flat);
						TetraPanel.u202b‏‏‬‎‮‫​‍​⁭‬‬‭‮⁫⁯‭⁪‬‎‫‫‎⁬‪‍‎⁪⁪‮‌‮‌‏⁯‌‍​‌‮(this.u200e‎⁭‏‎‪‎‍‬⁭⁮⁬‍⁭‮​⁪‮‏‍⁪‎‫⁮‫⁭⁯⁪‌‌​‌⁬‫‏‬‍⁯⁮‭‮, TetraPanel.u202c‫‭‪‌‌⁬‌⁬‌‪‬‏‌‍⁯⁪‮⁪‮‌‪⁪⁯‭⁮‪‪⁪‬‭​‬‭‮‍‭‌‍‮(u003cModuleu003e.u200d​‍⁮‏‭⁮⁪‌‪‬‬‬‪⁬⁭⁫⁫‬⁪⁬⁬⁬‏⁮⁭‌‍‏‍‏‎‬⁬​‪‎​‎⁭‮<string>(2136952738), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0));
						TetraPanel.u202b‎⁯‫‮⁬‏‪⁫‍⁫‭​⁭‎​‎‮⁬‍‏‏‎⁯​⁭⁫‏‫‌‌‪‪​‬⁬⁭‫⁮‮‮(this.u200e‎⁭‏‎‪‎‍‬⁭⁮⁬‍⁭‮​⁪‮‏‍⁪‎‫⁮‫⁭⁯⁪‌‌​‌⁬‫‏‬‍⁯⁮‭‮, new Point(3, 16));
						num = 310672881;
						continue;
					}
					case 252:
					{
						TetraPanel.u206e⁪‏‏​‍⁮‫⁬⁬⁯⁫⁯‏⁬⁮‫‫⁬⁬‭‫‌‌⁭‎​‭⁭‍⁬‏‏⁮‫⁮‭‮‎‪‮(this.u200c‎‎‪‎‮‎⁫‭‪⁯⁬⁪⁬‏‮‏‪‫‏⁯⁪​⁬‫⁯⁪‎‪‏‫‮⁯‏‪‭‬‏‪‮, u003cModuleu003e.u200f⁫‌​⁬‌‎‎‏‍‍⁫‎​‌‬⁯‬‫‭‎‏​‌​⁪‭‬⁬‮⁬​‌⁬⁪‫‫‎⁪⁮‮<string>(-400102573));
						num = 262046762;
						continue;
					}
					case 253:
					{
						TetraPanel.u200b⁫⁬⁯⁮⁭⁮‭‪‏‍‌​‏‪​⁪⁫‍‫⁫⁯‍​‏⁭⁪‭‫⁬‭‪‌​⁬‬​‍‍‏‮(this, u003cModuleu003e.u200f⁫‌​⁬‌‎‎‏‍‍⁫‎​‌‬⁯‬‫‭‎‏​‌​⁪‭‬⁬‮⁬​‌⁬⁪‫‫‎⁪⁮‮<string>(-1582088622));
						num = 107292224;
						continue;
					}
					case 254:
					{
						this.u206e‬​⁯⁫‍‎​‮⁬⁮‍‫‪‬‌‌‭⁯⁫‮‫‮⁭‮‫‪‫⁮‫⁪‏‏‏‫‏‭⁬⁬‍‮ = TetraPanel.u202b⁬‮‍‪‏⁬‌‭‏⁭⁮‪‌⁬⁯⁯⁮‪⁭‌‬⁪‎‮‪‭‭‪​‭‭⁭⁪⁭‪⁬⁯​‬‮();
						this.u202c⁭‎‫‮‌⁯⁮‍‎⁪⁪⁬‭⁮‏‎‌‌‎‌⁯‪‮⁯‌⁮‌‭⁯‎‍‌⁪‍‭‏⁪‬‮ = TetraPanel.u202b⁬‮‍‪‏⁬‌‭‏⁭⁮‪‌⁬⁯⁯⁮‪⁭‌‬⁪‎‮‪‭‭‪​‭‭⁭⁪⁭‪⁬⁯​‬‮();
						this.u202e‪⁬⁫⁬⁭‪‏‌‏‫‫⁬⁭‌‭‮⁭⁭‬‪⁭⁭‬‌‮⁮⁭⁫‌‬⁯⁫‪‭‎‭‎‍⁫‮ = TetraPanel.u200b‬‌⁯‫‪⁪⁯​‭‬‌‭⁯⁮⁮‏​‪‬⁯‭‪​⁫‮​‪‬‬​‌‏⁬⁪‪‏⁪‏⁬‮();
						this.u200c‫‌‪‌‌‏​⁯⁪​‫⁪⁮⁯‫‍⁪⁫⁪‮⁬⁬‭⁯‌‫⁯‫‪‏‭‏⁭⁬‌‫‬⁪⁬‮ = TetraPanel.u200b‬‌⁯‫‪⁪⁯​‭‬‌‭⁯⁮⁮‏​‪‬⁯‭‪​⁫‮​‪‬‬​‌‏⁬⁪‪‏⁪‏⁬‮();
						num = (int)(num2 * -1128812106 ^ -2049662417);
						continue;
					}
					case 255:
					{
						TetraPanel.u206b⁬‪‍‭⁮⁪‌‭⁯⁪⁪‏‌‪⁯⁭‮​‭‏‌⁮⁯⁪‪‬​⁮⁯‮⁫⁮‪‪‫‍⁪⁬‎‮(this.u206d‪⁪‌⁭‌‫⁭‌⁪​‭⁫‎‪‭‌⁬‍‎‌‮‍‌‬‍‬⁬‏⁫‏‫‏‏‎‭‬‍‪⁫‮, 54);
						TetraPanel.u206d‫‫‫⁮‮‌​‍⁫‭‎‬​⁭‬⁫‪‌‍‍‎‮⁫‬⁭⁫‫‎⁯‏‌‮‮⁬‮⁬⁪‮(this.u206d‪⁪‌⁭‌‫⁭‌⁪​‭⁫‎‪‭‌⁬‍‎‌‮‍‌‬‍‬⁬‏⁫‏‫‏‏‎‭‬‍‪⁫‮, u003cModuleu003e.u202a‮‫‏‫‬‬‪⁫⁬​‏⁫⁭‍‪‪‎⁬​‪​‌⁮‮‌​⁫​⁬‪‫⁪⁯⁪‎‫⁭‎⁪‮<string>(1670665763));
						num = 2052074396;
						continue;
					}
					case 256:
					{
						TetraPanel.u202c‬​‪‌‭‏‫⁬‪‭‮⁬⁪⁯⁪⁭‎‭​‪‭⁯‏⁪​⁫‪⁬‌‏⁯⁪‫‬‬⁪⁮⁭‍‮(this.u206e⁬‬‭⁫‏⁪⁬⁬⁪⁬‏⁬⁯‍‌⁮‮⁪⁬‍⁭⁯⁮‭‌‏⁬⁭‍‎‌⁭​‬⁯‏⁮‌‍‮, true);
						num = (int)(num2 * -1431008249 ^ 521654514);
						continue;
					}
					case 257:
					{
						TetraPanel.u202c⁭⁫‪‏⁬⁭⁭​​⁪⁫‬‍⁪⁫⁭⁬‮‌⁭‫‮‭​⁫‌⁪‎‏⁪‫‮‌​‌‍⁮⁮⁮‮(this.u200e​⁭⁯​‏‏‎‭⁮‍‮⁬‪‮‪⁮‫⁭‏‍⁬‍‎‏‪‫‪‮⁪‍⁫‮‍⁪‬‏‭‮‏‮, new System.Drawing.Size(13, 13));
						TetraPanel.u206b⁬‪‍‭⁮⁪‌‭⁯⁪⁪‏‌‪⁯⁭‮​‭‏‌⁮⁯⁪‪‬​⁮⁯‮⁫⁮‪‪‫‍⁪⁬‎‮(this.u200e​⁭⁯​‏‏‎‭⁮‍‮⁬‪‮‪⁮‫⁭‏‍⁬‍‎‏‪‫‪‮⁪‍⁫‮‍⁪‬‏‭‮‏‮, 62);
						num = (int)(num2 * -445417708 ^ 488232417);
						continue;
					}
					case 258:
					{
						TetraPanel.u206b⁬‪‍‭⁮⁪‌‭⁯⁪⁪‏‌‪⁯⁭‮​‭‏‌⁮⁯⁪‪‬​⁮⁯‮⁫⁮‪‪‫‍⁪⁬‎‮(this.u202b‫‌‍⁭‎‮⁮‍‮‎‏⁮‭‌⁭⁫‮⁮‭‎‏⁮⁮‌‌‫‬‪⁬⁬‏‌‭‌‫‌‭‭⁭‮, 72);
						num = (int)(num2 * 291365181 ^ 1982291846);
						continue;
					}
					case 259:
					{
						TetraPanel.u206d‫‫‫⁮‮‌​‍⁫‭‎‬​⁭‬⁫‪‌‍‍‎‮⁫‬⁭⁫‫‎⁯‏‌‮‮⁬‮⁬⁪‮(this.u202a‪‬⁭‮⁬⁫‫⁬‮‏‪‪‭‎‌‫‪‍⁭‏⁮⁬‭⁪⁯‍‍⁭‪‏‫‮​⁪⁭⁪‪‬‮, u003cModuleu003e.u200d​‍⁮‏‭⁮⁪‌‪‬‬‬‪⁬⁭⁫⁫‬⁪⁬⁬⁬‏⁮⁭‌‍‏‍‏‎‬⁬​‪‎​‎⁭‮<string>(369295615));
						TetraPanel.u200e‭⁭‌‪‫​⁯⁫⁫‪⁯‍⁯⁯⁭‎⁫‮⁮​​‭‎‮‍‏‎‎⁪‌⁫‬‮⁮‌⁮‏⁭⁪‮(this.u202b⁪⁭‍‎⁭‮⁮‭⁮⁪‬⁯⁭‎‌⁫‮‮⁪‍⁯‎‍‫⁫‪‪‎‪‬‍‎‮‍⁭‍⁭‎⁬‮, true);
						TetraPanel.u202b‏‏‬‎‮‫​‍​⁭‬‬‭‮⁫⁯‭⁪‬‎‫‫‎⁬‪‍‎⁪⁪‮‌‮‌‏⁯‌‍​‌‮(this.u202b⁪⁭‍‎⁭‮⁮‭⁮⁪‬⁯⁭‎‌⁫‮‮⁪‍⁯‎‍‫⁫‪‪‎‪‬‍‎‮‍⁭‍⁭‎⁬‮, TetraPanel.u202c‫‭‪‌‌⁬‌⁬‌‪‬‏‌‍⁯⁪‮⁪‮‌‪⁪⁯‭⁮‪‪⁪‬‭​‬‭‮‍‭‌‍‮(u003cModuleu003e.u202a‮‫‏‫‬‬‪⁫⁬​‏⁫⁭‍‪‪‎⁬​‪​‌⁮‮‌​⁫​⁬‪‫⁪⁯⁪‎‫⁭‎⁪‮<string>(1627927687), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0));
						TetraPanel.u202b‎⁯‫‮⁬‏‪⁫‍⁫‭​⁭‎​‎‮⁬‍‏‏‎⁯​⁭⁫‏‫‌‌‪‪​‬⁬⁭‫⁮‮‮(this.u202b⁪⁭‍‎⁭‮⁮‭⁮⁪‬⁯⁭‎‌⁫‮‮⁪‍⁯‎‍‫⁫‪‪‎‪‬‍‎‮‍⁭‍⁭‎⁬‮, new Point(2, 469));
						TetraPanel.u206e⁪‏‏​‍⁮‫⁬⁬⁯⁫⁯‏⁬⁮‫‫⁬⁬‭‫‌‌⁭‎​‭⁭‍⁬‏‏⁮‫⁮‭‮‎‪‮(this.u202b⁪⁭‍‎⁭‮⁮‭⁮⁪‬⁯⁭‎‌⁫‮‮⁪‍⁯‎‍‫⁫‪‪‎‪‬‍‎‮‍⁭‍⁭‎⁬‮, u003cModuleu003e.u200f⁫‌​⁬‌‎‎‏‍‍⁫‎​‌‬⁯‬‫‭‎‏​‌​⁪‭‬⁬‮⁬​‌⁬⁪‫‫‎⁪⁮‮<string>(908721475));
						TetraPanel.u202c⁭⁫‪‏⁬⁭⁭​​⁪⁫‬‍⁪⁫⁭⁬‮‌⁭‫‮‭​⁫‌⁪‎‏⁪‫‮‌​‌‍⁮⁮⁮‮(this.u202b⁪⁭‍‎⁭‮⁮‭⁮⁪‬⁯⁭‎‌⁫‮‮⁪‍⁯‎‍‫⁫‪‪‎‪‬‍‎‮‍⁭‍⁭‎⁬‮, new System.Drawing.Size(62, 13));
						TetraPanel.u206b⁬‪‍‭⁮⁪‌‭⁯⁪⁪‏‌‪⁯⁭‮​‭‏‌⁮⁯⁪‪‬​⁮⁯‮⁫⁮‪‪‫‍⁪⁬‎‮(this.u202b⁪⁭‍‎⁭‮⁮‭⁮⁪‬⁯⁭‎‌⁫‮‮⁪‍⁯‎‍‫⁫‪‪‎‪‬‍‎‮‍⁭‍⁭‎⁬‮, 80);
						num = 162263338;
						continue;
					}
					case 260:
					{
						this.u202a⁫⁫⁪‎⁯⁭‬‬⁬​‮‍⁭‮‌⁭‌‏‎‭‫‌‏‏⁫⁬‮⁬‌⁭​⁫⁯‫⁮⁭‬‏‏‮ = TetraPanel.u200b‬‌⁯‫‪⁪⁯​‭‬‌‭⁯⁮⁮‏​‪‬⁯‭‪​⁫‮​‪‬‬​‌‏⁬⁪‪‏⁪‏⁬‮();
						this.u200e‮⁯​⁬⁫‍⁭⁯⁪‪⁫‭⁯‬⁭‫‭⁭⁫‮⁮‏⁫‮‫‭‍‫​⁭‏⁮⁯‎‭⁯‫⁯⁮‮ = TetraPanel.u200e​‏⁯‍‫‍⁪‌‪‮‫⁫‮‏‎‪‪⁪‍‍‏​⁯‎‪⁫‮⁯⁮⁯⁭‫‭⁯‌​‮⁫⁭‮();
						this.u206c‍‍‌‬‪‮‪‮⁪‎⁬‍‭⁪‫‌‬‪⁫‫‫‫‪⁮‮‬⁮⁬⁪‫⁭‫‌⁪‮‪⁭⁭⁮‮ = TetraPanel.u200b‬‌⁯‫‪⁪⁯​‭‬‌‭⁯⁮⁮‏​‪‬⁯‭‪​⁫‮​‪‬‬​‌‏⁬⁪‪‏⁪‏⁬‮();
						num = (int)(num2 * -1862996015 ^ -141848714);
						continue;
					}
					case 261:
					{
						TetraPanel.u202c‬​‪‌‭‏‫⁬‪‭‮⁬⁪⁯⁪⁭‎‭​‪‭⁯‏⁪​⁫‪⁬‌‏⁯⁪‫‬‬⁪⁮⁭‍‮(this.u202e⁪‍‍⁫⁪‪‍‌‏⁪⁪⁫⁪‎‮‭‌⁭‬‪⁮​‭⁯⁯‌‮⁪⁬‮⁬⁬​‮‏⁯⁯‌‏‮, true);
						num = (int)(num2 * 849005904 ^ -670673617);
						continue;
					}
					case 262:
					{
						TetraPanel.u200e​⁮⁯‮⁭‬‭⁫⁭⁬‌‭‎⁬⁬⁮⁬‭‬⁮‭‏⁫‫​‮‌‬⁪​‮⁮‪‪⁭‮⁪‍⁮‮(this.u206b⁭‍‏⁮‪‎‪‎⁬‌⁪⁬⁯‎‬⁫⁬‭⁪⁯‍⁭⁮‪‍⁬‬⁭‮‭⁯​‏‪⁮​​‎⁭‮, AnchorStyles.Top | AnchorStyles.Right);
						num = (int)(num2 * 1121159559 ^ -2012192335);
						continue;
					}
					case 263:
					{
						TetraPanel.u202c⁭⁫‪‏⁬⁭⁭​​⁪⁫‬‍⁪⁫⁭⁬‮‌⁭‫‮‭​⁫‌⁪‎‏⁪‫‮‌​‌‍⁮⁮⁮‮(this.u200c⁭‫‪⁮⁪⁬‭⁬⁮‌⁬⁭‌‍‎⁫‮‭‍⁮‬‮⁫‫⁮⁬‮‬⁬‭⁯⁫‍‪⁪⁯‏​⁭‮, new System.Drawing.Size(31, 13));
						TetraPanel.u206b⁬‪‍‭⁮⁪‌‭⁯⁪⁪‏‌‪⁯⁭‮​‭‏‌⁮⁯⁪‪‬​⁮⁯‮⁫⁮‪‪‫‍⁪⁬‎‮(this.u200c⁭‫‪⁮⁪⁬‭⁬⁮‌⁬⁭‌‍‎⁫‮‭‍⁮‬‮⁫‫⁮⁬‮‬⁬‭⁯⁫‍‪⁪⁯‏​⁭‮, 65);
						num = (int)(num2 * 788832374 ^ -723922663);
						continue;
					}
					case 264:
					{
						TetraPanel.u206d‫‫‫⁮‮‌​‍⁫‭‎‬​⁭‬⁫‪‌‍‍‎‮⁫‬⁭⁫‫‎⁯‏‌‮‮⁬‮⁬⁪‮(this.u200d‮⁪⁭⁭‍⁯‮‭‏‏⁭‬‫⁮⁯‬⁫‬‪⁫‎⁭‭​⁫‪⁬⁮⁫‍⁭​⁭‌⁪​⁪‭⁯‮, u003cModuleu003e.u200f⁫‌​⁬‌‎‎‏‍‍⁫‎​‌‬⁯‬‫‭‎‏​‌​⁪‭‬⁬‮⁬​‌⁬⁪‫‫‎⁪⁮‮<string>(278620280));
						TetraPanel.u206f‮⁫⁯⁪‌‏⁭‏‌⁫⁯⁬‬⁭⁬⁬⁯⁮⁭⁮‮⁯⁯‬⁭⁬‏‌⁭⁬⁯⁪‫‮​‮‍⁫‍‮(this.u200d‮⁪⁭⁭‍⁯‮‭‏‏⁭‬‫⁮⁯‬⁫‬‪⁫‎⁭‭​⁫‪⁬⁮⁫‍⁭​⁭‌⁪​⁪‭⁯‮, new PaintEventHandler(this.u206c‌‫‫‭‮‌⁪‫‏⁫‮⁮‫‭⁯⁮⁪‏⁯‌‎⁬⁫⁪⁭‮‮⁪⁪⁮⁬‏‭⁬‎⁫⁯‬⁯‮));
						num = 183246965;
						continue;
					}
					case 265:
					{
						TetraPanel.u202b‎⁯‫‮⁬‏‪⁫‍⁫‭​⁭‎​‎‮⁬‍‏‏‎⁯​⁭⁫‏‫‌‌‪‪​‬⁬⁭‫⁮‮‮(this.u200b‏⁭⁯⁮⁬‭‮⁭⁯‮​‏‭⁬⁮‫⁬⁬‬‮‏‏‎‮⁫⁬⁭⁮​​⁮⁪⁭⁭​‫‫‮, new Point(3, 86));
						num = (int)(num2 * -1320284856 ^ -157853210);
						continue;
					}
					case 266:
					{
						TetraPanel.u206d‫‫‫⁮‮‌​‍⁫‭‎‬​⁭‬⁫‪‌‍‍‎‮⁫‬⁭⁫‫‎⁯‏‌‮‮⁬‮⁬⁪‮(this.u206e‬​⁯⁫‍‎​‮⁬⁮‍‫‪‬‌‌‭⁯⁫‮‫‮⁭‮‫‪‫⁮‫⁪‏‏‏‫‏‭⁬⁬‍‮, u003cModuleu003e.u206f⁮​‌‪‮‎‭‏‮‎⁮⁮‮⁬⁫‍‍⁪‍⁫⁮‏​‎⁬⁯⁪‪‍⁪⁮‎⁬⁪⁫​⁮⁪⁮‮<string>(2111630467));
						TetraPanel.u200c‬‌‏⁬⁬‍⁫​⁮‮‏⁪⁪‪‪⁪⁮⁮⁫⁯⁮‭‌⁫‫‌‫‫‫⁭⁬‪‎‭⁪‍⁮‏‏‮(this.u206e‬​⁯⁫‍‎​‮⁬⁮‍‫‪‬‌‌‭⁯⁫‮‫‮⁭‮‫‪‫⁮‫⁪‏‏‏‫‏‭⁬⁬‍‮, TextImageRelation.TextAboveImage);
						num = 479462589;
						continue;
					}
					case 267:
					{
						TetraPanel.u202b‎⁯‫‮⁬‏‪⁫‍⁫‭​⁭‎​‎‮⁬‍‏‏‎⁯​⁭⁫‏‫‌‌‪‪​‬⁬⁭‫⁮‮‮(this.u206c‫‍⁯⁫⁬⁬‎‮‎‭‎⁭⁪‍‏⁯‬​⁪‪⁯⁪​⁪‪‫‏⁮‏‍⁮⁮‫​‭⁬⁪⁮‍‮, new Point(149, 1));
						TetraPanel.u206e⁪‏‏​‍⁮‫⁬⁬⁯⁫⁯‏⁬⁮‫‫⁬⁬‭‫‌‌⁭‎​‭⁭‍⁬‏‏⁮‫⁮‭‮‎‪‮(this.u206c‫‍⁯⁫⁬⁬‎‮‎‭‎⁭⁪‍‏⁯‬​⁪‪⁯⁪​⁪‪‫‏⁮‏‍⁮⁮‫​‭⁬⁪⁮‍‮, u003cModuleu003e.u206f⁮​‌‪‮‎‭‏‮‎⁮⁮‮⁬⁫‍‍⁪‍⁫⁮‏​‎⁬⁯⁪‪‍⁪⁮‎⁬⁪⁫​⁮⁪⁮‮<string>(-2126811451));
						TetraPanel.u202c⁭⁫‪‏⁬⁭⁭​​⁪⁫‬‍⁪⁫⁭⁬‮‌⁭‫‮‭​⁫‌⁪‎‏⁪‫‮‌​‌‍⁮⁮⁮‮(this.u206c‫‍⁯⁫⁬⁬‎‮‎‭‎⁭⁪‍‏⁯‬​⁪‪⁯⁪​⁪‪‫‏⁮‏‍⁮⁮‫​‭⁬⁪⁮‍‮, new System.Drawing.Size(53, 13));
						num = 1087569067;
						continue;
					}
					case 268:
					{
						TetraPanel.u206d‫‫‫⁮‮‌​‍⁫‭‎‬​⁭‬⁫‪‌‍‍‎‮⁫‬⁭⁫‫‎⁯‏‌‮‮⁬‮⁬⁪‮(this.u200f‫‮⁭⁭‬‌‪⁭‭‭‬⁮‪‮⁬⁬​⁮⁫‍⁮‍​⁮‫‪‮‎⁪⁬‎⁮⁭⁯⁯⁮‮‪⁭‮, u003cModuleu003e.u200e‏‌‬⁮‪‭⁭‭⁭‎​‏‌‭‭‭⁭⁬⁯⁫‍‮‫⁯‌‮‏​‬⁫⁯⁮⁫‮‪⁫‬⁮⁬‮<string>(-357250622));
						TetraPanel.u200c‏⁫‬‭‌‪⁮‬⁮‏‪⁭‍‪⁯‫⁬⁫⁭‭‮‬‬⁪⁫‏⁭‏⁮⁫​⁫⁬‪‌‫⁭‭‍‮(this.u200f‫‮⁭⁭‬‌‪⁭‭‭‬⁮‪‮⁬⁬​⁮⁫‍⁮‍​⁮‫‪‮‎⁪⁬‎⁮⁭⁯⁯⁮‮‪⁭‮, true);
						TetraPanel.u202e⁯‮​‏‬⁭‬⁯⁯⁭‎⁯‮‎​‮⁪⁮‭‌⁮⁭‬‫⁭⁭‮‮⁯‪‫⁭⁬‌⁭‬‏⁬‬‮(this.u200f‫‮⁭⁭‬‌‪⁭‭‭‬⁮‪‮⁬⁬​⁮⁫‍⁮‍​⁮‫‪‮‎⁪⁬‎⁮⁭⁯⁯⁮‮‪⁭‮, new EventHandler(this.u200c‮⁫⁭⁬⁬‮‬‌‮‬⁮‪‭‮‫‏⁬‍‏⁬‎⁮⁭‍⁬‮‪⁭⁫‫‮‭‍‎‭⁫‬​⁯‮));
						TetraPanel.u200e‭⁭‌‪‫​⁯⁫⁫‪⁯‍⁯⁯⁭‎⁫‮⁮​​‭‎‮‍‏‎‎⁪‌⁫‬‮⁮‌⁮‏⁭⁪‮(this.u206d‏‪‫‍⁪‪⁬‌⁪‌‪‭⁫‫‎‍⁯‎‬‭⁪⁯​⁪⁮‬​‌​‎‌⁪‭⁮‏‌‫‫⁯‮, true);
						TetraPanel.u202b‏‏‬‎‮‫​‍​⁭‬‬‭‮⁫⁯‭⁪‬‎‫‫‎⁬‪‍‎⁪⁪‮‌‮‌‏⁯‌‍​‌‮(this.u206d‏‪‫‍⁪‪⁬‌⁪‌‪‭⁫‫‎‍⁯‎‬‭⁪⁯​⁪⁮‬​‌​‎‌⁪‭⁮‏‌‫‫⁯‮, TetraPanel.u202c‫‭‪‌‌⁬‌⁬‌‪‬‏‌‍⁯⁪‮⁪‮‌‪⁪⁯‭⁮‪‪⁪‬‭​‬‭‮‍‭‌‍‮(u003cModuleu003e.u200d​‍⁮‏‭⁮⁪‌‪‬‬‬‪⁬⁭⁫⁫‬⁪⁬⁬⁬‏⁮⁭‌‍‏‍‏‎‬⁬​‪‎​‎⁭‮<string>(2136952738), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0));
						TetraPanel.u202b‎⁯‫‮⁬‏‪⁫‍⁫‭​⁭‎​‎‮⁬‍‏‏‎⁯​⁭⁫‏‫‌‌‪‪​‬⁬⁭‫⁮‮‮(this.u206d‏‪‫‍⁪‪⁬‌⁪‌‪‭⁫‫‎‍⁯‎‬‭⁪⁯​⁪⁮‬​‌​‎‌⁪‭⁮‏‌‫‫⁯‮, new Point(3, 35));
						num = 509687762;
						continue;
					}
					case 269:
					{
						TetraPanel.u202e⁯‮​‏‬⁭‬⁯⁯⁭‎⁯‮‎​‮⁪⁮‭‌⁮⁭‬‫⁭⁭‮‮⁯‪‫⁭⁬‌⁭‬‏⁬‬‮(this.u202e⁮‍‍⁮‎⁪⁫⁫‍‮‭‬‍⁪‪‮⁭‬⁫⁯‪⁯​⁪‬‫​⁬‭‭⁯‫‎⁮‏​​‬‎‮, new EventHandler(this.u200d‭‍⁪⁮‮‮⁬‭⁭⁪‌‮‎⁪⁮⁪‮⁫⁬⁬​⁬⁭⁫‌⁮‍⁮​‫⁫‭‭‫‏‬‎⁫‮‮));
						num = (int)(num2 * 2085238349 ^ -49977914);
						continue;
					}
					case 270:
					{
						TetraPanel.u202b‪​⁯⁪⁬⁬‭‍⁪‫‪​‮‍‭‎‍⁯‫‭⁮‭​⁯​‍⁬‌‭‭⁯⁭‭‬‍‭‎‎⁭‮(this.u206e⁭‫‬‫⁪‭‍‏⁫⁭​​‏‌‭⁭⁫‏⁮⁪‏‎‫⁯‭⁯‍⁮​‫‫⁪⁮⁫‎‬‫‌⁯‮, 1);
						num = (int)(num2 * 931792803 ^ 600933467);
						continue;
					}
					case 271:
					{
						TetraPanel.u202d‏⁭⁫‮‫​‎‪⁫⁯‏⁮‫​‮‌⁮‬⁬‌⁮⁬‏⁭‏⁮‌⁮‮⁮‭‌‫‏⁪‎⁮‏‎‮(TetraPanel.u206a‬⁯⁭⁫‍⁪‫⁬⁭⁬⁮‫‏‍⁫‫‌⁪‪‌​⁭⁮‍‌‬⁯‭⁪‭⁮‏⁮‪​‍⁭⁫⁫‮(this.u200d‮⁪⁭⁭‍⁯‮‭‏‏⁭‬‫⁮⁯‬⁫‬‪⁫‎⁭‭​⁫‪⁬⁮⁫‍⁭​⁭‌⁪​⁪‭⁯‮), this.u200c‎‎‪‎‮‎⁫‭‪⁯⁬⁪⁬‏‮‏‪‫‏⁯⁪​⁬‫⁯⁪‎‪‏‫‮⁯‏‪‭‬‏‪‮);
						num = (int)(num2 * -1339617270 ^ 722932584);
						continue;
					}
					case 272:
					{
						TetraPanel.u206e⁪‏‏​‍⁮‫⁬⁬⁯⁫⁯‏⁬⁮‫‫⁬⁬‭‫‌‌⁭‎​‭⁭‍⁬‏‏⁮‫⁮‭‮‎‪‮(this.u200c‎‏⁪⁭⁬⁫‎⁭‪⁫⁫‮​⁯‫‪‏‮‮‬‬⁬‍⁭⁯‪⁪⁫⁬‬⁫‬‍⁮‍⁭‪‭⁪‮, u003cModuleu003e.u200e‏‌‬⁮‪‭⁭‭⁭‎​‏‌‭‭‭⁭⁬⁯⁫‍‮‫⁯‌‮‏​‬⁫⁯⁮⁫‮‪⁫‬⁮⁬‮<string>(1264064452));
						num = 31975572;
						continue;
					}
					case 273:
					{
						TetraPanel.u206b⁬‪‍‭⁮⁪‌‭⁯⁪⁪‏‌‪⁯⁭‮​‭‏‌⁮⁯⁪‪‬​⁮⁯‮⁫⁮‪‪‫‍⁪⁬‎‮(this.u200f‍‮‏‌‏‌‍‍⁪⁫⁯⁭‫⁮⁫‫⁯‏‫⁪‍‫⁮‮⁪⁫‍‭‍⁫‏‍⁫‍‌⁪⁫⁪⁭‮, 78);
						num = (int)(num2 * -1426719030 ^ 974255789);
						continue;
					}
					case 274:
					{
						TetraPanel.u202c⁭⁫‪‏⁬⁭⁭​​⁪⁫‬‍⁪⁫⁭⁬‮‌⁭‫‮‭​⁫‌⁪‎‏⁪‫‮‌​‌‍⁮⁮⁮‮(this.u206c‮⁫⁫⁭⁬‍‮​‮⁭⁭⁭⁭⁪‪‪⁬‬⁫⁮‌​‎⁬‭‫‏‏⁮‍‍​⁯‎⁬‪⁬‏⁫‮, new System.Drawing.Size(13, 13));
						TetraPanel.u206b⁬‪‍‭⁮⁪‌‭⁯⁪⁪‏‌‪⁯⁭‮​‭‏‌⁮⁯⁪‪‬​⁮⁯‮⁫⁮‪‪‫‍⁪⁬‎‮(this.u206c‮⁫⁫⁭⁬‍‮​‮⁭⁭⁭⁭⁪‪‪⁬‬⁫⁮‌​‎⁬‭‫‏‏⁮‍‍​⁯‎⁬‪⁬‏⁫‮, 67);
						TetraPanel.u206d‫‫‫⁮‮‌​‍⁫‭‎‬​⁭‬⁫‪‌‍‍‎‮⁫‬⁭⁫‫‎⁯‏‌‮‮⁬‮⁬⁪‮(this.u206c‮⁫⁫⁭⁬‍‮​‮⁭⁭⁭⁭⁪‪‪⁬‬⁫⁮‌​‎⁬‭‫‏‏⁮‍‍​⁯‎⁬‪⁬‏⁫‮, u003cModuleu003e.u206f⁮​‌‪‮‎‭‏‮‎⁮⁮‮⁬⁫‍‍⁪‍⁫⁮‏​‎⁬⁯⁪‪‍⁪⁮‎⁬⁪⁫​⁮⁪⁮‮<string>(445359012));
						num = 204081654;
						continue;
					}
					case 275:
					{
						TetraPanel.u202d‏⁭⁫‮‫​‎‪⁫⁯‏⁮‫​‮‌⁮‬⁬‌⁮⁬‏⁭‏⁮‌⁮‮⁮‭‌‫‏⁪‎⁮‏‎‮(TetraPanel.u206a‬⁯⁭⁫‍⁪‫⁬⁭⁬⁮‫‏‍⁫‫‌⁪‪‌​⁭⁮‍‌‬⁯‭⁪‭⁮‏⁮‪​‍⁭⁫⁫‮(this.u206a⁭‫⁬⁯‌‎⁯‬‍​‏‎‌‏⁯‏⁮‬⁯⁮‎⁯⁬‌‪⁯⁬⁭⁬​‭​‌​‎⁫⁪‭‍‮), this.u200d⁪‮‬⁭​​⁫⁪⁯⁫‬‏⁮⁭​‭‬‏‏⁭⁯‫‌‮‎⁫⁫‏‮⁮⁬⁫‮⁮⁪⁯‭‎‫‮);
						num = (int)(num2 * 1667065017 ^ 995655222);
						continue;
					}
					case 276:
					{
						TetraPanel.u200e​⁮⁯‮⁭‬‭⁫⁭⁬‌‭‎⁬⁬⁮⁬‭‬⁮‭‏⁫‫​‮‌‬⁪​‮⁮‪‪⁭‮⁪‍⁮‮(this.u206a⁭‫⁬⁯‌‎⁯‬‍​‏‎‌‏⁯‏⁮‬⁯⁮‎⁯⁬‌‪⁯⁬⁭⁬​‭​‌​‎⁫⁪‭‍‮, AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
						num = (int)(num2 * 1670326276 ^ -1593120233);
						continue;
					}
					case 277:
					{
						TetraPanel.u206b⁬‪‍‭⁮⁪‌‭⁯⁪⁪‏‌‪⁯⁭‮​‭‏‌⁮⁯⁪‪‬​⁮⁯‮⁫⁮‪‪‫‍⁪⁬‎‮(this.u206e‬​⁯⁫‍‎​‮⁬⁮‍‫‪‬‌‌‭⁯⁫‮‫‮⁭‮‫‪‫⁮‫⁪‏‏‏‫‏‭⁬⁬‍‮, 84);
						num = (int)(num2 * 1583920830 ^ 606983908);
						continue;
					}
					case 278:
					{
						TetraPanel.u206f⁬‏⁫‍‫⁯‍⁫‎‪‭‬⁭⁫‍⁯​‍‫‏‏‫⁯‪‍⁬‬‏‪⁫⁬‌‮‎⁭‌⁫⁮⁪‮(this.u200d‌‏‪‍‭⁯‎⁫⁪⁮⁮‍‮⁪⁫⁮⁬‎⁭⁫⁬‭‎⁯‪‍‏‌⁭⁯⁯‬‫‌‭⁮‬‭⁭‮, Color.Black);
						num = (int)(num2 * -211353239 ^ 177044159);
						continue;
					}
					case 279:
					{
						TetraPanel.u200e‭⁭‌‪‫​⁯⁫⁫‪⁯‍⁯⁯⁭‎⁫‮⁮​​‭‎‮‍‏‎‎⁪‌⁫‬‮⁮‌⁮‏⁭⁪‮(this.u206e‬‮​⁮‌⁭​‍‍⁪‌‏‭‬‏‎⁪⁬‫‬⁬⁪‍‌‪​‭⁬⁫⁬‪‭⁬⁪​⁪⁪​⁪‮, true);
						TetraPanel.u202b‏‏‬‎‮‫​‍​⁭‬‬‭‮⁫⁯‭⁪‬‎‫‫‎⁬‪‍‎⁪⁪‮‌‮‌‏⁯‌‍​‌‮(this.u206e‬‮​⁮‌⁭​‍‍⁪‌‏‭‬‏‎⁪⁬‫‬⁬⁪‍‌‪​‭⁬⁫⁬‪‭⁬⁪​⁪⁪​⁪‮, TetraPanel.u202c‫‭‪‌‌⁬‌⁬‌‪‬‏‌‍⁯⁪‮⁪‮‌‪⁪⁯‭⁮‪‪⁪‬‭​‬‭‮‍‭‌‍‮(u003cModuleu003e.u200d​‍⁮‏‭⁮⁪‌‪‬‬‬‪⁬⁭⁫⁫‬⁪⁬⁬⁬‏⁮⁭‌‍‏‍‏‎‬⁬​‪‎​‎⁭‮<string>(2136952738), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0));
						num = 818498310;
						continue;
					}
					case 280:
					{
						TetraPanel.u206e⁪‏‏​‍⁮‫⁬⁬⁯⁫⁯‏⁬⁮‫‫⁬⁬‭‫‌‌⁭‎​‭⁭‍⁬‏‏⁮‫⁮‭‮‎‪‮(this.u206a‎‪⁮​‮⁭‭⁪‎⁪‏‌‎‌‎⁮⁫‬‭‍⁭⁭‫‏⁫​‬‪⁪‮⁮‏‏⁭⁬‌⁪⁯‭‮, u003cModuleu003e.u200e‏‌‬⁮‪‭⁭‭⁭‎​‏‌‭‭‭⁭⁬⁯⁫‍‮‫⁯‌‮‏​‬⁫⁯⁮⁫‮‪⁫‬⁮⁬‮<string>(-1029675528));
						TetraPanel.u202c⁭⁫‪‏⁬⁭⁭​​⁪⁫‬‍⁪⁫⁭⁬‮‌⁭‫‮‭​⁫‌⁪‎‏⁪‫‮‌​‌‍⁮⁮⁮‮(this.u206a‎‪⁮​‮⁭‭⁪‎⁪‏‌‎‌‎⁮⁫‬‭‍⁭⁭‫‏⁫​‬‪⁪‮⁮‏‏⁭⁬‌⁪⁯‭‮, new System.Drawing.Size(209, 171));
						num = 669464307;
						continue;
					}
					case 281:
					{
						TetraPanel.u206d‫‫‫⁮‮‌​‍⁫‭‎‬​⁭‬⁫‪‌‍‍‎‮⁫‬⁭⁫‫‎⁯‏‌‮‮⁬‮⁬⁪‮(this.u200b‏⁭⁯⁮⁬‭‮⁭⁯‮​‏‭⁬⁮‫⁬⁬‬‮‏‏‎‮⁫⁬⁭⁮​​⁮⁪⁭⁭​‫‫‮, u003cModuleu003e.u200e‏‌‬⁮‪‭⁭‭⁭‎​‏‌‭‭‭⁭⁬⁯⁫‍‮‫⁯‌‮‏​‬⁫⁯⁮⁫‮‪⁫‬⁮⁬‮<string>(-851314624));
						num = 1103154065;
						continue;
					}
					case 282:
					{
						this.u202a‪⁮​‏‫‮‫⁭⁯⁭‬⁯‎‭​‎⁬‭⁬‬‬‬‌⁪‍⁪​‎‍⁯​‍⁯⁫‎‍⁪‎‭‮ = TetraPanel.u202a⁪⁭⁬​‍⁮⁪‮⁬‍‌⁮‍⁯‮⁫‪⁪‏⁪‍⁮‮⁬​‏‮⁪⁬⁯‌‏​‭⁭‫‭⁬‮‮();
						num = (int)(num2 * 92581844 ^ 34231417);
						continue;
					}
					case 283:
					{
						TetraPanel.u200e​⁮⁯‮⁭‬‭⁫⁭⁬‌‭‎⁬⁬⁮⁬‭‬⁮‭‏⁫‫​‮‌‬⁪​‮⁮‪‪⁭‮⁪‍⁮‮(this.u206e‬​⁯⁫‍‎​‮⁬⁮‍‫‪‬‌‌‭⁯⁫‮‫‮⁭‮‫‪‫⁮‫⁪‏‏‏‫‏‭⁬⁬‍‮, AnchorStyles.Top | AnchorStyles.Right);
						num = (int)(num2 * -896535890 ^ 73744632);
						continue;
					}
					case 284:
					{
						TetraPanel.u202a‭‮⁬⁪⁯⁫‎⁬⁭‏⁯⁫⁪​⁭‏‏⁫‫⁯‍‮‫⁮‮​‍‮‪‫⁫​⁭‏⁮​⁭⁯‪‮(this.u200f‍‮‏‌‏‌‍‍⁪⁫⁯⁭‫⁮⁫‫⁯‏‫⁪‍‫⁮‮⁪⁫‍‭‍⁫‏‍⁫‍‌⁪⁫⁪⁭‮, new decimal(new int[] { 11, 0, 0, 0 }));
						TetraPanel.u206e⁪‏‏​‍⁮‫⁬⁬⁯⁫⁯‏⁬⁮‫‫⁬⁬‭‫‌‌⁭‎​‭⁭‍⁬‏‏⁮‫⁮‭‮‎‪‮(this.u200f‍‮‏‌‏‌‍‍⁪⁫⁯⁭‫⁮⁫‫⁯‏‫⁪‍‫⁮‮⁪⁫‍‭‍⁫‏‍⁫‍‌⁪⁫⁪⁭‮, u003cModuleu003e.u206f⁮​‌‪‮‎‭‏‮‎⁮⁮‮⁬⁫‍‍⁪‍⁫⁮‏​‎⁬⁯⁪‪‍⁪⁮‎⁬⁪⁫​⁮⁪⁮‮<string>(-1943697053));
						num = 73737924;
						continue;
					}
					case 285:
					{
						TetraPanel.u202c⁭⁫‪‏⁬⁭⁭​​⁪⁫‬‍⁪⁫⁭⁬‮‌⁭‫‮‭​⁫‌⁪‎‏⁪‫‮‌​‌‍⁮⁮⁮‮(this.u200e⁫​‭⁪‫‏‬‮⁭⁬‌‏⁮⁮​‍‍‎‍‭‍‎​‪‪‭⁪‏‎⁬‎‍‫‮​⁬⁮⁯‫‮, new System.Drawing.Size(226, 530));
						TetraPanel.u206b⁬‪‍‭⁮⁪‌‭⁯⁪⁪‏‌‪⁯⁭‮​‭‏‌⁮⁯⁪‪‬​⁮⁯‮⁫⁮‪‪‫‍⁪⁬‎‮(this.u200e⁫​‭⁪‫‏‬‮⁭⁬‌‏⁮⁮​‍‍‎‍‭‍‎​‪‪‭⁪‏‎⁬‎‍‫‮​⁬⁮⁯‫‮, 0);
						num = (int)(num2 * 18418913 ^ 1616027705);
						continue;
					}
					case 286:
					{
						TetraPanel.u200e‭⁭‌‪‫​⁯⁫⁫‪⁯‍⁯⁯⁭‎⁫‮⁮​​‭‎‮‍‏‎‎⁪‌⁫‬‮⁮‌⁮‏⁭⁪‮(this.u200d‌‎‪⁯⁯⁫‭‬‬‭‎​‍‮⁯‮‌‬‪‭​⁮⁭⁬‏‏‫⁪‏⁭⁬‏⁮⁮‬⁯‏‭‍‮, true);
						num = (int)(num2 * 1367485998 ^ -1898712032);
						continue;
					}
					case 287:
					{
						TetraPanel.u206b⁬‪‍‭⁮⁪‌‭⁯⁪⁪‏‌‪⁯⁭‮​‭‏‌⁮⁯⁪‪‬​⁮⁯‮⁫⁮‪‪‫‍⁪⁬‎‮(this.u202a‌⁯‌⁮‍‎‏⁭‌‮‭‌‏‎⁬⁯⁭‌‎⁪‪⁪‎⁪‏⁯⁪⁯​‪⁭‭‫⁬​⁭⁯⁯⁬‮, 63);
						TetraPanel.u206d‫‫‫⁮‮‌​‍⁫‭‎‬​⁭‬⁫‪‌‍‍‎‮⁫‬⁭⁫‫‎⁯‏‌‮‮⁬‮⁬⁪‮(this.u202a‌⁯‌⁮‍‎‏⁭‌‮‭‌‏‎⁬⁯⁭‌‎⁪‪⁪‎⁪‏⁯⁪⁯​‪⁭‭‫⁬​⁭⁯⁯⁬‮, u003cModuleu003e.u202a‮‫‏‫‬‬‪⁫⁬​‏⁫⁭‍‪‪‎⁬​‪​‌⁮‮‌​⁫​⁬‪‫⁪⁯⁪‎‫⁭‎⁪‮<string>(-692536552));
						num = 890014265;
						continue;
					}
					case 288:
					{
						TetraPanel.u202b‎⁯‫‮⁬‏‪⁫‍⁫‭​⁭‎​‎‮⁬‍‏‏‎⁯​⁭⁫‏‫‌‌‪‪​‬⁬⁭‫⁮‮‮(this.u200d‌‎‪⁯⁯⁫‭‬‬‭‎​‍‮⁯‮‌‬‪‭​⁮⁭⁬‏‏‫⁪‏⁭⁬‏⁮⁮‬⁯‏‭‍‮, new Point(138, 37));
						num = (int)(num2 * -1543061839 ^ -1333431067);
						continue;
					}
					case 289:
					{
						TetraPanel.u202e​‍‌‌⁮⁫‫‍⁯⁯⁯⁬‫⁪‎⁪⁬‫⁮‎⁯‭​​‭‌‎​‍‮⁯⁪⁪⁪‫⁬‬‏⁫‮(this.u200e‮⁯​⁬⁫‍⁭⁯⁪‪⁫‭⁯‬⁭‫‭⁭⁫‮⁮‏⁫‮‫‭‍‫​⁭‏⁮⁯‎‭⁯‫⁯⁮‮, FlatStyle.Flat);
						TetraPanel.u202b‏‏‬‎‮‫​‍​⁭‬‬‭‮⁫⁯‭⁪‬‎‫‫‎⁬‪‍‎⁪⁪‮‌‮‌‏⁯‌‍​‌‮(this.u200e‮⁯​⁬⁫‍⁭⁯⁪‪⁫‭⁯‬⁭‫‭⁭⁫‮⁮‏⁫‮‫‭‍‫​⁭‏⁮⁯‎‭⁯‫⁯⁮‮, TetraPanel.u202c‫‭‪‌‌⁬‌⁬‌‪‬‏‌‍⁯⁪‮⁪‮‌‪⁪⁯‭⁮‪‪⁪‬‭​‬‭‮‍‭‌‍‮(u003cModuleu003e.u200e‏‌‬⁮‪‭⁭‭⁭‎​‏‌‭‭‭⁭⁬⁯⁫‍‮‫⁯‌‮‏​‬⁫⁯⁮⁫‮‪⁫‬⁮⁬‮<string>(507840788), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0));
						num = 86174868;
						continue;
					}
					case 290:
					{
						TetraPanel.u206d‫‫‫⁮‮‌​‍⁫‭‎‬​⁭‬⁫‪‌‍‍‎‮⁫‬⁭⁫‫‎⁯‏‌‮‮⁬‮⁬⁪‮(this.u206c‫‍⁯⁫⁬⁬‎‮‎‭‎⁭⁪‍‏⁯‬​⁪‪⁯⁪​⁪‪‫‏⁮‏‍⁮⁮‫​‭⁬⁪⁮‍‮, u003cModuleu003e.u200e‏‌‬⁮‪‭⁭‭⁭‎​‏‌‭‭‭⁭⁬⁯⁫‍‮‫⁯‌‮‏​‬⁫⁯⁮⁫‮‪⁫‬⁮⁬‮<string>(-548097180));
						TetraPanel.u206a‏⁫‫​‏⁪⁬⁪‪⁪⁬‬⁫⁯‎‪⁯‫‎⁯‪‭‎‮‪‎⁮⁯‭⁯‎⁮⁮‪‭⁫‬⁫⁬‮(this.u206c‫‍⁯⁫⁬⁬‎‮‎‭‎⁭⁪‍‏⁯‬​⁪‪⁯⁪​⁪‪‫‏⁮‏‍⁮⁮‫​‭⁬⁪⁮‍‮, false);
						num = 1760466748;
						continue;
					}
					case 291:
					{
						TetraPanel.u206e‏‪⁯‏⁯‫‭​⁮‮‮‌⁫⁪⁪‪⁮‪​‫⁯⁪‬‍‬‬⁮⁬⁭⁪​‭‎‌​‫​‌⁪‮(this.u206a⁯‏⁯​‫‬⁬‌⁮​⁯‬‌‭⁯‪⁬⁯⁮‌‫⁫⁫‍‎‎⁫⁮‫‍‍‪​‮‍‮‭⁬‏‮, HorizontalAlignment.Right);
						num = (int)(num2 * -1331689193 ^ 1464722035);
						continue;
					}
					case 292:
					{
						TetraPanel.u200e​⁮⁯‮⁭‬‭⁫⁭⁬‌‭‎⁬⁬⁮⁬‭‬⁮‭‏⁫‫​‮‌‬⁪​‮⁮‪‪⁭‮⁪‍⁮‮(this.u200d‮⁪⁭⁭‍⁯‮‭‏‏⁭‬‫⁮⁯‬⁫‬‪⁫‎⁭‭​⁫‪⁬⁮⁫‍⁭​⁭‌⁪​⁪‭⁯‮, AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
						TetraPanel.u202d‏⁭⁫‮‫​‎‪⁫⁯‏⁮‫​‮‌⁮‬⁬‌⁮⁬‏⁭‏⁮‌⁮‮⁮‭‌‫‏⁪‎⁮‏‎‮(TetraPanel.u206a‬⁯⁭⁫‍⁪‫⁬⁭⁬⁮‫‏‍⁫‫‌⁪‪‌​⁭⁮‍‌‬⁯‭⁪‭⁮‏⁮‪​‍⁭⁫⁫‮(this.u200d‮⁪⁭⁭‍⁯‮‭‏‏⁭‬‫⁮⁯‬⁫‬‪⁫‎⁭‭​⁫‪⁬⁮⁫‍⁭​⁭‌⁪​⁪‭⁯‮), this.u206e‬‮​⁮‌⁭​‍‍⁪‌‏‭‬‏‎⁪⁬‫‬⁬⁪‍‌‪​‭⁬⁫⁬‪‭⁬⁪​⁪⁪​⁪‮);
						num = (int)(num2 * -104230238 ^ -224940070);
						continue;
					}
					case 293:
					{
						this.u202e‭‭‮​⁬⁯‎⁫​‬‏‌⁮⁮‮⁮⁬⁭‮⁯⁯‏‬‎​‎‍‏⁭⁮‏‬‫⁪‍‬‫‪‬‮ = TetraPanel.u200e​‏⁯‍‫‍⁪‌‪‮‫⁫‮‏‎‪‪⁪‍‍‏​⁯‎‪⁫‮⁯⁮⁯⁭‫‭⁯‌​‮⁫⁭‮();
						num = (int)(num2 * -822069772 ^ -1554562159);
						continue;
					}
					case 294:
					{
						TetraPanel.u202b‏‏‬‎‮‫​‍​⁭‬‬‭‮⁫⁯‭⁪‬‎‫‫‎⁬‪‍‎⁪⁪‮‌‮‌‏⁯‌‍​‌‮(this.u200d⁪‮‬⁭​​⁫⁪⁯⁫‬‏⁮⁭​‭‬‏‏⁭⁯‫‌‮‎⁫⁫‏‮⁮⁬⁫‮⁮⁪⁯‭‎‫‮, TetraPanel.u202c‫‭‪‌‌⁬‌⁬‌‪‬‏‌‍⁯⁪‮⁪‮‌‪⁪⁯‭⁮‪‪⁪‬‭​‬‭‮‍‭‌‍‮(u003cModuleu003e.u202a‮‫‏‫‬‬‪⁫⁬​‏⁫⁭‍‪‪‎⁬​‪​‌⁮‮‌​⁫​⁬‪‫⁪⁯⁪‎‫⁭‎⁪‮<string>(1627927687), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0));
						TetraPanel.u202b‎⁯‫‮⁬‏‪⁫‍⁫‭​⁭‎​‎‮⁬‍‏‏‎⁯​⁭⁫‏‫‌‌‪‪​‬⁬⁭‫⁮‮‮(this.u200d⁪‮‬⁭​​⁫⁪⁯⁫‬‏⁮⁭​‭‬‏‏⁭⁯‫‌‮‎⁫⁫‏‮⁮⁬⁫‮⁮⁪⁯‭‎‫‮, new Point(123, 74));
						num = 1131671686;
						continue;
					}
					case 295:
					{
						TetraPanel.u200c⁪‏‏⁫‌⁭‭⁪‮⁯⁫‬‏‍‬⁮⁮‍‌‎‮⁪‌⁮⁭⁮⁫‮‬⁪‭⁬⁮⁮⁫‫‌‌‏‮(this.u200d‮⁪⁭⁭‍⁯‮‭‏‏⁭‬‫⁮⁯‬⁫‬‪⁫‎⁭‭​⁫‪⁬⁮⁫‍⁭​⁭‌⁪​⁪‭⁯‮, Color.FromArgb(1, 1, 1));
						TetraPanel.u202b‎⁯‫‮⁬‏‪⁫‍⁫‭​⁭‎​‎‮⁬‍‏‏‎⁯​⁭⁫‏‫‌‌‪‪​‬⁬⁭‫⁮‮‮(this.u200d‮⁪⁭⁭‍⁯‮‭‏‏⁭‬‫⁮⁯‬⁫‬‪⁫‎⁭‭​⁫‪⁬⁮⁫‍⁭​⁭‌⁪​⁪‭⁯‮, new Point(5, 128));
						TetraPanel.u206e⁪‏‏​‍⁮‫⁬⁬⁯⁫⁯‏⁬⁮‫‫⁬⁬‭‫‌‌⁭‎​‭⁭‍⁬‏‏⁮‫⁮‭‮‎‪‮(this.u200d‮⁪⁭⁭‍⁯‮‭‏‏⁭‬‫⁮⁯‬⁫‬‪⁫‎⁭‭​⁫‪⁬⁮⁫‍⁭​⁭‌⁪​⁪‭⁯‮, u003cModuleu003e.u200d​‍⁮‏‭⁮⁪‌‪‬‬‬‪⁬⁭⁫⁫‬⁪⁬⁬⁬‏⁮⁭‌‍‏‍‏‎‬⁬​‪‎​‎⁭‮<string>(290829182));
						num = 1032159743;
						continue;
					}
					case 296:
					{
						TetraPanel.u200e‭⁭‌‪‫​⁯⁫⁫‪⁯‍⁯⁯⁭‎⁫‮⁮​​‭‎‮‍‏‎‎⁪‌⁫‬‮⁮‌⁮‏⁭⁪‮(this.u202a⁫⁫⁪‎⁯⁭‬‬⁬​‮‍⁭‮‌⁭‌‏‎‭‫‌‏‏⁫⁬‮⁬‌⁭​⁫⁯‫⁮⁭‬‏‏‮, true);
						num = (int)(num2 * 783596246 ^ -1435258707);
						continue;
					}
					case 297:
					{
						TetraPanel.u206e‏‪⁯‏⁯‫‭​⁮‮‮‌⁫⁪⁪‪⁮‪​‫⁯⁪‬‍‬‬⁮⁬⁭⁪​‭‎‌​‫​‌⁪‮(this.u200f‍‮‏‌‏‌‍‍⁪⁫⁯⁭‫⁮⁫‫⁯‏‫⁪‍‫⁮‮⁪⁫‍‭‍⁫‏‍⁫‍‌⁪⁫⁪⁭‮, HorizontalAlignment.Right);
						num = (int)(num2 * 1023577167 ^ -1287454088);
						continue;
					}
					case 298:
					{
						TetraPanel.u206e⁪‏‏​‍⁮‫⁬⁬⁯⁫⁯‏⁬⁮‫‫⁬⁬‭‫‌‌⁭‎​‭⁭‍⁬‏‏⁮‫⁮‭‮‎‪‮(this.u206d‏‪‫‍⁪‪⁬‌⁪‌‪‭⁫‫‎‍⁯‎‬‭⁪⁯​⁪⁮‬​‌​‎‌⁪‭⁮‏‌‫‫⁯‮, u003cModuleu003e.u206f⁮​‌‪‮‎‭‏‮‎⁮⁮‮⁬⁫‍‍⁪‍⁫⁮‏​‎⁬⁯⁪‪‍⁪⁮‎⁬⁪⁫​⁮⁪⁮‮<string>(332880819));
						num = 552960697;
						continue;
					}
					case 299:
					{
						TetraPanel.u206d‫‫‫⁮‮‌​‍⁫‭‎‬​⁭‬⁫‪‌‍‍‎‮⁫‬⁭⁫‫‎⁯‏‌‮‮⁬‮⁬⁪‮(this.u200e​⁭⁯​‏‏‎‭⁮‍‮⁬‪‮‪⁮‫⁭‏‍⁬‍‎‏‪‫‪‮⁪‍⁫‮‍⁪‬‏‭‮‏‮, u003cModuleu003e.u200f⁫‌​⁬‌‎‎‏‍‍⁫‎​‌‬⁯‬‫‭‎‏​‌​⁪‭‬⁬‮⁬​‌⁬⁪‫‫‎⁪⁮‮<string>(1939131891));
						num = 705463260;
						continue;
					}
					case 300:
					{
						TetraPanel.u200e​⁮⁯‮⁭‬‭⁫⁭⁬‌‭‎⁬⁬⁮⁬‭‬⁮‭‏⁫‫​‮‌‬⁪​‮⁮‪‪⁭‮⁪‍⁮‮(this.u202e‪⁬⁫⁬⁭‪‏‌‏‫‫⁬⁭‌‭‮⁭⁭‬‪⁭⁭‬‌‮⁮⁭⁫‌‬⁯⁫‪‭‎‭‎‍⁫‮, AnchorStyles.Top | AnchorStyles.Right);
						TetraPanel.u200e‭⁭‌‪‫​⁯⁫⁫‪⁯‍⁯⁯⁭‎⁫‮⁮​​‭‎‮‍‏‎‎⁪‌⁫‬‮⁮‌⁮‏⁭⁪‮(this.u202e‪⁬⁫⁬⁭‪‏‌‏‫‫⁬⁭‌‭‮⁭⁭‬‪⁭⁭‬‌‮⁮⁭⁫‌‬⁯⁫‪‭‎‭‎‍⁫‮, true);
						TetraPanel.u202b‏‏‬‎‮‫​‍​⁭‬‬‭‮⁫⁯‭⁪‬‎‫‫‎⁬‪‍‎⁪⁪‮‌‮‌‏⁯‌‍​‌‮(this.u202e‪⁬⁫⁬⁭‪‏‌‏‫‫⁬⁭‌‭‮⁭⁭‬‪⁭⁭‬‌‮⁮⁭⁫‌‬⁯⁫‪‭‎‭‎‍⁫‮, TetraPanel.u202c‫‭‪‌‌⁬‌⁬‌‪‬‏‌‍⁯⁪‮⁪‮‌‪⁪⁯‭⁮‪‪⁪‬‭​‬‭‮‍‭‌‍‮(u003cModuleu003e.u206f⁮​‌‪‮‎‭‏‮‎⁮⁮‮⁬⁫‍‍⁪‍⁫⁮‏​‎⁬⁯⁪‪‍⁪⁮‎⁬⁪⁫​⁮⁪⁮‮<string>(125941577), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0));
						num = 1584542866;
						continue;
					}
					case 301:
					{
						TetraPanel.u206a⁪⁯⁫​‌⁬‬⁫‫‫‍⁯‫‬⁬‍​⁭⁮‬‌‍⁬⁪‌⁬‍‍‪‍‌⁬‫‭‮‍⁪‎‭‮(this.u200d‌‏‪‍‭⁯‎⁫⁪⁮⁮‍‮⁪⁫⁮⁬‎⁭⁫⁬‭‎⁯‪‍‏‌⁭⁯⁯‬‫‌‭⁮‬‭⁭‮, ImageLayout.Zoom);
						num = (int)(num2 * -23432895 ^ -722183209);
						continue;
					}
					case 302:
					{
						TetraPanel.u202d‏⁭⁫‮‫​‎‪⁫⁯‏⁮‫​‮‌⁮‬⁬‌⁮⁬‏⁭‏⁮‌⁮‮⁮‭‌‫‏⁪‎⁮‏‎‮(TetraPanel.u206a‬⁯⁭⁫‍⁪‫⁬⁭⁬⁮‫‏‍⁫‫‌⁪‪‌​⁭⁮‍‌‬⁯‭⁪‭⁮‏⁮‪​‍⁭⁫⁫‮(this.u200d‮⁪⁭⁭‍⁯‮‭‏‏⁭‬‫⁮⁯‬⁫‬‪⁫‎⁭‭​⁫‪⁬⁮⁫‍⁭​⁭‌⁪​⁪‭⁯‮), this.u202a‎‎‭⁭⁬‎⁬‏⁫⁬⁯‫‎‬‪‏⁬‪‬‭‌‪‌‎⁯‪‪‫​‪​⁮‫‭‌⁮​⁪⁬‮);
						num = (int)(num2 * 1283801940 ^ -1641584717);
						continue;
					}
					case 303:
					{
						TetraPanel.u202d‏⁭⁫‮‫​‎‪⁫⁯‏⁮‫​‮‌⁮‬⁬‌⁮⁬‏⁭‏⁮‌⁮‮⁮‭‌‫‏⁪‎⁮‏‎‮(TetraPanel.u206a‬⁯⁭⁫‍⁪‫⁬⁭⁬⁮‫‏‍⁫‫‌⁪‪‌​⁭⁮‍‌‬⁯‭⁪‭⁮‏⁮‪​‍⁭⁫⁫‮(this.u200d‮⁪⁭⁭‍⁯‮‭‏‏⁭‬‫⁮⁯‬⁫‬‪⁫‎⁭‭​⁫‪⁬⁮⁫‍⁭​⁭‌⁪​⁪‭⁯‮), this.u202a‌⁯‌⁮‍‎‏⁭‌‮‭‌‏‎⁬⁯⁭‌‎⁪‪⁪‎⁪‏⁯⁪⁯​‪⁭‭‫⁬​⁭⁯⁯⁬‮);
						num = (int)(num2 * -121296 ^ -685895210);
						continue;
					}
					case 304:
					{
						TetraPanel.u206b⁬‪‍‭⁮⁪‌‭⁯⁪⁪‏‌‪⁯⁭‮​‭‏‌⁮⁯⁪‪‬​⁮⁯‮⁫⁮‪‪‫‍⁪⁬‎‮(this.u206a‮​‫‪‪⁬‫‏⁬⁯‫‏⁬‌​⁪‮​‌⁬‏‍‎‍‌⁬⁮⁫‍⁪⁭‎‭‌⁭⁫⁬‏⁮‮, 47);
						TetraPanel.u206d‫‫‫⁮‮‌​‍⁫‭‎‬​⁭‬⁫‪‌‍‍‎‮⁫‬⁭⁫‫‎⁯‏‌‮‮⁬‮⁬⁪‮(this.u206a‮​‫‪‪⁬‫‏⁬⁯‫‏⁬‌​⁪‮​‌⁬‏‍‎‍‌⁬⁮⁫‍⁪⁭‎‭‌⁭⁫⁬‏⁮‮, u003cModuleu003e.u200f⁫‌​⁬‌‎‎‏‍‍⁫‎​‌‬⁯‬‫‭‎‏​‌​⁪‭‬⁬‮⁬​‌⁬⁪‫‫‎⁪⁮‮<string>(1554264483));
						TetraPanel.u202a‬​‍⁬‮‫‪⁯‎‫⁮⁭⁯‎‌⁭⁭‍‏‮‫‭‮‏‎‭⁮‮⁯‮⁬⁮‍‍‍⁭‫‮‪‮(this.u206a‮​‫‪‪⁬‫‏⁬⁯‫‏⁬‌​⁪‮​‌⁬‏‍‎‍‌⁬⁮⁫‍⁪⁭‎‭‌⁭⁫⁬‏⁮‮, new EventHandler(this.u206a‏⁯‍‏‍⁫‫‪⁯⁯⁭‎​⁫⁪‪⁭‎‏⁪‍‭‍‍⁭‫‏⁫‮⁮⁫⁫‍‫‌⁫‫‍⁪‮));
						num = 1003138091;
						continue;
					}
					case 305:
					{
						TetraPanel.u206d‫‫‫⁮‮‌​‍⁫‭‎‬​⁭‬⁫‪‌‍‍‎‮⁫‬⁭⁫‫‎⁯‏‌‮‮⁬‮⁬⁪‮(this.u200f‏⁯‭‌⁫‌‏⁪‫‬‎‫⁫‮‫‎‬‭‪⁪‫⁮‫‍‎‎⁪⁭⁬⁯⁪‬‎‮⁫⁪‎‭‌‮, u003cModuleu003e.u206f⁮​‌‪‮‎‭‏‮‎⁮⁮‮⁬⁫‍‍⁪‍⁫⁮‏​‎⁬⁯⁪‪‍⁪⁮‎⁬⁪⁫​⁮⁪⁮‮<string>(783897682));
						num = 248664150;
						continue;
					}
					case 306:
					{
						this.u206f⁯⁭‫‍⁪‬‭⁮‪⁯⁭‮‌‭‪‏⁯‫‪‎‪⁯⁫⁪‌‭‪‌‫⁮‭⁪‍‏‌‪‬‏‫‮ = TetraPanel.u200b‬‌⁯‫‪⁪⁯​‭‬‌‭⁯⁮⁮‏​‪‬⁯‭‪​⁫‮​‪‬‬​‌‏⁬⁪‪‏⁪‏⁬‮();
						this.u202a‎‎‭⁭⁬‎⁬‏⁫⁬⁯‫‎‬‪‏⁬‪‬‭‌‪‌‎⁯‪‪‫​‪​⁮‫‭‌⁮​⁪⁬‮ = TetraPanel.u200b‬‌⁯‫‪⁪⁯​‭‬‌‭⁯⁮⁮‏​‪‬⁯‭‪​⁫‮​‪‬‬​‌‏⁬⁪‪‏⁪‏⁬‮();
						num = (int)(num2 * -1766410981 ^ -1542493634);
						continue;
					}
					case 307:
					{
						TetraPanel.u206a‪⁭​⁫‮‍‬‭⁬‮‬‫‪⁬‎‌‭⁬‬‭‪‌‫⁮⁫⁫‪‍⁭⁬​‌⁪⁪⁯‮​‫‬‮(this.u202a‪⁮​‏‫‮‫⁭⁯⁭‬⁯‎‭​‎⁬‭⁬‬‬‬‌⁪‍⁪​‎‍⁯​‍⁯⁫‎‍⁪‎‭‮);
						num = (int)(num2 * 1009136427 ^ 276178275);
						continue;
					}
					case 308:
					{
						TetraPanel.u202b‎⁯‫‮⁬‏‪⁫‍⁫‭​⁭‎​‎‮⁬‍‏‏‎⁯​⁭⁫‏‫‌‌‪‪​‬⁬⁭‫⁮‮‮(this.u202a‌⁯‌⁮‍‎‏⁭‌‮‭‌‏‎⁬⁯⁭‌‎⁪‪⁪‎⁪‏⁯⁪⁯​‪⁭‭‫⁬​⁭⁯⁯⁬‮, new Point(138, 71));
						TetraPanel.u206e⁪‏‏​‍⁮‫⁬⁬⁯⁫⁯‏⁬⁮‫‫⁬⁬‭‫‌‌⁭‎​‭⁭‍⁬‏‏⁮‫⁮‭‮‎‪‮(this.u202a‌⁯‌⁮‍‎‏⁭‌‮‭‌‏‎⁬⁯⁭‌‎⁪‪⁪‎⁪‏⁯⁪⁯​‪⁭‭‫⁬​⁭⁯⁯⁬‮, u003cModuleu003e.u200f⁫‌​⁬‌‎‎‏‍‍⁫‎​‌‬⁯‬‫‭‎‏​‌​⁪‭‬⁬‮⁬​‌⁬⁪‫‫‎⁪⁮‮<string>(662890161));
						TetraPanel.u202c⁭⁫‪‏⁬⁭⁭​​⁪⁫‬‍⁪⁫⁭⁬‮‌⁭‫‮‭​⁫‌⁪‎‏⁪‫‮‌​‌‍⁮⁮⁮‮(this.u202a‌⁯‌⁮‍‎‏⁭‌‮‭‌‏‎⁬⁯⁭‌‎⁪‪⁪‎⁪‏⁯⁪⁯​‪⁭‭‫⁬​⁭⁯⁯⁬‮, new System.Drawing.Size(13, 13));
						num = 1102526787;
						continue;
					}
					case 309:
					{
						TetraPanel.u202b‏‏‬‎‮‫​‍​⁭‬‬‭‮⁫⁯‭⁪‬‎‫‫‎⁬‪‍‎⁪⁪‮‌‮‌‏⁯‌‍​‌‮(this.u200f‏⁪‪⁪‪⁯‪‌⁬‎‪‬‫⁯‭‬‌⁯‏⁮⁫‪⁯‬⁪⁭⁭‪‪‌‍‭‎⁭⁫⁯⁯​‏‮, TetraPanel.u202c‫‭‪‌‌⁬‌⁬‌‪‬‏‌‍⁯⁪‮⁪‮‌‪⁪⁯‭⁮‪‪⁪‬‭​‬‭‮‍‭‌‍‮(u003cModuleu003e.u200d​‍⁮‏‭⁮⁪‌‪‬‬‬‪⁬⁭⁫⁫‬⁪⁬⁬⁬‏⁮⁭‌‍‏‍‏‎‬⁬​‪‎​‎⁭‮<string>(2136952738), 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0));
						TetraPanel.u202b‎⁯‫‮⁬‏‪⁫‍⁫‭​⁭‎​‎‮⁬‍‏‏‎⁯​⁭⁫‏‫‌‌‪‪​‬⁬⁭‫⁮‮‮(this.u200f‏⁪‪⁪‪⁯‪‌⁬‎‪‬‫⁯‭‬‌⁯‏⁮⁫‪⁯‬⁪⁭⁭‪‪‌‍‭‎⁭⁫⁯⁯​‏‮, new Point(85, 17));
						num = 1576213946;
						continue;
					}
					case 310:
					{
						TetraPanel.u202c⁭⁫‪‏⁬⁭⁭​​⁪⁫‬‍⁪⁫⁭⁬‮‌⁭‫‮‭​⁫‌⁪‎‏⁪‫‮‌​‌‍⁮⁮⁮‮(this.u202c⁭‎‫‮‌⁯⁮‍‎⁪⁪⁬‭⁮‏‎‌‌‎‌⁯‪‮⁯‌⁮‌‭⁯‎‍‌⁪‍‭‏⁪‬‮, new System.Drawing.Size(86, 17));
						num = (int)(num2 * 1882840156 ^ -784261288);
						continue;
					}
					case 311:
					{
						TetraPanel.u206d‫‫‫⁮‮‌​‍⁫‭‎‬​⁭‬⁫‪‌‍‍‎‮⁫‬⁭⁫‫‎⁯‏‌‮‮⁬‮⁬⁪‮(this.u200c‎‎‪‎‮‎⁫‭‪⁯⁬⁪⁬‏‮‏‪‫‏⁯⁪​⁬‫⁯⁪‎‪‏‫‮⁯‏‪‭‬‏‪‮, u003cModuleu003e.u200f⁫‌​⁬‌‎‎‏‍‍⁫‎​‌‬⁯‬‫‭‎‏​‌​⁪‭‬⁬‮⁬​‌⁬⁪‫‫‎⁪⁮‮<string>(1835153584));
						num = 856322972;
						continue;
					}
					case 312:
					{
						TetraPanel.u206e⁪‏‏​‍⁮‫⁬⁬⁯⁫⁯‏⁬⁮‫‫⁬⁬‭‫‌‌⁭‎​‭⁭‍⁬‏‏⁮‫⁮‭‮‎‪‮(this.u200f‏⁪‪⁪‪⁯‪‌⁬‎‪‬‫⁯‭‬‌⁯‏⁮⁫‪⁯‬⁪⁭⁭‪‪‌‍‭‎⁭⁫⁯⁯​‏‮, u003cModuleu003e.u200d​‍⁮‏‭⁮⁪‌‪‬‬‬‪⁬⁭⁫⁫‬⁪⁬⁬⁬‏⁮⁭‌‍‏‍‏‎‬⁬​‪‎​‎⁭‮<string>(-1342614079));
						num = 1711709129;
						continue;
					}
					case 313:
					{
						TetraPanel.u206a‪⁭​⁫‮‍‬‭⁬‮‬‫‪⁬‎‌‭⁬‬‭‪‌‫⁮⁫⁫‪‍⁭⁬​‌⁪⁪⁯‮​‫‬‮(this.u206a⁯‏⁯​‫‬⁬‌⁮​⁯‬‌‭⁯‪⁬⁯⁮‌‫⁫⁫‍‎‎⁫⁮‫‍‍‪​‮‍‮‭⁬‏‮);
						num = (int)(num2 * -1752316372 ^ -506456470);
						continue;
					}
					case 314:
					{
						TetraPanel.u206e⁪‏‏​‍⁮‫⁬⁬⁯⁫⁯‏⁬⁮‫‫⁬⁬‭‫‌‌⁭‎​‭⁭‍⁬‏‏⁮‫⁮‭‮‎‪‮(this.u206d‪⁪‌⁭‌‫⁭‌⁪​‭⁫‎‪‭‌⁬‍‎‌‮‍‌‬‍‬⁬‏⁫‏‫‏‏‎‭‬‍‪⁫‮, u003cModuleu003e.u200f⁫‌​⁬‌‎‎‏‍‍⁫‎​‌‬⁯‬‫‭‎‏​‌​⁪‭‬⁬‮⁬​‌⁬⁪‫‫‎⁪⁮‮<string>(-1909806800));
						TetraPanel.u202c⁭⁫‪‏⁬⁭⁭​​⁪⁫‬‍⁪⁫⁭⁬‮‌⁭‫‮‭​⁫‌⁪‎‏⁪‫‮‌​‌‍⁮⁮⁮‮(this.u206d‪⁪‌⁭‌‫⁭‌⁪​‭⁫‎‪‭‌⁬‍‎‌‮‍‌‬‍‬⁬‏⁫‏‫‏‏‎‭‬‍‪⁫‮, new System.Drawing.Size(33, 13));
						num = 1797012279;
						continue;
					}
					case 315:
					{
						this.u200b‏⁭⁯⁮⁬‭‮⁭⁯‮​‏‭⁬⁮‫⁬⁬‬‮‏‏‎‮⁫⁬⁭⁮​​⁮⁪⁭⁭​‫‫‮ = TetraPanel.u206e⁮⁬⁫‏⁯‪​⁬‭​⁫‭‬⁯⁬‫⁪​⁮⁪⁪‏⁬⁯‍‫⁮⁭‌⁭⁮‪⁭⁯‬‬‍‭‪‮();
						num = (int)(num2 * -1326010025 ^ -423393776);
						continue;
					}
					case 316:
					{
						TetraPanel.u202b‏‏‬‎‮‫​‍​⁭‬‬‭‮⁫⁯‭⁪‬‎‫‫‎⁬‪‍‎⁪⁪‮‌‮‌‏⁯‌‍​‌‮(this.u200c‫‌‪‌‌‏​⁯⁪​‫⁪⁮⁯‫‍⁪⁫⁪‮⁬⁬‭⁯‌‫⁯‫‪‏‭‏⁭⁬‌‫‬⁪⁬‮, TetraPanel.u202c‫‭‪‌‌⁬‌⁬‌‪‬‏‌‍⁯⁪‮⁪‮‌‪⁪⁯‭⁮‪‪⁪‬‭​‬‭‮‍‭‌‍‮(u003cModuleu003e.u200f⁫‌​⁬‌‎‎‏‍‍⁫‎​‌‬⁯‬‫‭‎‏​‌​⁪‭‬⁬‮⁬​‌⁬⁪‫‫‎⁪⁮‮<string>(-285035864), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0));
						num = 1136964103;
						continue;
					}
					case 317:
					{
						TetraPanel.u202b‎⁯‫‮⁬‏‪⁫‍⁫‭​⁭‎​‎‮⁬‍‏‏‎⁯​⁭⁫‏‫‌‌‪‪​‬⁬⁭‫⁮‮‮(this.u200c‫‌‪‌‌‏​⁯⁪​‫⁪⁮⁯‫‍⁪⁫⁪‮⁬⁬‭⁯‌‫⁯‫‪‏‭‏⁭⁬‌‫‬⁪⁬‮, new Point(140, 469));
						num = (int)(num2 * 861488723 ^ 472739921);
						continue;
					}
					case 318:
					{
						TetraPanel.u206e⁪‏‏​‍⁮‫⁬⁬⁯⁫⁯‏⁬⁮‫‫⁬⁬‭‫‌‌⁭‎​‭⁭‍⁬‏‏⁮‫⁮‭‮‎‪‮(this.u200f‏⁯‭‌⁫‌‏⁪‫‬‎‫⁫‮‫‎‬‭‪⁪‫⁮‫‍‎‎⁪⁭⁬⁯⁪‬‎‮⁫⁪‎‭‌‮, u003cModuleu003e.u200f⁫‌​⁬‌‎‎‏‍‍⁫‎​‌‬⁯‬‫‭‎‏​‌​⁪‭‬⁬‮⁬​‌⁬⁪‫‫‎⁪⁮‮<string>(149904339));
						TetraPanel.u202c⁭⁫‪‏⁬⁭⁭​​⁪⁫‬‍⁪⁫⁭⁬‮‌⁭‫‮‭​⁫‌⁪‎‏⁪‫‮‌​‌‍⁮⁮⁮‮(this.u200f‏⁯‭‌⁫‌‏⁪‫‬‎‫⁫‮‫‎‬‭‪⁪‫⁮‫‍‎‎⁪⁭⁬⁯⁪‬‎‮⁫⁪‎‭‌‮, new System.Drawing.Size(31, 13));
						TetraPanel.u206b⁬‪‍‭⁮⁪‌‭⁯⁪⁪‏‌‪⁯⁭‮​‭‏‌⁮⁯⁪‪‬​⁮⁯‮⁫⁮‪‪‫‍⁪⁬‎‮(this.u200f‏⁯‭‌⁫‌‏⁪‫‬‎‫⁫‮‫‎‬‭‪⁪‫⁮‫‍‎‎⁪⁭⁬⁯⁪‬‎‮⁫⁪‎‭‌‮, 67);
						num = 1870854947;
						continue;
					}
					case 319:
					{
						this.u200d⁪‮‬⁭​​⁫⁪⁯⁫‬‏⁮⁭​‭‬‏‏⁭⁯‫‌‮‎⁫⁫‏‮⁮⁬⁫‮⁮⁪⁯‭‎‫‮ = TetraPanel.u200b‬‌⁯‫‪⁪⁯​‭‬‌‭⁯⁮⁮‏​‪‬⁯‭‪​⁫‮​‪‬‬​‌‏⁬⁪‪‏⁪‏⁬‮();
						num = (int)(num2 * 42023659 ^ -43087565);
						continue;
					}
					case 320:
					{
						TetraPanel.u206b⁬‪‍‭⁮⁪‌‭⁯⁪⁪‏‌‪⁯⁭‮​‭‏‌⁮⁯⁪‪‬​⁮⁯‮⁫⁮‪‪‫‍⁪⁬‎‮(this.u202e⁭​⁬‎​⁬⁮​⁬‬‫‎⁫‬‌​⁬⁪⁮​⁫⁬⁫⁪‎‍⁭⁭‬‬‪‎‍‬⁪‍‍​‍‮, 70);
						TetraPanel.u202d‭⁮‌‏‍⁬⁫⁮​‍‮‎⁭‪‌‭‮‌⁬⁯‌⁭‮‫‪‬⁫⁭‍⁬⁪‌‬‍⁮‏‌‭‭‮(this.u202e⁭​⁬‎​⁬⁮​⁬‬‫‎⁫‬‌​⁬⁪⁮​⁫⁬⁫⁪‎‍⁭⁭‬‬‪‎‍‬⁪‍‍​‍‮, true);
						num = (int)(num2 * -1713234861 ^ 794353858);
						continue;
					}
					case 321:
					{
						TetraPanel.u202b‬⁫‌‪⁯⁭‪⁮‏‪⁭⁪‌‪⁬⁪‭⁬‮‬‭⁫‫⁯‭‫‫‎‎‮‎‏⁮⁯‪‌‭⁫‌‮(this.u206a⁭‫⁬⁯‌‎⁯‬‍​‏‎‌‏⁯‏⁮‬⁯⁮‎⁯⁬‌‪⁯⁬⁭⁬​‭​‌​‎⁫⁪‭‍‮, false);
						num = (int)(num2 * 223521398 ^ 1205733806);
						continue;
					}
					case 322:
					{
						TetraPanel.u202b‎⁯‫‮⁬‏‪⁫‍⁫‭​⁭‎​‎‮⁬‍‏‏‎⁯​⁭⁫‏‫‌‌‪‪​‬⁬⁭‫⁮‮‮(this.u200d‌‏‪‍‭⁯‎⁫⁪⁮⁮‍‮⁪⁫⁮⁬‎⁭⁫⁬‭‎⁯‪‍‏‌⁭⁯⁯‬‫‌‭⁮‬‭⁭‮, new Point(3, 19));
						num = (int)(num2 * -1108855122 ^ 1628750855);
						continue;
					}
					case 323:
					{
						goto Label1;
					}
					case 324:
					{
						TetraPanel.u206e⁪‏‏​‍⁮‫⁬⁬⁯⁫⁯‏⁬⁮‫‫⁬⁬‭‫‌‌⁭‎​‭⁭‍⁬‏‏⁮‫⁮‭‮‎‪‮(this.u200e‮⁯​⁬⁫‍⁭⁯⁪‪⁫‭⁯‬⁭‫‭⁭⁫‮⁮‏⁫‮‫‭‍‫​⁭‏⁮⁯‎‭⁯‫⁯⁮‮, u003cModuleu003e.u200f⁫‌​⁬‌‎‎‏‍‍⁫‎​‌‬⁯‬‫‭‎‏​‌​⁪‭‬⁬‮⁬​‌⁬⁪‫‫‎⁪⁮‮<string>(735054399));
						num = 1633442102;
						continue;
					}
					case 325:
					{
						TetraPanel.u202d⁭⁪⁭‫‌⁬⁬⁭‎‏‬⁯⁮‭‪⁪‫⁭⁭‏‫‌‎⁪​⁮‎⁯⁭⁪‎⁪⁯‎‭⁯⁭​‌‮(this, new SizeF(6f, 13f));
						num = (int)(num2 * -397401711 ^ 1603936503);
						continue;
					}
				}
			}
		}

		// ⁬‮‌⁭​⁫‫​‪⁮‌‌‌‪​‮⁮‍‎‌​‏‫⁭‍⁭‭‍‎‎⁯‎‪‬‮‪‍‭‬‪‮
		private void u206c‮‌⁭​⁫‫​‪⁮‌‌‌‪​‮⁮‍‎‌​‏‫⁭‍⁭‭‍‎‎⁯‎‪‬‮‪‍‭‬‪‮(object obj, EventArgs eventArg)
		{
			this.u206d‫‏‎‭‭⁮‭‮‌⁮‮‍‎⁬⁮‍⁯​⁯⁮⁮‬⁪‍‎⁫⁮⁫‭‏‌⁮⁯‍⁫⁫‬‮⁮‮ = null;
		Label0:
			int num = -761116836;
			while (true)
			{
				int num1 = num ^ -1606142086;
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
						this.u200b‍⁯⁪‌‍‍‎‪⁯⁮⁪‬⁯⁮⁮‍⁫‫⁭⁯​⁮⁮‫⁫‪‭‪⁪‪⁬⁫‬‎‌‎⁬‎⁫‮.TttModeEnabled = false;
						num = (int)(num2 * -710534222 ^ 450939813);
						continue;
					}
				}
			}
		}

		// ‪⁯⁯⁬‮⁪⁪‭‪‍⁬‫‎⁫⁮⁬‎‎‏‍‎⁪‍⁯‍⁯‌⁮⁮⁮‍⁬⁬‎⁮‫‬⁫⁫‎‮
		private void u202a⁯⁯⁬‮⁪⁪‭‪‍⁬‫‎⁫⁮⁬‎‎‏‍‎⁪‍⁯‍⁯‌⁮⁮⁮‍⁬⁬‎⁮‫‬⁫⁫‎‮()
		{
			// 
			// Current member / type: System.Void SDRSharp.Tetra.TetraPanel::‪⁯⁯⁬‮⁪⁪‭‪‍⁬‫‎⁫⁮⁬‎‎‏‍‎⁪‍⁯‍⁯‌⁮⁮⁮‍⁬⁬‎⁮‫‬⁫⁫‎‮()
			// File path: C:\SDRSharp\Plugins\Tetra\SDRSharp.Tetra.dll
			// 
			// Product version: 0.0.0.0
			// Exception in: System.Void ‪⁯⁯⁬‮⁪⁪‭‪‍⁬‫‎⁫⁮⁬‎‎‏‍‎⁪‍⁯‍⁯‌⁮⁮⁮‍⁬⁬‎⁮‫‬⁫⁫‎‮()
			// 
			// Not supported type System.Object.
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.GetTypeIndex(TypeDefinition type) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 684
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.GetContainingType(TypeDefinition leftType, TypeDefinition rightType) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 608
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.GetExpressionType() in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 492
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.get_ExpressionType() in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 414
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.AddAssignmentCastIfNeeded(Expression expr) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\TypeInference\TypeInferer.cs:line 112
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.FixAssignmentInList(IList`1 expressionList, Expression value) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\TypeInference\TypeInferer.cs:line 75
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.AddCasts() in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\TypeInference\TypeInferer.cs:line 38
			//    at Telerik.JustDecompiler.Decompiler.ExpressionDecompilerStep.Process(DecompilationContext theContext, BlockStatement body) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\ExpressionDecompilerStep.cs:line 68
			//    at Telerik.JustDecompiler.Decompiler.DecompilationPipeline.RunInternal(MethodBody body, BlockStatement block, ILanguage language) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\DecompilationPipeline.cs:line 100
			//    at Telerik.JustDecompiler.Decompiler.WriterContextServices.BaseWriterContextService.DecompileMethod(ILanguage language, MethodDefinition method, TypeSpecificContext typeContext) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\WriterContextServices\BaseWriterContextService.cs:line 133
			// 
			// mailto: JustDecompilePublicFeedback@telerik.com

		}

		// ⁫‍⁯⁮⁬‍‎⁮​‪‬⁭‫⁭⁮⁫⁯‍‌‬‫‬⁭‪⁫‌‌⁮⁯​⁪⁭⁭⁬​‌‍‭‌⁭‮
		private Dictionary<int, NetworkEntry> u206b‍⁯⁮⁬‍‎⁮​‪‬⁭‫⁭⁮⁫⁯‍‌‬‫‬⁭‪⁫‌‌⁮⁯​⁪⁭⁭⁬​‌‍‭‌⁭‮(List<GroupsEntries> )
		{
			// 
			// Current member / type: System.Collections.Generic.Dictionary`2<System.Int32,SDRSharp.Tetra.NetworkEntry> SDRSharp.Tetra.TetraPanel::⁫‍⁯⁮⁬‍‎⁮​‪‬⁭‫⁭⁮⁫⁯‍‌‬‫‬⁭‪⁫‌‌⁮⁯​⁪⁭⁭⁬​‌‍‭‌⁭‮(System.Collections.Generic.List`1<SDRSharp.Tetra.GroupsEntries>)
			// File path: C:\SDRSharp\Plugins\Tetra\SDRSharp.Tetra.dll
			// 
			// Product version: 0.0.0.0
			// Exception in: System.Collections.Generic.Dictionary<System.Int32,SDRSharp.Tetra.NetworkEntry> ⁫‍⁯⁮⁬‍‎⁮​‪‬⁭‫⁭⁮⁫⁯‍‌‬‫‬⁭‪⁫‌‌⁮⁯​⁪⁭⁭⁬​‌‍‭‌⁭‮(System.Collections.Generic.List<SDRSharp.Tetra.GroupsEntries>)
			// 
			// Not supported type System.Object.
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.GetTypeIndex(TypeDefinition type) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 684
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.GetContainingType(TypeDefinition leftType, TypeDefinition rightType) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 608
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.GetExpressionType() in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 492
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.get_ExpressionType() in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 414
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.AddAssignmentCastIfNeeded(Expression expr) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\TypeInference\TypeInferer.cs:line 112
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.FixAssignmentInList(IList`1 expressionList, Expression value) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\TypeInference\TypeInferer.cs:line 75
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.AddCasts() in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\TypeInference\TypeInferer.cs:line 38
			//    at Telerik.JustDecompiler.Decompiler.ExpressionDecompilerStep.Process(DecompilationContext theContext, BlockStatement body) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\ExpressionDecompilerStep.cs:line 68
			//    at Telerik.JustDecompiler.Decompiler.DecompilationPipeline.RunInternal(MethodBody body, BlockStatement block, ILanguage language) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\DecompilationPipeline.cs:line 100
			//    at Telerik.JustDecompiler.Decompiler.WriterContextServices.BaseWriterContextService.DecompileMethod(ILanguage language, MethodDefinition method, TypeSpecificContext typeContext) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\WriterContextServices\BaseWriterContextService.cs:line 133
			// 
			// mailto: JustDecompilePublicFeedback@telerik.com

		}

		// ⁮⁫‍​⁬‫‪‪⁪⁪​​‍‎‪‭‭‫‫⁫⁫‬⁬‫‫‪‪‎⁭‬‌‌‬‬⁭⁭⁭‎​‪‮
		private List<GroupsEntries> u206e⁫‍​⁬‫‪‪⁪⁪​​‍‎‪‭‭‫‫⁫⁫‬⁬‫‫‪‪‎⁭‬‌‌‬‬⁭⁭⁭‎​‪‮(Dictionary<int, NetworkEntry> )
		{
			// 
			// Current member / type: System.Collections.Generic.List`1<SDRSharp.Tetra.GroupsEntries> SDRSharp.Tetra.TetraPanel::⁮⁫‍​⁬‫‪‪⁪⁪​​‍‎‪‭‭‫‫⁫⁫‬⁬‫‫‪‪‎⁭‬‌‌‬‬⁭⁭⁭‎​‪‮(System.Collections.Generic.Dictionary`2<System.Int32,SDRSharp.Tetra.NetworkEntry>)
			// File path: C:\SDRSharp\Plugins\Tetra\SDRSharp.Tetra.dll
			// 
			// Product version: 0.0.0.0
			// Exception in: System.Collections.Generic.List<SDRSharp.Tetra.GroupsEntries> ⁮⁫‍​⁬‫‪‪⁪⁪​​‍‎‪‭‭‫‫⁫⁫‬⁬‫‫‪‪‎⁭‬‌‌‬‬⁭⁭⁭‎​‪‮(System.Collections.Generic.Dictionary<System.Int32,SDRSharp.Tetra.NetworkEntry>)
			// 
			// Not supported type System.Object.
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.GetTypeIndex(TypeDefinition type) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 684
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.GetContainingType(TypeDefinition leftType, TypeDefinition rightType) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 608
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.GetExpressionType() in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 492
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.get_ExpressionType() in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 414
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.AddAssignmentCastIfNeeded(Expression expr) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\TypeInference\TypeInferer.cs:line 112
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.FixAssignmentInList(IList`1 expressionList, Expression value) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\TypeInference\TypeInferer.cs:line 75
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.AddCasts() in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\TypeInference\TypeInferer.cs:line 38
			//    at Telerik.JustDecompiler.Decompiler.ExpressionDecompilerStep.Process(DecompilationContext theContext, BlockStatement body) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\ExpressionDecompilerStep.cs:line 68
			//    at Telerik.JustDecompiler.Decompiler.DecompilationPipeline.RunInternal(MethodBody body, BlockStatement block, ILanguage language) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\DecompilationPipeline.cs:line 100
			//    at Telerik.JustDecompiler.Decompiler.WriterContextServices.BaseWriterContextService.DecompileMethod(ILanguage language, MethodDefinition method, TypeSpecificContext typeContext) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\WriterContextServices\BaseWriterContextService.cs:line 133
			// 
			// mailto: JustDecompilePublicFeedback@telerik.com

		}

		// ‫‏‫‎‎​⁮‮‫​‎⁮​‮​‌‬‫‍⁭⁮‭⁭‭‌‭⁪‏‌⁯‫‌‭‏‏‌‫​‌‍‮
		private void u202b‏‫‎‎​⁮‮‫​‎⁮​‮​‌‬‫‍⁭⁮‭⁭‭‌‭⁪‏‌⁯‫‌‭‏‏‌‫​‌‍‮(object obj, FormClosingEventArgs formClosingEventArg)
		{
			TetraPanel.u206b‍⁮⁬⁬‍⁪‭⁯‍‬‌‏‏⁪⁯⁪‍‮⁬‮‏‬⁬‍‬‎‪⁯⁭⁬⁮⁯⁪‬‭⁪‌⁬⁬‮(formClosingEventArg, true);
			this.u202e‫⁮‭‏‎⁭⁪⁮‪‪⁫‬‮‭‭⁯‭‫​‫‭‮‭‪‫‭‍‎⁯‫‬‪‫​‎‌‎​‍‮ = true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		// ⁮‫⁭⁪‌‌​⁫⁪⁬‭‌‭‍⁬‬‍‎‭​‬⁯⁬‫‭​⁯‪‬⁯‎‍‏‎‫‭⁪‬‍‮‮
		private void u206e‫⁭⁪‌‌​⁫⁪⁬‭‌‭‍⁬‬‍‎‭​‬⁯⁬‫‭​⁯‪‬⁯‎‍‏‎‫‭⁪‬‍‮‮(object , PropertyChangedEventArgs )
		{
			// 
			// Current member / type: System.Void SDRSharp.Tetra.TetraPanel::⁮‫⁭⁪‌‌​⁫⁪⁬‭‌‭‍⁬‬‍‎‭​‬⁯⁬‫‭​⁯‪‬⁯‎‍‏‎‫‭⁪‬‍‮‮(System.Object,System.ComponentModel.PropertyChangedEventArgs)
			// File path: C:\SDRSharp\Plugins\Tetra\SDRSharp.Tetra.dll
			// 
			// Product version: 0.0.0.0
			// Exception in: System.Void ⁮‫⁭⁪‌‌​⁫⁪⁬‭‌‭‍⁬‬‍‎‭​‬⁯⁬‫‭​⁯‪‬⁯‎‍‏‎‫‭⁪‬‍‮‮(System.Object,System.ComponentModel.PropertyChangedEventArgs)
			// 
			// Not supported type System.Object.
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.GetTypeIndex(TypeDefinition type) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 684
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.GetContainingType(TypeDefinition leftType, TypeDefinition rightType) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 608
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.GetExpressionType() in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 492
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.get_ExpressionType() in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 414
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.AddAssignmentCastIfNeeded(Expression expr) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\TypeInference\TypeInferer.cs:line 112
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.FixAssignmentInList(IList`1 expressionList, Expression value) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\TypeInference\TypeInferer.cs:line 75
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.AddCasts() in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\TypeInference\TypeInferer.cs:line 38
			//    at Telerik.JustDecompiler.Decompiler.ExpressionDecompilerStep.Process(DecompilationContext theContext, BlockStatement body) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\ExpressionDecompilerStep.cs:line 68
			//    at Telerik.JustDecompiler.Decompiler.DecompilationPipeline.RunInternal(MethodBody body, BlockStatement block, ILanguage language) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\DecompilationPipeline.cs:line 100
			//    at Telerik.JustDecompiler.Decompiler.WriterContextServices.BaseWriterContextService.DecompileMethod(ILanguage language, MethodDefinition method, TypeSpecificContext typeContext) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\WriterContextServices\BaseWriterContextService.cs:line 133
			// 
			// mailto: JustDecompilePublicFeedback@telerik.com

		}

		// ‏⁮⁮⁮‬‎‪‮‏​⁮‮⁯​‭‪‭⁮‭‮‪‭​⁮‌‍‍⁪‎⁫⁭‍‎‫‎⁮⁮⁪⁭‭‮
		private void u200f⁮⁮⁮‬‎‪‮‏​⁮‮⁯​‭‪‭⁮‭‮‪‭​⁮‌‍‍⁪‎⁫⁭‍‎‫‎⁮⁮⁪⁭‭‮()
		{
			uint num;
			this.u200b​⁭‎⁬‎⁯‍‌⁬⁪⁭‭⁯‏‬‪‫‮⁪⁫⁬⁭⁭⁪⁭‌⁮⁪⁯⁫⁮‏‎⁫⁭‪‌⁬‭‮ = 3;
			TetraPanel.u206e⁭⁪⁬‎‮⁪‫​⁭‫‮​‮‎‌⁭⁯⁮‬‍⁫‫⁫‬‪⁮‬⁬⁪‌‏​⁯​⁭​⁫‮‫‮(this.u202c⁯⁯‏⁫‭‪‍‎⁫⁫‎⁯⁭‮‪⁪‌⁫‫⁭‎‪‌‎⁮‮⁬⁪⁯‪⁬‌‮‫⁫‏⁪‪‮‮);
			if (!this.u200b‍⁯⁪‌‍‍‎‪⁯⁮⁪‬⁯⁮⁮‍⁫‫⁭⁯​⁮⁮‫⁫‪‭‪⁪‪⁬⁫‬‎‌‎⁬‎⁫‮.TttModeEnabled)
			{
				SortedDictionary<int, CallsEntry> nums = this.u200f‪‍⁫⁭⁮‌‏⁭‍‏‭‪⁫‭⁮⁭‫‪‫⁬⁬‮⁫⁫​⁮‎⁪‪⁪‍⁬‮⁬‪‪‌‍⁬‮;
				bool flag = false;
				try
				{
					TetraPanel.u200b‭⁭​⁬‪⁫‌‏⁬‎⁮‬‮‏⁭⁭‫‪‬‏⁪⁪‪‌‌‮​‭‍‪‪‏‬⁯‍‬‏⁯⁯‮(nums, ref flag);
				Label0:
					int num1 = 105585175;
					while (true)
					{
						int num2 = num1 ^ 1117567913;
						num = (uint)num2;
						switch (num2 % 3)
						{
							case 0:
							{
								goto Label0;
							}
							case 1:
							{
								this.u200f‪‍⁫⁭⁮‌‏⁭‍‏‭‪⁫‭⁮⁭‫‪‫⁬⁬‮⁫⁫​⁮‎⁪‪⁪‍⁬‮⁬‪‪‌‍⁬‮.Clear();
								num1 = (int)(num * 1167721602 ^ -1866666096);
								continue;
							}
							case 2:
							{
								goto Label1;
							}
						}
					}
				Label1:
				}
				finally
				{
					if (!flag)
					{
						goto Label2;
					}
				Label3:
					int num3 = 55782698;
					while (true)
					{
						int num4 = num3 ^ 1117567913;
						num = (uint)num4;
						switch (num4 % 3)
						{
							case 0:
							{
								goto Label3;
							}
							case 1:
							{
								TetraPanel.u206b‭‍‫‭‪‌⁯⁫‌⁫‌‮‮‌‏⁪⁪​⁯‎‭⁫‪⁯⁭‭‎‏‍‌​‍‪⁮⁪‫‫‍‍‮(nums);
								num3 = (int)(num * -959255611 ^ -632432438);
								continue;
							}
							case 2:
							{
								goto Label2;
							}
						}
					}
				Label2:
				}
			}
			this.u206a‪⁭‎⁪‌‎‭⁭‎‏‬‪‏⁫‭‪⁫‍⁬⁫⁪‏⁪⁫​⁮‫⁯⁮‎⁭‪⁭‏‍⁮⁪‎⁬‮ = false;
			this.u202a⁮‍⁫‬⁭‌⁬⁫⁭​‭‭⁫‍‮⁬⁮⁬‎‏‮‭​⁪‏‪‌⁭‭‪‭‍⁪‪‌⁭‫⁪⁬‮ = false;
			this.u206e‍⁫⁫‪⁬⁪‬⁮​‭‮‬⁭‫‏⁮⁫‌‮‍​‎⁫⁫⁭‮‪‫‮⁯​‪​‎‬​‍⁬⁬‮ = 0;
			this.u202d‍⁮⁬‍‫‮⁮⁯‏‭​‭‍​‌⁮‫⁫⁮‪‏‬⁭‎​​‬‮‫⁪‍‎‌‭‎⁫‪‏‭‮ = -1;
		Label4:
			int num5 = 703817455;
			while (true)
			{
				int num6 = num5 ^ 1117567913;
				num = (uint)num6;
				switch (num6 % 10)
				{
					case 0:
					{
						this.u200e‭‌‭‫⁯‏​‭⁮​‪​‏‭‌‭‌‎⁮⁮‫⁭‬‏‪‫⁫‏⁬⁫‍⁫⁬⁪‬‏⁫‎‪‮ = 0;
						this.u202c‌⁯‌‍‏‍‬​‌‬⁪​‏⁫⁫⁭​‭‮‮⁭⁪​​​⁫‮‮‍​‫⁯​⁫⁮‫‬‭⁭‮ = 0;
						num5 = (int)(num * -156213290 ^ -285920621);
						continue;
					}
					case 1:
					{
						this.u200d‮‌⁯‏⁪‌⁯⁯‭‪‪⁪‌​‫‏‮⁬‪‮‏‬‬⁫⁪‍‍‌⁪⁬‫‮⁬⁬‪⁫⁭⁯⁬‮ = false;
						this.u206f‮‫‮‌‎⁮​‍⁮‬‏‮⁪‭‍‌‌‎⁯‮‪⁯‍‏⁯⁬‎‮‏‌⁫‏⁪‮‮⁬‏⁮‪‮ = false;
						this.u200f‭⁯‌‎⁫‏‪⁪‭‏‫‍⁫‪‏‌​‫​‮⁪‎‮⁬⁭⁯‮​‌‭‬⁮‍⁪​⁬‌‏⁪‮ = true;
						this.u202c‭‭‌‍‌⁫‭‬‌⁬⁭​⁮‮⁮‬⁬‎‪‍⁮‏‪⁭‫‬‮⁯⁬‪‬‬‫‎‮⁫‮‫‮ = (int)TetraPanel.u200c⁪‭‌‏⁯​⁯⁭⁮‫‫​⁭‏⁭⁮‍⁮⁯‭‪‭⁯‍⁪⁬⁯⁭⁭‫‮⁫​⁪‪‫‮‌⁬‮((double)(TetraPanel.u202a⁫‬‎⁯‌⁪‬‏⁯​‎‎‬⁬⁫⁭⁭‏⁮⁬‎‏⁬‮‭‎‫‬‏⁬‮‬⁭‪‍‭‏‫‬‮(this.u202a⁬‮⁬‬‮‏⁬‏⁯⁬​⁮​‌‫‍⁯‌⁬⁫‪⁬‬⁪⁪‫⁫⁭‎‍‫‫‬‮‬⁫⁯⁫‌‮) % (long)100000000) / 25000);
						TetraPanel.CurrentDmoCommunicationType = 0;
						num5 = (int)(num * -778126499 ^ 1166274915);
						continue;
					}
					case 2:
					{
						this.u200f‍⁫‍​⁫⁫⁫‏‮‎‪⁯‬⁭⁬⁪⁪⁯⁪⁮⁬⁮‫‍⁯⁭‎⁬‍‎‫⁫‏⁭⁯​​⁫‭‮ = false;
						num5 = (int)(num * -1094564934 ^ -951080316);
						continue;
					}
					case 3:
					{
						goto Label4;
					}
					case 4:
					{
						this.u206d⁭⁯‭⁬‍⁭⁪‫‫⁭⁪⁬‏‮​‌‏​⁭⁯⁮‪⁭⁫⁫⁭‍‍‪‭‎‮‭⁯​‎⁮⁬‮‮ = -1;
						this.u200c‏‭‬⁮‎​⁯⁯‮‏‪⁫⁯​⁭‫‏‌⁬‬⁯‪‬‍‭‫‮⁫‮‭‏‌​⁮‌⁯⁫⁭⁮‮ = -1;
						num5 = (int)(num * -709030695 ^ -645583063);
						continue;
					}
					case 5:
					{
						this.u206a‮⁬‮⁬‪⁫⁪⁪‫‭⁪⁬​‌⁭‍⁮‌‮‫‫‬⁭⁫⁭⁬⁮⁮⁫​‪‏‮‮‮​⁫‎⁫‮ = 0;
						this.u202b⁬⁪‫⁭⁪‪‎⁮⁬⁪⁪‎⁭‬‪‭⁯‫‬⁭‮‎‎⁫‪‍⁬‌⁪⁪⁫‍‌‪‬‮‎‏‭‮ = 0;
						this.u200b‪‭⁫‮‍⁫‫‫⁬⁬‌⁮⁭‪‍⁬‏‪⁫⁬⁫‮‪⁫‌‎‌⁫⁬‏⁫‬⁮‌⁮⁯‌⁪‪‮ = 0;
						num5 = (int)(num * -2130490138 ^ 124904975);
						continue;
					}
					case 6:
					{
						this.u202d‪⁮⁭‮⁯‮‏‌⁯‭⁬⁯⁫‮‌‍⁯⁫‏‏‪‌‬⁬‍⁬‭​⁭‏‫⁮⁬‌​‮‎‪⁬‮ = -1;
						this.u202b​‭⁭‭⁫​​‍‎⁭‬‏​⁫‮‏⁬‭‎‪‬⁮⁭‌⁬⁮‍⁪⁯⁪‌‍⁬‫⁭⁭⁪⁫⁫‮ = (long)0;
						num5 = (int)(num * 184984082 ^ 171893838);
						continue;
					}
					case 7:
					{
						this.u202c‬‬‮⁮⁯‮‏‮‬‍‬‏‪‭⁬‪⁮⁭⁭⁭‎⁭‎‭⁫​‪⁫‫‎⁫‬‌‌⁬⁪‌‪⁯‮ = false;
						num5 = (int)(num * -1393953832 ^ -1248216066);
						continue;
					}
					case 8:
					{
						this.u202c⁮​⁬⁭‭⁪‍‏‭⁭⁫‎⁬‭‍‍‭⁭⁪‍‭‎⁭⁯⁭‭‭‮‮⁭‌⁪​⁬‮⁯⁬⁫‏‮ = 0;
						num5 = (int)(num * 696795319 ^ -1111499175);
						continue;
					}
					case 9:
					{
						return;
					}
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		// ‮‬⁫‮‌‬‪⁯⁭‬‭‬‪‮‫⁭⁯‫‌⁬⁭⁭‍‭⁫‍⁬‫‬‪‎‭‮⁬‬⁭‌⁭⁫‌‮
		private void u202e‬⁫‮‌‬‪⁯⁭‬‭‬‪‮‫⁭⁯‫‌⁬⁭⁭‍‭⁫‍⁬‫‬‪‎‭‮⁬‬⁭‌⁭⁫‌‮()
		{
			this.u200c‭‫⁮‪‭‮‍‏‎⁮​‫‬‫‮⁪⁭‏⁯⁪⁮⁭⁪‫​‏‮‌‪‬‫‭‬⁫‬‮‫‭⁯‮.Enabled = true;
		Label1:
			int num = 639309214;
			while (true)
			{
				int num1 = num ^ 1367093916;
				uint num2 = (uint)num1;
				switch (num1 % 6)
				{
					case 0:
					{
						return;
					}
					case 1:
					{
						Thread thread = TetraPanel.u202b⁭⁯⁪‎⁪‮⁮⁭⁬⁯⁭‎‬‎⁪‏‫⁮⁪‌⁯‍⁭‮⁯‏‎‪‪⁫⁯⁯‍⁯‪‫‌‫‎‮(new ThreadStart(this.u202c⁬⁭‬‌⁪⁭⁭⁪​‎⁭‍⁯‪⁪‎⁮‪‪‮‎⁪⁪‪‭⁬‏‬‎​⁮⁮⁫‎​‍⁯‍⁯‮));
						TetraPanel.u206f​‍‮‎‬⁯‮⁬‍‬⁯⁫‪⁯‏⁭⁫⁮‪‬‭⁪​⁭​‬‎‏‮‏⁯‍‏⁭‍‎⁫⁪‏‮(thread, u003cModuleu003e.u200f⁫‌​⁬‌‎‎‏‍‍⁫‎​‌‬⁯‬‫‭‎‏​‌​⁪‭‬⁬‮⁬​‌⁬⁪‫‫‎⁪⁮‮<string>(-587333520));
						TetraPanel.u200b‏‌‬⁫‎⁫⁮‮​‌⁪‮⁪⁬‏‮‌⁬⁪⁪⁪⁬⁪‎⁪⁯⁮⁬⁭‫‍⁪‭‏‬⁫‍⁯‮‮(thread, ThreadPriority.Normal);
						this.u206b​‫‌‬​⁫‎‫⁫​⁫‬‎⁪⁭‮⁫⁭‪‮‏‍‮‫‫‪‫‎‎⁬⁮‪‍⁫⁪​‮‭⁯‮ = thread;
						num = 1752936613;
						continue;
					}
					case 2:
					{
						this.u206e⁮⁫‏‪⁮⁪‏‭‬​⁯⁫‍⁬‬⁮⁭​‌‏‍⁫​⁪⁮⁭‮⁮‭⁮⁭​​‍‌⁭‬‌⁬‮ = true;
						num = (int)(num2 * -1864473483 ^ -539252403);
						continue;
					}
					case 3:
					{
						this.u206d​⁬​‮‏​​⁯‌‌‌‫‌‍‪‏‎⁪⁭⁬‫‫‮⁪‪‮‍‬‪‎‌⁯⁮⁯‌⁬⁫⁪‏‮();
						num = (int)(num2 * -483657912 ^ 1110048230);
						continue;
					}
					case 4:
					{
						goto Label1;
					}
					case 5:
					{
						TetraPanel.u200e‮⁬‬⁯⁯‭‍⁪‫‫‍⁭⁬‌‫‏⁫⁬‭‌⁮‬‬‎⁫‍‬⁮⁬⁮‬‍‌⁮‬⁬⁪⁪‍‮(this.u206b​‫‌‬​⁫‎‫⁫​⁫‬‎⁪⁭‮⁫⁭‪‮‏‍‮‫‫‪‫‎‎⁬⁮‪‍⁫⁪​‮‭⁯‮);
						num = (int)(num2 * -1192059518 ^ -211404475);
						continue;
					}
				}
			}
		}

		// ⁯⁯⁪‬‪‪‬‪⁭‏⁪‎⁬‭⁬‪‪‫‭‏‮⁬⁯‪⁯‎‬‭⁫‪‮‪‎‍⁬‮‫‬⁬‪‮
		private void u206f⁯⁪‬‪‪‬‪⁭‏⁪‎⁬‭⁬‪‪‫‭‏‮⁬⁯‪⁯‎‬‭⁫‪‮‪‎‍⁬‮‫‬⁬‪‮()
		{
			int num;
			this.u200c‭‫⁮‪‭‮‍‏‎⁮​‫‬‫‮⁪⁭‏⁯⁪⁮⁭⁪‫​‏‮‌‪‬‫‭‬⁫‬‮‫‭⁯‮.Enabled = false;
		Label1:
			int num1 = 1592299334;
			while (true)
			{
				int num2 = num1 ^ 1269581767;
				uint num3 = (uint)num2;
				switch (num2 % 7)
				{
					case 0:
					{
						return;
					}
					case 1:
					{
						this.u206e⁮⁫‏‪⁮⁪‏‭‬​⁯⁫‍⁬‬⁮⁭​‌‏‍⁫​⁪⁮⁭‮⁮‭⁮⁭​​‍‌⁭‬‌⁬‮ = false;
						num1 = (int)(num3 * -299982979 ^ -886712238);
						continue;
					}
					case 2:
					{
						this.u200b⁮​⁫⁬‍‫⁬⁯⁬‫⁬​‮‪‎‌‌‍‬⁫‍⁯‮‏‮⁬⁭​⁪⁫‪‫‮⁯⁪‍⁯⁭‮‮();
						num1 = 1627772294;
						continue;
					}
					case 3:
					{
						TetraPanel.u206c‭‬⁯⁬⁭‫‎⁬​‫‪⁫‏⁭‫‮⁮⁮‍‮‪‮‎‪‬‏‌‬​​‍‪‫‫‍​‍⁯‪‮(this.u206b​‫‌‬​⁫‎‫⁫​⁫‬‎⁪⁭‮⁫⁭‪‮‏‍‮‫‫‪‫‎‎⁬⁮‪‍⁫⁪​‮‭⁯‮);
						num1 = (int)(num3 * 382956853 ^ 15895016);
						continue;
					}
					case 4:
					{
						this.u206b​‫‌‬​⁫‎‫⁫​⁫‬‎⁪⁭‮⁫⁭‪‮‏‍‮‫‫‪‫‎‎⁬⁮‪‍⁫⁪​‮‭⁯‮ = null;
						num1 = (int)(num3 * -1253323163 ^ -341759118);
						continue;
					}
					case 5:
					{
						num = (this.u206b​‫‌‬​⁫‎‫⁫​⁫‬‎⁪⁭‮⁫⁭‪‮‏‍‮‫‫‪‫‎‎⁬⁮‪‍⁫⁪​‮‭⁯‮ == null ? 1633980921 : 535262599);
						num1 = (int)(num ^ num3 * 1519741254);
						continue;
					}
					case 6:
					{
						goto Label1;
					}
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		// ‭‪‌‍​⁬⁫​‭⁫⁪‭‮‎⁫‍‬‪⁫‮⁫‬‏‏⁬‪​‬⁭⁭‎⁮⁭‫‮‍⁪‌⁭‮‮
		private bool u202d‪‌‍​⁬⁫​‭⁫⁪‭‮‎⁫‍‬‪⁫‮⁫‬‏‏⁬‪​‬⁭⁭‎⁮⁭‫‮‍⁪‌⁭‮‮()
		{
			// 
			// Current member / type: System.Boolean SDRSharp.Tetra.TetraPanel::‭‪‌‍​⁬⁫​‭⁫⁪‭‮‎⁫‍‬‪⁫‮⁫‬‏‏⁬‪​‬⁭⁭‎⁮⁭‫‮‍⁪‌⁭‮‮()
			// File path: C:\SDRSharp\Plugins\Tetra\SDRSharp.Tetra.dll
			// 
			// Product version: 0.0.0.0
			// Exception in: System.Boolean ‭‪‌‍​⁬⁫​‭⁫⁪‭‮‎⁫‍‬‪⁫‮⁫‬‏‏⁬‪​‬⁭⁭‎⁮⁭‫‮‍⁪‌⁭‮‮()
			// 
			// Not supported type System.Object.
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.GetTypeIndex(TypeDefinition type) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 684
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.GetContainingType(TypeDefinition leftType, TypeDefinition rightType) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 608
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.GetExpressionType() in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 492
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.get_ExpressionType() in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 414
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.AddAssignmentCastIfNeeded(Expression expr) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\TypeInference\TypeInferer.cs:line 112
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.FixAssignmentInList(IList`1 expressionList, Expression value) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\TypeInference\TypeInferer.cs:line 75
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.AddCasts() in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\TypeInference\TypeInferer.cs:line 38
			//    at Telerik.JustDecompiler.Decompiler.ExpressionDecompilerStep.Process(DecompilationContext theContext, BlockStatement body) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\ExpressionDecompilerStep.cs:line 68
			//    at Telerik.JustDecompiler.Decompiler.DecompilationPipeline.RunInternal(MethodBody body, BlockStatement block, ILanguage language) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\DecompilationPipeline.cs:line 100
			//    at Telerik.JustDecompiler.Decompiler.WriterContextServices.BaseWriterContextService.DecompileMethod(ILanguage language, MethodDefinition method, TypeSpecificContext typeContext) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\WriterContextServices\BaseWriterContextService.cs:line 133
			// 
			// mailto: JustDecompilePublicFeedback@telerik.com

		}

		// ⁮‭⁭⁭‬⁪⁮‎‭‫⁬‮‭‫‎‌⁯‍⁪​‫‏‏⁮⁭‬‪⁭‪⁭‭‫⁬⁮‌‎‍⁭⁬‌‮
		private unsafe void u206e‭⁭⁭‬⁪⁮‎‭‫⁬‮‭‫‎‌⁯‍⁪​‫‏‏⁮⁭‬‪⁭‪⁭‭‫⁬⁮‌‎‍⁭⁬‌‮(float* , int )
		{
			// 
			// Current member / type: System.Void SDRSharp.Tetra.TetraPanel::⁮‭⁭⁭‬⁪⁮‎‭‫⁬‮‭‫‎‌⁯‍⁪​‫‏‏⁮⁭‬‪⁭‪⁭‭‫⁬⁮‌‎‍⁭⁬‌‮(System.Single*,System.Int32)
			// File path: C:\SDRSharp\Plugins\Tetra\SDRSharp.Tetra.dll
			// 
			// Product version: 0.0.0.0
			// Exception in: System.Void ⁮‭⁭⁭‬⁪⁮‎‭‫⁬‮‭‫‎‌⁯‍⁪​‫‏‏⁮⁭‬‪⁭‪⁭‭‫⁬⁮‌‎‍⁭⁬‌‮(System.Single*,System.Int32)
			// 
			// Not supported type System.Object.
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.GetTypeIndex(TypeDefinition type) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 684
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.GetContainingType(TypeDefinition leftType, TypeDefinition rightType) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 608
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.GetExpressionType() in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 492
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.get_ExpressionType() in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 414
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.AddAssignmentCastIfNeeded(Expression expr) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\TypeInference\TypeInferer.cs:line 112
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.FixAssignmentInList(IList`1 expressionList, Expression value) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\TypeInference\TypeInferer.cs:line 75
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.AddCasts() in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\TypeInference\TypeInferer.cs:line 38
			//    at Telerik.JustDecompiler.Decompiler.ExpressionDecompilerStep.Process(DecompilationContext theContext, BlockStatement body) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\ExpressionDecompilerStep.cs:line 68
			//    at Telerik.JustDecompiler.Decompiler.DecompilationPipeline.RunInternal(MethodBody body, BlockStatement block, ILanguage language) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\DecompilationPipeline.cs:line 100
			//    at Telerik.JustDecompiler.Decompiler.WriterContextServices.BaseWriterContextService.DecompileMethod(ILanguage language, MethodDefinition method, TypeSpecificContext typeContext) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\WriterContextServices\BaseWriterContextService.cs:line 133
			// 
			// mailto: JustDecompilePublicFeedback@telerik.com

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		// ⁭​⁬​‮‏​​⁯‌‌‌‫‌‍‪‏‎⁪⁭⁬‫‫‮⁪‪‮‍‬‪‎‌⁯⁮⁯‌⁬⁫⁪‏‮
		private void u206d​⁬​‮‏​​⁯‌‌‌‫‌‍‪‏‎⁪⁭⁬‫‫‮⁪‪‮‍‬‪‎‌⁯⁮⁯‌⁬⁫⁪‏‮()
		{
			this.u206c‍‪‍‌‏⁯‬⁪‪​⁪⁮⁮⁫‎⁪⁯​‪⁭‍⁭‌‮‍⁬⁬‮‫‪⁯⁫‮‎‮‍‎⁭‮ = true;
			Thread thread = TetraPanel.u202b⁭⁯⁪‎⁪‮⁮⁭⁬⁯⁭‎‬‎⁪‏‫⁮⁪‌⁯‍⁭‮⁯‏‎‪‪⁫⁯⁯‍⁯‪‫‌‫‎‮(new ThreadStart(this.u206c‎‌⁪⁫⁯‮⁪⁮‍‬‮‫⁫⁫⁭‍‪‭‏⁯‏⁪⁮⁯‎‪‬‏‎⁯‬‬⁯⁬⁯‬‪⁯‮‮));
			TetraPanel.u200b‏‌‬⁫‎⁫⁮‮​‌⁪‮⁪⁬‏‮‌⁬⁪⁪⁪⁬⁪‎⁪⁯⁮⁬⁭‫‍⁪‭‏‬⁫‍⁯‮‮(thread, ThreadPriority.Normal);
			TetraPanel.u206f​‍‮‎‬⁯‮⁬‍‬⁯⁫‪⁯‏⁭⁫⁮‪‬‭⁪​⁭​‬‎‏‮‏⁯‍‏⁭‍‎⁫⁪‏‮(thread, u003cModuleu003e.u202a‮‫‏‫‬‬‪⁫⁬​‏⁫⁭‍‪‪‎⁬​‪​‌⁮‮‌​⁫​⁬‪‫⁪⁯⁪‎‫⁭‎⁪‮<string>(-1346790001));
			this.u206e⁪‎‮‫‎‌⁪‏‪‫‌‏‮⁫⁯‌‪‍‪‪‍⁭‬⁮‮⁬⁪‌⁫‌⁯‪⁭‏‎‫‪⁯‭‮ = thread;
		Label0:
			int num = 229289250;
			while (true)
			{
				int num1 = num ^ 1140225073;
				uint num2 = (uint)num1;
				switch (num1 % 3)
				{
					case 0:
					{
						goto Label0;
					}
					case 1:
					{
						TetraPanel.u200e‮⁬‬⁯⁯‭‍⁪‫‫‍⁭⁬‌‫‏⁫⁬‭‌⁮‬‬‎⁫‍‬⁮⁬⁮‬‍‌⁮‬⁬⁪⁪‍‮(this.u206e⁪‎‮‫‎‌⁪‏‪‫‌‏‮⁫⁯‌‪‍‪‪‍⁭‬⁮‮⁬⁪‌⁫‌⁯‪⁭‏‎‫‪⁯‭‮);
						this.u202c⁪​‬‫⁫‭⁫‪‫⁪⁭‮⁮⁫‫‭⁮‬‌‎‬⁮⁭⁭‭‪‪‮‌‬‪⁫​‮⁬‍⁪‍‏‮.Enabled = true;
						num = (int)(num2 * -133428718 ^ -206846268);
						continue;
					}
					case 2:
					{
						this.u200e‫⁯​‍⁯‎‬‫‭⁯‮‎‍‌‭⁪⁭⁮‎⁯⁫‬‌‌⁬‪‏‫‏⁮‌‭​‬‮⁪‌⁬‍‮ = true;
						return;
					}
				}
			}
			this.u200e‫⁯​‍⁯‎‬‫‭⁯‮‎‍‌‭⁪⁭⁮‎⁯⁫‬‌‌⁬‪‏‫‏⁮‌‭​‬‮⁪‌⁬‍‮ = true;
		}

		// ​⁮​⁫⁬‍‫⁬⁯⁬‫⁬​‮‪‎‌‌‍‬⁫‍⁯‮‏‮⁬⁭​⁪⁫‪‫‮⁯⁪‍⁯⁭‮‮
		private void u200b⁮​⁫⁬‍‫⁬⁯⁬‫⁬​‮‪‎‌‌‍‬⁫‍⁯‮‏‮⁬⁭​⁪⁫‪‫‮⁯⁪‍⁯⁭‮‮()
		{
			int num;
			this.u202c⁪​‬‫⁫‭⁫‪‫⁪⁭‮⁮⁫‫‭⁮‬‌‎‬⁮⁭⁭‭‪‪‮‌‬‪⁫​‮⁬‍⁪‍‏‮.Enabled = false;
		Label0:
			int num1 = -1636053105;
			while (true)
			{
				int num2 = num1 ^ -1971544847;
				uint num3 = (uint)num2;
				switch (num2 % 6)
				{
					case 0:
					{
						this.u206e⁪‎‮‫‎‌⁪‏‪‫‌‏‮⁫⁯‌‪‍‪‪‍⁭‬⁮‮⁬⁪‌⁫‌⁯‪⁭‏‎‫‪⁯‭‮ = null;
						num1 = (int)(num3 * 564878578 ^ 2115631244);
						continue;
					}
					case 1:
					{
						TetraPanel.u206c‭‬⁯⁬⁭‫‎⁬​‫‪⁫‏⁭‫‮⁮⁮‍‮‪‮‎‪‬‏‌‬​​‍‪‫‫‍​‍⁯‪‮(this.u206e⁪‎‮‫‎‌⁪‏‪‫‌‏‮⁫⁯‌‪‍‪‪‍⁭‬⁮‮⁬⁪‌⁫‌⁯‪⁭‏‎‫‪⁯‭‮);
						num1 = (int)(num3 * -435914051 ^ 1300705740);
						continue;
					}
					case 2:
					{
						this.u206c‍‪‍‌‏⁯‬⁪‪​⁪⁮⁮⁫‎⁪⁯​‪⁭‍⁭‌‮‍⁬⁬‮‫‪⁯⁫‮‎‮‍‎⁭‮ = false;
						num1 = (int)(num3 * 938786222 ^ 832556630);
						continue;
					}
					case 3:
					{
						num = (this.u206e⁪‎‮‫‎‌⁪‏‪‫‌‏‮⁫⁯‌‪‍‪‪‍⁭‬⁮‮⁬⁪‌⁫‌⁯‪⁭‏‎‫‪⁯‭‮ != null ? 1289476516 : 1251730506);
						num1 = (int)(num ^ num3 * -730756098);
						continue;
					}
					case 4:
					{
						goto Label0;
					}
					case 5:
					{
						TetraPanel.u206a‭⁬⁭⁮‎‎⁮⁪⁮‌⁫‫⁫​‪‪⁭⁭⁯‫⁯‏⁬⁬‌⁫⁮⁯‫‪⁪⁮‎⁮‏⁮⁪⁭‍‮(this.u202a⁬‮⁬‬‮‏⁬‏⁯⁬​⁮​‌‫‍⁯‌⁬⁫‪⁬‬⁪⁪‫⁫⁭‎‍‫‫‬‮‬⁫⁯⁫‌‮, false);
						return;
					}
				}
			}
			TetraPanel.u206a‭⁬⁭⁮‎‎⁮⁪⁮‌⁫‫⁫​‪‪⁭⁭⁯‫⁯‏⁬⁬‌⁫⁮⁯‫‪⁪⁮‎⁮‏⁮⁪⁭‍‮(this.u202a⁬‮⁬‬‮‏⁬‏⁯⁬​⁮​‌‫‍⁯‌⁬⁫‪⁬‬⁪⁪‫⁫⁭‎‍‫‫‬‮‬⁫⁯⁫‌‮, false);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		// ‬⁬⁭‬‌⁪⁭⁭⁪​‎⁭‍⁯‪⁪‎⁮‪‪‮‎⁪⁪‪‭⁬‏‬‎​⁮⁮⁫‎​‍⁯‍⁯‮
		private void u202c⁬⁭‬‌⁪⁭⁭⁪​‎⁭‍⁯‪⁪‎⁮‪‪‮‎⁪⁪‪‭⁬‏‬‎​⁮⁮⁫‎​‍⁯‍⁯‮()
		{
			// 
			// Current member / type: System.Void SDRSharp.Tetra.TetraPanel::‬⁬⁭‬‌⁪⁭⁭⁪​‎⁭‍⁯‪⁪‎⁮‪‪‮‎⁪⁪‪‭⁬‏‬‎​⁮⁮⁫‎​‍⁯‍⁯‮()
			// File path: C:\SDRSharp\Plugins\Tetra\SDRSharp.Tetra.dll
			// 
			// Product version: 0.0.0.0
			// Exception in: System.Void ‬⁬⁭‬‌⁪⁭⁭⁪​‎⁭‍⁯‪⁪‎⁮‪‪‮‎⁪⁪‪‭⁬‏‬‎​⁮⁮⁫‎​‍⁯‍⁯‮()
			// 
			// Not supported type System.Object.
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.GetTypeIndex(TypeDefinition type) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 684
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.GetContainingType(TypeDefinition leftType, TypeDefinition rightType) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 608
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.GetExpressionType() in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 492
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.get_ExpressionType() in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 414
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.AddAssignmentCastIfNeeded(Expression expr) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\TypeInference\TypeInferer.cs:line 112
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.FixAssignmentInList(IList`1 expressionList, Expression value) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\TypeInference\TypeInferer.cs:line 75
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.AddCasts() in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\TypeInference\TypeInferer.cs:line 38
			//    at Telerik.JustDecompiler.Decompiler.ExpressionDecompilerStep.Process(DecompilationContext theContext, BlockStatement body) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\ExpressionDecompilerStep.cs:line 68
			//    at Telerik.JustDecompiler.Decompiler.DecompilationPipeline.RunInternal(MethodBody body, BlockStatement block, ILanguage language) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\DecompilationPipeline.cs:line 100
			//    at Telerik.JustDecompiler.Decompiler.WriterContextServices.BaseWriterContextService.DecompileMethod(ILanguage language, MethodDefinition method, TypeSpecificContext typeContext) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\WriterContextServices\BaseWriterContextService.cs:line 133
			// 
			// mailto: JustDecompilePublicFeedback@telerik.com

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		// ⁬‎‌⁪⁫⁯‮⁪⁮‍‬‮‫⁫⁫⁭‍‪‭‏⁯‏⁪⁮⁯‎‪‬‏‎⁯‬‬⁯⁬⁯‬‪⁯‮‮
		private void u206c‎‌⁪⁫⁯‮⁪⁮‍‬‮‫⁫⁫⁭‍‪‭‏⁯‏⁪⁮⁯‎‪‬‏‎⁯‬‬⁯⁬⁯‬‪⁯‮‮()
		{
			// 
			// Current member / type: System.Void SDRSharp.Tetra.TetraPanel::⁬‎‌⁪⁫⁯‮⁪⁮‍‬‮‫⁫⁫⁭‍‪‭‏⁯‏⁪⁮⁯‎‪‬‏‎⁯‬‬⁯⁬⁯‬‪⁯‮‮()
			// File path: C:\SDRSharp\Plugins\Tetra\SDRSharp.Tetra.dll
			// 
			// Product version: 0.0.0.0
			// Exception in: System.Void ⁬‎‌⁪⁫⁯‮⁪⁮‍‬‮‫⁫⁫⁭‍‪‭‏⁯‏⁪⁮⁯‎‪‬‏‎⁯‬‬⁯⁬⁯‬‪⁯‮‮()
			// 
			// Not supported type System.Object.
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.GetTypeIndex(TypeDefinition type) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 684
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.GetContainingType(TypeDefinition leftType, TypeDefinition rightType) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 608
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.GetExpressionType() in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 492
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.get_ExpressionType() in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 414
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.AddAssignmentCastIfNeeded(Expression expr) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\TypeInference\TypeInferer.cs:line 112
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.FixAssignmentInList(IList`1 expressionList, Expression value) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\TypeInference\TypeInferer.cs:line 75
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.AddCasts() in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\TypeInference\TypeInferer.cs:line 38
			//    at Telerik.JustDecompiler.Decompiler.ExpressionDecompilerStep.Process(DecompilationContext theContext, BlockStatement body) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\ExpressionDecompilerStep.cs:line 68
			//    at Telerik.JustDecompiler.Decompiler.DecompilationPipeline.RunInternal(MethodBody body, BlockStatement block, ILanguage language) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\DecompilationPipeline.cs:line 100
			//    at Telerik.JustDecompiler.Decompiler.WriterContextServices.BaseWriterContextService.DecompileMethod(ILanguage language, MethodDefinition method, TypeSpecificContext typeContext) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\WriterContextServices\BaseWriterContextService.cs:line 133
			// 
			// mailto: JustDecompilePublicFeedback@telerik.com

		}

		// ⁪⁭‎‬‌⁮‭⁬‌‎‪⁭⁯‮‭⁯​‬‏‍⁪‌⁯‬⁮​‭⁫‬⁭⁯⁫‬⁫‌‮‍⁯⁪‪‮
		private unsafe byte[] u206a⁭‎‬‌⁮‭⁬‌‎‪⁭⁯‮‭⁯​‬‏‍⁪‌⁯‬⁮​‭⁫‬⁭⁯⁫‬⁫‌‮‍⁯⁪‪‮(short* , int )
		{
			// 
			// Current member / type: System.Byte[] SDRSharp.Tetra.TetraPanel::⁪⁭‎‬‌⁮‭⁬‌‎‪⁭⁯‮‭⁯​‬‏‍⁪‌⁯‬⁮​‭⁫‬⁭⁯⁫‬⁫‌‮‍⁯⁪‪‮(System.Int16*,System.Int32)
			// File path: C:\SDRSharp\Plugins\Tetra\SDRSharp.Tetra.dll
			// 
			// Product version: 0.0.0.0
			// Exception in: System.Byte[] ⁪⁭‎‬‌⁮‭⁬‌‎‪⁭⁯‮‭⁯​‬‏‍⁪‌⁯‬⁮​‭⁫‬⁭⁯⁫‬⁫‌‮‍⁯⁪‪‮(System.Int16*,System.Int32)
			// 
			// Not supported type System.Object.
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.GetTypeIndex(TypeDefinition type) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 684
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.GetContainingType(TypeDefinition leftType, TypeDefinition rightType) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 608
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.GetExpressionType() in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 492
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.get_ExpressionType() in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 414
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.AddAssignmentCastIfNeeded(Expression expr) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\TypeInference\TypeInferer.cs:line 112
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.FixAssignmentInList(IList`1 expressionList, Expression value) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\TypeInference\TypeInferer.cs:line 75
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.AddCasts() in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\TypeInference\TypeInferer.cs:line 38
			//    at Telerik.JustDecompiler.Decompiler.ExpressionDecompilerStep.Process(DecompilationContext theContext, BlockStatement body) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\ExpressionDecompilerStep.cs:line 68
			//    at Telerik.JustDecompiler.Decompiler.DecompilationPipeline.RunInternal(MethodBody body, BlockStatement block, ILanguage language) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\DecompilationPipeline.cs:line 100
			//    at Telerik.JustDecompiler.Decompiler.WriterContextServices.BaseWriterContextService.DecompileMethod(ILanguage language, MethodDefinition method, TypeSpecificContext typeContext) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\WriterContextServices\BaseWriterContextService.cs:line 133
			// 
			// mailto: JustDecompilePublicFeedback@telerik.com

		}

		// ⁬⁭‍‍‫⁮​⁪⁮⁯⁪⁯‏‭‪‪‏⁮‬⁫⁯‭‍⁬‮‪⁪‍‪⁪‫‎⁪‌‫‎‪‍⁯‌‮
		private unsafe void u206c⁭‍‍‫⁮​⁪⁮⁯⁪⁯‏‭‪‪‏⁮‬⁫⁯‭‍⁬‮‪⁪‍‪⁪‫‎⁪‌‫‎‪‍⁯‌‮(byte* , float* , int , int )
		{
			// 
			// Current member / type: System.Void SDRSharp.Tetra.TetraPanel::⁬⁭‍‍‫⁮​⁪⁮⁯⁪⁯‏‭‪‪‏⁮‬⁫⁯‭‍⁬‮‪⁪‍‪⁪‫‎⁪‌‫‎‪‍⁯‌‮(System.Byte*,System.Single*,System.Int32,System.Int32)
			// File path: C:\SDRSharp\Plugins\Tetra\SDRSharp.Tetra.dll
			// 
			// Product version: 0.0.0.0
			// Exception in: System.Void ⁬⁭‍‍‫⁮​⁪⁮⁯⁪⁯‏‭‪‪‏⁮‬⁫⁯‭‍⁬‮‪⁪‍‪⁪‫‎⁪‌‫‎‪‍⁯‌‮(System.Byte*,System.Single*,System.Int32,System.Int32)
			// 
			// Not supported type System.Object.
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.GetTypeIndex(TypeDefinition type) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 684
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.GetContainingType(TypeDefinition leftType, TypeDefinition rightType) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 608
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.GetExpressionType() in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 492
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.get_ExpressionType() in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 414
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.AddAssignmentCastIfNeeded(Expression expr) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\TypeInference\TypeInferer.cs:line 112
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.FixAssignmentInList(IList`1 expressionList, Expression value) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\TypeInference\TypeInferer.cs:line 75
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.AddCasts() in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\TypeInference\TypeInferer.cs:line 38
			//    at Telerik.JustDecompiler.Decompiler.ExpressionDecompilerStep.Process(DecompilationContext theContext, BlockStatement body) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\ExpressionDecompilerStep.cs:line 68
			//    at Telerik.JustDecompiler.Decompiler.DecompilationPipeline.RunInternal(MethodBody body, BlockStatement block, ILanguage language) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\DecompilationPipeline.cs:line 100
			//    at Telerik.JustDecompiler.Decompiler.WriterContextServices.BaseWriterContextService.DecompileMethod(ILanguage language, MethodDefinition method, TypeSpecificContext typeContext) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\WriterContextServices\BaseWriterContextService.cs:line 133
			// 
			// mailto: JustDecompilePublicFeedback@telerik.com

		}

		// ‍‏‏⁯‎⁬‬⁭‭‭⁮⁮⁬‎‎‍⁭‌‎‏⁫‭⁫‪⁯‎⁯‎‫‎‪⁪‫‍⁯⁯‬⁪⁪⁪‮
		private unsafe void u200d‏‏⁯‎⁬‬⁭‭‭⁮⁮⁬‎‎‍⁭‌‎‏⁫‭⁫‪⁯‎⁯‎‫‎‪⁪‫‍⁯⁯‬⁪⁪⁪‮(short* , float* )
		{
			// 
			// Current member / type: System.Void SDRSharp.Tetra.TetraPanel::‍‏‏⁯‎⁬‬⁭‭‭⁮⁮⁬‎‎‍⁭‌‎‏⁫‭⁫‪⁯‎⁯‎‫‎‪⁪‫‍⁯⁯‬⁪⁪⁪‮(System.Int16*,System.Single*)
			// File path: C:\SDRSharp\Plugins\Tetra\SDRSharp.Tetra.dll
			// 
			// Product version: 0.0.0.0
			// Exception in: System.Void ‍‏‏⁯‎⁬‬⁭‭‭⁮⁮⁬‎‎‍⁭‌‎‏⁫‭⁫‪⁯‎⁯‎‫‎‪⁪‫‍⁯⁯‬⁪⁪⁪‮(System.Int16*,System.Single*)
			// 
			// Not supported type System.Object.
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.GetTypeIndex(TypeDefinition type) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 684
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.GetContainingType(TypeDefinition leftType, TypeDefinition rightType) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 608
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.GetExpressionType() in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 492
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.get_ExpressionType() in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 414
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.AddAssignmentCastIfNeeded(Expression expr) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\TypeInference\TypeInferer.cs:line 112
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.FixAssignmentInList(IList`1 expressionList, Expression value) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\TypeInference\TypeInferer.cs:line 75
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.AddCasts() in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\TypeInference\TypeInferer.cs:line 38
			//    at Telerik.JustDecompiler.Decompiler.ExpressionDecompilerStep.Process(DecompilationContext theContext, BlockStatement body) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\ExpressionDecompilerStep.cs:line 68
			//    at Telerik.JustDecompiler.Decompiler.DecompilationPipeline.RunInternal(MethodBody body, BlockStatement block, ILanguage language) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\DecompilationPipeline.cs:line 100
			//    at Telerik.JustDecompiler.Decompiler.WriterContextServices.BaseWriterContextService.DecompileMethod(ILanguage language, MethodDefinition method, TypeSpecificContext typeContext) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\WriterContextServices\BaseWriterContextService.cs:line 133
			// 
			// mailto: JustDecompilePublicFeedback@telerik.com

		}

		// ‍‏‏⁯‎⁬‬⁭‭‭⁮⁮⁬‎‎‍⁭‌‎‏⁫‭⁫‪⁯‎⁯‎‫‎‪⁪‫‍⁯⁯‬⁪⁪⁪‮
		private unsafe void u200d‏‏⁯‎⁬‬⁭‭‭⁮⁮⁬‎‎‍⁭‌‎‏⁫‭⁫‪⁯‎⁯‎‫‎‪⁪‫‍⁯⁯‬⁪⁪⁪‮(float* , int )
		{
			// 
			// Current member / type: System.Void SDRSharp.Tetra.TetraPanel::‍‏‏⁯‎⁬‬⁭‭‭⁮⁮⁬‎‎‍⁭‌‎‏⁫‭⁫‪⁯‎⁯‎‫‎‪⁪‫‍⁯⁯‬⁪⁪⁪‮(System.Single*,System.Int32)
			// File path: C:\SDRSharp\Plugins\Tetra\SDRSharp.Tetra.dll
			// 
			// Product version: 0.0.0.0
			// Exception in: System.Void ‍‏‏⁯‎⁬‬⁭‭‭⁮⁮⁬‎‎‍⁭‌‎‏⁫‭⁫‪⁯‎⁯‎‫‎‪⁪‫‍⁯⁯‬⁪⁪⁪‮(System.Single*,System.Int32)
			// 
			// Not supported type System.Object.
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.GetTypeIndex(TypeDefinition type) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 684
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.GetContainingType(TypeDefinition leftType, TypeDefinition rightType) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 608
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.GetExpressionType() in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 492
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.get_ExpressionType() in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 414
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.AddAssignmentCastIfNeeded(Expression expr) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\TypeInference\TypeInferer.cs:line 112
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.FixAssignmentInList(IList`1 expressionList, Expression value) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\TypeInference\TypeInferer.cs:line 75
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.AddCasts() in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\TypeInference\TypeInferer.cs:line 38
			//    at Telerik.JustDecompiler.Decompiler.ExpressionDecompilerStep.Process(DecompilationContext theContext, BlockStatement body) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\ExpressionDecompilerStep.cs:line 68
			//    at Telerik.JustDecompiler.Decompiler.DecompilationPipeline.RunInternal(MethodBody body, BlockStatement block, ILanguage language) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\DecompilationPipeline.cs:line 100
			//    at Telerik.JustDecompiler.Decompiler.WriterContextServices.BaseWriterContextService.DecompileMethod(ILanguage language, MethodDefinition method, TypeSpecificContext typeContext) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\WriterContextServices\BaseWriterContextService.cs:line 133
			// 
			// mailto: JustDecompilePublicFeedback@telerik.com

		}

		// ‮‪‌‏‬⁮‏‬‎‎‍⁪⁪‏⁯‫‮‌‍⁬‌​​‮⁬‬‬⁪⁭⁬​‎‮⁯⁪⁯⁫‏​‌‮
		private unsafe int u202e‪‌‏‬⁮‏‬‎‎‍⁪⁪‏⁯‫‮‌‍⁬‌​​‮⁬‬‬⁪⁭⁬​‎‮⁯⁪⁯⁫‏​‌‮(float* , int )
		{
			// 
			// Current member / type: System.Int32 SDRSharp.Tetra.TetraPanel::‮‪‌‏‬⁮‏‬‎‎‍⁪⁪‏⁯‫‮‌‍⁬‌​​‮⁬‬‬⁪⁭⁬​‎‮⁯⁪⁯⁫‏​‌‮(System.Single*,System.Int32)
			// File path: C:\SDRSharp\Plugins\Tetra\SDRSharp.Tetra.dll
			// 
			// Product version: 0.0.0.0
			// Exception in: System.Int32 ‮‪‌‏‬⁮‏‬‎‎‍⁪⁪‏⁯‫‮‌‍⁬‌​​‮⁬‬‬⁪⁭⁬​‎‮⁯⁪⁯⁫‏​‌‮(System.Single*,System.Int32)
			// 
			// Not supported type System.Object.
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.GetTypeIndex(TypeDefinition type) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 684
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.GetContainingType(TypeDefinition leftType, TypeDefinition rightType) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 608
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.GetExpressionType() in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 492
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.get_ExpressionType() in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 414
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.AddAssignmentCastIfNeeded(Expression expr) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\TypeInference\TypeInferer.cs:line 112
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.FixAssignmentInList(IList`1 expressionList, Expression value) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\TypeInference\TypeInferer.cs:line 75
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.AddCasts() in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\TypeInference\TypeInferer.cs:line 38
			//    at Telerik.JustDecompiler.Decompiler.ExpressionDecompilerStep.Process(DecompilationContext theContext, BlockStatement body) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\ExpressionDecompilerStep.cs:line 68
			//    at Telerik.JustDecompiler.Decompiler.DecompilationPipeline.RunInternal(MethodBody body, BlockStatement block, ILanguage language) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\DecompilationPipeline.cs:line 100
			//    at Telerik.JustDecompiler.Decompiler.WriterContextServices.BaseWriterContextService.DecompileMethod(ILanguage language, MethodDefinition method, TypeSpecificContext typeContext) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\WriterContextServices\BaseWriterContextService.cs:line 133
			// 
			// mailto: JustDecompilePublicFeedback@telerik.com

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		// ‏⁮‭‎‪⁮⁪⁫‮⁯⁯‏‫‍​⁪​‭⁮⁪‏⁬⁪⁫⁮​‍⁯⁭‎‬‪‮‪‌‏‎⁮⁪‮‮
		private void u200f⁮‭‎‪⁮⁪⁫‮⁯⁯‏‫‍​⁪​‭⁮⁪‏⁬⁪⁫⁮​‍⁯⁭‎‬‪‮‪‌‏‎⁮⁪‮‮(List<Dictionary<GlobalNames, int>> )
		{
			// 
			// Current member / type: System.Void SDRSharp.Tetra.TetraPanel::‏⁮‭‎‪⁮⁪⁫‮⁯⁯‏‫‍​⁪​‭⁮⁪‏⁬⁪⁫⁮​‍⁯⁭‎‬‪‮‪‌‏‎⁮⁪‮‮(System.Collections.Generic.List`1<System.Collections.Generic.Dictionary`2<SDRSharp.Tetra.GlobalNames,System.Int32>>)
			// File path: C:\SDRSharp\Plugins\Tetra\SDRSharp.Tetra.dll
			// 
			// Product version: 0.0.0.0
			// Exception in: System.Void ‏⁮‭‎‪⁮⁪⁫‮⁯⁯‏‫‍​⁪​‭⁮⁪‏⁬⁪⁫⁮​‍⁯⁭‎‬‪‮‪‌‏‎⁮⁪‮‮(System.Collections.Generic.List<System.Collections.Generic.Dictionary<SDRSharp.Tetra.GlobalNames,System.Int32>>)
			// 
			// Not supported type System.Object.
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.GetTypeIndex(TypeDefinition type) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 684
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.GetContainingType(TypeDefinition leftType, TypeDefinition rightType) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 608
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.GetExpressionType() in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 492
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.get_ExpressionType() in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 414
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.AddAssignmentCastIfNeeded(Expression expr) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\TypeInference\TypeInferer.cs:line 112
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.FixAssignmentInList(IList`1 expressionList, Expression value) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\TypeInference\TypeInferer.cs:line 75
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.AddCasts() in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\TypeInference\TypeInferer.cs:line 38
			//    at Telerik.JustDecompiler.Decompiler.ExpressionDecompilerStep.Process(DecompilationContext theContext, BlockStatement body) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\ExpressionDecompilerStep.cs:line 68
			//    at Telerik.JustDecompiler.Decompiler.DecompilationPipeline.RunInternal(MethodBody body, BlockStatement block, ILanguage language) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\DecompilationPipeline.cs:line 100
			//    at Telerik.JustDecompiler.Decompiler.WriterContextServices.BaseWriterContextService.DecompileMethod(ILanguage language, MethodDefinition method, TypeSpecificContext typeContext) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\WriterContextServices\BaseWriterContextService.cs:line 133
			// 
			// mailto: JustDecompilePublicFeedback@telerik.com

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		// ​‌​⁭​‬​‍‮⁬‪‏⁭‍‫⁮‭⁮‌⁫‎‍‫‭⁯⁫⁭⁫‮‫⁬‎‭⁬⁭‪⁯⁭‬‎‮
		private void u200b‌​⁭​‬​‍‮⁬‪‏⁭‍‫⁮‭⁮‌⁫‎‍‫‭⁯⁫⁭⁫‮‫⁬‎‭⁬⁭‪⁯⁭‬‎‮(Dictionary<GlobalNames, int> )
		{
			// 
			// Current member / type: System.Void SDRSharp.Tetra.TetraPanel::​‌​⁭​‬​‍‮⁬‪‏⁭‍‫⁮‭⁮‌⁫‎‍‫‭⁯⁫⁭⁫‮‫⁬‎‭⁬⁭‪⁯⁭‬‎‮(System.Collections.Generic.Dictionary`2<SDRSharp.Tetra.GlobalNames,System.Int32>)
			// File path: C:\SDRSharp\Plugins\Tetra\SDRSharp.Tetra.dll
			// 
			// Product version: 0.0.0.0
			// Exception in: System.Void ​‌​⁭​‬​‍‮⁬‪‏⁭‍‫⁮‭⁮‌⁫‎‍‫‭⁯⁫⁭⁫‮‫⁬‎‭⁬⁭‪⁯⁭‬‎‮(System.Collections.Generic.Dictionary<SDRSharp.Tetra.GlobalNames,System.Int32>)
			// 
			// Not supported type System.Object.
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.GetTypeIndex(TypeDefinition type) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 684
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.GetContainingType(TypeDefinition leftType, TypeDefinition rightType) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 608
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.GetExpressionType() in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 492
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.get_ExpressionType() in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 414
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.AddAssignmentCastIfNeeded(Expression expr) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\TypeInference\TypeInferer.cs:line 112
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.FixAssignmentInList(IList`1 expressionList, Expression value) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\TypeInference\TypeInferer.cs:line 75
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.AddCasts() in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\TypeInference\TypeInferer.cs:line 38
			//    at Telerik.JustDecompiler.Decompiler.ExpressionDecompilerStep.Process(DecompilationContext theContext, BlockStatement body) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\ExpressionDecompilerStep.cs:line 68
			//    at Telerik.JustDecompiler.Decompiler.DecompilationPipeline.RunInternal(MethodBody body, BlockStatement block, ILanguage language) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\DecompilationPipeline.cs:line 100
			//    at Telerik.JustDecompiler.Decompiler.WriterContextServices.BaseWriterContextService.DecompileMethod(ILanguage language, MethodDefinition method, TypeSpecificContext typeContext) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\WriterContextServices\BaseWriterContextService.cs:line 133
			// 
			// mailto: JustDecompilePublicFeedback@telerik.com

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		// ⁭‍‮⁫⁪​‫‌​⁬‭‪⁫‍‮⁯⁯⁭‪⁪‫‍⁫⁯‏‪​‌‮⁬⁪⁬‌‌‪‫⁬‫‫‮‮
		private void u206d‍‮⁫⁪​‫‌​⁬‭‪⁫‍‮⁯⁯⁭‪⁪‫‍⁫⁯‏‪​‌‮⁬⁪⁬‌‌‪‫⁬‫‫‮‮(Dictionary<GlobalNames, int> )
		{
			// 
			// Current member / type: System.Void SDRSharp.Tetra.TetraPanel::⁭‍‮⁫⁪​‫‌​⁬‭‪⁫‍‮⁯⁯⁭‪⁪‫‍⁫⁯‏‪​‌‮⁬⁪⁬‌‌‪‫⁬‫‫‮‮(System.Collections.Generic.Dictionary`2<SDRSharp.Tetra.GlobalNames,System.Int32>)
			// File path: C:\SDRSharp\Plugins\Tetra\SDRSharp.Tetra.dll
			// 
			// Product version: 0.0.0.0
			// Exception in: System.Void ⁭‍‮⁫⁪​‫‌​⁬‭‪⁫‍‮⁯⁯⁭‪⁪‫‍⁫⁯‏‪​‌‮⁬⁪⁬‌‌‪‫⁬‫‫‮‮(System.Collections.Generic.Dictionary<SDRSharp.Tetra.GlobalNames,System.Int32>)
			// 
			// Not supported type System.Object.
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.GetTypeIndex(TypeDefinition type) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 684
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.GetContainingType(TypeDefinition leftType, TypeDefinition rightType) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 608
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.GetExpressionType() in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 492
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.get_ExpressionType() in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 414
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.AddAssignmentCastIfNeeded(Expression expr) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\TypeInference\TypeInferer.cs:line 112
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.FixAssignmentInList(IList`1 expressionList, Expression value) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\TypeInference\TypeInferer.cs:line 75
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.AddCasts() in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\TypeInference\TypeInferer.cs:line 38
			//    at Telerik.JustDecompiler.Decompiler.ExpressionDecompilerStep.Process(DecompilationContext theContext, BlockStatement body) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\ExpressionDecompilerStep.cs:line 68
			//    at Telerik.JustDecompiler.Decompiler.DecompilationPipeline.RunInternal(MethodBody body, BlockStatement block, ILanguage language) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\DecompilationPipeline.cs:line 100
			//    at Telerik.JustDecompiler.Decompiler.WriterContextServices.BaseWriterContextService.DecompileMethod(ILanguage language, MethodDefinition method, TypeSpecificContext typeContext) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\WriterContextServices\BaseWriterContextService.cs:line 133
			// 
			// mailto: JustDecompilePublicFeedback@telerik.com

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		// ​‍⁮‍⁮⁭⁯‫⁪‮‎​‭‫‍‏‫‬‎‌‍‭‌⁮​‭‎‭⁪‫‍⁯​‭‏⁭⁪​⁫‭‮
		private void u200b‍⁮‍⁮⁭⁯‫⁪‮‎​‭‫‍‏‫‬‎‌‍‭‌⁮​‭‎‭⁪‫‍⁯​‭‏⁭⁪​⁫‭‮(Dictionary<GlobalNames, int> )
		{
			// 
			// Current member / type: System.Void SDRSharp.Tetra.TetraPanel::​‍⁮‍⁮⁭⁯‫⁪‮‎​‭‫‍‏‫‬‎‌‍‭‌⁮​‭‎‭⁪‫‍⁯​‭‏⁭⁪​⁫‭‮(System.Collections.Generic.Dictionary`2<SDRSharp.Tetra.GlobalNames,System.Int32>)
			// File path: C:\SDRSharp\Plugins\Tetra\SDRSharp.Tetra.dll
			// 
			// Product version: 0.0.0.0
			// Exception in: System.Void ​‍⁮‍⁮⁭⁯‫⁪‮‎​‭‫‍‏‫‬‎‌‍‭‌⁮​‭‎‭⁪‫‍⁯​‭‏⁭⁪​⁫‭‮(System.Collections.Generic.Dictionary<SDRSharp.Tetra.GlobalNames,System.Int32>)
			// 
			// Not supported type System.Object.
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.GetTypeIndex(TypeDefinition type) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 684
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.GetContainingType(TypeDefinition leftType, TypeDefinition rightType) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 608
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.GetExpressionType() in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 492
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.get_ExpressionType() in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 414
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.AddAssignmentCastIfNeeded(Expression expr) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\TypeInference\TypeInferer.cs:line 112
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.FixAssignmentInList(IList`1 expressionList, Expression value) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\TypeInference\TypeInferer.cs:line 75
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.AddCasts() in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\TypeInference\TypeInferer.cs:line 38
			//    at Telerik.JustDecompiler.Decompiler.ExpressionDecompilerStep.Process(DecompilationContext theContext, BlockStatement body) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\ExpressionDecompilerStep.cs:line 68
			//    at Telerik.JustDecompiler.Decompiler.DecompilationPipeline.RunInternal(MethodBody body, BlockStatement block, ILanguage language) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\DecompilationPipeline.cs:line 100
			//    at Telerik.JustDecompiler.Decompiler.WriterContextServices.BaseWriterContextService.DecompileMethod(ILanguage language, MethodDefinition method, TypeSpecificContext typeContext) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\WriterContextServices\BaseWriterContextService.cs:line 133
			// 
			// mailto: JustDecompilePublicFeedback@telerik.com

		}

		// ‬⁮⁫⁬⁬⁮‪‍⁬⁪‪⁪‎‮‌‎‫⁮‎⁫⁪⁪‌⁫⁫‬‭‫‪‬⁯‏‬⁬‫⁯‍‏‪⁭‮
		private void u202c⁮⁫⁬⁬⁮‪‍⁬⁪‪⁪‎‮‌‎‫⁮‎⁫⁪⁪‌⁫⁫‬‭‫‪‬⁯‏‬⁬‫⁯‍‏‪⁭‮(Dictionary<GlobalNames, int> )
		{
			// 
			// Current member / type: System.Void SDRSharp.Tetra.TetraPanel::‬⁮⁫⁬⁬⁮‪‍⁬⁪‪⁪‎‮‌‎‫⁮‎⁫⁪⁪‌⁫⁫‬‭‫‪‬⁯‏‬⁬‫⁯‍‏‪⁭‮(System.Collections.Generic.Dictionary`2<SDRSharp.Tetra.GlobalNames,System.Int32>)
			// File path: C:\SDRSharp\Plugins\Tetra\SDRSharp.Tetra.dll
			// 
			// Product version: 0.0.0.0
			// Exception in: System.Void ‬⁮⁫⁬⁬⁮‪‍⁬⁪‪⁪‎‮‌‎‫⁮‎⁫⁪⁪‌⁫⁫‬‭‫‪‬⁯‏‬⁬‫⁯‍‏‪⁭‮(System.Collections.Generic.Dictionary<SDRSharp.Tetra.GlobalNames,System.Int32>)
			// 
			// Not supported type System.Object.
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.GetTypeIndex(TypeDefinition type) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 684
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.GetContainingType(TypeDefinition leftType, TypeDefinition rightType) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 608
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.GetExpressionType() in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 492
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.get_ExpressionType() in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 414
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.AddAssignmentCastIfNeeded(Expression expr) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\TypeInference\TypeInferer.cs:line 112
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.FixAssignmentInList(IList`1 expressionList, Expression value) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\TypeInference\TypeInferer.cs:line 75
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.AddCasts() in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\TypeInference\TypeInferer.cs:line 38
			//    at Telerik.JustDecompiler.Decompiler.ExpressionDecompilerStep.Process(DecompilationContext theContext, BlockStatement body) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\ExpressionDecompilerStep.cs:line 68
			//    at Telerik.JustDecompiler.Decompiler.DecompilationPipeline.RunInternal(MethodBody body, BlockStatement block, ILanguage language) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\DecompilationPipeline.cs:line 100
			//    at Telerik.JustDecompiler.Decompiler.WriterContextServices.BaseWriterContextService.DecompileMethod(ILanguage language, MethodDefinition method, TypeSpecificContext typeContext) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\WriterContextServices\BaseWriterContextService.cs:line 133
			// 
			// mailto: JustDecompilePublicFeedback@telerik.com

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		// ‎‍​‭‎⁮‏‮​‫⁫‪⁪‬⁫‏⁫‍‭⁫‮⁭⁪‫‭⁬⁬‌‎⁯⁬‌⁭⁬‬⁫‮‬⁬‎‮
		private void u200e‍​‭‎⁮‏‮​‫⁫‪⁪‬⁫‏⁫‍‭⁫‮⁭⁪‫‭⁬⁬‌‎⁯⁬‌⁭⁬‬⁫‮‬⁬‎‮(object , EventArgs )
		{
			// 
			// Current member / type: System.Void SDRSharp.Tetra.TetraPanel::‎‍​‭‎⁮‏‮​‫⁫‪⁪‬⁫‏⁫‍‭⁫‮⁭⁪‫‭⁬⁬‌‎⁯⁬‌⁭⁬‬⁫‮‬⁬‎‮(System.Object,System.EventArgs)
			// File path: C:\SDRSharp\Plugins\Tetra\SDRSharp.Tetra.dll
			// 
			// Product version: 0.0.0.0
			// Exception in: System.Void ‎‍​‭‎⁮‏‮​‫⁫‪⁪‬⁫‏⁫‍‭⁫‮⁭⁪‫‭⁬⁬‌‎⁯⁬‌⁭⁬‬⁫‮‬⁬‎‮(System.Object,System.EventArgs)
			// 
			// Not supported type System.Object.
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.GetTypeIndex(TypeDefinition type) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 684
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.GetContainingType(TypeDefinition leftType, TypeDefinition rightType) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 608
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.GetExpressionType() in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 492
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.get_ExpressionType() in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 414
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.AddAssignmentCastIfNeeded(Expression expr) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\TypeInference\TypeInferer.cs:line 112
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.FixAssignmentInList(IList`1 expressionList, Expression value) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\TypeInference\TypeInferer.cs:line 75
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.AddCasts() in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\TypeInference\TypeInferer.cs:line 38
			//    at Telerik.JustDecompiler.Decompiler.ExpressionDecompilerStep.Process(DecompilationContext theContext, BlockStatement body) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\ExpressionDecompilerStep.cs:line 68
			//    at Telerik.JustDecompiler.Decompiler.DecompilationPipeline.RunInternal(MethodBody body, BlockStatement block, ILanguage language) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\DecompilationPipeline.cs:line 100
			//    at Telerik.JustDecompiler.Decompiler.WriterContextServices.BaseWriterContextService.DecompileMethod(ILanguage language, MethodDefinition method, TypeSpecificContext typeContext) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\WriterContextServices\BaseWriterContextService.cs:line 133
			// 
			// mailto: JustDecompilePublicFeedback@telerik.com

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		// ⁭‏​⁮‎‍‬⁭⁫​⁬​‪⁮‎⁭‫​⁪‫‫‫‍‬​⁬‬‍‭⁮⁫⁮⁭⁯‏‏⁫⁭​⁭‮
		private void u206d‏​⁮‎‍‬⁭⁫​⁬​‪⁮‎⁭‫​⁪‫‫‫‍‬​⁬‬‍‭⁮⁫⁮⁭⁯‏‏⁫⁭​⁭‮(object obj, EventArgs eventArg)
		{
			int num;
			this.u200b‍⁯⁪‌‍‍‎‪⁯⁮⁪‬⁯⁮⁮‍⁫‫⁭⁯​⁮⁮‫⁫‪‭‪⁪‪⁬⁫‬‎‌‎⁬‎⁫‮.DmoMode = TetraPanel.u200c⁭⁬‪‎‍⁬‭⁮​⁬⁪⁭‪‭‮‫‏‮‫‏⁪⁬⁫​‍⁫⁮‬⁭⁬‭⁯⁮‎⁪‫⁫‬‏‮(this.u206e‬​⁯⁫‍‎​‮⁬⁮‍‫‪‬‌‌‭⁯⁫‮‫‮⁭‮‫‪‫⁮‫⁪‏‏‏‫‏‭⁬⁬‍‮);
		Label1:
			int num1 = -1690885251;
			while (true)
			{
				int num2 = num1 ^ -1504235987;
				uint num3 = (uint)num2;
				switch (num2 % 9)
				{
					case 0:
					{
						TetraPanel.u206d‫‫‫⁮‮‌​‍⁫‭‎‬​⁭‬⁫‪‌‍‍‎‮⁫‬⁭⁫‫‎⁯‏‌‮‮⁬‮⁬⁪‮(this.u206c‍‍‌‬‪‮‪‮⁪‎⁬‍‭⁪‫‌‬‪⁫‫‫‫‪⁮‮‬⁮⁬⁪‫⁭‫‌⁪‮‪⁭⁭⁮‮, u003cModuleu003e.u200e‏‌‬⁮‪‭⁭‭⁭‎​‏‌‭‭‭⁭⁬⁯⁫‍‮‫⁯‌‮‏​‬⁫⁯⁮⁫‮‪⁫‬⁮⁬‮<string>(-1966080042));
						num1 = -888706256;
						continue;
					}
					case 1:
					{
						TetraPanel.DmoMode = this.u200b‍⁯⁪‌‍‍‎‪⁯⁮⁪‬⁯⁮⁮‍⁫‫⁭⁯​⁮⁮‫⁫‪‭‪⁪‪⁬⁫‬‎‌‎⁬‎⁫‮.DmoMode;
						num1 = (int)(num3 * 73816338 ^ -1412344374);
						continue;
					}
					case 2:
					{
						return;
					}
					case 3:
					{
						TetraPanel.u206d‫‫‫⁮‮‌​‍⁫‭‎‬​⁭‬⁫‪‌‍‍‎‮⁫‬⁭⁫‫‎⁯‏‌‮‮⁬‮⁬⁪‮(this.u206d‫⁭‮⁯​⁫‬‍‪‍⁬⁭⁭‍‎‬‮⁪‫‫‍‎⁫​⁪‪​‮⁬‌​‬‮⁪‬‮⁫⁬⁫‮, u003cModuleu003e.u202a‮‫‏‫‬‬‪⁫⁬​‏⁫⁭‍‪‪‎⁬​‪​‌⁮‮‌​⁫​⁬‪‫⁪⁯⁪‎‫⁭‎⁪‮<string>(1498888463));
						num1 = -507304506;
						continue;
					}
					case 4:
					{
						num = (!TetraPanel.DmoMode ? 1404858622 : 364592751);
						num1 = (int)(num ^ num3 * -838954512);
						continue;
					}
					case 5:
					{
						goto Label1;
					}
					case 6:
					{
						TetraPanel.u200c⁪‏‏⁫‌⁭‭⁪‮⁯⁫‬‏‍‬⁮⁮‍‌‎‮⁪‌⁮⁭⁮⁫‮‬⁪‭⁬⁮⁮⁫‫‌‌‏‮(this.u206e‬​⁯⁫‍‎​‮⁬⁮‍‫‪‬‌‌‭⁯⁫‮‫‮⁭‮‫‪‫⁮‫⁪‏‏‏‫‏‭⁬⁬‍‮, this.u200e‮⁪‪​‮‍‌​‍‍‍​‌⁬⁪⁮⁯‫⁭⁬‬‭‪‫‭⁫⁪⁭⁬⁮‫⁬‍‫‬⁭‬⁫‮‮);
						TetraPanel.u206d‫‫‫⁮‮‌​‍⁫‭‎‬​⁭‬⁫‪‌‍‍‎‮⁫‬⁭⁫‫‎⁯‏‌‮‮⁬‮⁬⁪‮(this.u200f‏⁪‪⁪‪⁯‪‌⁬‎‪‬‫⁯‭‬‌⁯‏⁮⁫‪⁯‬⁪⁭⁭‪‪‌‍‭‎⁭⁫⁯⁯​‏‮, u003cModuleu003e.u202a‮‫‏‫‬‬‪⁫⁬​‏⁫⁭‍‪‪‎⁬​‪​‌⁮‮‌​⁫​⁬‪‫⁪⁯⁪‎‫⁭‎⁪‮<string>(-1807885711));
						TetraPanel.u206d‫‫‫⁮‮‌​‍⁫‭‎‬​⁭‬⁫‪‌‍‍‎‮⁫‬⁭⁫‫‎⁯‏‌‮‮⁬‮⁬⁪‮(this.u200c⁭‫‪⁮⁪⁬‭⁬⁮‌⁬⁭‌‍‎⁫‮‭‍⁮‬‮⁫‫⁮⁬‮‬⁬‭⁯⁫‍‪⁪⁯‏​⁭‮, u003cModuleu003e.u200d​‍⁮‏‭⁮⁪‌‪‬‬‬‪⁬⁭⁫⁫‬⁪⁬⁬⁬‏⁮⁭‌‍‏‍‏‎‬⁬​‪‎​‎⁭‮<string>(-312195911));
						num1 = -1402068780;
						continue;
					}
					case 7:
					{
						break;
					}
					case 8:
					{
						TetraPanel.u200c⁪‏‏⁫‌⁭‭⁪‮⁯⁫‬‏‍‬⁮⁮‍‌‎‮⁪‌⁮⁭⁮⁫‮‬⁪‭⁬⁮⁮⁫‫‌‌‏‮(this.u206e‬​⁯⁫‍‎​‮⁬⁮‍‫‪‬‌‌‭⁯⁫‮‫‮⁭‮‫‪‫⁮‫⁪‏‏‏‫‏‭⁬⁬‍‮, Color.ForestGreen);
						num1 = (int)(num3 * 1671750581 ^ -1644292134);
						continue;
					}
					default:
					{
						return;
					}
				}
			}
			TetraPanel.u206d‫‫‫⁮‮‌​‍⁫‭‎‬​⁭‬⁫‪‌‍‍‎‮⁫‬⁭⁫‫‎⁯‏‌‮‮⁬‮⁬⁪‮(this.u206d‫⁭‮⁯​⁫‬‍‪‍⁬⁭⁭‍‎‬‮⁪‫‫‍‎⁫​⁪‪​‮⁬‌​‬‮⁪‬‮⁫⁬⁫‮, "");
			TetraPanel.u206d‫‫‫⁮‮‌​‍⁫‭‎‬​⁭‬⁫‪‌‍‍‎‮⁫‬⁭⁫‫‎⁯‏‌‮‮⁬‮⁬⁪‮(this.u206c‍‍‌‬‪‮‪‮⁪‎⁬‍‭⁪‫‌‬‪⁫‫‫‫‪⁮‮‬⁮⁬⁪‫⁭‫‌⁪‮‪⁭⁭⁮‮, u003cModuleu003e.u202a‮‫‏‫‬‬‪⁫⁬​‏⁫⁭‍‪‪‎⁬​‪​‌⁮‮‌​⁫​⁬‪‫⁪⁯⁪‎‫⁭‎⁪‮<string>(-1629167464));
			return;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		// ⁪‏⁫⁯⁫⁬‎⁫‍‌⁫‭⁫‫⁪‍​​‏⁪‫​⁪⁪‎‏⁭‫⁭‍⁫⁭‫⁫⁫‎‪⁫⁪‬‮
		private void u206a‏⁫⁯⁫⁬‎⁫‍‌⁫‭⁫‫⁪‍​​‏⁪‫​⁪⁪‎‏⁭‫⁭‍⁫⁭‫⁫⁫‎‪⁫⁪‬‮(object , EventArgs )
		{
			// 
			// Current member / type: System.Void SDRSharp.Tetra.TetraPanel::⁪‏⁫⁯⁫⁬‎⁫‍‌⁫‭⁫‫⁪‍​​‏⁪‫​⁪⁪‎‏⁭‫⁭‍⁫⁭‫⁫⁫‎‪⁫⁪‬‮(System.Object,System.EventArgs)
			// File path: C:\SDRSharp\Plugins\Tetra\SDRSharp.Tetra.dll
			// 
			// Product version: 0.0.0.0
			// Exception in: System.Void ⁪‏⁫⁯⁫⁬‎⁫‍‌⁫‭⁫‫⁪‍​​‏⁪‫​⁪⁪‎‏⁭‫⁭‍⁫⁭‫⁫⁫‎‪⁫⁪‬‮(System.Object,System.EventArgs)
			// 
			// Not supported type System.Object.
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.GetTypeIndex(TypeDefinition type) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 684
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.GetContainingType(TypeDefinition leftType, TypeDefinition rightType) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 608
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.GetExpressionType() in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 492
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.get_ExpressionType() in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 414
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.AddAssignmentCastIfNeeded(Expression expr) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\TypeInference\TypeInferer.cs:line 112
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.FixAssignmentInList(IList`1 expressionList, Expression value) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\TypeInference\TypeInferer.cs:line 75
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.AddCasts() in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\TypeInference\TypeInferer.cs:line 38
			//    at Telerik.JustDecompiler.Decompiler.ExpressionDecompilerStep.Process(DecompilationContext theContext, BlockStatement body) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\ExpressionDecompilerStep.cs:line 68
			//    at Telerik.JustDecompiler.Decompiler.DecompilationPipeline.RunInternal(MethodBody body, BlockStatement block, ILanguage language) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\DecompilationPipeline.cs:line 100
			//    at Telerik.JustDecompiler.Decompiler.WriterContextServices.BaseWriterContextService.DecompileMethod(ILanguage language, MethodDefinition method, TypeSpecificContext typeContext) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\WriterContextServices\BaseWriterContextService.cs:line 133
			// 
			// mailto: JustDecompilePublicFeedback@telerik.com

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		// ‫⁪⁬⁫‏‭​⁭‏‭⁭⁫​‫⁪‌⁮⁯‭⁯⁪‏‪‎⁫‫​⁫‭⁯‎⁭⁯‏⁯⁪⁬⁭‍⁭‮
		private void u202b⁪⁬⁫‏‭​⁭‏‭⁭⁫​‫⁪‌⁮⁯‭⁯⁪‏‪‎⁫‫​⁫‭⁯‎⁭⁯‏⁯⁪⁬⁭‍⁭‮(object , EventArgs )
		{
			// 
			// Current member / type: System.Void SDRSharp.Tetra.TetraPanel::‫⁪⁬⁫‏‭​⁭‏‭⁭⁫​‫⁪‌⁮⁯‭⁯⁪‏‪‎⁫‫​⁫‭⁯‎⁭⁯‏⁯⁪⁬⁭‍⁭‮(System.Object,System.EventArgs)
			// File path: C:\SDRSharp\Plugins\Tetra\SDRSharp.Tetra.dll
			// 
			// Product version: 0.0.0.0
			// Exception in: System.Void ‫⁪⁬⁫‏‭​⁭‏‭⁭⁫​‫⁪‌⁮⁯‭⁯⁪‏‪‎⁫‫​⁫‭⁯‎⁭⁯‏⁯⁪⁬⁭‍⁭‮(System.Object,System.EventArgs)
			// 
			// Not supported type System.Object.
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.GetTypeIndex(TypeDefinition type) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 684
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.GetContainingType(TypeDefinition leftType, TypeDefinition rightType) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 608
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.GetExpressionType() in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 492
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.get_ExpressionType() in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 414
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.AddAssignmentCastIfNeeded(Expression expr) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\TypeInference\TypeInferer.cs:line 112
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.FixAssignmentInList(IList`1 expressionList, Expression value) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\TypeInference\TypeInferer.cs:line 75
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.AddCasts() in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\TypeInference\TypeInferer.cs:line 38
			//    at Telerik.JustDecompiler.Decompiler.ExpressionDecompilerStep.Process(DecompilationContext theContext, BlockStatement body) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\ExpressionDecompilerStep.cs:line 68
			//    at Telerik.JustDecompiler.Decompiler.DecompilationPipeline.RunInternal(MethodBody body, BlockStatement block, ILanguage language) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\DecompilationPipeline.cs:line 100
			//    at Telerik.JustDecompiler.Decompiler.WriterContextServices.BaseWriterContextService.DecompileMethod(ILanguage language, MethodDefinition method, TypeSpecificContext typeContext) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\WriterContextServices\BaseWriterContextService.cs:line 133
			// 
			// mailto: JustDecompilePublicFeedback@telerik.com

		}

		// ‬⁫‭‪⁭⁮‪‭⁭⁭‏⁪⁯⁭‮‫‮‪⁫‪‍‎⁭‌⁭⁬‌‪​⁭⁪⁫‮⁫​⁬‌‬⁬⁭‮
		private void u202c⁫‭‪⁭⁮‪‭⁭⁭‏⁪⁯⁭‮‫‮‪⁫‪‍‎⁭‌⁭⁬‌‪​⁭⁪⁫‮⁫​⁬‌‬⁬⁭‮(object obj, EventArgs eventArg)
		{
			int num;
			int num1;
			this.u200c⁫⁪‫‮‏‫⁮⁯‬⁮​‎⁯‪‪‭​‬‫‭⁫⁭‏‪‫‪‫⁫‌⁭‮‌‪‍‭⁫‬⁭⁭‮ = TetraPanel.u206e‏⁬⁬‭‮​‍‍‭⁫⁮⁮⁯⁪‏⁫‭‍‎‪⁭‎‏​⁭⁮⁬⁯⁯‏​‬‭⁪‏‬‌‮‍‮(this.u206d‏‪‫‍⁪‪⁬‌⁪‌‪‭⁫‫‎‍⁯‎‬‭⁪⁯​⁪⁮‬​‌​‎‌⁪‭⁮‏‌‫‫⁯‮);
		Label0:
			int num2 = -860943946;
			while (true)
			{
				int num3 = num2 ^ -1785518095;
				uint num4 = (uint)num3;
				switch (num3 % 5)
				{
					case 0:
					{
						goto Label0;
					}
					case 1:
					{
						num = (TetraPanel.u206e‏⁬⁬‭‮​‍‍‭⁫⁮⁮⁯⁪‏⁫‭‍‎‪⁭‎‏​⁭⁮⁬⁯⁯‏​‬‭⁪‏‬‌‮‍‮(this.u206d‏‪‫‍⁪‪⁬‌⁪‌‪‭⁫‫‎‍⁯‎‬‭⁪⁯​⁪⁮‬​‌​‎‌⁪‭⁮‏‌‫‫⁯‮) ? -1130856977 : -793017321);
						num2 = (int)(num ^ num4 * 1235785917);
						continue;
					}
					case 2:
					{
						return;
					}
					case 3:
					{
						num1 = (!this.u200b‍⁯⁪‌‍‍‎‪⁯⁮⁪‬⁯⁮⁮‍⁫‫⁭⁯​⁮⁮‫⁫‪‭‪⁪‪⁬⁫‬‎‌‎⁬‎⁫‮.AlternativeCallListGeneration ? -302870584 : -1075160568);
						num2 = (int)(num1 ^ num4 * 1722834020);
						continue;
					}
					case 4:
					{
						this.u206c‪‌‭‏⁯​‫⁫⁫‬‫‍‪⁯‫‏‫⁪⁯⁫​‮‍‫‭‎‍‏‪‎⁬⁭‬​⁭​‎⁫⁪‮.u202c⁮⁬‬‭​⁪‮⁮‮‌‏‫⁫‌‪‏⁮‭​⁬‌‫‮⁯‭⁯‎‎⁪‭‍⁮‎​⁬‫‍‌‎‮ = true;
						num2 = (int)(num4 * -630124855 ^ -209821687);
						continue;
					}
				}
			}
		}

		// ‌‮⁫⁭⁬⁬‮‬‌‮‬⁮‪‭‮‫‏⁬‍‏⁬‎⁮⁭‍⁬‮‪⁭⁫‫‮‭‍‎‭⁫‬​⁯‮
		private void u200c‮⁫⁭⁬⁬‮‬‌‮‬⁮‪‭‮‫‏⁬‍‏⁬‎⁮⁭‍⁬‮‪⁭⁫‫‮‭‍‎‭⁫‬​⁯‮(object obj, EventArgs eventArg)
		{
			int num;
			int num1;
			this.u200b‎⁪⁫‬⁬‭‌⁫‌​⁭‪‮‮‫‎‫‫‏‌‏‌‫‬‬​⁫⁭‮‮​⁮⁯​⁭‎​‫‍‮ = TetraPanel.u206e‏⁬⁬‭‮​‍‍‭⁫⁮⁮⁯⁪‏⁫‭‍‎‪⁭‎‏​⁭⁮⁬⁯⁯‏​‬‭⁪‏‬‌‮‍‮(this.u200f‫‮⁭⁭‬‌‪⁭‭‭‬⁮‪‮⁬⁬​⁮⁫‍⁮‍​⁮‫‪‮‎⁪⁬‎⁮⁭⁯⁯⁮‮‪⁭‮);
		Label1:
			int num2 = -287983509;
			while (true)
			{
				int num3 = num2 ^ -466648378;
				uint num4 = (uint)num3;
				switch (num3 % 5)
				{
					case 0:
					{
						num = (this.u200b‍⁯⁪‌‍‍‎‪⁯⁮⁪‬⁯⁮⁮‍⁫‫⁭⁯​⁮⁮‫⁫‪‭‪⁪‪⁬⁫‬‎‌‎⁬‎⁫‮.AlternativeCallListGeneration ? 629258113 : 2090290391);
						num2 = (int)(num ^ num4 * 2118450556);
						continue;
					}
					case 1:
					{
						num1 = (!TetraPanel.u206e‏⁬⁬‭‮​‍‍‭⁫⁮⁮⁯⁪‏⁫‭‍‎‪⁭‎‏​⁭⁮⁬⁯⁯‏​‬‭⁪‏‬‌‮‍‮(this.u200f‫‮⁭⁭‬‌‪⁭‭‭‬⁮‪‮⁬⁬​⁮⁫‍⁮‍​⁮‫‪‮‎⁪⁬‎⁮⁭⁯⁯⁮‮‪⁭‮) ? -1971454332 : -292994239);
						num2 = (int)(num1 ^ num4 * -725891825);
						continue;
					}
					case 2:
					{
						return;
					}
					case 3:
					{
						this.u206c‪‌‭‏⁯​‫⁫⁫‬‫‍‪⁯‫‏‫⁪⁯⁫​‮‍‫‭‎‍‏‪‎⁬⁭‬​⁭​‎⁫⁪‮.u206f⁭⁭⁫⁬⁪‎‎‭‎​‬⁫‎⁫⁫‎⁪‪⁭⁮⁬‫⁮⁮‎‪​⁮⁯⁯⁭‌⁭⁪⁫⁭‍‎⁫‮ = true;
						num2 = (int)(num4 * 426764380 ^ 421837923);
						continue;
					}
					case 4:
					{
						goto Label1;
					}
				}
			}
		}

		// ‍‭‍⁪⁮‮‮⁬‭⁭⁪‌‮‎⁪⁮⁪‮⁫⁬⁬​⁬⁭⁫‌⁮‍⁮​‫⁫‭‭‫‏‬‎⁫‮‮
		private void u200d‭‍⁪⁮‮‮⁬‭⁭⁪‌‮‎⁪⁮⁪‮⁫⁬⁬​⁬⁭⁫‌⁮‍⁮​‫⁫‭‭‫‏‬‎⁫‮‮(object obj, EventArgs eventArg)
		{
			int num;
			int num1;
			this.u200c⁪‌⁯‪‏⁭​‮⁮‫⁪⁫‮‪‎‭⁭⁭‮⁬‍⁪⁫‏‍‎‭​‭‍‫⁭‪⁬​‪‏‬⁮‮ = TetraPanel.u206e‏⁬⁬‭‮​‍‍‭⁫⁮⁮⁯⁪‏⁫‭‍‎‪⁭‎‏​⁭⁮⁬⁯⁯‏​‬‭⁪‏‬‌‮‍‮(this.u202e⁮‍‍⁮‎⁪⁫⁫‍‮‭‬‍⁪‪‮⁭‬⁫⁯‪⁯​⁪‬‫​⁬‭‭⁯‫‎⁮‏​​‬‎‮);
		Label1:
			int num2 = 6279964;
			while (true)
			{
				int num3 = num2 ^ 2070978402;
				uint num4 = (uint)num3;
				switch (num3 % 5)
				{
					case 0:
					{
						this.u206c‪‌‭‏⁯​‫⁫⁫‬‫‍‪⁯‫‏‫⁪⁯⁫​‮‍‫‭‎‍‏‪‎⁬⁭‬​⁭​‎⁫⁪‮.u202c‮‮⁫‎‎‏‬‫⁯‎⁪‌⁮⁬⁪‌⁯‫⁭‪⁫‫‎‬‎‭‬⁫‎‍⁬​⁫⁯⁯‭‌⁭‮ = true;
						num2 = (int)(num4 * 1284307313 ^ -1475967357);
						continue;
					}
					case 1:
					{
						return;
					}
					case 2:
					{
						num = (!TetraPanel.u206e‏⁬⁬‭‮​‍‍‭⁫⁮⁮⁯⁪‏⁫‭‍‎‪⁭‎‏​⁭⁮⁬⁯⁯‏​‬‭⁪‏‬‌‮‍‮(this.u202e⁮‍‍⁮‎⁪⁫⁫‍‮‭‬‍⁪‪‮⁭‬⁫⁯‪⁯​⁪‬‫​⁬‭‭⁯‫‎⁮‏​​‬‎‮) ? 1194292211 : 1330802036);
						num2 = (int)(num ^ num4 * 1040100490);
						continue;
					}
					case 3:
					{
						goto Label1;
					}
					case 4:
					{
						num1 = (!this.u200b‍⁯⁪‌‍‍‎‪⁯⁮⁪‬⁯⁮⁮‍⁫‫⁭⁯​⁮⁮‫⁫‪‭‪⁪‪⁬⁫‬‎‌‎⁬‎⁫‮.AlternativeCallListGeneration ? 1039837201 : 1396716848);
						num2 = (int)(num1 ^ num4 * 742464083);
						continue;
					}
				}
			}
		}

		// ⁬‮‭‬‬‭‮‭‌‍‪‮⁬⁪⁬​‌‏⁪‍⁮⁫‭‬⁮⁪⁪‎‍‫⁪‬⁬‮⁯‏‮​‪‭‮
		private void u206c‮‭‬‬‭‮‭‌‍‪‮⁬⁪⁬​‌‏⁪‍⁮⁫‭‬⁮⁪⁪‎‍‫⁪‬⁬‮⁯‏‮​‪‭‮(object obj, EventArgs eventArg)
		{
			int num;
			int num1;
			this.u202e‍⁪⁪⁯⁫‮⁬‪⁬‪‍​‍⁬‍⁬⁫‬‌‌‬‬⁭‬‪‮‬‬⁬⁮‍‏​‪‫​⁬⁫‌‮ = TetraPanel.u206e‏⁬⁬‭‮​‍‍‭⁫⁮⁮⁯⁪‏⁫‭‍‎‪⁭‎‏​⁭⁮⁬⁯⁯‏​‬‭⁪‏‬‌‮‍‮(this.u200b‏⁭⁯⁮⁬‭‮⁭⁯‮​‏‭⁬⁮‫⁬⁬‬‮‏‏‎‮⁫⁬⁭⁮​​⁮⁪⁭⁭​‫‫‮);
		Label1:
			int num2 = -1763122676;
			while (true)
			{
				int num3 = num2 ^ -1973104407;
				uint num4 = (uint)num3;
				switch (num3 % 5)
				{
					case 0:
					{
						this.u206c‪‌‭‏⁯​‫⁫⁫‬‫‍‪⁯‫‏‫⁪⁯⁫​‮‍‫‭‎‍‏‪‎⁬⁭‬​⁭​‎⁫⁪‮.u202b⁯⁮⁮‌⁯‍⁪‬‪​‫‮‏‭‎‌⁮⁫​‍‏‮⁫⁯⁭‏⁮‭‭​‌⁮⁮‫‎‪⁬‍⁭‮ = true;
						num2 = (int)(num4 * 1640452403 ^ -1123037467);
						continue;
					}
					case 1:
					{
						return;
					}
					case 2:
					{
						num = (!TetraPanel.u206e‏⁬⁬‭‮​‍‍‭⁫⁮⁮⁯⁪‏⁫‭‍‎‪⁭‎‏​⁭⁮⁬⁯⁯‏​‬‭⁪‏‬‌‮‍‮(this.u200b‏⁭⁯⁮⁬‭‮⁭⁯‮​‏‭⁬⁮‫⁬⁬‬‮‏‏‎‮⁫⁬⁭⁮​​⁮⁪⁭⁭​‫‫‮) ? 93490762 : 33053268);
						num2 = (int)(num ^ num4 * -549318214);
						continue;
					}
					case 3:
					{
						goto Label1;
					}
					case 4:
					{
						num1 = (this.u200b‍⁯⁪‌‍‍‎‪⁯⁮⁪‬⁯⁮⁮‍⁫‫⁭⁯​⁮⁮‫⁫‪‭‪⁪‪⁬⁫‬‎‌‎⁬‎⁫‮.AlternativeCallListGeneration ? -1520064175 : -547757457);
						num2 = (int)(num1 ^ num4 * 1731067801);
						continue;
					}
				}
			}
		}

		// ⁯‮⁫‫‏‎‮⁯⁪‎⁮​‏⁬⁭‏‍‮⁯⁭‌⁬⁯‬⁮⁯⁪⁪‌⁫⁯‍‍​⁫‎⁫‭‏⁬‮
		private void u206f‮⁫‫‏‎‮⁯⁪‎⁮​‏⁬⁭‏‍‮⁯⁭‌⁬⁯‬⁮⁯⁪⁪‌⁫⁯‍‍​⁫‎⁫‭‏⁬‮(object obj, EventArgs eventArg)
		{
			int num;
			this.u202b⁬‌‎⁬⁪⁪⁯‮⁬‎⁮⁬⁮​‮⁬‍‎⁬⁬‭‏​⁫⁫‎‭‬⁮‎‌⁯⁯⁬⁬⁬​‍⁭‮ = TetraPanel.u200c⁭⁬‪‎‍⁬‭⁮​⁬⁪⁭‪‭‮‫‏‮‫‏⁪⁬⁫​‍⁫⁮‬⁭⁬‭⁯⁮‎⁪‫⁫‬‏‮(this.u200e‎⁭‏‎‪‎‍‬⁭⁮⁬‍⁭‮​⁪‮‏‍⁪‎‫⁮‫⁭⁯⁪‌‌​‌⁬‫‏‬‍⁯⁮‭‮);
		Label0:
			int num1 = 176936711;
			while (true)
			{
				int num2 = num1 ^ 333382533;
				uint num3 = (uint)num2;
				switch (num2 % 4)
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
						num = (!this.u202b⁬‌‎⁬⁪⁪⁯‮⁬‎⁮⁬⁮​‮⁬‍‎⁬⁬‭‏​⁫⁫‎‭‬⁮‎‌⁯⁯⁬⁬⁬​‍⁭‮ ? 178684568 : 223211986);
						num1 = (int)(num ^ num3 * -68233018);
						continue;
					}
					case 3:
					{
						TetraPanel.u202a⁪‪‎⁫​‏‏‌⁬‪‮⁯‭⁬‫⁫‪⁯⁬‮‬⁭‭​‫⁫⁭‪⁪‫‌‏‌‪‭‌‫⁪‮(this.u206d‏‪‫‍⁪‪⁬‌⁪‌‪‭⁫‫‎‍⁯‎‬‭⁪⁯​⁪⁮‬​‌​‎‌⁪‭⁮‏‌‫‫⁯‮, true);
						num1 = (int)(num3 * -331255428 ^ 807768832);
						continue;
					}
				}
			}
		}

		// ‫‬⁬‍⁯⁫‫‍‪‌​‮‏‪⁭‭⁮⁭‫‬‭⁪‫‏‪‮‪‪‬‫⁯‬‎‭⁬​‮‎⁭‮
		private void u202b‬⁬‍⁯⁫‫‍‪‌​‮‏‪⁭‭⁮⁭‫‬‭⁪‫‏‪‮‪‪‬‫⁯‬‎‭⁬​‮‎⁭‮(object obj, EventArgs eventArg)
		{
			this.u200b⁮⁪‌⁭‪‭‌​‍‭‏‍‬​‌⁪‬‫‪‪⁮​⁬‎​‫‌⁯⁬​⁬‌‫‭⁮⁪‌‎⁯‮(false);
		}

		// ​⁮⁪‌⁭‪‭‌​‍‭‏‍‬​‌⁪‬‫‪‪⁮​⁬‎​‫‌⁯⁬​⁬‌‫‭⁮⁪‌‎⁯‮
		private void u200b⁮⁪‌⁭‪‭‌​‍‭‏‍‬​‌⁪‬‫‪‪⁮​⁬‎​‫‌⁯⁬​⁬‌‫‭⁮⁪‌‎⁯‮(bool flag)
		{
			int num;
			int num1;
			if (!TetraPanel.u200f‏⁫​‪‌⁮‫​‍‏‍⁭​‬⁯⁬‬‌⁯‍⁫‮‮‍‬⁫⁭‏⁭‏‍⁭⁮​⁪⁬⁫⁭‭‮(this.u206e​‮⁪⁯⁭⁬‌‭‪‍‌‮⁬‭‏‫‫‬⁮⁭‎⁮​‫‍‎‪⁫‏‍‎‫‏‬⁪⁮‍​⁪‮))
			{
				goto Label0;
			}
		Label2:
			num = 30240138;
		Label4:
			while (true)
			{
				int num2 = num ^ 1941640890;
				uint num3 = (uint)num2;
				switch (num2 % 7)
				{
					case 0:
					{
						this.u206f‌‏‪‫‏‮⁫‮‭⁯⁯⁮‎⁭‏‪‎⁮⁮⁬​‪‍⁬‭‬⁮​‬⁮‍‬‍‍‬‪‮​‪‮ = true;
						num = (int)(num3 * -101307480 ^ 1876715557);
						continue;
					}
					case 1:
					{
						num1 = (flag ? 565111765 : 1147386256);
						num = (int)(num1 ^ num3 * -655661010);
						continue;
					}
					case 2:
					{
						this.u202e‫⁮‭‏‎⁭⁪⁮‪‪⁫‬‮‭‭⁯‭‫​‫‭‮‭‪‫‭‍‎⁯‫‬‪‫​‎‌‎​‍‮ = true;
						num = (int)(num3 * -1610346266 ^ 1693734903);
						continue;
					}
					case 3:
					{
						goto Label0;
					}
					case 4:
					{
						return;
					}
					case 5:
					{
						break;
					}
					case 6:
					{
						goto Label2;
					}
					default:
					{
						return;
					}
				}
			}
			return;
		Label0:
			TetraPanel.u200b⁮⁭⁪⁬‬⁭‎⁮‫⁫‌‫‭‎‎‎‬‍‮‍‎​‬‫⁭⁮⁫⁬‭‫⁭​‌⁮‫⁬‫‫⁬‮(this.u206e​‮⁪⁯⁭⁬‌‭‪‍‌‮⁬‭‏‫‫‬⁮⁭‎⁮​‫‍‎‪⁫‏‍‎‫‏‬⁪⁮‍​⁪‮, this.u200b‍⁯⁪‌‍‍‎‪⁯⁮⁪‬⁯⁮⁮‍⁫‫⁭⁯​⁮⁮‫⁫‪‭‪⁪‪⁬⁫‬‎‌‎⁬‎⁫‮.TopMostInfo);
			TetraPanel.u206b⁯⁯‮‌‏⁬⁫​‮‎⁬⁭‭‪‬‍‍⁭⁯‭⁬‍⁮​⁪⁮⁫‎‎‌‌‌​⁪‬‪‏‎‭‮(this.u206e​‮⁪⁯⁭⁬‌‭‪‍‌‮⁬‭‏‫‫‬⁮⁭‎⁮​‫‍‎‪⁫‏‍‎‫‏‬⁪⁮‍​⁪‮);
			num = 1787009784;
			goto Label4;
		}

		// ⁬‫‫​​‎⁯‫‫‭‍⁭‌‎⁮⁮‌‌⁭‮‎‎⁫‮‏‪‫‍⁯⁮⁮⁬‮‌⁪⁫⁮‭‬‌‮
		private void u206c‫‫​​‎⁯‫‫‭‍⁭‌‎⁮⁮‌‌⁭‮‎‎⁫‮‏‪‫‍⁯⁮⁮⁬‮‌⁪⁫⁮‭‬‌‮(object obj, EventArgs eventArg)
		{
			int num;
			int num1;
			bool tttModeEnabled = this.u200b‍⁯⁪‌‍‍‎‪⁯⁮⁪‬⁯⁮⁮‍⁫‫⁭⁯​⁮⁮‫⁫‪‭‪⁪‪⁬⁫‬‎‌‎⁬‎⁫‮.TttModeEnabled;
			int tttUdpPort = this.u200b‍⁯⁪‌‍‍‎‪⁯⁮⁪‬⁯⁮⁮‍⁫‫⁭⁯​⁮⁮‫⁫‪‭‪⁪‪⁬⁫‬‎‌‎⁬‎⁫‮.TttUdpPort;
			DialogConfigure dialogConfigure = new DialogConfigure(this.u200b‍⁯⁪‌‍‍‎‪⁯⁮⁪‬⁯⁮⁮‍⁫‫⁭⁯​⁮⁮‫⁫‪‭‪⁪‪⁬⁫‬‎‌‎⁬‎⁫‮, this);
			TetraPanel.u206d⁮​‪‫‫⁫⁯⁭⁮⁪‬‏‍​‬‍‌⁫⁬‮‍‮⁮⁬‏‭⁯⁫‍‮‬​‏⁪⁬‌⁮‬‎‮(dialogConfigure, FormStartPosition.CenterParent);
			TetraPanel.u206e‬‪‎‎‬⁭⁬‌⁭‪⁬‌‮‏​‏⁮⁮‫⁮‬⁯⁬‮⁮‬⁭‫‪‍​⁭‎⁪‮⁪⁯‍⁫‮(dialogConfigure);
			this.u202a‎‌​⁮⁫‍⁮‬‭‎⁫‮​⁭⁪⁭‮⁫‮⁭‎‭‍‬‫‏⁮‍‫⁪‫‫​‌​⁮‎⁯‮‮();
			TetraPanel.u206a‏⁫‫​‏⁪⁬⁪‪⁪⁬‬⁫⁯‎‪⁯‫‎⁯‪‭‎‮‪‎⁮⁯‭⁯‎⁮⁮‪‭⁫‬⁫⁬‮(this.u200e‎⁭‏‎‪‎‍‬⁭⁮⁬‍⁭‮​⁪‮‏‍⁪‎‫⁮‫⁭⁯⁪‌‌​‌⁬‫‏‬‍⁯⁮‭‮, !this.u200b‍⁯⁪‌‍‍‎‪⁯⁮⁪‬⁯⁮⁮‍⁫‫⁭⁯​⁮⁮‫⁫‪‭‪⁪‪⁬⁫‬‎‌‎⁬‎⁫‮.TttModeEnabled);
			TetraPanel.u206a‏⁫‫​‏⁪⁬⁪‪⁪⁬‬⁫⁯‎‪⁯‫‎⁯‪‭‎‮‪‎⁮⁯‭⁯‎⁮⁮‪‭⁫‬⁫⁬‮(this.u200c‎‎‪‎‮‎⁫‭‪⁯⁬⁪⁬‏‮‏‪‫‏⁯⁪​⁬‫⁯⁪‎‪‏‫‮⁯‏‪‭‬‏‪‮, this.u200b‍⁯⁪‌‍‍‎‪⁯⁮⁪‬⁯⁮⁮‍⁫‫⁭⁯​⁮⁮‫⁫‪‭‪⁪‪⁬⁫‬‎‌‎⁬‎⁫‮.TttModeEnabled);
			TetraPanel.GssiDisplayType = this.u200b‍⁯⁪‌‍‍‎‪⁯⁮⁪‬⁯⁮⁮‍⁫‫⁭⁯​⁮⁮‫⁫‪‭‪⁪‪⁬⁫‬‎‌‎⁬‎⁫‮.GssiDisplayType;
			TetraPanel.u206a‏⁫‫​‏⁪⁬⁪‪⁪⁬‬⁫⁯‎‪⁯‫‎⁯‪‭‎‮‪‎⁮⁯‭⁯‎⁮⁮‪‭⁫‬⁫⁬‮(this.u202a‪⁮​‏‫‮‫⁭⁯⁭‬⁯‎‭​‎⁬‭⁬‬‬‬‌⁪‍⁪​‎‍⁯​‍⁯⁫‎‍⁪‎‭‮, this.u200b‍⁯⁪‌‍‍‎‪⁯⁮⁪‬⁯⁮⁮‍⁫‫⁭⁯​⁮⁮‫⁫‪‭‪⁪‪⁬⁫‬‎‌‎⁬‎⁫‮.AudioAGCEnabled);
			TetraPanel.u206a‏⁫‫​‏⁪⁬⁪‪⁪⁬‬⁫⁯‎‪⁯‫‎⁯‪‭‎‮‪‎⁮⁯‭⁯‎⁮⁮‪‭⁫‬⁫⁬‮(this.u200f‍‮‏‌‏‌‍‍⁪⁫⁯⁭‫⁮⁫‫⁯‏‫⁪‍‫⁮‮⁪⁫‍‭‍⁫‏‍⁫‍‌⁪⁫⁪⁭‮, this.u200b‍⁯⁪‌‍‍‎‪⁯⁮⁪‬⁯⁮⁮‍⁫‫⁭⁯​⁮⁮‫⁫‪‭‪⁪‪⁬⁫‬‎‌‎⁬‎⁫‮.AudioAGCEnabled);
			TetraPanel.u206a‏⁫‫​‏⁪⁬⁪‪⁪⁬‬⁫⁯‎‪⁯‫‎⁯‪‭‎‮‪‎⁮⁯‭⁯‎⁮⁮‪‭⁫‬⁫⁬‮(this.u206a⁯‏⁯​‫‬⁬‌⁮​⁯‬‌‭⁯‪⁬⁯⁮‌‫⁫⁫‍‎‎⁫⁮‫‍‍‪​‮‍‮‭⁬‏‮, this.u200b‍⁯⁪‌‍‍‎‪⁯⁮⁪‬⁯⁮⁮‍⁫‫⁭⁯​⁮⁮‫⁫‪‭‪⁪‪⁬⁫‬‎‌‎⁬‎⁫‮.AudioAGCEnabled);
			TetraPanel.u206a‏⁫‫​‏⁪⁬⁪‪⁪⁬‬⁫⁯‎‪⁯‫‎⁯‪‭‎‮‪‎⁮⁯‭⁯‎⁮⁮‪‭⁫‬⁫⁬‮(this.u202b⁪⁭‍‎⁭‮⁮‭⁮⁪‬⁯⁭‎‌⁫‮‮⁪‍⁯‎‍‫⁫‪‪‎‪‬‍‎‮‍⁭‍⁭‎⁬‮, this.u200b‍⁯⁪‌‍‍‎‪⁯⁮⁪‬⁯⁮⁮‍⁫‫⁭⁯​⁮⁮‫⁫‪‭‪⁪‪⁬⁫‬‎‌‎⁬‎⁫‮.AudioAGCEnabled);
			TetraPanel.u206a‏⁫‫​‏⁪⁬⁪‪⁪⁬‬⁫⁯‎‪⁯‫‎⁯‪‭‎‮‪‎⁮⁯‭⁯‎⁮⁮‪‭⁫‬⁫⁬‮(this.u202a‪‬⁭‮⁬⁫‫⁬‮‏‪‪‭‎‌‫‪‍⁭‏⁮⁬‭⁪⁯‍‍⁭‪‏‫‮​⁪⁭⁪‪‬‮, this.u200b‍⁯⁪‌‍‍‎‪⁯⁮⁪‬⁯⁮⁮‍⁫‫⁭⁯​⁮⁮‫⁫‪‭‪⁪‪⁬⁫‬‎‌‎⁬‎⁫‮.AudioAGCEnabled);
			TetraPanel.u206a‏⁫‫​‏⁪⁬⁪‪⁪⁬‬⁫⁯‎‪⁯‫‎⁯‪‭‎‮‪‎⁮⁯‭⁯‎⁮⁮‪‭⁫‬⁫⁬‮(this.u200c‫‌‪‌‌‏​⁯⁪​‫⁪⁮⁯‫‍⁪⁫⁪‮⁬⁬‭⁯‌‫⁯‫‪‏‭‏⁭⁬‌‫‬⁪⁬‮, this.u200b‍⁯⁪‌‍‍‎‪⁯⁮⁪‬⁯⁮⁮‍⁫‫⁭⁯​⁮⁮‫⁫‪‭‪⁪‪⁬⁫‬‎‌‎⁬‎⁫‮.AudioAGCEnabled);
			TetraPanel.u206b⁪‫‬⁮‬‭‪‮‍‌⁮⁮⁪‏‍‍‎‏‎​‏‏⁮‬‫⁬‬⁫‪⁪⁮⁫‏⁪‪⁭‎‌⁯‮(this.u202b‫‌‍⁭‎‮⁮‍‮‎‏⁮‭‌⁭⁫‮⁮‭‎‏⁮⁮‌‌‫‬‪⁬⁬‏‌‭‌‫‌‭‭⁭‮, !this.u200b‍⁯⁪‌‍‍‎‪⁯⁮⁪‬⁯⁮⁮‍⁫‫⁭⁯​⁮⁮‫⁫‪‭‪⁪‪⁬⁫‬‎‌‎⁬‎⁫‮.TttModeEnabled);
			if (tttModeEnabled != this.u200b‍⁯⁪‌‍‍‎‪⁯⁮⁪‬⁯⁮⁮‍⁫‫⁭⁯​⁮⁮‫⁫‪‭‪⁪‪⁬⁫‬‎‌‎⁬‎⁫‮.TttModeEnabled)
			{
				goto Label0;
			}
		Label1:
			num = -1342809189;
		Label4:
			while (true)
			{
				int num2 = num ^ -31398259;
				uint num3 = (uint)num2;
				switch (num2 % 5)
				{
					case 0:
					{
						goto Label1;
					}
					case 1:
					{
						num1 = (tttUdpPort == this.u200b‍⁯⁪‌‍‍‎‪⁯⁮⁪‬⁯⁮⁮‍⁫‫⁭⁯​⁮⁮‫⁫‪‭‪⁪‪⁬⁫‬‎‌‎⁬‎⁫‮.TttUdpPort ? 1583838237 : 1186283994);
						num = (int)(num1 ^ num3 * 1489778759);
						continue;
					}
					case 2:
					{
						TetraPanel.BroadcastPort = this.u200b‍⁯⁪‌‍‍‎‪⁯⁮⁪‬⁯⁮⁮‍⁫‫⁭⁯​⁮⁮‫⁫‪‭‪⁪‪⁬⁫‬‎‌‎⁬‎⁫‮.TttUdpPort + 2;
						this.ServerControl(true);
						num = (int)(num3 * -313631991 ^ -206517394);
						continue;
					}
					case 3:
					{
						break;
					}
					case 4:
					{
						return;
					}
					default:
					{
						return;
					}
				}
			}
		Label0:
			this.ServerControl(false);
			num = -892311828;
			goto Label4;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		// ‪‎‌​⁮⁫‍⁮‬‭‎⁫‮​⁭⁪⁭‮⁫‮⁭‎‭‍‬‫‏⁮‍‫⁪‫‫​‌​⁮‎⁯‮‮
		private void u202a‎‌​⁮⁫‍⁮‬‭‎⁫‮​⁭⁪⁭‮⁫‮⁭‎‭‍‬‫‏⁮‍‫⁪‫‫​‌​⁮‎⁯‮‮()
		{
			string str = null;
			int num;
			u206b⁯⁬‫⁬⁬‎‭⁪‫‎‭‍‎‪⁬‪⁭‬⁬‬‍⁪‭‌⁬⁯⁯‌⁯⁮‪‍‍‫‮​‎⁭‎‮.u206b‭‍⁯⁫‪‭⁭‎‏‎‮​⁯‌⁬‭‮‭‮‌⁬⁫‫‪⁬‭⁫‭⁬⁪⁯‫⁭‎⁬⁬‎⁪⁯‮ = this.u200b‍⁯⁪‌‍‍‎‪⁯⁮⁪‬⁯⁮⁮‍⁫‫⁭⁯​⁮⁮‫⁫‪‭‪⁪‪⁬⁫‬‎‌‎⁬‎⁫‮.IgnoreEncodedData;
		Label0:
			int num1 = -1938092054;
			while (true)
			{
				int num2 = num1 ^ -943462823;
				uint num3 = (uint)num2;
				switch (num2 % 9)
				{
					case 0:
					{
						str = u003cModuleu003e.u200f⁫‌​⁬‌‎‎‏‍‍⁫‎​‌‬⁯‬‫‭‎‏​‌​⁪‭‬⁬‮⁬​‌⁬⁪‫‫‎⁪⁮‮<string>(-1113968574);
						num1 = -1506446198;
						continue;
					}
					case 1:
					{
						TetraPanel.IsTttUsed = this.u200b‍⁯⁪‌‍‍‎‪⁯⁮⁪‬⁯⁮⁮‍⁫‫⁭⁯​⁮⁮‫⁫‪‭‪⁪‪⁬⁫‬‎‌‎⁬‎⁫‮.TttModeEnabled;
						TetraPanel.ShowEncryptedCallDetails = this.u200b‍⁯⁪‌‍‍‎‪⁯⁮⁪‬⁯⁮⁮‍⁫‫⁭⁯​⁮⁮‫⁫‪‭‪⁪‪⁬⁫‬‎‌‎⁬‎⁫‮.ShowEncryptedCallDetails;
						num1 = (int)(num3 * 901616164 ^ -1720497408);
						continue;
					}
					case 2:
					{
						str = u003cModuleu003e.u200d​‍⁮‏‭⁮⁪‌‪‬‬‬‪⁬⁭⁫⁫‬⁪⁬⁬⁬‏⁮⁭‌‍‏‍‏‎‬⁬​‪‎​‎⁭‮<string>(-1273497222);
						num1 = -206320826;
						continue;
					}
					case 3:
					{
						TetraPanel.SdrSharpRole = str;
						num1 = -1993352208;
						continue;
					}
					case 4:
					{
						num = (!this.u200b‍⁯⁪‌‍‍‎‪⁯⁮⁪‬⁯⁮⁮‍⁫‫⁭⁯​⁮⁮‫⁫‪‭‪⁪‪⁬⁫‬‎‌‎⁬‎⁫‮.IsCc ? 1162758921 : 1958528809);
						num1 = (int)(num ^ num3 * -935393675);
						continue;
					}
					case 5:
					{
						goto Label0;
					}
					case 6:
					{
						TetraPanel.ElementVerbosity = this.u200b‍⁯⁪‌‍‍‎‪⁯⁮⁪‬⁯⁮⁮‍⁫‫⁭⁯​⁮⁮‫⁫‪‭‪⁪‪⁬⁫‬‎‌‎⁬‎⁫‮.ElementVerbosity;
						TetraPanel.LogMM = this.u200b‍⁯⁪‌‍‍‎‪⁯⁮⁪‬⁯⁮⁮‍⁫‫⁭⁯​⁮⁮‫⁫‪‭‪⁪‪⁬⁫‬‎‌‎⁬‎⁫‮.LogMmRegistrations;
						TetraPanel.SdsShowBinaryString = this.u200b‍⁯⁪‌‍‍‎‪⁯⁮⁪‬⁯⁮⁮‍⁫‫⁭⁯​⁮⁮‫⁫‪‭‪⁪‪⁬⁫‬‎‌‎⁬‎⁫‮.ShowSdsBinaryString;
						TetraPanel.IgnoreEncodedData = this.u200b‍⁯⁪‌‍‍‎‪⁯⁮⁪‬⁯⁮⁮‍⁫‫⁭⁯​⁮⁮‫⁫‪‭‪⁪‪⁬⁫‬‎‌‎⁬‎⁫‮.IgnoreEncodedData;
						TetraPanel.StrongerBusrtDetection = this.u200b‍⁯⁪‌‍‍‎‪⁯⁮⁪‬⁯⁮⁮‍⁫‫⁭⁯​⁮⁮‫⁫‪‭‪⁪‪⁬⁫‬‎‌‎⁬‎⁫‮.StrongerBusrtDetection;
						PhyLevel.DiagramUseSyncOnly = this.u200b‍⁯⁪‌‍‍‎‪⁯⁮⁪‬⁯⁮⁮‍⁫‫⁭⁯​⁮⁮‫⁫‪‭‪⁪‪⁬⁫‬‎‌‎⁬‎⁫‮.DiagramUseSyncOnly;
						num1 = (int)(num3 * 1268337973 ^ 256363541);
						continue;
					}
					case 7:
					{
						return;
					}
					case 8:
					{
						u206b⁯⁬‫⁬⁬‎‭⁪‫‎‭‍‎‪⁬‪⁭‬⁬‬‍⁪‭‌⁬⁯⁯‌⁯⁮‪‍‍‫‮​‎⁭‎‮.u200b‍‎⁭‏‏‫⁫‬‫⁫⁬⁬⁬‫⁭⁪‫‭⁯‍‫‌⁮‪‎⁬‪⁭‍⁫‭‎⁭‌​‍‏‌‎‮ = this.u200b‍⁯⁪‌‍‍‎‪⁯⁮⁪‬⁯⁮⁮‍⁫‫⁭⁯​⁮⁮‫⁫‪‭‪⁪‪⁬⁫‬‎‌‎⁬‎⁫‮.IgnoreEncodedSpeech;
						num1 = (int)(num3 * 1264017658 ^ -1024194554);
						continue;
					}
				}
			}
		}

		// ‌‎‎⁬‏‪‎‌⁭⁯‮⁭‭‪‎⁯⁪⁫‏‫⁬​‬⁪‭‪⁬‫‭⁮‮‏‏‍⁪⁫⁬​‍⁮‮
		private void u200c‎‎⁬‏‪‎‌⁭⁯‮⁭‭‪‎⁯⁪⁫‏‫⁬​‬⁪‭‪⁬‫‭⁮‮‏‏‍⁪⁫⁬​‍⁮‮(object obj, EventArgs eventArg)
		{
			this.u200b‍⁯⁪‌‍‍‎‪⁯⁮⁪‬⁯⁮⁮‍⁫‫⁭⁯​⁮⁮‫⁫‪‭‪⁪‪⁬⁫‬‎‌‎⁬‎⁫‮.BlockedLevel = (int)TetraPanel.u202a⁮​‮‌‪‏⁭‪‪⁮⁫‌‏‎‬‫‍⁫⁯‭‎⁪‫⁭‌⁭⁯‎​⁮⁮⁪‌‭‬⁭⁭⁮⁪‮(this.u202b‫‌‍⁭‎‮⁮‍‮‎‏⁮‭‌⁭⁫‮⁮‭‎‏⁮⁮‌‌‫‬‪⁬⁬‏‌‭‌‫‌‭‭⁭‮);
		}

		// ⁭‭⁭⁭‭‏‌‮⁪‫‪⁫‌‌‍‍‭‬⁭⁪‭​⁮⁮‫⁯​⁬⁬‬⁮‪‪⁫‌‬‭⁮‭‍‮
		private void u206d‭⁭⁭‭‏‌‮⁪‫‪⁫‌‌‍‍‭‬⁭⁪‭​⁮⁮‫⁯​⁬⁬‬⁮‪‪⁫‌‬‭⁮‭‍‮(object obj, LinkLabelLinkClickedEventArgs linkLabelLinkClickedEventArg)
		{
			TetraPanel.u202a‬⁪‬⁫‎‌⁯‪‫⁮⁪‫⁮‏⁫‭‎⁭​⁮⁪⁪‪⁪⁬‎⁭‎⁭⁭‮‮‍‮⁮⁫⁮‭⁮‮(this.u202a⁬‮⁬‬‮‏⁬‏⁯⁬​⁮​‌‫‍⁯‌⁬⁫‪⁬‬⁪⁪‫⁫⁭‎‍‫‫‬‮‬⁫⁯⁫‌‮, this.u202b​‭⁭‭⁫​​‍‎⁭‬‏​⁫‮‏⁬‭‎‪‬⁮⁭‌⁬⁮‍⁪⁯⁪‌‍⁬‫⁭⁭⁪⁫⁫‮);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		// ‮‌⁯‎⁭⁪‬⁬⁭⁬‪‮‌‮⁮‫⁪⁬⁬‎‬⁭⁪⁫‌⁪‪‬‍‎‍⁫‎‫⁫‬⁬‎‬⁭‮
		private void u202e‌⁯‎⁭⁪‬⁬⁭⁬‪‮‌‮⁮‫⁪⁬⁬‎‬⁭⁪⁫‌⁪‪‬‍‎‍⁫‎‫⁫‬⁬‎‬⁭‮(CallsEntry )
		{
			// 
			// Current member / type: System.Void SDRSharp.Tetra.TetraPanel::‮‌⁯‎⁭⁪‬⁬⁭⁬‪‮‌‮⁮‫⁪⁬⁬‎‬⁭⁪⁫‌⁪‪‬‍‎‍⁫‎‫⁫‬⁬‎‬⁭‮(SDRSharp.Tetra.CallsEntry)
			// File path: C:\SDRSharp\Plugins\Tetra\SDRSharp.Tetra.dll
			// 
			// Product version: 0.0.0.0
			// Exception in: System.Void ‮‌⁯‎⁭⁪‬⁬⁭⁬‪‮‌‮⁮‫⁪⁬⁬‎‬⁭⁪⁫‌⁪‪‬‍‎‍⁫‎‫⁫‬⁬‎‬⁭‮(SDRSharp.Tetra.CallsEntry)
			// 
			// Not supported type System.Object.
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.GetTypeIndex(TypeDefinition type) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 684
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.GetContainingType(TypeDefinition leftType, TypeDefinition rightType) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 608
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.GetExpressionType() in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 492
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.get_ExpressionType() in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 414
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.AddAssignmentCastIfNeeded(Expression expr) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\TypeInference\TypeInferer.cs:line 112
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.FixAssignmentInList(IList`1 expressionList, Expression value) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\TypeInference\TypeInferer.cs:line 75
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.AddCasts() in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\TypeInference\TypeInferer.cs:line 38
			//    at Telerik.JustDecompiler.Decompiler.ExpressionDecompilerStep.Process(DecompilationContext theContext, BlockStatement body) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\ExpressionDecompilerStep.cs:line 68
			//    at Telerik.JustDecompiler.Decompiler.DecompilationPipeline.RunInternal(MethodBody body, BlockStatement block, ILanguage language) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\DecompilationPipeline.cs:line 100
			//    at Telerik.JustDecompiler.Decompiler.WriterContextServices.BaseWriterContextService.DecompileMethod(ILanguage language, MethodDefinition method, TypeSpecificContext typeContext) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\WriterContextServices\BaseWriterContextService.cs:line 133
			// 
			// mailto: JustDecompilePublicFeedback@telerik.com

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		// ⁫⁬⁭‭⁮‭⁮‎‬⁭⁮⁯‮⁮‍⁭‌⁮‪​‬‪‮⁭‌⁬⁭‭‫⁭⁬‌‍⁫‪‌⁭⁭⁬‏‮
		private static string u206b⁬⁭‭⁮‭⁮‎‬⁭⁮⁯‮⁮‍⁭‌⁮‪​‬‪‮⁭‌⁬⁭‭‫⁭⁬‌‍⁫‪‌⁭⁭⁬‏‮(long )
		{
			// 
			// Current member / type: System.String SDRSharp.Tetra.TetraPanel::⁫⁬⁭‭⁮‭⁮‎‬⁭⁮⁯‮⁮‍⁭‌⁮‪​‬‪‮⁭‌⁬⁭‭‫⁭⁬‌‍⁫‪‌⁭⁭⁬‏‮(System.Int64)
			// File path: C:\SDRSharp\Plugins\Tetra\SDRSharp.Tetra.dll
			// 
			// Product version: 0.0.0.0
			// Exception in: System.String ⁫⁬⁭‭⁮‭⁮‎‬⁭⁮⁯‮⁮‍⁭‌⁮‪​‬‪‮⁭‌⁬⁭‭‫⁭⁬‌‍⁫‪‌⁭⁭⁬‏‮(System.Int64)
			// 
			// Not supported type System.Object.
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.GetTypeIndex(TypeDefinition type) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 684
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.GetContainingType(TypeDefinition leftType, TypeDefinition rightType) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 608
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.GetExpressionType() in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 492
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.get_ExpressionType() in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 414
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.AddAssignmentCastIfNeeded(Expression expr) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\TypeInference\TypeInferer.cs:line 112
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.FixAssignmentInList(IList`1 expressionList, Expression value) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\TypeInference\TypeInferer.cs:line 75
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.AddCasts() in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\TypeInference\TypeInferer.cs:line 38
			//    at Telerik.JustDecompiler.Decompiler.ExpressionDecompilerStep.Process(DecompilationContext theContext, BlockStatement body) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\ExpressionDecompilerStep.cs:line 68
			//    at Telerik.JustDecompiler.Decompiler.DecompilationPipeline.RunInternal(MethodBody body, BlockStatement block, ILanguage language) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\DecompilationPipeline.cs:line 100
			//    at Telerik.JustDecompiler.Decompiler.WriterContextServices.BaseWriterContextService.DecompileMethod(ILanguage language, MethodDefinition method, TypeSpecificContext typeContext) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\WriterContextServices\BaseWriterContextService.cs:line 133
			// 
			// mailto: JustDecompilePublicFeedback@telerik.com

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		// ⁯‫‮⁪⁬‪‬⁯‌⁭‭⁯‫‫​​‏​⁬‏‫⁭‫‍⁭⁭​‫⁭‮‬‍‮‎‭​⁯‭‍‮
		private string u206f‫‮⁪⁬‪‬⁯‌⁭‭⁯‫‫​​‏​⁬‏‫⁭‫‍⁭⁭​‫⁭‮‬‍‮‎‭​⁯‭‍‮(string str, string str, string str)
		{
			string str1;
			string str2;
			string str3;
			DirectoryInfo directoryInfo;
			object obj;
			DialogResult dialogResult;
			string str4 = str;
		Label0:
			int num = -946232027;
			while (true)
			{
				int num1 = num ^ -1714655730;
				uint num2 = (uint)num1;
				switch (num1 % 3)
				{
					case 0:
					{
						goto Label0;
					}
					case 1:
					{
						str3 = str4;
						str2 = str4;
						str1 = TetraPanel.u206a‏​‪⁯‌‮‫‭‏‫‏‮‮⁪‎‏⁭⁮‎‬⁭‎‎‮⁭‬⁫⁮‭⁯‭‎​‬⁭⁬⁫⁮‬‮(str3, 0, TetraPanel.u200c⁪⁬‌⁪‭⁭​⁫‌⁮‬⁪‍⁮⁫‎⁮‭‪‎‫‭⁭⁯⁭⁯‭‭⁮⁮⁫⁮‬⁪⁪⁮⁭‏⁪‮(str2, u003cModuleu003e.u206f⁮​‌‪‮‎‭‏‮‎⁮⁮‮⁬⁫‍‍⁪‍⁫⁮‏​‎⁬⁯⁪‪‍⁪⁮‎⁬⁪⁫​⁮⁪⁮‮<string>(-1441430984)));
						try
						{
							directoryInfo = TetraPanel.u202e⁫‏‭‌⁯‭⁭⁬‌​‍‮⁬‮‭⁪‌‎⁯⁭‭‍⁫‌‮‌⁭‭‏‍‪​​⁪‮⁫‫​‎‮(str1);
						}
						catch
						{
							obj = obj1;
							dialogResult = TetraPanel.u206d​‌‫‍‫‬‌‮⁭⁬⁫⁯‎‬‭⁭​⁭⁭‫⁮‌‍‍‪⁯⁮‮‫⁭⁭‏‭‪⁭‪⁯⁮‪‮(u003cModuleu003e.u200d​‍⁮‏‭⁮⁪‌‪‬‬‬‪⁬⁭⁫⁫‬⁪⁬⁬⁬‏⁮⁭‌‍‏‍‏‎‬⁬​‪‎​‎⁭‮<string>(2054489012), str1, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						}
						return str4;
					}
					case 2:
					{
						str4 = TetraPanel.u206a‬‍‬‍​‏‫‍‎‌‪⁭‍‭⁯‮‫⁪‮‮‫⁮⁮‪⁮‌‎‎⁬⁬‬‍‌‎‎‬⁭‍‌‮(str4, this.ParseStringToPath(str, str));
						num = (int)(num2 * 978836997 ^ -2035735090);
						continue;
					}
				}
			}
			str3 = str4;
			str2 = str4;
			str1 = TetraPanel.u206a‏​‪⁯‌‮‫‭‏‫‏‮‮⁪‎‏⁭⁮‎‬⁭‎‎‮⁭‬⁫⁮‭⁯‭‎​‬⁭⁬⁫⁮‬‮(str3, 0, TetraPanel.u200c⁪⁬‌⁪‭⁭​⁫‌⁮‬⁪‍⁮⁫‎⁮‭‪‎‫‭⁭⁯⁭⁯‭‭⁮⁮⁫⁮‬⁪⁪⁮⁭‏⁪‮(str2, u003cModuleu003e.u206f⁮​‌‪‮‎‭‏‮‎⁮⁮‮⁬⁫‍‍⁪‍⁫⁮‏​‎⁬⁯⁪‪‍⁪⁮‎⁬⁪⁫​⁮⁪⁮‮<string>(-1441430984)));
			try
			{
				directoryInfo = TetraPanel.u202e⁫‏‭‌⁯‭⁭⁬‌​‍‮⁬‮‭⁪‌‎⁯⁭‭‍⁫‌‮‌⁭‭‏‍‪​​⁪‮⁫‫​‎‮(str1);
			}
			catch
			{
				obj = obj1;
				dialogResult = TetraPanel.u206d​‌‫‍‫‬‌‮⁭⁬⁫⁯‎‬‭⁭​⁭⁭‫⁮‌‍‍‪⁯⁮‮‫⁭⁭‏‭‪⁭‪⁯⁮‪‮(u003cModuleu003e.u200d​‍⁮‏‭⁮⁪‌‪‬‬‬‪⁬⁭⁫⁫‬⁪⁬⁬⁬‏⁮⁭‌‍‏‍‏‎‬⁬​‪‎​‎⁭‮<string>(2054489012), str1, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			return str4;
		}

		// ‮⁭‌⁪​‬⁮⁫⁭‬‍‬⁯‫‪​⁭⁮‎‌‎‎⁬⁭‏⁭‭‪⁯⁯‬‎‎‌⁬‍‭​⁬‮
		private bool u202e⁭‌⁪​‬⁮⁫⁭‬‍‬⁯‫‪​⁭⁮‎‌‎‎⁬⁭‏⁭‭‪⁯⁯‬‎‎‌⁬‍‭​⁬‮(string str, string str, int num)
		{
			if (num + TetraPanel.u206c‌‬‮‫‬⁮‎⁫⁯‪⁪⁬⁬‏‬‌⁮⁮‪‭⁭⁮⁫‮‎​‫⁮​⁯‍‪⁪‭‭⁪‭‏⁭‮(str) <= TetraPanel.u206c‌‬‮‫‬⁮‎⁫⁯‪⁪⁬⁬‏‬‌⁮⁮‪‭⁭⁮⁫‮‎​‫⁮​⁯‍‪⁪‭‭⁪‭‏⁭‮(str))
			{
				return TetraPanel.u202a‎​⁫⁪‫‭⁮⁪‫‮‎⁫‏‎‍​⁫⁮‫‭‎‏​⁭‭⁭‏‌‭‎⁮‬⁯‎‫⁪‭⁬‫‮(TetraPanel.u206a‏​‪⁯‌‮‫‭‏‫‏‮‮⁪‎‏⁭⁮‎‬⁭‎‎‮⁭‬⁫⁮‭⁯‭‎​‬⁭⁬⁫⁮‬‮(str, num, TetraPanel.u206c‌‬‮‫‬⁮‎⁫⁯‪⁪⁬⁬‏‬‌⁮⁮‪‭⁭⁮⁫‮‎​‫⁮​⁯‍‪⁪‭‭⁪‭‏⁭‮(str)), str);
			}
		Label1:
			int num1 = 838221179 ^ 1656375103;
			uint num2 = (uint)num1;
			switch (num1 % 3)
			{
				case 1:
				{
					return false;
				}
				case 2:
				{
					goto Label1;
				}
			}
			return TetraPanel.u202a‎​⁫⁪‫‭⁮⁪‫‮‎⁫‏‎‍​⁫⁮‫‭‎‏​⁭‭⁭‏‌‭‎⁮‬⁯‎‫⁪‭⁬‫‮(TetraPanel.u206a‏​‪⁯‌‮‫‭‏‫‏‮‮⁪‎‏⁭⁮‎‬⁭‎‎‮⁭‬⁫⁮‭⁯‭‎​‬⁭⁬⁫⁮‬‮(str, num, TetraPanel.u206c‌‬‮‫‬⁮‎⁫⁯‪⁪⁬⁬‏‬‌⁮⁮‪‭⁭⁮⁫‮‎​‫⁮​⁯‍‪⁪‭‭⁪‭‏⁭‮(str)), str);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		// ​‍​‏‎‏‌⁯⁪⁭⁮⁪‫⁫​‏⁮‍⁯⁪⁭‪‭⁭⁬‮⁬⁯‌‎⁫‭‍‍‍⁪‬‮⁫‮‮
		private void u200b‍​‏‎‏‌⁯⁪⁭⁮⁪‫⁫​‏⁮‍⁯⁪⁭‪‭⁭⁬‮⁬⁯‌‎⁫‭‍‍‍⁪‬‮⁫‮‮(object , EventArgs )
		{
			// 
			// Current member / type: System.Void SDRSharp.Tetra.TetraPanel::​‍​‏‎‏‌⁯⁪⁭⁮⁪‫⁫​‏⁮‍⁯⁪⁭‪‭⁭⁬‮⁬⁯‌‎⁫‭‍‍‍⁪‬‮⁫‮‮(System.Object,System.EventArgs)
			// File path: C:\SDRSharp\Plugins\Tetra\SDRSharp.Tetra.dll
			// 
			// Product version: 0.0.0.0
			// Exception in: System.Void ​‍​‏‎‏‌⁯⁪⁭⁮⁪‫⁫​‏⁮‍⁯⁪⁭‪‭⁭⁬‮⁬⁯‌‎⁫‭‍‍‍⁪‬‮⁫‮‮(System.Object,System.EventArgs)
			// 
			// Not supported type System.Object.
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.GetTypeIndex(TypeDefinition type) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 684
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.GetContainingType(TypeDefinition leftType, TypeDefinition rightType) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 608
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.GetExpressionType() in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 492
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.get_ExpressionType() in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 414
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.AddAssignmentCastIfNeeded(Expression expr) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\TypeInference\TypeInferer.cs:line 112
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.FixAssignmentInList(IList`1 expressionList, Expression value) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\TypeInference\TypeInferer.cs:line 75
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.AddCasts() in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\TypeInference\TypeInferer.cs:line 38
			//    at Telerik.JustDecompiler.Decompiler.ExpressionDecompilerStep.Process(DecompilationContext theContext, BlockStatement body) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\ExpressionDecompilerStep.cs:line 68
			//    at Telerik.JustDecompiler.Decompiler.DecompilationPipeline.RunInternal(MethodBody body, BlockStatement block, ILanguage language) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\DecompilationPipeline.cs:line 100
			//    at Telerik.JustDecompiler.Decompiler.WriterContextServices.BaseWriterContextService.DecompileMethod(ILanguage language, MethodDefinition method, TypeSpecificContext typeContext) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\WriterContextServices\BaseWriterContextService.cs:line 133
			// 
			// mailto: JustDecompilePublicFeedback@telerik.com

		}

		// ‎​‎​⁮⁬‮​⁯⁭‏​‮‌‮‭‏‌⁫‎‫‫‌⁭​‍‭⁫​‭⁭‮‌⁭‍⁮‬⁫‮⁯‮
		private void u200e​‎​⁮⁬‮​⁯⁭‏​‮‌‮‭‏‌⁫‎‫‫‌⁭​‍‭⁫​‭⁭‮‌⁭‍⁮‬⁫‮⁯‮(object obj, EventArgs eventArg)
		{
		}

		// ⁭⁬‍⁮‍‮⁫‍‍‍‌‌⁮⁫⁪⁮‬‌⁫⁬​⁬⁬⁪‎⁯⁬⁮‫‪⁫‍‮‌‎‎‍⁪‌⁭‮
		private void u206d⁬‍⁮‍‮⁫‍‍‍‌‌⁮⁫⁪⁮‬‌⁫⁬​⁬⁬⁪‎⁯⁬⁮‫‪⁫‍‮‌‎‎‍⁪‌⁭‮(Dictionary<GlobalNames, int> )
		{
			// 
			// Current member / type: System.Void SDRSharp.Tetra.TetraPanel::⁭⁬‍⁮‍‮⁫‍‍‍‌‌⁮⁫⁪⁮‬‌⁫⁬​⁬⁬⁪‎⁯⁬⁮‫‪⁫‍‮‌‎‎‍⁪‌⁭‮(System.Collections.Generic.Dictionary`2<SDRSharp.Tetra.GlobalNames,System.Int32>)
			// File path: C:\SDRSharp\Plugins\Tetra\SDRSharp.Tetra.dll
			// 
			// Product version: 0.0.0.0
			// Exception in: System.Void ⁭⁬‍⁮‍‮⁫‍‍‍‌‌⁮⁫⁪⁮‬‌⁫⁬​⁬⁬⁪‎⁯⁬⁮‫‪⁫‍‮‌‎‎‍⁪‌⁭‮(System.Collections.Generic.Dictionary<SDRSharp.Tetra.GlobalNames,System.Int32>)
			// 
			// Not supported type System.Object.
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.GetTypeIndex(TypeDefinition type) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 684
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.GetContainingType(TypeDefinition leftType, TypeDefinition rightType) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 608
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.GetExpressionType() in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 492
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.get_ExpressionType() in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 414
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.AddAssignmentCastIfNeeded(Expression expr) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\TypeInference\TypeInferer.cs:line 112
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.FixAssignmentInList(IList`1 expressionList, Expression value) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\TypeInference\TypeInferer.cs:line 75
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.AddCasts() in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\TypeInference\TypeInferer.cs:line 38
			//    at Telerik.JustDecompiler.Decompiler.ExpressionDecompilerStep.Process(DecompilationContext theContext, BlockStatement body) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\ExpressionDecompilerStep.cs:line 68
			//    at Telerik.JustDecompiler.Decompiler.DecompilationPipeline.RunInternal(MethodBody body, BlockStatement block, ILanguage language) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\DecompilationPipeline.cs:line 100
			//    at Telerik.JustDecompiler.Decompiler.WriterContextServices.BaseWriterContextService.DecompileMethod(ILanguage language, MethodDefinition method, TypeSpecificContext typeContext) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\WriterContextServices\BaseWriterContextService.cs:line 133
			// 
			// mailto: JustDecompilePublicFeedback@telerik.com

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		// ‏‭⁬⁬‏⁮‭​​⁮⁪‪⁪⁯⁭‌⁪‎⁪‭​​⁪‍⁭‮​‭⁪‌‏⁮‮‭‫⁭‭‫⁭‪‮
		private void u200f‭⁬⁬‏⁮‭​​⁮⁪‪⁪⁯⁭‌⁪‎⁪‭​​⁪‍⁭‮​‭⁪‌‏⁮‮‭‫⁭‭‫⁭‪‮()
		{
			// 
			// Current member / type: System.Void SDRSharp.Tetra.TetraPanel::‏‭⁬⁬‏⁮‭​​⁮⁪‪⁪⁯⁭‌⁪‎⁪‭​​⁪‍⁭‮​‭⁪‌‏⁮‮‭‫⁭‭‫⁭‪‮()
			// File path: C:\SDRSharp\Plugins\Tetra\SDRSharp.Tetra.dll
			// 
			// Product version: 0.0.0.0
			// Exception in: System.Void ‏‭⁬⁬‏⁮‭​​⁮⁪‪⁪⁯⁭‌⁪‎⁪‭​​⁪‍⁭‮​‭⁪‌‏⁮‮‭‫⁭‭‫⁭‪‮()
			// 
			// Not supported type System.Object.
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.GetTypeIndex(TypeDefinition type) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 684
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.GetContainingType(TypeDefinition leftType, TypeDefinition rightType) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 608
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.GetExpressionType() in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 492
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.get_ExpressionType() in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 414
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.AddAssignmentCastIfNeeded(Expression expr) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\TypeInference\TypeInferer.cs:line 112
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.FixAssignmentInList(IList`1 expressionList, Expression value) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\TypeInference\TypeInferer.cs:line 75
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.AddCasts() in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\TypeInference\TypeInferer.cs:line 38
			//    at Telerik.JustDecompiler.Decompiler.ExpressionDecompilerStep.Process(DecompilationContext theContext, BlockStatement body) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\ExpressionDecompilerStep.cs:line 68
			//    at Telerik.JustDecompiler.Decompiler.DecompilationPipeline.RunInternal(MethodBody body, BlockStatement block, ILanguage language) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\DecompilationPipeline.cs:line 100
			//    at Telerik.JustDecompiler.Decompiler.WriterContextServices.BaseWriterContextService.DecompileMethod(ILanguage language, MethodDefinition method, TypeSpecificContext typeContext) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\WriterContextServices\BaseWriterContextService.cs:line 133
			// 
			// mailto: JustDecompilePublicFeedback@telerik.com

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		// ​⁭⁮⁮‫‍‭‎⁭‌‏​‬‮‫‏⁫‮⁪‎⁬⁬⁭⁮⁭⁪‪⁬‌‪‫‮⁭⁪‎⁪‍‪⁬⁮‮
		private void u200b⁭⁮⁮‫‍‭‎⁭‌‏​‬‮‫‏⁫‮⁪‎⁬⁬⁭⁮⁭⁪‪⁬‌‪‫‮⁭⁪‎⁪‍‪⁬⁮‮()
		{
			// 
			// Current member / type: System.Void SDRSharp.Tetra.TetraPanel::​⁭⁮⁮‫‍‭‎⁭‌‏​‬‮‫‏⁫‮⁪‎⁬⁬⁭⁮⁭⁪‪⁬‌‪‫‮⁭⁪‎⁪‍‪⁬⁮‮()
			// File path: C:\SDRSharp\Plugins\Tetra\SDRSharp.Tetra.dll
			// 
			// Product version: 0.0.0.0
			// Exception in: System.Void ​⁭⁮⁮‫‍‭‎⁭‌‏​‬‮‫‏⁫‮⁪‎⁬⁬⁭⁮⁭⁪‪⁬‌‪‫‮⁭⁪‎⁪‍‪⁬⁮‮()
			// 
			// Not supported type System.Object.
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.GetTypeIndex(TypeDefinition type) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 684
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.GetContainingType(TypeDefinition leftType, TypeDefinition rightType) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 608
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.GetExpressionType() in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 492
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.get_ExpressionType() in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 414
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.AddAssignmentCastIfNeeded(Expression expr) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\TypeInference\TypeInferer.cs:line 112
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.FixAssignmentInList(IList`1 expressionList, Expression value) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\TypeInference\TypeInferer.cs:line 75
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.AddCasts() in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\TypeInference\TypeInferer.cs:line 38
			//    at Telerik.JustDecompiler.Decompiler.ExpressionDecompilerStep.Process(DecompilationContext theContext, BlockStatement body) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\ExpressionDecompilerStep.cs:line 68
			//    at Telerik.JustDecompiler.Decompiler.DecompilationPipeline.RunInternal(MethodBody body, BlockStatement block, ILanguage language) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\DecompilationPipeline.cs:line 100
			//    at Telerik.JustDecompiler.Decompiler.WriterContextServices.BaseWriterContextService.DecompileMethod(ILanguage language, MethodDefinition method, TypeSpecificContext typeContext) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\WriterContextServices\BaseWriterContextService.cs:line 133
			// 
			// mailto: JustDecompilePublicFeedback@telerik.com

		}

		// ⁬‌‫‫‭‮‌⁪‫‏⁫‮⁮‫‭⁯⁮⁪‏⁯‌‎⁬⁫⁪⁭‮‮⁪⁪⁮⁬‏‭⁬‎⁫⁯‬⁯‮
		private void u206c‌‫‫‭‮‌⁪‫‏⁫‮⁮‫‭⁯⁮⁪‏⁯‌‎⁬⁫⁪⁭‮‮⁪⁪⁮⁬‏‭⁬‎⁫⁯‬⁯‮(object obj, PaintEventArgs paintEventArg)
		{
			GroupBox groupBox = obj as GroupBox;
		Label1:
			int num = 469997970;
			while (true)
			{
				int num1 = num ^ 1117204756;
				uint num2 = (uint)num1;
				switch (num1 % 3)
				{
					case 0:
					{
						return;
					}
					case 1:
					{
						this.u206c‭⁭‌⁬‬​‍⁪‏‌⁪⁫‌⁫⁫‫⁬‎‎‫‏⁮⁫⁬⁪‎‏‍‮⁪‪⁫‍⁯⁯‌‫⁮‭‮(groupBox, TetraPanel.u206b⁪⁫⁯⁯‪‮‎‮⁭‬‬‪⁬‏‫​‎‪‪⁭‍‎⁫‌‌‬‮⁫‪‏‫⁫‭‬‏⁪⁪‎⁮‮(paintEventArg), this.u200e‮⁪‪​‮‍‌​‍‍‍​‌⁬⁪⁮⁯‫⁭⁬‬‭‪‫‭⁫⁪⁭⁬⁮‫⁬‍‫‬⁭‬⁫‮‮, Color.Gray);
						num = (int)(num2 * 175474792 ^ -1491034153);
						continue;
					}
					case 2:
					{
						goto Label1;
					}
				}
			}
		}

		// ‍‎‏‬⁯⁭⁫‎⁮‫‎⁯‬‬⁫‬⁭​‭⁭‏‬‏⁮‫⁮‪⁯‪⁭‮‎‍‌‎​⁬‭‍‬‮
		private void u200d‎‏‬⁯⁭⁫‎⁮‫‎⁯‬‬⁫‬⁭​‭⁭‏‬‏⁮‫⁮‪⁯‪⁭‮‎‍‌‎​⁬‭‍‬‮(object obj, PaintEventArgs paintEventArg)
		{
			GroupBox groupBox = obj as GroupBox;
			this.u206c‭⁭‌⁬‬​‍⁪‏‌⁪⁫‌⁫⁫‫⁬‎‎‫‏⁮⁫⁬⁪‎‏‍‮⁪‪⁫‍⁯⁯‌‫⁮‭‮(groupBox, TetraPanel.u206b⁪⁫⁯⁯‪‮‎‮⁭‬‬‪⁬‏‫​‎‪‪⁭‍‎⁫‌‌‬‮⁫‪‏‫⁫‭‬‏⁪⁪‎⁮‮(paintEventArg), this.u200e‮⁪‪​‮‍‌​‍‍‍​‌⁬⁪⁮⁯‫⁭⁬‬‭‪‫‭⁫⁪⁭⁬⁮‫⁬‍‫‬⁭‬⁫‮‮, Color.Gray);
		}

		// ⁭‏⁮‬‫‮⁯‪‮‎‍‌‪⁭‬‏⁬‎‫⁭‌⁫‪⁯‎⁮‍‫⁮⁪‏‮⁪⁫⁫⁯⁮‌​⁭‮
		private void u206d‏⁮‬‫‮⁯‪‮‎‍‌‪⁭‬‏⁬‎‫⁭‌⁫‪⁯‎⁮‍‫⁮⁪‏‮⁪⁫⁫⁯⁮‌​⁭‮(object obj, PaintEventArgs paintEventArg)
		{
			GroupBox groupBox = obj as GroupBox;
			this.u206c‭⁭‌⁬‬​‍⁪‏‌⁪⁫‌⁫⁫‫⁬‎‎‫‏⁮⁫⁬⁪‎‏‍‮⁪‪⁫‍⁯⁯‌‫⁮‭‮(groupBox, TetraPanel.u206b⁪⁫⁯⁯‪‮‎‮⁭‬‬‪⁬‏‫​‎‪‪⁭‍‎⁫‌‌‬‮⁫‪‏‫⁫‭‬‏⁪⁪‎⁮‮(paintEventArg), this.u200e‮⁪‪​‮‍‌​‍‍‍​‌⁬⁪⁮⁯‫⁭⁬‬‭‪‫‭⁫⁪⁭⁬⁮‫⁬‍‫‬⁭‬⁫‮‮, Color.Gray);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		// ⁬‭⁭‌⁬‬​‍⁪‏‌⁪⁫‌⁫⁫‫⁬‎‎‫‏⁮⁫⁬⁪‎‏‍‮⁪‪⁫‍⁯⁯‌‫⁮‭‮
		private void u206c‭⁭‌⁬‬​‍⁪‏‌⁪⁫‌⁫⁫‫⁬‎‎‫‏⁮⁫⁬⁪‎‏‍‮⁪‪⁫‍⁯⁯‌‫⁮‭‮(GroupBox , Graphics , Color , Color )
		{
			// 
			// Current member / type: System.Void SDRSharp.Tetra.TetraPanel::⁬‭⁭‌⁬‬​‍⁪‏‌⁪⁫‌⁫⁫‫⁬‎‎‫‏⁮⁫⁬⁪‎‏‍‮⁪‪⁫‍⁯⁯‌‫⁮‭‮(System.Windows.Forms.GroupBox,System.Drawing.Graphics,System.Drawing.Color,System.Drawing.Color)
			// File path: C:\SDRSharp\Plugins\Tetra\SDRSharp.Tetra.dll
			// 
			// Product version: 0.0.0.0
			// Exception in: System.Void ⁬‭⁭‌⁬‬​‍⁪‏‌⁪⁫‌⁫⁫‫⁬‎‎‫‏⁮⁫⁬⁪‎‏‍‮⁪‪⁫‍⁯⁯‌‫⁮‭‮(System.Windows.Forms.GroupBox,System.Drawing.Graphics,System.Drawing.Color,System.Drawing.Color)
			// 
			// Not supported type System.Object.
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.GetTypeIndex(TypeDefinition type) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 684
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.GetContainingType(TypeDefinition leftType, TypeDefinition rightType) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 608
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.GetExpressionType() in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 492
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.get_ExpressionType() in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 414
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.AddAssignmentCastIfNeeded(Expression expr) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\TypeInference\TypeInferer.cs:line 112
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.FixAssignmentInList(IList`1 expressionList, Expression value) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\TypeInference\TypeInferer.cs:line 75
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.AddCasts() in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\TypeInference\TypeInferer.cs:line 38
			//    at Telerik.JustDecompiler.Decompiler.ExpressionDecompilerStep.Process(DecompilationContext theContext, BlockStatement body) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\ExpressionDecompilerStep.cs:line 68
			//    at Telerik.JustDecompiler.Decompiler.DecompilationPipeline.RunInternal(MethodBody body, BlockStatement block, ILanguage language) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\DecompilationPipeline.cs:line 100
			//    at Telerik.JustDecompiler.Decompiler.WriterContextServices.BaseWriterContextService.DecompileMethod(ILanguage language, MethodDefinition method, TypeSpecificContext typeContext) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\WriterContextServices\BaseWriterContextService.cs:line 133
			// 
			// mailto: JustDecompilePublicFeedback@telerik.com

		}

		// ‪‍‪⁫‫‏‭⁭⁯‌‪⁬‭​‬‬⁬⁫⁪‭‪‏⁪⁫‬‮⁫‎‏‫⁬‮⁭‎‍‫‌‌‮⁫‮
		private void u202a‍‪⁫‫‏‭⁭⁯‌‪⁬‭​‬‬⁬⁫⁪‭‪‏⁪⁫‬‮⁫‎‏‫⁬‮⁭‎‍‫‌‌‮⁫‮(object obj, EventArgs eventArg)
		{
			int num;
			this.u206b⁫‍‬‌⁭‌⁭‪‪⁪​‪⁭⁫‍‬‫⁪⁯‬⁫‏‌⁪‪‫⁭‬‌⁫‬⁫⁭⁬‏⁭⁬‎‌‮ = TetraPanel.u202a‏⁯‌‭‬‎‌‫‪‏‬‬⁮‬⁬‮‌‏‪‎⁪⁬‌⁬⁬‎‏⁬⁪​⁫⁯⁫⁫‫‭‬‪‮‮(TetraPanel.u200c​‪⁯‭‪⁮​⁪‭‭‌‫⁬⁫⁭⁬‭⁭⁪‍‍⁭⁭⁭‏⁭‮‬‍⁫​‏‏⁬⁮‍‪⁫⁪‮(this));
		Label0:
			int num1 = -633350711;
			while (true)
			{
				int num2 = num1 ^ -1444253105;
				uint num3 = (uint)num2;
				switch (num2 % 6)
				{
					case 0:
					{
						goto Label0;
					}
					case 1:
					{
						this.u202d‪⁮‌​⁫⁫⁮‪‬​‮‪‌⁮⁬‮‫‎⁬‌‭‍‮​​‎⁯​‫⁭⁫⁯‎⁫‏‪⁯​‮‮ = true;
						num1 = (int)(num3 * 1322999725 ^ -1534670731);
						continue;
					}
					case 2:
					{
						num = (this.u206a‎‎⁪​‏‫⁮‍⁪⁯‏⁭‌‮​‍‪⁬‮⁮⁮‎⁫‭⁫⁬⁪‮‭‍⁫‫‬‭‮‍‏​‌‮ ? -556950650 : -445419058);
						num1 = (int)(num ^ num3 * 1843980104);
						continue;
					}
					case 3:
					{
						this.u200b⁭⁮⁮‫‍‭‎⁭‌‏​‬‮‫‏⁫‮⁪‎⁬⁬⁭⁮⁭⁪‪⁬‌‪‫‮⁭⁪‎⁪‍‪⁬⁮‮();
						num1 = (int)(num3 * 2133857078 ^ 1927205163);
						continue;
					}
					case 4:
					{
						TetraPanel.u202c‬​‪‌‭‏‫⁬‪‭‮⁬⁪⁯⁪⁭‎‭​‪‭⁯‏⁪​⁫‪⁬‌‏⁯⁪‫‬‬⁪⁮⁭‍‮(this.u206e⁭‫‬‫⁪‭‍‏⁫⁭​​‏‌‭⁭⁫‏⁮⁪‏‎‫⁯‭⁯‍⁮​‫‫⁪⁮⁫‎‬‫‌⁯‮, true);
						num1 = (int)(num3 * 601254773 ^ 770040056);
						continue;
					}
					case 5:
					{
						return;
					}
				}
			}
		}

		// ⁯⁪⁫‪‎⁮⁫⁭‏⁯‬‮⁪⁬⁪‍‌‭‭‭⁮⁫‏‮‌⁫‎‎⁪​‬⁬‏‪‫​⁮⁫⁮⁮‮
		private void u206f⁪⁫‪‎⁮⁫⁭‏⁯‬‮⁪⁬⁪‍‌‭‭‭⁮⁫‏‮‌⁫‎‎⁪​‬⁬‏‪‫​⁮⁫⁮⁮‮(object obj, EventArgs eventArg)
		{
			if (!this.u206a‎‎⁪​‏‫⁮‍⁪⁯‏⁭‌‮​‍‪⁬‮⁮⁮‎⁫‭⁫⁬⁪‮‭‍⁫‫‬‭‮‍‏​‌‮)
			{
				return;
			}
		Label1:
			int num = -762852574;
			while (true)
			{
				int num1 = num ^ -93100453;
				uint num2 = (uint)num1;
				switch (num1 % 4)
				{
					case 0:
					{
						goto Label1;
					}
					case 1:
					{
						this.u202d‪⁮‌​⁫⁫⁮‪‬​‮‪‌⁮⁬‮‫‎⁬‌‭‍‮​​‎⁯​‫⁭⁫⁯‎⁫‏‪⁯​‮‮ = true;
						num = (int)(num2 * 272725194 ^ 777637062);
						continue;
					}
					case 2:
					{
						return;
					}
					case 3:
					{
						this.u200b⁭⁮⁮‫‍‭‎⁭‌‏​‬‮‫‏⁫‮⁪‎⁬⁬⁭⁮⁭⁪‪⁬‌‪‫‮⁭⁪‎⁪‍‪⁬⁮‮();
						TetraPanel.u202c‬​‪‌‭‏‫⁬‪‭‮⁬⁪⁯⁪⁭‎‭​‪‭⁯‏⁪​⁫‪⁬‌‏⁯⁪‫‬‬⁪⁮⁭‍‮(this.u206e⁭‫‬‫⁪‭‍‏⁫⁭​​‏‌‭⁭⁫‏⁮⁪‏‎‫⁯‭⁯‍⁮​‫‫⁪⁮⁫‎‬‫‌⁯‮, true);
						num = (int)(num2 * -2089907051 ^ 1330441770);
						continue;
					}
				}
			}
		}

		// ⁮‬‭⁫‎​‬⁪⁬‪‎‮‪‪‌‮‭‮⁬⁬​⁫‍‎‫⁫‌‪⁭⁯‏‌‍‪‬⁫‏⁭‮‍‮
		private void u206e‬‭⁫‎​‬⁪⁬‪‎‮‪‪‌‮‭‮⁬⁬​⁫‍‎‫⁫‌‪⁭⁯‏‌‍‪‬⁫‏⁭‮‍‮(object obj, EventArgs eventArg)
		{
			this.u206e‫‫​‮⁫‮⁬‎‫​‭‬⁭‫⁫⁪‬‭⁫⁫‫‌⁪‏⁪⁫‍‍​⁯⁯⁭‏‫‪⁫‮⁫⁪‮ = !this.u206e‫‫​‮⁫‮⁬‎‫​‭‬⁭‫⁫⁪‬‭⁫⁫‫‌⁪‏⁪⁫‍‍​⁯⁯⁭‏‫‪⁫‮⁫⁪‮;
		}

		// ⁪‏⁯‍‏‍⁫‫‪⁯⁯⁭‎​⁫⁪‪⁭‎‏⁪‍‭‍‍⁭‫‏⁫‮⁮⁫⁫‍‫‌⁫‫‍⁪‮
		private void u206a‏⁯‍‏‍⁫‫‪⁯⁯⁭‎​⁫⁪‪⁭‎‏⁪‍‭‍‍⁭‫‏⁫‮⁮⁫⁫‍‫‌⁫‫‍⁪‮(object obj, EventArgs eventArg)
		{
			TetraPanel.u206c​‮​‭⁬​⁫‎⁮⁮​‮‬‏⁪‪⁫‪⁭⁬‍⁮⁬‫‪⁯‬‎‬‫‪​‌⁫‌‏​​⁪‮(this.u200d‭‍‭⁪‬⁭‎⁬‍‬⁭‍‍‌⁬⁫‍‬‫‏⁯⁭‍⁮‎⁪⁪⁫⁬⁯‭‏⁪‮‫‭⁯⁪⁪‮, this.u206a‮​‫‪‪⁬‫‏⁬⁯‫‏⁬‌​⁪‮​‌⁬‏‍‎‍‌⁬⁮⁫‍⁪⁭‎‭‌⁭⁫⁬‏⁮‮, this.u202b⁭‮‮‌⁮‍⁪‭‮⁯‍​‬⁯⁫⁪⁬⁮⁮‎‫⁬⁬‌⁬‮⁮‍​‫​‫‌⁬​‌‪‮.u202a‍⁮‭⁪‌‪‫‍‌​‭⁪⁮‬⁭‭‍‭‌⁪⁬‍⁪⁯‫‍‫‮‎‫‌‏‍‏⁮⁭⁪‫⁭‮(this.u206d⁭⁯‭⁬‍⁭⁪‫‫⁭⁪⁬‏‮​‌‏​⁭⁯⁮‪⁭⁫⁫⁭‍‍‪‭‎‮‭⁯​‎⁮⁬‮‮));
		}

		// ‍‏‫⁫‬‬‬‪​‮‭⁭‏‬‬‫​‪⁫⁭⁭‫⁪‎‎⁫‪⁯‍⁫⁭⁭⁮‬‎⁪‪⁪‪‬‮
		private void u200d‏‫⁫‬‬‬‪​‮‭⁭‏‬‬‫​‪⁫⁭⁭‫⁪‎‎⁫‪⁯‍⁫⁭⁭⁮‬‎⁪‪⁪‪‬‮(object obj, EventArgs eventArg)
		{
			TetraPanel.u206c​‮​‭⁬​⁫‎⁮⁮​‮‬‏⁪‪⁫‪⁭⁬‍⁮⁬‫‪⁯‬‎‬‫‪​‌⁫‌‏​​⁪‮(this.u200d‭‍‭⁪‬⁭‎⁬‍‬⁭‍‍‌⁬⁫‍‬‫‏⁯⁭‍⁮‎⁪⁪⁫⁬⁯‭‏⁪‮‫‭⁯⁪⁪‮, this.u206a‮​‫‪‪⁬‫‏⁬⁯‫‏⁬‌​⁪‮​‌⁬‏‍‎‍‌⁬⁮⁫‍⁪⁭‎‭‌⁭⁫⁬‏⁮‮, "");
		}

		// ‏⁬‌‍⁬‏‫​⁯‬⁭‬‎‎⁪‎‮​⁪⁮‭⁬⁬‪⁮‪⁪‪‬‮⁮​‫‮‭‬‎‍⁯⁬‮
		private void u200f⁬‌‍⁬‏‫​⁯‬⁭‬‎‎⁪‎‮​⁪⁮‭⁬⁬‪⁮‪⁪‪‬‮⁮​‫‮‭‬‎‍⁯⁬‮(object obj, EventArgs eventArg)
		{
			TetraPanel.u206c​‮​‭⁬​⁫‎⁮⁮​‮‬‏⁪‪⁫‪⁭⁬‍⁮⁬‫‪⁯‬‎‬‫‪​‌⁫‌‏​​⁪‮(this.u200d‭‍‭⁪‬⁭‎⁬‍‬⁭‍‍‌⁬⁫‍‬‫‏⁯⁭‍⁮‎⁪⁪⁫⁬⁯‭‏⁪‮‫‭⁯⁪⁪‮, this.u202b‫‭‪⁯⁯⁮‎⁫⁫⁮‫⁪⁯⁮⁭⁫‎‏⁮⁭‭⁪‌⁯⁪⁪‍⁯⁯‌⁫‪‮⁭‌⁪‎‬⁫‮, this.u202b⁭‮‮‌⁮‍⁪‭‮⁯‍​‬⁯⁫⁪⁬⁮⁮‎‫⁬⁬‌⁬‮⁮‍​‫​‫‌⁬​‌‪‮.u200b⁯⁮⁪​‭‬‭‮⁮‏⁪⁫‎‪‪​⁮‍‬​⁬‏⁬‫‮⁮‮‌‪‭‍‏‭‎⁪‬‭​‌‮(this.u206d⁭⁯‭⁬‍⁭⁪‫‫⁭⁪⁬‏‮​‌‏​⁭⁯⁮‪⁭⁫⁫⁭‍‍‪‭‎‮‭⁯​‎⁮⁬‮‮, this.u202d‍⁮⁬‍‫‮⁮⁯‏‭​‭‍​‌⁮‫⁫⁮‪‏‬⁭‎​​‬‮‫⁪‍‎‌‭‎⁫‪‏‭‮));
		}

		// ‪‮‎⁮‏​‫‮‬⁬⁬‌⁫​‮⁪‎‬‍‮⁮‏⁯⁬‎‭⁬⁮‫⁪‭‎‏‮‪​‎‮⁮‍‮
		private void u202a‮‎⁮‏​‫‮‬⁬⁬‌⁫​‮⁪‎‬‍‮⁮‏⁯⁬‎‭⁬⁮‫⁪‭‎‏‮‪​‎‮⁮‍‮(object obj, EventArgs eventArg)
		{
			TetraPanel.u206c​‮​‭⁬​⁫‎⁮⁮​‮‬‏⁪‪⁫‪⁭⁬‍⁮⁬‫‪⁯‬‎‬‫‪​‌⁫‌‏​​⁪‮(this.u200d‭‍‭⁪‬⁭‎⁬‍‬⁭‍‍‌⁬⁫‍‬‫‏⁯⁭‍⁮‎⁪⁪⁫⁬⁯‭‏⁪‮‫‭⁯⁪⁪‮, this.u202b‫‭‪⁯⁯⁮‎⁫⁫⁮‫⁪⁯⁮⁭⁫‎‏⁮⁭‭⁪‌⁯⁪⁪‍⁯⁯‌⁫‪‮⁭‌⁪‎‬⁫‮, "");
		}

		// ⁪‮‌⁫‫‎⁬​⁮‌‏⁫‌⁫⁫⁪‫⁬‍⁫‫‎‬⁮⁬‫⁬‮‎‏⁫⁭‌⁪‌⁪‮‎‍‬‮
		private void u206a‮‌⁫‫‎⁬​⁮‌‏⁫‌⁫⁫⁪‫⁬‍⁫‫‎‬⁮⁬‫⁬‮‎‏⁫⁭‌⁪‌⁪‮‎‍‬‮(object obj, EventArgs eventArg)
		{
			TetraPanel.u206c​‮​‭⁬​⁫‎⁮⁮​‮‬‏⁪‪⁫‪⁭⁬‍⁮⁬‫‪⁯‬‎‬‫‪​‌⁫‌‏​​⁪‮(this.u200d‭‍‭⁪‬⁭‎⁬‍‬⁭‍‍‌⁬⁫‍‬‫‏⁯⁭‍⁮‎⁪⁪⁫⁬⁯‭‏⁪‮‫‭⁯⁪⁪‮, this.u206c‍‍‌‬‪‮‪‮⁪‎⁬‍‭⁪‫‌‬‪⁫‫‫‫‪⁮‮‬⁮⁬⁪‫⁭‫‌⁪‮‪⁭⁭⁮‮, this.u202b⁭‮‮‌⁮‍⁪‭‮⁯‍​‬⁯⁫⁪⁬⁮⁮‎‫⁬⁬‌⁬‮⁮‍​‫​‫‌⁬​‌‪‮.u200f‌⁬‭‬‎‪‬⁫‭​‬⁬‎​‌⁪‏⁯⁬‎‍‫​⁯‪‮‫⁫‪⁯⁮‭⁫‫‍⁯‮‍⁬‮(this.u206d⁭⁯‭⁬‍⁭⁪‫‫⁭⁪⁬‏‮​‌‏​⁭⁯⁮‪⁭⁫⁫⁭‍‍‪‭‎‮‭⁯​‎⁮⁬‮‮, this.u202d‍⁮⁬‍‫‮⁮⁯‏‭​‭‍​‌⁮‫⁫⁮‪‏‬⁭‎​​‬‮‫⁪‍‎‌‭‎⁫‪‏‭‮, this.u200c‏‭‬⁮‎​⁯⁯‮‏‪⁫⁯​⁭‫‏‌⁬‬⁯‪‬‍‭‫‮⁫‮‭‏‌​⁮‌⁯⁫⁭⁮‮, false));
		}

		// ‍⁫⁭‍‪‭‮‮‎⁬​⁭‌⁬⁭‬‬‫‎‫‪‎⁬‎‌‪⁭‎‍⁯⁯⁪⁯⁮⁮‍‏‬‭‫‮
		private void u200d⁫⁭‍‪‭‮‮‎⁬​⁭‌⁬⁭‬‬‫‎‫‪‎⁬‎‌‪⁭‎‍⁯⁯⁪⁯⁮⁮‍‏‬‭‫‮(object obj, EventArgs eventArg)
		{
			TetraPanel.u206c​‮​‭⁬​⁫‎⁮⁮​‮‬‏⁪‪⁫‪⁭⁬‍⁮⁬‫‪⁯‬‎‬‫‪​‌⁫‌‏​​⁪‮(this.u200d‭‍‭⁪‬⁭‎⁬‍‬⁭‍‍‌⁬⁫‍‬‫‏⁯⁭‍⁮‎⁪⁪⁫⁬⁯‭‏⁪‮‫‭⁯⁪⁪‮, this.u206c‍‍‌‬‪‮‪‮⁪‎⁬‍‭⁪‫‌‬‪⁫‫‫‫‪⁮‮‬⁮⁬⁪‫⁭‫‌⁪‮‪⁭⁭⁮‮, "");
		}

		// ⁪‎‎‪‬‭‎‌‮⁫⁫⁪‫‭⁫‏‪‫‪⁮‎‍⁪⁭‌‍‮‬‫‪‭⁮​⁭‪‎‏⁮​‬‮
		private void u206a‎‎‪‬‭‎‌‮⁫⁫⁪‫‭⁫‏‪‫‪⁮‎‍⁪⁭‌‍‮‬‫‪‭⁮​⁭‪‎‏⁮​‬‮(object obj, EventArgs eventArg)
		{
			TetraPanel.u202c‬​‪‌‭‏‫⁬‪‭‮⁬⁪⁯⁪⁭‎‭​‪‭⁯‏⁪​⁫‪⁬‌‏⁯⁪‫‬‬⁪⁮⁭‍‮(this.u206e⁭‫‬‫⁪‭‍‏⁫⁭​​‏‌‭⁭⁫‏⁮⁪‏‎‫⁯‭⁯‍⁮​‫‫⁪⁮⁫‎‬‫‌⁯‮, false);
			this.u200f‭⁬⁬‏⁮‭​​⁮⁪‪⁪⁯⁭‌⁪‎⁪‭​​⁪‍⁭‮​‭⁪‌‏⁮‮‭‫⁭‭‫⁭‪‮();
		}

		// ‫​⁭‪⁬‫⁮⁫⁫⁭‫‭⁭‪‍‪‭‪​⁪‭‍‌‫⁮‮‌‎‫‌‭⁮⁭‬⁭‍⁫‍⁬⁫‮
		// privatescope
		internal static void u202b​⁭‪⁬‫⁮⁫⁫⁭‫‭⁭‪‍‪‭‪​⁪‭‍‌‫⁮‮‌‎‫‌‭⁮⁭‬⁭‍⁫‍⁬⁫‮(IDisposable disposable)
		{
			disposable.Dispose();
		}

		// ‮‍‬‎‫‪​⁭⁪‮⁯⁯‬⁮‏‫⁭‭‬‏‪⁯⁪⁫​⁬‌⁫‍⁮‌‌‮‌‬‏‎‪​⁫‮
		// privatescope
		internal static System.ComponentModel.Container u202e‍‬‎‫‪​⁭⁪‮⁯⁯‬⁮‏‫⁭‭‬‏‪⁯⁪⁫​⁬‌⁫‍⁮‌‌‮‌‬‏‎‪​⁫‮()
		{
			return new System.ComponentModel.Container();
		}

		// ⁪⁪‬‍‍‭⁬⁫‬‮​‌‌‮⁯⁪‭⁭‪‮⁯‭‏‌‮⁫​‏⁮⁬‏⁬‬​‭⁯‬⁯‬‍‮
		// privatescope
		internal static Panel u206a⁪‬‍‍‭⁬⁫‬‮​‌‌‮⁯⁪‭⁭‪‮⁯‭‏‌‮⁫​‏⁮⁬‏⁬‬​‭⁯‬⁯‬‍‮()
		{
			return new Panel();
		}

		// ​‏‌​‍‬⁮‭‍⁬⁬⁪​⁫⁬⁭‭⁪‪‎‏‏⁮‏‏‌‭​⁮‍‬⁮‪⁪​‬‮‏‪‮
		// privatescope
		internal static GroupBox u200b‏‌​‍‬⁮‭‍⁬⁬⁪​⁫⁬⁭‭⁪‪‎‏‏⁮‏‏‌‭​⁮‍‬⁮‪⁪​‬‮‏‪‮()
		{
			return new GroupBox();
		}

		// ​‬‌⁯‫‪⁪⁯​‭‬‌‭⁯⁮⁮‏​‪‬⁯‭‪​⁫‮​‪‬‬​‌‏⁬⁪‪‏⁪‏⁬‮
		// privatescope
		internal static Label u200b‬‌⁯‫‪⁪⁯​‭‬‌‭⁯⁮⁮‏​‪‬⁯‭‪​⁫‮​‪‬‬​‌‏⁬⁪‪‏⁪‏⁬‮()
		{
			return new Label();
		}

		// ‫⁬‮‍‪‏⁬‌‭‏⁭⁮‪‌⁬⁯⁯⁮‪⁭‌‬⁪‎‮‪‭‭‪​‭‭⁭⁪⁭‪⁬⁯​‬‮
		// privatescope
		internal static CheckBox u202b⁬‮‍‪‏⁬‌‭‏⁭⁮‪‌⁬⁯⁯⁮‪⁭‌‬⁪‎‮‪‭‭‪​‭‭⁭⁪⁭‪⁬⁯​‬‮()
		{
			return new CheckBox();
		}

		// ‪⁪⁭⁬​‍⁮⁪‮⁬‍‌⁮‍⁯‮⁫‪⁪‏⁪‍⁮‮⁬​‏‮⁪⁬⁯‌‏​‭⁭‫‭⁬‮‮
		// privatescope
		internal static NumericUpDown u202a⁪⁭⁬​‍⁮⁪‮⁬‍‌⁮‍⁯‮⁫‪⁪‏⁪‍⁮‮⁬​‏‮⁪⁬⁯‌‏​‭⁭‫‭⁬‮‮()
		{
			return new NumericUpDown();
		}

		// ‏‭‏⁬⁪‎⁬‌⁬‌⁬‫⁪⁬‏‭‮‍‪​‎⁮‎‎⁬⁪‬⁭‎‌‬‮‪‬⁫⁬‮‬‪⁮‮
		// privatescope
		internal static LinkLabel u200f‭‏⁬⁪‎⁬‌⁬‌⁬‫⁪⁬‏‭‮‍‪​‎⁮‎‎⁬⁪‬⁭‎‌‬‮‪‬⁫⁬‮‬‪⁮‮()
		{
			return new LinkLabel();
		}

		// ‎​‏⁯‍‫‍⁪‌‪‮‫⁫‮‏‎‪‪⁪‍‍‏​⁯‎‪⁫‮⁯⁮⁯⁭‫‭⁯‌​‮⁫⁭‮
		// privatescope
		internal static Button u200e​‏⁯‍‫‍⁪‌‪‮‫⁫‮‏‎‪‪⁪‍‍‏​⁯‎‪⁫‮⁯⁮⁯⁭‫‭⁯‌​‮⁫⁭‮()
		{
			return new Button();
		}

		// ⁮⁮⁬⁫‏⁯‪​⁬‭​⁫‭‬⁯⁬‫⁪​⁮⁪⁪‏⁬⁯‍‫⁮⁭‌⁭⁮‪⁭⁯‬‬‍‭‪‮
		// privatescope
		internal static RadioButton u206e⁮⁬⁫‏⁯‪​⁬‭​⁫‭‬⁯⁬‫⁪​⁮⁪⁪‏⁬⁯‍‫⁮⁭‌⁭⁮‪⁭⁯‬‬‍‭‪‮()
		{
			return new RadioButton();
		}

		// ‪⁭‌⁭‏‪⁭‎⁬‌⁪‫‏​‎⁯‍‭⁭‮‏‎⁪‏⁭‎⁪⁪⁫‫‭⁫‍‌‬⁫‭​‌‍‮
		// privatescope
		internal static System.Windows.Forms.Timer u202a⁭‌⁭‏‪⁭‎⁬‌⁪‫‏​‎⁯‍‭⁭‮‏‎⁪‏⁭‎⁪⁪⁫‫‭⁫‍‌‬⁫‭​‌‍‮(IContainer container)
		{
			return new System.Windows.Forms.Timer(container);
		}

		// ‏‭‎⁫‎‏‫‫⁭​‪‫⁯‌‎‫‮‬⁯⁯‍‭‎‌‌‌⁫‏⁮⁬​⁮‭‌​⁮⁭⁮⁯⁭‮
		// privatescope
		internal static ToolTip u200f‭‎⁫‎‏‫‫⁭​‪‫⁯‌‎‫‮‬⁯⁯‍‭‎‌‌‌⁫‏⁮⁬​⁮‭‌​⁮⁭⁮⁯⁭‮(IContainer container)
		{
			return new ToolTip(container);
		}

		// ⁮⁪‫‮‫⁮⁭‏‏‮‏‍⁭‬‏⁯​‬‍‌‎‫‍‬⁮⁮‫⁭⁯​‭‬⁯‌⁮⁮⁭‭‍⁬‮
		// privatescope
		internal static void u206e⁪‫‮‫⁮⁭‏‏‮‏‍⁭‬‏⁯​‬‍‌‎‫‍‬⁮⁮‫⁭⁯​‭‬⁯‌⁮⁮⁭‭‍⁬‮(Control control)
		{
			control.SuspendLayout();
		}

		// ⁬‎⁫​‌‎​⁯⁮‮⁪⁬‌⁯‍⁫‬‍​⁮‫‮‌‍‪‫‎‭⁬⁯⁪‎‭⁫‫‏⁮‏‮⁫‮
		// privatescope
		internal static void u206c‎⁫​‌‎​⁯⁮‮⁪⁬‌⁯‍⁫‬‍​⁮‫‮‌‍‪‫‎‭⁬⁯⁪‎‭⁫‫‏⁮‏‮⁫‮(ISupportInitialize supportInitialize)
		{
			supportInitialize.BeginInit();
		}

		// ⁪⁫‌⁭‌‬‬‎‌‭‫‍‎⁫⁬⁪​‎‬‏⁭‭‎⁬‍‭‪‫‏‬⁫⁬‫⁯⁯​‬‪​‬‮
		// privatescope
		internal static void u206a⁫‌⁭‌‬‬‎‌‭‫‍‎⁫⁬⁪​‎‬‏⁭‭‎⁬‍‭‪‫‏‬⁫⁬‫⁯⁯​‬‪​‬‮(Control control)
		{
			control.SuspendLayout();
		}

		// ‎​⁮⁯‮⁭‬‭⁫⁭⁬‌‭‎⁬⁬⁮⁬‭‬⁮‭‏⁫‫​‮‌‬⁪​‮⁮‪‪⁭‮⁪‍⁮‮
		// privatescope
		internal static void u200e​⁮⁯‮⁭‬‭⁫⁭⁬‌‭‎⁬⁬⁮⁬‭‬⁮‭‏⁫‫​‮‌‬⁪​‮⁮‪‪⁭‮⁪‍⁮‮(Control control, AnchorStyles anchorStyle)
		{
			control.Anchor = anchorStyle;
		}

		// ⁪‬⁯⁭⁫‍⁪‫⁬⁭⁬⁮‫‏‍⁫‫‌⁪‪‌​⁭⁮‍‌‬⁯‭⁪‭⁮‏⁮‪​‍⁭⁫⁫‮
		// privatescope
		internal static Control.ControlCollection u206a‬⁯⁭⁫‍⁪‫⁬⁭⁬⁮‫‏‍⁫‫‌⁪‪‌​⁭⁮‍‌‬⁯‭⁪‭⁮‏⁮‪​‍⁭⁫⁫‮(Control control)
		{
			return control.Controls;
		}

		// ‭‏⁭⁫‮‫​‎‪⁫⁯‏⁮‫​‮‌⁮‬⁬‌⁮⁬‏⁭‏⁮‌⁮‮⁮‭‌‫‏⁪‎⁮‏‎‮
		// privatescope
		internal static void u202d‏⁭⁫‮‫​‎‪⁫⁯‏⁮‫​‮‌⁮‬⁬‌⁮⁬‏⁭‏⁮‌⁮‮⁮‭‌‫‏⁪‎⁮‏‎‮(Control.ControlCollection controlCollections, Control control)
		{
			controlCollections.Add(control);
		}

		// ‫‎⁯‫‮⁬‏‪⁫‍⁫‭​⁭‎​‎‮⁬‍‏‏‎⁯​⁭⁫‏‫‌‌‪‪​‬⁬⁭‫⁮‮‮
		// privatescope
		internal static void u202b‎⁯‫‮⁬‏‪⁫‍⁫‭​⁭‎​‎‮⁬‍‏‏‎⁯​⁭⁫‏‫‌‌‪‪​‬⁬⁭‫⁮‮‮(Control control, Point point)
		{
			control.Location = point;
		}

		// ⁮⁪‏‏​‍⁮‫⁬⁬⁯⁫⁯‏⁬⁮‫‫⁬⁬‭‫‌‌⁭‎​‭⁭‍⁬‏‏⁮‫⁮‭‮‎‪‮
		// privatescope
		internal static void u206e⁪‏‏​‍⁮‫⁬⁬⁯⁫⁯‏⁬⁮‫‫⁬⁬‭‫‌‌⁭‎​‭⁭‍⁬‏‏⁮‫⁮‭‮‎‪‮(Control control, string str)
		{
			control.Name = str;
		}

		// ‬⁭⁫‪‏⁬⁭⁭​​⁪⁫‬‍⁪⁫⁭⁬‮‌⁭‫‮‭​⁫‌⁪‎‏⁪‫‮‌​‌‍⁮⁮⁮‮
		// privatescope
		internal static void u202c⁭⁫‪‏⁬⁭⁭​​⁪⁫‬‍⁪⁫⁭⁬‮‌⁭‫‮‭​⁫‌⁪‎‏⁪‫‮‌​‌‍⁮⁮⁮‮(Control control, System.Drawing.Size size)
		{
			control.Size = size;
		}

		// ⁫⁬‪‍‭⁮⁪‌‭⁯⁪⁪‏‌‪⁯⁭‮​‭‏‌⁮⁯⁪‪‬​⁮⁯‮⁫⁮‪‪‫‍⁪⁬‎‮
		// privatescope
		internal static void u206b⁬‪‍‭⁮⁪‌‭⁯⁪⁪‏‌‪⁯⁭‮​‭‏‌⁮⁯⁪‪‬​⁮⁯‮⁫⁮‪‪‫‍⁪⁬‎‮(Control control, int num)
		{
			control.TabIndex = num;
		}

		// ‏⁪​‬‍‏‭‭‏‫⁬‬‭‮⁯‫⁫⁯⁫‪‌‌‌‪‍⁪‏‎‌‬⁮⁬⁫⁬⁬⁮‪⁮⁬‪‮
		// privatescope
		internal static void u200f⁪​‬‍‏‭‭‏‫⁬‬‭‮⁯‫⁫⁯⁫‪‌‌‌‪‍⁪‏‎‌‬⁮⁬⁫⁬⁬⁮‪⁮⁬‪‮(GroupBox groupBox, bool flag)
		{
			groupBox.TabStop = flag;
		}

		// ⁭‫‫‫⁮‮‌​‍⁫‭‎‬​⁭‬⁫‪‌‍‍‎‮⁫‬⁭⁫‫‎⁯‏‌‮‮⁬‮⁬⁪‮
		// privatescope
		internal static void u206d‫‫‫⁮‮‌​‍⁫‭‎‬​⁭‬⁫‪‌‍‍‎‮⁫‬⁭⁫‫‎⁯‏‌‮‮⁬‮⁬⁪‮(Control control, string str)
		{
			control.Text = str;
		}

		// ⁯‮⁫⁯⁪‌‏⁭‏‌⁫⁯⁬‬⁭⁬⁬⁯⁮⁭⁮‮⁯⁯‬⁭⁬‏‌⁭⁬⁯⁪‫‮​‮‍⁫‍‮
		// privatescope
		internal static void u206f‮⁫⁯⁪‌‏⁭‏‌⁫⁯⁬‬⁭⁬⁬⁯⁮⁭⁮‮⁯⁯‬⁭⁬‏‌⁭⁬⁯⁪‫‮​‮‍⁫‍‮(Control control, PaintEventHandler paintEventHandler)
		{
			control.Paint += paintEventHandler;
		}

		// ‎‭⁭‌‪‫​⁯⁫⁫‪⁯‍⁯⁯⁭‎⁫‮⁮​​‭‎‮‍‏‎‎⁪‌⁫‬‮⁮‌⁮‏⁭⁪‮
		// privatescope
		internal static void u200e‭⁭‌‪‫​⁯⁫⁫‪⁯‍⁯⁯⁭‎⁫‮⁮​​‭‎‮‍‏‎‎⁪‌⁫‬‮⁮‌⁮‏⁭⁪‮(Control control, bool flag)
		{
			control.AutoSize = flag;
		}

		// ‬‫‭‪‌‌⁬‌⁬‌‪‬‏‌‍⁯⁪‮⁪‮‌‪⁪⁯‭⁮‪‪⁪‬‭​‬‭‮‍‭‌‍‮
		// privatescope
		internal static System.Drawing.Font u202c‫‭‪‌‌⁬‌⁬‌‪‬‏‌‍⁯⁪‮⁪‮‌‪⁪⁯‭⁮‪‪⁪‬‭​‬‭‮‍‭‌‍‮(string str, float single, FontStyle fontStyle, GraphicsUnit graphicsUnit, byte num)
		{
			return new System.Drawing.Font(str, single, fontStyle, graphicsUnit, num);
		}

		// ‫‏‏‬‎‮‫​‍​⁭‬‬‭‮⁫⁯‭⁪‬‎‫‫‎⁬‪‍‎⁪⁪‮‌‮‌‏⁯‌‍​‌‮
		// privatescope
		internal static void u202b‏‏‬‎‮‫​‍​⁭‬‬‭‮⁫⁯‭⁪‬‎‫‫‎⁬‪‍‎⁪⁪‮‌‮‌‏⁯‌‍​‌‮(Control control, System.Drawing.Font font)
		{
			control.Font = font;
		}

		// ‌‬‌‏⁬⁬‍⁫​⁮‮‏⁪⁪‪‪⁪⁮⁮⁫⁯⁮‭‌⁫‫‌‫‫‫⁭⁬‪‎‭⁪‍⁮‏‏‮
		// privatescope
		internal static void u200c‬‌‏⁬⁬‍⁫​⁮‮‏⁪⁪‪‪⁪⁮⁮⁫⁯⁮‭‌⁫‫‌‫‫‫⁭⁬‪‎‭⁪‍⁮‏‏‮(ButtonBase buttonBase, TextImageRelation textImageRelation)
		{
			buttonBase.TextImageRelation = textImageRelation;
		}

		// ‌‏⁫‬‭‌‪⁮‬⁮‏‪⁭‍‪⁯‫⁬⁫⁭‭‮‬‬⁪⁫‏⁭‏⁮⁫​⁫⁬‪‌‫⁭‭‍‮
		// privatescope
		internal static void u200c‏⁫‬‭‌‪⁮‬⁮‏‪⁭‍‪⁯‫⁬⁫⁭‭‮‬‬⁪⁫‏⁭‏⁮⁫​⁫⁬‪‌‫⁭‭‍‮(ButtonBase buttonBase, bool flag)
		{
			buttonBase.UseVisualStyleBackColor = flag;
		}

		// ‏⁪⁪⁫⁭‏‮‌‬⁭‍​‭‫⁭⁮‫‍‏⁫⁭⁯​⁪‌‮‍⁭​⁫⁮⁫‫‌‭⁬⁫‬​‪‮
		// privatescope
		internal static void u200f⁪⁪⁫⁭‏‮‌‬⁭‍​‭‫⁭⁮‫‍‏⁫⁭⁯​⁪‌‮‍⁭​⁫⁮⁫‫‌‭⁬⁫‬​‪‮(CheckBox checkBox, EventHandler eventHandler)
		{
			checkBox.CheckedChanged += eventHandler;
		}

		// ‪‭‮⁬⁪⁯⁫‎⁬⁭‏⁯⁫⁪​⁭‏‏⁫‫⁯‍‮‫⁮‮​‍‮‪‫⁫​⁭‏⁮​⁭⁯‪‮
		// privatescope
		internal static void u202a‭‮⁬⁪⁯⁫‎⁬⁭‏⁯⁫⁪​⁭‏‏⁫‫⁯‍‮‫⁮‮​‍‮‪‫⁫​⁭‏⁮​⁭⁯‪‮(NumericUpDown numericUpDown, decimal num)
		{
			numericUpDown.Maximum = num;
		}

		// ⁫‪‫⁫​⁬‪‍‫‏⁭​⁫⁬‮‬‍⁮‮‍‬‬‬‭‬‍‮⁭‍‏‌⁬⁭‬‫⁬‏⁬⁫‌‮
		// privatescope
		internal static void u206b‪‫⁫​⁬‪‍‫‏⁭​⁫⁬‮‬‍⁮‮‍‬‬‬‭‬‍‮⁭‍‏‌⁬⁭‬‫⁬‏⁬⁫‌‮(NumericUpDown numericUpDown, decimal num)
		{
			numericUpDown.Minimum = num;
		}

		// ⁮‏‪⁯‏⁯‫‭​⁮‮‮‌⁫⁪⁪‪⁮‪​‫⁯⁪‬‍‬‬⁮⁬⁭⁪​‭‎‌​‫​‌⁪‮
		// privatescope
		internal static void u206e‏‪⁯‏⁯‫‭​⁮‮‮‌⁫⁪⁪‪⁮‪​‫⁯⁪‬‍‬‬⁮⁬⁭⁪​‭‎‌​‫​‌⁪‮(UpDownBase upDownBase, HorizontalAlignment horizontalAlignment)
		{
			upDownBase.TextAlign = horizontalAlignment;
		}

		// ‮⁯‭⁪‪⁬‮‬‍‭⁪⁭⁯⁯‌⁫⁫‭‎⁯‭⁭⁪‌‮‪‏⁮‮⁭‫‎⁭‬‏‏‫‌⁪‌‮
		// privatescope
		internal static void u202e⁯‭⁪‪⁬‮‬‍‭⁪⁭⁯⁯‌⁫⁫‭‎⁯‭⁭⁪‌‮‪‏⁮‮⁭‫‎⁭‬‏‏‫‌⁪‌‮(NumericUpDown numericUpDown, decimal num)
		{
			numericUpDown.Value = num;
		}

		// ‭‭⁮‌‏‍⁬⁫⁮​‍‮‎⁭‪‌‭‮‌⁬⁯‌⁭‮‫‪‬⁫⁭‍⁬⁪‌‬‍⁮‏‌‭‭‮
		// privatescope
		internal static void u202d‭⁮‌‏‍⁬⁫⁮​‍‮‎⁭‪‌‭‮‌⁬⁯‌⁭‮‫‪‬⁫⁭‍⁬⁪‌‬‍⁮‏‌‭‭‮(LinkLabel linkLabel, bool flag)
		{
			linkLabel.TabStop = flag;
		}

		// ‭⁮⁮⁪⁭‭⁫⁭‮‫⁬‏⁭‏‬‎​‌‎​⁬⁪⁭‬‫⁫‌‫‮‮‭‪‬​⁭‭⁪⁬⁬‍‮
		// privatescope
		internal static void u202d⁮⁮⁪⁭‭⁫⁭‮‫⁬‏⁭‏‬‎​‌‎​⁬⁪⁭‬‫⁫‌‫‮‮‭‪‬​⁭‭⁪⁬⁬‍‮(LinkLabel linkLabel, LinkLabelLinkClickedEventHandler linkLabelLinkClickedEventHandler)
		{
			linkLabel.LinkClicked += linkLabelLinkClickedEventHandler;
		}

		// ‮​‍‌‌⁮⁫‫‍⁯⁯⁯⁬‫⁪‎⁪⁬‫⁮‎⁯‭​​‭‌‎​‍‮⁯⁪⁪⁪‫⁬‬‏⁫‮
		// privatescope
		internal static void u202e​‍‌‌⁮⁫‫‍⁯⁯⁯⁬‫⁪‎⁪⁬‫⁮‎⁯‭​​‭‌‎​‍‮⁯⁪⁪⁪‫⁬‬‏⁫‮(ButtonBase buttonBase, FlatStyle flatStyle)
		{
			buttonBase.FlatStyle = flatStyle;
		}

		// ⁮⁮⁭‎⁮⁪‮‌‏‫‫‌⁮⁬‮⁫⁮⁪⁫⁪‬‪​⁭⁯‭⁬‌‍‭⁪⁮‪⁯‎‬‪⁪‍⁯‮
		// privatescope
		internal static void u206e⁮⁭‎⁮⁪‮‌‏‫‫‌⁮⁬‮⁫⁮⁪⁫⁪‬‪​⁭⁯‭⁬‌‍‭⁪⁮‪⁯‎‬‪⁪‍⁯‮(Control control, EventHandler eventHandler)
		{
			control.Click += eventHandler;
		}

		// ‪‬​‍⁬‮‫‪⁯‎‫⁮⁭⁯‎‌⁭⁭‍‏‮‫‭‮‏‎‭⁮‮⁯‮⁬⁮‍‍‍⁭‫‮‪‮
		// privatescope
		internal static void u202a‬​‍⁬‮‫‪⁯‎‫⁮⁭⁯‎‌⁭⁭‍‏‮‫‭‮‏‎‭⁮‮⁯‮⁬⁮‍‍‍⁭‫‮‪‮(Control control, EventHandler eventHandler)
		{
			control.MouseEnter += eventHandler;
		}

		// ‫‏⁪​⁬⁯‫⁯‍‪⁯‪⁪‭⁫‎‍‎‬‬‌‫⁯⁮⁭⁭‮‭‌‏⁯‬‫‮‏‫‫⁮‮‫‮
		// privatescope
		internal static void u202b‏⁪​⁬⁯‫⁯‍‪⁯‪⁪‭⁫‎‍‎‬‬‌‫⁯⁮⁭⁭‮‭‌‏⁯‬‫‮‏‫‫⁮‮‫‮(Control control, EventHandler eventHandler)
		{
			control.MouseLeave += eventHandler;
		}

		// ‌⁪‏‏⁫‌⁭‭⁪‮⁯⁫‬‏‍‬⁮⁮‍‌‎‮⁪‌⁮⁭⁮⁫‮‬⁪‭⁬⁮⁮⁫‫‌‌‏‮
		// privatescope
		internal static void u200c⁪‏‏⁫‌⁭‭⁪‮⁯⁫‬‏‍‬⁮⁮‍‌‎‮⁪‌⁮⁭⁮⁫‮‬⁪‭⁬⁮⁮⁫‫‌‌‏‮(Control control, Color color)
		{
			control.ForeColor = color;
		}

		// ⁪‬⁪‏⁭‏‫‬‎⁪‬⁮‪⁭‪​‪‍⁮⁪⁭⁮⁫‮‎‭‍‮‎‎⁪⁮‮‫‎⁫⁫‌⁯‌‮
		// privatescope
		internal static void u206a‬⁪‏⁭‏‫‬‎⁪‬⁮‪⁭‪​‪‍⁮⁪⁭⁮⁫‮‎‭‍‮‎‎⁪⁮‮‫‎⁫⁫‌⁯‌‮(NumericUpDown numericUpDown, EventHandler eventHandler)
		{
			numericUpDown.ValueChanged += eventHandler;
		}

		// ‪⁫⁬‭‏⁪‌⁬‏⁫​‎⁮‏‭‌‎‌⁯⁮‪‍‭⁪‏⁪‌‎⁬‮‏⁫‏‬⁫⁭⁫⁭‫⁪‮
		// privatescope
		internal static void u202a⁫⁬‭‏⁪‌⁬‏⁫​‎⁮‏‭‌‎‌⁯⁮‪‍‭⁪‏⁪‌‎⁬‮‏⁫‏‬⁫⁭⁫⁭‫⁪‮(RadioButton radioButton, bool flag)
		{
			radioButton.TabStop = flag;
		}

		// ‮⁯‮​‏‬⁭‬⁯⁯⁭‎⁯‮‎​‮⁪⁮‭‌⁮⁭‬‫⁭⁭‮‮⁯‪‫⁭⁬‌⁭‬‏⁬‬‮
		// privatescope
		internal static void u202e⁯‮​‏‬⁭‬⁯⁯⁭‎⁯‮‎​‮⁪⁮‭‌⁮⁭‬‫⁭⁭‮‮⁯‪‫⁭⁬‌⁭‬‏⁬‬‮(RadioButton radioButton, EventHandler eventHandler)
		{
			radioButton.CheckedChanged += eventHandler;
		}

		// ⁪‏⁫‫​‏⁪⁬⁪‪⁪⁬‬⁫⁯‎‪⁯‫‎⁯‪‭‎‮‪‎⁮⁯‭⁯‎⁮⁮‪‭⁫‬⁫⁬‮
		// privatescope
		internal static void u206a‏⁫‫​‏⁪⁬⁪‪⁪⁬‬⁫⁯‎‪⁯‫‎⁯‪‭‎‮‪‎⁮⁯‭⁯‎⁮⁮‪‭⁫‬⁫⁬‮(Control control, bool flag)
		{
			control.Visible = flag;
		}

		// ⁯⁬‏⁫‍‫⁯‍⁫‎‪‭‬⁭⁫‍⁯​‍‫‏‏‫⁯‪‍⁬‬‏‪⁫⁬‌‮‎⁭‌⁫⁮⁪‮
		// privatescope
		internal static void u206f⁬‏⁫‍‫⁯‍⁫‎‪‭‬⁭⁫‍⁯​‍‫‏‏‫⁯‪‍⁬‬‏‪⁫⁬‌‮‎⁭‌⁫⁮⁪‮(Control control, Color color)
		{
			control.BackColor = color;
		}

		// ⁪⁪⁯⁫​‌⁬‬⁫‫‫‍⁯‫‬⁬‍​⁭⁮‬‌‍⁬⁪‌⁬‍‍‪‍‌⁬‫‭‮‍⁪‎‭‮
		// privatescope
		internal static void u206a⁪⁯⁫​‌⁬‬⁫‫‫‍⁯‫‬⁬‍​⁭⁮‬‌‍⁬⁪‌⁬‍‍‪‍‌⁬‫‭‮‍⁪‎‭‮(Control control, ImageLayout imageLayout)
		{
			control.BackgroundImageLayout = imageLayout;
		}

		// ‬‬​‪‌‭‏‫⁬‪‭‮⁬⁪⁯⁪⁭‎‭​‪‭⁯‏⁪​⁫‪⁬‌‏⁯⁪‫‬‬⁪⁮⁭‍‮
		// privatescope
		internal static void u202c‬​‪‌‭‏‫⁬‪‭‮⁬⁪⁯⁪⁭‎‭​‪‭⁯‏⁪​⁫‪⁬‌‏⁯⁪‫‬‬⁪⁮⁭‍‮(System.Windows.Forms.Timer timer, bool flag)
		{
			timer.Enabled = flag;
		}

		// ‫‪​⁯⁪⁬⁬‭‍⁪‫‪​‮‍‭‎‍⁯‫‭⁮‭​⁯​‍⁬‌‭‭⁯⁭‭‬‍‭‎‎⁭‮
		// privatescope
		internal static void u202b‪​⁯⁪⁬⁬‭‍⁪‫‪​‮‍‭‎‍⁯‫‭⁮‭​⁯​‍⁬‌‭‭⁯⁭‭‬‍‭‎‎⁭‮(System.Windows.Forms.Timer timer, int num)
		{
			timer.Interval = num;
		}

		// ‏‍​‍⁯‏‫‫‏‮⁬​‎⁬‍‪⁪‎‫‌‮‎‪‌‌‮⁪⁪‌‭⁭‮⁭​‎⁭⁪‬⁮‎‮
		// privatescope
		internal static void u200f‍​‍⁯‏‫‫‏‮⁬​‎⁬‍‪⁪‎‫‌‮‎‪‌‌‮⁪⁪‌‭⁭‮⁭​‎⁭⁪‬⁮‎‮(System.Windows.Forms.Timer timer, EventHandler eventHandler)
		{
			timer.Tick += eventHandler;
		}

		// ‭⁭⁪⁭‫‌⁬⁬⁭‎‏‬⁯⁮‭‪⁪‫⁭⁭‏‫‌‎⁪​⁮‎⁯⁭⁪‎⁪⁯‎‭⁯⁭​‌‮
		// privatescope
		internal static void u202d⁭⁪⁭‫‌⁬⁬⁭‎‏‬⁯⁮‭‪⁪‫⁭⁭‏‫‌‎⁪​⁮‎⁯⁭⁪‎⁪⁯‎‭⁯⁭​‌‮(ContainerControl containerControl, SizeF sizeF)
		{
			containerControl.AutoScaleDimensions = sizeF;
		}

		// ⁬‭‬‬⁮⁪⁮‬‎⁭⁫‪​⁯‭‌‪‫​‬‌⁯‭⁪⁪⁮‬⁬‏⁮‏‏‬‎‌‮⁮⁭⁬⁪‮
		// privatescope
		internal static void u206c‭‬‬⁮⁪⁮‬‎⁭⁫‪​⁯‭‌‪‫​‬‌⁯‭⁪⁪⁮‬⁬‏⁮‏‏‬‎‌‮⁮⁭⁬⁪‮(ContainerControl containerControl, System.Windows.Forms.AutoScaleMode autoScaleMode)
		{
			containerControl.AutoScaleMode = autoScaleMode;
		}

		// ⁯‍‭⁪‮‍‎‌⁫‫‏‍‮‫‫⁯‏‏‍‍‫‬⁪‫​‬⁯⁯⁭‮‌‍⁬‍‍‌‬‪‍‬‮
		// privatescope
		internal static Control.ControlCollection u206f‍‭⁪‮‍‎‌⁫‫‏‍‮‫‫⁯‏‏‍‍‫‬⁪‫​‬⁯⁯⁭‮‌‍⁬‍‍‌‬‪‍‬‮(Control control)
		{
			return control.Controls;
		}

		// ​⁫⁬⁯⁮⁭⁮‭‪‏‍‌​‏‪​⁪⁫‍‫⁫⁯‍​‏⁭⁪‭‫⁬‭‪‌​⁬‬​‍‍‏‮
		// privatescope
		internal static void u200b⁫⁬⁯⁮⁭⁮‭‪‏‍‌​‏‪​⁪⁫‍‫⁫⁯‍​‏⁭⁪‭‫⁬‭‪‌​⁬‬​‍‍‏‮(Control control, string str)
		{
			control.Name = str;
		}

		// ⁭‍‍⁯‌​⁪‬⁮⁮‪‮⁬⁭‎⁪‍‮‬‎​⁬‮⁬⁬⁪‬‏⁪‌⁫⁭‎⁭⁬‏‪‌⁭‍‮
		// privatescope
		internal static void u206d‍‍⁯‌​⁪‬⁮⁮‪‮⁬⁭‎⁪‍‮‬‎​⁬‮⁬⁬⁪‬‏⁪‌⁫⁭‎⁭⁬‏‪‌⁭‍‮(Control control, System.Drawing.Size size)
		{
			control.Size = size;
		}

		// ⁭‏⁬‪‪‭⁪‏⁯⁭‌‍⁬‮‮⁪‪‬⁯‪⁬⁯‫‫‫‫​⁯‫‭‌‬⁫⁫⁮⁫⁯‪‍⁪‮
		// privatescope
		internal static void u206d‏⁬‪‪‭⁪‏⁯⁭‌‍⁬‮‮⁪‪‬⁯‪⁬⁯‫‫‫‫​⁯‫‭‌‬⁫⁫⁮⁫⁯‪‍⁪‮(UserControl userControl, EventHandler eventHandler)
		{
			userControl.Load += eventHandler;
		}

		// ⁬‬​‍⁬‪‍​‭‌⁮‫‮⁭‫‮⁯⁯‎‌‎⁮​‪‮⁬‭⁪‪⁭‍‏⁪‍‮⁬‬‏‎‮
		// privatescope
		internal static void u206c‬​‍⁬‪‍​‭‌⁮‫‮⁭‫‮⁯⁯‎‌‎⁮​‪‮⁬‭⁪‪⁭‍‏⁪‍‮⁬‬‏‎‮(Control control, EventHandler eventHandler)
		{
			control.VisibleChanged += eventHandler;
		}

		// ‫‬⁫‌‪⁯⁭‪⁮‏‪⁭⁪‌‪⁬⁪‭⁬‮‬‭⁫‫⁯‭‫‫‎‎‮‎‏⁮⁯‪‌‭⁫‌‮
		// privatescope
		internal static void u202b‬⁫‌‪⁯⁭‪⁮‏‪⁭⁪‌‪⁬⁪‭⁬‮‬‭⁫‫⁯‭‫‫‎‎‮‎‏⁮⁯‪‌‭⁫‌‮(Control control, bool flag)
		{
			control.ResumeLayout(flag);
		}

		// ‮‎‫‪⁮‏‪‎​⁬‮‎⁪⁪⁫‭⁯‌‏‬​‏⁫⁭‬⁫‎‬⁯‎⁪‏⁮​‍⁯⁫⁮⁯‫‮
		// privatescope
		internal static void u202e‎‫‪⁮‏‪‎​⁬‮‎⁪⁪⁫‭⁯‌‏‬​‏⁫⁭‬⁫‎‬⁯‎⁪‏⁮​‍⁯⁫⁮⁯‫‮(Control control)
		{
			control.PerformLayout();
		}

		// ⁪‪⁭​⁫‮‍‬‭⁬‮‬‫‪⁬‎‌‭⁬‬‭‪‌‫⁮⁫⁫‪‍⁭⁬​‌⁪⁪⁯‮​‫‬‮
		// privatescope
		internal static void u206a‪⁭​⁫‮‍‬‭⁬‮‬‫‪⁬‎‌‭⁬‬‭‪‌‫⁮⁫⁫‪‍⁭⁬​‌⁪⁪⁯‮​‫‬‮(ISupportInitialize supportInitialize)
		{
			supportInitialize.EndInit();
		}

		// ‬‏‫‬⁭‍‏‏‍‪‭‪‏‭⁭‍‍‮‏‪‍‭⁪‬⁪‌‍⁭⁭⁯‌⁪⁯‌⁬‌⁬⁬‎‎‮
		// privatescope
		internal static void u202c‏‫‬⁭‍‏‏‍‪‭‪‏‭⁭‍‍‮‏‪‍‭⁪‬⁪‌‍⁭⁭⁯‌⁪⁯‌⁬‌⁬⁬‎‎‮(Control control, bool flag)
		{
			control.ResumeLayout(flag);
		}

		// ‍⁯⁬​‮‎‪⁯‌⁬‬⁫⁬⁯⁭‬‍‫⁫‎‍​‬‫⁪‏⁮‮​‬‭⁪‮⁭⁪‮‎‫⁪‏‮
		// privatescope
		internal static IAsyncResult u200d⁯⁬​‮‎‪⁯‌⁬‬⁫⁬⁯⁭‬‍‫⁫‎‍​‬‫⁪‏⁮‮​‬‭⁪‮⁭⁪‮‎‫⁪‏‮(Control control, Delegate @delegate)
		{
			return control.BeginInvoke(@delegate);
		}

		// ⁮‏⁬⁬‭‮​‍‍‭⁫⁮⁮⁯⁪‏⁫‭‍‎‪⁭‎‏​⁭⁮⁬⁯⁯‏​‬‭⁪‏‬‌‮‍‮
		// privatescope
		internal static bool u206e‏⁬⁬‭‮​‍‍‭⁫⁮⁮⁯⁪‏⁫‭‍‎‪⁭‎‏​⁭⁮⁬⁯⁯‏​‬‭⁪‏‬‌‮‍‮(RadioButton radioButton)
		{
			return radioButton.Checked;
		}

		// ‪⁪‪‎⁫​‏‏‌⁬‪‮⁯‭⁬‫⁫‪⁯⁬‮‬⁭‭​‫⁫⁭‪⁪‫‌‏‌‪‭‌‫⁪‮
		// privatescope
		internal static void u202a⁪‪‎⁫​‏‏‌⁬‪‮⁯‭⁬‫⁫‪⁯⁬‮‬⁭‭​‫⁫⁭‪⁪‫‌‏‌‪‭‌‫⁪‮(RadioButton radioButton, bool flag)
		{
			radioButton.Checked = flag;
		}

		// ‍⁭⁮⁬‍⁮‌​‍‪‮‭⁭⁬‭‭‍‬⁬​‭⁬⁯‏‪⁭⁬‍‎⁯⁯‏⁯‭‏‭‬‌‌‮
		// privatescope
		internal static void u200d⁭⁮⁬‍⁮‌​‍‪‮‭⁭⁬‭‭‍‬⁬​‭⁬⁯‏‪⁭⁬‍‎⁯⁯‏⁯‭‏‭‬‌‌‮(CheckBox checkBox, bool flag)
		{
			checkBox.Checked = flag;
		}

		// ⁫‬⁭‬‫⁮‮‭‫‫‪⁯‏‬⁫‬‬‌⁫⁪‮‫‫‭⁯‎‪‏‍​‫⁭‭‌‎⁫‮⁭‭‬‮
		// privatescope
		internal static bool u206b‬⁭‬‫⁮‮‭‫‫‪⁯‏‬⁫‬‬‌⁫⁪‮‫‫‭⁯‎‪‏‍​‫⁭‭‌‎⁫‮⁭‭‬‮(ISharpControl sharpControl)
		{
			return sharpControl.get_IsPlaying();
		}

		// ⁬‭​⁮‏⁯⁫​‪​‮‪‎‌​‌⁪‭⁮⁫⁪⁭⁪‬⁯‫​‫⁭⁮‮‌⁬‏‍‍​⁪‍⁫‮
		// privatescope
		internal static void u206c‭​⁮‏⁯⁫​‪​‮‪‎‌​‌⁪‭⁮⁫⁪⁭⁪‬⁯‫​‫⁭⁮‮‌⁬‏‍‍​⁪‍⁫‮(ISharpControl sharpControl)
		{
			sharpControl.StartRadio();
		}

		// ⁪‬‍‬‍​‏‫‍‎‌‪⁭‍‭⁯‮‫⁪‮‮‫⁮⁮‪⁮‌‎‎⁬⁬‬‍‌‎‎‬⁭‍‌‮
		// privatescope
		internal static string u206a‬‍‬‍​‏‫‍‎‌‪⁭‍‭⁯‮‫⁪‮‮‫⁮⁮‪⁮‌‎‎⁬⁬‬‍‌‎‎‬⁭‍‌‮(string str, string str)
		{
			return string.Concat(str, str);
		}

		// ‪‫⁬‮‬‍‫⁮⁬‫⁭‮‭⁭‪‌‎‎‏‎⁬‏⁯‏‍⁮‭⁯​‌⁮⁬‬⁪‭‏⁮‪‏‌‮
		// privatescope
		internal static int u202a‫⁬‮‬‍‫⁮⁬‫⁭‮‭⁭‪‌‎‎‏‎⁬‏⁯‏‍⁮‭⁯​‌⁮⁬‬⁪‭‏⁮‪‏‌‮(Control control)
		{
			return control.Height;
		}

		// ⁮⁮⁫‏‮‌‪⁫‏‌‌⁬‮⁫‬⁬‫⁪‎⁫⁬‎​‮‎⁪⁭‬⁬​⁫‫‍​‎⁮⁯‪‫‪‮
		// privatescope
		internal static string u206e⁮⁫‏‮‌‪⁫‏‌‌⁬‮⁫‬⁬‫⁪‎⁫⁬‎​‮‎⁪⁭‬⁬​⁫‫‍​‎⁮⁯‪‫‪‮(object obj, object obj, object obj)
		{
			return string.Concat(obj, obj, obj);
		}

		// ‬⁯⁭‮⁬​‎⁭⁯‮‌‭‫‌⁭⁪‪‍‮⁭⁯‬‪⁪⁪‍⁪‬⁬‭‌⁪⁪​⁯⁯‮⁮⁭‏‮
		// privatescope
		internal static int u202c⁯⁭‮⁬​‎⁭⁯‮‌‭‫‌⁭⁪‪‍‮⁭⁯‬‪⁪⁪‍⁪‬⁬‭‌⁪⁪​⁯⁯‮⁮⁭‏‮(Control control)
		{
			return control.Left;
		}

		// ‫‏‫‬⁫‪⁯‮⁬⁯​‫‬‏⁯‪⁮‎‎⁭‬⁫‮‫‬⁪⁮⁭‍‎‪⁯‭⁭‭⁮‏⁮‎‫‮
		// privatescope
		internal static int u202b‏‫‬⁫‪⁯‮⁬⁯​‫‬‏⁯‪⁮‎‎⁭‬⁫‮‫‬⁪⁮⁭‍‎‪⁯‭⁭‭⁮‏⁮‎‫‮(Control control)
		{
			return control.Width;
		}

		// ‍‪​⁭‭⁭‮‭⁪‪​⁫‪⁯‮⁬⁫⁯‪⁬⁬​‬⁯‍⁪‭‪⁭‪‍⁪‭⁮‮⁫‏‭‍⁭‮
		// privatescope
		internal static int u200d‪​⁭‭⁭‮‭⁪‪​⁫‪⁯‮⁬⁫⁯‪⁬⁬​‬⁯‍⁪‭‪⁭‪‍⁪‭⁮‮⁫‏‭‍⁭‮(Control control)
		{
			return control.Top;
		}

		// ‭‎⁮‫‍‬​⁭⁪⁮‪‪⁯‪⁯⁯‭‪‫⁯⁮⁫⁯‮‍‎‪‏‪‮‪⁮​⁮​‬‪‬‎⁯‮
		// privatescope
		internal static FormWindowState u202d‎⁮‫‍‬​⁭⁪⁮‪‪⁯‪⁯⁯‭‪‫⁯⁮⁫⁯‮‍‎‪‏‪‮‪⁮​⁮​‬‪‬‎⁯‮(Form form)
		{
			return form.WindowState;
		}

		// ⁪‍⁯‪‌⁮⁭⁬‏‍​‏‮‏‌‏‫‭‌‌​⁬⁪⁭⁭⁪‍‭⁯⁪‬‏‎‫⁪‍⁮⁮‬‪‮
		// privatescope
		internal static string u206a‍⁯‪‌⁮⁭⁬‏‍​‏‮‏‌‏‫‭‌‌​⁬⁪⁭⁭⁪‍‭⁯⁪‬‏‎‫⁪‍⁮⁮‬‪‮(object obj, object obj)
		{
			return string.Concat(obj, obj);
		}

		// ⁬‬‬‫‬⁭‭​‮‮‫⁫‍‫⁪‪‏‪⁭‪⁮⁭⁯⁯⁮‫‍‍⁫⁭‮‍‌‬‍‍‮⁯⁮‭‮
		// privatescope
		internal static string[] u206c‬‬‫‬⁭‭​‮‮‫⁫‍‫⁪‪‏‪⁭‪⁮⁭⁯⁯⁮‫‍‍⁫⁭‮‍‌‬‍‍‮⁯⁮‭‮(string str, char[] chrArray)
		{
			return str.Split(chrArray);
		}

		// ‏‫⁪⁬​⁯‍‍‌⁭⁪⁯⁪⁬‭‬⁯‎⁯‎⁪⁬⁯​‪⁬⁬‮‫‎‌‭‬‬‪‍‫⁬⁯⁮‮
		// privatescope
		internal static int u200f‫⁪⁬​⁯‍‍‌⁭⁪⁯⁪⁬‭‬⁯‎⁯‎⁪⁬⁯​‪⁬⁬‮‫‎‌‭‬‬‪‍‫⁬⁯⁮‮(string str)
		{
			return Convert.ToInt32(str);
		}

		// ⁭‬⁫‎‬‍⁪‬‏⁪‏‭‪‫‏‫⁬⁪‬⁭⁫‬⁫⁫‍⁯⁪⁯‌‍‪⁬‎‫‏‪⁭⁯‍‮‮
		// privatescope
		internal static void u206d‬⁫‎‬‍⁪‬‏⁪‏‭‪‫‏‫⁬⁪‬⁭⁫‬⁫⁫‍⁯⁪⁯‌‍‪⁬‎‫‏‪⁭⁯‍‮‮(Control control, int num)
		{
			control.Height = num;
		}

		// ‏‌⁯​‌‏‭⁭‎⁯‌⁮‫⁬⁯‎⁫‍‌‬⁯‮‪⁯‏‍‭‍‎​‎‌⁬​‫‮⁬‪‌‌‮
		// privatescope
		internal static void u200f‌⁯​‌‏‭⁭‎⁯‌⁮‫⁬⁯‎⁫‍‌‬⁯‮‪⁯‏‍‭‍‎​‎‌⁬​‫‮⁬‪‌‌‮(Control control, int num)
		{
			control.Left = num;
		}

		// ‌⁫‫‪​‍⁪‌⁯‏‍‏‌‍⁫‬‍⁫‎⁯​‍‫​‎⁯⁮⁮‌‬‮⁬‮⁮‎‌⁪‍​⁫‮
		// privatescope
		internal static void u200c⁫‫‪​‍⁪‌⁯‏‍‏‌‍⁫‬‍⁫‎⁯​‍‫​‎⁯⁮⁮‌‬‮⁬‮⁮‎‌⁪‍​⁫‮(Control control, int num)
		{
			control.Width = num;
		}

		// ‎​⁬‪‎‫⁬‎‫⁪‌‎‭‪‎⁯‎‍‭⁮‏‍‫‏‎⁪‬‪‭‫​‬‮⁫‫‌‮⁯‌‏‮
		// privatescope
		internal static void u200e​⁬‪‎‫⁬‎‫⁪‌‎‭‪‎⁯‎‍‭⁮‏‍‫‏‎⁪‬‪‭‫​‬‮⁫‫‌‮⁯‌‏‮(Control control, int num)
		{
			control.Top = num;
		}

		// ‮‏​‮‮‏⁬⁬⁪‌‬‏‎​‮‎‍‬‪⁫⁮⁫⁪‭⁮‏‬​‭⁬⁮‪‏‮⁮‏⁮‍‏‌‮
		// privatescope
		internal static void u202e‏​‮‮‏⁬⁬⁪‌‬‏‎​‮‎‍‬‪⁫⁮⁫⁪‭⁮‏‬​‭⁬⁮‪‏‮⁮‏⁮‍‏‌‮(Form form, FormWindowState formWindowState)
		{
			form.WindowState = formWindowState;
		}

		// ⁫⁬⁮⁭⁬​⁫‫‍⁯‎‪‎‏⁯⁪‎‪‎‎‫⁪‌‌⁯‬‎⁪⁫‫‬‪‭‬⁬‫⁮⁪‪⁯‮
		// privatescope
		internal static string u206b⁬⁮⁭⁬​⁫‫‍⁯‎‪‎‏⁯⁪‎‪‎‎‫⁪‌‌⁯‬‎⁪⁫‫‬‪‭‬⁬‫⁮⁪‪⁯‮(object[] objArray)
		{
			return string.Concat(objArray);
		}

		// ​‭⁭​⁬‪⁫‌‏⁬‎⁮‬‮‏⁭⁭‫‪‬‏⁪⁪‪‌‌‮​‭‍‪‪‏‬⁯‍‬‏⁯⁯‮
		// privatescope
		internal static void u200b‭⁭​⁬‪⁫‌‏⁬‎⁮‬‮‏⁭⁭‫‪‬‏⁪⁪‪‌‌‮​‭‍‪‪‏‬⁯‍‬‏⁯⁯‮(object obj, ref bool flagPointer)
		{
			Monitor.Enter(obj, ref flagPointer);
		}

		// ‪‎​⁫⁪‫‭⁮⁪‫‮‎⁫‏‎‍​⁫⁮‫‭‎‏​⁭‭⁭‏‌‭‎⁮‬⁯‎‫⁪‭⁬‫‮
		// privatescope
		internal static bool u202a‎​⁫⁪‫‭⁮⁪‫‮‎⁫‏‎‍​⁫⁮‫‭‎‏​⁭‭⁭‏‌‭‎⁮‬⁯‎‫⁪‭⁬‫‮(string str, string str)
		{
			return str == str;
		}

		// ⁫‭‍‫‭‪‌⁯⁫‌⁫‌‮‮‌‏⁪⁪​⁯‎‭⁫‪⁯⁭‭‎‏‍‌​‍‪⁮⁪‫‫‍‍‮
		// privatescope
		internal static void u206b‭‍‫‭‪‌⁯⁫‌⁫‌‮‮‌‏⁪⁪​⁯‎‭⁫‪⁯⁭‭‎‏‍‌​‍‪⁮⁪‫‫‍‍‮(object obj)
		{
			Monitor.Exit(obj);
		}

		// ⁮⁭⁪⁬‎‮⁪‫​⁭‫‮​‮‎‌⁭⁯⁮‬‍⁫‫⁫‬‪⁮‬⁬⁪‌‏​⁯​⁭​⁫‮‫‮
		// privatescope
		internal static void u206e⁭⁪⁬‎‮⁪‫​⁭‫‮​‮‎‌⁭⁯⁮‬‍⁫‫⁫‬‪⁮‬⁬⁪‌‏​⁯​⁭​⁫‮‫‮(FloatFifoStream floatFifoStream)
		{
			floatFifoStream.Flush();
		}

		// ⁪‏​‪⁯‌‮‫‭‏‫‏‮‮⁪‎‏⁭⁮‎‬⁭‎‎‮⁭‬⁫⁮‭⁯‭‎​‬⁭⁬⁫⁮‬‮
		// privatescope
		internal static string u206a‏​‪⁯‌‮‫‭‏‫‏‮‮⁪‎‏⁭⁮‎‬⁭‎‎‮⁭‬⁫⁮‭⁯‭‎​‬⁭⁬⁫⁮‬‮(string str, int num, int num)
		{
			return str.Substring(num, num);
		}

		// ⁯​⁭‫‮⁪‮‬‎⁮⁪‏⁯‍⁬‏⁫⁯‍​‎‬‮​⁫‌⁭‫‬⁮⁮‪⁫‏‮‎‭​⁯‮‮
		// privatescope
		internal static string u206f​⁭‫‮⁪‮‬‎⁮⁪‏⁯‍⁬‏⁫⁯‍​‎‬‮​⁫‌⁭‫‬⁮⁮‪⁫‏‮‎‭​⁯‮‮(string str, int num)
		{
			return str.Substring(num);
		}

		// ‎⁯⁯​‏‫‫‌⁬​‍‭‬‬‬⁬⁯⁫‪⁭⁪⁮⁯‏‪‮‫‮⁫⁯⁬‍‮‫⁮⁯⁪‌‮‌‮
		// privatescope
		internal static bool u200e⁯⁯​‏‫‫‌⁬​‍‭‬‬‬⁬⁯⁫‪⁭⁪⁮⁯‏‪‮‫‮⁫⁯⁬‍‮‫⁮⁯⁪‌‮‌‮(string str, string str)
		{
			return str != str;
		}

		// ‫​‌⁭‭‏⁬⁭⁫‏‏‮⁭‏‪‌⁮‮‎‍⁬⁪‭​⁯‫‌‮⁫‫​‍⁭‍‭‌‭‭‎⁯‮
		// privatescope
		internal static Color u202b​‌⁭‭‏⁬⁭⁫‏‏‮⁭‏‪‌⁮‮‎‍⁬⁪‭​⁯‫‌‮⁫‫​‍⁭‍‭‌‭‭‎⁯‮()
		{
			return SystemColors.ControlText;
		}

		// ‫⁬⁫‮‎⁭⁯‮‎​‏​‎⁯⁯⁫‭⁭‍‭⁯‎‏⁫⁯‎⁯‫⁮‬⁭⁮‍⁪‭⁬⁮⁯‏‮
		// privatescope
		internal static Color u202b⁬⁫‮‎⁭⁯‮‎​‏​‎⁯⁯⁫‭⁭‍‭⁯‎‏⁫⁯‎⁯‫⁮‬⁭⁮‍⁪‭⁬⁮⁯‏‮()
		{
			return SystemColors.Control;
		}

		// ‌‭⁫‫‮‌⁯‭⁫⁯⁫‬⁫⁮⁪‮‏⁫‮‬‬⁬‌⁫⁪⁪⁪⁮⁫‌⁪⁭⁭‍‫‭⁪⁬‬‮‮
		// privatescope
		internal static Color u200c‭⁫‫‮‌⁯‭⁫⁯⁫‬⁫⁮⁪‮‏⁫‮‬‬⁬‌⁫⁪⁪⁪⁮⁫‌⁪⁭⁭‍‫‭⁪⁬‬‮‮()
		{
			return SystemColors.Highlight;
		}

		// ⁬‮⁪​⁭‪‮⁭⁪‬‬⁬‪⁮‫⁯⁭‏‎⁫‌‮‮‭‭⁫‌‭⁮‭⁬‮‬⁪‍‭‫‍⁮⁯‮
		// privatescope
		internal static string u206c‮⁪​⁭‪‮⁭⁪‬‬⁬‪⁮‫⁯⁭‏‎⁫‌‮‮‭‭⁫‌‭⁮‭⁬‮‬⁪‍‭‫‍⁮⁯‮()
		{
			return Application.ExecutablePath;
		}

		// ‮⁫⁫⁭​‌​‍‌‌​‪‬⁭⁮‭‬‬‭‫⁪‌‏‬‏‫‌‍⁯⁯⁭‬​‬‭​‏‪⁮⁫‮
		// privatescope
		internal static string u202e⁫⁫⁭​‌​‍‌‌​‪‬⁭⁮‭‬‬‭‫⁪‌‏‬‏‫‌‍⁯⁯⁭‬​‬‭​‏‪⁮⁫‮(string str)
		{
			return Path.GetDirectoryName(str);
		}

		// ‎⁬​⁪⁮‏⁫‮⁫‌⁮⁮⁬‪⁪‪‏‭⁭​‏⁫⁫⁯⁮​‎⁮​‌‍‎⁭⁯‫​‮⁭‭‫‮
		// privatescope
		internal static bool u200e⁬​⁪⁮‏⁫‮⁫‌⁮⁮⁬‪⁪‪‏‭⁭​‏⁫⁫⁯⁮​‎⁮​‌‍‎⁭⁯‫​‮⁭‭‫‮(string str)
		{
			return Utils.GetBooleanSetting(str);
		}

		// ⁪⁭⁮⁭⁬‭‪⁯‏‫⁯⁬⁮⁭‪⁯‭‏‬‎‭⁬‬⁯‮⁫‎⁮⁬‏‭⁭‏⁮‎⁪⁬⁭‭‮
		// privatescope
		internal static Type u206a⁭⁮⁭⁬‭‪⁯‏‫⁯⁬⁮⁭‪⁯‭‏‬‎‭⁬‬⁯‮⁫‎⁮⁬‏‭⁭‏⁮‎⁪⁬⁭‭‮(object obj)
		{
			return obj.GetType();
		}

		// ‍‭‭‎‌‪‍​⁪‫‎‫‎⁫‫⁪‏‌​‭‪⁫‮​‪‎‮‏⁯‬⁬‭‎⁯​‭‭‭‭⁮‮
		// privatescope
		internal static PropertyInfo u200d‭‭‎‌‪‍​⁪‫‎‫‎⁫‫⁪‏‌​‭‪⁫‮​‪‎‮‏⁯‬⁬‭‎⁯​‭‭‭‭⁮‮(Type type, string str)
		{
			return type.GetProperty(str);
		}

		// ‫‭⁬‬⁭‮‮⁪‮‫‮⁯⁯‎‭‏‎‎​⁫⁭‭‎‬‌‌‬‌‎‬‍‍‮⁭​‍⁬‫‪⁪‮
		// privatescope
		internal static bool u202b‭⁬‬⁭‮‮⁪‮‫‮⁯⁯‎‭‏‎‎​⁫⁭‭‎‬‌‌‬‌‎‬‍‍‮⁭​‍⁬‫‪⁪‮(PropertyInfo propertyInfo, PropertyInfo propertyInfo)
		{
			return propertyInfo != propertyInfo;
		}

		// ‎‏‌⁭‪⁮‪‏‏‎⁭‍‮‫‭‍⁯‬⁪‪‌‮⁯​⁮‫‏⁬‎‍⁮‌⁮⁭‪‬⁫‎‬⁬‮
		// privatescope
		internal static string u200e‏‌⁭‪⁮‪‏‏‎⁭‍‮‫‭‍⁯‬⁪‪‌‮⁯​⁮‫‏⁬‎‍⁮‌⁮⁭‪‬⁫‎‬⁬‮(string str, string str)
		{
			return Utils.GetStringSetting(str, str);
		}

		// ⁫⁪‫‬⁮‬‭‪‮‍‌⁮⁮⁪‏‍‍‎‏‎​‏‏⁮‬‫⁬‬⁫‪⁪⁮⁫‏⁪‪⁭‎‌⁯‮
		// privatescope
		internal static void u206b⁪‫‬⁮‬‭‪‮‍‌⁮⁮⁪‏‍‍‎‏‎​‏‏⁮‬‫⁬‬⁫‪⁪⁮⁫‏⁪‪⁭‎‌⁯‮(Control control, bool flag)
		{
			control.Enabled = flag;
		}

		// ⁭‎⁯⁯‍⁪‬⁬⁮⁯‫⁭⁬‭‬‮⁮‫⁬⁬⁪⁮‎‏‪​​‏⁪⁪‭‭‏‪‍‌‭‫‭⁫‮
		// privatescope
		internal static void u206d‎⁯⁯‍⁪‬⁬⁮⁯‫⁭⁬‭‬‮⁮‫⁬⁬⁪⁮‎‏‪​​‏⁪⁪‭‭‏‪‍‌‭‫‭⁫‮(Form form, FormClosingEventHandler formClosingEventHandler)
		{
			form.FormClosing += formClosingEventHandler;
		}

		// ‌‭‌⁬‪⁭⁭‏‍⁭⁯‌⁫‍​‏‎⁮⁬‌⁯‫‪⁪⁪⁮⁪⁫‍‫‏‫‏⁯​‬‭‎⁮‮‮
		// privatescope
		internal static TabControl.TabPageCollection u200c‭‌⁬‪⁭⁭‏‍⁭⁯‌⁫‍​‏‎⁮⁬‌⁯‫‪⁪⁪⁮⁪⁫‍‫‏‫‏⁯​‬‭‎⁮‮‮(TabControl tabControl)
		{
			return tabControl.TabPages;
		}

		// ‍⁯‮‎​⁫‮‮‎‌⁬‪‮⁫⁮‏⁮‭​⁯⁫⁮‍⁭⁮⁭‎⁮⁫‏‭⁫‍‪⁭‎‌‌‏⁯‮
		// privatescope
		internal static void u200d⁯‮‎​⁫‮‮‎‌⁬‪‮⁫⁮‏⁮‭​⁯⁫⁮‍⁭⁮⁭‎⁮⁫‏‭⁫‍‪⁭‎‌‌‏⁯‮(TabControl.TabPageCollection tabPageCollections, TabPage tabPage)
		{
			tabPageCollections.Remove(tabPage);
		}

		// ‪⁬‌‮‫‮‬‮⁮⁪⁭⁯‬‬‫‎⁮‪‍⁪⁫⁯‮‍‮⁪⁬‬⁬‪‍‫⁯‎​⁭‪⁯‬‪‮
		// privatescope
		internal static void u202a⁬‌‮‫‮‬‮⁮⁪⁭⁯‬‬‫‎⁮‪‍⁪⁫⁯‮‍‮⁪⁬‬⁬‪‍‫⁯‎​⁭‪⁯‬‪‮(ISharpControl sharpControl, object obj, ProcessorType processorType)
		{
			sharpControl.RegisterStreamHook(obj, processorType);
		}

		// ⁫⁯‫‪‌⁭⁯⁬⁪⁯‭‮‬‮‫‭⁪⁮⁮⁭‍‏​‏⁪‬‌⁯‍⁫‭‭⁫⁫‭‏⁮‭‭⁯‮
		// privatescope
		internal static void u206b⁯‫‪‌⁭⁯⁬⁪⁯‭‮‬‮‫‭⁪⁮⁮⁭‍‏​‏⁪‬‌⁯‍⁫‭‭⁫⁫‭‏⁮‭‭⁯‮(ISharpControl sharpControl, PropertyChangedEventHandler propertyChangedEventHandler)
		{
			sharpControl.add_PropertyChanged(propertyChangedEventHandler);
		}

		// ⁯‍⁯⁮‌⁪‎⁮⁬‪⁫⁬‬‮⁯‏‪⁫⁯⁬‌⁫‍‭⁮‫‪⁫⁬⁬⁯‭‏‎⁮⁯⁯⁬‎⁪‮
		// privatescope
		internal static UnsafeBuffer u206f‍⁯⁮‌⁪‎⁮⁬‪⁫⁬‬‮⁯‏‪⁫⁯⁬‌⁫‍‭⁮‫‪⁫⁬⁬⁯‭‏‎⁮⁯⁯⁬‎⁪‮(int num, int num)
		{
			return UnsafeBuffer.Create(num, num);
		}

		// ‌‏‬⁪⁯‌‍⁮⁫​‏‮⁪‎‍⁪⁮‬‏‭⁯​‪‏‫⁭⁪‌‍‬‏⁯‬‮⁪‪⁭‏⁭‏‮
		// privatescope
		internal static unsafe void* u200c‏‬⁪⁯‌‍⁮⁫​‏‮⁪‎‍⁪⁮‬‏‭⁯​‪‏‫⁭⁪‌‍‬‏⁯‬‮⁪‪⁭‏⁭‏‮(UnsafeBuffer unsafeBuffer)
		{
			return unsafeBuffer;
		}

		// ‏‮⁫‏⁯⁯‏​⁬‌‎⁫​‏‬‪⁮‫‬‌‎‍‌‮⁮⁬⁯‏⁮​⁭⁭⁬‮⁮⁯‏‮⁮‎‮
		// privatescope
		internal static UnsafeBuffer u200f‮⁫‏⁯⁯‏​⁬‌‎⁫​‏‬‪⁮‫‬‌‎‍‌‮⁮⁬⁯‏⁮​⁭⁭⁬‮⁮⁯‏‮⁮‎‮(int num)
		{
			return UnsafeBuffer.Create(num);
		}

		// ⁪⁪‎‮​‎⁮⁪‏‫‭‮‌⁯⁭⁯⁯‎‫‪‪‪​‍⁮‭‭‌​​‍‪⁬⁬‬⁮‪​⁯‮
		// privatescope
		internal static FloatFifoStream u206a⁪‎‮​‎⁮⁪‏‫‭‮‌⁯⁭⁯⁯‎‫‪‪‪​‍⁮‭‭‌​​‍‪⁬⁬‬⁮‪​⁯‮(BlockMode blockMode, int num)
		{
			return new FloatFifoStream(blockMode, num);
		}

		// ‎‎‭‍‮‭‍‎‏⁪‭‬⁫⁫‍⁪‏‭‪⁬​⁮⁮​‏⁯‍​​‪‭‫⁮‏‫‎‏‮‎⁯‮
		// privatescope
		internal static FloatFifoStream u200e‎‭‍‮‭‍‎‏⁪‭‬⁫⁫‍⁪‏‭‪⁬​⁮⁮​‏⁯‍​​‪‭‫⁮‏‫‎‏‮‎⁯‮(BlockMode blockMode)
		{
			return new FloatFifoStream(blockMode);
		}

		// ‏‫​‍‌‮‌​‍​‏‌‏⁬‍⁫⁯‌‏‬‬‪‏⁭‏‪⁮‍‪⁫⁪‬⁬⁪⁯⁫⁯‫‬‫‮
		// privatescope
		internal static bool u200f‫​‍‌‮‌​‍​‏‌‏⁬‍⁫⁯‌‏‬‬‪‏⁭‏‪⁮‍‪⁫⁪‬⁬⁪⁯⁫⁯‫‬‫‮(string str)
		{
			return File.Exists(str);
		}

		// ​‍‭‎⁭⁬⁭‬⁭⁯⁬⁮⁫‌⁮⁪⁮‭⁭⁯⁮⁫⁬​‭‏‭⁬‭‫⁬‫‏‌‬​⁫‏‏‮
		// privatescope
		internal static FileStream u200b‍‭‎⁭⁬⁭‬⁭⁯⁬⁮⁫‌⁮⁪⁮‭⁭⁯⁮⁫⁬​‭‏‭⁬‭‫⁬‫‏‌‬​⁫‏‏‮(string str, int num, FileOptions fileOption)
		{
			return File.Create(str, num, fileOption);
		}

		// ‏‏‌⁪⁯​⁪‎‮⁭‫‭‫​‏⁪‮⁬‭​‎‮‭⁮‏‌⁪⁬‮‭‭⁪⁭‬⁭​‪‌⁫‏‮
		// privatescope
		internal static FileStream u200f‏‌⁪⁯​⁪‎‮⁭‫‭‫​‏⁪‮⁬‭​‎‮‭⁮‏‌⁪⁬‮‭‭⁪⁭‬⁭​‪‌⁫‏‮(string str, FileMode fileMode)
		{
			return File.Open(str, fileMode);
		}

		// ⁪⁫⁮⁪⁫‮‭‌‪‪‬‭‌​⁯‌‪‏‫⁫⁮‮‪‏‌‏‌⁪‌​⁯‍⁫‌‌​⁮​⁮⁪‮
		// privatescope
		internal static void u206a⁫⁮⁪⁫‮‭‌‪‪‬‭‌​⁯‌‪‏‫⁫⁮‮‪‏‌‏‌⁪‌​⁯‍⁫‌‌​⁮​⁮⁪‮(Stream stream)
		{
			stream.Close();
		}

		// ‏‌⁮⁮⁮⁭⁯⁭‮‬‪‭​‍⁭⁫⁪⁭‭‭‮‬⁬⁬‏‌‬‍‫⁬⁮‭⁬⁭‭⁬‭​‫⁫‮
		// privatescope
		internal static void u200f‌⁮⁮⁮⁭⁯⁭‮‬‪‭​‍⁭⁫⁪⁭‭‭‮‬⁬⁬‏‌‬‍‫⁬⁮‭⁬⁭‭⁬‭​‫⁫‮(string str)
		{
			File.Delete(str);
		}

		// ⁫‬‮⁪‮‬‭‏⁯​‫‭‫‮⁭‏‮‎‭⁮‭⁯‫‎‭⁮‏‮​‬‎‎⁪‍‏‏⁫​⁯‮‮
		// privatescope
		internal static string u206b‬‮⁪‮‬‭‏⁯​‫‭‫‮⁭‏‮‎‭⁮‭⁯‫‎‭⁮‏‮​‬‎‎⁪‍‏‏⁫​⁯‮‮()
		{
			return Environment.NewLine;
		}

		// ​‮‍‏‬⁬​‏⁬⁮‭‎‎‭⁪​‬​‏​‌‫⁪‮‬‍​⁯‫‌‎​⁭⁯⁭‍‭⁯‫‮‮
		// privatescope
		internal static string u200b‮‍‏‬⁬​‏⁬⁮‭‎‎‭⁪​‬​‏​‌‫⁪‮‬‍​⁯‫‌‎​⁭⁯⁭‍‭⁯‫‮‮(object obj)
		{
			return obj.ToString();
		}

		// ‬‍‭​​‎‏​‭‬‮​‌‮‎⁬‌‫‎⁫⁬‎⁯‮‪‮‍⁯⁭‏‏⁪‏⁫‮⁫‬⁯‮‮
		// privatescope
		internal static string u202c‍‭​​‎‏​‭‬‮​‌‮‎⁬‌‫‎⁫⁬‎⁯‮‪‮‍⁯⁭‏‏⁪‏⁫‮⁫‬⁯‮‮(string[] strArrays)
		{
			return string.Concat(strArrays);
		}

		// ‌⁬‫‭‌⁮⁫⁬⁭‍⁪‎‌‮⁯‏​⁭​‍‭‌‭‪⁬​‮‌‏‪​‫‏‪​‫‪⁪⁮⁭‮
		// privatescope
		internal static DialogResult u200c⁬‫‭‌⁮⁫⁬⁭‍⁪‎‌‮⁯‏​⁭​‍‭‌‭‪⁬​‮‌‏‪​‫‏‪​‫‪⁪⁮⁭‮(string str)
		{
			return MessageBox.Show(str);
		}

		// ⁮‌‪‎‍‬⁪‪‍‎‎⁪‌⁪‌‎⁪‮⁮⁯‮‌⁬​‪‌⁭‏‪‭‪‎⁬‮‪⁪‏⁬⁬‭‮
		// privatescope
		internal static string u206e‌‪‎‍‬⁪‪‍‎‎⁪‌⁪‌‎⁪‮⁮⁯‮‌⁬​‪‌⁭‏‪‭‪‎⁬‮‪⁪‏⁬⁬‭‮(string str, string str, string str)
		{
			return string.Concat(str, str, str);
		}

		// ‫⁭⁯⁪‎⁪‮⁮⁭⁬⁯⁭‎‬‎⁪‏‫⁮⁪‌⁯‍⁭‮⁯‏‎‪‪⁫⁯⁯‍⁯‪‫‌‫‎‮
		// privatescope
		internal static Thread u202b⁭⁯⁪‎⁪‮⁮⁭⁬⁯⁭‎‬‎⁪‏‫⁮⁪‌⁯‍⁭‮⁯‏‎‪‪⁫⁯⁯‍⁯‪‫‌‫‎‮(ThreadStart threadStart)
		{
			return new Thread(threadStart);
		}

		// ‎‮⁬‬⁯⁯‭‍⁪‫‫‍⁭⁬‌‫‏⁫⁬‭‌⁮‬‬‎⁫‍‬⁮⁬⁮‬‍‌⁮‬⁬⁪⁪‍‮
		// privatescope
		internal static void u200e‮⁬‬⁯⁯‭‍⁪‫‫‍⁭⁬‌‫‏⁫⁬‭‌⁮‬‬‎⁫‍‬⁮⁬⁮‬‍‌⁮‬⁬⁪⁪‍‮(Thread thread)
		{
			thread.Start();
		}

		// ‫⁫‎‮​‎‌⁭⁭‎⁭​‎⁯‬⁭‭⁪‫‬⁬‫‭⁪‌‫⁪⁬⁭‏⁪‏‏‌‌‍⁬‎‏‭‮
		// privatescope
		internal static bool u202b⁫‎‮​‎‌⁭⁭‎⁭​‎⁯‬⁭‭⁪‫‬⁬‫‭⁪‌‫⁪⁬⁭‏⁪‏‏‌‌‍⁬‎‏‭‮(Thread thread, int num)
		{
			return thread.Join(num);
		}

		// ⁫‍⁮⁬⁬‍⁪‭⁯‍‬‌‏‏⁪⁯⁪‍‮⁬‮‏‬⁬‍‬‎‪⁯⁭⁬⁮⁯⁪‬‭⁪‌⁬⁬‮
		// privatescope
		internal static void u206b‍⁮⁬⁬‍⁪‭⁯‍‬‌‏‏⁪⁯⁪‍‮⁬‮‏‬⁬‍‬‎‪⁯⁭⁬⁮⁯⁪‬‭⁪‌⁬⁬‮(CancelEventArgs cancelEventArg, bool flag)
		{
			cancelEventArg.Cancel = flag;
		}

		// ‏‍‌‍‮‎⁯​‬⁯⁭‏⁬⁫‮‌‎‎‎⁭‍‎⁭‎‫​‮‫‭‫⁬‫​‫‪⁯‌‌‌‫‮
		// privatescope
		internal static Type u200f‍‌‍‮‎⁯​‬⁯⁭‏⁬⁫‮‌‎‎‎⁭‍‎⁭‎‫​‮‫‭‫⁬‫​‫‪⁯‌‌‌‫‮(ISharpControl sharpControl)
		{
			return sharpControl.get_SourceType();
		}

		// ​‮⁬⁭⁯⁪⁮‎‌‬‮‫‭⁫⁯⁫‌⁪‬⁭​‍‮⁯⁫⁪‫‎‭‍‏‮⁯‏⁯‎‎‮‮⁯‮
		// privatescope
		internal static bool u200b‮⁬⁭⁯⁪⁮‎‌‬‮‫‭⁫⁯⁫‌⁪‬⁭​‍‮⁯⁫⁪‫‎‭‍‏‮⁯‏⁯‎‎‮‮⁯‮(Type type, Type type)
		{
			return type != type;
		}

		// ⁪‭‏‪⁬‍‮‪⁮‎⁪⁭​‪‫‭‮‏‪‬​⁫‫⁬‫⁯‎⁪‬‭⁯‍‬‎‍‎‫‎‎⁭‮
		// privatescope
		internal static string u206a‭‏‪⁬‍‮‪⁮‎⁪⁭​‪‫‭‮‏‪‬​⁫‫⁬‫⁯‎⁪‬‭⁯‍‬‎‍‎‫‎‎⁭‮(MemberInfo memberInfo)
		{
			return memberInfo.Name;
		}

		// ‪⁮​‮‌‪‏⁭‪‪⁮⁫‌‏‎‬‫‍⁫⁯‭‎⁪‫⁭‌⁭⁯‎​⁮⁮⁪‌‭‬⁭⁭⁮⁪‮
		// privatescope
		internal static decimal u202a⁮​‮‌‪‏⁭‪‪⁮⁫‌‏‎‬‫‍⁫⁯‭‎⁪‫⁭‌⁭⁯‎​⁮⁮⁪‌‭‬⁭⁭⁮⁪‮(NumericUpDown numericUpDown)
		{
			return numericUpDown.Value;
		}

		// ‌⁭⁬‪‎‍⁬‭⁮​⁬⁪⁭‪‭‮‫‏‮‫‏⁪⁬⁫​‍⁫⁮‬⁭⁬‭⁯⁮‎⁪‫⁫‬‏‮
		// privatescope
		internal static bool u200c⁭⁬‪‎‍⁬‭⁮​⁬⁪⁭‪‭‮‫‏‮‫‏⁪⁬⁫​‍⁫⁮‬⁭⁬‭⁯⁮‎⁪‫⁫‬‏‮(CheckBox checkBox)
		{
			return checkBox.Checked;
		}

		// ‮⁬‏‌‍⁬‍‍⁪​‌⁬⁫‮‭⁬⁫⁮‪​‮⁯‫‪⁭​⁬‮‫‪‭‭⁪⁬‮⁭⁮⁭⁭‎‮
		// privatescope
		internal static string u202e⁬‏‌‍⁬‍‍⁪​‌⁬⁫‮‭⁬⁫⁮‪​‮⁯‫‪⁭​⁬‮‫‪‭‭⁪⁬‮⁭⁮⁭⁭‎‮(PropertyChangedEventArgs propertyChangedEventArg)
		{
			return propertyChangedEventArg.PropertyName;
		}

		// ⁮‮‭‪‫⁪‪‎⁬⁮⁭‫⁫⁪‍⁭⁪⁭⁭‮‌‏‮‍⁭⁫‍⁫⁮‌⁪⁯⁪⁮‎⁮‭⁫⁯‏‮
		// privatescope
		internal static bool u206e‮‭‪‫⁪‪‎⁬⁮⁭‫⁫⁪‍⁭⁪⁭⁭‮‌‏‮‍⁭⁫‍⁫⁮‌⁪⁯⁪⁮‎⁮‭⁫⁯‏‮(ISharpControl sharpControl)
		{
			return sharpControl.get_SourceIsTunable();
		}

		// ‪⁫‬‎⁯‌⁪‬‏⁯​‎‎‬⁬⁫⁭⁭‏⁮⁬‎‏⁬‮‭‎‫‬‏⁬‮‬⁭‪‍‭‏‫‬‮
		// privatescope
		internal static long u202a⁫‬‎⁯‌⁪‬‏⁯​‎‎‬⁬⁫⁭⁭‏⁮⁬‎‏⁬‮‭‎‫‬‏⁬‮‬⁭‪‍‭‏‫‬‮(ISharpControl sharpControl)
		{
			return sharpControl.get_Frequency();
		}

		// ‌⁪‭‌‏⁯​⁯⁭⁮‫‫​⁭‏⁭⁮‍⁮⁯‭‪‭⁯‍⁪⁬⁯⁭⁭‫‮⁫​⁪‪‫‮‌⁬‮
		// privatescope
		internal static double u200c⁪‭‌‏⁯​⁯⁭⁮‫‫​⁭‏⁭⁮‍⁮⁯‭‪‭⁯‍⁪⁬⁯⁭⁭‫‮⁫​⁪‪‫‮‌⁬‮(double num)
		{
			return Math.Round(num);
		}

		// ⁯​‍‮‎‬⁯‮⁬‍‬⁯⁫‪⁯‏⁭⁫⁮‪‬‭⁪​⁭​‬‎‏‮‏⁯‍‏⁭‍‎⁫⁪‏‮
		// privatescope
		internal static void u206f​‍‮‎‬⁯‮⁬‍‬⁯⁫‪⁯‏⁭⁫⁮‪‬‭⁪​⁭​‬‎‏‮‏⁯‍‏⁭‍‎⁫⁪‏‮(Thread thread, string str)
		{
			thread.Name = str;
		}

		// ​‏‌‬⁫‎⁫⁮‮​‌⁪‮⁪⁬‏‮‌⁬⁪⁪⁪⁬⁪‎⁪⁯⁮⁬⁭‫‍⁪‭‏‬⁫‍⁯‮‮
		// privatescope
		internal static void u200b‏‌‬⁫‎⁫⁮‮​‌⁪‮⁪⁬‏‮‌⁬⁪⁪⁪⁬⁪‎⁪⁯⁮⁬⁭‫‍⁪‭‏‬⁫‍⁯‮‮(Thread thread, ThreadPriority threadPriority)
		{
			thread.Priority = threadPriority;
		}

		// ⁬‭‬⁯⁬⁭‫‎⁬​‫‪⁫‏⁭‫‮⁮⁮‍‮‪‮‎‪‬‏‌‬​​‍‪‫‫‍​‍⁯‪‮
		// privatescope
		internal static void u206c‭‬⁯⁬⁭‫‎⁬​‫‪⁫‏⁭‫‮⁮⁮‍‮‪‮‎‪‬‏‌‬​​‍‪‫‫‍​‍⁯‪‮(Thread thread)
		{
			thread.Join();
		}

		// ‪⁫‭⁮⁫‍‏‬‮⁭‏‭‎⁪⁫‬‍⁯⁯‫‌⁪‪​‏‪⁫⁯‮⁭‬⁯⁭​‎‬‏⁯⁪‍‮
		// privatescope
		internal static CultureInfo u202a⁫‭⁮⁫‍‏‬‮⁭‏‭‎⁪⁫‬‍⁯⁯‫‌⁪‪​‏‪⁫⁯‮⁭‬⁯⁭​‎‬‏⁯⁪‍‮()
		{
			return CultureInfo.CurrentCulture;
		}

		// ⁪‫⁬‫⁭‮⁯⁮⁭⁯⁭‫⁯​‌⁪⁯⁬‎⁮‭‬‮‫⁯‍‭‪‎‍​‍⁪‌‌⁪‬‪‍‫‮
		// privatescope
		internal static string u206a‫⁬‫⁭‮⁯⁮⁭⁯⁭‫⁯​‌⁪⁯⁬‎⁮‭‬‮‫⁯‍‭‪‎‍​‍⁪‌‌⁪‬‪‍‫‮(CultureInfo cultureInfo)
		{
			return cultureInfo.Name;
		}

		// ⁭​‌‫‍‫‬‌‮⁭⁬⁫⁯‎‬‭⁭​⁭⁭‫⁮‌‍‍‪⁯⁮‮‫⁭⁭‏‭‪⁭‪⁯⁮‪‮
		// privatescope
		internal static DialogResult u206d​‌‫‍‫‬‌‮⁭⁬⁫⁯‎‬‭⁭​⁭⁭‫⁮‌‍‍‪⁯⁮‮‫⁭⁭‏‭‪⁭‪⁯⁮‪‮(string str, string str, MessageBoxButtons messageBoxButton, MessageBoxIcon messageBoxIcon)
		{
			return MessageBox.Show(str, str, messageBoxButton, messageBoxIcon);
		}

		// ‏‎​⁮‎‮‮‍⁮‍⁫​​⁭⁭⁭‍⁯‪‏‏‏‌⁯‎⁮‬‪‬‪‭⁪‪⁫‍⁭⁪⁯‎‬‮
		// privatescope
		internal static ComplexFifoStream u200f‎​⁮‎‮‮‍⁮‍⁫​​⁭⁭⁭‍⁯‪‏‏‏‌⁯‎⁮‬‪‬‪‭⁪‪⁫‍⁭⁪⁯‎‬‮(BlockMode blockMode)
		{
			return new ComplexFifoStream(blockMode);
		}

		// ‮⁯‬‬‬‎​‍⁯‎⁯⁪⁯​‌‮‌​​‭‫⁭‏​‫⁫⁯⁫‮‬​‏‮⁪‫⁪‌⁯‏‮‮
		// privatescope
		internal static int u202e⁯‬‬‬‎​‍⁯‎⁯⁪⁯​‌‮‌​​‭‫⁭‏​‫⁫⁯⁫‮‬​‏‮⁪‫⁪‌⁯‏‮‮(ComplexFifoStream complexFifoStream)
		{
			return complexFifoStream.get_Length();
		}

		// ‏⁫⁯‏⁮​‌‍‏‮⁫‌​‍⁯⁪⁮⁫‮⁭‭‮‮⁭‮‭‬⁮‌⁪‍⁪‍⁯‌​⁯‪‫⁯‮
		// privatescope
		internal static unsafe void u200f⁫⁯‏⁮​‌‍‏‮⁫‌​‍⁯⁪⁮⁫‮⁭‭‮‮⁭‮‭‬⁮‌⁪‍⁪‍⁯‌​⁯‪‫⁯‮(ComplexFifoStream complexFifoStream, Complex* complexPointer, int num)
		{
			complexFifoStream.Write(complexPointer, num);
		}

		// ⁭‎⁯⁫⁭​⁮‏‬⁭‭⁮⁮⁪‬‪‬‍⁭‫⁬‫‎‏‫‪⁬​⁮⁪‍‭‌⁮⁭‏‫‬⁪‮‮
		// privatescope
		internal static float u206d‎⁯⁫⁭​⁮‏‬⁭‭⁮⁮⁪‬‪‬‍⁭‫⁬‫‎‏‫‪⁬​⁮⁪‍‭‌⁮⁭‏‫‬⁪‮‮(float single)
		{
			return Math.Abs(single);
		}

		// ⁪‭⁬⁭⁮‎‎⁮⁪⁮‌⁫‫⁫​‪‪⁭⁭⁯‫⁯‏⁬⁬‌⁫⁮⁯‫‪⁪⁮‎⁮‏⁮⁪⁭‍‮
		// privatescope
		internal static void u206a‭⁬⁭⁮‎‎⁮⁪⁮‌⁫‫⁫​‪‪⁭⁭⁯‫⁯‏⁬⁬‌⁫⁮⁯‫‪⁪⁮‎⁮‏⁮⁪⁭‍‮(ISharpControl sharpControl, bool flag)
		{
			sharpControl.set_AudioIsMuted(flag);
		}

		// ‏​⁪‪⁫‭⁮⁪⁮‎⁪‎⁪⁭‍⁪‌‍‎‏‍‫⁮⁯‭‭⁮⁯‪⁯‫⁬‍‍⁮‪‬‭‮⁫‮
		// privatescope
		internal static void u200f​⁪‪⁫‭⁮⁪⁮‎⁪‎⁪⁭‍⁪‌‍‎‏‍‫⁮⁯‭‭⁮⁯‪⁯‫⁬‍‍⁮‪‬‭‮⁫‮(int num)
		{
			Thread.Sleep(num);
		}

		// ‫‬⁭⁫‍⁬⁯⁪⁭⁫‮‏⁭‭‌‪⁭⁮‌‌⁫‎‫⁮‮‏​‬‭‌⁪⁫⁪⁬‮‬⁫‪⁯⁭‮
		// privatescope
		internal static unsafe int u202b‬⁭⁫‍⁬⁯⁪⁭⁫‮‏⁭‭‌‪⁭⁮‌‌⁫‎‫⁮‮‏​‬‭‌⁪⁫⁪⁬‮‬⁫‪⁯⁭‮(ComplexFifoStream complexFifoStream, Complex* complexPointer, int num)
		{
			return complexFifoStream.Read(complexPointer, num);
		}

		// ‭‫⁬⁮‏‬‪⁯‍​‪⁯‪⁪⁯‫‮⁭⁫​⁬⁪‭‭‫⁭⁯‭‭‏‏‎‮⁫⁬⁫⁯‮​⁯‮
		// privatescope
		internal static int u202d‫⁬⁮‏‬‪⁯‍​‪⁯‪⁪⁯‫‮⁭⁫​⁬⁪‭‭‫⁭⁯‭‭‏‏‎‮⁫⁬⁫⁯‮​⁯‮(FloatFifoStream floatFifoStream)
		{
			return floatFifoStream.get_Length();
		}

		// ‍‌​⁮‭‬‮‬⁭⁬‮⁭‬‭⁪‮‭‎⁮⁭⁮⁭‬⁬‬⁭‬⁭‌⁬‍‏⁮⁯‌⁭​‫⁮⁪‮
		// privatescope
		internal static unsafe void u200d‌​⁮‭‬‮‬⁭⁬‮⁭‬‭⁪‮‭‎⁮⁭⁮⁭‬⁬‬⁭‬⁭‌⁬‍‏⁮⁯‌⁭​‫⁮⁪‮(FloatFifoStream floatFifoStream, float* singlePointer, int num)
		{
			floatFifoStream.Write(singlePointer, num);
		}

		// ​⁭‪⁬‎‏⁫​‎‏⁫⁬⁭‪⁪‮​⁫‭⁯‮⁫‫‬⁭⁫‪‌⁫⁪⁭‪⁯⁯‏⁫‬‎⁮⁯‮
		// privatescope
		internal static void u200b⁭‪⁬‎‏⁫​‎‏⁫⁬⁭‪⁪‮​⁫‭⁯‮⁫‫‬⁭⁫‪‌⁫⁪⁭‪⁯⁯‏⁫‬‎⁮⁯‮(UnsafeBuffer unsafeBuffer)
		{
			unsafeBuffer.Dispose();
		}

		// ‪‏‌⁫⁯⁯‮⁪⁬‍‭‌⁬⁬‏⁯‏⁫‪‬‭‭‌⁬⁭⁮‮⁭⁯‌⁯‫‪‪‎‎​​⁬‫‮
		// privatescope
		internal static DialogResult u202a‏‌⁫⁯⁯‮⁪⁬‍‭‌⁬⁬‏⁯‏⁫‪‬‭‭‌⁬⁭⁮‮⁭⁯‌⁯‫‪‪‎‎​​⁬‫‮(string str, string str)
		{
			return MessageBox.Show(str, str);
		}

		// ‬‍⁮‭⁭‏⁮‎⁯​‍⁯⁯‪‏‏‫‎‌‎‮‍⁬‫⁫‫‬‮‪⁯⁪‬‭​‏⁫‍‪​‬‮
		// privatescope
		internal static int u202c‍⁮‭⁭‏⁮‎⁯​‍⁯⁯‪‏‏‫‎‌‎‮‍⁬‫⁫‫‬‮‪⁯⁪‬‭​‏⁫‍‪​‬‮(UnsafeBuffer unsafeBuffer)
		{
			return unsafeBuffer.get_Length();
		}

		// ‪‬‫‫‬‎‌‎‮‏​‫‎‏⁯⁪‎‪⁪‫‬⁫​‍‏‮⁫‎⁬‬‭⁯‍‌‏‏‪⁪‫‪‮
		// privatescope
		internal static unsafe int u202a‬‫‫‬‎‌‎‮‏​‫‎‏⁯⁪‎‪⁪‫‬⁫​‍‏‮⁫‎⁬‬‭⁯‍‌‏‏‪⁪‫‪‮(FloatFifoStream floatFifoStream, float* singlePointer, int num)
		{
			return floatFifoStream.Read(singlePointer, num);
		}

		// ‮‎‍‌⁮‫‏⁯‎⁭⁮‌‏⁮⁯‭⁫‍‬‮‍⁭‍⁭‍⁭‪⁪⁮⁮⁬⁭‭​​‬‪⁪‌‎‮
		// privatescope
		internal static Resampler u202e‎‍‌⁮‫‏⁯‎⁭⁮‌‏⁮⁯‭⁫‍‬‮‍⁭‍⁭‍⁭‪⁪⁮⁮⁬⁭‭​​‬‪⁪‌‎‮(double num, double num, int num, double num)
		{
			return new Resampler(num, num, num, num);
		}

		// ‮‮‍⁬‬‎⁪⁮⁮‮‎‍⁮​​⁫​​⁯​⁫‌⁯‭⁪⁯‎‌‫⁮⁬‪⁪‍‮⁯‫⁫⁭‭‮
		// privatescope
		internal static void u202e‮‍⁬‬‎⁪⁮⁮‮‎‍⁮​​⁫​​⁯​⁫‌⁯‭⁪⁯‎‌‫⁮⁬‪⁪‍‮⁯‫⁫⁭‭‮(FirFilter firFilter)
		{
			firFilter.Dispose();
		}

		// ⁪‎⁯‬‌⁫⁭⁮‪​‪⁯‬‎​‮⁬⁫⁪⁬⁭‍⁮⁪⁬⁭‮‪‪‪‌‬⁬‮‬‮⁪‭‪⁮‮
		// privatescope
		internal static float[] u206a‎⁯‬‌⁫⁭⁮‪​‪⁯‬‎​‮⁬⁫⁪⁬⁭‍⁮⁪⁬⁭‮‪‪‪‌‬⁬‮‬‮⁪‭‪⁮‮(double num, int num, double num, double num, WindowType windowType)
		{
			return FilterBuilder.MakeBandPassKernel(num, num, num, num, windowType);
		}

		// ⁫‪‪‪‍‎‫⁫⁯⁯⁭⁯‬​⁫‮‫⁮⁭⁭‪‮‍‎‪‌⁭‭‎​⁮‎‌‌⁫⁮‭​⁪‍‮
		// privatescope
		internal static FirFilter u206b‪‪‪‍‎‫⁫⁯⁯⁭⁯‬​⁫‮‫⁮⁭⁭‪‮‍‎‪‌⁭‭‎​⁮‎‌‌⁫⁮‭​⁪‍‮(float[] singleArray, int num)
		{
			return new FirFilter(singleArray, num);
		}

		// ⁬⁮⁪‭‭⁮⁪⁭‮⁮⁯‍‪⁭‫‮‎‎​‎​⁭⁭⁪⁯‏‏‬‬‌‭⁬‮‏‎‬‪⁫‪⁬‮
		// privatescope
		internal static AutomaticGainControl u206c⁮⁪‭‭⁮⁪⁭‮⁮⁯‍‪⁭‫‮‎‎​‎​⁭⁭⁪⁯‏‏‬‬‌‭⁬‮‏‎‬‪⁫‪⁬‮()
		{
			return new AutomaticGainControl();
		}

		// ‌​‮‫⁭‪‭⁬‭⁪‎⁭⁪‫⁯‫‏‌⁫⁯‭‍⁪‭⁪⁪‍⁫⁫⁯⁬‭​⁭⁪⁪‎‬‫⁭‮
		// privatescope
		internal static void u200c​‮‫⁭‪‭⁬‭⁪‎⁭⁪‫⁯‫‏‌⁫⁯‭‍⁪‭⁪⁪‍⁫⁫⁯⁬‭​⁭⁪⁪‎‬‫⁭‮(AutomaticGainControl automaticGainControl, double num)
		{
			automaticGainControl.set_SampleRate(num);
		}

		// ‍‪‮‌‮⁯‏⁫⁮⁭⁭⁯‮‏⁬‭‫‪⁯⁮⁮‌‬‮‪‪‎⁬‍‮​⁬‍⁬‪‮‭‫‌⁫‮
		// privatescope
		internal static void u200d‪‮‌‮⁯‏⁫⁮⁭⁭⁯‮‏⁬‭‫‪⁯⁮⁮‌‬‮‪‪‎⁬‍‮​⁬‍⁬‪‮‭‫‌⁫‮(AutomaticGainControl automaticGainControl, bool flag)
		{
			automaticGainControl.set_UseHang(flag);
		}

		// ⁮‌​⁪⁮‬⁭⁭‮‫‎⁫⁭‍‏⁭‎‫‮‍‫‫​⁮‎‭‮⁫⁪‍⁬‍⁬‮‮‍‍‭‫‮‮
		// privatescope
		internal static void u206e‌​⁪⁮‬⁭⁭‮‫‎⁫⁭‍‏⁭‎‫‮‍‫‫​⁮‎‭‮⁫⁪‍⁬‍⁬‮‮‍‍‭‫‮‮(AutomaticGainControl automaticGainControl, float single)
		{
			automaticGainControl.set_Threshold(single);
		}

		// ‍⁫‌‬⁪‫‬‎⁯⁮⁯‪‏⁫‪‮⁯‮⁪‬‪⁭‌⁭‮⁯‫​‬‬‮‌⁪‬⁮‪⁯‭‎‏‮
		// privatescope
		internal static void u200d⁫‌‬⁪‫‬‎⁯⁮⁯‪‏⁫‪‮⁯‮⁪‬‪⁭‌⁭‮⁯‫​‬‬‮‌⁪‬⁮‪⁯‭‎‏‮(AutomaticGainControl automaticGainControl, float single)
		{
			automaticGainControl.set_Slope(single);
		}

		// ‌⁫⁬⁭‍⁮‏‏⁫‏‌‬⁯‮⁫‍⁯‬‪‬⁯⁮⁯‍‎‪⁭‭‍⁬⁭⁯⁪⁬‬‍⁭⁮‬‮‮
		// privatescope
		internal static void u200c⁫⁬⁭‍⁮‏‏⁫‏‌‬⁯‮⁫‍⁯‬‪‬⁯⁮⁯‍‎‪⁭‭‍⁬⁭⁯⁪⁬‬‍⁭⁮‬‮‮(AutomaticGainControl automaticGainControl, float single)
		{
			automaticGainControl.set_Decay(single);
		}

		// ⁯⁭‌⁯⁬‌‎⁪​⁯​⁬⁭‭‭‪⁭‫‫‫‏‭‎⁪‎‮⁬‮⁫‌‪‎⁮⁬⁪‪⁬‫⁪⁪‮
		// privatescope
		internal static unsafe void u206f⁭‌⁯⁬‌‎⁪​⁯​⁬⁭‭‭‪⁭‫‫‫‏‭‎⁪‎‮⁬‮⁫‌‪‎⁮⁬⁪‪⁬‫⁪⁪‮(AutomaticGainControl automaticGainControl, float* singlePointer, int num)
		{
			automaticGainControl.Process(singlePointer, num);
		}

		// ​⁫​‎⁬‌‮⁮⁯‭‏‭‎​⁭‎⁬⁪⁭​‍⁭⁭⁪⁮‪⁯⁯‏‏‪⁮‪‍⁮‌‏‭‍⁮‮
		// privatescope
		internal static unsafe int u200b⁫​‎⁬‌‮⁮⁯‭‏‭‎​⁭‎⁬⁪⁭​‍⁭⁭⁪⁮‪⁯⁯‏‏‪⁮‪‍⁮‌‏‭‍⁮‮(FirFilter firFilter, float* singlePointer, int num)
		{
			return firFilter.Process(singlePointer, num);
		}

		// ⁫‫‍‭‏⁬⁭​​⁫​‏⁮⁬⁯‭‬‮‎‭‫‎​⁯‍‪⁯⁯‏‏‌‬‬⁯‭‪‬‭⁭‏‮
		// privatescope
		internal static unsafe void* u206b‫‍‭‏⁬⁭​​⁫​‏⁮⁬⁯‭‬‮‎‭‫‎​⁯‍‪⁯⁯‏‏‌‬‬⁯‭‪‬‭⁭‏‮(void* voidPointer, void* voidPointer, int num)
		{
			return Utils.Memcpy(voidPointer, voidPointer, num);
		}

		// ⁬⁫⁭‪‍‪‮‫‍‪‏‍⁬‫‏‪​‪‪‏‫⁬⁯‭‫​⁮⁫⁪‭‫​⁪‎⁯⁭⁪⁭⁪⁯‮
		// privatescope
		internal static unsafe int u206c⁫⁭‪‍‪‮‫‍‪‏‍⁬‫‏‪​‪‪‏‫⁬⁯‭‫​⁮⁫⁪‭‫​⁪‎⁯⁭⁪⁭⁪⁯‮(Resampler resampler, float* singlePointer, float* singlePointer, int num)
		{
			return resampler.Process(singlePointer, singlePointer, num);
		}

		// ‪‭⁭⁭‭⁮‫‫⁪‍⁫​⁭⁫‪‌⁫​⁭‪‭​‮‮‏‮​‌⁪‍‪⁪⁭‏‏⁭‫‎⁯‏‮
		// privatescope
		internal static StringBuilder u202a‭⁭⁭‭⁮‫‫⁪‍⁫​⁭⁫‪‌⁫​⁭‪‭​‮‮‏‮​‌⁪‍‪⁪⁭‏‏⁭‫‎⁯‏‮()
		{
			return new StringBuilder();
		}

		// ‮‌‬⁮‏​‭​‪‪​‍‮‮‪‍‬‬​⁫‫⁯⁬⁯⁬‍‏‬‬‪‎⁫⁯⁬⁮⁭⁫‮​‌‮
		// privatescope
		internal static StringBuilder u202e‌‬⁮‏​‭​‪‪​‍‮‮‪‍‬‬​⁫‫⁯⁬⁯⁬‍‏‬‬‪‎⁫⁯⁬⁮⁭⁫‮​‌‮(StringBuilder stringBuilder, string str, object obj, object obj, object obj)
		{
			return stringBuilder.AppendFormat(str, obj, obj, obj);
		}

		// ⁪‎‭‪‍‌​‪⁫⁪‭‮​‌⁫‭⁫⁮⁬⁯‬‪‎⁫​‏‏‌⁪‪​⁯‬​⁮⁪⁮‏‭⁭‮
		// privatescope
		internal static string u206a‎‭‪‍‌​‪⁫⁪‭‮​‌⁫‭⁫⁮⁬⁯‬‪‎⁫​‏‏‌⁪‪​⁯‬​⁮⁪⁮‏‭⁭‮(string str, char[] chrArray)
		{
			return str.TrimEnd(chrArray);
		}

		// ‪‬⁪‬⁫‎‌⁯‪‫⁮⁪‫⁮‏⁫‭‎⁭​⁮⁪⁪‪⁪⁬‎⁭‎⁭⁭‮‮‍‮⁮⁫⁮‭⁮‮
		// privatescope
		internal static void u202a‬⁪‬⁫‎‌⁯‪‫⁮⁪‫⁮‏⁫‭‎⁭​⁮⁪⁪‪⁪⁬‎⁭‎⁭⁭‮‮‍‮⁮⁫⁮‭⁮‮(ISharpControl sharpControl, long num)
		{
			sharpControl.set_Frequency(num);
		}

		// ‏‌⁮⁪‬‬‎‫⁯⁬⁬⁮‮‭​‬‍⁯⁫‮⁫⁫‏‌‮⁭​‬‮‎‌⁯⁬⁪‮⁯​⁬‬‬‮
		// privatescope
		internal static void u200f‌⁮⁪‬‬‎‫⁯⁬⁬⁮‮‭​‬‍⁯⁫‮⁫⁫‏‌‮⁭​‬‮‎‌⁯⁬⁪‮⁯​⁬‬‬‮(Control control)
		{
			control.Refresh();
		}

		// ‬‫‮⁯⁯​⁮‌‪⁫‫⁪⁭‍‎‮‭⁮‍‬​⁪‌‏⁪‏‪⁮⁫‏⁮⁭⁫‎⁪‫⁫⁯‏‬‮
		// privatescope
		internal static string u202c‫‮⁯⁯​⁮‌‪⁫‫⁪⁭‍‎‮‭⁮‍‬​⁪‌‏⁪‏‪⁮⁫‏⁮⁭⁫‎⁪‫⁫⁯‏‬‮(string str, object obj)
		{
			return string.Format(str, obj);
		}

		// ⁫⁫⁯⁮‬⁪‮‌‍‬‪⁯⁫‪⁬⁫⁭⁬⁬‮⁭⁪⁫‏⁮‍‏⁪‫‬‫​⁪⁬‭⁯‍‫‬‫‮
		// privatescope
		internal static void u206b⁫⁯⁮‬⁪‮‌‍‬‪⁯⁫‪⁬⁫⁭⁬⁬‮⁭⁪⁫‏⁮‍‏⁪‫‬‫​⁪⁬‭⁯‍‫‬‫‮(TextBoxBase textBoxBase)
		{
			textBoxBase.Clear();
		}

		// ⁬‬‍⁪‎‮⁫‪⁫‏⁭⁯⁮‬‪‬‎⁬‏‮‮‪‬⁮‫⁬‌‎⁯‭‪‪​⁬‬‮‎‪⁪‌‮
		// privatescope
		internal static int u206c‬‍⁪‎‮⁫‪⁫‏⁭⁯⁮‬‪‬‎⁬‏‮‮‪‬⁮‫⁬‌‎⁯‭‪‪​⁬‬‮‎‪⁪‌‮(ISharpControl sharpControl)
		{
			return sharpControl.get_AudioGain();
		}

		// ‭⁪⁬‪‍⁪‪⁮‭⁮‎‭⁬‍‪‬‮⁭⁮‪⁫⁯‮‪‫‏‎​‬‍‫⁯‭‪⁫‭‮‏​⁯‮
		// privatescope
		internal static void u202d⁪⁬‪‍⁪‪⁮‭⁮‎‭⁬‍‪‬‮⁭⁮‪⁫⁯‮‪‫‏‎​‬‍‫⁯‭‪⁫‭‮‏​⁯‮(ISharpControl sharpControl, int num)
		{
			sharpControl.set_AudioGain(num);
		}

		// ⁫​⁭⁪‮‭‍​‎⁭⁪‮⁭‌‭‍‬‏⁪​​​‍⁫‎‫⁮⁪​​‏‫⁪⁮⁬‬‬​‮‬‮
		// privatescope
		internal static string u206b​⁭⁪‮‭‍​‎⁭⁪‮⁭‌‭‍‬‏⁪​​​‍⁫‎‫⁮⁪​​‏‫⁪⁮⁬‬‬​‮‬‮(string str, string str, string str, string str)
		{
			return string.Concat(str, str, str, str);
		}

		// ‌⁫‎‍​‭‮‪⁪⁪‬‭⁮‍⁭​⁯‫‪‏‫‭​‌⁭⁭⁬⁯⁯⁭‍⁪‬‎‭⁭‭⁪⁫‪‮
		// privatescope
		internal static bool u200c⁫‎‍​‭‮‪⁪⁪‬‭⁮‍⁭​⁯‫‪‏‫‭​‌⁭⁭⁬⁯⁯⁭‍⁪‬‎‭⁭‭⁪⁫‪‮(Form form)
		{
			return form.TopMost;
		}

		// ‏‏⁫​‪‌⁮‫​‍‏‍⁭​‬⁯⁬‬‌⁯‍⁫‮‮‍‬⁫⁭‏⁭‏‍⁭⁮​⁪⁬⁫⁭‭‮
		// privatescope
		internal static bool u200f‏⁫​‪‌⁮‫​‍‏‍⁭​‬⁯⁬‬‌⁯‍⁫‮‮‍‬⁫⁭‏⁭‏‍⁭⁮​⁪⁬⁫⁭‭‮(Control control)
		{
			return control.Visible;
		}

		// ​⁮⁭⁪⁬‬⁭‎⁮‫⁫‌‫‭‎‎‎‬‍‮‍‎​‬‫⁭⁮⁫⁬‭‫⁭​‌⁮‫⁬‫‫⁬‮
		// privatescope
		internal static void u200b⁮⁭⁪⁬‬⁭‎⁮‫⁫‌‫‭‎‎‎‬‍‮‍‎​‬‫⁭⁮⁫⁬‭‫⁭​‌⁮‫⁬‫‫⁬‮(Form form, bool flag)
		{
			form.TopMost = flag;
		}

		// ⁫⁯⁯‮‌‏⁬⁫​‮‎⁬⁭‭‪‬‍‍⁭⁯‭⁬‍⁮​⁪⁮⁫‎‎‌‌‌​⁪‬‪‏‎‭‮
		// privatescope
		internal static void u206b⁯⁯‮‌‏⁬⁫​‮‎⁬⁭‭‪‬‍‍⁭⁯‭⁬‍⁮​⁪⁮⁫‎‎‌‌‌​⁪‬‪‏‎‭‮(Control control)
		{
			control.Show();
		}

		// ⁭⁮​‪‫‫⁫⁯⁭⁮⁪‬‏‍​‬‍‌⁫⁬‮‍‮⁮⁬‏‭⁯⁫‍‮‬​‏⁪⁬‌⁮‬‎‮
		// privatescope
		internal static void u206d⁮​‪‫‫⁫⁯⁭⁮⁪‬‏‍​‬‍‌⁫⁬‮‍‮⁮⁬‏‭⁯⁫‍‮‬​‏⁪⁬‌⁮‬‎‮(Form form, FormStartPosition formStartPosition)
		{
			form.StartPosition = formStartPosition;
		}

		// ⁮‬‪‎‎‬⁭⁬‌⁭‪⁬‌‮‏​‏⁮⁮‫⁮‬⁯⁬‮⁮‬⁭‫‪‍​⁭‎⁪‮⁪⁯‍⁫‮
		// privatescope
		internal static DialogResult u206e‬‪‎‎‬⁭⁬‌⁭‪⁬‌‮‏​‏⁮⁮‫⁮‬⁯⁬‮⁮‬⁭‫‪‍​⁭‎⁪‮⁪⁯‍⁫‮(Form form)
		{
			return form.ShowDialog();
		}

		// ‫​⁬‎⁮‫​‬‬‌‍⁬⁮‬‭‪‭‭‫⁯‌​⁮‮‬‍‭⁫‏‬⁮‫‍‫‫‬‪⁪‬‍‮
		// privatescope
		internal static bool u202b​⁬‎⁮‫​‬‬‌‍⁬⁮‬‭‪‭‭‫⁯‌​⁮‮‬‍‭⁫‏‬⁮‫‍‫‫‬‪⁪‬‍‮(string str, string str)
		{
			return str.EndsWith(str);
		}

		// ⁬‌‬‮‫‬⁮‎⁫⁯‪⁪⁬⁬‏‬‌⁮⁮‪‭⁭⁮⁫‮‎​‫⁮​⁯‍‪⁪‭‭⁪‭‏⁭‮
		// privatescope
		internal static int u206c‌‬‮‫‬⁮‎⁫⁯‪⁪⁬⁬‏‬‌⁮⁮‪‭⁭⁮⁫‮‎​‫⁮​⁯‍‪⁪‭‭⁪‭‏⁭‮(string str)
		{
			return str.Length;
		}

		// ⁫‪‪​⁫‪‭⁬‬‍⁭‏‮‍⁬​⁪⁮‫‬‍‮‌⁯‮‌⁪⁯⁮⁬‫‎‮‬‏‍​‎⁮‪‮
		// privatescope
		internal static string u206b‪‪​⁫‪‭⁬‬‍⁭‏‮‍⁬​⁪⁮‫‬‍‮‌⁯‮‌⁪⁯⁮⁬‫‎‮‬‏‍​‎⁮‪‮(string str, int num)
		{
			return str.Remove(num);
		}

		// ‮‌⁯⁫‌​⁬⁬⁫⁬‍⁬‌⁮⁪‎‏⁮⁫‭⁮‏⁯⁬‬⁬⁬‪⁪‬‮⁭‭‮⁪‍⁭‫⁭‌‮
		// privatescope
		internal static DateTimeFormatInfo u202e‌⁯⁫‌​⁬⁬⁫⁬‍⁬‌⁮⁪‎‏⁮⁫‭⁮‏⁯⁬‬⁬⁬‪⁪‬‮⁭‭‮⁪‍⁭‫⁭‌‮(CultureInfo cultureInfo)
		{
			return cultureInfo.DateTimeFormat;
		}

		// ​⁬‎‭‫‎​‭‭⁬‮‍‌‮‬‍‎‬‪‎‮‪⁭⁫⁫⁪​‫⁫⁮‭⁭‪‮‎​⁮‬⁮⁭‮
		// privatescope
		internal static string u200b⁬‎‭‫‎​‭‭⁬‮‍‌‮‬‍‎‬‪‎‮‪⁭⁫⁫⁪​‫⁫⁮‭⁭‪‮‎​⁮‬⁮⁭‮(DateTimeFormatInfo dateTimeFormatInfo)
		{
			return dateTimeFormatInfo.ShortDatePattern;
		}

		// ⁭⁯⁭⁬​‪⁪‌⁭‪‏⁫⁮⁫⁭⁮⁪‌‮‌⁬‏⁬‮‮‌‌⁮⁭‭⁯⁫‎⁭‌⁮‫⁫⁭‪‮
		// privatescope
		internal static int u206d⁯⁭⁬​‪⁪‌⁭‪‏⁫⁮⁫⁭⁮⁪‌‮‌⁬‏⁬‮‮‌‌⁮⁭‭⁯⁫‎⁭‌⁮‫⁫⁭‪‮(string str)
		{
			return str.Length;
		}

		// ⁮‏⁯⁫⁫⁬⁯⁯‎​‍⁮‮‪⁭⁯‎‌‍⁮⁯​⁬​‎‎‏⁭⁬⁪⁮‫⁭‏‎⁫​‬⁪‬‮
		// privatescope
		internal static int u206e‏⁯⁫⁫⁬⁯⁯‎​‍⁮‮‪⁭⁯‎‌‍⁮⁯​⁬​‎‎‏⁭⁬⁪⁮‫⁭‏‎⁫​‬⁪‬‮(string str, char chr, int num)
		{
			return str.IndexOf(chr, num);
		}

		// ⁯‍‫⁪⁯⁯​‬⁮‪⁯⁯⁭​‬⁬‮⁮‮​‪⁫‏‪​​‭​‬⁪⁮⁭‬‬⁫‫⁪‬‍‎‮
		// privatescope
		internal static char u206f‍‫⁪⁯⁯​‬⁮‪⁯⁯⁭​‬⁬‮⁮‮​‪⁫‏‪​​‭​‬⁪⁮⁭‬‬⁫‫⁪‬‍‎‮(string str, int num)
		{
			return str[num];
		}

		// ‫‍‬‍‎‭⁪‌⁯‪​‏‍⁮‏‍⁮‬‌⁬⁭‌‪‬⁭⁮​⁪⁭‍⁮​⁮‫⁪‎‭‫‌⁯‮
		// privatescope
		internal static long u202b‍‬‍‎‭⁪‌⁯‪​‏‍⁮‏‍⁮‬‌⁬⁭‌‪‬⁭⁮​⁪⁭‍⁮​⁮‫⁪‎‭‫‌⁯‮(long num)
		{
			return Math.Abs(num);
		}

		// ‌⁪⁬‌⁪‭⁭​⁫‌⁮‬⁪‍⁮⁫‎⁮‭‪‎‫‭⁭⁯⁭⁯‭‭⁮⁮⁫⁮‬⁪⁪⁮⁭‏⁪‮
		// privatescope
		internal static int u200c⁪⁬‌⁪‭⁭​⁫‌⁮‬⁪‍⁮⁫‎⁮‭‪‎‫‭⁭⁯⁭⁯‭‭⁮⁮⁫⁮‬⁪⁪⁮⁭‏⁪‮(string str, string str)
		{
			return str.LastIndexOf(str);
		}

		// ‮⁫‏‭‌⁯‭⁭⁬‌​‍‮⁬‮‭⁪‌‎⁯⁭‭‍⁫‌‮‌⁭‭‏‍‪​​⁪‮⁫‫​‎‮
		// privatescope
		internal static DirectoryInfo u202e⁫‏‭‌⁯‭⁭⁬‌​‍‮⁬‮‭⁪‌‎⁯⁭‭‍⁫‌‮‌⁭‭‏‍‪​​⁪‮⁫‫​‎‮(string str)
		{
			return Directory.CreateDirectory(str);
		}

		// ‌​‪⁯‭‪⁮​⁪‭‭‌‫⁬⁫⁭⁬‭⁭⁪‍‍⁭⁭⁭‏⁭‮‬‍⁫​‏‏⁬⁮‍‪⁫⁪‮
		// privatescope
		internal static Form u200c​‪⁯‭‪⁮​⁪‭‭‌‫⁬⁫⁭⁬‭⁭⁪‍‍⁭⁭⁭‏⁭‮‬‍⁫​‏‏⁬⁮‍‪⁫⁪‮(ContainerControl containerControl)
		{
			return containerControl.ParentForm;
		}

		// ‪‎⁭‫⁮‭⁫​‪‮‎⁫⁭⁬‎⁭⁪‬‪‬‌⁫⁪‎⁪‪⁯​‍‮‭‌‏‍⁪​⁮⁮‮‭‮
		// privatescope
		internal static Color u202a‎⁭‫⁮‭⁫​‪‮‎⁫⁭⁬‎⁭⁪‬‪‬‌⁫⁪‎⁪‪⁯​‍‮‭‌‏‍⁪​⁮⁮‮‭‮(Control control)
		{
			return control.BackColor;
		}

		// ⁪​⁬⁯⁪⁪⁯‌‏‎‌‭‮‪‌⁫⁮‌⁮​⁭‍⁭‌⁬‪‭⁯‬‫⁭‌⁫‮‫‬‮⁭⁫‌‮
		// privatescope
		internal static Color u206a​⁬⁯⁪⁪⁯‌‏‎‌‭‮‪‌⁫⁮‌⁮​⁭‍⁭‌⁬‪‭⁯‬‫⁭‌⁫‮‫‬‮⁭⁫‌‮(Control control)
		{
			return control.ForeColor;
		}

		// ‪‏⁯‌‭‬‎‌‫‪‏‬‬⁮‬⁬‮‌‏‪‎⁪⁬‌⁬⁬‎‏⁬⁪​⁫⁯⁫⁫‫‭‬‪‮‮
		// privatescope
		internal static string u202a‏⁯‌‭‬‎‌‫‪‏‬‬⁮‬⁬‮‌‏‪‎⁪⁬‌⁬⁬‎‏⁬⁪​⁫⁯⁫⁫‫‭‬‪‮‮(Control control)
		{
			return control.Text;
		}

		// ‎‍⁯‏‌‪⁮⁬⁪‏‫‌‪‌‍‌‭⁯‫‮⁫‬‍‬​‮​⁬⁯‫‮‌⁮‬⁯‮⁪‏⁯‬‮
		// privatescope
		internal static bool u200e‍⁯‏‌‪⁮⁬⁪‏‫‌‪‌‍‌‭⁯‫‮⁫‬‍‬​‮​⁬⁯‫‮‌⁮‬⁯‮⁪‏⁯‬‮(ISharpControl sharpControl)
		{
			return sharpControl.get_ThemeIsDark();
		}

		// ‪‮⁮⁫‫‭‏‌‪​⁫‏⁯⁯‌⁯‭⁮‭‭⁯⁭​‍‍‪​⁪‌‎‏‍⁭‬⁯‍‫‭‍⁭‮
		// privatescope
		internal static bool u202a‮⁮⁫‫‭‏‌‪​⁫‏⁯⁯‌⁯‭⁮‭‭⁯⁭​‍‍‪​⁪‌‎‏‍⁭‬⁯‍‫‭‍⁭‮(Control control)
		{
			return control.Enabled;
		}

		// ⁬⁬‍‌‭​⁯‮‌‎‬‪⁮​‪‪‭⁪‎‭⁪⁪‎⁫⁮⁪⁫‌⁪‌⁫⁫‌‬⁯‍‌‭‭‬‮
		// privatescope
		internal static void u206c⁬‍‌‭​⁯‮‌‎‬‪⁮​‪‪‭⁪‎‭⁪⁪‎⁫⁮⁪⁫‌⁪‌⁫⁫‌‬⁯‍‌‭‭‬‮(LinkLabel linkLabel, Color color)
		{
			linkLabel.LinkColor = color;
		}

		// ⁫⁪⁫⁯⁯‪‮‎‮⁭‬‬‪⁬‏‫​‎‪‪⁭‍‎⁫‌‌‬‮⁫‪‏‫⁫‭‬‏⁪⁪‎⁮‮
		// privatescope
		internal static Graphics u206b⁪⁫⁯⁯‪‮‎‮⁭‬‬‪⁬‏‫​‎‪‪⁭‍‎⁫‌‌‬‮⁫‪‏‫⁫‭‬‏⁪⁪‎⁮‮(PaintEventArgs paintEventArg)
		{
			return paintEventArg.Graphics;
		}

		// ⁬​‬⁪‫⁬‬‏⁪‭‍⁯‏‌⁬‌‮​⁫​‬⁬‮‫‌‌‏‍‬⁯‪‎⁬‫‭⁯⁫⁮‮‎‮
		// privatescope
		internal static SolidBrush u206c​‬⁪‫⁬‬‏⁪‭‍⁯‏‌⁬‌‮​⁫​‬⁬‮‫‌‌‏‍‬⁯‪‎⁬‫‭⁯⁫⁮‮‎‮(Color color)
		{
			return new SolidBrush(color);
		}

		// ‪‮‎‍‭⁮⁬‫⁪⁯⁪⁯‭‮⁭‬⁭‬‏‭⁯‍‫⁬‎‫‪‫​‭‎⁯‍‏‮‏‪‏‏‭‮
		// privatescope
		internal static Pen u202a‮‎‍‭⁮⁬‫⁪⁯⁪⁯‭‮⁭‬⁭‬‏‭⁯‍‫⁬‎‫‪‫​‭‎⁯‍‏‮‏‪‏‏‭‮(Brush brush)
		{
			return new Pen(brush);
		}

		// ‏‍‍‭⁫​⁬⁮‪⁫‏⁯​‪‫‮‌‬⁮‮⁮‮​⁬⁬⁪⁯‌⁫‭⁮​⁮‪‪⁯⁬‪‍⁬‮
		// privatescope
		internal static System.Drawing.Font u200f‍‍‭⁫​⁬⁮‪⁫‏⁯​‪‫‮‌‬⁮‮⁮‮​⁬⁬⁪⁯‌⁫‭⁮​⁮‪‪⁯⁬‪‍⁬‮(Control control)
		{
			return control.Font;
		}

		// ⁭‎⁬⁫‎⁫‍‫‮‪⁮⁪‎‍⁬⁫‬⁫‫⁬⁮‬‭‎⁪⁪​⁪⁬‭‪‮‭⁫‬‍⁫‌‌‫‮
		// privatescope
		internal static SizeF u206d‎⁬⁫‎⁫‍‫‮‪⁮⁪‎‍⁬⁫‬⁫‫⁬⁮‬‭‎⁪⁪​⁪⁬‭‪‮‭⁫‬‍⁫‌‌‫‮(Graphics graphic, string str, System.Drawing.Font font)
		{
			return graphic.MeasureString(str, font);
		}

		// ‍‪⁬‭⁭‏⁪‏‎⁬‭⁪​⁭‫‬⁮‎​‍‎⁮‪‬‮‭‌⁪⁭‏⁬⁪⁭‮⁭‍⁬‎‌‍‮
		// privatescope
		internal static Rectangle u200d‪⁬‭⁭‏⁪‏‎⁬‭⁪​⁭‫‬⁮‎​‍‎⁮‪‬‮‭‌⁪⁭‏⁬⁪⁭‮⁭‍⁬‎‌‍‮(Control control)
		{
			return control.ClientRectangle;
		}

		// ‮⁭‎‌⁯‫⁯‮‭‌‭‭‌‏‌‪‭‪‌⁯⁯‌⁪⁫⁮‎‏‪‏⁬⁭‎‪​‎‏‫⁭‎⁪‮
		// privatescope
		internal static void u202e⁭‎‌⁯‫⁯‮‭‌‭‭‌‏‌‪‭‪‌⁯⁯‌⁪⁫⁮‎‏‪‏⁬⁭‎‪​‎‏‫⁭‎⁪‮(Graphics graphic, Color color)
		{
			graphic.Clear(color);
		}

		// ‏‬⁫‏⁭‬‏⁮⁯⁫⁯⁬⁪⁫⁪​‮⁭‮⁯‭​‮⁮‮⁪‎‬‫‏⁭⁮‮⁬‍‏‏‏⁭⁭‮
		// privatescope
		internal static System.Windows.Forms.Padding u200f‬⁫‏⁭‬‏⁮⁯⁫⁯⁬⁪⁫⁪​‮⁭‮⁯‭​‮⁮‮⁪‎‬‫‏⁭⁮‮⁬‍‏‏‏⁭⁭‮(Control control)
		{
			return control.Padding;
		}

		// ‌‎‪‬⁭‮‍⁮⁪‭⁬⁫​​‬‏⁭⁪‫‏⁭‫‍​​‎‪⁮‎​‭‮‭​⁭⁬‭⁬​⁫‮
		// privatescope
		internal static void u200c‎‪‬⁭‮‍⁮⁪‭⁬⁫​​‬‏⁭⁪‫‏⁭‫‍​​‎‪⁮‎​‭‮‭​⁭⁬‭⁬​⁫‮(Graphics graphic, string str, System.Drawing.Font font, Brush brush, float single, float single)
		{
			graphic.DrawString(str, font, brush, single, single);
		}

		// ⁭‫⁬‌‍⁭‭​⁫⁫⁫⁫⁬‬⁭⁯‌‏‌‏⁯‪⁪⁬‭‎⁯‍⁫⁯⁮⁮‭⁮‮‎‮‬⁫⁯‮
		// privatescope
		internal static void u206d‫⁬‌‍⁭‭​⁫⁫⁫⁫⁬‬⁭⁯‌‏‌‏⁯‪⁪⁬‭‎⁯‍⁫⁯⁮⁮‭⁮‮‎‮‬⁫⁯‮(Graphics graphic, Pen pen, Point point, Point point)
		{
			graphic.DrawLine(pen, point, point);
		}

		// ‎⁪⁮‬‮⁯⁪⁪⁪​‭‍⁫​‫⁪‫​‭‎‬⁬‫‎⁫⁮‬‪‏​‍‭‪‫​⁮⁫‫‫⁬‮
		// privatescope
		internal static System.Windows.Forms.Padding u200e⁪⁮‬‮⁯⁪⁪⁪​‭‍⁫​‫⁪‫​‭‎‬⁬‫‎⁫⁮‬‪‏​‍‭‪‫​⁮⁫‫‫⁬‮(Control control)
		{
			return control.Margin;
		}

		// ⁬​‮​‭⁬​⁫‎⁮⁮​‮‬‏⁪‪⁫‪⁭⁬‍⁮⁬‫‪⁯‬‎‬‫‪​‌⁫‌‏​​⁪‮
		// privatescope
		internal static void u206c​‮​‭⁬​⁫‎⁮⁮​‮‬‏⁪‪⁫‪⁭⁬‍⁮⁬‫‪⁯‬‎‬‫‪​‌⁫‌‏​​⁪‮(ToolTip toolTip, Control control, string str)
		{
			toolTip.SetToolTip(control, str);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public TetraPanel(ISharpControl sharpControl)
		{
			try
			{
				this.u200e‬‌⁮⁬‌​⁯⁯⁯⁮‬⁭‏‬⁮‍⁯‏⁬⁯‍⁫⁭⁭⁬​⁬​‌‭⁯⁫‫‏‏‭⁫‏‪‮();
				this.u202a⁯⁯⁬‮⁪⁪‭‪‍⁬‫‎⁫⁮⁬‎‎‏‍‎⁪‍⁯‍⁯‌⁮⁮⁮‍⁬⁬‎⁮‫‬⁫⁫‎‮();
				this.u206f‬⁪​‮‌⁮‪‫‍⁪⁭‫‎⁪⁫‌⁮⁮‍‍⁮‌⁫⁪‬‏⁮‎‭⁬‭‍⁫⁬‮⁭⁪‎‬‮ = new SettingsPersister(u003cModuleu003e.u206f⁮​‌‪‮‎‭‏‮‎⁮⁮‮⁬⁫‍‍⁪‍⁫⁮‏​‎⁬⁯⁪‪‍⁪⁮‎⁬⁪⁫​⁮⁪⁮‮<string>(-638337187));
				this.u200b‍⁯⁪‌‍‍‎‪⁯⁮⁪‬⁯⁮⁮‍⁫‫⁭⁯​⁮⁮‫⁫‪‭‪⁪‪⁬⁫‬‎‌‎⁬‎⁫‮ = this.u206f‬⁪​‮‌⁮‪‫‍⁪⁭‫‎⁪⁫‌⁮⁮‍‍⁮‌⁫⁪‬‏⁮‎‭⁬‭‍⁫⁬‮⁭⁪‎‬‮.ReadStored();
				this.u202b⁭‮‮‌⁮‍⁪‭‮⁯‍​‬⁯⁫⁪⁬⁮⁮‎‫⁬⁬‌⁬‮⁮‍​‫​‫‌⁬​‌‪‮ = new u200f⁭‏‫‪‪‎‍⁫‏⁬⁮‫‫‌⁪⁭‌⁬⁫‍⁮⁭‌‎⁮⁫⁪⁪‬‪⁫⁮‫⁭‬⁮‪‌‪‮(TetraPanel.u202e⁫⁫⁭​‌​‍‌‌​‪‬⁭⁮‭‬‬‭‫⁪‌‏‬‏‫‌‍⁯⁯⁭‬​‬‭​‏‪⁮⁫‮(TetraPanel.u206c‮⁪​⁭‪‮⁭⁪‬‬⁬‪⁮‫⁯⁭‏‎⁫‌‮‮‭‭⁫‌‭⁮‭⁬‮‬⁪‍‭‫‍⁮⁯‮()));
				if (this.u200b‍⁯⁪‌‍‍‎‪⁯⁮⁪‬⁯⁮⁮‍⁫‫⁭⁯​⁮⁮‫⁫‪‭‪⁪‪⁬⁫‬‎‌‎⁬‎⁫‮.LogEntryRules == null || TetraPanel.u202a‎​⁫⁪‫‭⁮⁪‫‮‎⁫‏‎‍​⁫⁮‫‭‎‏​⁭‭⁭‏‌‭‎⁮‬⁯‎‫⁪‭⁬‫‮(this.u200b‍⁯⁪‌‍‍‎‪⁯⁮⁪‬⁯⁮⁮‍⁫‫⁭⁯​⁮⁮‫⁫‪‭‪⁪‪⁬⁫‬‎‌‎⁬‎⁫‮.LogEntryRules, string.Empty))
				{
					this.u200b‍⁯⁪‌‍‍‎‪⁯⁮⁪‬⁯⁮⁮‍⁫‫⁭⁯​⁮⁮‫⁫‪‭‪⁪‪⁬⁫‬‎‌‎⁬‎⁫‮.LogEntryRules = u003cModuleu003e.u200e‏‌‬⁮‪‭⁭‭⁭‎​‏‌‭‭‭⁭⁬⁯⁫‍‮‫⁯‌‮‏​‬⁫⁯⁮⁫‮‪⁫‬⁮⁬‮<string>(-1017189874);
				}
				if (this.u200b‍⁯⁪‌‍‍‎‪⁯⁮⁪‬⁯⁮⁮‍⁫‫⁭⁯​⁮⁮‫⁫‪‭‪⁪‪⁬⁫‬‎‌‎⁬‎⁫‮.LogFileNameRules == null || TetraPanel.u202a‎​⁫⁪‫‭⁮⁪‫‮‎⁫‏‎‍​⁫⁮‫‭‎‏​⁭‭⁭‏‌‭‎⁮‬⁯‎‫⁪‭⁬‫‮(this.u200b‍⁯⁪‌‍‍‎‪⁯⁮⁪‬⁯⁮⁮‍⁫‫⁭⁯​⁮⁮‫⁫‪‭‪⁪‪⁬⁫‬‎‌‎⁬‎⁫‮.LogFileNameRules, string.Empty))
				{
					this.u200b‍⁯⁪‌‍‍‎‪⁯⁮⁪‬⁯⁮⁮‍⁫‫⁭⁯​⁮⁮‫⁫‪‭‪⁪‪⁬⁫‬‎‌‎⁬‎⁫‮.LogFileNameRules = u003cModuleu003e.u202a‮‫‏‫‬‬‪⁫⁬​‏⁫⁭‍‪‪‎⁬​‪​‌⁮‮‌​⁫​⁬‪‫⁪⁯⁪‎‫⁭‎⁪‮<string>(-869127016);
				}
				if (this.u200b‍⁯⁪‌‍‍‎‪⁯⁮⁪‬⁯⁮⁮‍⁫‫⁭⁯​⁮⁮‫⁫‪‭‪⁪‪⁬⁫‬‎‌‎⁬‎⁫‮.LogSeparator == null || TetraPanel.u202a‎​⁫⁪‫‭⁮⁪‫‮‎⁫‏‎‍​⁫⁮‫‭‎‏​⁭‭⁭‏‌‭‎⁮‬⁯‎‫⁪‭⁬‫‮(this.u200b‍⁯⁪‌‍‍‎‪⁯⁮⁪‬⁯⁮⁮‍⁫‫⁭⁯​⁮⁮‫⁫‪‭‪⁪‪⁬⁫‬‎‌‎⁬‎⁫‮.LogSeparator, string.Empty))
				{
					this.u200b‍⁯⁪‌‍‍‎‪⁯⁮⁪‬⁯⁮⁮‍⁫‫⁭⁯​⁮⁮‫⁫‪‭‪⁪‪⁬⁫‬‎‌‎⁬‎⁫‮.LogSeparator = u003cModuleu003e.u202a‮‫‏‫‬‬‪⁫⁬​‏⁫⁭‍‪‪‎⁬​‪​‌⁮‮‌​⁫​⁬‪‫⁪⁯⁪‎‫⁭‎⁪‮<string>(2112799017);
				}
				if (this.u200b‍⁯⁪‌‍‍‎‪⁯⁮⁪‬⁯⁮⁮‍⁫‫⁭⁯​⁮⁮‫⁫‪‭‪⁪‪⁬⁫‬‎‌‎⁬‎⁫‮.NetworkBase == null)
				{
					this.u200b‍⁯⁪‌‍‍‎‪⁯⁮⁪‬⁯⁮⁮‍⁫‫⁭⁯​⁮⁮‫⁫‪‭‪⁪‪⁬⁫‬‎‌‎⁬‎⁫‮.NetworkBase = new List<GroupsEntries>();
				}
				if (this.u200b‍⁯⁪‌‍‍‎‪⁯⁮⁪‬⁯⁮⁮‍⁫‫⁭⁯​⁮⁮‫⁫‪‭‪⁪‪⁬⁫‬‎‌‎⁬‎⁫‮.TttUdpPort < 1024)
				{
					this.u200b‍⁯⁪‌‍‍‎‪⁯⁮⁪‬⁯⁮⁮‍⁫‫⁭⁯​⁮⁮‫⁫‪‭‪⁪‪⁬⁫‬‎‌‎⁬‎⁫‮.TttUdpPort = 3383;
				}
				if (this.u200b‍⁯⁪‌‍‍‎‪⁯⁮⁪‬⁯⁮⁮‍⁫‫⁭⁯​⁮⁮‫⁫‪‭‪⁪‪⁬⁫‬‎‌‎⁬‎⁫‮.BpfLowCuttoff == 0)
				{
					this.u200b‍⁯⁪‌‍‍‎‪⁯⁮⁪‬⁯⁮⁮‍⁫‫⁭⁯​⁮⁮‫⁫‪‭‪⁪‪⁬⁫‬‎‌‎⁬‎⁫‮.BpfLowCuttoff = 300;
				}
				if (this.u200b‍⁯⁪‌‍‍‎‪⁯⁮⁪‬⁯⁮⁮‍⁫‫⁭⁯​⁮⁮‫⁫‪‭‪⁪‪⁬⁫‬‎‌‎⁬‎⁫‮.AgcThresh == 0)
				{
					this.u200b‍⁯⁪‌‍‍‎‪⁯⁮⁪‬⁯⁮⁮‍⁫‫⁭⁯​⁮⁮‫⁫‪‭‪⁪‪⁬⁫‬‎‌‎⁬‎⁫‮.AgcThresh = -51;
				}
				if (this.u200b‍⁯⁪‌‍‍‎‪⁯⁮⁪‬⁯⁮⁮‍⁫‫⁭⁯​⁮⁮‫⁫‪‭‪⁪‪⁬⁫‬‎‌‎⁬‎⁫‮.AgcSlope == 0)
				{
					this.u200b‍⁯⁪‌‍‍‎‪⁯⁮⁪‬⁯⁮⁮‍⁫‫⁭⁯​⁮⁮‫⁫‪‭‪⁪‪⁬⁫‬‎‌‎⁬‎⁫‮.AgcSlope = 0;
				}
				if (this.u200b‍⁯⁪‌‍‍‎‪⁯⁮⁪‬⁯⁮⁮‍⁫‫⁭⁯​⁮⁮‫⁫‪‭‪⁪‪⁬⁫‬‎‌‎⁬‎⁫‮.AgcDecay == 0)
				{
					this.u200b‍⁯⁪‌‍‍‎‪⁯⁮⁪‬⁯⁮⁮‍⁫‫⁭⁯​⁮⁮‫⁫‪‭‪⁪‪⁬⁫‬‎‌‎⁬‎⁫‮.AgcDecay = 500;
				}
				TetraPanel.u200d⁭⁮⁬‍⁮‌​‍‪‮‭⁭⁬‭‭‍‬⁬​‭⁬⁯‏‪⁭⁬‍‎⁯⁯‏⁯‭‏‭‬‌‌‮(this.u206e‬​⁯⁫‍‎​‮⁬⁮‍‫‪‬‌‌‭⁯⁫‮‫‮⁭‮‫‪‫⁮‫⁪‏‏‏‫‏‭⁬⁬‍‮, this.u200b‍⁯⁪‌‍‍‎‪⁯⁮⁪‬⁯⁮⁮‍⁫‫⁭⁯​⁮⁮‫⁫‪‭‪⁪‪⁬⁫‬‎‌‎⁬‎⁫‮.DmoMode);
				TetraPanel.u202e⁯‭⁪‪⁬‮‬‍‭⁪⁭⁯⁯‌⁫⁫‭‎⁯‭⁭⁪‌‮‪‏⁮‮⁭‫‎⁭‬‏‏‫‌⁪‌‮(this.u202a‪⁮​‏‫‮‫⁭⁯⁭‬⁯‎‭​‎⁬‭⁬‬‬‬‌⁪‍⁪​‎‍⁯​‍⁯⁫‎‍⁪‎‭‮, this.u200b‍⁯⁪‌‍‍‎‪⁯⁮⁪‬⁯⁮⁮‍⁫‫⁭⁯​⁮⁮‫⁫‪‭‪⁪‪⁬⁫‬‎‌‎⁬‎⁫‮.AgcThresh);
				TetraPanel.u202e⁯‭⁪‪⁬‮‬‍‭⁪⁭⁯⁯‌⁫⁫‭‎⁯‭⁭⁪‌‮‪‏⁮‮⁭‫‎⁭‬‏‏‫‌⁪‌‮(this.u200f‍‮‏‌‏‌‍‍⁪⁫⁯⁭‫⁮⁫‫⁯‏‫⁪‍‫⁮‮⁪⁫‍‭‍⁫‏‍⁫‍‌⁪⁫⁪⁭‮, this.u200b‍⁯⁪‌‍‍‎‪⁯⁮⁪‬⁯⁮⁮‍⁫‫⁭⁯​⁮⁮‫⁫‪‭‪⁪‪⁬⁫‬‎‌‎⁬‎⁫‮.AgcSlope);
				TetraPanel.u202e⁯‭⁪‪⁬‮‬‍‭⁪⁭⁯⁯‌⁫⁫‭‎⁯‭⁭⁪‌‮‪‏⁮‮⁭‫‎⁭‬‏‏‫‌⁪‌‮(this.u206a⁯‏⁯​‫‬⁬‌⁮​⁯‬‌‭⁯‪⁬⁯⁮‌‫⁫⁫‍‎‎⁫⁮‫‍‍‪​‮‍‮‭⁬‏‮, this.u200b‍⁯⁪‌‍‍‎‪⁯⁮⁪‬⁯⁮⁮‍⁫‫⁭⁯​⁮⁮‫⁫‪‭‪⁪‪⁬⁫‬‎‌‎⁬‎⁫‮.AgcDecay);
				this.u200e⁯⁪‫‪​‎‌‭⁪‍⁮⁮⁭‌‭‫‌‎⁬‫⁯⁬‮‫⁫‭⁪⁭‭⁬⁬‌⁪‏⁮‌⁮‫‎‮ = TetraPanel.u200e⁬​⁪⁮‏⁫‮⁫‌⁮⁮⁬‪⁪‪‏‭⁭​‏⁫⁫⁯⁮​‎⁮​‌‍‎⁭⁯‫​‮⁭‭‫‮(u003cModuleu003e.u200e‏‌‬⁮‪‭⁭‭⁭‎​‏‌‭‭‭⁭⁬⁯⁫‍‮‫⁯‌‮‏​‬⁫⁯⁮⁫‮‪⁫‬⁮⁬‮<string>(693305652));
				this.u202a⁬‮⁬‬‮‏⁬‏⁯⁬​⁮​‌‫‍⁯‌⁬⁫‪⁬‬⁪⁪‫⁫⁭‎‍‫‫‬‮‬⁫⁯⁫‌‮ = sharpControl;
				if (TetraPanel.u202b‭⁬‬⁭‮‮⁪‮‫‮⁯⁯‎‭‏‎‎​⁫⁭‭‎‬‌‌‬‌‎‬‍‍‮⁭​‍⁬‫‪⁪‮(TetraPanel.u200d‭‭‎‌‪‍​⁪‫‎‫‎⁫‫⁪‏‌​‭‪⁫‮​‪‎‮‏⁯‬⁬‭‎⁯​‭‭‭‭⁮‮(TetraPanel.u206a⁭⁮⁭⁬‭‪⁯‏‫⁯⁬⁮⁭‪⁯‭‏‬‎‭⁬‬⁯‮⁫‎⁮⁬‏‭⁭‏⁮‎⁪⁬⁭‭‮(this.u202a⁬‮⁬‬‮‏⁬‏⁯⁬​⁮​‌‫‍⁯‌⁬⁫‪⁬‬⁪⁪‫⁫⁭‎‍‫‫‬‮‬⁫⁯⁫‌‮), u003cModuleu003e.u200f⁫‌​⁬‌‎‎‏‍‍⁫‎​‌‬⁯‬‫‭‎‏​‌​⁪‭‬⁬‮⁬​‌⁬⁪‫‫‎⁪⁮‮<string>(-1301199521)), null))
				{
					this.u206a‎‎⁪​‏‫⁮‍⁪⁯‏⁭‌‮​‍‪⁬‮⁮⁮‎⁫‭⁫⁬⁪‮‭‍⁫‫‬‭‮‍‏​‌‮ = true;
				}
				this.u202a‎‌​⁮⁫‍⁮‬‭‎⁫‮​⁭⁪⁭‮⁫‮⁭‎‭‍‬‫‏⁮‍‫⁪‫‫​‌​⁮‎⁯‮‮();
				this.u202c​⁪⁭‎​‌⁯⁮‌⁫‌⁪⁭⁯‪⁯‮​⁭⁭‬⁭‬‮⁪⁫‭‭⁭‫‌‏‪‫‍⁫‫⁮‪‮ = TetraPanel.u200e‏‌⁭‪⁮‪‏‏‎⁭‍‮‫‭‍⁯‬⁪‪‌‮⁯​⁮‫‏⁬‎‍⁮‌⁮⁭‪‬⁫‎‬⁬‮(u003cModuleu003e.u202a‮‫‏‫‬‬‪⁫⁬​‏⁫⁭‍‪‪‎⁬​‪​‌⁮‮‌​⁫​⁬‪‫⁪⁯⁪‎‫⁭‎⁪‮<string>(1069578912), string.Empty);
				TetraPanel.u206a‏⁫‫​‏⁪⁬⁪‪⁪⁬‬⁫⁯‎‪⁯‫‎⁯‪‭‎‮‪‎⁮⁯‭⁯‎⁮⁮‪‭⁫‬⁫⁬‮(this.u202a‪⁮​‏‫‮‫⁭⁯⁭‬⁯‎‭​‎⁬‭⁬‬‬‬‌⁪‍⁪​‎‍⁯​‍⁯⁫‎‍⁪‎‭‮, this.u200b‍⁯⁪‌‍‍‎‪⁯⁮⁪‬⁯⁮⁮‍⁫‫⁭⁯​⁮⁮‫⁫‪‭‪⁪‪⁬⁫‬‎‌‎⁬‎⁫‮.AudioAGCEnabled);
				TetraPanel.u206a‏⁫‫​‏⁪⁬⁪‪⁪⁬‬⁫⁯‎‪⁯‫‎⁯‪‭‎‮‪‎⁮⁯‭⁯‎⁮⁮‪‭⁫‬⁫⁬‮(this.u200f‍‮‏‌‏‌‍‍⁪⁫⁯⁭‫⁮⁫‫⁯‏‫⁪‍‫⁮‮⁪⁫‍‭‍⁫‏‍⁫‍‌⁪⁫⁪⁭‮, this.u200b‍⁯⁪‌‍‍‎‪⁯⁮⁪‬⁯⁮⁮‍⁫‫⁭⁯​⁮⁮‫⁫‪‭‪⁪‪⁬⁫‬‎‌‎⁬‎⁫‮.AudioAGCEnabled);
				TetraPanel.u206a‏⁫‫​‏⁪⁬⁪‪⁪⁬‬⁫⁯‎‪⁯‫‎⁯‪‭‎‮‪‎⁮⁯‭⁯‎⁮⁮‪‭⁫‬⁫⁬‮(this.u206a⁯‏⁯​‫‬⁬‌⁮​⁯‬‌‭⁯‪⁬⁯⁮‌‫⁫⁫‍‎‎⁫⁮‫‍‍‪​‮‍‮‭⁬‏‮, this.u200b‍⁯⁪‌‍‍‎‪⁯⁮⁪‬⁯⁮⁮‍⁫‫⁭⁯​⁮⁮‫⁫‪‭‪⁪‪⁬⁫‬‎‌‎⁬‎⁫‮.AudioAGCEnabled);
				TetraPanel.u206a‏⁫‫​‏⁪⁬⁪‪⁪⁬‬⁫⁯‎‪⁯‫‎⁯‪‭‎‮‪‎⁮⁯‭⁯‎⁮⁮‪‭⁫‬⁫⁬‮(this.u202b⁪⁭‍‎⁭‮⁮‭⁮⁪‬⁯⁭‎‌⁫‮‮⁪‍⁯‎‍‫⁫‪‪‎‪‬‍‎‮‍⁭‍⁭‎⁬‮, this.u200b‍⁯⁪‌‍‍‎‪⁯⁮⁪‬⁯⁮⁮‍⁫‫⁭⁯​⁮⁮‫⁫‪‭‪⁪‪⁬⁫‬‎‌‎⁬‎⁫‮.AudioAGCEnabled);
				TetraPanel.u206a‏⁫‫​‏⁪⁬⁪‪⁪⁬‬⁫⁯‎‪⁯‫‎⁯‪‭‎‮‪‎⁮⁯‭⁯‎⁮⁮‪‭⁫‬⁫⁬‮(this.u202a‪‬⁭‮⁬⁫‫⁬‮‏‪‪‭‎‌‫‪‍⁭‏⁮⁬‭⁪⁯‍‍⁭‪‏‫‮​⁪⁭⁪‪‬‮, this.u200b‍⁯⁪‌‍‍‎‪⁯⁮⁪‬⁯⁮⁮‍⁫‫⁭⁯​⁮⁮‫⁫‪‭‪⁪‪⁬⁫‬‎‌‎⁬‎⁫‮.AudioAGCEnabled);
				TetraPanel.u206a‏⁫‫​‏⁪⁬⁪‪⁪⁬‬⁫⁯‎‪⁯‫‎⁯‪‭‎‮‪‎⁮⁯‭⁯‎⁮⁮‪‭⁫‬⁫⁬‮(this.u200c‫‌‪‌‌‏​⁯⁪​‫⁪⁮⁯‫‍⁪⁫⁪‮⁬⁬‭⁯‌‫⁯‫‪‏‭‏⁭⁬‌‫‬⁪⁬‮, this.u200b‍⁯⁪‌‍‍‎‪⁯⁮⁪‬⁯⁮⁮‍⁫‫⁭⁯​⁮⁮‫⁫‪‭‪⁪‪⁬⁫‬‎‌‎⁬‎⁫‮.AudioAGCEnabled);
				TetraPanel.u202e⁯‭⁪‪⁬‮‬‍‭⁪⁭⁯⁯‌⁫⁫‭‎⁯‭⁭⁪‌‮‪‏⁮‮⁭‫‎⁭‬‏‏‫‌⁪‌‮(this.u202b‫‌‍⁭‎‮⁮‍‮‎‏⁮‭‌⁭⁫‮⁮‭‎‏⁮⁮‌‌‫‬‪⁬⁬‏‌‭‌‫‌‭‭⁭‮, this.u200b‍⁯⁪‌‍‍‎‪⁯⁮⁪‬⁯⁮⁮‍⁫‫⁭⁯​⁮⁮‫⁫‪‭‪⁪‪⁬⁫‬‎‌‎⁬‎⁫‮.BlockedLevel);
				TetraPanel.u206b⁪‫‬⁮‬‭‪‮‍‌⁮⁮⁪‏‍‍‎‏‎​‏‏⁮‬‫⁬‬⁫‪⁪⁮⁫‏⁪‪⁭‎‌⁯‮(this.u202b‫‌‍⁭‎‮⁮‍‮‎‏⁮‭‌⁭⁫‮⁮‭‎‏⁮⁮‌‌‫‬‪⁬⁬‏‌‭‌‫‌‭‭⁭‮, !this.u200b‍⁯⁪‌‍‍‎‪⁯⁮⁪‬⁯⁮⁮‍⁫‫⁭⁯​⁮⁮‫⁫‪‭‪⁪‪⁬⁫‬‎‌‎⁬‎⁫‮.TttModeEnabled);
				this.u200f⁯⁫‮⁭​⁮⁫⁭‬‌‮‍‭‮‮‭⁭⁮⁮‍‫‭⁯⁪⁯⁬‬⁬⁬‮‬⁬⁪⁮⁫‪​​‮‮ = this.u206b‍⁯⁮⁬‍‎⁮​‪‬⁭‫⁭⁮⁫⁯‍‌‬‫‬⁭‪⁫‌‌⁮⁯​⁪⁭⁭⁬​‌‍‭‌⁭‮(this.u200b‍⁯⁪‌‍‍‎‪⁯⁮⁪‬⁯⁮⁮‍⁫‫⁭⁯​⁮⁮‫⁫‪‭‪⁪‪⁬⁫‬‎‌‎⁬‎⁫‮.NetworkBase);
				this.u200f‭⁯‌‎⁫‏‪⁪‭‏‫‍⁫‪‏‌​‫​‮⁪‎‮⁬⁭⁯‮​‌‭‬⁮‍⁪​⁬‌‏⁪‮ = true;
				this.u206e​‮⁪⁯⁭⁬‌‭‪‍‌‮⁬‭‏‫‫‬⁮⁭‎⁮​‫‍‎‪⁫‏‍‎‫‏‬⁪⁮‍​⁪‮ = new NetInfoWindow();
				TetraPanel.u206d‎⁯⁯‍⁪‬⁬⁮⁯‫⁭⁬‭‬‮⁮‫⁬⁬⁪⁮‎‏‪​​‏⁪⁪‭‭‏‪‍‌‭‫‭⁫‮(this.u206e​‮⁪⁯⁭⁬‌‭‪‍‌‮⁬‭‏‫‫‬⁮⁭‎⁮​‫‍‎‪⁫‏‍‎‫‏‬⁪⁮‍​⁪‮, new FormClosingEventHandler(this.u202b‏‫‎‎​⁮‮‫​‎⁮​‮​‌‬‫‍⁭⁮‭⁭‭‌‭⁪‏‌⁯‫‌‭‏‏‌‫​‌‍‮));
				TetraPanel.u200d⁯‮‎​⁫‮‮‎‌⁬‪‮⁫⁮‏⁮‭​⁯⁫⁮‍⁭⁮⁭‎⁮⁫‏‭⁫‍‪⁭‎‌‌‏⁯‮(TetraPanel.u200c‭‌⁬‪⁭⁭‏‍⁭⁯‌⁫‍​‏‎⁮⁬‌⁯‫‪⁪⁪⁮⁪⁫‍‫‏‫‏⁯​‬‭‎⁮‮‮(this.u206e​‮⁪⁯⁭⁬‌‭‪‍‌‮⁬‭‏‫‫‬⁮⁭‎⁮​‫‍‎‪⁫‏‍‎‫‏‬⁪⁮‍​⁪‮.tabControl1), this.u206e​‮⁪⁯⁭⁬‌‭‪‍‌‮⁬‭‏‫‫‬⁮⁭‎⁮​‫‍‎‪⁫‏‍‎‫‏‬⁪⁮‍​⁪‮.burstErrorsTabPage);
				this.u200c‭‫⁮‪‭‮‍‏‎⁮​‫‬‫‮⁪⁭‏⁯⁪⁮⁭⁪‫​‏‮‌‪‬‫‭‬⁫‬‮‫‭⁯‮ = new IFProcessor();
				TetraPanel.u202a⁬‌‮‫‮‬‮⁮⁪⁭⁯‬‬‫‎⁮‪‍⁪⁫⁯‮‍‮⁪⁬‬⁬‪‍‫⁯‎​⁭‪⁯‬‪‮(this.u202a⁬‮⁬‬‮‏⁬‏⁯⁬​⁮​‌‫‍⁯‌⁬⁫‪⁬‬⁪⁪‫⁫⁭‎‍‫‫‬‮‬⁫⁯⁫‌‮, this.u200c‭‫⁮‪‭‮‍‏‎⁮​‫‬‫‮⁪⁭‏⁯⁪⁮⁭⁪‫​‏‮‌‪‬‫‭‬⁫‬‮‫‭⁯‮, 1);
				this.u200c‭‫⁮‪‭‮‍‏‎⁮​‫‬‫‮⁪⁭‏⁯⁪⁮⁭⁪‫​‏‮‌‪‬‫‭‬⁫‬‮‫‭⁯‮.IQReady += new IFProcessor.IQReadyDelegate(this.IQSamplesAvailable);
				this.u202c⁪​‬‫⁫‭⁫‪‫⁪⁭‮⁮⁫‫‭⁮‬‌‎‬⁮⁭⁭‭‪‪‮‌‬‪⁫​‮⁬‍⁪‍‏‮ = new AudioProcessor();
				TetraPanel.u202a⁬‌‮‫‮‬‮⁮⁪⁭⁯‬‬‫‎⁮‪‍⁪⁫⁯‮‍‮⁪⁬‬⁬‪‍‫⁯‎​⁭‪⁯‬‪‮(this.u202a⁬‮⁬‬‮‏⁬‏⁯⁬​⁮​‌‫‍⁯‌⁬⁫‪⁬‬⁪⁪‫⁫⁭‎‍‫‫‬‮‬⁫⁯⁫‌‮, this.u202c⁪​‬‫⁫‭⁫‪‫⁪⁭‮⁮⁫‫‭⁮‬‌‎‬⁮⁭⁭‭‪‪‮‌‬‪⁫​‮⁬‍⁪‍‏‮, 3);
				this.u202c⁪​‬‫⁫‭⁫‪‫⁪⁭‮⁮⁫‫‭⁮‬‌‎‬⁮⁭⁭‭‪‪‮‌‬‪⁫​‮⁬‍⁪‍‏‮.AudioReady += new AudioProcessor.AudioReadyDelegate(this.AudioSamplesNedeed);
				this.u206c‪‌‭‏⁯​‫⁫⁫‬‫‍‪⁯‫‏‫⁪⁯⁫​‮‍‫‭‎‍‏‪‎⁬⁭‬​⁭​‎⁫⁪‮ = new u202a‍‎‎‪‍⁬⁭‬‌‎⁬‎‭‪‬‬​⁭⁬⁮‏‏‪‏‏‏‬⁬‭⁫​‎‎‭‎​‎‬⁬‮();
				this.u206c‪‌‭‏⁯​‫⁫⁫‬‫‍‪⁯‫‏‫⁪⁯⁫​‮‍‫‭‎‍‏‪‎⁬⁭‬​⁭​‎⁫⁪‮.u200f⁫⁬‍​‍‪‬‭⁯⁭⁪‬‮‎⁬‮⁯⁪‬‪‏⁬‮⁬⁯‫⁬‫‫‬‬⁯‭‭‍​‭‌‭‮(new u202a‍‎‎‪‍⁬⁭‬‌‎⁬‎‭‪‬‬​⁭⁬⁮‏‏‪‏‏‏‬⁬‭⁫​‎‎‭‎​‎‬⁬‮.u206e‮‏‎‬‪‬‫⁭‍‬‬‎‮⁮‭⁯⁪‮‪‏‍‮‎⁬⁬‪‪‫‫⁯‬⁮‎⁯‌‮‎‫⁬‮(this.u200f⁮‭‎‪⁮⁪⁫‮⁯⁯‏‫‍​⁪​‭⁮⁪‏⁬⁪⁫⁮​‍⁯⁭‎‬‪‮‪‌‏‎⁮⁪‮‮));
				this.u206c‪‌‭‏⁯​‫⁫⁫‬‫‍‪⁯‫‏‫⁪⁯⁫​‮‍‫‭‎‍‏‪‎⁬⁭‬​⁭​‎⁫⁪‮.u206a⁪⁪⁮‎⁫⁯⁪⁭‫‏‫⁫​‫​⁪‬​‏‮‌⁭‮⁬‪⁫‬⁫‎‫‌‫‫‭‫⁯‫‬⁫‮(new u202a‍‎‎‪‍⁬⁭‬‌‎⁬‎‭‪‬‬​⁭⁬⁮‏‏‪‏‏‏‬⁬‭⁫​‎‎‭‎​‎‬⁬‮.u202b⁪‌‪⁯⁭‬‏‍⁬⁮⁮‬‍‍‍⁫‍⁯‬‫‍‫‫‪‏‌‮⁬⁫‪‌‌​⁬⁪⁭⁯⁫‪‮(this.u200b‍⁮‍⁮⁭⁯‫⁪‮‎​‭‫‍‏‫‬‎‌‍‭‌⁮​‭‎‭⁪‫‍⁯​‭‏⁭⁪​⁫‭‮));
				this.u206a‏‏‍‎⁫‫‍‮‌⁫​‪‫‍‫⁭‮‫‎‫‌⁫‬​‫‪⁫‭‪‫‭⁬⁫‎‭⁮⁮⁮‮ = new u200c⁯⁯⁬‮‌‎⁫‌⁯‍‭⁮⁫‍‫‎‬‪⁮⁭‌⁮‭⁪⁬‌⁯⁯‮‫‪⁮‎‎⁯‍‭‏‌‮();
				TetraPanel.u206b⁯‫‪‌⁭⁯⁬⁪⁯‭‮‬‮‫‭⁪⁮⁮⁭‍‏​‏⁪‬‌⁯‍⁫‭‭⁫⁫‭‏⁮‭‭⁯‮(this.u202a⁬‮⁬‬‮‏⁬‏⁯⁬​⁮​‌‫‍⁯‌⁬⁫‪⁬‬⁪⁪‫⁫⁭‎‍‫‫‬‮‬⁫⁯⁫‌‮, new PropertyChangedEventHandler(this.u206e‫⁭⁪‌‌​⁫⁪⁬‭‌‭‍⁬‬‍‎‭​‬⁯⁬‫‭​⁯‪‬⁯‎‍‏‎‫‭⁪‬‍‮‮));
				this.u200b⁭‎‪‫​‫‫⁬‮⁭‭​⁮⁫‎‌‮‫⁫‬​‎‌⁪‫‎⁯⁯⁭‭‏⁭‭‮⁭⁯‍‪‮ = TetraPanel.u206f‍⁯⁮‌⁪‎⁮⁬‪⁫⁬‬‮⁯‏‪⁫⁯⁬‌⁫‍‭⁮‫‪⁫⁬⁬⁯‭‏‎⁮⁯⁯⁬‎⁪‮(255, 4);
				this.u202d⁭⁮‭‏‫‭‎​‭‌⁪‬‬‭‪⁭‍​⁬‪⁪‮‌‎⁬‪‪‮⁮‏‎‍⁫⁮‬⁭‭⁮‬‮ = (float*)TetraPanel.u200c‏‬⁪⁯‌‍⁮⁫​‏‮⁪‎‍⁪⁮‬‏‭⁯​‪‏‫⁭⁪‌‍‬‏⁯‬‮⁪‪⁭‏⁭‏‮(this.u200b⁭‎‪‫​‫‫⁬‮⁭‭​⁮⁫‎‌‮‫⁫‬​‎‌⁪‫‎⁯⁯⁭‭‏⁭‭‮⁭⁯‍‪‮);
				this.u200c⁫⁯⁮​⁮‍‬⁮⁮‏⁯⁫‎‍‏​‏‪‍‪​‌⁬‪‌‪‬‪⁯‭​⁫​⁯⁭‪‪⁬⁪‮ = TetraPanel.u206f‍⁯⁮‌⁪‎⁮⁬‪⁫⁬‬‮⁯‏‪⁫⁯⁬‌⁫‍‭⁮‫‪⁫⁬⁬⁯‭‏‎⁮⁯⁯⁬‎⁪‮(255, 4);
				this.u202b⁭‍‌⁯‮‏⁪⁪‎‫‍​‍⁪‎‮⁬‪⁯⁯⁬⁮‏‫⁮⁫‏‮‪‫⁯⁯‪⁯‪‪‬⁮‭‮ = (float*)TetraPanel.u200c‏‬⁪⁯‌‍⁮⁫​‏‮⁪‎‍⁪⁮‬‏‭⁯​‪‏‫⁭⁪‌‍‬‏⁯‬‮⁪‪⁭‏⁭‏‮(this.u200c⁫⁯⁮​⁮‍‬⁮⁮‏⁯⁫‎‍‏​‏‪‍‪​‌⁬‪‌‪‬‪⁯‭​⁫​⁯⁭‪‪⁬⁪‮);
				this.u200d‫⁪‭‏‮⁮‮‪⁭⁫​‍‫⁬​‏‍⁫‭⁫‭‪‫⁪‌⁪​⁪⁭‎‏‮‭‌⁬⁫‏‮‮ = TetraPanel.u200f‮⁫‏⁯⁯‏​⁬‌‎⁫​‏‬‪⁮‫‬‌‎‍‌‮⁮⁬⁯‏⁮​⁭⁭⁬‮⁮⁯‏‮⁮‎‮(510);
				this.u206f⁪‌​⁮‌‫‪⁮⁫⁭‍‍⁭‮‏‌‬‫‬‬⁮​‏​⁭​⁮‭‮‌‬‏​​⁮​⁪⁯‭‮ = (byte*)TetraPanel.u200c‏‬⁪⁯‌‍⁮⁫​‏‮⁪‎‍⁪⁮‬‏‭⁯​‪‏‫⁭⁪‌‍‬‏⁯‬‮⁪‪⁭‏⁭‏‮(this.u200d‫⁪‭‏‮⁮‮‪⁭⁫​‍‫⁬​‏‍⁫‭⁫‭‪‫⁪‌⁪​⁪⁭‎‏‮‭‌⁬⁫‏‮‮);
				this.u206b⁫​‬⁫‏‪‏‍‏‍​⁪⁯‌‭‭‍‪‮⁮⁯⁬‎‮‎⁪⁭‮​⁭‍‪⁪‮⁮​⁭⁯‫‮ = TetraPanel.u206f‍⁯⁮‌⁪‎⁮⁬‪⁫⁬‬‮⁯‏‪⁫⁯⁬‌⁫‍‭⁮‫‪⁫⁬⁬⁯‭‏‎⁮⁯⁯⁬‎⁪‮(1920, 4);
				this.u200f⁯‬‮⁫‪‬‪‮‍⁮⁮⁭⁯⁫‬‪⁮⁭‍⁮⁮‏‬⁬‏‭‫⁯⁯‎‏⁪‬‬‬‮⁮‎‏‮ = (float*)TetraPanel.u200c‏‬⁪⁯‌‍⁮⁫​‏‮⁪‎‍⁪⁮‬‏‭⁯​‪‏‫⁭⁪‌‍‬‏⁯‬‮⁪‪⁭‏⁭‏‮(this.u206b⁫​‬⁫‏‪‏‍‏‍​⁪⁯‌‭‭‍‪‮⁮⁯⁬‎‮‎⁪⁭‮​⁭‍‪⁪‮⁮​⁭⁯‫‮);
				this.u206a‏⁮‪⁬‪⁯‫​‭‬‪‬⁯​‎‌⁬⁭‍‬‭‪‮​‌‌⁭⁫‫​‏‏⁬⁮‎​‬‏‏‮ = TetraPanel.u206f‍⁯⁮‌⁪‎⁮⁬‪⁫⁬‬‮⁯‏‪⁫⁯⁬‌⁫‍‭⁮‫‪⁫⁬⁬⁯‭‏‎⁮⁯⁯⁬‎⁪‮(480, 4);
				this.u202a‍‌⁮⁮‫⁪⁫‪‌‫‌‌⁮⁬⁪‫‎⁫‍⁬‭‎‌‫‮⁪‎‬⁬‭‎‫​⁮​​⁬‌‭‮ = (float*)TetraPanel.u200c‏‬⁪⁯‌‍⁮⁫​‏‮⁪‎‍⁪⁮‬‏‭⁯​‪‏‫⁭⁪‌‍‬‏⁯‬‮⁪‪⁭‏⁭‏‮(this.u206a‏⁮‪⁬‪⁯‫​‭‬‪‬⁯​‎‌⁬⁭‍‬‭‪‮​‌‌⁭⁫‫​‏‏⁬⁮‎​‬‏‏‮);
				this.u206a⁮⁫‪‎‏⁪⁯⁭‌‮⁬‭‫‪‎‫‎‌‍⁬‏⁬‮⁪⁬‪‬⁭⁪‬‫‌‌‫⁫‎‌⁫‫‮ = TetraPanel.u206a⁪‎‮​‎⁮⁪‏‫‭‮‌⁯⁭⁯⁯‎‫‪‪‪​‍⁮‭‭‌​​‍‪⁬⁬‬⁮‪​⁯‮(0, 4080);
				this.u202c⁯⁯‏⁫‭‪‍‎⁫⁫‎⁯⁭‮‪⁪‌⁫‫⁭‎‪‌‎⁮‮⁬⁪⁯‪⁬‌‮‫⁫‏⁪‪‮‮ = TetraPanel.u200e‎‭‍‮‭‍‎‏⁪‭‬⁫⁫‍⁪‏‭‪⁬​⁮⁮​‏⁯‍​​‪‭‫⁮‏‫‎‏‮‎⁯‮(0);
				TetraPanel.u200d⁭⁮⁬‍⁮‌​‍‪‮‭⁭⁬‭‭‍‬⁬​‭⁬⁯‏‪⁭⁬‍‎⁯⁯‏⁯‭‏‭‬‌‌‮(this.u200e‎⁭‏‎‪‎‍‬⁭⁮⁬‍⁭‮​⁪‮‏‍⁪‎‫⁮‫⁭⁯⁪‌‌​‌⁬‫‏‬‍⁯⁮‭‮, this.u200b‍⁯⁪‌‍‍‎‪⁯⁮⁪‬⁯⁮⁮‍⁫‫⁭⁯​⁮⁮‫⁫‪‭‪⁪‪⁬⁫‬‎‌‎⁬‎⁫‮.AutoPlay);
				this.u206f‮⁫‫‏‎‮⁯⁪‎⁮​‏⁬⁭‏‍‮⁯⁭‌⁬⁯‬⁮⁯⁪⁪‌⁫⁯‍‍​⁫‎⁫‭‏⁬‮(null, null);
				TetraPanel.u206a‏⁫‫​‏⁪⁬⁪‪⁪⁬‬⁫⁯‎‪⁯‫‎⁯‪‭‎‮‪‎⁮⁯‭⁯‎⁮⁮‪‭⁫‬⁫⁬‮(this.u200e‎⁭‏‎‪‎‍‬⁭⁮⁬‍⁭‮​⁪‮‏‍⁪‎‫⁮‫⁭⁯⁪‌‌​‌⁬‫‏‬‍⁯⁮‭‮, !this.u200b‍⁯⁪‌‍‍‎‪⁯⁮⁪‬⁯⁮⁮‍⁫‫⁭⁯​⁮⁮‫⁫‪‭‪⁪‪⁬⁫‬‎‌‎⁬‎⁫‮.TttModeEnabled);
				TetraPanel.u206a‏⁫‫​‏⁪⁬⁪‪⁪⁬‬⁫⁯‎‪⁯‫‎⁯‪‭‎‮‪‎⁮⁯‭⁯‎⁮⁮‪‭⁫‬⁫⁬‮(this.u200c‎‎‪‎‮‎⁫‭‪⁯⁬⁪⁬‏‮‏‪‫‏⁯⁪​⁬‫⁯⁪‎‪‏‫‮⁯‏‪‭‬‏‪‮, this.u200b‍⁯⁪‌‍‍‎‪⁯⁮⁪‬⁯⁮⁮‍⁫‫⁭⁯​⁮⁮‫⁫‪‭‪⁪‪⁬⁫‬‎‌‎⁬‎⁫‮.TttModeEnabled);
				TetraPanel.GssiDisplayType = this.u200b‍⁯⁪‌‍‍‎‪⁯⁮⁪‬⁯⁮⁮‍⁫‫⁭⁯​⁮⁮‫⁫‪‭‪⁪‪⁬⁫‬‎‌‎⁬‎⁫‮.GssiDisplayType;
				TetraPanel._currentSource_SSI = 0;
				TetraPanel._currentSource_SSI_type = 0;
				TetraPanel._currentDestination_SSI = 0;
				TetraPanel._currentDestination_SSI_type = 0;
				TetraPanel.CurrentDmoCommunicationType = 0;
				string empty = string.Empty;
				try
				{
					string str = TetraPanel.u202e⁫⁫⁭​‌​‍‌‌​‪‬⁭⁮‭‬‬‭‫⁪‌‏‬‏‫‌‍⁯⁯⁭‬​‬‭​‏‪⁮⁫‮(TetraPanel.u206c‮⁪​⁭‪‮⁭⁪‬‬⁬‪⁮‫⁯⁭‏‎⁫‌‮‮‭‭⁫‌‭⁮‭⁬‮‬⁪‍‭‫‍⁮⁯‮());
					empty = u003cModuleu003e.u200f⁫‌​⁬‌‎‎‏‍‍⁫‎​‌‬⁯‬‫‭‎‏​‌​⁪‭‬⁬‮⁬​‌⁬⁪‫‫‎⁪⁮‮<string>(-1067139497);
					if (TetraPanel.u200f‫​‍‌‮‌​‍​‏‌‏⁬‍⁫⁯‌‏‬‬‪‏⁭‏‪⁮‍‪⁫⁪‬⁬⁪⁯⁫⁯‫‬‫‮(TetraPanel.u206a‬‍‬‍​‏‫‍‎‌‪⁭‍‭⁯‮‫⁪‮‮‫⁮⁮‪⁮‌‎‎⁬⁬‬‍‌‎‎‬⁭‍‌‮(str, u003cModuleu003e.u200d​‍⁮‏‭⁮⁪‌‪‬‬‬‪⁬⁭⁫⁫‬⁪⁬⁬⁬‏⁮⁭‌‍‏‍‏‎‬⁬​‪‎​‎⁭‮<string>(-663459947))))
					{
						try
						{
							empty = u003cModuleu003e.u202a‮‫‏‫‬‬‪⁫⁬​‏⁫⁭‍‪‪‎⁬​‪​‌⁮‮‌​⁫​⁬‪‫⁪⁯⁪‎‫⁭‎⁪‮<string>(124670063);
							this.u206a⁬⁬‮⁫‎‫⁮⁭‍‪⁮⁮‮​​⁯​‫‭‬⁬⁯‮⁪‫⁭‎⁫‏⁬⁭‪⁭⁫‏‫‏⁬‫‮ = TetraPanel.u200f‏‌⁪⁯​⁪‎‮⁭‫‭‫​‏⁪‮⁬‭​‎‮‭⁮‏‌⁪⁬‮‭‭⁪⁭‬⁭​‪‌⁫‏‮(TetraPanel.u206a‬‍‬‍​‏‫‍‎‌‪⁭‍‭⁯‮‫⁪‮‮‫⁮⁮‪⁮‌‎‎⁬⁬‬‍‌‎‎‬⁭‍‌‮(str, u003cModuleu003e.u202a‮‫‏‫‬‬‪⁫⁬​‏⁫⁭‍‪‪‎⁬​‪​‌⁮‮‌​⁫​⁬‪‫⁪⁯⁪‎‫⁭‎⁪‮<string>(505091384)), FileMode.Open);
							empty = u003cModuleu003e.u202a‮‫‏‫‬‬‪⁫⁬​‏⁫⁭‍‪‪‎⁬​‪​‌⁮‮‌​⁫​⁬‪‫⁪⁯⁪‎‫⁭‎⁪‮<string>(-807949879);
							TetraPanel.u206a⁫⁮⁪⁫‮‭‌‪‪‬‭‌​⁯‌‪‏‫⁫⁮‮‪‏‌‏‌⁪‌​⁯‍⁫‌‌​⁮​⁮⁪‮(this.u206a⁬⁬‮⁫‎‫⁮⁭‍‪⁮⁮‮​​⁯​‫‭‬⁬⁯‮⁪‫⁭‎⁫‏⁬⁭‪⁭⁫‏‫‏⁬‫‮);
							empty = u003cModuleu003e.u200e‏‌‬⁮‪‭⁭‭⁭‎​‏‌‭‭‭⁭⁬⁯⁫‍‮‫⁯‌‮‏​‬⁫⁯⁮⁫‮‪⁫‬⁮⁬‮<string>(-440188247);
							TetraPanel.u200f‌⁮⁮⁮⁭⁯⁭‮‬‪‭​‍⁭⁫⁪⁭‭‭‮‬⁬⁬‏‌‬‍‫⁬⁮‭⁬⁭‭⁬‭​‫⁫‮(TetraPanel.u206a‬‍‬‍​‏‫‍‎‌‪⁭‍‭⁯‮‫⁪‮‮‫⁮⁮‪⁮‌‎‎⁬⁬‬‍‌‎‎‬⁭‍‌‮(str, u003cModuleu003e.u200f⁫‌​⁬‌‎‎‏‍‍⁫‎​‌‬⁯‬‫‭‎‏​‌​⁪‭‬⁬‮⁬​‌⁬⁪‫‫‎⁪⁮‮<string>(-950109485)));
							empty = u003cModuleu003e.u206f⁮​‌‪‮‎‭‏‮‎⁮⁮‮⁬⁫‍‍⁪‍⁫⁮‏​‎⁬⁯⁪‪‍⁪⁮‎⁬⁪⁫​⁮⁪⁮‮<string>(-64555551);
							this.u206a⁬⁬‮⁫‎‫⁮⁭‍‪⁮⁮‮​​⁯​‫‭‬⁬⁯‮⁪‫⁭‎⁫‏⁬⁭‪⁭⁫‏‫‏⁬‫‮ = TetraPanel.u200b‍‭‎⁭⁬⁭‬⁭⁯⁬⁮⁫‌⁮⁪⁮‭⁭⁯⁮⁫⁬​‭‏‭⁬‭‫⁬‫‏‌‬​⁫‏‏‮(TetraPanel.u206a‬‍‬‍​‏‫‍‎‌‪⁭‍‭⁯‮‫⁪‮‮‫⁮⁮‪⁮‌‎‎⁬⁬‬‍‌‎‎‬⁭‍‌‮(str, u003cModuleu003e.u200d​‍⁮‏‭⁮⁪‌‪‬‬‬‪⁬⁭⁫⁫‬⁪⁬⁬⁬‏⁮⁭‌‍‏‍‏‎‬⁬​‪‎​‎⁭‮<string>(-663459947)), 1, FileOptions.DeleteOnClose);
							this.u200b‍⁯⁪‌‍‍‎‪⁯⁮⁪‬⁯⁮⁮‍⁫‫⁭⁯​⁮⁮‫⁫‪‭‪⁪‪⁬⁫‬‎‌‎⁬‎⁫‮.IsCc = true;
							TetraPanel.SdrSharpRole = u003cModuleu003e.u206f⁮​‌‪‮‎‭‏‮‎⁮⁮‮⁬⁫‍‍⁪‍⁫⁮‏​‎⁬⁯⁪‪‍⁪⁮‎⁬⁪⁫​⁮⁪⁮‮<string>(1556397503);
						}
						catch
						{
							this.u200b‍⁯⁪‌‍‍‎‪⁯⁮⁪‬⁯⁮⁮‍⁫‫⁭⁯​⁮⁮‫⁫‪‭‪⁪‪⁬⁫‬‎‌‎⁬‎⁫‮.IsCc = false;
							TetraPanel.SdrSharpRole = u003cModuleu003e.u200d​‍⁮‏‭⁮⁪‌‪‬‬‬‪⁬⁭⁫⁫‬⁪⁬⁬⁬‏⁮⁭‌‍‏‍‏‎‬⁬​‪‎​‎⁭‮<string>(-1273497222);
						}
					}
					else
					{
						this.u200b‍⁯⁪‌‍‍‎‪⁯⁮⁪‬⁯⁮⁮‍⁫‫⁭⁯​⁮⁮‫⁫‪‭‪⁪‪⁬⁫‬‎‌‎⁬‎⁫‮.IsCc = true;
						empty = u003cModuleu003e.u206f⁮​‌‪‮‎‭‏‮‎⁮⁮‮⁬⁫‍‍⁪‍⁫⁮‏​‎⁬⁯⁪‪‍⁪⁮‎⁬⁪⁫​⁮⁪⁮‮<string>(1597319094);
						this.u206a⁬⁬‮⁫‎‫⁮⁭‍‪⁮⁮‮​​⁯​‫‭‬⁬⁯‮⁪‫⁭‎⁫‏⁬⁭‪⁭⁫‏‫‏⁬‫‮ = TetraPanel.u200b‍‭‎⁭⁬⁭‬⁭⁯⁬⁮⁫‌⁮⁪⁮‭⁭⁯⁮⁫⁬​‭‏‭⁬‭‫⁬‫‏‌‬​⁫‏‏‮(TetraPanel.u206a‬‍‬‍​‏‫‍‎‌‪⁭‍‭⁯‮‫⁪‮‮‫⁮⁮‪⁮‌‎‎⁬⁬‬‍‌‎‎‬⁭‍‌‮(str, u003cModuleu003e.u200f⁫‌​⁬‌‎‎‏‍‍⁫‎​‌‬⁯‬‫‭‎‏​‌​⁪‭‬⁬‮⁬​‌⁬⁪‫‫‎⁪⁮‮<string>(-950109485)), 1, FileOptions.DeleteOnClose);
						TetraPanel.SdrSharpRole = u003cModuleu003e.u200f⁫‌​⁬‌‎‎‏‍‍⁫‎​‌‬⁯‬‫‭‎‏​‌​⁪‭‬⁬‮⁬​‌⁬⁪‫‫‎⁪⁮‮<string>(-1113968574);
					}
					TetraPanel.BroadcastPort = this.u200b‍⁯⁪‌‍‍‎‪⁯⁮⁪‬⁯⁮⁮‍⁫‫⁭⁯​⁮⁮‫⁫‪‭‪⁪‪⁬⁫‬‎‌‎⁬‎⁫‮.TttUdpPort + 2;
					TetraPanel.IsTttUsed = this.u200b‍⁯⁪‌‍‍‎‪⁯⁮⁪‬⁯⁮⁮‍⁫‫⁭⁯​⁮⁮‫⁫‪‭‪⁪‪⁬⁫‬‎‌‎⁬‎⁫‮.TttModeEnabled;
				}
				catch (Exception exception1)
				{
					Exception exception = exception1;
					TetraPanel.u200c⁬‫‭‌⁮⁫⁬⁭‍⁪‎‌‮⁯‏​⁭​‍‭‌‭‪⁬​‮‌‏‪​‫‏‪​‫‪⁪⁮⁭‮(TetraPanel.u202c‍‭​​‎‏​‭‬‮​‌‮‎⁬‌‫‎⁫⁬‎⁯‮‪‮‍⁯⁭‏‏⁪‏⁫‮⁫‬⁯‮‮(new string[] { u003cModuleu003e.u200f⁫‌​⁬‌‎‎‏‍‍⁫‎​‌‬⁯‬‫‭‎‏​‌​⁪‭‬⁬‮⁬​‌⁬⁪‫‫‎⁪⁮‮<string>(1870296732), empty, TetraPanel.u206b‬‮⁪‮‬‭‏⁯​‫‭‫‮⁭‏‮‎‭⁮‭⁯‫‎‭⁮‏‮​‬‎‎⁪‍‏‏⁫​⁯‮‮(), u003cModuleu003e.u200f⁫‌​⁬‌‎‎‏‍‍⁫‎​‌‬⁯‬‫‭‎‏​‌​⁪‭‬⁬‮⁬​‌⁬⁪‫‫‎⁪⁮‮<string>(2045841750), TetraPanel.u206b‬‮⁪‮‬‭‏⁯​‫‭‫‮⁭‏‮‎‭⁮‭⁯‫‎‭⁮‏‮​‬‎‎⁪‍‏‏⁫​⁯‮‮(), TetraPanel.u206b‬‮⁪‮‬‭‏⁯​‫‭‫‮⁭‏‮‎‭⁮‭⁯‫‎‭⁮‏‮​‬‎‎⁪‍‏‏⁫​⁯‮‮(), TetraPanel.u200b‮‍‏‬⁬​‏⁬⁮‭‎‎‭⁪​‬​‏​‌‫⁪‮‬‍​⁯‫‌‎​⁭⁯⁭‍‭⁯‫‮‮(exception) }));
					return;
				}
				this.u206a‌‭‪‍‪⁯⁯⁫‭​‪⁭⁮‫⁮⁬⁮‌⁭⁭‎‎⁭‌‏⁭⁯⁫‎‎⁯‍‫⁮⁯‮‎‬⁬‮ = new u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮(sharpControl, this);
				this.ServerControl(true);
			}
			catch (Exception exception3)
			{
				Exception exception2 = exception3;
				TetraPanel.u200c⁬‫‭‌⁮⁫⁬⁭‍⁪‎‌‮⁯‏​⁭​‍‭‌‭‪⁬​‮‌‏‪​‫‏‪​‫‪⁪⁮⁭‮(TetraPanel.u206e‌‪‎‍‬⁪‪‍‎‎⁪‌⁪‌‎⁪‮⁮⁯‮‌⁬​‪‌⁭‏‪‭‪‎⁬‮‪⁪‏⁬⁬‭‮(u003cModuleu003e.u200d​‍⁮‏‭⁮⁪‌‪‬‬‬‪⁬⁭⁫⁫‬⁪⁬⁬⁬‏⁮⁭‌‍‏‍‏‎‬⁬​‪‎​‎⁭‮<string>(1138603150), TetraPanel.u206b‬‮⁪‮‬‭‏⁯​‫‭‫‮⁭‏‮‎‭⁮‭⁯‫‎‭⁮‏‮​‬‎‎⁪‍‏‏⁫​⁯‮‮(), TetraPanel.u200b‮‍‏‬⁬​‏⁬⁮‭‎‎‭⁪​‬​‏​‌‫⁪‮‬‍​⁯‫‌‎​⁭⁯⁭‍‭⁯‫‮‮(exception2)));
			}
		}

		public unsafe void AudioSamplesNedeed(float* samples, double samplerate, int length)
		{
			// 
			// Current member / type: System.Void SDRSharp.Tetra.TetraPanel::AudioSamplesNedeed(System.Single*,System.Double,System.Int32)
			// File path: C:\SDRSharp\Plugins\Tetra\SDRSharp.Tetra.dll
			// 
			// Product version: 0.0.0.0
			// Exception in: System.Void AudioSamplesNedeed(System.Single*,System.Double,System.Int32)
			// 
			// Not supported type System.Object.
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.GetTypeIndex(TypeDefinition type) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 684
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.GetContainingType(TypeDefinition leftType, TypeDefinition rightType) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 608
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.GetExpressionType() in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 492
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.get_ExpressionType() in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 414
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.AddAssignmentCastIfNeeded(Expression expr) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\TypeInference\TypeInferer.cs:line 112
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.FixAssignmentInList(IList`1 expressionList, Expression value) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\TypeInference\TypeInferer.cs:line 75
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.AddCasts() in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\TypeInference\TypeInferer.cs:line 38
			//    at Telerik.JustDecompiler.Decompiler.ExpressionDecompilerStep.Process(DecompilationContext theContext, BlockStatement body) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\ExpressionDecompilerStep.cs:line 68
			//    at Telerik.JustDecompiler.Decompiler.DecompilationPipeline.RunInternal(MethodBody body, BlockStatement block, ILanguage language) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\DecompilationPipeline.cs:line 100
			//    at Telerik.JustDecompiler.Decompiler.WriterContextServices.BaseWriterContextService.DecompileMethod(ILanguage language, MethodDefinition method, TypeSpecificContext typeContext) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\WriterContextServices\BaseWriterContextService.cs:line 133
			// 
			// mailto: JustDecompilePublicFeedback@telerik.com

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void DeleteRoleFile()
		{
			// 
			// Current member / type: System.Void SDRSharp.Tetra.TetraPanel::DeleteRoleFile()
			// File path: C:\SDRSharp\Plugins\Tetra\SDRSharp.Tetra.dll
			// 
			// Product version: 0.0.0.0
			// Exception in: System.Void DeleteRoleFile()
			// 
			// Not supported type System.Object.
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.GetTypeIndex(TypeDefinition type) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 684
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.GetContainingType(TypeDefinition leftType, TypeDefinition rightType) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 608
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.GetExpressionType() in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 492
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.get_ExpressionType() in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 414
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.AddAssignmentCastIfNeeded(Expression expr) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\TypeInference\TypeInferer.cs:line 112
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.FixAssignmentInList(IList`1 expressionList, Expression value) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\TypeInference\TypeInferer.cs:line 75
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.AddCasts() in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\TypeInference\TypeInferer.cs:line 38
			//    at Telerik.JustDecompiler.Decompiler.ExpressionDecompilerStep.Process(DecompilationContext theContext, BlockStatement body) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\ExpressionDecompilerStep.cs:line 68
			//    at Telerik.JustDecompiler.Decompiler.DecompilationPipeline.RunInternal(MethodBody body, BlockStatement block, ILanguage language) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\DecompilationPipeline.cs:line 100
			//    at Telerik.JustDecompiler.Decompiler.WriterContextServices.BaseWriterContextService.DecompileMethod(ILanguage language, MethodDefinition method, TypeSpecificContext typeContext) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\WriterContextServices\BaseWriterContextService.cs:line 133
			// 
			// mailto: JustDecompilePublicFeedback@telerik.com

		}

		protected override void Dispose(bool disposing)
		{
			int num;
			int num1;
			if (!disposing)
			{
				goto Label0;
			}
		Label2:
			num = -425456139;
		Label4:
			while (true)
			{
				int num2 = num ^ -1242819420;
				uint num3 = (uint)num2;
				switch (num2 % 5)
				{
					case 0:
					{
						TetraPanel.u202b​⁭‪⁬‫⁮⁫⁫⁭‫‭⁭‪‍‪‭‪​⁪‭‍‌‫⁮‮‌‎‫‌‭⁮⁭‬⁭‍⁫‍⁬⁫‮(this.u200c⁫⁯⁬‪‌‬‭‫‭​‪​⁯‮⁪‫⁫⁯⁪‏‌⁬⁮‬‌‬⁭‭⁮⁯‮‬⁮‏‫⁯​‭‏‮);
						num = (int)(num3 * 2115900337 ^ 1306711190);
						continue;
					}
					case 1:
					{
						num1 = (this.u200c⁫⁯⁬‪‌‬‭‫‭​‪​⁯‮⁪‫⁫⁯⁪‏‌⁬⁮‬‌‬⁭‭⁮⁯‮‬⁮‏‫⁯​‭‏‮ == null ? -1324696726 : -824164280);
						num = (int)(num1 ^ num3 * -226278401);
						continue;
					}
					case 2:
					{
						return;
					}
					case 3:
					{
						goto Label2;
					}
					case 4:
					{
						break;
					}
					default:
					{
						return;
					}
				}
			}
		Label0:
			base.Dispose(disposing);
			num = -503795258;
			goto Label4;
		}

		public unsafe void IQSamplesAvailable(Complex* samples, double samplerate, int length)
		{
			// 
			// Current member / type: System.Void SDRSharp.Tetra.TetraPanel::IQSamplesAvailable(SDRSharp.Radio.Complex*,System.Double,System.Int32)
			// File path: C:\SDRSharp\Plugins\Tetra\SDRSharp.Tetra.dll
			// 
			// Product version: 0.0.0.0
			// Exception in: System.Void IQSamplesAvailable(SDRSharp.Radio.Complex*,System.Double,System.Int32)
			// 
			// Not supported type System.Object.
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.GetTypeIndex(TypeDefinition type) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 684
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.GetContainingType(TypeDefinition leftType, TypeDefinition rightType) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 608
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.GetExpressionType() in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 492
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.get_ExpressionType() in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 414
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.AddAssignmentCastIfNeeded(Expression expr) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\TypeInference\TypeInferer.cs:line 112
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.FixAssignmentInList(IList`1 expressionList, Expression value) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\TypeInference\TypeInferer.cs:line 75
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.AddCasts() in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\TypeInference\TypeInferer.cs:line 38
			//    at Telerik.JustDecompiler.Decompiler.ExpressionDecompilerStep.Process(DecompilationContext theContext, BlockStatement body) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\ExpressionDecompilerStep.cs:line 68
			//    at Telerik.JustDecompiler.Decompiler.DecompilationPipeline.RunInternal(MethodBody body, BlockStatement block, ILanguage language) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\DecompilationPipeline.cs:line 100
			//    at Telerik.JustDecompiler.Decompiler.WriterContextServices.BaseWriterContextService.DecompileMethod(ILanguage language, MethodDefinition method, TypeSpecificContext typeContext) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\WriterContextServices\BaseWriterContextService.cs:line 133
			// 
			// mailto: JustDecompilePublicFeedback@telerik.com

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public string ParseStringToEntries(string entryString, CallsEntry call)
		{
			// 
			// Current member / type: System.String SDRSharp.Tetra.TetraPanel::ParseStringToEntries(System.String,SDRSharp.Tetra.CallsEntry)
			// File path: C:\SDRSharp\Plugins\Tetra\SDRSharp.Tetra.dll
			// 
			// Product version: 0.0.0.0
			// Exception in: System.String ParseStringToEntries(System.String,SDRSharp.Tetra.CallsEntry)
			// 
			// Not supported type System.Object.
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.GetTypeIndex(TypeDefinition type) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 684
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.GetContainingType(TypeDefinition leftType, TypeDefinition rightType) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 608
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.GetExpressionType() in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 492
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.get_ExpressionType() in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 414
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.AddAssignmentCastIfNeeded(Expression expr) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\TypeInference\TypeInferer.cs:line 112
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.FixAssignmentInList(IList`1 expressionList, Expression value) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\TypeInference\TypeInferer.cs:line 75
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.AddCasts() in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\TypeInference\TypeInferer.cs:line 38
			//    at Telerik.JustDecompiler.Decompiler.ExpressionDecompilerStep.Process(DecompilationContext theContext, BlockStatement body) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\ExpressionDecompilerStep.cs:line 68
			//    at Telerik.JustDecompiler.Decompiler.DecompilationPipeline.RunInternal(MethodBody body, BlockStatement block, ILanguage language) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\DecompilationPipeline.cs:line 100
			//    at Telerik.JustDecompiler.Decompiler.WriterContextServices.BaseWriterContextService.DecompileMethod(ILanguage language, MethodDefinition method, TypeSpecificContext typeContext) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\WriterContextServices\BaseWriterContextService.cs:line 133
			// 
			// mailto: JustDecompilePublicFeedback@telerik.com

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public string ParseStringToPath(string nameString, string extension)
		{
			// 
			// Current member / type: System.String SDRSharp.Tetra.TetraPanel::ParseStringToPath(System.String,System.String)
			// File path: C:\SDRSharp\Plugins\Tetra\SDRSharp.Tetra.dll
			// 
			// Product version: 0.0.0.0
			// Exception in: System.String ParseStringToPath(System.String,System.String)
			// 
			// Not supported type System.Object.
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.GetTypeIndex(TypeDefinition type) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 684
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.GetContainingType(TypeDefinition leftType, TypeDefinition rightType) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 608
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.GetExpressionType() in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 492
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.get_ExpressionType() in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 414
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.AddAssignmentCastIfNeeded(Expression expr) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\TypeInference\TypeInferer.cs:line 112
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.FixAssignmentInList(IList`1 expressionList, Expression value) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\TypeInference\TypeInferer.cs:line 75
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.AddCasts() in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\TypeInference\TypeInferer.cs:line 38
			//    at Telerik.JustDecompiler.Decompiler.ExpressionDecompilerStep.Process(DecompilationContext theContext, BlockStatement body) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\ExpressionDecompilerStep.cs:line 68
			//    at Telerik.JustDecompiler.Decompiler.DecompilationPipeline.RunInternal(MethodBody body, BlockStatement block, ILanguage language) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\DecompilationPipeline.cs:line 100
			//    at Telerik.JustDecompiler.Decompiler.WriterContextServices.BaseWriterContextService.DecompileMethod(ILanguage language, MethodDefinition method, TypeSpecificContext typeContext) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\WriterContextServices\BaseWriterContextService.cs:line 133
			// 
			// mailto: JustDecompilePublicFeedback@telerik.com

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SaveSettings()
		{
			// 
			// Current member / type: System.Void SDRSharp.Tetra.TetraPanel::SaveSettings()
			// File path: C:\SDRSharp\Plugins\Tetra\SDRSharp.Tetra.dll
			// 
			// Product version: 0.0.0.0
			// Exception in: System.Void SaveSettings()
			// 
			// Not supported type System.Object.
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.GetTypeIndex(TypeDefinition type) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 684
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.GetContainingType(TypeDefinition leftType, TypeDefinition rightType) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 608
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.GetExpressionType() in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 492
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.get_ExpressionType() in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 414
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.AddAssignmentCastIfNeeded(Expression expr) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\TypeInference\TypeInferer.cs:line 112
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.FixAssignmentInList(IList`1 expressionList, Expression value) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\TypeInference\TypeInferer.cs:line 75
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.AddCasts() in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\TypeInference\TypeInferer.cs:line 38
			//    at Telerik.JustDecompiler.Decompiler.ExpressionDecompilerStep.Process(DecompilationContext theContext, BlockStatement body) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\ExpressionDecompilerStep.cs:line 68
			//    at Telerik.JustDecompiler.Decompiler.DecompilationPipeline.RunInternal(MethodBody body, BlockStatement block, ILanguage language) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\DecompilationPipeline.cs:line 100
			//    at Telerik.JustDecompiler.Decompiler.WriterContextServices.BaseWriterContextService.DecompileMethod(ILanguage language, MethodDefinition method, TypeSpecificContext typeContext) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\WriterContextServices\BaseWriterContextService.cs:line 133
			// 
			// mailto: JustDecompilePublicFeedback@telerik.com

		}

		public void ServerControl(bool startServer)
		{
			// 
			// Current member / type: System.Void SDRSharp.Tetra.TetraPanel::ServerControl(System.Boolean)
			// File path: C:\SDRSharp\Plugins\Tetra\SDRSharp.Tetra.dll
			// 
			// Product version: 0.0.0.0
			// Exception in: System.Void ServerControl(System.Boolean)
			// 
			// Not supported type System.Object.
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.GetTypeIndex(TypeDefinition type) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 684
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.GetContainingType(TypeDefinition leftType, TypeDefinition rightType) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 608
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.GetExpressionType() in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 492
			//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.get_ExpressionType() in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 414
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.AddAssignmentCastIfNeeded(Expression expr) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\TypeInference\TypeInferer.cs:line 112
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.FixAssignmentInList(IList`1 expressionList, Expression value) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\TypeInference\TypeInferer.cs:line 75
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.AddCasts() in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\TypeInference\TypeInferer.cs:line 38
			//    at Telerik.JustDecompiler.Decompiler.ExpressionDecompilerStep.Process(DecompilationContext theContext, BlockStatement body) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\ExpressionDecompilerStep.cs:line 68
			//    at Telerik.JustDecompiler.Decompiler.DecompilationPipeline.RunInternal(MethodBody body, BlockStatement block, ILanguage language) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\DecompilationPipeline.cs:line 100
			//    at Telerik.JustDecompiler.Decompiler.WriterContextServices.BaseWriterContextService.DecompileMethod(ILanguage language, MethodDefinition method, TypeSpecificContext typeContext) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\WriterContextServices\BaseWriterContextService.cs:line 133
			// 
			// mailto: JustDecompilePublicFeedback@telerik.com

		}
	}
}