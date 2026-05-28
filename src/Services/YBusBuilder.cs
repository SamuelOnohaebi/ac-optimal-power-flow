using System;
using System.Collections.Generic;
using System.Numerics;

public static class YBusBuilder
{
    public static Complex[,] BuildYBus(List<Bus> buses, List<Line> lines)
    {
        int numberOfBuses = buses.Count;

        Complex[,] yBus = new Complex[numberOfBuses, numberOfBuses];

        foreach (var line in lines)
        {
            int from = line.FromBus - 1;
            int to = line.ToBus - 1;

            Complex impedance = new Complex(line.ResistancePU, line.ReactancePU);

            Complex admittance = Complex.One / impedance;

            Complex charging = new Complex(0, line.ChargingPU / 2);

            yBus[from, from] += admittance + charging;
            yBus[to, to] += admittance + charging;

            yBus[from, to] -= admittance;
            yBus[to, from] -= admittance;
        }

        return yBus;
    }

    public static void PrintYBus(Complex[,] yBus)
    {
        int size = yBus.GetLength(0);

        Console.WriteLine("\nY-Bus Matrix:");

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                Console.Write($"{yBus[i, j].Real:F4} + j{yBus[i, j].Imaginary:F4}\t");
            }

            Console.WriteLine();
        }
    }
}