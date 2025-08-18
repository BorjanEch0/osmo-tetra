using SDRSharp.Radio;
using System;
using System.Reflection;

// ⁯‪​‭‫‭‬‏‌⁯‎‌‫‌⁭‎⁪⁯‭‭‭‮⁫⁫‏⁮⁬⁯‭‮‏‍‮⁮‭⁪‪‫‏‮‮
internal class u206f‪​‭‫‭‬‏‌⁯‎‌‫‌⁭‎⁪⁯‭‭‭‮⁫⁫‏⁮⁬⁯‭‮‏‍‮⁮‭⁪‪‫‏‮‮
{
	// ‍⁮‌⁬‎‎​‍⁯⁯⁫‌⁮‎‍⁯‪⁮‌‬​‬⁪‪‫⁪‎‍⁭⁬⁫⁭‍‍⁪⁮‏‍⁬‪‮
	private const int u200d⁮‌⁬‎‎​‍⁯⁯⁫‌⁮‎‍⁯‪⁮‌‬​‬⁪‪‫⁪‎‍⁭⁬⁫⁭‍‍⁪⁮‏‍⁬‪‮ = 4;

	// ⁪⁫⁭⁬‍‭​⁬⁫‮⁬‍⁪‮‪⁫‌‌⁭‭⁮‭⁮‍‮‏​‫‮⁯‬⁭​⁮‬‮‬‭‏‍‮
	private const int u206a⁫⁭⁬‍‭​⁬⁫‮⁬‍⁪‮‪⁫‌‌⁭‭⁮‭⁮‍‮‏​‫‮⁯‬⁭​⁮‬‮‬‭‏‍‮ = 5;

	// ‫‬⁫⁭‬‭⁪⁭‬⁮​‪‮​‌‌⁪⁫‮‎⁮‭⁮‭‮‭‍⁫⁬​⁯​‫⁮⁯‫‎⁪⁮⁯‮
	private const float u202b‬⁫⁭‬‭⁪⁭‬⁮​‪‮​‌‌⁪⁫‮‎⁮‭⁮‭‮‭‍⁫⁬​⁯​‫⁮⁯‫‎⁪⁮⁯‮ = 0.99f;

	// ​⁬⁬‮‫⁭⁫‮⁪⁭‍‬‬‏⁭‮‫‍‏⁫‎‪‭⁫⁪‫‍‮‏⁬‪‪‫‫‬⁫‫‫‏‬‮
	private const float u200b⁬⁬‮‫⁭⁫‮⁪⁭‍‬‬‏⁭‮‫‍‏⁫‎‪‭⁫⁪‫‍‮‏⁬‪‪‫‫‬⁫‫‫‏‬‮ = 0.00999999f;

	// ⁪⁫‌⁯‫‪‎‏​‍‌‫⁬‍‬⁬‍⁬⁫‬⁪‫‭‌​‍⁪‮‫‫⁪⁮⁬⁫​‬⁮‫⁫⁫‮
	private UnsafeBuffer u206a⁫‌⁯‫‪‎‏​‍‌‫⁬‍‬⁬‍⁬⁫‬⁪‫‭‌​‍⁪‮‫‫⁪⁮⁬⁫​‬⁮‫⁫⁫‮ = u206f‪​‭‫‭‬‏‌⁯‎‌‫‌⁭‎⁪⁯‭‭‭‮⁫⁫‏⁮⁬⁯‭‮‏‍‮⁮‭⁪‪‫‏‮‮.u206c‏‏‮​‏‪​⁭‏‏‎‪‮‍⁫⁫⁭⁯‏‬‫‫‪⁬‬​⁮⁪‮​⁭⁫‮⁯​⁫⁪⁯⁮‮(16384, 1);

	// ‏‎‎‭⁫⁪‎⁫⁯‏‌⁪‭​‮⁮‮‏‪‪‪‌‪​​⁮‍⁫⁭‍⁫‫‫‌‪‭‏⁫‍⁬‮
	private unsafe byte* u200f‎‎‭⁫⁪‎⁫⁯‏‌⁪‭​‮⁮‮‏‪‪‪‌‪​​⁮‍⁫⁭‍⁫‫‫‌‪‭‏⁫‍⁬‮;

