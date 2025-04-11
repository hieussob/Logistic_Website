using Logistic_Website.Data;
using Logistic_Website.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Diagnostics;
using System.Globalization;
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
        return View();
    }

    public IActionResult GetPorts(string query)
    {
        var ports = new List<SelectListItem>
        {
            new SelectListItem { Value = "HOCHIMINH", Text = "HOCHIMINH" },
            new SelectListItem { Value = "DANANG", Text = "DANANG" },
            new SelectListItem { Value = "HAIPHONG", Text = "HAIPHONG" },
            new SelectListItem { Value = "SINGAPORE", Text = "SINGAPORE" },
        };

        var filteredPorts = ports
            .Where(p => p.Text.Contains(query, StringComparison.OrdinalIgnoreCase))
            .Select(p => p.Text)
            .ToList();

        return Json(filteredPorts);
    }

    [HttpPost]
    public IActionResult Search(
        string origin,
        string destination,
        int? page,
        DateTime? departureDate,
        DateTime? arrivalDate
    )
    {
        departureDate ??= DateTime.MinValue;
        arrivalDate ??= DateTime.MaxValue;

        TransientData.FilterVesselChedules = _vesselSchedules
            .Where(s =>
                s.Origin == origin
                && s.Destination == destination
                && DateTime.TryParseExact(
                    s.ETD,
                    "dd/MM/yyyy",
                    CultureInfo.InvariantCulture,
                    DateTimeStyles.None,
                    out DateTime etd
                )
                && etd >= departureDate
                && DateTime.TryParseExact(
                    s.ETA,
                    "dd/MM/yyyy",
                    CultureInfo.InvariantCulture,
                    DateTimeStyles.None,
                    out DateTime eta
                )
                && eta <= arrivalDate
            )
            .ToList();

        int pageSize = 3;
        int pageNumber = page ?? 1;
        var pageFilterSchedule = TransientData.FilterVesselChedules.ToPagedList(
            pageNumber,
            pageSize
        );

        return View(pageFilterSchedule);
    }

    [HttpGet]
    public IActionResult Search(int? page)
    {
        int pageSize = 3;
        int pageNumber = page ?? 1;
        var pageFilterSchedule = TransientData.FilterVesselChedules.ToPagedList(
            pageNumber,
            pageSize
        );

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
