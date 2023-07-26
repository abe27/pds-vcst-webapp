namespace WebPDSConfirm.Data;

public class OrderHeader
{
    public int Id { get; set; }
    public DateOnly Date { get; set; }

    public string? RefNo { get; set; }
    public string? Vendor { get; set; }
    // public OrderDetail[]? Item { get; set; }
    public int Item { get; set; }
    public double Amount { get; set; }
    public double Vat { get; set; }
    public string? Status { get; set; }

    public DateTime LastUpdate { get; set; }
}
