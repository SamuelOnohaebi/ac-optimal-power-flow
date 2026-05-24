public enum Bus_Type // A bus is a node in the power system where one or more components are connected.
{
    Ref_Bus, // The bus where voltage magnitude and phase angle are specified.
    PV_Bus, // Buses where active power generation and voltage magnitude are specified.
    PQ_Bus //  Buses where active power and reactive power are specified (acting as either a load or constant generation). 
}