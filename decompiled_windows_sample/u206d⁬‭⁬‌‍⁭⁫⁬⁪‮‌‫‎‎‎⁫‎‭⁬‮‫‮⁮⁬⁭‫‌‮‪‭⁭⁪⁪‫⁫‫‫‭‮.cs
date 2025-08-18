using SDRSharp.Tetra;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// ⁭⁬‭⁬‌‍⁭⁫⁬⁪‮‌‫‎‎‎⁫‎‭⁬‮‫‮⁮⁬⁭‫‌‮‪‭⁭⁪⁪‫⁫‫‫‭‮
internal class u206d⁬‭⁬‌‍⁭⁫⁬⁪‮‌‫‎‎‎⁫‎‭⁬‮‫‮⁮⁬⁭‫‌‮‪‭⁭⁪⁪‫⁫‫‫‭‮
{
	// ⁬⁭⁭‍⁮​⁮⁪⁮‍‍‌‍‪‭‬‫⁪‪‍​⁯‪‌⁪⁭‎‏⁮‭‪⁫⁫⁭‭‏‪⁭​⁭‮
	private bool u206c⁭⁭‍⁮​⁮⁪⁮‍‍‌‍‪‭‬‫⁪‪‍​⁯‪‌⁪⁭‎‏⁮‭‪⁫⁫⁭‭‏‪⁭​⁭‮;

	// ⁭⁬​‪‏⁬‬‍‎⁮‍‎⁪‪⁬⁫⁪⁫​‌⁭‍⁫‍‭‪⁯‬‍‏⁮‫‪⁪⁬‬⁭‍​‏‮
	private readonly Rules[] u206d⁬​‪‏⁬‬‍‎⁮‍‎⁪‪⁬⁫⁪⁫​‌⁭‍⁫‍‭‪⁯‬‍‏⁮‫‪⁪⁬‬⁭‍​‏‮ = new Rules[] { new Rules(GlobalNames.Location_update_accept_type, 3, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Options_bit, 1, RulesType.Options_bit, 0, 0, 0), new Rules(GlobalNames.Presence_bit, 1, RulesType.Presence_bit, 1, 0, 0), new Rules(GlobalNames.MM_SSI, 24, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Presence_bit, 1, RulesType.Presence_bit, 1, 0, 0), new Rules(GlobalNames.Reserved, 24, RulesType.Reserved, 0, 0, 0), new Rules(GlobalNames.Presence_bit, 1, RulesType.Presence_bit, 1, 0, 0), new Rules(GlobalNames.Reserved, 16, RulesType.Reserved, 0, 0, 0), new Rules(GlobalNames.Presence_bit, 1, RulesType.Presence_bit, 1, 0, 0), new Rules(GlobalNames.Reserved, 14, RulesType.Reserved, 0, 0, 0), new Rules(GlobalNames.Presence_bit, 1, RulesType.Presence_bit, 1, 0, 0), new Rules(GlobalNames.Reserved, 6, RulesType.Reserved, 0, 0, 0) };

	// ‫​‍‭‬⁯⁭‪‬‍⁮⁮‏⁬⁮⁮⁯‮‬‏‭⁯⁬‬‌​‭⁯‪​⁭​⁪⁮⁬⁫‫‏⁭⁭‮
	private readonly Rules[] u202b​‍‭‬⁯⁭‪‬‍⁮⁮‏⁬⁮⁮⁯‮‬‏‭⁯⁬‬‌​‭⁯‪​⁭​⁪⁮⁬⁫‫‏⁭⁭‮ = new Rules[] { new Rules(GlobalNames.Group_identity_report, 1, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Cipher_control, 1, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Ciphering_parameters, 10, RulesType.Switch, 363, 1, 0), new Rules(GlobalNames.Options_bit, 1, RulesType.Options_bit, 0, 0, 0), new Rules(GlobalNames.Presence_bit, 1, RulesType.Presence_bit, 1, 0, 0), new Rules(GlobalNames.MM_Address_extension, 24, RulesType.Direct, 0, 0, 0) };

