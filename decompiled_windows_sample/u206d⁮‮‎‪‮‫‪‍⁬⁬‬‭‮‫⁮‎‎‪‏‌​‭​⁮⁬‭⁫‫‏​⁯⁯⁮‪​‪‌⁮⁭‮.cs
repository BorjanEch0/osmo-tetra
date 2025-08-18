using SDRSharp.Tetra;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

// ⁭⁮‮‎‪‮‫‪‍⁬⁬‬‭‮‫⁮‎‎‪‏‌​‭​⁮⁬‭⁫‫‏​⁯⁯⁮‪​‪‌⁮⁭‮
internal class u206d⁮‮‎‪‮‫‪‍⁬⁬‬‭‮‫⁮‎‎‪‏‌​‭​⁮⁬‭⁫‫‏​⁯⁯⁮‪​‪‌⁮⁭‮
{
	// ‮⁫⁭‫⁭‍‫‪​⁯⁫‬⁮‌‬⁭‏‮⁭⁭‮​‬‪⁫‭‫⁮‫⁫‭‫⁯‏‍⁭‌‬⁪‪‮
	public static List<Dictionary<int, SdsMessage>> u202e⁫⁭‫⁭‍‫‪​⁯⁫‬⁮‌‬⁭‏‮⁭⁭‮​‬‪⁫‭‫⁮‫⁫‭‫⁯‏‍⁭‌‬⁪‪‮;

	// ‭‌‏​⁭⁭​‎​‫‬⁬⁯‮‏‌‍‌⁪⁫‬‍‏‭⁬‭‎‪⁪‫⁫‌​‪‪‭‍⁯⁮⁯‮
	public static int u202d‌‏​⁭⁭​‎​‫‬⁬⁯‮‏‌‍‌⁪⁫‬‍‏‭⁬‭‎‪⁪‫⁫‌​‪‪‭‍⁯⁮⁯‮;

	// ⁬⁭⁭‍⁮​⁮⁪⁮‍‍‌‍‪‭‬‫⁪‪‍​⁯‪‌⁪⁭‎‏⁮‭‪⁫⁫⁭‭‏‪⁭​⁭‮
	private bool u206c⁭⁭‍⁮​⁮⁪⁮‍‍‌‍‪‭‬‫⁪‪‍​⁯‪‌⁪⁭‎‏⁮‭‪⁫⁫⁭‭‏‪⁭​⁭‮;

	// ⁬‪‭‭‎‍⁯⁪‏‌⁯⁫‪‫⁮⁮‫⁫‮‬‌‏​‍‮⁫⁪‮⁫​⁬‮‭‬‬⁭‌⁯‌‍‮
	private readonly Rules[] u206c‪‭‭‎‍⁯⁪‏‌⁯⁫‪‫⁮⁮‫⁫‮‬‌‏​‍‮⁫⁪‮⁫​⁬‮‭‬‬⁭‌⁯‌‍‮ = new Rules[] { new Rules(GlobalNames.Reserved, 4, RulesType.Reserved, 0, 0, 0), new Rules(GlobalNames.Delivery_status, 8, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Message_reference, 8, RulesType.Direct, 0, 0, 0) };

	// ‌‭‭‬⁬‍‭‍⁮‍⁯⁭‌‎‮‮‌‍⁪‪‬⁫‭‌‬‮⁯⁫‫‫⁫⁫⁪‮⁯‌‏⁫‏⁭‮
	private readonly Rules[] u200c‭‭‬⁬‍‭‍⁮‍⁯⁭‌‎‮‮‌‍⁪‪‬⁫‭‌‬‮⁯⁫‫‫⁫⁫⁪‮⁯‌‏⁫‏⁭‮ = new Rules[] { new Rules(GlobalNames.Acknowledgement_required, 1, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Reserved, 2, RulesType.Reserved, 0, 0, 0), new Rules(GlobalNames.Storage_forward_control, 1, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Delivery_status, 8, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Message_reference, 8, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Presence_bit, 0, RulesType.Jamp, 73, 0, 8), new Rules(GlobalNames.Validity_period, 5, RulesType.Switch, 73, 1, 0), new Rules(GlobalNames.Forward_address_type, 3, RulesType.Switch, 73, 1, 0), new Rules(GlobalNames.Forward_short_address, 8, RulesType.Switch, 76, 0, 0), new Rules(GlobalNames.Forward_address_SSI, 24, RulesType.Switch, 76, 1, 0), new Rules(GlobalNames.MCC, 10, RulesType.Switch, 76, 2, 0), new Rules(GlobalNames.MNC, 14, RulesType.Switch, 76, 2, 0), new Rules(GlobalNames.Forward_address_SSI, 24, RulesType.Switch, 76, 2, 0), new Rules(GlobalNames.Number_subscriber_number_digits, 8, RulesType.Switch, 76, 3, 0) };

