using SDRSharp.Radio;
using SDRSharp.Tetra;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;

// ‪‍‎‎‪‍⁬⁭‬‌‎⁬‎‭‪‬‬​⁭⁬⁮‏‏‪‏‏‏‬⁬‭⁫​‎‎‭‎​‎‬⁬‮
internal class u202a‍‎‎‪‍⁬⁭‬‌‎⁬‎‭‪‬‬​⁭⁬⁮‏‏‪‏‏‏‬⁬‭⁫​‎‎‭‎​‎‬⁬‮
{
	// ‌‏⁭⁫‫‌‌⁯‬‍⁫⁮⁬​‌‍‪⁭‌‪‍‫⁮‮⁭⁬⁬​‮‍‫⁪‌​‭‍‫‫‮⁮‮
	private PhyLevel u200c‏⁭⁫‫‌‌⁯‬‍⁫⁮⁬​‌‍‪⁭‌‪‍‫⁮‮⁭⁬⁬​‮‍‫⁪‌​‭‍‫‫‮⁮‮ = new PhyLevel();

	// ⁫‎​⁪‬⁮‭‏‎⁮⁯​⁬⁯⁬⁪‬‫‎​‏‏‎‮‌‮⁯‭​‎‫‫‪‭⁯‫⁬‏⁫‎‮
	private u202a⁬⁪⁫⁫⁮‎‮⁪‌⁮‮‪‌⁪‎‏⁭⁪‌⁫⁮⁫‎⁮⁭‭‭‌‪‭‌​‏⁮‍⁪‬⁪‍‮ u206b‎​⁪‬⁮‭‏‎⁮⁯​⁬⁯⁬⁪‬‫‎​‏‏‎‮‌‮⁯‭​‎‫‫‪‭⁯‫⁬‏⁫‎‮ = new u202a⁬⁪⁫⁫⁮‎‮⁪‌⁮‮‪‌⁪‎‏⁭⁪‌⁫⁮⁫‎⁮⁭‭‭‌‪‭‌​‏⁮‍⁪‬⁪‍‮();

	// ‏⁯⁭‬‪‫‌⁬⁪⁮‍⁮⁪‫⁫‮⁬‌‮⁫⁯⁬​⁫‭‫⁪⁭‏⁬‪‫⁪‮⁯‮⁬⁪⁫⁯‮
	private u200b‎‫⁮‭‏‏⁮⁫⁫‭‍‏‮‬‪‮⁮‎⁯‪⁯⁬‍‮⁮‫‎‮‏‎​⁮‏‫‫⁪‍‫‬‮ u200f⁯⁭‬‪‫‌⁬⁪⁮‍⁮⁪‫⁫‮⁬‌‮⁫⁯⁬​⁫‭‫⁪⁭‏⁬‪‫⁪‮⁯‮⁬⁪⁫⁯‮ = new u200b‎‫⁮‭‏‏⁮⁫⁫‭‍‏‮‬‪‮⁮‎⁯‪⁯⁬‍‮⁮‫‎‮‏‎​⁮‏‫‫⁪‍‫‬‮();

	// ‫‎⁬⁬‭⁭‍⁭⁬⁮‭​‍‌‪‬‏‪‬‬‌‍‏‭⁬⁭‫‮‍⁪⁭​‏⁮‪⁬⁭​⁮⁫‮
	private LogicChannel u202b‎⁬⁬‭⁭‍⁭⁬⁮‭​‍‌‪‬‏‪‬‬‌‍‏‭⁬⁭‫‮‍⁪⁭​‏⁮‪⁬⁭​⁮⁫‮ = new LogicChannel();

	// ‮⁮‪‪‏‎‏‏‍⁭‌⁯‏⁭‮‮‭‎‏​‭⁪‬⁬⁮⁪​‪⁬​‪​‌⁫‬‫⁫​⁪⁪‮
	private u206f‬⁪‌‌​‌​‌‭‍​‭‎‭⁫‭⁪‫⁭‎⁭⁫⁯​‎⁭‬‌‪‌‎⁬⁮⁯​⁮⁫‎⁭‮ u202e⁮‪‪‏‎‏‏‍⁭‌⁯‏⁭‮‮‭‎‏​‭⁪‬⁬⁮⁪​‪⁬​‪​‌⁫‬‫⁫​⁪⁪‮ = new u206f‬⁪‌‌​‌​‌‭‍​‭‎‭⁫‭⁪‫⁭‎⁭⁫⁯​‎⁭‬‌‪‌‎⁬⁮⁯​⁮⁫‎⁭‮();

	// ‫‎⁫​⁪⁮‌​⁮‮‮​‍‮⁭⁯‌‫​‫⁬‎‌⁮‬‍‌​⁯⁭⁭​‫‪⁮‍⁭⁬‫‪‮
	private u206d‎​⁪⁪‎‫‪​‭‫⁮‌‍‬⁭⁯‏‌⁭​‌‪‌‬⁭⁫‮‬⁪‏⁫⁪‫‫‬‬‬‪‪‮ u202b‎⁫​⁪⁮‌​⁮‮‮​‍‮⁭⁯‌‫​‫⁬‎‌⁮‬‍‌​⁯⁭⁭​‫‪⁮‍⁭⁬‫‪‮ = new u206d‎​⁪⁪‎‫‪​‭‫⁮‌‍‬⁭⁯‏‌⁭​‌‪‌‬⁭⁫‮‬⁪‏⁫⁪‫‫‬‬‬‪‪‮();

	// ‫⁪⁭‏‏‌‌‏‌‏⁭‮⁫​‍⁮​‍‮⁭‭⁬‫‎⁭⁪​‎‫‮‮‪‫‫​‍‫‫​‌‮
	private UnsafeBuffer u202b⁪⁭‏‏‌‌‏‌‏⁭‮⁫​‍⁮​‍‮⁭‭⁬‫‎⁭⁪​‎‫‮‮‪‫‫​‍‫‫​‌‮;

	// ‌‎⁯⁪⁬‭⁪⁯⁪⁮⁬‬‍‮⁯⁮‌‌⁯‮‏⁮⁭‬‫‏⁬‍⁬‎‫‪⁭‎⁯⁬​⁪⁭⁬‮
	private unsafe byte* u200c‎⁯⁪⁬‭⁪⁯⁪⁮⁬‬‍‮⁯⁮‌‌⁯‮‏⁮⁭‬‫‏⁬‍⁬‎‫‪⁭‎⁯⁬​⁪⁭⁬‮;

	// ⁮‍⁯⁬‪⁪⁮⁭‌‭‫‏⁫‫‌​‪‏⁬‏‭‭‪‬‭‎⁯‭‌‏‬⁮‬‮‮‮⁪⁮⁬‌‮
	private UnsafeBuffer u206e‍⁯⁬‪⁪⁮⁭‌‭‫‏⁫‫‌​‪‏⁬‏‭‭‪‬‭‎⁯‭‌‏‬⁮‬‮‮‮⁪⁮⁬‌‮;

	// ‪⁪‎‌‬⁭‍‭‮‮‌‬⁪‭⁭⁭⁯​​⁪‎‫⁯⁬⁮⁫⁭⁮‮‫‏⁭‫‍‏⁭‪⁫‪⁯‮
	private unsafe byte* u202a⁪‎‌‬⁭‍‭‮‮‌‬⁪‭⁭⁭⁯​​⁪‎‫⁯⁬⁮⁫⁭⁮‮‫‏⁭‫‍‏⁭‪⁫‪⁯‮;

	// ‍‪⁭‏⁫‫‪‏⁫‬‭‏‮⁭‫‏⁪‬​‫⁯‫⁮‫⁬⁮⁪‭⁪⁭‏‌⁭‏‬‮‪⁭‮⁯‮
	private UnsafeBuffer u200d‪⁭‏⁫‫‪‏⁫‬‭‏‮⁭‫‏⁪‬​‫⁯‫⁮‫⁬⁮⁪‭⁪⁭‏‌⁭‏‬‮‪⁭‮⁯‮;

	// ‭⁮⁮​​‭⁮⁪⁯⁮⁮⁮‪‬⁫⁫⁬⁪‮‮⁮⁭‌‭‭⁭​‭‬‪⁮‮‎⁬⁭⁬⁪‎‬⁬‮
	private unsafe byte* u202d⁮⁮​​‭⁮⁪⁯⁮⁮⁮‪‬⁫⁫⁬⁪‮‮⁮⁭‌‭‭⁭​‭‬‪⁮‮‎⁬⁭⁬⁪‎‬⁬‮;

	// ⁪‎‬‏‮‬⁪⁬‬‫‏⁭‎⁯‮⁮⁫‌​‪‭⁬‏‎‏‮‬⁯‮‌⁭‪‬‎⁬‏⁪​⁪‍‮
	private UnsafeBuffer u206a‎‬‏‮‬⁪⁬‬‫‏⁭‎⁯‮⁮⁫‌​‪‭⁬‏‎‏‮‬⁯‮‌⁭‪‬‎⁬‏⁪​⁪‍‮;

	// ‮‮‭⁮​‭‬​⁮‫⁭‌⁬‌⁭⁭‌⁮‌⁫‭‪‫‬⁬⁯‫⁫‮⁮‏⁬⁪⁫‎⁫​‏‍‭‮
	private unsafe byte* u202e‮‭⁮​‭‬​⁮‫⁭‌⁬‌⁭⁭‌⁮‌⁫‭‪‫‬⁬⁯‫⁫‮⁮‏⁬⁪⁫‎⁫​‏‍‭‮;

	// ⁪‍⁮‮​⁮‭⁬⁯‎‬⁯‏‭⁪​‬‏⁮‮‬‍‫‫‪‬⁪‪⁭⁯‫‭‏⁫‎‭‫‎⁪‬‮
	private Dictionary<GlobalNames, int> u206a‍⁮‮​⁮‭⁬⁯‎‬⁯‏‭⁪​‬‏⁮‮‬‍‫‫‪‬⁪‪⁭⁯‫‭‏⁫‎‭‫‎⁪‬‮ = new Dictionary<GlobalNames, int>();

	// ‮⁯⁭⁮‬‫⁭⁯‫⁫‌‪‍‍‏⁫⁫⁯⁮‎‎‪‭‬‌‌‮⁪⁯‎⁬⁬‭‭⁮⁯‪‭‬‏‮
	private List<Dictionary<GlobalNames, int>> u202e⁯⁭⁮‬‫⁭⁯‫⁫‌‪‍‍‏⁫⁫⁯⁮‎‎‪‭‬‌‌‮⁪⁯‎⁬⁬‭‭⁮⁯‪‭‬‏‮ = new List<Dictionary<GlobalNames, int>>();

	// ‭‭⁯‬‌‪‌⁯​‌‍‭‍‫‎‮‭⁫⁯‏‬‍⁯‍‫‮⁮⁮‫⁫⁪⁬⁭​⁭‫⁫‌⁯⁬‮
	private Dictionary<GlobalNames, int> u202d‭⁯‬‌‪‌⁯​‌‍‭‍‫‎‮‭⁫⁯‏‬‍⁯‍‫‮⁮⁮‫⁫⁪⁬⁭​⁭‫⁫‌⁯⁬‮ = new Dictionary<GlobalNames, int>();

