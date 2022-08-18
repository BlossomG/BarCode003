namespace BarCode003
{
  partial class GetUnlockPassword
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
      this.tbPWD = new System.Windows.Forms.TextBox();
      this.bOK = new System.Windows.Forms.Button();
      this.bCancel = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(13, 13);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(198, 16);
      this.label1.TabIndex = 0;
      this.label1.Text = "OPEN LABEL GENERATOR";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(12, 38);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(101, 13);
      this.label2.TabIndex = 1;
      this.label2.Text = "Enter the password:";
      // 
      // tbPWD
      // 
      this.tbPWD.Location = new System.Drawing.Point(114, 34);
      this.tbPWD.Name = "tbPWD";
      this.tbPWD.PasswordChar = '*';
      this.tbPWD.Size = new System.Drawing.Size(100, 20);
      this.tbPWD.TabIndex = 2;
      // 
      // bOK
      // 
      this.bOK.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.bOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.bOK.Location = new System.Drawing.Point(16, 70);
      this.bOK.Name = "bOK";
      this.bOK.Size = new System.Drawing.Size(75, 23);
      this.bOK.TabIndex = 4;
      this.bOK.Text = "OK";
      this.bOK.UseVisualStyleBackColor = true;
      // 
      // bCancel
      // 
      this.bCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.bCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.bCancel.Location = new System.Drawing.Point(135, 70);
      this.bCancel.Name = "bCancel";
      this.bCancel.Size = new System.Drawing.Size(75, 23);
      this.bCancel.TabIndex = 5;
      this.bCancel.Text = "Cancel";
      this.bCancel.UseVisualStyleBackColor = true;
      // 
      // GetUnlockPassword
      // 
      this.AcceptButton = this.bOK;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.bCancel;
      this.ClientSize = new System.Drawing.Size(234, 111);
      this.ControlBox = false;
      this.Controls.Add(this.bCancel);
      this.Controls.Add(this.bOK);
      this.Controls.Add(this.tbPWD);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Name = "GetUnlockPassword";
      this.Text = "Open Label Printer";
      this.Activated += new System.EventHandler(this.GetUnlockPassword_Activated);
      this.Load += new System.EventHandler(this.GetUnlockPassword_Load);
      this.VisibleChanged += new System.EventHandler(this.GetUnlockPassword_VisibleChanged);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button bOK;
    private System.Windows.Forms.Button bCancel;
    public System.Windows.Forms.TextBox tbPWD;
  }
}