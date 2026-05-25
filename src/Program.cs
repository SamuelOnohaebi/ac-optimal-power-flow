using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

class Program
{
    static void Main()
    {
        var buses = LoadBusTable("../datasets/5_bus.csv");

        foreach (var bus in buses)
        {
            Console.WriteLine(
                $"Bus {bus.BusNum} | Type: {bus.Type} | V: {bus.VoltagePU} p.u. | Angle: {bus.PhaseAngle}° | Net P: {bus.NetMW} MW | Net Q: {bus.NetMvar} Mvar"
            );
        }
    }

    static List<Bus> LoadBusTable(string filePath)
    {
        var buses = new List<Bus>();

        string[] lines = File.ReadAllLines(filePath);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] columns = lines[i].Split(',');

            var bus = new Bus
            {
                BusNum = int.Parse(columns[0]),
                Type = Enum.Parse<BusType>(columns[1]),
                VoltagePU = double.Parse(columns[2], CultureInfo.InvariantCulture),
                PhaseAngle = double.Parse(columns[3], CultureInfo.InvariantCulture),
                GenerationMW = double.Parse(columns[4], CultureInfo.InvariantCulture),
                GenerationMvar = double.Parse(columns[5], CultureInfo.InvariantCulture),
                LoadMW = double.Parse(columns[6], CultureInfo.InvariantCulture),
                LoadMvar = double.Parse(columns[7], CultureInfo.InvariantCulture)
            };

            buses.Add(bus);
        }

        return buses;
    }
}