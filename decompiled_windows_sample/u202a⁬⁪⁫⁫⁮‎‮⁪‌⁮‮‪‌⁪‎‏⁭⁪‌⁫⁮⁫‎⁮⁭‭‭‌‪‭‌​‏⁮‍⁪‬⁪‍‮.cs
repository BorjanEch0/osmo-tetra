using SDRSharp.Radio;
using SDRSharp.Tetra;
using System;
using System.Runtime.CompilerServices;

// ‪⁬⁪⁫⁫⁮‎‮⁪‌⁮‮‪‌⁪‎‏⁭⁪‌⁫⁮⁫‎⁮⁭‭‭‌‪‭‌​‏⁮‍⁪‬⁪‍‮
internal class u202a⁬⁪⁫⁫⁮‎‮⁪‌⁮‮‪‌⁪‎‏⁭⁪‌⁫⁮⁫‎⁮⁭‭‭‌‪‭‌​‏⁮‍⁪‬⁪‍‮
{
	// ‎⁪⁫⁮‍‍⁪​​⁬‎‍⁬⁬‪​⁬‫‏‌‭‬⁫‎‏‬‮‌‭​⁫‍⁫⁪‎‬‬​‮⁪‮
	private u200b‭​‮⁫‌​​‌⁯‫‫‬‫‌‍⁪⁫‍‍⁮⁭⁭‪‌⁫‫‌⁫⁭‬‮‎‬‍‫‎⁭‏⁬‮ u200e⁪⁫⁮‍‍⁪​​⁬‎‍⁬⁬‪​⁬‫‏‌‭‬⁫‎‏‬‮‌‭​⁫‍⁫⁪‎‬‬​‮⁪‮;

	// ⁪‌​⁮​⁬⁫​‍⁪‬‫⁮‭⁫⁮‭⁭⁬⁯‎⁯⁫‭‏⁮‫‭‫⁬​‍‍⁮‭‎​‮⁪‎‮
	private u200e‮‭‌‏⁫⁬‌‪‌‌‌‭‫⁯⁯‮⁬‎⁬⁪‍‏‬​⁯‍‭‭⁭‍‎⁬⁭⁮⁮‫‭‍⁬‮ u206a‌​⁮​⁬⁫​‍⁪‬‫⁮‭⁫⁮‭⁭⁬⁯‎⁯⁫‭‏⁮‫‭‫⁬​‍‍⁮‭‎​‮⁪‎‮;

	// ‍⁯‮‬‬‫‫‮​⁮⁪‎‌‌⁮⁭‏‏‪‎‌‍‍‫⁪⁮​‏‌‬‌⁬⁬‍‫‌⁪‍⁬⁭‮
	private u202e‫‏‎‎‫⁮⁭‮⁭⁮‬⁭‍⁮​⁮⁯‪⁬‭‭​‬⁯‫‭‬‫​⁫⁮⁯‫⁯‏⁮⁪⁫‮‮ u200d⁯‮‬‬‫‫‮​⁮⁪‎‌‌⁮⁭‏‏‪‎‌‍‍‫⁪⁮​‏‌‬‌⁬⁬‍‫‌⁪‍⁬⁭‮;

	// ⁬⁬‌‭‌‌⁯‭⁫⁯‪⁭‌‮‎‪‪⁮‫⁭​⁫‫⁭‪​⁫‏⁪⁫⁯⁪‮‭⁬​⁯‍‏⁯‮
	private u206b⁯⁫⁮​⁪‮‫‮​‪‍‪⁬⁪⁭‮‬‍⁬‌‍​⁬‍‎‫‏‬⁯‏‎⁫‏⁫​‍‮‎‭‮ u206c⁬‌‭‌‌⁯‭⁫⁯‪⁭‌‮‎‪‪⁮‫⁭​⁫‫⁭‪​⁫‏⁪⁫⁯⁪‮‭⁬​⁯‍‏⁯‮;

	// ⁫‬‮⁫‏‍‫‍⁫‮⁮⁭⁮‎⁬⁬⁪‬‬⁪⁬‬‌‫⁪⁭⁭⁪‎‌‮⁯‪‏‪‬‏⁮‬‭‮
	private u206b‌⁮‪‪⁫‭⁮⁮⁭‭‮⁯⁭‬‍‫‭‪⁮⁫‌‫⁪‬‮⁬‏‍⁯‭⁬‫‍⁪‏​⁬⁮‌‮ u206b‬‮⁫‏‍‫‍⁫‮⁮⁭⁮‎⁬⁬⁪‬‬⁪⁬‬‌‫⁪⁭⁭⁪‎‌‮⁯‪‏‪‬‏⁮‬‭‮;

	// ⁪‪‬‭⁭‍⁯‌⁯⁭⁯‍‭‪⁬​​‪⁪‏‏‍‌‬‎‪⁮⁪‏‌​⁭⁫‫⁫‍⁮⁭⁭‬‮
	private u206f‪​‭‫‭‬‏‌⁯‎‌‫‌⁭‎⁪⁯‭‭‭‮⁫⁫‏⁮⁬⁯‭‮‏‍‮⁮‭⁪‪‫‏‮‮ u206a‪‬‭⁭‍⁯‌⁯⁭⁯‍‭‪⁬​​‪⁪‏‏‍‌‬‎‪⁮⁪‏‌​⁭⁫‫⁫‍⁮⁭⁭‬‮;

	// ⁯‫⁬‏‬‭‏⁯‭‮‍⁭‮‪‪‍‏‍‎‌‫‮⁪‎‭‏​⁯‪⁬⁫⁭‫‎‭‫‮‮⁮‌‮
	private UnsafeBuffer u206f‫⁬‏‬‭‏⁯‭‮‍⁭‮‪‪‍‏‍‎‌‫‮⁪‎‭‏​⁯‪⁬⁫⁭‫‎‭‫‮‮⁮‌‮;

