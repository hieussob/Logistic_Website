using Logistic_Website.Models;
using OfficeOpenXml;

namespace Logistic_Website.Data
{
    public static class TransientData
    {
        public static List<VesselSchedule> FilterVesselChedules;

        public static List<FeeLookup> GetFeeLookups()
        {
            string filePath = Path.Combine(
                Directory.GetCurrentDirectory(),
                "wwwroot",
                "Excel",
                "data.xlsx"
            );
            List<FeeLookup> feeLookups = [];
            if (!File.Exists(filePath))
            {
                return feeLookups;
            }
            FileInfo fileInfo = new(filePath);
            ExcelPackage.License.SetNonCommercialOrganization("My Noncommercial organization");
            using var package = new ExcelPackage(fileInfo);
            ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
            int rowCount = 0;
            for (int row = 4; row <= worksheet.Dimension.Rows; row++)
            {
                if (
                    !string.IsNullOrEmpty(worksheet.Cells[row, 1].Text)
                    || !string.IsNullOrEmpty(worksheet.Cells[row, 2].Text)
                    || !string.IsNullOrEmpty(worksheet.Cells[row, 3].Text)
                    || !string.IsNullOrEmpty(worksheet.Cells[row, 4].Text)
                    || !string.IsNullOrEmpty(worksheet.Cells[row, 5].Text)
                    || !string.IsNullOrEmpty(worksheet.Cells[row, 6].Text)
                    || !string.IsNullOrEmpty(worksheet.Cells[row, 7].Text)
                    || !string.IsNullOrEmpty(worksheet.Cells[row, 8].Text)
                    || !string.IsNullOrEmpty(worksheet.Cells[row, 9].Text)
                    || !string.IsNullOrEmpty(worksheet.Cells[row, 10].Text)
                    || !string.IsNullOrEmpty(worksheet.Cells[row, 11].Text)
                    || !string.IsNullOrEmpty(worksheet.Cells[row, 12].Text)
                )
                {
                    rowCount = row;
                }
            }
            for (int row = 4; row <= rowCount; row++)
            {
                var data = new FeeLookup
                {
                    Name = worksheet.Cells[row, 1].Text,
                    THC = new TerminalHandlingCharge
                    {
                        DC20 = worksheet.Cells[row, 2].Text,
                        DC40 = worksheet.Cells[row, 3].Text,
                        DC45 = worksheet.Cells[row, 4].Text,
                        RFFLOT20 = worksheet.Cells[row, 5].Text,
                        RFFLOT40 = worksheet.Cells[row, 6].Text,
                    },
                    DOFee = new DeliveryOrderFee
                    {
                        Manual = string.IsNullOrEmpty(worksheet.Cells[row, 8].Text) ? "" : worksheet.Cells[row, 7].Text,
                        Electric = worksheet.Cells[row, 8].Text,
                        MergeFee = worksheet.Cells[row, 7].Text,
                    },
                    SealFee = worksheet.Cells[row, 9].Text,
                    ManifestSubmissionFee = worksheet.Cells[row, 10].Text,
                    BLAmendmentFee = worksheet.Cells[row, 11].Text,
                    LatePayment = worksheet.Cells[row, 12].Text,
                };
                feeLookups.Add(data);
            }
            return feeLookups;
        }

        public static List<LiftOnLiftOff> GetLiftOnLiftOffs()
        {
            string filePath = Path.Combine(
                Directory.GetCurrentDirectory(),
                "wwwroot",
                "Excel",
                "data.xlsx"
            );
            List<LiftOnLiftOff> liftOnLiftOffs = [];
            if (!File.Exists(filePath))
            {
                return liftOnLiftOffs;
            }

            FileInfo fileInfo = new(filePath);
            ExcelPackage.License.SetNonCommercialOrganization("My Noncommercial organization");

            using var package = new ExcelPackage(fileInfo);
            ExcelWorksheet worksheet = package.Workbook.Worksheets[1];
            int rowCount = 0;

            for (int row = 4; row <= worksheet.Dimension.Rows; row++)
            {
                for (int col = 1; col <= 10; col++)
                {
                    if (!string.IsNullOrEmpty(worksheet.Cells[row, col].Text))
                    {
                        rowCount = row;
                        break;
                    }
                }
            }

            for (int row = 4; row <= rowCount; row++)
            {
                var data = new LiftOnLiftOff
                {
                    PortDepot = CleanText(worksheet.Cells[row, 1].Text),
                    LadenContainer = new()
                    {
                        Feet20 = CleanText(worksheet.Cells[row, 2].Text),
                        Feet40 = CleanText(worksheet.Cells[row, 3].Text),
                        Feet45 = CleanText(worksheet.Cells[row, 4].Text),
                    },
                    EmptyContainer = new()
                    {
                        Feet20 = CleanText(worksheet.Cells[row, 5].Text),
                        Feet40 = CleanText(worksheet.Cells[row, 6].Text),
                        Feet45 = CleanText(worksheet.Cells[row, 7].Text),
                    },
                    Valid = CleanText(worksheet.Cells[row, 8].Text),
                    Mark = CleanText(worksheet.Cells[row, 9].Text),
                    City = CleanText(worksheet.Cells[row, 10].Text),
                };
                liftOnLiftOffs.Add(data);
            }

            return liftOnLiftOffs;
        }

