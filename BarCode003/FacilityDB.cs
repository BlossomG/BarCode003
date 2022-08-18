using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BarCode003
{
  internal class FacilityDB
  {
    #region Instance Variables
    public string ConnectionString;
    #endregion

    public FacilityDB( string subApp )
    {
      bool needcs = true;
      switch (subApp)
      {
        case "CShipLabel":        //Chelsea01
        case "StealthShipLabel":  //AFT01
        case "DLQ_Label":         //AFT02
        case "InspectionLabel":   //BOW01
          break;
        case "ShipHatchAFTMain":
        case "ShipHatchBOWMain":
        case "ChelseaBoxLabelMain":
          break;
        case "LabelTypes":
        case "":
          this.ConnectionString = HRDB.ConnectionString;
          needcs = false;
          break;
        default:
          MessageBox.Show("Unknown Value: " + subApp + ".\r\n Using Chelsea for now...");
          this.ConnectionString = ChelseaDB.ConnectionString;
          break;
      }
      if (needcs)
      {
        this.ConnectionString =
          string.Format("Persist Security Info=False;database=M2MDATA{0};server={1};User ID=sa; Pwd=Orch#d07"
                      , ConfigurationUtilities.CompanyCode()
                      , ConfigurationUtilities.DatabaseServer()
                       );
      }
    }

    public static bool Connected(string subapp = "")
    {
      bool answer = true;
      FacilityDB FDB = new FacilityDB(subapp);
      string connectionString = FDB.ConnectionString;
      try
      {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
          conn.Open();
          conn.Close();
        }
      }
      catch
      {
        answer= false;
      }
      return answer;
    }
  }

  internal class ChelseaDB
  {
    public static string ConnectionString = "Persist Security Info=False;database=M2MDATA60;server=SQL6001;User ID=sa; Pwd=Orch#d07";
  }

  internal class HRDB
  {
    public static string ConnectionString = "Persist Security Info=False;database=HR_IT_OnBoarding;server=SQL6001;User ID=sa; Pwd=Orch#d07";
  }

}
