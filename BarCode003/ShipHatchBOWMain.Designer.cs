namespace BarCode003
{
  partial class ShipHatchBOWMain
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
      this.components = new System.ComponentModel.Container();
      this.nudSHPrintQty = new System.Windows.Forms.NumericUpDown();
      this.label12 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.cbLabelType = new System.Windows.Forms.ComboBox();
      this.bPrint = new System.Windows.Forms.Button();
      this.gbActions = new System.Windows.Forms.GroupBox();
      this.bExit = new System.Windows.Forms.Button();
      this.tbScannedInput = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.gbInputs = new System.Windows.Forms.GroupBox();
      this.bCmdReset = new System.Windows.Forms.Button();
      this.tResetTimer = new System.Windows.Forms.Timer(this.components);
      this.tbPartDescription = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.tbPartNumberRevisionOut = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.tbJobNumberOut = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.gbVerification = new System.Windows.Forms.GroupBox();
      this.tbCustLot = new System.Windows.Forms.TextBox();
      this.tbDueDate = new System.Windows.Forms.TextBox();
      this.label10 = new System.Windows.Forms.Label();
      this.lblCustLot = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.tbQtyOut = new System.Windows.Forms.TextBox();
      this.tbPrinterNameMain = new System.Windows.Forms.TextBox();
      this.cbUnlock = new System.Windows.Forms.CheckBox();
      this.bConfig = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.nudSHPrintQty)).BeginInit();
      this.gbActions.SuspendLayout();
      this.gbInputs.SuspendLayout();
      this.gbVerification.SuspendLayout();
      this.SuspendLayout();
      // 
      // nudSHPrintQty
      // 
      this.nudSHPrintQty.BackColor = System.Drawing.SystemColors.Menu;
      this.nudSHPrintQty.ForeColor = System.Drawing.SystemColors.MenuText;
      this.nudSHPrintQty.Location = new System.Drawing.Point(350, 9);
      this.nudSHPrintQty.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
      this.nudSHPrintQty.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.nudSHPrintQty.Name = "nudSHPrintQty";
      this.nudSHPrintQty.Size = new System.Drawing.Size(56, 20);
      this.nudSHPrintQty.TabIndex = 105;
      this.nudSHPrintQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.nudSHPrintQty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      // 
      // label12
      // 
      this.label12.AutoSize = true;
      this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label12.Location = new System.Drawing.Point(291, 13);
      this.label12.Name = "label12";
      this.label12.Size = new System.Drawing.Size(56, 13);
      this.label12.TabIndex = 104;
      this.label12.Text = "Print Qty";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(12, 13);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(70, 13);
      this.label1.TabIndex = 103;
      this.label1.Text = "Label Type";
      // 
      // cbLabelType
      // 
      this.cbLabelType.AllowDrop = true;
      this.cbLabelType.BackColor = System.Drawing.SystemColors.Menu;
      this.cbLabelType.Cursor = System.Windows.Forms.Cursors.Hand;
      this.cbLabelType.ForeColor = System.Drawing.SystemColors.MenuText;
      this.cbLabelType.FormattingEnabled = true;
      this.cbLabelType.Location = new System.Drawing.Point(83, 9);
      this.cbLabelType.Name = "cbLabelType";
      this.cbLabelType.Size = new System.Drawing.Size(154, 21);
      this.cbLabelType.TabIndex = 102;
      this.cbLabelType.TabStop = false;
      this.cbLabelType.SelectedIndexChanged += new System.EventHandler(this.cbLabelType_SelectedIndexChanged);
      // 
      // bPrint
      // 
      this.bPrint.AutoSize = true;
      this.bPrint.Enabled = false;
      this.bPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.bPrint.Location = new System.Drawing.Point(71, 21);
      this.bPrint.Name = "bPrint";
      this.bPrint.Size = new System.Drawing.Size(75, 26);
      this.bPrint.TabIndex = 107;
      this.bPrint.Text = "Print";
      this.bPrint.UseVisualStyleBackColor = true;
      this.bPrint.Click += new System.EventHandler(this.bPrint_Click);
      // 
      // gbActions
      // 
      this.gbActions.Controls.Add(this.bExit);
      this.gbActions.Controls.Add(this.bPrint);
      this.gbActions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.gbActions.Location = new System.Drawing.Point(12, 245);
      this.gbActions.Name = "gbActions";
      this.gbActions.Size = new System.Drawing.Size(406, 61);
      this.gbActions.TabIndex = 106;
      this.gbActions.TabStop = false;
      this.gbActions.Text = "Actions";
      // 
      // bExit
      // 
      this.bExit.Location = new System.Drawing.Point(319, 21);
      this.bExit.Name = "bExit";
      this.bExit.Size = new System.Drawing.Size(75, 26);
      this.bExit.TabIndex = 0;
      this.bExit.Text = "Exit";
      this.bExit.UseVisualStyleBackColor = true;
      this.bExit.Click += new System.EventHandler(this.bExit_Click);
      // 
      // tbScannedInput
      // 
      this.tbScannedInput.Location = new System.Drawing.Point(83, 65);
      this.tbScannedInput.MaxLength = 11;
      this.tbScannedInput.Name = "tbScannedInput";
      this.tbScannedInput.Size = new System.Drawing.Size(100, 20);
      this.tbScannedInput.TabIndex = 108;
      this.tbScannedInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbJobNumberInput_KeyPress);
      this.tbScannedInput.Leave += new System.EventHandler(this.tbJobNumberInput_Leave);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(4, 24);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(64, 13);
      this.label2.TabIndex = 109;
      this.label2.Text = "Job Number";
      // 
      // gbInputs
      // 
      this.gbInputs.BackColor = System.Drawing.SystemColors.ButtonFace;
      this.gbInputs.Controls.Add(this.bCmdReset);
      this.gbInputs.Controls.Add(this.label2);
      this.gbInputs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.gbInputs.Location = new System.Drawing.Point(12, 45);
      this.gbInputs.Name = "gbInputs";
      this.gbInputs.Size = new System.Drawing.Size(406, 51);
      this.gbInputs.TabIndex = 110;
      this.gbInputs.TabStop = false;
      this.gbInputs.Text = "Inputs";
      // 
      // bCmdReset
      // 
      this.bCmdReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.bCmdReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.bCmdReset.Location = new System.Drawing.Point(338, 17);
      this.bCmdReset.Name = "bCmdReset";
      this.bCmdReset.Size = new System.Drawing.Size(56, 23);
      this.bCmdReset.TabIndex = 0;
      this.bCmdReset.Text = "&R";
      this.bCmdReset.UseVisualStyleBackColor = true;
      this.bCmdReset.Click += new System.EventHandler(this.bCmdReset_Click);
      // 
      // tResetTimer
      // 
      this.tResetTimer.Interval = 1000;
      this.tResetTimer.Tick += new System.EventHandler(this.tResetTimer_Tick);
      // 
      // tbPartDescription
      // 
      this.tbPartDescription.BackColor = System.Drawing.Color.Black;
      this.tbPartDescription.ForeColor = System.Drawing.Color.White;
      this.tbPartDescription.Location = new System.Drawing.Point(83, 173);
      this.tbPartDescription.Name = "tbPartDescription";
      this.tbPartDescription.Size = new System.Drawing.Size(323, 20);
      this.tbPartDescription.TabIndex = 116;
      this.tbPartDescription.TabStop = false;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label5.Location = new System.Drawing.Point(14, 70);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(54, 13);
      this.label5.TabIndex = 115;
      this.label5.Text = "Part Desc";
      // 
      // tbPartNumberRevisionOut
      // 
      this.tbPartNumberRevisionOut.BackColor = System.Drawing.Color.Black;
      this.tbPartNumberRevisionOut.ForeColor = System.Drawing.Color.White;
      this.tbPartNumberRevisionOut.Location = new System.Drawing.Point(83, 151);
      this.tbPartNumberRevisionOut.Name = "tbPartNumberRevisionOut";
      this.tbPartNumberRevisionOut.Size = new System.Drawing.Size(225, 20);
      this.tbPartNumberRevisionOut.TabIndex = 114;
      this.tbPartNumberRevisionOut.TabStop = false;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.Location = new System.Drawing.Point(12, 48);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(56, 13);
      this.label4.TabIndex = 113;
      this.label4.Text = "Job Part #";
      // 
      // tbJobNumberOut
      // 
      this.tbJobNumberOut.BackColor = System.Drawing.Color.Black;
      this.tbJobNumberOut.ForeColor = System.Drawing.Color.White;
      this.tbJobNumberOut.Location = new System.Drawing.Point(83, 129);
      this.tbJobNumberOut.Name = "tbJobNumberOut";
      this.tbJobNumberOut.Size = new System.Drawing.Size(100, 20);
      this.tbJobNumberOut.TabIndex = 111;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(4, 26);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(64, 13);
      this.label3.TabIndex = 112;
      this.label3.Text = "Job Number";
      // 
      // gbVerification
      // 
      this.gbVerification.BackColor = System.Drawing.SystemColors.ButtonFace;
      this.gbVerification.Controls.Add(this.tbCustLot);
      this.gbVerification.Controls.Add(this.tbDueDate);
      this.gbVerification.Controls.Add(this.label5);
      this.gbVerification.Controls.Add(this.label3);
      this.gbVerification.Controls.Add(this.label10);
      this.gbVerification.Controls.Add(this.lblCustLot);
      this.gbVerification.Controls.Add(this.label6);
      this.gbVerification.Controls.Add(this.tbQtyOut);
      this.gbVerification.Controls.Add(this.label4);
      this.gbVerification.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.gbVerification.Location = new System.Drawing.Point(12, 106);
      this.gbVerification.Name = "gbVerification";
      this.gbVerification.Size = new System.Drawing.Size(406, 123);
      this.gbVerification.TabIndex = 117;
      this.gbVerification.TabStop = false;
      this.gbVerification.Text = "Verification";
      // 
      // tbCustLot
      // 
      this.tbCustLot.BackColor = System.Drawing.Color.Black;
      this.tbCustLot.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tbCustLot.ForeColor = System.Drawing.Color.White;
      this.tbCustLot.Location = new System.Drawing.Point(71, 89);
      this.tbCustLot.Name = "tbCustLot";
      this.tbCustLot.Size = new System.Drawing.Size(100, 20);
      this.tbCustLot.TabIndex = 126;
      this.tbCustLot.TabStop = false;
      // 
      // tbDueDate
      // 
      this.tbDueDate.BackColor = System.Drawing.Color.Black;
      this.tbDueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tbDueDate.ForeColor = System.Drawing.Color.White;
      this.tbDueDate.Location = new System.Drawing.Point(294, 89);
      this.tbDueDate.Name = "tbDueDate";
      this.tbDueDate.Size = new System.Drawing.Size(100, 20);
      this.tbDueDate.TabIndex = 125;
      this.tbDueDate.TabStop = false;
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label10.Location = new System.Drawing.Point(240, 93);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(53, 13);
      this.label10.TabIndex = 124;
      this.label10.Text = "Due Date";
      // 
      // lblCustLot
      // 
      this.lblCustLot.AutoSize = true;
      this.lblCustLot.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblCustLot.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.lblCustLot.Location = new System.Drawing.Point(46, 93);
      this.lblCustLot.Name = "lblCustLot";
      this.lblCustLot.Size = new System.Drawing.Size(22, 13);
      this.lblCustLot.TabIndex = 122;
      this.lblCustLot.Text = "Lot";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label6.Location = new System.Drawing.Point(312, 48);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(23, 13);
      this.label6.TabIndex = 119;
      this.label6.Text = "Qty";
      // 
      // tbQtyOut
      // 
      this.tbQtyOut.BackColor = System.Drawing.Color.Black;
      this.tbQtyOut.ForeColor = System.Drawing.Color.White;
      this.tbQtyOut.Location = new System.Drawing.Point(338, 43);
      this.tbQtyOut.Name = "tbQtyOut";
      this.tbQtyOut.Size = new System.Drawing.Size(56, 22);
      this.tbQtyOut.TabIndex = 118;
      this.tbQtyOut.TabStop = false;
      // 
      // tbPrinterNameMain
      // 
      this.tbPrinterNameMain.Cursor = System.Windows.Forms.Cursors.Default;
      this.tbPrinterNameMain.Font = new System.Drawing.Font("Calibri", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tbPrinterNameMain.Location = new System.Drawing.Point(12, 324);
      this.tbPrinterNameMain.Name = "tbPrinterNameMain";
      this.tbPrinterNameMain.ReadOnly = true;
      this.tbPrinterNameMain.Size = new System.Drawing.Size(60, 17);
      this.tbPrinterNameMain.TabIndex = 120;
      this.tbPrinterNameMain.Text = "ZebraBoxLabel";
      this.tbPrinterNameMain.Click += new System.EventHandler(this.tbPrinter_Click);
      this.tbPrinterNameMain.DoubleClick += new System.EventHandler(this.tbPrinter_DoubleClick);
      // 
      // cbUnlock
      // 
      this.cbUnlock.AutoSize = true;
      this.cbUnlock.ForeColor = System.Drawing.Color.Red;
      this.cbUnlock.Location = new System.Drawing.Point(262, 324);
      this.cbUnlock.Name = "cbUnlock";
      this.cbUnlock.Size = new System.Drawing.Size(151, 17);
      this.cbUnlock.TabIndex = 121;
      this.cbUnlock.Text = "Unlock for ALL Job Orders";
      this.cbUnlock.UseVisualStyleBackColor = true;
      this.cbUnlock.CheckedChanged += new System.EventHandler(this.cbUnlock_CheckedChanged);
      // 
      // bConfig
      // 
      this.bConfig.AutoSize = true;
      this.bConfig.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.bConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.bConfig.Location = new System.Drawing.Point(115, 322);
      this.bConfig.Name = "bConfig";
      this.bConfig.Size = new System.Drawing.Size(43, 19);
      this.bConfig.TabIndex = 122;
      this.bConfig.Text = "Config";
      this.bConfig.UseVisualStyleBackColor = true;
      this.bConfig.Click += new System.EventHandler(this.bConfig_Click);
      // 
      // ShipHatchBOWMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(432, 351);
      this.ControlBox = false;
      this.Controls.Add(this.bConfig);
      this.Controls.Add(this.cbUnlock);
      this.Controls.Add(this.tbPrinterNameMain);
      this.Controls.Add(this.tbPartDescription);
      this.Controls.Add(this.tbPartNumberRevisionOut);
      this.Controls.Add(this.tbJobNumberOut);
      this.Controls.Add(this.gbVerification);
      this.Controls.Add(this.tbScannedInput);
      this.Controls.Add(this.gbInputs);
      this.Controls.Add(this.gbActions);
      this.Controls.Add(this.nudSHPrintQty);
      this.Controls.Add(this.label12);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.cbLabelType);
      this.ForeColor = System.Drawing.SystemColors.ControlText;
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
      this.Name = "ShipHatchBOWMain";
      this.Text = "Ship Hatch BOW";
      this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.ShipHatchBOWMain_HelpRequested);
      ((System.ComponentModel.ISupportInitialize)(this.nudSHPrintQty)).EndInit();
      this.gbActions.ResumeLayout(false);
      this.gbActions.PerformLayout();
      this.gbInputs.ResumeLayout(false);
      this.gbInputs.PerformLayout();
      this.gbVerification.ResumeLayout(false);
      this.gbVerification.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.NumericUpDown nudSHPrintQty;
    private System.Windows.Forms.Label label12;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.ComboBox cbLabelType;
    private System.Windows.Forms.Button bPrint;
    private System.Windows.Forms.GroupBox gbActions;
    private System.Windows.Forms.Button bExit;
    private System.Windows.Forms.TextBox tbScannedInput;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.GroupBox gbInputs;
    private System.Windows.Forms.Button bCmdReset;
    private System.Windows.Forms.Timer tResetTimer;
    private System.Windows.Forms.TextBox tbPartDescription;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox tbPartNumberRevisionOut;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox tbJobNumberOut;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.GroupBox gbVerification;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.TextBox tbQtyOut;
    internal System.Windows.Forms.Label lblCustLot;
    private System.Windows.Forms.TextBox tbCustLot;
    private System.Windows.Forms.TextBox tbDueDate;
    private System.Windows.Forms.Label label10;
    internal System.Windows.Forms.TextBox tbPrinterNameMain;
    internal System.Windows.Forms.CheckBox cbUnlock;
    private System.Windows.Forms.Button bConfig;
  }
}