        public static string CleanText(string? text) =>
                text?.Replace("\r\n", "<br>")
                    .Replace("\n", "<br>")
                    .Replace("\r", "<br>") ?? string.Empty;

        public static List<VesselSchedule> GetScheduleDetails()
        {
            string filePath = Path.Combine(
                Directory.GetCurrentDirectory(),
                "wwwroot",
                "Excel",
                "SCHEDULEDATA.xlsx"
            );
            List<VesselSchedule> dataList = new List<VesselSchedule>();

            if (File.Exists(filePath))
            {
                FileInfo fileInfo = new FileInfo(filePath);
                ExcelPackage.License.SetNonCommercialOrganization("My Noncommercial organization");
                using (var package = new ExcelPackage(fileInfo))
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets[0];

                    int rowCount = 0;
                    for (int row = 2; row <= worksheet.Dimension.Rows; row++)
                    {
                        if (
                            !string.IsNullOrEmpty(worksheet.Cells[row, 1].Text)
                            || !string.IsNullOrEmpty(worksheet.Cells[row, 2].Text)
                            || !string.IsNullOrEmpty(worksheet.Cells[row, 3].Text)
                            || !string.IsNullOrEmpty(worksheet.Cells[row, 4].Text)
                            || !string.IsNullOrEmpty(worksheet.Cells[row, 5].Text)
                            || !string.IsNullOrEmpty(worksheet.Cells[row, 6].Text)
                            || !string.IsNullOrEmpty(worksheet.Cells[row, 7].Text)
                            || !string.IsNullOrEmpty(worksheet.Cells[row, 8].Text)
                            || !string.IsNullOrEmpty(worksheet.Cells[row, 9].Text)
                            || !string.IsNullOrEmpty(worksheet.Cells[row, 10].Text)
                            || !string.IsNullOrEmpty(worksheet.Cells[row, 11].Text)
                            || !string.IsNullOrEmpty(worksheet.Cells[row, 12].Text)
                            || !string.IsNullOrEmpty(worksheet.Cells[row, 13].Text)
                            || !string.IsNullOrEmpty(worksheet.Cells[row, 14].Text)
                        )
                        {
                            rowCount = row;
                        }
                    }

                    for (int row = 2; row <= rowCount; row++)
                    {
                        var data = new VesselSchedule
                        {
                            Id = Convert.ToInt32(worksheet.Cells[row, 1].Value),
                            Origin = worksheet.Cells[row, 2].Text,
                            Destination = worksheet.Cells[row, 3].Text,
                            Line = worksheet.Cells[row, 4].Text,
                            Service = worksheet.Cells[row, 5].Text,
                            Vessel = worksheet.Cells[row, 6].Text,
                            CutOff = worksheet.Cells[row, 7].Text,
                            ETD = worksheet.Cells[row, 8].Text,
                            Hub = worksheet.Cells[row, 9].Text,
                            ETAHub = worksheet.Cells[row, 10].Text,
                            MV = worksheet.Cells[row, 11].Text,
                            ETDHub = worksheet.Cells[row, 12].Text,
                            ETA = worksheet.Cells[row, 13].Text,
                            TransitTime = worksheet.Cells[row, 14].Text,
                        };

                        dataList.Add(data);
                    }
                }
            }
            return dataList;
        }

        public static List<Stock> GetStocks()
        {
            string filePath = Path.Combine(
                Directory.GetCurrentDirectory(),
                "wwwroot",
                "Excel",
                "data.xlsx"
            );
            List<Stock> stocks = new List<Stock>();

            if (File.Exists(filePath))
            {
                FileInfo fileInfo = new FileInfo(filePath);
                ExcelPackage.License.SetNonCommercialOrganization("My Noncommercial organization");
                using (var package = new ExcelPackage(fileInfo))
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets[2];

                    int rowCount = 0;
                    for (int row = 3; row <= worksheet.Dimension.Rows; row++)
                    {
                        if (
                            !string.IsNullOrEmpty(worksheet.Cells[row, 1].Text)
                            || !string.IsNullOrEmpty(worksheet.Cells[row, 2].Text)
                            || !string.IsNullOrEmpty(worksheet.Cells[row, 3].Text)
                            || !string.IsNullOrEmpty(worksheet.Cells[row, 4].Text)
                            || !string.IsNullOrEmpty(worksheet.Cells[row, 5].Text)
                            || !string.IsNullOrEmpty(worksheet.Cells[row, 6].Text)
                            || !string.IsNullOrEmpty(worksheet.Cells[row, 7].Text)
                            || !string.IsNullOrEmpty(worksheet.Cells[row, 8].Text)
                            || !string.IsNullOrEmpty(worksheet.Cells[row, 9].Text)
                        )
                        {
                            rowCount = row;
                        }
                    }

                    for (int row = 3; row <= rowCount; row++)
                    {
                        var data = new Stock
                        {
                            Name = worksheet.Cells[row, 1].Text,
                            Type = worksheet.Cells[row, 2].Text,
                            Address = worksheet.Cells[row, 3].Text,
                            Area = Convert.ToDouble(worksheet.Cells[row, 4].Value),
                            Telephone = worksheet.Cells[row, 5].Text,
                            Email = worksheet.Cells[row, 6].Text,
                            Image = worksheet.Cells[row, 8].Text,
                            Province = worksheet.Cells[row, 9].Text,
                        };

                        stocks.Add(data);
                    }
                }
            }
            return stocks;
        }
    }
}