public class Bus // A bus is a node in the power system where one or more components are connected.
{
    public int BusNum { get; set; } // Bus ID for each bus.
    public BusType Type { get; set; } // Bus type.
    public double VoltagePU { get; set; } // Voltage magnitude per unit.
    public double PhaseAngle { get; set; } // Voltage phase angle.
    public double GenerationMW { get; set; } // Active power generated.
    public double GenerationMvar { get; set; } // Reactive power generated.
    public double LoadMW { get; set; } // Active load consumed.
    public double LoadMvar { get; set; } // Reactive load consumed.
    public double NetMW => GenerationMW - LoadMW; // Net active power (Gen MW - Load MW).
    public double NetMvar => GenerationMvar - LoadMvar; // Net reactive power (Gen MWAR - Load MWAR).
}