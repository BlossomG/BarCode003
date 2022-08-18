using System;
using System.IO;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BarCode003
{
  public class ErrorLog
  {
    //***************************************************************************
    //* Function to document errors to a text file within the working directory
    //*  Argument: System error message, system error number, caode section making the call
    //*  Returns: Nothing
    //*  Output: 'writing error message to a file in the working directory
    //*          filename Err + year + Month + day + hour + minute + second
    //***************************************************************************
    public static void HoustonWeHaveAProblem( Exception ex, string subApp = "" )
    {
      if (!ErrorLog.LogDB(ex, subApp))
      {
        StreamWriter sw;
        string strFileName;
        DateTime now = DateTime.Now;
        string filepath = ConfigurationUtilities.ErrorPath();
        strFileName = string.Format("{1}ERROR-{0:yyyyMMddHHmmss}.txt", now, filepath);
        sw = new StreamWriter(strFileName);
        sw.WriteLine("***** Error Log *****");
        sw.WriteLine(now.ToString("dddd, MMM dd yyyy HH:mm:ss"));
        sw.WriteLine("*******************************************");
        sw.WriteLine();
        sw.WriteLine(ex.Message);
        sw.WriteLine();
        sw.WriteLine(ex.StackTrace);
        sw.Flush();
        sw.Close();
        sw.Dispose();
      }
    }

    protected static bool LogDB(Exception ex, string subApp)
    {
      bool success = false;
      FacilityDB FDB = new FacilityDB(subApp);
      string connectionString = FDB.ConnectionString;
      //string User = SystemInformation.UserName;
      string machinename = Environment.MachineName;

      string strSQL = string.Format(@"
INSERT INTO [dbo].[ExceptionLog] 
      ( [HResult]
      , [TargetSite]
      , [Message]
      , [StackTrace]
      , [AppName]
      , [ComputerName]) 
VALUES ({0},'{1}','{2}','{3}','{4}','{5}')"
, ex.HResult
, ex.TargetSite
, ex.Message
, ex.StackTrace
, subApp
, machinename
);

      try
      {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
          conn.Open();
          SqlCommand cmd = new SqlCommand(strSQL, conn);
          cmd.ExecuteNonQuery();
          success = true;
        } //using
      }
      catch (Exception exi)
      {
        ActionLog.Log(exi.Message);
        MessageBox.Show(exi.Message);
      }
      finally
      { }

      return success;
    }
  }
}