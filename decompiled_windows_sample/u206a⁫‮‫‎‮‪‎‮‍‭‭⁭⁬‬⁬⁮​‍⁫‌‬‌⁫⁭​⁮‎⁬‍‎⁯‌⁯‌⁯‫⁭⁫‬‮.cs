using SDRSharp.Tetra;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Wireshark;

// ⁪⁫‮‫‎‮‪‎‮‍‭‭⁭⁬‬⁬⁮​‍⁫‌‬‌⁫⁭​⁮‎⁬‍‎⁯‌⁯‌⁯‫⁭⁫‬‮
internal class u206a⁫‮‫‎‮‪‎‮‍‭‭⁭⁬‬⁬⁮​‍⁫‌‬‌⁫⁭​⁮‎⁬‍‎⁯‌⁯‌⁯‫⁭⁫‬‮
{
	// ‌⁭⁭⁬​​⁫‎‌‌⁬⁬‏⁮‎⁪‬⁯⁬⁮‭​‫‎⁫⁯⁪⁫​⁯‫​⁯⁪‎‬‮‪‏‪‮
	private WiresharkSender u200c⁭⁭⁬​​⁫‎‌‌⁬⁬‏⁮‎⁪‬⁯⁬⁮‭​‫‎⁫⁯⁪⁫​⁯‫​⁯⁪‎‬‮‪‏‪‮;

	// ⁬⁭⁭‍⁮​⁮⁪⁮‍‍‌‍‪‭‬‫⁪‪‍​⁯‪‌⁪⁭‎‏⁮‭‪⁫⁫⁭‭‏‪⁭​⁭‮
	private bool u206c⁭⁭‍⁮​⁮⁪⁮‍‍‌‍‪‭‬‫⁪‪‍​⁯‪‌⁪⁭‎‏⁮‭‪⁫⁫⁭‭‏‪⁭​⁭‮;

	// ‍‪‏‪⁫⁫‌⁪‌⁪‏‏‏‎‮‌​⁬⁯‫‍‮⁬⁫‎‮⁭‫‌⁭‪​‮‫⁪‏​​‮‬‮
	private int u200d‪‏‪⁫⁫‌⁪‌⁪‏‏‏‎‮‌​⁬⁯‫‍‮⁬⁫‎‮⁭‫‌⁭‪​‮‫⁪‏​​‮‬‮ = -1;

	// ‏‌‎⁫⁯‫‮‭⁫⁬⁫‭‌‌⁫‎⁯⁫⁮⁫‫‬​⁮⁬⁪‬‭⁪‬‮‭‮⁫​⁮‬⁪‌‫‮
	public static bool u200f‌‎⁫⁯‫‮‭⁫⁬⁫‭‌‌⁫‎⁯⁫⁮⁫‫‬​⁮⁬⁪‬‭⁪‬‮‭‮⁫​⁮‬⁪‌‫‮
	{
		get;
		set;
	}

	// ⁪⁭​‬‬‎‪⁯‬‮⁪‌⁭‏‭‮‪‍‭⁪‎⁮⁬‎‎‍⁭​‬‏⁬⁬​⁯‮‌‭‫‪⁮‮
	public static string u206a⁭​‬‬‎‪⁯‬‮⁪‌⁭‏‭‮‪‍‭⁪‎⁮⁬‎‎‍⁭​‬‏⁬⁬​⁯‮‌‭‫‪⁮‮
	{
		get;
		set;
	}

	// ⁮‬‎‬‏⁯‪‌⁫‮⁮⁬‮‏‮‫⁫‪‫‫⁪‭⁬‪‮⁬​⁯⁬⁪⁭⁬‭⁪‪‌‌‪‪⁬‮
	public static string u206e‬‎‬‏⁯‪‌⁫‮⁮⁬‮‏‮‫⁫‪‫‫⁪‭⁬‪‮⁬​⁯⁬⁪⁭⁬‭⁪‪‌‌‪‪⁬‮
	{
		get;
		set;
	}

