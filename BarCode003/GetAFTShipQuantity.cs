using System;
using System.Windows.Forms;

namespace BarCode003
{
  public partial class GetAFTShipQuantity : Form
  {
    public GetAFTShipQuantity()
    {
      InitializeComponent();
    }
    
    public GetAFTShipQuantity( int remainingQty, string lotnumber ) : this()
    {
      lblQty.Text = remainingQty.ToString();
      lblLot.Text = string.Format("LOT {0}", lotnumber);
      tbScannedInput.Focus();
    }

    private void GetAFTShipQuantity_Load( object sender, System.EventArgs e )
    {
      tbScannedInput.Focus();
    }

    private void GetAFTShipQuantity_Activated( object sender, System.EventArgs e )
    {
      tbScannedInput.Focus();
    }

    private void GetAFTShipQuantity_VisibleChanged( object sender, System.EventArgs e )
    {
      tbScannedInput.Focus();
    }

    private void tbScannedInput_TextChanged( object sender, EventArgs e )
    {
      if ( tbScannedInput.Text.Length > 0)
      {
        bBLOK.Enabled = true;
        bCancel.Enabled = true;
      }
      else
      {
        bBLOK.Enabled = false;
        bCancel.Enabled = false;
      }
    }
  }
}
