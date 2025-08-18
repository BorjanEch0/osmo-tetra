using SDRSharp.Radio;
using SDRSharp.Tetra;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// ‭‍‍‬‍‫⁪⁭‌⁮‬‮⁬‍‏‭⁭‍‬⁫⁮‬⁭⁫‎⁫⁭‍‌‍⁮‮‮⁬‫‌⁪⁯​⁪‮
internal class u202d‍‍‬‍‫⁪⁭‌⁮‬‮⁬‍‏‭⁭‍‬⁫⁮‬⁭⁫‎⁫⁭‍‌‍⁮‮‮⁬‫‌⁪⁯​⁪‮
{
	// ​‎‎⁬⁮‎‭​‭‪‏‌‪⁪⁫‪⁯‏‌‎‍‬‭‭⁬‪⁫‌‍‏⁫⁪⁪​‍⁮‎‍⁫‍‮
	private const uint u200b‎‎⁬⁮‎‭​‭‪‏‌‪⁪⁫‪⁯‏‌‎‍‬‭‭⁬‪⁫‌‍‏⁫⁪⁪​‍⁮‎‍⁫‍‮ = 3988292384;

	// ‮​⁬‍⁭⁭‌‭⁫‬‪⁪⁪⁫‍‬⁯‬‫⁫⁬​‌⁬⁫‪‎‍‭⁪‍‮⁯‫‫⁯‍‬⁭‍‮
	private const uint u202e​⁬‍⁭⁭‌‭⁫‬‪⁪⁪⁫‍‬⁯‬‫⁫⁬​‌⁬⁫‪‎‍‭⁪‍‮⁯‫‫⁯‍‬⁭‍‮ = 3736805603;

	// ‎‏‪‬‌⁯⁪⁫⁯⁬‪‫⁪‍‭⁭⁬‭‫⁯‮⁫⁫‫‬‎⁬‫‎‭‪‭‪⁭⁪⁭‪⁯⁬⁪‮
	private u200c‏‬⁭​‌‪⁬‬‮‏⁪⁯​‮‭‏‎⁪⁫‮⁪⁮‎‫‌⁪​⁫‌⁯⁮‌​‎‭‍‬‪⁯‮ u200e‏‪‬‌⁯⁪⁫⁯⁬‪‫⁪‍‭⁭⁬‭‫⁯‮⁫⁫‫‬‎⁬‫‎‭‪‭‪⁭⁪⁭‪⁯⁬⁪‮ = new u200c‏‬⁭​‌‪⁬‬‮‏⁪⁯​‮‭‏‎⁪⁫‮⁪⁮‎‫‌⁪​⁫‌⁯⁮‌​‎‭‍‬‪⁯‮();

	// ‎⁭‮⁪⁬‬⁯⁭‬‫​‍‏​​‎‍​⁯‌‌⁮‎‎‫⁮‭⁭‎‪‎⁭⁪‪‬‌‭⁯‎‏‮
	private int u200e⁭‮⁪⁬‬⁯⁭‬‫​‍‏​​‎‍​⁯‌‌⁮‎‎‫⁮‭⁭‎‪‎⁭⁪‪‬‌‭⁯‎‏‮ = -1;

	// ‌‍⁭⁮‪‫‍‏⁯⁯​‍⁪⁬⁬‭‪⁮⁮‌⁫⁭‌‫⁫⁯‮⁮⁯‫‪‮‭‬‏‭‬‬‍‌‮
	private int u200c‍⁭⁮‪‫‍‏⁯⁯​‍⁪⁬⁬‭‪⁮⁮‌⁫⁭‌‫⁫⁯‮⁮⁯‫‪‮‭‬‏‭‬‬‍‌‮ = -1;

	// ‍‭⁫‪​‍‍​‍‌‬⁫‮⁮‎‭‫​⁪‎⁭‮‭‫⁭‬‍‫⁭⁪‫‬‎⁪‫⁪​‌⁪‮‮
	private int u200d‭⁫‪​‍‍​‍‌‬⁫‮⁮‎‭‫​⁪‎⁭‮‭‫⁭‬‍‫⁭⁪‫‬‎⁪‫⁪​‌⁪‮‮ = -1;

