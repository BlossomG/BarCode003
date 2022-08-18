using System;
using System.Drawing;
using System.Windows.Forms;
using System.Reflection;

namespace BarCode003
{
  public partial class ShipHatchBOWMain : Form
  {
    public ShipHatchBOWMain()
    {
      if (!FacilityDB.Connected(this.Name))
      {
        Application.Run(new Error("No Database Connection Detected"));
        this.Close();
        return;
      }
      this.InitializeComponent();
      this.cbLabelType.Items.Clear();
      this.cbLabelType.DataSource = LabelType.LabelTypes();
      if (this.cbLabelType.Items.Count <= 1)
      {
        this.cbLabelType.Enabled = false;
      }
      string thingy = typeof(ShipHatchBOWMain).Assembly.GetName().Version.ToString();
      this.Text = string.Format("Ship Hatch BOW: {0}", thingy);
      ActionLog.LogDB(this.Text, this.Name);
    }

    private void cbLabelType_SelectedIndexChanged( object sender, EventArgs e )
    {
      ComboBox control = (ComboBox)sender;
      string whatitis = control.SelectedValue.ToString();
      int x = whatitis.Length;
      if (x >= 25)
      {
        //Straight out of old code:
        //  Call BeforeProcess();
        //    --Changes form(s) color(s) to DarkSalmon and show some picture
        //  Call FillInTheBlanksLabel();
        //    --"SELECT jodbom.fbomdesc FROM jodbom WHERE (fparent = '" + txtPartNo.Text.Trim + "') AND (fjobno = '" + Me.txtJobNumber.Text.Trim + "') AND (fbompart = '" + txtLabelPartNumber.Text.Trim + "')"
        //    --Sets txPartDesc.Text to result
        //  Call CanIPrint();
        //    --Screen fields validation
        //    --HaveLabel()
        //      --Checks for existence of "txtLabelPartNumber".btw file
        //      --    OR in my code, "cbShipHatchBOWLabelType".btw
      }
      this.tbScannedInput.Focus();
    }

    private void tbJobNumberInput_Leave( object sender, EventArgs e )
    {
      string jni = this.tbScannedInput.Text;
      this.tbScannedInput.BackColor = SystemColors.Window;
      string jno = this.tbJobNumberOut.Text;
      if (string.IsNullOrWhiteSpace(jni))
      {
        if (string.IsNullOrWhiteSpace(jno))
        {
          this.BackColor = SystemColors.Control;
          this.bPrint.Enabled = false;
          this.tbScannedInput.Focus();
        }
        return;
      }
      if (this.PostJobNumber(jni))
      {
        this.BackColor = Color.LightGreen;
        this.bPrint.Enabled = true;
      }
      else
      {
        this.tbScannedInput.BackColor = Color.Pink;
        this.tbScannedInput.Text = this.tbScannedInput.Text.ToUpper();
      }
    }

    private void tbJobNumberInput_KeyPress( object sender, KeyPressEventArgs e )
    {
      if (this.tbScannedInput.Text.Length == 10)
      {
        string jni = this.tbScannedInput.Text;
        this.tbScannedInput.Focus();
        if (this.PostJobNumber(jni))
        {
          this.BackColor = Color.LightGreen;
          this.bPrint.Enabled = true;
        }
        else
        {
          this.tbScannedInput.BackColor = Color.Pink;
          this.tbScannedInput.Text = this.tbScannedInput.Text.ToUpper();
        }
      }
      else if (this.tbScannedInput.Text.Length == 0)
      {
        this.bCmdReset_Click(sender, e);
        this.tbScannedInput.BackColor = SystemColors.Window;
      }
      else
      {
        this.tbScannedInput.BackColor = SystemColors.Window;
      }
    }

