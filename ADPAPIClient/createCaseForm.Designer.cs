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
            this.messageLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(0, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(779, 23);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "ADP API Client";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Advocate email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Case number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Case type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 186);
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
            this.caseTypeComboBox.Location = new System.Drawing.Point(199, 154);
            this.caseTypeComboBox.Name = "caseTypeComboBox";
            this.caseTypeComboBox.Size = new System.Drawing.Size(166, 21);
            this.caseTypeComboBox.TabIndex = 3;
            // 
            // advocateEmailTextBox
            // 
            this.advocateEmailTextBox.Location = new System.Drawing.Point(199, 95);
            this.advocateEmailTextBox.Name = "advocateEmailTextBox";
            this.advocateEmailTextBox.Size = new System.Drawing.Size(263, 20);
            this.advocateEmailTextBox.TabIndex = 1;
            this.advocateEmailTextBox.Enter += new System.EventHandler(this.advocateEmailTextBox_Enter);
            // 
            // caseNumberTextBox
            // 
            this.caseNumberTextBox.Location = new System.Drawing.Point(199, 125);
            this.caseNumberTextBox.Name = "caseNumberTextBox";
            this.caseNumberTextBox.Size = new System.Drawing.Size(166, 20);
            this.caseNumberTextBox.TabIndex = 2;
            // 
            // cmsNumberTextBox
            // 
            this.cmsNumberTextBox.Location = new System.Drawing.Point(199, 186);
            this.cmsNumberTextBox.Name = "cmsNumberTextBox";
            this.cmsNumberTextBox.Size = new System.Drawing.Size(166, 20);
            this.cmsNumberTextBox.TabIndex = 4;
            // 
            // createCaseButton
            // 
            this.createCaseButton.Location = new System.Drawing.Point(199, 248);
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
            this.label5.Size = new System.Drawing.Size(779, 23);
            this.label5.TabIndex = 99;
            this.label5.Text = "Create Case";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // messageLabel
            // 
            this.messageLabel.Location = new System.Drawing.Point(70, 310);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(625, 154);
            this.messageLabel.TabIndex = 100;
            // 
            // createCaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 540);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.createCaseButton);
            this.Controls.Add(this.cmsNumberTextBox);
            this.Controls.Add(this.caseNumberTextBox);
            this.Controls.Add(this.advocateEmailTextBox);
            this.Controls.Add(this.caseTypeComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.titleLabel);
            this.Name = "createCaseForm";
            this.Text = "Form1";
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
        private System.Windows.Forms.Label messageLabel;
    }
}

