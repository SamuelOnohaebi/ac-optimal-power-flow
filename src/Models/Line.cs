public class Line // A line represents a transmission line connecting two buses in the power system,

{
    public int FromBus { get; set; } // Originating bus of transmission line.
    public int ToBus { get; set; } // Termination bus of transmission line.
    public double Resistance { get; set; } // Resistance value of transmission line.
    public double Reactance { get; set; } // Reactance value of transmission line.
}