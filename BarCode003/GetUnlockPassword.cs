using System;
using System.Windows.Forms;

namespace BarCode003
{
  public partial class GetUnlockPassword : Form
  {
    protected GetUnlockPassword()
    {
      InitializeComponent();
    }

    public GetUnlockPassword(string label) : this()
    {
      if (!string.IsNullOrWhiteSpace(label))
      {
        label1.Text = label;
      }
    }

    private void GetUnlockPassword_Activated( object sender, EventArgs e )
    {
      tbPWD.Focus();
    }

    private void GetUnlockPassword_Load( object sender, EventArgs e )
    {
      tbPWD.Focus();
    }

    private void GetUnlockPassword_VisibleChanged( object sender, EventArgs e )
    {
      tbPWD.Focus();
    }
  }
}
