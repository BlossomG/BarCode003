
namespace BarCode003
{
  public class AFTStealthLabel
  {
    #region Instance Variables
    public int BoxNumber { get; set; }
    public string PartNumberA { get; set; }
    public string PartNumberB { get; set; }
    public string PONumber { get; set; }
    public string ShipperNumber { get; set; }
    public string LotNumber { get; set; }
    public string HeatNumber { get; set; }
    public int Quantity { get; set; }
    public string KB { get; set; }
    public string Country { get; set; }
    public string PartDesc { get; set; }
    #endregion

    public AFTStealthLabel()
    {
      PartNumberA = string.Empty;
      PartNumberB = string.Empty;
      PONumber = string.Empty;
      ShipperNumber = string.Empty;
      LotNumber = string.Empty;
      HeatNumber = string.Empty;
      Country = string.Empty;
      PartDesc = string.Empty;
      Quantity = 0;
    }
  }
}