	// ‪⁮⁯‌⁫⁪‪‬‍⁮⁮⁫⁮⁭​‍⁪‫⁫‮⁭⁬​⁪⁬‏‫‭⁮⁫‫‭‎‌⁫⁬⁫⁮⁮‌‮
	private readonly Rules[] u202a⁮⁯‌⁫⁪‪‬‍⁮⁮⁫⁮⁭​‍⁪‫⁫‮⁭⁬​⁪⁬‏‫‭⁮⁫‫‭‎‌⁫⁬⁫⁮⁮‌‮ = new Rules[] { new Rules(GlobalNames.Location_update_type, 3, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Reject_cause, 5, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Cipher_control, 1, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Ciphering_parameters, 10, RulesType.Switch, 363, 1, 0), new Rules(GlobalNames.Options_bit, 1, RulesType.Options_bit, 0, 0, 0), new Rules(GlobalNames.Presence_bit, 1, RulesType.Presence_bit, 1, 0, 0), new Rules(GlobalNames.MM_Address_extension, 24, RulesType.Direct, 0, 0, 0) };

	// ⁮⁪⁫‪⁬‏‮⁯‪‎⁭‫‍⁭‫⁭‌‬​‭​‪‪‮⁮​‎⁫‬‏⁬‮⁪‮⁯‬⁯⁪​‌‮
	private readonly Rules[] u206e⁪⁫‪⁬‏‮⁯‪‎⁭‫‍⁭‫⁭‌‬​‭​‪‪‮⁮​‎⁫‬‏⁬‮⁪‮⁯‬⁯⁪​‌‮ = new Rules[] { new Rules(GlobalNames.MM_SSI, 24, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.MM_Address_extension, 24, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Options_bit, 1, RulesType.Options_bit, 0, 0, 0) };

	// ‍⁪⁭‬⁬‪‭​‫‬‏‌⁮‏⁭⁪​‭​‭⁫⁮‪‌⁭‏‌‏‍‏‭⁮‪‎⁬‎‬⁬‫‭‮
	private readonly Rules[] u200d⁪⁭‬⁬‪‭​‫‬‏‌⁮‏⁭⁪​‭​‭⁫⁮‪‌⁭‏‌‏‍‏‭⁮‪‎⁬‎‬⁬‫‭‮ = new Rules[] { new Rules(GlobalNames.Group_identity_report, 1, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Group_identity_acknowledgement_request, 1, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Group_identity_attach_detach_mode, 1, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Options_bit, 1, RulesType.Options_bit, 0, 0, 0) };

	// ⁫⁯‬‮​⁯‫⁪⁮‫‍‍‎⁫‌‬‍⁫‮‪‍‏‌‍‏‮‭⁯⁬‎​‭‍‪‫​‍⁯‮‍‮
	private readonly Rules[] u206b⁯‬‮​⁯‫⁪⁮‫‍‍‎⁫‌‬‍⁫‮‪‍‏‌‍‏‮‭⁯⁬‎​‭‍‪‫​‍⁯‮‍‮ = new Rules[] { new Rules(GlobalNames.Group_identity_accept_reject, 1, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Reserved, 1, RulesType.Reserved, 0, 0, 0), new Rules(GlobalNames.Options_bit, 1, RulesType.Options_bit, 0, 0, 0) };

