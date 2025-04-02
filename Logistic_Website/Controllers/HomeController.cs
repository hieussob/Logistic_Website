using System.Diagnostics;
using Logistic_Website.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using X.PagedList.Extensions;

namespace Logistic_Website.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private List<VesselSchedule> _vesselSchedules;
    private List<VesselSchedule> _filteredSchedules;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
        _vesselSchedules = TransientData.GetScheduleDetails();
    }

    public IActionResult Index()
    {
        var ports = new List<SelectListItem>
        {
            new SelectListItem { Value = "HCM", Text = "Hồ Chí Minh" },
            new SelectListItem { Value = "HN", Text = "Hà Nội" },
            new SelectListItem { Value = "DN", Text = "Đà Nẵng" },
            new SelectListItem { Value = "HAIPHONG", Text = "Hải Phòng" },
            new SelectListItem { Value = "SINGAPORE", Text = "Singapore" }
        };

        ViewBag.Ports = ports;
        return View();
    }

    [HttpPost]
    public IActionResult Search(string origin, string destination, int? page)
    {
        TransientData.FilterVesselChedules = _vesselSchedules.Where(s => s.Origin == origin && s.Destination == destination).ToList();

        int pageSize = 3;
        int pageNumber = page ?? 1; 
        var pageFilterSchedule = TransientData.FilterVesselChedules.ToPagedList(pageNumber, pageSize);

        return View(pageFilterSchedule);
    }

    [HttpGet]
    public IActionResult Search(int? page)
    {
        int pageSize = 3;
        int pageNumber = page ?? 1;
        var pageFilterSchedule = TransientData.FilterVesselChedules.ToPagedList(pageNumber, pageSize);

        return View(pageFilterSchedule);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(
            new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier }
        );
    }
}
