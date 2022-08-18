namespace BarCode003
{
  partial class ShipHatchAFTMain
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
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
      this.bPrint = new System.Windows.Forms.Button();
      this.gbActions = new System.Windows.Forms.GroupBox();
      this.bExit = new System.Windows.Forms.Button();
      this.tbScannedInput = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.gbInputs = new System.Windows.Forms.GroupBox();
      this.tbDLQLabelType = new System.Windows.Forms.TextBox();
      this.tbShipLabelType = new System.Windows.Forms.TextBox();
      this.label12 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.nudSHPrintQty = new System.Windows.Forms.NumericUpDown();
      this.bCmdReset = new System.Windows.Forms.Button();
      this.tResetTimer = new System.Windows.Forms.Timer(this.components);
      this.tbPartDescription = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.tbPartNumberRevisionOut = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.tbShipperNumberOut = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.gbVerification = new System.Windows.Forms.GroupBox();
      this.tbPartQuantity = new System.Windows.Forms.TextBox();
      this.label6 = new System.Windows.Forms.Label();
      this.myDataGridView = new System.Windows.Forms.DataGridView();
      this.BoxNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.PartNumberB = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.tbPrinterNameMain = new System.Windows.Forms.TextBox();
      this.tbPrinterNameOther = new System.Windows.Forms.TextBox();
      this.bConfig = new System.Windows.Forms.Button();
      this.gbActions.SuspendLayout();
      this.gbInputs.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.nudSHPrintQty)).BeginInit();
      this.gbVerification.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.myDataGridView)).BeginInit();
      this.SuspendLayout();
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
      this.gbActions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.gbActions.Controls.Add(this.bExit);
      this.gbActions.Controls.Add(this.bPrint);
      this.gbActions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.gbActions.Location = new System.Drawing.Point(12, 310);
      this.gbActions.Name = "gbActions";
      this.gbActions.Size = new System.Drawing.Size(406, 61);
      this.gbActions.TabIndex = 106;
      this.gbActions.TabStop = false;
      this.gbActions.Text = "Actions";
      // 
      // bExit
      // 
      this.bExit.Location = new System.Drawing.Point(319, 23);
      this.bExit.Name = "bExit";
      this.bExit.Size = new System.Drawing.Size(75, 26);
      this.bExit.TabIndex = 0;
      this.bExit.Text = "Exit";
      this.bExit.UseVisualStyleBackColor = true;
      this.bExit.Click += new System.EventHandler(this.bExit_Click);
      // 
      // tbScannedInput
      // 
      this.tbScannedInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tbScannedInput.Location = new System.Drawing.Point(7, 36);
      this.tbScannedInput.MaxLength = 11;
      this.tbScannedInput.Name = "tbScannedInput";
      this.tbScannedInput.Size = new System.Drawing.Size(124, 20);
      this.tbScannedInput.TabIndex = 108;
      this.tbScannedInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbScannedInput_KeyPress);
      this.tbScannedInput.Leave += new System.EventHandler(this.tbShipperNumberInput_Leave);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(4, 18);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(97, 13);
      this.label2.TabIndex = 109;
      this.label2.Text = "Shipper Number";
      // 
      // gbInputs
      // 
      this.gbInputs.BackColor = System.Drawing.SystemColors.ButtonFace;
      this.gbInputs.Controls.Add(this.tbDLQLabelType);
      this.gbInputs.Controls.Add(this.tbShipLabelType);
      this.gbInputs.Controls.Add(this.label12);
      this.gbInputs.Controls.Add(this.label1);
      this.gbInputs.Controls.Add(this.nudSHPrintQty);
      this.gbInputs.Controls.Add(this.bCmdReset);
      this.gbInputs.Controls.Add(this.tbScannedInput);
      this.gbInputs.Controls.Add(this.label2);
      this.gbInputs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.gbInputs.Location = new System.Drawing.Point(12, 2);
      this.gbInputs.Name = "gbInputs";
      this.gbInputs.Size = new System.Drawing.Size(406, 90);
      this.gbInputs.TabIndex = 110;
      this.gbInputs.TabStop = false;
      this.gbInputs.Text = "Inputs";
      // 
      // tbDLQLabelType
      // 
      this.tbDLQLabelType.Location = new System.Drawing.Point(181, 61);
      this.tbDLQLabelType.Name = "tbDLQLabelType";
      this.tbDLQLabelType.Size = new System.Drawing.Size(130, 22);
      this.tbDLQLabelType.TabIndex = 112;
      // 
      // tbShipLabelType
      // 
      this.tbShipLabelType.Location = new System.Drawing.Point(181, 35);
      this.tbShipLabelType.Name = "tbShipLabelType";
      this.tbShipLabelType.Size = new System.Drawing.Size(130, 22);
      this.tbShipLabelType.TabIndex = 111;
      // 
      // label12
      // 
      this.label12.AutoSize = true;
      this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label12.Location = new System.Drawing.Point(12, 61);
      this.label12.Name = "label12";
      this.label12.Size = new System.Drawing.Size(56, 13);
      this.label12.TabIndex = 104;
      this.label12.Text = "Print Qty";
      this.label12.Visible = false;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(178, 18);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(76, 13);
      this.label1.TabIndex = 110;
      this.label1.Text = "Label Types";
      // 
      // nudSHPrintQty
      // 
      this.nudSHPrintQty.BackColor = System.Drawing.SystemColors.Menu;
      this.nudSHPrintQty.ForeColor = System.Drawing.SystemColors.MenuText;
      this.nudSHPrintQty.Location = new System.Drawing.Point(71, 57);
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
      this.nudSHPrintQty.Size = new System.Drawing.Size(56, 22);
      this.nudSHPrintQty.TabIndex = 105;
      this.nudSHPrintQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.nudSHPrintQty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.nudSHPrintQty.Visible = false;
      // 
      // bCmdReset
      // 
      this.bCmdReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.bCmdReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.bCmdReset.Location = new System.Drawing.Point(360, 18);
      this.bCmdReset.Name = "bCmdReset";
      this.bCmdReset.Size = new System.Drawing.Size(34, 23);
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
      this.tbPartDescription.Location = new System.Drawing.Point(83, 159);
      this.tbPartDescription.Name = "tbPartDescription";
      this.tbPartDescription.Size = new System.Drawing.Size(323, 20);
      this.tbPartDescription.TabIndex = 116;
      this.tbPartDescription.TabStop = false;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label5.Location = new System.Drawing.Point(15, 64);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(54, 13);
      this.label5.TabIndex = 115;
      this.label5.Text = "Part Desc";
      // 
      // tbPartNumberRevisionOut
      // 
      this.tbPartNumberRevisionOut.BackColor = System.Drawing.Color.Black;
      this.tbPartNumberRevisionOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tbPartNumberRevisionOut.ForeColor = System.Drawing.Color.White;
      this.tbPartNumberRevisionOut.Location = new System.Drawing.Point(71, 38);
      this.tbPartNumberRevisionOut.Name = "tbPartNumberRevisionOut";
      this.tbPartNumberRevisionOut.Size = new System.Drawing.Size(183, 20);
      this.tbPartNumberRevisionOut.TabIndex = 114;
      this.tbPartNumberRevisionOut.TabStop = false;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.Location = new System.Drawing.Point(13, 42);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(56, 13);
      this.label4.TabIndex = 113;
      this.label4.Text = "Job Part #";
      // 
      // tbShipperNumberOut
      // 
      this.tbShipperNumberOut.BackColor = System.Drawing.Color.Black;
      this.tbShipperNumberOut.ForeColor = System.Drawing.Color.White;
      this.tbShipperNumberOut.Location = new System.Drawing.Point(110, 112);
      this.tbShipperNumberOut.Name = "tbShipperNumberOut";
      this.tbShipperNumberOut.Size = new System.Drawing.Size(100, 20);
      this.tbShipperNumberOut.TabIndex = 111;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(13, 17);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(83, 13);
      this.label3.TabIndex = 112;
      this.label3.Text = "Shipper Number";
      // 
      // gbVerification
      // 
      this.gbVerification.BackColor = System.Drawing.SystemColors.ButtonFace;
      this.gbVerification.Controls.Add(this.tbPartQuantity);
      this.gbVerification.Controls.Add(this.label6);
      this.gbVerification.Controls.Add(this.label5);
      this.gbVerification.Controls.Add(this.tbPartNumberRevisionOut);
      this.gbVerification.Controls.Add(this.myDataGridView);
      this.gbVerification.Controls.Add(this.label3);
      this.gbVerification.Controls.Add(this.label4);
      this.gbVerification.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.gbVerification.Location = new System.Drawing.Point(12, 98);
      this.gbVerification.Name = "gbVerification";
      this.gbVerification.Size = new System.Drawing.Size(406, 206);
      this.gbVerification.TabIndex = 117;
      this.gbVerification.TabStop = false;
      this.gbVerification.Text = "Verification";
      // 
      // tbPartQuantity
      // 
      this.tbPartQuantity.BackColor = System.Drawing.Color.Black;
      this.tbPartQuantity.ForeColor = System.Drawing.Color.White;
      this.tbPartQuantity.Location = new System.Drawing.Point(319, 37);
      this.tbPartQuantity.Name = "tbPartQuantity";
      this.tbPartQuantity.Size = new System.Drawing.Size(75, 22);
      this.tbPartQuantity.TabIndex = 116;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label6.Location = new System.Drawing.Point(285, 42);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(23, 13);
      this.label6.TabIndex = 115;
      this.label6.Text = "Qty";
      // 
      // myDataGridView
      // 
      this.myDataGridView.AllowUserToAddRows = false;
      this.myDataGridView.AllowUserToDeleteRows = false;
      this.myDataGridView.AllowUserToResizeColumns = false;
      this.myDataGridView.AllowUserToResizeRows = false;
      this.myDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.myDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
      dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
      dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaption;
      dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.myDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
      this.myDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
      this.myDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BoxNumber,
            this.PartNumberB,
            this.Quantity});
      dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
      dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
      dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
      dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.myDataGridView.DefaultCellStyle = dataGridViewCellStyle4;
      this.myDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
      this.myDataGridView.Location = new System.Drawing.Point(7, 93);
      this.myDataGridView.MultiSelect = false;
      this.myDataGridView.Name = "myDataGridView";
      this.myDataGridView.ReadOnly = true;
      this.myDataGridView.RowHeadersVisible = false;
      this.myDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.None;
      this.myDataGridView.ShowEditingIcon = false;
      this.myDataGridView.Size = new System.Drawing.Size(393, 105);
      this.myDataGridView.TabIndex = 114;
      this.myDataGridView.TabStop = false;
      // 
      // BoxNumber
      // 
      this.BoxNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
      this.BoxNumber.DataPropertyName = "BoxNumber";
      this.BoxNumber.HeaderText = "Box #";
      this.BoxNumber.Name = "BoxNumber";
      this.BoxNumber.ReadOnly = true;
      this.BoxNumber.Resizable = System.Windows.Forms.DataGridViewTriState.False;
      this.BoxNumber.Width = 75;
      // 
      // PartNumberB
      // 
      this.PartNumberB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
      this.PartNumberB.DataPropertyName = "PartNumberB";
      this.PartNumberB.HeaderText = "Cust Part Number";
      this.PartNumberB.Name = "PartNumberB";
      this.PartNumberB.ReadOnly = true;
      this.PartNumberB.Resizable = System.Windows.Forms.DataGridViewTriState.False;
      this.PartNumberB.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
      this.PartNumberB.Width = 159;
      // 
      // Quantity
      // 
      this.Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
      this.Quantity.DataPropertyName = "Quantity";
      this.Quantity.HeaderText = "Quantity";
      this.Quantity.Name = "Quantity";
      this.Quantity.ReadOnly = true;
      this.Quantity.Resizable = System.Windows.Forms.DataGridViewTriState.False;
      this.Quantity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
      this.Quantity.Width = 159;
      // 
      // tbPrinterNameMain
      // 
      this.tbPrinterNameMain.Cursor = System.Windows.Forms.Cursors.Default;
      this.tbPrinterNameMain.Font = new System.Drawing.Font("Calibri", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tbPrinterNameMain.Location = new System.Drawing.Point(12, 381);
      this.tbPrinterNameMain.Name = "tbPrinterNameMain";
      this.tbPrinterNameMain.ReadOnly = true;
      this.tbPrinterNameMain.Size = new System.Drawing.Size(60, 17);
      this.tbPrinterNameMain.TabIndex = 119;
      this.tbPrinterNameMain.Text = "ZebraBoxLabel";
      this.tbPrinterNameMain.Click += new System.EventHandler(this.tbPrinter_Click);
      this.tbPrinterNameMain.DoubleClick += new System.EventHandler(this.tbPrinter_DoubleClick);
      // 
      // tbPrinterNameOther
      // 
      this.tbPrinterNameOther.Cursor = System.Windows.Forms.Cursors.Default;
      this.tbPrinterNameOther.Font = new System.Drawing.Font("Calibri", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tbPrinterNameOther.Location = new System.Drawing.Point(332, 381);
      this.tbPrinterNameOther.Name = "tbPrinterNameOther";
      this.tbPrinterNameOther.Size = new System.Drawing.Size(83, 17);
      this.tbPrinterNameOther.TabIndex = 118;
      this.tbPrinterNameOther.Text = "BrotherShipperLabel";
      this.tbPrinterNameOther.Click += new System.EventHandler(this.tbPrinter_Click);
      this.tbPrinterNameOther.DoubleClick += new System.EventHandler(this.tbPrinter_DoubleClick);
      // 
      // bConfig
      // 
      this.bConfig.AutoSize = true;
      this.bConfig.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.bConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.bConfig.Location = new System.Drawing.Point(179, 379);
      this.bConfig.Name = "bConfig";
      this.bConfig.Size = new System.Drawing.Size(43, 19);
      this.bConfig.TabIndex = 120;
      this.bConfig.Text = "Config";
      this.bConfig.UseVisualStyleBackColor = true;
      this.bConfig.Click += new System.EventHandler(this.bConfig_Click);
      // 
      // ShipHatchAFTMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(432, 406);
      this.ControlBox = false;
      this.Controls.Add(this.bConfig);
      this.Controls.Add(this.tbPrinterNameMain);
      this.Controls.Add(this.tbPrinterNameOther);
      this.Controls.Add(this.tbPartDescription);
      this.Controls.Add(this.tbShipperNumberOut);
      this.Controls.Add(this.gbVerification);
      this.Controls.Add(this.gbInputs);
      this.Controls.Add(this.gbActions);
      this.ForeColor = System.Drawing.SystemColors.ControlText;
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
      this.Name = "ShipHatchAFTMain";
      this.Text = "Ship Hatch AFT";
      this.Activated += new System.EventHandler(this.ShipHatchAFTMain_Activated);
      this.Load += new System.EventHandler(this.ShipHatchAFTMain_Load);
      this.VisibleChanged += new System.EventHandler(this.ShipHatchAFTMain_VisibleChanged);
      this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.ShipHatchAFTMain_HelpRequested);
      this.gbActions.ResumeLayout(false);
      this.gbActions.PerformLayout();
      this.gbInputs.ResumeLayout(false);
      this.gbInputs.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.nudSHPrintQty)).EndInit();
      this.gbVerification.ResumeLayout(false);
      this.gbVerification.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.myDataGridView)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
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
    private System.Windows.Forms.TextBox tbShipperNumberOut;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.GroupBox gbVerification;
    private System.Windows.Forms.DataGridView myDataGridView;
    private System.Windows.Forms.Label label12;
    private System.Windows.Forms.NumericUpDown nudSHPrintQty;
    private System.Windows.Forms.TextBox tbDLQLabelType;
    private System.Windows.Forms.TextBox tbShipLabelType;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox tbPartQuantity;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.DataGridViewTextBoxColumn BoxNumber;
    private System.Windows.Forms.DataGridViewTextBoxColumn PartNumberB;
    private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
    internal System.Windows.Forms.TextBox tbPrinterNameMain;
    internal System.Windows.Forms.TextBox tbPrinterNameOther;
    private System.Windows.Forms.Button bConfig;
  }
}