	// ‏‪​‌​‍‍⁪‫‌‎​‫‭‌​⁮⁪‌‭‍‏‍‏⁫⁯⁪‮‌‪‮⁪‮⁭⁫‌⁭⁫‬‮‮
	private unsafe byte* u200f‪​‌​‍‍⁪‫‌‎​‫‭‌​⁮⁪‌‭‍‏‍‏⁫⁯⁪‮‌‪‮⁪‮⁭⁫‌⁭⁫‬‮‮;

	// ‏⁬‭⁯⁪⁯​‫⁬‍⁭⁪‮​‎⁪‭‪⁮‎⁫‌⁭⁬‎⁮⁫‮‪⁫⁭‍‏⁫‍‎‏‌‭‌‮
	private UnsafeBuffer u200f⁬‭⁯⁪⁯​‫⁬‍⁭⁪‮​‎⁪‭‪⁮‎⁫‌⁭⁬‎⁮⁫‮‪⁫⁭‍‏⁫‍‎‏‌‭‌‮;

	// ‬⁫‪‮​‭‎‮⁮‮⁯⁪‎​‭‎‎‬‬‭‌​⁮⁪‭​⁬⁪⁪‌⁬‫‫⁬‬‫‮⁮⁭⁯‮
	private unsafe byte* u202c⁫‪‮​‭‎‮⁮‮⁯⁪‎​‭‎‎‬‬‭‌​⁮⁪‭​⁬⁪⁪‌⁬‫‫⁬‬‫‮⁮⁭⁯‮;

	// ‪⁪‏‏​‪‎⁪​⁪⁭⁫‬‬⁯‌⁫⁫‪‭‏⁮⁯‎‫‪⁬‮⁭⁭‫⁮​‪⁬‮‍​​⁫‮
	private UnsafeBuffer u202a⁪‏‏​‪‎⁪​⁪⁭⁫‬‬⁯‌⁫⁫‪‭‏⁮⁯‎‫‪⁬‮⁭⁭‫⁮​‪⁬‮‍​​⁫‮;

	// ‏‪⁯‭‮‭​‏‍‭‍​⁬⁮‎‫⁫‫⁮⁯‫‮‍‭⁭‪‌‪‬⁯⁬‫‏‏⁬‮‏‪⁯‮
	private unsafe byte* u200f‪⁯‭‮‭​‏‍‭‍​⁬⁮‎‫⁫‫⁮⁯‫‮‍‭⁭‪‌‪‬⁯⁬‫‏‏⁬‮‏‪⁯‮;

	// ‬‎​‮⁯⁬‏​⁯⁫‌‍‎​⁮⁮‬‏⁬‌‬‫⁬‍​⁫‍⁪‏‭‬⁯⁯‭⁮​‏⁭‏‫‮
	private UnsafeBuffer u202c‎​‮⁯⁬‏​⁯⁫‌‍‎​⁮⁮‬‏⁬‌‬‫⁬‍​⁫‍⁪‏‭‬⁯⁯‭⁮​‏⁭‏‫‮;

	// ‫⁯‬‌⁪⁮⁬⁪‏⁬‮‍‍‬⁭​⁬‌‭⁫⁭⁪⁪‏⁭‮‫‏‪⁯‮‎‌⁫‌‌‍‮‎‭‮
	private unsafe byte* u202b⁯‬‌⁪⁮⁬⁪‏⁬‮‍‍‬⁭​⁬‌‭⁫⁭⁪⁪‏⁭‮‫‏‪⁯‮‎‌⁫‌‌‍‮‎‭‮;

	// ⁯⁫⁮⁬‪‍‏‍​‪⁬​⁭⁬‎‫⁫‪‪‏​‎‪‏‏⁮‪‪‎‍⁮‎‍‎⁮‬​‬‭⁪‮
	private UnsafeBuffer u206f⁫⁮⁬‪‍‏‍​‪⁬​⁭⁬‎‫⁫‪‪‏​‎‪‏‏⁮‪‪‎‍⁮‎‍‎⁮‬​‬‭⁪‮;

	// ⁮‌‬‭⁪‎⁯‮​⁭⁯‌‍⁬⁭‬‍‍‌⁭⁯‌‮⁬‭‬‍⁯‌⁮​⁬‏‎⁪‌⁮‍‌‌‮
	private unsafe sbyte* u206e‌‬‭⁪‎⁯‮​⁭⁯‌‍⁬⁭‬‍‍‌⁭⁯‌‮⁬‭‬‍⁯‌⁮​⁬‏‎⁪‌⁮‍‌‌‮;

	// ‬⁭⁫⁫‌⁫⁬‪⁪⁭‌⁫‬‭⁬⁯‍‬⁭⁪⁯‎⁯⁯⁮⁫‫‎‮‪​⁫‪⁯‫‍‏⁯‭⁮‮
	private uint u202c⁭⁫⁫‌⁫⁬‪⁪⁭‌⁫‬‭⁬⁯‍‬⁭⁪⁯‎⁯⁯⁮⁫‫‎‮‪​⁫‪⁯‫‍‏⁯‭⁮‮;

	// ‪‮‌‍⁫⁬⁮⁫‎‭‫⁫‫‬‍⁫⁪‌‍⁫⁬⁯​​⁮⁬⁫⁬‏‫‏⁭⁮‌⁬⁬‍​‫‎‮
	private float u202a‮‌‍⁫⁬⁮⁫‎‭‫⁫‫‬‍⁫⁪‌‍⁫⁬⁯​​⁮⁬⁫⁬‏‫‏⁭⁮‌⁬⁬‍​‫‎‮;

