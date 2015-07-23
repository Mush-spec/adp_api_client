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

        public createCaseForm()
        {
            InitializeComponent();
            initializeCaseTypeComboBox();
            
        }


        private void initializeCaseTypeComboBox()
        {
            caseTypeComboBox.DataSource = apiConstants.caseTypes;
            caseTypeComboBox.DisplayMember = "Description";
            caseTypeComboBox.ValueMember = "Id";
        }

        private void createCaseButton_Click(object sender, EventArgs e)
        {
            Case myCase = new Case(advocateEmailTextBox.Text,
                caseNumberTextBox.Text,
                caseTypeComboBox.Text,
                cmsNumberTextBox.Text);


            HttpClient client = new HttpClient();
            string response = client.createClaim(myCase.toJson());
            messageLabel.Text = response;
        }

        private void advocateEmailTextBox_Enter(object sender, EventArgs e)
        {
            messageLabel.Text = "";
        }
    }
}

