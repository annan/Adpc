using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Adpc
{
    public partial class FormCountries : Form
    {
        public FormCountries()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if (validateCountries()) 
            {
                // Save Data
                SaveCountryData();
            }
        }

        Boolean validateCountries()
        { 
            if (string.IsNullOrEmpty(textBoxCName.Text.Trim()))
            { 
                countryErrorProvider1.SetError(textBoxCName, "Country Name Required!");
                return false;
            }
            else 
            { 
                countryErrorProvider1.SetError(textBoxCName, ""); 
            }
            // Validate Country Code
            if (string.IsNullOrEmpty(textBoxCCode.Text.Trim()))
            {
                countryErrorProvider1.SetError(textBoxCCode, "Country Code Required!");
                return false;
            }
            else
            {
                countryErrorProvider1.SetError(textBoxCCode, "");
            }
            return true;
        }

        void SaveCountryData() 
        {
            ClassCountries country = new ClassCountries();
            country.CountryName = textBoxCName.Text.Trim();
            country.CountryCode = textBoxCCode.Text.Trim();
            if (country.SaveCountry())
            {
                // Refresh DataGrid
                MessageBox.Show("Saved!");
            }
            else { labelError.Text = "Error Saving Data"; }
        }

        void refreshGrid() 
        {
            //
        }

        void EditCountryData() { }
    }
}
