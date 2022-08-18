using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;
using System.IO;
using System.Windows.Forms;
using System.Data;

namespace BarCode003
{
  internal class ConfigurationUtilities
  {
    #region Class Variables
    public static XElement KANPATHTXT = new XElement("KANPATH");
    public static XElement SHIPTXT = new XElement("SHIP");
    public static XElement PartLinkTXT = new XElement("PartLink");
    public static string ExecutionPath = "";
    public static string InstallationPath = "";
    #endregion

    public static string Initialize()
    {
      InstallationPath = "\\\\vs1001\\Install\\LabelPrinter";
      string machinename = Environment.MachineName;
      StringBuilder errormessages = new StringBuilder(string.Empty);
      FileInfo fi = new FileInfo(System.Reflection.Assembly.GetExecutingAssembly().Location);
      ExecutionPath = fi.DirectoryName + "\\";
      string xmlfile = "";
      string txtfile = "";
      string netfile = "";
      xmlfile =
        string.Format("{0}{1}", ExecutionPath, "_KANPATH.TXT.XML");
      if (!(KANPATHTXT.HasElements))
      {
        if (File.Exists(xmlfile))
        {
          KANPATHTXT = XElement.Load(xmlfile);
        }
        else
        {
          txtfile =
            string.Format("{0}{1}", ExecutionPath, "_KANPATH.TXT");
          if (File.Exists(txtfile))
          {
            KANPATHTXT = ConfigurationUtilities.XMLize(txtfile, xmlfile);
          }
          else
          {
            netfile =
              string.Format("{0}\\Configurations\\{1}{2}", ExecutionPath, machinename, "_KANPATH.TXT");
            if (File.Exists(netfile))
            {
              KANPATHTXT = ConfigurationUtilities.XMLize(netfile, xmlfile);
            }
            else
            {
              errormessages.AppendLine("A configuration file is missing:");
              errormessages.AppendFormat("    {0}", txtfile);
              errormessages.AppendLine();
            }
          }
        }
        if ((KANPATHTXT.HasElements) && (KANPATHTXT.Element("LabelLocation") == null))
        {
          FolderBrowserDialog folderDlg = new FolderBrowserDialog();
          folderDlg.ShowNewFolderButton = false;
          string guessedlocation = LabelLocation(); //Has the "CompanyCode" defaults...
          folderDlg.SelectedPath = guessedlocation;
          if (string.IsNullOrWhiteSpace(guessedlocation))
          {
            folderDlg.Description = "Where are your Label Template (btw) files?";
          }
          else
          {
            folderDlg.Description = "Is this where your Label Template (btw) files are?";
          }
          DialogResult result = DialogResult.Cancel;
          bool firsttime = true;
          while (result != DialogResult.OK)
          {
            if (!firsttime)
            {
              if (string.IsNullOrWhiteSpace(guessedlocation))
              {
                folderDlg.Description = "Where are your Label Template (btw) files?\nAn answer is required.";
              }
              else
              {
                folderDlg.Description = "Is this where your Label Template (btw) files are?\nPlease CONFIRM.";
              }
            }
            result = folderDlg.ShowDialog();
            firsttime = false;
          }
          string answer = folderDlg.SelectedPath;
          if (string.IsNullOrWhiteSpace(answer))
          {
            MessageBox.Show("This application can't continue without this infromation.");
          }
          XElement parent = new XElement("LabelLocation");
          parent.Add(new XElement("Value",answer));
          KANPATHTXT.Add(parent);
          KANPATHTXT.Save(xmlfile, SaveOptions.None);
        }
      }
      xmlfile =
        string.Format("{0}{1}", ExecutionPath, "_SHIP.TXT.XML");
      if (!(SHIPTXT.HasElements))
      {
        if (File.Exists(xmlfile))
        {
          SHIPTXT = XElement.Load(xmlfile);
        }
        else
        {
          txtfile =
            string.Format("{0}{1}", ExecutionPath, "_SHIP.TXT");
          if (File.Exists(txtfile))
          {
            SHIPTXT = ConfigurationUtilities.XMLize(txtfile, xmlfile);
          }
          else
          {
            netfile =
              string.Format("{0}\\Configurations\\{1}{2}", ExecutionPath, machinename, "_SHIP.TXT");
            if (File.Exists(netfile))
            {
              SHIPTXT = ConfigurationUtilities.XMLize(netfile, xmlfile);
            }
            else
            {
              errormessages.AppendLine("A configuration file is missing:");
              errormessages.AppendFormat("    {0}", xmlfile);
              errormessages.AppendLine();
            }
          }
        }
      }
      if (!(PartLinkTXT.HasElements))
      {
        txtfile =
          string.Format("{0}\\Support\\{1}", LabelLocation(), "PartLink.TXT");
        if (File.Exists(txtfile))
        {
          PartLinkTXT = ConfigurationUtilities.XMLize(txtfile, "");
        }
        //else
        //{
        //  errormessages.AppendLine("A configuration file is missing:");
        //  errormessages.AppendFormat("    {0}", txtfile);
        //  errormessages.AppendLine();
        //}
      }
      return errormessages.ToString();
    }

