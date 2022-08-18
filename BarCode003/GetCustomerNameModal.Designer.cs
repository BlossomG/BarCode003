namespace BarCode003
{
  partial class GetCustomerNameModal
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
      this.tbNewCustomerName = new System.Windows.Forms.TextBox();
      this.bNewCNSave = new System.Windows.Forms.Button();
      this.bNewCNCancel = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(12, 8);
      this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(216, 24);
      this.label1.TabIndex = 0;
      this.label1.Text = "Enter Customer Name";
      // 
      // tbNewCustomerName
      // 
      this.tbNewCustomerName.AccessibleDescription = "tbNewCustomerName";
      this.tbNewCustomerName.AccessibleName = "tbNewCustomerName";
      this.tbNewCustomerName.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
      this.tbNewCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tbNewCustomerName.Location = new System.Drawing.Point(28, 37);
      this.tbNewCustomerName.Margin = new System.Windows.Forms.Padding(2);
      this.tbNewCustomerName.Name = "tbNewCustomerName";
      this.tbNewCustomerName.Size = new System.Drawing.Size(463, 23);
      this.tbNewCustomerName.TabIndex = 1;
      // 
      // bNewCNSave
      // 
      this.bNewCNSave.AutoSize = true;
      this.bNewCNSave.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.bNewCNSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.bNewCNSave.Location = new System.Drawing.Point(98, 66);
      this.bNewCNSave.Margin = new System.Windows.Forms.Padding(2);
      this.bNewCNSave.Name = "bNewCNSave";
      this.bNewCNSave.Size = new System.Drawing.Size(91, 27);
      this.bNewCNSave.TabIndex = 2;
      this.bNewCNSave.Text = "Save";
      this.bNewCNSave.UseVisualStyleBackColor = true;
      // 
      // bNewCNCancel
      // 
      this.bNewCNCancel.AutoSize = true;
      this.bNewCNCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.bNewCNCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.bNewCNCancel.Location = new System.Drawing.Point(274, 66);
      this.bNewCNCancel.Margin = new System.Windows.Forms.Padding(2);
      this.bNewCNCancel.Name = "bNewCNCancel";
      this.bNewCNCancel.Size = new System.Drawing.Size(111, 27);
      this.bNewCNCancel.TabIndex = 3;
      this.bNewCNCancel.Text = "Cancel";
      this.bNewCNCancel.UseVisualStyleBackColor = true;
      // 
      // GetCustomerNameModal
      // 
      this.AcceptButton = this.bNewCNSave;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.bNewCNCancel;
      this.ClientSize = new System.Drawing.Size(502, 114);
      this.ControlBox = false;
      this.Controls.Add(this.bNewCNCancel);
      this.Controls.Add(this.bNewCNSave);
      this.Controls.Add(this.tbNewCustomerName);
      this.Controls.Add(this.label1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.Margin = new System.Windows.Forms.Padding(2);
      this.Name = "GetCustomerNameModal";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.Text = "Enter Customer Name";
      this.Activated += new System.EventHandler(this.GetCustomerNameModal_Activated);
      this.Load += new System.EventHandler(this.GetCustomerNameModal_Load);
      this.VisibleChanged += new System.EventHandler(this.GetCustomerNameModal_VisibleChanged);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    public System.Windows.Forms.TextBox tbNewCustomerName;
    private System.Windows.Forms.Button bNewCNSave;
    private System.Windows.Forms.Button bNewCNCancel;
  }
}