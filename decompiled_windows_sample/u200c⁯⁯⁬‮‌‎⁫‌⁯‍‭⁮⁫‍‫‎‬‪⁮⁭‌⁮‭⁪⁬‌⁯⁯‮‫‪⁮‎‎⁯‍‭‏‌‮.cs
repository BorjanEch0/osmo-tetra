using SDRSharp.Radio;
using System;

// ‌⁯⁯⁬‮‌‎⁫‌⁯‍‭⁮⁫‍‫‎‬‪⁮⁭‌⁮‭⁪⁬‌⁯⁯‮‫‪⁮‎‎⁯‍‭‏‌‮
internal class u200c⁯⁯⁬‮‌‎⁫‌⁯‍‭⁮⁫‍‫‎‬‪⁮⁭‌⁮‭⁪⁬‌⁯⁯‮‫‪⁮‎‎⁯‍‭‏‌‮
{
	// ‪‍⁪​‌‌‏⁬⁫‭​⁬​‏‭‪⁮⁭⁮‬‏‭‭⁮‮‎​⁮‎‍⁯⁫​⁫‭‮⁯‭⁬‮
	private readonly unsafe IirFilter* u202a‍⁪​‌‌‏⁬⁫‭​⁬​‏‭‪⁮⁭⁮‬‏‭‭⁮‮‎​⁮‎‍⁯⁫​⁫‭‮⁯‭⁬‮;

	// ​‪‪⁪‎‎‎‮‌‎‬​⁮‭‎‭‏‬‎‫⁮‎⁯‏‎⁭⁯‍⁫‌⁯‮⁫⁯‎⁬‮‬‭‪‮
	private readonly UnsafeBuffer u200b‪‪⁪‎‎‎‮‌‎‬​⁮‭‎‭‏‬‎‫⁮‎⁯‏‎⁭⁯‍⁫‌⁯‮⁫⁯‎⁬‮‬‭‪‮;

	// ‭‫‮‪‪​‏‮⁮‪‎⁭⁬‏‍‌‌‍‏‏‎‍​‌‮​‎‏‪⁮‎⁫‍‮​⁬‎⁫⁬‪‮
	private UnsafeBuffer u202d‫‮‪‪​‏‮⁮‪‎⁭⁬‏‍‌‌‍‏‏‎‍​‌‮​‎‏‪⁮‎⁫‍‮​⁬‎⁫⁬‪‮;

	// ⁪‌⁪‏‭‬‏⁪‫⁯⁪⁪‍​⁬‬⁬⁭‏‍‎‫⁬⁬⁭‫‫⁯‬‮⁬​⁭⁫‏‏⁬‬⁬‮
	private unsafe float* u206a‌⁪‏‭‬‏⁪‫⁯⁪⁪‍​⁬‬⁬⁭‏‍‎‫⁬⁬⁭‫‫⁯‬‮⁬​⁭⁫‏‏⁬‬⁬‮;

	// ‭‫‍‎‫‫​‭‭‏⁭‌⁮⁫‮⁭‏⁭‫‬‎⁬‍‫⁪‮‫⁬‮‌‭‮‫⁪‮‍⁭‍‪⁮‮
	private UnsafeBuffer u202d‫‍‎‫‫​‭‭‏⁭‌⁮⁫‮⁭‏⁭‫‬‎⁬‍‫⁪‮‫⁬‮‌‭‮‫⁪‮‍⁭‍‪⁮‮;

	// ⁬⁯⁯‭⁮⁬‌⁯‫‭​‮‪⁪⁯‎‎‏⁯‮‬⁯​‮⁪⁯⁬⁭‌‬‮​⁭​‫‍⁭‎‭⁭‮
	private unsafe Complex* u206c⁯⁯‭⁮⁬‌⁯‫‭​‮‪⁪⁯‎‎‏⁯‮‬⁯​‮⁪⁯⁬⁭‌‬‮​⁭​‫‍⁭‎‭⁭‮;

