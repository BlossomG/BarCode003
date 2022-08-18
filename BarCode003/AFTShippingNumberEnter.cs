using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BarCode003
{
  internal class AFTShippingNumberEnter
  {
    #region Instance Variables
    public string ShippingNumberIn;
    public string ShippingNumberOut;
    public List<AFTPart> Parts;
    public int aQuantity;
    #endregion

    public AFTShippingNumberEnter()
    {
      ShippingNumberIn = "";
      ShippingNumberOut = "";
      Parts = new List<AFTPart>();
    }

    public AFTShippingNumberEnter( string shippingnumber, string subApp ) : this()
    {
      ShippingNumberIn = AFTShippingNumberEnter.FixShippingNumber(shippingnumber);
      ShippingNumberOut = ShippingNumberIn;
      FacilityDB FDB = new FacilityDB(subApp);
      string strSQL = string.Format(
@"
SELECT 
       shitem.fshipno
     , shitem.fpartno          AS PartNumber
     , shitem.fmdescript       AS PartDesc
     , shitem.fshipqty         AS Quantity
     , shitem.fitemno          AS ShipIN
     , shsrce.Identity_Column  AS IDShrce
     , shsrce.fcitemno         AS ShrceIN
     , shlotc.Identity_Column  AS IDShlotc
     , shlotc.fcitemno         AS SchlotcIN
     , shlotc.fclot            AS LotNumber
     , shsrce.bin              AS Bin
     , shlotc.fnlotqty         AS LotQty
     , shitem.fcustpart        AS CustomerPartNumber
     , somast.fcustpono        AS PONumber
     , JOMAST_EXT.HEATNUMBER   AS HeatNumber
     , shmast.fccountry        AS Country
     , CASE WHEN SOMAST_EXT.LKANBAN = 1 THEN 'KB' 
            ELSE '' END        AS KB
  FROM dbo.shitem
  JOIN dbo.shsrce ON shsrce.fcshipno = shitem.fshipno
                 AND shsrce.fcitemno = shitem.fitemno
  JOIN dbo.shlotc ON shlotc.fcshipno = shitem.fshipno
                 AND shlotc.fcitemno = shitem.fitemno
  JOIN dbo.shmast ON shmast.fshipno = shitem.fshipno
  INNER JOIN dbo.somast ON somast.fsono = shmast.fcsono
  JOIN dbo.qalotc ON qalotc.fcpartno = shitem.fpartno 
                 AND (qalotc.fctype = 'J')
                 AND (qalotc.fclot = shlotc.fclot)
  INNER JOIN dbo.Jomast ON jomast.fjobno = qalotc.fcdoc
  INNER JOIN JOMAST_EXT ON JOMAST_EXT.FKey_ID = jomast.identity_column
  JOIN dbo.SOMAST_EXT ON SOMAST_EXT.FKey_ID = somast.identity_column
 WHERE shitem.fshipno = '{0}'
   AND LEN(shlotc.fclot) > 0
   AND LEN(shsrce.bin) > 0
   AND shlotc.fnlotqty > 0
 order by shitem.fpartno, shitem.fitemno
", shippingnumber);

      string connectionString = FDB.ConnectionString;

      try
      {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
          conn.Open();
          SqlCommand cmd = new SqlCommand(strSQL, conn);
          //cmd.CommandType = System.Data.CommandType.StoredProcedure;
          SqlDataReader rdr = cmd.ExecuteReader();
          while (rdr.Read())
          {
            AFTPart model = new AFTPart();
            model.ShipperNumber = ((string)rdr["fshipno"]).Trim();
            model.PartNumber = ((string)rdr["PartNumber"]).Trim();
            model.PartDesc = ((string)rdr["PartDesc"]).Trim();
            model.Quantity = (decimal)rdr["Quantity"];
            model.ShipItemNumber = ((string)rdr["ShipIN"]).Trim();
            model.IDShrce = (int)rdr["IDShrce"];
            model.ShrceItemNumber = ((string)rdr["ShrceIN"]).Trim();
            model.IDShlotc = (int)rdr["IDShlotc"];
            model.ShlotcItemNumber = ((string)rdr["SchlotcIN"]).Trim();
            model.LotNumber = ((string)rdr["LotNumber"]).Trim();
            model.Bin = ((string)rdr["Bin"]).Trim();
            model.LotQty = (decimal)rdr["LotQty"];
            model.CustomerPartNumber = ((string)rdr["CustomerPartNumber"]).Trim();
            model.PONumber = ((string)rdr["PONumber"]).Trim();
            model.HeatNumber = ((string)rdr["HeatNumber"]).Trim();
            model.KB = ((string)rdr["KB"]).Trim();
            model.Country = ((string)rdr["Country"]).Trim();
            this.Parts.Add(model);
          }
        } //using
      }
      catch (Exception ex)
      {
        ActionLog.LogDB(ex.Message, subApp);
        ErrorLog.HoustonWeHaveAProblem(ex);
        MessageBox.Show(ex.Message);
      }
      finally
      {
      }
      strSQL = String.Format(
        "SELECT SUM(fshipqty) AS HowMany FROM dbo.shitem WHERE fshipno = '{0}'"
        , shippingnumber
      );
      try
      {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
          conn.Open();
          SqlCommand cmd = new SqlCommand(strSQL, conn);
          //cmd.CommandType = System.Data.CommandType.StoredProcedure;
          SqlDataReader rdr = cmd.ExecuteReader();
          if (rdr.Read())
          {
            this.aQuantity = (int)((decimal)rdr["HowMany"]);
          }
        }
      }
      catch (Exception ex)
      {
        ActionLog.LogDB(ex.Message, subApp);
        ErrorLog.HoustonWeHaveAProblem(ex);
        MessageBox.Show(ex.Message);
      }
      finally
      {
      }
    }

    protected static string FixShippingNumber( string shippingnumber )
    {
      string workwith = shippingnumber.Trim().ToUpper();
      while (workwith.Length < 6)
      {
        workwith = "0" + workwith;
      }
      if (workwith.Length > 6)
      {
        workwith = workwith.Substring(workwith.Length - 5);
      }
      return workwith;
    }
  }
}
