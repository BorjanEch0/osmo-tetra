using System;

namespace SDRSharp.Tetra
{
	public enum LocationShapeType
	{
		No_shape,
		Location_point,
		Location_circle,
		Location_ellipse,
		Location_point_with_altitude,
		Location_circle_with_altitude,
		Location_ellipse_with_altitude,
		Location_circle_with_altitude_and_altitude_uncertainty,
		Location_ellipse_with_altitude_and_altitude_uncertainty,
		Location_arc,
		Location_point_and_position_error,
		Reserved_12,
		Reserved_13,
		Reserved_14,
		Reserved_15,
		Location_shape_extension
	}
}