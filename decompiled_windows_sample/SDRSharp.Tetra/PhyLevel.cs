using SDRSharp.Radio;
using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace SDRSharp.Tetra
{
	public class PhyLevel : IDisposable
	{
		// ‏‍‌⁫⁪‫⁬‍⁭‪⁯‬‪‌⁪‎⁪‏‎‪‌⁭‬⁫​⁪‏⁫⁭⁪‍‌⁮‬⁬⁯‫‌‪⁯‮
		private readonly static byte[] u200f‍‌⁫⁪‫⁬‍⁭‪⁯‬‪‌⁪‎⁪‏‎‪‌⁭‬⁫​⁪‏⁫⁭⁪‍‌⁮‬⁬⁯‫‌‪⁯‮;

		// ‍⁯‌⁭‭‬‏‬⁭‪‎‪⁮⁬‏​​⁪⁭‪⁯⁫⁮⁬⁪⁫‍‏⁫‫‎‏‮⁯⁮​‬⁮‍⁮‮
		private readonly static byte[] u200d⁯‌⁭‭‬‏‬⁭‪‎‪⁮⁬‏​​⁪⁭‪⁯⁫⁮⁬⁪⁫‍‏⁫‫‎‏‮⁯⁮​‬⁮‍⁮‮;

		// ‍‍⁫⁮‎‌⁬⁮‏⁪‬⁮⁫‏‭‏⁫​‪⁭⁪​⁯⁬⁮⁫​‫‏‪‫‮‌⁮⁮⁬‭‎⁮⁪‮
		private readonly static byte[] u200d‍⁫⁮‎‌⁬⁮‏⁪‬⁮⁫‏‭‏⁫​‪⁭⁪​⁯⁬⁮⁫​‫‏‪‫‮‌⁮⁮⁬‭‎⁮⁪‮;

		// ⁫‬⁫‏‏‍‍⁫‌‍⁬‮‬⁫‭‍⁬‬⁯⁫⁪​⁫‮⁯‍‍‎‭‌‫‌‭‍‭⁯‌‬⁫‫‮
		private readonly static byte[] u206b‬⁫‏‏‍‍⁫‌‍⁬‮‬⁫‭‍⁬‬⁯⁫⁪​⁫‮⁯‍‍‎‭‌‫‌‭‍‭⁯‌‬⁫‫‮;

		// ‎‫‮‌⁭‪⁬⁪⁭​‭⁯⁭‮‭‬‭⁬‭‌⁯⁫⁯‭‭‏‭‭⁫​‌⁭‎‌‬‪‎‮‏⁮‮
		private readonly static byte[] u200e‫‮‌⁭‪⁬⁪⁭​‭⁯⁭‮‭‬‭⁬‭‌⁯⁫⁯‭‭‏‭‭⁫​‌⁭‎‌‬‪‎‮‏⁮‮;

		// ‭‮‍‬‪⁬⁯‬‍‫‌⁬‬‏‭‏‏⁭‎‌​‫⁮⁬‌‌⁫‍​⁪‫‏⁭⁬⁮‫‭‍‫‏‮
		private readonly static byte[] u202d‮‍‬‪⁬⁯‬‍‫‌⁬‬‏‭‏‏⁭‎‌​‫⁮⁬‌‌⁫‍​⁪‫‏⁭⁬⁮‫‭‍‫‏‮;

		// ‪‬⁫⁪‭‎⁪‌⁮⁭‫‎​⁭⁪⁮⁮⁯‮‏⁯⁫‪⁮‍‪‭‎‫‬⁭‮​‍⁭⁯‍⁫‏‮‮
		private readonly static byte[] u202a‬⁫⁪‭‎⁪‌⁮⁭‫‎​⁭⁪⁮⁮⁯‮‏⁯⁫‪⁮‍‪‭‎‫‬⁭‮​‍⁭⁯‍⁫‏‮‮;

		// ⁮‏⁬‬⁬‏‭‍‎‌‮⁫⁮⁬⁫⁫⁪‫​‍‍‏‬⁭⁯‮‎‪​​‫‌‎‬‭‮⁮⁬​⁭‮
		private readonly static byte[] u206e‏⁬‬⁬‏‭‍‎‌‮⁫⁮⁬⁫⁫⁪‫​‍‍‏‬⁭⁯‮‎‪​​‫‌‎‬‭‮⁮⁬​⁭‮;

		// ‍‍⁫‮‪‪‏‍‪‎​‫‫‬⁭⁮​‏‪⁪⁮‬⁪​⁪⁫⁭⁬⁪⁯⁮‬⁯‭‬⁭⁪‭⁮‍‮
		private readonly static byte[] u200d‍⁫‮‪‪‏‍‪‎​‫‫‬⁭⁮​‏‪⁪⁮‬⁪​⁪⁫⁭⁬⁪⁯⁮‬⁯‭‬⁭⁪‭⁮‍‮;

		// ‭⁬‫⁪⁯⁭‫⁮‍‭‍‪​⁫⁯⁭⁭‮⁬‌‎⁭‬⁯⁮⁬‮⁬⁭⁭⁬⁫⁫‬‌‫⁯‌⁬⁬‮
		private readonly static byte[] u202d⁬‫⁪⁯⁭‫⁮‍‭‍‪​⁫⁯⁭⁭‮⁬‌‎⁭‬⁯⁮⁬‮⁬⁭⁭⁬⁫⁫‬‌‫⁯‌⁬⁬‮;

		// ‍‫‪⁬⁫‎⁮⁯⁯⁭‎​⁮⁯‭‭‍‭​⁮⁮‏‮‪⁬‏⁫⁭⁮⁬‍‏⁫​⁫‪⁫⁮‫‪‮
		private readonly static byte[] u200d‫‪⁬⁫‎⁮⁯⁯⁭‎​⁮⁯‭‭‍‭​⁮⁮‏‮‪⁬‏⁫⁭⁮⁬‍‏⁫​⁫‪⁫⁮‫‪‮;

		// ⁬⁯‭​‍⁪‎⁬​​⁫‍⁮‮‮⁬‮‍⁮‭​‮‭‭‫‫‪‭‏⁮⁬‮⁯⁯⁯‏‎⁯⁬‪‮
		private readonly static byte[] u206c⁯‭​‍⁪‎⁬​​⁫‍⁮‮‮⁬‮‍⁮‭​‮‭‭‫‫‪‭‏⁮⁬‮⁯⁯⁯‏‎⁯⁬‪‮;

		public const int BurstLength = 510;

		public const int nts_Length = 22;

		public const int nts3_pre_Length = 12;

		public const int nts3_post_Length = 10;

		public const int sts_Length = 38;

		public const int phaseAdjust_Length = 2;

		public const int bkn_Length = 216;

		public const int bb1_Length = 14;

		public const int bb2_Length = 16;

		public const int bb_Length = 30;

		public const int freqCorrection_Length = 80;

		public const int sb_Length = 120;

		// ⁬⁭⁭‍⁮​⁮⁪⁮‍‍‌‍‪‭‬‫⁪‪‍​⁯‪‌⁪⁭‎‏⁮‭‪⁫⁫⁭‭‏‪⁭​⁭‮
		private bool u206c⁭⁭‍⁮​⁮⁪⁮‍‍‌‍‪‭‬‫⁪‪‍​⁯‪‌⁪⁭‎‏⁮‭‪⁫⁫⁭‭‏‪⁭​⁭‮;

		// ⁯⁫⁮⁬‪‍‏‍​‪⁬​⁭⁬‎‫⁫‪‪‏​‎‪‏‏⁮‪‪‎‍⁮‎‍‎⁮‬​‬‭⁪‮
		private UnsafeBuffer u206f⁫⁮⁬‪‍‏‍​‪⁬​⁭⁬‎‫⁫‪‪‏​‎‪‏‏⁮‪‪‎‍⁮‎‍‎⁮‬​‬‭⁪‮;

		// ⁮‌‬‭⁪‎⁯‮​⁭⁯‌‍⁬⁭‬‍‍‌⁭⁯‌‮⁬‭‬‍⁯‌⁮​⁬‏‎⁪‌⁮‍‌‌‮
		private unsafe byte* u206e‌‬‭⁪‎⁯‮​⁭⁯‌‍⁬⁭‬‍‍‌⁭⁯‌‮⁬‭‬‍⁯‌⁮​⁬‏‎⁪‌⁮‍‌‌‮;

		// ‍​‍​​‪‬‬‫‮‬‍‮‪⁬⁪‮‎⁪⁯⁬‎⁪‫‮‮‫⁯⁫‫‮‎‬‎‭‏‪‎‏⁬‮
		private UnsafeBuffer u200d​‍​​‪‬‬‫‮‬‍‮‪⁬⁪‮‎⁪⁯⁬‎⁪‫‮‮‫⁯⁫‫‮‎‬‎‭‏‪‎‏⁬‮;

		// ‪⁮⁭‎‎⁪‬‭‌‭‎‌‫‭​‬‮⁫​‍⁬‎‪⁫⁫‏‫‎⁪​⁯‎‪‭⁭‎‭‏⁪‌‮
		private unsafe float* u202a⁮⁭‎‎⁪‬‭‌‭‎‌‫‭​‬‮⁫​‍⁬‎‪⁫⁫‏‫‎⁪​⁯‎‪‭⁭‎‭‏⁪‌‮;

		// ‭‍‏‬‮⁭‏‎‮​⁬‏⁬⁪‫⁭⁮​⁭‭‏‏⁪‎‍⁮⁬⁮‏​​‫‍‌‭‪‌⁫⁮‮‮
		private UnsafeBuffer u202d‍‏‬‮⁭‏‎‮​⁬‏⁬⁪‫⁭⁮​⁭‭‏‏⁪‎‍⁮⁬⁮‏​​‫‍‌‭‪‌⁫⁮‮‮;

		// ⁫⁫⁬⁪​‪‌⁪‍⁫‫‬⁪‬​‏​‍‪‭​‭‌‮​⁮⁬⁪​‪‌⁪‍‬‎⁫⁫⁪‮‪‮
		private unsafe byte* u206b⁫⁬⁪​‪‌⁪‍⁫‫‬⁪‬​‏​‍‪‭​‭‌‮​⁮⁬⁪​‪‌⁪‍‬‎⁫⁫⁪‮‪‮;

		// ⁬‮‫‭‮⁫​⁯⁫⁭⁫⁬⁬‎⁫‌‌⁯‌⁯⁪‪⁭⁯‎‮‪‪‎⁯‮⁭‍‭‎‍⁯⁬‮⁪‮
		private int u206c‮‫‭‮⁫​⁯⁫⁭⁫⁬⁬‎⁫‌‌⁯‌⁯⁪‪⁭⁯‎‮‪‪‎⁯‮⁭‍‭‎‍⁯⁬‮⁪‮;

		// ‏⁬⁫​​‏‎⁪‍‏​‍‪⁯⁭​⁪‮‎⁪‭‌‎⁬‏‏‎‍‪⁯⁬⁪​⁯‬‬⁬​‍‍‮
		private const float u200f⁬⁫​​‏‎⁪‍‏​‍‪⁯⁭​⁪‮‎⁪‭‌‎⁬‏‏‎‍‪⁯⁬⁪​⁯‬‬⁬​‍‍‮ = 1.5707964f;

		public static bool DiagramUseSyncOnly
		{
			get;
			set;
		}

		// ‮‭⁫‭‫‎‭‍‎⁪⁯⁮‏⁬‭⁯‫‍⁯‫⁭⁬⁬​‮‫⁬⁮⁭‭⁭‎‬‌⁪​‌⁪‌⁫‮
		private unsafe void u202e‭⁫‭‫‎‭‍‎⁪⁯⁮‏⁬‭⁯‫‍⁯‫⁭⁬⁬​‮‫⁬⁮⁭‭⁭‎‬‌⁪​‌⁪‌⁫‮(byte* , int , float* , int )
		{
			// 
			// Current member / type: System.Void SDRSharp.Tetra.PhyLevel::‮‭⁫‭‫‎‭‍‎⁪⁯⁮‏⁬‭⁯‫‍⁯‫⁭⁬⁬​‮‫⁬⁮⁭‭⁭‎‬‌⁪​‌⁪‌⁫‮(System.Byte*,System.Int32,System.Single*,System.Int32)
			// File path: C:\SDRSharp\Plugins\Tetra\SDRSharp.Tetra.dll
			// 
			// Product version: 0.0.0.0
			// Exception in: System.Void ‮‭⁫‭‫‎‭‍‎⁪⁯⁮‏⁬‭⁯‫‍⁯‫⁭⁬⁬​‮‫⁬⁮⁭‭⁭‎‬‌⁪​‌⁪‌⁫‮(System.Byte*,System.Int32,System.Single*,System.Int32)
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

		// ‏‭‫‮⁫‫⁬‎‎‭⁬⁬‌‌⁮‌‮‏‌‎⁮⁯⁭​⁯⁯⁭‭‪⁯​⁬​‭⁯‎⁭‪⁭⁪‮
		private unsafe void u200f‭‫‮⁫‫⁬‎‎‭⁬⁬‌‌⁮‌‮‏‌‎⁮⁯⁭​⁯⁯⁭‭‪⁯​⁬​‭⁯‎⁭‪⁭⁪‮(byte* , int , byte* , int , int )
		{
			// 
			// Current member / type: System.Void SDRSharp.Tetra.PhyLevel::‏‭‫‮⁫‫⁬‎‎‭⁬⁬‌‌⁮‌‮‏‌‎⁮⁯⁭​⁯⁯⁭‭‪⁯​⁬​‭⁯‎⁭‪⁭⁪‮(System.Byte*,System.Int32,System.Byte*,System.Int32,System.Int32)
			// File path: C:\SDRSharp\Plugins\Tetra\SDRSharp.Tetra.dll
			// 
			// Product version: 0.0.0.0
			// Exception in: System.Void ‏‭‫‮⁫‫⁬‎‎‭⁬⁬‌‌⁮‌‮‏‌‎⁮⁯⁭​⁯⁯⁭‭‪⁯​⁬​‭⁯‎⁭‪⁭⁪‮(System.Byte*,System.Int32,System.Byte*,System.Int32,System.Int32)
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

		// ‍⁬‌‫⁮‫⁪⁪‏‫‌‌‭⁭‌‬​⁪‮‭‫‭‭‎⁮⁫⁭‎⁬⁭‮‮⁬‮⁮‎‍‏​⁬‮
		// privatescope
		internal static UnsafeBuffer u200d⁬‌‫⁮‫⁪⁪‏‫‌‌‭⁭‌‬​⁪‮‭‫‭‭‎⁮⁫⁭‎⁬⁭‮‮⁬‮⁮‎‍‏​⁬‮(int num, int num)
		{
			return UnsafeBuffer.Create(num, num);
		}

		// ‭‭‪‌‮⁫‬‮‬⁯‮⁫⁮‏⁭⁮⁪⁭⁯⁯⁮‬⁪‌‮‏⁮⁭‎⁯‪‎⁫⁪⁪⁬⁯‪‭‏‮
		// privatescope
		internal static unsafe void* u202d‭‪‌‮⁫‬‮‬⁯‮⁫⁮‏⁭⁮⁪⁭⁯⁯⁮‬⁪‌‮‏⁮⁭‎⁯‪‎⁫⁪⁪⁬⁯‪‭‏‮(UnsafeBuffer unsafeBuffer)
		{
			return unsafeBuffer;
		}

		// ⁪⁫​⁭⁪⁬‎‍⁫‭‌‍‌⁭‪⁮⁭‪‭⁭‏⁯‍⁬‍⁯⁬‌‌‎⁫‎‫‭‍‪⁬​⁮‏‮
		// privatescope
		internal static unsafe void* u206a⁫​⁭⁪⁬‎‍⁫‭‌‍‌⁭‪⁮⁭‪‭⁭‏⁯‍⁬‍⁯⁬‌‌‎⁫‎‫‭‍‪⁬​⁮‏‮(void* voidPointer, void* voidPointer, int num)
		{
			return Utils.Memcpy(voidPointer, voidPointer, num);
		}

		// ⁯⁭⁪‍‬‏‫‍‬⁬‬⁬‮‏⁭⁮⁯⁫‌‬‮‪‪‌⁯‬‎⁯‍‮⁮⁭‭‭​‫⁭⁬‭‪‮
		// privatescope
		internal static string u206f⁭⁪‍‬‏‫‍‬⁬‬⁬‮‏⁭⁮⁯⁫‌‬‮‪‪‌⁯‬‎⁯‍‮⁮⁭‭‭​‫⁭⁬‭‪‮(string str, string str)
		{
			return string.Concat(str, str);
		}

		// ‍⁮⁬‫‭‮‬⁯⁮‎‬‌‭⁯⁪‎‪⁯‭‫⁮⁭⁬⁬​⁫‫‪​‌‭‍⁪⁪‪‍⁭‌‭‎‮
		// privatescope
		internal static string u200d⁮⁬‫‭‮‬⁯⁮‎‬‌‭⁯⁪‎‪⁯‭‫⁮⁭⁬⁬​⁫‫‪​‌‭‍⁪⁪‪‍⁭‌‭‎‮(object obj, object obj)
		{
			return string.Concat(obj, obj);
		}

		// ⁭​⁭⁯‎‎​​⁭‮‌‮‍⁮⁫‌⁯⁫‌⁫‍⁪‍⁪‌⁪‏⁮‎⁭⁬‪‬‮⁮⁪‪‪‬‏‮
		// privatescope
		internal static string u206d​⁭⁯‎‎​​⁭‮‌‮‍⁮⁫‌⁯⁫‌⁫‍⁪‍⁪‌⁪‏⁮‎⁭⁬‪‬‮⁮⁪‪‪‬‏‮()
		{
			return Environment.NewLine;
		}

		// ⁯‎⁪‫​⁬‬‎‌‭‏‪⁮‮‏⁮‫⁬‍⁫⁬⁮‭‏⁯⁭​‫⁮‎‍‌⁭⁭‭⁪​⁮‏‏‮
		// privatescope
		internal static string u206f‎⁪‫​⁬‬‎‌‭‏‪⁮‮‏⁮‫⁬‍⁫⁬⁮‭‏⁯⁭​‫⁮‎‍‌⁭⁭‭⁪​⁮‏‏‮(object obj)
		{
			return obj.ToString();
		}

		// ⁬‫‌‮‫‪‮‭​‎⁫⁪​‎⁭‌‍‬‌‮​‫‮‏⁭‬‫⁭‌⁮‎‭⁮⁬⁬‏⁬⁫‌‫‮
		// privatescope
		internal static string u206c‫‌‮‫‪‮‭​‎⁫⁪​‎⁭‌‍‬‌‮​‫‮‏⁭‬‫⁭‌⁮‎‭⁮⁬⁬‏⁬⁫‌‫‮(string[] strArrays)
		{
			return string.Concat(strArrays);
		}

		// ‎⁯‏⁪‍⁮‮‏‪‮⁫‮​‫⁪⁯‌‏⁪‮​‍‬⁯​‍⁯⁬‌​⁯⁮‬⁬⁬‌‭‌‍‎‮
		// privatescope
		internal static DialogResult u200e⁯‏⁪‍⁮‮‏‪‮⁫‮​‫⁪⁯‌‏⁪‮​‍‬⁯​‍⁯⁬‌​⁯⁮‬⁬⁬‌‭‌‍‎‮(string str)
		{
			return MessageBox.Show(str);
		}

		// ‬‌‫‌‬⁭‍⁬‮‭⁭‭⁯‍‫‏‫⁮‭⁭⁮⁪⁪⁮‪‌⁯⁫‎​‮‪‏‬⁬⁮⁪⁮‫‫‮
		// privatescope
		internal static float u202c‌‫‌‬⁭‍⁬‮‭⁭‭⁯‍‫‏‫⁮‭⁭⁮⁪⁪⁮‪‌⁯⁫‎​‮‪‏‬⁬⁮⁪⁮‫‫‮(float single)
		{
			return Math.Abs(single);
		}

		// ‮⁭‪‪‌⁬‬‍‌‫‎⁫⁭‫⁫⁮⁬‬‌‭⁬⁫⁫‌​⁪⁫⁮​‭⁭⁫⁫‍‌⁮‍⁬‮‮
		// privatescope
		internal static void u202e⁭‪‪‌⁬‬‍‌‫‎⁫⁭‫⁫⁮⁬‬‌‭⁬⁫⁫‌​⁪⁫⁮​‭⁭⁫⁫‍‌⁮‍⁬‮‮(Array , RuntimeFieldHandle )
		{
			// 
			// Current member / type: System.Void SDRSharp.Tetra.PhyLevel::‮⁭‪‪‌⁬‬‍‌‫‎⁫⁭‫⁫⁮⁬‬‌‭⁬⁫⁫‌​⁪⁫⁮​‭⁭⁫⁫‍‌⁮‍⁬‮‮(System.Array,System.RuntimeFieldHandle)
			// File path: C:\SDRSharp\Plugins\Tetra\SDRSharp.Tetra.dll
			// 
			// Product version: 0.0.0.0
			// Exception in: System.Void ‮⁭‪‪‌⁬‬‍‌‫‎⁫⁭‫⁫⁮⁬‬‌‭⁬⁫⁫‌​⁪⁫⁮​‭⁭⁫⁫‍‌⁮‍⁬‮‮(System.Array,System.RuntimeFieldHandle)
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

		static PhyLevel()
		{
			byte[] numArray;
			byte[] numArray1 = new byte[22];
			PhyLevel.u202e⁭‪‪‌⁬‬‍‌‫‎⁫⁭‫⁫⁮⁬‬‌‭⁬⁫⁫‌​⁪⁫⁮​‭⁭⁫⁫‍‌⁮‍⁬‮‮((Array)numArray1, typeof(u206e⁭⁬‬‬‎⁮⁪⁯‫‮⁮‍⁭‍‬⁭⁪‏⁮⁭⁫⁪⁬⁯‍⁮⁭‎⁬‪‌⁫⁭⁮‫‍‮‏‭‮).GetField("C2AF9026553B9761E0A9FE08BA86938C7314D95D").FieldHandle);
			PhyLevel.u200f‍‌⁫⁪‫⁬‍⁭‪⁯‬‪‌⁪‎⁪‏‎‪‌⁭‬⁫​⁪‏⁫⁭⁪‍‌⁮‬⁬⁯‫‌‪⁯‮ = numArray1;
			byte[] numArray2 = new byte[22];
			PhyLevel.u202e⁭‪‪‌⁬‬‍‌‫‎⁫⁭‫⁫⁮⁬‬‌‭⁬⁫⁫‌​⁪⁫⁮​‭⁭⁫⁫‍‌⁮‍⁬‮‮((Array)numArray2, typeof(u206e⁭⁬‬‬‎⁮⁪⁯‫‮⁮‍⁭‍‬⁭⁪‏⁮⁭⁫⁪⁬⁯‍⁮⁭‎⁬‪‌⁫⁭⁮‫‍‮‏‭‮).GetField("3F7F5C21ECA427CD8F850B5545C72D0DA2A3D992").FieldHandle);
			PhyLevel.u200d⁯‌⁭‭‬‏‬⁭‪‎‪⁮⁬‏​​⁪⁭‪⁯⁫⁮⁬⁪⁫‍‏⁫‫‎‏‮⁯⁮​‬⁮‍⁮‮ = numArray2;
		Label0:
			int num = 1645409473;
			while (true)
			{
				int num1 = num ^ 1507325084;
				uint num2 = (uint)num1;
				switch (num1 % 6)
				{
					case 0:
					{
						goto Label0;
					}
					case 1:
					{
						byte[] numArray3 = new byte[10];
						PhyLevel.u202e⁭‪‪‌⁬‬‍‌‫‎⁫⁭‫⁫⁮⁬‬‌‭⁬⁫⁫‌​⁪⁫⁮​‭⁭⁫⁫‍‌⁮‍⁬‮‮((Array)numArray3, typeof(u206e⁭⁬‬‬‎⁮⁪⁯‫‮⁮‍⁭‍‬⁭⁪‏⁮⁭⁫⁪⁬⁯‍⁮⁭‎⁬‪‌⁫⁭⁮‫‍‮‏‭‮).GetField("7F32B4C36B63CFFC0D349D0252D2764EEE497893").FieldHandle);
						PhyLevel.u200d‍⁫⁮‎‌⁬⁮‏⁪‬⁮⁫‏‭‏⁫​‪⁭⁪​⁯⁬⁮⁫​‫‏‪‫‮‌⁮⁮⁬‭‎⁮⁪‮ = numArray3;
						byte[] numArray4 = new byte[12];
						PhyLevel.u202e⁭‪‪‌⁬‬‍‌‫‎⁫⁭‫⁫⁮⁬‬‌‭⁬⁫⁫‌​⁪⁫⁮​‭⁭⁫⁫‍‌⁮‍⁬‮‮((Array)numArray4, typeof(u206e⁭⁬‬‬‎⁮⁪⁯‫‮⁮‍⁭‍‬⁭⁪‏⁮⁭⁫⁪⁬⁯‍⁮⁭‎⁬‪‌⁫⁭⁮‫‍‮‏‭‮).GetField("3465AFF8E38466A3EB2EA73EB0B2178EE2BE14E3").FieldHandle);
						PhyLevel.u206b‬⁫‏‏‍‍⁫‌‍⁬‮‬⁫‭‍⁬‬⁯⁫⁪​⁫‮⁯‍‍‎‭‌‫‌‭‍‭⁯‌‬⁫‫‮ = numArray4;
						byte[] numArray5 = new byte[12];
						PhyLevel.u202e⁭‪‪‌⁬‬‍‌‫‎⁫⁭‫⁫⁮⁬‬‌‭⁬⁫⁫‌​⁪⁫⁮​‭⁭⁫⁫‍‌⁮‍⁬‮‮((Array)numArray5, typeof(u206e⁭⁬‬‬‎⁮⁪⁯‫‮⁮‍⁭‍‬⁭⁪‏⁮⁭⁫⁪⁬⁯‍⁮⁭‎⁬‪‌⁫⁭⁮‫‍‮‏‭‮).GetField("4F34246497D933B3C20D1A6A3F07511B209EE3FC").FieldHandle);
						PhyLevel.u200e‫‮‌⁭‪⁬⁪⁭​‭⁯⁭‮‭‬‭⁬‭‌⁯⁫⁯‭‭‏‭‭⁫​‌⁭‎‌‬‪‎‮‏⁮‮ = numArray5;
						byte[] numArray6 = new byte[12];
						PhyLevel.u202e⁭‪‪‌⁬‬‍‌‫‎⁫⁭‫⁫⁮⁬‬‌‭⁬⁫⁫‌​⁪⁫⁮​‭⁭⁫⁫‍‌⁮‍⁬‮‮((Array)numArray6, typeof(u206e⁭⁬‬‬‎⁮⁪⁯‫‮⁮‍⁭‍‬⁭⁪‏⁮⁭⁫⁪⁬⁯‍⁮⁭‎⁬‪‌⁫⁭⁮‫‍‮‏‭‮).GetField("815B1DC10D170842ECCB45667DD90FFA5669CB9F").FieldHandle);
						PhyLevel.u202d‮‍‬‪⁬⁯‬‍‫‌⁬‬‏‭‏‏⁭‎‌​‫⁮⁬‌‌⁫‍​⁪‫‏⁭⁬⁮‫‭‍‫‏‮ = numArray6;
						num = (int)(num2 * -1030821672 ^ -1382708965);
						continue;
					}
					case 2:
					{
						byte[] numArray7 = new byte[38];
						PhyLevel.u202e⁭‪‪‌⁬‬‍‌‫‎⁫⁭‫⁫⁮⁬‬‌‭⁬⁫⁫‌​⁪⁫⁮​‭⁭⁫⁫‍‌⁮‍⁬‮‮((Array)numArray7, typeof(u206e⁭⁬‬‬‎⁮⁪⁯‫‮⁮‍⁭‍‬⁭⁪‏⁮⁭⁫⁪⁬⁯‍⁮⁭‎⁬‪‌⁫⁭⁮‫‍‮‏‭‮).GetField("EB2790582426FF9F4FD0C35D007F6FEDB6070928").FieldHandle);
						PhyLevel.u206e‏⁬‬⁬‏‭‍‎‌‮⁫⁮⁬⁫⁫⁪‫​‍‍‏‬⁭⁯‮‎‪​​‫‌‎‬‭‮⁮⁬​⁭‮ = numArray7;
						num = (int)(num2 * -1785673156 ^ -1046832184);
						continue;
					}
					case 3:
					{
						byte[] numArray8 = new byte[12];
						PhyLevel.u202e⁭‪‪‌⁬‬‍‌‫‎⁫⁭‫⁫⁮⁬‬‌‭⁬⁫⁫‌​⁪⁫⁮​‭⁭⁫⁫‍‌⁮‍⁬‮‮((Array)numArray8, typeof(u206e⁭⁬‬‬‎⁮⁪⁯‫‮⁮‍⁭‍‬⁭⁪‏⁮⁭⁫⁪⁬⁯‍⁮⁭‎⁬‪‌⁫⁭⁮‫‍‮‏‭‮).GetField("05F5F3F8D3717214B949DFA8EE65AF0AD5C1A015").FieldHandle);
						PhyLevel.u202a‬⁫⁪‭‎⁪‌⁮⁭‫‎​⁭⁪⁮⁮⁯‮‏⁯⁫‪⁮‍‪‭‎‫‬⁭‮​‍⁭⁯‍⁫‏‮‮ = numArray8;
						num = (int)(num2 * 1969104367 ^ 1076256879);
						continue;
					}
					case 4:
					{
						byte[] numArray9 = new byte[80];
						PhyLevel.u202e⁭‪‪‌⁬‬‍‌‫‎⁫⁭‫⁫⁮⁬‬‌‭⁬⁫⁫‌​⁪⁫⁮​‭⁭⁫⁫‍‌⁮‍⁬‮‮((Array)numArray9, typeof(u206e⁭⁬‬‬‎⁮⁪⁯‫‮⁮‍⁭‍‬⁭⁪‏⁮⁭⁫⁪⁬⁯‍⁮⁭‎⁬‪‌⁫⁭⁮‫‍‮‏‭‮).GetField("3126F8A3A702EF94F82F32F3F574EB7B0FF3C0D2").FieldHandle);
						PhyLevel.u200d‍⁫‮‪‪‏‍‪‎​‫‫‬⁭⁮​‏‪⁪⁮‬⁪​⁪⁫⁭⁬⁪⁯⁮‬⁯‭‬⁭⁪‭⁮‍‮ = numArray9;
						byte[] numArray10 = new byte[30];
						PhyLevel.u202e⁭‪‪‌⁬‬‍‌‫‎⁫⁭‫⁫⁮⁬‬‌‭⁬⁫⁫‌​⁪⁫⁮​‭⁭⁫⁫‍‌⁮‍⁬‮‮((Array)numArray10, typeof(u206e⁭⁬‬‬‎⁮⁪⁯‫‮⁮‍⁭‍‬⁭⁪‏⁮⁭⁫⁪⁬⁯‍⁮⁭‎⁬‪‌⁫⁭⁮‫‍‮‏‭‮).GetField("92D518672DE06C1B002BD1B38A252E1033A347AB").FieldHandle);
						PhyLevel.u202d⁬‫⁪⁯⁭‫⁮‍‭‍‪​⁫⁯⁭⁭‮⁬‌‎⁭‬⁯⁮⁬‮⁬⁭⁭⁬⁫⁫‬‌‫⁯‌⁬⁬‮ = numArray10;
						num = (int)(num2 * 1648966216 ^ 991838447);
						continue;
					}
					case 5:
					{
						numArray = new byte[] { 1, 1, 0, 0 };
						PhyLevel.u200d‫‪⁬⁫‎⁮⁯⁯⁭‎​⁮⁯‭‭‍‭​⁮⁮‏‮‪⁬‏⁫⁭⁮⁬‍‏⁫​⁫‪⁫⁮‫‪‮ = numArray;
						PhyLevel.u206c⁯‭​‍⁪‎⁬​​⁫‍⁮‮‮⁬‮‍⁮‭​‮‭‭‫‫‪‭‏⁮⁬‮⁯⁯⁯‏‎⁯⁬‪‮ = new byte[2];
						return;
					}
				}
			}
			numArray = new byte[] { 1, 1, 0, 0 };
			PhyLevel.u200d‫‪⁬⁫‎⁮⁯⁯⁭‎​⁮⁯‭‭‍‭​⁮⁮‏‮‪⁬‏⁫⁭⁮⁬‍‏⁫​⁫‪⁫⁮‫‪‮ = numArray;
			PhyLevel.u206c⁯‭​‍⁪‎⁬​​⁫‍⁮‮‮⁬‮‍⁮‭​‮‭‭‫‫‪‭‏⁮⁬‮⁯⁯⁯‏‎⁯⁬‪‮ = new byte[2];
		}

		public PhyLevel()
		{
		Label1:
			int num = 12402103;
			while (true)
			{
				int num1 = num ^ 378035426;
				uint num2 = (uint)num1;
				switch (num1 % 5)
				{
					case 0:
					{
						this.u206b⁫⁬⁪​‪‌⁪‍⁫‫‬⁪‬​‏​‍‪‭​‭‌‮​⁮⁬⁪​‪‌⁪‍‬‎⁫⁫⁪‮‪‮ = (byte*)PhyLevel.u202d‭‪‌‮⁫‬‮‬⁯‮⁫⁮‏⁭⁮⁪⁭⁯⁯⁮‬⁪‌‮‏⁮⁭‎⁯‪‎⁫⁪⁪⁬⁯‪‭‏‮(this.u202d‍‏‬‮⁭‏‎‮​⁬‏⁬⁪‫⁭⁮​⁭‭‏‏⁪‎‍⁮⁬⁮‏​​‫‍‌‭‪‌⁫⁮‮‮);
						this.u206c‮‫‭‮⁫​⁯⁫⁭⁫⁬⁬‎⁫‌‌⁯‌⁯⁪‪⁭⁯‎‮‪‪‎⁯‮⁭‍‭‎‍⁯⁬‮⁪‮ = 0;
						return;
					}
					case 1:
					{
						this.u200d​‍​​‪‬‬‫‮‬‍‮‪⁬⁪‮‎⁪⁯⁬‎⁪‫‮‮‫⁯⁫‫‮‎‬‎‭‏‪‎‏⁬‮ = PhyLevel.u200d⁬‌‫⁮‫⁪⁪‏‫‌‌‭⁭‌‬​⁪‮‭‫‭‭‎⁮⁫⁭‎⁬⁭‮‮⁬‮⁮‎‍‏​⁬‮(510, 4);
						num = (int)(num2 * -876254479 ^ -1789424154);
						continue;
					}
					case 2:
					{
						this.u206f⁫⁮⁬‪‍‏‍​‪⁬​⁭⁬‎‫⁫‪‪‏​‎‪‏‏⁮‪‪‎‍⁮‎‍‎⁮‬​‬‭⁪‮ = PhyLevel.u200d⁬‌‫⁮‫⁪⁪‏‫‌‌‭⁭‌‬​⁪‮‭‫‭‭‎⁮⁫⁭‎⁬⁭‮‮⁬‮⁮‎‍‏​⁬‮(1020, 1);
						this.u206e‌‬‭⁪‎⁯‮​⁭⁯‌‍⁬⁭‬‍‍‌⁭⁯‌‮⁬‭‬‍⁯‌⁮​⁬‏‎⁪‌⁮‍‌‌‮ = (byte*)PhyLevel.u202d‭‪‌‮⁫‬‮‬⁯‮⁫⁮‏⁭⁮⁪⁭⁯⁯⁮‬⁪‌‮‏⁮⁭‎⁯‪‎⁫⁪⁪⁬⁯‪‭‏‮(this.u206f⁫⁮⁬‪‍‏‍​‪⁬​⁭⁬‎‫⁫‪‪‏​‎‪‏‏⁮‪‪‎‍⁮‎‍‎⁮‬​‬‭⁪‮);
						num = (int)(num2 * 1073680629 ^ 1808135637);
						continue;
					}
					case 3:
					{
						this.u202a⁮⁭‎‎⁪‬‭‌‭‎‌‫‭​‬‮⁫​‍⁬‎‪⁫⁫‏‫‎⁪​⁯‎‪‭⁭‎‭‏⁪‌‮ = (float*)PhyLevel.u202d‭‪‌‮⁫‬‮‬⁯‮⁫⁮‏⁭⁮⁪⁭⁯⁯⁮‬⁪‌‮‏⁮⁭‎⁯‪‎⁫⁪⁪⁬⁯‪‭‏‮(this.u200d​‍​​‪‬‬‫‮‬‍‮‪⁬⁪‮‎⁪⁯⁬‎⁪‫‮‮‫⁯⁫‫‮‎‬‎‭‏‪‎‏⁬‮);
						this.u202d‍‏‬‮⁭‏‎‮​⁬‏⁬⁪‫⁭⁮​⁭‭‏‏⁪‎‍⁮⁬⁮‏​​‫‍‌‭‪‌⁫⁮‮‮ = PhyLevel.u200d⁬‌‫⁮‫⁪⁪‏‫‌‌‭⁭‌‬​⁪‮‭‫‭‭‎⁮⁫⁭‎⁬⁭‮‮⁬‮⁮‎‍‏​⁬‮(510, 1);
						num = (int)(num2 * -467177721 ^ -1449930803);
						continue;
					}
					case 4:
					{
						goto Label1;
					}
				}
			}
			this.u206b⁫⁬⁪​‪‌⁪‍⁫‫‬⁪‬​‏​‍‪‭​‭‌‮​⁮⁬⁪​‪‌⁪‍‬‎⁫⁫⁪‮‪‮ = (byte*)PhyLevel.u202d‭‪‌‮⁫‬‮‬⁯‮⁫⁮‏⁭⁮⁪⁭⁯⁯⁮‬⁪‌‮‏⁮⁭‎⁯‪‎⁫⁪⁪⁬⁯‪‭‏‮(this.u202d‍‏‬‮⁭‏‎‮​⁬‏⁬⁪‫⁭⁮​⁭‭‏‏⁪‎‍⁮⁬⁮‏​​‫‍‌‭‪‌⁫⁮‮‮);
			this.u206c‮‫‭‮⁫​⁯⁫⁭⁫⁬⁬‎⁫‌‌⁯‌⁯⁪‪⁭⁯‎‮‪‪‎⁯‮⁭‍‭‎‍⁯⁬‮⁪‮ = 0;
		}

		public void Dispose()
		{
		}

		public unsafe void ExtractPhyChannels(Burst burst, byte* bbBuffer, byte* bkn1Buffer, byte* bkn2Buffer, byte* sb1Buffer)
		{
			// 
			// Current member / type: System.Void SDRSharp.Tetra.PhyLevel::ExtractPhyChannels(SDRSharp.Tetra.Burst,System.Byte*,System.Byte*,System.Byte*,System.Byte*)
			// File path: C:\SDRSharp\Plugins\Tetra\SDRSharp.Tetra.dll
			// 
			// Product version: 0.0.0.0
			// Exception in: System.Void ExtractPhyChannels(SDRSharp.Tetra.Burst,System.Byte*,System.Byte*,System.Byte*,System.Byte*)
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
		public unsafe Burst ParseTrainingSequence(float* inBuffer, int length, float* displayBufferPtr)
		{
			// 
			// Current member / type: SDRSharp.Tetra.Burst SDRSharp.Tetra.PhyLevel::ParseTrainingSequence(System.Single*,System.Int32,System.Single*)
			// File path: C:\SDRSharp\Plugins\Tetra\SDRSharp.Tetra.dll
			// 
			// Product version: 0.0.0.0
			// Exception in: SDRSharp.Tetra.Burst ParseTrainingSequence(System.Single*,System.Int32,System.Single*)
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
}