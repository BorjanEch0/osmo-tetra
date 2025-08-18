using SDRSharp.Radio;
using SDRSharp.Tetra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

// ​‎‫⁮‭‏‏⁮⁫⁫‭‍‏‮‬‪‮⁮‎⁯‪⁯⁬‍‮⁮‫‎‮‏‎​⁮‏‫‫⁪‍‫‬‮
internal class u200b‎‫⁮‭‏‏⁮⁫⁫‭‍‏‮‬‪‮⁮‎⁯‪⁯⁬‍‮⁮‫‎‮‏‎​⁮‏‫‫⁪‍‫‬‮
{
	// ‏‮‭⁬⁭‭‫⁮‪​‎‫‎‪‏‫⁪‬⁯⁭‍‌‌‫⁪‫⁭⁬⁫‏​​⁯⁬⁪⁮‭‫‬⁯‮
	private u202d‍‍‬‍‫⁪⁭‌⁮‬‮⁬‍‏‭⁭‍‬⁫⁮‬⁭⁫‎⁫⁭‍‌‍⁮‮‮⁬‫‌⁪⁯​⁪‮ u200f‮‭⁬⁭‭‫⁮‪​‎‫‎‪‏‫⁪‬⁯⁭‍‌‌‫⁪‫⁭⁬⁫‏​​⁯⁬⁪⁮‭‫‬⁯‮;

	// ‫‎⁫​⁪⁮‌​⁮‮‮​‍‮⁭⁯‌‫​‫⁬‎‌⁮‬‍‌​⁯⁭⁭​‫‪⁮‍⁭⁬‫‪‮
	private u206d‎​⁪⁪‎‫‪​‭‫⁮‌‍‬⁭⁯‏‌⁭​‌‪‌‬⁭⁫‮‬⁪‏⁫⁪‫‫‬‬‬‪‪‮ u202b‎⁫​⁪⁮‌​⁮‮‮​‍‮⁭⁯‌‫​‫⁬‎‌⁮‬‍‌​⁯⁭⁭​‫‪⁮‍⁭⁬‫‪‮;

	// ⁫‍⁮‭‬⁮‮‭⁭‪⁭‏‮‌‭‪‍⁫‌⁪⁪‎⁭​‫⁬⁮​‫‎‌‭‍⁪‍⁯⁯⁮⁯⁫‮
	private UnsafeBuffer[] u206b‍⁮‭‬⁮‮‭⁭‪⁭‏‮‌‭‪‍⁫‌⁪⁪‎⁭​‫⁬⁮​‫‎‌‭‍⁪‍⁯⁯⁮⁯⁫‮;

	// ⁪‮‮‭‌​‬‮​⁪‍⁬⁭​‮‮⁯‮‏‫‭⁮⁮‫⁮⁬⁪‮‍‪‎‏⁯‭⁪‎‮​‌⁪‮
	private byte*[] u206a‮‮‭‌​‬‮​⁪‍⁬⁭​‮‮⁯‮‏‫‭⁮⁮‫⁮⁬⁪‮‍‪‎‏⁯‭⁪‎‮​‌⁪‮;

	// ⁪‎⁮‌‏⁪‪‫‪⁫⁭‏‬‮‫⁪‪‭‫⁪⁪‪⁬‏​‭⁮⁭​⁭⁪‫⁬⁭⁭‭⁫​⁪⁪‮
	private int[] u206a‎⁮‌‏⁪‪‫‪⁫⁭‏‬‮‫⁪‪‭‫⁪⁪‪⁬‏​‭⁮⁭​⁭⁪‫⁬⁭⁭‭⁫​⁪⁪‮;

	// ⁪‏⁭‭‌⁭⁮‭​​⁫⁪‮⁫⁮‭‭⁯‪‪⁫⁯⁬⁪‫‏⁪⁫⁭⁯⁮​‎‭‍⁯‭⁪‌‬‮
	private Dictionary<GlobalNames, int>[] u206a‏⁭‭‌⁭⁮‭​​⁫⁪‮⁫⁮‭‭⁯‪‪⁫⁯⁬⁪‫‏⁪⁫⁭⁯⁮​‎‭‍⁯‭⁪‌‬‮;

	// ⁯‮‮‎‍⁮⁭⁫​‏‬‮‬​⁬‌⁮⁮‏⁫‏⁫‮‬⁮‏‬⁪‏⁬⁮‫‫‮⁮‏‪⁪‏‭‮
	private static List<SSIEventLabelAllocationElement> u206f‮‮‎‍⁮⁭⁫​‏‬‮‬​⁬‌⁮⁮‏⁫‏⁫‮‬⁮‏‬⁪‏⁬⁮‫‫‮⁮‏‪⁪‏‭‮;

	// ⁬⁭⁭‍⁮​⁮⁪⁮‍‍‌‍‪‭‬‫⁪‪‍​⁯‪‌⁪⁭‎‏⁮‭‪⁫⁫⁭‭‏‪⁭​⁭‮
	private bool u206c⁭⁭‍⁮​⁮⁪⁮‍‍‌‍‪‭‬‫⁪‪‍​⁯‪‌⁪⁭‎‏⁮‭‪⁫⁫⁭‭‏‪⁭​⁭‮;

	// ⁬‌‬‍⁭‮‌‬‏‏⁫‍‫⁬⁮‏​‌⁭⁪⁭‏​⁪⁮⁫‪‏⁪⁬‬⁮‍⁯‪‫‌‎‌‮
	private readonly Rules[] u206c‌‬‍⁭‮‌‬‏‏⁫‍‫⁬⁮‏​‌⁭⁪⁭‏​⁪⁮⁫‪‏⁪⁬‬⁮‍⁯‪‫‌‎‌‮;

	// ⁮‏‌‭‭⁭‭⁫‪‮‏‭​⁫​‍‫​‭‎‬‎‬⁯⁯‪⁮‏‌‍⁮​​‏⁭‏‏⁪‍⁭‮
	private readonly Rules[] u206e‏‌‭‭⁭‭⁫‪‮‏‭​⁫​‍‫​‭‎‬‎‬⁯⁯‪⁮‏‌‍⁮​​‏⁭‏‏⁪‍⁭‮;

	// ‪‮⁫‭⁮⁮‪⁬⁫⁪‬‏‬‏‪⁯​‎⁪‭‌⁫⁪‫‭⁭⁮‪⁪‬‪‎⁬‌‮⁪‬⁬‪‫‮
	private readonly Rules[] u202a‮⁫‭⁮⁮‪⁬⁫⁪‬‏‬‏‪⁯​‎⁪‭‌⁫⁪‫‭⁭⁮‪⁪‬‪‎⁬‌‮⁪‬⁬‪‫‮;

	// ‌‎⁮​‬‎‏‬⁮‌‎‪⁪⁪‪‬‏​‮⁮⁬⁪‍‫‫⁮⁭⁭‏​‫‬‍⁭​⁫⁪‮‎⁪‮
	private readonly Rules[] u200c‎⁮​‬‎‏‬⁮‌‎‪⁪⁪‪‬‏​‮⁮⁬⁪‍‫‫⁮⁭⁭‏​‫‬‍⁭​⁫⁪‮‎⁪‮;

	// ‮‫‮⁭⁬⁫‬‎⁫‎​‍⁭⁫‎⁭⁫⁮‫⁮‎⁯‍‭⁮⁬‌⁯‍‎‪‬⁫​⁪​⁭‍‌‎‮
	private readonly Rules[] u202e‫‮⁭⁬⁫‬‎⁫‎​‍⁭⁫‎⁭⁫⁮‫⁮‎⁯‍‭⁮⁬‌⁯‍‎‪‬⁫​⁪​⁭‍‌‎‮;

	// ⁬‎‎‬⁬⁫⁯⁪‭‏‪‏⁯‭‎⁬⁭‪‌‎⁪‏‮⁮‎‪‬​‌‮⁭‭⁭‎⁪⁬⁭‎‎‮
	private readonly Rules[] u206c‎‎‬⁬⁫⁯⁪‭‏‪‏⁯‭‎⁬⁭‪‌‎⁪‏‮⁮‎‪‬​‌‮⁭‭⁭‎⁪⁬⁭‎‎‮;

	// ‫⁮‌‭‬⁭‍⁭‬⁫⁬⁮‎‍‫‍‪⁬‏‬‪‍⁮‪⁯‪⁯‫⁪‪‏⁫‬‭‫‬‫⁪‍‭‮
	private readonly Rules[] u202b⁮‌‭‬⁭‍⁭‬⁫⁬⁮‎‍‫‍‪⁬‏‬‪‍⁮‪⁯‪⁯‫⁪‪‏⁫‬‭‫‬‫⁪‍‭‮;

	// ‪‍‍⁫‪‪‏‫‬‫‎⁮‬⁮‭⁪‮‭‬‎⁯‎⁭​⁬‍⁫‪‏‬‌‫⁭‏​⁬‬‬‮‮
	private readonly Rules[] u202a‍‍⁫‪‪‏‫‬‫‎⁮‬⁮‭⁪‮‭‬‎⁯‎⁭​⁬‍⁫‪‏‬‌‫⁭‏​⁬‬‬‮‮;

