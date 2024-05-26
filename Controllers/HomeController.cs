using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using mvcapi.Models;
using mvcapi.Models.Services.Application;

namespace mvcapi.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly ITransientRandom _transientRandom1;
    private readonly ITransientRandom _transientRandom2;
    private readonly ITransientRandom _transientRandom3;
    private readonly IScopedRandom _scopedRandom1;
    private readonly IScopedRandom _scopedRandom2;
    private readonly IScopedRandom _scopedRandom3;
    private readonly ISingletonRandom _singletonRandom1;
    private readonly ISingletonRandom _singletonRandom2;
    private readonly ISingletonRandom _singletonRandom3;

    public HomeController(ILogger<HomeController> logger,
                          ITransientRandom transientRandom1,
                          ITransientRandom transientRandom2,
                          ITransientRandom transientRandom3,
                          IScopedRandom scopedRandom1,
                          IScopedRandom scopedRandom2,
                          IScopedRandom scopedRandom3,
                          ISingletonRandom singletonRandom1,
                          ISingletonRandom singletonRandom2,
                          ISingletonRandom singletonRandom3)
    {
        _logger = logger;
        _transientRandom1 = transientRandom1;
        _transientRandom2 = transientRandom2;
        _transientRandom3 = transientRandom3;
        _scopedRandom1 = scopedRandom1;
        _scopedRandom2 = scopedRandom2;
        _scopedRandom3 = scopedRandom3;
        _singletonRandom1 = singletonRandom1;
        _singletonRandom2 = singletonRandom2;
        _singletonRandom3 = singletonRandom3;
        

    }

    public IActionResult Index()
    {
        ViewBag.transientRandom1 = _transientRandom1.GetRandomNumber();
        ViewBag.transientRandom2 = _transientRandom2.GetRandomNumber();
        ViewBag.transientRandom3 = _transientRandom3.GetRandomNumber();
        ViewBag.scopedRandom1 = _scopedRandom1.GetRandomNumber();
        ViewBag.scopedRandom2 = _scopedRandom2.GetRandomNumber();
        ViewBag.scopedRandom3 = _scopedRandom3.GetRandomNumber();
        ViewBag.singletonRandom1 = _singletonRandom1.GetRandomNumber();
        ViewBag.singletonRandom2 = _singletonRandom2.GetRandomNumber();
        ViewBag.singletonRandom3 = _singletonRandom3.GetRandomNumber();
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