	// ⁫‍⁮‭‬⁮‮‭⁭‪⁭‏‮‌‭‪‍⁫‌⁪⁪‎⁭​‫⁬⁮​‫‎‌‭‍⁪‍⁯⁯⁮⁯⁫‮
	private UnsafeBuffer u206b‍⁮‭‬⁮‮‭⁭‪⁭‏‮‌‭‪‍⁫‌⁪⁪‎⁭​‫⁬⁮​‫‎‌‭‍⁪‍⁯⁯⁮⁯⁫‮;

	// ⁪‮‮‭‌​‬‮​⁪‍⁬⁭​‮‮⁯‮‏‫‭⁮⁮‫⁮⁬⁪‮‍‪‎‏⁯‭⁪‎‮​‌⁪‮
	private unsafe byte* u206a‮‮‭‌​‬‮​⁪‍⁬⁭​‮‮⁯‮‏‫‭⁮⁮‫⁮⁬⁪‮‍‪‎‏⁯‭⁪‎‮​‌⁪‮;

	// ⁪‎⁮‌‏⁪‪‫‪⁫⁭‏‬‮‫⁪‪‭‫⁪⁪‪⁬‏​‭⁮⁭​⁭⁪‫⁬⁭⁭‭⁫​⁪⁪‮
	private int u206a‎⁮‌‏⁪‪‫‪⁫⁭‏‬‮‫⁪‪‭‫⁪⁪‪⁬‏​‭⁮⁭​⁭⁪‫⁬⁭⁭‭⁫​⁪⁪‮;

	// ⁬⁭⁭‍⁮​⁮⁪⁮‍‍‌‍‪‭‬‫⁪‪‍​⁯‪‌⁪⁭‎‏⁮‭‪⁫⁫⁭‭‏‪⁭​⁭‮
	private bool u206c⁭⁭‍⁮​⁮⁪⁮‍‍‌‍‪‭‬‫⁪‪‍​⁯‪‌⁪⁭‎‏⁮‭‪⁫⁫⁭‭‏‪⁭​⁭‮;

	// ‌‌‮‌⁬‫⁭⁭​‪⁬⁬​‎‎‭‍‬‎‪⁬⁬⁪​​⁫‭‬⁭‬⁭‬‏‌‫⁪⁮‭⁫‎‮
	public static int u200c‌‮‌⁬‫⁭⁭​‪⁬⁬​‎‎‭‍‬‎‪⁬⁬⁪​​⁫‭‬⁭‬⁭‬‏‌‫⁪⁮‭⁫‎‮
	{
		get;
		set;
	}

	// ‏‌‬‫‭⁬⁪‮‫‌⁮‫⁬⁯​‌⁯⁮‪⁯‭⁮‮‌⁯‫⁬‮⁭⁫‮‭‮⁯‪‫‎⁪‪⁪‮
	public static string u200f‌‬‫‭⁬⁪‮‫‌⁮‫⁬⁯​‌⁯⁮‪⁯‭⁮‮‌⁯‫⁬‮⁭⁫‮‭‮⁯‪‫‎⁪‪⁪‮
	{
		get;
		set;
	}

	// ⁪‍‫‎⁯⁮‏⁮‬​‬‌‎​‮⁭⁭​⁬‏‍⁫‫​⁯⁯‍⁭​⁬​‌⁭⁫‮⁮‎‏⁬⁮‮
	public static int u206a‍‫‎⁯⁮‏⁮‬​‬‌‎​‮⁭⁭​⁬‏‍⁫‫​⁯⁯‍⁭​⁬​‌⁭⁫‮⁮‎‏⁬⁮‮
	{
		get;
		set;
	}

	// ‌‎‏‪⁪⁮‎⁯‫‬⁪‍‬‎​‬​‌‮⁭‏‍‎‭⁪⁯⁯‌‏⁯‌‬‬‬⁬‭‪‌⁪‌‮
	public static int u200c‎‏‪⁪⁮‎⁯‫‬⁪‍‬‎​‬​‌‮⁭‏‍‎‭⁪⁯⁯‌‏⁯‌‬‬‬⁬‭‪‌⁪‌‮
	{
		get;
		set;
	}