	// ‌⁯‮‏‪⁪‌⁬⁫⁭‬‎‬‮‎⁯‏⁬⁯⁭‫‬⁬‏‍​⁭‎‍⁪​‫‫‫‎‫‏⁭⁮‍‮
	private readonly Rules[] u200c⁯‮‏‪⁪‌⁬⁫⁭‬‎‬‮‎⁯‏⁬⁯⁭‫‬⁬‏‍​⁭‎‍⁪​‫‫‫‎‫‏⁭⁮‍‮;

	// ‎‍‪‮⁪​⁬‍⁫‍‬⁯‌‬‫‭‍⁮⁫‏‍‏⁫⁭⁭⁯‌⁪‫‎‪⁫‏‪‌⁬⁫⁬⁭‏‮
	private readonly Rules[] u200e‍‪‮⁪​⁬‍⁫‍‬⁯‌‬‫‭‍⁮⁫‏‍‏⁫⁭⁭⁯‌⁪‫‎‪⁫‏‪‌⁬⁫⁬⁭‏‮;

	// ​⁮‬‍‫‬‏‌‏‍‏⁫⁭‏‍‭‌‌‭‍‌‎‌‎‮⁬‭‏⁪‏‬‏‬‭‮‎‏‬⁬⁬‮
	private readonly Rules[] u200b⁮‬‍‫‬‏‌‏‍‏⁫⁭‏‍‭‌‌‭‍‌‎‌‎‮⁬‭‏⁪‏‬‏‬‭‮‎‏‬⁬⁬‮;

	// ‫‭⁪⁫‎​‫⁫⁭⁮⁬‬⁮‌‫⁫‪⁫⁮​⁭⁯⁪‌‏‌⁪⁬⁫‌⁬‌⁫⁮‬⁬⁯‫‌⁯‮
	private readonly Rules[] u202b‭⁪⁫‎​‫⁫⁭⁮⁬‬⁮‌‫⁫‪⁫⁮​⁭⁯⁪‌‏‌⁪⁬⁫‌⁬‌⁫⁮‬⁬⁯‫‌⁯‮;

	// ⁮‭‮‪‎⁮‫⁮‌‭⁪‬‏⁫⁬‮‭⁬‪‭‪‌‭​‎​​‫‍‭⁭⁪⁫⁮⁮‪⁬‫‫⁮‮
	private readonly Rules[] u206e‭‮‪‎⁮‫⁮‌‭⁪‬‏⁫⁬‮‭⁬‪‭‪‌‭​‎​​‫‍‭⁭⁪⁫⁮⁮‪⁬‫‫⁮‮;

	// ⁮​‭⁪⁮⁫⁮‏⁯‏⁬‪⁪‏‫⁬‪‪‌‏‍‬⁭‪‮‎⁭‏⁪‌⁪⁬‭⁭⁮‮⁮⁭​‫‮
	private readonly Rules[] u206e​‭⁪⁮⁫⁮‏⁯‏⁬‪⁪‏‫⁬‪‪‌‏‍‬⁭‪‮‎⁭‏⁪‌⁪⁬‭⁭⁮‮⁮⁭​‫‮;

	// ⁪‎⁯‍⁯⁭‬⁮‮‍⁭‍⁭‬‭‪‭⁯‌⁯‭⁯‮‏‎‮‎‌​⁮⁯‪‮‫‏‪‮⁬‍‎‮
	private readonly Rules[] u206a‎⁯‍⁯⁭‬⁮‮‍⁭‍⁭‬‭‪‭⁯‌⁯‭⁯‮‏‎‮‎‌​⁮⁯‪‮‫‏‪‮⁬‍‎‮;

	// ⁭⁮‬⁪‫‮‭‌⁭‍‫⁫⁬⁪‬‪‪‮‬⁬‪‎‏‫‌⁮‎⁮‮‮​‭⁭‌‭‫‌‮⁬‏‮
	private readonly Rules[] u206d⁮‬⁪‫‮‭‌⁭‍‫⁫⁬⁪‬‪‪‮‬⁬‪‎‏‫‌⁮‎⁮‮‮​‭⁭‌‭‫‌‮⁬‏‮;

	// ‎⁪⁫​⁪‍‮⁯⁪⁪‫⁬⁭⁫‬‬‌‌‫​⁯‭‌‬‫⁮​‫⁪⁫‎‬⁫‫‪‬⁬⁪‌‮
	private readonly Rules[] u200e⁪⁫​⁪‍‮⁯⁪⁪‫⁬⁭⁫‬‬‌‌‫​⁯‭‌‬‫⁮​‫⁪⁫‎‬⁫‫‪‬⁬⁪‌‮;

	// ‌‍‌‪​‎‎‎⁫⁯‌⁪⁫⁪⁯‭‫‮​‬‮‫⁭‌‬⁯⁭‬‬⁫⁭⁯‌‫⁬⁫⁪‌⁬‍‮
	private readonly Rules[] u200c‍‌‪​‎‎‎⁫⁯‌⁪⁫⁪⁯‭‫‮​‬‮‫⁭‌‬⁯⁭‬‬⁫⁭⁯‌‫⁬⁫⁪‌⁬‍‮;

	// ‭⁮‌‎‮⁪⁭‭‎‎‬‍​‌‪⁫‎​‭⁪​‍‬‫⁯⁪‫‏⁭‍‌‎‪​⁯⁭‌‪⁬⁯‮
	private readonly Rules[] u202d⁮‌‎‮⁪⁭‭‎‎‬‍​‌‪⁫‎​‭⁪​‍‬‫⁯⁪‫‏⁭‍‌‎‪​⁯⁭‌‪⁬⁯‮;

	// ​‌⁫‌‪​⁪‪‪‮⁮​‭‍‌⁯‌‭⁫‌‭⁪‍‭⁮‎⁮‮‏‏⁪⁮‫⁬​‫‏​‎‫‮
	public int u200b‌⁫‌‪​⁪‪‪‮⁮​‭‍‌⁯‌‭⁫‌‭⁪‍‭⁮‎⁮‮‏‏⁪⁮‫⁬​‫‏​‎‫‮
	{
		set
		{
			this.u206a‎⁮‌‏⁪‪‫‪⁫⁭‏‬‮‫⁪‪‭‫⁪⁪‪⁬‏​‭⁮⁭​⁭⁪‫⁬⁭⁭‭⁫​⁪⁪‮[value - 1] = 0;
		}
	}

