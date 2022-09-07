namespace BarCode003
{
  partial class ChelseaBoxLabelMain
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
      this.cbLabelType = new System.Windows.Forms.ComboBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.tbScannedInput = new System.Windows.Forms.TextBox();
      this.tbJobNumberOut = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.tbPartNumberRevisionOut = new System.Windows.Forms.TextBox();
      this.tbPartDescription = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.tbOriginalQuantity = new System.Windows.Forms.TextBox();
      this.tbFirstOpQty = new System.Windows.Forms.TextBox();
      this.tbLastOpQty = new System.Windows.Forms.TextBox();
      this.label6 = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.label8 = new System.Windows.Forms.Label();
      this.label9 = new System.Windows.Forms.Label();
      this.tbPO = new System.Windows.Forms.TextBox();
      this.label10 = new System.Windows.Forms.Label();
      this.tbDueDate = new System.Windows.Forms.TextBox();
      this.gbInputs = new System.Windows.Forms.GroupBox();
      this.bCmdReset = new System.Windows.Forms.Button();
      this.gbVerification = new System.Windows.Forms.GroupBox();
      this.label11 = new System.Windows.Forms.Label();
      this.cbCustomers = new System.Windows.Forms.ComboBox();
      this.tbCustomerName = new System.Windows.Forms.TextBox();
      this.bPrint = new System.Windows.Forms.Button();
      this.gbActions = new System.Windows.Forms.GroupBox();
      this.bExit = new System.Windows.Forms.Button();
      this.label12 = new System.Windows.Forms.Label();
      this.nudCBLPrintQty = new System.Windows.Forms.NumericUpDown();
      this.tResetTimer = new System.Windows.Forms.Timer(this.components);
      this.tbPrinterNameMain = new System.Windows.Forms.TextBox();
      this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
      this.bConfig = new System.Windows.Forms.Button();
      this.gbInputs.SuspendLayout();
      this.gbVerification.SuspendLayout();
      this.gbActions.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.nudCBLPrintQty)).BeginInit();
      this.SuspendLayout();
      // 
      // cbLabelType
      // 
      this.cbLabelType.AllowDrop = true;
      this.cbLabelType.BackColor = System.Drawing.SystemColors.Menu;
      this.cbLabelType.Cursor = System.Windows.Forms.Cursors.Hand;
      this.cbLabelType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbLabelType.ForeColor = System.Drawing.SystemColors.MenuText;
      this.cbLabelType.FormattingEnabled = true;
      this.cbLabelType.Location = new System.Drawing.Point(83, 9);
      this.cbLabelType.Name = "cbLabelType";
      this.cbLabelType.Size = new System.Drawing.Size(154, 21);
      this.cbLabelType.TabIndex = 0;
      this.cbLabelType.TabStop = false;
      this.cbLabelType.SelectedIndexChanged += new System.EventHandler(this.cbLabelType_SelectedIndexChanged);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(12, 13);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(70, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "Label Type";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(4, 22);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(64, 13);
      this.label2.TabIndex = 2;
      this.label2.Text = "Job Number";
      // 
      // tbScannedInput
      // 
      this.tbScannedInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tbScannedInput.Location = new System.Drawing.Point(71, 18);
      this.tbScannedInput.MaxLength = 11;
      this.tbScannedInput.Name = "tbScannedInput";
      this.tbScannedInput.Size = new System.Drawing.Size(100, 20);
      this.tbScannedInput.TabIndex = 0;
      this.tbScannedInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbJobNumberInput_KeyPress);
      this.tbScannedInput.Leave += new System.EventHandler(this.tbJobNumberInput_Leave);
      // 
      // tbJobNumberOut
      // 
      this.tbJobNumberOut.BackColor = System.Drawing.Color.Black;
      this.tbJobNumberOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tbJobNumberOut.ForeColor = System.Drawing.Color.White;
      this.tbJobNumberOut.Location = new System.Drawing.Point(71, 21);
      this.tbJobNumberOut.Name = "tbJobNumberOut";
      this.tbJobNumberOut.Size = new System.Drawing.Size(100, 20);
      this.tbJobNumberOut.TabIndex = 1;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(4, 25);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(64, 13);
      this.label3.TabIndex = 4;
      this.label3.Text = "Job Number";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.Location = new System.Drawing.Point(1, 47);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(67, 13);
      this.label4.TabIndex = 6;
      this.label4.Text = "Part # / Rev";
      // 
      // tbPartNumberRevisionOut
      // 
      this.tbPartNumberRevisionOut.BackColor = System.Drawing.Color.Black;
      this.tbPartNumberRevisionOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tbPartNumberRevisionOut.ForeColor = System.Drawing.Color.White;
      this.tbPartNumberRevisionOut.Location = new System.Drawing.Point(71, 43);
      this.tbPartNumberRevisionOut.Name = "tbPartNumberRevisionOut";
      this.tbPartNumberRevisionOut.Size = new System.Drawing.Size(323, 20);
      this.tbPartNumberRevisionOut.TabIndex = 7;
      this.tbPartNumberRevisionOut.TabStop = false;
      // 
      // tbPartDescription
      // 
      this.tbPartDescription.BackColor = System.Drawing.Color.Black;
      this.tbPartDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tbPartDescription.ForeColor = System.Drawing.Color.White;
      this.tbPartDescription.Location = new System.Drawing.Point(71, 65);
      this.tbPartDescription.Name = "tbPartDescription";
      this.tbPartDescription.Size = new System.Drawing.Size(323, 20);
      this.tbPartDescription.TabIndex = 9;
      this.tbPartDescription.TabStop = false;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label5.Location = new System.Drawing.Point(14, 69);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(54, 13);
      this.label5.TabIndex = 8;
      this.label5.Text = "Part Desc";
      // 
      // tbOriginalQuantity
      // 
      this.tbOriginalQuantity.BackColor = System.Drawing.Color.Black;
      this.tbOriginalQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tbOriginalQuantity.ForeColor = System.Drawing.Color.White;
      this.tbOriginalQuantity.Location = new System.Drawing.Point(71, 87);
      this.tbOriginalQuantity.Name = "tbOriginalQuantity";
      this.tbOriginalQuantity.Size = new System.Drawing.Size(38, 20);
      this.tbOriginalQuantity.TabIndex = 10;
      this.tbOriginalQuantity.TabStop = false;
      this.tbOriginalQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // tbFirstOpQty
      // 
      this.tbFirstOpQty.BackColor = System.Drawing.Color.Black;
      this.tbFirstOpQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tbFirstOpQty.ForeColor = System.Drawing.Color.White;
      this.tbFirstOpQty.Location = new System.Drawing.Point(213, 87);
      this.tbFirstOpQty.Name = "tbFirstOpQty";
      this.tbFirstOpQty.Size = new System.Drawing.Size(38, 20);
      this.tbFirstOpQty.TabIndex = 11;
      this.tbFirstOpQty.TabStop = false;
      this.tbFirstOpQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // tbLastOpQty
      // 
      this.tbLastOpQty.BackColor = System.Drawing.Color.Black;
      this.tbLastOpQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tbLastOpQty.ForeColor = System.Drawing.Color.White;
      this.tbLastOpQty.Location = new System.Drawing.Point(356, 87);
      this.tbLastOpQty.Name = "tbLastOpQty";
      this.tbLastOpQty.Size = new System.Drawing.Size(38, 20);
      this.tbLastOpQty.TabIndex = 12;
      this.tbLastOpQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.tbLastOpQty.Click += new System.EventHandler(this.tbLastOpQty_Enter);
      this.tbLastOpQty.Enter += new System.EventHandler(this.tbLastOpQty_Enter);
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label6.Location = new System.Drawing.Point(4, 92);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(64, 13);
      this.label6.TabIndex = 13;
      this.label6.Text = "Original Qty.";
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label7.Location = new System.Drawing.Point(155, 92);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(60, 13);
      this.label7.TabIndex = 14;
      this.label7.Text = "1st Op Qty.";
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label8.Location = new System.Drawing.Point(292, 92);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(66, 13);
      this.label8.TabIndex = 15;
      this.label8.Text = "Last Op Qty.";
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label9.Location = new System.Drawing.Point(40, 113);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(28, 13);
      this.label9.TabIndex = 16;
      this.label9.Text = "P.O.";
      // 
      // tbPO
      // 
      this.tbPO.BackColor = System.Drawing.Color.Black;
      this.tbPO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tbPO.ForeColor = System.Drawing.Color.White;
      this.tbPO.Location = new System.Drawing.Point(71, 109);
      this.tbPO.Name = "tbPO";
      this.tbPO.Size = new System.Drawing.Size(100, 20);
      this.tbPO.TabIndex = 17;
      this.tbPO.TabStop = false;
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label10.Location = new System.Drawing.Point(240, 113);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(53, 13);
      this.label10.TabIndex = 18;
      this.label10.Text = "Due Date";
      // 
      // tbDueDate
      // 
      this.tbDueDate.BackColor = System.Drawing.Color.Black;
      this.tbDueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tbDueDate.ForeColor = System.Drawing.Color.White;
      this.tbDueDate.Location = new System.Drawing.Point(294, 109);
      this.tbDueDate.Name = "tbDueDate";
      this.tbDueDate.Size = new System.Drawing.Size(100, 20);
      this.tbDueDate.TabIndex = 19;
      this.tbDueDate.TabStop = false;
      // 
      // gbInputs
      // 
      this.gbInputs.BackColor = System.Drawing.SystemColors.ButtonFace;
      this.gbInputs.Controls.Add(this.bCmdReset);
      this.gbInputs.Controls.Add(this.tbScannedInput);
      this.gbInputs.Controls.Add(this.label2);
      this.gbInputs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.gbInputs.Location = new System.Drawing.Point(12, 35);
      this.gbInputs.Name = "gbInputs";
      this.gbInputs.Size = new System.Drawing.Size(406, 46);
      this.gbInputs.TabIndex = 20;
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
      // gbVerification
      // 
      this.gbVerification.BackColor = System.Drawing.SystemColors.ButtonFace;
      this.gbVerification.Controls.Add(this.label11);
      this.gbVerification.Controls.Add(this.tbDueDate);
      this.gbVerification.Controls.Add(this.cbCustomers);
      this.gbVerification.Controls.Add(this.label10);
      this.gbVerification.Controls.Add(this.label6);
      this.gbVerification.Controls.Add(this.tbPO);
      this.gbVerification.Controls.Add(this.label7);
      this.gbVerification.Controls.Add(this.label9);
      this.gbVerification.Controls.Add(this.label8);
      this.gbVerification.Controls.Add(this.tbLastOpQty);
      this.gbVerification.Controls.Add(this.tbJobNumberOut);
      this.gbVerification.Controls.Add(this.tbFirstOpQty);
      this.gbVerification.Controls.Add(this.label3);
      this.gbVerification.Controls.Add(this.tbOriginalQuantity);
      this.gbVerification.Controls.Add(this.label4);
      this.gbVerification.Controls.Add(this.tbPartDescription);
      this.gbVerification.Controls.Add(this.tbPartNumberRevisionOut);
      this.gbVerification.Controls.Add(this.label5);
      this.gbVerification.Controls.Add(this.tbCustomerName);
      this.gbVerification.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.gbVerification.Location = new System.Drawing.Point(12, 87);
      this.gbVerification.Name = "gbVerification";
      this.gbVerification.Size = new System.Drawing.Size(406, 166);
      this.gbVerification.TabIndex = 21;
      this.gbVerification.TabStop = false;
      this.gbVerification.Text = "Verification";
      // 
      // label11
      // 
      this.label11.AutoSize = true;
      this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label11.Location = new System.Drawing.Point(11, 138);
      this.label11.Name = "label11";
      this.label11.Size = new System.Drawing.Size(59, 13);
      this.label11.TabIndex = 0;
      this.label11.Text = "Cust Name";
      // 
      // cbCustomers
      // 
      this.cbCustomers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cbCustomers.FormattingEnabled = true;
      this.cbCustomers.Location = new System.Drawing.Point(71, 134);
      this.cbCustomers.Name = "cbCustomers";
      this.cbCustomers.Size = new System.Drawing.Size(323, 21);
      this.cbCustomers.TabIndex = 0;
      this.cbCustomers.SelectedIndexChanged += new System.EventHandler(this.cbCustomers_SelectedIndexChanged);
      // 
      // tbCustomerName
      // 
      this.tbCustomerName.BackColor = System.Drawing.Color.Black;
      this.tbCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tbCustomerName.ForeColor = System.Drawing.Color.White;
      this.tbCustomerName.Location = new System.Drawing.Point(71, 133);
      this.tbCustomerName.Name = "tbCustomerName";
      this.tbCustomerName.Size = new System.Drawing.Size(323, 20);
      this.tbCustomerName.TabIndex = 24;
      this.tbCustomerName.TabStop = false;
      // 
      // bPrint
      // 
      this.bPrint.AutoSize = true;
      this.bPrint.Enabled = false;
      this.bPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.bPrint.Location = new System.Drawing.Point(71, 21);
      this.bPrint.Name = "bPrint";
      this.bPrint.Size = new System.Drawing.Size(75, 26);
      this.bPrint.TabIndex = 99;
      this.bPrint.Text = "Print";
      this.bPrint.UseVisualStyleBackColor = true;
      this.bPrint.Click += new System.EventHandler(this.bPrint_Click);
      // 
      // gbActions
      // 
      this.gbActions.Controls.Add(this.bExit);
      this.gbActions.Controls.Add(this.bPrint);
      this.gbActions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.gbActions.Location = new System.Drawing.Point(12, 259);
      this.gbActions.Name = "gbActions";
      this.gbActions.Size = new System.Drawing.Size(406, 61);
      this.gbActions.TabIndex = 23;
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
      // label12
      // 
      this.label12.AutoSize = true;
      this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label12.Location = new System.Drawing.Point(291, 13);
      this.label12.Name = "label12";
      this.label12.Size = new System.Drawing.Size(56, 13);
      this.label12.TabIndex = 100;
      this.label12.Text = "Print Qty";
      // 
      // nudCBLPrintQty
      // 
      this.nudCBLPrintQty.BackColor = System.Drawing.SystemColors.Menu;
      this.nudCBLPrintQty.ForeColor = System.Drawing.SystemColors.MenuText;
      this.nudCBLPrintQty.Location = new System.Drawing.Point(350, 9);
      this.nudCBLPrintQty.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
      this.nudCBLPrintQty.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.nudCBLPrintQty.Name = "nudCBLPrintQty";
      this.nudCBLPrintQty.Size = new System.Drawing.Size(56, 20);
      this.nudCBLPrintQty.TabIndex = 101;
      this.nudCBLPrintQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.nudCBLPrintQty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      // 
      // tResetTimer
      // 
      this.tResetTimer.Interval = 1000;
      this.tResetTimer.Tick += new System.EventHandler(this.tResetTimer_Tick);
      // 
      // tbPrinterNameMain
      // 
      this.tbPrinterNameMain.Cursor = System.Windows.Forms.Cursors.Default;
      this.tbPrinterNameMain.Font = new System.Drawing.Font("Calibri", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tbPrinterNameMain.Location = new System.Drawing.Point(7, 326);
      this.tbPrinterNameMain.Name = "tbPrinterNameMain";
      this.tbPrinterNameMain.ReadOnly = true;
      this.tbPrinterNameMain.Size = new System.Drawing.Size(60, 17);
      this.tbPrinterNameMain.TabIndex = 121;
      this.tbPrinterNameMain.Text = "ZebraBoxLabel";
      this.tbPrinterNameMain.Click += new System.EventHandler(this.tbPrinter_Click);
      this.tbPrinterNameMain.DoubleClick += new System.EventHandler(this.tbPrinter_DoubleClick);
      // 
      // bConfig
      // 
      this.bConfig.AutoSize = true;
      this.bConfig.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.bConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.bConfig.Location = new System.Drawing.Point(184, 324);
      this.bConfig.Name = "bConfig";
      this.bConfig.Size = new System.Drawing.Size(43, 19);
      this.bConfig.TabIndex = 123;
      this.bConfig.Text = "Config";
      this.bConfig.UseVisualStyleBackColor = true;
      this.bConfig.Click += new System.EventHandler(this.bConfig_Click);
      // 
      // ChelseaBoxLabelMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoSize = true;
      this.ClientSize = new System.Drawing.Size(432, 351);
      this.ControlBox = false;
      this.Controls.Add(this.bConfig);
      this.Controls.Add(this.tbPrinterNameMain);
      this.Controls.Add(this.nudCBLPrintQty);
      this.Controls.Add(this.label12);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.cbLabelType);
      this.Controls.Add(this.gbInputs);
      this.Controls.Add(this.gbVerification);
      this.Controls.Add(this.gbActions);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "ChelseaBoxLabelMain";
      this.Text = "Chelsea Box Label";
      this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.ChelseaBoxLabelMain_HelpRequested);
      this.gbInputs.ResumeLayout(false);
      this.gbInputs.PerformLayout();
      this.gbVerification.ResumeLayout(false);
      this.gbVerification.PerformLayout();
      this.gbActions.ResumeLayout(false);
      this.gbActions.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.nudCBLPrintQty)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ComboBox cbLabelType;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox tbScannedInput;
    private System.Windows.Forms.TextBox tbJobNumberOut;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox tbPartNumberRevisionOut;
    private System.Windows.Forms.TextBox tbPartDescription;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox tbOriginalQuantity;
    private System.Windows.Forms.TextBox tbFirstOpQty;
    private System.Windows.Forms.TextBox tbLastOpQty;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.TextBox tbPO;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.TextBox tbDueDate;
    private System.Windows.Forms.GroupBox gbInputs;
    private System.Windows.Forms.GroupBox gbVerification;
    private System.Windows.Forms.Button bPrint;
    private System.Windows.Forms.GroupBox gbActions;
    private System.Windows.Forms.TextBox tbCustomerName;
    private System.Windows.Forms.Label label11;
    private System.Windows.Forms.ComboBox cbCustomers;
    private System.Windows.Forms.Label label12;
    private System.Windows.Forms.NumericUpDown nudCBLPrintQty;
    private System.Windows.Forms.Button bCmdReset;
    private System.Windows.Forms.Timer tResetTimer;
    private System.Windows.Forms.Button bExit;
    internal System.Windows.Forms.TextBox tbPrinterNameMain;
    private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    private System.Windows.Forms.Button bConfig;
  }
}

