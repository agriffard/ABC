namespace ABC.Admin.Controllers;

public class DashboardController : BaseController
{
    private ILogger<DashboardController> _logger { get; set; }

    public DashboardController(ILogger<DashboardController> logger)
    {
        _logger = logger;
    }

    public ActionResult Index()
    {
        return View();
    }
}
