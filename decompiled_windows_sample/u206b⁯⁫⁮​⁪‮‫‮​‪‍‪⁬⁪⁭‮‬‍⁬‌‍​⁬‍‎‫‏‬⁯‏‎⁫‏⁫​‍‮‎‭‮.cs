using System;

// ⁫⁯⁫⁮​⁪‮‫‮​‪‍‪⁬⁪⁭‮‬‍⁬‌‍​⁬‍‎‫‏‬⁯‏‎⁫‏⁫​‍‮‎‭‮
internal class u206b⁯⁫⁮​⁪‮‫‮​‪‍‪⁬⁪⁭‮‬‍⁬‌‍​⁬‍‎‫‏‬⁯‏‎⁫‏⁫​‍‮‎‭‮
{
	// ‪‬‬‮⁮‍⁭‪‎‬‍‫‎⁭‌‏‬‌⁭‭‭⁭‮‬⁪‫‮‮‬‎‮⁯‏‫⁬‭‪⁮‮‮
	private const int u202a‬‬‮⁮‍⁭‪‎‬‍‫‎⁭‌‏‬‌⁭‭‭⁭‮‬⁪‫‮‮‬‎‮⁯‏‫⁬‭‪⁮‮‮ = 33800;

	// ‮⁭‎‍‭⁬‬‌⁪‏​‭‎⁫⁬‫‫⁫⁪⁮‫‭⁮‍‎‪‬‎‌‍⁯‫‮‫⁯⁮‫‌‎‬‮
	private const int u202e⁭‎‍‭⁬‬‌⁪‏​‭‎⁫⁬‫‫⁫⁪⁮‫‭⁮‍‎‪‬‎‌‍⁯‫‮‫⁯⁮‫‌‎‬‮ = 61624;

	// ⁪⁫⁬⁮⁮‌‍⁫​⁬‫⁭‬‪​‏⁮‏‪‮⁪‭‫‎​⁫‌‮‪​‪‭‭‎⁬‎⁪‭⁪⁯‮
	public unsafe int u206a⁫⁬⁮⁮‌‍⁫​⁬‫⁭‬‪​‏⁮‏‪‮⁪‭‫‎​⁫‌‮‪​‪‭‭‎⁬‎⁪‭⁪⁯‮(byte* , int )
	{
		// 
		// Current member / type: System.Int32 ⁫⁯⁫⁮​⁪‮‫‮​‪‍‪⁬⁪⁭‮‬‍⁬‌‍​⁬‍‎‫‏‬⁯‏‎⁫‏⁫​‍‮‎‭‮::⁪⁫⁬⁮⁮‌‍⁫​⁬‫⁭‬‪​‏⁮‏‪‮⁪‭‫‎​⁫‌‮‪​‪‭‭‎⁬‎⁪‭⁪⁯‮(System.Byte*,System.Int32)
		// File path: C:\SDRSharp\Plugins\Tetra\SDRSharp.Tetra.dll
		// 
		// Product version: 0.0.0.0
		// Exception in: System.Int32 ⁪⁫⁬⁮⁮‌‍⁫​⁬‫⁭‬‪​‏⁮‏‪‮⁪‭‫‎​⁫‌‮‪​‪‭‭‎⁬‎⁪‭⁪⁯‮(System.Byte*,System.Int32)
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
	public unsafe bool u202c‪⁯⁭‫‪⁬‎⁭⁫‌‫‭‏⁮⁮⁬​‪‍‍‫‭​‪⁪‏⁯⁪⁬‍⁯‪⁭⁪‭‌⁭​‮‮(byte* , byte* , int )
	{
		// 
		// Current member / type: System.Boolean ⁫⁯⁫⁮​⁪‮‫‮​‪‍‪⁬⁪⁭‮‬‍⁬‌‍​⁬‍‎‫‏‬⁯‏‎⁫‏⁫​‍‮‎‭‮::‬‪⁯⁭‫‪⁬‎⁭⁫‌‫‭‏⁮⁮⁬​‪‍‍‫‭​‪⁪‏⁯⁪⁬‍⁯‪⁭⁪‭‌⁭​‮‮(System.Byte*,System.Byte*,System.Int32)
		// File path: C:\SDRSharp\Plugins\Tetra\SDRSharp.Tetra.dll
		// 
		// Product version: 0.0.0.0
		// Exception in: System.Boolean ‬‪⁯⁭‫‪⁬‎⁭⁫‌‫‭‏⁮⁮⁬​‪‍‍‫‭​‪⁪‏⁯⁪⁬‍⁯‪⁭⁪‭‌⁭​‮‮(System.Byte*,System.Byte*,System.Int32)
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

	public u206b⁯⁫⁮​⁪‮‫‮​‪‍‪⁬⁪⁭‮‬‍⁬‌‍​⁬‍‎‫‏‬⁯‏‎⁫‏⁫​‍‮‎‭‮()
	{
	}
}