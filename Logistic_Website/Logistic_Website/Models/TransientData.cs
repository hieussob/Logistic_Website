namespace Logistic_Website.Models
{
    public static class TransientData
    {
        public static List<VesselSchedule> GetScheduleDetails()
        {
            return new List<VesselSchedule>()
                {
                    new VesselSchedule { Id = 1, Origin="HAIPHONG", Destination="SINGAPORE", Line = "YANGMING", Service = "DIRECT", Vessel = "YM HEIGHT 039S", CutOff = "2025-04-12 11:00:00", ETD = "15/04/2025", ETA = "20/04/2025", TransitTime = "5" },
                    new VesselSchedule { Id = 2, Origin="HAIPHONG", Destination="SINGAPORE", Line = "CNC", Service = "DIRECT", Vessel = "CMA CGM VISBY 5IU9Y51NC", CutOff = "2025-04-14 16:00:00", ETD = "16/04/2025", ETA = "20/04/2025", TransitTime = "4" },
                    new VesselSchedule { Id = 3, Origin="HAIPHONG", Destination="SINGAPORE", Line = "CMA-CGM", Service = "DIRECT", Vessel = "CMA CGM VISBY 5IU9Y51MA", CutOff = "2025-04-14 16:00:00", ETD = "16/04/2025", ETA = "20/04/2025", TransitTime = "4" },
                    new VesselSchedule { Id = 4, Origin="HAIPHONG", Destination="SINGAPORE", Line = "COSCO", Service = "DIRECT", Vessel = "CMA CGM VISBY 5IU9Y51NC", CutOff = "2025-04-15 17:00:00", ETD = "17/04/2025", ETA = "21/04/2025", TransitTime = "4" },
                    new VesselSchedule { Id = 5, Origin="HAIPHONG", Destination="SINGAPORE", Line = "MSC", Service = "DIRECT", Vessel = "MSC MAKALU III HD516A", CutOff = "2025-04-15 17:00:00", ETD = "17/04/2025", ETA = "21/04/2025", TransitTime = "4" },
                    new VesselSchedule { Id = 6, Origin="HAIPHONG", Destination="SINGAPORE", Line = "CNC", Service = "DIRECT", Vessel = "SINAR SULAWESI 5IU9WW1NC", CutOff = "2025-04-16 16:00:00", ETD = "18/04/2025", ETA = "22/04/2025", TransitTime = "4" },
                    new VesselSchedule { Id = 7, Origin="HAIPHONG", Destination="SINGAPORE", Line = "SAMUDERA", Service = "DIRECT", Vessel = "SINAR SULAWESI 026S", CutOff = "2025-04-16 16:00:00", ETD = "18/04/2025", ETA = "22/04/2025", TransitTime = "4" },
                    new VesselSchedule { Id = 8, Origin="HAIPHONG", Destination="SINGAPORE", Line = "CMA-CGM", Service = "DIRECT", Vessel = "CMA CGM VISBY 5IU9Y51MA", CutOff = "2025-04-16 16:00:00", ETD = "18/04/2025", ETA = "21/04/2025", TransitTime = "3" },
                    new VesselSchedule { Id = 9, Origin="HAIPHONG", Destination="SINGAPORE", Line = "ONE", Service = "DIRECT", Vessel = "SINAR SULAWESI 026S", CutOff = "2025-04-16 16:00:00", ETD = "18/04/2025", ETA = "21/04/2025", TransitTime = "3" },
                    new VesselSchedule { Id = 10, Origin="HAIPHONG", Destination="SINGAPORE", Line = "Hapag-Lloyd", Service = "DIRECT", Vessel = "ULSAN 516S", CutOff = "2025-04-16 10:00:00", ETD = "18/04/2025", ETA = "21/04/2025", TransitTime = "3" },
                    new VesselSchedule { Id = 11, Origin="HAIPHONG", Destination="SINGAPORE", Line = "Evergreen", Service = "DIRECT", Vessel = "EVER WISE 0417 003S", CutOff = "2025-04-17 10:00:00", ETD = "19/04/2025", ETA = "01/05/2025", TransitTime = "12" },
                    new VesselSchedule { Id = 12, Origin="HAIPHONG", Destination="SINGAPORE", Line = "IAL", Service = "DIRECT", Vessel = "SEASPAN OSAKA E023", CutOff = "2025-04-17 10:00:00", ETD = "19/04/2025", ETA = "01/05/2025", TransitTime = "12" },
                    new VesselSchedule { Id = 13, Origin="HAIPHONG", Destination="SINGAPORE", Line = "IAL", Service = "DIRECT", Vessel = "WAN HAI 361 W023", CutOff = "2025-04-17 10:00:00", ETD = "20/04/2025", ETA = "04/05/2025", TransitTime = "14" },
                    new VesselSchedule { Id = 14, Origin="HAIPHONG", Destination="SINGAPORE", Line = "WANHAI", Service = "DIRECT", Vessel = "WAN HAI 361 W023", CutOff = "2025-04-17 10:00:00", ETD = "20/04/2025", ETA = "04/05/2025", TransitTime = "14" },
                    new VesselSchedule { Id = 15, Origin="HAIPHONG", Destination="SINGAPORE", Line = "PIL", Service = "DIRECT", Vessel = "KOTA NAZAR 0368S", CutOff = "2025-04-19 10:00:00", ETD = "21/04/2025", ETA = "25/04/2025", TransitTime = "5" },
                    new VesselSchedule { Id = 16, Origin="HAIPHONG", Destination="SINGAPORE", Line = "CMA-CGM", Service = "DIRECT", Vessel = "INCEDA 5IU2AS1MA", CutOff = "2025-04-18 16:00:00", ETD = "21/04/2025", ETA = "26/04/2025", TransitTime = "5" },
                    new VesselSchedule { Id = 17, Origin="HAIPHONG", Destination="SINGAPORE", Line = "SAMUDERA", Service = "DIRECT", Vessel = "INCEDA 019S", CutOff = "2025-04-18 16:00:00", ETD = "21/04/2025", ETA = "26/04/2025", TransitTime = "5" },
                    new VesselSchedule { Id = 18, Origin="HAIPHONG", Destination="SINGAPORE", Line = "CNC", Service = "DIRECT", Vessel = "INCEDA 5IU2AS1NC", CutOff = "2025-04-18 16:00:00", ETD = "21/04/2025", ETA = "26/04/2025", TransitTime = "5" },
                    new VesselSchedule { Id = 19, Origin="HAIPHONG", Destination="SINGAPORE", Line = "COSCO", Service = "DIRECT", Vessel = "HANSA COLOMBO 054S", CutOff = "2025-04-18 17:00:00", ETD = "21/04/2025", ETA = "27/04/2025", TransitTime = "6" },
                    new VesselSchedule { Id = 20, Origin="HAIPHONG", Destination="SINGAPORE", Line = "ONE", Service = "DIRECT", Vessel = "INCEDA 019S", CutOff = "2025-04-18 17:00:00", ETD = "21/04/2025", ETA = "26/04/2025", TransitTime = "5" },
                    new VesselSchedule { Id = 21, Origin="HAIPHONG", Destination="SINGAPORE", Line = "WANHAI", Service = "DIRECT", Vessel = "SEASPAN OSAKA E023", CutOff = "2025-04-19 10:00:00", ETD = "22/04/2025", ETA = "06/05/2025", TransitTime = "14" },
                    new VesselSchedule { Id = 22, Origin="HAIPHONG", Destination="SINGAPORE", Line = "ONE", Service = "DIRECT", Vessel = "HAIAN DELL 014S", CutOff = "2025-04-21 11:00:00", ETD = "23/04/2025", ETA = "28/04/2025", TransitTime = "5" },
                    new VesselSchedule { Id = 23, Origin="HAIPHONG", Destination="SINGAPORE", Line = "MSC", Service = "DIRECT", Vessel = "MSC LARA III HD516A", CutOff = "2025-04-21 17:00:00", ETD = "24/04/2025", ETA = "30/04/2025", TransitTime = "6" },
                    new VesselSchedule { Id = 24, Origin="HAIPHONG", Destination="SINGAPORE", Line = "OOCL", Service = "DIRECT", Vessel = "HANSA COLOMBO 054S", CutOff = "2025-04-22 17:00:00", ETD = "24/04/2025", ETA = "27/04/2025", TransitTime = "3" },
                    new VesselSchedule { Id = 25, Origin="HAIPHONG", Destination="SINGAPORE", Line = "WANHAI", Service = "DIRECT", Vessel = "XIN WEN ZHOU E169", CutOff = "2025-04-23 17:00:00", ETD = "25/04/2025", ETA = "09/05/2025", TransitTime = "14" },
                    new VesselSchedule { Id = 26, Origin="HAIPHONG", Destination="SINGAPORE", Line = "PIL", Service = "DIRECT", Vessel = "KOTA NEKAD 0210S", CutOff = "2025-04-23 17:00:00", ETD = "25/04/2025", ETA = "02/05/2025", TransitTime = "7" },
                    new VesselSchedule { Id = 27, Origin="HAIPHONG", Destination="SINGAPORE", Line = "SAMUDERA", Service = "DIRECT", Vessel = "CMA CGM VISBY 5IU9ZE1NC", CutOff = "2025-04-23 17:00:00", ETD = "25/04/2025", ETA = "29/04/2025", TransitTime = "4" },
                    new VesselSchedule { Id = 28, Origin="HAIPHONG", Destination="SINGAPORE", Line = "IAL", Service = "DIRECT", Vessel = "XIN WEN ZHOU E169", CutOff = "2025-04-23 17:00:00", ETD = "25/04/2025", ETA = "09/05/2025", TransitTime = "14" },
                    new VesselSchedule { Id = 29, Origin="HAIPHONG", Destination="SINGAPORE", Line = "IAL", Service = "DIRECT", Vessel = "WAN HAI 510 E187", CutOff = "2025-04-23 17:00:00", ETD = "25/04/2025", ETA = "12/05/2025", TransitTime = "17" }
                };
        }

        public static List<VesselSchedule> FilterVesselChedules;
        
    }
}