	// ⁭⁭⁬‬‮‍‭⁫⁪‭⁭⁮‏‮‌‌⁭‏⁭‮​‏‪⁭⁯‫⁬⁭⁪‬‌‎‏⁭‭‮‫‏⁪‭‮
	private Dictionary<GlobalNames, int> u206d⁭⁬‬‮‍‭⁫⁪‭⁭⁮‏‮‌‌⁭‏⁭‮​‏‪⁭⁯‫⁬⁭⁪‬‌‎‏⁭‭‮‫‏⁪‭‮ = new Dictionary<GlobalNames, int>();

	// ‪⁫‮‭⁭‮⁬‍‏​‭‏‭‎‭⁮‪‬⁫⁭‪‪‌‮⁬‮‌⁮⁮⁬⁪‫⁭‭⁭​‎‍‫‮
	private double u202a⁫‮‭⁭‮⁬‍‏​‭‏‭‎‭⁮‪‬⁫⁭‪‪‌‮⁬‮‌⁮⁮⁬⁪‫⁭‭⁭​‎‍‫‮;

	// ‬⁬⁬⁯⁯‎⁯‌‫⁬⁭⁫‭⁯⁯‭​​⁮‬⁫⁬‍⁪⁯‎‎‎⁫⁬⁪‪⁪‍⁬​⁫⁪‭‎‮
	private double u202c⁬⁬⁯⁯‎⁯‌‫⁬⁭⁫‭⁯⁯‭​​⁮‬⁫⁬‍⁪⁯‎‎‎⁫⁬⁪‪⁪‍⁬​⁫⁪‭‎‮;

	// ‌‪‪‌⁭‍‎‬⁫‍‫⁪‎⁬⁮‎⁪‍‌‬⁫‮⁪​‬‬‎​‪‮⁯‫‎‍⁮​‫​⁭⁫‮
	private double u200c‪‪‌⁭‍‎‬⁫‍‫⁪‎⁬⁮‎⁪‍‌‬⁫‮⁪​‬‬‎​‪‮⁯‫‎‍⁮​‫​⁭⁫‮;

	// ‬⁮‍⁯‍⁬⁬‌⁯⁪⁮‫⁯⁫‫‎⁯‬⁯⁯‫⁫‍‭‏‎​⁭‎‭‌​⁪‬‏‍‍​⁮‎‮
	private const int u202c⁮‍⁯‍⁬⁬‌⁯⁪⁮‫⁯⁫‫‎⁯‬⁯⁯‫⁫‍‭‏‎​⁭‎‭‌​⁪‬‏‍‍​⁮‎‮ = 40;

	// ‭‪⁮‌⁪‫‮‭​⁪‌‏⁪‭‪‪⁮⁭⁯​⁫‪‫⁯‮​‮‮​‪‌‌⁯‪‭⁬⁫​‎⁯‮
	private int u202d‪⁮‌⁪‫‮‭​⁪‌‏⁪‭‪‪⁮⁭⁯​⁫‪‫⁯‮​‮‮​‪‌‌⁯‪‭⁬⁫​‎⁯‮ = 40;

	// ⁯‬‪⁮​‎⁯⁫‭‏‪‎⁭‫​‎⁪⁯⁪⁪‏⁮​⁯⁭‎⁪‏⁮⁮​‍⁪‮‬‪⁭⁪‭‍‮
	private int u206f‬‪⁮​‎⁯⁫‭‏‪‎⁭‫​‎⁪⁯⁪⁪‏⁮​⁯⁭‎⁪‏⁮⁮​‍⁪‮‬‪⁭⁪‭‍‮ = 40;

	// ​‍⁬‍⁫‫‮‌‍⁪⁭⁯⁫‏​⁯‎‏‍‭‫⁬⁭‌‬⁯‍‭‮‍⁬‏​‭⁫‌⁬‌⁬‌‮
	private int u200b‍⁬‍⁫‫‮‌‍⁪⁭⁯⁫‏​⁯‎‏‍‭‫⁬⁭‌‬⁯‍‭‮‍⁬‏​‭⁫‌⁬‌⁬‌‮ = 40;

	// ‪⁫‎​⁫‫⁬‍‪‏⁮⁫​⁬⁪‮‮⁪​​⁪‫‪‍‭​‪‭⁮⁪‪‪⁪⁪⁫‍⁭‬‌‬‮
	private int u202a⁫‎​⁫‫⁬‍‪‏⁮⁫​⁬⁪‮‮⁪​​⁪‫‪‍‭​‪‭⁮⁪‪‪⁪⁪⁫‍⁭‬‌‬‮ = 40;

	// ‪‮⁫‌‭‮⁬⁫⁬⁯‭‫‭‎​‌‌‏⁮⁫⁮⁪⁯‮‮‍‭‭⁪‭⁬‍‍⁭‏⁮‪⁫⁪‎‮
	private bool u202a‮⁫‌‭‮⁬⁫⁬⁯‭‫‭‎​‌‌‏⁮⁫⁮⁪⁯‮‮‍‭‭⁪‭⁬‍‍⁭‏⁮‪⁫⁪‎‮;

	// ‬​⁫‍‬⁯⁯‮⁮‭‏‪‌⁮‮⁮⁬‍⁫‏‭‫⁬⁪‭‫‭‪⁪‪⁭‪⁮‏‎⁪⁬‬‎‮
	private int u202c​⁫‍‬⁯⁯‮⁮‭‏‪‌⁮‮⁮⁬‍⁫‏‭‫⁬⁪‭‫‭‪⁪‪⁭‪⁮‏‎⁪⁬‬‎‮;

	// ‌​‏⁮⁫⁬‏⁫⁫‭‭​⁫‪⁫‪‎‏‎⁮​‬‮‬⁪⁯‫⁪‪‎⁯⁬‌‮‭‮​‬⁫⁭‮
	private int u200c​‏⁮⁫⁬‏⁫⁫‭‭​⁫‪⁫‪‎‏‎⁮​‬‮‬⁪⁯‫⁪‪‎⁯⁬‌‮‭‮​‬⁫⁭‮;

	// ⁬⁭⁭‍⁮​⁮⁪⁮‍‍‌‍‪‭‬‫⁪‪‍​⁯‪‌⁪⁭‎‏⁮‭‪⁫⁫⁭‭‏‪⁭​⁭‮
	private bool u206c⁭⁭‍⁮​⁮⁪⁮‍‍‌‍‪‭‬‫⁪‪‍​⁯‪‌⁪⁭‎‏⁮‭‪⁫⁫⁭‭‏‪⁭​⁭‮;

	// ⁮⁪‬‏⁭⁪⁯‌⁪⁪‫‎⁮‏‪‪‮‮‍‏‬⁮‪‮‬​‍‪​⁬⁬‬⁯‫‏‬⁭​‭⁪‮
	private ChannelType u206e⁪‬‏⁭⁪⁯‌⁪⁪‫‎⁮‏‪‪‮‮‍‏‬⁮‪‮‬​‍‪​⁬⁬‬⁯‫‏‬⁭​‭⁪‮;

	// ​‭‮‍‫‬⁯‮‎‫⁯‍⁭‎⁭‏⁬⁪‍⁬‮‎‮‏‭‍​​‪‪‫⁬⁭‏‍​‭⁮‏‮
	private ChannelType u200b‭‮‍‫‬⁯‮‎‫⁯‍⁭‎⁭‏⁬⁪‍⁬‮‎‮‏‭‍​​‪‪‫⁬⁭‏‍​‭⁮‏‮;

	// ⁬⁭⁯‭⁪‌‬‍​‫‎⁮‫‭‌‭‎⁭‍‪​‫‏⁪⁮‪‏‎‌‎‭⁯‌⁯‏‬⁫‎⁬⁯‮
	private int u206c⁭⁯‭⁪‌‬‍​‫‎⁮‫‭‌‭‎⁭‍‪​‫‏⁪⁮‪‏‎‌‎‭⁯‌⁯‏‬⁫‎⁬⁯‮;

	// ‬⁯‮‌‭‎‭⁮‬​⁮‮‫⁫‭‫‭⁭‮‬⁬⁮⁮⁯‬‫‏‍‏⁯‪‭‌⁭‪⁬‏‌‮⁮‮
	private int u202c⁯‮‌‭‎‭⁮‬​⁮‮‫⁫‭‫‭⁭‮‬⁬⁮⁮⁯‬‫‏‍‏⁯‪‭‌⁭‪⁬‏‌‮⁮‮;

	// ⁪‮‮‪‮‫⁬⁬⁭‍‬‪‮⁬‏⁫⁭⁮‎‎‎⁫⁭⁭‫⁮‎‮‏​‎⁬⁭⁬‬‬‫‬⁫⁯‮
	public static List<string> u206a‮‮‪‮‫⁬⁬⁭‍‬‪‮⁬‏⁫⁭⁮‎‎‎⁫⁭⁭‫⁮‎‮‏​‎⁬⁭⁬‬‬‫‬⁫⁯‮;

	// ‭⁭⁪‫‬‎‭‍⁫⁭​⁫​‮⁫⁮‮⁫‎‬⁫⁮⁪⁭⁫‫⁪‌⁮⁬‍⁬‮‏⁪⁪‭⁪⁯⁭‮
	public static List<string> u202d⁭⁪‫‬‎‭‍⁫⁭​⁫​‮⁫⁮‮⁫‎‬⁫⁮⁪⁭⁫‫⁪‌⁮⁬‍⁬‮‏⁪⁪‭⁪⁯⁭‮;

	// ⁫‮⁭‭‏‫⁯​‏⁯‫⁯‮‮‭‎⁮⁭‭⁪‏‎‮‎⁪​⁫‭⁬⁪‮‬⁫⁭‭‌⁫‬‭‪‮
	public bool u206b‮⁭‭‏‫⁯​‏⁯‫⁯‮‮‭‎⁮⁭‭⁪‏‎‮‎⁪​⁫‭⁬⁪‮‬⁫⁭‭‌⁫‬‭‪‮
	{
		get;
		internal set;
	}

	// ‭​⁮‭‌⁬‭‪‏‬‌‬⁫⁬​⁮‎‭⁭‏‏‌‎‭‬‮‏‍‮‍‌‪‌‫‎‭‪⁭⁪‮
	public float u202d​⁮‭‌⁬‭‪‏‬‌‬⁫⁬​⁮‎‭⁭‏‏‌‎‭‬‮‏‍‮‍‌‪‌‫‎‭‪⁭⁪‮
	{
		get;
		internal set;
	}

