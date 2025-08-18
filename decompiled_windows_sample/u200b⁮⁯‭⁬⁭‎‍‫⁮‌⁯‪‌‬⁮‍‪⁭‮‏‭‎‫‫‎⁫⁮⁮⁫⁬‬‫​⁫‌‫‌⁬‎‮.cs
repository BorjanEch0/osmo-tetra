using SDRSharp.Common;
using SDRSharp.Radio;
using SDRSharp.Tetra;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;

// ​⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮
internal class u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮
{
	// ⁮⁪⁬‪‭‭‎‮⁮‌‏⁪‫⁯​⁪‏‫‌⁪⁫⁪⁬⁭‍‎⁯‏‪‬⁬‍⁫‮‎‬‬⁪⁬⁯‮
	private static string[] u206e⁪⁬‪‭‭‎‮⁮‌‏⁪‫⁯​⁪‏‫‌⁪⁫⁪⁬⁭‍‎⁯‏‪‬⁬‍⁫‮‎‬‬⁪⁬⁯‮;

	// ‍⁮‭⁮‪‍‍‬​‪⁫⁪‏‭‫​‫‬‌​⁯​⁫⁯‪⁭‏⁪‮‫⁯⁫⁫⁪⁯​‍⁭⁮⁯‮
	private static Dictionary<string, Func<bool, object, string>> u200d⁮‭⁮‪‍‍‬​‪⁫⁪‏‭‫​‫‬‌​⁯​⁫⁯‪⁭‏⁪‮‫⁯⁫⁫⁪⁯​‍⁭⁮⁯‮;

	// ⁫‏‭‫⁫‎‪‬‪⁪‎‪‍⁯‮‏‎⁮‏⁪‍‬‍⁯‭‏⁪⁭‫‬⁮‪⁮‭‍‫‎​​‍‮
	private ISharpControl u206b‏‭‫⁫‎‪‬‪⁪‎‪‍⁯‮‏‎⁮‏⁪‍‬‍⁯‭‏⁪⁭‫‬⁮‪⁮‭‍‫‎​​‍‮;

	// ⁪‪‭⁮‍‭⁭‌⁫​‏‮⁪‍⁪‭‍‬‪‏‬‎‎‏‪‪‮⁭⁫‍‌⁮⁪‪‌⁪‏⁯⁫‍‮
	private TetraPanel u206a‪‭⁮‍‭⁭‌⁫​‏‮⁪‍⁪‭‍‬‪‏‬‎‎‏‪‪‮⁭⁫‍‌⁮⁪‪‌⁪‏⁯⁫‍‮;

