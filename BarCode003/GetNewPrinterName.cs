using System;
using System.Windows.Forms;

namespace BarCode003
{
  public partial class GetNewPrinterName : Form
  {
    public GetNewPrinterName()
    {
      InitializeComponent();
    }

    public GetNewPrinterName(string startlabelname = "") : this()
    {
      tbNewName.Text = startlabelname;
    }

    private void GetNewPrinterName_Activated( object sender, EventArgs e )
    {
      tbNewName.Focus();
    }

    private void GetNewPrinterName_Load( object sender, EventArgs e )
    {
      tbNewName.Focus();
    }

    private void GetNewPrinterName_VisibleChanged( object sender, EventArgs e )
    {
      tbNewName.Focus();
    }
  }
}
