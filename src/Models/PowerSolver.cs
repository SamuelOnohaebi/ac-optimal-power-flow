using System;
using System.Collections.Generic;
using System.Numerics;

public class PowerSolver
{
    public int BusNum { get; set; }
    public double SpecifiedP { get; set; }
    public double CalculatedP { get; set; }
    public double DeltaP { get; set; }

    public double SpecifiedQ { get; set; }
    public double CalculatedQ { get; set; }
    public double DeltaQ { get; set; }
}