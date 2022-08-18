using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BarCode003
{
  public partial class ConfigurationPage : Form
  {
    public ConfigurationPage()
    {
      this.InitializeComponent();
      this.dgvList.DataSource = ConfigurationUtilities.ParameterList();
    }

    private void bClose_Click( object sender, EventArgs e )
    {
      bool kanpathChanged = false;
      bool shipChanged = false;
      foreach (DataGridViewRow row in this.dgvList.Rows )
      {
        XElement curElement = ConfigurationUtilities.ElementWithName(((string)(row.Cells[1].Value)));
        if (((string)(row.Cells[0].Value)) == "KanPath")
        {
          if (curElement == null)
          {
            ConfigurationUtilities.AddElementTo("KanPath"
                                        , ((string)(row.Cells[1].Value))
                                        , ((string)(row.Cells[2].Value))
                                                );
            kanpathChanged = true;
          }
          else if (((string)(curElement.Value)) != ((string)(row.Cells[2].Value)))
          {
            ConfigurationUtilities.UpdateElementIn("KanPath"
                                        , ((string)(row.Cells[1].Value))
                                        , ((string)(row.Cells[2].Value))
                                                );
            kanpathChanged = true;
          }
        }
        else if (((string)(row.Cells[0].Value)) == "Ship")
        {
          if (curElement == null)
          {
            ConfigurationUtilities.AddElementTo("Ship"
                                        , ((string)(row.Cells[1].Value))
                                        , ((string)(row.Cells[2].Value))
                                                );
            shipChanged = true;
          }
          else if (((string)(curElement.Value)) != ((string)(row.Cells[2].Value)))
          {
            ConfigurationUtilities.UpdateElementIn("Ship"
                                        , ((string)(row.Cells[1].Value))
                                        , ((string)(row.Cells[2].Value))
                                                );
            shipChanged = true;
          }
        }
      }
      if (kanpathChanged)
      {
        ConfigurationUtilities.WriteTable("KANPATH");
      }
      if (shipChanged)
      {
        ConfigurationUtilities.WriteTable("SHIP");
      }
      this.Close();
    }

    private void bCancel_Click( object sender, EventArgs e )
    {
      this.Close();
    }
  }
}
