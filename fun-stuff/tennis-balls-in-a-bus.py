import math


def estimate_tennis_balls_in_bus_meters():
    """Estimates the number of tennis balls that can fit into a bus, using meters."""

    print("Let's estimate how many tennis balls fit in a bus, step by step (using meters)!")

    # Step 1: Define the type of bus
    bus_type = "regular school bus"
    print(f"\nStep 1: We're considering a {bus_type}.")

    # Step 2: Estimate the inside dimensions of the bus (in meters)
    bus_length_meters = 7.62  # 25 feet * 0.3048 meters/foot
    bus_width_meters = 2.13  # 7 feet * 0.3048 meters/foot
    bus_height_meters = 1.83  # 6 feet * 0.3048 meters/foot
    bus_volume_cubic_meters = bus_length_meters * bus_width_meters * bus_height_meters
    print("Step 2: Estimating the bus dimensions:")
    print(f"   Length: {bus_length_meters:.2f} meters")
    print(f"   Width: {bus_width_meters:.2f} meters")
    print(f"   Height: {bus_height_meters:.2f} meters")
    print(f"   Estimated bus volume: {bus_volume_cubic_meters:.2f} cubic meters")

    # Step 3: Define the size of a tennis ball (diameter in meters)
    tennis_ball_diameter_meters = 0.068  # 2.7 inches * 0.0254 meters/inch (max diameter)
    tennis_ball_radius_meters = tennis_ball_diameter_meters / 2
    # Calculate the volume of a tennis ball using the sphere volume formula
    tennis_ball_volume_cubic_meters = (4 / 3) * math.pi * (tennis_ball_radius_meters ** 3)
    print("\nStep 3: Defining the tennis ball size:")
    print(f"   Diameter: {tennis_ball_diameter_meters:.3f} meters")
    print(f"   Radius: {tennis_ball_radius_meters:.3f} meters")
    print(f"   Estimated volume of one tennis ball: {tennis_ball_volume_cubic_meters:.5f} cubic meters")

    # Step 4: No conversion needed, volumes are already in cubic meters

    # Step 5: Calculate the theoretical number of tennis balls (ignoring packing efficiency)
    theoretical_number_of_balls = bus_volume_cubic_meters / tennis_ball_volume_cubic_meters
    print("\nStep 5: Calculating the theoretical number of tennis balls (no gaps):")
    print(f"   Theoretical number of balls: {theoretical_number_of_balls:.2f}")

    # Step 6: Account for packing efficiency (estimate 70%)
    packing_efficiency = 0.70
    estimated_number_of_balls = theoretical_number_of_balls * packing_efficiency
    print(f"\nStep 6: Accounting for packing efficiency (using an estimate of {packing_efficiency * 100}%):")
    print(f"   Estimated number of tennis balls that can fit: {int(estimated_number_of_balls)}")

    return int(estimated_number_of_balls)


# Run the function to see the output
if __name__ == "__main__":
    estimate_tennis_balls_in_bus_meters()
