using System;
using System.Collections.Generic;
using System.Numerics;

public static class PowerCalculator
{
    public static List<PowerSolver> Calculate(List<Bus> buses, Complex[,] yBus, double baseMVA)
    {
        var results = new List<PowerSolver>();

        for (int i = 0; i < buses.Count; i++)
        {
            var busI = buses[i];

            double vi = busI.VoltagePU;
            double thetaI = DegreesToRadians(busI.PhaseAngle);

            double calculatedP = 0.0;
            double calculatedQ = 0.0;

            for (int j = 0; j < buses.Count; j++)
            {
                var busJ = buses[j];

                double vj = busJ.VoltagePU;
                double thetaJ = DegreesToRadians(busJ.PhaseAngle);

                double gij = yBus[i, j].Real;
                double bij = yBus[i, j].Imaginary;

                double angleDifference = thetaI - thetaJ;

                calculatedP += vi * vj *
                    (gij * Math.Cos(angleDifference) + bij * Math.Sin(angleDifference));

                calculatedQ += vi * vj *
                    (gij * Math.Sin(angleDifference) - bij * Math.Cos(angleDifference));
            }

            double specifiedP = busI.NetMW / baseMVA;
            double specifiedQ = busI.NetMvar / baseMVA;

            results.Add(new PowerSolver
            {
                BusNum = busI.BusNum,

                SpecifiedP = specifiedP,
                CalculatedP = calculatedP,
                DeltaP = specifiedP - calculatedP,

                SpecifiedQ = specifiedQ,
                CalculatedQ = calculatedQ,
                DeltaQ = specifiedQ - calculatedQ
            });
        }

        return results;
    }

    private static double DegreesToRadians(double degrees)
    {
        return degrees * Math.PI / 180.0;
    }
}