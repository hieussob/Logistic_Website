using Logistic_Website.Data;
using Logistic_Website.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using X.PagedList.Extensions;

namespace Logistic_Website.Controllers
{
    public class StockController : Controller
    {
        [HttpGet]
        public IActionResult Index(int? page)
        {
            ViewBag.Provinces = new[] { "HOCHIMINH", "HAI PHONG" };
            ViewBag.Types = new[]
            {
                "Kho thường",
                "Kho ngoại quan",
                "Kho CFS",
                "Kho lạnh",
                "Kho DG",
            };

            var stocks = TransientData.GetStocks();
            int pageSize = 3;
            int pageNumber = page ?? 1;
            var stockPaging = stocks.ToPagedList(pageNumber, pageSize);

            return View(stockPaging);
        }

        [HttpGet]
        public IActionResult Search(string? province, string? type, string? area)
        {
            var stocks = GetFilteredStock(province, type, area);
            int pageSize = 3;
            int pageNumber = 1;
            var stockPagings = stocks.ToPagedList(pageNumber, pageSize);

            //ViewData["Province"] = province;
            //ViewData["Type"] = type;
            //ViewData["Area"] = area;
            ViewBag.Provinces = new[] { "HOCHIMINH", "HAI PHONG" };
            ViewBag.Types = new[]
            {
                "Kho thường",
                "Kho ngoại quan",
                "Kho CFS",
                "Kho lạnh",
                "Kho DG",
            };

            return View("Index", stockPagings);
        }

        private List<Stock> GetFilteredStock(string province, string type, string area)
        {
            return TransientData
                .GetStocks()
                .Where(x =>
                    (string.IsNullOrEmpty(province) || x.Province.ToLower() == province.ToLower())
                    && (string.IsNullOrEmpty(type) || x.Type.ToLower().Equals(type.ToLower()))
                    && (
                        string.IsNullOrEmpty(area)
                        || (double.TryParse(area, out var areaValue) && x.Area == areaValue)
                    )
                )
                .ToList();
        }
    }
}
