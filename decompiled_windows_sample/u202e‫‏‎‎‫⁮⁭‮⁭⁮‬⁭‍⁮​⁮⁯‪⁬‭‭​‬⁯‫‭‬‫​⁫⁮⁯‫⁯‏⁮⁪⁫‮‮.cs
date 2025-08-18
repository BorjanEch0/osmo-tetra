using System;
using System.Reflection;

// ‮‫‏‎‎‫⁮⁭‮⁭⁮‬⁭‍⁮​⁮⁯‪⁬‭‭​‬⁯‫‭‬‫​⁫⁮⁯‫⁯‏⁮⁪⁫‮‮
internal class u202e‫‏‎‎‫⁮⁭‮⁭⁮‬⁭‍⁮​⁮⁯‪⁬‭‭​‬⁯‫‭‬‫​⁫⁮⁯‫⁯‏⁮⁪⁫‮‮
{
	// ⁭‮⁮‮⁫⁫⁮⁯‭⁬⁫‮⁫⁭‬⁪⁬‬‫‮​‏‌⁪⁬‌‪​⁪‭‬⁫‫‪‍‮⁬‮⁮⁯‮
	private static byte[] u206d‮⁮‮⁫⁫⁮⁯‭⁬⁫‮⁫⁭‬⁪⁬‬‫‮​‏‌⁪⁬‌‪​⁪‭‬⁫‫‪‍‮⁬‮⁮⁯‮;

	// ‭‍⁮‏⁯⁮‭‎⁮⁮⁯‮‎‎‮‍‍‪‬‍⁯‎‏​​‪‌‭⁪⁪⁪‮‬​‭​​⁫⁫⁬‮
	private static byte[] u202d‍⁮‏⁯⁮‭‎⁮⁮⁯‮‎‎‮‍‍‪‬‍⁯‎‏​​‪‌‭⁪⁪⁪‮‬​‭​​⁫⁫⁬‮;

	// ⁫⁫‭‪⁫⁪⁬‮⁯⁫⁯⁮‍‫⁭⁬⁭⁮‫⁫‎‮⁭‭⁯‮⁬‌⁭‬‫‫⁮⁫‎⁮​⁬‬‎‮
	private static byte[] u206b⁫‭‪⁫⁪⁬‮⁯⁫⁯⁮‍‫⁭⁬⁭⁮‫⁫‎‮⁭‭⁯‮⁬‌⁭‬‫‫⁮⁫‎⁮​⁬‬‎‮;

	// ‌‪⁯‮⁪‌‪‍‍‪‌⁬‏⁬‏​‏​⁬‍​‭⁬⁭‏​⁭‏‍⁭​⁬‍‬​⁬⁮‎‌‎‮
	private static byte[] u200c‪⁯‮⁪‌‪‍‍‪‌⁬‏⁬‏​‏​⁬‍​‭⁬⁭‏​⁭‏‍⁭​⁬‍‬​⁬⁮‎‌‎‮;

	// ‫‭⁭‪‫⁫‫⁯‌‫⁬⁮⁬⁭‍‌‪‫‏⁭‎⁮‎⁫⁯‮‎‮⁮‬‮‌‌‫‮⁭‏‬⁬‎‮
	private static byte[] u202b‭⁭‪‫⁫‫⁯‌‫⁬⁮⁬⁭‍‌‪‫‏⁭‎⁮‎⁫⁯‮‎‮⁮‬‮‌‌‫‮⁭‏‬⁬‎‮;

