namespace WebPDSConfirm.Data;

public class OrderHeader
{
    public int Id { get; set; }
    public string? FcskId { get; set; }
    public DateOnly Date { get; set; }

    public string? RefNo { get; set; }
    public string? Vendor { get; set; }
    public OrderDetail[]? Item { get; set; }
    public double Amount { get; set; }
    public double Vat { get; set; }
    public string Status { get; set; }
    public int OrderStatus { get; set; }
    public DateTime LastUpdate { get; set; }
}

public class OrderDetail {
    public int Id { get; set; }
}
