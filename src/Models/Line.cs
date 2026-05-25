public class Line // A line represents a transmission line connecting two buses in the power system,

{
    public int FromBus { get; set; } // Originating bus of transmission line.
    public int ToBus { get; set; } // Termination bus of transmission line.
    public double ResistancePU { get; set; } // Resistance value of transmission line.
    public double ReactancePU { get; set; } // Reactance value of transmission line.
    public double ChargingPU { get; set; } // Charging susceptance value of the transmission line.
}