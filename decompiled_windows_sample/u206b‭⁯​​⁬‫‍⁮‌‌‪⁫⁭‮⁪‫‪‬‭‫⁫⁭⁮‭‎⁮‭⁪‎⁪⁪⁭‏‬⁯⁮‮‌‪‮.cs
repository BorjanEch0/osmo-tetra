using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Timers;
using System.Windows.Forms;

// ⁫‭⁯​​⁬‫‍⁮‌‌‪⁫⁭‮⁪‫‪‬‭‫⁫⁭⁮‭‎⁮‭⁪‎⁪⁪⁭‏‬⁯⁮‮‌‪‮
internal class u206b‭⁯​​⁬‫‍⁮‌‌‪⁫⁭‮⁪‫‪‬‭‫⁫⁭⁮‭‎⁮‭⁪‎⁪⁪⁭‏‬⁯⁮‮‌‪‮
{
	// ‭⁪‍⁫‏‎⁭⁪⁭⁯‮⁪​‎⁬‬‎⁭‏‌‬‎‎‬‪⁪⁫⁪​⁯‎⁬⁯⁬‌‫⁬⁮‬‫‮
	private const int u202d⁪‍⁫‏‎⁭⁪⁭⁯‮⁪​‎⁬‬‎⁭‏‌‬‎‎‬‪⁪⁫⁪​⁯‎⁬⁯⁬‌‫⁬⁮‬‫‮ = 4;

	// ​‫⁭⁪⁮⁭‪⁯⁪⁪‬⁫⁫⁮‬⁪‫‭⁮‮⁯‮​⁯‬​⁪⁫‌‫‬‮⁬‍‬‫‌‏‭‌‮
	private ManualResetEvent u200b‫⁭⁪⁮⁭‪⁯⁪⁪‬⁫⁫⁮‬⁪‫‭⁮‮⁯‮​⁯‬​⁪⁫‌‫‬‮⁬‍‬‫‌‏‭‌‮ = u206b‭⁯​​⁬‫‍⁮‌‌‪⁫⁭‮⁪‫‪‬‭‫⁫⁭⁮‭‎⁮‭⁪‎⁪⁪⁭‏‬⁯⁮‮‌‪‮.u206f⁫⁬⁬⁮‬‎‌⁮‫⁫⁫⁬‌⁬⁯‌⁪‎‌‏‬⁬‪⁯⁪‍‎‮⁫‬‭‎‍⁬⁪‭​⁫‭‮(false);

	// ‏⁯‭⁭‌⁯⁯​⁬⁮‎⁮⁪⁭⁬⁮⁭⁯‮‫⁪‬⁭⁮⁭‬⁫⁬‮‫⁫‎‮⁯⁯‏⁬‏⁮‫‮
	private object u200f⁯‭⁭‌⁯⁯​⁬⁮‎⁮⁪⁭⁬⁮⁭⁯‮‫⁪‬⁭⁮⁭‬⁫⁬‮‫⁫‎‮⁯⁯‏⁬‏⁮‫‮ = u206b‭⁯​​⁬‫‍⁮‌‌‪⁫⁭‮⁪‫‪‬‭‫⁫⁭⁮‭‎⁮‭⁪‎⁪⁪⁭‏‬⁯⁮‮‌‪‮.u206a‌‪‏‏‪⁫‎⁯‎⁬⁪⁯‎‏‫‫⁪‮⁬‭‎‫‎⁭⁪‭‪⁮‍⁯‮‎⁫‏⁬⁭​‮‪‮();

	// ⁬‬⁮‭⁫⁮‮‪⁬​⁯‬⁭‎‮⁫‏‫‮⁪⁬⁮⁫⁯‍‪⁪⁬‌⁫⁭‬⁫⁪‫⁮⁯⁬⁯‌‮
	private List<u202b‫‬‮⁬⁪⁪⁫‪‎‏‬‌‎⁪‫‍⁪⁮⁭‫⁬‮‪‍⁪‭‪​⁬‎⁬⁬‪‌​⁯‫‮‌‮> u206c‬⁮‭⁫⁮‮‪⁬​⁯‬⁭‎‮⁫‏‫‮⁪⁬⁮⁫⁯‍‪⁪⁬‌⁫⁭‬⁫⁪‫⁮⁯⁬⁯‌‮ = new List<u202b‫‬‮⁬⁪⁪⁫‪‎‏‬‌‎⁪‫‍⁪⁮⁭‫⁬‮‪‍⁪‭‪​⁬‎⁬⁬‪‌​⁯‫‮‌‮>();

	// ​‫‬⁬⁯‍‏‮‌‭⁬‬‌‭⁫‎​‫‮‪⁪​‍​‮⁮‏‬⁯‬‫⁮⁮⁮⁭⁯​​⁮‭‮
	private volatile bool u200b‫‬⁬⁯‍‏‮‌‭⁬‬‌‭⁫‎​‫‮‪⁪​‍​‮⁮‏‬⁯‬‫⁮⁮⁮⁭⁯​​⁮‭‮;

	// ⁪‌‭‪‍‪⁯⁯⁫‭​‪⁭⁮‫⁮⁬⁮‌⁭⁭‎‎⁭‌‏⁭⁯⁫‎‎⁯‍‫⁮⁯‮‎‬⁬‮
	private u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮ u206a‌‭‪‍‪⁯⁯⁫‭​‪⁭⁮‫⁮⁬⁮‌⁭⁭‎‎⁭‌‏⁭⁯⁫‎‎⁯‍‫⁮⁯‮‎‬⁬‮;

	// ⁬‬‍‮‬⁪‫‬⁮⁬⁭‬‬‮‭‏‫‪‬⁭⁪​‍‌⁭‫‪‏⁬⁫⁯⁯‭‮‮‍‭⁫‌⁭‮
	private int u206c‬‍‮‬⁪‫‬⁮⁬⁭‬‬‮‭‏‫‪‬⁭⁪​‍‌⁭‫‪‏⁬⁫⁯⁯‭‮‮‍‭⁫‌⁭‮;

	// ​‭‏‮⁯‌‎⁪‏​⁬‌⁪⁬⁯‎⁭⁯⁭‬⁮‪‫‬‮‪‍​‫‮‮⁯‍⁭⁬‏⁯‪⁭⁬‮
	private byte[] u200b‭‏‮⁯‌‎⁪‏​⁬‌⁪⁬⁯‎⁭⁯⁭‬⁮‪‫‬‮‪‍​‫‮‮⁯‍⁭⁬‏⁯‪⁭⁬‮ = u206b‭⁯​​⁬‫‍⁮‌‌‪⁫⁭‮⁪‫‪‬‭‫⁫⁭⁮‭‎⁮‭⁪‎⁪⁪⁭‏‬⁯⁮‮‌‪‮.u202d‏‏⁬‮‬⁮⁯⁭⁮​‌‌⁮‮‌‍‍⁯‌‍⁬⁪​⁬‍⁪‫⁫‏⁯‏‎‬‬⁬‌‮⁫‎‮(u206b‭⁯​​⁬‫‍⁮‌‌‪⁫⁭‮⁪‫‪‬‭‫⁫⁭⁮‭‎⁮‭⁪‎⁪⁪⁭‏‬⁯⁮‮‌‪‮.u206f‫⁮⁭⁬‎​‮‪‪‮‏‫‌‌‏‫⁮⁯‌‫‪‌⁪‬‪‮‌‫‌⁫‍‪‮‍⁬⁪⁪⁬⁯‮(), u003cModuleu003e.u200f⁫‌​⁬‌‎‎‏‍‍⁫‎​‌‬⁯‬‫‭‎‏​‌​⁪‭‬⁬‮⁬​‌⁬⁪‫‫‎⁪⁮‮<string>(-563534857));