	// ‌⁮‎‍‮‌‫‮‪‪‏​‌‬‌‎‭‪⁫⁪‪‌⁮‌‬⁫‏‫‬‫‮⁫⁮⁪‬‫‪​⁪‭‮
	public uint u200c⁮‎‍‮‌‫‮‪‪‏​‌‬‌‎‭‪⁫⁪‪‌⁮‌‬⁫‏‫‬‫‮⁫⁮⁪‬‫‪​⁪‭‮
	{
		set
		{
			this.u202c⁭⁫⁫‌⁫⁬‪⁪⁭‌⁫‬‭⁬⁯‍‬⁭⁪⁯‎⁯⁯⁮⁫‫‎‮‪​⁫‪⁯‫‍‏⁯‭⁮‮ = value;
		}
	}

	// ‌​⁮⁪⁮‌⁯⁪‍‫‎⁫‌⁫‏‪⁬‍‏⁭​⁪‬‏‎⁫⁪⁬‌‏⁬‮‎‭⁪‮‎‍⁫‪‮
	public int u200c​⁮⁪⁮‌⁯⁪‍‫‎⁫‌⁫‏‪⁬‍‏⁭​⁪‬‏‎⁫⁪⁬‌‏⁬‮‎‭⁪‮‎‍⁫‪‮
	{
		get;
		set;
	}

	// ⁫‭​⁬‮⁮‏⁮‪​‬‭⁫⁭‏⁭​‭⁬⁮⁪‪‪⁫‍‭⁫‮‪​⁫​⁭⁫⁮⁯⁪⁪⁭⁮‮
	public int u206b‭​⁬‮⁮‏⁮‪​‬‭⁫⁭‏⁭​‭⁬⁮⁪‪‪⁫‍‭⁫‮‪​⁫​⁭⁫⁮⁯⁪⁪⁭⁮‮
	{
		get;
		set;
	}

	// ‭​⁮‭‌⁬‭‪‏‬‌‬⁫⁬​⁮‎‭⁭‏‏‌‎‭‬‮‏‍‮‍‌‪‌‫‎‭‪⁭⁪‮
	public float u202d​⁮‭‌⁬‭‪‏‬‌‬⁫⁬​⁮‎‭⁭‏‏‌‎‭‬‮‏‍‮‍‌‪‌‫‎‭‪⁭⁪‮
	{
		get
		{
			return this.u202a‮‌‍⁫⁬⁮⁫‎‭‫⁫‫‬‍⁫⁪‌‍⁫⁬⁯​​⁮⁬⁫⁬‏‫‏⁭⁮‌⁬⁬‍​‫‎‮;
		}
	}

	// ‍⁪⁪‍‌‌⁭‮‌‍‮‭⁬‏⁭⁮​‏‮‪‬⁬⁫‮‬‮‍‫⁫⁭‎‮⁫⁬⁮‫‭‫‬⁮‮
	public unsafe LogicChannel u200d⁪⁪‍‌‌⁭‮‌‍‮‭⁬‏⁭⁮​‏‮‪‬⁬⁫‮‬‮‍‫⁫⁭‎‮⁫⁬⁮‫‭‫‬⁮‮(byte* numPointer, int num)
	{
		LogicChannel logicChannel = new LogicChannel()
		{
			TimeSlot = this.u200c​⁮⁪⁮‌⁯⁪‍‫‎⁫‌⁫‏‪⁬‍‏⁭​⁪‬‏‎⁫⁪⁬‌‏⁬‮‎‭⁪‮‎‍⁫‪‮,
			Frame = this.u206b‭​⁬‮⁮‏⁮‪​‬‭⁫⁭‏⁭​‭⁬⁮⁪‪‪⁫‍‭⁫‮‪​⁫​⁭⁫⁮⁯⁪⁪⁭⁮‮,
			Ptr = this.u200f‪​‌​‍‍⁪‫‌‎​‫‭‌​⁮⁪‌‭‍‏‍‏⁫⁯⁪‮‌‪‮⁪‮⁭⁫‌⁭⁫‬‮‮,
			Length = 14,
			crcGen = -1
		};
		this.u200e⁪⁫⁮‍‍⁪​​⁬‎‍⁬⁬‪​⁬‫‏‌‭‬⁫‎‏‬‮‌‭​⁫‍⁫⁪‎‬‬​‮⁪‮.u202c‪⁯⁭‫‪⁬‎⁭⁫‌‫‭‏⁮⁮⁬​‪‍‍‫‭​‪⁪‏⁯⁪⁬‍⁯‪⁭⁪‭‌⁭​‮‮(numPointer, num, this.u202c⁭⁫⁫‌⁫⁬‪⁪⁭‌⁫‬‭⁬⁯‍‬⁭⁪⁯‎⁯⁯⁮⁫‫‎‮‪​⁫‪⁯‫‍‏⁯‭⁮‮);
		logicChannel.CrcIsOk = this.u206b‬‮⁫‏‍‫‍⁫‮⁮⁭⁮‎⁬⁬⁪‬‬⁪⁬‬‌‫⁪⁭⁭⁪‎‌‮⁯‪‏‪‬‏⁮‬‭‮.u202c‪⁯⁭‫‪⁬‎⁭⁫‌‫‭‏⁮⁮⁬​‪‍‍‫‭​‪⁪‏⁯⁪⁬‍⁯‪⁭⁪‭‌⁭​‮‮(numPointer, this.u200f‪​‌​‍‍⁪‫‌‎​‫‭‌​⁮⁪‌‭‍‏‍‏⁫⁯⁪‮‌‪‮⁪‮⁭⁫‌⁭⁫‬‮‮);
		return logicChannel;
	}