	// ​‌‭⁯⁯⁮⁫‎‮⁮⁯⁭​‮‍‮‬‎‫‭‭⁮⁫⁫‮⁭‏‍‫‬‪‎‬​⁬⁫⁭⁫⁬‭‮
	public bool u200b‌‭⁯⁯⁮⁫‎‮⁮⁯⁭​‮‍‮‬‎‫‭‭⁮⁫⁫‮⁭‏‍‫‬‪‎‬​⁬⁫⁭⁫⁬‭‮
	{
		get;
		private set;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	// ​‏⁬⁪‎⁯⁪‏⁯‬‍​‮‫‏⁪⁯‬‍‪‏‌⁮​​​‭⁮⁬⁯⁯‬‮‎⁯‍‬‌⁬‮
	public void u200b‏⁬⁪‎⁯⁪‏⁯‬‍​‮‫‏⁪⁯‬‍‪‏‌⁮​​​‭⁮⁬⁯⁯‬‮‎⁯‍‬‌⁬‮(LogicChannel , Dictionary<GlobalNames, int> )
	{
		// 
		// Current member / type: System.Void ​‎‫⁮‭‏‏⁮⁫⁫‭‍‏‮‬‪‮⁮‎⁯‪⁯⁬‍‮⁮‫‎‮‏‎​⁮‏‫‫⁪‍‫‬‮::​‏⁬⁪‎⁯⁪‏⁯‬‍​‮‫‏⁪⁯‬‍‪‏‌⁮​​​‭⁮⁬⁯⁯‬‮‎⁯‍‬‌⁬‮(SDRSharp.Tetra.LogicChannel,System.Collections.Generic.Dictionary`2<SDRSharp.Tetra.GlobalNames,System.Int32>)
		// File path: C:\SDRSharp\Plugins\Tetra\SDRSharp.Tetra.dll
		// 
		// Product version: 0.0.0.0
		// Exception in: System.Void ​‏⁬⁪‎⁯⁪‏⁯‬‍​‮‫‏⁪⁯‬‍‪‏‌⁮​​​‭⁮⁬⁯⁯‬‮‎⁯‍‬‌⁬‮(SDRSharp.Tetra.LogicChannel,System.Collections.Generic.Dictionary<SDRSharp.Tetra.GlobalNames,System.Int32>)
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

	// ⁬‮‪‫⁯‮‏‎⁮‭‬‍⁬​‭⁯‏⁬​⁯‌⁫​​‌‫⁮‍‪‌‬‬‬​‎‭‪‮⁯⁯‮
	public int u206c‮‪‫⁯‮‏‎⁮‭‬‍⁬​‭⁯‏⁬​⁯‌⁫​​‌‫⁮‍‪‌‬‬‬​‎‭‪‮⁯⁯‮(LogicChannel , int , Dictionary<GlobalNames, int> )
	{
		// 
		// Current member / type: System.Int32 ​‎‫⁮‭‏‏⁮⁫⁫‭‍‏‮‬‪‮⁮‎⁯‪⁯⁬‍‮⁮‫‎‮‏‎​⁮‏‫‫⁪‍‫‬‮::⁬‮‪‫⁯‮‏‎⁮‭‬‍⁬​‭⁯‏⁬​⁯‌⁫​​‌‫⁮‍‪‌‬‬‬​‎‭‪‮⁯⁯‮(SDRSharp.Tetra.LogicChannel,System.Int32,System.Collections.Generic.Dictionary`2<SDRSharp.Tetra.GlobalNames,System.Int32>)
		// File path: C:\SDRSharp\Plugins\Tetra\SDRSharp.Tetra.dll
		// 
		// Product version: 0.0.0.0
		// Exception in: System.Int32 ⁬‮‪‫⁯‮‏‎⁮‭‬‍⁬​‭⁯‏⁬​⁯‌⁫​​‌‫⁮‍‪‌‬‬‬​‎‭‪‮⁯⁯‮(SDRSharp.Tetra.LogicChannel,System.Int32,System.Collections.Generic.Dictionary<SDRSharp.Tetra.GlobalNames,System.Int32>)
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
	// ‫‬⁫‭⁯⁮‎‮⁪⁫​‌​‍‍‏⁬‬‎‌‍⁪​⁫⁭⁬‮​⁬⁫⁭‎‍‍‏‫‭‭⁯‪‮
	public void u202b‬⁫‭⁯⁮‎‮⁪⁫​‌​‍‍‏⁬‬‎‌‍⁪​⁫⁭⁬‮​⁬⁫⁭‎‍‍‏‫‭‭⁯‪‮(LogicChannel , List<Dictionary<GlobalNames, int>> )
	{
		// 
		// Current member / type: System.Void ​‎‫⁮‭‏‏⁮⁫⁫‭‍‏‮‬‪‮⁮‎⁯‪⁯⁬‍‮⁮‫‎‮‏‎​⁮‏‫‫⁪‍‫‬‮::‫‬⁫‭⁯⁮‎‮⁪⁫​‌​‍‍‏⁬‬‎‌‍⁪​⁫⁭⁬‮​⁬⁫⁭‎‍‍‏‫‭‭⁯‪‮(SDRSharp.Tetra.LogicChannel,System.Collections.Generic.List`1<System.Collections.Generic.Dictionary`2<SDRSharp.Tetra.GlobalNames,System.Int32>>)
		// File path: C:\SDRSharp\Plugins\Tetra\SDRSharp.Tetra.dll
		// 
		// Product version: 0.0.0.0
		// Exception in: System.Void ‫‬⁫‭⁯⁮‎‮⁪⁫​‌​‍‍‏⁬‬‎‌‍⁪​⁫⁭⁬‮​⁬⁫⁭‎‍‍‏‫‭‭⁯‪‮(SDRSharp.Tetra.LogicChannel,System.Collections.Generic.List<System.Collections.Generic.Dictionary<SDRSharp.Tetra.GlobalNames,System.Int32>>)
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

	// ‏‏⁫⁬‫⁭⁫‍⁪⁮‍​⁯‍‪‪⁭⁬⁯⁮​‍‬‮⁫⁮‍​‎‏‪⁮‪‮‮‎‌⁪‭‮
	private void u200f‏⁫⁬‫⁭⁫‍⁪⁮‍​⁯‍‪‪⁭⁬⁯⁮​‍‬‮⁫⁮‍​‎‏‪⁮‪‮‮‎‌⁪‭‮(LogicChannel , int , Dictionary<GlobalNames, int> )
	{
		// 
		// Current member / type: System.Void ​‎‫⁮‭‏‏⁮⁫⁫‭‍‏‮‬‪‮⁮‎⁯‪⁯⁬‍‮⁮‫‎‮‏‎​⁮‏‫‫⁪‍‫‬‮::‏‏⁫⁬‫⁭⁫‍⁪⁮‍​⁯‍‪‪⁭⁬⁯⁮​‍‬‮⁫⁮‍​‎‏‪⁮‪‮‮‎‌⁪‭‮(SDRSharp.Tetra.LogicChannel,System.Int32,System.Collections.Generic.Dictionary`2<SDRSharp.Tetra.GlobalNames,System.Int32>)
		// File path: C:\SDRSharp\Plugins\Tetra\SDRSharp.Tetra.dll
		// 
		// Product version: 0.0.0.0
		// Exception in: System.Void ‏‏⁫⁬‫⁭⁫‍⁪⁮‍​⁯‍‪‪⁭⁬⁯⁮​‍‬‮⁫⁮‍​‎‏‪⁮‪‮‮‎‌⁪‭‮(SDRSharp.Tetra.LogicChannel,System.Int32,System.Collections.Generic.Dictionary<SDRSharp.Tetra.GlobalNames,System.Int32>)
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

	// ‌⁯‬⁪‌‭⁯⁪‏‎‏‍‬⁬‏⁭​⁭​‪⁮‮‏⁯⁫​‏⁪‎⁬‭‌‍‭‏‪⁯‪‌⁯‮
	private void u200c⁯‬⁪‌‭⁯⁪‏‎‏‍‬⁬‏⁭​⁭​‪⁮‮‏⁯⁫​‏⁪‎⁬‭‌‍‭‏‪⁯‪‌⁯‮(LogicChannel , int , Dictionary<GlobalNames, int> )
	{
		// 
		// Current member / type: System.Void ​‎‫⁮‭‏‏⁮⁫⁫‭‍‏‮‬‪‮⁮‎⁯‪⁯⁬‍‮⁮‫‎‮‏‎​⁮‏‫‫⁪‍‫‬‮::‌⁯‬⁪‌‭⁯⁪‏‎‏‍‬⁬‏⁭​⁭​‪⁮‮‏⁯⁫​‏⁪‎⁬‭‌‍‭‏‪⁯‪‌⁯‮(SDRSharp.Tetra.LogicChannel,System.Int32,System.Collections.Generic.Dictionary`2<SDRSharp.Tetra.GlobalNames,System.Int32>)
		// File path: C:\SDRSharp\Plugins\Tetra\SDRSharp.Tetra.dll
		// 
		// Product version: 0.0.0.0
		// Exception in: System.Void ‌⁯‬⁪‌‭⁯⁪‏‎‏‍‬⁬‏⁭​⁭​‪⁮‮‏⁯⁫​‏⁪‎⁬‭‌‍‭‏‪⁯‪‌⁯‮(SDRSharp.Tetra.LogicChannel,System.Int32,System.Collections.Generic.Dictionary<SDRSharp.Tetra.GlobalNames,System.Int32>)
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

	// ⁫⁬‏‬​‭⁮​‫‫⁬‫​⁪‫​‫‬​⁭‌⁭⁮⁭⁯‪⁬‬‬‏‌‫⁫‬⁫‌‌​⁯‪‮
	private void u206b⁬‏‬​‭⁮​‫‫⁬‫​⁪‫​‫‬​⁭‌⁭⁮⁭⁯‪⁬‬‬‏‌‫⁫‬⁫‌‌​⁯‪‮(LogicChannel , int , Dictionary<GlobalNames, int> )
	{
		// 
		// Current member / type: System.Void ​‎‫⁮‭‏‏⁮⁫⁫‭‍‏‮‬‪‮⁮‎⁯‪⁯⁬‍‮⁮‫‎‮‏‎​⁮‏‫‫⁪‍‫‬‮::⁫⁬‏‬​‭⁮​‫‫⁬‫​⁪‫​‫‬​⁭‌⁭⁮⁭⁯‪⁬‬‬‏‌‫⁫‬⁫‌‌​⁯‪‮(SDRSharp.Tetra.LogicChannel,System.Int32,System.Collections.Generic.Dictionary`2<SDRSharp.Tetra.GlobalNames,System.Int32>)
		// File path: C:\SDRSharp\Plugins\Tetra\SDRSharp.Tetra.dll
		// 
		// Product version: 0.0.0.0
		// Exception in: System.Void ⁫⁬‏‬​‭⁮​‫‫⁬‫​⁪‫​‫‬​⁭‌⁭⁮⁭⁯‪⁬‬‬‏‌‫⁫‬⁫‌‌​⁯‪‮(SDRSharp.Tetra.LogicChannel,System.Int32,System.Collections.Generic.Dictionary<SDRSharp.Tetra.GlobalNames,System.Int32>)
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

	// ⁬⁫‫⁪‍⁭‫⁮⁬⁬‬​​‏⁪‬‍‭⁪‏⁮⁬⁭‬⁬⁯‎‮⁯⁭‌‭⁫⁪‌‪‌‌​‎‮
	private void u206c⁫‫⁪‍⁭‫⁮⁬⁬‬​​‏⁪‬‍‭⁪‏⁮⁬⁭‬⁬⁯‎‮⁯⁭‌‭⁫⁪‌‪‌‌​‎‮(LogicChannel logicChannel, int num, Dictionary<GlobalNames, int> globalNames)
	{
		int num1 = 0;
		int num2;
		int num3;
		int num4 = 1;
		int num5 = u206c‪‬⁭‭⁯‏​‪⁭‍⁫‍‫⁮‎⁭‭⁪‮‎‭‏‬⁮⁮‍⁭‎⁪‮⁯​‎‎‌⁯⁯⁭⁯‮.u200b‌⁫‏‮‌‭​​⁮‫⁪⁮‏⁫⁯⁫‪⁬⁭‫⁮‏⁪‭⁮⁯​​‎‍‍‎​⁭‏⁫‌‏⁭‮(logicChannel.Ptr, num, num4);
	Label0:
		int num6 = -2145341512;
		while (true)
		{
			int num7 = num6 ^ -115378272;
			uint num8 = (uint)num7;
			switch (num7 % 9)
			{
				case 0:
				{
					num += 6;
					num6 = (int)(num8 * 1600797117 ^ -116392783);
					continue;
				}
				case 1:
				{
					this.u200b‌‭⁯⁯⁮⁫‎‮⁮⁯⁭​‮‍‮‬‎‫‭‭⁮⁫⁫‮⁭‏‍‫‬‪‎‬​⁬⁫⁭⁫⁬‭‮ = (num5 == 0 ? false : true);
					num6 = -744355316;
					continue;
				}
				case 2:
				{
					u206c‪‬⁭‭⁯‏​‪⁭‍⁫‍‫⁮‎⁭‭⁪‮‎‭‏‬⁮⁮‍⁭‎⁪‮⁯​‎‎‌⁯⁯⁭⁯‮.u200b‌⁫‏‮‌‭​​⁮‫⁪⁮‏⁫⁯⁫‪⁬⁭‫⁮‏⁪‭⁮⁯​​‎‍‍‎​⁭‏⁫‌‏⁭‮(logicChannel.Ptr, num, 6);
					num6 = (int)(num8 * -417636347 ^ -645069170);
					continue;
				}
				case 3:
				{
					globalNames.Add(GlobalNames.Second_half_slot_stolen, num5);
					num6 = (int)(num8 * 133322963 ^ 26148102);
					continue;
				}
				case 4:
				{
					num += num4;
					num6 = (int)(num8 * 2074274042 ^ 1889852850);
					continue;
				}
				case 5:
				{
					int num9 = u206c‪‬⁭‭⁯‏​‪⁭‍⁫‍‫⁮‎⁭‭⁪‮‎‭‏‬⁮⁮‍⁭‎⁪‮⁯​‎‎‌⁯⁯⁭⁯‮.u200b‌⁫‏‮‌‭​​⁮‫⁪⁮‏⁫⁯⁫‪⁬⁭‫⁮‏⁪‭⁮⁯​​‎‍‍‎​⁭‏⁫‌‏⁭‮(logicChannel.Ptr, num, num4);
					num += num4;
					num1 = u206c‪‬⁭‭⁯‏​‪⁭‍⁫‍‫⁮‎⁭‭⁪‮‎‭‏‬⁮⁮‍⁭‎⁪‮⁯​‎‎‌⁯⁯⁭⁯‮.u200b‌⁫‏‮‌‭​​⁮‫⁪⁮‏⁫⁯⁫‪⁬⁭‫⁮‏⁪‭⁮⁯​​‎‍‍‎​⁭‏⁫‌‏⁭‮(logicChannel.Ptr, num, num4);
					num += num4;
					num2 = (num9 == 0 ? 927358881 : 1395561893);
					num6 = (int)(num2 ^ num8 * 953810177);
					continue;
				}
				case 6:
				{
					goto Label0;
				}
				case 7:
				{
					num3 = (num1 == 0 ? -965506045 : -1276895356);
					num6 = (int)(num3 ^ num8 * 851275553);
					continue;
				}
				case 8:
				{
					return;
				}
			}
		}
	}

	// ‬​⁯⁬⁭⁪‍⁪⁭‏‏⁬‎⁬⁬​‫‍⁫‏‭⁬⁭‌‭‪‏⁭‌‏‪⁫‪⁭⁬‮‫‍⁭‍‮
	private void u202c​⁯⁬⁭⁪‍⁪⁭‏‏⁬‎⁬⁬​‫‍⁫‏‭⁬⁭‌‭‪‏⁭‌‏‪⁫‪⁭⁬‮‫‍⁭‍‮(LogicChannel , int , Dictionary<GlobalNames, int> )
	{
		// 
		// Current member / type: System.Void ​‎‫⁮‭‏‏⁮⁫⁫‭‍‏‮‬‪‮⁮‎⁯‪⁯⁬‍‮⁮‫‎‮‏‎​⁮‏‫‫⁪‍‫‬‮::‬​⁯⁬⁭⁪‍⁪⁭‏‏⁬‎⁬⁬​‫‍⁫‏‭⁬⁭‌‭‪‏⁭‌‏‪⁫‪⁭⁬‮‫‍⁭‍‮(SDRSharp.Tetra.LogicChannel,System.Int32,System.Collections.Generic.Dictionary`2<SDRSharp.Tetra.GlobalNames,System.Int32>)
		// File path: C:\SDRSharp\Plugins\Tetra\SDRSharp.Tetra.dll
		// 
		// Product version: 0.0.0.0
		// Exception in: System.Void ‬​⁯⁬⁭⁪‍⁪⁭‏‏⁬‎⁬⁬​‫‍⁫‏‭⁬⁭‌‭‪‏⁭‌‏‪⁫‪⁭⁬‮‫‍⁭‍‮(SDRSharp.Tetra.LogicChannel,System.Int32,System.Collections.Generic.Dictionary<SDRSharp.Tetra.GlobalNames,System.Int32>)
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
	// ‬‭‬⁫‭⁯‭‏‪⁫‌‫⁯⁯‮‍‭‎⁬‎‭‍‫‬⁮⁯‌‫‭‌‌‪⁮‎​⁫‪‭‫‭‮
	public void u202c‭‬⁫‭⁯‭‏‪⁫‌‫⁯⁯‮‍‭‎⁬‎‭‍‫‬⁮⁯‌‫‭‌‌‪⁮‎​⁫‪‭‫‭‮(LogicChannel , Dictionary<GlobalNames, int> , List<Dictionary<GlobalNames, int>> )
	{
		// 
		// Current member / type: System.Void ​‎‫⁮‭‏‏⁮⁫⁫‭‍‏‮‬‪‮⁮‎⁯‪⁯⁬‍‮⁮‫‎‮‏‎​⁮‏‫‫⁪‍‫‬‮::‬‭‬⁫‭⁯‭‏‪⁫‌‫⁯⁯‮‍‭‎⁬‎‭‍‫‬⁮⁯‌‫‭‌‌‪⁮‎​⁫‪‭‫‭‮(SDRSharp.Tetra.LogicChannel,System.Collections.Generic.Dictionary`2<SDRSharp.Tetra.GlobalNames,System.Int32>,System.Collections.Generic.List`1<System.Collections.Generic.Dictionary`2<SDRSharp.Tetra.GlobalNames,System.Int32>>)
		// File path: C:\SDRSharp\Plugins\Tetra\SDRSharp.Tetra.dll
		// 
		// Product version: 0.0.0.0
		// Exception in: System.Void ‬‭‬⁫‭⁯‭‏‪⁫‌‫⁯⁯‮‍‭‎⁬‎‭‍‫‬⁮⁯‌‫‭‌‌‪⁮‎​⁫‪‭‫‭‮(SDRSharp.Tetra.LogicChannel,System.Collections.Generic.Dictionary<SDRSharp.Tetra.GlobalNames,System.Int32>,System.Collections.Generic.List<System.Collections.Generic.Dictionary<SDRSharp.Tetra.GlobalNames,System.Int32>>)
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
	// ‎‪‭‌‌‭⁯​‎‏⁭‏‍⁮‮⁮⁪‭⁪⁮⁫⁯⁬‫⁫‫‍⁯⁭⁪​⁭‬⁪⁯⁭‪‫⁬⁯‮
	public void u200e‪‭‌‌‭⁯​‎‏⁭‏‍⁮‮⁮⁪‭⁪⁮⁫⁯⁬‫⁫‫‍⁯⁭⁪​⁭‬⁪⁯⁭‪‫⁬⁯‮(LogicChannel logicChannel, List<Dictionary<GlobalNames, int>> dictionaries)
	{
		int num = 0;
		DMAC_PDU_Type dMACPDUType = (DMAC_PDU_Type)0;
		int num1 = 0;
		uint num2;
		int num3;
		int num4;
		string empty = string.Empty;
	Label1:
		int num5 = 382948873;
		while (true)
		{
			int num6 = num5 ^ 1983573512;
			num2 = (uint)num6;
			switch (num6 % 5)
			{
				case 0:
				{
					num = 0;
					num5 = 848837003;
					continue;
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
					num4 = (this.u206c⁭⁭‍⁮​⁮⁪⁮‍‍‌‍‪‭‬‫⁪‪‍​⁯‪‌⁪⁭‎‏⁮‭‪⁫⁫⁭‭‏‪⁭​⁭‮ ? -1919981328 : -418867290);
					num5 = (int)(num4 ^ num2 * -1770453724);
					continue;
				}
				default:
				{
					goto Label0;
				}
			}
		}
		return;
	Label0:
		Dictionary<GlobalNames, int> globalNames = new Dictionary<GlobalNames, int>()
		{
			{ GlobalNames.CurrTimeSlot, logicChannel.TimeSlot }
		};
		Dictionary<GlobalNames, int> globalNames1 = globalNames;
		try
		{
			empty = u003cModuleu003e.u206f⁮​‌‪‮‎‭‏‮‎⁮⁮‮⁬⁫‍‍⁪‍⁫⁮‏​‎⁬⁯⁪‪‍⁪⁮‎⁬⁪⁫​⁮⁪⁮‮<string>(1761619056);
		Label4:
			int num7 = 357560981;
			while (true)
			{
				int num8 = num7 ^ 1983573512;
				num2 = (uint)num8;
				switch (num8 % 20)
				{
					case 0:
					{
						num7 = (int)(num2 * 1412844033 ^ -1619770322);
						continue;
					}
					case 1:
					{
						dMACPDUType = (DMAC_PDU_Type)u206c‪‬⁭‭⁯‏​‪⁭‍⁫‍‫⁮‎⁭‭⁪‮‎‭‏‬⁮⁮‍⁭‎⁪‮⁯​‎‎‌⁯⁯⁭⁯‮.u200b‌⁫‏‮‌‭​​⁮‫⁪⁮‏⁫⁯⁫‪⁬⁭‫⁮‏⁪‭⁮⁯​​‎‍‍‎​⁭‏⁫‌‏⁭‮(logicChannel.Ptr, num, 2);
						num += 2;
						num7 = (int)(num2 * 525572380 ^ 1443253915);
						continue;
					}
					case 2:
					{
						dictionaries.Add(globalNames1);
						num7 = 830969644;
						continue;
					}
					case 3:
					{
						globalNames1.Add(GlobalNames.DMAC_PDU_Type, dMACPDUType);
						empty = u200b‎‫⁮‭‏‏⁮⁫⁫‭‍‏‮‬‪‮⁮‎⁯‪⁯⁬‍‮⁮‫‎‮‏‎​⁮‏‫‫⁪‍‫‬‮.u206e‏​‌‪‎‌‌​⁮⁫‎‏‮‬‬​‎‌⁫‌⁯‪‬⁮‬‫‌​‮⁮⁭‌⁯‬⁭‫⁮​‪‮(empty, dMACPDUType.ToString());
						num7 = (int)(num2 * 1599182341 ^ 1606286014);
						continue;
					}
					case 4:
					{
						num++;
						num7 = (int)(num2 * -1121280711 ^ 1771994066);
						continue;
					}
					case 5:
					{
						this.u206c‭‍⁮‫‮‪⁭‎‏‫‭‬⁫⁭‭⁬‍⁮⁯​‌‪⁪⁮‎‮‭⁯‮⁭‌⁪⁭⁭⁬‮⁯⁭⁬‮(logicChannel, num, globalNames1);
						num7 = 218249426;
						continue;
					}
					case 6:
					{
						num7 = (int)(num2 * -1121413780 ^ -334126798);
						continue;
					}
					case 7:
					{
					Label6:
						num1 = u206c‪‬⁭‭⁯‏​‪⁭‍⁫‍‫⁮‎⁭‭⁪‮‎‭‏‬⁮⁮‍⁭‎⁪‮⁯​‎‎‌⁯⁯⁭⁯‮.u200b‌⁫‏‮‌‭​​⁮‫⁪⁮‏⁫⁯⁫‪⁬⁭‫⁮‏⁪‭⁮⁯​​‎‍‍‎​⁭‏⁫‌‏⁭‮(logicChannel.Ptr, num, 1);
						num7 = 923069572;
						continue;
					}
					case 8:
					{
						this.u200b‍‍‮⁮‏⁫‍⁬‌‎⁬⁮‏‭⁫⁯‬‪‫⁬⁫‪⁬‍‌⁬‫‭⁬‮​⁭‏⁪‌⁯‭⁮⁯‮(logicChannel, num, globalNames1);
						num7 = (int)(num2 * 309506738 ^ -1479419530);
						continue;
					}
					case 9:
					{
					Label7:
						globalNames1.Add(GlobalNames.UnknownData, 1);
						num7 = 2030183626;
						continue;
					}
					case 10:
					{
						globalNames1.Add(GlobalNames.DMAC_PDU_Sub_Type, num1);
						num7 = (int)(num2 * 1036426257 ^ 679859298);
						continue;
					}
					case 11:
					{
						num7 = (int)(num2 * -1509203079 ^ 771316081);
						continue;
					}
					case 12:
					{
						goto Label3;
					}
					case 13:
					{
						switch (dMACPDUType)
						{
							case DMAC_PDU_Type.DMAC_data:
							{
								goto Label5;
							}
							case DMAC_PDU_Type.DMAC_frag:
							{
								goto Label6;
							}
							case DMAC_PDU_Type.DMAC_reserved:
							{
								goto Label7;
							}
							case DMAC_PDU_Type.DMAC_U_Signal:
							{
								goto Label8;
							}
							default:
							{
								num7 = (int)(num2 * 1167085481 ^ -47035232);
								continue;
							}
						}
						break;
					}
					case 14:
					{
					Label8:
						this.u206c⁫‫⁪‍⁭‫⁮⁬⁬‬​​‏⁪‬‍‭⁪‏⁮⁬⁭‬⁬⁯‎‮⁯⁭‌‭⁫⁪‌‪‌‌​‎‮(logicChannel, num, globalNames1);
						num7 = 1013557211;
						continue;
					}
					case 15:
					{
					Label5:
						this.u206e⁭⁯​⁪⁪‪‌​‌‏⁭‮⁭‏‏‪‬‫⁭⁫⁫‮‏‌‏⁫‮⁯‮⁫⁬⁯‍‏⁭‌‪⁪⁪‮(logicChannel, num, globalNames1);
						num7 = 1297520364;
						continue;
					}
					case 16:
					{
						num3 = (num1 != 0 ? -99188283 : -1595740268);
						num7 = (int)(num3 ^ num2 * -412220376);
						continue;
					}
					case 17:
					{
						num7 = (int)(num2 * 822545374 ^ -748557377);
						continue;
					}
					case 18:
					{
						num7 = (int)(num2 * -309530945 ^ 242625776);
						continue;
					}
					case 19:
					{
						goto Label4;
					}
				}
			}
		Label3:
		}
		catch (Exception exception1)
		{
			Exception exception = exception1;
		Label9:
			int num9 = 1978815627;
			while (true)
			{
				int num10 = num9 ^ 1983573512;
				num2 = (uint)num10;
				switch (num10 % 4)
				{
					case 0:
					{
						goto Label9;
					}
					case 1:
					{
						goto Label10;
					}
					case 2:
					{
						u206b⁯⁬‫⁬⁬‎‭⁪‫‎‭‍‎‪⁬‪⁭‬⁬‬‍⁪‭‌⁬⁯⁯‌⁯⁮‪‍‍‫‮​‎⁭‎‮.u200b‪‪‭‎‎​‏‬‭‏⁪⁬‬‭‎⁭⁬⁮⁬‭⁪⁭⁭‬‮⁪‮‎‍‫‭⁪‮‫‌⁯⁭‬⁭‮(logicChannel, exception, u003cModuleu003e.u206f⁮​‌‪‮‎‭‏‮‎⁮⁮‮⁬⁫‍‍⁪‍⁫⁮‏​‎⁬⁯⁪‪‍⁪⁮‎⁬⁪⁫​⁮⁪⁮‮<string>(2001258832), empty, globalNames1);
						num9 = 1120333573;
						continue;
					}
					case 3:
					{
						this.u206c⁭⁭‍⁮​⁮⁪⁮‍‍‌‍‪‭‬‫⁪‪‍​⁯‪‌⁪⁭‎‏⁮‭‪⁫⁫⁭‭‏‪⁭​⁭‮ = true;
						num9 = (int)(num2 * -143930984 ^ 13142822);
						continue;
					}
				}
			}
		Label10:
			this.u206c⁭⁭‍⁮​⁮⁪⁮‍‍‌‍‪‭‬‫⁪‪‍​⁯‪‌⁪⁭‎‏⁮‭‪⁫⁫⁭‭‏‪⁭​⁭‮ = false;
		}
	}

	// ⁮⁭⁯​⁪⁪‪‌​‌‏⁭‮⁭‏‏‪‬‫⁭⁫⁫‮‏‌‏⁫‮⁯‮⁫⁬⁯‍‏⁭‌‪⁪⁪‮
	private void u206e⁭⁯​⁪⁪‪‌​‌‏⁭‮⁭‏‏‪‬‫⁭⁫⁫‮‏‌‏⁫‮⁯‮⁫⁬⁯‍‏⁭‌‪⁪⁪‮(LogicChannel , int , Dictionary<GlobalNames, int> )
	{
		// 
		// Current member / type: System.Void ​‎‫⁮‭‏‏⁮⁫⁫‭‍‏‮‬‪‮⁮‎⁯‪⁯⁬‍‮⁮‫‎‮‏‎​⁮‏‫‫⁪‍‫‬‮::⁮⁭⁯​⁪⁪‪‌​‌‏⁭‮⁭‏‏‪‬‫⁭⁫⁫‮‏‌‏⁫‮⁯‮⁫⁬⁯‍‏⁭‌‪⁪⁪‮(SDRSharp.Tetra.LogicChannel,System.Int32,System.Collections.Generic.Dictionary`2<SDRSharp.Tetra.GlobalNames,System.Int32>)
		// File path: C:\SDRSharp\Plugins\Tetra\SDRSharp.Tetra.dll
		// 
		// Product version: 0.0.0.0
		// Exception in: System.Void ⁮⁭⁯​⁪⁪‪‌​‌‏⁭‮⁭‏‏‪‬‫⁭⁫⁫‮‏‌‏⁫‮⁯‮⁫⁬⁯‍‏⁭‌‪⁪⁪‮(SDRSharp.Tetra.LogicChannel,System.Int32,System.Collections.Generic.Dictionary<SDRSharp.Tetra.GlobalNames,System.Int32>)
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

	// ⁬‭‍⁮‫‮‪⁭‎‏‫‭‬⁫⁭‭⁬‍⁮⁯​‌‪⁪⁮‎‮‭⁯‮⁭‌⁪⁭⁭⁬‮⁯⁭⁬‮
	private void u206c‭‍⁮‫‮‪⁭‎‏‫‭‬⁫⁭‭⁬‍⁮⁯​‌‪⁪⁮‎‮‭⁯‮⁭‌⁪⁭⁭⁬‮⁯⁭⁬‮(LogicChannel , int , Dictionary<GlobalNames, int> )
	{
		// 
		// Current member / type: System.Void ​‎‫⁮‭‏‏⁮⁫⁫‭‍‏‮‬‪‮⁮‎⁯‪⁯⁬‍‮⁮‫‎‮‏‎​⁮‏‫‫⁪‍‫‬‮::⁬‭‍⁮‫‮‪⁭‎‏‫‭‬⁫⁭‭⁬‍⁮⁯​‌‪⁪⁮‎‮‭⁯‮⁭‌⁪⁭⁭⁬‮⁯⁭⁬‮(SDRSharp.Tetra.LogicChannel,System.Int32,System.Collections.Generic.Dictionary`2<SDRSharp.Tetra.GlobalNames,System.Int32>)
		// File path: C:\SDRSharp\Plugins\Tetra\SDRSharp.Tetra.dll
		// 
		// Product version: 0.0.0.0
		// Exception in: System.Void ⁬‭‍⁮‫‮‪⁭‎‏‫‭‬⁫⁭‭⁬‍⁮⁯​‌‪⁪⁮‎‮‭⁯‮⁭‌⁪⁭⁭⁬‮⁯⁭⁬‮(SDRSharp.Tetra.LogicChannel,System.Int32,System.Collections.Generic.Dictionary<SDRSharp.Tetra.GlobalNames,System.Int32>)
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

	// ​‍‍‮⁮‏⁫‍⁬‌‎⁬⁮‏‭⁫⁯‬‪‫⁬⁫‪⁬‍‌⁬‫‭⁬‮​⁭‏⁪‌⁯‭⁮⁯‮
	private void u200b‍‍‮⁮‏⁫‍⁬‌‎⁬⁮‏‭⁫⁯‬‪‫⁬⁫‪⁬‍‌⁬‫‭⁬‮​⁭‏⁪‌⁯‭⁮⁯‮(LogicChannel , int , Dictionary<GlobalNames, int> )
	{
		// 
		// Current member / type: System.Void ​‎‫⁮‭‏‏⁮⁫⁫‭‍‏‮‬‪‮⁮‎⁯‪⁯⁬‍‮⁮‫‎‮‏‎​⁮‏‫‫⁪‍‫‬‮::​‍‍‮⁮‏⁫‍⁬‌‎⁬⁮‏‭⁫⁯‬‪‫⁬⁫‪⁬‍‌⁬‫‭⁬‮​⁭‏⁪‌⁯‭⁮⁯‮(SDRSharp.Tetra.LogicChannel,System.Int32,System.Collections.Generic.Dictionary`2<SDRSharp.Tetra.GlobalNames,System.Int32>)
		// File path: C:\SDRSharp\Plugins\Tetra\SDRSharp.Tetra.dll
		// 
		// Product version: 0.0.0.0
		// Exception in: System.Void ​‍‍‮⁮‏⁫‍⁬‌‎⁬⁮‏‭⁫⁯‬‪‫⁬⁫‪⁬‍‌⁬‫‭⁬‮​⁭‏⁪‌⁯‭⁮⁯‮(SDRSharp.Tetra.LogicChannel,System.Int32,System.Collections.Generic.Dictionary<SDRSharp.Tetra.GlobalNames,System.Int32>)
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

	// ‭⁭‬​‌‬‭⁬⁪‪⁪⁪‎‬⁫⁫⁭‏​​⁬‪‏‍⁬​‭‍‍​‬⁫​⁫‏‌‭‮‫‏‮
	private unsafe int u202d⁭‬​‌‬‭⁬⁪‪⁪⁪‎‬⁫⁫⁭‏​​⁬‪‏‍⁬​‭‍‍​‬⁫​⁫‏‌‭‮‫‏‮(byte* numPointer, int num, int num)
	{
		uint num1;
		int num2;
		int num3 = num + num - 1;
		while (true)
		{
		Label1:
			num1 = (uint)((num3 > num ? 228549253 : 1139896217));
			int num4 = (int)num1;
			while (true)
			{
				uint num5 = (uint)(num1 ^ 1867102687);
				uint num6 = num5;
				switch (num5 % 5)
				{
					case 0:
					{
						goto Label1;
					}
					case 1:
					{
						num2 = (*(numPointer + num3) != 0 ? 998689313 : 942279963);
						num1 = num2 ^ num6 * 215335372;
						continue;
					}
					case 2:
					{
						return num3 - num;
					}
					case 3:
					{
						num3--;
						num1 = 1437007995;
						continue;
					}
					case 4:
					{
						num1 = 1079879843;
						continue;
					}
				}
			}
		}
		return num3 - num;
	}

	// ‪‭‎‎‬‏‫⁬‍‪⁭​⁪‪‍‭⁭‎⁬‭‎‪‌‌‮⁬⁯‏⁬⁪‮⁫⁪‏​‮⁬‫⁭⁬‮
	private void u202a‭‎‎‬‏‫⁬‍‪⁭​⁪‪‍‭⁭‎⁬‭‎‪‌‌‮⁬⁯‏⁬⁪‮⁫⁪‏​‮⁬‫⁭⁬‮(LogicChannel logicChannel, int num, int num, Dictionary<GlobalNames, int> globalNames)
	{
		int num1;
		int num2;
		int timeSlot = logicChannel.TimeSlot - 1;
	Label1:
		int num3 = -821092189;
		while (true)
		{
			int num4 = num3 ^ -895711374;
			uint num5 = (uint)num4;
			switch (num4 % 6)
			{
				case 0:
				{
					return;
				}
				case 1:
				{
					this.u206a‏⁭‭‌⁭⁮‭​​⁫⁪‮⁫⁮‭‭⁯‪‪⁫⁯⁬⁪‫‏⁪⁫⁭⁯⁮​‎‭‍⁯‭⁪‌‬‮[timeSlot] = globalNames.ToDictionary<KeyValuePair<GlobalNames, int>, GlobalNames, int>((KeyValuePair<GlobalNames, int> argument0) => argument0.Key, (KeyValuePair<GlobalNames, int> argument1) => argument1.Value);
					num3 = -298639760;
					continue;
				}
				case 2:
				{
					u200b‎‫⁮‭‏‏⁮⁫⁫‭‍‏‮‬‪‮⁮‎⁯‪⁯⁬‍‮⁮‫‎‮‏‎​⁮‏‫‫⁪‍‫‬‮.u202a⁯‪‫‫⁫‏‭‫‏⁪‌‮⁮‫‪⁮‎⁭⁯‏⁮‍‌‫‍‬⁭⁯⁮⁪‭‫‎​⁯⁮⁯‫⁭‮(this.u206a‮‮‭‌​‬‮​⁪‍⁬⁭​‮‮⁯‮‏‫‭⁮⁮‫⁮⁬⁪‮‍‪‎‏⁯‭⁪‎‮​‌⁪‮[timeSlot], logicChannel.Ptr + num, num);
					num3 = (int)(num5 * 1260697555 ^ 2013621334);
					continue;
				}
				case 3:
				{
					num1 = (this.u206a‎⁮‌‏⁪‪‫‪⁫⁭‏‬‮‫⁪‪‭‫⁪⁪‪⁬‏​‭⁮⁭​⁭⁪‫⁬⁭⁭‭⁫​⁪⁪‮[timeSlot] + num < u200b‎‫⁮‭‏‏⁮⁫⁫‭‍‏‮‬‪‮⁮‎⁯‪⁯⁬‍‮⁮‫‎‮‏‎​⁮‏‫‫⁪‍‫‬‮.u200d‫‍⁮‏‫‏‭‫⁪‍‎⁯‎‌⁪⁯‌⁬⁬⁬‫‏‪‎⁯‎‍‏‌⁯‫‏⁮‭‍‪‎‌‍‮(this.u206b‍⁮‭‬⁮‮‭⁭‪⁭‏‮‌‭‪‍⁫‌⁪⁪‎⁭​‫⁬⁮​‫‎‌‭‍⁪‍⁯⁯⁮⁯⁫‮[timeSlot]) ? 2136936645 : 536323919);
					num3 = (int)(num1 ^ num5 * -1612930033);
					continue;
				}
				case 4:
				{
					this.u206a‎⁮‌‏⁪‪‫‪⁫⁭‏‬‮‫⁪‪‭‫⁪⁪‪⁬‏​‭⁮⁭​⁭⁪‫⁬⁭⁭‭⁫​⁪⁪‮[timeSlot] = num;
					num2 = (globalNames == null ? 16941016 : 1082235569);
					num3 = (int)(num2 ^ num5 * -1275977610);
					continue;
				}
				case 5:
				{
					goto Label1;
				}
			}
		}
	}

	// ⁫⁫⁭⁫‮‎⁮⁪‭​‪⁫⁭​⁮⁫⁭⁪⁮‪‏‫‪‭⁫‫‬⁪​‍‭‏​‮⁯‍‎⁭⁭⁭‮
	private void u206b⁫⁭⁫‮‎⁮⁪‭​‪⁫⁭​⁮⁫⁭⁪⁮‪‏‫‪‭⁫‫‬⁪​‍‭‏​‮⁯‍‎⁭⁭⁭‮(LogicChannel , int , int )
	{
		// 
		// Current member / type: System.Void ​‎‫⁮‭‏‏⁮⁫⁫‭‍‏‮‬‪‮⁮‎⁯‪⁯⁬‍‮⁮‫‎‮‏‎​⁮‏‫‫⁪‍‫‬‮::⁫⁫⁭⁫‮‎⁮⁪‭​‪⁫⁭​⁮⁫⁭⁪⁮‪‏‫‪‭⁫‫‬⁪​‍‭‏​‮⁯‍‎⁭⁭⁭‮(SDRSharp.Tetra.LogicChannel,System.Int32,System.Int32)
		// File path: C:\SDRSharp\Plugins\Tetra\SDRSharp.Tetra.dll
		// 
		// Product version: 0.0.0.0
		// Exception in: System.Void ⁫⁫⁭⁫‮‎⁮⁪‭​‪⁫⁭​⁮⁫⁭⁪⁮‪‏‫‪‭⁫‫‬⁪​‍‭‏​‮⁯‍‎⁭⁭⁭‮(SDRSharp.Tetra.LogicChannel,System.Int32,System.Int32)
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

	// ‎‬‬‍⁫​‍‍⁯​​‏⁯⁮‮⁬‪‍‭​​⁮‎‪⁫⁬‭⁪⁬‍⁮⁬‬⁮‌‎⁬​​‫‮
	private bool u200e‬‬‍⁫​‍‍⁯​​‏⁯⁮‮⁬‪‍‭​​⁮‎‪⁫⁬‭⁪⁬‍⁮⁬‬⁮‌‎⁬​​‫‮(int num)
	{
		return this.u206a‎⁮‌‏⁪‪‫‪⁫⁭‏‬‮‫⁪‪‭‫⁪⁪‪⁬‏​‭⁮⁭​⁭⁪‫⁬⁭⁭‭⁫​⁪⁪‮[num - 1] == 0;
	}

	// ‏‍‎‏‫‫⁭‎⁫⁯⁫‏⁪‏‫⁯⁯‬⁭‬‫‮⁫⁭⁪‎⁪⁬‌‪⁫‪‫‬⁭⁬‍​‮⁯‮
	private LogicChannel u200f‍‎‏‫‫⁭‎⁫⁯⁫‏⁪‏‫⁯⁯‬⁭‬‫‮⁫⁭⁪‎⁪⁬‌‪⁫‪‫‬⁭⁬‍​‮⁯‮(LogicChannel logicChannel, Dictionary<GlobalNames, int> globalNames)
	{
		int timeSlot = logicChannel.TimeSlot - 1;
		LogicChannel logicChannel1 = new LogicChannel()
		{
			Ptr = this.u206a‮‮‭‌​‬‮​⁪‍⁬⁭​‮‮⁯‮‏‫‭⁮⁮‫⁮⁬⁪‮‍‪‎‏⁯‭⁪‎‮​‌⁪‮[timeSlot],
			Length = this.u206a‎⁮‌‏⁪‪‫‪⁫⁭‏‬‮‫⁪‪‭‫⁪⁪‪⁬‏​‭⁮⁭​⁭⁪‫⁬⁭⁭‭⁫​⁪⁪‮[timeSlot],
			CrcIsOk = true,
			TimeSlot = logicChannel.TimeSlot,
			Frame = logicChannel.Frame
		};
		GlobalNames globalName = GlobalNames.Encryption_mode;
		if (this.u206a‏⁭‭‌⁭⁮‭​​⁫⁪‮⁫⁮‭‭⁯‪‪⁫⁯⁬⁪‫‏⁪⁫⁭⁯⁮​‎‭‍⁯‭⁪‌‬‮[timeSlot].ContainsKey(globalName))
		{
			globalNames.Add(globalName, this.u206a‏⁭‭‌⁭⁮‭​​⁫⁪‮⁫⁮‭‭⁯‪‪⁫⁯⁬⁪‫‏⁪⁫⁭⁯⁮​‎‭‍⁯‭⁪‌‬‮[timeSlot][globalName]);
		}
		globalName = GlobalNames.Address_type;
		if (this.u206a‏⁭‭‌⁭⁮‭​​⁫⁪‮⁫⁮‭‭⁯‪‪⁫⁯⁬⁪‫‏⁪⁫⁭⁯⁮​‎‭‍⁯‭⁪‌‬‮[timeSlot].ContainsKey(globalName))
		{
			globalNames.Add(globalName, this.u206a‏⁭‭‌⁭⁮‭​​⁫⁪‮⁫⁮‭‭⁯‪‪⁫⁯⁬⁪‫‏⁪⁫⁭⁯⁮​‎‭‍⁯‭⁪‌‬‮[timeSlot][globalName]);
		}
		globalName = GlobalNames.SSI;
		if (this.u206a‏⁭‭‌⁭⁮‭​​⁫⁪‮⁫⁮‭‭⁯‪‪⁫⁯⁬⁪‫‏⁪⁫⁭⁯⁮​‎‭‍⁯‭⁪‌‬‮[timeSlot].ContainsKey(globalName))
		{
			globalNames.Add(globalName, this.u206a‏⁭‭‌⁭⁮‭​​⁫⁪‮⁫⁮‭‭⁯‪‪⁫⁯⁬⁪‫‏⁪⁫⁭⁯⁮​‎‭‍⁯‭⁪‌‬‮[timeSlot][globalName]);
		}
		globalName = GlobalNames.Usage;
		if (this.u206a‏⁭‭‌⁭⁮‭​​⁫⁪‮⁫⁮‭‭⁯‪‪⁫⁯⁬⁪‫‏⁪⁫⁭⁯⁮​‎‭‍⁯‭⁪‌‬‮[timeSlot].ContainsKey(globalName))
		{
			globalNames.Add(globalName, this.u206a‏⁭‭‌⁭⁮‭​​⁫⁪‮⁫⁮‭‭⁯‪‪⁫⁯⁬⁪‫‏⁪⁫⁭⁯⁮​‎‭‍⁯‭⁪‌‬‮[timeSlot][globalName]);
		}
		globalName = GlobalNames.Event_Label;
		if (this.u206a‏⁭‭‌⁭⁮‭​​⁫⁪‮⁫⁮‭‭⁯‪‪⁫⁯⁬⁪‫‏⁪⁫⁭⁯⁮​‎‭‍⁯‭⁪‌‬‮[timeSlot].ContainsKey(globalName))
		{
			globalNames.Add(globalName, this.u206a‏⁭‭‌⁭⁮‭​​⁫⁪‮⁫⁮‭‭⁯‪‪⁫⁯⁬⁪‫‏⁪⁫⁭⁯⁮​‎‭‍⁯‭⁪‌‬‮[timeSlot][globalName]);
		}
		globalName = GlobalNames.DMAC_Message_type;
		if (this.u206a‏⁭‭‌⁭⁮‭​​⁫⁪‮⁫⁮‭‭⁯‪‪⁫⁯⁬⁪‫‏⁪⁫⁭⁯⁮​‎‭‍⁯‭⁪‌‬‮[timeSlot].ContainsKey(globalName))
		{
			globalNames.Add(globalName, this.u206a‏⁭‭‌⁭⁮‭​​⁫⁪‮⁫⁮‭‭⁯‪‪⁫⁯⁬⁪‫‏⁪⁫⁭⁯⁮​‎‭‍⁯‭⁪‌‬‮[timeSlot][globalName]);
		}
		globalName = GlobalNames.Source_address_type;
		if (this.u206a‏⁭‭‌⁭⁮‭​​⁫⁪‮⁫⁮‭‭⁯‪‪⁫⁯⁬⁪‫‏⁪⁫⁭⁯⁮​‎‭‍⁯‭⁪‌‬‮[timeSlot].ContainsKey(globalName))
		{
			globalNames.Add(globalName, this.u206a‏⁭‭‌⁭⁮‭​​⁫⁪‮⁫⁮‭‭⁯‪‪⁫⁯⁬⁪‫‏⁪⁫⁭⁯⁮​‎‭‍⁯‭⁪‌‬‮[timeSlot][globalName]);
		}
		globalName = GlobalNames.Source_address;
		if (this.u206a‏⁭‭‌⁭⁮‭​​⁫⁪‮⁫⁮‭‭⁯‪‪⁫⁯⁬⁪‫‏⁪⁫⁭⁯⁮​‎‭‍⁯‭⁪‌‬‮[timeSlot].ContainsKey(globalName))
		{
			globalNames.Add(globalName, this.u206a‏⁭‭‌⁭⁮‭​​⁫⁪‮⁫⁮‭‭⁯‪‪⁫⁯⁬⁪‫‏⁪⁫⁭⁯⁮​‎‭‍⁯‭⁪‌‬‮[timeSlot][globalName]);
		}
		globalName = GlobalNames.Destination_address_type;
		if (this.u206a‏⁭‭‌⁭⁮‭​​⁫⁪‮⁫⁮‭‭⁯‪‪⁫⁯⁬⁪‫‏⁪⁫⁭⁯⁮​‎‭‍⁯‭⁪‌‬‮[timeSlot].ContainsKey(globalName))
		{
			globalNames.Add(globalName, this.u206a‏⁭‭‌⁭⁮‭​​⁫⁪‮⁫⁮‭‭⁯‪‪⁫⁯⁬⁪‫‏⁪⁫⁭⁯⁮​‎‭‍⁯‭⁪‌‬‮[timeSlot][globalName]);
		}
		globalName = GlobalNames.Destination_address;
		if (this.u206a‏⁭‭‌⁭⁮‭​​⁫⁪‮⁫⁮‭‭⁯‪‪⁫⁯⁬⁪‫‏⁪⁫⁭⁯⁮​‎‭‍⁯‭⁪‌‬‮[timeSlot].ContainsKey(globalName))
		{
			globalNames.Add(globalName, this.u206a‏⁭‭‌⁭⁮‭​​⁫⁪‮⁫⁮‭‭⁯‪‪⁫⁯⁬⁪‫‏⁪⁫⁭⁯⁮​‎‭‍⁯‭⁪‌‬‮[timeSlot][globalName]);
		}
		globalName = GlobalNames.Air_interface_encryption;
		if (this.u206a‏⁭‭‌⁭⁮‭​​⁫⁪‮⁫⁮‭‭⁯‪‪⁫⁯⁬⁪‫‏⁪⁫⁭⁯⁮​‎‭‍⁯‭⁪‌‬‮[timeSlot].ContainsKey(globalName))
		{
			globalNames.Add(globalName, this.u206a‏⁭‭‌⁭⁮‭​​⁫⁪‮⁫⁮‭‭⁯‪‪⁫⁯⁬⁪‫‏⁪⁫⁭⁯⁮​‎‭‍⁯‭⁪‌‬‮[timeSlot][globalName]);
		}
		globalNames.Add(GlobalNames.IsFragmentedPDU, 1);
		this.u206a‏⁭‭‌⁭⁮‭​​⁫⁪‮⁫⁮‭‭⁯‪‪⁫⁯⁬⁪‫‏⁪⁫⁭⁯⁮​‎‭‍⁯‭⁪‌‬‮[timeSlot].Clear();
		this.u206a‎⁮‌‏⁪‪‫‪⁫⁭‏‬‮‫⁪‪‭‫⁪⁪‪⁬‏​‭⁮⁭​⁭⁪‫⁬⁭⁭‭⁫​⁪⁪‮[timeSlot] = 0;
		return logicChannel1;
	}

	// ⁮⁭‏‪‪‮⁯‫⁯⁫‏​⁭⁮‮‬‌‏‍‬‍⁯⁬‍​‪⁮⁭‭⁬‍⁮⁫‮‭‬​‎​‎‮
	// privatescope
	internal static UnsafeBuffer u206e⁭‏‪‪‮⁯‫⁯⁫‏​⁭⁮‮‬‌‏‍‬‍⁯⁬‍​‪⁮⁭‭⁬‍⁮⁫‮‭‬​‎​‎‮(int num, int num)
	{
		return UnsafeBuffer.Create(num, num);
	}

	// ⁫⁮‪‏⁬‭⁪​‍‍‎‎⁭⁭​⁪⁪‎‭​⁯‪‫⁯‌⁪‫‍‍‌‌‏‭‎‭⁪⁭‬‍‮‮
	// privatescope
	internal static unsafe void* u206b⁮‪‏⁬‭⁪​‍‍‎‎⁭⁭​⁪⁪‎‭​⁯‪‫⁯‌⁪‫‍‍‌‌‏‭‎‭⁪⁭‬‍‮‮(UnsafeBuffer unsafeBuffer)
	{
		return unsafeBuffer;
	}

	// ⁮‏​‌‪‎‌‌​⁮⁫‎‏‮‬‬​‎‌⁫‌⁯‪‬⁮‬‫‌​‮⁮⁭‌⁯‬⁭‫⁮​‪‮
	// privatescope
	internal static string u206e‏​‌‪‎‌‌​⁮⁫‎‏‮‬‬​‎‌⁫‌⁯‪‬⁮‬‫‌​‮⁮⁭‌⁯‬⁭‫⁮​‪‮(string str, string str)
	{
		return string.Concat(str, str);
	}

	// ⁭⁫‭‌‪⁬⁫⁪‮‏⁪‮‪‌‪‪⁬‍⁫⁫‍‮‫​⁯‭​⁬‍‎‌‍⁭‏⁪‭‬‍⁪⁪‮
	// privatescope
	internal static string u206d⁫‭‌‪⁬⁫⁪‮‏⁪‮‪‌‪‪⁬‍⁫⁫‍‮‫​⁯‭​⁬‍‎‌‍⁭‏⁪‭‬‍⁪⁪‮(object obj, object obj, object obj)
	{
		return string.Concat(obj, obj, obj);
	}

	// ‍‫‍⁮‏‫‏‭‫⁪‍‎⁯‎‌⁪⁯‌⁬⁬⁬‫‏‪‎⁯‎‍‏‌⁯‫‏⁮‭‍‪‎‌‍‮
	// privatescope
	internal static int u200d‫‍⁮‏‫‏‭‫⁪‍‎⁯‎‌⁪⁯‌⁬⁬⁬‫‏‪‎⁯‎‍‏‌⁯‫‏⁮‭‍‪‎‌‍‮(UnsafeBuffer unsafeBuffer)
	{
		return unsafeBuffer.get_Length();
	}

	// ‪⁯‪‫‫⁫‏‭‫‏⁪‌‮⁮‫‪⁮‎⁭⁯‏⁮‍‌‫‍‬⁭⁯⁮⁪‭‫‎​⁯⁮⁯‫⁭‮
	// privatescope
	internal static unsafe void* u202a⁯‪‫‫⁫‏‭‫‏⁪‌‮⁮‫‪⁮‎⁭⁯‏⁮‍‌‫‍‬⁭⁯⁮⁪‭‫‎​⁯⁮⁯‫⁭‮(void* voidPointer, void* voidPointer, int num)
	{
		return Utils.Memcpy(voidPointer, voidPointer, num);
	}

	static u200b‎‫⁮‭‏‏⁮⁫⁫‭‍‏‮‬‪‮⁮‎⁯‪⁯⁬‍‮⁮‫‎‮‏‎​⁮‏‫‫⁪‍‫‬‮()
	{
		u200b‎‫⁮‭‏‏⁮⁫⁫‭‍‏‮‬‪‮⁮‎⁯‪⁯⁬‍‮⁮‫‎‮‏‎​⁮‏‫‫⁪‍‫‬‮.u206f‮‮‎‍⁮⁭⁫​‏‬‮‬​⁬‌⁮⁮‏⁫‏⁫‮‬⁮‏‬⁪‏⁬⁮‫‫‮⁮‏‪⁪‏‭‮ = new List<SSIEventLabelAllocationElement>();
	}

	public u200b‎‫⁮‭‏‏⁮⁫⁫‭‍‏‮‬‪‮⁮‎⁯‪⁯⁬‍‮⁮‫‎‮‏‎​⁮‏‫‫⁪‍‫‬‮()
	{
		// 
		// Current member / type: System.Void ​‎‫⁮‭‏‏⁮⁫⁫‭‍‏‮‬‪‮⁮‎⁯‪⁯⁬‍‮⁮‫‎‮‏‎​⁮‏‫‫⁪‍‫‬‮::.ctor()
		// File path: C:\SDRSharp\Plugins\Tetra\SDRSharp.Tetra.dll
		// 
		// Product version: 0.0.0.0
		// Exception in: System.Void .ctor()
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