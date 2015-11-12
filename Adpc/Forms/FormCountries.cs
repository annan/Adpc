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
        int EnableEditMode = 0;
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

            if((!string.IsNullOrEmpty(textBoxCountryID.Text.Trim())) && EnableEditMode> 0)// (validateCountries()) 
            { EditCountryData(); }
                
            else
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
            country.Active = checkBoxActive.Checked ? 1 : 0;// Ternary Operator
            if (country.SaveCountry())
            {
                // Refresh DataGrid
                MessageBox.Show("Country Data Edited!", "ADPC: Country Data");
                clearScreen();
                refreshGrid(); // Refresh Screen for new Changes to take effects
                EnableEditMode = 0;
                EditMode();
            }
            else { labelError.Text = "Error Saving Data"; }
        }

        void SaveEditedData()
        {
            ClassCountries country = new ClassCountries();
            country.CountryID = Convert.ToInt16(textBoxCountryID.Text.Trim());
            country.CountryName = textBoxCName.Text.Trim();
            country.CountryCode = textBoxCCode.Text.Trim();
            country.Active = checkBoxActive.Checked ? 1 : 0;// Ternary Operator
            if (country.EditCountry())
            {
                // Refresh DataGrid
                MessageBox.Show("Country Data Saved!", "ADPC: Country Data");
                clearScreen();
                refreshGrid(); // Refresh Screen for new Changes to take effects
                EnableEditMode = 0;
                EditMode();
            }
            else { labelError.Text = "Error Saving Data"; }
        }
        void refreshGrid() 
        {
        
            ClassCountries country = new ClassCountries();
            dataGridViewCountries.DataSource = country.retrieveAllData();
        }
        void clearScreen() 
        {
            textBoxCName.Text = "";
            textBoxCCode.Text = "";
            checkBoxActive.Checked = false;
            textBoxCountryID.Text = "";
        }
        void EditCountryData() 
        {
            /* When countryID is empty Invalid Editing Data */
            if (string.IsNullOrEmpty(textBoxCountryID.Text.Trim())) { labelError.Text = "When countryID is empty Invalid Editing Data"; return; }
            if (validateCountries())
            {
                // Save Data
                SaveEditedData();
            }

        }

        private void FormCountries_Load(object sender, EventArgs e)
        {
            refreshGrid();
            EditMode();
        }

        private void dataGridViewCountries_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxCountryID.Text = dataGridViewCountries.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBoxCName.Text = dataGridViewCountries.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxCCode.Text = dataGridViewCountries.Rows[e.RowIndex].Cells[2].Value.ToString();
            if (dataGridViewCountries.Rows[e.RowIndex].Cells[3].Value.ToString() == "True") { checkBoxActive.Checked = true; }
            else { checkBoxActive.Checked = false; }
            EnableEditMode = 1;
            EditMode();
        }
        void EditMode() 
        {
            //EnableEditMode = 1;
            if (EnableEditMode > 0) { buttonCancel.Text = "Can&cel Edit"; buttonCancel.Enabled = true; }
            else { buttonCancel.Text = "Can&cel Save"; buttonCancel.Enabled = false; }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            clearScreen();
            EnableEditMode = 0;
            EditMode();
        }
    }
}