	// ​⁪‭⁭⁫‮‍‭‮‫⁬‍‪‌⁭⁭‫​⁫‫‮⁯‬⁬⁮⁫⁭‬‍‌‬‏⁯‍​⁮⁪⁫⁫⁮‮
	public double u200b⁪‭⁭⁫‮‍‭‮‫⁬‍‪‌⁭⁭‫​⁫‫‮⁯‬⁬⁮⁫⁭‬‍‌‬‏⁯‍​⁮⁪⁫⁫⁮‮
	{
		get;
		internal set;
	}

	// ‬⁮⁬‬‭​⁪‮⁮‮‌‏‫⁫‌‪‏⁮‭​⁬‌‫‮⁯‭⁯‎‎⁪‭‍⁮‎​⁬‫‍‌‎‮
	public bool u202c⁮⁬‬‭​⁪‮⁮‮‌‏‫⁫‌‪‏⁮‭​⁬‌‫‮⁯‭⁯‎‎⁪‭‍⁮‎​⁬‫‍‌‎‮
	{
		get;
		internal set;
	}

	// ⁯⁭⁭⁫⁬⁪‎‎‭‎​‬⁫‎⁫⁫‎⁪‪⁭⁮⁬‫⁮⁮‎‪​⁮⁯⁯⁭‌⁭⁪⁫⁭‍‎⁫‮
	public bool u206f⁭⁭⁫⁬⁪‎‎‭‎​‬⁫‎⁫⁫‎⁪‪⁭⁮⁬‫⁮⁮‎‪​⁮⁯⁯⁭‌⁭⁪⁫⁭‍‎⁫‮
	{
		get;
		internal set;
	}

	// ‬‮‮⁫‎‎‏‬‫⁯‎⁪‌⁮⁬⁪‌⁯‫⁭‪⁫‫‎‬‎‭‬⁫‎‍⁬​⁫⁯⁯‭‌⁭‮
	public bool u202c‮‮⁫‎‎‏‬‫⁯‎⁪‌⁮⁬⁪‌⁯‫⁭‪⁫‫‎‬‎‭‬⁫‎‍⁬​⁫⁯⁯‭‌⁭‮
	{
		get;
		internal set;
	}

	// ‫⁯⁮⁮‌⁯‍⁪‬‪​‫‮‏‭‎‌⁮⁫​‍‏‮⁫⁯⁭‏⁮‭‭​‌⁮⁮‫‎‪⁬‍⁭‮
	public bool u202b⁯⁮⁮‌⁯‍⁪‬‪​‫‮‏‭‎‌⁮⁫​‍‏‮⁫⁯⁭‏⁮‭‭​‌⁮⁮‫‎‪⁬‍⁭‮
	{
		get;
		internal set;
	}

	// ‏⁯⁬‍​‮​‭‮​‫‍​‮‏⁯⁮‌‬‏⁫‌‏⁭‬⁫⁭‪‏‬⁬‫‭‮⁬‮‍‎⁯⁭‮
	public float u200f⁯⁬‍​‮​‭‮​‫‍​‮‏⁯⁮‌‬‏⁫‌‏⁭‬⁫⁭‪‏‬⁬‫‭‮⁬‮‍‎⁯⁭‮
	{
		get;
		set;
	}

	// ‏‍⁫⁬‌‍‮‌​‭‮⁪​‍⁬‮⁯‮⁫‪⁭‏‬‍‌‫⁭‫⁫‭‬‏⁬‌⁫‏⁫​⁪‮
	public void u200f‍⁫⁬‌‍‮‌​‭‮⁪​‍⁬‮⁯‮⁫‪⁭‏‬‍‌‫⁭‫⁫‭‬‏⁬‌⁫‏⁫​⁪‮()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	// ‬‪⁯⁭‫‪⁬‎⁭⁫‌‫‭‏⁮⁮⁬​‪‍‍‫‭​‪⁪‏⁯⁪⁬‍⁯‪⁭⁪‭‌⁭​‮‮
	public unsafe int u202c‪⁯⁭‫‪⁬‎⁭⁫‌‫‭‏⁮⁮⁬​‪‍‍‫‭​‪⁪‏⁯⁪⁬‍⁯‪⁭⁪‭‌⁭​‮‮(ref Burst , float* , int , byte* , ref int , float* )
	{
		// 
		// Current member / type: System.Int32 ‪‍‎‎‪‍⁬⁭‬‌‎⁬‎‭‪‬‬​⁭⁬⁮‏‏‪‏‏‏‬⁬‭⁫​‎‎‭‎​‎‬⁬‮::‬‪⁯⁭‫‪⁬‎⁭⁫‌‫‭‏⁮⁮⁬​‪‍‍‫‭​‪⁪‏⁯⁪⁬‍⁯‪⁭⁪‭‌⁭​‮‮(SDRSharp.Tetra.Burst&,System.Single*,System.Int32,System.Byte*,System.Int32&,System.Single*)
		// File path: C:\SDRSharp\Plugins\Tetra\SDRSharp.Tetra.dll
		// 
		// Product version: 0.0.0.0
		// Exception in: System.Int32 ‬‪⁯⁭‫‪⁬‎⁭⁫‌‫‭‏⁮⁮⁬​‪‍‍‫‭​‪⁪‏⁯⁪⁬‍⁯‪⁭⁪‭‌⁭​‮‮(SDRSharp.Tetra.Burst&,System.Single*,System.Int32,System.Byte*,System.Int32&,System.Single*)
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
	// ​⁭‏‌⁮⁭‮⁭⁯‎​‫‬⁭‌‎‬‎‏⁯‮⁫‌‬​‭‌‍‌‏⁮⁫‪‏‍⁯‌⁭⁬‬‮
	private string u200b⁭‏‌⁮⁭‮⁭⁯‎​‫‬⁭‌‎‬‎‏⁯‮⁫‌‬​‭‌‍‌‏⁮⁫‪‏‍⁯‌⁭⁬‬‮(Dictionary<GlobalNames, int> )
	{
		// 
		// Current member / type: System.String ‪‍‎‎‪‍⁬⁭‬‌‎⁬‎‭‪‬‬​⁭⁬⁮‏‏‪‏‏‏‬⁬‭⁫​‎‎‭‎​‎‬⁬‮::​⁭‏‌⁮⁭‮⁭⁯‎​‫‬⁭‌‎‬‎‏⁯‮⁫‌‬​‭‌‍‌‏⁮⁫‪‏‍⁯‌⁭⁬‬‮(System.Collections.Generic.Dictionary`2<SDRSharp.Tetra.GlobalNames,System.Int32>)
		// File path: C:\SDRSharp\Plugins\Tetra\SDRSharp.Tetra.dll
		// 
		// Product version: 0.0.0.0
		// Exception in: System.String ​⁭‏‌⁮⁭‮⁭⁯‎​‫‬⁭‌‎‬‎‏⁯‮⁫‌‬​‭‌‍‌‏⁮⁫‪‏‍⁯‌⁭⁬‬‮(System.Collections.Generic.Dictionary<SDRSharp.Tetra.GlobalNames,System.Int32>)
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

	// ⁫⁪‌‍‪⁯⁫‌‏⁬‏‭‮‎⁭‫‪‌⁫‍⁮‮‌‪⁮‮‮⁯⁪‎⁭‬‏⁫⁫‬‪‭‭‎‮
	private void u206b⁪‌‍‪⁯⁫‌‏⁬‏‭‮‎⁭‫‪‌⁫‍⁮‮‌‪⁮‮‮⁯⁪‎⁭‬‏⁫⁫‬‪‭‭‎‮(Dictionary<GlobalNames, int> globalNames)
	{
		int num;
		if (this.u200b‌‬⁭⁫‎⁯‌⁫⁮‏‍⁫‬‪​‭‎‌‏‬⁪⁭⁪‏⁫‎‏⁫⁯‍‏⁯⁬‮⁬⁫⁪⁫‏‮ != null)
		{
			goto Label0;
		}
	Label1:
		num = -1697236982;
	Label3:
		int num1 = num ^ -678852132;
		uint num2 = (uint)num1;
		switch (num1 % 4)
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
				return;
			}
			case 3:
			{
				break;
			}
			default:
			{
				return;
			}
		}
	Label0:
		this.u200b‌‬⁭⁫‎⁯‌⁫⁮‏‍⁫‬‪​‭‎‌‏‬⁪⁭⁪‏⁫‎‏⁫⁯‍‏⁯⁬‮⁬⁫⁪⁫‏‮(globalNames);
		num = -1850633983;
		goto Label3;
	}

	// ‎⁮⁭⁫⁫⁮⁪‮‮⁫‫⁫⁭⁮‎‎‫‏‎⁯⁮⁭⁪⁯⁭⁮⁪‍‎⁭‮⁯⁫​‬⁮‮‪‍‬‮
	private void u200e⁮⁭⁫⁫⁮⁪‮‮⁫‫⁫⁭⁮‎‎‫‏‎⁯⁮⁭⁪⁯⁭⁮⁪‍‎⁭‮⁯⁫​‬⁮‮‪‍‬‮(List<Dictionary<GlobalNames, int>> dictionaries)
	{
		if (this.u200b‌⁭‪‌⁫⁪⁬⁯‏‪‌⁪‍‍‍‪‪‫⁯​‏‫⁭‬‍​‭‮‮‎⁪‫‎⁬‎‪⁫‫‌‮ != null)
		{
			this.u200b‌⁭‪‌⁫⁪⁬⁯‏‪‌⁪‍‍‍‪‪‫⁯​‏‫⁭‬‍​‭‮‮‎⁪‫‎⁬‎‪⁫‫‌‮(dictionaries);
			return;
		}
	Label1:
		int num = -1556594406 ^ -275273679;
		uint num1 = (uint)num;
		switch (num % 3)
		{
			case 0:
			{
				goto Label1;
			}
			case 2:
			{
				return;
			}
		}
		this.u200b‌⁭‪‌⁫⁪⁬⁯‏‪‌⁪‍‍‍‪‪‫⁯​‏‫⁭‬‍​‭‮‮‎⁪‫‎⁬‎‪⁫‫‌‮(dictionaries);
	}

