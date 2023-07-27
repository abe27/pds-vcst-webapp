namespace WebPDSConfirm.Data;

public class OrderHeaderService
{
    private static readonly string[] OrderStatus = new string[] { "In Process", "Paid"};
    private static readonly string[] Summaries = new[]
    {
        "PO/0003476","PO/0003160","VCS6408/CB70-J","PO/0003294","SSA6501/DP203-N","SSA6501/EXP-N1","SORE6501/CK70-N","SRC6502/CH70-N","VDP6502/CB70-N",
    };

    public Task<OrderHeader[]> GetForecastAsync(DateOnly startDate)
    {
        return Task.FromResult(Enumerable.Range(0, Summaries.Length - 1).Select(index => new OrderHeader
        {
            Id = index + 1,
            // Date = startDate.AddDays(index),
            FcskId = (index + 1).ToString(),
            Date = startDate,
            RefNo = Summaries[Random.Shared.Next(Summaries.Length)],
            Vendor = "WeatherForecast",
            Item = null,
            Amount = Random.Shared.Next(0, 9999),
            Vat = Random.Shared.Next(0, 99),
            Status = OrderStatus[Random.Shared.Next(0, OrderStatus.Length)],
            LastUpdate=DateTime.Now,
        }).ToArray());
    }
}
