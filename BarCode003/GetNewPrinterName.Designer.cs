namespace BarCode003
{
  partial class GetNewPrinterName
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
      this.tbNewName = new System.Windows.Forms.TextBox();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.bSave = new System.Windows.Forms.Button();
      this.bCancel = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(60, 13);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(164, 16);
      this.label1.TabIndex = 0;
      this.label1.Text = "Enter new printer name";
      // 
      // tbNewName
      // 
      this.tbNewName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tbNewName.Location = new System.Drawing.Point(27, 35);
      this.tbNewName.Name = "tbNewName";
      this.tbNewName.Size = new System.Drawing.Size(240, 22);
      this.tbNewName.TabIndex = 1;
      // 
      // textBox1
      // 
      this.textBox1.BackColor = System.Drawing.Color.White;
      this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.textBox1.ForeColor = System.Drawing.Color.Red;
      this.textBox1.Location = new System.Drawing.Point(16, 100);
      this.textBox1.Multiline = true;
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(262, 86);
      this.textBox1.TabIndex = 2;
      this.textBox1.TabStop = false;
      this.textBox1.Text = "WARNING!\r\nChanging the name of your printer COULD cause the wrong label to be pri" +
    "nted to the wrong printer OR not at all.";
      this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // bSave
      // 
      this.bSave.AutoSize = true;
      this.bSave.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.bSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.bSave.Location = new System.Drawing.Point(50, 64);
      this.bSave.Name = "bSave";
      this.bSave.Size = new System.Drawing.Size(75, 26);
      this.bSave.TabIndex = 3;
      this.bSave.Text = "Save";
      this.bSave.UseVisualStyleBackColor = true;
      // 
      // bCancel
      // 
      this.bCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.bCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.bCancel.Location = new System.Drawing.Point(168, 66);
      this.bCancel.Name = "bCancel";
      this.bCancel.Size = new System.Drawing.Size(75, 23);
      this.bCancel.TabIndex = 4;
      this.bCancel.Text = "Cancel";
      this.bCancel.UseVisualStyleBackColor = true;
      // 
      // GetNewPrinterName
      // 
      this.AcceptButton = this.bSave;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.bCancel;
      this.ClientSize = new System.Drawing.Size(299, 204);
      this.ControlBox = false;
      this.Controls.Add(this.bCancel);
      this.Controls.Add(this.bSave);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.tbNewName);
      this.Controls.Add(this.label1);
      this.Name = "GetNewPrinterName";
      this.Text = "New Printer Name?";
      this.Activated += new System.EventHandler(this.GetNewPrinterName_Activated);
      this.Load += new System.EventHandler(this.GetNewPrinterName_Load);
      this.VisibleChanged += new System.EventHandler(this.GetNewPrinterName_VisibleChanged);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    public System.Windows.Forms.TextBox tbNewName;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Button bSave;
    private System.Windows.Forms.Button bCancel;
  }
}