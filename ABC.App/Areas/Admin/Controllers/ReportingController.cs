namespace ABC.Admin.Controllers;

public class ReportingController : BaseController
{
    private ILogger<ReportingController> _logger { get; set; }

    public ReportingController(ILogger<ReportingController> logger)
    {
        _logger = logger;
    }

    public ActionResult Index()
    {
        return View();
    }
}
