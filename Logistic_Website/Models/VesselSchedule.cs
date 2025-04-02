namespace Logistic_Website.Models
{
    public class VesselSchedule
    {
        public int Id { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
        public string Line { get; set; }
        public string Service { get; set; }
        public string Vessel { get; set; }
        public string CutOff { get; set; }
        public string ETDHPH { get; set; }
        public string POD { get; set; }
        public string MV { get; set; }
        public string ETD { get; set; }
        public string ETA { get; set; }
        public string TransitTime { get; set; }
        public string ETSIN { get; set; }
    }
}