	[MethodImpl(MethodImplOptions.NoInlining)]
	// ‌‌‫‮‮⁭‭‬⁭‍⁫‍⁯‫‭⁭⁯‎‭‏‭⁭‪⁫⁮‌‪‏‍‭‫⁮‏⁯⁭‬‪‪‍‌‮
	public void u200c‌‫‮‮⁭‭‬⁭‍⁫‍⁯‫‭⁭⁯‎‭‏‭⁭‪⁫⁮‌‪‏‍‭‫⁮‏⁯⁭‬‪‪‍‌‮(LogicChannel , ref int , Dictionary<GlobalNames, int> )
	{
		// 
		// Current member / type: System.Void ⁭⁬‭⁬‌‍⁭⁫⁬⁪‮‌‫‎‎‎⁫‎‭⁬‮‫‮⁮⁬⁭‫‌‮‪‭⁭⁪⁪‫⁫‫‫‭‮::‌‌‫‮‮⁭‭‬⁭‍⁫‍⁯‫‭⁭⁯‎‭‏‭⁭‪⁫⁮‌‪‏‍‭‫⁮‏⁯⁭‬‪‪‍‌‮(SDRSharp.Tetra.LogicChannel,System.Int32&,System.Collections.Generic.Dictionary`2<SDRSharp.Tetra.GlobalNames,System.Int32>)
		// File path: C:\SDRSharp\Plugins\Tetra\SDRSharp.Tetra.dll
		// 
		// Product version: 0.0.0.0
		// Exception in: System.Void ‌‌‫‮‮⁭‭‬⁭‍⁫‍⁯‫‭⁭⁯‎‭‏‭⁭‪⁫⁮‌‪‏‍‭‫⁮‏⁯⁭‬‪‪‍‌‮(SDRSharp.Tetra.LogicChannel,System.Int32&,System.Collections.Generic.Dictionary<SDRSharp.Tetra.GlobalNames,System.Int32>)
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
	// ‭⁫‌⁯‭⁭‭‍‏‏⁮‫‌​‎‭‪⁯‫⁮‌‏‬⁫⁯⁬‬‎‭‭‍⁬⁭‏⁮‪‫‍⁬⁪‮
	private void u202d⁫‌⁯‭⁭‭‍‏‏⁮‫‌​‎‭‪⁯‫⁮‌‏‬⁫⁯⁬‬‎‭‭‍⁬⁭‏⁮‪‫‍⁬⁪‮(LogicChannel , ref int , Dictionary<GlobalNames, int> )
	{
		// 
		// Current member / type: System.Void ⁭⁬‭⁬‌‍⁭⁫⁬⁪‮‌‫‎‎‎⁫‎‭⁬‮‫‮⁮⁬⁭‫‌‮‪‭⁭⁪⁪‫⁫‫‫‭‮::‭⁫‌⁯‭⁭‭‍‏‏⁮‫‌​‎‭‪⁯‫⁮‌‏‬⁫⁯⁬‬‎‭‭‍⁬⁭‏⁮‪‫‍⁬⁪‮(SDRSharp.Tetra.LogicChannel,System.Int32&,System.Collections.Generic.Dictionary`2<SDRSharp.Tetra.GlobalNames,System.Int32>)
		// File path: C:\SDRSharp\Plugins\Tetra\SDRSharp.Tetra.dll
		// 
		// Product version: 0.0.0.0
		// Exception in: System.Void ‭⁫‌⁯‭⁭‭‍‏‏⁮‫‌​‎‭‪⁯‫⁮‌‏‬⁫⁯⁬‬‎‭‭‍⁬⁭‏⁮‪‫‍⁬⁪‮(SDRSharp.Tetra.LogicChannel,System.Int32&,System.Collections.Generic.Dictionary<SDRSharp.Tetra.GlobalNames,System.Int32>)
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

	// ⁮‬⁮‍‭‮⁪⁭‪‌‭‍⁮‮⁫⁭‍⁪⁮‪‎⁫⁯‍⁮⁬‍⁪⁪‎⁫⁪⁫⁯‭‎‪‬‏⁪‮
	// privatescope
	internal static string u206e‬⁮‍‭‮⁪⁭‪‌‭‍⁮‮⁫⁭‍⁪⁮‪‎⁫⁯‍⁮⁬‍⁪⁪‎⁫⁪⁫⁯‭‎‪‬‏⁪‮(string str, string str)
	{
		return string.Concat(str, str);
	}

	// ⁭⁮⁫‫‬⁭⁭⁭⁬‭⁪​‎‭⁮‍⁫‮‬‫‌⁪‍‬⁯‏‬⁯‪‍⁫‮‭⁭‫‪⁪‏‪⁮‮
	// privatescope
	internal static string u206d⁮⁫‫‬⁭⁭⁭⁬‭⁪​‎‭⁮‍⁫‮‬‫‌⁪‍‬⁯‏‬⁯‪‍⁫‮‭⁭‫‪⁪‏‪⁮‮(object obj, object obj, object obj)
	{
		return string.Concat(obj, obj, obj);
	}

	public u206d⁬‭⁬‌‍⁭⁫⁬⁪‮‌‫‎‎‎⁫‎‭⁬‮‫‮⁮⁬⁭‫‌‮‪‭⁭⁪⁪‫⁫‫‫‭‮()
	{
	}
}