	// ‫‪​⁪​‪‫⁭‪⁭‪‍⁯‭‍‏⁯‎‍⁭⁭‭‫⁯⁮⁬‭‫⁭⁯‎⁭‎‌⁪⁮⁬‌⁫‫‮
	public unsafe LogicChannel u202b‪​⁪​‪‫⁭‪⁭‪‍⁯‭‍‏⁯‎‍⁭⁭‭‫⁯⁮⁬‭‫⁭⁯‎⁭‎‌⁪⁮⁬‌⁫‫‮(byte* , byte* , int )
	{
		// 
		// Current member / type: SDRSharp.Tetra.LogicChannel ‪⁬⁪⁫⁫⁮‎‮⁪‌⁮‮‪‌⁪‎‏⁭⁪‌⁫⁮⁫‎⁮⁭‭‭‌‪‭‌​‏⁮‍⁪‬⁪‍‮::‫‪​⁪​‪‫⁭‪⁭‪‍⁯‭‍‏⁯‎‍⁭⁭‭‫⁯⁮⁬‭‫⁭⁯‎⁭‎‌⁪⁮⁬‌⁫‫‮(System.Byte*,System.Byte*,System.Int32)
		// File path: C:\SDRSharp\Plugins\Tetra\SDRSharp.Tetra.dll
		// 
		// Product version: 0.0.0.0
		// Exception in: SDRSharp.Tetra.LogicChannel ‫‪​⁪​‪‫⁭‪⁭‪‍⁯‭‍‏⁯‎‍⁭⁭‭‫⁯⁮⁬‭‫⁭⁯‎⁭‎‌⁪⁮⁬‌⁫‫‮(System.Byte*,System.Byte*,System.Int32)
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

	// ‭‬‍⁬‭‬‏⁭‮‎⁮‪⁮‪⁪‬⁫‫‫‪​‬‮⁯‬​‎‮‮‪‎‫⁭⁬‪‪‭⁬‏⁭‮
	public unsafe LogicChannel u202d‬‍⁬‭‬‏⁭‮‎⁮‪⁮‪⁪‬⁫‫‫‪​‬‮⁯‬​‎‮‮‪‎‫⁭⁬‪‪‭⁬‏⁭‮(byte* , int )
	{
		// 
		// Current member / type: SDRSharp.Tetra.LogicChannel ‪⁬⁪⁫⁫⁮‎‮⁪‌⁮‮‪‌⁪‎‏⁭⁪‌⁫⁮⁫‎⁮⁭‭‭‌‪‭‌​‏⁮‍⁪‬⁪‍‮::‭‬‍⁬‭‬‏⁭‮‎⁮‪⁮‪⁪‬⁫‫‫‪​‬‮⁯‬​‎‮‮‪‎‫⁭⁬‪‪‭⁬‏⁭‮(System.Byte*,System.Int32)
		// File path: C:\SDRSharp\Plugins\Tetra\SDRSharp.Tetra.dll
		// 
		// Product version: 0.0.0.0
		// Exception in: SDRSharp.Tetra.LogicChannel ‭‬‍⁬‭‬‏⁭‮‎⁮‪⁮‪⁪‬⁫‫‫‪​‬‮⁯‬​‎‮‮‪‎‫⁭⁬‪‪‭⁬‏⁭‮(System.Byte*,System.Int32)
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

	// ‍‬‭‫‭​⁪‫​⁭‮⁫​‍‪⁬‏⁪‬​⁬‏‏​‪‬⁭⁮⁭‪‫​⁫‬‪⁭‍‏⁬‏‮
	public unsafe LogicChannel u200d‬‭‫‭​⁪‫​⁭‮⁫​‍‪⁬‏⁪‬​⁬‏‏​‪‬⁭⁮⁭‪‫​⁫‬‪⁭‍‏⁬‏‮(byte* , byte* , int )
	{
		// 
		// Current member / type: SDRSharp.Tetra.LogicChannel ‪⁬⁪⁫⁫⁮‎‮⁪‌⁮‮‪‌⁪‎‏⁭⁪‌⁫⁮⁫‎⁮⁭‭‭‌‪‭‌​‏⁮‍⁪‬⁪‍‮::‍‬‭‫‭​⁪‫​⁭‮⁫​‍‪⁬‏⁪‬​⁬‏‏​‪‬⁭⁮⁭‪‫​⁫‬‪⁭‍‏⁬‏‮(System.Byte*,System.Byte*,System.Int32)
		// File path: C:\SDRSharp\Plugins\Tetra\SDRSharp.Tetra.dll
		// 
		// Product version: 0.0.0.0
		// Exception in: SDRSharp.Tetra.LogicChannel ‍‬‭‫‭​⁪‫​⁭‮⁫​‍‪⁬‏⁪‬​⁬‏‏​‪‬⁭⁮⁭‪‫​⁫‬‪⁭‍‏⁬‏‮(System.Byte*,System.Byte*,System.Int32)
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

	// ‬⁯⁭‮⁪⁯⁬⁪‬‫‪‭‬‏‪⁬⁭‮‬⁬⁬‬⁫‌⁯⁮‫⁭‬⁫⁪‏‏‏⁯⁮​​⁬‮‮
	public unsafe LogicChannel u202c⁯⁭‮⁪⁯⁬⁪‬‫‪‭‬‏‪⁬⁭‮‬⁬⁬‬⁫‌⁯⁮‫⁭‬⁫⁪‏‏‏⁯⁮​​⁬‮‮(byte* , int , int )
	{
		// 
		// Current member / type: SDRSharp.Tetra.LogicChannel ‪⁬⁪⁫⁫⁮‎‮⁪‌⁮‮‪‌⁪‎‏⁭⁪‌⁫⁮⁫‎⁮⁭‭‭‌‪‭‌​‏⁮‍⁪‬⁪‍‮::‬⁯⁭‮⁪⁯⁬⁪‬‫‪‭‬‏‪⁬⁭‮‬⁬⁬‬⁫‌⁯⁮‫⁭‬⁫⁪‏‏‏⁯⁮​​⁬‮‮(System.Byte*,System.Int32,System.Int32)
		// File path: C:\SDRSharp\Plugins\Tetra\SDRSharp.Tetra.dll
		// 
		// Product version: 0.0.0.0
		// Exception in: SDRSharp.Tetra.LogicChannel ‬⁯⁭‮⁪⁯⁬⁪‬‫‪‭‬‏‪⁬⁭‮‬⁬⁬‬⁫‌⁯⁮‫⁭‬⁫⁪‏‏‏⁯⁮​​⁬‮‮(System.Byte*,System.Int32,System.Int32)
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

	// ‍‎‫‫⁫‫⁪‫‫​⁭⁬⁬‍‮‍‪⁫‫‬‍⁮⁯‍‪‫‏⁬‍‌‌⁯⁫‌‪‌⁬‌​⁯‮
	public unsafe LogicChannel u200d‎‫‫⁫‫⁪‫‫​⁭⁬⁬‍‮‍‪⁫‫‬‍⁮⁯‍‪‫‏⁬‍‌‌⁯⁫‌‪‌⁬‌​⁯‮(byte* numPointer, int num)
	{
		LogicChannel logicChannel = new LogicChannel()
		{
			TimeSlot = this.u200c​⁮⁪⁮‌⁯⁪‍‫‎⁫‌⁫‏‪⁬‍‏⁭​⁪‬‏‎⁫⁪⁬‌‏⁬‮‎‭⁪‮‎‍⁫‪‮,
			Frame = this.u206b‭​⁬‮⁮‏⁮‪​‬‭⁫⁭‏⁭​‭⁬⁮⁪‪‪⁫‍‭⁫‮‪​⁫​⁭⁫⁮⁯⁪⁪⁭⁮‮,
			Ptr = this.u200f‪​‌​‍‍⁪‫‌‎​‫‭‌​⁮⁪‌‭‍‏‍‏⁫⁯⁪‮‌‪‮⁪‮⁭⁫‌⁭⁫‬‮‮,
			Length = 60
		};
		this.u200e⁪⁫⁮‍‍⁪​​⁬‎‍⁬⁬‪​⁬‫‏‌‭‬⁫‎‏‬‮‌‭​⁫‍⁫⁪‎‬‬​‮⁪‮.u202c‪⁯⁭‫‪⁬‎⁭⁫‌‫‭‏⁮⁮⁬​‪‍‍‫‭​‪⁪‏⁯⁪⁬‍⁯‪⁭⁪‭‌⁭​‮‮(numPointer, num, 3);
		this.u206a‌​⁮​⁬⁫​‍⁪‬‫⁮‭⁫⁮‭⁭⁬⁯‎⁯⁫‭‏⁮‫‭‫⁬​‍‍⁮‭‎​‮⁪‎‮.u202c‪⁯⁭‫‪⁬‎⁭⁫‌‫‭‏⁮⁮⁬​‪‍‍‫‭​‪⁪‏⁯⁪⁬‍⁯‪⁭⁪‭‌⁭​‮‮(numPointer, this.u200f‪⁯‭‮‭​‏‍‭‍​⁬⁮‎‫⁫‫⁮⁯‫‮‍‭⁭‪‌‪‬⁯⁬‫‏‏⁬‮‏‪⁯‮, 120, 11);
		this.u200d⁯‮‬‬‫‫‮​⁮⁪‎‌‌⁮⁭‏‏‪‎‌‍‍‫⁪⁮​‏‌‬‌⁬⁬‍‫‌⁪‍⁬⁭‮.u202c‪⁯⁭‫‪⁬‎⁭⁫‌‫‭‏⁮⁮⁬​‪‍‍‫‭​‪⁪‏⁯⁪⁬‍⁯‪⁭⁪‭‌⁭​‮‮(u202e‫‏‎‎‫⁮⁭‮⁭⁮‬⁭‍⁮​⁮⁯‪⁬‭‭​‬⁯‫‭‬‫​⁫⁮⁯‫⁯‏⁮⁪⁫‮‮.u206a‌‮‭‬⁯‬⁫⁫‫⁪⁬⁮‬‎‎⁬‎⁬‫⁬⁭‎‍‮‬‭​⁫‫⁬‎‭⁪⁭‌‌‎⁭⁭‮.PUNCT_2_3, this.u200f‪⁯‭‮‭​‏‍‭‍​⁬⁮‎‫⁫‫⁮⁯‫‮‍‭⁭‪‌‪‬⁯⁬‫‏‏⁬‮‏‪⁯‮, this.u206e‌‬‭⁪‎⁯‮​⁭⁯‌‍⁬⁭‬‍‍‌⁭⁯‌‮⁬‭‬‍⁯‌⁮​⁬‏‎⁪‌⁮‍‌‌‮, 120);
		this.u202a‮‌‍⁫⁬⁮⁫‎‭‫⁫‫‬‍⁫⁪‌‍⁫⁬⁯​​⁮⁬⁫⁬‏‫‏⁭⁮‌⁬⁬‍​‫‎‮ = this.u206a‪‬‭⁭‍⁯‌⁯⁭⁯‍‭‪⁬​​‪⁪‏‏‍‌‬‎‪⁮⁪‏‌​⁭⁫‫⁫‍⁮⁭⁭‬‮.u206e⁪‎‭‬‮⁫‏⁪‍‌‎⁫⁯⁮⁯​‫⁫‬⁪‪‬‬‌‏⁭‫‍⁫‎‌‏⁬‏⁬⁬‫⁭⁪‮(this.u206e‌‬‭⁪‎⁯‮​⁭⁯‌‍⁬⁭‬‍‍‌⁭⁯‌‮⁬‭‬‍⁯‌⁮​⁬‏‎⁪‌⁮‍‌‌‮, this.u202c⁫‪‮​‭‎‮⁮‮⁯⁪‎​‭‎‎‬‬‭‌​⁮⁪‭​⁬⁪⁪‌⁬‫‫⁬‬‫‮⁮⁭⁯‮, 320);
		logicChannel.CrcIsOk = this.u206c⁬‌‭‌‌⁯‭⁫⁯‪⁭‌‮‎‪‪⁮‫⁭​⁫‫⁭‪​⁫‏⁪⁫⁯⁪‮‭⁬​⁯‍‏⁯‮.u202c‪⁯⁭‫‪⁬‎⁭⁫‌‫‭‏⁮⁮⁬​‪‍‍‫‭​‪⁪‏⁯⁪⁬‍⁯‪⁭⁪‭‌⁭​‮‮(this.u202c⁫‪‮​‭‎‮⁮‮⁯⁪‎​‭‎‎‬‬‭‌​⁮⁪‭​⁬⁪⁪‌⁬‫‫⁬‬‫‮⁮⁭⁯‮, this.u200f‪​‌​‍‍⁪‫‌‎​‫‭‌​⁮⁪‌‭‍‏‍‏⁫⁯⁪‮‌‪‮⁪‮⁭⁫‌⁭⁫‬‮‮, 76);
		logicChannel.crcGen = u206c‪‬⁭‭⁯‏​‪⁭‍⁫‍‫⁮‎⁭‭⁪‮‎‭‏‬⁮⁮‍⁭‎⁪‮⁯​‎‎‌⁯⁯⁭⁯‮.u200b‌⁫‏‮‌‭​​⁮‫⁪⁮‏⁫⁯⁫‪⁬⁭‫⁮‏⁪‭⁮⁯​​‎‍‍‎​⁭‏⁫‌‏⁭‮(this.u202c⁫‪‮​‭‎‮⁮‮⁯⁪‎​‭‎‎‬‬‭‌​⁮⁪‭​⁬⁪⁪‌⁬‫‫⁬‬‫‮⁮⁭⁯‮, 60, 16);
		return logicChannel;
	}

	// ‏‍⁫⁬‌‍‮‌​‭‮⁪​‍⁬‮⁯‮⁫‪⁭‏‬‍‌‫⁭‫⁫‭‬‏⁬‌⁫‏⁫​⁪‮
	public void u200f‍⁫⁬‌‍‮‌​‭‮⁪​‍⁬‮⁯‮⁫‪⁭‏‬‍‌‫⁭‫⁫‭‬‏⁬‌⁫‏⁫​⁪‮()
	{
	}

	// ⁬‬‬‭‏‭‪​‭‎‬⁯‍‬⁭⁭‮‌‮‌‮⁯⁭⁮⁫‍⁬⁬‮‪‌‭‬‏‮⁯⁭‍⁬‫‮
	// privatescope
	internal static UnsafeBuffer u206c‬‬‭‏‭‪​‭‎‬⁯‍‬⁭⁭‮‌‮‌‮⁯⁭⁮⁫‍⁬⁬‮‪‌‭‬‏‮⁯⁭‍⁬‫‮(int num)
	{
		return UnsafeBuffer.Create(num);
	}

	// ‫⁫⁯‌‍⁪‮‎‌⁬⁮⁭⁭‭‏‬​​⁪⁬‭⁫‏‬⁮‍‍‌‪‫‎⁪‏‮⁪‎⁭⁯‭‮‮
	// privatescope
	internal static unsafe void* u202b⁫⁯‌‍⁪‮‎‌⁬⁮⁭⁭‭‏‬​​⁪⁬‭⁫‏‬⁮‍‍‌‪‫‎⁪‏‮⁪‎⁭⁯‭‮‮(UnsafeBuffer unsafeBuffer)
	{
		return unsafeBuffer;
	}

	public u202a⁬⁪⁫⁫⁮‎‮⁪‌⁮‮‪‌⁪‎‏⁭⁪‌⁫⁮⁫‎⁮⁭‭‭‌‪‭‌​‏⁮‍⁪‬⁪‍‮()
	{
	Label0:
		int num = 63733163;
		while (true)
		{
			int num1 = num ^ 81008415;
			uint num2 = (uint)num1;
			switch (num1 % 13)
			{
				case 0:
				{
					goto Label0;
				}
				case 1:
				{
					this.u206a‌​⁮​⁬⁫​‍⁪‬‫⁮‭⁫⁮‭⁭⁬⁯‎⁯⁫‭‏⁮‫‭‫⁬​‍‍⁮‭‎​‮⁪‎‮ = new u200e‮‭‌‏⁫⁬‌‪‌‌‌‭‫⁯⁯‮⁬‎⁬⁪‍‏‬​⁯‍‭‭⁭‍‎⁬⁭⁮⁮‫‭‍⁬‮();
					this.u200d⁯‮‬‬‫‫‮​⁮⁪‎‌‌⁮⁭‏‏‪‎‌‍‍‫⁪⁮​‏‌‬‌⁬⁬‍‫‌⁪‍⁬⁭‮ = new u202e‫‏‎‎‫⁮⁭‮⁭⁮‬⁭‍⁮​⁮⁯‪⁬‭‭​‬⁯‫‭‬‫​⁫⁮⁯‫⁯‏⁮⁪⁫‮‮();
					num = (int)(num2 * -1232703101 ^ 885220917);
					continue;
				}
				case 2:
				{
					this.u206b‬‮⁫‏‍‫‍⁫‮⁮⁭⁮‎⁬⁬⁪‬‬⁪⁬‬‌‫⁪⁭⁭⁪‎‌‮⁯‪‏‪‬‏⁮‬‭‮.u206b⁬‏‬‭‏‍‭‍‭‮⁪⁭‬‭⁯‮​‬‏⁯‌‪‌‬⁪⁭⁫‌‌⁮⁭​‏‬‫⁫‏‫‮‮();
					num = (int)(num2 * 1820521062 ^ 1157508361);
					continue;
				}
				case 3:
				{
					this.u202c⁫‪‮​‭‎‮⁮‮⁯⁪‎​‭‎‎‬‬‭‌​⁮⁪‭​⁬⁪⁪‌⁬‫‫⁬‬‫‮⁮⁭⁯‮ = (byte*)u202a⁬⁪⁫⁫⁮‎‮⁪‌⁮‮‪‌⁪‎‏⁭⁪‌⁫⁮⁫‎⁮⁭‭‭‌‪‭‌​‏⁮‍⁪‬⁪‍‮.u202b⁫⁯‌‍⁪‮‎‌⁬⁮⁭⁭‭‏‬​​⁪⁬‭⁫‏‬⁮‍‍‌‪‫‎⁪‏‮⁪‎⁭⁯‭‮‮(this.u200f⁬‭⁯⁪⁯​‫⁬‍⁭⁪‮​‎⁪‭‪⁮‎⁫‌⁭⁬‎⁮⁫‮‪⁫⁭‍‏⁫‍‎‏‌‭‌‮);
					this.u202a⁪‏‏​‪‎⁪​⁪⁭⁫‬‬⁯‌⁫⁫‪‭‏⁮⁯‎‫‪⁬‮⁭⁭‫⁮​‪⁬‮‍​​⁫‮ = u202a⁬⁪⁫⁫⁮‎‮⁪‌⁮‮‪‌⁪‎‏⁭⁪‌⁫⁮⁫‎⁮⁭‭‭‌‪‭‌​‏⁮‍⁪‬⁪‍‮.u206c‬‬‭‏‭‪​‭‎‬⁯‍‬⁭⁭‮‌‮‌‮⁯⁭⁮⁫‍⁬⁬‮‪‌‭‬‏‮⁯⁭‍⁬‫‮(512);
					this.u200f‪⁯‭‮‭​‏‍‭‍​⁬⁮‎‫⁫‫⁮⁯‫‮‍‭⁭‪‌‪‬⁯⁬‫‏‏⁬‮‏‪⁯‮ = (byte*)u202a⁬⁪⁫⁫⁮‎‮⁪‌⁮‮‪‌⁪‎‏⁭⁪‌⁫⁮⁫‎⁮⁭‭‭‌‪‭‌​‏⁮‍⁪‬⁪‍‮.u202b⁫⁯‌‍⁪‮‎‌⁬⁮⁭⁭‭‏‬​​⁪⁬‭⁫‏‬⁮‍‍‌‪‫‎⁪‏‮⁪‎⁭⁯‭‮‮(this.u202a⁪‏‏​‪‎⁪​⁪⁭⁫‬‬⁯‌⁫⁫‪‭‏⁮⁯‎‫‪⁬‮⁭⁭‫⁮​‪⁬‮‍​​⁫‮);
					num = (int)(num2 * 1783434831 ^ 1028696636);
					continue;
				}
				case 4:
				{
					this.u200e⁪⁫⁮‍‍⁪​​⁬‎‍⁬⁬‪​⁬‫‏‌‭‬⁫‎‏‬‮‌‭​⁫‍⁫⁪‎‬‬​‮⁪‮ = new u200b‭​‮⁫‌​​‌⁯‫‫‬‫‌‍⁪⁫‍‍⁮⁭⁭‪‌⁫‫‌⁫⁭‬‮‎‬‍‫‎⁭‏⁬‮();
					num = (int)(num2 * 885130029 ^ -781571278);
					continue;
				}
				case 5:
				{
					this.u206b‬‮⁫‏‍‫‍⁫‮⁮⁭⁮‎⁬⁬⁪‬‬⁪⁬‬‌‫⁪⁭⁭⁪‎‌‮⁯‪‏‪‬‏⁮‬‭‮ = new u206b‌⁮‪‪⁫‭⁮⁮⁭‭‮⁯⁭‬‍‫‭‪⁮⁫‌‫⁪‬‮⁬‏‍⁯‭⁬‫‍⁪‏​⁬⁮‌‮();
					num = (int)(num2 * 64073711 ^ 1331831216);
					continue;
				}
				case 6:
				{
					this.u202c‎​‮⁯⁬‏​⁯⁫‌‍‎​⁮⁮‬‏⁬‌‬‫⁬‍​⁫‍⁪‏‭‬⁯⁯‭⁮​‏⁭‏‫‮ = u202a⁬⁪⁫⁫⁮‎‮⁪‌⁮‮‪‌⁪‎‏⁭⁪‌⁫⁮⁫‎⁮⁭‭‭‌‪‭‌​‏⁮‍⁪‬⁪‍‮.u206c‬‬‭‏‭‪​‭‎‬⁯‍‬⁭⁭‮‌‮‌‮⁯⁭⁮⁫‍⁬⁬‮‪‌‭‬‏‮⁯⁭‍⁬‫‮(512);
					num = (int)(num2 * -1278861036 ^ -255303067);
					continue;
				}
				case 7:
				{
					this.u200f‪​‌​‍‍⁪‫‌‎​‫‭‌​⁮⁪‌‭‍‏‍‏⁫⁯⁪‮‌‪‮⁪‮⁭⁫‌⁭⁫‬‮‮ = (byte*)u202a⁬⁪⁫⁫⁮‎‮⁪‌⁮‮‪‌⁪‎‏⁭⁪‌⁫⁮⁫‎⁮⁭‭‭‌‪‭‌​‏⁮‍⁪‬⁪‍‮.u202b⁫⁯‌‍⁪‮‎‌⁬⁮⁭⁭‭‏‬​​⁪⁬‭⁫‏‬⁮‍‍‌‪‫‎⁪‏‮⁪‎⁭⁯‭‮‮(this.u206f‫⁬‏‬‭‏⁯‭‮‍⁭‮‪‪‍‏‍‎‌‫‮⁪‎‭‏​⁯‪⁬⁫⁭‫‎‭‫‮‮⁮‌‮);
					this.u200f⁬‭⁯⁪⁯​‫⁬‍⁭⁪‮​‎⁪‭‪⁮‎⁫‌⁭⁬‎⁮⁫‮‪⁫⁭‍‏⁫‍‎‏‌‭‌‮ = u202a⁬⁪⁫⁫⁮‎‮⁪‌⁮‮‪‌⁪‎‏⁭⁪‌⁫⁮⁫‎⁮⁭‭‭‌‪‭‌​‏⁮‍⁪‬⁪‍‮.u206c‬‬‭‏‭‪​‭‎‬⁯‍‬⁭⁭‮‌‮‌‮⁯⁭⁮⁫‍⁬⁬‮‪‌‭‬‏‮⁯⁭‍⁬‫‮(512);
					num = (int)(num2 * 548807712 ^ -1075917693);
					continue;
				}
				case 8:
				{
					this.u202b⁯‬‌⁪⁮⁬⁪‏⁬‮‍‍‬⁭​⁬‌‭⁫⁭⁪⁪‏⁭‮‫‏‪⁯‮‎‌⁫‌‌‍‮‎‭‮ = (byte*)u202a⁬⁪⁫⁫⁮‎‮⁪‌⁮‮‪‌⁪‎‏⁭⁪‌⁫⁮⁫‎⁮⁭‭‭‌‪‭‌​‏⁮‍⁪‬⁪‍‮.u202b⁫⁯‌‍⁪‮‎‌⁬⁮⁭⁭‭‏‬​​⁪⁬‭⁫‏‬⁮‍‍‌‪‫‎⁪‏‮⁪‎⁭⁯‭‮‮(this.u202c‎​‮⁯⁬‏​⁯⁫‌‍‎​⁮⁮‬‏⁬‌‬‫⁬‍​⁫‍⁪‏‭‬⁯⁯‭⁮​‏⁭‏‫‮);
					this.u206f⁫⁮⁬‪‍‏‍​‪⁬​⁭⁬‎‫⁫‪‪‏​‎‪‏‏⁮‪‪‎‍⁮‎‍‎⁮‬​‬‭⁪‮ = u202a⁬⁪⁫⁫⁮‎‮⁪‌⁮‮‪‌⁪‎‏⁭⁪‌⁫⁮⁫‎⁮⁭‭‭‌‪‭‌​‏⁮‍⁪‬⁪‍‮.u206c‬‬‭‏‭‪​‭‎‬⁯‍‬⁭⁭‮‌‮‌‮⁯⁭⁮⁫‍⁬⁬‮‪‌‭‬‏‮⁯⁭‍⁬‫‮(2048);
					this.u206e‌‬‭⁪‎⁯‮​⁭⁯‌‍⁬⁭‬‍‍‌⁭⁯‌‮⁬‭‬‍⁯‌⁮​⁬‏‎⁪‌⁮‍‌‌‮ = (sbyte*)u202a⁬⁪⁫⁫⁮‎‮⁪‌⁮‮‪‌⁪‎‏⁭⁪‌⁫⁮⁫‎⁮⁭‭‭‌‪‭‌​‏⁮‍⁪‬⁪‍‮.u202b⁫⁯‌‍⁪‮‎‌⁬⁮⁭⁭‭‏‬​​⁪⁬‭⁫‏‬⁮‍‍‌‪‫‎⁪‏‮⁪‎⁭⁯‭‮‮(this.u206f⁫⁮⁬‪‍‏‍​‪⁬​⁭⁬‎‫⁫‪‪‏​‎‪‏‏⁮‪‪‎‍⁮‎‍‎⁮‬​‬‭⁪‮);
					num = (int)(num2 * -1499674667 ^ -1646766285);
					continue;
				}
				case 9:
				{
					this.u206a‪‬‭⁭‍⁯‌⁯⁭⁯‍‭‪⁬​​‪⁪‏‏‍‌‬‎‪⁮⁪‏‌​⁭⁫‫⁫‍⁮⁭⁭‬‮.u200f‬‫‬‌⁯‭⁫‪⁯‏⁯⁪‏‭‬‍‫‬​‬⁯‏‪‬‍‍‎⁫​‬⁬‫​⁯‫⁪‎‭⁬‮();
					num = (int)(num2 * 1496412537 ^ 239516221);
					continue;
				}
				case 10:
				{
					this.u206c⁬‌‭‌‌⁯‭⁫⁯‪⁭‌‮‎‪‪⁮‫⁭​⁫‫⁭‪​⁫‏⁪⁫⁯⁪‮‭⁬​⁯‍‏⁯‮ = new u206b⁯⁫⁮​⁪‮‫‮​‪‍‪⁬⁪⁭‮‬‍⁬‌‍​⁬‍‎‫‏‬⁯‏‎⁫‏⁫​‍‮‎‭‮();
					this.u206f‫⁬‏‬‭‏⁯‭‮‍⁭‮‪‪‍‏‍‎‌‫‮⁪‎‭‏​⁯‪⁬⁫⁭‫‎‭‫‮‮⁮‌‮ = u202a⁬⁪⁫⁫⁮‎‮⁪‌⁮‮‪‌⁪‎‏⁭⁪‌⁫⁮⁫‎⁮⁭‭‭‌‪‭‌​‏⁮‍⁪‬⁪‍‮.u206c‬‬‭‏‭‪​‭‎‬⁯‍‬⁭⁭‮‌‮‌‮⁯⁭⁮⁫‍⁬⁬‮‪‌‭‬‏‮⁯⁭‍⁬‫‮(512);
					num = (int)(num2 * -1904589338 ^ -1828504300);
					continue;
				}
				case 11:
				{
					return;
				}
				case 12:
				{
					this.u206a‪‬‭⁭‍⁯‌⁯⁭⁯‍‭‪⁬​​‪⁪‏‏‍‌‬‎‪⁮⁪‏‌​⁭⁫‫⁫‍⁮⁭⁭‬‮ = new u206f‪​‭‫‭‬‏‌⁯‎‌‫‌⁭‎⁪⁯‭‭‭‮⁫⁫‏⁮⁬⁯‭‮‏‍‮⁮‭⁪‪‫‏‮‮();
					num = (int)(num2 * -1077048803 ^ -1158450632);
					continue;
				}
			}
		}
	}
}