	// ⁭‌⁫‬⁫‮‫‪⁭⁫⁮⁫‪⁮⁯⁫‌‍‍⁪⁭⁯⁭‏‬⁬⁭‪⁯‮‍‪‌‫‮‍⁮⁪⁫‎‮
	public static bool u206d‌⁫‬⁫‮‫‪⁭⁫⁮⁫‪⁮⁯⁫‌‍‍⁪⁭⁯⁭‏‬⁬⁭‪⁯‮‍‪‌‫‮‍⁮⁪⁫‎‮
	{
		get;
		set;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	// ⁭⁭⁯‍‭‍⁫‫‪⁯‍​⁪‌⁮‫⁬⁯‫⁭‬‫⁬‌‫​‍⁮⁪‭⁯‭‎⁬‎‬‫‪‎‍‮
	public void u206d⁭⁯‍‭‍⁫‫‪⁯‍​⁪‌⁮‫⁬⁯‫⁭‬‫⁬‌‫​‍⁮⁪‭⁯‭‎⁬‎‬‫‪‎‍‮(LogicChannel , ref int , Dictionary<GlobalNames, int> )
	{
		// 
		// Current member / type: System.Void ⁪⁫‮‫‎‮‪‎‮‍‭‭⁭⁬‬⁬⁮​‍⁫‌‬‌⁫⁭​⁮‎⁬‍‎⁯‌⁯‌⁯‫⁭⁫‬‮::⁭⁭⁯‍‭‍⁫‫‪⁯‍​⁪‌⁮‫⁬⁯‫⁭‬‫⁬‌‫​‍⁮⁪‭⁯‭‎⁬‎‬‫‪‎‍‮(SDRSharp.Tetra.LogicChannel,System.Int32&,System.Collections.Generic.Dictionary`2<SDRSharp.Tetra.GlobalNames,System.Int32>)
		// File path: C:\SDRSharp\Plugins\Tetra\SDRSharp.Tetra.dll
		// 
		// Product version: 0.0.0.0
		// Exception in: System.Void ⁭⁭⁯‍‭‍⁫‫‪⁯‍​⁪‌⁮‫⁬⁯‫⁭‬‫⁬‌‫​‍⁮⁪‭⁯‭‎⁬‎‬‫‪‎‍‮(SDRSharp.Tetra.LogicChannel,System.Int32&,System.Collections.Generic.Dictionary<SDRSharp.Tetra.GlobalNames,System.Int32>)
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

	// ⁪‫⁪‎⁮‪⁯⁬‌⁯​​‌⁮⁭‍⁬⁭⁮⁮⁬​‪‪⁯⁬‮⁬⁯⁫‬‫⁭‭⁯⁪‫⁪⁫‏‮
	private void u206a‫⁪‎⁮‪⁯⁬‌⁯​​‌⁮⁭‍⁬⁭⁮⁮⁬​‪‪⁯⁬‮⁬⁯⁫‬‫⁭‭⁯⁪‫⁪⁫‏‮(byte[] )
	{
		// 
		// Current member / type: System.Void ⁪⁫‮‫‎‮‪‎‮‍‭‭⁭⁬‬⁬⁮​‍⁫‌‬‌⁫⁭​⁮‎⁬‍‎⁯‌⁯‌⁯‫⁭⁫‬‮::⁪‫⁪‎⁮‪⁯⁬‌⁯​​‌⁮⁭‍⁬⁭⁮⁮⁬​‪‪⁯⁬‮⁬⁯⁫‬‫⁭‭⁯⁪‫⁪⁫‏‮(System.Byte[])
		// File path: C:\SDRSharp\Plugins\Tetra\SDRSharp.Tetra.dll
		// 
		// Product version: 0.0.0.0
		// Exception in: System.Void ⁪‫⁪‎⁮‪⁯⁬‌⁯​​‌⁮⁭‍⁬⁭⁮⁮⁬​‪‪⁯⁬‮⁬⁯⁫‬‫⁭‭⁯⁪‫⁪⁫‏‮(System.Byte[])
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

	// ⁫‫​‎⁯⁬⁪‫‏‌‌‎‫​‎‬‏⁪⁬‏​‍⁪⁮⁬⁯⁯⁭‎⁭‫‏‪⁮⁫‫⁮⁮⁭⁫‮
	private unsafe byte[] u206b‫​‎⁯⁬⁪‫‏‌‌‎‫​‎‬‏⁪⁬‏​‍⁪⁮⁬⁯⁯⁭‎⁭‫‏‪⁮⁫‫⁮⁮⁭⁫‮(byte* , int , int )
	{
		// 
		// Current member / type: System.Byte[] ⁪⁫‮‫‎‮‪‎‮‍‭‭⁭⁬‬⁬⁮​‍⁫‌‬‌⁫⁭​⁮‎⁬‍‎⁯‌⁯‌⁯‫⁭⁫‬‮::⁫‫​‎⁯⁬⁪‫‏‌‌‎‫​‎‬‏⁪⁬‏​‍⁪⁮⁬⁯⁯⁭‎⁭‫‏‪⁮⁫‫⁮⁮⁭⁫‮(System.Byte*,System.Int32,System.Int32)
		// File path: C:\SDRSharp\Plugins\Tetra\SDRSharp.Tetra.dll
		// 
		// Product version: 0.0.0.0
		// Exception in: System.Byte[] ⁫‫​‎⁯⁬⁪‫‏‌‌‎‫​‎‬‏⁪⁬‏​‍⁪⁮⁬⁯⁯⁭‎⁭‫‏‪⁮⁫‫⁮⁮⁭⁫‮(System.Byte*,System.Int32,System.Int32)
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

	// ⁮⁯​‪⁯⁯‫‭⁯‮‏⁮‭‎‎​⁫​‮‍‏‎⁮‫⁭⁯⁭‏‎⁬⁮⁫‎‌‫‫⁪‌⁭‎‮
	// privatescope
	internal static string u206e⁯​‪⁯⁯‫‭⁯‮‏⁮‭‎‎​⁫​‮‍‏‎⁮‫⁭⁯⁭‏‎⁬⁮⁫‎‌‫‫⁪‌⁭‎‮(object obj, object obj, object obj)
	{
		return string.Concat(obj, obj, obj);
	}

	// ‪⁪‍‫⁬‬‬‭‪‫⁬⁬‬‮‬‮‌‪⁮‫‬⁪⁬‫‍‍‍⁭⁬‬‪⁯⁫⁬‫‏‬‎⁮⁭‮
	// privatescope
	internal static string u202a⁪‍‫⁬‬‬‭‪‫⁬⁬‬‮‬‮‌‪⁮‫‬⁪⁬‫‍‍‍⁭⁬‬‪⁯⁫⁬‫‏‬‎⁮⁭‮(string str, string str)
	{
		return string.Concat(str, str);
	}

	// ‌⁫‬‭‬⁮⁪‮​‮‏​⁪​⁯‭⁮⁬‭‬‎⁯‬⁭⁭​‏‬‭⁪⁬‭⁭⁮⁬⁮‏‫⁪⁫‮
	// privatescope
	internal static string u200c⁫‬‭‬⁮⁪‮​‮‏​⁪​⁯‭⁮⁬‭‬‎⁯‬⁭⁭​‏‬‭⁪⁬‭⁭⁮⁬⁮‏‫⁪⁫‮(object[] objArray)
	{
		return string.Concat(objArray);
	}

	// ‎⁬‎‍‬⁬⁯⁪‮‪‏⁯‭⁯‫‭⁫‮⁫⁭⁬‍⁮‏‬⁪⁬⁮⁪⁫⁪‪‎‍‭‏‏‌‏⁫‮
	// privatescope
	internal static string u200e⁬‎‍‬⁬⁯⁪‮‪‏⁯‭⁯‫‭⁫‮⁫⁭⁬‍⁮‏‬⁪⁬⁮⁪⁫⁪‪‎‍‭‏‏‌‏⁫‮()
	{
		return Environment.NewLine;
	}

	// ⁯​⁪​​‭‭‏⁭‫⁬⁯⁮‮‭​⁪⁮⁪‏⁮‏‭⁪‏⁫​‎⁯‏‫⁪⁬‬‍‪⁫‏‍‫‮
	// privatescope
	internal static string u206f​⁪​​‭‭‏⁭‫⁬⁯⁮‮‭​⁪⁮⁪‏⁮‏‭⁪‏⁫​‎⁯‏‫⁪⁬‬‍‪⁫‏‍‫‮(object obj, object obj)
	{
		return string.Concat(obj, obj);
	}

	// ‌‌⁮‫‏‮⁪⁬⁫​‍‌⁭⁮⁪⁪‬‌⁮‫‍⁫‍‏‌‮‎⁮‫‬⁭⁭‫​‪⁫⁭‍‬‍‮
	// privatescope
	internal static short u200c‌⁮‫‏‮⁪⁬⁫​‍‌⁭⁮⁪⁪‬‌⁮‫‍⁫‍‏‌‮‎⁮‫‬⁭⁭‫​‪⁫⁭‍‬‍‮(string str, int num)
	{
		return Convert.ToInt16(str, num);
	}

	// ‪‏⁮‫‌‪⁪‪‫‫⁬‎​⁫‫⁯‎⁪‪⁬⁭⁬‪​‬‫⁪‎‫⁫‬‏‌⁫⁬⁪‬⁪⁭⁮‮
	// privatescope
	internal static string u202a‏⁮‫‌‪⁪‪‫‫⁬‎​⁫‫⁯‎⁪‪⁬⁭⁬‪​‬‫⁪‎‫⁫‬‏‌⁫⁬⁪‬⁪⁭⁮‮(string str, string str, string str)
	{
		return string.Concat(str, str, str);
	}

	// ⁪​⁬⁯⁬⁬‮‫‪‏⁬⁯​⁫‎⁬‎​‌‌‌⁭‍⁯‭​‌⁯​‮‬‬‌‭‎⁬‎‎⁪‬‮
	// privatescope
	internal static string u206a​⁬⁯⁬⁬‮‫‪‏⁬⁯​⁫‎⁬‎​‌‌‌⁭‍⁯‭​‌⁯​‮‬‬‌‭‎⁬‎‎⁪‬‮()
	{
		return Application.ExecutablePath;
	}

	// ⁮⁫⁮⁬‫⁮‮⁭⁭⁫‏‏‭‏‏‌‪⁮‌​​⁭‍⁪‪‫‮⁯‬⁯⁭⁫⁬‫⁪‮⁯⁯‏⁮‮
	// privatescope
	internal static string u206e⁫⁮⁬‫⁮‮⁭⁭⁫‏‏‭‏‏‌‪⁮‌​​⁭‍⁪‪‫‮⁯‬⁯⁭⁫⁬‫⁪‮⁯⁯‏⁮‮(string str)
	{
		return Path.GetDirectoryName(str);
	}

	// ‬‎⁬‍‭‍‏‪‫‎⁬‬⁫⁮‎‭‬‬‪⁫‌‮⁮​⁫‬⁯‮‌⁭‎‫‎‪⁭‮‍‭⁬‮‮
	// privatescope
	internal static bool u202c‎⁬‍‭‍‏‪‫‎⁬‬⁫⁮‎‭‬‬‪⁫‌‮⁮​⁫‬⁯‮‌⁭‎‫‎‪⁭‮‍‭⁬‮‮(string str, string str)
	{
		return str != str;
	}

	// ‭​⁮‍‪‭‏‬⁯‍​‮‌⁪‎⁬⁭‮‮‪⁭‪⁮‍‫⁬⁯‏‪‮⁯‏​‎‭​⁭‫⁯‭‮
	// privatescope
	internal static string u202d​⁮‍‪‭‏‬⁯‍​‮‌⁪‎⁬⁭‮‮‪⁭‪⁮‍‫⁬⁯‏‪‮⁯‏​‎‭​⁭‫⁯‭‮(string str, string str, string str, string str)
	{
		return string.Concat(str, str, str, str);
	}

	// ‪⁮⁯‭‌⁪‭‭‫⁬‫⁬⁫‎⁯⁫⁮⁪‎‭⁬‮⁮‎‬⁮‭‪⁬⁪⁬‍‌​‍‮⁫‎⁯‭‮
	// privatescope
	internal static void u202a⁮⁯‭‌⁪‭‭‫⁬‫⁬⁫‎⁯⁫⁮⁪‎‭⁬‮⁮‎‬⁮‭‪⁬⁪⁬‍‌​‍‮⁫‎⁯‭‮(string str, IEnumerable<string> strs)
	{
		File.AppendAllLines(str, strs);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public u206a⁫‮‫‎‮‪‎‮‍‭‭⁭⁬‬⁬⁮​‍⁫‌‬‌⁫⁭​⁮‎⁬‍‎⁯‌⁯‌⁯‫⁭⁫‬‮()
	{
		object obj;
	Label0:
		int num = 62668368;
		while (true)
		{
			int num1 = num ^ 1584465874;
			uint num2 = (uint)num1;
			switch (num1 % 3)
			{
				case 0:
				{
					goto Label0;
				}
				case 1:
				{
					u206a⁫‮‫‎‮‪‎‮‍‭‭⁭⁬‬⁬⁮​‍⁫‌‬‌⁫⁭​⁮‎⁬‍‎⁯‌⁯‌⁯‫⁭⁫‬‮.u206e‬‎‬‏⁯‪‌⁫‮⁮⁬‮‏‮‫⁫‪‫‫⁪‭⁬‪‮⁬​⁯⁬⁪⁭⁬‭⁪‪‌‌‪‪⁬‮ = string.Empty;
					try
					{
						this.u200c⁭⁭⁬​​⁫‎‌‌⁬⁬‏⁮‎⁪‬⁯⁬⁮‭​‫‎⁫⁯⁪⁫​⁯‫​⁯⁪‎‬‮‪‏‪‮ = new WiresharkSender(u003cModuleu003e.u202a‮‫‏‫‬‬‪⁫⁬​‏⁫⁭‍‪‪‎⁬​‪​‌⁮‮‌​⁫​⁬‪‫⁪⁯⁪‎‫⁭‎⁪‮<string>(1390962280), 101);
						u206a⁫‮‫‎‮‪‎‮‍‭‭⁭⁬‬⁬⁮​‍⁫‌‬‌⁫⁭​⁮‎⁬‍‎⁯‌⁯‌⁯‫⁭⁫‬‮.u206d‌⁫‬⁫‮‫‪⁭⁫⁮⁫‪⁮⁯⁫‌‍‍⁪⁭⁯⁭‏‬⁬⁭‪⁯‮‍‪‌‫‮‍⁮⁪⁫‎‮ = true;
					}
					catch
					{
						obj = obj1;
						u206a⁫‮‫‎‮‪‎‮‍‭‭⁭⁬‬⁬⁮​‍⁫‌‬‌⁫⁭​⁮‎⁬‍‎⁯‌⁯‌⁯‫⁭⁫‬‮.u206d‌⁫‬⁫‮‫‪⁭⁫⁮⁫‪⁮⁯⁫‌‍‍⁪⁭⁯⁭‏‬⁬⁭‪⁯‮‍‪‌‫‮‍⁮⁪⁫‎‮ = false;
					}
					return;
				}
				case 2:
				{
					u206a⁫‮‫‎‮‪‎‮‍‭‭⁭⁬‬⁬⁮​‍⁫‌‬‌⁫⁭​⁮‎⁬‍‎⁯‌⁯‌⁯‫⁭⁫‬‮.u206a⁭​‬‬‎‪⁯‬‮⁪‌⁭‏‭‮‪‍‭⁪‎⁮⁬‎‎‍⁭​‬‏⁬⁬​⁯‮‌‭‫‪⁮‮ = u003cModuleu003e.u200e‏‌‬⁮‪‭⁭‭⁭‎​‏‌‭‭‭⁭⁬⁯⁫‍‮‫⁯‌‮‏​‬⁫⁯⁮⁫‮‪⁫‬⁮⁬‮<string>(335722711);
					num = 1718262016;
					continue;
				}
			}
		}
		u206a⁫‮‫‎‮‪‎‮‍‭‭⁭⁬‬⁬⁮​‍⁫‌‬‌⁫⁭​⁮‎⁬‍‎⁯‌⁯‌⁯‫⁭⁫‬‮.u206e‬‎‬‏⁯‪‌⁫‮⁮⁬‮‏‮‫⁫‪‫‫⁪‭⁬‪‮⁬​⁯⁬⁪⁭⁬‭⁪‪‌‌‪‪⁬‮ = string.Empty;
		try
		{
			this.u200c⁭⁭⁬​​⁫‎‌‌⁬⁬‏⁮‎⁪‬⁯⁬⁮‭​‫‎⁫⁯⁪⁫​⁯‫​⁯⁪‎‬‮‪‏‪‮ = new WiresharkSender(u003cModuleu003e.u202a‮‫‏‫‬‬‪⁫⁬​‏⁫⁭‍‪‪‎⁬​‪​‌⁮‮‌​⁫​⁬‪‫⁪⁯⁪‎‫⁭‎⁪‮<string>(1390962280), 101);
			u206a⁫‮‫‎‮‪‎‮‍‭‭⁭⁬‬⁬⁮​‍⁫‌‬‌⁫⁭​⁮‎⁬‍‎⁯‌⁯‌⁯‫⁭⁫‬‮.u206d‌⁫‬⁫‮‫‪⁭⁫⁮⁫‪⁮⁯⁫‌‍‍⁪⁭⁯⁭‏‬⁬⁭‪⁯‮‍‪‌‫‮‍⁮⁪⁫‎‮ = true;
		}
		catch
		{
			obj = obj1;
			u206a⁫‮‫‎‮‪‎‮‍‭‭⁭⁬‬⁬⁮​‍⁫‌‬‌⁫⁭​⁮‎⁬‍‎⁯‌⁯‌⁯‫⁭⁫‬‮.u206d‌⁫‬⁫‮‫‪⁭⁫⁮⁫‪⁮⁯⁫‌‍‍⁪⁭⁯⁭‏‬⁬⁭‪⁯‮‍‪‌‫‮‍⁮⁪⁫‎‮ = false;
		}
	}
}