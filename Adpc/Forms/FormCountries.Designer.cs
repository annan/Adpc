namespace Adpc
{
    partial class FormCountries
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxActive = new System.Windows.Forms.CheckBox();
            this.labelError = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.textBoxCCode = new System.Windows.Forms.TextBox();
            this.textBoxCName = new System.Windows.Forms.TextBox();
            this.labelCode = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.countryErrorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBoxCountries = new System.Windows.Forms.GroupBox();
            this.dataGridViewCountries = new System.Windows.Forms.DataGridView();
            this.CountryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountryCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Active = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CreatedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxCountryID = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countryErrorProvider1)).BeginInit();
            this.groupBoxCountries.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCountries)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxCountryID);
            this.groupBox1.Controls.Add(this.checkBoxActive);
            this.groupBox1.Controls.Add(this.labelError);
            this.groupBox1.Controls.Add(this.buttonCancel);
            this.groupBox1.Controls.Add(this.buttonExit);
            this.groupBox1.Controls.Add(this.buttonSubmit);
            this.groupBox1.Controls.Add(this.textBoxCCode);
            this.groupBox1.Controls.Add(this.textBoxCName);
            this.groupBox1.Controls.Add(this.labelCode);
            this.groupBox1.Controls.Add(this.labelName);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(694, 267);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Country";
            // 
            // checkBoxActive
            // 
            this.checkBoxActive.AutoSize = true;
            this.checkBoxActive.Location = new System.Drawing.Point(545, 117);
            this.checkBoxActive.Name = "checkBoxActive";
            this.checkBoxActive.Size = new System.Drawing.Size(103, 29);
            this.checkBoxActive.TabIndex = 9;
            this.checkBoxActive.Text = "Active";
            this.checkBoxActive.UseVisualStyleBackColor = true;
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(50, 209);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(31, 29);
            this.labelError.TabIndex = 7;
            this.labelError.Text = "...";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(221, 168);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(129, 45);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(374, 168);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(128, 45);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "E&xit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(524, 168);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(124, 45);
            this.buttonSubmit.TabIndex = 4;
            this.buttonSubmit.Text = "Sa&ve";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // textBoxCCode
            // 
            this.textBoxCCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCCode.Location = new System.Drawing.Point(221, 111);
            this.textBoxCCode.Name = "textBoxCCode";
            this.textBoxCCode.Size = new System.Drawing.Size(233, 35);
            this.textBoxCCode.TabIndex = 3;
            // 
            // textBoxCName
            // 
            this.textBoxCName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCName.Location = new System.Drawing.Point(221, 44);
            this.textBoxCName.Name = "textBoxCName";
            this.textBoxCName.Size = new System.Drawing.Size(427, 35);
            this.textBoxCName.TabIndex = 2;
            // 
            // labelCode
            // 
            this.labelCode.AutoSize = true;
            this.labelCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCode.Location = new System.Drawing.Point(40, 115);
            this.labelCode.Name = "labelCode";
            this.labelCode.Size = new System.Drawing.Size(160, 29);
            this.labelCode.TabIndex = 1;
            this.labelCode.Text = "Country Code";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(40, 50);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(166, 29);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Country Name";
            // 
            // countryErrorProvider1
            // 
            this.countryErrorProvider1.ContainerControl = this;
            // 
            // groupBoxCountries
            // 
            this.groupBoxCountries.Controls.Add(this.dataGridViewCountries);
            this.groupBoxCountries.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxCountries.Location = new System.Drawing.Point(0, 267);
            this.groupBoxCountries.Name = "groupBoxCountries";
            this.groupBoxCountries.Size = new System.Drawing.Size(694, 575);
            this.groupBoxCountries.TabIndex = 1;
            this.groupBoxCountries.TabStop = false;
            this.groupBoxCountries.Text = "Countries";
            // 
            // dataGridViewCountries
            // 
            this.dataGridViewCountries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCountries.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CountryID,
            this.CountryName,
            this.CountryCode,
            this.Active,
            this.CreatedDate});
            this.dataGridViewCountries.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewCountries.Location = new System.Drawing.Point(3, 27);
            this.dataGridViewCountries.Name = "dataGridViewCountries";
            this.dataGridViewCountries.Size = new System.Drawing.Size(688, 545);
            this.dataGridViewCountries.TabIndex = 0;
            this.dataGridViewCountries.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCountries_CellDoubleClick);
            // 
            // CountryID
            // 
            this.CountryID.DataPropertyName = "country_id";
            this.CountryID.HeaderText = "Country ID";
            this.CountryID.Name = "CountryID";
            this.CountryID.ReadOnly = true;
            this.CountryID.Visible = false;
            // 
            // CountryName
            // 
            this.CountryName.DataPropertyName = "country_name";
            this.CountryName.HeaderText = "Country Name";
            this.CountryName.Name = "CountryName";
            this.CountryName.ReadOnly = true;
            // 
            // CountryCode
            // 
            this.CountryCode.DataPropertyName = "country_code";
            this.CountryCode.HeaderText = "Country Code";
            this.CountryCode.Name = "CountryCode";
            this.CountryCode.ReadOnly = true;
            // 
            // Active
            // 
            this.Active.DataPropertyName = "active";
            this.Active.HeaderText = "Active";
            this.Active.Name = "Active";
            this.Active.ReadOnly = true;
            this.Active.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Active.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // CreatedDate
            // 
            this.CreatedDate.DataPropertyName = "created_date";
            this.CreatedDate.HeaderText = "Created Date";
            this.CreatedDate.Name = "CreatedDate";
            this.CreatedDate.ReadOnly = true;
            this.CreatedDate.Visible = false;
            // 
            // textBoxCountryID
            // 
            this.textBoxCountryID.Location = new System.Drawing.Point(100, 174);
            this.textBoxCountryID.Name = "textBoxCountryID";
            this.textBoxCountryID.Size = new System.Drawing.Size(100, 31);
            this.textBoxCountryID.TabIndex = 10;
            this.textBoxCountryID.Visible = false;
            // 
            // FormCountries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 842);
            this.Controls.Add(this.groupBoxCountries);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCountries";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Countries";
            this.Load += new System.EventHandler(this.FormCountries_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countryErrorProvider1)).EndInit();
            this.groupBoxCountries.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCountries)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.TextBox textBoxCCode;
        private System.Windows.Forms.TextBox textBoxCName;
        private System.Windows.Forms.Label labelCode;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.ErrorProvider countryErrorProvider1;
        private System.Windows.Forms.GroupBox groupBoxCountries;
        private System.Windows.Forms.DataGridView dataGridViewCountries;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.CheckBox checkBoxActive;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountryCode;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Active;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedDate;
        private System.Windows.Forms.TextBox textBoxCountryID;
    }
}