
using Logistic_Website.Models;
using Microsoft.AspNetCore.Mvc;

namespace Logistic_Website.Controllers;

public class TrackingController : Controller
{
    public IActionResult Index(string query)
    {
        var groups = GetShippingCompanies();

        if (!string.IsNullOrEmpty(query))
        {
            groups =
            [
                .. groups.Where(c =>
                    c.Name.Contains(query, StringComparison.OrdinalIgnoreCase)
                    || c.Abbreviation.Contains(query, StringComparison.OrdinalIgnoreCase)
                    || c.Code.Contains(query, StringComparison.OrdinalIgnoreCase)
                ),
            ];
            ViewBag.Query = query;
        }

        return View(groups);
    }

    private static List<LogisticGroup> GetShippingCompanies()
    {
        return
        [
            new LogisticGroup
            {
                Name = "Maersk",
                Abbreviation = "MSK",
                Logo= Utils.Images.Maersk,
                Code = "Mask-MSK",
                Website="https://www.maersk.com/tracking/"
            },
            new LogisticGroup
            {
                Name = "Mediterranean",
                Abbreviation = "MSC",
                Logo= Utils.Images.Msc,
                Code = "Mediterranean-MSC",
                Website="https://www.msc.com/en/track-a-shipment"
            },
            new LogisticGroup
            {
                Name = "CMA CGM",
                Abbreviation = "CMA",
                Logo= Utils.Images.CmaCgm,
                Code = "Dafei-CMA",
                Website="https://www.cma-cgm.com/ebusiness/tracking"
            },
            new LogisticGroup
            {
                Name = "COSCO",
                Abbreviation = "COSCO",
                Logo= Utils.Images.Cosco,
                Code = "COSCO-COSCO",
                Website="https://elines.coscoshipping.com/ebusiness/cargoTracking"
            },
            new LogisticGroup
            {
                Name = "MATSON",
                Abbreviation = "MATSON",
                Logo= Utils.Images.Matson,
                Code = "MATSON-MATSON",
                Website="https://www.matson.com/shipment-tracking.html"
            },
            new LogisticGroup
            {
                Name = "Evergreen",
                Abbreviation = "EMC",
                Logo= Utils.Images.Evergreen,
                Code = "Evergreen-EMC",
                Website="https://ct.shipmentlink.com/servlet/TDB1_CargoTracking.do"
            },
            new LogisticGroup
            {
                Name = "Hapag-Lloyd",
                Abbreviation = "HPL",
                Logo= Utils.Images.HapagLloyd,
                Code = "Hapag-Lloyd-HPL",
                Website=" https://www.hapag-lloyd.com/en/online-business/track/track-by-booking-solution.html"
            },
            new LogisticGroup
            {
                Name = "Wanhai",
                Abbreviation = "WHL",
                Logo= Utils.Images.WanHaiLine,
                Code = "Wanhai-WHL",
                Website="https://www.wanhai.com/views/Main.xhtml"
            },
            new LogisticGroup
            {
                Name = "Oriental Overseas",
                Abbreviation = "OOCL",
                Logo= Utils.Images.Oocl,
                Code = "Oriental-Overseas-OOCL",
                Website="https://www.oocl.com/eng/Pages/default.aspx"
            },
            new LogisticGroup
            {
                Name = "Ocean Network",
                Abbreviation = "ONE",
                Logo= Utils.Images.One,
                Code = "Ocean-Network-ONE",
                Website="https://ecomm.one-line.com/one-ecom"
            },
            new LogisticGroup
            {
                Name = "Zhen Hua",
                Abbreviation = "CNC",
                Logo= Utils.Images.Cnc,
                Code = "Zhen-Hua-CNC",
                Website="https://www.cnc-line.com/ebusiness/tracking"
            },
            new LogisticGroup
            {
                Name = "Yang Ming",
                Abbreviation = "YML",
                Logo= Utils.Images.YangMing,
                Code = "Yang-Ming-YML",
                Website="https://e-solution.yangming.com/e-service/Track_Trace/track_trace_cargo_tracking.aspx"
            },
            new LogisticGroup
            {
                Name = "Han Xin",
                Abbreviation = "HMM",
                Logo= Utils.Images.Hmm,
                Code = "Han-Xin-HMM",
                Website="https://www.hmm21.com/e-service/general/trackNTrace/TrackNTrace.do"
            },
            new LogisticGroup
            {
                Name = "Taiping Shipping",
                Abbreviation = "PIL",
                Logo= Utils.Images.Pil,
                Code = "Taiping-Shipping-PIL",
                Website="https://www.pilship.com/countries/australia/"
            },
            new LogisticGroup
            {
                Name = "MARIANA",
                Abbreviation = "MARIANA",
                Logo= Utils.Images.Mariana,
                Code = "MARIANA-MARIANA",
                Website="https://www.mellship.com/track"
            },
            new LogisticGroup
            {
                Name = "Yixing Shipping",
                Abbreviation = "ZIM",
                Logo= Utils.Images.Zim,
                Code = "Yixing-Shipping-ZIM",
                Website="https://www.zim.com/tools/track-a-shipment"
            },
            new LogisticGroup
            {
                Name = "Goryeo Shipping",
                Abbreviation = "KMTC",
                Logo= Utils.Images.Ktmc,
                Code = "Goryeo-Shipping-KMTC",
                Website="https://www.ekmtc.com/index.html#/main"
            },
            new LogisticGroup
            {
                Name = "Haifeng",
                Abbreviation = "SITC",
                Logo= Utils.Images.Sitc,
                Code = "Haifeng-SITC",
                Website="https://www.sitcline.com/trackCargoSearch.jsp"
            },
        ];
    }
}
