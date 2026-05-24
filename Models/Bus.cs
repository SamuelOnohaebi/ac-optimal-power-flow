public class Bus // A bus is a node in the power system where one or more components are connected.
{
    public int Bus_Number { get; set; } // Bus ID for each bus.
    public Bus_Type Type { get; set; } // Bus type.
    public double Voltage_pu { get; set; } // Voltage magnitude per unit.
    public double phase_angle { get; set; } // Voltage phase angle.
    public double Generation_MW { get; set; } // Active power generated.
    public double Generation_MVAR { get; set; } // Reactive power generated.
    public double Load_MW { get; set; } // Active load consumed.
    public double Load_MVAR { get; set; } // Reactive load consumed.
    public double Net_MW { get; set; } // Net active power (Gen MW - Load MW).
    public double Net_MVAR { get; set; } // Net reactive power (Gen MWAR - Load MWAR).
}