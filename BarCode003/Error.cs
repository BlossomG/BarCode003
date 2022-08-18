using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarCode003
{
  public partial class Error : Form
  {
    public Error()
    {
      InitializeComponent();
    }
    public Error( string message ) : this()
    {
      tbMessage.Text = message;
      tbMessage.SelectionLength = 0;
    }
  }
}
