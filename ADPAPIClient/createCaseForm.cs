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
            byte[] jsonBytes = GetBytes(jsonString);

            // let's try to contact the web server
            WebClient client = new WebClient();
            client.Headers["Content-type"] = "application/json";

            // invoke the REST method
            byte[] data;
            try
            {
                messageLabel.Text = "Contacting server .....";
                data = client.UploadData(
                   "http://192.168.33.1:3000/api/advocates/claims.json",
                   jsonBytes);
                messageLabel.Text = GetString(data);

            }
            catch (System.Exception ex)
            {
                messageLabel.Text = ex.Message;
            }
            
        }

        static byte[] GetBytes(string str)
        {
            byte[] bytes = new byte[str.Length * sizeof(char)];
            System.Buffer.BlockCopy(str.ToCharArray(), 0, bytes, 0, bytes.Length);
            return bytes;
        }

        static string GetString(byte[] bytes)
        {
            char[] chars = new char[bytes.Length / sizeof(char)];
            System.Buffer.BlockCopy(bytes, 0, chars, 0, bytes.Length);
            return new string(chars);
        }
    }
}