	// ‏‎‫⁭‬​⁬‭⁬‫⁫‮‏⁮​‎⁭⁬⁯‫‪​‪‮‫‭‭‮‏⁫‮‮‏‪​⁫‭‏⁭‫‮
	private readonly Rules[] u200f‎‫⁭‬​⁬‭⁬‫⁫‮‏⁮​‎⁭⁬⁯‫‪​‪‮‫‭‭‮‏⁫‮‮‏‪​⁫‭‏⁭‫‮ = new Rules[] { new Rules(GlobalNames.Delivery_report_request, 2, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Service_selection, 1, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Storage_forward_control, 1, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Message_reference, 8, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Presence_bit, 0, RulesType.Jamp, 73, 0, 8), new Rules(GlobalNames.Validity_period, 5, RulesType.Switch, 73, 1, 0), new Rules(GlobalNames.Forward_address_type, 3, RulesType.Switch, 73, 1, 0), new Rules(GlobalNames.Forward_short_address, 8, RulesType.Switch, 76, 0, 0), new Rules(GlobalNames.Forward_address_SSI, 24, RulesType.Switch, 76, 1, 0), new Rules(GlobalNames.MCC, 10, RulesType.Switch, 76, 2, 0), new Rules(GlobalNames.MNC, 14, RulesType.Switch, 76, 2, 0), new Rules(GlobalNames.Forward_address_SSI, 24, RulesType.Switch, 76, 2, 0), new Rules(GlobalNames.Number_subscriber_number_digits, 8, RulesType.Switch, 76, 3, 0) };

	// ⁬‎‎⁫‬⁮⁮‏⁪‍‫⁮⁯‫⁫‭‬‎⁪‍‬‌⁭⁮‏⁫‌‎‌‪‏‌⁫‪⁪⁮‍‪⁮‌‮
	private readonly Rules[] u206c‎‎⁫‬⁮⁮‏⁪‍‫⁮⁯‫⁫‭‬‎⁪‍‬‌⁭⁮‏⁫‌‎‌‪‏‌⁫‪⁪⁮‍‪⁮‌‮ = new Rules[] { new Rules(GlobalNames.Time_elapsed, 2, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Longitude, 25, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Latitude, 24, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Position_error, 3, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Horizontal_velocity, 7, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Direction_of_travel, 4, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Type_of_additional_data, 1, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Reason_for_sending, 8, RulesType.Switch, 89, 0, 0), new Rules(GlobalNames.User_defined_data, 8, RulesType.Switch, 89, 1, 0) };

