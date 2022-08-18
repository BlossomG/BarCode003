using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Reflection;

namespace BarCode003
{
  public partial class ShipHatchAFTMain : Form
  {
    public List<AFTStealthLabel> LabelsToPrint;

    public ShipHatchAFTMain()
    {
      if (!FacilityDB.Connected(this.Name))
      {
        Application.Run(new Error("No Database Connection Detected"));
        this.Close();
        return;
      }
      this.InitializeComponent();
      string[] lts = (string[])LabelType.LabelTypes();
      foreach (string lt in lts)
      {
        if (lt.IndexOf("DLQ") > -1)
        {
          this.tbDLQLabelType.Text = lt;
        }
        else
        {
          this.tbShipLabelType.Text = lt;
        }
      }
      string thingy = (typeof(ShipHatchAFTMain).Assembly.GetName().Version).ToString();
      this.Text = string.Format("Ship Hatch AFT: {0}", thingy);
      ActionLog.LogDB(this.Text, this.Name);
      this.tbDLQLabelType.Enabled = false;
      this.tbShipLabelType.Enabled = false;
      this.tbScannedInput.Focus();
    }

    private void tbScannedInput_KeyPress( object sender, KeyPressEventArgs e )
    {
      if (this.tbScannedInput.Text.Length == 6)
      {
        //e.Handled = true;
        string sni = this.tbScannedInput.Text;
        this.BackColor = Color.Orange;
        if (this.PostShippingNumber(sni))
        {
          this.BackColor = Color.Green;
          this.bPrint.Enabled = true;
        }
        else
        {
          this.BackColor = SystemColors.Control;
          this.bPrint.Enabled = false;
        }
        this.tbScannedInput.Focus();
      }
      else if (this.tbScannedInput.Text.Length == 0)
      {
        this.bCmdReset_Click(sender, e);
      }
    }

    private void tbShipperNumberInput_Leave( object sender, EventArgs e )
    {
      string jni = this.tbScannedInput.Text;
      string jno = this.tbShipperNumberOut.Text;
      if (string.IsNullOrWhiteSpace(jni))
      {
        if (string.IsNullOrWhiteSpace(jno))
        {
          this.BackColor = SystemColors.Control;
          this.bPrint.Enabled = false;
        }
        return;
      }
      this.BackColor = Color.Orange;
      if (this.PostShippingNumber(jni))
      {
        this.BackColor = Color.Green;
        this.bPrint.Enabled = true;
      }
      else
      {
        this.BackColor = SystemColors.Control;
        this.bPrint.Enabled = false;
      }
    }

