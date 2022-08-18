namespace BarCode003
{
  partial class GetAFTShipQuantity
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose( bool disposing )
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.tbScannedInput = new System.Windows.Forms.TextBox();
      this.bCancel = new System.Windows.Forms.Button();
      this.bBLOK = new System.Windows.Forms.Button();
      this.lblQty = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.lblLot = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // tbScannedInput
      // 
      this.tbScannedInput.Location = new System.Drawing.Point(15, 83);
      this.tbScannedInput.Name = "tbScannedInput";
      this.tbScannedInput.ShortcutsEnabled = false;
      this.tbScannedInput.Size = new System.Drawing.Size(317, 20);
      this.tbScannedInput.TabIndex = 11;
      this.tbScannedInput.TabStop = false;
      this.tbScannedInput.TextChanged += new System.EventHandler(this.tbScannedInput_TextChanged);
      // 
      // bCancel
      // 
      this.bCancel.AutoSize = true;
      this.bCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.bCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.bCancel.Location = new System.Drawing.Point(257, 45);
      this.bCancel.Name = "bCancel";
      this.bCancel.Size = new System.Drawing.Size(75, 25);
      this.bCancel.TabIndex = 10;
      this.bCancel.Text = "Cancel";
      this.bCancel.UseVisualStyleBackColor = true;
      // 
      // bBLOK
      // 
      this.bBLOK.AutoSize = true;
      this.bBLOK.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.bBLOK.Enabled = false;
      this.bBLOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.bBLOK.Location = new System.Drawing.Point(257, 14);
      this.bBLOK.Name = "bBLOK";
      this.bBLOK.Size = new System.Drawing.Size(75, 25);
      this.bBLOK.TabIndex = 9;
      this.bBLOK.Text = "OK";
      this.bBLOK.UseVisualStyleBackColor = true;
      // 
      // lblQty
      // 
      this.lblQty.AutoSize = true;
      this.lblQty.Location = new System.Drawing.Point(137, 52);
      this.lblQty.Name = "lblQty";
      this.lblQty.Size = new System.Drawing.Size(13, 13);
      this.lblQty.TabIndex = 8;
      this.lblQty.Text = "0";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(21, 52);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(115, 13);
      this.label2.TabIndex = 7;
      this.label2.Text = "Quantity Remaining is: ";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(12, 14);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(235, 15);
      this.label1.TabIndex = 6;
      this.label1.Text = "Enter the Quantity in the box to ship";
      // 
      // lblLot
      // 
      this.lblLot.AutoSize = true;
      this.lblLot.Location = new System.Drawing.Point(21, 35);
      this.lblLot.Name = "lblLot";
      this.lblLot.Size = new System.Drawing.Size(61, 13);
      this.lblLot.TabIndex = 12;
      this.lblLot.Text = "LOT ?????";
      // 
      // GetAFTShipQuantity
      // 
      this.AcceptButton = this.bBLOK;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.bCancel;
      this.ClientSize = new System.Drawing.Size(348, 131);
      this.ControlBox = false;
      this.Controls.Add(this.lblLot);
      this.Controls.Add(this.tbScannedInput);
      this.Controls.Add(this.bCancel);
      this.Controls.Add(this.bBLOK);
      this.Controls.Add(this.lblQty);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Name = "GetAFTShipQuantity";
      this.Text = "Enter Quantity";
      this.Activated += new System.EventHandler(this.GetAFTShipQuantity_Activated);
      this.Load += new System.EventHandler(this.GetAFTShipQuantity_Load);
      this.VisibleChanged += new System.EventHandler(this.GetAFTShipQuantity_VisibleChanged);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    public System.Windows.Forms.TextBox tbScannedInput;
    private System.Windows.Forms.Button bCancel;
    private System.Windows.Forms.Button bBLOK;
    private System.Windows.Forms.Label lblQty;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label lblLot;
  }
}