    public static XElement XMLize(string infile, string outfile)
    {
      IEnumerable<string> lines = File.ReadLines(infile);
      XElement parent = new XElement("Configuration");
      XElement child = new XElement("child");
      string tousename = "";
      int linenumber = 1; //1 == Key; 2 == Value; 3 == Ignore
      foreach (string line in lines)
      {
        switch (linenumber)
        {
          case 1: //KEY
            tousename = line.Replace(' ', '_');
            if (string.IsNullOrWhiteSpace(tousename))
              break;
            child = parent.Element(tousename);
            if (child == null)
            {
              child = new XElement(tousename);
              parent.Add(child);
            }
            break;
          case 2: //VALUE
            if (line.IndexOf("^") > -1)
            {
              string[] childlines = line.Split('^');
              foreach (string line2 in childlines)
              {
                string[] linepieces = line2.Split('~');
                if (linepieces.Length != 3) break;
                string childname = "Part"+linepieces[0].Trim();
                XElement temp = new XElement(childname);
                //temp.Add(new XElement("Number", linepieces[0].Trim()));
                temp.Add(new XElement("Company", linepieces[1].Trim()));
                temp.Add(new XElement("Country", linepieces[2].Trim()));
                child.Add(temp);
              }
            }
            else
            {
              child.Add(new XElement("Value", line));
            }
            break;
          default:
            break;
        }
        linenumber++;
        if (linenumber == 4) linenumber = 1;
      }
      if (!string.IsNullOrWhiteSpace(outfile))
      {
        tousename = outfile;
        int nextval = 1;
        while (File.Exists(tousename))
        {
          tousename = string.Format("{0}({1:00}).xml", outfile, nextval);
          nextval++;
        }
        parent.Save(tousename, SaveOptions.None);
      }
      return parent;
    }

    public static string CompanyCode()
    {
      string answer = "";
      if ((KANPATHTXT.HasElements)
        &&(KANPATHTXT.Element("DatabaseLocation") != null))
      {
        answer = KANPATHTXT.Element("DatabaseLocation").Value.Substring(5, 2);
      }
      else
      {
        string machinename = Environment.MachineName;
        int start = 2;
        if (machinename.StartsWith("PC") || machinename.StartsWith("FS"))
        {
          start = 2;
        }
        else
        {
          start = 3;
        }
        answer = machinename.Substring(start, 2);
      }
      return answer;
    }

    public static string ScreenStart()
    {
      string answer = "";
      if (SHIPTXT.HasElements)
      {
        answer = SHIPTXT.Element("ScreenStart").Value.ToUpper();
      }
      return answer;
    }

    public static string DatabasePath()
    {
      string answer = "";
      if (KANPATHTXT.HasElements)
      {
        answer = KANPATHTXT.Element("DatabaseLocation").Value;
      }
      return answer;
    }

    public static string DatabaseServer()
    {
      string answer = DatabasePath();
      int loc = answer.IndexOf("\\", 2); //SINGLE back slash
      if (loc != -1)
      {
        answer = answer.Substring(2, (loc - 2));
      }
      return answer;
    }

    public static string LabelLocation()
    {
      string answer = "";
      if ((KANPATHTXT.HasElements)
       && (KANPATHTXT.Element("LabelLocation") != null))
      {
        answer = KANPATHTXT.Element("LabelLocation").Value;
      }
      else
      {
        switch (CompanyCode())
        {
          case "10":
            answer = "\\\\sql1003\\M2M\\M2Mdata\\DATA10\\ShipLabel\\";
            break;
          case "60":
            answer = "\\\\Sql6001\\M2M\\M2MData\\DATA60\\ShipLabel\\";
            break;
          case "80":
            answer = "\\\\sql1003\\M2M\\M2Mdata\\DATA10\\ShipLabel\\";
            break;
          default:
            break;
        }
      }
      return answer;
    }

    public static string LogPath()
    {
      return ExecutionPath;
    }

