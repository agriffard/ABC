namespace ABC.Business.Services;

public partial class ReportingService : IReportingService
{
    public ReportingService()
    {
    }

    public int GetCount(ReportingType reportingType, string filter)
    {
        var rnd = new Random();
        return rnd.Next(1, 1000);
    }

    public List<XY<string, int>> GetByRange(ReportingType reportingType, RangeType range)
    {
        var result = new List<XY<string, int>>();

        var rnd = new Random();
        switch (reportingType)
        {
            case ReportingType.Orders:
                switch (range)
                {
                    case RangeType.AllTime:
                        result.Add(new XY<string, int>("", rnd.Next(1, 1000)));
                        break;
                    case RangeType.Yearly:
                        foreach (var i in Enumerable.Range(2011, 12))
                        {
                            result.Add(new XY<string, int>(i.ToString(), rnd.Next(200, 500)));
                        }
                        break;
                    case RangeType.Monthly:
                        foreach (var i in Enumerable.Range(1, 12))
                        {
                            result.Add(new XY<string, int>(new DateTime(2000, i, 1).ToString("MMMM"), rnd.Next(20, 50)));
                        }
                        break;
                    default:
                        break;
                }
                break;

            default:
                break;
        }

        return result;
    }
}