	[MethodImpl(MethodImplOptions.NoInlining)]
	// ⁬‭‭⁫‮⁫⁪⁫⁪‪⁯​⁮⁯‭‌‌⁮⁪‪‫‎⁫⁯⁫⁯​‫⁭‏‫⁬‎⁭⁯‌⁭‪‬‌‮
	public void u206c‭‭⁫‮⁫⁪⁫⁪‪⁯​⁮⁯‭‌‌⁮⁪‪‫‎⁫⁯⁫⁯​‫⁭‏‫⁬‎⁭⁯‌⁭‪‬‌‮()
	{
		// 
		// Current member / type: System.Void ⁫‭⁯​​⁬‫‍⁮‌‌‪⁫⁭‮⁪‫‪‬‭‫⁫⁭⁮‭‎⁮‭⁪‎⁪⁪⁭‏‬⁯⁮‮‌‪‮::⁬‭‭⁫‮⁫⁪⁫⁪‪⁯​⁮⁯‭‌‌⁮⁪‪‫‎⁫⁯⁫⁯​‫⁭‏‫⁬‎⁭⁯‌⁭‪‬‌‮()
		// File path: C:\SDRSharp\Plugins\Tetra\SDRSharp.Tetra.dll
		// 
		// Product version: 0.0.0.0
		// Exception in: System.Void ⁬‭‭⁫‮⁫⁪⁫⁪‪⁯​⁮⁯‭‌‌⁮⁪‪‫‎⁫⁯⁫⁯​‫⁭‏‫⁬‎⁭⁯‌⁭‪‬‌‮()
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

	// ‫‭‎‭‮⁯‭‌‬⁫‫‌‮​‌⁮‪‏‬‬⁬‬⁪⁫‏​‬​⁮⁯‌‌⁮⁮⁮​‬⁭⁫‌‮
	public void u202b‭‎‭‮⁯‭‌‬⁫‫‌‮​‌⁮‪‏‬‬⁬‬⁪⁫‏​‬​⁮⁯‌‌⁮⁮⁮​‬⁭⁫‌‮()
	{
		this.u200b‫‬⁬⁯‍‏‮‌‭⁬‬‌‭⁫‎​‫‮‪⁪​‍​‮⁮‏‬⁯‬‫⁮⁮⁮⁭⁯​​⁮‭‮ = true;
	Label0:
		int num = -2110854876;
		while (true)
		{
			int num1 = num ^ -1306294056;
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
					u206b‭⁯​​⁬‫‍⁮‌‌‪⁫⁭‮⁪‫‪‬‭‫⁫⁭⁮‭‎⁮‭⁪‎⁪⁪⁭‏‬⁯⁮‮‌‪‮.u200c⁫⁮‮‌​⁫⁬‮​⁮‍‏‫⁫‏‪‫‏⁪‭‏⁫⁫‎‪‭‬‬‬⁪⁮‬‏‭‪‪⁫⁯⁪‮(this.u200b‫⁭⁪⁮⁭‪⁯⁪⁪‬⁫⁫⁮‬⁪‫‭⁮‮⁯‮​⁯‬​⁪⁫‌‫‬‮⁬‍‬‫‌‏‭‌‮);
					num = (int)(num2 * -546275731 ^ -524800690);
					continue;
				}
			}
		}
	}

	// ‮‮‭‮​⁯⁫‭‬‍⁭‪⁫‍‮‏‬‌⁫⁮‌‮‎⁮⁫⁪‎‮‮⁭‭‌⁬‬​‍‭‍⁮‭‮
	private bool u202e‮‭‮​⁯⁫‭‬‍⁭‪⁫‍‮‏‬‌⁫⁮‌‮‎⁮⁫⁪‎‮‮⁭‭‌⁬‬​‍‭‍⁮‭‮(Socket socket)
	{
		bool flag = false;
		uint num;
		bool flag1;
		int num1;
		try
		{
			if (u206b‭⁯​​⁬‫‍⁮‌‌‪⁫⁭‮⁪‫‪‬‭‫⁫⁭⁮‭‎⁮‭⁪‎⁪⁪⁭‏‬⁯⁮‮‌‪‮.u200d‫‫⁫‌‌⁯⁯⁭‭‏⁪⁯‏⁬‭​⁯⁫‬​⁪‪‪‪‎⁬‍‮⁬​⁯‫⁪‍‎⁫⁮⁫‭‮(socket, 1, SelectMode.SelectRead))
			{
				goto Label0;
			}
			flag1 = true;
		Label4:
			flag = flag1;
			num1 = 1502167592;
			goto Label1;
		}
		catch (SocketException socketException)
		{
		Label2:
			int num2 = 1976454257;
			while (true)
			{
				int num3 = num2 ^ 1182413010;
				num = (uint)num3;
				switch (num3 % 3)
				{
					case 0:
					{
						goto Label2;
					}
					case 1:
					{
						goto Label3;
					}
					case 2:
					{
						flag = false;
						num2 = (int)(num * -1213036964 ^ 880263359);
						continue;
					}
				}
			}
		Label3:
		}
		return flag;
	Label0:
		num1 = 1406974510;
	Label1:
		int num4 = num1 ^ 1182413010;
		num = (uint)num4;
		switch (num4 % 3)
		{
			case 0:
			{
				goto Label0;
			}
			case 1:
			{
				flag1 = u206b‭⁯​​⁬‫‍⁮‌‌‪⁫⁭‮⁪‫‪‬‭‫⁫⁭⁮‭‎⁮‭⁪‎⁪⁪⁭‏‬⁯⁮‮‌‪‮.u206a‭⁮‪⁬⁬‌⁫​‪⁪​‫‫⁮⁮‍‭⁬‮‎‬​‫‮‏⁫‫‌‏‭⁫‎‭⁮‪⁭‭‫‭‮(socket) != 0;
				goto Label4;
			}
			case 2:
			{
				return flag;
			}
			default:
			{
				return flag;
			}
		}
	}

	// ⁫‬⁬​‌⁭⁪⁯⁯​⁪⁭⁫⁪‌⁬⁬⁬⁪‍‮‍‏‪⁮‫‍‪‌‌⁬​‌‎⁬⁭‭‬‍⁮‮
	private void u206b‬⁬​‌⁭⁪⁯⁯​⁪⁭⁫⁪‌⁬⁬⁬⁪‍‮‍‏‪⁮‫‍‪‌‌⁬​‌‎⁬⁭‭‬‍⁮‮(u202b‫‬‮⁬⁪⁪⁫‪‎‏‬‌‎⁪‫‍⁪⁮⁭‫⁬‮‪‍⁪‭‪​⁬‎⁬⁬‪‌​⁯‫‮‌‮ _‫‫‬‮⁬⁪⁪⁫‪‎‏‬‌‎⁪‫‍⁪⁮⁭‫⁬‮‪‍⁪‭‪​⁬‎⁬⁬‪‌​⁯‫‮‌‮)
	{
		uint num;
		object obj = this.u200f⁯‭⁭‌⁯⁯​⁬⁮‎⁮⁪⁭⁬⁮⁭⁯‮‫⁪‬⁭⁮⁭‬⁫⁬‮‫⁫‎‮⁯⁯‏⁬‏⁮‫‮;
		bool flag = false;
		try
		{
			u206b‭⁯​​⁬‫‍⁮‌‌‪⁫⁭‮⁪‫‪‬‭‫⁫⁭⁮‭‎⁮‭⁪‎⁪⁪⁭‏‬⁯⁮‮‌‪‮.u206f‍‬⁯‍⁪‎‮‭‫⁭‬‪⁭‭⁯⁮‮‫‮⁭‪‭‪⁬‬⁬‏⁮‪⁫‎‬​​⁭⁫‏‮⁪‮(obj, ref flag);
		Label0:
			int num1 = 621935292;
			while (true)
			{
				int num2 = num1 ^ 1397926545;
				num = (uint)num2;
				switch (num2 % 3)
				{
					case 0:
					{
						goto Label0;
					}
					case 1:
					{
						this.u206c‬⁮‭⁫⁮‮‪⁬​⁯‬⁭‎‮⁫‏‫‮⁪⁬⁮⁫⁯‍‪⁪⁬‌⁫⁭‬⁫⁪‫⁮⁯⁬⁯‌‮.Add(_‫‫‬‮⁬⁪⁪⁫‪‎‏‬‌‎⁪‫‍⁪⁮⁭‫⁬‮‪‍⁪‭‪​⁬‎⁬⁬‪‌​⁯‫‮‌‮);
						num1 = (int)(num * 591863390 ^ -1109962652);
						continue;
					}
					case 2:
					{
						goto Label1;
					}
				}
			}
		Label1:
		}
		finally
		{
			if (!flag)
			{
				goto Label2;
			}
		Label3:
			int num3 = 54333722;
			while (true)
			{
				int num4 = num3 ^ 1397926545;
				num = (uint)num4;
				switch (num4 % 3)
				{
					case 0:
					{
						goto Label2;
					}
					case 1:
					{
						u206b‭⁯​​⁬‫‍⁮‌‌‪⁫⁭‮⁪‫‪‬‭‫⁫⁭⁮‭‎⁮‭⁪‎⁪⁪⁭‏‬⁯⁮‮‌‪‮.u200f⁮‪⁬⁮‏‮‍‫​‍​​​⁯‫‭‬⁭‪‎‍‭‬⁭⁯⁪⁪‍‌⁫​‮‍⁭⁪‭⁯‭‫‮(obj);
						num3 = (int)(num * -1854477975 ^ -415652169);
						continue;
					}
					case 2:
					{
						goto Label3;
					}
				}
			}
		Label2:
		}
		this.u200c‫‫⁫⁯‎⁪​‭⁭‍⁬‎‎​‍‭‎‪‫‮‭‫‮‏‪⁪​‍⁮​‮‍‫⁮⁬‌‏‪‌‮(_‫‫‬‮⁬⁪⁪⁫‪‎‏‬‌‎⁪‫‍⁪⁮⁭‫⁬‮‪‍⁪‭‪​⁬‎⁬⁬‪‌​⁯‫‮‌‮, this.u206a‌‭‪‍‪⁯⁯⁫‭​‪⁭⁮‫⁮⁬⁮‌⁭⁭‎‎⁭‌‏⁭⁯⁫‎‎⁯‍‫⁮⁯‮‎‬⁬‮.u200c​‎⁫⁪‬‌⁯‍‮‫‫⁭⁪‫‍‭⁭⁪⁪‎‏‎‮‎⁬‍‎‍‮‍‬⁯‬⁭⁪‍‮‭⁭‮());
		try
		{
			u206b‭⁯​​⁬‫‍⁮‌‌‪⁫⁭‮⁪‫‪‬‭‫⁫⁭⁮‭‎⁮‭⁪‎⁪⁪⁭‏‬⁯⁮‮‌‪‮.u200f⁫‬⁪⁬‫⁭‭⁮‎⁬‌‬‍⁯‪‎‫‮⁫‍⁯⁪⁪⁮‭‮⁯‍‏‪⁮‬⁪‭⁯⁭‮⁮⁪‮(_‫‫‬‮⁬⁪⁪⁫‪‎‏‬‌‎⁪‫‍⁪⁮⁭‫⁬‮‪‍⁪‭‪​⁬‎⁬⁬‪‌​⁯‫‮‌‮.u206e⁭⁭‭⁪⁯‎⁭‮‍⁬‫‮‫‏⁫‌​⁭⁪‎⁭‬‍‭⁮‮‮‭⁬‭‬⁪‭‪‬‭⁫‏‮, _‫‫‬‮⁬⁪⁪⁫‪‎‏‬‌‎⁪‫‍⁪⁮⁭‫⁬‮‪‍⁪‭‪​⁬‎⁬⁬‪‌​⁯‫‮‌‮.u206f‮‭‍‭⁮‪‬‏‫‪⁭⁪⁪⁬‮‭‍⁯⁫⁫⁬‍​‏⁫⁬‍​‪‫‎‍⁪⁬‭‮‬‌‫‮, 0, 256, SocketFlags.None, new AsyncCallback(this.u200c‬‌‪⁮‭‭⁪‪⁭‫‮‏‎‬‎‮⁯‬‎‫‍‌⁭‭‌​‌‪‬‎‮‬⁯​⁭⁫‏‪‪‮), _‫‫‬‮⁬⁪⁪⁫‪‎‏‬‌‎⁪‫‍⁪⁮⁭‫⁬‮‪‍⁪‭‪​⁬‎⁬⁬‪‌​⁯‫‮‌‮);
		}
		catch (Exception exception)
		{
			this.u202e⁫‍‪⁭‌⁫⁫‭⁪‎‏‫​⁮​⁫‪‪‭‎‏⁪​‮‬⁮⁬‭⁯‪‍‭‮‪‬‌‌‮‭‮(_‫‫‬‮⁬⁪⁪⁫‪‎‏‬‌‎⁪‫‍⁪⁮⁭‫⁬‮‪‍⁪‭‪​⁬‎⁬⁬‪‌​⁯‫‮‌‮);
		}
	}

	// ‮⁫‍‪⁭‌⁫⁫‭⁪‎‏‫​⁮​⁫‪‪‭‎‏⁪​‮‬⁮⁬‭⁯‪‍‭‮‪‬‌‌‮‭‮
	private void u202e⁫‍‪⁭‌⁫⁫‭⁪‎‏‫​⁮​⁫‪‪‭‎‏⁪​‮‬⁮⁬‭⁯‪‍‭‮‪‬‌‌‮‭‮(u202b‫‬‮⁬⁪⁪⁫‪‎‏‬‌‎⁪‫‍⁪⁮⁭‫⁬‮‪‍⁪‭‪​⁬‎⁬⁬‪‌​⁯‫‮‌‮ _‫‫‬‮⁬⁪⁪⁫‪‎‏‬‌‎⁪‫‍⁪⁮⁭‫⁬‮‪‍⁪‭‪​⁬‎⁬⁬‪‌​⁯‫‮‌‮)
	{
		uint num;
		object obj = this.u200f⁯‭⁭‌⁯⁯​⁬⁮‎⁮⁪⁭⁬⁮⁭⁯‮‫⁪‬⁭⁮⁭‬⁫⁬‮‫⁫‎‮⁯⁯‏⁬‏⁮‫‮;
		bool flag = false;
		try
		{
			u206b‭⁯​​⁬‫‍⁮‌‌‪⁫⁭‮⁪‫‪‬‭‫⁫⁭⁮‭‎⁮‭⁪‎⁪⁪⁭‏‬⁯⁮‮‌‪‮.u206f‍‬⁯‍⁪‎‮‭‫⁭‬‪⁭‭⁯⁮‮‫‮⁭‪‭‪⁬‬⁬‏⁮‪⁫‎‬​​⁭⁫‏‮⁪‮(obj, ref flag);
			this.u206c‬⁮‭⁫⁮‮‪⁬​⁯‬⁭‎‮⁫‏‫‮⁪⁬⁮⁫⁯‍‪⁪⁬‌⁫⁭‬⁫⁪‫⁮⁯⁬⁯‌‮.Remove(_‫‫‬‮⁬⁪⁪⁫‪‎‏‬‌‎⁪‫‍⁪⁮⁭‫⁬‮‪‍⁪‭‪​⁬‎⁬⁬‪‌​⁯‫‮‌‮);
		}
		finally
		{
			if (!flag)
			{
				goto Label0;
			}
		Label1:
			int num1 = 674810123;
			while (true)
			{
				int num2 = num1 ^ 1754872916;
				num = (uint)num2;
				switch (num2 % 3)
				{
					case 0:
					{
						goto Label0;
					}
					case 1:
					{
						u206b‭⁯​​⁬‫‍⁮‌‌‪⁫⁭‮⁪‫‪‬‭‫⁫⁭⁮‭‎⁮‭⁪‎⁪⁪⁭‏‬⁯⁮‮‌‪‮.u200f⁮‪⁬⁮‏‮‍‫​‍​​​⁯‫‭‬⁭‪‎‍‭‬⁭⁯⁪⁪‍‌⁫​‮‍⁭⁪‭⁯‭‫‮(obj);
						num1 = (int)(num * 1507799602 ^ 329199548);
						continue;
					}
					case 2:
					{
						goto Label1;
					}
				}
			}
		Label0:
		}
		try
		{
			u206b‭⁯​​⁬‫‍⁮‌‌‪⁫⁭‮⁪‫‪‬‭‫⁫⁭⁮‭‎⁮‭⁪‎⁪⁪⁭‏‬⁯⁮‮‌‪‮.u200c⁪⁮‬‬‌​⁭‏‌⁪‪‮⁫‮‌⁭​‬⁪‌⁬⁪⁬⁭‭‏⁫​‌‭‪⁪⁯‭​⁪‪⁪‮‮(_‫‫‬‮⁬⁪⁪⁫‪‎‏‬‌‎⁪‫‍⁪⁮⁭‫⁬‮‪‍⁪‭‪​⁬‎⁬⁬‪‌​⁯‫‮‌‮.u206e⁭⁭‭⁪⁯‎⁭‮‍⁬‫‮‫‏⁫‌​⁭⁪‎⁭‬‍‭⁮‮‮‭⁬‭‬⁪‭‪‬‭⁫‏‮, SocketShutdown.Both);
		Label2:
			int num3 = 916511096;
			while (true)
			{
				int num4 = num3 ^ 1754872916;
				num = (uint)num4;
				switch (num4 % 3)
				{
					case 0:
					{
						goto Label2;
					}
					case 1:
					{
						u206b‭⁯​​⁬‫‍⁮‌‌‪⁫⁭‮⁪‫‪‬‭‫⁫⁭⁮‭‎⁮‭⁪‎⁪⁪⁭‏‬⁯⁮‮‌‪‮.u206f‮‎‫‬‏‪​‫⁪‌‪‪‍​‭‌‎⁯‍‭‭‏‬⁬⁯⁮⁭⁭⁯‮⁯‫‍‭⁭​‭⁮‬‮(_‫‫‬‮⁬⁪⁪⁫‪‎‏‬‌‎⁪‫‍⁪⁮⁭‫⁬‮‪‍⁪‭‪​⁬‎⁬⁬‪‌​⁯‫‮‌‮.u206e⁭⁭‭⁪⁯‎⁭‮‍⁬‫‮‫‏⁫‌​⁭⁪‎⁭‬‍‭⁮‮‮‭⁬‭‬⁪‭‪‬‭⁫‏‮);
						num3 = (int)(num * -1337091912 ^ 1593774103);
						continue;
					}
					case 2:
					{
						goto Label3;
					}
				}
			}
		Label3:
		}
		catch (SocketException socketException)
		{
		}
		catch (ObjectDisposedException objectDisposedException)
		{
		}
	}

	// ‍‫⁯⁬⁪‌⁬‮‭‮​‮‎​‌‫‪⁯⁪‫⁮⁬⁮‭‍‎⁯‪‍⁭⁮‎‬‏‭⁬‭‪‍⁫‮
	private void u200d‫⁯⁬⁪‌⁬‮‭‮​‮‎​‌‫‪⁯⁪‫⁮⁬⁮‭‍‎⁯‪‍⁭⁮‎‬‏‭⁬‭‪‍⁫‮(IAsyncResult asyncResult)
	{
		int num;
		u206b‭⁯​​⁬‫‍⁮‌‌‪⁫⁭‮⁪‫‪‬‭‫⁫⁭⁮‭‎⁮‭⁪‎⁪⁪⁭‏‬⁯⁮‮‌‪‮.u200c⁫⁮‮‌​⁫⁬‮​⁮‍‏‫⁫‏‪‫‏⁪‭‏⁫⁫‎‪‭‬‬‬⁪⁮‬‏‭‪‪⁫⁯⁪‮(this.u200b‫⁭⁪⁮⁭‪⁯⁪⁪‬⁫⁫⁮‬⁪‫‭⁮‮⁯‮​⁯‬​⁪⁫‌‫‬‮⁬‍‬‫‌‏‭‌‮);
		try
		{
			u202b‫‬‮⁬⁪⁪⁫‪‎‏‬‌‎⁪‫‍⁪⁮⁭‫⁬‮‪‍⁪‭‪​⁬‎⁬⁬‪‌​⁯‫‮‌‮ _‫‫‬‮⁬⁪⁪⁫‪‎‏‬‌‎⁪‫‍⁪⁮⁭‫⁬‮‪‍⁪‭‪​⁬‎⁬⁬‪‌​⁯‫‮‌‮ = new u202b‫‬‮⁬⁪⁪⁫‪‎‏‬‌‎⁪‫‍⁪⁮⁭‫⁬‮‪‍⁪‭‪​⁬‎⁬⁬‪‌​⁯‫‮‌‮(u206b‭⁯​​⁬‫‍⁮‌‌‪⁫⁭‮⁪‫‪‬‭‫⁫⁭⁮‭‎⁮‭⁪‎⁪⁪⁭‏‬⁯⁮‮‌‪‮.u200b⁮‪‎⁫‬‎⁬‫​⁪‏⁯⁫⁭⁭‪‬‮‫‌‭⁪‏⁯‪‬⁬‭‭​‬‮‭‬‎⁬‪‪‏‮((Socket)u206b‭⁯​​⁬‫‍⁮‌‌‪⁫⁭‮⁪‫‪‬‭‫⁫⁭⁮‭‎⁮‭⁪‎⁪⁪⁭‏‬⁯⁮‮‌‪‮.u206a⁯⁪‫‪‎‮‎⁯‏⁯⁯⁯⁯‎⁪​⁪‏‌‮‎‍‬⁮‍‍‏‪‎‎‍‌⁬⁬‏‍⁯‮‪‮(asyncResult), asyncResult));
			if (this.u206c‬⁮‭⁫⁮‮‪⁬​⁯‬⁭‎‮⁫‏‫‮⁪⁬⁮⁫⁯‍‪⁪⁬‌⁫⁭‬⁫⁪‫⁮⁯⁬⁯‌‮.Count >= 4)
			{
				goto Label0;
			}
		Label1:
			num = 1547657586;
		Label4:
			while (true)
			{
				int num1 = num ^ 235685513;
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
						num = (int)(num2 * -1083247713 ^ 1710939972);
						continue;
					}
					case 3:
					{
						this.u206b‬⁬​‌⁭⁪⁯⁯​⁪⁭⁫⁪‌⁬⁬⁬⁪‍‮‍‏‪⁮‫‍‪‌‌⁬​‌‎⁬⁭‭‬‍⁮‮(_‫‫‬‮⁬⁪⁪⁫‪‎‏‬‌‎⁪‫‍⁪⁮⁭‫⁬‮‪‍⁪‭‪​⁬‎⁬⁬‪‌​⁯‫‮‌‮);
						num = (int)(num2 * -1538043275 ^ -101896835);
						continue;
					}
					case 4:
					{
						return;
					}
					default:
					{
						return;
					}
				}
			}
		Label0:
			this.u202e⁫‍‪⁭‌⁫⁫‭⁪‎‏‫​⁮​⁫‪‪‭‎‏⁪​‮‬⁮⁬‭⁯‪‍‭‮‪‬‌‌‮‭‮(_‫‫‬‮⁬⁪⁪⁫‪‎‏‬‌‎⁪‫‍⁪⁮⁭‫⁬‮‪‍⁪‭‪​⁬‎⁬⁬‪‌​⁯‫‮‌‮);
			num = 1560993241;
			goto Label4;
		}
		catch (ObjectDisposedException objectDisposedException)
		{
		}
		catch (SocketException socketException)
		{
		}
		return;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	// ‌‬‌‪⁮‭‭⁪‪⁭‫‮‏‎‬‎‮⁯‬‎‫‍‌⁭‭‌​‌‪‬‎‮‬⁯​⁭⁫‏‪‪‮
	private void u200c‬‌‪⁮‭‭⁪‪⁭‫‮‏‎‬‎‮⁯‬‎‫‍‌⁭‭‌​‌‪‬‎‮‬⁯​⁭⁫‏‪‪‮(IAsyncResult )
	{
		// 
		// Current member / type: System.Void ⁫‭⁯​​⁬‫‍⁮‌‌‪⁫⁭‮⁪‫‪‬‭‫⁫⁭⁮‭‎⁮‭⁪‎⁪⁪⁭‏‬⁯⁮‮‌‪‮::‌‬‌‪⁮‭‭⁪‪⁭‫‮‏‎‬‎‮⁯‬‎‫‍‌⁭‭‌​‌‪‬‎‮‬⁯​⁭⁫‏‪‪‮(System.IAsyncResult)
		// File path: C:\SDRSharp\Plugins\Tetra\SDRSharp.Tetra.dll
		// 
		// Product version: 0.0.0.0
		// Exception in: System.Void ‌‬‌‪⁮‭‭⁪‪⁭‫‮‏‎‬‎‮⁯‬‎‫‍‌⁭‭‌​‌‪‬‎‮‬⁯​⁭⁫‏‪‪‮(System.IAsyncResult)
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

	// ‌‫‫⁫⁯‎⁪​‭⁭‍⁬‎‎​‍‭‎‪‫‮‭‫‮‏‪⁪​‍⁮​‮‍‫⁮⁬‌‏‪‌‮
	private void u200c‫‫⁫⁯‎⁪​‭⁭‍⁬‎‎​‍‭‎‪‫‮‭‫‮‏‪⁪​‍⁮​‮‍‫⁮⁬‌‏‪‌‮(u202b‫‬‮⁬⁪⁪⁫‪‎‏‬‌‎⁪‫‍⁪⁮⁭‫⁬‮‪‍⁪‭‪​⁬‎⁬⁬‪‌​⁯‫‮‌‮ _‫‫‬‮⁬⁪⁪⁫‪‎‏‬‌‎⁪‫‍⁪⁮⁭‫⁬‮‪‍⁪‭‪​⁬‎⁬⁬‪‌​⁯‫‮‌‮, string str)
	{
		byte[] numArray;
		IAsyncResult asyncResult;
		Exception exception;
		if (str != null)
		{
			numArray = u206b‭⁯​​⁬‫‍⁮‌‌‪⁫⁭‮⁪‫‪‬‭‫⁫⁭⁮‭‎⁮‭⁪‎⁪⁪⁭‏‬⁯⁮‮‌‪‮.u202d‏‏⁬‮‬⁮⁯⁭⁮​‌‌⁮‮‌‍‍⁯‌‍⁬⁪​⁬‍⁪‫⁫‏⁯‏‎‬‬⁬‌‮⁫‎‮(u206b‭⁯​​⁬‫‍⁮‌‌‪⁫⁭‮⁪‫‪‬‭‫⁫⁭⁮‭‎⁮‭⁪‎⁪⁪⁭‏‬⁯⁮‮‌‪‮.u206f‫⁮⁭⁬‎​‮‪‪‮‏‫‌‌‏‫⁮⁯‌‫‪‌⁪‬‪‮‌‫‌⁫‍‪‮‍⁬⁪⁪⁬⁯‮(), str);
			try
			{
				asyncResult = u206b‭⁯​​⁬‫‍⁮‌‌‪⁫⁭‮⁪‫‪‬‭‫⁫⁭⁮‭‎⁮‭⁪‎⁪⁪⁭‏‬⁯⁮‮‌‪‮.u206a⁪⁫‬⁭​⁮​⁮‬‍​‍‏⁭‎‬‎​⁪⁫‍⁭‎‏‮‌⁪‫‏⁮‫‏⁭‍⁫‌‭‍‎‮(_‫‫‬‮⁬⁪⁪⁫‪‎‏‬‌‎⁪‫‍⁪⁮⁭‫⁬‮‪‍⁪‭‪​⁬‎⁬⁬‪‌​⁯‫‮‌‮.u206e⁭⁭‭⁪⁯‎⁭‮‍⁬‫‮‫‏⁫‌​⁭⁪‎⁭‬‍‭⁮‮‮‭⁬‭‬⁪‭‪‬‭⁫‏‮, numArray, 0, (int)numArray.Length, SocketFlags.None, new AsyncCallback(this.u202e​‌‪‫⁭‫‪‮⁪‌‭‌⁬‭‬⁮‮⁬‍‍‭‏⁯⁬‮⁫‮‌‎‮⁫‭‮‭⁫⁫⁪⁮‎‮), _‫‫‬‮⁬⁪⁪⁫‪‎‏‬‌‎⁪‫‍⁪⁮⁭‫⁬‮‪‍⁪‭‪​⁬‎⁬⁬‪‌​⁯‫‮‌‮);
			}
			catch (Exception exception1)
			{
				exception = exception1;
				this.u202e⁫‍‪⁭‌⁫⁫‭⁪‎‏‫​⁮​⁫‪‪‭‎‏⁪​‮‬⁮⁬‭⁯‪‍‭‮‪‬‌‌‮‭‮(_‫‫‬‮⁬⁪⁪⁫‪‎‏‬‌‎⁪‫‍⁪⁮⁭‫⁬‮‪‍⁪‭‪​⁬‎⁬⁬‪‌​⁯‫‮‌‮);
			}
			return;
		}
	Label1:
		int num = -1906270170 ^ -418000144;
		uint num1 = (uint)num;
		switch (num % 3)
		{
			case 1:
			{
				return;
			}
			case 2:
			{
				goto Label1;
			}
		}
		numArray = u206b‭⁯​​⁬‫‍⁮‌‌‪⁫⁭‮⁪‫‪‬‭‫⁫⁭⁮‭‎⁮‭⁪‎⁪⁪⁭‏‬⁯⁮‮‌‪‮.u202d‏‏⁬‮‬⁮⁯⁭⁮​‌‌⁮‮‌‍‍⁯‌‍⁬⁪​⁬‍⁪‫⁫‏⁯‏‎‬‬⁬‌‮⁫‎‮(u206b‭⁯​​⁬‫‍⁮‌‌‪⁫⁭‮⁪‫‪‬‭‫⁫⁭⁮‭‎⁮‭⁪‎⁪⁪⁭‏‬⁯⁮‮‌‪‮.u206f‫⁮⁭⁬‎​‮‪‪‮‏‫‌‌‏‫⁮⁯‌‫‪‌⁪‬‪‮‌‫‌⁫‍‪‮‍⁬⁪⁪⁬⁯‮(), str);
		try
		{
			asyncResult = u206b‭⁯​​⁬‫‍⁮‌‌‪⁫⁭‮⁪‫‪‬‭‫⁫⁭⁮‭‎⁮‭⁪‎⁪⁪⁭‏‬⁯⁮‮‌‪‮.u206a⁪⁫‬⁭​⁮​⁮‬‍​‍‏⁭‎‬‎​⁪⁫‍⁭‎‏‮‌⁪‫‏⁮‫‏⁭‍⁫‌‭‍‎‮(_‫‫‬‮⁬⁪⁪⁫‪‎‏‬‌‎⁪‫‍⁪⁮⁭‫⁬‮‪‍⁪‭‪​⁬‎⁬⁬‪‌​⁯‫‮‌‮.u206e⁭⁭‭⁪⁯‎⁭‮‍⁬‫‮‫‏⁫‌​⁭⁪‎⁭‬‍‭⁮‮‮‭⁬‭‬⁪‭‪‬‭⁫‏‮, numArray, 0, (int)numArray.Length, SocketFlags.None, new AsyncCallback(this.u202e​‌‪‫⁭‫‪‮⁪‌‭‌⁬‭‬⁮‮⁬‍‍‭‏⁯⁬‮⁫‮‌‎‮⁫‭‮‭⁫⁫⁪⁮‎‮), _‫‫‬‮⁬⁪⁪⁫‪‎‏‬‌‎⁪‫‍⁪⁮⁭‫⁬‮‪‍⁪‭‪​⁬‎⁬⁬‪‌​⁯‫‮‌‮);
		}
		catch (Exception exception1)
		{
			exception = exception1;
			this.u202e⁫‍‪⁭‌⁫⁫‭⁪‎‏‫​⁮​⁫‪‪‭‎‏⁪​‮‬⁮⁬‭⁯‪‍‭‮‪‬‌‌‮‭‮(_‫‫‬‮⁬⁪⁪⁫‪‎‏‬‌‎⁪‫‍⁪⁮⁭‫⁬‮‪‍⁪‭‪​⁬‎⁬⁬‪‌​⁯‫‮‌‮);
		}
	}

	// ‮​‌‪‫⁭‫‪‮⁪‌‭‌⁬‭‬⁮‮⁬‍‍‭‏⁯⁬‮⁫‮‌‎‮⁫‭‮‭⁫⁫⁪⁮‎‮
	private void u202e​‌‪‫⁭‫‪‮⁪‌‭‌⁬‭‬⁮‮⁬‍‍‭‏⁯⁬‮⁫‮‌‎‮⁫‭‮‭⁫⁫⁪⁮‎‮(IAsyncResult asyncResult)
	{
		u202b‫‬‮⁬⁪⁪⁫‪‎‏‬‌‎⁪‫‍⁪⁮⁭‫⁬‮‪‍⁪‭‪​⁬‎⁬⁬‪‌​⁯‫‮‌‮ _‫‫‬‮⁬⁪⁪⁫‪‎‏‬‌‎⁪‫‍⁪⁮⁭‫⁬‮‪‍⁪‭‪​⁬‎⁬⁬‪‌​⁯‫‮‌‮ = (u202b‫‬‮⁬⁪⁪⁫‪‎‏‬‌‎⁪‫‍⁪⁮⁭‫⁬‮‪‍⁪‭‪​⁬‎⁬⁬‪‌​⁯‫‮‌‮)u206b‭⁯​​⁬‫‍⁮‌‌‪⁫⁭‮⁪‫‪‬‭‫⁫⁭⁮‭‎⁮‭⁪‎⁪⁪⁭‏‬⁯⁮‮‌‪‮.u206a⁯⁪‫‪‎‮‎⁯‏⁯⁯⁯⁯‎⁪​⁪‏‌‮‎‍‬⁮‍‍‏‪‎‎‍‌⁬⁬‏‍⁯‮‪‮(asyncResult);
		try
		{
			u206b‭⁯​​⁬‫‍⁮‌‌‪⁫⁭‮⁪‫‪‬‭‫⁫⁭⁮‭‎⁮‭⁪‎⁪⁪⁭‏‬⁯⁮‮‌‪‮.u200d⁯‪⁯‭‫‫⁭⁬‭‪‮‪‪​⁪‪⁪⁭‪‭‏⁬⁮⁫‎⁪⁪‍‎‪⁭⁭⁫‬⁪⁬‭⁪‍‮(_‫‫‬‮⁬⁪⁪⁫‪‎‏‬‌‎⁪‫‍⁪⁮⁭‫⁬‮‪‍⁪‭‪​⁬‎⁬⁬‪‌​⁯‫‮‌‮.u206e⁭⁭‭⁪⁯‎⁭‮‍⁬‫‮‫‏⁫‌​⁭⁪‎⁭‬‍‭⁮‮‮‭⁬‭‬⁪‭‪‬‭⁫‏‮, asyncResult);
		}
		catch (Exception exception)
		{
		Label1:
			int num = -2098978539;
			while (true)
			{
				int num1 = num ^ -889229211;
				uint num2 = (uint)num1;
				switch (num1 % 3)
				{
					case 0:
					{
						goto Label0;
					}
					case 1:
					{
						this.u202e⁫‍‪⁭‌⁫⁫‭⁪‎‏‫​⁮​⁫‪‪‭‎‏⁪​‮‬⁮⁬‭⁯‪‍‭‮‪‬‌‌‮‭‮(_‫‫‬‮⁬⁪⁪⁫‪‎‏‬‌‎⁪‫‍⁪⁮⁭‫⁬‮‪‍⁪‭‪​⁬‎⁬⁬‪‌​⁯‫‮‌‮);
						num = (int)(num2 * -1085644124 ^ 2132788338);
						continue;
					}
					case 2:
					{
						goto Label1;
					}
				}
			}
		Label0:
		}
	}

	// ‭​⁫‍⁮‏⁬⁬‏‎‬‍‬​‍‌⁬‫‫‮⁪‬‭‌⁮‮⁯⁮‎⁮‎‌⁭‬‫⁬‫‏⁫‮
	private void u202d​⁫‍⁮‏⁬⁬‏‎‬‍‬​‍‌⁬‫‫‮⁪‬‭‌⁮‮⁯⁮‎⁮‎‌⁭‬‫⁬‫‏⁫‮(object , ElapsedEventArgs )
	{
		// 
		// Current member / type: System.Void ⁫‭⁯​​⁬‫‍⁮‌‌‪⁫⁭‮⁪‫‪‬‭‫⁫⁭⁮‭‎⁮‭⁪‎⁪⁪⁭‏‬⁯⁮‮‌‪‮::‭​⁫‍⁮‏⁬⁬‏‎‬‍‬​‍‌⁬‫‫‮⁪‬‭‌⁮‮⁯⁮‎⁮‎‌⁭‬‫⁬‫‏⁫‮(System.Object,System.Timers.ElapsedEventArgs)
		// File path: C:\SDRSharp\Plugins\Tetra\SDRSharp.Tetra.dll
		// 
		// Product version: 0.0.0.0
		// Exception in: System.Void ‭​⁫‍⁮‏⁬⁬‏‎‬‍‬​‍‌⁬‫‫‮⁪‬‭‌⁮‮⁯⁮‎⁮‎‌⁭‬‫⁬‫‏⁫‮(System.Object,System.Timers.ElapsedEventArgs)
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

	// ⁬‮‌⁭​⁫‫​‪⁮‌‌‌‪​‮⁮‍‎‌​‏‫⁭‍⁭‭‍‎‎⁯‎‪‬‮‪‍‭‬‪‮
	protected virtual void u206c‮‌⁭​⁫‫​‪⁮‌‌‌‪​‮⁮‍‎‌​‏‫⁭‍⁭‭‍‎‎⁯‎‪‬‮‪‍‭‬‪‮()
	{
		int num;
		EventHandler eventHandler = this.u202e⁬‫‌⁯‬‪​‍⁫‏‮‍⁪‏‍⁪‍‮⁫⁫‭‮⁯‪‫⁪‭‪⁫‮‬​‎‎‪‮‍⁫‌‮;
	Label1:
		int num1 = 1199291548;
		while (true)
		{
			int num2 = num1 ^ 1756889785;
			uint num3 = (uint)num2;
			switch (num2 % 4)
			{
				case 0:
				{
					return;
				}
				case 1:
				{
					num = (eventHandler != null ? -2117098646 : -468543136);
					num1 = (int)(num ^ num3 * 377692705);
					continue;
				}
				case 2:
				{
					eventHandler(this, EventArgs.Empty);
					num1 = (int)(num3 * 468379073 ^ 1782496819);
					continue;
				}
				case 3:
				{
					goto Label1;
				}
			}
		}
	}

	// ​​‎‮⁬⁮‌⁫⁮⁮‮⁮‬‎‮‎‮‬‬‫‌⁯‎⁪​⁯‎‌⁫‬‬‮‫⁯⁯‏⁫‫⁫‏‮
	// privatescope
	internal static Delegate u200b​‎‮⁬⁮‌⁫⁮⁮‮⁮‬‎‮‎‮‬‬‫‌⁯‎⁪​⁯‎‌⁫‬‬‮‫⁯⁯‏⁫‫⁫‏‮(Delegate @delegate, Delegate @delegate)
	{
		return Delegate.Combine(@delegate, @delegate);
	}

	// ‬​⁭⁫‌‫​‬‭⁮⁫⁯⁮⁬‏⁭​‍‏‎⁭⁪‮⁫⁮⁬‏‭‎‫‪‌‍⁮‮⁬⁬‪‏‫‮
	// privatescope
	internal static Delegate u202c​⁭⁫‌‫​‬‭⁮⁫⁯⁮⁬‏⁭​‍‏‎⁭⁪‮⁫⁮⁬‏‭‎‫‪‌‍⁮‮⁬⁬‪‏‫‮(Delegate @delegate, Delegate @delegate)
	{
		return Delegate.Remove(@delegate, @delegate);
	}

	// ⁯⁫⁬⁬⁮‬‎‌⁮‫⁫⁫⁬‌⁬⁯‌⁪‎‌‏‬⁬‪⁯⁪‍‎‮⁫‬‭‎‍⁬⁪‭​⁫‭‮
	// privatescope
	internal static ManualResetEvent u206f⁫⁬⁬⁮‬‎‌⁮‫⁫⁫⁬‌⁬⁯‌⁪‎‌‏‬⁬‪⁯⁪‍‎‮⁫‬‭‎‍⁬⁪‭​⁫‭‮(bool flag)
	{
		return new ManualResetEvent(flag);
	}

	// ⁪‌‪‏‏‪⁫‎⁯‎⁬⁪⁯‎‏‫‫⁪‮⁬‭‎‫‎⁭⁪‭‪⁮‍⁯‮‎⁫‏⁬⁭​‮‪‮
	// privatescope
	internal static object u206a‌‪‏‏‪⁫‎⁯‎⁬⁪⁯‎‏‫‫⁪‮⁬‭‎‫‎⁭⁪‭‪⁮‍⁯‮‎⁫‏⁬⁭​‮‪‮()
	{
		return new object();
	}

	// ⁯‫⁮⁭⁬‎​‮‪‪‮‏‫‌‌‏‫⁮⁯‌‫‪‌⁪‬‪‮‌‫‌⁫‍‪‮‍⁬⁪⁪⁬⁯‮
	// privatescope
	internal static Encoding u206f‫⁮⁭⁬‎​‮‪‪‮‏‫‌‌‏‫⁮⁯‌‫‪‌⁪‬‪‮‌‫‌⁫‍‪‮‍⁬⁪⁪⁬⁯‮()
	{
		return Encoding.ASCII;
	}

	// ‭‏‏⁬‮‬⁮⁯⁭⁮​‌‌⁮‮‌‍‍⁯‌‍⁬⁪​⁬‍⁪‫⁫‏⁯‏‎‬‬⁬‌‮⁫‎‮
	// privatescope
	internal static byte[] u202d‏‏⁬‮‬⁮⁯⁭⁮​‌‌⁮‮‌‍‍⁯‌‍⁬⁪​⁬‍⁪‫⁫‏⁯‏‎‬‬⁬‌‮⁫‎‮(Encoding encoding, string str)
	{
		return encoding.GetBytes(str);
	}

	// ‮⁬‎⁭⁮‮‍​‌⁯‭⁭‍‬‍⁪⁯‬⁮‮‍​​⁪‏‌‫⁮‎‮⁭‏⁫‪⁫‌‏⁯‬⁬‮
	// privatescope
	internal static IPEndPoint u202e⁬‎⁭⁮‮‍​‌⁯‭⁭‍‬‍⁪⁯‬⁮‮‍​​⁪‏‌‫⁮‎‮⁭‏⁫‪⁫‌‏⁯‬⁬‮(IPAddress pAddress, int num)
	{
		return new IPEndPoint(pAddress, num);
	}

	// ‫‌⁪​⁫⁬‫⁯‬‌⁪‍⁬⁯⁫⁯​⁯‍‮⁯‌‫⁯‬‮‏⁫‏⁯⁫⁪‬⁭‭‍⁫‪‍‮‮
	// privatescope
	internal static Socket u202b‌⁪​⁫⁬‫⁯‬‌⁪‍⁬⁯⁫⁯​⁯‍‮⁯‌‫⁯‬‮‏⁫‏⁯⁫⁪‬⁭‭‍⁫‪‍‮‮(AddressFamily addressFamily, SocketType socketType, ProtocolType protocolType)
	{
		return new Socket(addressFamily, socketType, protocolType);
	}

	// ‫⁮⁪‫‮‫⁮​⁫‫‫‌‮‎⁯⁯‎‎‍‍‮‪⁭⁪‫​‌‌‮‬⁭‍⁫‮‍⁭‏‎⁯⁯‮
	// privatescope
	internal static System.Timers.Timer u202b⁮⁪‫‮‫⁮​⁫‫‫‌‮‎⁯⁯‎‎‍‍‮‪⁭⁪‫​‌‌‮‬⁭‍⁫‮‍⁭‏‎⁯⁯‮()
	{
		return new System.Timers.Timer();
	}

	// ‌⁪⁯‌⁭⁯‌⁬‫‏⁪‏⁬‮⁬‮‮⁬‮‏⁯‎‌‍‏‬‫⁮‌‫‭⁮⁪‪‪‍‌⁫⁬‏‮
	// privatescope
	internal static void u200c⁪⁯‌⁭⁯‌⁬‫‏⁪‏⁬‮⁬‮‮⁬‮‏⁯‎‌‍‏‬‫⁮‌‫‭⁮⁪‪‪‍‌⁫⁬‏‮(System.Timers.Timer timer, ElapsedEventHandler elapsedEventHandler)
	{
		timer.Elapsed += elapsedEventHandler;
	}

	// ‏‏⁯‮‭⁯‪‏‌⁮‍⁪‏‭‍⁫⁭⁫‌‬⁫‮‮‮⁮‪‬‬⁫⁬‍‌‪‌‬⁫⁮‬‭‫‮
	// privatescope
	internal static void u200f‏⁯‮‭⁯‪‏‌⁮‍⁪‏‭‍⁫⁭⁫‌‬⁫‮‮‮⁮‪‬‬⁫⁬‍‌‪‌‬⁫⁮‬‭‫‮(System.Timers.Timer timer, double num)
	{
		timer.Interval = num;
	}

	// ⁯‮‮‭‍⁫‏‌​⁬‎⁬‫‍⁬⁮​⁮‏‮⁭‮‫‎‬⁪⁬‪⁮⁫‏‭‫‭⁭‍‬⁪⁮‬‮
	// privatescope
	internal static void u206f‮‮‭‍⁫‏‌​⁬‎⁬‫‍⁬⁮​⁮‏‮⁭‮‫‎‬⁪⁬‪⁮⁫‏‭‫‭⁭‍‬⁪⁮‬‮(System.Timers.Timer timer, bool flag)
	{
		timer.Enabled = flag;
	}

	// ⁭‮‎‪‫⁭‌⁮⁯‎​⁪⁬‮⁫⁬‏‏‍⁭⁯⁪‬‮​​​‎⁫⁮⁯‬‌‭⁬‭⁮‬⁬⁮‮
	// privatescope
	internal static void u206d‮‎‪‫⁭‌⁮⁯‎​⁪⁬‮⁫⁬‏‏‍⁭⁯⁪‬‮​​​‎⁫⁮⁯‬‌‭⁬‭⁮‬⁬⁮‮(Socket socket, EndPoint endPoint)
	{
		socket.Bind(endPoint);
	}

	// ‬⁭⁭⁮⁯‍‪‎‮‭‏‫‮⁮⁫‮‏⁮⁬​⁬‫​‍‪‭‮⁯‎​‮‬⁭⁪⁯⁬‎‏⁬⁬‮
	// privatescope
	internal static void u202c⁭⁭⁮⁯‍‪‎‮‭‏‫‮⁮⁫‮‏⁮⁬​⁬‫​‍‪‭‮⁯‎​‮‬⁭⁪⁯⁬‎‏⁬⁬‮(Socket socket, int num)
	{
		socket.Listen(num);
	}

	// ​‭⁭‌‍‬​⁮‪⁭‮‎⁬‬‎‌​‌⁬‭‫⁬‬‌‮​‎‫‮‫‫‌‏‌‍‬⁪⁪‎‫‮
	// privatescope
	internal static bool u200b‭⁭‌‍‬​⁮‪⁭‮‎⁬‬‎‌​‌⁬‭‫⁬‬‌‮​‎‫‮‫‫‌‏‌‍‬⁪⁪‎‫‮(EventWaitHandle eventWaitHandle)
	{
		return eventWaitHandle.Reset();
	}

	// ‏⁬⁯‍‮⁪‭⁯⁫‎⁯⁮​‍⁮⁯‪‎‬⁬‪‮‪‬‭​⁯⁬⁮⁮​​‍‭‍⁯⁪‌⁯⁮‮
	// privatescope
	internal static IAsyncResult u200f⁬⁯‍‮⁪‭⁯⁫‎⁯⁮​‍⁮⁯‪‎‬⁬‪‮‪‬‭​⁯⁬⁮⁮​​‍‭‍⁯⁪‌⁯⁮‮(Socket socket, AsyncCallback asyncCallback, object obj)
	{
		return socket.BeginAccept(asyncCallback, obj);
	}

	// ‪⁮⁪​‏‏‏‮⁭⁮‎‮​‫‫‍‫⁯‭​‬‏‮⁮‫‮‏⁪⁭‮⁭⁯‭‫⁯⁬⁭‭⁭‭‮
	// privatescope
	internal static bool u202a⁮⁪​‏‏‏‮⁭⁮‎‮​‫‫‍‫⁯‭​‬‏‮⁮‫‮‏⁪⁭‮⁭⁯‭‫⁯⁬⁭‭⁭‭‮(WaitHandle waitHandle)
	{
		return waitHandle.WaitOne();
	}

	// ⁭⁮‪⁫‪​​‭‪‬‭⁫‮‎‏‌⁯⁭​‭‏‎‫‬⁮⁮‭⁭‌​⁯‭‭‫‪‮⁫⁫⁮⁬‮
	// privatescope
	internal static bool u206d⁮‪⁫‪​​‭‪‬‭⁫‮‎‏‌⁯⁭​‭‏‎‫‬⁮⁮‭⁭‌​⁯‭‭‫‪‮⁫⁫⁮⁬‮(Socket socket)
	{
		return socket.IsBound;
	}

	// ‌⁪⁮‬‬‌​⁭‏‌⁪‪‮⁫‮‌⁭​‬⁪‌⁬⁪⁬⁭‭‏⁫​‌‭‪⁪⁯‭​⁪‪⁪‮‮
	// privatescope
	internal static void u200c⁪⁮‬‬‌​⁭‏‌⁪‪‮⁫‮‌⁭​‬⁪‌⁬⁪⁬⁭‭‏⁫​‌‭‪⁪⁯‭​⁪‪⁪‮‮(Socket socket, SocketShutdown socketShutdown)
	{
		socket.Shutdown(socketShutdown);
	}

	// ‍‫‪‎⁯‭‪‎⁭⁭⁬‫⁫⁬⁪⁭‌‭‬‬​‭‏‮​‭‌‍⁫‎‫⁬‮‎⁯‏⁭​⁬‭‮
	// privatescope
	internal static string u200d‫‪‎⁯‭‪‎⁭⁭⁬‫⁫⁬⁪⁭‌‭‬‬​‭‏‮​‭‌‍⁫‎‫⁬‮‎⁯‏⁭​⁬‭‮(Exception exception)
	{
		return exception.Message;
	}

	// ‎‍⁮‍⁮⁯⁬‭⁯⁫⁮‎‫‬⁯‍⁯​‬‎⁭‪‮⁫‭‎⁮​⁮⁬‌‏⁪‎⁯‪‭⁭⁫⁭‮
	// privatescope
	internal static string u200e‍⁮‍⁮⁯⁬‭⁯⁫⁮‎‫‬⁯‍⁯​‬‎⁭‪‮⁫‭‎⁮​⁮⁬‌‏⁪‎⁯‪‭⁭⁫⁭‮(string str, string str)
	{
		return string.Concat(str, str);
	}

	// ‬‏⁭⁭‏‌⁬​⁬‏‏‬⁬‌‎‭⁯⁪‬‍⁪‌⁮​⁫‎⁬⁬‭⁫‭‏​‭‪‮​⁯⁬‍‮
	// privatescope
	internal static DialogResult u202c‏⁭⁭‏‌⁬​⁬‏‏‬⁬‌‎‭⁯⁪‬‍⁪‌⁮​⁫‎⁬⁬‭⁫‭‏​‭‪‮​⁯⁬‍‮(string str, string str, MessageBoxButtons messageBoxButton, MessageBoxIcon messageBoxIcon)
	{
		return MessageBox.Show(str, str, messageBoxButton, messageBoxIcon);
	}

	// ‪⁪⁭‭⁪‭⁮⁮⁬⁭‭‍⁯⁬⁯‮‎​‎‮‎‏⁫‮⁫‌‫‫‏​‫‌‏‪⁫⁬‬⁪⁪‮‮
	// privatescope
	internal static void u202a⁪⁭‭⁪‭⁮⁮⁬⁭‭‍⁯⁬⁯‮‎​‎‮‎‏⁫‮⁫‌‫‫‏​‫‌‏‪⁫⁬‬⁪⁪‮‮(System.Timers.Timer timer)
	{
		timer.Close();
	}

	// ⁯‮‎‫‬‏‪​‫⁪‌‪‪‍​‭‌‎⁯‍‭‭‏‬⁬⁯⁮⁭⁭⁯‮⁯‫‍‭⁭​‭⁮‬‮
	// privatescope
	internal static void u206f‮‎‫‬‏‪​‫⁪‌‪‪‍​‭‌‎⁯‍‭‭‏‬⁬⁯⁮⁭⁭⁯‮⁯‫‍‭⁭​‭⁮‬‮(Socket socket)
	{
		socket.Close();
	}

	// ‌⁫⁮‮‌​⁫⁬‮​⁮‍‏‫⁫‏‪‫‏⁪‭‏⁫⁫‎‪‭‬‬‬⁪⁮‬‏‭‪‪⁫⁯⁪‮
	// privatescope
	internal static bool u200c⁫⁮‮‌​⁫⁬‮​⁮‍‏‫⁫‏‪‫‏⁪‭‏⁫⁫‎‪‭‬‬‬⁪⁮‬‏‭‪‪⁫⁯⁪‮(EventWaitHandle eventWaitHandle)
	{
		return eventWaitHandle.Set();
	}

	// ‍‫‫⁫‌‌⁯⁯⁭‭‏⁪⁯‏⁬‭​⁯⁫‬​⁪‪‪‪‎⁬‍‮⁬​⁯‫⁪‍‎⁫⁮⁫‭‮
	// privatescope
	internal static bool u200d‫‫⁫‌‌⁯⁯⁭‭‏⁪⁯‏⁬‭​⁯⁫‬​⁪‪‪‪‎⁬‍‮⁬​⁯‫⁪‍‎⁫⁮⁫‭‮(Socket socket, int num, SelectMode selectMode)
	{
		return socket.Poll(num, selectMode);
	}

	// ⁪‭⁮‪⁬⁬‌⁫​‪⁪​‫‫⁮⁮‍‭⁬‮‎‬​‫‮‏⁫‫‌‏‭⁫‎‭⁮‪⁭‭‫‭‮
	// privatescope
	internal static int u206a‭⁮‪⁬⁬‌⁫​‪⁪​‫‫⁮⁮‍‭⁬‮‎‬​‫‮‏⁫‫‌‏‭⁫‎‭⁮‪⁭‭‫‭‮(Socket socket)
	{
		return socket.Available;
	}

	// ⁯‍‬⁯‍⁪‎‮‭‫⁭‬‪⁭‭⁯⁮‮‫‮⁭‪‭‪⁬‬⁬‏⁮‪⁫‎‬​​⁭⁫‏‮⁪‮
	// privatescope
	internal static void u206f‍‬⁯‍⁪‎‮‭‫⁭‬‪⁭‭⁯⁮‮‫‮⁭‪‭‪⁬‬⁬‏⁮‪⁫‎‬​​⁭⁫‏‮⁪‮(object obj, ref bool flagPointer)
	{
		Monitor.Enter(obj, ref flagPointer);
	}

	// ‏⁮‪⁬⁮‏‮‍‫​‍​​​⁯‫‭‬⁭‪‎‍‭‬⁭⁯⁪⁪‍‌⁫​‮‍⁭⁪‭⁯‭‫‮
	// privatescope
	internal static void u200f⁮‪⁬⁮‏‮‍‫​‍​​​⁯‫‭‬⁭‪‎‍‭‬⁭⁯⁪⁪‍‌⁫​‮‍⁭⁪‭⁯‭‫‮(object obj)
	{
		Monitor.Exit(obj);
	}

	// ‏⁫‬⁪⁬‫⁭‭⁮‎⁬‌‬‍⁯‪‎‫‮⁫‍⁯⁪⁪⁮‭‮⁯‍‏‪⁮‬⁪‭⁯⁭‮⁮⁪‮
	// privatescope
	internal static IAsyncResult u200f⁫‬⁪⁬‫⁭‭⁮‎⁬‌‬‍⁯‪‎‫‮⁫‍⁯⁪⁪⁮‭‮⁯‍‏‪⁮‬⁪‭⁯⁭‮⁮⁪‮(Socket socket, byte[] numArray, int num, int num, SocketFlags socketFlag, AsyncCallback asyncCallback, object obj)
	{
		return socket.BeginReceive(numArray, num, num, socketFlag, asyncCallback, obj);
	}

	// ⁪⁯⁪‫‪‎‮‎⁯‏⁯⁯⁯⁯‎⁪​⁪‏‌‮‎‍‬⁮‍‍‏‪‎‎‍‌⁬⁬‏‍⁯‮‪‮
	// privatescope
	internal static object u206a⁯⁪‫‪‎‮‎⁯‏⁯⁯⁯⁯‎⁪​⁪‏‌‮‎‍‬⁮‍‍‏‪‎‎‍‌⁬⁬‏‍⁯‮‪‮(IAsyncResult asyncResult)
	{
		return asyncResult.AsyncState;
	}

	// ​⁮‪‎⁫‬‎⁬‫​⁪‏⁯⁫⁭⁭‪‬‮‫‌‭⁪‏⁯‪‬⁬‭‭​‬‮‭‬‎⁬‪‪‏‮
	// privatescope
	internal static Socket u200b⁮‪‎⁫‬‎⁬‫​⁪‏⁯⁫⁭⁭‪‬‮‫‌‭⁪‏⁯‪‬⁬‭‭​‬‮‭‬‎⁬‪‪‏‮(Socket socket, IAsyncResult asyncResult)
	{
		return socket.EndAccept(asyncResult);
	}

	// ⁯⁪⁬⁯‏‏⁫‎‌⁫‌‬⁪⁫‍⁯⁭‪‮⁯⁮‮⁭‬‫⁪‌⁬⁮⁪‭⁫⁬⁮‭‮⁭⁬‎⁭‮
	// privatescope
	internal static int u206f⁪⁬⁯‏‏⁫‎‌⁫‌‬⁪⁫‍⁯⁭‪‮⁯⁮‮⁭‬‫⁪‌⁬⁮⁪‭⁫⁬⁮‭‮⁭⁬‎⁭‮(Socket socket, IAsyncResult asyncResult)
	{
		return socket.EndReceive(asyncResult);
	}

	// ‭‎‍‫‮‍‏⁮‪⁪‮‌​​⁮⁮‌‏⁪‏⁫‌⁬‪‍‏‮‍⁬‍‍‍⁮‬‌‪⁬​⁯‏‮
	// privatescope
	internal static string u202d‎‍‫‮‍‏⁮‪⁪‮‌​​⁮⁮‌‏⁪‏⁫‌⁬‪‍‏‮‍⁬‍‍‍⁮‬‌‪⁬​⁯‏‮(Encoding encoding, byte[] numArray, int num, int num)
	{
		return encoding.GetString(numArray, num, num);
	}

	// ‬‎⁫⁭‪‎‬⁫‮‫⁮⁮⁯⁭‮‫‎​‭‍‍⁫‬‮‎‫⁬⁮‏‫‪‎⁫⁭‫⁮‮⁭‮‬‮
	// privatescope
	internal static StringBuilder u202c‎⁫⁭‪‎‬⁫‮‫⁮⁮⁯⁭‮‫‎​‭‍‍⁫‬‮‎‫⁬⁮‏‫‪‎⁫⁭‫⁮‮⁭‮‬‮(StringBuilder stringBuilder, string str)
	{
		return stringBuilder.Append(str);
	}

	// ⁯‬‬​‮‌⁭​‭‏⁫‬‏⁯⁬‍‎⁯‮⁫⁪⁫‭⁭⁮‮⁯⁮‭‮‫⁭⁮‌⁬⁫‌⁬‏‫‮
	// privatescope
	internal static string u206f‬‬​‮‌⁭​‭‏⁫‬‏⁯⁬‍‎⁯‮⁫⁪⁫‭⁭⁮‮⁯⁮‭‮‫⁭⁮‌⁬⁫‌⁬‏‫‮(object obj)
	{
		return obj.ToString();
	}

	// ⁫⁮⁪⁮‮‌⁫⁫‍‏⁯‫⁮​‎‍‌‏‫‮‫‭‎⁯‪⁫‭​⁮⁮‭‍‍⁪​‬‎​⁪‎‮
	// privatescope
	internal static string[] u206b⁮⁪⁮‮‌⁫⁫‍‏⁯‫⁮​‎‍‌‏‫‮‫‭‎⁯‪⁫‭​⁮⁮‭‍‍⁪​‬‎​⁪‎‮(string str, char[] chrArray)
	{
		return str.Split(chrArray);
	}

	// ⁫‭⁫⁬⁫‮⁪‮​⁬‭⁭‬‎‮⁪‮‌‭‏⁯‏‌‭‭‏‏‌⁫‪‭‎​⁬⁪‬‎⁭⁬‍‮
	// privatescope
	internal static int u206b‭⁫⁬⁫‮⁪‮​⁬‭⁭‬‎‮⁪‮‌‭‏⁯‏‌‭‭‏‏‌⁫‪‭‎​⁬⁪‬‎⁭⁬‍‮(string str, string str, int num)
	{
		return str.IndexOf(str, num);
	}

	// ⁫‬‍‪⁫‮‬‬⁭​‭‍⁮‮‎⁭‪‍⁭‍‍​‬‬‌‍‌‍⁮‫‪‌‌⁫‌‍‍⁫⁯⁭‮
	// privatescope
	internal static string u206b‬‍‪⁫‮‬‬⁭​‭‍⁮‮‎⁭‪‍⁭‍‍​‬‬‌‍‌‍⁮‫‪‌‌⁫‌‍‍⁫⁯⁭‮(string str, int num, int num)
	{
		return str.Substring(num, num);
	}

	// ‪‭‭‭‭‮⁪‭‬‭​⁬⁯‍‏‪⁯⁮⁬⁪⁮‫⁭​‮‏‫‎⁮​‭‎‬⁭​⁮‌​​⁬‮
	// privatescope
	internal static int u202a‭‭‭‭‮⁪‭‬‭​⁬⁯‍‏‪⁯⁮⁬⁪⁮‫⁭​‮‏‫‎⁮​‭‎‬⁭​⁮‌​​⁬‮(string str)
	{
		return str.Length;
	}

	// ‮‮⁮⁪​⁬‬‮⁭⁪⁯‏‎‪‬‌‪⁬⁫‪⁫​‮‏‫‎⁪‪‌‏⁬⁯⁯‏‌‌⁫‏‬‎‮
	// privatescope
	internal static void u202e‮⁮⁪​⁬‬‮⁭⁪⁯‏‎‪‬‌‪⁬⁫‪⁫​‮‏‫‎⁪‪‌‏⁬⁯⁯‏‌‌⁫‏‬‎‮(StringBuilder stringBuilder, int num)
	{
		stringBuilder.Length = num;
	}

	// ‏‭⁯‭‌‪‎‏‮⁮‭‮⁭‌⁬‌⁭⁭⁭⁪‪⁮⁮​‪‎‮​⁫‭‍​⁭‮⁬⁯⁪⁯⁬‏‮
	// privatescope
	internal static StringBuilder u200f‭⁯‭‌‪‎‏‮⁮‭‮⁭‌⁬‌⁭⁭⁭⁪‪⁮⁮​‪‎‮​⁫‭‍​⁭‮⁬⁯⁪⁯⁬‏‮(StringBuilder stringBuilder)
	{
		return stringBuilder.Clear();
	}

	// ⁪⁪⁫‬⁭​⁮​⁮‬‍​‍‏⁭‎‬‎​⁪⁫‍⁭‎‏‮‌⁪‫‏⁮‫‏⁭‍⁫‌‭‍‎‮
	// privatescope
	internal static IAsyncResult u206a⁪⁫‬⁭​⁮​⁮‬‍​‍‏⁭‎‬‎​⁪⁫‍⁭‎‏‮‌⁪‫‏⁮‫‏⁭‍⁫‌‭‍‎‮(Socket socket, byte[] numArray, int num, int num, SocketFlags socketFlag, AsyncCallback asyncCallback, object obj)
	{
		return socket.BeginSend(numArray, num, num, socketFlag, asyncCallback, obj);
	}

	// ‍⁯‪⁯‭‫‫⁭⁬‭‪‮‪‪​⁪‪⁪⁭‪‭‏⁬⁮⁫‎⁪⁪‍‎‪⁭⁭⁫‬⁪⁬‭⁪‍‮
	// privatescope
	internal static int u200d⁯‪⁯‭‫‫⁭⁬‭‪‮‪‪​⁪‪⁪⁭‪‭‏⁬⁮⁫‎⁪⁪‍‎‪⁭⁭⁫‬⁪⁬‭⁪‍‮(Socket socket, IAsyncResult asyncResult)
	{
		return socket.EndSend(asyncResult);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public u206b‭⁯​​⁬‫‍⁮‌‌‪⁫⁭‮⁪‫‪‬‭‫⁫⁭⁮‭‎⁮‭⁪‎⁪⁪⁭‏‬⁯⁮‮‌‪‮(u200b⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮ _​⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮, int num)
	{
		this.u206a‌‭‪‍‪⁯⁯⁫‭​‪⁭⁮‫⁮⁬⁮‌⁭⁭‎‎⁭‌‏⁭⁯⁫‎‎⁯‍‫⁮⁯‮‎‬⁬‮ = _​⁮⁯‭⁬⁭‎‍‫⁮‌⁯‪‌‬⁮‍‪⁭‮‏‭‎‫‫‎⁫⁮⁮⁫⁬‬‫​⁫‌‫‌⁬‎‮;
		this.u206c‬‍‮‬⁪‫‬⁮⁬⁭‬‬‮‭‏‫‪‬⁭⁪​‍‌⁭‫‪‏⁬⁫⁯⁯‭‮‮‍‭⁫‌⁭‮ = num;
	}

	public event EventHandler ‮⁬‫‌⁯‬‪​‍⁫‏‮‍⁪‏‍⁪‍‮⁫⁫‭‮⁯‪‫⁪‭‪⁫‮‬​‎‎‪‮‍⁫‌‮
	{
		add
		{
			EventHandler eventHandler1 = null;
			int num;
			EventHandler eventHandler2 = this.u202e⁬‫‌⁯‬‪​‍⁫‏‮‍⁪‏‍⁪‍‮⁫⁫‭‮⁯‪‫⁪‭‪⁫‮‬​‎‎‪‮‍⁫‌‮;
		Label1:
			int num1 = -1776678020;
			while (true)
			{
				int num2 = num1 ^ -1894197137;
				uint num3 = (uint)num2;
				switch (num2 % 5)
				{
					case 0:
					{
						num = ((object)eventHandler2 == (object)eventHandler1 ? 1576120131 : 2058351416);
						num1 = (int)(num ^ num3 * 1589598228);
						continue;
					}
					case 1:
					{
						return;
					}
					case 2:
					{
						eventHandler1 = eventHandler2;
						num1 = -1459950435;
						continue;
					}
					case 3:
					{
						goto Label1;
					}
					case 4:
					{
						EventHandler eventHandler3 = (EventHandler)u206b‭⁯​​⁬‫‍⁮‌‌‪⁫⁭‮⁪‫‪‬‭‫⁫⁭⁮‭‎⁮‭⁪‎⁪⁪⁭‏‬⁯⁮‮‌‪‮.u200b​‎‮⁬⁮‌⁫⁮⁮‮⁮‬‎‮‎‮‬‬‫‌⁯‎⁪​⁯‎‌⁫‬‬‮‫⁯⁯‏⁫‫⁫‏‮(eventHandler1, eventHandler);
						eventHandler2 = Interlocked.CompareExchange<EventHandler>(ref this.u202e⁬‫‌⁯‬‪​‍⁫‏‮‍⁪‏‍⁪‍‮⁫⁫‭‮⁯‪‫⁪‭‪⁫‮‬​‎‎‪‮‍⁫‌‮, eventHandler3, eventHandler1);
						num1 = (int)(num3 * -76365493 ^ -618466028);
						continue;
					}
				}
			}
		}
		remove
		{
			EventHandler eventHandler1 = null;
			int num;
			EventHandler eventHandler2 = this.u202e⁬‫‌⁯‬‪​‍⁫‏‮‍⁪‏‍⁪‍‮⁫⁫‭‮⁯‪‫⁪‭‪⁫‮‬​‎‎‪‮‍⁫‌‮;
		Label0:
			int num1 = -1907812887;
			while (true)
			{
				int num2 = num1 ^ -623127048;
				uint num3 = (uint)num2;
				switch (num2 % 4)
				{
					case 0:
					{
						goto Label0;
					}
					case 1:
					{
						eventHandler1 = eventHandler2;
						EventHandler eventHandler3 = (EventHandler)u206b‭⁯​​⁬‫‍⁮‌‌‪⁫⁭‮⁪‫‪‬‭‫⁫⁭⁮‭‎⁮‭⁪‎⁪⁪⁭‏‬⁯⁮‮‌‪‮.u202c​⁭⁫‌‫​‬‭⁮⁫⁯⁮⁬‏⁭​‍‏‎⁭⁪‮⁫⁮⁬‏‭‎‫‪‌‍⁮‮⁬⁬‪‏‫‮(eventHandler1, eventHandler);
						eventHandler2 = Interlocked.CompareExchange<EventHandler>(ref this.u202e⁬‫‌⁯‬‪​‍⁫‏‮‍⁪‏‍⁪‍‮⁫⁫‭‮⁯‪‫⁪‭‪⁫‮‬​‎‎‪‮‍⁫‌‮, eventHandler3, eventHandler1);
						num1 = -1607323698;
						continue;
					}
					case 2:
					{
						num = ((object)eventHandler2 == (object)eventHandler1 ? -419798727 : -1972226737);
						num1 = (int)(num ^ num3 * -523860695);
						continue;
					}
					case 3:
					{
						return;
					}
				}
			}
		}
	}
}