using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BarCode003
{
  internal class JobNumberEnter
  {
    #region Instance Variables
    public string ExecutionPath { get; set; }
    public bool DebugMode { get; set; }
    public string JobNumberIn { get; set; }
    public string JobNumberOut { get; set; }
    public string JobPartNumber { get; set; }
    public string PartRevision { get; set; }
    public string PartNumberRevision
    {
      get
      {
        if ((JobPartNumber == null) || (JobPartNumber.Trim().Length == 0))
        {
          return "";
        }
        else if ((PartRevision == null) || (PartRevision.Trim().Length == 0))
        {
          return JobPartNumber.Trim();
        }
        return JobPartNumber.Trim() + " / " + PartRevision.Trim();
      }
    }
    public int OrigQty { get; set; }
    public int FirstOpQty { get; set; }
    public int LastOpQty { get; set; }
    public int PrintQuantity { get; set; }
    public string PartDescription { get; set; }
    public string PO { get; set; }
    public string DueDateString { get; set; }
    public string CustomerName { get; set; }
    protected DateTime RealDateTime { get; set; }
    public DateTime DueDate
    {
      get { return RealDateTime; }
      set
      {
        RealDateTime = value;
        DueDateString = value.ToString("yyyy-MM-dd");
      }
    }
    #endregion

    public JobNumberEnter()
    {
      JobNumberIn = "";
      JobNumberOut = "Not Entered";
      JobPartNumber = "";
      OrigQty = 0;
      FirstOpQty = 0;
      LastOpQty = 0;
      PrintQuantity = 0;
      PartDescription = "";
      PartRevision = "";
      PO = "";
      DueDate = DateTime.Now;
      DueDateString = "";
      CustomerName = "";
      DebugMode = false;
      ExecutionPath = ConfigurationUtilities.ExecutionPath;
    }

    public JobNumberEnter( string jobnumber, string subApp, bool findall = false ) : this()
    {
      JobNumberIn = JobNumberEnter.FixJobNumber(jobnumber);
      JobNumberOut = JobNumberIn;
      FacilityDB FDB = new FacilityDB(subApp);
      string connectionString = FDB.ConnectionString;
      string strSQL = "";
      switch (subApp)
      {
        case "ChelseaBoxLabelMain":
          strSQL = string.Format(
    @"
SELECT jomast.fsono        AS OrderNumber
     , jomast.fcompany     AS CustomerName
     , jomast.fddue_date   AS DueDate
     , ISNULL(somast.fcustpono, '') AS CustLot
     , joitem.fpartno      AS PartNumber
     , joitem.fpartrev     AS PartRevision
     , joitem.fdesc        AS PartDesc
     , joitem.fmqty        AS Quantity
     , jodrtg1.fnqty_comp  AS FirstQty --MIN(jodrtg.foperno),
     , jodrtgL.fnqty_comp  AS LastQty  --MAX(jodrtg.foperno)
  FROM dbo.jomast
  LEFT JOIN dbo.somast ON somast.fsono = jomast.fsono
  JOIN dbo.joitem ON joitem.fjobno = jomast.fjobno
  JOIN dbo.jodrtg AS jodrtg1 ON jodrtg1.fjobno = jomast.fjobno 
                            AND jodrtg1.foperno = (SELECT MIN(foperno) 
                                                     FROM jodrtg 
                                                    WHERE fjobno = '{0}')
  JOIN dbo.jodrtg AS jodrtgL ON jodrtgL.fjobno = jomast.fjobno 
                            AND jodrtgL.foperno = (SELECT MAX(foperno) 
                                                     FROM jodrtg 
                                                    WHERE fjobno = '{0}')
 WHERE jomast.fjobno = '{0}'"
          , JobNumberIn);

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
                this.JobPartNumber = (string)rdr["PartNumber"];
                this.PartRevision = (string)rdr["PartRevision"];
                this.OrigQty = (int)((decimal)rdr["Quantity"]);
                this.FirstOpQty = (int)((decimal)rdr["FirstQty"]);
                this.LastOpQty = (int)((decimal)rdr["LastQty"]);
                this.PartDescription = (string)rdr["PartDesc"];
                this.PO = (string)rdr["CustLot"];
                this.DueDate = (DateTime)rdr["DueDate"];
                this.CustomerName = (string)rdr["CustomerName"];
              }
            } //using
          }
          catch (Exception ex)
          {
            ErrorLog.HoustonWeHaveAProblem(ex);
            ActionLog.LogDB(ex.Message, subApp);
            MessageBox.Show(ex.Message);
          }
          finally
          {
          }
          break;
        case "ShipHatchBOWMain":
          string whereclause = " AND (jomast.fstatus = 'OPEN' OR jomast.fstatus = 'RELEASED')";
          if (findall)
          {
            whereclause = "";
          }
          strSQL = string.Format(
    @"
SELECT 1 AS Dummy
     , jomast.fddue_date   AS DueDate
     , joitem.fpartno      AS PartNumber
     , joitem.fpartrev     AS PartRevision
     , qalotc.fclot        AS CustLot
     , joitem.fdesc        AS PartDesc
     , joitem.fmqty        AS Quantity
  FROM dbo.jomast
  JOIN dbo.joitem ON joitem.fjobno = jomast.fjobno
  JOIN dbo.qalotc ON qalotc.fcdoc = jomast.fjobno AND qalotc.fctype = 'J'
 WHERE jomast.fjobno = '{0}'{1}"
          , JobNumberIn, whereclause);

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
                this.DueDate = (DateTime)rdr["DueDate"];
                this.JobPartNumber = (string)rdr["PartNumber"];
                this.PartRevision = (string)rdr["PartRevision"];
                this.PO = (string)rdr["CustLot"];
                this.PartDescription = (string)rdr["PartDesc"];
                this.OrigQty = (int)((decimal)rdr["Quantity"]);
              }
            } //using
          }
          catch (Exception ex)
          {
            ErrorLog.HoustonWeHaveAProblem(ex);
            ActionLog.LogDB(ex.Message, subApp);
            MessageBox.Show(ex.Message);
          }
          finally
          {
          }
          break;
        case "DLQ Label":
        default:
          break;
      }
    }

    protected static string FixJobNumber( string jobnumber )
    {
      string workwith = jobnumber.Trim().ToUpper();
      while (workwith.Length != 10)
      {
        int wheredash = workwith.IndexOf('-');
        if (wheredash == -1)
        {
          if (workwith.Length == 5)
          {
            workwith += "-";
          }
          else if (workwith.Length == 6)
          {
            workwith = workwith.Substring(1) + "-";
          }
          else
          {
            workwith = "00000" + workwith;
            workwith = workwith.Substring(workwith.Length - 5);
          }
        }
        else if (wheredash < 5)
        {
          workwith = "00000" + workwith;
          wheredash = workwith.IndexOf('-');
          workwith = workwith.Substring(wheredash - 5);
        }
        else if (wheredash > 5)
        {
          workwith = workwith.Substring(wheredash - 5);
        }
        else
        {
          workwith += "0000";
        }
        if (workwith.Length > 10)
        {
          workwith = workwith.Substring(0, 10);
        }
      }
      return workwith;
    }
  }
}