	// ⁯‮‏⁬‮⁯‌‮⁮⁫⁯⁮‬⁭‏‫⁮‍‪‭‬‎‮‍‏⁮⁫‏‌‫​‍⁮⁭⁫‏⁪‭​‎‮
	private readonly Rules[] u206f‮‏⁬‮⁯‌‮⁮⁫⁯⁮‬⁭‏‫⁮‍‪‭‬‎‮‍‏⁮⁫‏‌‫​‍⁮⁭⁫‏⁪‭​‎‮ = new Rules[] { new Rules(GlobalNames.Time_data_type, 2, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Presence_bit, 0, RulesType.Jamp, 102, 0, 2), new Rules(GlobalNames.Time_elapsed, 2, RulesType.Switch, 102, 1, 0), new Rules(GlobalNames.Time_of_postion, 22, RulesType.Switch, 102, 2, 0), new Rules(GlobalNames.Location_shape, 4, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Presence_bit, 0, RulesType.Jamp, 119, 0, 11), new Rules(GlobalNames.Longitude, 25, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Latitude, 24, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Horizontal_position_uncertainty, 6, RulesType.Switch, 119, 2, 0), new Rules(GlobalNames.Half_of_the_major_axis, 6, RulesType.Switch, 119, 3, 0), new Rules(GlobalNames.Half_of_the_minor_axis, 6, RulesType.Switch, 119, 3, 0), new Rules(GlobalNames.Angle, 8, RulesType.Switch, 119, 3, 0), new Rules(GlobalNames.Confidence_level, 3, RulesType.Switch, 119, 3, 0), new Rules(GlobalNames.Location_altitude, 12, RulesType.Switch, 119, 4, 0), new Rules(GlobalNames.Horizontal_position_uncertainty, 6, RulesType.Switch, 119, 5, 0), new Rules(GlobalNames.Location_altitude, 12, RulesType.Switch, 119, 5, 0), new Rules(GlobalNames.Half_of_the_major_axis, 6, RulesType.Switch, 119, 6, 0), new Rules(GlobalNames.Half_of_the_minor_axis, 6, RulesType.Switch, 119, 6, 0), new Rules(GlobalNames.Angle, 8, RulesType.Switch, 119, 6, 0), new Rules(GlobalNames.Location_altitude, 12, RulesType.Switch, 119, 6, 0), new Rules(GlobalNames.Confidence_level, 3, RulesType.Switch, 119, 6, 0), new Rules(GlobalNames.Horizontal_position_uncertainty, 6, RulesType.Switch, 119, 7, 0), new Rules(GlobalNames.Location_altitude, 12, RulesType.Switch, 119, 7, 0), new Rules(GlobalNames.Location_altitude_uncertainty, 3, RulesType.Switch, 119, 7, 0), new Rules(GlobalNames.Half_of_the_major_axis, 6, RulesType.Switch, 119, 8, 0), new Rules(GlobalNames.Half_of_the_minor_axis, 6, RulesType.Switch, 119, 8, 0), new Rules(GlobalNames.Angle, 8, RulesType.Switch, 119, 8, 0), new Rules(GlobalNames.Location_altitude, 12, RulesType.Switch, 119, 8, 0), new Rules(GlobalNames.Location_altitude_accuracy, 3, RulesType.Switch, 119, 8, 0), new Rules(GlobalNames.Confidence_level, 3, RulesType.Switch, 119, 8, 0), new Rules(GlobalNames.Inner_radius, 16, RulesType.Switch, 119, 9, 0), new Rules(GlobalNames.Outer_radius, 16, RulesType.Switch, 119, 9, 0), new Rules(GlobalNames.Start_angle, 8, RulesType.Switch, 119, 9, 0), new Rules(GlobalNames.Stop_angle, 8, RulesType.Switch, 119, 9, 0), new Rules(GlobalNames.Confidence_level, 3, RulesType.Switch, 119, 9, 0), new Rules(GlobalNames.Position_error, 3, RulesType.Switch, 119, 10, 0), new Rules(GlobalNames.Location_shape_extension, 4, RulesType.Switch, 119, 15, 0), new Rules(GlobalNames.Velocity_data_type, 3, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Presence_bit, 0, RulesType.Jamp, 148, 0, 14), new Rules(GlobalNames.Horizontal_velocity, 7, RulesType.Switch, 148, 1, 0), new Rules(GlobalNames.Horizontal_velocity, 7, RulesType.Switch, 148, 2, 0), new Rules(GlobalNames.Vertical_velocity_uncertainty, 3, RulesType.Switch, 148, 2, 0), new Rules(GlobalNames.Horizontal_velocity, 7, RulesType.Switch, 148, 3, 0), new Rules(GlobalNames.Vertical_velocity_sign, 1, RulesType.Switch, 148, 3, 0), new Rules(GlobalNames.Vertical_velocity, 7, RulesType.Switch, 148, 3, 0), new Rules(GlobalNames.Horizontal_velocity, 7, RulesType.Switch, 148, 4, 0), new Rules(GlobalNames.Vertical_velocity_sign, 1, RulesType.Switch, 148, 4, 0), new Rules(GlobalNames.Vertical_velocity, 7, RulesType.Switch, 148, 4, 0), new Rules(GlobalNames.Vertical_velocity_uncertainty, 3, RulesType.Switch, 148, 4, 0), new Rules(GlobalNames.Horizontal_velocity, 7, RulesType.Switch, 148, 5, 0), new Rules(GlobalNames.Direction_of_Travel_extended, 8, RulesType.Switch, 148, 5, 0), new Rules(GlobalNames.Horizontal_velocity, 7, RulesType.Switch, 148, 6, 0), new Rules(GlobalNames.Direction_of_Travel_extended, 8, RulesType.Switch, 148, 6, 0), new Rules(GlobalNames.Vertical_velocity_uncertainty, 3, RulesType.Switch, 148, 6, 0), new Rules(GlobalNames.Horizontal_velocity, 7, RulesType.Switch, 148, 7, 0), new Rules(GlobalNames.Vertical_velocity_sign, 1, RulesType.Switch, 148, 7, 0), new Rules(GlobalNames.Vertical_velocity, 7, RulesType.Switch, 148, 7, 0), new Rules(GlobalNames.Direction_of_Travel_extended, 8, RulesType.Switch, 148, 7, 0), new Rules(GlobalNames.Vertical_velocity_uncertainty, 3, RulesType.Switch, 148, 7, 0), new Rules(GlobalNames.Acknowledgement_request, 1, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Type_of_additional_data, 1, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Reason_for_sending, 8, RulesType.Switch, 89, 0, 0), new Rules(GlobalNames.User_defined_data, 8, RulesType.Switch, 89, 1, 0) };

