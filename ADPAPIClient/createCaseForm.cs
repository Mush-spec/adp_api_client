using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;



namespace ADPAPIClient
{
    public partial class createCaseForm : Form
    {
        APIConstants apiConstants = new APIConstants();
        private string fillFormStatusMessage = "Enter values into the form";
        private string displayResponseStatusMessage = "Response from server displayed above";
        private string postingClaimStatusMessage = "POSTing claim to server....";
        private string responseLabelText = "Response from server:";

        public createCaseForm()
        {
            InitializeComponent();
            initializeCaseTypeComboBox();
            initializeAdvocateCategoryComboBox();
            statusMessage.Text = fillFormStatusMessage;
            sentToServerLabel.Text = "";
        }


        private void initializeCaseTypeComboBox()
        {
            caseTypeComboBox.DataSource = apiConstants.caseTypes;
            caseTypeComboBox.DisplayMember = "Description";
            caseTypeComboBox.ValueMember = "Id";
        }

        private void initializeAdvocateCategoryComboBox()
        {
            advocateCategoryComboBox.DataSource = apiConstants.advocateCategories;
            advocateCategoryComboBox.DisplayMember = "Description";
            advocateCategoryComboBox.ValueMember = "Id";
        }

        private void createCaseButton_Click(object sender, EventArgs e)
        {
            statusMessage.Text = postingClaimStatusMessage;
            Case myCase = populateCase();
            HttpClient client = new HttpClient();
            string payload = myCase.toJson();

            string response = client.createClaim(payload);
            sentToServerLabel.Text = formatSentToServerLabel(client, payload);
            statusMessage.Text = displayResponseStatusMessage;
            responseLabel.Text = responseLabelText;
            messageLabel.Text = "Status: " + client.responseStatusCode + "  " + response;
        }


        private string formatSentToServerLabel(HttpClient client, string payload)
        {
            string msg = "URL: " + client.fullUrl + "\n\n" + payload;
            return msg;
        }

        private Case populateCase()
        {
            Case myCase = new Case();
            myCase.advocateEmail = advocateEmailTextBox.Text;
            myCase.caseNumber = caseNumberTextBox.Text;
            myCase.caseTypeId = caseTypeComboBox.Text;
            myCase.indictmentNumber = indictmentNumberTextBox.Text;
            myCase.trialStartDate = trialStartDatePicker.Value;
            myCase.estimatedTrialLength = estimatedTrialLengthNumericUpdown.Value;
            myCase.actualTrialLength = actualTrialLengthNumericUpDown.Value;
            myCase.endTrialDate = trialEndDatePicker.Value;
            myCase.advocateCategory = advocateCategoryComboBox.Text;
            myCase.cmsNumber = cmsNumberTextBox.Text;
            return myCase;
        }

        private void advocateEmailTextBox_Enter(object sender, EventArgs e)
        {
            messageLabel.Text = "";
            responseLabel.Text = "";
            statusMessage.Text = fillFormStatusMessage;
        }

        private void populateButton_Click(object sender, EventArgs e)
        {
            advocateEmailTextBox.Text = "advocate@example.com";
            caseNumberTextBox.Text = "CASE0001";
            caseTypeComboBox.Text = "Trial";
            indictmentNumberTextBox.Text = "IND-3553";
            trialStartDatePicker.Value = new DateTime(2015, 5, 17);
            estimatedTrialLengthNumericUpdown.Value = 3;
            actualTrialLengthNumericUpDown.Value = 3;
            trialEndDatePicker.Value = new DateTime(2015, 5, 19);
            advocateCategoryComboBox.Text = "QC";
            cmsNumberTextBox.Text = "CMS-001";
            additionalInformation.Text = "This is a test Case sent from a sample API client program running on .NET.";
            applyVatCheckBox.Checked = true;

        }

       
    }
}

