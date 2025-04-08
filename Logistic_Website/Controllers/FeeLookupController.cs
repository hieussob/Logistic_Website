using Logistic_Website.Models;
using Microsoft.AspNetCore.Mvc;

namespace Logistic_Website.Controllers
{
    public class FeeLookupController : Controller
    {
        public IActionResult Index()
        {
            var feeLookup = GenerateFeeLookup();
            return View(feeLookup);
        }

        [HttpPost]
        public IActionResult Search([FromBody] List<string> selectedNames)
        {
            var feeLookup = GenerateFeeLookup();
            if (selectedNames == null || selectedNames.Count == 0)
            {
                return PartialView("_FeeTable", feeLookup);
            }
            var result = feeLookup.Where(f => selectedNames.Contains(f.Name)).ToList();
            return PartialView("_FeeTable", result);
        }

        private static List<FeeLookup> GenerateFeeLookup()
        {
            return
            [
                new FeeLookup
                {
                    Name = "ONE",
                    THC = new TerminalHandlingCharge
                    {
                        DC20 = "2.800.000",
                        DC40 = "4.500.000",
                        DC45 = "5.050.000",
                        RFFLOT20 = "3.950.000",
                        RFFLOT40 = "5.600.000",
                    },
                    DOFee = new DeliveryOrderFee { Manual = "1.000.000", Electric = "900.000" },
                    SealFee = "210.000",
                    ManifestSubmissionFee = "950.000",
                    BLAmendmentFee = "500.000",
                    LatePayment = "1.000.000",
                },
                new FeeLookup
                {
                    Name = "EVERGREEN",
                    THC = new TerminalHandlingCharge
                    {
                        DC20 = "3.050.000",
                        DC40 = "4.700.000",
                        DC45 = "5.050.000",
                        RFFLOT20 = "4.730.000",
                        RFFLOT40 = "6.580.000",
                    },
                    DOFee = new DeliveryOrderFee { Manual = "900.000", Electric = "800.000" },
                    SealFee = "250.000",
                    BLAmendmentFee = "1.080.000",
                    LatePayment = "500.000",
                },
                new FeeLookup
                {
                    Name = "ZIM",
                    THC = new TerminalHandlingCharge
                    {
                        DC20 = "2.850.000",
                        DC40 = "4.417.500",
                        DC45 = "5.700.000",
                        RFFLOT20 = "3.610.000",
                        RFFLOT40 = "5.510.000",
                    },
                    DOFee = new DeliveryOrderFee
                    {
                        Manual = "1.000.000",
                        Electric = "1.250.000",
                        MergeFee = "",
                    },
                    SealFee = "",
                    ManifestSubmissionFee = "1.250.000",
                    BLAmendmentFee = "750.000",
                    LatePayment = "1.500.000",
                },
                new FeeLookup
                {
                    Name = "MSC",
                    THC = new TerminalHandlingCharge
                    {
                        DC20 = "2.990.000",
                        DC40 = "4.530.000",
                        DC45 = "5.310.000",
                        RFFLOT20 = "3.710.000",
                        RFFLOT40 = "6.120.000",
                    },
                    DOFee = new DeliveryOrderFee
                    {
                        Manual = "",
                        Electric = "",
                        MergeFee = "972.000",
                    },
                    SealFee = "200.000",
                    ManifestSubmissionFee = "",
                    BLAmendmentFee = "756.000",
                    LatePayment = "",
                },
                new FeeLookup
                {
                    Name = "OOCL",
                    THC = new TerminalHandlingCharge
                    {
                        DC20 = "3.250.000",
                        DC40 = "5.070.000",
                        DC45 = "6.370.000",
                        RFFLOT20 = "4.160.000",
                        RFFLOT40 = "6.500.000",
                    },
                    DOFee = new DeliveryOrderFee
                    {
                        Manual = "950.000",
                        Electric = "850.000",
                        MergeFee = "",
                    },
                    SealFee = "208.000",
                    ManifestSubmissionFee = "1.430.000",
                    BLAmendmentFee = "600.000",
                    LatePayment = "650.000",
                },
                new FeeLookup
                {
                    Name = "CMA-CGM",
                    THC = new TerminalHandlingCharge
                    {
                        DC20 = "2.900.000",
                        DC40 = "4.400.000",
                        DC45 = "5.150.000",
                        RFFLOT20 = "3.600.000",
                        RFFLOT40 = "5.750.000",
                    },
                    DOFee = new DeliveryOrderFee
                    {
                        Manual = "1.050.000",
                        Electric = "950.000",
                        MergeFee = "",
                    },
                    SealFee = "",
                    ManifestSubmissionFee = "880.000",
                    BLAmendmentFee = "930.000",
                    LatePayment = "600.000",
                },
                new FeeLookup
                {
                    Name = "TS LINES",
                    THC = new TerminalHandlingCharge
                    {
                        DC20 = "3.372.500",
                        DC40 = "5.130.000",
                        DC45 = "",
                        RFFLOT20 = "4.750.000",
                        RFFLOT40 = "7.315.000",
                    },
                    DOFee = new DeliveryOrderFee
                    {
                        Manual = "",
                        Electric = "",
                        MergeFee = "1.000.000",
                    },
                    SealFee = "199.500",
                    ManifestSubmissionFee = "627.000",
                    BLAmendmentFee = "",
                    LatePayment = "500.000",
                },
                new FeeLookup
                {
                    Name = "YANGMING",
                    THC = new TerminalHandlingCharge
                    {
                        DC20 = "3.043.200",
                        DC40 = "4.677.850",
                        DC45 = "",
                        RFFLOT20 = "4.076.400",
                        RFFLOT40 = "6.111.600",
                    },
                    DOFee = new DeliveryOrderFee
                    {
                        Manual = "",
                        Electric = "",
                        MergeFee = "950.000",
                    },
                    SealFee = "205.000",
                    ManifestSubmissionFee = "650.000",
                    BLAmendmentFee = "1.150.000",
                    LatePayment = "400.000",
                },
                new FeeLookup
                {
                    Name = "MMAERSK",
                    THC = new TerminalHandlingCharge
                    {
                        DC20 = "3.050.000",
                        DC40 = "4.700.000",
                        DC45 = "5.750.000",
                        RFFLOT20 = "3.950.000",
                        RFFLOT40 = "6.050.000",
                    },
                    DOFee = new DeliveryOrderFee
                    {
                        Manual = "",
                        Electric = "",
                        MergeFee = "950.000",
                    },
                    SealFee = "200.000",
                    ManifestSubmissionFee = "",
                    BLAmendmentFee = "900.000",
                    LatePayment = "500.000",
                },
                new FeeLookup
                {
                    Name = "SITC",
                    THC = new TerminalHandlingCharge
                    {
                        DC20 = "3.200.000",
                        DC40 = "4.800.000",
                        DC45 = "6.000.000",
                        RFFLOT20 = "4.000.000",
                        RFFLOT40 = "6.000.000",
                    },
                    DOFee = new DeliveryOrderFee
                    {
                        Manual = "",
                        Electric = "",
                        MergeFee = "1.000.000",
                    },
                    SealFee = "200.000",
                    ManifestSubmissionFee = "",
                    BLAmendmentFee = "",
                    LatePayment = "",
                },
                new FeeLookup
                {
                    Name = "HMM",
                    THC = new TerminalHandlingCharge
                    {
                        DC20 = "3.036.000",
                        DC40 = "4.554.000",
                        DC45 = "5.221.700",
                        RFFLOT20 = "3.710.000",
                        RFFLOT40 = "5.819.000",
                    },
                    DOFee = new DeliveryOrderFee
                    {
                        Manual = "",
                        Electric = "",
                        MergeFee = "920.000",
                    },
                    SealFee = "190.000",
                    ManifestSubmissionFee = "USD 30",
                    BLAmendmentFee = "",
                    LatePayment = "",
                },
                new FeeLookup
                {
                    Name = "IAL",
                    THC = new TerminalHandlingCharge
                    {
                        DC20 = "USD 137.75",
                        DC40 = "USD 209",
                        DC45 = "",
                        RFFLOT20 = "USD 203.3",
                        RFFLOT40 = "USD 313.5",
                    },
                    DOFee = new DeliveryOrderFee
                    {
                        Manual = "",
                        Electric = "",
                        MergeFee = "1.097.250",
                    },
                    SealFee = "USD 8.55",
                    ManifestSubmissionFee = "627.000",
                    BLAmendmentFee = "",
                    LatePayment = "",
                },
                new FeeLookup
                {
                    Name = "SINO LINE",
                    THC = new TerminalHandlingCharge
                    {
                        DC20 = "USD 130",
                        DC40 = "USD 203",
                        DC45 = "USD 203",
                        RFFLOT20 = "USD 203",
                        RFFLOT40 = "USD 304",
                    },
                    DOFee = new DeliveryOrderFee
                    {
                        Manual = "",
                        Electric = "",
                        MergeFee = "800.000",
                    },
                    SealFee = "USD 8",
                    ManifestSubmissionFee = "USD 30",
                    BLAmendmentFee = "",
                    LatePayment = "",
                },
                new FeeLookup
                {
                    Name = "KTMC",
                    THC = new TerminalHandlingCharge
                    {
                        DC20 = " USD 138",
                        DC40 = "USD 208",
                        DC45 = "USD 208",
                        RFFLOT20 = "USD 167",
                        RFFLOT40 = "USD 265",
                    },
                    DOFee = new DeliveryOrderFee
                    {
                        Manual = "",
                        Electric = "",
                        MergeFee = "945.000",
                    },
                    SealFee = "USD 9.45",
                    ManifestSubmissionFee = "",
                    BLAmendmentFee = "",
                    LatePayment = "",
                },
                new FeeLookup
                {
                    Name = "JJ SHIPPING",
                    THC = new TerminalHandlingCharge
                    {
                        DC20 = "USD 130",
                        DC40 = "USD 195",
                        DC45 = "",
                        RFFLOT20 = "USD 165",
                        RFFLOT40 = "USD 250",
                    },
                    DOFee = new DeliveryOrderFee
                    {
                        Manual = "",
                        Electric = "",
                        MergeFee = "900.000",
                    },
                    SealFee = "USD 8",
                    ManifestSubmissionFee = "",
                    BLAmendmentFee = "",
                    LatePayment = "",
                },
            ];
        }
    }
}
