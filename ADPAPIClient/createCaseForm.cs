using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
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


            string jsonString = myCase.toJson();

            // let's try to contact the web server
            WebClient client = new WebClient();
            client.Headers["Content-type"] = "application/json";
            client.Headers["Accept"] = "applicaton/json";

            // invoke the REST method
            string response;
            try
            {
                messageLabel.Text = "Contacting server .....";
                response = client.UploadString(
                   "http://192.168.33.1:3000/api/advocates/claims.json",
                   jsonString);
                messageLabel.Text = response;

            }
            catch (System.Exception ex)
            {
                messageLabel.Text = ex.Message;
            }
        }
    }
}