	// ⁯​‭‏⁬⁮⁮‍‌⁬⁪‏⁪⁬‭⁭⁫⁮⁫‍‏‏‫‏‬​⁭‏‮⁮⁬‫⁫⁬⁮‏⁫⁭‫⁯‮
	private void u206f​‭‏⁬⁮⁮‍‌⁬⁪‏⁪⁬‭⁭⁫⁮⁫‍‏‏‫‏‬​⁭‏‮⁮⁬‫⁫⁬⁮‏⁫⁭‫⁯‮(LogicChannel logicChannel)
	{
		int num = 0;
		int num1;
		int num2;
		int num3;
		int num4 = 0;
	Label0:
		int num5 = 511315751;
		while (true)
		{
			int num6 = num5 ^ 1044615263;
			uint num7 = (uint)num6;
			switch (num6 % 30)
			{
				case 0:
				{
					this.u206e⁪‬‏⁭⁪⁯‌⁪⁪‫‎⁮‏‪‪‮‮‍‏‬⁮‪‮‬​‍‪​⁬⁬‬⁯‫‏‬⁭​‭⁪‮ = ChannelType.Traffic;
					num5 = 1714259011;
					continue;
				}
				case 1:
				{
					this.u200b‭‮‍‫‬⁯‮‎‫⁯‍⁭‎⁭‏⁬⁪‍⁬‮‎‮‏‭‍​​‪‪‫⁬⁭‏‍​‭⁮‏‮ = ChannelType.Traffic;
					num5 = 1510784213;
					continue;
				}
				case 2:
				{
					goto Label0;
				}
				case 3:
				{
					num1 = (num != 0 ? 388630065 : 2099625492);
					num5 = (int)(num1 ^ num7 * 1008228865);
					continue;
				}
				case 4:
				{
					num2 = (this.u206b‎​⁪‬⁮‭‏‎⁮⁯​⁬⁯⁬⁪‬‫‎​‏‏‎‮‌‮⁯‭​‎‫‫‪‭⁯‫⁬‏⁫‎‮.u200c​⁮⁪⁮‌⁯⁪‍‫‎⁫‌⁫‏‪⁬‍‏⁭​⁪‬‏‎⁫⁪⁬‌‏⁬‮‎‭⁪‮‎‍⁫‪‮ == 1 ? 1776334664 : 1945431430);
					num5 = (int)(num2 ^ num7 * -1462356225);
					continue;
				}
				case 5:
				{
					this.u202c⁯‮‌‭‎‭⁮‬​⁮‮‫⁫‭‫‭⁭‮‬⁬⁮⁮⁯‬‫‏‍‏⁯‪‭‌⁭‪⁬‏‌‮⁮‮ = u206c‪‬⁭‭⁯‏​‪⁭‍⁫‍‫⁮‎⁭‭⁪‮‎‭‏‬⁮⁮‍⁭‎⁪‮⁯​‎‎‌⁯⁯⁭⁯‮.u200b‌⁫‏‮‌‭​​⁮‫⁪⁮‏⁫⁯⁫‪⁬⁭‫⁮‏⁪‭⁮⁯​​‎‍‍‎​⁭‏⁫‌‏⁭‮(logicChannel.Ptr, num4, 6);
					num5 = (int)(num7 * 1585616892 ^ -1543227765);
					continue;
				}
				case 6:
				{
					switch (this.u202c⁯‮‌‭‎‭⁮‬​⁮‮‫⁫‭‫‭⁭‮‬⁬⁮⁮⁯‬‫‏‍‏⁯‪‭‌⁭‪⁬‏‌‮⁮‮)
					{
						case 0:
						{
							goto Label1;
						}
						case 1:
						case 2:
						case 3:
						{
							break;
						}
						default:
						{
							num5 = 505138078;
							continue;
						}
					}
					break;
				}
				case 7:
				{
				Label7:
					switch (this.u206c⁭⁯‭⁪‌‬‍​‫‎⁮‫‭‌‭‎⁭‍‪​‫‏⁪⁮‪‏‎‌‎‭⁯‌⁯‏‬⁫‎⁬⁯‮)
					{
						case 0:
						{
							goto Label2;
						}
						case 1:
						{
							goto Label3;
						}
						case 2:
						{
							goto Label4;
						}
						case 3:
						{
							goto Label5;
						}
						default:
						{
							num5 = 560497530;
							continue;
						}
					}
					break;
				}
				case 8:
				{
					num = u206c‪‬⁭‭⁯‏​‪⁭‍⁫‍‫⁮‎⁭‭⁪‮‎‭‏‬⁮⁮‍⁭‎⁪‮⁯​‎‎‌⁯⁯⁭⁯‮.u200b‌⁫‏‮‌‭​​⁮‫⁪⁮‏⁫⁯⁫‪⁬⁭‫⁮‏⁪‭⁮⁯​​‎‍‍‎​⁭‏⁫‌‏⁭‮(logicChannel.Ptr, num4, 2);
					num4 += 2;
					this.u206c⁭⁯‭⁪‌‬‍​‫‎⁮‫‭‌‭‎⁭‍‪​‫‏⁪⁮‪‏‎‌‎‭⁯‌⁯‏‬⁫‎⁬⁯‮ = u206c‪‬⁭‭⁯‏​‪⁭‍⁫‍‫⁮‎⁭‭⁪‮‎‭‏‬⁮⁮‍⁭‎⁪‮⁯​‎‎‌⁯⁯⁭⁯‮.u200b‌⁫‏‮‌‭​​⁮‫⁪⁮‏⁫⁯⁫‪⁬⁭‫⁮‏⁪‭⁮⁯​​‎‍‍‎​⁭‏⁫‌‏⁭‮(logicChannel.Ptr, num4, 6);
					num5 = (int)(num7 * 1156163271 ^ 1494602528);
					continue;
				}
				case 9:
				{
					num5 = (int)(num7 * 1976934489 ^ 958453478);
					continue;
				}
				case 10:
				{
					num3 = (logicChannel.Frame == 18 ? -120851843 : -562990011);
					num5 = (int)(num3 ^ num7 * 729676090);
					continue;
				}
				case 11:
				{
				Label2:
					this.u206e⁪‬‏⁭⁪⁯‌⁪⁪‫‎⁮‏‪‪‮‮‍‏‬⁮‪‮‬​‍‪​⁬⁬‬⁯‫‏‬⁭​‭⁪‮ = ChannelType.Unallocated;
					num5 = 414554109;
					continue;
				}
				case 12:
				{
					this.u206e⁪‬‏⁭⁪⁯‌⁪⁪‫‎⁮‏‪‪‮‮‍‏‬⁮‪‮‬​‍‪​⁬⁬‬⁯‫‏‬⁭​‭⁪‮ = ChannelType.Unallocated;
					num5 = (int)(num7 * -408201424 ^ 329881138);
					continue;
				}
				case 13:
				{
					return;
				}
				case 14:
				{
					return;
				}
				case 15:
				{
					return;
				}
				case 17:
				{
					num4 += 6;
					num5 = (int)(num7 * -847826446 ^ 1206738594);
					continue;
				}
				case 18:
				{
					num5 = (int)(num7 * 1854233053 ^ -669487975);
					continue;
				}
				case 19:
				{
					this.u206e⁪‬‏⁭⁪⁯‌⁪⁪‫‎⁮‏‪‪‮‮‍‏‬⁮‪‮‬​‍‪​⁬⁬‬⁯‫‏‬⁭​‭⁪‮ = ChannelType.Common;
					num5 = (int)(num7 * -1316485032 ^ -1119122108);
					continue;
				}
				case 20:
				{
				Label1:
					this.u200b‭‮‍‫‬⁯‮‎‫⁯‍⁭‎⁭‏⁬⁪‍⁬‮‎‮‏‭‍​​‪‪‫⁬⁭‏‍​‭⁮‏‮ = ChannelType.Unallocated;
					num5 = 2066112889;
					continue;
				}
				case 21:
				{
					num5 = (int)(num7 * 1790610253 ^ 1390992128);
					continue;
				}
				case 22:
				{
					return;
				}
				case 23:
				{
				Label3:
					this.u206e⁪‬‏⁭⁪⁯‌⁪⁪‫‎⁮‏‪‪‮‮‍‏‬⁮‪‮‬​‍‪​⁬⁬‬⁯‫‏‬⁭​‭⁪‮ = ChannelType.Assigned;
					num5 = 2117553010;
					continue;
				}
				case 24:
				{
					switch (num)
					{
						case 0:
						{
							goto Label6;
						}
						case 1:
						case 2:
						case 3:
						{
							goto Label7;
						}
						default:
						{
							num5 = 162089225;
							continue;
						}
					}
					break;
				}
				case 25:
				{
					num5 = (int)(num7 * -195314897 ^ 1781967322);
					continue;
				}
				case 26:
				{
				Label5:
					this.u206e⁪‬‏⁭⁪⁯‌⁪⁪‫‎⁮‏‪‪‮‮‍‏‬⁮‪‮‬​‍‪​⁬⁬‬⁯‫‏‬⁭​‭⁪‮ = ChannelType.Common_and_Assigned;
					num5 = 1714259011;
					continue;
				}
				case 27:
				{
				Label6:
					this.u206e⁪‬‏⁭⁪⁯‌⁪⁪‫‎⁮‏‪‪‮‮‍‏‬⁮‪‮‬​‍‪​⁬⁬‬⁯‫‏‬⁭​‭⁪‮ = ChannelType.Common;
					num5 = 1885123856;
					continue;
				}
				case 28:
				{
				Label4:
					this.u206e⁪‬‏⁭⁪⁯‌⁪⁪‫‎⁮‏‪‪‮‮‍‏‬⁮‪‮‬​‍‪​⁬⁬‬⁯‫‏‬⁭​‭⁪‮ = ChannelType.Common;
					num5 = 611335312;
					continue;
				}
				case 29:
				{
					num5 = (int)(num7 * -1791050626 ^ 1116853602);
					continue;
				}
			}
		}
	}

	// ‍‮⁫‍​‎‮‎⁫‎⁯‬‭⁫⁫‭‫‮⁭‌‫⁫⁪‮​‪‎‏⁫‌‌‫‭⁬⁭‎‎‭⁫‌‮
	private void u200d‮⁫‍​‎‮‎⁫‎⁯‬‭⁫⁫‭‫‮⁭‌‫⁫⁪‮​‪‎‏⁫‌‌‫‭⁬⁭‎‎‭⁫‌‮()
	{
		this.u206c⁭⁯‭⁪‌‬‍​‫‎⁮‫‭‌‭‎⁭‍‪​‫‏⁪⁮‪‏‎‌‎‭⁯‌⁯‏‬⁫‎⁬⁯‮ = 0;
	Label1:
		int num = 2143397824;
		while (true)
		{
			int num1 = num ^ 1951547643;
			uint num2 = (uint)num1;
			switch (num1 % 4)
			{
				case 0:
				{
					this.u202c⁯‮‌‭‎‭⁮‬​⁮‮‫⁫‭‫‭⁭‮‬⁬⁮⁮⁯‬‫‏‍‏⁯‪‭‌⁭‪⁬‏‌‮⁮‮ = 0;
					this.u200b‭‮‍‫‬⁯‮‎‫⁯‍⁭‎⁭‏⁬⁪‍⁬‮‎‮‏‭‍​​‪‪‫⁬⁭‏‍​‭⁮‏‮ = ChannelType.Common;
					num = (int)(num2 * -970926333 ^ -1738366666);
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
					this.u206e⁪‬‏⁭⁪⁯‌⁪⁪‫‎⁮‏‪‪‮‮‍‏‬⁮‪‮‬​‍‪​⁬⁬‬⁯‫‏‬⁭​‭⁪‮ = ChannelType.Common;
					num = (int)(num2 * 295106650 ^ -1170650819);
					continue;
				}
			}
		}
	}