    private bool PostJobNumber( string jobnumber )
    {
      this.StopTimer();
      this.BackColor = System.Drawing.Color.Orange;
      JobNumberEnter answer = new JobNumberEnter(jobnumber, this.Name, this.cbUnlock.Checked);
      bool success = false;
      if (!string.IsNullOrEmpty(answer.PartDescription))
      {
        this.tbScannedInput.Text = "";
        this.tbJobNumberOut.Text = answer.JobNumberOut;
        this.tbPartNumberRevisionOut.Text = answer.PartNumberRevision;
        this.tbPartDescription.Text = answer.PartDescription;
        this.tbQtyOut.Text = answer.OrigQty.ToString();
        this.tbCustLot.Text = answer.PO;
        this.tbDueDate.Text = answer.DueDateString;
        this.StartTimer();
        success = true;
      }
      this.tbScannedInput.Focus();
      return success;
    }

    private void bPrint_Click( object sender, EventArgs e )
    {
      int pQty = (int)this.nudSHPrintQty.Value;
      FacilityDB FDB = new FacilityDB(this.Name); ;
      try
      {
        string fullPath = string.Format("{0}\\{1}.btw"
                                      , ConfigurationUtilities.LabelLocation()
                                      , this.cbLabelType.Text);
        if (!System.IO.File.Exists(fullPath))
        {
          string message = string.Format("The file {0} does not exist.", fullPath);
          ActionLog.LogDB(message, this.Name);
          MessageBox.Show(message);
          this.tbScannedInput.Focus();
          return;
        }
        int loc = this.tbPartNumberRevisionOut.Text.IndexOf("/");
        string partnumber = this.tbPartNumberRevisionOut.Text.Substring(0, loc - 1);
        SeagullBC.InspectionLabel(fullPath
                               , pQty
                               , (this.tbCustLot.Text ?? "").Trim()
                               , partnumber
                               , (this.tbPartDescription.Text ?? "").Trim()
                               , this.Name
                               , this.tbPrinterNameMain.Text);
      }
      catch (Exception ex)
      {
        ErrorLog.HoustonWeHaveAProblem(ex);
        ActionLog.LogDB(ex.Message, this.Name);
        MessageBox.Show(ex.Message);
        this.tbScannedInput.Focus();
        return;
      }
      this.tbScannedInput.Text = "";
      this.tbScannedInput.Focus();
      this.StartTimer(true,"10");
    }

    private void cbUnlock_CheckedChanged( object sender, EventArgs e )
    {
      if (this.cbUnlock.Checked)
      {
        GetUnlockPassword mydialogA = new GetUnlockPassword("OPEN LABEL GENERATOR");
        string expected = "STEALTH";
        string inputpwd = "";
        if (mydialogA.ShowDialog(this) == DialogResult.OK)
        {
          inputpwd = mydialogA.tbPWD.Text.ToUpper();
          if (inputpwd == expected)
          {
            this.cbUnlock.ForeColor = Color.DarkGreen;
          }
          else
          {
            this.cbUnlock.ForeColor = Color.Red;
            this.cbUnlock.Checked = false;
          }
        }
        else
        {
          this.cbUnlock.ForeColor = Color.Red;
          this.cbUnlock.Checked = false;
        }
      }
      else
      {
        this.cbUnlock.ForeColor = Color.Red;
      }
      this.tbScannedInput.Focus();
    }

    private void ShipHatchBOWMain_HelpRequested( object sender, HelpEventArgs hlpevent )
    {
      Assembly thisAssem = Assembly.GetExecutingAssembly();
      AssemblyName thisAssemName = thisAssem.GetName();
      Version ver = thisAssemName.Version;
      MessageBox.Show(string.Format("{0}: {1}"
                            , thisAssemName.Name
                            , ver.ToString()));
      this.tbScannedInput.Focus();
    }

