namespace BarCode003
{
  partial class ConfigurationPage
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
      this.dgvList = new System.Windows.Forms.DataGridView();
      this.bClose = new System.Windows.Forms.Button();
      this.bCancel = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
      this.SuspendLayout();
      // 
      // dgvList
      // 
      this.dgvList.AllowUserToDeleteRows = false;
      this.dgvList.AllowUserToResizeRows = false;
      this.dgvList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.dgvList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
      this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvList.Location = new System.Drawing.Point(13, 13);
      this.dgvList.Name = "dgvList";
      this.dgvList.RowHeadersVisible = false;
      this.dgvList.Size = new System.Drawing.Size(502, 385);
      this.dgvList.TabIndex = 0;
      // 
      // bClose
      // 
      this.bClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.bClose.AutoSize = true;
      this.bClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.bClose.Location = new System.Drawing.Point(108, 404);
      this.bClose.Name = "bClose";
      this.bClose.Size = new System.Drawing.Size(75, 30);
      this.bClose.TabIndex = 1;
      this.bClose.Text = "Save";
      this.bClose.UseVisualStyleBackColor = true;
      this.bClose.Click += new System.EventHandler(this.bClose_Click);
      // 
      // bCancel
      // 
      this.bCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.bCancel.AutoSize = true;
      this.bCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.bCancel.Location = new System.Drawing.Point(324, 404);
      this.bCancel.Name = "bCancel";
      this.bCancel.Size = new System.Drawing.Size(81, 30);
      this.bCancel.TabIndex = 2;
      this.bCancel.Text = "Cancel";
      this.bCancel.UseVisualStyleBackColor = true;
      this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
      // 
      // ConfigurationPage
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(531, 442);
      this.ControlBox = false;
      this.Controls.Add(this.bCancel);
      this.Controls.Add(this.bClose);
      this.Controls.Add(this.dgvList);
      this.Name = "ConfigurationPage";
      this.Text = "ConfigurationPage";
      ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.DataGridView dgvList;
    private System.Windows.Forms.Button bClose;
    private System.Windows.Forms.Button bCancel;
  }
}