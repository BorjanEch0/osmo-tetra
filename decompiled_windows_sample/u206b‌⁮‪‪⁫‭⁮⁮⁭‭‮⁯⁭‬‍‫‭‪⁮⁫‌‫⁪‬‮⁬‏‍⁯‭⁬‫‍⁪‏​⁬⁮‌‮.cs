using SDRSharp.Radio;
using System;
using System.Reflection;

// ⁫‌⁮‪‪⁫‭⁮⁮⁭‭‮⁯⁭‬‍‫‭‪⁮⁫‌‫⁪‬‮⁬‏‍⁯‭⁬‫‍⁪‏​⁬⁮‌‮
internal class u206b‌⁮‪‪⁫‭⁮⁮⁭‭‮⁯⁭‬‍‫‭‪⁮⁫‌‫⁪‬‮⁬‏‍⁯‭⁬‫‍⁪‏​⁬⁮‌‮
{
	// ‭‪⁮⁫‬‎‫‏‭‏‍‌‬​‍‬‫‎‭⁫‫⁮​⁭‍‌‍‫​‎⁯⁪‎‏⁬⁭‫⁮‎‮‮
	private const int u202d‪⁮⁫‬‎‫‏‭‏‍‌‬​‍‬‫‎‭⁫‫⁮​⁭‍‌‍‫​‎⁯⁪‎‏⁬⁭‫⁮‎‮‮ = 14;

	// ‫‍⁬​⁮‌‪​‎‎​‭⁫⁯⁬‎‮‬‫‪​⁯⁫‪‏⁬‬‎‌‍‎⁯‫⁬⁫⁯‍‭‮‪‮
	private const int u202b‍⁬​⁮‌‪​‎‎​‭⁫⁯⁬‎‮‬‫‪​⁯⁫‪‏⁬‬‎‌‍‎⁯‫⁬⁫⁯‍‭‮‪‮ = 30;

	// ‮‭‮‭‫⁫⁫‬‫‎⁭‌‬⁯⁯‏⁯‬⁪‪​⁫​⁪⁮‏‏​‭‌‪⁭‭‌⁫‫​‌‎‫‮
	private const int u202e‭‮‭‫⁫⁫‬‫‎⁭‌‬⁯⁯‏⁯‬⁪‪​⁫​⁪⁮‏‏​‭‌‪⁭‭‌⁫‫​‌‎‫‮ = 16;

	// ⁯​‏‭‪​‌‫⁪‏‍​‫‬‎‮⁪‫‏‏‭‪⁭⁬‏‍⁮‏⁯‏​⁯‮‭‍⁭⁯‭​‮‮
	private const uint u206f​‏‭‪​‌‫⁪‏‍​‫‬‎‮⁪‫‏‏‭‪⁭⁬‏‍⁮‏⁯‏​⁯‮‭‍⁭⁯‭​‮‮ = 536870912;

	// ‬⁮‌‏‮‌‮‬‏‍⁭⁬‭‮‫‫‌‬‌‮⁮‏‏⁬‏⁬‌‍‭‍‬‬‎‌‮⁭‮⁭‫⁮‮
	private UnsafeBuffer u202c⁮‌‏‮‌‮‬‏‍⁭⁬‭‮‫‫‌‬‌‮⁮‏‏⁬‏⁬‌‍‭‍‬‬‎‌‮⁭‮⁭‫⁮‮;

	// ‬‫⁭‬‬⁯​​⁭‌⁫⁮‌​‭‬‮⁯‫⁯⁪‍​⁪⁭⁯‮⁯‎⁯‌⁮⁯‪‮‏‎⁫⁮‬‮
	private unsafe byte* u202c‫⁭‬‬⁯​​⁭‌⁫⁮‌​‭‬‮⁯‫⁯⁪‍​⁪⁭⁯‮⁯‎⁯‌⁮⁯‪‮‏‎⁫⁮‬‮;

	// ⁯‫‍‎‮‫‮⁭‪‏‬‏⁯‪‏‭‫‌​​‌‍⁯⁯⁮‏‏‏‎⁯⁭‏⁯​‍⁮‮‪‮‎‮
	private UnsafeBuffer u206f‫‍‎‮‫‮⁭‪‏‬‏⁯‪‏‭‫‌​​‌‍⁯⁯⁮‏‏‏‎⁯⁭‏⁯​‍⁮‮‪‮‎‮;

