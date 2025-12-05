namespace SchoolSystem.Controls
{
    partial class AddLocationControl
    {
        private System.ComponentModel.IContainer components = null;
        private Panel pnlHeader;
        private Label lblTitle;
        private Panel pnlForm;
        private TextBox txtCountry;
        private TextBox txtCity;
        private TextBox txtStreet;
        private TextBox txtBuildingNo;
        private Button btnAddLocation;
        private Button btnClear;
        private Label lblCountry;
        private Label lblCity;
        private Label lblStreet;
        private Label lblBuildingNo;
        private ToolTip toolTip;
        private Label lblCountryError;
        private Label lblCityError;
        private Label lblStreetError;
        private Label lblBuildingNoError;
        private Label lblStatus;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pnlHeader = new Panel();
            lblTitle = new Label();
            pnlForm = new Panel();
            lblStatus = new Label();
            lblBuildingNoError = new Label();
            lblStreetError = new Label();
            lblCityError = new Label();
            lblCountryError = new Label();
            btnClear = new Button();
            btnAddLocation = new Button();
            txtBuildingNo = new TextBox();
            txtStreet = new TextBox();
            txtCity = new TextBox();
            txtCountry = new TextBox();
            lblBuildingNo = new Label();
            lblStreet = new Label();
            lblCity = new Label();
            lblCountry = new Label();
            toolTip = new ToolTip(components);
            pnlHeader.SuspendLayout();
            pnlForm.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(41, 128, 185);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(3, 4, 3, 4);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(500, 58);
            pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(19, 10);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(233, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "📍 Add Location";
            // 
            // pnlForm
            // 
            pnlForm.Controls.Add(lblStatus);
            pnlForm.Controls.Add(lblBuildingNoError);
            pnlForm.Controls.Add(lblStreetError);
            pnlForm.Controls.Add(lblCityError);
            pnlForm.Controls.Add(lblCountryError);
            pnlForm.Controls.Add(btnClear);
            pnlForm.Controls.Add(btnAddLocation);
            pnlForm.Controls.Add(txtBuildingNo);
            pnlForm.Controls.Add(txtStreet);
            pnlForm.Controls.Add(txtCity);
            pnlForm.Controls.Add(txtCountry);
            pnlForm.Controls.Add(lblBuildingNo);
            pnlForm.Controls.Add(lblStreet);
            pnlForm.Controls.Add(lblCity);
            pnlForm.Controls.Add(lblCountry);
            pnlForm.Dock = DockStyle.Fill;
            pnlForm.Location = new Point(0, 58);
            pnlForm.Margin = new Padding(3, 4, 3, 4);
            pnlForm.Name = "pnlForm";
            pnlForm.Padding = new Padding(30, 25, 30, 25);
            pnlForm.Size = new Size(500, 567);
            pnlForm.TabIndex = 1;
            pnlForm.Paint += pnlForm_Paint;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblStatus.Location = new Point(34, 375);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(0, 20);
            lblStatus.TabIndex = 15;
            lblStatus.Visible = false;
            // 
            // lblBuildingNoError
            // 
            lblBuildingNoError.AutoSize = true;
            lblBuildingNoError.Font = new Font("Segoe UI", 8F);
            lblBuildingNoError.ForeColor = Color.FromArgb(231, 76, 60);
            lblBuildingNoError.Location = new Point(180, 250);
            lblBuildingNoError.Name = "lblBuildingNoError";
            lblBuildingNoError.Size = new Size(0, 19);
            lblBuildingNoError.TabIndex = 14;
            // 
            // lblStreetError
            // 
            lblStreetError.AutoSize = true;
            lblStreetError.Font = new Font("Segoe UI", 8F);
            lblStreetError.ForeColor = Color.FromArgb(231, 76, 60);
            lblStreetError.Location = new Point(180, 175);
            lblStreetError.Name = "lblStreetError";
            lblStreetError.Size = new Size(0, 19);
            lblStreetError.TabIndex = 13;
            // 
            // lblCityError
            // 
            lblCityError.AutoSize = true;
            lblCityError.Font = new Font("Segoe UI", 8F);
            lblCityError.ForeColor = Color.FromArgb(231, 76, 60);
            lblCityError.Location = new Point(180, 100);
            lblCityError.Name = "lblCityError";
            lblCityError.Size = new Size(0, 19);
            lblCityError.TabIndex = 12;
            // 
            // lblCountryError
            // 
            lblCountryError.AutoSize = true;
            lblCountryError.Font = new Font("Segoe UI", 8F);
            lblCountryError.ForeColor = Color.FromArgb(231, 76, 60);
            lblCountryError.Location = new Point(180, 25);
            lblCountryError.Name = "lblCountryError";
            lblCountryError.Size = new Size(0, 19);
            lblCountryError.TabIndex = 11;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 9F);
            btnClear.Location = new Point(186, 242);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(132, 39);
            btnClear.TabIndex = 10;
            btnClear.Text = "🗑️ Clear All";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnAddLocation
            // 
            btnAddLocation.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAddLocation.Location = new Point(34, 241);
            btnAddLocation.Margin = new Padding(3, 4, 3, 4);
            btnAddLocation.Name = "btnAddLocation";
            btnAddLocation.Size = new Size(140, 40);
            btnAddLocation.TabIndex = 9;
            btnAddLocation.Text = "➕ Add Location";
            btnAddLocation.UseVisualStyleBackColor = true;
            btnAddLocation.Click += btnAddLocation_Click;
            // 
            // txtBuildingNo
            // 
            txtBuildingNo.Font = new Font("Segoe UI", 10F);
            txtBuildingNo.Location = new Point(180, 191);
            txtBuildingNo.Margin = new Padding(3, 4, 3, 4);
            txtBuildingNo.Name = "txtBuildingNo";
            txtBuildingNo.Size = new Size(270, 30);
            txtBuildingNo.TabIndex = 8;
            // 
            // txtStreet
            // 
            txtStreet.Font = new Font("Segoe UI", 10F);
            txtStreet.Location = new Point(180, 131);
            txtStreet.Margin = new Padding(3, 4, 3, 4);
            txtStreet.Name = "txtStreet";
            txtStreet.Size = new Size(270, 30);
            txtStreet.TabIndex = 7;
            // 
            // txtCity
            // 
            txtCity.Font = new Font("Segoe UI", 10F);
            txtCity.Location = new Point(180, 76);
            txtCity.Margin = new Padding(3, 4, 3, 4);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(270, 30);
            txtCity.TabIndex = 6;
            // 
            // txtCountry
            // 
            txtCountry.Font = new Font("Segoe UI", 10F);
            txtCountry.Location = new Point(180, 21);
            txtCountry.Margin = new Padding(3, 4, 3, 4);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(270, 30);
            txtCountry.TabIndex = 5;
            txtCountry.TextChanged += txtCountry_TextChanged;
            // 
            // lblBuildingNo
            // 
            lblBuildingNo.AutoSize = true;
            lblBuildingNo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblBuildingNo.Location = new Point(34, 191);
            lblBuildingNo.Name = "lblBuildingNo";
            lblBuildingNo.Size = new Size(111, 23);
            lblBuildingNo.TabIndex = 4;
            lblBuildingNo.Text = "Building No:";
            // 
            // lblStreet
            // 
            lblStreet.AutoSize = true;
            lblStreet.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblStreet.Location = new Point(34, 131);
            lblStreet.Name = "lblStreet";
            lblStreet.Size = new Size(64, 23);
            lblStreet.TabIndex = 3;
            lblStreet.Text = "Street:";
            lblStreet.Click += lblStreet_Click;
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCity.Location = new Point(34, 76);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(47, 23);
            lblCity.TabIndex = 2;
            lblCity.Text = "City:";
            // 
            // lblCountry
            // 
            lblCountry.AutoSize = true;
            lblCountry.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCountry.Location = new Point(34, 21);
            lblCountry.Name = "lblCountry";
            lblCountry.Size = new Size(80, 23);
            lblCountry.TabIndex = 1;
            lblCountry.Text = "Country:";
            // 
            // AddLocationControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(pnlForm);
            Controls.Add(pnlHeader);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AddLocationControl";
            Size = new Size(500, 625);
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlForm.ResumeLayout(false);
            pnlForm.PerformLayout();
            ResumeLayout(false);
        }
    }
}