	// ‌⁮‫‮⁪‮⁬‌⁯‍‫‍⁬⁯⁬‭‍⁫‬‭‍​⁭‌‏‫⁬‌‌⁬‍‌‬‮‮‍⁫⁬⁫‭‮
	private FirFilter u200c⁮‫‮⁪‮⁬‌⁯‍‫‍⁬⁯⁬‭‍⁫‬‭‍​⁭‌‏‫⁬‌‌⁬‍‌‬‮‮‍⁫⁬⁫‭‮;

	// ‮⁮⁯‬⁭⁯‮⁬‪‫⁫‍⁯⁪‬‭‏⁮​‌‌‍‭⁯‌‬‌‍⁬‭⁪‪​​‍‭‪‏‪‌‮
	private IQFirFilter u202e⁮⁯‬⁭⁯‮⁬‪‫⁫‍⁯⁪‬‭‏⁮​‌‌‍‭⁯‌‬‌‍⁬‭⁪‪​​‍‭‪‏‪‌‮;

	// ‏‪​⁭‌‬‫⁮⁫​‪‮‪‮​‬‮⁬‍‫‪⁪⁭⁮⁪‍⁫⁮⁮‭⁭‫⁫‭‭⁯‏‏‎⁫‮
	private Complex u200f‪​⁭‌‬‫⁮⁫​‪‮‪‮​‬‮⁬‍‫‪⁪⁭⁮⁪‍⁫⁮⁮‭⁭‫⁫‭‭⁯‏‏‎⁫‮;

	// ‫‎​⁮⁮‬⁭‏‮⁬‮‪‍‭⁪⁭⁮⁭‬⁮⁫‪⁬⁬‏⁮‌⁫⁭⁮‫‎‭‏⁭⁫​⁪⁪‎‮
	private bool u202b‎​⁮⁮‬⁭‏‮⁬‮‪‍‭⁪⁭⁮⁭‬⁮⁫‪⁬⁬‏⁮‌⁫⁭⁮‫‎‭‏⁭⁫​⁪⁪‎‮;

	// ‌​⁪‎‮‮‬‫‪⁪‬⁪‬⁭‪‍​‮‎‭‭‎‎⁯‪⁪‍⁭‍‫⁮‎⁫‮‌‎‬‍⁯‭‮
	private bool u200c​⁪‎‮‮‬‫‪⁪‬⁪‬⁭‪‍​‮‎‭‭‎‎⁯‪⁪‍⁭‍‫⁮‎⁫‮‌‎‬‍⁯‭‮;

	// ⁪⁪⁫⁯‬‫​‫‬⁮‬⁭‪⁭⁮⁮‮⁭‬⁭⁪⁮⁮‎⁪‫⁭⁫‍‬‎​‪⁬⁯‪​⁪‎⁯‮
	private float u206a⁪⁫⁯‬‫​‫‬⁮‬⁭‪⁭⁮⁮‮⁭‬⁭⁪⁮⁮‎⁪‫⁭⁫‍‬‎​‪⁬⁯‪​⁪‎⁯‮;

	// ‭⁫‪⁪‎‪‬⁪‍‌‎​‎⁮‫​⁯​⁭‏‪⁭‪⁪⁭‍‬‍‬⁮⁯⁫‪‪⁬⁪‎‏‬‫‮
	private double u202d⁫‪⁪‎‪‬⁪‍‌‎​‎⁮‫​⁯​⁭‏‪⁭‪⁪⁭‍‬‍‬⁮⁯⁫‪‪⁬⁪‎‏‬‫‮;

	// ‬​⁭‍⁫‪⁮‪‪‫‌‪⁫‌‎‏‮⁭‍⁬‭‍⁭‍‭⁬⁮​⁬‫‭‎‪⁮‏‪‌‫⁬⁭‮
	private int u202c​⁭‍⁫‪⁮‪‪‫‌‪⁫‌‎‏‮⁭‍⁬‭‍⁭‍‭⁬⁮​⁬‫‭‎‪⁮‏‪‌‫⁬⁭‮;

