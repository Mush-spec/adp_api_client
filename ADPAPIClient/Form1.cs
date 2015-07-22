using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace ADPAPIClient
{
    public partial class Form1 : Form
    {
        APIConstants apiConstants = new APIConstants(); 

        public Form1()
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
            string casemail = myCase.advocateEmail;
        }
    }
}