	// ‮⁭⁮⁭‍‎‏⁯⁯⁯⁪‎‫⁯⁭‎‬⁬⁭‌‏‎⁭‫⁯⁬⁬‬‭‮‍‍‮‭‎⁫⁫‮‬‪‮
	// privatescope
	internal static Delegate u202e⁭⁮⁭‍‎‏⁯⁯⁯⁪‎‫⁯⁭‎‬⁬⁭‌‏‎⁭‫⁯⁬⁬‬‭‮‍‍‮‭‎⁫⁫‮‬‪‮(Delegate @delegate, Delegate @delegate)
	{
		return Delegate.Combine(@delegate, @delegate);
	}

	// ⁭⁫⁮‬⁯⁯⁭‏‭⁬​​⁭‪​​​⁪‭⁫⁯⁬‏⁬⁯⁯‍‪⁯⁫‏‍⁬⁪‭⁮‪‪‬‭‮
	// privatescope
	internal static Delegate u206d⁫⁮‬⁯⁯⁭‏‭⁬​​⁭‪​​​⁪‭⁫⁯⁬‏⁬⁯⁯‍‪⁯⁫‏‍⁬⁪‭⁮‪‪‬‭‮(Delegate @delegate, Delegate @delegate)
	{
		return Delegate.Remove(@delegate, @delegate);
	}

	// ⁭⁯‏⁮‮‪⁮‬‮⁯⁭‎‪⁮⁯⁯⁬⁭⁭‫⁪‬⁪⁬​‎⁬​‮⁭⁫⁬‪‏‮‭⁯‏‎‏‮
	// privatescope
	internal static UnsafeBuffer u206d⁯‏⁮‮‪⁮‬‮⁯⁭‎‪⁮⁯⁯⁬⁭⁭‫⁪‬⁪⁬​‎⁬​‮⁭⁫⁬‪‏‮‭⁯‏‎‏‮(int num)
	{
		return UnsafeBuffer.Create(num);
	}

	// ​‭‎⁭⁭‬‌‪‮​‏⁯⁭‫‮‌‪⁯‌‪‎‮‪⁪⁭‏⁭‪​‏⁪‪‌‮‬‬‭‍⁭‎‮
	// privatescope
	internal static unsafe void* u200b‭‎⁭⁭‬‌‪‮​‏⁯⁭‫‮‌‪⁯‌‪‎‮‪⁪⁭‏⁭‪​‏⁪‪‌‮‬‬‭‍⁭‎‮(UnsafeBuffer unsafeBuffer)
	{
		return unsafeBuffer;
	}

	// ‌⁮⁫‪⁬⁭‬⁬​‫‎‮‎‫‫‏⁭‏‪‍⁭‍⁮⁮‭​‬⁯‭⁭​‎⁬‪‏‭‌‌‎‭‮
	// privatescope
	internal static int u200c⁮⁫‪⁬⁭‬⁬​‫‎‮‎‫‫‏⁭‏‪‍⁭‍⁮⁮‭​‬⁯‭⁭​‎⁬‪‏‭‌‌‎‭‮(UnsafeBuffer unsafeBuffer)
	{
		return unsafeBuffer.get_Length();
	}

	// ​‬‪‌⁯⁪‮‮⁯‫⁯‭‬‌⁬⁮‪‬‮‮‫‌‍‪‬‏‏⁭‏‫‭‫⁮⁯​⁮‭⁪‬⁬‮
	// privatescope
	internal static string u200b‬‪‌⁯⁪‮‮⁯‫⁯‭‬‌⁬⁮‪‬‮‮‫‌‍‪‬‏‏⁭‏‫‭‫⁮⁯​⁮‭⁪‬⁬‮(string str, string str)
	{
		return string.Concat(str, str);
	}

	// ‬‪‌⁫‮⁮⁭⁬‌‍‌⁮‮‏‫‏‪‬⁫‎‪‬⁪‪​‮‭​‭‎⁯⁭⁬⁯‮⁪‪‪⁮‪‮
	// privatescope
	internal static unsafe void* u202c‪‌⁫‮⁮⁭⁬‌‍‌⁮‮‏‫‏‪‬⁫‎‪‬⁪‪​‮‭​‭‎⁯⁭⁬⁯‮⁪‪‪⁮‪‮(void* voidPointer, void* voidPointer, int num)
	{
		return Utils.Memcpy(voidPointer, voidPointer, num);
	}

	// ⁮‮‪‏‌‪⁮⁯‪‍‌‭⁮‫⁮‪⁬‎‏​‪​​‭⁮‏⁬‫​​‮‍‍‪‬‌‪⁯‎‍‮
	// privatescope
	internal static string u206e‮‪‏‌‪⁮⁯‪‍‌‭⁮‫⁮‪⁬‎‏​‪​​‭⁮‏⁬‫​​‮‍‍‪‬‌‪⁯‎‍‮(string str, object obj)
	{
		return string.Format(str, obj);
	}

	// ⁬⁬‍‭‎‏‭‬⁪‪‬‏‮⁬‭‎‮⁭‍‌‎⁭‬‫‬⁫​‭‬‬‭‍​⁪⁫‪⁮‍⁬⁯‮
	// privatescope
	internal static string u206c⁬‍‭‎‏‭‬⁪‪‬‏‮⁬‭‎‮⁭‍‌‎⁭‬‫‬⁫​‭‬‬‭‍​⁪⁫‪⁮‍⁬⁯‮(object[] objArray)
	{
		return string.Concat(objArray);
	}

	// ‌‫⁪‎⁮‎‍⁪‬‮⁯⁬‬‭‪‌⁯⁯⁮‫‫⁬‌​‫⁪⁭⁪‌‭⁭⁭‮‏‪‍‭‌‏‮‮
	// privatescope
	internal static string u200c‫⁪‎⁮‎‍⁪‬‮⁯⁬‬‭‪‌⁯⁯⁮‫‫⁬‌​‫⁪⁭⁪‌‭⁭⁭‮‏‪‍‭‌‏‮‮(object obj, object obj, object obj)
	{
		return string.Concat(obj, obj, obj);
	}

	// ​‍⁪⁪‍⁯‮⁯⁭​⁪⁪​⁫⁫⁯⁪‮⁭⁫⁮‎⁪⁪‫‫​‌‭⁫‮‮‎‪⁮‫‏‬​‭‮
	// privatescope
	internal static bool u200b‍⁪⁪‍⁯‮⁯⁭​⁪⁪​⁫⁫⁯⁪‮⁭⁫⁮‎⁪⁪‫‫​‌‭⁫‮‮‎‪⁮‫‏‬​‭‮(string str, string str)
	{
		return str == str;
	}

	// ‭‮‬​‏‬‬⁪‮⁭‭​⁮‎‏⁫⁯‌‎⁮‮‫‫⁮‭‮⁪‌‎‫‍⁮‪⁪‮⁯⁪‪⁭‮‮
	// privatescope
	internal static string u202d‮‬​‏‬‬⁪‮⁭‭​⁮‎‏⁫⁯‌‎⁮‮‫‫⁮‭‮⁪‌‎‫‍⁮‪⁪‮⁯⁪‪⁭‮‮(string str, object obj, object obj)
	{
		return string.Format(str, obj, obj);
	}

	// ‬​⁮⁬‬⁯‍‪‌‬⁫​‎⁯‎⁮⁫‪⁯‎‬⁫‏‍⁪⁮⁬‫‬⁫⁬⁭‬⁮​⁬‎‍​⁯‮
	// privatescope
	internal static string u202c​⁮⁬‬⁯‍‪‌‬⁫​‎⁯‎⁮⁫‪⁯‎‬⁫‏‍⁪⁮⁬‫‬⁫⁬⁭‬⁮​⁬‎‍​⁯‮(object obj, object obj)
	{
		return string.Concat(obj, obj);
	}

	static u202a‍‎‎‪‍⁬⁭‬‌‎⁬‎‭‪‬‬​⁭⁬⁮‏‏‪‏‏‏‬⁬‭⁫​‎‎‭‎​‎‬⁬‮()
	{
		u202a‍‎‎‪‍⁬⁭‬‌‎⁬‎‭‪‬‬​⁭⁬⁮‏‏‪‏‏‏‬⁬‭⁫​‎‎‭‎​‎‬⁬‮.u206a‮‮‪‮‫⁬⁬⁭‍‬‪‮⁬‏⁫⁭⁮‎‎‎⁫⁭⁭‫⁮‎‮‏​‎⁬⁭⁬‬‬‫‬⁫⁯‮ = new List<string>();
	Label0:
		int num = -498585478;
		while (true)
		{
			int num1 = num ^ -1199105461;
			uint num2 = (uint)num1;
			switch (num1 % 3)
			{
				case 0:
				{
					goto Label0;
				}
				case 1:
				{
					u202a‍‎‎‪‍⁬⁭‬‌‎⁬‎‭‪‬‬​⁭⁬⁮‏‏‪‏‏‏‬⁬‭⁫​‎‎‭‎​‎‬⁬‮.u202d⁭⁪‫‬‎‭‍⁫⁭​⁫​‮⁫⁮‮⁫‎‬⁫⁮⁪⁭⁫‫⁪‌⁮⁬‍⁬‮‏⁪⁪‭⁪⁯⁭‮ = new List<string>();
					num = (int)(num2 * -999652850 ^ -1882089338);
					continue;
				}
				case 2:
				{
					return;
				}
			}
		}
	}

