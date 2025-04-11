namespace Logistic_Website.Models;

public class LiftOnLiftOff
{
    public string PortDepot { get; set; }
    public ShipContainer LadenContainer { get; set; }
    public ShipContainer EmptyContainer { get; set; }
    public string Valid { get; set; }
    public string Mark { get; set; }
    public string City { get; set; }
}

public class ShipContainer
{
    public string Feet20 { get; set; }
    public string Feet40 { get; set; }
    public string Feet45 { get; set; }
}