	[MethodImpl(MethodImplOptions.NoInlining)]
	// ‬‏⁪‫⁯‮⁬‫‏⁫‍⁯‫⁭‮‭‫⁮‎‭⁬⁭⁮‭‍‏‍‏‎⁬‍‫⁬‌‏‎⁪⁭‌‎‮
	public string u202c‏⁪‫⁯‮⁬‫‏⁫‍⁯‫⁭‮‭‫⁮‎‭⁬⁭⁮‭‍‏‍‏‎⁬‍‫⁬‌‏‎⁪⁭‌‎‮(string )
	{
		// 
		// Current member / type: System.String ​⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮::‬‏⁪‫⁯‮⁬‫‏⁫‍⁯‫⁭‮‭‫⁮‎‭⁬⁭⁮‭‍‏‍‏‎⁬‍‫⁬‌‏‎⁪⁭‌‎‮(System.String)
		// File path: C:\SDRSharp\Plugins\Tetra\SDRSharp.Tetra.dll
		// 
		// Product version: 0.0.0.0
		// Exception in: System.String ‬‏⁪‫⁯‮⁬‫‏⁫‍⁯‫⁭‮‭‫⁮‎‭⁬⁭⁮‭‍‏‍‏‎⁬‍‫⁬‌‏‎⁪⁭‌‎‮(System.String)
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
	// ‌‪‎⁬⁮⁯⁫‪‪‎‌‬‫‫‏​‫⁮‫⁬⁪‎‪⁪⁮‫‪⁬‏‌‭⁪‪⁮⁪⁭‭⁮‌‪‮
	private Dictionary<string, object> u200c‪‎⁬⁮⁯⁫‪‪‎‌‬‫‫‏​‫⁮‫⁬⁪‎‪⁪⁮‫‪⁬‏‌‭⁪‪⁮⁪⁭‭⁮‌‪‮(string )
	{
		// 
		// Current member / type: System.Collections.Generic.Dictionary`2<System.String,System.Object> ​⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮::‌‪‎⁬⁮⁯⁫‪‪‎‌‬‫‫‏​‫⁮‫⁬⁪‎‪⁪⁮‫‪⁬‏‌‭⁪‪⁮⁪⁭‭⁮‌‪‮(System.String)
		// File path: C:\SDRSharp\Plugins\Tetra\SDRSharp.Tetra.dll
		// 
		// Product version: 0.0.0.0
		// Exception in: System.Collections.Generic.Dictionary<System.String,System.Object> ‌‪‎⁬⁮⁯⁫‪‪‎‌‬‫‫‏​‫⁮‫⁬⁪‎‪⁪⁮‫‪⁬‏‌‭⁪‪⁮⁪⁭‭⁮‌‪‮(System.String)
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
	// ‌‌‭⁪⁫‍⁫‪⁪‌‌‬⁪⁬⁯‮‌​‬‏⁪‭⁮‭‬‏⁫⁫‏‎‌‫‏⁫‏‫‭‍⁯‬‮
	private string u200c‌‭⁪⁫‍⁫‪⁪‌‌‬⁪⁬⁯‮‌​‬‏⁪‭⁮‭‬‏⁫⁫‏‎‌‫‏⁫‏‫‭‍⁯‬‮(bool flag, object obj)
	{
		string str = null;
		if (!flag)
		{
			throw new u206f​⁭‍‌‍⁬⁪‬⁯⁮⁬⁮‭‬‫‬⁫‏⁮⁫‌‮‪⁮⁫‏⁪‏⁬‍‌⁯‍‭⁭‍⁯⁪⁯‮(u003cModuleu003e.u206f⁮​‌‪‮‎‭‏‮‎⁮⁮‮⁬⁫‍‍⁪‍⁫⁮‏​‎⁬⁯⁪‪‍⁪⁮‎⁬⁪⁫​⁮⁪⁮‮<string>(-1249216167));
		}
	Label1:
		int num = -1921887244;
		while (true)
		{
			int num1 = num ^ -1668258386;
			uint num2 = (uint)num1;
			switch (num1 % 5)
			{
				case 0:
				{
					goto Label1;
				}
				case 1:
				{
					str = this.u200d⁬‎‍⁭​⁫​‬‬⁬‍‏‏‮⁫‫‭‎‪‫‮‏⁬⁪⁯⁫⁭‫‌‬‪‌‏⁪‌⁯⁫⁬⁮‮<object>(null, null);
					num = (int)(num2 * -1865926149 ^ -2085240571);
					continue;
				}
				case 2:
				{
					this.u206a‪‭⁮‍‭⁭‌⁫​‏‮⁪‍⁪‭‍‬‪‏‬‎‎‏‪‪‮⁭⁫‍‌⁮⁪‪‌⁪‏⁯⁫‍‮.TcpReset = (int)obj;
					num = (int)(num2 * 1472645743 ^ 765567560);
					continue;
				}
				case 3:
				{
					break;
				}
				case 4:
				{
					return str;
				}
				default:
				{
					return str;
				}
			}
		}
		throw new u206f​⁭‍‌‍⁬⁪‬⁯⁮⁬⁮‭‬‫‬⁫‏⁮⁫‌‮‪⁮⁫‏⁪‏⁬‍‌⁯‍‭⁭‍⁯⁪⁯‮(u003cModuleu003e.u206f⁮​‌‪‮‎‭‏‮‎⁮⁮‮⁬⁫‍‍⁪‍⁫⁮‏​‎⁬⁯⁪‪‍⁪⁮‎⁬⁪⁫​⁮⁪⁮‮<string>(-1249216167));
		return str;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	// ⁭‎‮‭‪⁫‎⁭‎‌‪​⁯⁮‪‌⁮⁯‫‌‎‪‬‮‎​‏‏⁯‮‌‍⁭⁮‮‍⁭⁫‫‫‮
	private string u206d‎‮‭‪⁫‎⁭‎‌‪​⁯⁮‪‌⁮⁯‫‌‎‪‬‮‎​‏‏⁯‮‌‍⁭⁮‮‍⁭⁫‫‫‮(bool flag, object obj)
	{
		string str = null;
		if (!flag)
		{
			throw new u206f​⁭‍‌‍⁬⁪‬⁯⁮⁬⁮‭‬‫‬⁫‏⁮⁫‌‮‪⁮⁫‏⁪‏⁬‍‌⁯‍‭⁭‍⁯⁪⁯‮(u003cModuleu003e.u206f⁮​‌‪‮‎‭‏‮‎⁮⁮‮⁬⁫‍‍⁪‍⁫⁮‏​‎⁬⁯⁪‪‍⁪⁮‎⁬⁪⁫​⁮⁪⁮‮<string>(-1249216167));
		}
	Label2:
		int num = -958583801;
		while (true)
		{
			int num1 = num ^ -1481114584;
			uint num2 = (uint)num1;
			switch (num1 % 6)
			{
				case 0:
				{
					num = (int)(num2 * -1224527597 ^ -845623611);
					continue;
				}
				case 1:
				{
					return str;
				}
				case 2:
				{
					str = this.u200d⁬‎‍⁭​⁫​‬‬⁬‍‏‏‮⁫‫‭‎‪‫‮‏⁬⁪⁯⁫⁭‫‌‬‪‌‏⁪‌⁯⁫⁬⁮‮<object>(null, null);
					num = (int)(num2 * 609822054 ^ -1251010610);
					continue;
				}
				case 3:
				{
					break;
				}
				case 4:
				{
					goto Label2;
				}
				case 5:
				{
					this.u206a‪‭⁮‍‭⁭‌⁫​‏‮⁪‍⁪‭‍‬‪‏‬‎‎‏‪‪‮⁭⁫‍‌⁮⁪‪‌⁪‏⁯⁫‍‮.TimeSlot = (int)obj;
					num = (int)(num2 * 2144177452 ^ 469019242);
					continue;
				}
				default:
				{
					return str;
				}
			}
		}
		throw new u206f​⁭‍‌‍⁬⁪‬⁯⁮⁬⁮‭‬‫‬⁫‏⁮⁫‌‮‪⁮⁫‏⁪‏⁬‍‌⁯‍‭⁭‍⁯⁪⁯‮(u003cModuleu003e.u206f⁮​‌‪‮‎‭‏‮‎⁮⁮‮⁬⁫‍‍⁪‍⁫⁮‏​‎⁬⁯⁪‪‍⁪⁮‎⁬⁪⁫​⁮⁪⁮‮<string>(-1249216167));
		return str;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	// ⁯⁮‎‍‏⁬‮‌‍⁭‎‪‭‌‎‪‫‏‏⁯‌‭⁪‭‪⁫⁬⁭‏‌‭⁭⁮‎‭⁪⁬​‍‏‮
	private string u206f⁮‎‍‏⁬‮‌‍⁭‎‪‭‌‎‪‫‏‏⁯‌‭⁪‭‪⁫⁬⁭‏‌‭⁭⁮‎‭⁪⁬​‍‏‮(bool flag, object obj)
	{
		string str = null;
		if (!flag)
		{
			throw new u206f​⁭‍‌‍⁬⁪‬⁯⁮⁬⁮‭‬‫‬⁫‏⁮⁫‌‮‪⁮⁫‏⁪‏⁬‍‌⁯‍‭⁭‍⁯⁪⁯‮(u003cModuleu003e.u200d​‍⁮‏‭⁮⁪‌‪‬‬‬‪⁬⁭⁫⁫‬⁪⁬⁬⁬‏⁮⁭‌‍‏‍‏‎‬⁬​‪‎​‎⁭‮<string>(-701863214));
		}
	Label1:
		int num = -1654941725;
		while (true)
		{
			int num1 = num ^ -2027302051;
			uint num2 = (uint)num1;
			switch (num1 % 5)
			{
				case 0:
				{
					goto Label1;
				}
				case 1:
				{
					return str;
				}
				case 2:
				{
					str = this.u200d⁬‎‍⁭​⁫​‬‬⁬‍‏‏‮⁫‫‭‎‪‫‮‏⁬⁪⁯⁫⁭‫‌‬‪‌‏⁪‌⁯⁫⁬⁮‮<object>(null, null);
					num = (int)(num2 * 202158737 ^ 620498333);
					continue;
				}
				case 3:
				{
					this.u206a‪‭⁮‍‭⁭‌⁫​‏‮⁪‍⁪‭‍‬‪‏‬‎‎‏‪‪‮⁭⁫‍‌⁮⁪‪‌⁪‏⁯⁫‍‮.SdrSharpTitle = (int)obj;
					num = (int)(num2 * 146253183 ^ 18525761);
					continue;
				}
				case 4:
				{
					break;
				}
				default:
				{
					return str;
				}
			}
		}
		throw new u206f​⁭‍‌‍⁬⁪‬⁯⁮⁬⁮‭‬‫‬⁫‏⁮⁫‌‮‪⁮⁫‏⁪‏⁬‍‌⁯‍‭⁭‍⁯⁪⁯‮(u003cModuleu003e.u200d​‍⁮‏‭⁮⁪‌‪‬‬‬‪⁬⁭⁫⁫‬⁪⁬⁬⁬‏⁮⁭‌‍‏‍‏‎‬⁬​‪‎​‎⁭‮<string>(-701863214));
		return str;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	// ‮‌​‬‏‍‎‌‫‌⁭⁭⁬‌‪⁭‭‍‏‌⁮‌‌‏‏‏‫⁯‪⁫‍‫‪⁫⁬‬‏‫⁯‍‮
	private string u202e‌​‬‏‍‎‌‫‌⁭⁭⁬‌‪⁭‭‍‏‌⁮‌‌‏‏‏‫⁯‪⁫‍‫‪⁫⁬‬‏‫⁯‍‮(bool flag, object obj)
	{
		string str = null;
		if (!flag)
		{
			throw new u206f​⁭‍‌‍⁬⁪‬⁯⁮⁬⁮‭‬‫‬⁫‏⁮⁫‌‮‪⁮⁫‏⁪‏⁬‍‌⁯‍‭⁭‍⁯⁪⁯‮(u003cModuleu003e.u200e‏‌‬⁮‪‭⁭‭⁭‎​‏‌‭‭‭⁭⁬⁯⁫‍‮‫⁯‌‮‏​‬⁫⁯⁮⁫‮‪⁫‬⁮⁬‮<string>(-34424028));
		}
	Label2:
		int num = -1263872826;
		while (true)
		{
			int num1 = num ^ -1341801947;
			uint num2 = (uint)num1;
			switch (num1 % 5)
			{
				case 0:
				{
					break;
				}
				case 1:
				{
					this.u206a‪‭⁮‍‭⁭‌⁫​‏‮⁪‍⁪‭‍‬‪‏‬‎‎‏‪‪‮⁭⁫‍‌⁮⁪‪‌⁪‏⁯⁫‍‮.NetInfoTitle = (int)obj;
					str = this.u200d⁬‎‍⁭​⁫​‬‬⁬‍‏‏‮⁫‫‭‎‪‫‮‏⁬⁪⁯⁫⁭‫‌‬‪‌‏⁪‌⁯⁫⁬⁮‮<object>(null, null);
					num = (int)(num2 * 524038150 ^ -1503215813);
					continue;
				}
				case 2:
				{
					return str;
				}
				case 3:
				{
					goto Label2;
				}
				case 4:
				{
					num = (int)(num2 * 576349688 ^ -2138966614);
					continue;
				}
				default:
				{
					return str;
				}
			}
		}
		throw new u206f​⁭‍‌‍⁬⁪‬⁯⁮⁬⁮‭‬‫‬⁫‏⁮⁫‌‮‪⁮⁫‏⁪‏⁬‍‌⁯‍‭⁭‍⁯⁪⁯‮(u003cModuleu003e.u200e‏‌‬⁮‪‭⁭‭⁭‎​‏‌‭‭‭⁭⁬⁯⁫‍‮‫⁯‌‮‏​‬⁫⁯⁮⁫‮‪⁫‬⁮⁬‮<string>(-34424028));
		return str;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	// ⁯⁯⁮‎‍‫⁯‏⁪‫‫​⁪‭⁭⁪‮‎⁭‏‫‌⁫‍‫‎‬‫⁬‮‏‏⁮‭⁭‮‬‏‏⁮‮
	private string u206f⁯⁮‎‍‫⁯‏⁪‫‫​⁪‭⁭⁪‮‎⁭‏‫‌⁫‍‫‎‬‫⁬‮‏‏⁮‭⁭‮‬‏‏⁮‮(bool flag, object obj)
	{
		string str = null;
		int num = 0;
		long num1 = 0L;
		int num2 = 0;
		string str1 = null;
		int num3 = 0;
		int num4 = 0;
		int num5 = 0;
		uint num6;
		int num7;
		if (!flag)
		{
			throw new u206f​⁭‍‌‍⁬⁪‬⁯⁮⁬⁮‭‬‫‬⁫‏⁮⁫‌‮‪⁮⁫‏⁪‏⁬‍‌⁯‍‭⁭‍⁯⁪⁯‮(u003cModuleu003e.u202a‮‫‏‫‬‬‪⁫⁬​‏⁫⁭‍‪‪‎⁬​‪​‌⁮‮‌​⁫​⁬‪‫⁪⁯⁪‎‫⁭‎⁪‮<string>(-2134349641));
		}
	Label1:
		int num8 = -1043253061;
		while (true)
		{
			int num9 = num8 ^ -335842143;
			num6 = (uint)num9;
			switch (num9 % 10)
			{
				case 0:
				{
					num7 = (num == 1 ? -1220830103 : -2121381952);
					num8 = (int)(num7 ^ num6 * 919619949);
					continue;
				}
				case 1:
				{
					this.u200c‌⁬‮‮‭‍‬⁮‬⁫‪‭⁭‫‭⁫⁪‪​‏⁬⁫‮‬‏‌‍‬‍‌‫‭‮‮‍⁫‌⁯‎‮(num1, (long)1, 999999999999L);
					num8 = -2141557594;
					continue;
				}
				case 2:
				{
					this.u200c‌⁬‮‮‭‍‬⁮‬⁫‪‭⁭‫‭⁫⁪‪​‏⁬⁫‮‬‏‌‍‬‍‌‫‭‮‮‍⁫‌⁯‎‮((long)num3, (long)10, (long)250000);
					num8 = (int)(num6 * 465989586 ^ 1852230897);
					continue;
				}
				case 3:
				{
					u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮.u202c⁯‬‫‍​⁯‍‌⁪⁮⁪⁬‬‮‬‏‬⁭‪‏‬​‬‭⁫‫⁪⁯‌‪⁬‌⁯⁭⁮‌‭‭‎‮(this.u206b‏‭‫⁫‎‪‬‪⁪‎‪‍⁯‮‏‎⁮‏⁪‍‬‍⁯‭‏⁪⁭‫‬⁮‪⁮‭‍‫‎​​‍‮, (DetectorType)this.u202c‌⁮‏‫‍⁫‎⁪‪‌​​‏⁪⁫‌⁬⁯⁬⁫‍‮⁮⁬‏⁪⁬‬‍⁪⁬⁫‍⁮‫‪‭‫‍‮(str1, u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮.u200c⁪‍​⁭‫‬‫⁬‎⁯​‎‪‌‌⁬‍‬‮⁮‮⁯‮‎‬⁪⁬⁫‪⁯⁬‏‬‎‏‭‭‫⁪‮(typeof(DetectorType).TypeHandle)));
					num8 = (int)(num6 * 417794798 ^ -331852571);
					continue;
				}
				case 4:
				{
					this.u206a‪‭⁮‍‭⁭‌⁫​‏‮⁪‍⁪‭‍‬‪‏‬‎‎‏‪‪‮⁭⁫‍‌⁮⁪‪‌⁪‏⁯⁫‍‮.TttInit = num;
					num8 = (int)(num6 * 1504891839 ^ -1820396048);
					continue;
				}
				case 5:
				{
					goto Label1;
				}
				case 6:
				{
					string[] strArrays = u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮.u200d⁬⁫‪‎​‭‌⁫‌​‎‌‪‭‫⁮‌​⁭‬‮⁪⁯⁬⁬‮⁭⁪‌‭‫⁪‭⁫⁯‌​‮‭‮((string)obj, new char[] { '|' });
					num = u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮.u202e‌‫⁪‌‭⁮‍⁫⁭⁪⁮‭‪‪​‌⁭‬‏‍⁮‏‌⁮‎‏⁬⁯‪⁯​⁫⁯⁫⁯‬⁮​‎‮(strArrays[0]);
					num1 = u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮.u202e‪‬⁪‌‌⁪‌‪⁬‍‪⁯⁪‫‫⁯‬‫⁫‎‪‎​‍‬⁭​‌‌⁮‬‏⁮⁫⁮‏‌‬⁫‮(strArrays[1]);
					num2 = u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮.u202e‌‫⁪‌‭⁮‍⁫⁭⁪⁮‭‪‪​‌⁭‬‏‍⁮‏‌⁮‎‏⁬⁯‪⁯​⁫⁯⁫⁯‬⁮​‎‮(strArrays[2]);
					str1 = strArrays[3];
					num3 = u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮.u202e‌‫⁪‌‭⁮‍⁫⁭⁪⁮‭‪‪​‌⁭‬‏‍⁮‏‌⁮‎‏⁬⁯‪⁯​⁫⁯⁫⁯‬⁮​‎‮(strArrays[4]);
					num4 = u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮.u202e‌‫⁪‌‭⁮‍⁫⁭⁪⁮‭‪‪​‌⁭‬‏‍⁮‏‌⁮‎‏⁬⁯‪⁯​⁫⁯⁫⁯‬⁮​‎‮(strArrays[5]);
					num5 = u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮.u202e‌‫⁪‌‭⁮‍⁫⁭⁪⁮‭‪‪​‌⁭‬‏‍⁮‏‌⁮‎‏⁬⁯‪⁯​⁫⁯⁫⁯‬⁮​‎‮(strArrays[6]);
					num8 = (int)(num6 * -1157308817 ^ -810657005);
					continue;
				}
				case 7:
				{
					this.u206a‪‭⁮‍‭⁭‌⁫​‏‮⁪‍⁪‭‍‬‪‏‬‎‎‏‪‪‮⁭⁫‍‌⁮⁪‪‌⁪‏⁯⁫‍‮.TimeSlot = num2;
					num8 = (int)(num6 * -1079863722 ^ 314953186);
					continue;
				}
				case 8:
				{
					goto Label2;
				}
				case 9:
				{
					u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮.u202a⁫‮‎⁮​⁬‎‪⁬‮‎‪⁪‍‬‪⁬‬​‌‬⁮‌⁬‫‮‍‏‌‭‮‏‪‎⁮‌‬⁬‫‮(this.u206b‏‭‫⁫‎‪‬‪⁪‎‪‍⁯‮‏‎⁮‏⁪‍‬‍⁯‭‏⁪⁭‫‬⁮‪⁮‭‍‫‎​​‍‮, num1);
					num8 = (int)(num6 * 1787310046 ^ 1827858412);
					continue;
				}
			}
		}
	Label2:
		u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮.u206a‬‮⁬‭‌⁬‭‌⁯‍⁬⁭‌⁯‎‪‌‎‍‮‭‬⁬⁮‬⁫‍⁯⁫⁮‌‬⁪⁪‬⁫‬‭‫‮(this.u206b‏‭‫⁫‎‪‬‪⁪‎‪‍⁯‮‏‎⁮‏⁪‍‬‍⁯‭‏⁪⁭‫‬⁮‪⁮‭‍‫‎​​‍‮, num3);
		this.u200c‌⁬‮‮‭‍‬⁮‬⁫‪‭⁭‫‭⁫⁪‪​‏⁬⁫‮‬‏‌‍‬‍‌‫‭‮‮‍⁫‌⁯‎‮((long)num4, (long)20, (long)60);
		try
		{
			u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮.u200b‬‏‎‮‎‎‮‪⁪‪‫⁬⁯​‌‌‭‪⁭‫‫‌‪‎‭‌‌⁬‌‭‮⁯⁮‮‮‭⁬‬‮‮(this.u206b‏‭‫⁫‎‪‬‪⁪‎‪‍⁯‮‏‎⁮‏⁪‍‬‍⁯‭‏⁪⁭‫‬⁮‪⁮‭‍‫‎​​‍‮, num4);
		}
		catch
		{
		Label3:
			int num10 = -1343649945;
			while (true)
			{
				int num11 = num10 ^ -335842143;
				num6 = (uint)num11;
				switch (num11 % 3)
				{
					case 0:
					{
						goto Label3;
					}
					case 1:
					{
						goto Label4;
					}
					case 2:
					{
						u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮.u200b‬‏‎‮‎‎‮‪⁪‪‫⁬⁯​‌‌‭‪⁭‫‫‌‪‎‭‌‌⁬‌‭‮⁯⁮‮‮‭⁬‬‮‮(this.u206b‏‭‫⁫‎‪‬‪⁪‎‪‍⁯‮‏‎⁮‏⁪‍‬‍⁯‭‏⁪⁭‫‬⁮‪⁮‭‍‫‎​​‍‮, 25);
						num10 = (int)(num6 * 1809241615 ^ -1427763201);
						continue;
					}
				}
			}
		Label4:
		}
		this.u206a‪‭⁮‍‭⁭‌⁫​‏‮⁪‍⁪‭‍‬‪‏‬‎‎‏‪‪‮⁭⁫‍‌⁮⁪‪‌⁪‏⁯⁫‍‮.SdrSharpTitle = num5;
	Label5:
		int num12 = -2053517217;
		while (true)
		{
			int num13 = num12 ^ -335842143;
			num6 = (uint)num13;
			switch (num13 % 5)
			{
				case 0:
				{
					goto Label5;
				}
				case 1:
				{
					this.u206a‪‭⁮‍‭⁭‌⁫​‏‮⁪‍⁪‭‍‬‪‏‬‎‎‏‪‪‮⁭⁫‍‌⁮⁪‪‌⁪‏⁯⁫‍‮.NetInfoTitle = num5;
					num12 = (int)(num6 * 18308718 ^ -807896773);
					continue;
				}
				case 2:
				{
					str = this.u200d⁬‎‍⁭​⁫​‬‬⁬‍‏‏‮⁫‫‭‎‪‫‮‏⁬⁪⁯⁫⁭‫‌‬‪‌‏⁪‌⁯⁫⁬⁮‮<object>(null, null);
					num12 = (int)(num6 * -1453542517 ^ -2087562348);
					continue;
				}
				case 3:
				{
					break;
				}
				case 4:
				{
					return str;
				}
				default:
				{
					return str;
				}
			}
		}
		throw new u206f​⁭‍‌‍⁬⁪‬⁯⁮⁬⁮‭‬‫‬⁫‏⁮⁫‌‮‪⁮⁫‏⁪‏⁬‍‌⁯‍‭⁭‍⁯⁪⁯‮(u003cModuleu003e.u202a‮‫‏‫‬‬‪⁫⁬​‏⁫⁭‍‪‪‎⁬​‪​‌⁮‮‌​⁫​⁬‪‫⁪⁯⁪‎‫⁭‎⁪‮<string>(-2134349641));
		return str;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	// ⁯‫‎⁪‌⁫⁭‫‮‪⁮⁮⁭⁯⁮‎‬‮‏‎‫‫⁯‏‬⁮​‮​⁭‫‏‬​‍‭‎‌‍‏‮
	private string u206f‫‎⁪‌⁫⁭‫‮‪⁮⁮⁭⁯⁮‎‬‮‏‎‫‫⁯‏‬⁮​‮​⁭‫‏‬​‍‭‎‌‍‏‮(bool flag, object obj)
	{
		string str;
		long num = 0L;
		int num1 = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		int num5 = 0;
		int num6;
		int num7;
		int num8;
		object obj1;
		if (!flag)
		{
			throw new u206f​⁭‍‌‍⁬⁪‬⁯⁮⁬⁮‭‬‫‬⁫‏⁮⁫‌‮‪⁮⁫‏⁪‏⁬‍‌⁯‍‭⁭‍⁯⁪⁯‮(u003cModuleu003e.u206f⁮​‌‪‮‎‭‏‮‎⁮⁮‮⁬⁫‍‍⁪‍⁫⁮‏​‎⁬⁯⁪‪‍⁪⁮‎⁬⁪⁫​⁮⁪⁮‮<string>(-1249216167));
		}
	Label1:
		int num9 = -306495228;
		while (true)
		{
			int num10 = num9 ^ -525767607;
			uint num11 = (uint)num10;
			switch (num10 % 8)
			{
				case 0:
				{
					num6 = (num == (long)1 ? 1689376950 : 577374010);
					num9 = (int)(num6 ^ num11 * 437290947);
					continue;
				}
				case 1:
				{
					this.u200c‌⁬‮‮‭‍‬⁮‬⁫‪‭⁭‫‭⁫⁪‪​‏⁬⁫‮‬‏‌‍‬‍‌‫‭‮‮‍⁫‌⁯‎‮(num, (long)1, 999999999999L);
					num7 = (num3 != 1 ? -1646747212 : -1289578183);
					num9 = (int)(num7 ^ num11 * -998746622);
					continue;
				}
				case 2:
				{
					num8 = (u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮.u200c⁪⁭⁯‮‍⁯⁭‏‪⁫⁬‎‍⁭⁮‍‍⁫⁭‮‏‭​⁪⁪⁮‏⁮‮‎‪⁪‮⁭‭‍‪⁬⁪‮(this.u206b‏‭‫⁫‎‪‬‪⁪‎‪‍⁯‮‏‎⁮‏⁪‍‬‍⁯‭‏⁪⁭‫‬⁮‪⁮‭‍‫‎​​‍‮) == num ? 527639242 : 1248296725);
					num9 = (int)(num8 ^ num11 * -390474842);
					continue;
				}
				case 3:
				{
					u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮.u202a⁫‮‎⁮​⁬‎‪⁬‮‎‪⁪‍‬‪⁬‬​‌‬⁮‌⁬‫‮‍‏‌‭‮‏‪‎⁮‌‬⁬‫‮(this.u206b‏‭‫⁫‎‪‬‪⁪‎‪‍⁯‮‏‎⁮‏⁪‍‬‍⁯‭‏⁪⁭‫‬⁮‪⁮‭‍‫‎​​‍‮, num);
					num9 = (int)(num11 * -788557112 ^ 543578462);
					continue;
				}
				case 4:
				{
					this.u206a‪‭⁮‍‭⁭‌⁫​‏‮⁪‍⁪‭‍‬‪‏‬‎‎‏‪‪‮⁭⁫‍‌⁮⁪‪‌⁪‏⁯⁫‍‮.UsageMarker2 = num5;
					this.u200c‌⁬‮‮‭‍‬⁮‬⁫‪‭⁭‫‭⁫⁪‪​‏⁬⁫‮‬‏‌‍‬‍‌‫‭‮‮‍⁫‌⁯‎‮((long)num2, (long)20, (long)60);
					try
					{
						u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮.u200b‬‏‎‮‎‎‮‪⁪‪‫⁬⁯​‌‌‭‪⁭‫‫‌‪‎‭‌‌⁬‌‭‮⁯⁮‮‮‭⁬‬‮‮(this.u206b‏‭‫⁫‎‪‬‪⁪‎‪‍⁯‮‏‎⁮‏⁪‍‬‍⁯‭‏⁪⁭‫‬⁮‪⁮‭‍‫‎​​‍‮, num2);
					}
					catch
					{
						obj1 = obj2;
						u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮.u200b‬‏‎‮‎‎‮‪⁪‪‫⁬⁯​‌‌‭‪⁭‫‫‌‪‎‭‌‌⁬‌‭‮⁯⁮‮‮‭⁬‬‮‮(this.u206b‏‭‫⁫‎‪‬‪⁪‎‪‍⁯‮‏‎⁮‏⁪‍‬‍⁯‭‏⁪⁭‫‬⁮‪⁮‭‍‫‎​​‍‮, 25);
					}
					str = this.u200d⁬‎‍⁭​⁫​‬‬⁬‍‏‏‮⁫‫‭‎‪‫‮‏⁬⁪⁯⁫⁭‫‌‬‪‌‏⁪‌⁯⁫⁬⁮‮<object>(null, null);
					return str;
				}
				case 5:
				{
					string[] strArrays = u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮.u200d⁬⁫‪‎​‭‌⁫‌​‎‌‪‭‫⁮‌​⁭‬‮⁪⁯⁬⁬‮⁭⁪‌‭‫⁪‭⁫⁯‌​‮‭‮((string)obj, new char[] { '|' });
					num = u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮.u202e‪‬⁪‌‌⁪‌‪⁬‍‪⁯⁪‫‫⁯‬‫⁫‎‪‎​‍‬⁭​‌‌⁮‬‏⁮⁫⁮‏‌‬⁫‮(strArrays[0]);
					num1 = u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮.u202e‌‫⁪‌‭⁮‍⁫⁭⁪⁮‭‪‪​‌⁭‬‏‍⁮‏‌⁮‎‏⁬⁯‪⁯​⁫⁯⁫⁯‬⁮​‎‮(strArrays[1]);
					num2 = u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮.u202e‌‫⁪‌‭⁮‍⁫⁭⁪⁮‭‪‪​‌⁭‬‏‍⁮‏‌⁮‎‏⁬⁯‪⁯​⁫⁯⁫⁯‬⁮​‎‮(strArrays[2]);
					num3 = u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮.u202e‌‫⁪‌‭⁮‍⁫⁭⁪⁮‭‪‪​‌⁭‬‏‍⁮‏‌⁮‎‏⁬⁯‪⁯​⁫⁯⁫⁯‬⁮​‎‮(strArrays[3]);
					num4 = u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮.u202e‌‫⁪‌‭⁮‍⁫⁭⁪⁮‭‪‪​‌⁭‬‏‍⁮‏‌⁮‎‏⁬⁯‪⁯​⁫⁯⁫⁯‬⁮​‎‮(strArrays[4]);
					num5 = u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮.u202e‌‫⁪‌‭⁮‍⁫⁭⁪⁮‭‪‪​‌⁭‬‏‍⁮‏‌⁮‎‏⁬⁯‪⁯​⁫⁯⁫⁯‬⁮​‎‮(strArrays[5]);
					num9 = (int)(num11 * -1764421249 ^ 702243363);
					continue;
				}
				case 6:
				{
					goto Label1;
				}
				case 7:
				{
					this.u206a‪‭⁮‍‭⁭‌⁫​‏‮⁪‍⁪‭‍‬‪‏‬‎‎‏‪‪‮⁭⁫‍‌⁮⁪‪‌⁪‏⁯⁫‍‮.TimeSlot = num1;
					this.u206a‪‭⁮‍‭⁭‌⁫​‏‮⁪‍⁪‭‍‬‪‏‬‎‎‏‪‪‮⁭⁫‍‌⁮⁪‪‌⁪‏⁯⁫‍‮.UsageMarker1 = num4;
					num9 = -521045963;
					continue;
				}
			}
		}
		this.u206a‪‭⁮‍‭⁭‌⁫​‏‮⁪‍⁪‭‍‬‪‏‬‎‎‏‪‪‮⁭⁫‍‌⁮⁪‪‌⁪‏⁯⁫‍‮.UsageMarker2 = num5;
		this.u200c‌⁬‮‮‭‍‬⁮‬⁫‪‭⁭‫‭⁫⁪‪​‏⁬⁫‮‬‏‌‍‬‍‌‫‭‮‮‍⁫‌⁯‎‮((long)num2, (long)20, (long)60);
		try
		{
			u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮.u200b‬‏‎‮‎‎‮‪⁪‪‫⁬⁯​‌‌‭‪⁭‫‫‌‪‎‭‌‌⁬‌‭‮⁯⁮‮‮‭⁬‬‮‮(this.u206b‏‭‫⁫‎‪‬‪⁪‎‪‍⁯‮‏‎⁮‏⁪‍‬‍⁯‭‏⁪⁭‫‬⁮‪⁮‭‍‫‎​​‍‮, num2);
		}
		catch
		{
			obj1 = obj2;
			u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮.u200b‬‏‎‮‎‎‮‪⁪‪‫⁬⁯​‌‌‭‪⁭‫‫‌‪‎‭‌‌⁬‌‭‮⁯⁮‮‮‭⁬‬‮‮(this.u206b‏‭‫⁫‎‪‬‪⁪‎‪‍⁯‮‏‎⁮‏⁪‍‬‍⁯‭‏⁪⁭‫‬⁮‪⁮‭‍‫‎​​‍‮, 25);
		}
		str = this.u200d⁬‎‍⁭​⁫​‬‬⁬‍‏‏‮⁫‫‭‎‪‫‮‏⁬⁪⁯⁫⁭‫‌‬‪‌‏⁪‌⁯⁫⁬⁮‮<object>(null, null);
		return str;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	// ‭​⁮⁪‮‎‭‬‮‎⁫‪‎⁪⁭​‬‮​‏‪‎‫‪‌‎‎⁯‌‎⁫‫⁬‭‪‏⁮‎⁮‬‮
	private string u202d​⁮⁪‮‎‭‬‮‎⁫‪‎⁪⁭​‬‮​‏‪‎‫‪‌‎‎⁯‌‎⁫‫⁬‭‪‏⁮‎⁮‬‮(bool flag, object obj)
	{
		string str = null;
		int num;
		if (!flag)
		{
			goto Label0;
		}
	Label1:
		num = -903516510;
	Label4:
		while (true)
		{
			int num1 = num ^ -1803397922;
			uint num2 = (uint)num1;
			switch (num1 % 5)
			{
				case 0:
				{
					goto Label1;
				}
				case 1:
				{
					break;
				}
				case 2:
				{
					return str;
				}
				case 3:
				{
					str = this.u200d⁬‎‍⁭​⁫​‬‬⁬‍‏‏‮⁫‫‭‎‪‫‮‏⁬⁪⁯⁫⁭‫‌‬‪‌‏⁪‌⁯⁫⁬⁮‮<object>(null, null);
					num = (int)(num2 * -1950808328 ^ -832333454);
					continue;
				}
				case 4:
				{
					num = (int)(num2 * 723564106 ^ 1375129755);
					continue;
				}
				default:
				{
					return str;
				}
			}
		}
	Label0:
		str = this.u200d⁬‎‍⁭​⁫​‬‬⁬‍‏‏‮⁫‫‭‎‪‫‮‏⁬⁪⁯⁫⁭‫‌‬‪‌‏⁪‌⁯⁫⁬⁮‮<string>(u003cModuleu003e.u200f⁫‌​⁬‌‎‎‏‍‍⁫‎​‌‬⁯‬‫‭‎‏​‌​⁪‭‬⁬‮⁬​‌⁬⁪‫‫‎⁪⁮‮<string>(-1585933), this.u206a‪‭⁮‍‭⁭‌⁫​‏‮⁪‍⁪‭‍‬‪‏‬‎‎‏‪‪‮⁭⁫‍‌⁮⁪‪‌⁪‏⁯⁫‍‮.GetSysInfo);
		num = -1772731677;
		goto Label4;
		return str;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	// ‭‪‍‮⁬‎‭‏⁪⁬‏⁮⁯‍‍‎‪‍‌⁭⁬⁯‌‏‮⁫‮‫‭‫‮​‌⁬‎⁭⁬⁭‏‮
	private string u202d‪‍‮⁬‎‭‏⁪⁬‏⁮⁯‍‍‎‪‍‌⁭⁬⁯‌‏‮⁫‮‫‭‫‮​‌⁬‎⁭⁬⁭‏‮(bool flag, object obj)
	{
		string str = null;
		string[] strArrays = null;
		string empty = null;
		int num;
		int num1;
		if (!flag)
		{
			goto Label0;
		}
	Label2:
		num = -270538900;
	Label4:
		while (true)
		{
			int num2 = num ^ -818890966;
			uint num3 = (uint)num2;
			switch (num2 % 11)
			{
				case 0:
				{
					empty = u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮.u206c⁭‌⁬⁬‬⁪⁮⁯‏‭‫⁭‎⁪⁮‪⁯⁮‎⁬‏⁪‭⁫‭​‮⁬⁭⁫⁮‍⁪‏‍‬‬‬‬‮(empty, u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮.u200f⁮‮‌‫‍‬​‌‫‍‬‫‬⁮⁫⁮‏‮​⁫⁫‫‌⁪⁭‭‭⁭⁭‫‏‎‬‮‍⁬‍⁫⁬‮(u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮.u202d‌‭⁭⁫‌​‎‬‪‌‏⁯⁮⁪‬‭‎‬⁫⁫⁪⁫‫‪⁭⁭‪​‫‭⁮‫​‎​‭​‏‍‮(this.u206a‪‭⁮‍‭⁭‌⁫​‏‮⁪‍⁪‭‍‬‪‏‬‎‎‏‪‪‮⁭⁫‍‌⁮⁪‪‌⁪‏⁯⁫‍‮)), u003cModuleu003e.u200e‏‌‬⁮‪‭⁭‭⁭‎​‏‌‭‭‭⁭⁬⁯⁫‍‮‫⁯‌‮‏​‬⁫⁯⁮⁫‮‪⁫‬⁮⁬‮<string>(-421459766));
					empty = u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮.u206c⁭‌⁬⁬‬⁪⁮⁯‏‭‫⁭‎⁪⁮‪⁯⁮‎⁬‏⁪‭⁫‭​‮⁬⁭⁫⁮‍⁪‏‍‬‬‬‬‮(empty, u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮.u206d⁮‭‭‎‌‌‍‭‭‍‏⁫⁫‏‭⁯‏⁯‍‪‫‌​‎​‪‌⁬⁪⁯‮‏‪‭‬‎‮‍‪‮(u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮.u202d‌‭⁭⁫‌​‎‬‪‌‏⁯⁮⁪‬‭‎‬⁫⁫⁪⁫‫‪⁭⁭‪​‫‭⁮‫​‎​‭​‏‍‮(this.u206a‪‭⁮‍‭⁭‌⁫​‏‮⁪‍⁪‭‍‬‪‏‬‎‎‏‪‪‮⁭⁫‍‌⁮⁪‪‌⁪‏⁯⁫‍‮)), u003cModuleu003e.u200f⁫‌​⁬‌‎‎‏‍‍⁫‎​‌‬⁯‬‫‭‎‏​‌​⁪‭‬⁬‮⁬​‌⁬⁪‫‫‎⁪⁮‮<string>(-1348028598));
					num = -791790014;
					continue;
				}
				case 1:
				{
					break;
				}
				case 2:
				{
					u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮.u206b⁬‬‏‎⁯‎​‏‏‪⁪​‫⁯‬‮⁯⁪⁪⁪⁭‫⁮‌⁪⁯​⁬⁮‪‫​‎⁫⁭‏​‌‎‮(u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮.u202d‌‭⁭⁫‌​‎‬‪‌‏⁯⁮⁪‬‭‎‬⁫⁫⁪⁫‫‪⁭⁭‪​‫‭⁮‫​‎​‭​‏‍‮(this.u206a‪‭⁮‍‭⁭‌⁫​‏‮⁪‍⁪‭‍‬‪‏‬‎‎‏‪‪‮⁭⁫‍‌⁮⁪‪‌⁪‏⁯⁫‍‮), u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮.u202e‌‫⁪‌‭⁮‍⁫⁭⁪⁮‭‪‪​‌⁭‬‏‍⁮‏‌⁮‎‏⁬⁯‪⁯​⁫⁯⁫⁯‬⁮​‎‮(strArrays[3]));
					u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮.u206d‬⁯‫‍‪⁪⁭‏‎‍‬‎⁭‭‎‭⁪‍‏‭‏‪‭‭⁯⁮⁯⁭‫‫‭⁫⁮‮‮‍‏‮⁪‮(u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮.u202d‌‭⁭⁫‌​‎‬‪‌‏⁯⁮⁪‬‭‎‬⁫⁫⁪⁫‫‪⁭⁭‪​‫‭⁮‫​‎​‭​‏‍‮(this.u206a‪‭⁮‍‭⁭‌⁫​‏‮⁪‍⁪‭‍‬‪‏‬‎‎‏‪‪‮⁭⁫‍‌⁮⁪‪‌⁪‏⁯⁫‍‮), (FormWindowState)u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮.u202e‌‫⁪‌‭⁮‍⁫⁭⁪⁮‭‪‪​‌⁭‬‏‍⁮‏‌⁮‎‏⁬⁯‪⁯​⁫⁯⁫⁯‬⁮​‎‮(strArrays[4]));
					str = this.u200d⁬‎‍⁭​⁫​‬‬⁬‍‏‏‮⁫‫‭‎‪‫‮‏⁬⁪⁯⁫⁭‫‌‬‪‌‏⁪‌⁯⁫⁬⁮‮<object>(null, null);
					num = (int)(num3 * 1412844379 ^ 1141567285);
					continue;
				}
				case 3:
				{
					strArrays = u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮.u200d⁬⁫‪‎​‭‌⁫‌​‎‌‪‭‫⁮‌​⁭‬‮⁪⁯⁬⁬‮⁭⁪‌‭‫⁪‭⁫⁯‌​‮‭‮((string)obj, new char[] { '|' });
					u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮.u202d‏‏‪⁫⁬⁪‍⁭​‎‌‪‪‮⁭‭⁪⁭‫⁫⁪‫‏​‮‬‏‬‎‮⁫​‎‭‏‫‌​‮‮(u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮.u202d‌‭⁭⁫‌​‎‬‪‌‏⁯⁮⁪‬‭‎‬⁫⁫⁪⁫‫‪⁭⁭‪​‫‭⁮‫​‎​‭​‏‍‮(this.u206a‪‭⁮‍‭⁭‌⁫​‏‮⁪‍⁪‭‍‬‪‏‬‎‎‏‪‪‮⁭⁫‍‌⁮⁪‪‌⁪‏⁯⁫‍‮), u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮.u202e‌‫⁪‌‭⁮‍⁫⁭⁪⁮‭‪‪​‌⁭‬‏‍⁮‏‌⁮‎‏⁬⁯‪⁯​⁫⁯⁫⁯‬⁮​‎‮(strArrays[0]));
					u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮.u202e‪⁫⁭⁭‫‪‭‪‬‬‭‏‬‌‌⁬‎⁮‌‏‏⁮⁪⁭‭‭‎⁭‏‫‭⁬⁮​‫‍‫‬‎‮(u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮.u202d‌‭⁭⁫‌​‎‬‪‌‏⁯⁮⁪‬‭‎‬⁫⁫⁪⁫‫‪⁭⁭‪​‫‭⁮‫​‎​‭​‏‍‮(this.u206a‪‭⁮‍‭⁭‌⁫​‏‮⁪‍⁪‭‍‬‪‏‬‎‎‏‪‪‮⁭⁫‍‌⁮⁪‪‌⁪‏⁯⁫‍‮), u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮.u202e‌‫⁪‌‭⁮‍⁫⁭⁪⁮‭‪‪​‌⁭‬‏‍⁮‏‌⁮‎‏⁬⁯‪⁯​⁫⁯⁫⁯‬⁮​‎‮(strArrays[1]));
					num = (int)(num3 * 2357837 ^ 1714215204);
					continue;
				}
				case 4:
				{
					u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮.u202b‮⁬‎⁭‭‪​⁫⁫‬⁬‮⁮​‭⁮‌‬⁯​​⁭‍‏‏‍‬‌⁯‌⁮⁮‍⁬⁪‎⁬‫‮‮(u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮.u202d‌‭⁭⁫‌​‎‬‪‌‏⁯⁮⁪‬‭‎‬⁫⁫⁪⁫‫‪⁭⁭‪​‫‭⁮‫​‎​‭​‏‍‮(this.u206a‪‭⁮‍‭⁭‌⁫​‏‮⁪‍⁪‭‍‬‪‏‬‎‎‏‪‪‮⁭⁫‍‌⁮⁪‪‌⁪‏⁯⁫‍‮), u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮.u202e‌‫⁪‌‭⁮‍⁫⁭⁪⁮‭‪‪​‌⁭‬‏‍⁮‏‌⁮‎‏⁬⁯‪⁯​⁫⁯⁫⁯‬⁮​‎‮(strArrays[2]));
					num = (int)(num3 * 1474436202 ^ -731720522);
					continue;
				}
				case 5:
				{
					empty = u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮.u206b‭‎⁬‪⁮⁬‏​⁫⁫‮‭⁫‫‭‪⁬​‬‬⁫⁪‭‭​⁬⁬‮‎‪‏⁪‍‭⁯⁮⁭‮⁬‮(empty, u003cModuleu003e.u200e‏‌‬⁮‪‭⁭‭⁭‎​‏‌‭‭‭⁭⁬⁯⁫‍‮‫⁯‌‮‏​‬⁫⁯⁮⁫‮‪⁫‬⁮⁬‮<string>(1909737176));
					num = -2082422979;
					continue;
				}
				case 6:
				{
					empty = u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮.u206b‭‎⁬‪⁮⁬‏​⁫⁫‮‭⁫‫‭‪⁬​‬‬⁫⁪‭‭​⁬⁬‮‎‪‏⁪‍‭⁯⁮⁭‮⁬‮(empty, u003cModuleu003e.u200d​‍⁮‏‭⁮⁪‌‪‬‬‬‪⁬⁭⁫⁫‬⁪⁬⁬⁬‏⁮⁭‌‍‏‍‏‎‬⁬​‪‎​‎⁭‮<string>(-1444454452));
					num = -2082422979;
					continue;
				}
				case 7:
				{
					num1 = (this.u206a‪‭⁮‍‭⁭‌⁫​‏‮⁪‍⁪‭‍‬‪‏‬‎‎‏‪‪‮⁭⁫‍‌⁮⁪‪‌⁪‏⁯⁫‍‮.TttRole ? -2008495026 : -908389471);
					num = (int)(num1 ^ num3 * -1345060584);
					continue;
				}
				case 8:
				{
					empty = u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮.u206c⁭‌⁬⁬‬⁪⁮⁯‏‭‫⁭‎⁪⁮‪⁯⁮‎⁬‏⁪‭⁫‭​‮⁬⁭⁫⁮‍⁪‏‍‬‬‬‬‮(empty, u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮.u206c⁫‍⁫⁬⁪​⁫‎‬‬⁪‬‫‬‬‎⁫‫⁬‬⁯‪‮⁯⁬‏‌‮‪‎‬⁭⁯‏‌⁭⁯​‬‮(u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮.u202d‌‭⁭⁫‌​‎‬‪‌‏⁯⁮⁪‬‭‎‬⁫⁫⁪⁫‫‪⁭⁭‪​‫‭⁮‫​‎​‭​‏‍‮(this.u206a‪‭⁮‍‭⁭‌⁫​‏‮⁪‍⁪‭‍‬‪‏‬‎‎‏‪‪‮⁭⁫‍‌⁮⁪‪‌⁪‏⁯⁫‍‮)), u003cModuleu003e.u200e‏‌‬⁮‪‭⁭‭⁭‎​‏‌‭‭‭⁭⁬⁯⁫‍‮‫⁯‌‮‏​‬⁫⁯⁮⁫‮‪⁫‬⁮⁬‮<string>(-421459766));
					empty = u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮.u206c⁭‌⁬⁬‬⁪⁮⁯‏‭‫⁭‎⁪⁮‪⁯⁮‎⁬‏⁪‭⁫‭​‮⁬⁭⁫⁮‍⁪‏‍‬‬‬‬‮(empty, u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮.u200c‎⁮‏‬⁯‍‬⁪⁭‪‮⁭‍‌⁬⁯‭‪‬‮‫‌⁪⁮​‌⁬‏⁪‪⁫⁮⁫‭⁪⁬‬‬⁬‮(u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮.u202d‌‭⁭⁫‌​‎‬‪‌‏⁯⁮⁪‬‭‎‬⁫⁫⁪⁫‫‪⁭⁭‪​‫‭⁮‫​‎​‭​‏‍‮(this.u206a‪‭⁮‍‭⁭‌⁫​‏‮⁪‍⁪‭‍‬‪‏‬‎‎‏‪‪‮⁭⁫‍‌⁮⁪‪‌⁪‏⁯⁫‍‮)), u003cModuleu003e.u200e‏‌‬⁮‪‭⁭‭⁭‎​‏‌‭‭‭⁭⁬⁯⁫‍‮‫⁯‌‮‏​‬⁫⁯⁮⁫‮‪⁫‬⁮⁬‮<string>(-421459766));
					empty = u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮.u206f‮‪‌‫⁬‭‏‪‪⁬⁭‫⁮‍‪⁯⁭‬‏‎‌‎⁬‮‌‍⁮⁯‌‏⁮⁯​‬‭‎‬‮‌‮(empty, (int)u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮.u202e‍‮‍⁯​⁪‌⁬‫⁭‍⁬⁪​‏⁬⁯​‭‌‏‏⁬⁯​⁬⁯⁯‮⁫⁮‍⁬‭‍⁬‬‎‌‮(u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮.u202d‌‭⁭⁫‌​‎‬‪‌‏⁯⁮⁪‬‭‎‬⁫⁫⁪⁫‫‪⁭⁭‪​‫‭⁮‫​‎​‭​‏‍‮(this.u206a‪‭⁮‍‭⁭‌⁫​‏‮⁪‍⁪‭‍‬‪‏‬‎‎‏‪‪‮⁭⁫‍‌⁮⁪‪‌⁪‏⁯⁫‍‮)));
					str = this.u200d⁬‎‍⁭​⁫​‬‬⁬‍‏‏‮⁫‫‭‎‪‫‮‏⁬⁪⁯⁫⁭‫‌‬‪‌‏⁪‌⁯⁫⁬⁮‮<string>(u003cModuleu003e.u200e‏‌‬⁮‪‭⁭‭⁭‎​‏‌‭‭‭⁭⁬⁯⁫‍‮‫⁯‌‮‏​‬⁫⁯⁮⁫‮‪⁫‬⁮⁬‮<string>(-1257098379), empty);
					num = -322630335;
					continue;
				}
				case 9:
				{
					return str;
				}
				case 10:
				{
					goto Label2;
				}
				default:
				{
					return str;
				}
			}
		}
	Label0:
		empty = string.Empty;
		num = -1280629652;
		goto Label4;
		return str;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	// ‬‭⁮​⁫‪‎⁪​⁫⁬‬‬‍⁪‍‪⁫‪‫‍‌‎‍‬⁭​‌⁫⁯‭⁮​‎‌⁮‫⁪⁮⁬‮
	private string u202c‭⁮​⁫‪‎⁪​⁫⁬‬‬‍⁪‍‪⁫‪‫‍‌‎‍‬⁭​‌⁫⁯‭⁮​‎‌⁮‫⁪⁮⁬‮(bool flag, object obj)
	{
		string str = null;
		string empty = null;
		int num;
		if (!flag)
		{
			goto Label0;
		}
	Label1:
		num = 380314884;
	Label4:
		while (true)
		{
			int num1 = num ^ 1685383109;
			uint num2 = (uint)num1;
			switch (num1 % 6)
			{
				case 0:
				{
					empty = u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮.u206b‭‎⁬‪⁮⁬‏​⁫⁫‮‭⁫‫‭‪⁬​‬‬⁫⁪‭‭​⁬⁬‮‎‪‏⁪‍‭⁯⁮⁭‮⁬‮(empty, this.u206a‪‭⁮‍‭⁭‌⁫​‏‮⁪‍⁪‭‍‬‪‏‬‎‎‏‪‪‮⁭⁫‍‌⁮⁪‪‌⁪‏⁯⁫‍‮.NetInfoPosition);
					str = this.u200d⁬‎‍⁭​⁫​‬‬⁬‍‏‏‮⁫‫‭‎‪‫‮‏⁬⁪⁯⁫⁭‫‌‬‪‌‏⁪‌⁯⁫⁬⁮‮<string>(u003cModuleu003e.u202a‮‫‏‫‬‬‪⁫⁬​‏⁫⁭‍‪‪‎⁬​‪​‌⁮‮‌​⁫​⁬‪‫⁪⁯⁪‎‫⁭‎⁪‮<string>(663510185), empty);
					num = 1217489872;
					continue;
				}
				case 1:
				{
					this.u206a‪‭⁮‍‭⁭‌⁫​‏‮⁪‍⁪‭‍‬‪‏‬‎‎‏‪‪‮⁭⁫‍‌⁮⁪‪‌⁪‏⁯⁫‍‮.NetInfoPosition = (string)obj;
					num = (int)(num2 * -1154874390 ^ -684430958);
					continue;
				}
				case 2:
				{
					goto Label1;
				}
				case 3:
				{
					str = this.u200d⁬‎‍⁭​⁫​‬‬⁬‍‏‏‮⁫‫‭‎‪‫‮‏⁬⁪⁯⁫⁭‫‌‬‪‌‏⁪‌⁯⁫⁬⁮‮<object>(null, null);
					num = (int)(num2 * -1570617066 ^ -514270226);
					continue;
				}
				case 4:
				{
					break;
				}
				case 5:
				{
					return str;
				}
				default:
				{
					return str;
				}
			}
		}
	Label0:
		empty = string.Empty;
		num = 966888529;
		goto Label4;
		return str;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	// ‮⁫‍⁮‪‏⁯‫‍‭‫‌⁬‪‍‭‎⁪‮⁭⁯‬⁭‫⁫‎‪⁯‍‍⁮⁯‮⁫⁪​⁭⁪‏⁬‮
	private string u202e⁫‍⁮‪‏⁯‫‍‭‫‌⁬‪‍‭‎⁪‮⁭⁯‬⁭‫⁫‎‪⁯‍‍⁮⁯‮⁫⁪​⁭⁪‏⁬‮(bool flag, object obj)
	{
		string str = null;
		if (!flag)
		{
			throw new u206f​⁭‍‌‍⁬⁪‬⁯⁮⁬⁮‭‬‫‬⁫‏⁮⁫‌‮‪⁮⁫‏⁪‏⁬‍‌⁯‍‭⁭‍⁯⁪⁯‮(u003cModuleu003e.u200d​‍⁮‏‭⁮⁪‌‪‬‬‬‪⁬⁭⁫⁫‬⁪⁬⁬⁬‏⁮⁭‌‍‏‍‏‎‬⁬​‪‎​‎⁭‮<string>(-701863214));
		}
	Label2:
		int num = -1215944671;
		while (true)
		{
			int num1 = num ^ -1743620233;
			uint num2 = (uint)num1;
			switch (num1 % 5)
			{
				case 0:
				{
					return str;
				}
				case 1:
				{
					this.u206a‪‭⁮‍‭⁭‌⁫​‏‮⁪‍⁪‭‍‬‪‏‬‎‎‏‪‪‮⁭⁫‍‌⁮⁪‪‌⁪‏⁯⁫‍‮.CallInfo = (string)obj;
					str = this.u200d⁬‎‍⁭​⁫​‬‬⁬‍‏‏‮⁫‫‭‎‪‫‮‏⁬⁪⁯⁫⁭‫‌‬‪‌‏⁪‌⁯⁫⁬⁮‮<object>(null, null);
					num = (int)(num2 * 1345957480 ^ -1981229905);
					continue;
				}
				case 2:
				{
					num = (int)(num2 * -175108689 ^ 1940737890);
					continue;
				}
				case 3:
				{
					break;
				}
				case 4:
				{
					goto Label2;
				}
				default:
				{
					return str;
				}
			}
		}
		throw new u206f​⁭‍‌‍⁬⁪‬⁯⁮⁬⁮‭‬‫‬⁫‏⁮⁫‌‮‪⁮⁫‏⁪‏⁬‍‌⁯‍‭⁭‍⁯⁪⁯‮(u003cModuleu003e.u200d​‍⁮‏‭⁮⁪‌‪‬‬‬‪⁬⁭⁫⁫‬⁪⁬⁬⁬‏⁮⁭‌‍‏‍‏‎‬⁬​‪‎​‎⁭‮<string>(-701863214));
		return str;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	// ⁭‌⁯‪⁮‍‌‪‍‏⁪‏‎‫⁪⁪‪⁭‎‮⁭⁫‍‍‎‏‫​⁭‮⁯‪⁮⁫⁫⁬‬⁭​‪‮
	private string u206d‌⁯‪⁮‍‌‪‍‏⁪‏‎‫⁪⁪‪⁭‎‮⁭⁫‍‍‎‏‫​⁭‮⁯‪⁮⁫⁫⁬‬⁭​‪‮(bool flag, object obj)
	{
		string str = null;
		if (!flag)
		{
			throw new u206f​⁭‍‌‍⁬⁪‬⁯⁮⁬⁮‭‬‫‬⁫‏⁮⁫‌‮‪⁮⁫‏⁪‏⁬‍‌⁯‍‭⁭‍⁯⁪⁯‮(u003cModuleu003e.u206f⁮​‌‪‮‎‭‏‮‎⁮⁮‮⁬⁫‍‍⁪‍⁫⁮‏​‎⁬⁯⁪‪‍⁪⁮‎⁬⁪⁫​⁮⁪⁮‮<string>(-1249216167));
		}
	Label1:
		int num = -1755019853;
		while (true)
		{
			int num1 = num ^ -947260463;
			uint num2 = (uint)num1;
			switch (num1 % 6)
			{
				case 0:
				{
					goto Label1;
				}
				case 1:
				{
					break;
				}
				case 2:
				{
					this.u206a‪‭⁮‍‭⁭‌⁫​‏‮⁪‍⁪‭‍‬‪‏‬‎‎‏‪‪‮⁭⁫‍‌⁮⁪‪‌⁪‏⁯⁫‍‮.CallInfoTXer = (string)obj;
					num = (int)(num2 * 1621285786 ^ -1924301338);
					continue;
				}
				case 3:
				{
					num = (int)(num2 * 323346348 ^ -2013912555);
					continue;
				}
				case 4:
				{
					return str;
				}
				case 5:
				{
					str = this.u200d⁬‎‍⁭​⁫​‬‬⁬‍‏‏‮⁫‫‭‎‪‫‮‏⁬⁪⁯⁫⁭‫‌‬‪‌‏⁪‌⁯⁫⁬⁮‮<object>(null, null);
					num = (int)(num2 * 1737271873 ^ 481816069);
					continue;
				}
				default:
				{
					return str;
				}
			}
		}
		throw new u206f​⁭‍‌‍⁬⁪‬⁯⁮⁬⁮‭‬‫‬⁫‏⁮⁫‌‮‪⁮⁫‏⁪‏⁬‍‌⁯‍‭⁭‍⁯⁪⁯‮(u003cModuleu003e.u206f⁮​‌‪‮‎‭‏‮‎⁮⁮‮⁬⁫‍‍⁪‍⁫⁮‏​‎⁬⁯⁪‪‍⁪⁮‎⁬⁪⁫​⁮⁪⁮‮<string>(-1249216167));
		return str;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	// ⁮‫‪⁭‌‏​‮‎‮‫‎‭⁬‎​‫‭⁬⁫‍⁮⁬‏‌‬⁬‍⁯‌‎⁭‎‬‭‌⁯⁬‬‭‮
	private string u206e‫‪⁭‌‏​‮‎‮‫‎‭⁬‎​‫‭⁬⁫‍⁮⁬‏‌‬⁬‍⁯‌‎⁭‎‬‭‌⁯⁬‬‭‮(bool flag, object obj)
	{
		string str = null;
		if (!flag)
		{
			throw new u206f​⁭‍‌‍⁬⁪‬⁯⁮⁬⁮‭‬‫‬⁫‏⁮⁫‌‮‪⁮⁫‏⁪‏⁬‍‌⁯‍‭⁭‍⁯⁪⁯‮(u003cModuleu003e.u200e‏‌‬⁮‪‭⁭‭⁭‎​‏‌‭‭‭⁭⁬⁯⁫‍‮‫⁯‌‮‏​‬⁫⁯⁮⁫‮‪⁫‬⁮⁬‮<string>(1808951739));
		}
	Label2:
		int num = -1985467885;
		while (true)
		{
			int num1 = num ^ -510750489;
			uint num2 = (uint)num1;
			switch (num1 % 6)
			{
				case 0:
				{
					break;
				}
				case 1:
				{
					return str;
				}
				case 2:
				{
					this.u206a‪‭⁮‍‭⁭‌⁫​‏‮⁪‍⁪‭‍‬‪‏‬‎‎‏‪‪‮⁭⁫‍‌⁮⁪‪‌⁪‏⁯⁫‍‮.OpenNetInfoWindow = (bool)obj;
					num = (int)(num2 * -1348193215 ^ 834495858);
					continue;
				}
				case 3:
				{
					num = (int)(num2 * 562467671 ^ -1124563157);
					continue;
				}
				case 4:
				{
					goto Label2;
				}
				case 5:
				{
					str = this.u200d⁬‎‍⁭​⁫​‬‬⁬‍‏‏‮⁫‫‭‎‪‫‮‏⁬⁪⁯⁫⁭‫‌‬‪‌‏⁪‌⁯⁫⁬⁮‮<object>(null, null);
					num = (int)(num2 * -1223410905 ^ 1521887327);
					continue;
				}
				default:
				{
					return str;
				}
			}
		}
		throw new u206f​⁭‍‌‍⁬⁪‬⁯⁮⁬⁮‭‬‫‬⁫‏⁮⁫‌‮‪⁮⁫‏⁪‏⁬‍‌⁯‍‭⁭‍⁯⁪⁯‮(u003cModuleu003e.u200e‏‌‬⁮‪‭⁭‭⁭‎​‏‌‭‭‭⁭⁬⁯⁫‍‮‫⁯‌‮‏​‬⁫⁯⁮⁫‮‪⁫‬⁮⁬‮<string>(1808951739));
		return str;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	// ‍⁪‪‍​⁪‭​⁬⁪⁫⁪‮⁫‭⁮‮‍‪‍‫‍​⁫⁫⁯⁯‏‮‪⁪‪‫⁯⁭⁫⁬‏‏‮
	private string u200d⁪‪‍​⁪‭​⁬⁪⁫⁪‮⁫‭⁮‮‍‪‍‫‍​⁫⁫⁯⁯‏‮‪⁪‪‫⁯⁭⁫⁬‏‏‮(string , string , object )
	{
		// 
		// Current member / type: System.String ​⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮::‍⁪‪‍​⁪‭​⁬⁪⁫⁪‮⁫‭⁮‮‍‪‍‫‍​⁫⁫⁯⁯‏‮‪⁪‪‫⁯⁭⁫⁬‏‏‮(System.String,System.String,System.Object)
		// File path: C:\SDRSharp\Plugins\Tetra\SDRSharp.Tetra.dll
		// 
		// Product version: 0.0.0.0
		// Exception in: System.String ‍⁪‪‍​⁪‭​⁬⁪⁫⁪‮⁫‭⁮‮‍‪‍‫‍​⁫⁫⁯⁯‏‮‪⁪‪‫⁯⁭⁫⁬‏‏‮(System.String,System.String,System.Object)
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
	// ⁪⁮‌⁬‎‮⁫‎⁬⁪⁭⁭‫‬⁬⁭‎‮‌‍‏‫​⁪⁯⁬⁮⁪⁫‍​‭‎‪⁮⁮⁮‫⁭‏‮
	private object u206a⁮‌⁬‎‮⁫‎⁬⁪⁭⁭‫‬⁬⁭‎‮‌‍‏‫​⁪⁯⁬⁮⁪⁫‍​‭‎‪⁮⁮⁮‫⁭‏‮<u0001>(object obj)
	{
		uint num;
		int num1;
		int num2;
		int num3;
		int num4;
		Type type = u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮.u200c⁪‍​⁭‫‬‫⁬‎⁯​‎‪‌‌⁬‍‬‮⁮‮⁯‮‎‬⁪⁬⁫‪⁯⁬‏‬‎‏‭‭‫⁪‮(typeof(u0001).TypeHandle);
		Type type1 = u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮.u200e⁮‪​‪‎‏⁪​⁭‬‬⁫⁮‪‌‏‮⁯‮⁯⁯‌​⁯‭‭‮⁮⁯‮‎‮⁯⁬‍‌‪⁫⁫‮(obj);
		if (!u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮.u200b⁭⁮⁪‎‪⁯⁪​‫‫⁬⁪‫⁪⁭‍⁫‫‍‍‌‍‪⁫‪‬‎⁬‎⁬‬⁮⁫‭‎⁮⁯​‫‮(type, u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮.u200c⁪‍​⁭‫‬‫⁬‎⁯​‎‪‌‌⁬‍‬‮⁮‮⁯‮‎‬⁪⁬⁫‪⁯⁬‏‬‎‏‭‭‫⁪‮(typeof(long).TypeHandle)))
		{
			goto Label0;
		}
	Label5:
		num = -212456003;
	Label7:
		while (true)
		{
			uint num5 = (uint)(num ^ -414222061);
			uint num6 = num5;
			switch (num5 % 13)
			{
				case 0:
				{
					throw new u200b‪‬⁫⁭‍⁫‭‍‬‏‏​‪‏‬‎‎⁪‎‪‌‎‪​⁭⁮⁮⁪⁪‭‪​‍⁯⁪‍‫⁫⁭‮(u003cModuleu003e.u200e‏‌‬⁮‪‭⁭‭⁭‎​‏‌‭‭‭⁭⁬⁯⁫‍‮‫⁯‌‮‏​‬⁫⁯⁮⁫‮‪⁫‬⁮⁬‮<string>(-339422346));
				}
				case 1:
				{
					num1 = (u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮.u200b⁭⁮⁪‎‪⁯⁪​‫‫⁬⁪‫⁪⁭‍⁫‫‍‍‌‍‪⁫‪‬‎⁬‎⁬‬⁮⁫‭‎⁮⁯​‫‮(type, u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮.u200c⁪‍​⁭‫‬‫⁬‎⁯​‎‪‌‌⁬‍‬‮⁮‮⁯‮‎‬⁪⁬⁫‪⁯⁬‏‬‎‏‭‭‫⁪‮(typeof(bool).TypeHandle)) ? 704121227 : 2006218975);
					num = num1 ^ num6 * -1589380689;
					continue;
				}
				case 2:
				{
					num2 = (!u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮.u200b⁭⁮⁪‎‪⁯⁪​‫‫⁬⁪‫⁪⁭‍⁫‫‍‍‌‍‪⁫‪‬‎⁬‎⁬‬⁮⁫‭‎⁮⁯​‫‮(type1, u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮.u200c⁪‍​⁭‫‬‫⁬‎⁯​‎‪‌‌⁬‍‬‮⁮‮⁯‮‎‬⁪⁬⁫‪⁯⁬‏‬‎‏‭‭‫⁪‮(typeof(int).TypeHandle)) ? 132873821 : 2033866515);
					num = num2 ^ num6 * 1558672267;
					continue;
				}
				case 3:
				{
					num = (uint)((u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮.u200b⁭⁮⁪‎‪⁯⁪​‫‫⁬⁪‫⁪⁭‍⁫‫‍‍‌‍‪⁫‪‬‎⁬‎⁬‬⁮⁫‭‎⁮⁯​‫‮(type, u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮.u200c⁪‍​⁭‫‬‫⁬‎⁯​‎‪‌‌⁬‍‬‮⁮‮⁯‮‎‬⁪⁬⁫‪⁯⁬‏‬‎‏‭‭‫⁪‮(typeof(int).TypeHandle)) ? -853934202 : -1592511275));
					int num7 = (int)num;
					continue;
				}
				case 4:
				{
					throw new u200b‪‬⁫⁭‍⁫‭‍‬‏‏​‪‏‬‎‎⁪‎‪‌‎‪​⁭⁮⁮⁪⁪‭‪​‍⁯⁪‍‫⁫⁭‮(u003cModuleu003e.u200d​‍⁮‏‭⁮⁪‌‪‬‬‬‪⁬⁭⁫⁫‬⁪⁬⁬⁬‏⁮⁭‌‍‏‍‏‎‬⁬​‪‎​‎⁭‮<string>(19364010));
				}
				case 5:
				{
					break;
				}
				case 6:
				{
					num = (uint)((u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮.u200b⁭⁮⁪‎‪⁯⁪​‫‫⁬⁪‫⁪⁭‍⁫‫‍‍‌‍‪⁫‪‬‎⁬‎⁬‬⁮⁫‭‎⁮⁯​‫‮(type, u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮.u200c⁪‍​⁭‫‬‫⁬‎⁯​‎‪‌‌⁬‍‬‮⁮‮⁯‮‎‬⁪⁬⁫‪⁯⁬‏‬‎‏‭‭‫⁪‮(typeof(string).TypeHandle)) ? -1420071894 : -1531874467));
					int num8 = (int)num;
					continue;
				}
				case 7:
				{
					goto Label0;
				}
				case 8:
				{
					return obj;
				}
				case 9:
				{
					return obj;
				}
				case 10:
				{
					goto Label5;
				}
				case 11:
				{
					num3 = (!u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮.u200b⁭⁮⁪‎‪⁯⁪​‫‫⁬⁪‫⁪⁭‍⁫‫‍‍‌‍‪⁫‪‬‎⁬‎⁬‬⁮⁫‭‎⁮⁯​‫‮(type1, u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮.u200c⁪‍​⁭‫‬‫⁬‎⁯​‎‪‌‌⁬‍‬‮⁮‮⁯‮‎‬⁪⁬⁫‪⁯⁬‏‬‎‏‭‭‫⁪‮(typeof(long).TypeHandle)) ? -156289376 : -2070004182);
					num = num3 ^ num6 * -1128084749;
					continue;
				}
				case 12:
				{
					num4 = (u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮.u200b⁭⁮⁪‎‪⁯⁪​‫‫⁬⁪‫⁪⁭‍⁫‫‍‍‌‍‪⁫‪‬‎⁬‎⁬‬⁮⁫‭‎⁮⁯​‫‮(type, u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮.u200c⁪‍​⁭‫‬‫⁬‎⁯​‎‪‌‌⁬‍‬‮⁮‮⁯‮‎‬⁪⁬⁫‪⁯⁬‏‬‎‏‭‭‫⁪‮(typeof(long).TypeHandle)) ? -872407854 : -164831884);
					num = num4 ^ num6 * -1059689010;
					continue;
				}
				default:
				{
					return obj;
				}
			}
		}
		throw new u200b‪‬⁫⁭‍⁫‭‍‬‏‏​‪‏‬‎‎⁪‎‪‌‎‪​⁭⁮⁮⁪⁪‭‪​‍⁯⁪‍‫⁫⁭‮(u003cModuleu003e.u202a‮‫‏‫‬‬‪⁫⁬​‏⁫⁭‍‪‪‎⁬​‪​‌⁮‮‌​⁫​⁬‪‫⁪⁯⁪‎‫⁭‎⁪‮<string>(270265161));
	Label0:
		num = (uint)((u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮.u202a‏‌⁮⁪⁮⁬⁯⁮⁬⁮‎‮⁫⁫‭​‌⁬⁬‪⁮‭​‏‍‏⁫‮‎⁮⁭‫⁯​‬‏‌​⁪‮(type1, type) ? -1190136178 : -1531874467));
		int num9 = (int)num;
		goto Label7;
		return obj;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	// ‌‌⁬‮‮‭‍‬⁮‬⁫‪‭⁭‫‭⁫⁪‪​‏⁬⁫‮‬‏‌‍‬‍‌‫‭‮‮‍⁫‌⁯‎‮
	private void u200c‌⁬‮‮‭‍‬⁮‬⁫‪‭⁭‫‭⁫⁪‪​‏⁬⁫‮‬‏‌‍‬‍‌‫‭‮‮‍⁫‌⁯‎‮(long num, long num, long num)
	{
		int num1;
		if (num >= num)
		{
			goto Label0;
		}
	Label1:
		num1 = -503782704;
	Label3:
		int num2 = num1 ^ -1508887208;
		uint num3 = (uint)num2;
		switch (num2 % 5)
		{
			case 0:
			{
				throw new u200b‪‬⁫⁭‍⁫‭‍‬‏‏​‪‏‬‎‎⁪‎‪‌‎‪​⁭⁮⁮⁪⁪‭‪​‍⁯⁪‍‫⁫⁭‮(u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮.u206e‍⁯​‏‏​⁯‫⁪‫‌⁭⁪‪‬⁫‫‫⁪‌‮‏⁪‎⁪‬⁮‏​​‪‍‮‏‭‫⁭⁫⁫‮(u003cModuleu003e.u200f⁫‌​⁬‌‎‎‏‍‍⁫‎​‌‬⁯‬‫‭‎‏​‌​⁪‭‬⁬‮⁬​‌⁬⁪‫‫‎⁪⁮‮<string>(1133400317), num));
			}
			case 1:
			{
				return;
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
				throw new u200b‪‬⁫⁭‍⁫‭‍‬‏‏​‪‏‬‎‎⁪‎‪‌‎‪​⁭⁮⁮⁪⁪‭‪​‍⁯⁪‍‫⁫⁭‮(u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮.u206e‍⁯​‏‏​⁯‫⁪‫‌⁭⁪‪‬⁫‫‫⁪‌‮‏⁪‎⁪‬⁮‏​​‪‍‮‏‭‫⁭⁫⁫‮(u003cModuleu003e.u200e‏‌‬⁮‪‭⁭‭⁭‎​‏‌‭‭‭⁭⁬⁯⁫‍‮‫⁯‌‮‏​‬⁫⁯⁮⁫‮‪⁫‬⁮⁬‮<string>(889494832), num));
			}
			default:
			{
				return;
			}
		}
	Label0:
		num1 = (num > num ? -1844304232 : -255508641);
		goto Label3;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	// ‬‌⁮‏‫‍⁫‎⁪‪‌​​‏⁪⁫‌⁬⁯⁬⁫‍‮⁮⁬‏⁪⁬‬‍⁪⁬⁫‍⁮‫‪‭‫‍‮
	private object u202c‌⁮‏‫‍⁫‎⁪‪‌​​‏⁪⁫‌⁬⁯⁬⁫‍‮⁮⁬‏⁪⁬‬‍⁪⁬⁫‍⁮‫‪‭‫‍‮(string str, Type type)
	{
		object obj;
		try
		{
			obj = u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮.u202a‍⁫‍‏⁫‍‭‭⁪‫‌⁯⁪⁫⁬⁯⁭⁪‫‫⁭‫‮‌⁬‫‮‌‭‭‬‬‮‬⁮⁯‭‮‏‮(type, str, true);
		}
		catch (ArgumentException argumentException)
		{
			throw new u200b‪‬⁫⁭‍⁫‭‍‬‏‏​‪‏‬‎‎⁪‎‪‌‎‪​⁭⁮⁮⁪⁪‭‪​‍⁯⁪‍‫⁫⁭‮(u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮.u206b‭‎⁬‪⁮⁬‏​⁫⁫‮‭⁫‫‭‪⁬​‬‬⁫⁪‭‭​⁬⁬‮‎‪‏⁪‍‭⁯⁮⁭‮⁬‮(u003cModuleu003e.u200d​‍⁮‏‭⁮⁪‌‪‬‬‬‪⁬⁭⁫⁫‬⁪⁬⁬⁬‏⁮⁭‌‍‏‍‏‎‬⁬​‪‎​‎⁭‮<string>(-840096928), u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮.u202d⁫⁯‫‭⁭⁪‪⁫‬⁭​⁯⁬‪⁬‬​‬‎⁭⁬⁯⁯‎‮⁬⁭‍‌‪‌‍⁮⁮‮‪⁭‪‎‮(u003cModuleu003e.u200d​‍⁮‏‭⁮⁪‌‪‬‬‬‪⁬⁭⁫⁫‬⁪⁬⁬⁬‏⁮⁭‌‍‏‍‏‎‬⁬​‪‎​‎⁭‮<string>(508511733), u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮.u200b‍⁯‎​‬‎‎‪‏‎‮‪‌‎‪⁪⁭‮‍‏⁫⁯⁫‏⁫‮‭⁫⁬‏​⁫⁬‮‪‍‏‭‍‮(type))));
		}
		return obj;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	// ​‪⁯‭⁯‮‭⁬​‪‌‌⁫⁬⁯‮‫⁫‫⁮⁯⁬⁬⁯‪‏​‭‍⁫⁬‎‫‬‭⁫‍‍‮‎‮
	private string u200b‪⁯‭⁯‮‭⁬​‪‌‌⁫⁬⁯‮‫⁫‫⁮⁯⁬⁬⁯‪‏​‭‍⁫⁬‎‫‬‭⁫‍‍‮‎‮(bool flag, object obj)
	{
		string str;
		int num = 0;
		uint num1;
		object obj1;
		if (flag)
		{
			goto Label0;
		}
	Label2:
		str = this.u200d⁬‎‍⁭​⁫​‬‬⁬‍‏‏‮⁫‫‭‎‪‫‮‏⁬⁪⁯⁫⁭‫‌‬‪‌‏⁪‌⁯⁫⁬⁮‮<int>(u003cModuleu003e.u200d​‍⁮‏‭⁮⁪‌‪‬‬‬‪⁬⁭⁫⁫‬⁪⁬⁬⁬‏⁮⁭‌‍‏‍‏‎‬⁬​‪‎​‎⁭‮<string>(1650469877), u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮.u206f‬‭‭‎⁪​⁬⁫‏⁭‎‎​⁫‫⁯​‫‮‫‌‫⁬⁬⁬‎‏⁯⁭‫⁫‮‫⁮‪​‎⁫‏‮(this.u206b‏‭‫⁫‎‪‬‪⁪‎‪‍⁯‮‏‎⁮‏⁪‍‬‍⁯‭‏⁪⁭‫‬⁮‪⁮‭‍‫‎​​‍‮));
		int num2 = -1765053663;
		while (true)
		{
			int num3 = num2 ^ -347583621;
			num1 = (uint)num3;
			switch (num3 % 3)
			{
				case 0:
				{
					return str;
				}
				case 1:
				{
					goto Label2;
				}
				case 2:
				{
					num2 = -1721292209;
					continue;
				}
			}
		}
		return str;
	Label0:
		int num4 = -2141011936;
		while (true)
		{
			int num5 = num4 ^ -347583621;
			num1 = (uint)num5;
			switch (num5 % 3)
			{
				case 0:
				{
					this.u200c‌⁬‮‮‭‍‬⁮‬⁫‪‭⁭‫‭⁫⁪‪​‏⁬⁫‮‬‏‌‍‬‍‌‫‭‮‮‍⁫‌⁯‎‮((long)num, (long)20, (long)60);
					try
					{
						u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮.u200b‬‏‎‮‎‎‮‪⁪‪‫⁬⁯​‌‌‭‪⁭‫‫‌‪‎‭‌‌⁬‌‭‮⁯⁮‮‮‭⁬‬‮‮(this.u206b‏‭‫⁫‎‪‬‪⁪‎‪‍⁯‮‏‎⁮‏⁪‍‬‍⁯‭‏⁪⁭‫‬⁮‪⁮‭‍‫‎​​‍‮, num);
					}
					catch
					{
						obj1 = obj2;
						u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮.u200b‬‏‎‮‎‎‮‪⁪‪‫⁬⁯​‌‌‭‪⁭‫‫‌‪‎‭‌‌⁬‌‭‮⁯⁮‮‮‭⁬‬‮‮(this.u206b‏‭‫⁫‎‪‬‪⁪‎‪‍⁯‮‏‎⁮‏⁪‍‬‍⁯‭‏⁪⁭‫‬⁮‪⁮‭‍‫‎​​‍‮, 25);
					}
					str = this.u200d⁬‎‍⁭​⁫​‬‬⁬‍‏‏‮⁫‫‭‎‪‫‮‏⁬⁪⁯⁫⁭‫‌‬‪‌‏⁪‌⁯⁫⁬⁮‮<object>(null, null);
					return str;
				}
				case 1:
				{
					num = (int)this.u206a⁮‌⁬‎‮⁫‎⁬⁪⁭⁭‫‬⁬⁭‎‮‌‍‏‫​⁪⁯⁬⁮⁪⁫‍​‭‎‪⁮⁮⁮‫⁭‏‮<int>(obj);
					num4 = (int)(num1 * -1471574022 ^ 145031191);
					continue;
				}
				case 2:
				{
					goto Label0;
				}
			}
		}
		this.u200c‌⁬‮‮‭‍‬⁮‬⁫‪‭⁭‫‭⁫⁪‪​‏⁬⁫‮‬‏‌‍‬‍‌‫‭‮‮‍⁫‌⁯‎‮((long)num, (long)20, (long)60);
		try
		{
			u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮.u200b‬‏‎‮‎‎‮‪⁪‪‫⁬⁯​‌‌‭‪⁭‫‫‌‪‎‭‌‌⁬‌‭‮⁯⁮‮‮‭⁬‬‮‮(this.u206b‏‭‫⁫‎‪‬‪⁪‎‪‍⁯‮‏‎⁮‏⁪‍‬‍⁯‭‏⁪⁭‫‬⁮‪⁮‭‍‫‎​​‍‮, num);
		}
		catch
		{
			obj1 = obj2;
			u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮.u200b‬‏‎‮‎‎‮‪⁪‪‫⁬⁯​‌‌‭‪⁭‫‫‌‪‎‭‌‌⁬‌‭‮⁯⁮‮‮‭⁬‬‮‮(this.u206b‏‭‫⁫‎‪‬‪⁪‎‪‍⁯‮‏‎⁮‏⁪‍‬‍⁯‭‏⁪⁭‫‬⁮‪⁮‭‍‫‎​​‍‮, 25);
		}
		str = this.u200d⁬‎‍⁭​⁫​‬‬⁬‍‏‏‮⁫‫‭‎‪‫‮‏⁬⁪⁯⁫⁭‫‌‬‪‌‏⁪‌⁯⁫⁬⁮‮<object>(null, null);
		return str;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	// ‭‮⁭⁮​⁮‭⁫‫‬​⁪⁭⁮‏‌‍⁬⁯⁪⁫⁭⁮‮‪⁪⁯‬⁪‪⁫‪‮‏‬⁯⁫⁯‏‌‮
	private string u202d‮⁭⁮​⁮‭⁫‫‬​⁪⁭⁮‏‌‍⁬⁯⁪⁫⁭⁮‮‪⁪⁯‬⁪‪⁫‪‮‏‬⁯⁫⁯‏‌‮(bool flag, object obj)
	{
		string str = null;
		int num;
		if (!flag)
		{
			goto Label0;
		}
	Label1:
		num = -1457520805;
	Label4:
		while (true)
		{
			int num1 = num ^ -977346711;
			uint num2 = (uint)num1;
			switch (num1 % 5)
			{
				case 0:
				{
					str = this.u200d⁬‎‍⁭​⁫​‬‬⁬‍‏‏‮⁫‫‭‎‪‫‮‏⁬⁪⁯⁫⁭‫‌‬‪‌‏⁪‌⁯⁫⁬⁮‮<object>(null, null);
					num = (int)(num2 * 1949061007 ^ -396692242);
					continue;
				}
				case 1:
				{
					u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮.u202c⁫⁪⁪‌‪⁭⁮‎‏‏‎‎‎‏‌⁪⁮‎⁫‎⁭‮‏⁭‍‌‌⁭‫⁫​⁭‮⁬‮‬⁭‮‪‮(this.u206b‏‭‫⁫‎‪‬‪⁪‎‪‍⁯‮‏‎⁮‏⁪‍‬‍⁯‭‏⁪⁭‫‬⁮‪⁮‭‍‫‎​​‍‮, (bool)this.u206a⁮‌⁬‎‮⁫‎⁬⁪⁭⁭‫‬⁬⁭‎‮‌‍‏‫​⁪⁯⁬⁮⁪⁫‍​‭‎‪⁮⁮⁮‫⁭‏‮<bool>(obj));
					num = (int)(num2 * -608381936 ^ 1534199512);
					continue;
				}
				case 2:
				{
					break;
				}
				case 3:
				{
					goto Label1;
				}
				case 4:
				{
					return str;
				}
				default:
				{
					return str;
				}
			}
		}
	Label0:
		str = this.u200d⁬‎‍⁭​⁫​‬‬⁬‍‏‏‮⁫‫‭‎‪‫‮‏⁬⁪⁯⁫⁭‫‌‬‪‌‏⁪‌⁯⁫⁬⁮‮<bool>(u003cModuleu003e.u202a‮‫‏‫‬‬‪⁫⁬​‏⁫⁭‍‪‪‎⁬​‪​‌⁮‮‌​⁫​⁬‪‫⁪⁯⁪‎‫⁭‎⁪‮<string>(847041596), u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮.u200c⁬‌⁫⁯‌⁬⁬‌‭‍⁫⁪‏‍‌⁪⁮⁬‎‪⁯‫‏⁮⁮‭⁭‌⁬‮‭⁭⁪⁮‏‏⁮‪‬‮(this.u206b‏‭‫⁫‎‪‬‪⁪‎‪‍⁯‮‏‎⁮‏⁪‍‬‍⁯‭‏⁪⁭‫‬⁮‪⁮‭‍‫‎​​‍‮));
		num = -482244335;
		goto Label4;
		return str;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	// ​⁮​‬​‎⁬⁬⁪​⁫‬⁪‭‮‌​⁬‮⁭‭⁪⁮⁮⁯‭‎‍⁬⁮⁮‏⁫​‪‌‍‌⁮⁪‮
	private string u200b⁮​‬​‎⁬⁬⁪​⁫‬⁪‭‮‌​⁬‮⁭‭⁪⁮⁮⁯‭‎‍⁬⁮⁮‏⁫​‪‌‍‌⁮⁪‮(bool flag, object obj)
	{
		string str = null;
		long num = 0L;
		int num1;
		if (!flag)
		{
			goto Label0;
		}
		num = (long)0;
		try
		{
			num = u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮.u206b⁪⁪⁮⁬‫‬‬‮‎⁮⁯⁫⁭⁭⁯‫‏‌‎‭‏⁮‮​⁯‫‏⁬⁫⁭⁭‏‭​⁮⁯‭‏‬‮(this.u206a⁮‌⁬‎‮⁫‎⁬⁪⁭⁭‫‬⁬⁭‎‮‌‍‏‫​⁪⁯⁬⁮⁪⁫‍​‭‎‪⁮⁮⁮‫⁭‏‮<long>(obj));
		}
		catch
		{
		}
		this.u200c‌⁬‮‮‭‍‬⁮‬⁫‪‭⁭‫‭⁫⁪‪​‏⁬⁫‮‬‏‌‍‬‍‌‫‭‮‮‍⁫‌⁯‎‮(num, (long)1, 999999999999L);
	Label1:
		num1 = 969352210;
	Label4:
		while (true)
		{
			int num2 = num1 ^ 219913763;
			uint num3 = (uint)num2;
			switch (num2 % 6)
			{
				case 0:
				{
					goto Label1;
				}
				case 1:
				{
					str = this.u200d⁬‎‍⁭​⁫​‬‬⁬‍‏‏‮⁫‫‭‎‪‫‮‏⁬⁪⁯⁫⁭‫‌‬‪‌‏⁪‌⁯⁫⁬⁮‮<object>(null, null);
					num1 = (int)(num3 * 1005392749 ^ 94005652);
					continue;
				}
				case 2:
				{
					num1 = (int)(num3 * 1925939283 ^ 215339243);
					continue;
				}
				case 3:
				{
					u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮.u202a⁫‮‎⁮​⁬‎‪⁬‮‎‪⁪‍‬‪⁬‬​‌‬⁮‌⁬‫‮‍‏‌‭‮‏‪‎⁮‌‬⁬‫‮(this.u206b‏‭‫⁫‎‪‬‪⁪‎‪‍⁯‮‏‎⁮‏⁪‍‬‍⁯‭‏⁪⁭‫‬⁮‪⁮‭‍‫‎​​‍‮, num);
					num1 = (int)(num3 * 1690510385 ^ 872936381);
					continue;
				}
				case 4:
				{
					return str;
				}
				case 5:
				{
					break;
				}
				default:
				{
					return str;
				}
			}
		}
	Label0:
		str = this.u200d⁬‎‍⁭​⁫​‬‬⁬‍‏‏‮⁫‫‭‎‪‫‮‏⁬⁪⁯⁫⁭‫‌‬‪‌‏⁪‌⁯⁫⁬⁮‮<long>(u003cModuleu003e.u200f⁫‌​⁬‌‎‎‏‍‍⁫‎​‌‬⁯‬‫‭‎‏​‌​⁪‭‬⁬‮⁬​‌⁬⁪‫‫‎⁪⁮‮<string>(-821393544), u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮.u200c⁪⁭⁯‮‍⁯⁭‏‪⁫⁬‎‍⁭⁮‍‍⁫⁭‮‏‭​⁪⁪⁮‏⁮‮‎‪⁪‮⁭‭‍‪⁬⁪‮(this.u206b‏‭‫⁫‎‪‬‪⁪‎‪‍⁯‮‏‎⁮‏⁪‍‬‍⁯‭‏⁪⁭‫‬⁮‪⁮‭‍‫‎​​‍‮));
		num1 = 1151418183;
		goto Label4;
		return str;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	// ⁬⁯‎⁫‮‭⁫‎‫‪‬‪‮⁯‬‮⁫‫⁫‭‍‌‎⁮‌⁮‪‏‌‍​‪⁫⁪‪⁯⁮‪‍‍‮
	private string u206c⁯‎⁫‮‭⁫‎‫‪‬‪‮⁯‬‮⁫‫⁫‭‍‌‎⁮‌⁮‪‏‌‍​‪⁫⁪‪⁯⁮‪‍‍‮(bool flag, object obj)
	{
		string str = null;
		string str1 = null;
		int num;
		if (!flag)
		{
			goto Label0;
		}
	Label1:
		num = -976682114;
	Label4:
		while (true)
		{
			int num1 = num ^ -806346082;
			uint num2 = (uint)num1;
			switch (num1 % 7)
			{
				case 0:
				{
					break;
				}
				case 1:
				{
					num = (int)(num2 * 314999673 ^ -1025586731);
					continue;
				}
				case 2:
				{
					goto Label1;
				}
				case 3:
				{
					return str;
				}
				case 4:
				{
					str1 = (string)this.u206a⁮‌⁬‎‮⁫‎⁬⁪⁭⁭‫‬⁬⁭‎‮‌‍‏‫​⁪⁯⁬⁮⁪⁫‍​‭‎‪⁮⁮⁮‫⁭‏‮<string>(obj);
					num = (int)(num2 * -1891439749 ^ -859047578);
					continue;
				}
				case 5:
				{
					str = this.u200d⁬‎‍⁭​⁫​‬‬⁬‍‏‏‮⁫‫‭‎‪‫‮‏⁬⁪⁯⁫⁭‫‌‬‪‌‏⁪‌⁯⁫⁬⁮‮<object>(null, null);
					num = (int)(num2 * 1770316107 ^ -267306880);
					continue;
				}
				case 6:
				{
					u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮.u202c⁯‬‫‍​⁯‍‌⁪⁮⁪⁬‬‮‬‏‬⁭‪‏‬​‬‭⁫‫⁪⁯‌‪⁬‌⁯⁭⁮‌‭‭‎‮(this.u206b‏‭‫⁫‎‪‬‪⁪‎‪‍⁯‮‏‎⁮‏⁪‍‬‍⁯‭‏⁪⁭‫‬⁮‪⁮‭‍‫‎​​‍‮, (DetectorType)this.u202c‌⁮‏‫‍⁫‎⁪‪‌​​‏⁪⁫‌⁬⁯⁬⁫‍‮⁮⁬‏⁪⁬‬‍⁪⁬⁫‍⁮‫‪‭‫‍‮(str1, u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮.u200c⁪‍​⁭‫‬‫⁬‎⁯​‎‪‌‌⁬‍‬‮⁮‮⁯‮‎‬⁪⁬⁫‪⁯⁬‏‬‎‏‭‭‫⁪‮(typeof(DetectorType).TypeHandle)));
					num = (int)(num2 * 1027993297 ^ 463380448);
					continue;
				}
				default:
				{
					return str;
				}
			}
		}
	Label0:
		string str2 = u003cModuleu003e.u206f⁮​‌‪‮‎‭‏‮‎⁮⁮‮⁬⁫‍‍⁪‍⁫⁮‏​‎⁬⁯⁪‪‍⁪⁮‎⁬⁪⁫​⁮⁪⁮‮<string>(320221917);
		DetectorType detectorType = u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮.u202e‬‭⁫​​‫⁫⁫⁭⁬‬‭⁭‮‍⁪⁯‎‍‍⁯‫‍‎⁬‮‭‌⁬‌⁬‬‌⁬‪‎⁬​‪‮(this.u206b‏‭‫⁫‎‪‬‪⁪‎‪‍⁯‮‏‎⁮‏⁪‍‬‍⁯‭‏⁪⁭‫‬⁮‪⁮‭‍‫‎​​‍‮);
		str = this.u200d⁬‎‍⁭​⁫​‬‬⁬‍‏‏‮⁫‫‭‎‪‫‮‏⁬⁪⁯⁫⁭‫‌‬‪‌‏⁪‌⁯⁫⁬⁮‮<string>(str2, detectorType.ToString());
		num = -172331511;
		goto Label4;
		return str;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	// ‪‭⁪⁯‮⁯​‬‭⁭‮‎‭‬​‪‫​⁬‌‬⁬‬‮‎‬‎‌‫⁫‬⁫‎​‌⁭⁭​⁯‍‮
	private string u202a‭⁪⁯‮⁯​‬‭⁭‮‎‭‬​‪‫​⁬‌‬⁬‬‮‎‬‎‌‫⁫‬⁫‎​‌⁭⁭​⁯‍‮(bool flag, object obj)
	{
		string str = null;
		int num;
		if (!flag)
		{
			goto Label0;
		}
	Label1:
		num = -515941628;
	Label3:
		int num1 = num ^ -885024063;
		uint num2 = (uint)num1;
		switch (num1 % 4)
		{
			case 0:
			{
				goto Label1;
			}
			case 1:
			{
				throw new u206f​⁭‍‌‍⁬⁪‬⁯⁮⁬⁮‭‬‫‬⁫‏⁮⁫‌‮‪⁮⁫‏⁪‏⁬‍‌⁯‍‭⁭‍⁯⁪⁯‮(u003cModuleu003e.u200f⁫‌​⁬‌‎‎‏‍‍⁫‎​‌‬⁯‬‫‭‎‏​‌​⁪‭‬⁬‮⁬​‌⁬⁪‫‫‎⁪⁮‮<string>(525049121));
			}
			case 2:
			{
				return str;
			}
			case 3:
			{
				break;
			}
			default:
			{
				return str;
			}
		}
	Label0:
		str = this.u200d⁬‎‍⁭​⁫​‬‬⁬‍‏‏‮⁫‫‭‎‪‫‮‏⁬⁪⁯⁫⁭‫‌‬‪‌‏⁪‌⁯⁫⁬⁮‮<bool>(u003cModuleu003e.u200d​‍⁮‏‭⁮⁪‌‪‬‬‬‪⁬⁭⁫⁫‬⁪⁬⁬⁬‏⁮⁭‌‍‏‍‏‎‬⁬​‪‎​‎⁭‮<string>(-1614079251), u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮.u200d⁬​‏‍⁫‭‪‫⁬‍‍‌‭‬‮⁭‭​‌⁪​⁭⁯⁬⁭‪⁯‍⁬‭‫⁮​⁮‬⁮⁮‫‭‮(this.u206b‏‭‫⁫‎‪‬‪⁪‎‪‍⁯‮‏‎⁮‏⁪‍‬‍⁯‭‏⁪⁭‫‬⁮‪⁮‭‍‫‎​​‍‮));
		num = -666810537;
		goto Label3;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	// ‭⁪‎‬⁯⁯⁪⁯‍‪‏⁯​⁮‬‏‫‏​⁮⁮‎‌‮​‏⁬‭⁭‬‬‎⁪‬​⁮⁮⁯‮⁯‮
	private string u202d⁪‎‬⁯⁯⁪⁯‍‪‏⁯​⁮‬‏‫‏​⁮⁮‎‌‮​‏⁬‭⁭‬‬‎⁪‬​⁮⁮⁯‮⁯‮(bool flag, object obj)
	{
		string str = null;
		int num = 0;
		int num1;
		if (!flag)
		{
			goto Label0;
		}
	Label2:
		num1 = -1513411443;
	Label4:
		while (true)
		{
			int num2 = num1 ^ -60683154;
			uint num3 = (uint)num2;
			switch (num2 % 6)
			{
				case 0:
				{
					return str;
				}
				case 1:
				{
					num = (int)this.u206a⁮‌⁬‎‮⁫‎⁬⁪⁭⁭‫‬⁬⁭‎‮‌‍‏‫​⁪⁯⁬⁮⁪⁫‍​‭‎‪⁮⁮⁮‫⁭‏‮<int>(obj);
					this.u200c‌⁬‮‮‭‍‬⁮‬⁫‪‭⁭‫‭⁫⁪‪​‏⁬⁫‮‬‏‌‍‬‍‌‫‭‮‮‍⁫‌⁯‎‮((long)num, (long)10, (long)250000);
					num1 = (int)(num3 * -960352238 ^ 1636508362);
					continue;
				}
				case 2:
				{
					break;
				}
				case 3:
				{
					goto Label2;
				}
				case 4:
				{
					u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮.u206a‬‮⁬‭‌⁬‭‌⁯‍⁬⁭‌⁯‎‪‌‎‍‮‭‬⁬⁮‬⁫‍⁯⁫⁮‌‬⁪⁪‬⁫‬‭‫‮(this.u206b‏‭‫⁫‎‪‬‪⁪‎‪‍⁯‮‏‎⁮‏⁪‍‬‍⁯‭‏⁪⁭‫‬⁮‪⁮‭‍‫‎​​‍‮, num);
					num1 = (int)(num3 * 2129776585 ^ 1423100313);
					continue;
				}
				case 5:
				{
					str = this.u200d⁬‎‍⁭​⁫​‬‬⁬‍‏‏‮⁫‫‭‎‪‫‮‏⁬⁪⁯⁫⁭‫‌‬‪‌‏⁪‌⁯⁫⁬⁮‮<object>(null, null);
					num1 = (int)(num3 * -1802882633 ^ 1825044739);
					continue;
				}
				default:
				{
					return str;
				}
			}
		}
	Label0:
		str = this.u200d⁬‎‍⁭​⁫​‬‬⁬‍‏‏‮⁫‫‭‎‪‫‮‏⁬⁪⁯⁫⁭‫‌‬‪‌‏⁪‌⁯⁫⁬⁮‮<int>(u003cModuleu003e.u206f⁮​‌‪‮‎‭‏‮‎⁮⁮‮⁬⁫‍‍⁪‍⁫⁮‏​‎⁬⁯⁪‪‍⁪⁮‎⁬⁪⁫​⁮⁪⁮‮<string>(192446736), u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮.u200c‪‌‬⁯​‏⁯‫‌​‌⁯‎⁭‪‏‏‍‪‪⁮‬‭⁯‍‭‏‎⁭‬⁫⁭⁬‏‬⁬​‮‎‮(this.u206b‏‭‫⁫‎‪‬‪⁪‎‪‍⁯‮‏‎⁮‏⁪‍‬‍⁯‭‏⁪⁭‫‬⁮‪⁮‭‍‫‎​​‍‮));
		num1 = -1750948736;
		goto Label4;
		return str;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	// ⁯‎⁪⁭‪⁯⁯‬‮‭⁯‪​⁭⁮⁮‍‫‪‮‌‍‍‏‭‬‮⁯⁯‪‎⁫‫‌⁯⁬‎⁮‏‬‮
	private string u206f‎⁪⁭‪⁯⁯‬‮‭⁯‪​⁭⁮⁮‍‫‪‮‌‍‍‏‭‬‮⁯⁯‪‎⁫‫‌⁯⁬‎⁮‏‬‮(bool flag, object obj)
	{
		throw new u206f​⁭‍‌‍⁬⁪‬⁯⁮⁬⁮‭‬‫‬⁫‏⁮⁫‌‮‪⁮⁫‏⁪‏⁬‍‌⁯‍‭⁭‍⁯⁪⁯‮(u003cModuleu003e.u200d​‍⁮‏‭⁮⁪‌‪‬‬‬‪⁬⁭⁫⁫‬⁪⁬⁬⁬‏⁮⁭‌‍‏‍‏‎‬⁬​‪‎​‎⁭‮<string>(361278470));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	// ‌​‎⁫⁪‬‌⁯‍‮‫‫⁭⁪‫‍‭⁭⁪⁪‎‏‎‮‎⁬‍‎‍‮‍‬⁯‬⁭⁪‍‮‭⁭‮
	public string u200c​‎⁫⁪‬‌⁯‍‮‫‫⁭⁪‫‍‭⁭⁪⁪‎‏‎‮‎⁬‍‎‍‮‍‬⁯‬⁭⁪‍‮‭⁭‮()
	{
		string str;
		string str1;
		string str2;
		string str3;
		string str4;
		string str5;
		string str6;
		int num;
		string empty = string.Empty;
	Label0:
		int num1 = 1436507662;
		while (true)
		{
			int num2 = num1 ^ 1076390601;
			uint num3 = (uint)num2;
			switch (num2 % 6)
			{
				case 0:
				{
					empty = u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮.u206b‭‎⁬‪⁮⁬‏​⁫⁫‮‭⁫‫‭‪⁬​‬‬⁫⁪‭‭​⁬⁬‮‎‪‏⁪‍‭⁯⁮⁭‮⁬‮(empty, u003cModuleu003e.u206f⁮​‌‪‮‎‭‏‮‎⁮⁮‮⁬⁫‍‍⁪‍⁫⁮‏​‎⁬⁯⁪‪‍⁪⁮‎⁬⁪⁫​⁮⁪⁮‮<string>(-1742033983));
					num1 = 505863244;
					continue;
				}
				case 1:
				{
					num1 = (int)(num3 * 793240055 ^ -49212775);
					continue;
				}
				case 2:
				{
					goto Label0;
				}
				case 3:
				{
					str = u003cModuleu003e.u202a‮‫‏‫‬‬‪⁫⁬​‏⁫⁭‍‪‪‎⁬​‪​‌⁮‮‌​⁫​⁬‪‫⁪⁯⁪‎‫⁭‎⁪‮<string>(-1742174209);
					str1 = empty;
					str2 = Info.Title();
					str3 = u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮.u202c‌‍‏‌‎‬⁭⁯‮‫⁭‬⁬‮⁮‮⁮⁭‬‎‭‮‎⁫⁯⁪‎‭⁯⁪⁮‏⁭‬⁯‭⁯‎‬‮(str, str1, str2, u003cModuleu003e.u200e‏‌‬⁮‪‭⁭‭⁭‎​‏‌‭‭‭⁭⁬⁯⁫‍‮‫⁯‌‮‏​‬⁫⁯⁮⁫‮‪⁫‬⁮⁬‮<string>(-1047523340));
					str4 = u003cModuleu003e.u200d​‍⁮‏‭⁮⁪‌‪‬‬‬‪⁬⁭⁫⁫‬⁪⁬⁬⁬‏⁮⁭‌‍‏‍‏‎‬⁬​‪‎​‎⁭‮<string>(1391696638);
					str5 = Info.Version();
					str6 = u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮.u202c‌‍‏‌‎‬⁭⁯‮‫⁭‬⁬‮⁮‮⁮⁭‬‎‭‮‎⁫⁯⁪‎‭⁯⁪⁮‏⁭‬⁯‭⁯‎‬‮(str3, str4, str5, u003cModuleu003e.u206f⁮​‌‪‮‎‭‏‮‎⁮⁮‮⁬⁫‍‍⁪‍⁫⁮‏​‎⁬⁯⁪‪‍⁪⁮‎⁬⁪⁫​⁮⁪⁮‮<string>(529533481));
					return u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮.u206b‭‎⁬‪⁮⁬‏​⁫⁫‮‭⁫‫‭‪⁬​‬‬⁫⁪‭‭​⁬⁬‮‎‪‏⁪‍‭⁯⁮⁭‮⁬‮(str6, u003cModuleu003e.u202a‮‫‏‫‬‬‪⁫⁬​‏⁫⁭‍‪‪‎⁬​‪​‌⁮‮‌​⁫​⁬‪‫⁪⁯⁪‎‫⁭‎⁪‮<string>(1988305559));
				}
				case 4:
				{
					empty = u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮.u206b‭‎⁬‪⁮⁬‏​⁫⁫‮‭⁫‫‭‪⁬​‬‬⁫⁪‭‭​⁬⁬‮‎‪‏⁪‍‭⁯⁮⁭‮⁬‮(empty, u003cModuleu003e.u206f⁮​‌‪‮‎‭‏‮‎⁮⁮‮⁬⁫‍‍⁪‍⁫⁮‏​‎⁬⁯⁪‪‍⁪⁮‎⁬⁪⁫​⁮⁪⁮‮<string>(1556397503));
					num1 = 1188792410;
					continue;
				}
				case 5:
				{
					num = (this.u206a‪‭⁮‍‭⁭‌⁫​‏‮⁪‍⁪‭‍‬‪‏‬‎‎‏‪‪‮⁭⁫‍‌⁮⁪‪‌⁪‏⁯⁫‍‮.TttRole ? -914344609 : -1160194583);
					num1 = (int)(num ^ num3 * 573022558);
					continue;
				}
			}
		}
		str = u003cModuleu003e.u202a‮‫‏‫‬‬‪⁫⁬​‏⁫⁭‍‪‪‎⁬​‪​‌⁮‮‌​⁫​⁬‪‫⁪⁯⁪‎‫⁭‎⁪‮<string>(-1742174209);
		str1 = empty;
		str2 = Info.Title();
		str3 = u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮.u202c‌‍‏‌‎‬⁭⁯‮‫⁭‬⁬‮⁮‮⁮⁭‬‎‭‮‎⁫⁯⁪‎‭⁯⁪⁮‏⁭‬⁯‭⁯‎‬‮(str, str1, str2, u003cModuleu003e.u200e‏‌‬⁮‪‭⁭‭⁭‎​‏‌‭‭‭⁭⁬⁯⁫‍‮‫⁯‌‮‏​‬⁫⁯⁮⁫‮‪⁫‬⁮⁬‮<string>(-1047523340));
		str4 = u003cModuleu003e.u200d​‍⁮‏‭⁮⁪‌‪‬‬‬‪⁬⁭⁫⁫‬⁪⁬⁬⁬‏⁮⁭‌‍‏‍‏‎‬⁬​‪‎​‎⁭‮<string>(1391696638);
		str5 = Info.Version();
		str6 = u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮.u202c‌‍‏‌‎‬⁭⁯‮‫⁭‬⁬‮⁮‮⁮⁭‬‎‭‮‎⁫⁯⁪‎‭⁯⁪⁮‏⁭‬⁯‭⁯‎‬‮(str3, str4, str5, u003cModuleu003e.u206f⁮​‌‪‮‎‭‏‮‎⁮⁮‮⁬⁫‍‍⁪‍⁫⁮‏​‎⁬⁯⁪‪‍⁪⁮‎⁬⁪⁫​⁮⁪⁮‮<string>(529533481));
		return u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮.u206b‭‎⁬‪⁮⁬‏​⁫⁫‮‭⁫‫‭‪⁬​‬‬⁫⁪‭‭​⁬⁬‮‎‪‏⁪‍‭⁯⁮⁭‮⁬‮(str6, u003cModuleu003e.u202a‮‫‏‫‬‬‪⁫⁬​‏⁫⁭‍‪‪‎⁬​‪​‌⁮‮‌​⁫​⁬‪‫⁪⁯⁪‎‫⁭‎⁪‮<string>(1988305559));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	// ⁬‭‍‫⁬⁪⁮‫‬​‮⁭⁭⁯⁬⁬‬⁬‪‎‭‏⁮‬‏‫‭⁯⁫⁯‮⁬⁭‭​‌‍⁫⁮⁯‮
	private string u206c‭‍‫⁬⁪⁮‫‬​‮⁭⁭⁯⁬⁬‬⁬‪‎‭‏⁮‬‏‫‭⁯⁫⁯‮⁬⁭‭​‌‍⁫⁮⁯‮(string str, string str)
	{
		return u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮.u206b‭‎⁬‪⁮⁬‏​⁫⁫‮‭⁫‫‭‪⁬​‬‬⁫⁪‭‭​⁬⁬‮‎‪‏⁪‍‭⁯⁮⁭‮⁬‮(u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮.u202c‌‍‏‌‎‬⁭⁯‮‫⁭‬⁬‮⁮‮⁮⁭‬‎‭‮‎⁫⁯⁪‎‭⁯⁪⁮‏⁭‬⁯‭⁯‎‬‮(u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮.u202c‌‍‏‌‎‬⁭⁯‮‫⁭‬⁬‮⁮‮⁮⁭‬‎‭‮‎⁫⁯⁪‎‭⁯⁪⁮‏⁭‬⁯‭⁯‎‬‮(u003cModuleu003e.u200d​‍⁮‏‭⁮⁪‌‪‬‬‬‪⁬⁭⁫⁫‬⁪⁬⁬⁬‏⁮⁭‌‍‏‍‏‎‬⁬​‪‎​‎⁭‮<string>(532235700), u003cModuleu003e.u200e‏‌‬⁮‪‭⁭‭⁭‎​‏‌‭‭‭⁭⁬⁯⁫‍‮‫⁯‌‮‏​‬⁫⁯⁮⁫‮‪⁫‬⁮⁬‮<string>(-1796643044), str, u003cModuleu003e.u200e‏‌‬⁮‪‭⁭‭⁭‎​‏‌‭‭‭⁭⁬⁯⁫‍‮‫⁯‌‮‏​‬⁫⁯⁮⁫‮‪⁫‬⁮⁬‮<string>(-1047523340)), u003cModuleu003e.u206f⁮​‌‪‮‎‭‏‮‎⁮⁮‮⁬⁫‍‍⁪‍⁫⁮‏​‎⁬⁯⁪‪‍⁪⁮‎⁬⁪⁫​⁮⁪⁮‮<string>(1255221941), str, u003cModuleu003e.u200f⁫‌​⁬‌‎‎‏‍‍⁫‎​‌‬⁯‬‫‭‎‏​‌​⁪‭‬⁬‮⁬​‌⁬⁪‫‫‎⁪⁮‮<string>(1695263880)), u003cModuleu003e.u200f⁫‌​⁬‌‎‎‏‍‍⁫‎​‌‬⁯‬‫‭‎‏​‌​⁪‭‬⁬‮⁬​‌⁬⁪‫‫‎⁪⁮‮<string>(618451192));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	// ‍⁬‎‍⁭​⁫​‬‬⁬‍‏‏‮⁫‫‭‎‪‫‮‏⁬⁪⁯⁫⁭‫‌‬‪‌‏⁪‌⁯⁫⁬⁮‮
	private string u200d⁬‎‍⁭​⁫​‬‬⁬‍‏‏‮⁫‫‭‎‪‫‮‏⁬⁪⁯⁫⁭‫‌‬‪‌‏⁪‌⁯⁫⁬⁮‮<u0001>(string str, object obj)
	{
		int num;
		string str1 = u003cModuleu003e.u200e‏‌‬⁮‪‭⁭‭⁭‎​‏‌‭‭‭⁭⁬⁯⁫‍‮‫⁯‌‮‏​‬⁫⁯⁮⁫‮‪⁫‬⁮⁬‮<string>(-1061789868);
		if (str == null)
		{
			goto Label0;
		}
	Label2:
		num = 1202605491;
	Label4:
		while (true)
		{
			int num1 = num ^ 1700350340;
			uint num2 = (uint)num1;
			switch (num1 % 4)
			{
				case 0:
				{
					break;
				}
				case 1:
				{
					return str1;
				}
				case 2:
				{
					goto Label2;
				}
				case 3:
				{
					str1 = u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮.u202c‌‍‏‌‎‬⁭⁯‮‫⁭‬⁬‮⁮‮⁮⁭‬‎‭‮‎⁫⁯⁪‎‭⁯⁪⁮‏⁭‬⁯‭⁯‎‬‮(str1, u003cModuleu003e.u200e‏‌‬⁮‪‭⁭‭⁭‎​‏‌‭‭‭⁭⁬⁯⁫‍‮‫⁯‌‮‏​‬⁫⁯⁮⁫‮‪⁫‬⁮⁬‮<string>(-2043675045), str, u003cModuleu003e.u200d​‍⁮‏‭⁮⁪‌‪‬‬‬‪⁬⁭⁫⁫‬⁪⁬⁬⁬‏⁮⁭‌‍‏‍‏‎‬⁬​‪‎​‎⁭‮<string>(-1896226430));
					str1 = u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮.u206c⁭‌⁬⁬‬⁪⁮⁯‏‭‫⁭‎⁪⁮‪⁯⁮‎⁬‏⁪‭⁫‭​‮⁬⁭⁫⁮‍⁪‏‍‬‬‬‬‮(str1, u003cModuleu003e.u200f⁫‌​⁬‌‎‎‏‍‍⁫‎​‌‬⁯‬‫‭‎‏​‌​⁪‭‬⁬‮⁬​‌⁬⁪‫‫‎⁪⁮‮<string>(-739079875), ()obj);
					num = 379174940;
					continue;
				}
				default:
				{
					return str1;
				}
			}
		}
	Label0:
		string str2 = str1;
		str1 = u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮.u206b‭‎⁬‪⁮⁬‏​⁫⁫‮‭⁫‫‭‪⁬​‬‬⁫⁪‭‭​⁬⁬‮‎‪‏⁪‍‭⁯⁮⁭‮⁬‮(str2, u003cModuleu003e.u202a‮‫‏‫‬‬‪⁫⁬​‏⁫⁭‍‪‪‎⁬​‪​‌⁮‮‌​⁫​⁬‪‫⁪⁯⁪‎‫⁭‎⁪‮<string>(1988305559));
		num = 987842461;
		goto Label4;
		return str1;
	}

	// ‍⁬​⁯⁫⁯​‌‍‬‭‮​⁪⁪‮‪‫‪‪‏‫⁭‌‬‍‫‭‎‌‫‪‬‍​‫‍⁮⁭‮‮
	// privatescope
	internal static string u200d⁬​⁯⁫⁯​‌‍‬‭‮​⁪⁪‮‪‫‪‪‏‫⁭‌‬‍‫‭‎‌‫‪‬‍​‫‍⁮⁭‮‮(string str, string str, string str)
	{
		return Regex.Replace(str, str, str);
	}

	// ⁬‪‬‭⁫‎‫‌‎‌⁯⁮​‪‍​‮‏‫⁬‍‭‭‍⁮⁮⁪‌‌‍⁭‌⁭⁪‪⁪‎‎​‮‮
	// privatescope
	internal static string u206c‪‬‭⁫‎‫‌‎‌⁯⁮​‪‍​‮‏‫⁬‍‭‭‍⁮⁮⁪‌‌‍⁭‌⁭⁪‪⁪‎‎​‮‮(string str)
	{
		return str.ToLower();
	}

	// ⁮‍⁯​‏‏​⁯‫⁪‫‌⁭⁪‪‬⁫‫‫⁪‌‮‏⁪‎⁪‬⁮‏​​‪‍‮‏‭‫⁭⁫⁫‮
	// privatescope
	internal static string u206e‍⁯​‏‏​⁯‫⁪‫‌⁭⁪‪‬⁫‫‫⁪‌‮‏⁪‎⁪‬⁮‏​​‪‍‮‏‭‫⁭⁫⁫‮(string str, object obj)
	{
		return string.Format(str, obj);
	}

	// ‪‍‮‪‬‌‌‍‬‬​⁬⁮⁪​‌‫⁭‎⁯​⁯⁪‍‎‍⁪‍​⁭⁪‪⁫⁪‍⁯‏⁮⁮‮
	// privatescope
	internal static bool u202a‍‮‪‬‌‌‍‬‬​⁬⁮⁪​‌‫⁭‎⁯​⁯⁪‍‎‍⁪‍​⁭⁪‪⁫⁪‍⁯‏⁮⁮‮(string str, string str)
	{
		return string.Equals(str, str);
	}

	// ‍⁪⁫⁮‪‏‎‭‮‎⁬‪⁯‭⁪‭‎‏​⁪‎⁮‪‭⁪‌‍‮‮‏‌‬‫‌⁪⁬‫⁫‎‭‮
	// privatescope
	internal static string u200d⁪⁫⁮‪‏‎‭‮‎⁬‪⁯‭⁪‭‎‏​⁪‎⁮‪‭⁪‌‍‮‮‏‌‬‫‌⁪⁬‫⁫‎‭‮(Exception exception)
	{
		return exception.Message;
	}

	// ⁫‮​‎‍⁬⁯⁫⁭⁫‏‭⁫⁪‎‫⁯⁯‬‏‭⁭‬⁫‌⁫‮‫⁭‪‭‮‭‏‭‌⁬⁮‪‪‮
	// privatescope
	internal static bool u206b‮​‎‍⁬⁯⁫⁭⁫‏‭⁫⁪‎‫⁯⁯‬‏‭⁭‬⁫‌⁫‮‫⁭‪‭‮‭‏‭‌⁬⁮‪‪‮(string str, string str)
	{
		return str == str;
	}

	// ‌​‍⁪‬‏‎⁯‪⁭⁮‏⁬‮⁫⁪⁬‎⁮​‪⁫‭‏‮‬⁯‬⁯‭‮⁪‫⁯‬⁮‬⁮‌‍‮
	// privatescope
	internal static bool u200c​‍⁪‬‏‎⁯‪⁭⁮‏⁬‮⁫⁪⁬‎⁮​‪⁫‭‏‮‬⁯‬⁯‭‮⁪‫⁯‬⁮‬⁮‌‍‮(string str, string str)
	{
		return str.StartsWith(str);
	}

	// ‌‫‭⁪⁪‍‪⁪⁯‎⁮​‍‪⁭‌‌⁯⁯⁫‮​‌⁭‭‍⁭‮⁮⁬‎‭‏⁯⁫​‮‌‏‭‮
	// privatescope
	internal static bool u200c‫‭⁪⁪‍‪⁪⁯‎⁮​‍‪⁭‌‌⁯⁯⁫‮​‌⁭‭‍⁭‮⁮⁬‎‭‏⁯⁫​‮‌‏‭‮(string str, string str)
	{
		return str.EndsWith(str);
	}

	// ‍⁬⁫‪‎​‭‌⁫‌​‎‌‪‭‫⁮‌​⁭‬‮⁪⁯⁬⁬‮⁭⁪‌‭‫⁪‭⁫⁯‌​‮‭‮
	// privatescope
	internal static string[] u200d⁬⁫‪‎​‭‌⁫‌​‎‌‪‭‫⁮‌​⁭‬‮⁪⁯⁬⁬‮⁭⁪‌‭‫⁪‭⁫⁯‌​‮‭‮(string str, char[] chrArray)
	{
		return str.Split(chrArray);
	}

	// ⁭⁭‫‍⁪​‫‬‫‎‏⁬⁯⁭​‫⁯‎‮‬‬⁯‌‮‫‏⁭‮‌⁮‮‬⁭‎‪⁪‮⁮‬‮
	// privatescope
	internal static int u206d⁭‫‍⁪​‫‬‫‎‏⁬⁯⁭​‫⁯‎‮‬‬⁯‌‮‫‏⁭‮‌⁮‮‬⁭‎‪⁪‮⁮‬‮(string str)
	{
		return str.Length;
	}

	// ⁫⁯⁬‌​⁬‪‍‏‮​‍⁬⁬⁮‫‎​⁮‌⁮‎‭⁪⁪‫⁪⁭⁫⁯‎⁯⁪‭‌​⁯‪​‮‮
	// privatescope
	internal static string u206b⁯⁬‌​⁬‪‍‏‮​‍⁬⁬⁮‫‎​⁮‌⁮‎‭⁪⁪‫⁪⁭⁫⁯‎⁯⁪‭‌​⁯‪​‮‮(string str, int num, int num)
	{
		return str.Substring(num, num);
	}

	// ‌‍‪⁮‭‫‫⁫‏⁯⁮‪⁯‍‬‪⁬‏‪⁬⁫‪⁯‭‬‬​‏⁭‍‏⁭⁬⁫‍⁮‬‌⁫‮
	// privatescope
	internal static InvalidOperationException u200c‍‪⁮‭‫‫⁫‏⁯⁮‪⁯‍‬‪⁬‏‪⁬⁫‪⁯‭‬‬​‏⁭‍‏⁭⁬⁫‍⁮‬‌⁫‮(string str)
	{
		return new InvalidOperationException(str);
	}

	// ‭⁮‮​‏⁪‌⁯‌‌⁭⁮⁮‮‮‌‫‌‪‬⁬​‫‍‏​‪​‭‌‬​⁭⁯⁫​⁫‫‌‬‮
	// privatescope
	internal static bool u202d⁮‮​‏⁪‌⁯‌‌⁭⁮⁮‮‮‌‫‌‪‬⁬​‫‍‏​‪​‭‌‬​⁭⁯⁫​⁫‫‌‬‮(string str, string str)
	{
		return str != str;
	}

	// ‍⁯‬⁬‮‮‪⁮​‪⁪‮​‍⁮​‬‏‎‎​⁮⁮‫‎‬‪⁭‫‍‭‏⁭‮‭‬⁬⁫⁭⁬‮
	// privatescope
	internal static string u200d⁯‬⁬‮‮‪⁮​‪⁪‮​‍⁮​‬‏‎‎​⁮⁮‫‎‬‪⁭‫‍‭‏⁭‮‭‬⁬⁫⁭⁬‮(string str)
	{
		return str.Trim();
	}

	// ‮‌‫⁪‌‭⁮‍⁫⁭⁪⁮‭‪‪​‌⁭‬‏‍⁮‏‌⁮‎‏⁬⁯‪⁯​⁫⁯⁫⁯‬⁮​‎‮
	// privatescope
	internal static int u202e‌‫⁪‌‭⁮‍⁫⁭⁪⁮‭‪‪​‌⁭‬‏‍⁮‏‌⁮‎‏⁬⁯‪⁯​⁫⁯⁫⁯‬⁮​‎‮(string str)
	{
		return Convert.ToInt32(str);
	}

	// ‎‮⁬​⁫⁭‪‮⁯‍⁮⁭‌⁬⁬​‌‫‍‎⁮‪‪​‎⁮⁯⁬‮‌⁫‬‎‫⁪⁫‪‎⁪⁪‮
	// privatescope
	internal static bool u200e‮⁬​⁫⁭‪‮⁯‍⁮⁭‌⁬⁬​‌‫‍‎⁮‪‪​‎⁮⁯⁬‮‌⁫‬‎‫⁪⁫‪‎⁪⁪‮(string str)
	{
		return Convert.ToBoolean(str);
	}

	// ‮‪‬⁪‌‌⁪‌‪⁬‍‪⁯⁪‫‫⁯‬‫⁫‎‪‎​‍‬⁭​‌‌⁮‬‏⁮⁫⁮‏‌‬⁫‮
	// privatescope
	internal static long u202e‪‬⁪‌‌⁪‌‪⁬‍‪⁯⁪‫‫⁯‬‫⁫‎‪‎​‍‬⁭​‌‌⁮‬‏⁮⁫⁮‏‌‬⁫‮(string str)
	{
		return Convert.ToInt64(str);
	}

	// ‪⁫‮‎⁮​⁬‎‪⁬‮‎‪⁪‍‬‪⁬‬​‌‬⁮‌⁬‫‮‍‏‌‭‮‏‪‎⁮‌‬⁬‫‮
	// privatescope
	internal static void u202a⁫‮‎⁮​⁬‎‪⁬‮‎‪⁪‍‬‪⁬‬​‌‬⁮‌⁬‫‮‍‏‌‭‮‏‪‎⁮‌‬⁬‫‮(ISharpControl sharpControl, long num)
	{
		sharpControl.set_Frequency(num);
	}

	// ‌⁪‍​⁭‫‬‫⁬‎⁯​‎‪‌‌⁬‍‬‮⁮‮⁯‮‎‬⁪⁬⁫‪⁯⁬‏‬‎‏‭‭‫⁪‮
	// privatescope
	internal static Type u200c⁪‍​⁭‫‬‫⁬‎⁯​‎‪‌‌⁬‍‬‮⁮‮⁯‮‎‬⁪⁬⁫‪⁯⁬‏‬‎‏‭‭‫⁪‮(RuntimeTypeHandle runtimeTypeHandle)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle);
	}

	// ‬⁯‬‫‍​⁯‍‌⁪⁮⁪⁬‬‮‬‏‬⁭‪‏‬​‬‭⁫‫⁪⁯‌‪⁬‌⁯⁭⁮‌‭‭‎‮
	// privatescope
	internal static void u202c⁯‬‫‍​⁯‍‌⁪⁮⁪⁬‬‮‬‏‬⁭‪‏‬​‬‭⁫‫⁪⁯‌‪⁬‌⁯⁭⁮‌‭‭‎‮(ISharpControl sharpControl, DetectorType detectorType)
	{
		sharpControl.set_DetectorType(detectorType);
	}

	// ⁪‬‮⁬‭‌⁬‭‌⁯‍⁬⁭‌⁯‎‪‌‎‍‮‭‬⁬⁮‬⁫‍⁯⁫⁮‌‬⁪⁪‬⁫‬‭‫‮
	// privatescope
	internal static void u206a‬‮⁬‭‌⁬‭‌⁯‍⁬⁭‌⁯‎‪‌‎‍‮‭‬⁬⁮‬⁫‍⁯⁫⁮‌‬⁪⁪‬⁫‬‭‫‮(ISharpControl sharpControl, int num)
	{
		sharpControl.set_FilterBandwidth(num);
	}

	// ​‬‏‎‮‎‎‮‪⁪‪‫⁬⁯​‌‌‭‪⁭‫‫‌‪‎‭‌‌⁬‌‭‮⁯⁮‮‮‭⁬‬‮‮
	// privatescope
	internal static void u200b‬‏‎‮‎‎‮‪⁪‪‫⁬⁯​‌‌‭‪⁭‫‫‌‪‎‭‌‌⁬‌‭‮⁯⁮‮‮‭⁬‬‮‮(ISharpControl sharpControl, int num)
	{
		sharpControl.set_AudioGain(num);
	}

	// ‌⁪⁭⁯‮‍⁯⁭‏‪⁫⁬‎‍⁭⁮‍‍⁫⁭‮‏‭​⁪⁪⁮‏⁮‮‎‪⁪‮⁭‭‍‪⁬⁪‮
	// privatescope
	internal static long u200c⁪⁭⁯‮‍⁯⁭‏‪⁫⁬‎‍⁭⁮‍‍⁫⁭‮‏‭​⁪⁪⁮‏⁮‮‎‪⁪‮⁭‭‍‪⁬⁪‮(ISharpControl sharpControl)
	{
		return sharpControl.get_Frequency();
	}

	// ‭‌‭⁭⁫‌​‎‬‪‌‏⁯⁮⁪‬‭‎‬⁫⁫⁪⁫‫‪⁭⁭‪​‫‭⁮‫​‎​‭​‏‍‮
	// privatescope
	internal static Form u202d‌‭⁭⁫‌​‎‬‪‌‏⁯⁮⁪‬‭‎‬⁫⁫⁪⁫‫‪⁭⁭‪​‫‭⁮‫​‎​‭​‏‍‮(ContainerControl containerControl)
	{
		return containerControl.ParentForm;
	}

	// ‭‏‏‪⁫⁬⁪‍⁭​‎‌‪‪‮⁭‭⁪⁭‫⁫⁪‫‏​‮‬‏‬‎‮⁫​‎‭‏‫‌​‮‮
	// privatescope
	internal static void u202d‏‏‪⁫⁬⁪‍⁭​‎‌‪‪‮⁭‭⁪⁭‫⁫⁪‫‏​‮‬‏‬‎‮⁫​‎‭‏‫‌​‮‮(Control control, int num)
	{
		control.Height = num;
	}

	// ‮‪⁫⁭⁭‫‪‭‪‬‬‭‏‬‌‌⁬‎⁮‌‏‏⁮⁪⁭‭‭‎⁭‏‫‭⁬⁮​‫‍‫‬‎‮
	// privatescope
	internal static void u202e‪⁫⁭⁭‫‪‭‪‬‬‭‏‬‌‌⁬‎⁮‌‏‏⁮⁪⁭‭‭‎⁭‏‫‭⁬⁮​‫‍‫‬‎‮(Control control, int num)
	{
		control.Left = num;
	}

	// ‫‮⁬‎⁭‭‪​⁫⁫‬⁬‮⁮​‭⁮‌‬⁯​​⁭‍‏‏‍‬‌⁯‌⁮⁮‍⁬⁪‎⁬‫‮‮
	// privatescope
	internal static void u202b‮⁬‎⁭‭‪​⁫⁫‬⁬‮⁮​‭⁮‌‬⁯​​⁭‍‏‏‍‬‌⁯‌⁮⁮‍⁬⁪‎⁬‫‮‮(Control control, int num)
	{
		control.Width = num;
	}

	// ⁫⁬‬‏‎⁯‎​‏‏‪⁪​‫⁯‬‮⁯⁪⁪⁪⁭‫⁮‌⁪⁯​⁬⁮‪‫​‎⁫⁭‏​‌‎‮
	// privatescope
	internal static void u206b⁬‬‏‎⁯‎​‏‏‪⁪​‫⁯‬‮⁯⁪⁪⁪⁭‫⁮‌⁪⁯​⁬⁮‪‫​‎⁫⁭‏​‌‎‮(Control control, int num)
	{
		control.Top = num;
	}

	// ⁭‬⁯‫‍‪⁪⁭‏‎‍‬‎⁭‭‎‭⁪‍‏‭‏‪‭‭⁯⁮⁯⁭‫‫‭⁫⁮‮‮‍‏‮⁪‮
	// privatescope
	internal static void u206d‬⁯‫‍‪⁪⁭‏‎‍‬‎⁭‭‎‭⁪‍‏‭‏‪‭‭⁯⁮⁯⁭‫‫‭⁫⁮‮‮‍‏‮⁪‮(Form form, FormWindowState formWindowState)
	{
		form.WindowState = formWindowState;
	}

	// ⁫‭‎⁬‪⁮⁬‏​⁫⁫‮‭⁫‫‭‪⁬​‬‬⁫⁪‭‭​⁬⁬‮‎‪‏⁪‍‭⁯⁮⁭‮⁬‮
	// privatescope
	internal static string u206b‭‎⁬‪⁮⁬‏​⁫⁫‮‭⁫‫‭‪⁬​‬‬⁫⁪‭‭​⁬⁬‮‎‪‏⁪‍‭⁯⁮⁭‮⁬‮(string str, string str)
	{
		return string.Concat(str, str);
	}

	// ‏⁮‮‌‫‍‬​‌‫‍‬‫‬⁮⁫⁮‏‮​⁫⁫‫‌⁪⁭‭‭⁭⁭‫‏‎‬‮‍⁬‍⁫⁬‮
	// privatescope
	internal static int u200f⁮‮‌‫‍‬​‌‫‍‬‫‬⁮⁫⁮‏‮​⁫⁫‫‌⁪⁭‭‭⁭⁭‫‏‎‬‮‍⁬‍⁫⁬‮(Control control)
	{
		return control.Height;
	}

	// ⁬⁭‌⁬⁬‬⁪⁮⁯‏‭‫⁭‎⁪⁮‪⁯⁮‎⁬‏⁪‭⁫‭​‮⁬⁭⁫⁮‍⁪‏‍‬‬‬‬‮
	// privatescope
	internal static string u206c⁭‌⁬⁬‬⁪⁮⁯‏‭‫⁭‎⁪⁮‪⁯⁮‎⁬‏⁪‭⁫‭​‮⁬⁭⁫⁮‍⁪‏‍‬‬‬‬‮(object obj, object obj, object obj)
	{
		return string.Concat(obj, obj, obj);
	}

	// ⁭⁮‭‭‎‌‌‍‭‭‍‏⁫⁫‏‭⁯‏⁯‍‪‫‌​‎​‪‌⁬⁪⁯‮‏‪‭‬‎‮‍‪‮
	// privatescope
	internal static int u206d⁮‭‭‎‌‌‍‭‭‍‏⁫⁫‏‭⁯‏⁯‍‪‫‌​‎​‪‌⁬⁪⁯‮‏‪‭‬‎‮‍‪‮(Control control)
	{
		return control.Left;
	}

	// ⁬⁫‍⁫⁬⁪​⁫‎‬‬⁪‬‫‬‬‎⁫‫⁬‬⁯‪‮⁯⁬‏‌‮‪‎‬⁭⁯‏‌⁭⁯​‬‮
	// privatescope
	internal static int u206c⁫‍⁫⁬⁪​⁫‎‬‬⁪‬‫‬‬‎⁫‫⁬‬⁯‪‮⁯⁬‏‌‮‪‎‬⁭⁯‏‌⁭⁯​‬‮(Control control)
	{
		return control.Width;
	}

	// ‌‎⁮‏‬⁯‍‬⁪⁭‪‮⁭‍‌⁬⁯‭‪‬‮‫‌⁪⁮​‌⁬‏⁪‪⁫⁮⁫‭⁪⁬‬‬⁬‮
	// privatescope
	internal static int u200c‎⁮‏‬⁯‍‬⁪⁭‪‮⁭‍‌⁬⁯‭‪‬‮‫‌⁪⁮​‌⁬‏⁪‪⁫⁮⁫‭⁪⁬‬‬⁬‮(Control control)
	{
		return control.Top;
	}

	// ‮‍‮‍⁯​⁪‌⁬‫⁭‍⁬⁪​‏⁬⁯​‭‌‏‏⁬⁯​⁬⁯⁯‮⁫⁮‍⁬‭‍⁬‬‎‌‮
	// privatescope
	internal static FormWindowState u202e‍‮‍⁯​⁪‌⁬‫⁭‍⁬⁪​‏⁬⁯​‭‌‏‏⁬⁯​⁬⁯⁯‮⁫⁮‍⁬‭‍⁬‬‎‌‮(Form form)
	{
		return form.WindowState;
	}

	// ⁯‮‪‌‫⁬‭‏‪‪⁬⁭‫⁮‍‪⁯⁭‬‏‎‌‎⁬‮‌‍⁮⁯‌‏⁮⁯​‬‭‎‬‮‌‮
	// privatescope
	internal static string u206f‮‪‌‫⁬‭‏‪‪⁬⁭‫⁮‍‪⁯⁭‬‏‎‌‎⁬‮‌‍⁮⁯‌‏⁮⁯​‬‭‎‬‮‌‮(object obj, object obj)
	{
		return string.Concat(obj, obj);
	}

	// ‪⁫‭‭⁯⁫⁪⁪‍‪‭‏⁯⁪⁪‎​⁪⁬⁫‮‏⁫⁫⁫‮‍⁪⁫​‫‍‭⁭‌⁭‫⁮⁫‭‮
	// privatescope
	internal static void u202a⁫‭‭⁯⁫⁪⁪‍‪‭‏⁯⁪⁪‎​⁪⁬⁫‮‏⁫⁫⁫‮‍⁪⁫​‫‍‭⁭‌⁭‫⁮⁫‭‮(ISharpControl sharpControl)
	{
		sharpControl.StartRadio();
	}

	// ⁫⁮⁬⁮‭⁫⁫⁯⁪‮⁫‎‮‌⁪​⁭⁬⁪‌‬‫‎‫‭‭‫⁬⁪‎‬‏⁮‌‫‌‏⁬‎‏‮
	// privatescope
	internal static void u206b⁮⁬⁮‭⁫⁫⁯⁪‮⁫‎‮‌⁪​⁭⁬⁪‌‬‫‎‫‭‭‫⁬⁪‎‬‏⁮‌‫‌‏⁬‎‏‮(ISharpControl sharpControl)
	{
		sharpControl.StopRadio();
	}

	// ‎⁮‪​‪‎‏⁪​⁭‬‬⁫⁮‪‌‏‮⁯‮⁯⁯‌​⁯‭‭‮⁮⁯‮‎‮⁯⁬‍‌‪⁫⁫‮
	// privatescope
	internal static Type u200e⁮‪​‪‎‏⁪​⁭‬‬⁫⁮‪‌‏‮⁯‮⁯⁯‌​⁯‭‭‮⁮⁯‮‎‮⁯⁬‍‌‪⁫⁫‮(object obj)
	{
		return obj.GetType();
	}

	// ​⁭⁮⁪‎‪⁯⁪​‫‫⁬⁪‫⁪⁭‍⁫‫‍‍‌‍‪⁫‪‬‎⁬‎⁬‬⁮⁫‭‎⁮⁯​‫‮
	// privatescope
	internal static bool u200b⁭⁮⁪‎‪⁯⁪​‫‫⁬⁪‫⁪⁭‍⁫‫‍‍‌‍‪⁫‪‬‎⁬‎⁬‬⁮⁫‭‎⁮⁯​‫‮(Type type, Type type)
	{
		return type == type;
	}

	// ‪‏‌⁮⁪⁮⁬⁯⁮⁬⁮‎‮⁫⁫‭​‌⁬⁬‪⁮‭​‏‍‏⁫‮‎⁮⁭‫⁯​‬‏‌​⁪‮
	// privatescope
	internal static bool u202a‏‌⁮⁪⁮⁬⁯⁮⁬⁮‎‮⁫⁫‭​‌⁬⁬‪⁮‭​‏‍‏⁫‮‎⁮⁭‫⁯​‬‏‌​⁪‮(Type type, Type type)
	{
		return type != type;
	}

	// ‪‍⁫‍‏⁫‍‭‭⁪‫‌⁯⁪⁫⁬⁯⁭⁪‫‫⁭‫‮‌⁬‫‮‌‭‭‬‬‮‬⁮⁯‭‮‏‮
	// privatescope
	internal static object u202a‍⁫‍‏⁫‍‭‭⁪‫‌⁯⁪⁫⁬⁯⁭⁪‫‫⁭‫‮‌⁬‫‮‌‭‭‬‬‮‬⁮⁯‭‮‏‮(Type type, string str, bool flag)
	{
		return Enum.Parse(type, str, flag);
	}

	// ​‍⁯‎​‬‎‎‪‏‎‮‪‌‎‪⁪⁭‮‍‏⁫⁯⁫‏⁫‮‭⁫⁬‏​⁫⁬‮‪‍‏‭‍‮
	// privatescope
	internal static string[] u200b‍⁯‎​‬‎‎‪‏‎‮‪‌‎‪⁪⁭‮‍‏⁫⁯⁫‏⁫‮‭⁫⁬‏​⁫⁬‮‪‍‏‭‍‮(Type type)
	{
		return Enum.GetNames(type);
	}

	// ‭⁫⁯‫‭⁭⁪‪⁫‬⁭​⁯⁬‪⁬‬​‬‎⁭⁬⁯⁯‎‮⁬⁭‍‌‪‌‍⁮⁮‮‪⁭‪‎‮
	// privatescope
	internal static string u202d⁫⁯‫‭⁭⁪‪⁫‬⁭​⁯⁬‪⁬‬​‬‎⁭⁬⁯⁯‎‮⁬⁭‍‌‪‌‍⁮⁮‮‪⁭‪‎‮(string str, string[] strArrays)
	{
		return string.Join(str, strArrays);
	}

	// ⁯‬‭‭‎⁪​⁬⁫‏⁭‎‎​⁫‫⁯​‫‮‫‌‫⁬⁬⁬‎‏⁯⁭‫⁫‮‫⁮‪​‎⁫‏‮
	// privatescope
	internal static int u206f‬‭‭‎⁪​⁬⁫‏⁭‎‎​⁫‫⁯​‫‮‫‌‫⁬⁬⁬‎‏⁯⁭‫⁫‮‫⁮‪​‎⁫‏‮(ISharpControl sharpControl)
	{
		return sharpControl.get_AudioGain();
	}

	// ‬⁫⁪⁪‌‪⁭⁮‎‏‏‎‎‎‏‌⁪⁮‎⁫‎⁭‮‏⁭‍‌‌⁭‫⁫​⁭‮⁬‮‬⁭‮‪‮
	// privatescope
	internal static void u202c⁫⁪⁪‌‪⁭⁮‎‏‏‎‎‎‏‌⁪⁮‎⁫‎⁭‮‏⁭‍‌‌⁭‫⁫​⁭‮⁬‮‬⁭‮‪‮(ISharpControl sharpControl, bool flag)
	{
		sharpControl.set_AudioIsMuted(flag);
	}

	// ‌⁬‌⁫⁯‌⁬⁬‌‭‍⁫⁪‏‍‌⁪⁮⁬‎‪⁯‫‏⁮⁮‭⁭‌⁬‮‭⁭⁪⁮‏‏⁮‪‬‮
	// privatescope
	internal static bool u200c⁬‌⁫⁯‌⁬⁬‌‭‍⁫⁪‏‍‌⁪⁮⁬‎‪⁯‫‏⁮⁮‭⁭‌⁬‮‭⁭⁪⁮‏‏⁮‪‬‮(ISharpControl sharpControl)
	{
		return sharpControl.get_AudioIsMuted();
	}

	// ⁫⁪⁪⁮⁬‫‬‬‮‎⁮⁯⁫⁭⁭⁯‫‏‌‎‭‏⁮‮​⁯‫‏⁬⁫⁭⁭‏‭​⁮⁯‭‏‬‮
	// privatescope
	internal static long u206b⁪⁪⁮⁬‫‬‬‮‎⁮⁯⁫⁭⁭⁯‫‏‌‎‭‏⁮‮​⁯‫‏⁬⁫⁭⁭‏‭​⁮⁯‭‏‬‮(object obj)
	{
		return Convert.ToInt64(obj);
	}

	// ‮‬‭⁫​​‫⁫⁫⁭⁬‬‭⁭‮‍⁪⁯‎‍‍⁯‫‍‎⁬‮‭‌⁬‌⁬‬‌⁬‪‎⁬​‪‮
	// privatescope
	internal static DetectorType u202e‬‭⁫​​‫⁫⁫⁭⁬‬‭⁭‮‍⁪⁯‎‍‍⁯‫‍‎⁬‮‭‌⁬‌⁬‬‌⁬‪‎⁬​‪‮(ISharpControl sharpControl)
	{
		return sharpControl.get_DetectorType();
	}

	// ‍⁬​‏‍⁫‭‪‫⁬‍‍‌‭‬‮⁭‭​‌⁪​⁭⁯⁬⁭‪⁯‍⁬‭‫⁮​⁮‬⁮⁮‫‭‮
	// privatescope
	internal static bool u200d⁬​‏‍⁫‭‪‫⁬‍‍‌‭‬‮⁭‭​‌⁪​⁭⁯⁬⁭‪⁯‍⁬‭‫⁮​⁮‬⁮⁮‫‭‮(ISharpControl sharpControl)
	{
		return sharpControl.get_IsPlaying();
	}

	// ‌‪‌‬⁯​‏⁯‫‌​‌⁯‎⁭‪‏‏‍‪‪⁮‬‭⁯‍‭‏‎⁭‬⁫⁭⁬‏‬⁬​‮‎‮
	// privatescope
	internal static int u200c‪‌‬⁯​‏⁯‫‌​‌⁯‎⁭‪‏‏‍‪‪⁮‬‭⁯‍‭‏‎⁭‬⁫⁭⁬‏‬⁬​‮‎‮(ISharpControl sharpControl)
	{
		return sharpControl.get_FilterBandwidth();
	}

	// ‬‌‍‏‌‎‬⁭⁯‮‫⁭‬⁬‮⁮‮⁮⁭‬‎‭‮‎⁫⁯⁪‎‭⁯⁪⁮‏⁭‬⁯‭⁯‎‬‮
	// privatescope
	internal static string u202c‌‍‏‌‎‬⁭⁯‮‫⁭‬⁬‮⁮‮⁮⁭‬‎‭‮‎⁫⁯⁪‎‭⁯⁪⁮‏⁭‬⁯‭⁯‎‬‮(string str, string str, string str, string str)
	{
		return string.Concat(str, str, str, str);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮()
	{
		u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮.u206e⁪⁬‪‭‭‎‮⁮‌‏⁪‫⁯​⁪‏‫‌⁪⁫⁪⁬⁭‍‎⁯‏‪‬⁬‍⁫‮‎‬‬⁪⁬⁯‮ = new string[] { u003cModuleu003e.u206f⁮​‌‪‮‎‭‏‮‎⁮⁮‮⁬⁫‍‍⁪‍⁫⁮‏​‎⁬⁯⁪‪‍⁪⁮‎⁬⁪⁫​⁮⁪⁮‮<string>(-1882468066), u003cModuleu003e.u202a‮‫‏‫‬‬‪⁫⁬​‏⁫⁭‍‪‪‎⁬​‪​‌⁮‮‌​⁫​⁬‪‫⁪⁯⁪‎‫⁭‎⁪‮<string>(160467192), u003cModuleu003e.u200e‏‌‬⁮‪‭⁭‭⁭‎​‏‌‭‭‭⁭⁬⁯⁫‍‮‫⁯‌‮‏​‬⁫⁯⁮⁫‮‪⁫‬⁮⁬‮<string>(-92390345) };
		u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮.u200d⁮‭⁮‪‍‍‬​‪⁫⁪‏‭‫​‫‬‌​⁯​⁫⁯‪⁭‏⁪‮‫⁯⁫⁫⁪⁯​‍⁭⁮⁯‮ = new Dictionary<string, Func<bool, object, string>>();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮(ISharpControl sharpControl, TetraPanel tetraPanel)
	{
		Dictionary<string, Func<bool, object, string>> strs;
		Dictionary<string, Func<bool, object, string>> strs1;
	Label1:
		int num = 4510075;
		while (true)
		{
			int num1 = num ^ 861744169;
			uint num2 = (uint)num1;
			switch (num1 % 15)
			{
				case 0:
				{
					u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮.u200d⁮‭⁮‪‍‍‬​‪⁫⁪‏‭‫​‫‬‌​⁯​⁫⁯‪⁭‏⁪‮‫⁯⁫⁫⁪⁯​‍⁭⁮⁯‮.Add(u003cModuleu003e.u200f⁫‌​⁬‌‎‎‏‍‍⁫‎​‌‬⁯‬‫‭‎‏​‌​⁪‭‬⁬‮⁬​‌⁬⁪‫‫‎⁪⁮‮<string>(-1312373284), new Func<bool, object, string>(this.u206f‫‎⁪‌⁫⁭‫‮‪⁮⁮⁭⁯⁮‎‬‮‏‎‫‫⁯‏‬⁮​‮​⁭‫‏‬​‍‭‎‌‍‏‮));
					num = 1194308802;
					continue;
				}
				case 1:
				{
					u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮.u200d⁮‭⁮‪‍‍‬​‪⁫⁪‏‭‫​‫‬‌​⁯​⁫⁯‪⁭‏⁪‮‫⁯⁫⁫⁪⁯​‍⁭⁮⁯‮.Add(u003cModuleu003e.u206f⁮​‌‪‮‎‭‏‮‎⁮⁮‮⁬⁫‍‍⁪‍⁫⁮‏​‎⁬⁯⁪‪‍⁪⁮‎⁬⁪⁫​⁮⁪⁮‮<string>(-520582822), new Func<bool, object, string>(this.u200b‪⁯‭⁯‮‭⁬​‪‌‌⁫⁬⁯‮‫⁫‫⁮⁯⁬⁬⁯‪‏​‭‍⁫⁬‎‫‬‭⁫‍‍‮‎‮));
					u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮.u200d⁮‭⁮‪‍‍‬​‪⁫⁪‏‭‫​‫‬‌​⁯​⁫⁯‪⁭‏⁪‮‫⁯⁫⁫⁪⁯​‍⁭⁮⁯‮.Add(u003cModuleu003e.u200d​‍⁮‏‭⁮⁪‌‪‬‬‬‪⁬⁭⁫⁫‬⁪⁬⁬⁬‏⁮⁭‌‍‏‍‏‎‬⁬​‪‎​‎⁭‮<string>(257100703), new Func<bool, object, string>(this.u202d‮⁭⁮​⁮‭⁫‫‬​⁪⁭⁮‏‌‍⁬⁯⁪⁫⁭⁮‮‪⁪⁯‬⁪‪⁫‪‮‏‬⁯⁫⁯‏‌‮));
					num = 887113165;
					continue;
				}
				case 2:
				{
					u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮.u200d⁮‭⁮‪‍‍‬​‪⁫⁪‏‭‫​‫‬‌​⁯​⁫⁯‪⁭‏⁪‮‫⁯⁫⁫⁪⁯​‍⁭⁮⁯‮.Add(u003cModuleu003e.u200f⁫‌​⁬‌‎‎‏‍‍⁫‎​‌‬⁯‬‫‭‎‏​‌​⁪‭‬⁬‮⁬​‌⁬⁪‫‫‎⁪⁮‮<string>(1039912885), new Func<bool, object, string>(this.u202d​⁮⁪‮‎‭‬‮‎⁫‪‎⁪⁭​‬‮​‏‪‎‫‪‌‎‎⁯‌‎⁫‫⁬‭‪‏⁮‎⁮‬‮));
					u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮.u200d⁮‭⁮‪‍‍‬​‪⁫⁪‏‭‫​‫‬‌​⁯​⁫⁯‪⁭‏⁪‮‫⁯⁫⁫⁪⁯​‍⁭⁮⁯‮.Add(u003cModuleu003e.u200e‏‌‬⁮‪‭⁭‭⁭‎​‏‌‭‭‭⁭⁬⁯⁫‍‮‫⁯‌‮‏​‬⁫⁯⁮⁫‮‪⁫‬⁮⁬‮<string>(1024155947), new Func<bool, object, string>(this.u206f⁮‎‍‏⁬‮‌‍⁭‎‪‭‌‎‪‫‏‏⁯‌‭⁪‭‪⁫⁬⁭‏‌‭⁭⁮‎‭⁪⁬​‍‏‮));
					u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮.u200d⁮‭⁮‪‍‍‬​‪⁫⁪‏‭‫​‫‬‌​⁯​⁫⁯‪⁭‏⁪‮‫⁯⁫⁫⁪⁯​‍⁭⁮⁯‮.Add(u003cModuleu003e.u206f⁮​‌‪‮‎‭‏‮‎⁮⁮‮⁬⁫‍‍⁪‍⁫⁮‏​‎⁬⁯⁪‪‍⁪⁮‎⁬⁪⁫​⁮⁪⁮‮<string>(397054691), new Func<bool, object, string>(this.u202e‌​‬‏‍‎‌‫‌⁭⁭⁬‌‪⁭‭‍‏‌⁮‌‌‏‏‏‫⁯‪⁫‍‫‪⁫⁬‬‏‫⁯‍‮));
					num = 1205121683;
					continue;
				}
				case 3:
				{
					u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮.u200d⁮‭⁮‪‍‍‬​‪⁫⁪‏‭‫​‫‬‌​⁯​⁫⁯‪⁭‏⁪‮‫⁯⁫⁫⁪⁯​‍⁭⁮⁯‮.Add(u003cModuleu003e.u202a‮‫‏‫‬‬‪⁫⁬​‏⁫⁭‍‪‪‎⁬​‪​‌⁮‮‌​⁫​⁬‪‫⁪⁯⁪‎‫⁭‎⁪‮<string>(-232510434), new Func<bool, object, string>(this.u202a‭⁪⁯‮⁯​‬‭⁭‮‎‭‬​‪‫​⁬‌‬⁬‬‮‎‬‎‌‫⁫‬⁫‎​‌⁭⁭​⁯‍‮));
					u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮.u200d⁮‭⁮‪‍‍‬​‪⁫⁪‏‭‫​‫‬‌​⁯​⁫⁯‪⁭‏⁪‮‫⁯⁫⁫⁪⁯​‍⁭⁮⁯‮.Add(u003cModuleu003e.u206f⁮​‌‪‮‎‭‏‮‎⁮⁮‮⁬⁫‍‍⁪‍⁫⁮‏​‎⁬⁯⁪‪‍⁪⁮‎⁬⁪⁫​⁮⁪⁮‮<string>(-640402710), new Func<bool, object, string>(this.u202d⁪‎‬⁯⁯⁪⁯‍‪‏⁯​⁮‬‏‫‏​⁮⁮‎‌‮​‏⁬‭⁭‬‬‎⁪‬​⁮⁮⁯‮⁯‮));
					num = 258818010;
					continue;
				}
				case 4:
				{
					u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮.u200d⁮‭⁮‪‍‍‬​‪⁫⁪‏‭‫​‫‬‌​⁯​⁫⁯‪⁭‏⁪‮‫⁯⁫⁫⁪⁯​‍⁭⁮⁯‮.Add(u003cModuleu003e.u200d​‍⁮‏‭⁮⁪‌‪‬‬‬‪⁬⁭⁫⁫‬⁪⁬⁬⁬‏⁮⁭‌‍‏‍‏‎‬⁬​‪‎​‎⁭‮<string>(-1124581501), new Func<bool, object, string>(this.u200b⁮​‬​‎⁬⁬⁪​⁫‬⁪‭‮‌​⁬‮⁭‭⁪⁮⁮⁯‭‎‍⁬⁮⁮‏⁫​‪‌‍‌⁮⁪‮));
					num = 378700149;
					continue;
				}
				case 5:
				{
					this.u206a‪‭⁮‍‭⁭‌⁫​‏‮⁪‍⁪‭‍‬‪‏‬‎‎‏‪‪‮⁭⁫‍‌⁮⁪‪‌⁪‏⁯⁫‍‮ = tetraPanel;
					num = (int)(num2 * -369140555 ^ 1811234579);
					continue;
				}
				case 6:
				{
					this.u206b‏‭‫⁫‎‪‬‪⁪‎‪‍⁯‮‏‎⁮‏⁪‍‬‍⁯‭‏⁪⁭‫‬⁮‪⁮‭‍‫‎​​‍‮ = sharpControl;
					num = (int)(num2 * 478353604 ^ 928779460);
					continue;
				}
				case 7:
				{
					strs = u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮.u200d⁮‭⁮‪‍‍‬​‪⁫⁪‏‭‫​‫‬‌​⁯​⁫⁯‪⁭‏⁪‮‫⁯⁫⁫⁪⁯​‍⁭⁮⁯‮;
					strs.Add(u003cModuleu003e.u200f⁫‌​⁬‌‎‎‏‍‍⁫‎​‌‬⁯‬‫‭‎‏​‌​⁪‭‬⁬‮⁬​‌⁬⁪‫‫‎⁪⁮‮<string>(1543176081), new Func<bool, object, string>(this.u202e⁫‍⁮‪‏⁯‫‍‭‫‌⁬‪‍‭‎⁪‮⁭⁯‬⁭‫⁫‎‪⁯‍‍⁮⁯‮⁫⁪​⁭⁪‏⁬‮));
					strs1 = u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮.u200d⁮‭⁮‪‍‍‬​‪⁫⁪‏‭‫​‫‬‌​⁯​⁫⁯‪⁭‏⁪‮‫⁯⁫⁫⁪⁯​‍⁭⁮⁯‮;
					strs1.Add(u003cModuleu003e.u206f⁮​‌‪‮‎‭‏‮‎⁮⁮‮⁬⁫‍‍⁪‍⁫⁮‏​‎⁬⁯⁪‪‍⁪⁮‎⁬⁪⁫​⁮⁪⁮‮<string>(-381679), new Func<bool, object, string>(this.u206d‌⁯‪⁮‍‌‪‍‏⁪‏‎‫⁪⁪‪⁭‎‮⁭⁫‍‍‎‏‫​⁭‮⁯‪⁮⁫⁫⁬‬⁭​‪‮));
					return;
				}
				case 8:
				{
					u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮.u200d⁮‭⁮‪‍‍‬​‪⁫⁪‏‭‫​‫‬‌​⁯​⁫⁯‪⁭‏⁪‮‫⁯⁫⁫⁪⁯​‍⁭⁮⁯‮.Add(u003cModuleu003e.u200e‏‌‬⁮‪‭⁭‭⁭‎​‏‌‭‭‭⁭⁬⁯⁫‍‮‫⁯‌‮‏​‬⁫⁯⁮⁫‮‪⁫‬⁮⁬‮<string>(-806734166), new Func<bool, object, string>(this.u206f‎⁪⁭‪⁯⁯‬‮‭⁯‪​⁭⁮⁮‍‫‪‮‌‍‍‏‭‬‮⁯⁯‪‎⁫‫‌⁯⁬‎⁮‏‬‮));
					u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮.u200d⁮‭⁮‪‍‍‬​‪⁫⁪‏‭‫​‫‬‌​⁯​⁫⁯‪⁭‏⁪‮‫⁯⁫⁫⁪⁯​‍⁭⁮⁯‮.Add(u003cModuleu003e.u200f⁫‌​⁬‌‎‎‏‍‍⁫‎​‌‬⁯‬‫‭‎‏​‌​⁪‭‬⁬‮⁬​‌⁬⁪‫‫‎⁪⁮‮<string>(-1663463320), new Func<bool, object, string>(this.u206f‎⁪⁭‪⁯⁯‬‮‭⁯‪​⁭⁮⁮‍‫‪‮‌‍‍‏‭‬‮⁯⁯‪‎⁫‫‌⁯⁬‎⁮‏‬‮));
					u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮.u200d⁮‭⁮‪‍‍‬​‪⁫⁪‏‭‫​‫‬‌​⁯​⁫⁯‪⁭‏⁪‮‫⁯⁫⁫⁪⁯​‍⁭⁮⁯‮.Add(u003cModuleu003e.u200e‏‌‬⁮‪‭⁭‭⁭‎​‏‌‭‭‭⁭⁬⁯⁫‍‮‫⁯‌‮‏​‬⁫⁯⁮⁫‮‪⁫‬⁮⁬‮<string>(-1053766167), new Func<bool, object, string>(this.u200c‌‭⁪⁫‍⁫‪⁪‌‌‬⁪⁬⁯‮‌​‬‏⁪‭⁮‭‬‏⁫⁫‏‎‌‫‏⁫‏‫‭‍⁯‬‮));
					num = 1599671016;
					continue;
				}
				case 9:
				{
					u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮.u200d⁮‭⁮‪‍‍‬​‪⁫⁪‏‭‫​‫‬‌​⁯​⁫⁯‪⁭‏⁪‮‫⁯⁫⁫⁪⁯​‍⁭⁮⁯‮.Add(u003cModuleu003e.u202a‮‫‏‫‬‬‪⁫⁬​‏⁫⁭‍‪‪‎⁬​‪​‌⁮‮‌​⁫​⁬‪‫⁪⁯⁪‎‫⁭‎⁪‮<string>(1056220413), new Func<bool, object, string>(this.u206d‎‮‭‪⁫‎⁭‎‌‪​⁯⁮‪‌⁮⁯‫‌‎‪‬‮‎​‏‏⁯‮‌‍⁭⁮‮‍⁭⁫‫‫‮));
					num = 1101646245;
					continue;
				}
				case 10:
				{
					u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮.u200d⁮‭⁮‪‍‍‬​‪⁫⁪‏‭‫​‫‬‌​⁯​⁫⁯‪⁭‏⁪‮‫⁯⁫⁫⁪⁯​‍⁭⁮⁯‮.Add(u003cModuleu003e.u202a‮‫‏‫‬‬‪⁫⁬​‏⁫⁭‍‪‪‎⁬​‪​‌⁮‮‌​⁫​⁬‪‫⁪⁯⁪‎‫⁭‎⁪‮<string>(484791938), new Func<bool, object, string>(this.u206f‎⁪⁭‪⁯⁯‬‮‭⁯‪​⁭⁮⁮‍‫‪‮‌‍‍‏‭‬‮⁯⁯‪‎⁫‫‌⁯⁬‎⁮‏‬‮));
					num = 1771355036;
					continue;
				}
				case 11:
				{
					goto Label1;
				}
				case 12:
				{
					u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮.u200d⁮‭⁮‪‍‍‬​‪⁫⁪‏‭‫​‫‬‌​⁯​⁫⁯‪⁭‏⁪‮‫⁯⁫⁫⁪⁯​‍⁭⁮⁯‮.Add(u003cModuleu003e.u200d​‍⁮‏‭⁮⁪‌‪‬‬‬‪⁬⁭⁫⁫‬⁪⁬⁬⁬‏⁮⁭‌‍‏‍‏‎‬⁬​‪‎​‎⁭‮<string>(-1205385328), new Func<bool, object, string>(this.u202d‪‍‮⁬‎‭‏⁪⁬‏⁮⁯‍‍‎‪‍‌⁭⁬⁯‌‏‮⁫‮‫‭‫‮​‌⁬‎⁭⁬⁭‏‮));
					u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮.u200d⁮‭⁮‪‍‍‬​‪⁫⁪‏‭‫​‫‬‌​⁯​⁫⁯‪⁭‏⁪‮‫⁯⁫⁫⁪⁯​‍⁭⁮⁯‮.Add(u003cModuleu003e.u200d​‍⁮‏‭⁮⁪‌‪‬‬‬‪⁬⁭⁫⁫‬⁪⁬⁬⁬‏⁮⁭‌‍‏‍‏‎‬⁬​‪‎​‎⁭‮<string>(-1119906713), new Func<bool, object, string>(this.u202c‭⁮​⁫‪‎⁪​⁫⁬‬‬‍⁪‍‪⁫‪‫‍‌‎‍‬⁭​‌⁫⁯‭⁮​‎‌⁮‫⁪⁮⁬‮));
					u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮.u200d⁮‭⁮‪‍‍‬​‪⁫⁪‏‭‫​‫‬‌​⁯​⁫⁯‪⁭‏⁪‮‫⁯⁫⁫⁪⁯​‍⁭⁮⁯‮.Add(u003cModuleu003e.u206f⁮​‌‪‮‎‭‏‮‎⁮⁮‮⁬⁫‍‍⁪‍⁫⁮‏​‎⁬⁯⁪‪‍⁪⁮‎⁬⁪⁫​⁮⁪⁮‮<string>(-984258587), new Func<bool, object, string>(this.u206e‫‪⁭‌‏​‮‎‮‫‎‭⁬‎​‫‭⁬⁫‍⁮⁬‏‌‬⁬‍⁯‌‎⁭‎‬‭‌⁯⁬‬‭‮));
					num = 234471576;
					continue;
				}
				case 13:
				{
					u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮.u200d⁮‭⁮‪‍‍‬​‪⁫⁪‏‭‫​‫‬‌​⁯​⁫⁯‪⁭‏⁪‮‫⁯⁫⁫⁪⁯​‍⁭⁮⁯‮.Add(u003cModuleu003e.u200d​‍⁮‏‭⁮⁪‌‪‬‬‬‪⁬⁭⁫⁫‬⁪⁬⁬⁬‏⁮⁭‌‍‏‍‏‎‬⁬​‪‎​‎⁭‮<string>(-345924390), new Func<bool, object, string>(this.u206f⁯⁮‎‍‫⁯‏⁪‫‫​⁪‭⁭⁪‮‎⁭‏‫‌⁫‍‫‎‬‫⁬‮‏‏⁮‭⁭‮‬‏‏⁮‮));
					num = 1851208351;
					continue;
				}
				case 14:
				{
					u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮.u200d⁮‭⁮‪‍‍‬​‪⁫⁪‏‭‫​‫‬‌​⁯​⁫⁯‪⁭‏⁪‮‫⁯⁫⁫⁪⁯​‍⁭⁮⁯‮.Add(u003cModuleu003e.u200d​‍⁮‏‭⁮⁪‌‪‬‬‬‪⁬⁭⁫⁫‬⁪⁬⁬⁬‏⁮⁭‌‍‏‍‏‎‬⁬​‪‎​‎⁭‮<string>(1802727955), new Func<bool, object, string>(this.u206c⁯‎⁫‮‭⁫‎‫‪‬‪‮⁯‬‮⁫‫⁫‭‍‌‎⁮‌⁮‪‏‌‍​‪⁫⁪‪⁯⁮‪‍‍‮));
					num = 335906275;
					continue;
				}
			}
		}
		strs = u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮.u200d⁮‭⁮‪‍‍‬​‪⁫⁪‏‭‫​‫‬‌​⁯​⁫⁯‪⁭‏⁪‮‫⁯⁫⁫⁪⁯​‍⁭⁮⁯‮;
		strs.Add(u003cModuleu003e.u200f⁫‌​⁬‌‎‎‏‍‍⁫‎​‌‬⁯‬‫‭‎‏​‌​⁪‭‬⁬‮⁬​‌⁬⁪‫‫‎⁪⁮‮<string>(1543176081), new Func<bool, object, string>(this.u202e⁫‍⁮‪‏⁯‫‍‭‫‌⁬‪‍‭‎⁪‮⁭⁯‬⁭‫⁫‎‪⁯‍‍⁮⁯‮⁫⁪​⁭⁪‏⁬‮));
		strs1 = u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮.u200d⁮‭⁮‪‍‍‬​‪⁫⁪‏‭‫​‫‬‌​⁯​⁫⁯‪⁭‏⁪‮‫⁯⁫⁫⁪⁯​‍⁭⁮⁯‮;
		strs1.Add(u003cModuleu003e.u206f⁮​‌‪‮‎‭‏‮‎⁮⁮‮⁬⁫‍‍⁪‍⁫⁮‏​‎⁬⁯⁪‪‍⁪⁮‎⁬⁪⁫​⁮⁪⁮‮<string>(-381679), new Func<bool, object, string>(this.u206d‌⁯‪⁮‍‌‪‍‏⁪‏‎‫⁪⁪‪⁭‎‮⁭⁫‍‍‎‏‫​⁭‮⁯‪⁮⁫⁫⁬‬⁭​‪‮));
	}
}