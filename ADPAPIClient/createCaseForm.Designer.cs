namespace ADPAPIClient
{
    partial class createCaseForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.caseTypeComboBox = new System.Windows.Forms.ComboBox();
            this.advocateEmailTextBox = new System.Windows.Forms.TextBox();
            this.caseNumberTextBox = new System.Windows.Forms.TextBox();
            this.cmsNumberTextBox = new System.Windows.Forms.TextBox();
            this.createCaseButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.responseLabel = new System.Windows.Forms.Label();
            this.advocateCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.indictmentNumberTextBox = new System.Windows.Forms.TextBox();
            this.trialStartDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.estimatedTrialLengthNumericUpdown = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.trialEndDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.actualTrialLengthNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.trialCrackAtThirdComboBox = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.additionalInformation = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.trialCrackedDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.trialFixedNoticeDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.trialFixedDatePicker = new System.Windows.Forms.DateTimePicker();
            this.prosecutingAuthorityTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.applyVatCheckBox = new System.Windows.Forms.CheckBox();
            this.populateButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.messageLabel = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.sentToServerLabel = new System.Windows.Forms.Label();
            this.courtComboBox = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.estimatedTrialLengthNumericUpdown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actualTrialLengthNumericUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(0, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(818, 23);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "ADP API Client";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Advocate email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Case number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(505, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Case type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "CMS number";
            // 
            // caseTypeComboBox
            // 
            this.caseTypeComboBox.AllowDrop = true;
            this.caseTypeComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.caseTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.caseTypeComboBox.FormattingEnabled = true;
            this.caseTypeComboBox.Location = new System.Drawing.Point(562, 77);
            this.caseTypeComboBox.Name = "caseTypeComboBox";
            this.caseTypeComboBox.Size = new System.Drawing.Size(162, 21);
            this.caseTypeComboBox.TabIndex = 3;
            this.caseTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.caseTypeComboBox_SelectedIndexChanged);
            // 
            // advocateEmailTextBox
            // 
            this.advocateEmailTextBox.Location = new System.Drawing.Point(110, 48);
            this.advocateEmailTextBox.Name = "advocateEmailTextBox";
            this.advocateEmailTextBox.Size = new System.Drawing.Size(166, 20);
            this.advocateEmailTextBox.TabIndex = 1;
            this.advocateEmailTextBox.Enter += new System.EventHandler(this.advocateEmailTextBox_Enter);
            // 
            // caseNumberTextBox
            // 
            this.caseNumberTextBox.Location = new System.Drawing.Point(110, 78);
            this.caseNumberTextBox.Name = "caseNumberTextBox";
            this.caseNumberTextBox.Size = new System.Drawing.Size(166, 20);
            this.caseNumberTextBox.TabIndex = 2;
            // 
            // cmsNumberTextBox
            // 
            this.cmsNumberTextBox.Location = new System.Drawing.Point(109, 32);
            this.cmsNumberTextBox.Name = "cmsNumberTextBox";
            this.cmsNumberTextBox.Size = new System.Drawing.Size(140, 20);
            this.cmsNumberTextBox.TabIndex = 4;
            // 
            // createCaseButton
            // 
            this.createCaseButton.Location = new System.Drawing.Point(25, 439);
            this.createCaseButton.Name = "createCaseButton";
            this.createCaseButton.Size = new System.Drawing.Size(75, 23);
            this.createCaseButton.TabIndex = 5;
            this.createCaseButton.Text = "Create Case";
            this.createCaseButton.UseVisualStyleBackColor = true;
            this.createCaseButton.Click += new System.EventHandler(this.createCaseButton_Click);
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(0, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(818, 23);
            this.label5.TabIndex = 99;
            this.label5.Text = "Create Case";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusMessage});
            this.statusStrip1.Location = new System.Drawing.Point(0, 782);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(818, 22);
            this.statusStrip1.TabIndex = 101;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusMessage
            // 
            this.statusMessage.Name = "statusMessage";
            this.statusMessage.Size = new System.Drawing.Size(111, 17);
            this.statusMessage.Text = "Awating form input";
            // 
            // responseLabel
            // 
            this.responseLabel.AutoSize = true;
            this.responseLabel.Location = new System.Drawing.Point(70, 236);
            this.responseLabel.Name = "responseLabel";
            this.responseLabel.Size = new System.Drawing.Size(0, 13);
            this.responseLabel.TabIndex = 102;
            // 
            // advocateCategoryComboBox
            // 
            this.advocateCategoryComboBox.FormattingEnabled = true;
            this.advocateCategoryComboBox.Location = new System.Drawing.Point(562, 48);
            this.advocateCategoryComboBox.Name = "advocateCategoryComboBox";
            this.advocateCategoryComboBox.Size = new System.Drawing.Size(162, 21);
            this.advocateCategoryComboBox.TabIndex = 103;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(461, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 104;
            this.label6.Text = "Advocate Category";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 105;
            this.label7.Text = "Indictment No.";
            // 
            // indictmentNumberTextBox
            // 
            this.indictmentNumberTextBox.Location = new System.Drawing.Point(110, 110);
            this.indictmentNumberTextBox.Name = "indictmentNumberTextBox";
            this.indictmentNumberTextBox.Size = new System.Drawing.Size(166, 20);
            this.indictmentNumberTextBox.TabIndex = 106;
            // 
            // trialStartDatePicker
            // 
            this.trialStartDatePicker.Location = new System.Drawing.Point(110, 145);
            this.trialStartDatePicker.Name = "trialStartDatePicker";
            this.trialStartDatePicker.Size = new System.Drawing.Size(130, 20);
            this.trialStartDatePicker.TabIndex = 107;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 108;
            this.label8.Text = "Trial start date";
            // 
            // estimatedTrialLengthNumericUpdown
            // 
            this.estimatedTrialLengthNumericUpdown.Location = new System.Drawing.Point(349, 145);
            this.estimatedTrialLengthNumericUpdown.Name = "estimatedTrialLengthNumericUpdown";
            this.estimatedTrialLengthNumericUpdown.Size = new System.Drawing.Size(84, 20);
            this.estimatedTrialLengthNumericUpdown.TabIndex = 109;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(245, 148);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 13);
            this.label9.TabIndex = 110;
            this.label9.Text = "Estimated trial length";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // trialEndDatePicker
            // 
            this.trialEndDatePicker.Location = new System.Drawing.Point(110, 170);
            this.trialEndDatePicker.Name = "trialEndDatePicker";
            this.trialEndDatePicker.Size = new System.Drawing.Size(130, 20);
            this.trialEndDatePicker.TabIndex = 111;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(32, 174);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 13);
            this.label10.TabIndex = 112;
            this.label10.Text = "Trial end date";
            // 
            // actualTrialLengthNumericUpDown
            // 
            this.actualTrialLengthNumericUpDown.Location = new System.Drawing.Point(349, 170);
            this.actualTrialLengthNumericUpDown.Name = "actualTrialLengthNumericUpDown";
            this.actualTrialLengthNumericUpDown.Size = new System.Drawing.Size(84, 20);
            this.actualTrialLengthNumericUpDown.TabIndex = 113;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(254, 172);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 13);
            this.label11.TabIndex = 114;
            this.label11.Text = "Actual trial length";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.trialCrackAtThirdComboBox);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.additionalInformation);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.trialCrackedDatePicker);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.trialFixedNoticeDatePicker);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.trialFixedDatePicker);
            this.groupBox1.Controls.Add(this.applyVatCheckBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmsNumberTextBox);
            this.groupBox1.Location = new System.Drawing.Point(27, 215);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(691, 218);
            this.groupBox1.TabIndex = 115;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Optional fields";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(386, 95);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(110, 13);
            this.label15.TabIndex = 19;
            this.label15.Text = "Trial Cracked At Third";
            // 
            // trialCrackAtThirdComboBox
            // 
            this.trialCrackAtThirdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.trialCrackAtThirdComboBox.FormattingEnabled = true;
            this.trialCrackAtThirdComboBox.Location = new System.Drawing.Point(507, 92);
            this.trialCrackAtThirdComboBox.Name = "trialCrackAtThirdComboBox";
            this.trialCrackAtThirdComboBox.Size = new System.Drawing.Size(161, 21);
            this.trialCrackAtThirdComboBox.TabIndex = 18;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(27, 138);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(74, 13);
            this.label17.TabIndex = 17;
            this.label17.Text = "Additional Info";
            // 
            // additionalInformation
            // 
            this.additionalInformation.Location = new System.Drawing.Point(109, 135);
            this.additionalInformation.Multiline = true;
            this.additionalInformation.Name = "additionalInformation";
            this.additionalInformation.Size = new System.Drawing.Size(531, 77);
            this.additionalInformation.TabIndex = 16;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(407, 64);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(93, 13);
            this.label16.TabIndex = 15;
            this.label16.Text = "Trial cracked date";
            // 
            // trialCrackedDatePicker
            // 
            this.trialCrackedDatePicker.Checked = false;
            this.trialCrackedDatePicker.Location = new System.Drawing.Point(506, 57);
            this.trialCrackedDatePicker.Name = "trialCrackedDatePicker";
            this.trialCrackedDatePicker.ShowCheckBox = true;
            this.trialCrackedDatePicker.Size = new System.Drawing.Size(134, 20);
            this.trialCrackedDatePicker.TabIndex = 12;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(-5, 91);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(108, 13);
            this.label14.TabIndex = 11;
            this.label14.Text = "Trial fixed notice date";
            // 
            // trialFixedNoticeDatePicker
            // 
            this.trialFixedNoticeDatePicker.Checked = false;
            this.trialFixedNoticeDatePicker.Location = new System.Drawing.Point(109, 85);
            this.trialFixedNoticeDatePicker.Name = "trialFixedNoticeDatePicker";
            this.trialFixedNoticeDatePicker.ShowCheckBox = true;
            this.trialFixedNoticeDatePicker.Size = new System.Drawing.Size(140, 20);
            this.trialFixedNoticeDatePicker.TabIndex = 10;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(27, 64);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 13);
            this.label13.TabIndex = 9;
            this.label13.Text = "Trial fixed date";
            // 
            // trialFixedDatePicker
            // 
            this.trialFixedDatePicker.Checked = false;
            this.trialFixedDatePicker.Location = new System.Drawing.Point(109, 58);
            this.trialFixedDatePicker.Name = "trialFixedDatePicker";
            this.trialFixedDatePicker.ShowCheckBox = true;
            this.trialFixedDatePicker.Size = new System.Drawing.Size(140, 20);
            this.trialFixedDatePicker.TabIndex = 8;
            this.trialFixedDatePicker.ValueChanged += new System.EventHandler(this.trialFixedDatePicker_ValueChanged);
            // 
            // prosecutingAuthorityTextBox
            // 
            this.prosecutingAuthorityTextBox.Location = new System.Drawing.Point(562, 141);
            this.prosecutingAuthorityTextBox.Name = "prosecutingAuthorityTextBox";
            this.prosecutingAuthorityTextBox.Size = new System.Drawing.Size(100, 20);
            this.prosecutingAuthorityTextBox.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(453, 145);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "Prosecuting authority";
            // 
            // applyVatCheckBox
            // 
            this.applyVatCheckBox.AutoSize = true;
            this.applyVatCheckBox.Location = new System.Drawing.Point(109, 111);
            this.applyVatCheckBox.Name = "applyVatCheckBox";
            this.applyVatCheckBox.Size = new System.Drawing.Size(76, 17);
            this.applyVatCheckBox.TabIndex = 5;
            this.applyVatCheckBox.Text = "Apply VAT";
            this.applyVatCheckBox.UseVisualStyleBackColor = true;
            // 
            // populateButton
            // 
            this.populateButton.Location = new System.Drawing.Point(565, 439);
            this.populateButton.Name = "populateButton";
            this.populateButton.Size = new System.Drawing.Size(153, 23);
            this.populateButton.TabIndex = 116;
            this.populateButton.Text = "Populate with Sample Data";
            this.populateButton.UseVisualStyleBackColor = true;
            this.populateButton.Click += new System.EventHandler(this.populateButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.messageLabel);
            this.groupBox2.Location = new System.Drawing.Point(25, 653);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(700, 174);
            this.groupBox2.TabIndex = 117;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ServerResponse";
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.BackColor = System.Drawing.SystemColors.Info;
            this.messageLabel.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageLabel.Location = new System.Drawing.Point(7, 18);
            this.messageLabel.MaximumSize = new System.Drawing.Size(680, 0);
            this.messageLabel.MinimumSize = new System.Drawing.Size(680, 140);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(680, 140);
            this.messageLabel.TabIndex = 100;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox3.Controls.Add(this.sentToServerLabel);
            this.groupBox3.Location = new System.Drawing.Point(27, 468);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(700, 174);
            this.groupBox3.TabIndex = 118;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sent to Server";
            // 
            // sentToServerLabel
            // 
            this.sentToServerLabel.AutoSize = true;
            this.sentToServerLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sentToServerLabel.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sentToServerLabel.ForeColor = System.Drawing.SystemColors.Info;
            this.sentToServerLabel.Location = new System.Drawing.Point(8, 16);
            this.sentToServerLabel.MaximumSize = new System.Drawing.Size(680, 0);
            this.sentToServerLabel.MinimumSize = new System.Drawing.Size(680, 150);
            this.sentToServerLabel.Name = "sentToServerLabel";
            this.sentToServerLabel.Size = new System.Drawing.Size(680, 150);
            this.sentToServerLabel.TabIndex = 0;
            this.sentToServerLabel.Click += new System.EventHandler(this.sentToServerLabel_Click);
            // 
            // courtComboBox
            // 
            this.courtComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.courtComboBox.FormattingEnabled = true;
            this.courtComboBox.Location = new System.Drawing.Point(562, 110);
            this.courtComboBox.Name = "courtComboBox";
            this.courtComboBox.Size = new System.Drawing.Size(161, 21);
            this.courtComboBox.TabIndex = 119;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(527, 113);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(32, 13);
            this.label18.TabIndex = 120;
            this.label18.Text = "Court";
            // 
            // createCaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 804);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.courtComboBox);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.populateButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.actualTrialLengthNumericUpDown);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.trialEndDatePicker);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.prosecutingAuthorityTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.estimatedTrialLengthNumericUpdown);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.trialStartDatePicker);
            this.Controls.Add(this.indictmentNumberTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.advocateCategoryComboBox);
            this.Controls.Add(this.responseLabel);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.createCaseButton);
            this.Controls.Add(this.caseNumberTextBox);
            this.Controls.Add(this.advocateEmailTextBox);
            this.Controls.Add(this.caseTypeComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.titleLabel);
            this.Name = "createCaseForm";
            this.Text = "ADP Client";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.estimatedTrialLengthNumericUpdown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actualTrialLengthNumericUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox caseTypeComboBox;
        private System.Windows.Forms.TextBox advocateEmailTextBox;
        private System.Windows.Forms.TextBox caseNumberTextBox;
        private System.Windows.Forms.TextBox cmsNumberTextBox;
        private System.Windows.Forms.Button createCaseButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusMessage;
        private System.Windows.Forms.Label responseLabel;
        private System.Windows.Forms.ComboBox advocateCategoryComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox indictmentNumberTextBox;
        private System.Windows.Forms.DateTimePicker trialStartDatePicker;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown estimatedTrialLengthNumericUpdown;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker trialEndDatePicker;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown actualTrialLengthNumericUpDown;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox prosecutingAuthorityTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox applyVatCheckBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DateTimePicker trialCrackedDatePicker;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker trialFixedNoticeDatePicker;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button populateButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox additionalInformation;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label sentToServerLabel;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.ComboBox courtComboBox;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox trialCrackAtThirdComboBox;
        private System.Windows.Forms.DateTimePicker trialFixedDatePicker;
    }
}

