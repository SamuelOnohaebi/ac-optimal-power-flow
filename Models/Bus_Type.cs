public enum Bus_Type // A bus is a node in the power system where one or more components are connected, 
// this enumeration defines the type of bus based on its characteristics and the role it plays in the power system.
{
    Ref_Bus, // The bus where voltage magnitude and phase angle are specified.
    PV_Bus, // Buses where active power generation and voltage magnitude are specified.
    PQ_Bus //  Buses where active power and reactive power are specified (acting as either a load or constant generation). 
}