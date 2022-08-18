using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Reflection;
using System.Drawing;

namespace BarCode003
{
  public partial class ChelseaBoxLabelMain : Form
  {
    public ChelseaBoxLabelMain()
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
      string thingy = typeof(ChelseaBoxLabelMain).Assembly.GetName().Version.ToString();
      this.Text = string.Format("Chelsea Box Label: {0}", thingy);
      ActionLog.LogDB(this.Text, this.Name);
      this.cbCustomers.Visible = false;
      this.tbCustomerName.BringToFront();
      this.tbCustomerName.Visible = true;
    }

    private void tbJobNumberInput_Leave( object sender, EventArgs e )
    {
      string jni = this.tbScannedInput.Text;
      string jno = this.tbJobNumberOut.Text;
      if (string.IsNullOrWhiteSpace(jni))
      {
        if (string.IsNullOrWhiteSpace(jno))
        {
          this.bPrint.Enabled = false;
        }
        //this.tbScannedInput.Focus();
        return;
      }
      //tbJobNumberInput.Focus();
      if (this.PostJobNumber( jni ))
      {
        this.bPrint.Enabled = true;
      }
    }

    private bool PostJobNumber( string jobnumber )
    {
      this.StopTimer();
      JobNumberEnter answer = new JobNumberEnter(jobnumber, this.Name);
      bool success = false;
      if (!string.IsNullOrEmpty(answer.PartDescription))
      {
        this.tbScannedInput.Text = "";
        this.tbJobNumberOut.Text = answer.JobNumberOut;
        this.tbPartNumberRevisionOut.Text = answer.PartNumberRevision;
        this.tbPartDescription.Text = answer.PartDescription;
        this.tbOriginalQuantity.Text = answer.OrigQty.ToString();
        this.tbFirstOpQty.Text = answer.FirstOpQty.ToString();
        this.tbLastOpQty.Text = answer.LastOpQty.ToString();
        this.tbPO.Text = answer.PO;
        this.tbDueDate.Text = answer.DueDateString;
        if (string.IsNullOrWhiteSpace(answer.CustomerName))
        {
          List<Customer> customers = this.GetCustomers(this.Name, answer.JobPartNumber, answer.PartRevision);
          this.cbCustomers.BringToFront();
          this.cbCustomers.Focus();
          this.cbCustomers.Items.Clear();
          this.cbCustomers.Items.Add("Choose Customer");
          foreach (Customer customer in customers)
          {
            this.cbCustomers.Items.Add(customer.Name.Trim());
          }
          this.cbCustomers.Items.Add("None of the Above...");
          this.cbCustomers.SelectedIndex = 0;
          this.cbCustomers.Visible = true;
          this.cbCustomers.Enabled = true;
          this.tbCustomerName.Visible = false;
          success = false;
        }
        else
        {
          this.cbCustomers.Visible = false;
          this.tbCustomerName.BringToFront();
          this.tbCustomerName.Visible = true;
          this.tbCustomerName.Text = answer.CustomerName;
          success = true;
        }
        this.StartTimer();
      }
      this.tbScannedInput.Focus();
      return success;
    }

    private List<Customer> GetCustomers( string subApp, string jobpartno, string partrev )
    {
      List<Customer> customers = Customer.GetCustomersFor(subApp, jobpartno, partrev);
      return customers;
    }

    private void cbCustomers_SelectedIndexChanged( object sender, EventArgs e )
    {
      this.StopTimer();
      this.bPrint.Enabled = false;
      string whatitis = this.cbCustomers.Text;
      if (whatitis == "Choose Customer")
      {
        this.StartTimer();
        this.tbScannedInput.Focus();
        return;
      }
      if (whatitis == "None of the Above...")
      {
        GetCustomerNameModal myDialog = new GetCustomerNameModal();
        if (myDialog.ShowDialog(this) == DialogResult.OK)
        {
          string whatdidiget = myDialog.tbNewCustomerName.Text;
          if (!string.IsNullOrWhiteSpace(whatdidiget))
          {
            this.tbCustomerName.Text = whatdidiget;
            this.tbCustomerName.Visible = true;
            this.cbCustomers.Visible = false;
            this.bPrint.Enabled = true;
            this.StartTimer();
            this.tbScannedInput.Focus();
            return;
          }
        }
        this.cbCustomers.SelectedIndex = 0;
        this.tbCustomerName.Text = "";
        this.tbScannedInput.Focus();
        return;
      }
      this.tbCustomerName.Text = whatitis;
      this.bPrint.Enabled = true;
      this.StartTimer();
      this.tbScannedInput.Focus();
    }

    private void bPrint_Click( object sender, EventArgs e )
    {
      //GetPrintQty myDialog = new GetPrintQty();
      //DialogResult myDialogResult = myDialog.ShowDialog(this);
      //if (myDialogResult != DialogResult.OK)
      //{
      //  return;
      //}
      //int pQty = (int)myDialog.nudPrintQuantity.Value;
      int pQty = (int)this.nudCBLPrintQty.Value;
      FacilityDB FDB = new FacilityDB(this.Name);
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
        SeagullBC.ShipBoxLabel(fullPath
                             , pQty
                             , (this.tbPartNumberRevisionOut.Text ?? "").Trim()
                             , (this.tbPartDescription.Text ?? "").Trim()
                             , (this.tbPO.Text ?? "").Trim()
                             , (this.tbJobNumberOut.Text ?? "").Trim()
                             , (this.tbCustomerName.Text ?? "").Trim()
                             , (this.tbFirstOpQty.Text == "0" ? "" : this.tbFirstOpQty.Text)
                             , (this.tbLastOpQty.Text == "0" ? "" : this.tbLastOpQty.Text)
                             , this.Name
                             //, tbPrinterNameMain.Text
                             );
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
      this.StartTimer();
    }

    private void tbJobNumberInput_KeyPress( object sender, KeyPressEventArgs e )
    {
      if (this.tbScannedInput.Text.Length == 10)
      {
        //e.Handled = true;
        string jni = this.tbScannedInput.Text;
        this.tbScannedInput.Focus();
        if (this.PostJobNumber(jni))
        {
          this.bPrint.Enabled = true;
        }
        this.tbScannedInput.Focus();
      }
      else if (this.tbScannedInput.Text.Length == 0)
      {
        this.bCmdReset_Click(sender, e);
      }
    }

    private void ChelseaBoxLabelMain_HelpRequested( object sender, HelpEventArgs hlpevent )
    {
      Assembly thisAssem = Assembly.GetExecutingAssembly();
      AssemblyName thisAssemName = thisAssem.GetName();
      Version ver = thisAssemName.Version;
      MessageBox.Show(string.Format("{0}: {1}"
                            , thisAssemName.Name
                            , ver.ToString()));
      this.tbScannedInput.Focus();
    }

    private void cbLabelType_SelectedIndexChanged( object sender, EventArgs e )
    {
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
      this.tbOriginalQuantity.Text = "";
      this.tbFirstOpQty.Text = "";
      this.tbLastOpQty.Text = "";
      this.tbPO.Text = "";
      this.tbDueDate.Text = "";
      this.cbCustomers.Visible = false;
      this.tbCustomerName.BringToFront();
      this.tbCustomerName.Visible = true;
      this.tbCustomerName.Text = "";
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
      this.bPrint.Enabled = false;
      this.BackColor = SystemColors.Control;
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

    private void tbLastOpQty_Enter( object sender, EventArgs e )
    {
      int breakhere = 0;
      if (breakhere > 0)
      { }
    }
  }
}
