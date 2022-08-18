using System;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;

namespace BarCode003
{
  public class ActionLog
  {
    public static void Log(string WhatToLog, string subApp = "" )
    {
      string curdir = ConfigurationUtilities.LogPath();
      string where = string.Format("{0}{1}-log.txt", curdir, DateTime.Now.ToString("yyyyMMdd"));
      FileStream fs = null;
      StreamWriter sw = null;
      try
      {
        if (!File.Exists(where))
        {
          fs = File.Create(where);
        }
        else
        {
          fs = new FileStream(where, FileMode.Append);
        }
        sw = new StreamWriter(fs);
        sw.WriteLine();
        sw.WriteLine(DateTime.Now.ToString("HH:mm:ss") + ": " + WhatToLog);
      }
      catch (Exception ex)
      {
        ErrorLog.HoustonWeHaveAProblem(ex);
      }
      finally
      {
        sw.Flush();
        sw.Close();
        sw.Dispose();
        fs.Close();
        fs.Dispose();
      }
    }

    public static void LogDB( string WhatToLog, string subApp )
    {
      FacilityDB FDB = new FacilityDB(subApp);
      string connectionString = FDB.ConnectionString;
      string strSQL = "SELECT TOP 1 * FROM [dbo].[ActionLog]";
      try
      {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
          conn.Open();
          SqlCommand cmd = new SqlCommand(strSQL, conn);
          cmd.ExecuteNonQuery();
        }
      }
      catch (Exception ex)
      {
        if (ex.Message == "Invalid object name 'dbo.ActionLog'.")
        {
          strSQL = @"
CREATE TABLE [dbo].[ActionLog](
	[pIdentityColumn] [int] IDENTITY(1,1) NOT NULL,
	[pDate] [datetime] NOT NULL,
	[ComputerName] [varchar](15) NOT NULL,
	[AppName] [varchar](20) NOT NULL,
	[UserName] [varchar](50) NOT NULL,
	[Message] [varchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY];
ALTER TABLE [dbo].[ActionLog] ADD  CONSTRAINT [DF_ActionLog_pDate]  DEFAULT (getdate()) FOR [pDate];
";
          try
          {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
              conn.Open();
              SqlCommand cmd = new SqlCommand(strSQL, conn);
              cmd.ExecuteNonQuery();
            } //using
          }
          catch (Exception exi)
          {
            ActionLog.Log(exi.Message);
            MessageBox.Show(exi.Message);
            return;
          }
          finally { }
        }
        else
        {
          ActionLog.Log(ex.Message);
          MessageBox.Show(ex.Message);
          return;
        }
      }
      finally
      { }
      string User = SystemInformation.UserName;
      string machinename = Environment.MachineName;
      strSQL = string.Format(@"
INSERT INTO [dbo].[ActionLog] ([AppName],[Message],[UserName],[ComputerName]) 
VALUES ('{0}','{1}','{2}','{3}')"
, subApp, WhatToLog, User, machinename
);
      try
      {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
          conn.Open();
          SqlCommand cmd = new SqlCommand(strSQL, conn);
          cmd.ExecuteNonQuery();
        } //using
      }
      catch (Exception ex)
      {
        ActionLog.Log(ex.Message);
        MessageBox.Show(ex.Message);
      }
      finally 
      { }
    }
  }
}