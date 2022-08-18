using System;
using System.Windows;
using System.Windows.Forms;
using System.Diagnostics;
using System.Reflection;
using System.Security.Principal;

namespace BarCode003
{
  internal static class Program
  {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      //if (!IsRunAsAdmin())
      //{
      //  ProcessStartInfo proc = new ProcessStartInfo();
      //  proc.UseShellExecute = true;
      //  proc.WorkingDirectory = Environment.CurrentDirectory;
      //  proc.FileName = Assembly.GetEntryAssembly().CodeBase;

      //  proc.Verb = "runas";

      //  try
      //  {
      //    Process.Start(proc);
      //    //Application.Current.Shutdown();
      //  }
      //  catch (Exception ex)
      //  {
      //    MessageBox.Show("This program must be run as an administrator! \n\n" + ex.ToString());
      //  }
      //}
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      string anyErrors = ConfigurationUtilities.Initialize();
      if (!(string.IsNullOrEmpty(anyErrors)))
      {
        Application.Run(new Error(anyErrors));
        return;
      }
      string[] args = Environment.GetCommandLineArgs();
      if (args.Length > +1)
      {

      }
      Form formToRun = new Error("No Startup page found.");
      string company = ConfigurationUtilities.CompanyCode();
      string screenStart = ConfigurationUtilities.ScreenStart();
      switch (screenStart)
      {
        case "SHIPPING":
          switch (company)
          {
            case "10":
              formToRun = new ShipHatchAFTMain();
              break;
            default:
              break;
          }
          break;
        case "INSPECTION":
          switch (company)
          {
            case "10":
              formToRun = new ShipHatchBOWMain();
              break;
            case "60":
              formToRun = new ChelseaBoxLabelMain();
              break;
            default:
              break;
          }
          break;
        default:
          break;
      }
      if (!(formToRun.IsDisposed))
      {
        Application.Run(formToRun);
      }
    }

    static bool IsRunAsAdmin()
    {
      try
      {
        WindowsIdentity id = WindowsIdentity.GetCurrent();
        WindowsPrincipal principal = new WindowsPrincipal(id);
        return principal.IsInRole(WindowsBuiltInRole.Administrator);
      }
      catch (Exception)
      {
      }
      return false;
    }
  }
}
