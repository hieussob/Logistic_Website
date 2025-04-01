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
            groups = [.. groups.Where(c =>
                c.Name.Contains(query, StringComparison.OrdinalIgnoreCase) ||
                c.Abbreviation.Contains(query, StringComparison.OrdinalIgnoreCase) ||
                c.Code.Contains(query, StringComparison.OrdinalIgnoreCase)
            )];
            ViewBag.Query = query;
        }

        return View(groups);
    }

    private static List<LogisticGroup> GetShippingCompanies()
    {
        return
        [
            new LogisticGroup { Name = "Maersk", Abbreviation = "MSK", LogoUrl = "https://upload.wikimedia.org/wikipedia/commons/6/6c/Maersk_Group_Logo.jpeg", Code = "Mosk-MSK" },
            new LogisticGroup { Name = "Mediterranean", Abbreviation = "MSC", LogoUrl = "https://upload.wikimedia.org/wikipedia/commons/b/b3/Mediterranean_Shipping_Company_logo.svg", Code = "Mediterranean-MSC" },
            new LogisticGroup { Name = "CMA CGM", Abbreviation = "CMA", LogoUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/d/d1/CMA_CGM_logo.svg/1280px-CMA_CGM_logo.svg.png", Code = "Dafei-CMA" },
            new LogisticGroup { Name = "COSCO", Abbreviation = "COSCO", LogoUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c2/COSCO_logo.svg/2560px-COSCO_logo.svg.png", Code = "COSCO-COSCO" },
            new LogisticGroup { Name = "MATSON", Abbreviation = "MATSON", LogoUrl = "https://cdn.freebiesupply.com/logos/large/2x/matson-logo-png-transparent.png", Code = "MATSON-MATSON" },
            new LogisticGroup { Name = "Evergreen", Abbreviation = "EMC", LogoUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/8a/Evergreen_Roundel.svg/1024px-Evergreen_Roundel.svg.png", Code = "Evergreen-EMC" },
            new LogisticGroup { Name = "Hapag-Lloyd", Abbreviation = "HPL", LogoUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/6/6a/Hapag-Lloyd.svg/2560px-Hapag-Lloyd.svg.png", Code = "Hapag-Lloyd-HPL" },
            new LogisticGroup { Name = "Wanhai", Abbreviation = "WHL", LogoUrl = "https://companieslogo.com/img/orig/2615.TW_BIG-35b188e7.png?t=1730742803", Code = "Wanhai-WHL" },
            new LogisticGroup { Name = "Oriental Overseas", Abbreviation = "OOCL", LogoUrl = "https://upload.wikimedia.org/wikipedia/de/f/fb/Orient_Overseas_Container_Line_logo.svg", Code = "Oriental-Overseas-OOCL" },
            new LogisticGroup { Name = "Ocean Network", Abbreviation = "ONE", LogoUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/45/Ocean_Network_Express_logo.svg/2560px-Ocean_Network_Express_logo.svg.png", Code = "Ocean-Network-ONE" },
            new LogisticGroup { Name = "Zhen Hua", Abbreviation = "CNC", LogoUrl = "https://trackingstatus.my/wp-content/uploads/2023/12/CNC-Line-Container-Tracking.webp", Code = "Zhen-Hua-CNC" },
            new LogisticGroup { Name = "Yang Ming", Abbreviation = "YML", LogoUrl = "https://container-news.com/wp-content/uploads/2022/11/Yang-Ming-logo.png", Code = "Yang-Ming-YML" },
            new LogisticGroup { Name = "Han Xin", Abbreviation = "HMM", LogoUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/5/56/HMM_Logo_Basic_Form.svg/1280px-HMM_Logo_Basic_Form.svg.png", Code = "Han-Xin-HMM" },
            new LogisticGroup { Name = "Taiping Shipping", Abbreviation = "PIL", LogoUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSUgikRBY6Yj9SfPMQmRmbwFucW7U6RhOgzaQ&s", Code = "Taiping-Shipping-PIL" },
            new LogisticGroup { Name = "MARIANA", Abbreviation = "MARIANA", LogoUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTG2MaHf46kVgwwKplGGDF6tcTrOEXBuPKEfQ&s", Code = "MARIANA-MARIANA" },
            new LogisticGroup { Name = "Yixing Shipping", Abbreviation = "ZIM", LogoUrl = "https://www.cdnlogo.com/logos/z/91/zim.svg", Code = "Yixing-Shipping-ZIM" },
            new LogisticGroup { Name = "Goryeo Shipping", Abbreviation = "KMTC", LogoUrl = "https://cdn.phaata.com/files/2021/04/29/kmtc-line.webp", Code = "Goryeo-Shipping-KMTC" },
            new LogisticGroup { Name = "Haifeng", Abbreviation = "SITC", LogoUrl = "https://companieslogo.com/img/orig/1308.HK-5c10b475.png?t=1720244490", Code = "Haifeng-SITC" },
        ];
    }
}