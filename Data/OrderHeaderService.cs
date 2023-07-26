namespace WebPDSConfirm.Data;

public class OrderHeaderService
{
    private static readonly string[] Summaries = new[]
    {
        "PO/0003476","PO/0003160","VCS6408/CB70-J","PO/0003294","SSA6501/DP203-N","SSA6501/EXP-N1","SORE6501/CK70-N","SRC6502/CH70-N","VDP6502/CB70-N","NTP6502/CB70-N1","SIRI6502/FD220N","TBT6502/CB70-N","PO/0003325","NTN6502/CP200-N","CHI6502/CB70N1","PO/0003289","CQP6502/DC70-D","PAC6502/CB70-D","CQP6502/DC93-D3","CQP6502/DC93-D2","CQP6502/DC93-D1","VDP6502/CB70-N2","CQP6502/DC95-S1","BSP6503/FD220N1","PO/0003326","SIRI6503/FD220N","SNJ6503/AAPT-1","PO/0003339","PO/0003348","SSA6503/FD220N2","BR6503/CB70-MO","SRC6503/FD220-N","CQP6503/CH70-N1","PO/0003361","TTN6504/CP100-T","CQP6504/CB70N1","ABT6501/CP200-N","SRC6505/LD100-N","SRC6505/VAN-N","ABT6505/LD100N1","FST6505/LD100N1","ABT6505/CP200N2","AMI6505/CP200N2","SRC6505/CP200N2","ATO6505/LD100N3","ABT6505/LD100N2","NLD6505/LD100N","NLD6505/CP200-N","VMT6505/VAN-N","NTP6505/CH70-N","ATO6506/CP200-N","SRC6506/CP200N1","ABT6506/CP200N1","PO/0003362","SIR6506/M954-SP","KJN6505/DC108-R","PO/0003984","ATO6505/LD100N","NLD6506/BF612-N","SOR6506/CP200-N","TSM6506/CP200-N","KKB6506/LD100-N","SRC6506/LD100-N","TTN6506/100-SP1","PO/0003987","TTN6506/100-SP2","FTB6506/CB70-J","SOR6506/DC95-SP","ABT6506/CP200-N","FTB6506/CB70-N","RK6506/BF612N1","TSP6507/VAN-N","ATO6507/200-SP","TTNC6507/100-SP","SORE6506/200-SP","WIN6506/DC93-R","ABT6507/CP200N1","AMI6507/CP200-N","CQP6507/CP200-N","NTP6506/BF615","SCK6507/164-SP1","SIR6507/LD100-N","SIR6505/LD100-N","SOR6508/200-SP","NLD6507/VAN-SP","SIRI6508/VAN-N","SIR6507/FD240-R","SCK6507/164-SP","SCC6502/DC105D1","SCC6502/DC105D3","SCC6502/DC105D4","SCC6502/DC105D5","TTNC6508/100-SP","NTP6508/100-SP","SORE6508/100-SP","NLD6508/VAN-SP","WPK6508/105-SP","PO/0004006","ATOM6508/BF615N","SCC6502/DC105D2","ABT6508/CP200-N","ATO6508/70-SP1","NLD6508/CP200-N","SORE6508/LD100N","PO/0004019","SPS6508/CH70-N","KKB6509/CP200-N","BSC6509/CH70-SP","NTP6509/CB70-N","NTP6506/CP200-N","BSM6510/CB70-N1","VCS6509/CB70-J","NLD6510/SF-440","SCC6502/DC70-D1","SCC6502/DC70-D","SCC6502/DC70-D3","NLD6511/CP200-N","ATO6510/70-SP3","FTB6512/CB70-N","AAPT6511/105-MO","VDP6512/E65C-T","ATO6512/CH70-SP","BSP6512/CB70-N1","NLD6512/CP200-N","PO/0003325","NLD6512/BF615","WPK6601/CK105","MLA6601/E65-N","KJN6601/E65-N","BKS6601/CP100SP","PO/0012271","GFP6512/E65C-T","PO/0004037","PO004/0012298","PO6601/0070789","NTP6601/COMBINE","PO6601/0070926","PO6601/0070920","NTN6601/CH70","PO6601/0070936","PO6601/0070769","PO6601/0070930","PO6601/0070879","PO/0012286","PO/0012285","PO/0012274","PO/0012275","PO/0012258","PO/0012270","PO/0012278","PO/0012266","PO/0012267","PO/0012276","PO/0012265","PO/0012269","PO/0012268","PO/0012273","PO/0012263","PO/0012279","PO/0012259","PO/0012261","UNA6601/VAN-N","PO6601/0070728","PO6601/0070727","PO6601/0070726","PO6601/0070846","PO6601/0070611","PO6601/0070613","PO6601/0070640","PO6601/0070612","PO6601/0070905","PO6601/0070586","PO6601/0070585","PO6601/0070691","PO6601/0070773","BKS6601/AAA","BKS6601/BSP","BKS6601/CH70","BKS6601/CB70-N","BKS6601/CP100","BKS6601/VAN-N","PO6601/0070882","PO6601/0070883","PO6601/0070642","PO6601/0070913","PO6601/0070595","PO6601/0070596","PO6601/0070756","PO6601/0070637","PO6601/0070712","PO6601/0070807","PO6601/0070607","PO6601/0070606","PO6601/0070609","PO6601/0070631","PO6601/0070630","PO6601/0070629","PO6601/0070628","PO6601/0070605"
    };

    public Task<OrderHeader[]> GetForecastAsync(DateOnly startDate)
    {
        return Task.FromResult(Enumerable.Range(0, Summaries.Length).Select(index => new OrderHeader
        {
            Id = index,
            Date = startDate.AddDays(index),
            RefNo = Summaries[Random.Shared.Next(Summaries.Length)],
            Vendor = "WeatherForecast",
            Item = Random.Shared.Next(10, 9999),
            Amount = Random.Shared.Next(0, 9999),
            Vat = Random.Shared.Next(0, 99),
            LastUpdate=DateTime.Now,
        }).ToArray());
    }
}