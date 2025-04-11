using Logistic_Website.Data;
using Logistic_Website.Models;
using Microsoft.AspNetCore.Mvc;

namespace Logistic_Website.Controllers
{
    public class FeeLookupController : Controller
    {
        public List<FeeLookup> FeeLookups = TransientData.GetFeeLookups();
        public List<LiftOnLiftOff> LiftOnOffs = TransientData.GetLiftOnLiftOffs();

        public IActionResult Index(FeeType feeType = FeeType.LCC)
        {
            ViewBag.FeeType = feeType;
            ViewBag.FeeLookups = FeeLookups;
            ViewBag.LiftOnOffs = LiftOnOffs;
            return View();
        }

        [HttpPost]
        public IActionResult Search([FromBody] SearchRequest searchRequest)
        {
            if (searchRequest.FeeType == FeeType.LCC)
            {
                if (searchRequest.SelectedNames == null || searchRequest.SelectedNames.Count == 0)
                {
                    return PartialView("_FeeTable", FeeLookups);
                }
                var resultLCC = FeeLookups.Where(f => searchRequest.SelectedNames.Contains(f.Name)).ToList();
                return PartialView("_FeeTable", resultLCC);
            }
            if (searchRequest.SelectedNames == null || searchRequest.SelectedNames.Count == 0)
            {
                return PartialView("_LiftOnLiftOffTable", LiftOnOffs);
            }
            var resultLOLO = LiftOnOffs.Where(f => searchRequest.SelectedNames.Contains(f.City)).ToList();
            return PartialView("_LiftOnLiftOffTable", resultLOLO);
        }
    }

    public class SearchRequest
    {
        public List<string> SelectedNames { get; set; }
        public FeeType FeeType { get; set; }
    }

    public enum FeeType
    {
        LCC,
        LOLO
    }
}