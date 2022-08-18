using System.Windows.Forms;

namespace BarCode003
{
  public partial class GetCustomerNameModal : Form
  {
    public GetCustomerNameModal()
    {
      InitializeComponent();
    }

    private void GetCustomerNameModal_Activated( object sender, System.EventArgs e )
    {
      tbNewCustomerName.Focus();
    }

    private void GetCustomerNameModal_Load( object sender, System.EventArgs e )
    {
      tbNewCustomerName.Focus();
    }

    private void GetCustomerNameModal_VisibleChanged( object sender, System.EventArgs e )
    {
      tbNewCustomerName.Focus();
    }
  }
}