	// ⁯⁫⁮⁬‪‍‏‍​‪⁬​⁭⁬‎‫⁫‪‪‏​‎‪‏‏⁮‪‪‎‍⁮‎‍‎⁮‬​‬‭⁪‮
	private UnsafeBuffer u206f⁫⁮⁬‪‍‏‍​‪⁬​⁭⁬‎‫⁫‪‪‏​‎‪‏‏⁮‪‪‎‍⁮‎‍‎⁮‬​‬‭⁪‮ = u206f‪​‭‫‭‬‏‌⁯‎‌‫‌⁭‎⁪⁯‭‭‭‮⁫⁫‏⁮⁬⁯‭‮‏‍‮⁮‭⁪‪‫‏‮‮.u206c‏‏‮​‏‪​⁭‏‏‎‪‮‍⁫⁫⁭⁯‏‬‫‫‪⁬‬​⁮⁪‮​⁭⁫‮⁯​⁫⁪⁯⁮‮(8192, 1);

	// ⁮‌‬‭⁪‎⁯‮​⁭⁯‌‍⁬⁭‬‍‍‌⁭⁯‌‮⁬‭‬‍⁯‌⁮​⁬‏‎⁪‌⁮‍‌‌‮
	private unsafe byte* u206e‌‬‭⁪‎⁯‮​⁭⁯‌‍⁬⁭‬‍‍‌⁭⁯‌‮⁬‭‬‍⁯‌⁮​⁬‏‎⁪‌⁮‍‌‌‮;

	// ‏‎‍⁬⁯‎‪⁯‏‍‮‮⁫⁬⁯⁬​‫‏‎⁬⁮‮‬⁬​‎‍‌⁫‭⁯‫‬⁭‫⁪‏‍‎‮
	private int[] u200f‎‍⁬⁯‎‪⁯‏‍‮‮⁫⁬⁯⁬​‫‏‎⁬⁮‮‬⁬​‎‍‌⁫‭⁯‫‬⁭‫⁪‏‍‎‮ = new int[32];

	// ‌‎⁬‏‎⁯‏‭‬‌⁮⁬‭‭‭⁭‮‫⁬‪‭‌‭‎‬​‏‬‎‌​‬​⁫‪‭‬‏⁮‎‮
	private int[] u200c‎⁬‏‎⁯‏‭‬‌⁮⁬‭‭‭⁭‮‫⁬‪‭‌‭‎‬​‏‬‎‌​‬​⁫‪‭‬‏⁮‎‮ = new int[16];

	// ‪‮‌‍⁫⁬⁮⁫‎‭‫⁫‫‬‍⁫⁪‌‍⁫⁬⁯​​⁮⁬⁫⁬‏‫‏⁭⁮‌⁬⁬‍​‫‎‮
	private float u202a‮‌‍⁫⁬⁮⁫‎‭‫⁫‫‬‍⁫⁪‌‍⁫⁬⁯​​⁮⁬⁫⁬‏‫‏⁭⁮‌⁬⁬‍​‫‎‮;

	// ‬‭⁫⁪⁪⁫‏⁮‎​‮‌​‍‌‌⁪⁬​‬‪⁭⁪⁯‎⁬‎‮⁭‬⁮‫⁭‍‪‍‏‪‪‌‮
	private readonly sbyte[] u202c‭⁫⁪⁪⁫‏⁮‎​‮‌​‍‌‌⁪⁬​‬‪⁭⁪⁯‎⁬‎‮⁭‬⁮‫⁭‍‪‍‏‪‪‌‮;

	// ‪⁬⁬⁮⁮‭‮⁬‌‬‫‏‬⁯‭⁮‬⁫‭‮⁬‪‌‮⁫‮⁫​‎‪⁫⁮‎‍‮‫⁭⁮‎⁫‮
	private readonly sbyte[] u202a⁬⁬⁮⁮‭‮⁬‌‬‫‏‬⁯‭⁮‬⁫‭‮⁬‪‌‮⁫‮⁫​‎‪⁫⁮‎‍‮‫⁭⁮‎⁫‮;

