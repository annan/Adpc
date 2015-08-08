using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Adpc
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (!ValidateLoginForm()) { labelError.Text = "Required Fields!"; }
        }

        Boolean ValidateLoginForm() 
        {
            
            if (string.IsNullOrEmpty(textBoxUsername.Text.Trim())) { LoginErrorProvider.SetError(textBoxUsername, "Field Required!"); return false; ; }
            else { LoginErrorProvider.SetError(textBoxUsername, ""); }

            if (string.IsNullOrEmpty(textBoxPassword.Text.Trim())) { LoginErrorProvider.SetError(textBoxPassword, "Field Required!"); return false; }
            else { LoginErrorProvider.SetError(textBoxPassword, ""); }
            return true;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
