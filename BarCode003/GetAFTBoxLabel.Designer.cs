namespace BarCode003
{
  partial class GetAFTBoxLabel
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
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.lblQty = new System.Windows.Forms.Label();
      this.bBLOK = new System.Windows.Forms.Button();
      this.bCancel = new System.Windows.Forms.Button();
      this.tbScannedInput = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(10, 13);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(152, 15);
      this.label1.TabIndex = 0;
      this.label1.Text = "SCAN THE BOX LABEL";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(13, 42);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(115, 13);
      this.label2.TabIndex = 1;
      this.label2.Text = "Quantity Remaining is: ";
      // 
      // lblQty
      // 
      this.lblQty.AutoSize = true;
      this.lblQty.Location = new System.Drawing.Point(129, 42);
      this.lblQty.Name = "lblQty";
      this.lblQty.Size = new System.Drawing.Size(13, 13);
      this.lblQty.TabIndex = 2;
      this.lblQty.Text = "0";
      // 
      // bBLOK
      // 
      this.bBLOK.AutoSize = true;
      this.bBLOK.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.bBLOK.Enabled = false;
      this.bBLOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.bBLOK.Location = new System.Drawing.Point(255, 13);
      this.bBLOK.Name = "bBLOK";
      this.bBLOK.Size = new System.Drawing.Size(75, 25);
      this.bBLOK.TabIndex = 3;
      this.bBLOK.Text = "OK";
      this.bBLOK.UseVisualStyleBackColor = true;
      // 
      // bCancel
      // 
      this.bCancel.AutoSize = true;
      this.bCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.bCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.bCancel.Location = new System.Drawing.Point(255, 44);
      this.bCancel.Name = "bCancel";
      this.bCancel.Size = new System.Drawing.Size(75, 25);
      this.bCancel.TabIndex = 4;
      this.bCancel.Text = "Cancel";
      this.bCancel.UseVisualStyleBackColor = true;
      // 
      // tbScannedInput
      // 
      this.tbScannedInput.Location = new System.Drawing.Point(13, 82);
      this.tbScannedInput.Name = "tbScannedInput";
      this.tbScannedInput.ShortcutsEnabled = false;
      this.tbScannedInput.Size = new System.Drawing.Size(317, 20);
      this.tbScannedInput.TabIndex = 5;
      this.tbScannedInput.TabStop = false;
      this.tbScannedInput.TextChanged += new System.EventHandler(this.tbScannedInput_TextChanged);
      // 
      // GetAFTBoxLabel
      // 
      this.AcceptButton = this.bBLOK;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.bCancel;
      this.ClientSize = new System.Drawing.Size(348, 131);
      this.ControlBox = false;
      this.Controls.Add(this.tbScannedInput);
      this.Controls.Add(this.bCancel);
      this.Controls.Add(this.bBLOK);
      this.Controls.Add(this.lblQty);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.Name = "GetAFTBoxLabel";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.Text = "Scan the Box Label";
      this.Activated += new System.EventHandler(this.GetAFTBoxLabel_Activated);
      this.Load += new System.EventHandler(this.GetAFTBoxLabel_Load);
      this.VisibleChanged += new System.EventHandler(this.GetAFTBoxLabel_VisibleChanged);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label lblQty;
    private System.Windows.Forms.Button bBLOK;
    private System.Windows.Forms.Button bCancel;
    public System.Windows.Forms.TextBox tbScannedInput;
  }
}