	// ⁯⁬⁭⁬‫⁬⁮⁪​‎⁯‏⁫‍⁯‮⁫‬‏‌‬‏⁫​‬‎‭‫‏‫⁬‌‭‍‭‬⁪‍‭‏‮
	private readonly sbyte[] u206f⁬⁭⁬‫⁬⁮⁪​‎⁯‏⁫‍⁯‮⁫‬‏‌‬‏⁫​‬‎‭‫‏‫⁬‌‭‍‭‬⁪‍‭‏‮;

	// ⁬‎‫‭⁮‬‏‪‫‬‌⁪‭‏⁭⁭⁫‮‮‌⁬⁮⁭‍‮‌‭‌⁪‎​‎‎‫‬‏‎‮⁭‫‮
	private readonly sbyte[] u206c‎‫‭⁮‬‏‪‫‬‌⁪‭‏⁭⁭⁫‮‮‌⁬⁮⁭‍‮‌‭‌⁪‎​‎‎‫‬‏‎‮⁭‫‮;

	// ​‌‌⁮‎‏⁪‪‭⁬‌‮‎‎‎‪‪​‪‪‎⁫‪⁫‭⁫​‬‌⁮⁯‮‪⁯‎⁪⁪‪‪⁫‮
	private readonly sbyte[] u200b‌‌⁮‎‏⁪‪‭⁬‌‮‎‎‎‪‪​‪‪‎⁫‪⁫‭⁫​‬‌⁮⁯‮‪⁯‎⁪⁪‪‪⁫‮;