	// ⁪‌⁪‫⁮‭‪⁫‮⁯‌‪⁮‮‎⁬⁪‍‬⁭‪‪‮‪⁫​‍​‮​⁫‎⁪⁮‮⁪⁯⁭‬‪‮
	private readonly Rules[] u206a‌⁪‫⁮‭‪⁫‮⁯‌‪⁮‮‎⁬⁪‍‬⁭‪‪‮‪⁫​‍​‮​⁫‎⁪⁮‮⁪⁯⁭‬‪‮ = new Rules[] { new Rules(GlobalNames.Time_stamp_used, 1, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Text_coding_scheme, 7, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Timeframe_type, 2, RulesType.Switch, 105, 1, 0), new Rules(GlobalNames.Reserved, 2, RulesType.SwitchPass, 105, 1, 0), new Rules(GlobalNames.Month, 4, RulesType.Switch, 105, 1, 0), new Rules(GlobalNames.Day, 5, RulesType.Switch, 105, 1, 0), new Rules(GlobalNames.Hour, 5, RulesType.Switch, 105, 1, 0), new Rules(GlobalNames.Minute, 6, RulesType.Switch, 105, 1, 0) };

	// ⁮‏‪‎‮‪‭​‌‮‬‫⁬⁪‬‏‭⁯⁭‍⁬​‎‍‫‮‪‏‬​‫‏⁬‌​‭⁯‭⁭‪‮
	private readonly Rules[] u206e‏‪‎‮‪‭​‌‮‬‫⁬⁪‬‏‭⁯⁭‍⁬​‎‍‫‮‪‏‬​‫‏⁬‌​‭⁯‭⁭‪‮ = new Rules[] { new Rules(GlobalNames.Reserved, 1, RulesType.Reserved, 0, 0, 0), new Rules(GlobalNames.Text_coding_scheme, 7, RulesType.Direct, 0, 0, 0) };