	// ⁯‮‭‭‏‌⁮‬⁯⁭⁮⁪‍‫‭⁭⁪‍​​‪⁪​‏‎‮⁯‮⁯‏‫‏⁫‎‍​‫‎​‎‮
	public static int u206f‮‭‭‏‌⁮‬⁯⁭⁮⁪‍‫‭⁭⁪‍​​‪⁪​‏‎‮⁯‮⁯‏‫‏⁫‎‍​‫‎​‎‮
	{
		get;
		set;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	// ‬‏⁪‫⁯‮⁬‫‏⁫‍⁯‫⁭‮‭‫⁮‎‭⁬⁭⁮‭‍‏‍‏‎⁬‍‫⁬‌‏‎⁪⁭‌‎‮
	public void u202c‏⁪‫⁯‮⁬‫‏⁫‍⁯‫⁭‮‭‫⁮‎‭⁬⁭⁮‭‍‏‍‏‎⁬‍‫⁬‌‏‎⁪⁭‌‎‮(LogicChannel , int , int , Dictionary<GlobalNames, int> )
	{
		// 
		// Current member / type: System.Void ‭‍‍‬‍‫⁪⁭‌⁮‬‮⁬‍‏‭⁭‍‬⁫⁮‬⁭⁫‎⁫⁭‍‌‍⁮‮‮⁬‫‌⁪⁯​⁪‮::‬‏⁪‫⁯‮⁬‫‏⁫‍⁯‫⁭‮‭‫⁮‎‭⁬⁭⁮‭‍‏‍‏‎⁬‍‫⁬‌‏‎⁪⁭‌‎‮(SDRSharp.Tetra.LogicChannel,System.Int32,System.Int32,System.Collections.Generic.Dictionary`2<SDRSharp.Tetra.GlobalNames,System.Int32>)
		// File path: C:\SDRSharp\Plugins\Tetra\SDRSharp.Tetra.dll
		// 
		// Product version: 0.0.0.0
		// Exception in: System.Void ‬‏⁪‫⁯‮⁬‫‏⁫‍⁯‫⁭‮‭‫⁮‎‭⁬⁭⁮‭‍‏‍‏‎⁬‍‫⁬‌‏‎⁪⁭‌‎‮(SDRSharp.Tetra.LogicChannel,System.Int32,System.Int32,System.Collections.Generic.Dictionary<SDRSharp.Tetra.GlobalNames,System.Int32>)
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
	// ‮‌⁭​⁯⁯⁯‎⁬⁬‏‏‬⁭‌‎‌⁬⁫‮‭⁮‪⁭⁭‌‌‮⁬‬‎⁬⁭‍⁯‬‌⁪‫‪‮
	private bool u202e‌⁭​⁯⁯⁯‎⁬⁬‏‏‬⁭‌‎‌⁬⁫‮‭⁮‪⁭⁭‌‌‮⁬‬‎⁬⁭‍⁯‬‌⁪‫‪‮(LogicChannel , int , int , int , int , int , ref string , int , Dictionary<GlobalNames, int> )
	{
		// 
		// Current member / type: System.Boolean ‭‍‍‬‍‫⁪⁭‌⁮‬‮⁬‍‏‭⁭‍‬⁫⁮‬⁭⁫‎⁫⁭‍‌‍⁮‮‮⁬‫‌⁪⁯​⁪‮::‮‌⁭​⁯⁯⁯‎⁬⁬‏‏‬⁭‌‎‌⁬⁫‮‭⁮‪⁭⁭‌‌‮⁬‬‎⁬⁭‍⁯‬‌⁪‫‪‮(SDRSharp.Tetra.LogicChannel,System.Int32,System.Int32,System.Int32,System.Int32,System.Int32,System.String&,System.Int32,System.Collections.Generic.Dictionary`2<SDRSharp.Tetra.GlobalNames,System.Int32>)
		// File path: C:\SDRSharp\Plugins\Tetra\SDRSharp.Tetra.dll
		// 
		// Product version: 0.0.0.0
		// Exception in: System.Boolean ‮‌⁭​⁯⁯⁯‎⁬⁬‏‏‬⁭‌‎‌⁬⁫‮‭⁮‪⁭⁭‌‌‮⁬‬‎⁬⁭‍⁯‬‌⁪‫‪‮(SDRSharp.Tetra.LogicChannel,System.Int32,System.Int32,System.Int32,System.Int32,System.Int32,System.String&,System.Int32,System.Collections.Generic.Dictionary<SDRSharp.Tetra.GlobalNames,System.Int32>)
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

	// ⁭‍⁬‎‫‍‬⁫⁬‎‎​​⁬‬⁭⁮‎‍‌⁯⁪⁬⁫‭‪‭⁭‭‭‪⁬‮‏⁪‏⁯⁯‪‭‮
	public static bool u206d‍⁬‎‫‍‬⁫⁬‎‎​​⁬‬⁭⁮‎‍‌⁯⁪⁬⁫‭‪‭⁭‭‭‪⁬‮‏⁪‏⁯⁯‪‭‮(LogicChannel , int )
	{
		// 
		// Current member / type: System.Boolean ‭‍‍‬‍‫⁪⁭‌⁮‬‮⁬‍‏‭⁭‍‬⁫⁮‬⁭⁫‎⁫⁭‍‌‍⁮‮‮⁬‫‌⁪⁯​⁪‮::⁭‍⁬‎‫‍‬⁫⁬‎‎​​⁬‬⁭⁮‎‍‌⁯⁪⁬⁫‭‪‭⁭‭‭‪⁬‮‏⁪‏⁯⁯‪‭‮(SDRSharp.Tetra.LogicChannel,System.Int32)
		// File path: C:\SDRSharp\Plugins\Tetra\SDRSharp.Tetra.dll
		// 
		// Product version: 0.0.0.0
		// Exception in: System.Boolean ⁭‍⁬‎‫‍‬⁫⁬‎‎​​⁬‬⁭⁮‎‍‌⁯⁪⁬⁫‭‪‭⁭‭‭‪⁬‮‏⁪‏⁯⁯‪‭‮(SDRSharp.Tetra.LogicChannel,System.Int32)
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

	// ​⁮⁫‌⁮⁯‏‮⁭‭⁮‌‪‍‌⁪​‮⁬‫‫⁪‍⁭‎‬⁪‏‫‭⁫⁯​⁪‫‬‮⁬⁬‭‮
	private void u200b⁮⁫‌⁮⁯‏‮⁭‭⁮‌‪‍‌⁪​‮⁬‫‫⁪‍⁭‎‬⁪‏‫‭⁫⁯​⁪‫‬‮⁬⁬‭‮(LogicChannel logicChannel, int num, int num, int num, Dictionary<GlobalNames, int> globalNames)
	{
		if (this.u206a‎⁮‌‏⁪‪‫‪⁫⁭‏‬‮‫⁪‪‭‫⁪⁪‪⁬‏​‭⁮⁭​⁭⁪‫⁬⁭⁭‭⁫​⁪⁪‮ + num >= u202d‍‍‬‍‫⁪⁭‌⁮‬‮⁬‍‏‭⁭‍‬⁫⁮‬⁭⁫‎⁫⁭‍‌‍⁮‮‮⁬‫‌⁪⁯​⁪‮.u206d‮⁭​‪⁭⁭⁪⁫‫‌​‬⁯‭​‪‌‏‪‬‮‭‭⁭‮‬⁮⁬⁭‭‎‬‬⁬‍​⁭⁬‮(this.u206b‍⁮‭‬⁮‮‭⁭‪⁭‏‮‌‭‪‍⁫‌⁪⁪‎⁭​‫⁬⁮​‫‎‌‭‍⁪‍⁯⁯⁮⁯⁫‮))
		{
			return;
		}
	Label1:
		int num1 = -997365573;
		while (true)
		{
			int num2 = num1 ^ -1887999947;
			uint num3 = (uint)num2;
			switch (num2 % 4)
			{
				case 0:
				{
					return;
				}
				case 1:
				{
					this.u206a‎⁮‌‏⁪‪‫‪⁫⁭‏‬‮‫⁪‪‭‫⁪⁪‪⁬‏​‭⁮⁭​⁭⁪‫⁬⁭⁭‭⁫​⁪⁪‮ = num - (num - num);
					num1 = (int)(num3 * 1302659851 ^ 103298214);
					continue;
				}
				case 2:
				{
					u202d‍‍‬‍‫⁪⁭‌⁮‬‮⁬‍‏‭⁭‍‬⁫⁮‬⁭⁫‎⁫⁭‍‌‍⁮‮‮⁬‫‌⁪⁯​⁪‮.u202b‏⁫‮⁮⁫⁬⁪⁮⁬‌⁭‭⁫⁫⁫‫‬​‍⁬‌‏‭‫‌‫‎‪⁫​‫‎⁫‎‪‍‭‫⁯‮(this.u206a‮‮‭‌​‬‮​⁪‍⁬⁭​‮‮⁯‮‏‫‭⁮⁮‫⁮⁬⁪‮‍‪‎‏⁯‭⁪‎‮​‌⁪‮, logicChannel.Ptr + num, num - (num - num));
					num1 = (int)(num3 * 398798479 ^ 1440663622);
					continue;
				}
				case 3:
				{
					goto Label1;
				}
			}
		}
	}

	// ‌‏‎⁮‎⁮‍‪‍‪‬‭⁬⁪⁬‮‬​‮⁯‮‬⁪‎‬​⁪⁪‪⁭‌‮‎‪⁬‎⁮⁭‌‏‮
	private void u200c‏‎⁮‎⁮‍‪‍‪‬‭⁬⁪⁬‮‬​‮⁯‮‬⁪‎‬​⁪⁪‪⁭‌‮‎‪⁬‎⁮⁭‌‏‮(LogicChannel , int , int , int )
	{
		// 
		// Current member / type: System.Void ‭‍‍‬‍‫⁪⁭‌⁮‬‮⁬‍‏‭⁭‍‬⁫⁮‬⁭⁫‎⁫⁭‍‌‍⁮‮‮⁬‫‌⁪⁯​⁪‮::‌‏‎⁮‎⁮‍‪‍‪‬‭⁬⁪⁬‮‬​‮⁯‮‬⁪‎‬​⁪⁪‪⁭‌‮‎‪⁬‎⁮⁭‌‏‮(SDRSharp.Tetra.LogicChannel,System.Int32,System.Int32,System.Int32)
		// File path: C:\SDRSharp\Plugins\Tetra\SDRSharp.Tetra.dll
		// 
		// Product version: 0.0.0.0
		// Exception in: System.Void ‌‏‎⁮‎⁮‍‪‍‪‬‭⁬⁪⁬‮‬​‮⁯‮‬⁪‎‬​⁪⁪‪⁭‌‮‎‪⁬‎⁮⁭‌‏‮(SDRSharp.Tetra.LogicChannel,System.Int32,System.Int32,System.Int32)
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

	// ⁭⁪‌⁯‮‎⁫‮⁪⁫⁭⁬‏⁮‮‌⁯⁬⁫‭⁯⁬‍‮‬‭‭⁭‌‪‌⁫⁫‍‎⁫‭⁪⁯‏‮
	private LogicChannel u206d⁪‌⁯‮‎⁫‮⁪⁫⁭⁬‏⁮‮‌⁯⁬⁫‭⁯⁬‍‮‬‭‭⁭‌‪‌⁫⁫‍‎⁫‭⁪⁯‏‮(LogicChannel logicChannel, Dictionary<GlobalNames, int> globalNames)
	{
		LogicChannel logicChannel1 = new LogicChannel()
		{
			Ptr = this.u206a‮‮‭‌​‬‮​⁪‍⁬⁭​‮‮⁯‮‏‫‭⁮⁮‫⁮⁬⁪‮‍‪‎‏⁯‭⁪‎‮​‌⁪‮,
			Length = this.u206a‎⁮‌‏⁪‪‫‪⁫⁭‏‬‮‫⁪‪‭‫⁪⁪‪⁬‏​‭⁮⁭​⁭⁪‫⁬⁭⁭‭⁫​⁪⁪‮,
			CrcIsOk = true,
			TimeSlot = logicChannel.TimeSlot,
			Frame = logicChannel.Frame
		};
		this.u206a‎⁮‌‏⁪‪‫‪⁫⁭‏‬‮‫⁪‪‭‫⁪⁪‪⁬‏​‭⁮⁭​⁭⁪‫⁬⁭⁭‭⁫​⁪⁪‮ = 0;
		return logicChannel1;
	}

	// ​‭‏‮⁭⁮⁬​‎‌‫⁬‏⁮‌​‫⁬‎⁫‍‍⁪⁯‏⁭‪‭‌‮‫‪‏‍‌‌⁪​⁫‭‮
	// privatescope
	internal static UnsafeBuffer u200b‭‏‮⁭⁮⁬​‎‌‫⁬‏⁮‌​‫⁬‎⁫‍‍⁪⁯‏⁭‪‭‌‮‫‪‏‍‌‌⁪​⁫‭‮(int num, int num)
	{
		return UnsafeBuffer.Create(num, num);
	}

	// ‮‎​‍​‮‫‪‮⁬⁫⁫⁫‬‍‍​​‭⁫‪‌‎⁯⁬‏⁭‭​⁮⁫⁬‫‫‮‌‎‮‎⁪‮
	// privatescope
	internal static unsafe void* u202e‎​‍​‮‫‪‮⁬⁫⁫⁫‬‍‍​​‭⁫‪‌‎⁯⁬‏⁭‭​⁮⁫⁬‫‫‮‌‎‮‎⁪‮(UnsafeBuffer unsafeBuffer)
	{
		return unsafeBuffer;
	}

	// ‎⁮‫‍⁯‪​⁬⁮‪⁬‮‬‭‏‬‬⁭⁯‮⁬⁯⁭⁯⁮‏⁪⁫⁫⁫⁯‌‏⁯⁯‪‍‏⁯⁫‮
	// privatescope
	internal static string u200e⁮‫‍⁯‪​⁬⁮‪⁬‮‬‭‏‬‬⁭⁯‮⁬⁯⁭⁯⁮‏⁪⁫⁫⁫⁯‌‏⁯⁯‪‍‏⁯⁫‮(string str, string str, string str)
	{
		return string.Concat(str, str, str);
	}

	// ​‌‏⁮⁫⁪‍‪‪​⁬‬‎‮‌⁫‎‫​⁯⁪‬‍⁮⁭⁬‍‎‭⁮⁪⁬⁯‭‍‏⁬​‏‭‮
	// privatescope
	internal static string u200b‌‏⁮⁫⁪‍‪‪​⁬‬‎‮‌⁫‎‫​⁯⁪‬‍⁮⁭⁬‍‎‭⁮⁪⁬⁯‭‍‏⁬​‏‭‮(string str, string str)
	{
		return string.Concat(str, str);
	}

	// ‌‪⁫‌‌‎‍‮‭‭⁯‪‫‍‭⁪⁫‏‏⁮⁭‭⁭⁮⁫‪‌‭⁬‮‭‏‎‫‌‪‎‬‪‮‮
	// privatescope
	internal static string u200c‪⁫‌‌‎‍‮‭‭⁯‪‫‍‭⁪⁫‏‏⁮⁭‭⁭⁮⁫‪‌‭⁬‮‭‏‎‫‌‪‎‬‪‮‮(object[] objArray)
	{
		return string.Concat(objArray);
	}

	// ‌⁫‍‫‮⁭⁬⁪⁪⁬‎⁬‫‫‬‭⁯‍‬‬‪⁭‍⁬‌‬⁮‌⁬⁪⁫⁫⁮‌⁯⁭‌⁯​‮‮
	// privatescope
	internal static string u200c⁫‍‫‮⁭⁬⁪⁪⁬‎⁬‫‫‬‭⁯‍‬‬‪⁭‍⁬‌‬⁮‌⁬⁪⁫⁫⁮‌⁯⁭‌⁯​‮‮(object obj, object obj, object obj)
	{
		return string.Concat(obj, obj, obj);
	}

	// ‫‌‬⁮‭‎‮‌​‭‏⁯⁭‌‪​‮‬‍‫⁫‫‫‮⁬⁮⁭⁭‭‬‍‬‎‍⁬‪‬‍‎‬‮
	// privatescope
	internal static string u202b‌‬⁮‭‎‮‌​‭‏⁯⁭‌‪​‮‬‍‫⁫‫‫‮⁬⁮⁭⁭‭‬‍‬‎‍⁬‪‬‍‎‬‮()
	{
		return Environment.NewLine;
	}

	// ⁭‮⁭​‪⁭⁭⁪⁫‫‌​‬⁯‭​‪‌‏‪‬‮‭‭⁭‮‬⁮⁬⁭‭‎‬‬⁬‍​⁭⁬‮
	// privatescope
	internal static int u206d‮⁭​‪⁭⁭⁪⁫‫‌​‬⁯‭​‪‌‏‪‬‮‭‭⁭‮‬⁮⁬⁭‭‎‬‬⁬‍​⁭⁬‮(UnsafeBuffer unsafeBuffer)
	{
		return unsafeBuffer.get_Length();
	}

	// ‫‏⁫‮⁮⁫⁬⁪⁮⁬‌⁭‭⁫⁫⁫‫‬​‍⁬‌‏‭‫‌‫‎‪⁫​‫‎⁫‎‪‍‭‫⁯‮
	// privatescope
	internal static unsafe void* u202b‏⁫‮⁮⁫⁬⁪⁮⁬‌⁭‭⁫⁫⁫‫‬​‍⁬‌‏‭‫‌‫‎‪⁫​‫‎⁫‎‪‍‭‫⁯‮(void* voidPointer, void* voidPointer, int num)
	{
		return Utils.Memcpy(voidPointer, voidPointer, num);
	}

	public u202d‍‍‬‍‫⁪⁭‌⁮‬‮⁬‍‏‭⁭‍‬⁫⁮‬⁭⁫‎⁫⁭‍‌‍⁮‮‮⁬‫‌⁪⁯​⁪‮()
	{
		for (int i = 0; i < 4; i++)
		{
			this.u206b‍⁮‭‬⁮‮‭⁭‪⁭‏‮‌‭‪‍⁫‌⁪⁪‎⁭​‫⁬⁮​‫‎‌‭‍⁪‍⁯⁯⁮⁯⁫‮ = u202d‍‍‬‍‫⁪⁭‌⁮‬‮⁬‍‏‭⁭‍‬⁫⁮‬⁭⁫‎⁫⁭‍‌‍⁮‮‮⁬‫‌⁪⁯​⁪‮.u200b‭‏‮⁭⁮⁬​‎‌‫⁬‏⁮‌​‫⁬‎⁫‍‍⁪⁯‏⁭‪‭‌‮‫‪‏‍‌‌⁪​⁫‭‮(4096, 1);
			this.u206a‮‮‭‌​‬‮​⁪‍⁬⁭​‮‮⁯‮‏‫‭⁮⁮‫⁮⁬⁪‮‍‪‎‏⁯‭⁪‎‮​‌⁪‮ = (byte*)u202d‍‍‬‍‫⁪⁭‌⁮‬‮⁬‍‏‭⁭‍‬⁫⁮‬⁭⁫‎⁫⁭‍‌‍⁮‮‮⁬‫‌⁪⁯​⁪‮.u202e‎​‍​‮‫‪‮⁬⁫⁫⁫‬‍‍​​‭⁫‪‌‎⁯⁬‏⁭‭​⁮⁫⁬‫‫‮‌‎‮‎⁪‮(this.u206b‍⁮‭‬⁮‮‭⁭‪⁭‏‮‌‭‪‍⁫‌⁪⁪‎⁭​‫⁬⁮​‫‎‌‭‍⁪‍⁯⁯⁮⁯⁫‮);
		}
		u202d‍‍‬‍‫⁪⁭‌⁮‬‮⁬‍‏‭⁭‍‬⁫⁮‬⁭⁫‎⁫⁭‍‌‍⁮‮‮⁬‫‌⁪⁯​⁪‮.u206f‮‭‭‏‌⁮‬⁯⁭⁮⁪‍‫‭⁭⁪‍​​‪⁪​‏‎‮⁯‮⁯‏‫‏⁫‎‍​‫‎​‎‮ = -1;
		u202d‍‍‬‍‫⁪⁭‌⁮‬‮⁬‍‏‭⁭‍‬⁫⁮‬⁭⁫‎⁫⁭‍‌‍⁮‮‮⁬‫‌⁪⁯​⁪‮.u200c‎‏‪⁪⁮‎⁯‫‬⁪‍‬‎​‬​‌‮⁭‏‍‎‭⁪⁯⁯‌‏⁯‌‬‬‬⁬‭‪‌⁪‌‮ = 0;
		u202d‍‍‬‍‫⁪⁭‌⁮‬‮⁬‍‏‭⁭‍‬⁫⁮‬⁭⁫‎⁫⁭‍‌‍⁮‮‮⁬‫‌⁪⁯​⁪‮.u206a‍‫‎⁯⁮‏⁮‬​‬‌‎​‮⁭⁭​⁬‏‍⁫‫​⁯⁯‍⁭​⁬​‌⁭⁫‮⁮‎‏⁬⁮‮ = 0;
	}
}