    private bool PostShippingNumber( string shippingnumber )
    {
      this.StopTimer();
      this.BackColor = System.Drawing.Color.Orange;
      int TotalShipped = 0;
      int TotalToShip;
      AFTShippingNumberEnter answer = new AFTShippingNumberEnter(shippingnumber, this.Name);
      if (answer.Parts.Count > 0)
      {
        this.LabelsToPrint = new List<AFTStealthLabel>();
        this.tbScannedInput.Text = "";
        this.tbShipperNumberOut.Text = answer.ShippingNumberOut;
        this.tbPartNumberRevisionOut.Text = answer.Parts[0].PartNumber;
        this.tbPartDescription.Text = answer.Parts[0].PartDesc;
        this.tbPartQuantity.Text = answer.aQuantity.ToString();
        TotalToShip = answer.aQuantity;
        int box = 1;
        GetAFTBoxLabel mydialogA = new GetAFTBoxLabel((int)answer.Parts[0].Quantity);
        do //while (TotalShipped < TotalToShip);
        {
          mydialogA.tbScannedInput.Text = "";
          if (mydialogA.ShowDialog(this) == DialogResult.OK)
          {
            string scannedval = mydialogA.tbScannedInput.Text;
            int nloc = scannedval.IndexOf("%N");
            if ((!string.IsNullOrWhiteSpace(scannedval))
              && (nloc >= 5))
            {
              string scannedlot = scannedval.Substring(0, nloc).Trim().ToUpper();
              string scanPartNumber = scannedval.Substring(nloc + 2).Trim();
              bool foundit = false;
              int part_slot = 0;
              for (int i = 0; i < answer.Parts.Count; i++)
              {
                AFTPart part = (AFTPart)answer.Parts[i];
                if ((part.LotNumber == scannedlot)
                  && (part.PartNumber == scanPartNumber))
                {
                  foundit = true;
                  part_slot = i;
                  //TotalToShip = (int)part.Quantity;
                  break;
                }
              }
              if (foundit)
              {
                GetAFTShipQuantity mydialogB = new GetAFTShipQuantity((TotalToShip - TotalShipped), scannedlot);
                int scanqty = 0;
                scannedval = "TwentyOne";
                do
                {
                  DialogResult dr = mydialogB.ShowDialog(this);
                  if (dr == DialogResult.Cancel)
                  {
                    this.tbScannedInput.Focus();
                    return false;
                  }
                  scannedval = mydialogB.tbScannedInput.Text;
                  if (int.TryParse(scannedval, out scanqty))
                  {
                    if (scanqty > 0)
                    {
                      if (scanqty > (TotalToShip - TotalShipped))
                      {
                        string msg =
                          string.Format("{0} is too many.\nOnly shipping {1}."
                                      , scanqty, (TotalToShip - TotalShipped)
                                       );
                        MessageBox.Show(msg);
                        scanqty = (TotalToShip - TotalShipped);
                      }
                      break;
                    }
                    else
                    {
                      MessageBox.Show("You must enter a positive numeric value.");
                    }
                  }
                  else
                  {
                    MessageBox.Show("You must enter a positive numeric value.");
                  }
                } while (true);
                AFTStealthLabel model = new AFTStealthLabel();
                model.PartNumberA = scanPartNumber;
                model.PartNumberB = answer.Parts[part_slot].CustomerPartNumber;
                model.PONumber = answer.Parts[part_slot].PONumber;
                model.ShipperNumber = answer.Parts[part_slot].ShipperNumber;
                model.LotNumber = scannedlot;
                model.HeatNumber = answer.Parts[part_slot].HeatNumber;
                model.Quantity = scanqty;
                model.BoxNumber = box;
                model.KB = answer.Parts[part_slot].KB;
                model.Country = answer.Parts[part_slot].Country;
                model.PartDesc = answer.Parts[part_slot].PartDesc;
                this.LabelsToPrint.Add(model);
                TotalShipped += scanqty;
                box++;
              }
              else
              {
                string msg =
                  string.Format("{0}-{1} is an Invalid Combination."
                  , scannedlot, scanPartNumber);
                MessageBox.Show(msg);
                this.tbScannedInput.Focus();
                return false;
              }
            }
          }
          else
          {
            this.tbScannedInput.Focus();
            return false;
          }
        }
        while (TotalShipped < TotalToShip);
        this.myDataGridView.DataSource = this.LabelsToPrint;
        this.StartTimer();
      }
      else
      {
        this.EmptyFields();
        this.tbScannedInput.Focus();
        return false;
      }
      this.tbScannedInput.Focus();
      return true;
    }