    public static string ErrorPath()
    {
      return ExecutionPath;
    }

    public static bool UseTimer()
    {
      bool answer = false;
      XElement xElement = KANPATHTXT.Element("UseTimer");
      if ((xElement == null) || (xElement.Value.ToUpper() == "YES"))
      {
        answer = true;
      }
      return answer;
    }

    public static string AlternateLabelFor(string partnumber,string country)
    {
      string answer = "";
      if ((PartLinkTXT.HasElements) && (PartLinkTXT.Element("CONTENT") != null))
      {
        XElement list = PartLinkTXT.Element("CONTENT");
        string id = "Part" + partnumber.Trim();
        XElement exception = list.Element(id);
        if (exception != null)
        {
          string xcountry = exception.Element("Country").Value.ToUpper();
          if (xcountry == country.ToUpper())
          {
            string xcompany = exception.Element("Company").Value;
            if (xcompany.Trim().ToUpper() == "SMITH & NEPHEW - SWITZERLAND")
            {
              answer = string.Format("{0}SNSwitzerlanShipLabel.btw", ConfigurationUtilities.LabelLocation());
              if (!File.Exists(answer))
              {
                answer = "";
              }
            }
          }
        }
      }
      return answer;
    }

    public static DataTable ParameterList()
    {
      DataTable answer = new DataTable();
      DataColumn thing = answer.Columns.Add("XMLParent", typeof(string));
      thing.ReadOnly = true;
      thing = answer.Columns.Add("Key", typeof(string));
      thing.ReadOnly = true;
      answer.Columns.Add("Value", typeof(string));
      bool timerNotFound = true;
      foreach (XElement xElement in KANPATHTXT.Elements())
      {
        string debug = xElement.Name.ToString();
        if (((XElement)(xElement.FirstNode)) != null)
        {
          answer.Rows.Add("KanPath"
                      , debug
                      , ((XElement)(xElement.FirstNode)).Value);
        }
        else
        {
          answer.Rows.Add("KanPath"
                        , debug
                        , debug
                         );
        }
        if (debug.ToUpper() == "USETIMER")
        {
          timerNotFound = false;
        }
      }
      if (timerNotFound)
      {
        answer.Rows.Add("KanPath", "UseTimer", "YES");
      }
      foreach (XElement xElement in SHIPTXT.Elements())
      {
        if (((XElement)(xElement.FirstNode)) != null)
        {
          answer.Rows.Add("Ship"
                        , xElement.Name.ToString()
                        , ((XElement)(xElement.FirstNode)).Value);
        }
        else
        {
          answer.Rows.Add("Ship"
                        , xElement.Name.ToString()
                        , xElement.Name.ToString()
                         );
        }
      }
      return answer;
    }

    public static XElement ElementWithName(string aName)
    {
      XElement answer = null;
      if (KANPATHTXT.Element(aName) != null)
      {
        answer = KANPATHTXT.Element(aName);
      }
      if (SHIPTXT.Element(aName) != null)
      {
        answer = SHIPTXT.Element(aName);
      }
      return answer;
    }

    public static void AddElementTo(string xmlVarName, string newName, string newValue)
    {
      XElement newElement = new XElement(newName, new XElement("Value", newValue));
      if (xmlVarName.ToUpper().StartsWith("KAN"))
      {
        KANPATHTXT.Add(newElement);
      }
      else if (xmlVarName.ToUpper().StartsWith("SHIP"))
      {
        SHIPTXT.Add(newElement);
      }
    }

    public static void UpdateElementIn( string xmlVarName, string newName, string newValue )
    {
      XElement newElement = new XElement(newName, new XElement("Value", newValue));
      if (xmlVarName.ToUpper().StartsWith("KAN"))
      {
        KANPATHTXT.Add(newElement);
      }
      else if (xmlVarName.ToUpper().StartsWith("SHIP"))
      {
        SHIPTXT.Add(newElement);
      }
    }

    public static void WriteTable(string xmlVarName)
    {
      string xmlfile = "";
      XElement parent = null;
      if (xmlVarName.ToUpper().StartsWith("KAN"))
      {
        xmlfile =
          string.Format("{0}{1}", ExecutionPath, "_KANPATH.TXT.XML");
        parent = KANPATHTXT;
      }
      else if (xmlVarName.ToUpper().StartsWith("SHIP"))
      {
        xmlfile =
          string.Format("{0}{1}", ExecutionPath, "_SHIP.TXT.XML");
        parent = SHIPTXT;
      }
      parent.Save(xmlfile, SaveOptions.None);
    }
  }
}