    #region ESSENTIALLY Interface Code
    /*
     * Every form MUST implement the following methods
    */
    private void EmptyFields()
    {
      this.tbScannedInput.Text = "";
      this.tbJobNumberOut.Text = "";
      this.tbPartNumberRevisionOut.Text = "";
      this.tbPartDescription.Text = "";
      this.tbQtyOut.Text = "";
      this.tbCustLot.Text = "";
      this.tbDueDate.Text = "";
      this.bCmdReset.Text = "&R";
      this.tbScannedInput.Focus();
    }
    #endregion

    #region COMMON CODE!
    /*
     * The following methods MUST remain THE SAME across ALL
     * FORMS in this application!
    */
    private void tResetTimer_Tick( object sender, EventArgs e )
    {
      int timeleft = 0;
      if (!(int.TryParse(this.bCmdReset.Text, out timeleft)))
      {
        timeleft = 0; //MAKE SURE it is not undefined.
      }
      timeleft--;
      if (timeleft <= 0)
      {
        this.bCmdReset_Click(sender, e);
        this.tbScannedInput.Focus();
        return;
      }
      this.bCmdReset.Text = timeleft.ToString();
    }

    private void bExit_Click( object sender, EventArgs e )
    {
      this.tResetTimer.Enabled = false; //Make sure thread stops...
      Environment.Exit(0);
    }

    private void StartTimer( bool ignoreConfig = false, string buttonText = "24" )
    {
      if (ConfigurationUtilities.UseTimer() || ignoreConfig)
      {
        this.tResetTimer.Enabled = false;
        this.bCmdReset.Text = buttonText;
        this.tResetTimer.Enabled = true;
      }
    }

    private void StopTimer()
    {
      this.tResetTimer.Enabled = false;
      this.bCmdReset.Text = "&R";
    }

    private void bCmdReset_Click( object sender, EventArgs e )
    {
      this.StopTimer();
      this.EmptyFields();
      this.BackColor = SystemColors.Control;
      this.tbScannedInput.BackColor = SystemColors.Window;
      this.bPrint.Enabled = false;
      this.tbScannedInput.Focus();
    }

    private void tbPrinter_DoubleClick( object sender, EventArgs e )
    {
      ((TextBox)sender).SelectionLength = 0;
      GetUnlockPassword mydialogP = new GetUnlockPassword("Enter Password");
      string expected = "GEORGE";
      string inputpwd = "";
      if (mydialogP.ShowDialog(this) == DialogResult.OK)
      {
        inputpwd = mydialogP.tbPWD.Text.ToUpper();
        if (inputpwd == expected)
        {
          GetNewPrinterName mydialogA = new GetNewPrinterName(this.tbPrinterNameMain.Text);
          if (mydialogA.ShowDialog(this) == DialogResult.OK)
          {
            string newname = mydialogA.tbNewName.Text.Trim();
            if (string.IsNullOrWhiteSpace(newname))
            {
              expected = "GREGGO";
              if (mydialogP.ShowDialog(this) == DialogResult.OK)
              {
                inputpwd = mydialogP.tbPWD.Text.ToUpper();
                if (inputpwd == expected)
                {
                  ((TextBox)sender).Text = newname;
                }
              }
            }
            else
            {
              ((TextBox)sender).Text = newname;
            }
          }
        }
      }
      this.tbScannedInput.Focus();
    }

    private void tbPrinter_Click( object sender, EventArgs e )
    {
      this.tbScannedInput.Focus();
    }

    private void bConfig_Click( object sender, EventArgs e )
    {
      GetUnlockPassword mydialogP = new GetUnlockPassword("Enter Password");
      string expected = "GEORGE";
      string inputpwd = "";
      if (mydialogP.ShowDialog(this) == DialogResult.OK)
      {
        inputpwd = mydialogP.tbPWD.Text.ToUpper();
        if (inputpwd == expected)
        {
          ConfigurationPage configurationPage = new ConfigurationPage();
          configurationPage.ShowDialog(this);
        }
      }
      this.tbScannedInput.Focus();
    }
    #endregion
  }
}