	public u202a‍‎‎‪‍⁬⁭‬‌‎⁬‎‭‪‬‬​⁭⁬⁮‏‏‪‏‏‏‬⁬‭⁫​‎‎‭‎​‎‬⁬‮()
	{
		this.u202b⁪⁭‏‏‌‌‏‌‏⁭‮⁫​‍⁮​‍‮⁭‭⁬‫‎⁭⁪​‎‫‮‮‪‫‫​‍‫‫​‌‮ = u202a‍‎‎‪‍⁬⁭‬‌‎⁬‎‭‪‬‬​⁭⁬⁮‏‏‪‏‏‏‬⁬‭⁫​‎‎‭‎​‎‬⁬‮.u206d⁯‏⁮‮‪⁮‬‮⁯⁭‎‪⁮⁯⁯⁬⁭⁭‫⁪‬⁪⁬​‎⁬​‮⁭⁫⁬‪‏‮‭⁯‏‎‏‮(30);
		this.u200c‎⁯⁪⁬‭⁪⁯⁪⁮⁬‬‍‮⁯⁮‌‌⁯‮‏⁮⁭‬‫‏⁬‍⁬‎‫‪⁭‎⁯⁬​⁪⁭⁬‮ = (byte*)u202a‍‎‎‪‍⁬⁭‬‌‎⁬‎‭‪‬‬​⁭⁬⁮‏‏‪‏‏‏‬⁬‭⁫​‎‎‭‎​‎‬⁬‮.u200b‭‎⁭⁭‬‌‪‮​‏⁯⁭‫‮‌‪⁯‌‪‎‮‪⁪⁭‏⁭‪​‏⁪‪‌‮‬‬‭‍⁭‎‮(this.u202b⁪⁭‏‏‌‌‏‌‏⁭‮⁫​‍⁮​‍‮⁭‭⁬‫‎⁭⁪​‎‫‮‮‪‫‫​‍‫‫​‌‮);
		this.u206e‍⁯⁬‪⁪⁮⁭‌‭‫‏⁫‫‌​‪‏⁬‏‭‭‪‬‭‎⁯‭‌‏‬⁮‬‮‮‮⁪⁮⁬‌‮ = u202a‍‎‎‪‍⁬⁭‬‌‎⁬‎‭‪‬‬​⁭⁬⁮‏‏‪‏‏‏‬⁬‭⁫​‎‎‭‎​‎‬⁬‮.u206d⁯‏⁮‮‪⁮‬‮⁯⁭‎‪⁮⁯⁯⁬⁭⁭‫⁪‬⁪⁬​‎⁬​‮⁭⁫⁬‪‏‮‭⁯‏‎‏‮(216);
		this.u202a⁪‎‌‬⁭‍‭‮‮‌‬⁪‭⁭⁭⁯​​⁪‎‫⁯⁬⁮⁫⁭⁮‮‫‏⁭‫‍‏⁭‪⁫‪⁯‮ = (byte*)u202a‍‎‎‪‍⁬⁭‬‌‎⁬‎‭‪‬‬​⁭⁬⁮‏‏‪‏‏‏‬⁬‭⁫​‎‎‭‎​‎‬⁬‮.u200b‭‎⁭⁭‬‌‪‮​‏⁯⁭‫‮‌‪⁯‌‪‎‮‪⁪⁭‏⁭‪​‏⁪‪‌‮‬‬‭‍⁭‎‮(this.u206e‍⁯⁬‪⁪⁮⁭‌‭‫‏⁫‫‌​‪‏⁬‏‭‭‪‬‭‎⁯‭‌‏‬⁮‬‮‮‮⁪⁮⁬‌‮);
		this.u200d‪⁭‏⁫‫‪‏⁫‬‭‏‮⁭‫‏⁪‬​‫⁯‫⁮‫⁬⁮⁪‭⁪⁭‏‌⁭‏‬‮‪⁭‮⁯‮ = u202a‍‎‎‪‍⁬⁭‬‌‎⁬‎‭‪‬‬​⁭⁬⁮‏‏‪‏‏‏‬⁬‭⁫​‎‎‭‎​‎‬⁬‮.u206d⁯‏⁮‮‪⁮‬‮⁯⁭‎‪⁮⁯⁯⁬⁭⁭‫⁪‬⁪⁬​‎⁬​‮⁭⁫⁬‪‏‮‭⁯‏‎‏‮(216);
		this.u202d⁮⁮​​‭⁮⁪⁯⁮⁮⁮‪‬⁫⁫⁬⁪‮‮⁮⁭‌‭‭⁭​‭‬‪⁮‮‎⁬⁭⁬⁪‎‬⁬‮ = (byte*)u202a‍‎‎‪‍⁬⁭‬‌‎⁬‎‭‪‬‬​⁭⁬⁮‏‏‪‏‏‏‬⁬‭⁫​‎‎‭‎​‎‬⁬‮.u200b‭‎⁭⁭‬‌‪‮​‏⁯⁭‫‮‌‪⁯‌‪‎‮‪⁪⁭‏⁭‪​‏⁪‪‌‮‬‬‭‍⁭‎‮(this.u200d‪⁭‏⁫‫‪‏⁫‬‭‏‮⁭‫‏⁪‬​‫⁯‫⁮‫⁬⁮⁪‭⁪⁭‏‌⁭‏‬‮‪⁭‮⁯‮);
		this.u206a‎‬‏‮‬⁪⁬‬‫‏⁭‎⁯‮⁮⁫‌​‪‭⁬‏‎‏‮‬⁯‮‌⁭‪‬‎⁬‏⁪​⁪‍‮ = u202a‍‎‎‪‍⁬⁭‬‌‎⁬‎‭‪‬‬​⁭⁬⁮‏‏‪‏‏‏‬⁬‭⁫​‎‎‭‎​‎‬⁬‮.u206d⁯‏⁮‮‪⁮‬‮⁯⁭‎‪⁮⁯⁯⁬⁭⁭‫⁪‬⁪⁬​‎⁬​‮⁭⁫⁬‪‏‮‭⁯‏‎‏‮(120);
		this.u202e‮‭⁮​‭‬​⁮‫⁭‌⁬‌⁭⁭‌⁮‌⁫‭‪‫‬⁬⁯‫⁫‮⁮‏⁬⁪⁫‎⁫​‏‍‭‮ = (byte*)u202a‍‎‎‪‍⁬⁭‬‌‎⁬‎‭‪‬‬​⁭⁬⁮‏‏‪‏‏‏‬⁬‭⁫​‎‎‭‎​‎‬⁬‮.u200b‭‎⁭⁭‬‌‪‮​‏⁯⁭‫‮‌‪⁯‌‪‎‮‪⁪⁭‏⁭‪​‏⁪‪‌‮‬‬‭‍⁭‎‮(this.u206a‎‬‏‮‬⁪⁬‬‫‏⁭‎⁯‮⁮⁫‌​‪‭⁬‏‎‏‮‬⁯‮‌⁭‪‬‎⁬‏⁪​⁪‍‮);
	}

