using OfficeOpenXml;

namespace Logistic_Website.Models
{
    public static class TransientData
    {
        public static List<VesselSchedule> GetScheduleDetails()
        {
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Excel", "SCHEDULEDATA.xlsx");
            List<VesselSchedule> dataList = new List<VesselSchedule>();

            if (System.IO.File.Exists(filePath))
            {
                FileInfo fileInfo = new FileInfo(filePath);
                ExcelPackage.License.SetNonCommercialOrganization("My Noncommercial organization");
                using (var package = new ExcelPackage(fileInfo))
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets[0];

                    int rowCount = 0;
                    for (int row = 2; row <= worksheet.Dimension.Rows; row++)
                    {
                        if (!string.IsNullOrEmpty(worksheet.Cells[row, 1].Text) ||
                            !string.IsNullOrEmpty(worksheet.Cells[row, 2].Text) ||
                            !string.IsNullOrEmpty(worksheet.Cells[row, 3].Text) ||
                            !string.IsNullOrEmpty(worksheet.Cells[row, 4].Text) ||
                            !string.IsNullOrEmpty(worksheet.Cells[row, 5].Text) ||
                            !string.IsNullOrEmpty(worksheet.Cells[row, 6].Text) ||
                            !string.IsNullOrEmpty(worksheet.Cells[row, 7].Text) ||
                            !string.IsNullOrEmpty(worksheet.Cells[row, 8].Text) ||
                            !string.IsNullOrEmpty(worksheet.Cells[row, 9].Text) ||
                            !string.IsNullOrEmpty(worksheet.Cells[row, 10].Text) ||
                            !string.IsNullOrEmpty(worksheet.Cells[row, 11].Text) ||
                            !string.IsNullOrEmpty(worksheet.Cells[row, 12].Text) ||
                            !string.IsNullOrEmpty(worksheet.Cells[row, 13].Text) ||
                            !string.IsNullOrEmpty(worksheet.Cells[row, 14].Text))
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
                            TransitTime = worksheet.Cells[row, 14].Text
                        };

                        dataList.Add(data);
                    }
                }
            }
            return dataList;

        }



        public static List<VesselSchedule> FilterVesselChedules;

    }
}