	[MethodImpl(MethodImplOptions.NoInlining)]
	// ‏⁮‭‏⁯‮‪‮​‬​‍‌‪⁮⁭‏⁬‏‌⁮⁪⁮‫‬‏‪‬‏⁮‎⁫‮⁫‍⁬‌⁬⁮‭‮
	private bool u200f⁮‭‏⁯‮‪‮​‬​‍‌‪⁮⁭‏⁬‏‌⁮⁪⁮‫‬‏‪‬‏⁮‎⁫‮⁫‍⁬‌⁬⁮‭‮(LogicChannel , ref int , Dictionary<GlobalNames, int> )
	{
		// 
		// Current member / type: System.Boolean ⁭⁮‮‎‪‮‫‪‍⁬⁬‬‭‮‫⁮‎‎‪‏‌​‭​⁮⁬‭⁫‫‏​⁯⁯⁮‪​‪‌⁮⁭‮::‏⁮‭‏⁯‮‪‮​‬​‍‌‪⁮⁭‏⁬‏‌⁮⁪⁮‫‬‏‪‬‏⁮‎⁫‮⁫‍⁬‌⁬⁮‭‮(SDRSharp.Tetra.LogicChannel,System.Int32&,System.Collections.Generic.Dictionary`2<SDRSharp.Tetra.GlobalNames,System.Int32>)
		// File path: C:\SDRSharp\Plugins\Tetra\SDRSharp.Tetra.dll
		// 
		// Product version: 0.0.0.0
		// Exception in: System.Boolean ‏⁮‭‏⁯‮‪‮​‬​‍‌‪⁮⁭‏⁬‏‌⁮⁪⁮‫‬‏‪‬‏⁮‎⁫‮⁫‍⁬‌⁬⁮‭‮(SDRSharp.Tetra.LogicChannel,System.Int32&,System.Collections.Generic.Dictionary<SDRSharp.Tetra.GlobalNames,System.Int32>)
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
	// ⁫‪‫⁬‪⁮‪⁭‍‍‎⁯‌‫⁮⁪‏‮⁬⁯‫‪‎⁮⁬‎⁯‭‮‍‌‏‭‮‍⁮⁯⁮‫‬‮
	public void u206b‪‫⁬‪⁮‪⁭‍‍‎⁯‌‫⁮⁪‏‮⁬⁯‫‪‎⁮⁬‎⁯‭‮‍‌‏‭‮‍⁮⁯⁮‫‬‮(LogicChannel , int , int , Dictionary<GlobalNames, int> )
	{
		// 
		// Current member / type: System.Void ⁭⁮‮‎‪‮‫‪‍⁬⁬‬‭‮‫⁮‎‎‪‏‌​‭​⁮⁬‭⁫‫‏​⁯⁯⁮‪​‪‌⁮⁭‮::⁫‪‫⁬‪⁮‪⁭‍‍‎⁯‌‫⁮⁪‏‮⁬⁯‫‪‎⁮⁬‎⁯‭‮‍‌‏‭‮‍⁮⁯⁮‫‬‮(SDRSharp.Tetra.LogicChannel,System.Int32,System.Int32,System.Collections.Generic.Dictionary`2<SDRSharp.Tetra.GlobalNames,System.Int32>)
		// File path: C:\SDRSharp\Plugins\Tetra\SDRSharp.Tetra.dll
		// 
		// Product version: 0.0.0.0
		// Exception in: System.Void ⁫‪‫⁬‪⁮‪⁭‍‍‎⁯‌‫⁮⁪‏‮⁬⁯‫‪‎⁮⁬‎⁯‭‮‍‌‏‭‮‍⁮⁯⁮‫‬‮(SDRSharp.Tetra.LogicChannel,System.Int32,System.Int32,System.Collections.Generic.Dictionary<SDRSharp.Tetra.GlobalNames,System.Int32>)
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
	// ⁬⁫‮‫‏⁫⁪‪‭‬‫‮‍‫​‭⁫⁮‍‪⁯‎⁬⁬⁯⁫‌‏⁯⁮‭⁮⁪⁭‍⁯⁭‌‍‪‮
	public bool u206c⁫‮‫‏⁫⁪‪‭‬‫‮‍‫​‭⁫⁮‍‪⁯‎⁬⁬⁯⁫‌‏⁯⁮‭⁮⁪⁭‍⁯⁭‌‍‪‮(LogicChannel , ref int , Dictionary<GlobalNames, int> )
	{
		// 
		// Current member / type: System.Boolean ⁭⁮‮‎‪‮‫‪‍⁬⁬‬‭‮‫⁮‎‎‪‏‌​‭​⁮⁬‭⁫‫‏​⁯⁯⁮‪​‪‌⁮⁭‮::⁬⁫‮‫‏⁫⁪‪‭‬‫‮‍‫​‭⁫⁮‍‪⁯‎⁬⁬⁯⁫‌‏⁯⁮‭⁮⁪⁭‍⁯⁭‌‍‪‮(SDRSharp.Tetra.LogicChannel,System.Int32&,System.Collections.Generic.Dictionary`2<SDRSharp.Tetra.GlobalNames,System.Int32>)
		// File path: C:\SDRSharp\Plugins\Tetra\SDRSharp.Tetra.dll
		// 
		// Product version: 0.0.0.0
		// Exception in: System.Boolean ⁬⁫‮‫‏⁫⁪‪‭‬‫‮‍‫​‭⁫⁮‍‪⁯‎⁬⁬⁯⁫‌‏⁯⁮‭⁮⁪⁭‍⁯⁭‌‍‪‮(SDRSharp.Tetra.LogicChannel,System.Int32&,System.Collections.Generic.Dictionary<SDRSharp.Tetra.GlobalNames,System.Int32>)
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

	// ⁭‎⁯‌⁪⁭⁪‪‫‪⁪‮‍‫‮‏⁫⁫​‏‭‪‫⁮‏‏⁬⁯‫⁬‫‫⁯​‌⁫‬⁭‍⁬‮
	// privatescope
	internal static string u206d‎⁯‌⁪⁭⁪‪‫‪⁪‮‍‫‮‏⁫⁫​‏‭‪‫⁮‏‏⁬⁯‫⁬‫‫⁯​‌⁫‬⁭‍⁬‮(string str, string str)
	{
		return string.Concat(str, str);
	}

	// ​‍‬⁮⁯‫​​​‍‌‭⁫⁫‪‏‎​⁯‏⁮‏‍‮‬⁮‭‮⁯‬⁪‬⁫‌⁬​‪⁪‪‏‮
	// privatescope
	internal static bool u200b‍‬⁮⁯‫​​​‍‌‭⁫⁫‪‏‎​⁯‏⁮‏‍‮‬⁮‭‮⁯‬⁪‬⁫‌⁬​‪⁪‪‏‮(string str, string str)
	{
		return str != str;
	}

	// ‮⁭​‏⁫⁭⁪⁮⁮⁪‎​‌⁭‫‬​⁮⁯⁬⁪‬​⁮‌‮⁮‪⁭‭⁪​‭‎‎‎⁬⁪‬‪‮
	// privatescope
	internal static Encoding u202e⁭​‏⁫⁭⁪⁮⁮⁪‎​‌⁭‫‬​⁮⁯⁬⁪‬​⁮‌‮⁮‪⁭‭⁪​‭‎‎‎⁬⁪‬‪‮(string str)
	{
		return Encoding.GetEncoding(str);
	}

	// ⁫⁫⁫‏‪⁪‮‌‮⁭‌‎⁮‍‬⁭⁭⁯‭‬‏‎⁫‎⁫⁪​⁫‏‫‏⁭‫⁮‪⁫‎‮⁯⁫‮
	// privatescope
	internal static Encoding u206b⁫⁫‏‪⁪‮‌‮⁭‌‎⁮‍‬⁭⁭⁯‭‬‏‎⁫‎⁫⁪​⁫‏‫‏⁭‫⁮‪⁫‎‮⁯⁫‮()
	{
		return Encoding.BigEndianUnicode;
	}

	// ⁬​⁪⁬‬‭⁯⁫⁭​‭⁭⁯‭‌‬⁬⁯⁫⁭⁬‪‭‮⁪‪⁮‫‭⁯‏‫⁯‪⁭‭⁬⁭⁯‭‮
	// privatescope
	internal static string u206c​⁪⁬‬‭⁯⁫⁭​‭⁭⁯‭‌‬⁬⁯⁫⁭⁬‪‭‮⁪‪⁮‫‭⁯‏‫⁯‪⁭‭⁬⁭⁯‭‮(object obj, object obj, object obj)
	{
		return string.Concat(obj, obj, obj);
	}

	// ⁯⁭‍‪⁬‬‌‪⁬⁬⁬‬‎‭⁮‪‌⁭⁬‌‪‮⁪‬⁮‍‫‎⁫‎⁪⁬⁭⁫​‮‭⁮‭⁪‮
	// privatescope
	internal static decimal u206f⁭‍‪⁬‬‌‪⁬⁬⁬‬‎‭⁮‪‌⁭⁬‌‪‮⁪‬⁮‍‫‎⁫‎⁪⁬⁭⁫​‮‭⁮‭⁪‮(decimal num)
	{
		return Math.Ceiling(num);
	}

	// ⁬‭‍‎​‫‏‎⁮⁯‪‬‎‬‭‪‫​‬⁬‪​⁯‌⁮⁬⁭​⁬‌⁯‍​⁭‍​⁪⁮​⁭‮
	// privatescope
	internal static void u206c‭‍‎​‫‏‎⁮⁯‪‬‎‬‭‪‫​‬⁬‪​⁯‌⁮⁬⁭​⁬‌⁯‍​⁭‍​⁪⁮​⁭‮(Array , RuntimeFieldHandle )
	{
		// 
		// Current member / type: System.Void ⁭⁮‮‎‪‮‫‪‍⁬⁬‬‭‮‫⁮‎‎‪‏‌​‭​⁮⁬‭⁫‫‏​⁯⁯⁮‪​‪‌⁮⁭‮::⁬‭‍‎​‫‏‎⁮⁯‪‬‎‬‭‪‫​‬⁬‪​⁯‌⁮⁬⁭​⁬‌⁯‍​⁭‍​⁪⁮​⁭‮(System.Array,System.RuntimeFieldHandle)
		// File path: C:\SDRSharp\Plugins\Tetra\SDRSharp.Tetra.dll
		// 
		// Product version: 0.0.0.0
		// Exception in: System.Void ⁬‭‍‎​‫‏‎⁮⁯‪‬‎‬‭‪‫​‬⁬‪​⁯‌⁮⁬⁭​⁬‌⁯‍​⁭‍​⁪⁮​⁭‮(System.Array,System.RuntimeFieldHandle)
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

	// ‎‬‮‬⁮‍‬‎‍‪‮⁬⁬‏‪‪‮‪⁬‍⁫‍‌‪⁬‫‬‬‎‮‪‮‭⁪‭‭‏‬‪‬‮
	// privatescope
	internal static string u200e‬‮‬⁮‍‬‎‍‪‮⁬⁬‏‪‪‮‪⁬‍⁫‍‌‪⁬‫‬‬‎‮‪‮‭⁪‭‭‏‬‪‬‮(Encoding encoding, byte[] numArray)
	{
		return encoding.GetString(numArray);
	}

	// ‪⁬‍⁯‌⁫​‍‏‍⁮‍‏‬⁪‪​‮⁬⁯⁮​‮⁭‪⁯⁮‏​⁯⁭⁬⁪​⁫⁮‌‮‮‮‮
	// privatescope
	internal static string u202a⁬‍⁯‌⁫​‍‏‍⁮‍‏‬⁪‪​‮⁬⁯⁮​‮⁭‪⁯⁮‏​⁯⁭⁬⁪​⁫⁮‌‮‮‮‮(object obj, object obj)
	{
		return string.Concat(obj, obj);
	}

	static u206d⁮‮‎‪‮‫‪‍⁬⁬‬‭‮‫⁮‎‎‪‏‌​‭​⁮⁬‭⁫‫‏​⁯⁯⁮‪​‪‌⁮⁭‮()
	{
		u206d⁮‮‎‪‮‫‪‍⁬⁬‬‭‮‫⁮‎‎‪‏‌​‭​⁮⁬‭⁫‫‏​⁯⁯⁮‪​‪‌⁮⁭‮.u202e⁫⁭‫⁭‍‫‪​⁯⁫‬⁮‌‬⁭‏‮⁭⁭‮​‬‪⁫‭‫⁮‫⁫‭‫⁯‏‍⁭‌‬⁪‪‮ = new List<Dictionary<int, SdsMessage>>();
		u206d⁮‮‎‪‮‫‪‍⁬⁬‬‭‮‫⁮‎‎‪‏‌​‭​⁮⁬‭⁫‫‏​⁯⁯⁮‪​‪‌⁮⁭‮.u202d‌‏​⁭⁭​‎​‫‬⁬⁯‮‏‌‍‌⁪⁫‬‍‏‭⁬‭‎‪⁪‫⁫‌​‪‪‭‍⁯⁮⁯‮ = 1000;
	}

	public u206d⁮‮‎‪‮‫‪‍⁬⁬‬‭‮‫⁮‎‎‪‏‌​‭​⁮⁬‭⁫‫‏​⁯⁯⁮‪​‪‌⁮⁭‮()
	{
	}
}