    private void bPrint_Click( object sender, EventArgs e )
    {
      this.bPrint.Enabled = false; ;
      try
      {
        string fullPath = string.Format("{0}\\{1}.btw"
                                    , ConfigurationUtilities.LabelLocation()
                                    , this.tbShipLabelType.Text);
        string DLQPath = string.Format("{0}\\{1}.btw"
                                    , ConfigurationUtilities.LabelLocation()
                                    , this.tbDLQLabelType.Text);
        bool problem = false;
        string message = "";
        if (!System.IO.File.Exists(fullPath))
        {
          message += string.Format("The file {0} does not exist.\r\n", fullPath);
          problem = true;
        }
        if (!System.IO.File.Exists(DLQPath))
        {
          message += string.Format("The file {0} does not exist.", DLQPath);
          problem = true;
        }
        if (problem)
        {
          ActionLog.LogDB(message, this.Name);
          MessageBox.Show(message);
          this.tbScannedInput.Focus();
          return;
        }
        foreach (AFTStealthLabel aftsl in this.LabelsToPrint)
        {
          string boxnumber = string.Format("{0} of {1}", aftsl.BoxNumber, this.LabelsToPrint.Count);
          string altlabel = ConfigurationUtilities.AlternateLabelFor(aftsl.PartNumberA, aftsl.Country);
          if (string.IsNullOrEmpty(altlabel))
          {
            SeagullBC.StealthShipLabel(
                       fullPath
                     , 2
                     , aftsl.PartNumberA
                     , aftsl.PartNumberB
                     , aftsl.PONumber
                     , aftsl.ShipperNumber
                     , aftsl.LotNumber
                     , aftsl.HeatNumber
                     , aftsl.Quantity.ToString()
                     , boxnumber
                     , aftsl.KB
                     , this.Name
                     , this.tbPrinterNameMain.Text);
          }
          else if (altlabel.EndsWith("SNSwitzerlanShipLabel.btw"))
          {
            SeagullBC.Smith_NephewSwitzerland(
                       altlabel
                     , 2
                     , aftsl.PartNumberB
                     , aftsl.PartDesc
                     , aftsl.LotNumber
                     , ""
                     , aftsl.Quantity.ToString()
                     , ""
                     , boxnumber
                     , this.Name
                     , this.tbPrinterNameMain.Text
                     );
          }
        }
        int offset = 0;
        do
        {
          string strDie = "";
          string strBox1 = "", strBox2 = "", strBox3 = "";
          string strLot1 = "", strLot2 = "", strLot3 = "";
          string strQty1 = "", strQty2 = "", strQty3 = "";
          for (int i = 0; ((i + offset < this.LabelsToPrint.Count) && (i < 3)); i++)
          {
            int ai = i + offset;
            switch (i)
            {
              case 0:
                strDie = this.LabelsToPrint[0].PartNumberA;
                strBox1 = string.Format("Box {0}", this.LabelsToPrint[ai].BoxNumber);
                strLot1 = this.LabelsToPrint[ai].LotNumber;
                strQty1 = this.LabelsToPrint[ai].Quantity.ToString();
                break;
              case 1:
                strBox2 = string.Format("Box {0}", this.LabelsToPrint[ai].BoxNumber);
                strLot2 = this.LabelsToPrint[ai].LotNumber;
                strQty2 = this.LabelsToPrint[ai].Quantity.ToString();
                break;
              case 2:
                strBox3 = string.Format("Box {0}", this.LabelsToPrint[ai].BoxNumber);
                strLot3 = this.LabelsToPrint[ai].LotNumber;
                strQty3 = this.LabelsToPrint[ai].Quantity.ToString();
                break;
            }
          }
          SeagullBC.DLQLabel(DLQPath, 1, strDie
                           , strBox1, strBox2, strBox3
                           , strLot1, strLot2, strLot3
                           , strQty1, strQty2, strQty3
                           , this.Name
                           , this.tbPrinterNameOther.Text
                            );
          offset += 3;
        } while (offset < this.LabelsToPrint.Count);
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
      this.bPrint.Enabled = true;
      this.StartTimer(true, "10");
    }

    private void ShipHatchAFTMain_Activated( object sender, EventArgs e )
    {
      this.tbScannedInput.Focus();
    }

    private void ShipHatchAFTMain_Load( object sender, EventArgs e )
    {
      this.tbScannedInput.Focus();
    }

    private void ShipHatchAFTMain_VisibleChanged( object sender, EventArgs e )
    {
      this.tbScannedInput.Focus();
    }

    private void ShipHatchAFTMain_HelpRequested( object sender, HelpEventArgs hlpevent )
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
      this.tbShipperNumberOut.Text = "";
      this.tbPartNumberRevisionOut.Text = "";
      this.tbPartDescription.Text = "";
      this.myDataGridView.DataSource = new List<AFTStealthLabel>();
      this.StopTimer();
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
      this.bPrint.Enabled = false;
      this.tbScannedInput.Focus();
    }

    private void tbPrinter_DoubleClick( object sender, EventArgs e )
    {
      TextBox mySender = (TextBox)sender;
      mySender.SelectionLength = 0;
      GetUnlockPassword mydialogP = new GetUnlockPassword("Enter Password");
      string expected = "GEORGE";
      string inputpwd = "";
      if (mydialogP.ShowDialog(this) == DialogResult.OK)
      {
        inputpwd = mydialogP.tbPWD.Text.ToUpper();
        if (inputpwd == expected)
        {
          bool isMain = mySender.Name == "tbPrinterNameMain";
          string oldName = this.tbPrinterNameOther.Text;
          if (isMain)
          {
            oldName = this.tbPrinterNameMain.Text;
          }
          GetNewPrinterName mydialogA = new GetNewPrinterName(oldName);
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
              mySender.Text = newname;
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
