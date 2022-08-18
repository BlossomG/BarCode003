namespace BarCode003
{
  partial class GetPrintQty
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
      this.nudPrintQuantity = new System.Windows.Forms.NumericUpDown();
      this.bPrint = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.nudPrintQuantity)).BeginInit();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(7, 15);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(186, 24);
      this.label1.TabIndex = 0;
      this.label1.Text = "How Many Labels?";
      // 
      // nudPrintQuantity
      // 
      this.nudPrintQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.nudPrintQuantity.Location = new System.Drawing.Point(62, 42);
      this.nudPrintQuantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.nudPrintQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.nudPrintQuantity.Name = "nudPrintQuantity";
      this.nudPrintQuantity.Size = new System.Drawing.Size(75, 22);
      this.nudPrintQuantity.TabIndex = 1;
      this.nudPrintQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.nudPrintQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      // 
      // bPrint
      // 
      this.bPrint.AutoSize = true;
      this.bPrint.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.bPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.bPrint.Location = new System.Drawing.Point(62, 70);
      this.bPrint.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.bPrint.Name = "bPrint";
      this.bPrint.Size = new System.Drawing.Size(75, 34);
      this.bPrint.TabIndex = 2;
      this.bPrint.Text = "Print";
      this.bPrint.UseVisualStyleBackColor = true;
      // 
      // GetPrintQty
      // 
      this.AcceptButton = this.bPrint;
      this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(206, 124);
      this.ControlBox = false;
      this.Controls.Add(this.bPrint);
      this.Controls.Add(this.nudPrintQuantity);
      this.Controls.Add(this.label1);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
      this.Name = "GetPrintQty";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.Text = "Enter Print Quantity";
      ((System.ComponentModel.ISupportInitialize)(this.nudPrintQuantity)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    public System.Windows.Forms.NumericUpDown nudPrintQuantity;
    private System.Windows.Forms.Button bPrint;
  }
}