	// ‏‬‫‬‌⁯‭⁫‪⁯‏⁯⁪‏‭‬‍‫‬​‬⁯‏‪‬‍‍‎⁫​‬⁬‫​⁯‫⁪‎‭⁬‮
	public void u200f‬‫‬‌⁯‭⁫‪⁯‏⁯⁪‏‭‬‍‫‬​‬⁯‏‪‬‍‍‎⁫​‬⁬‫​⁯‫⁪‎‭⁬‮()
	{
		this.u200f‎‎‭⁫⁪‎⁫⁯‏‌⁪‭​‮⁮‮‏‪‪‪‌‪​​⁮‍⁫⁭‍⁫‫‫‌‪‭‏⁫‍⁬‮ = (byte*)u206f‪​‭‫‭‬‏‌⁯‎‌‫‌⁭‎⁪⁯‭‭‭‮⁫⁫‏⁮⁬⁯‭‮‏‍‮⁮‭⁪‪‫‏‮‮.u202b⁪‍⁭⁯⁭⁬⁫⁭⁭‮⁫⁭⁬⁭⁫‎‏⁪‎‎‌⁫‪‫‭⁭⁬⁮‎⁫‪‮‫⁫‪‎‫‏‮‮(this.u206a⁫‌⁯‫‪‎‏​‍‌‫⁬‍‬⁬‍⁬⁫‬⁪‫‭‌​‍⁪‮‫‫⁪⁮⁬⁫​‬⁮‫⁫⁫‮);
	Label0:
		int num = -1035397648;
		while (true)
		{
			int num1 = num ^ -955606474;
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
					this.u206e‌‬‭⁪‎⁯‮​⁭⁯‌‍⁬⁭‬‍‍‌⁭⁯‌‮⁬‭‬‍⁯‌⁮​⁬‏‎⁪‌⁮‍‌‌‮ = (byte*)u206f‪​‭‫‭‬‏‌⁯‎‌‫‌⁭‎⁪⁯‭‭‭‮⁫⁫‏⁮⁬⁯‭‮‏‍‮⁮‭⁪‪‫‏‮‮.u202b⁪‍⁭⁯⁭⁬⁫⁭⁭‮⁫⁭⁬⁭⁫‎‏⁪‎‎‌⁫‪‫‭⁭⁬⁮‎⁫‪‮‫⁫‪‎‫‏‮‮(this.u206f⁫⁮⁬‪‍‏‍​‪⁬​⁭⁬‎‫⁫‪‪‏​‎‪‏‏⁮‪‪‎‍⁮‎‍‎⁮‬​‬‭⁪‮);
					num = (int)(num2 * 773832122 ^ 967706081);
					continue;
				}
			}
		}
	}

	// ⁮⁪‎‭‬‮⁫‏⁪‍‌‎⁫⁯⁮⁯​‫⁫‬⁪‪‬‬‌‏⁭‫‍⁫‎‌‏⁬‏⁬⁬‫⁭⁪‮
	public unsafe float u206e⁪‎‭‬‮⁫‏⁪‍‌‎⁫⁯⁮⁯​‫⁫‬⁪‪‬‬‌‏⁭‫‍⁫‎‌‏⁬‏⁬⁬‫⁭⁪‮(sbyte* , byte* , int )
	{
		// 
		// Current member / type: System.Single ⁯‪​‭‫‭‬‏‌⁯‎‌‫‌⁭‎⁪⁯‭‭‭‮⁫⁫‏⁮⁬⁯‭‮‏‍‮⁮‭⁪‪‫‏‮‮::⁮⁪‎‭‬‮⁫‏⁪‍‌‎⁫⁯⁮⁯​‫⁫‬⁪‪‬‬‌‏⁭‫‍⁫‎‌‏⁬‏⁬⁬‫⁭⁪‮(System.SByte*,System.Byte*,System.Int32)
		// File path: C:\SDRSharp\Plugins\Tetra\SDRSharp.Tetra.dll
		// 
		// Product version: 0.0.0.0
		// Exception in: System.Single ⁮⁪‎‭‬‮⁫‏⁪‍‌‎⁫⁯⁮⁯​‫⁫‬⁪‪‬‬‌‏⁭‫‍⁫‎‌‏⁬‏⁬⁬‫⁭⁪‮(System.SByte*,System.Byte*,System.Int32)
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

	// ‫⁪‍⁭⁯⁭⁬⁫⁭⁭‮⁫⁭⁬⁭⁫‎‏⁪‎‎‌⁫‪‫‭⁭⁬⁮‎⁫‪‮‫⁫‪‎‫‏‮‮
	// privatescope
	internal static unsafe void* u202b⁪‍⁭⁯⁭⁬⁫⁭⁭‮⁫⁭⁬⁭⁫‎‏⁪‎‎‌⁫‪‫‭⁭⁬⁮‎⁫‪‮‫⁫‪‎‫‏‮‮(UnsafeBuffer unsafeBuffer)
	{
		return unsafeBuffer;
	}

	// ⁬‏‏‮​‏‪​⁭‏‏‎‪‮‍⁫⁫⁭⁯‏‬‫‫‪⁬‬​⁮⁪‮​⁭⁫‮⁯​⁫⁪⁯⁮‮
	// privatescope
	internal static UnsafeBuffer u206c‏‏‮​‏‪​⁭‏‏‎‪‮‍⁫⁫⁭⁯‏‬‫‫‪⁬‬​⁮⁪‮​⁭⁫‮⁯​⁫⁪⁯⁮‮(int num, int num)
	{
		return UnsafeBuffer.Create(num, num);
	}

	// ‪‍‍‎⁮‌⁫‍‭‏⁫⁯‎‌‭⁫​​‍⁬‍‭⁬⁮⁬‪⁬⁭⁭‬‌⁪‮‪⁬⁬‍‪⁯‪‮
	// privatescope
	internal static void u202a‍‍‎⁮‌⁫‍‭‏⁫⁯‎‌‭⁫​​‍⁬‍‭⁬⁮⁬‪⁬⁭⁭‬‌⁪‮‪⁬⁬‍‪⁯‪‮(Array , RuntimeFieldHandle )
	{
		// 
		// Current member / type: System.Void ⁯‪​‭‫‭‬‏‌⁯‎‌‫‌⁭‎⁪⁯‭‭‭‮⁫⁫‏⁮⁬⁯‭‮‏‍‮⁮‭⁪‪‫‏‮‮::‪‍‍‎⁮‌⁫‍‭‏⁫⁯‎‌‭⁫​​‍⁬‍‭⁬⁮⁬‪⁬⁭⁭‬‌⁪‮‪⁬⁬‍‪⁯‪‮(System.Array,System.RuntimeFieldHandle)
		// File path: C:\SDRSharp\Plugins\Tetra\SDRSharp.Tetra.dll
		// 
		// Product version: 0.0.0.0
		// Exception in: System.Void ‪‍‍‎⁮‌⁫‍‭‏⁫⁯‎‌‭⁫​​‍⁬‍‭⁬⁮⁬‪⁬⁭⁭‬‌⁪‮‪⁬⁬‍‪⁯‪‮(System.Array,System.RuntimeFieldHandle)
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

	public u206f‪​‭‫‭‬‏‌⁯‎‌‫‌⁭‎⁪⁯‭‭‭‮⁫⁫‏⁮⁬⁯‭‮‏‍‮⁮‭⁪‪‫‏‮‮()
	{
		this.u206a⁫‌⁯‫‪‎‏​‍‌‫⁬‍‬⁬‍⁬⁫‬⁪‫‭‌​‍⁪‮‫‫⁪⁮⁬⁫​‬⁮‫⁫⁫‮ = u206f‪​‭‫‭‬‏‌⁯‎‌‫‌⁭‎⁪⁯‭‭‭‮⁫⁫‏⁮⁬⁯‭‮‏‍‮⁮‭⁪‪‫‏‮‮.u206c‏‏‮​‏‪​⁭‏‏‎‪‮‍⁫⁫⁭⁯‏‬‫‫‪⁬‬​⁮⁪‮​⁭⁫‮⁯​⁫⁪⁯⁮‮(16384, 1);
		this.u206f⁫⁮⁬‪‍‏‍​‪⁬​⁭⁬‎‫⁫‪‪‏​‎‪‏‏⁮‪‪‎‍⁮‎‍‎⁮‬​‬‭⁪‮ = u206f‪​‭‫‭‬‏‌⁯‎‌‫‌⁭‎⁪⁯‭‭‭‮⁫⁫‏⁮⁬⁯‭‮‏‍‮⁮‭⁪‪‫‏‮‮.u206c‏‏‮​‏‪​⁭‏‏‎‪‮‍⁫⁫⁭⁯‏‬‫‫‪⁬‬​⁮⁪‮​⁭⁫‮⁯​⁫⁪⁯⁮‮(8192, 1);
		this.u200f‎‍⁬⁯‎‪⁯‏‍‮‮⁫⁬⁯⁬​‫‏‎⁬⁮‮‬⁬​‎‍‌⁫‭⁯‫‬⁭‫⁪‏‍‎‮ = new int[32];
		this.u200c‎⁬‏‎⁯‏‭‬‌⁮⁬‭‭‭⁭‮‫⁬‪‭‌‭‎‬​‏‬‎‌​‬​⁫‪‭‬‏⁮‎‮ = new int[16];
		sbyte[] numArray = new sbyte[32];
		u206f‪​‭‫‭‬‏‌⁯‎‌‫‌⁭‎⁪⁯‭‭‭‮⁫⁫‏⁮⁬⁯‭‮‏‍‮⁮‭⁪‪‫‏‮‮.u202a‍‍‎⁮‌⁫‍‭‏⁫⁯‎‌‭⁫​​‍⁬‍‭⁬⁮⁬‪⁬⁭⁭‬‌⁪‮‪⁬⁬‍‪⁯‪‮((Array)numArray, typeof(u206e⁭⁬‬‬‎⁮⁪⁯‫‮⁮‍⁭‍‬⁭⁪‏⁮⁭⁫⁪⁬⁯‍⁮⁭‎⁬‪‌⁫⁭⁮‫‍‮‏‭‮).GetField("4810D7A0AE5122B64456B2BD21E79F883C902EAF").FieldHandle);
		this.u202c‭⁫⁪⁪⁫‏⁮‎​‮‌​‍‌‌⁪⁬​‬‪⁭⁪⁯‎⁬‎‮⁭‬⁮‫⁭‍‪‍‏‪‪‌‮ = numArray;
		sbyte[] numArray1 = new sbyte[32];
		u206f‪​‭‫‭‬‏‌⁯‎‌‫‌⁭‎⁪⁯‭‭‭‮⁫⁫‏⁮⁬⁯‭‮‏‍‮⁮‭⁪‪‫‏‮‮.u202a‍‍‎⁮‌⁫‍‭‏⁫⁯‎‌‭⁫​​‍⁬‍‭⁬⁮⁬‪⁬⁭⁭‬‌⁪‮‪⁬⁬‍‪⁯‪‮((Array)numArray1, typeof(u206e⁭⁬‬‬‎⁮⁪⁯‫‮⁮‍⁭‍‬⁭⁪‏⁮⁭⁫⁪⁬⁯‍⁮⁭‎⁬‪‌⁫⁭⁮‫‍‮‏‭‮).GetField("CAEB95AC6245F1E7723B7B4B8F23EA61D79DB6FF").FieldHandle);
		this.u202a⁬⁬⁮⁮‭‮⁬‌‬‫‏‬⁯‭⁮‬⁫‭‮⁬‪‌‮⁫‮⁫​‎‪⁫⁮‎‍‮‫⁭⁮‎⁫‮ = numArray1;
		sbyte[] numArray2 = new sbyte[32];
		u206f‪​‭‫‭‬‏‌⁯‎‌‫‌⁭‎⁪⁯‭‭‭‮⁫⁫‏⁮⁬⁯‭‮‏‍‮⁮‭⁪‪‫‏‮‮.u202a‍‍‎⁮‌⁫‍‭‏⁫⁯‎‌‭⁫​​‍⁬‍‭⁬⁮⁬‪⁬⁭⁭‬‌⁪‮‪⁬⁬‍‪⁯‪‮((Array)numArray2, typeof(u206e⁭⁬‬‬‎⁮⁪⁯‫‮⁮‍⁭‍‬⁭⁪‏⁮⁭⁫⁪⁬⁯‍⁮⁭‎⁬‪‌⁫⁭⁮‫‍‮‏‭‮).GetField("CB1696D02103B8CABF89431CF13742DD9531E631").FieldHandle);
		this.u206f⁬⁭⁬‫⁬⁮⁪​‎⁯‏⁫‍⁯‮⁫‬‏‌‬‏⁫​‬‎‭‫‏‫⁬‌‭‍‭‬⁪‍‭‏‮ = numArray2;
		sbyte[] numArray3 = new sbyte[32];
		u206f‪​‭‫‭‬‏‌⁯‎‌‫‌⁭‎⁪⁯‭‭‭‮⁫⁫‏⁮⁬⁯‭‮‏‍‮⁮‭⁪‪‫‏‮‮.u202a‍‍‎⁮‌⁫‍‭‏⁫⁯‎‌‭⁫​​‍⁬‍‭⁬⁮⁬‪⁬⁭⁭‬‌⁪‮‪⁬⁬‍‪⁯‪‮((Array)numArray3, typeof(u206e⁭⁬‬‬‎⁮⁪⁯‫‮⁮‍⁭‍‬⁭⁪‏⁮⁭⁫⁪⁬⁯‍⁮⁭‎⁬‪‌⁫⁭⁮‫‍‮‏‭‮).GetField("1EDB89BD91F8FA1DD3BD3C5494961BA980884172").FieldHandle);
		this.u206c‎‫‭⁮‬‏‪‫‬‌⁪‭‏⁭⁭⁫‮‮‌⁬⁮⁭‍‮‌‭‌⁪‎​‎‎‫‬‏‎‮⁭‫‮ = numArray3;
		sbyte[] numArray4 = new sbyte[5];
		u206f‪​‭‫‭‬‏‌⁯‎‌‫‌⁭‎⁪⁯‭‭‭‮⁫⁫‏⁮⁬⁯‭‮‏‍‮⁮‭⁪‪‫‏‮‮.u202a‍‍‎⁮‌⁫‍‭‏⁫⁯‎‌‭⁫​​‍⁬‍‭⁬⁮⁬‪⁬⁭⁭‬‌⁪‮‪⁬⁬‍‪⁯‪‮((Array)numArray4, typeof(u206e⁭⁬‬‬‎⁮⁪⁯‫‮⁮‍⁭‍‬⁭⁪‏⁮⁭⁫⁪⁬⁯‍⁮⁭‎⁬‪‌⁫⁭⁮‫‍‮‏‭‮).GetField("393B2B1DC7BB85C0680DE33B2348DC302E018658").FieldHandle);
		this.u200b‌‌⁮‎‏⁪‪‭⁬‌‮‎‎‎‪‪​‪‪‎⁫‪⁫‭⁫​‬‌⁮⁯‮‪⁯‎⁪⁪‪‪⁫‮ = numArray4;
		base();
	}
}