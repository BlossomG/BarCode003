using System.Windows.Forms;

namespace BarCode003
{
  public partial class GetAFTBoxLabel : Form
  {
    public GetAFTBoxLabel()
    {
      InitializeComponent();
      tbScannedInput.Focus();
    }

    public GetAFTBoxLabel( int remainingQty ) : this()
    {
      lblQty.Text = remainingQty.ToString();
      tbScannedInput.Focus();
    }

    private void tbScannedInput_TextChanged( object sender, System.EventArgs e )
    {
      int working = tbScannedInput.Text.Length;
      if (working > 0 )
      {
        bBLOK.Enabled = true;
        bCancel.Enabled = true;
        if (working == 13)
        {
          bBLOK.PerformClick();
          return;
        }
      }
      else
      {
        bBLOK.Enabled = false;
        bCancel.Enabled = false;
      }
    }

    private void GetAFTBoxLabel_Load( object sender, System.EventArgs e )
    {
      tbScannedInput.Focus();
    }

    private void GetAFTBoxLabel_Activated( object sender, System.EventArgs e )
    {
      tbScannedInput.Focus();
    }

    private void GetAFTBoxLabel_VisibleChanged( object sender, System.EventArgs e )
    {
      tbScannedInput.Focus();
    }
  }
}