	// ⁬‬‫‮⁫‏⁮⁮⁯‏​⁫‫​​‬‪⁪‌‏⁫⁬⁪⁬⁮‮⁭⁫‭‍⁫‍‫‌‌‬⁭‮​‌‮
	private int u206c‬‫‮⁫‏⁮⁮⁯‏​⁫‫​​‬‪⁪‌‏⁫⁬⁪⁬⁮‮⁭⁫‭‍⁫‍‫‌‌‬⁭‮​‌‮;

	// ‬⁬‬⁫‪‭⁬‮‌‎⁯‮‪⁯‬‫‮‭‬​⁪​‎‪⁫⁮‭‌⁭‮‍⁭‭⁯‮‫‌⁮‎‪‮
	private Complex u202c⁬‬⁫‪‭⁬‮‌‎⁯‮‪⁯‬‫‮‭‬​⁪​‎‪⁫⁮‭‌⁭‮‍⁭‭⁯‮‫‌⁮‎‪‮;

	// ⁮‮‎‫‍⁬‏‪‫⁫⁯⁯‎‭‫‭⁯⁮‎‎⁭⁪‭‪​‭‭⁯‬‎⁬⁫⁯‫‬‫⁯‏‭‪‮
	public unsafe int u206e‮‎‫‍⁬‏‪‫⁫⁯⁯‎‭‫‭⁯⁮‎‎⁭⁪‭‪​‭‭⁯‬‎⁬⁫⁯‫‬‫⁯‏‭‪‮(Complex* , double , int , float* )
	{
		// 
		// Current member / type: System.Int32 ‌⁯⁯⁬‮‌‎⁫‌⁯‍‭⁮⁫‍‫‎‬‪⁮⁭‌⁮‭⁪⁬‌⁯⁯‮‫‪⁮‎‎⁯‍‭‏‌‮::⁮‮‎‫‍⁬‏‪‫⁫⁯⁯‎‭‫‭⁯⁮‎‎⁭⁪‭‪​‭‭⁯‬‎⁬⁫⁯‫‬‫⁯‏‭‪‮(SDRSharp.Radio.Complex*,System.Double,System.Int32,System.Single*)
		// File path: C:\SDRSharp\Plugins\Tetra\SDRSharp.Tetra.dll
		// 
		// Product version: 0.0.0.0
		// Exception in: System.Int32 ⁮‮‎‫‍⁬‏‪‫⁫⁯⁯‎‭‫‭⁯⁮‎‎⁭⁪‭‪​‭‭⁯‬‎⁬⁫⁯‫‬‫⁯‏‭‪‮(SDRSharp.Radio.Complex*,System.Double,System.Int32,System.Single*)
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

	// ‏‬‏‌‌⁭⁫⁪‎⁯⁮‮⁭⁭‏‬‭‬‭‍⁬⁭⁯⁭‮‮‎‎‎‌‫⁯⁬‎​⁪⁮‮​⁯‮
	// privatescope
	internal static UnsafeBuffer u200f‬‏‌‌⁭⁫⁪‎⁯⁮‮⁭⁭‏‬‭‬‭‍⁬⁭⁯⁭‮‮‎‎‎‌‫⁯⁬‎​⁪⁮‮​⁯‮(int num)
	{
		return UnsafeBuffer.Create(num);
	}

	// ‍⁪‏​⁮‏⁪‭​⁬⁯⁭‍‍‌‎‮‍⁭​‎⁯‬⁯⁭‫⁫‌‎‍⁭⁭‫⁬‬‭‭⁭⁬⁪‮
	// privatescope
	internal static unsafe void* u200d⁪‏​⁮‏⁪‭​⁬⁯⁭‍‍‌‎‮‍⁭​‎⁯‬⁯⁭‫⁫‌‎‍⁭⁭‫⁬‬‭‭⁭⁬⁪‮(UnsafeBuffer unsafeBuffer)
	{
		return unsafeBuffer;
	}

	// ⁪‭⁪‎‍⁭‎‎‪‬⁪⁮‌⁬⁮‪‪‪⁫‍⁬‪‮‮‌⁫⁫⁮⁯⁫⁫‪⁮‍‏⁪‍‪‌⁯‮
	// privatescope
	internal static UnsafeBuffer u206a‭⁪‎‍⁭‎‎‪‬⁪⁮‌⁬⁮‪‪‪⁫‍⁬‪‮‮‌⁫⁫⁮⁯⁫⁫‪⁮‍‏⁪‍‪‌⁯‮(int num, int num)
	{
		return UnsafeBuffer.Create(num, num);
	}

	// ‬‬‌⁫​⁫‏⁮​‍⁫‎‬‍‭​‬‬‎⁪⁭‫⁮‏⁮‪⁯‪⁫‫‏‎⁮⁬‍⁫‭⁯‌‏‮
	// privatescope
	internal static int u202c‬‌⁫​⁫‏⁮​‍⁫‎‬‍‭​‬‬‎⁪⁭‫⁮‏⁮‪⁯‪⁫‫‏‎⁮⁬‍⁫‭⁯‌‏‮(int num, int num)
	{
		return Math.Max(num, num);
	}

	// ⁭⁫⁫‫‭⁯‮⁭⁬⁬‪‍⁪⁫‮‫⁮‪‌⁯‌⁫‌‌​⁪⁯‫‭‌⁮‌‬⁪‬‏⁪‪⁪⁪‮
	// privatescope
	internal static float[] u206d⁫⁫‫‭⁯‮⁭⁬⁬‪‍⁪⁫‮‫⁮‪‌⁯‌⁫‌‌​⁪⁯‫‭‌⁮‌‬⁪‬‏⁪‪⁪⁪‮(double num, double num, int num)
	{
		return FilterBuilder.MakeSinc(num, num, num);
	}

	// ‎‏‎⁯‭‭‌‏⁯⁪‮⁬‍‌‍‭‬⁯‫⁫‬⁪‍⁫⁯‌‬‭‭‏⁫‎⁪‎⁫‭⁬⁭⁭⁯‮
	// privatescope
	internal static FirFilter u200e‏‎⁯‭‭‌‏⁯⁪‮⁬‍‌‍‭‬⁯‫⁫‬⁪‍⁫⁯‌‬‭‭‏⁫‎⁪‎⁫‭⁬⁭⁭⁯‮(float[] singleArray, int num)
	{
		return new FirFilter(singleArray, num);
	}

	// ‭‭⁫‎⁭‌​‫⁪⁯⁪⁮‎‎‎‬⁬‬‬⁪‪‮‎⁪⁬⁮⁭​‍​‭‮‍⁬‏​‍‬​⁫‮
	// privatescope
	internal static IQFirFilter u202d‭⁫‎⁭‌​‫⁪⁯⁪⁮‎‎‎‬⁬‬‬⁪‪‮‎⁪⁬⁮⁭​‍​‭‮‍⁬‏​‍‬​⁫‮(float[] singleArray, int num)
	{
		return new IQFirFilter(singleArray, num);
	}

	// ⁯‮⁫‪‌‭‭‍‏⁮‮‬⁫‮⁪‏⁫‬‍‏⁫⁮‌⁪⁭⁭‮⁮‍⁯⁭‮⁫‏‎⁪⁮‎‏‪‮
	// privatescope
	internal static unsafe void* u206f‮⁫‪‌‭‭‍‏⁮‮‬⁫‮⁪‏⁫‬‍‏⁫⁮‌⁪⁭⁭‮⁮‍⁯⁭‮⁫‏‎⁪⁮‎‏‪‮(void* voidPointer, void* voidPointer, int num)
	{
		return Utils.Memcpy(voidPointer, voidPointer, num);
	}

	// ‪‭‬‬⁬‮‎‍‏‪‮‍⁭‎‪⁪‌⁬​‪‬‎‭‎⁯⁭‭⁭‭‌⁫⁯‍⁫⁬⁬‮‍⁬⁪‮
	// privatescope
	internal static unsafe int u202a‭‬‬⁬‮‎‍‏‪‮‍⁭‎‪⁪‌⁬​‪‬‎‭‎⁯⁭‭⁭‭‌⁫⁯‍⁫⁬⁬‮‍⁬⁪‮(IQFirFilter qFirFilter, Complex* complexPointer, int num)
	{
		return qFirFilter.Process(complexPointer, num);
	}

	// ⁭‬⁮‬⁮⁬⁪‎⁯‏‎⁮​‌‎⁫‭​⁪‭⁮‍‎‬‫⁫‏⁬⁫‭⁯‪⁪‌⁮‌‮‬‫‭‮
	// privatescope
	internal static float u206d‬⁮‬⁮⁬⁪‎⁯‏‎⁮​‌‎⁫‭​⁪‭⁮‍‎‬‫⁫‏⁬⁫‭⁯‪⁪‌⁮‌‮‬‫‭‮(float single)
	{
		return Math.Abs(single);
	}

	// ‎⁬‮‫‫‮​⁮⁫‎‭​‍‏‍‌‍⁯⁬⁭​⁯⁪‫⁭‌‮‍‏⁬⁬‎⁯‍⁫‬‎‎‫⁮‮
	// privatescope
	internal static unsafe int u200e⁬‮‫‫‮​⁮⁫‎‭​‍‏‍‌‍⁯⁬⁭​⁯⁪‫⁭‌‮‍‏⁬⁬‎⁯‍⁫‬‎‎‫⁮‮(FirFilter firFilter, float* singlePointer, int num)
	{
		return firFilter.Process(singlePointer, num);
	}

	public u200c⁯⁯⁬‮‌‎⁫‌⁯‍‭⁮⁫‍‫‎‬‪⁮⁭‌⁮‭⁪⁬‌⁯⁯‮‫‪⁮‎‎⁯‍‭‏‌‮()
	{
		this.u200b‪‪⁪‎‎‎‮‌‎‬​⁮‭‎‭‏‬‎‫⁮‎⁯‏‎⁭⁯‍⁫‌⁯‮⁫⁯‎⁬‮‬‭‪‮ = u200c⁯⁯⁬‮‌‎⁫‌⁯‍‭⁮⁫‍‫‎‬‪⁮⁭‌⁮‭⁪⁬‌⁯⁯‮‫‪⁮‎‎⁯‍‭‏‌‮.u200f‬‏‌‌⁭⁫⁪‎⁯⁮‮⁭⁭‏‬‭‬‭‍⁬⁭⁯⁭‮‮‎‎‎‌‫⁯⁬‎​⁪⁮‮​⁯‮((int)sizeof(IirFilter));
		this.u202a‍⁪​‌‌‏⁬⁫‭​⁬​‏‭‪⁮⁭⁮‬‏‭‭⁮‮‎​⁮‎‍⁯⁫​⁫‭‮⁯‭⁬‮ = (IirFilter*)u200c⁯⁯⁬‮‌‎⁫‌⁯‍‭⁮⁫‍‫‎‬‪⁮⁭‌⁮‭⁪⁬‌⁯⁯‮‫‪⁮‎‎⁯‍‭‏‌‮.u200d⁪‏​⁮‏⁪‭​⁬⁯⁭‍‍‌‎‮‍⁭​‎⁯‬⁯⁭‫⁫‌‎‍⁭⁭‫⁬‬‭‭⁭⁬⁪‮(this.u200b‪‪⁪‎‎‎‮‌‎‬​⁮‭‎‭‏‬‎‫⁮‎⁯‏‎⁭⁯‍⁫‌⁯‮⁫⁯‎⁬‮‬‭‪‮);
	}
}