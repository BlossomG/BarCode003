namespace BarCode003
{
  partial class Error
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
      this.tbMessage = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // tbMessage
      // 
      this.tbMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tbMessage.CausesValidation = false;
      this.tbMessage.Cursor = System.Windows.Forms.Cursors.Default;
      this.tbMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tbMessage.ForeColor = System.Drawing.Color.Black;
      this.tbMessage.ImeMode = System.Windows.Forms.ImeMode.Off;
      this.tbMessage.Location = new System.Drawing.Point(52, 56);
      this.tbMessage.Multiline = true;
      this.tbMessage.Name = "tbMessage";
      this.tbMessage.ReadOnly = true;
      this.tbMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.tbMessage.ShortcutsEnabled = false;
      this.tbMessage.Size = new System.Drawing.Size(784, 392);
      this.tbMessage.TabIndex = 0;
      this.tbMessage.TabStop = false;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.ForeColor = System.Drawing.Color.White;
      this.label1.Location = new System.Drawing.Point(289, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(298, 31);
      this.label1.TabIndex = 1;
      this.label1.Text = "Errors Have Occurred";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // Error
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Red;
      this.ClientSize = new System.Drawing.Size(893, 492);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.tbMessage);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.ForeColor = System.Drawing.Color.Black;
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
      this.Margin = new System.Windows.Forms.Padding(6);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "Error";
      this.Text = "An Error Has Occurred";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox tbMessage;
    private System.Windows.Forms.Label label1;
  }
}