	// ‍‏⁮‌‬‏‮⁪‫‬​⁭‎‏‭​‌‮⁭⁭⁫‬⁮‭⁯‎​⁯‏‍‫⁯‌‌⁭‌‭‮‬‏‮
	private unsafe uint* u200d‏⁮‌‬‏‮⁪‫‬​⁭‎‏‭​‌‮⁭⁭⁫‬⁮‭⁯‎​⁯‏‍‫⁯‌‌⁭‌‭‮‬‏‮;

	// ⁮‫​‮⁮​‪‬‪⁬⁯‬⁭​⁪‬‮‪⁮‫​‬⁫‮⁭‍‬‪‮⁯‎‏‪⁫‌‏⁫⁪⁪⁯‮
	private UnsafeBuffer u206e‫​‮⁮​‪‬‪⁬⁯‬⁭​⁪‬‮‪⁮‫​‬⁫‮⁭‍‬‪‮⁯‎‏‪⁫‌‏⁫⁪⁪⁯‮;

	// ‬‭‭‎‭‎⁭​⁮⁭⁭‫‫​‌⁯‭‍‎⁫‮‫⁭‎⁭⁪‬⁯‌​​⁮​‮‪⁬‌‏⁫‪‮
	private unsafe uint* u202c‭‭‎‭‎⁭​⁮⁭⁭‫‫​‌⁯‭‍‎⁫‮‫⁭‎⁭⁪‬⁯‌​​⁮​‮‪⁬‌‏⁫‪‮;

	// ⁬‮‭⁪​‫‭⁪⁭‍‬⁫‭‎⁭‭‮‍⁬​‏‬⁬⁭⁯⁫‌⁬‎​‮‎‫⁬‌⁪‬⁭⁮‌‮
	private readonly static byte[,] u206c‮‭⁪​‫‭⁪⁭‍‬⁫‭‎⁭‭‮‍⁬​‏‬⁬⁭⁯⁫‌⁬‎​‮‎‫⁬‌⁪‬⁭⁮‌‮;

	// ‌⁭‮‎⁫⁮⁮‭⁮‮⁬‮‌⁫⁯‎‌‏‬‏⁭⁪‫‫‮​‎‍‬‏⁪‬‍⁭‎⁬⁬​‍‮
	private readonly static byte[,] u200c⁭‮‎⁫⁮⁮‭⁮‮⁬‮‌⁫⁯‎‌‏‬‏⁭⁪‫‫‮​‎‍‬‏⁪‬‍⁭‎⁬⁬​‍‮;