	public event u202a‍‎‎‪‍⁬⁭‬‌‎⁬‎‭‪‬‬​⁭⁬⁮‏‏‪‏‏‏‬⁬‭⁫​‎‎‭‎​‎‬⁬‮.u206e‮‏‎‬‪‬‫⁭‍‬‬‎‮⁮‭⁯⁪‮‪‏‍‮‎⁬⁬‪‪‫‫⁯‬⁮‎⁯‌‮‎‫⁬‮ ​‌⁭‪‌⁫⁪⁬⁯‏‪‌⁪‍‍‍‪‪‫⁯​‏‫⁭‬‍​‭‮‮‎⁪‫‎⁬‎‪⁫‫‌‮
	{
		add
		{
			u202a‍‎‎‪‍⁬⁭‬‌‎⁬‎‭‪‬‬​⁭⁬⁮‏‏‪‏‏‏‬⁬‭⁫​‎‎‭‎​‎‬⁬‮.u206e‮‏‎‬‪‬‫⁭‍‬‬‎‮⁮‭⁯⁪‮‪‏‍‮‎⁬⁬‪‪‫‫⁯‬⁮‎⁯‌‮‎‫⁬‮ _⁮‮‏‎‬‪‬‫⁭‍‬‬‎‮⁮‭⁯⁪‮‪‏‍‮‎⁬⁬‪‪‫‫⁯‬⁮‎⁯‌‮‎‫⁬‮1 = null;
			int num;
			u202a‍‎‎‪‍⁬⁭‬‌‎⁬‎‭‪‬‬​⁭⁬⁮‏‏‪‏‏‏‬⁬‭⁫​‎‎‭‎​‎‬⁬‮.u206e‮‏‎‬‪‬‫⁭‍‬‬‎‮⁮‭⁯⁪‮‪‏‍‮‎⁬⁬‪‪‫‫⁯‬⁮‎⁯‌‮‎‫⁬‮ _⁮‮‏‎‬‪‬‫⁭‍‬‬‎‮⁮‭⁯⁪‮‪‏‍‮‎⁬⁬‪‪‫‫⁯‬⁮‎⁯‌‮‎‫⁬‮2 = this.u200b‌⁭‪‌⁫⁪⁬⁯‏‪‌⁪‍‍‍‪‪‫⁯​‏‫⁭‬‍​‭‮‮‎⁪‫‎⁬‎‪⁫‫‌‮;
		Label0:
			int num1 = 534741734;
			while (true)
			{
				int num2 = num1 ^ 1143920855;
				uint num3 = (uint)num2;
				switch (num2 % 5)
				{
					case 0:
					{
						goto Label0;
					}
					case 1:
					{
						_⁮‮‏‎‬‪‬‫⁭‍‬‬‎‮⁮‭⁯⁪‮‪‏‍‮‎⁬⁬‪‪‫‫⁯‬⁮‎⁯‌‮‎‫⁬‮1 = _⁮‮‏‎‬‪‬‫⁭‍‬‬‎‮⁮‭⁯⁪‮‪‏‍‮‎⁬⁬‪‪‫‫⁯‬⁮‎⁯‌‮‎‫⁬‮2;
						num1 = 1573755758;
						continue;
					}
					case 2:
					{
						num = ((object)_⁮‮‏‎‬‪‬‫⁭‍‬‬‎‮⁮‭⁯⁪‮‪‏‍‮‎⁬⁬‪‪‫‫⁯‬⁮‎⁯‌‮‎‫⁬‮2 != (object)_⁮‮‏‎‬‪‬‫⁭‍‬‬‎‮⁮‭⁯⁪‮‪‏‍‮‎⁬⁬‪‪‫‫⁯‬⁮‎⁯‌‮‎‫⁬‮1 ? 1054779636 : 1548237035);
						num1 = (int)(num ^ num3 * 694511918);
						continue;
					}
					case 3:
					{
						return;
					}
					case 4:
					{
						u202a‍‎‎‪‍⁬⁭‬‌‎⁬‎‭‪‬‬​⁭⁬⁮‏‏‪‏‏‏‬⁬‭⁫​‎‎‭‎​‎‬⁬‮.u206e‮‏‎‬‪‬‫⁭‍‬‬‎‮⁮‭⁯⁪‮‪‏‍‮‎⁬⁬‪‪‫‫⁯‬⁮‎⁯‌‮‎‫⁬‮ _⁮‮‏‎‬‪‬‫⁭‍‬‬‎‮⁮‭⁯⁪‮‪‏‍‮‎⁬⁬‪‪‫‫⁯‬⁮‎⁯‌‮‎‫⁬‮3 = (u202a‍‎‎‪‍⁬⁭‬‌‎⁬‎‭‪‬‬​⁭⁬⁮‏‏‪‏‏‏‬⁬‭⁫​‎‎‭‎​‎‬⁬‮.u206e‮‏‎‬‪‬‫⁭‍‬‬‎‮⁮‭⁯⁪‮‪‏‍‮‎⁬⁬‪‪‫‫⁯‬⁮‎⁯‌‮‎‫⁬‮)u202a‍‎‎‪‍⁬⁭‬‌‎⁬‎‭‪‬‬​⁭⁬⁮‏‏‪‏‏‏‬⁬‭⁫​‎‎‭‎​‎‬⁬‮.u202e⁭⁮⁭‍‎‏⁯⁯⁯⁪‎‫⁯⁭‎‬⁬⁭‌‏‎⁭‫⁯⁬⁬‬‭‮‍‍‮‭‎⁫⁫‮‬‪‮(_⁮‮‏‎‬‪‬‫⁭‍‬‬‎‮⁮‭⁯⁪‮‪‏‍‮‎⁬⁬‪‪‫‫⁯‬⁮‎⁯‌‮‎‫⁬‮1, _⁮‮‏‎‬‪‬‫⁭‍‬‬‎‮⁮‭⁯⁪‮‪‏‍‮‎⁬⁬‪‪‫‫⁯‬⁮‎⁯‌‮‎‫⁬‮);
						_⁮‮‏‎‬‪‬‫⁭‍‬‬‎‮⁮‭⁯⁪‮‪‏‍‮‎⁬⁬‪‪‫‫⁯‬⁮‎⁯‌‮‎‫⁬‮2 = Interlocked.CompareExchange<u202a‍‎‎‪‍⁬⁭‬‌‎⁬‎‭‪‬‬​⁭⁬⁮‏‏‪‏‏‏‬⁬‭⁫​‎‎‭‎​‎‬⁬‮.u206e‮‏‎‬‪‬‫⁭‍‬‬‎‮⁮‭⁯⁪‮‪‏‍‮‎⁬⁬‪‪‫‫⁯‬⁮‎⁯‌‮‎‫⁬‮>(ref this.u200b‌⁭‪‌⁫⁪⁬⁯‏‪‌⁪‍‍‍‪‪‫⁯​‏‫⁭‬‍​‭‮‮‎⁪‫‎⁬‎‪⁫‫‌‮, _⁮‮‏‎‬‪‬‫⁭‍‬‬‎‮⁮‭⁯⁪‮‪‏‍‮‎⁬⁬‪‪‫‫⁯‬⁮‎⁯‌‮‎‫⁬‮3, _⁮‮‏‎‬‪‬‫⁭‍‬‬‎‮⁮‭⁯⁪‮‪‏‍‮‎⁬⁬‪‪‫‫⁯‬⁮‎⁯‌‮‎‫⁬‮1);
						num1 = (int)(num3 * 1232985377 ^ 1111728209);
						continue;
					}
				}
			}
		}
		remove
		{
			u202a‍‎‎‪‍⁬⁭‬‌‎⁬‎‭‪‬‬​⁭⁬⁮‏‏‪‏‏‏‬⁬‭⁫​‎‎‭‎​‎‬⁬‮.u206e‮‏‎‬‪‬‫⁭‍‬‬‎‮⁮‭⁯⁪‮‪‏‍‮‎⁬⁬‪‪‫‫⁯‬⁮‎⁯‌‮‎‫⁬‮ _⁮‮‏‎‬‪‬‫⁭‍‬‬‎‮⁮‭⁯⁪‮‪‏‍‮‎⁬⁬‪‪‫‫⁯‬⁮‎⁯‌‮‎‫⁬‮1 = this.u200b‌⁭‪‌⁫⁪⁬⁯‏‪‌⁪‍‍‍‪‪‫⁯​‏‫⁭‬‍​‭‮‮‎⁪‫‎⁬‎‪⁫‫‌‮;
		Label0:
			int num = 801993982;
			while (true)
			{
				int num1 = num ^ 1688926924;
				uint num2 = (uint)num1;
				switch (num1 % 3)
				{
					case 0:
					{
						goto Label0;
					}
					case 1:
					{
						u202a‍‎‎‪‍⁬⁭‬‌‎⁬‎‭‪‬‬​⁭⁬⁮‏‏‪‏‏‏‬⁬‭⁫​‎‎‭‎​‎‬⁬‮.u206e‮‏‎‬‪‬‫⁭‍‬‬‎‮⁮‭⁯⁪‮‪‏‍‮‎⁬⁬‪‪‫‫⁯‬⁮‎⁯‌‮‎‫⁬‮ _⁮‮‏‎‬‪‬‫⁭‍‬‬‎‮⁮‭⁯⁪‮‪‏‍‮‎⁬⁬‪‪‫‫⁯‬⁮‎⁯‌‮‎‫⁬‮2 = _⁮‮‏‎‬‪‬‫⁭‍‬‬‎‮⁮‭⁯⁪‮‪‏‍‮‎⁬⁬‪‪‫‫⁯‬⁮‎⁯‌‮‎‫⁬‮1;
						u202a‍‎‎‪‍⁬⁭‬‌‎⁬‎‭‪‬‬​⁭⁬⁮‏‏‪‏‏‏‬⁬‭⁫​‎‎‭‎​‎‬⁬‮.u206e‮‏‎‬‪‬‫⁭‍‬‬‎‮⁮‭⁯⁪‮‪‏‍‮‎⁬⁬‪‪‫‫⁯‬⁮‎⁯‌‮‎‫⁬‮ _⁮‮‏‎‬‪‬‫⁭‍‬‬‎‮⁮‭⁯⁪‮‪‏‍‮‎⁬⁬‪‪‫‫⁯‬⁮‎⁯‌‮‎‫⁬‮3 = (u202a‍‎‎‪‍⁬⁭‬‌‎⁬‎‭‪‬‬​⁭⁬⁮‏‏‪‏‏‏‬⁬‭⁫​‎‎‭‎​‎‬⁬‮.u206e‮‏‎‬‪‬‫⁭‍‬‬‎‮⁮‭⁯⁪‮‪‏‍‮‎⁬⁬‪‪‫‫⁯‬⁮‎⁯‌‮‎‫⁬‮)u202a‍‎‎‪‍⁬⁭‬‌‎⁬‎‭‪‬‬​⁭⁬⁮‏‏‪‏‏‏‬⁬‭⁫​‎‎‭‎​‎‬⁬‮.u206d⁫⁮‬⁯⁯⁭‏‭⁬​​⁭‪​​​⁪‭⁫⁯⁬‏⁬⁯⁯‍‪⁯⁫‏‍⁬⁪‭⁮‪‪‬‭‮(_⁮‮‏‎‬‪‬‫⁭‍‬‬‎‮⁮‭⁯⁪‮‪‏‍‮‎⁬⁬‪‪‫‫⁯‬⁮‎⁯‌‮‎‫⁬‮2, _⁮‮‏‎‬‪‬‫⁭‍‬‬‎‮⁮‭⁯⁪‮‪‏‍‮‎⁬⁬‪‪‫‫⁯‬⁮‎⁯‌‮‎‫⁬‮);
						_⁮‮‏‎‬‪‬‫⁭‍‬‬‎‮⁮‭⁯⁪‮‪‏‍‮‎⁬⁬‪‪‫‫⁯‬⁮‎⁯‌‮‎‫⁬‮1 = Interlocked.CompareExchange<u202a‍‎‎‪‍⁬⁭‬‌‎⁬‎‭‪‬‬​⁭⁬⁮‏‏‪‏‏‏‬⁬‭⁫​‎‎‭‎​‎‬⁬‮.u206e‮‏‎‬‪‬‫⁭‍‬‬‎‮⁮‭⁯⁪‮‪‏‍‮‎⁬⁬‪‪‫‫⁯‬⁮‎⁯‌‮‎‫⁬‮>(ref this.u200b‌⁭‪‌⁫⁪⁬⁯‏‪‌⁪‍‍‍‪‪‫⁯​‏‫⁭‬‍​‭‮‮‎⁪‫‎⁬‎‪⁫‫‌‮, _⁮‮‏‎‬‪‬‫⁭‍‬‬‎‮⁮‭⁯⁪‮‪‏‍‮‎⁬⁬‪‪‫‫⁯‬⁮‎⁯‌‮‎‫⁬‮3, _⁮‮‏‎‬‪‬‫⁭‍‬‬‎‮⁮‭⁯⁪‮‪‏‍‮‎⁬⁬‪‪‫‫⁯‬⁮‎⁯‌‮‎‫⁬‮2);
						num = ((object)_⁮‮‏‎‬‪‬‫⁭‍‬‬‎‮⁮‭⁯⁪‮‪‏‍‮‎⁬⁬‪‪‫‫⁯‬⁮‎⁯‌‮‎‫⁬‮1 != (object)_⁮‮‏‎‬‪‬‫⁭‍‬‬‎‮⁮‭⁯⁪‮‪‏‍‮‎⁬⁬‪‪‫‫⁯‬⁮‎⁯‌‮‎‫⁬‮2 ? 801993982 : 441733930);
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

	public event u202a‍‎‎‪‍⁬⁭‬‌‎⁬‎‭‪‬‬​⁭⁬⁮‏‏‪‏‏‏‬⁬‭⁫​‎‎‭‎​‎‬⁬‮.u202b⁪‌‪⁯⁭‬‏‍⁬⁮⁮‬‍‍‍⁫‍⁯‬‫‍‫‫‪‏‌‮⁬⁫‪‌‌​⁬⁪⁭⁯⁫‪‮ ​‌‬⁭⁫‎⁯‌⁫⁮‏‍⁫‬‪​‭‎‌‏‬⁪⁭⁪‏⁫‎‏⁫⁯‍‏⁯⁬‮⁬⁫⁪⁫‏‮
	{
		add
		{
			u202a‍‎‎‪‍⁬⁭‬‌‎⁬‎‭‪‬‬​⁭⁬⁮‏‏‪‏‏‏‬⁬‭⁫​‎‎‭‎​‎‬⁬‮.u202b⁪‌‪⁯⁭‬‏‍⁬⁮⁮‬‍‍‍⁫‍⁯‬‫‍‫‫‪‏‌‮⁬⁫‪‌‌​⁬⁪⁭⁯⁫‪‮ _‫⁪‌‪⁯⁭‬‏‍⁬⁮⁮‬‍‍‍⁫‍⁯‬‫‍‫‫‪‏‌‮⁬⁫‪‌‌​⁬⁪⁭⁯⁫‪‮1 = this.u200b‌‬⁭⁫‎⁯‌⁫⁮‏‍⁫‬‪​‭‎‌‏‬⁪⁭⁪‏⁫‎‏⁫⁯‍‏⁯⁬‮⁬⁫⁪⁫‏‮;
		Label0:
			int num = -71166246;
			while (true)
			{
				int num1 = num ^ -1533661111;
				uint num2 = (uint)num1;
				switch (num1 % 3)
				{
					case 0:
					{
						goto Label0;
					}
					case 1:
					{
						u202a‍‎‎‪‍⁬⁭‬‌‎⁬‎‭‪‬‬​⁭⁬⁮‏‏‪‏‏‏‬⁬‭⁫​‎‎‭‎​‎‬⁬‮.u202b⁪‌‪⁯⁭‬‏‍⁬⁮⁮‬‍‍‍⁫‍⁯‬‫‍‫‫‪‏‌‮⁬⁫‪‌‌​⁬⁪⁭⁯⁫‪‮ _‫⁪‌‪⁯⁭‬‏‍⁬⁮⁮‬‍‍‍⁫‍⁯‬‫‍‫‫‪‏‌‮⁬⁫‪‌‌​⁬⁪⁭⁯⁫‪‮2 = _‫⁪‌‪⁯⁭‬‏‍⁬⁮⁮‬‍‍‍⁫‍⁯‬‫‍‫‫‪‏‌‮⁬⁫‪‌‌​⁬⁪⁭⁯⁫‪‮1;
						u202a‍‎‎‪‍⁬⁭‬‌‎⁬‎‭‪‬‬​⁭⁬⁮‏‏‪‏‏‏‬⁬‭⁫​‎‎‭‎​‎‬⁬‮.u202b⁪‌‪⁯⁭‬‏‍⁬⁮⁮‬‍‍‍⁫‍⁯‬‫‍‫‫‪‏‌‮⁬⁫‪‌‌​⁬⁪⁭⁯⁫‪‮ _‫⁪‌‪⁯⁭‬‏‍⁬⁮⁮‬‍‍‍⁫‍⁯‬‫‍‫‫‪‏‌‮⁬⁫‪‌‌​⁬⁪⁭⁯⁫‪‮3 = (u202a‍‎‎‪‍⁬⁭‬‌‎⁬‎‭‪‬‬​⁭⁬⁮‏‏‪‏‏‏‬⁬‭⁫​‎‎‭‎​‎‬⁬‮.u202b⁪‌‪⁯⁭‬‏‍⁬⁮⁮‬‍‍‍⁫‍⁯‬‫‍‫‫‪‏‌‮⁬⁫‪‌‌​⁬⁪⁭⁯⁫‪‮)u202a‍‎‎‪‍⁬⁭‬‌‎⁬‎‭‪‬‬​⁭⁬⁮‏‏‪‏‏‏‬⁬‭⁫​‎‎‭‎​‎‬⁬‮.u202e⁭⁮⁭‍‎‏⁯⁯⁯⁪‎‫⁯⁭‎‬⁬⁭‌‏‎⁭‫⁯⁬⁬‬‭‮‍‍‮‭‎⁫⁫‮‬‪‮(_‫⁪‌‪⁯⁭‬‏‍⁬⁮⁮‬‍‍‍⁫‍⁯‬‫‍‫‫‪‏‌‮⁬⁫‪‌‌​⁬⁪⁭⁯⁫‪‮2, _‫⁪‌‪⁯⁭‬‏‍⁬⁮⁮‬‍‍‍⁫‍⁯‬‫‍‫‫‪‏‌‮⁬⁫‪‌‌​⁬⁪⁭⁯⁫‪‮);
						_‫⁪‌‪⁯⁭‬‏‍⁬⁮⁮‬‍‍‍⁫‍⁯‬‫‍‫‫‪‏‌‮⁬⁫‪‌‌​⁬⁪⁭⁯⁫‪‮1 = Interlocked.CompareExchange<u202a‍‎‎‪‍⁬⁭‬‌‎⁬‎‭‪‬‬​⁭⁬⁮‏‏‪‏‏‏‬⁬‭⁫​‎‎‭‎​‎‬⁬‮.u202b⁪‌‪⁯⁭‬‏‍⁬⁮⁮‬‍‍‍⁫‍⁯‬‫‍‫‫‪‏‌‮⁬⁫‪‌‌​⁬⁪⁭⁯⁫‪‮>(ref this.u200b‌‬⁭⁫‎⁯‌⁫⁮‏‍⁫‬‪​‭‎‌‏‬⁪⁭⁪‏⁫‎‏⁫⁯‍‏⁯⁬‮⁬⁫⁪⁫‏‮, _‫⁪‌‪⁯⁭‬‏‍⁬⁮⁮‬‍‍‍⁫‍⁯‬‫‍‫‫‪‏‌‮⁬⁫‪‌‌​⁬⁪⁭⁯⁫‪‮3, _‫⁪‌‪⁯⁭‬‏‍⁬⁮⁮‬‍‍‍⁫‍⁯‬‫‍‫‫‪‏‌‮⁬⁫‪‌‌​⁬⁪⁭⁯⁫‪‮2);
						num = ((object)_‫⁪‌‪⁯⁭‬‏‍⁬⁮⁮‬‍‍‍⁫‍⁯‬‫‍‫‫‪‏‌‮⁬⁫‪‌‌​⁬⁪⁭⁯⁫‪‮1 != (object)_‫⁪‌‪⁯⁭‬‏‍⁬⁮⁮‬‍‍‍⁫‍⁯‬‫‍‫‫‪‏‌‮⁬⁫‪‌‌​⁬⁪⁭⁯⁫‪‮2 ? -71166246 : -1169318948);
						continue;
					}
					case 2:
					{
						return;
					}
				}
			}
		}
		remove
		{
			u202a‍‎‎‪‍⁬⁭‬‌‎⁬‎‭‪‬‬​⁭⁬⁮‏‏‪‏‏‏‬⁬‭⁫​‎‎‭‎​‎‬⁬‮.u202b⁪‌‪⁯⁭‬‏‍⁬⁮⁮‬‍‍‍⁫‍⁯‬‫‍‫‫‪‏‌‮⁬⁫‪‌‌​⁬⁪⁭⁯⁫‪‮ _‫⁪‌‪⁯⁭‬‏‍⁬⁮⁮‬‍‍‍⁫‍⁯‬‫‍‫‫‪‏‌‮⁬⁫‪‌‌​⁬⁪⁭⁯⁫‪‮1 = this.u200b‌‬⁭⁫‎⁯‌⁫⁮‏‍⁫‬‪​‭‎‌‏‬⁪⁭⁪‏⁫‎‏⁫⁯‍‏⁯⁬‮⁬⁫⁪⁫‏‮;
		Label1:
			int num = -402556001;
			while (true)
			{
				int num1 = num ^ -1024377812;
				uint num2 = (uint)num1;
				switch (num1 % 3)
				{
					case 0:
					{
						return;
					}
					case 1:
					{
						u202a‍‎‎‪‍⁬⁭‬‌‎⁬‎‭‪‬‬​⁭⁬⁮‏‏‪‏‏‏‬⁬‭⁫​‎‎‭‎​‎‬⁬‮.u202b⁪‌‪⁯⁭‬‏‍⁬⁮⁮‬‍‍‍⁫‍⁯‬‫‍‫‫‪‏‌‮⁬⁫‪‌‌​⁬⁪⁭⁯⁫‪‮ _‫⁪‌‪⁯⁭‬‏‍⁬⁮⁮‬‍‍‍⁫‍⁯‬‫‍‫‫‪‏‌‮⁬⁫‪‌‌​⁬⁪⁭⁯⁫‪‮2 = _‫⁪‌‪⁯⁭‬‏‍⁬⁮⁮‬‍‍‍⁫‍⁯‬‫‍‫‫‪‏‌‮⁬⁫‪‌‌​⁬⁪⁭⁯⁫‪‮1;
						u202a‍‎‎‪‍⁬⁭‬‌‎⁬‎‭‪‬‬​⁭⁬⁮‏‏‪‏‏‏‬⁬‭⁫​‎‎‭‎​‎‬⁬‮.u202b⁪‌‪⁯⁭‬‏‍⁬⁮⁮‬‍‍‍⁫‍⁯‬‫‍‫‫‪‏‌‮⁬⁫‪‌‌​⁬⁪⁭⁯⁫‪‮ _‫⁪‌‪⁯⁭‬‏‍⁬⁮⁮‬‍‍‍⁫‍⁯‬‫‍‫‫‪‏‌‮⁬⁫‪‌‌​⁬⁪⁭⁯⁫‪‮3 = (u202a‍‎‎‪‍⁬⁭‬‌‎⁬‎‭‪‬‬​⁭⁬⁮‏‏‪‏‏‏‬⁬‭⁫​‎‎‭‎​‎‬⁬‮.u202b⁪‌‪⁯⁭‬‏‍⁬⁮⁮‬‍‍‍⁫‍⁯‬‫‍‫‫‪‏‌‮⁬⁫‪‌‌​⁬⁪⁭⁯⁫‪‮)u202a‍‎‎‪‍⁬⁭‬‌‎⁬‎‭‪‬‬​⁭⁬⁮‏‏‪‏‏‏‬⁬‭⁫​‎‎‭‎​‎‬⁬‮.u206d⁫⁮‬⁯⁯⁭‏‭⁬​​⁭‪​​​⁪‭⁫⁯⁬‏⁬⁯⁯‍‪⁯⁫‏‍⁬⁪‭⁮‪‪‬‭‮(_‫⁪‌‪⁯⁭‬‏‍⁬⁮⁮‬‍‍‍⁫‍⁯‬‫‍‫‫‪‏‌‮⁬⁫‪‌‌​⁬⁪⁭⁯⁫‪‮2, _‫⁪‌‪⁯⁭‬‏‍⁬⁮⁮‬‍‍‍⁫‍⁯‬‫‍‫‫‪‏‌‮⁬⁫‪‌‌​⁬⁪⁭⁯⁫‪‮);
						_‫⁪‌‪⁯⁭‬‏‍⁬⁮⁮‬‍‍‍⁫‍⁯‬‫‍‫‫‪‏‌‮⁬⁫‪‌‌​⁬⁪⁭⁯⁫‪‮1 = Interlocked.CompareExchange<u202a‍‎‎‪‍⁬⁭‬‌‎⁬‎‭‪‬‬​⁭⁬⁮‏‏‪‏‏‏‬⁬‭⁫​‎‎‭‎​‎‬⁬‮.u202b⁪‌‪⁯⁭‬‏‍⁬⁮⁮‬‍‍‍⁫‍⁯‬‫‍‫‫‪‏‌‮⁬⁫‪‌‌​⁬⁪⁭⁯⁫‪‮>(ref this.u200b‌‬⁭⁫‎⁯‌⁫⁮‏‍⁫‬‪​‭‎‌‏‬⁪⁭⁪‏⁫‎‏⁫⁯‍‏⁯⁬‮⁬⁫⁪⁫‏‮, _‫⁪‌‪⁯⁭‬‏‍⁬⁮⁮‬‍‍‍⁫‍⁯‬‫‍‫‫‪‏‌‮⁬⁫‪‌‌​⁬⁪⁭⁯⁫‪‮3, _‫⁪‌‪⁯⁭‬‏‍⁬⁮⁮‬‍‍‍⁫‍⁯‬‫‍‫‫‪‏‌‮⁬⁫‪‌‌​⁬⁪⁭⁯⁫‪‮2);
						num = ((object)_‫⁪‌‪⁯⁭‬‏‍⁬⁮⁮‬‍‍‍⁫‍⁯‬‫‍‫‫‪‏‌‮⁬⁫‪‌‌​⁬⁪⁭⁯⁫‪‮1 == (object)_‫⁪‌‪⁯⁭‬‏‍⁬⁮⁮‬‍‍‍⁫‍⁯‬‫‍‫‫‪‏‌‮⁬⁫‪‌‌​⁬⁪⁭⁯⁫‪‮2 ? -763290081 : -402556001);
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

	public delegate void u206e‮‏‎‬‪‬‫⁭‍‬‬‎‮⁮‭⁯⁪‮‪‏‍‮‎⁬⁬‪‪‫‫⁯‬⁮‎⁯‌‮‎‫⁬‮(List<Dictionary<GlobalNames, int>> data);

	public delegate void u202b⁪‌‪⁯⁭‬‏‍⁬⁮⁮‬‍‍‍⁫‍⁯‬‫‍‫‫‪‏‌‮⁬⁫‪‌‌​⁬⁪⁭⁯⁫‪‮(Dictionary<GlobalNames, int> syncInfo);
}