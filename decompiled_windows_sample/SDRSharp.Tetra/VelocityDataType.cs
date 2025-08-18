using System;

namespace SDRSharp.Tetra
{
	public enum VelocityDataType
	{
		No_velocity_information,
		Horizontal_velocity,
		Horizontal_velocity_with_uncertainty,
		Horizontal_velocity_and_vertical_velocity,
		Horizontal_velocity_and_vertical_velocity_with_uncertainty,
		Horizontal_velocity_with_direction_of_travel_extended,
		Horizontal_velocity_with_direction_of_travel_extended_and_uncertainty,
		Horizontal_velocity_and_vertical_velocity_with_direction_of_travel_extended_and_uncertainty
	}
}