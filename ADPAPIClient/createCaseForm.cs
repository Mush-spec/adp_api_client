using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

using System.IO;
using System.Net;



namespace ADPAPIClient
{
    public partial class createCaseForm : Form
    {
        APIConstants apiConstants = new APIConstants();
        private string fillFormStatusMessage = "Enter values into the form";
        private string displayResponseStatusMessage = "Response from server displayed above";
        private string postingClaimStatusMessage = "POSTing claim to server....";
        private string responseLabelText = "Response from server:";
        private string dump;

        public createCaseForm()
        {
            InitializeComponent();
            initializeCaseTypeComboBox();
            initializeAdvocateCategoryComboBox();
            initializeCourtCombobox();
            initializeTrialCrackedAtThirdComboBox();
            statusMessage.Text = fillFormStatusMessage;
            sentToServerLabel.Text = "";
        }

        private void initializeCaseTypeComboBox()
        {
            caseTypeComboBox.DataSource = apiConstants.caseTypes;
            caseTypeComboBox.DisplayMember = "Name";
            caseTypeComboBox.ValueMember = "Id";
        }

        private void initializeAdvocateCategoryComboBox()
        {
            advocateCategoryComboBox.DataSource = apiConstants.advocateCategories;
            advocateCategoryComboBox.DisplayMember = "Description";
            advocateCategoryComboBox.ValueMember = "Id";
        }

        private void initializeCourtCombobox()
        {
            courtComboBox.DataSource = apiConstants.courts;
            courtComboBox.DisplayMember = "Name";
            courtComboBox.ValueMember = "Id";
        }

        private void initializeTrialCrackedAtThirdComboBox()
        {
            trialCrackAtThirdComboBox.DataSource = apiConstants.trialCrackedAtThirds;
            trialCrackAtThirdComboBox.DisplayMember = "Description";
            trialCrackAtThirdComboBox.ValueMember = "Value";
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
            serverResponseLabel.Text = "Status: " + client.responseStatusCode + "  " + response;
        }


        private string formatSentToServerLabel(HttpClient client, string payload)
        {
            string msg = "URL: " + client.fullUrl + "\n\n" + payload;
            return msg;
        }

        private Case populateCase()
        {
            Case myCase = new Case();
            myCase.apiKey = APIConstants.ApiKey;
            myCase.creatorEmail = creatorEmailTextBox.Text;
            myCase.advocateEmail = advocateEmailTextBox.Text;
            myCase.caseNumber = caseNumberTextBox.Text;
            myCase.caseType = caseTypeComboBox.SelectedValue.ToString();
            myCase.courtId = courtComboBox.SelectedValue.ToString();
            myCase.trialStartDate = trialStartDatePicker.Value;
            myCase.estimatedTrialLength = estimatedTrialLengthNumericUpdown.Value;
            myCase.actualTrialLength = actualTrialLengthNumericUpDown.Value;
            myCase.endTrialDate = trialEndDatePicker.Value;
            myCase.advocateCategory = advocateCategoryComboBox.Text;
            myCase.cmsNumber = cmsNumberTextBox.Text;

            if (trialFixedDatePicker.Checked) myCase.trialFixedAt = trialFixedDatePicker.Value;
            if (trialFixedNoticeDatePicker.Checked) myCase.trialFixedNoticeAt = trialFixedNoticeDatePicker.Value;
            if (trialCrackedDatePicker.Checked) myCase.trialCrackedAt = trialCrackedDatePicker.Value;
            myCase.trialCrackedAtThird = trialCrackAtThirdComboBox.SelectedValue.ToString();

            myCase.applyVat = applyVatCheckBox.Checked;
            myCase.additionalInformation = additionalInformation.Text;
            return myCase;
        }

        private void advocateEmailTextBox_Enter(object sender, EventArgs e)
        {
            serverResponseLabel.Text = "";
            responseLabel.Text = "";
            statusMessage.Text = fillFormStatusMessage;
        }

        private void populateButton_Click(object sender, EventArgs e)
        {
            creatorEmailTextBox.Text = "advocateadmin@example.com";
            advocateEmailTextBox.Text = "advocate@example.com";
            caseNumberTextBox.Text = "C87654321";
            trialStartDatePicker.Value = new DateTime(2015, 5, 17);
            estimatedTrialLengthNumericUpdown.Value = 3;
            actualTrialLengthNumericUpDown.Value = 3;
            trialEndDatePicker.Value = new DateTime(2015, 5, 19);
            advocateCategoryComboBox.Text = "QC";
            cmsNumberTextBox.Text = "CMS-2015-0001";
            additionalInformation.Text = "This is a test Case sent from a sample API client program running on .NET.";
            applyVatCheckBox.Checked = true;
        }

        private void sentToServerLabel_Click(object sender, EventArgs e)
        {

        }

        private void getCourts_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            string response = client.getCourts();
            serverResponseLabel.Text = "Status: " + client.responseStatusCode + "  " + response;
            MessageBox.Show("Response: " + client.responseStatusCode + "  " + response, "Response form courts endpoint", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void caseTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void trialFixedDatePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void courtComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void createCaseForm_Load(object sender, EventArgs e)
        {

        }
    }
}

