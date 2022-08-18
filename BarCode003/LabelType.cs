using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarCode003
{
  internal class LabelType
  {
    public static object[] LabelTypes()
    {
      string company = ConfigurationUtilities.CompanyCode();
      string screenStart = ConfigurationUtilities.ScreenStart();
      return LabelTypes(screenStart, company);
      #region OLD CODE
      //      List<string> answer = new List<string>();
      //      //answer.Add("Chelsea Shipping Label");
      //      bool success = true;
      //      FacilityDB FDB = new FacilityDB("LabelTypes", out success);
      //      if (!success)
      //      {
      //        return answer.ToArray();
      //      }
      //      //string strSQLHowMany = "SELECT COUNT(*) FROM [dbo].[LabelPrinter_LabelTypes]";
      //      string strSQL =
      //@"SELECT [DisplayValue]
      //    FROM [dbo].[LabelPrinter_LabelTypes]
      //   ORDER BY [DisplayValue]";
      //      string connectionString = FDB.ConnectionString;
      //      using (SqlConnection conn = new SqlConnection(connectionString))
      //      {
      //        conn.Open();
      //        //SqlCommand cmdhm = new SqlCommand(strSQLHowMany, conn);
      //        SqlCommand cmd = new SqlCommand(strSQL, conn);
      //        //cmd.CommandType = System.Data.CommandType.StoredProcedure;
      //        try
      //        {
      //          //int howmany = (int)cmdhm.ExecuteScalar();
      //          SqlDataReader rdr = cmd.ExecuteReader();
      //          while (rdr.Read())
      //          {
      //            answer.Add((string)rdr["DisplayValue"]);
      //          }
      //        }
      //        catch (Exception ex)
      //        {
      //          answer = new List<string>();
      //          answer.Add(ex.Message);
      //          success = false;
      //        }
      //      } //using
      //      return answer.ToArray();
      #endregion
    }

    protected static object[] LabelTypes(string startScreen, string company)
    {
      List<string> theAnswers = new List<string>();
      switch (startScreen)
      {
        case "SHIPPING":
          switch (company)
          {
            case "10":
              theAnswers.Add("StealthShipLabel"); //AFT01
              theAnswers.Add("DLQ_Label");        //AFT02
              break;
            default:
              break;
          }
          break;
        case "INSPECTION":
          switch (company)
          {
            case "10":
              theAnswers.Add("InspectionLabel"); //BOW01
              break;
            case "60":
              theAnswers.Add("CShipLabel");      //Chelsea01
              break;
            default:
              break;
          }
          break;
        default:
          break;
      }
      return theAnswers.ToArray();
    }
  }
}