	// ‬‪⁯⁭‫‪⁬‎⁭⁫‌‫‭‏⁮⁮⁬​‪‍‍‫‭​‪⁪‏⁯⁪⁬‍⁯‪⁭⁪‭‌⁭​‮‮
	public unsafe void u202c‪⁯⁭‫‪⁬‎⁭⁫‌‫‭‏⁮⁮⁬​‪‍‍‫‭​‪⁪‏⁯⁪⁬‍⁯‪⁭⁪‭‌⁭​‮‮(u202e‫‏‎‎‫⁮⁭‮⁭⁮‬⁭‍⁮​⁮⁯‪⁬‭‭​‬⁯‫‭‬‫​⁫⁮⁯‫⁯‏⁮⁪⁫‮‮.u206a‌‮‭‬⁯‬⁫⁫‫⁪⁬⁮‬‎‎⁬‎⁬‫⁬⁭‎‍‮‬‭​⁫‫⁬‎‭⁪⁭‌‌‎⁭⁭‮ , byte* , sbyte* , int )
	{
		// 
		// Current member / type: System.Void ‮‫‏‎‎‫⁮⁭‮⁭⁮‬⁭‍⁮​⁮⁯‪⁬‭‭​‬⁯‫‭‬‫​⁫⁮⁯‫⁯‏⁮⁪⁫‮‮::‬‪⁯⁭‫‪⁬‎⁭⁫‌‫‭‏⁮⁮⁬​‪‍‍‫‭​‪⁪‏⁯⁪⁬‍⁯‪⁭⁪‭‌⁭​‮‮(‮‫‏‎‎‫⁮⁭‮⁭⁮‬⁭‍⁮​⁮⁯‪⁬‭‭​‬⁯‫‭‬‫​⁫⁮⁯‫⁯‏⁮⁪⁫‮‮/⁪‌‮‭‬⁯‬⁫⁫‫⁪⁬⁮‬‎‎⁬‎⁬‫⁬⁭‎‍‮‬‭​⁫‫⁬‎‭⁪⁭‌‌‎⁭⁭‮,System.Byte*,System.SByte*,System.Int32)
		// File path: C:\SDRSharp\Plugins\Tetra\SDRSharp.Tetra.dll
		// 
		// Product version: 0.0.0.0
		// Exception in: System.Void ‬‪⁯⁭‫‪⁬‎⁭⁫‌‫‭‏⁮⁮⁬​‪‍‍‫‭​‪⁪‏⁯⁪⁬‍⁯‪⁭⁪‭‌⁭​‮‮(u202e‫‏‎‎‫⁮⁭‮⁭⁮‬⁭‍⁮​⁮⁯‪⁬‭‭​‬⁯‫‭‬‫​⁫⁮⁯‫⁯‏⁮⁪⁫‮‮/u206a‌‮‭‬⁯‬⁫⁫‫⁪⁬⁮‬‎‎⁬‎⁬‫⁬⁭‎‍‮‬‭​⁫‫⁬‎‭⁪⁭‌‌‎⁭⁭‮,System.Byte*,System.SByte*,System.Int32)
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

	// ‍⁮‫‮⁯⁮⁮⁪‎⁬‫‫‬‬⁪‍‍‪‫⁭⁬‏​‏⁫‫⁫⁮‭⁯​⁯‎⁫⁫‍‪⁪⁭⁭‮
	// privatescope
	internal static void u200d⁮‫‮⁯⁮⁮⁪‎⁬‫‫‬‬⁪‍‍‪‫⁭⁬‏​‏⁫‫⁫⁮‭⁯​⁯‎⁫⁫‍‪⁪⁭⁭‮(Array , RuntimeFieldHandle )
	{
		// 
		// Current member / type: System.Void ‮‫‏‎‎‫⁮⁭‮⁭⁮‬⁭‍⁮​⁮⁯‪⁬‭‭​‬⁯‫‭‬‫​⁫⁮⁯‫⁯‏⁮⁪⁫‮‮::‍⁮‫‮⁯⁮⁮⁪‎⁬‫‫‬‬⁪‍‍‪‫⁭⁬‏​‏⁫‫⁫⁮‭⁯​⁯‎⁫⁫‍‪⁪⁭⁭‮(System.Array,System.RuntimeFieldHandle)
		// File path: C:\SDRSharp\Plugins\Tetra\SDRSharp.Tetra.dll
		// 
		// Product version: 0.0.0.0
		// Exception in: System.Void ‍⁮‫‮⁯⁮⁮⁪‎⁬‫‫‬‬⁪‍‍‪‫⁭⁬‏​‏⁫‫⁫⁮‭⁯​⁯‎⁫⁫‍‪⁪⁭⁭‮(System.Array,System.RuntimeFieldHandle)
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

	static u202e‫‏‎‎‫⁮⁭‮⁭⁮‬⁭‍⁮​⁮⁯‪⁬‭‭​‬⁯‫‭‬‫​⁫⁮⁯‫⁯‏⁮⁪⁫‮‮()
	{
		byte[] numArray;
		byte[] numArray1 = new byte[7];
		u202e‫‏‎‎‫⁮⁭‮⁭⁮‬⁭‍⁮​⁮⁯‪⁬‭‭​‬⁯‫‭‬‫​⁫⁮⁯‫⁯‏⁮⁪⁫‮‮.u200d⁮‫‮⁯⁮⁮⁪‎⁬‫‫‬‬⁪‍‍‪‫⁭⁬‏​‏⁫‫⁫⁮‭⁯​⁯‎⁫⁫‍‪⁪⁭⁭‮((Array)numArray1, typeof(u206e⁭⁬‬‬‎⁮⁪⁯‫‮⁮‍⁭‍‬⁭⁪‏⁮⁭⁫⁪⁬⁯‍⁮⁭‎⁬‪‌⁫⁭⁮‫‍‮‏‭‮).GetField("AF4213C9BD1F1D95FAD81C5133398189D54B92B0").FieldHandle);
		u202e‫‏‎‎‫⁮⁭‮⁭⁮‬⁭‍⁮​⁮⁯‪⁬‭‭​‬⁯‫‭‬‫​⁫⁮⁯‫⁯‏⁮⁪⁫‮‮.u206d‮⁮‮⁫⁫⁮⁯‭⁬⁫‮⁫⁭‬⁪⁬‬‫‮​‏‌⁪⁬‌‪​⁪‭‬⁫‫‪‍‮⁬‮⁮⁯‮ = numArray1;
	Label0:
		int num = 247955614;
		while (true)
		{
			int num1 = num ^ 1947507283;
			uint num2 = (uint)num1;
			switch (num1 % 4)
			{
				case 0:
				{
					goto Label0;
				}
				case 1:
				{
					byte[] numArray2 = new byte[4];
					u202e‫‏‎‎‫⁮⁭‮⁭⁮‬⁭‍⁮​⁮⁯‪⁬‭‭​‬⁯‫‭‬‫​⁫⁮⁯‫⁯‏⁮⁪⁫‮‮.u200d⁮‫‮⁯⁮⁮⁪‎⁬‫‫‬‬⁪‍‍‪‫⁭⁬‏​‏⁫‫⁫⁮‭⁯​⁯‎⁫⁫‍‪⁪⁭⁭‮((Array)numArray2, typeof(u206e⁭⁬‬‬‎⁮⁪⁯‫‮⁮‍⁭‍‬⁭⁪‏⁮⁭⁫⁪⁬⁯‍⁮⁭‎⁬‪‌⁫⁭⁮‫‍‮‏‭‮).GetField("101B2A675E9FB9546336D5B9EF70418B594184F4").FieldHandle);
					u202e‫‏‎‎‫⁮⁭‮⁭⁮‬⁭‍⁮​⁮⁯‪⁬‭‭​‬⁯‫‭‬‫​⁫⁮⁯‫⁯‏⁮⁪⁫‮‮.u202d‍⁮‏⁯⁮‭‎⁮⁮⁯‮‎‎‮‍‍‪‬‍⁯‎‏​​‪‌‭⁪⁪⁪‮‬​‭​​⁫⁫⁬‮ = numArray2;
					byte[] numArray3 = new byte[4];
					u202e‫‏‎‎‫⁮⁭‮⁭⁮‬⁭‍⁮​⁮⁯‪⁬‭‭​‬⁯‫‭‬‫​⁫⁮⁯‫⁯‏⁮⁪⁫‮‮.u200d⁮‫‮⁯⁮⁮⁪‎⁬‫‫‬‬⁪‍‍‪‫⁭⁬‏​‏⁫‫⁫⁮‭⁯​⁯‎⁫⁫‍‪⁪⁭⁭‮((Array)numArray3, typeof(u206e⁭⁬‬‬‎⁮⁪⁯‫‮⁮‍⁭‍‬⁭⁪‏⁮⁭⁫⁪⁬⁯‍⁮⁭‎⁬‪‌⁫⁭⁮‫‍‮‏‭‮).GetField("6E36A9BFACF6C4637D64042B11CB78BFDDAF8BF3").FieldHandle);
					u202e‫‏‎‎‫⁮⁭‮⁭⁮‬⁭‍⁮​⁮⁯‪⁬‭‭​‬⁯‫‭‬‫​⁫⁮⁯‫⁯‏⁮⁪⁫‮‮.u206b⁫‭‪⁫⁪⁬‮⁯⁫⁯⁮‍‫⁭⁬⁭⁮‫⁫‎‮⁭‭⁯‮⁬‌⁭‬‫‫⁮⁫‎⁮​⁬‬‎‮ = numArray3;
					num = (int)(num2 * -425259351 ^ 1519931668);
					continue;
				}
				case 2:
				{
					byte[] numArray4 = new byte[10];
					u202e‫‏‎‎‫⁮⁭‮⁭⁮‬⁭‍⁮​⁮⁯‪⁬‭‭​‬⁯‫‭‬‫​⁫⁮⁯‫⁯‏⁮⁪⁫‮‮.u200d⁮‫‮⁯⁮⁮⁪‎⁬‫‫‬‬⁪‍‍‪‫⁭⁬‏​‏⁫‫⁫⁮‭⁯​⁯‎⁫⁫‍‪⁪⁭⁭‮((Array)numArray4, typeof(u206e⁭⁬‬‬‎⁮⁪⁯‫‮⁮‍⁭‍‬⁭⁪‏⁮⁭⁫⁪⁬⁯‍⁮⁭‎⁬‪‌⁫⁭⁮‫‍‮‏‭‮).GetField("F392604DAA74E0A914F0DC3189E64E40CD6A6103").FieldHandle);
					u202e‫‏‎‎‫⁮⁭‮⁭⁮‬⁭‍⁮​⁮⁯‪⁬‭‭​‬⁯‫‭‬‫​⁫⁮⁯‫⁯‏⁮⁪⁫‮‮.u200c‪⁯‮⁪‌‪‍‍‪‌⁬‏⁬‏​‏​⁬‍​‭⁬⁭‏​⁭‏‍⁭​⁬‍‬​⁬⁮‎‌‎‮ = numArray4;
					num = (int)(num2 * 785763220 ^ 1057527800);
					continue;
				}
				case 3:
				{
					numArray = new byte[18];
					u202e‫‏‎‎‫⁮⁭‮⁭⁮‬⁭‍⁮​⁮⁯‪⁬‭‭​‬⁯‫‭‬‫​⁫⁮⁯‫⁯‏⁮⁪⁫‮‮.u200d⁮‫‮⁯⁮⁮⁪‎⁬‫‫‬‬⁪‍‍‪‫⁭⁬‏​‏⁫‫⁫⁮‭⁯​⁯‎⁫⁫‍‪⁪⁭⁭‮((Array)numArray, typeof(u206e⁭⁬‬‬‎⁮⁪⁯‫‮⁮‍⁭‍‬⁭⁪‏⁮⁭⁫⁪⁬⁯‍⁮⁭‎⁬‪‌⁫⁭⁮‫‍‮‏‭‮).GetField("B05F0AD3414D3652AD3E409170980C6B90B479B3").FieldHandle);
					u202e‫‏‎‎‫⁮⁭‮⁭⁮‬⁭‍⁮​⁮⁯‪⁬‭‭​‬⁯‫‭‬‫​⁫⁮⁯‫⁯‏⁮⁪⁫‮‮.u202b‭⁭‪‫⁫‫⁯‌‫⁬⁮⁬⁭‍‌‪‫‏⁭‎⁮‎⁫⁯‮‎‮⁮‬‮‌‌‫‮⁭‏‬⁬‎‮ = numArray;
					return;
				}
			}
		}
		numArray = new byte[18];
		u202e‫‏‎‎‫⁮⁭‮⁭⁮‬⁭‍⁮​⁮⁯‪⁬‭‭​‬⁯‫‭‬‫​⁫⁮⁯‫⁯‏⁮⁪⁫‮‮.u200d⁮‫‮⁯⁮⁮⁪‎⁬‫‫‬‬⁪‍‍‪‫⁭⁬‏​‏⁫‫⁫⁮‭⁯​⁯‎⁫⁫‍‪⁪⁭⁭‮((Array)numArray, typeof(u206e⁭⁬‬‬‎⁮⁪⁯‫‮⁮‍⁭‍‬⁭⁪‏⁮⁭⁫⁪⁬⁯‍⁮⁭‎⁬‪‌⁫⁭⁮‫‍‮‏‭‮).GetField("B05F0AD3414D3652AD3E409170980C6B90B479B3").FieldHandle);
		u202e‫‏‎‎‫⁮⁭‮⁭⁮‬⁭‍⁮​⁮⁯‪⁬‭‭​‬⁯‫‭‬‫​⁫⁮⁯‫⁯‏⁮⁪⁫‮‮.u202b‭⁭‪‫⁫‫⁯‌‫⁬⁮⁬⁭‍‌‪‫‏⁭‎⁮‎⁫⁯‮‎‮⁮‬‮‌‌‫‮⁭‏‬⁬‎‮ = numArray;
	}

	public u202e‫‏‎‎‫⁮⁭‮⁭⁮‬⁭‍⁮​⁮⁯‪⁬‭‭​‬⁯‫‭‬‫​⁫⁮⁯‫⁯‏⁮⁪⁫‮‮()
	{
	}

	// ⁪‌‮‭‬⁯‬⁫⁫‫⁪⁬⁮‬‎‎⁬‎⁬‫⁬⁭‎‍‮‬‭​⁫‫⁬‎‭⁪⁭‌‌‎⁭⁭‮
	public enum u206a‌‮‭‬⁯‬⁫⁫‫⁪⁬⁮‬‎‎⁬‎⁬‫⁬⁭‎‍‮‬‭​⁫‫⁬‎‭⁪⁭‌‌‎⁭⁭‮
	{
		PUNCT_2_3,
		PUNCT_1_3,
		PUNCT_292_432,
		PUNCT_148_432,
		PUNCT_112_168,
		PUNCT_72_162,
		PUNCT_38_80
	}

	// ​⁯‍‍‌‌‏‌‍‍⁪⁯⁭⁫‮‫⁬‌⁫​⁫‭‭‍‫‫⁭‏‌⁯‌‍‬​⁭‬​‭‭‏‮
	private enum u200b⁯‍‍‌‌‏‌‍‍⁪⁯⁭⁫‮‫⁬‌⁫​⁫‭‭‍‫‫⁭‏‌⁯‌‍‬​⁭‬​‭‭‏‮
	{
		Equals,
		Func_292,
		Func_148
	}
}