	// ‮⁪‮⁮‌‪‏‮‪‫‫‍‮‮⁫‎⁬‪‫⁯‎‮‫⁫‮‭‮⁯⁪‮‮‍⁭⁭‬‎‏‭⁬⁮‮
	public unsafe void u202e⁪‮⁮‌‪‏‮‪‫‫‍‮‮⁫‎⁬‪‫⁯‎‮‫⁫‮‭‮⁯⁪‮‮‍⁭⁭‬‎‏‭⁬⁮‮()
	{
		// 
		// Current member / type: System.Void ⁫‌⁮‪‪⁫‭⁮⁮⁭‭‮⁯⁭‬‍‫‭‪⁮⁫‌‫⁪‬‮⁬‏‍⁯‭⁬‫‍⁪‏​⁬⁮‌‮::‮⁪‮⁮‌‪‏‮‪‫‫‍‮‮⁫‎⁬‪‫⁯‎‮‫⁫‮‭‮⁯⁪‮‮‍⁭⁭‬‎‏‭⁬⁮‮()
		// File path: C:\SDRSharp\Plugins\Tetra\SDRSharp.Tetra.dll
		// 
		// Product version: 0.0.0.0
		// Exception in: System.Void ‮⁪‮⁮‌‪‏‮‪‫‫‍‮‮⁫‎⁬‪‫⁯‎‮‫⁫‮‭‮⁯⁪‮‮‍⁭⁭‬‎‏‭⁬⁮‮()
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

	// ⁫⁬‏‬‭‏‍‭‍‭‮⁪⁭‬‭⁯‮​‬‏⁯‌‪‌‬⁪⁭⁫‌‌⁮⁭​‏‬‫⁫‏‫‮‮
	public void u206b⁬‏‬‭‏‍‭‍‭‮⁪⁭‬‭⁯‮​‬‏⁯‌‪‌‬⁪⁭⁫‌‌⁮⁭​‏‬‫⁫‏‫‮‮()
	{
		// 
		// Current member / type: System.Void ⁫‌⁮‪‪⁫‭⁮⁮⁭‭‮⁯⁭‬‍‫‭‪⁮⁫‌‫⁪‬‮⁬‏‍⁯‭⁬‫‍⁪‏​⁬⁮‌‮::⁫⁬‏‬‭‏‍‭‍‭‮⁪⁭‬‭⁯‮​‬‏⁯‌‪‌‬⁪⁭⁫‌‌⁮⁭​‏‬‫⁫‏‫‮‮()
		// File path: C:\SDRSharp\Plugins\Tetra\SDRSharp.Tetra.dll
		// 
		// Product version: 0.0.0.0
		// Exception in: System.Void ⁫⁬‏‬‭‏‍‭‍‭‮⁪⁭‬‭⁯‮​‬‏⁯‌‪‌‬⁪⁭⁫‌‌⁮⁭​‏‬‫⁫‏‫‮‮()
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

	// ‬‪⁯⁭‫‪⁬‎⁭⁫‌‫‭‏⁮⁮⁬​‪‍‍‫‭​‪⁪‏⁯⁪⁬‍⁯‪⁭⁪‭‌⁭​‮‮
	public unsafe bool u202c‪⁯⁭‫‪⁬‎⁭⁫‌‫‭‏⁮⁮⁬​‪‍‍‫‭​‪⁪‏⁯⁪⁬‍⁯‪⁭⁪‭‌⁭​‮‮(byte* , byte* )
	{
		// 
		// Current member / type: System.Boolean ⁫‌⁮‪‪⁫‭⁮⁮⁭‭‮⁯⁭‬‍‫‭‪⁮⁫‌‫⁪‬‮⁬‏‍⁯‭⁬‫‍⁪‏​⁬⁮‌‮::‬‪⁯⁭‫‪⁬‎⁭⁫‌‫‭‏⁮⁮⁬​‪‍‍‫‭​‪⁪‏⁯⁪⁬‍⁯‪⁭⁪‭‌⁭​‮‮(System.Byte*,System.Byte*)
		// File path: C:\SDRSharp\Plugins\Tetra\SDRSharp.Tetra.dll
		// 
		// Product version: 0.0.0.0
		// Exception in: System.Boolean ‬‪⁯⁭‫‪⁬‎⁭⁫‌‫‭‏⁮⁮⁬​‪‍‍‫‭​‪⁪‏⁯⁪⁬‍⁯‪⁭⁪‭‌⁭​‮‮(System.Byte*,System.Byte*)
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

	// ⁫⁭‫‪⁫‏‎‎​⁫‌⁫⁭​⁪‬‏‪⁭‬‫⁯⁯‪‮‫‎‎‌​‬⁭‍⁭‪⁫⁯​‪‭‮
	// privatescope
	internal static Random u206b⁭‫‪⁫‏‎‎​⁫‌⁫⁭​⁪‬‏‪⁭‬‫⁯⁯‪‮‫‎‎‌​‬⁭‍⁭‪⁫⁯​‪‭‮()
	{
		return new Random();
	}

	// ‮⁭‪‎⁮⁭⁬‪‍⁬‎⁬⁬‮⁭⁯‬⁮‌‮⁫​‫⁫⁭⁮‬‭‫⁪‌‎‪⁬⁮‍‮‪‫⁭‮
	// privatescope
	internal static UnsafeBuffer u202e⁭‪‎⁮⁭⁬‪‍⁬‎⁬⁬‮⁭⁯‬⁮‌‮⁫​‫⁫⁭⁮‬‭‫⁪‌‎‪⁬⁮‍‮‪‫⁭‮(int num, int num)
	{
		return UnsafeBuffer.Create(num, num);
	}

	// ‭⁮⁫⁬‬‍‫⁭‭‬‍‍⁫‭⁭​‌⁬‎‪⁯‌⁭‬‭⁫⁫‬⁮⁮‏⁮⁬‏‪⁭⁮‭​⁯‮
	// privatescope
	internal static unsafe void* u202d⁮⁫⁬‬‍‫⁭‭‬‍‍⁫‭⁭​‌⁬‎‪⁯‌⁭‬‭⁫⁫‬⁮⁮‏⁮⁬‏‪⁭⁮‭​⁯‮(UnsafeBuffer unsafeBuffer)
	{
		return unsafeBuffer;
	}

	// ‍⁮⁯‭⁫‌‌‮‎‪‮⁮‫⁮‭⁯‌⁭‎‫‏‍⁫⁫‏‭‭‮⁮‎‏‭‬‏⁭⁯⁫‍⁫‫‮
	// privatescope
	internal static int u200d⁮⁯‭⁫‌‌‮‎‪‮⁮‫⁮‭⁯‌⁭‎‫‏‍⁫⁫‏‭‭‮⁮‎‏‭‬‏⁭⁯⁫‍⁫‫‮(Random random, int num, int num)
	{
		return random.Next(num, num);
	}

	// ⁪⁭⁫‏‫​⁪⁫⁯‫​‬⁭⁭‭⁬⁮‮⁪‬‬⁫‮⁬⁫‪‬‬⁯‍‮‍⁭​‏‎‍‎‏‫‮
	// privatescope
	internal static int u206a⁭⁫‏‫​⁪⁫⁯‫​‬⁭⁭‭⁬⁮‮⁪‬‬⁫‮⁬⁫‪‬‬⁯‍‮‍⁭​‏‎‍‎‏‫‮(UnsafeBuffer unsafeBuffer)
	{
		return unsafeBuffer.get_Length();
	}

	// ⁮‎⁭‏‪⁬‌‏‌⁫⁪‌‍‌⁪‍‍⁮⁭⁬‮‍⁪‭⁮‌‌‫‫‏‭‭‫⁪‍‭‎‏‬‍‮
	// privatescope
	internal static void u206e‎⁭‏‪⁬‌‏‌⁫⁪‌‍‌⁪‍‍⁮⁭⁬‮‍⁪‭⁮‌‌‫‫‏‭‭‫⁪‍‭‎‏‬‍‮(Array , RuntimeFieldHandle )
	{
		// 
		// Current member / type: System.Void ⁫‌⁮‪‪⁫‭⁮⁮⁭‭‮⁯⁭‬‍‫‭‪⁮⁫‌‫⁪‬‮⁬‏‍⁯‭⁬‫‍⁪‏​⁬⁮‌‮::⁮‎⁭‏‪⁬‌‏‌⁫⁪‌‍‌⁪‍‍⁮⁭⁬‮‍⁪‭⁮‌‌‫‫‏‭‭‫⁪‍‭‎‏‬‍‮(System.Array,System.RuntimeFieldHandle)
		// File path: C:\SDRSharp\Plugins\Tetra\SDRSharp.Tetra.dll
		// 
		// Product version: 0.0.0.0
		// Exception in: System.Void ⁮‎⁭‏‪⁬‌‏‌⁫⁪‌‍‌⁪‍‍⁮⁭⁬‮‍⁪‭⁮‌‌‫‫‏‭‭‫⁪‍‭‎‏‬‍‮(System.Array,System.RuntimeFieldHandle)
		// 
		// The expression at the top of the expression stack is not ArrayCreationExpression
		//    at Telerik.JustDecompiler.Decompiler.ExpressionDecompilerStep.TryProcessRuntimeHelpersInitArray(MethodInvocationExpression invocation) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\ExpressionDecompilerStep.cs:line 626
		//    at Telerik.JustDecompiler.Decompiler.ExpressionDecompilerStep.OnCall(Instruction instruction) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\ExpressionDecompilerStep.cs:line 470
		//    at Telerik.JustDecompiler.Cil.InstructionDispatcher.Dispatch(Instruction instruction, IInstructionVisitor visitor) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Cil\InstructionDispatcher.cs:line 178
		//    at Telerik.JustDecompiler.Decompiler.ExpressionDecompilerStep.CreateExpressions() in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\ExpressionDecompilerStep.cs:line 179
		//    at Telerik.JustDecompiler.Decompiler.ExpressionDecompilerStep.Process(DecompilationContext theContext, BlockStatement body) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\ExpressionDecompilerStep.cs:line 68
		//    at Telerik.JustDecompiler.Decompiler.DecompilationPipeline.RunInternal(MethodBody body, BlockStatement block, ILanguage language) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\DecompilationPipeline.cs:line 100
		//    at Telerik.JustDecompiler.Decompiler.WriterContextServices.BaseWriterContextService.DecompileMethod(ILanguage language, MethodDefinition method, TypeSpecificContext typeContext) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\WriterContextServices\BaseWriterContextService.cs:line 133
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com

	}

	static u206b‌⁮‪‪⁫‭⁮⁮⁭‭‮⁯⁭‬‍‫‭‪⁮⁫‌‫⁪‬‮⁬‏‍⁯‭⁬‫‍⁪‏​⁬⁮‌‮()
	{
		byte[,] numArray = new byte[14, 30];
		u206b‌⁮‪‪⁫‭⁮⁮⁭‭‮⁯⁭‬‍‫‭‪⁮⁫‌‫⁪‬‮⁬‏‍⁯‭⁬‫‍⁪‏​⁬⁮‌‮.u206e‎⁭‏‪⁬‌‏‌⁫⁪‌‍‌⁪‍‍⁮⁭⁬‮‍⁪‭⁮‌‌‫‫‏‭‭‫⁪‍‭‎‏‬‍‮((Array)numArray, typeof(u206e⁭⁬‬‬‎⁮⁪⁯‫‮⁮‍⁭‍‬⁭⁪‏⁮⁭⁫⁪⁬⁯‍⁮⁭‎⁬‪‌⁫⁭⁮‫‍‮‏‭‮).GetField("E52928A66D264DB571A5270CDE5CC4972497C0EA").FieldHandle);
		u206b‌⁮‪‪⁫‭⁮⁮⁭‭‮⁯⁭‬‍‫‭‪⁮⁫‌‫⁪‬‮⁬‏‍⁯‭⁬‫‍⁪‏​⁬⁮‌‮.u206c‮‭⁪​‫‭⁪⁭‍‬⁫‭‎⁭‭‮‍⁬​‏‬⁬⁭⁯⁫‌⁬‎​‮‎‫⁬‌⁪‬⁭⁮‌‮ = numArray;
		byte[,] numArray1 = new byte[30, 16];
		u206b‌⁮‪‪⁫‭⁮⁮⁭‭‮⁯⁭‬‍‫‭‪⁮⁫‌‫⁪‬‮⁬‏‍⁯‭⁬‫‍⁪‏​⁬⁮‌‮.u206e‎⁭‏‪⁬‌‏‌⁫⁪‌‍‌⁪‍‍⁮⁭⁬‮‍⁪‭⁮‌‌‫‫‏‭‭‫⁪‍‭‎‏‬‍‮((Array)numArray1, typeof(u206e⁭⁬‬‬‎⁮⁪⁯‫‮⁮‍⁭‍‬⁭⁪‏⁮⁭⁫⁪⁬⁯‍⁮⁭‎⁬‪‌⁫⁭⁮‫‍‮‏‭‮).GetField("FD809FAA7DD8503BAEA6999774647509F091019F").FieldHandle);
		u206b‌⁮‪‪⁫‭⁮⁮⁭‭‮⁯⁭‬‍‫‭‪⁮⁫‌‫⁪‬‮⁬‏‍⁯‭⁬‫‍⁪‏​⁬⁮‌‮.u200c⁭‮‎⁫⁮⁮‭⁮‮⁬‮‌⁫⁯‎‌‏‬‏⁭⁪‫‫‮​‎‍‬‏⁪‬‍⁭‎⁬⁬​‍‮ = numArray1;
	}

	public u206b‌⁮‪‪⁫‭⁮⁮⁭‭‮⁯⁭‬‍‫‭‪⁮⁫‌‫⁪‬‮⁬‏‍⁯‭⁬‫‍⁪‏​⁬⁮‌‮()
	{
	}
}