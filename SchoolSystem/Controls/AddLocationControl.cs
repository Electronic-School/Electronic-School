using Microsoft.EntityFrameworkCore;
using SchoolSystem.Data;
using SchoolSystem.Models;
using System;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SchoolSystem.Controls
{
    public partial class AddLocationControl : UserControl
    {
        // ألوان التصميم
        private readonly Color PrimaryColor = Color.FromArgb(41, 128, 185); // أزرق داكن
        private readonly Color SecondaryColor = Color.FromArgb(236, 240, 241); // رمادي فاتح
        private readonly Color SuccessColor = Color.FromArgb(46, 204, 113); // أخضر
        private readonly Color ErrorColor = Color.FromArgb(231, 76, 60); // أحمر

        private int _locationId = 0;
        private Location _loadedLocation;

        public event Action<int> LocationCreated;

        public AddLocationControl(int locationId = 0)
        {
            _locationId = locationId;
            InitializeComponent();
            ApplyModernDesign();
            LoadLocationIfExists();
        }

        private void ApplyModernDesign()
        {
            this.BackColor = Color.White;

            // تصميم حقول الإدخال
            StyleTextBox(txtCountry);
            StyleTextBox(txtCity);
            StyleTextBox(txtStreet);
            StyleTextBox(txtBuildingNo);

            // تصميم الأزرار
            StyleButton(btnAddLocation, _locationId == 0 ? PrimaryColor : Color.FromArgb(155, 89, 182), true);
            StyleButton(btnClear, Color.FromArgb(149, 165, 166));

            // إضافة ToolTips
            toolTip.SetToolTip(txtCountry, "Enter country name (e.g., Saudi Arabia)");
            toolTip.SetToolTip(txtCity, "Enter city name (e.g., Riyadh)");
            toolTip.SetToolTip(txtStreet, "Enter street name");
            toolTip.SetToolTip(txtBuildingNo, "Enter building number");
            toolTip.SetToolTip(btnAddLocation, _locationId == 0 ? "Add new location" : "Update location");
            toolTip.SetToolTip(btnClear, "Clear all fields");

            // تعيين النص المناسب للزر
            btnAddLocation.Text = _locationId == 0 ? "➕ Add Location" : "✏️ Update Location";

            // إخفاء رسائل الخطأ
            lblCountryError.Visible = false;
            lblCityError.Visible = false;
            lblStreetError.Visible = false;
            lblBuildingNoError.Visible = false;
        }

        private void StyleTextBox(System.Windows.Forms.TextBox textBox)
        {
            textBox.BackColor = Color.White;
            textBox.BorderStyle = BorderStyle.FixedSingle;
            textBox.Font = new Font("Segoe UI", 10);
        }

        private void StyleButton(System.Windows.Forms.Button button, Color backColor, bool isPrimary = false)
        {
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.BackColor = backColor;
            button.ForeColor = Color.White;
            button.Font = new Font("Segoe UI", isPrimary ? 10 : 9, isPrimary ? FontStyle.Bold : FontStyle.Regular);
            button.Cursor = Cursors.Hand;
            button.Padding = new Padding(10, 5, 10, 5);

            // تأثير hover
            button.MouseEnter += (s, e) => button.BackColor = ControlPaint.Light(backColor, 0.1f);
            button.MouseLeave += (s, e) => button.BackColor = backColor;
        }

        private void LoadLocationIfExists()
        {
            if (_locationId == 0)
                return;

            try
            {
                using var context = new SchoolDbContext();

                _loadedLocation = context.Locations
                    .Include(l => l.Country)
                    .Include(l => l.City)
                    .AsNoTracking()
                    .FirstOrDefault(l => l.LocationId == _locationId);

                if (_loadedLocation == null)
                {
                    MessageBox.Show("Location not found. Creating a new one.",
                        "Info",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    return;
                }

                txtCountry.Text = _loadedLocation.Country?.CountryName ?? "";
                txtCity.Text = _loadedLocation.City?.CityName ?? "";
                txtStreet.Text = _loadedLocation.Street ?? "";
                txtBuildingNo.Text = _loadedLocation.BuildingNo ?? "";

                ShowStatusMessage($"Loaded location ID: {_locationId}", SuccessColor);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading location: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnAddLocation_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
                return;

            try
            {
                Cursor = Cursors.WaitCursor;
                btnAddLocation.Enabled = false;

                using var context = new SchoolDbContext();

                string countryName = CapitalizeFirstLetter(txtCountry.Text.Trim());
                string cityName = CapitalizeFirstLetter(txtCity.Text.Trim());
                string street = txtStreet.Text.Trim();
                string buildingNo = txtBuildingNo.Text.Trim();

                var country = context.Countries.FirstOrDefault(c => c.CountryName == countryName);
                if (country == null)
                {
                    country = new Country
                    {
                        CountryName = countryName,
                        CountryCode = GenerateCode(countryName)
                    };
                    context.Countries.Add(country);
                    context.SaveChanges();
                }

                var city = context.Cities.FirstOrDefault(c => c.CityName == cityName);
                if (city == null)
                {
                    city = new City
                    {
                        CityName = cityName,
                        CityCode = GenerateCode(cityName)
                    };
                    context.Cities.Add(city);
                    context.SaveChanges();
                }

                if (_locationId == 0)
                {
                    var newLocation = new Location
                    {
                        Country = country,
                        City = city,
                        Street = street,
                        BuildingNo = buildingNo
                    };

                    context.Locations.Add(newLocation);
                    context.SaveChanges();

                    ShowSuccessMessage(newLocation.LocationId, "created");
                    LocationCreated?.Invoke(newLocation.LocationId);
                }
                else
                {
                    // إعادة تحميل الموقع للتأكد من أن لدينا أحدث نسخة
                    var locationToUpdate = context.Locations.Find(_locationId);
                    if (locationToUpdate == null)
                    {
                        MessageBox.Show("Location no longer exists.",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        return;
                    }

                    locationToUpdate.Country = country;
                    locationToUpdate.City = city;
                    locationToUpdate.Street = street;
                    locationToUpdate.BuildingNo = buildingNo;

                    context.SaveChanges();

                    ShowSuccessMessage(_locationId, "updated");
                    LocationCreated?.Invoke(_locationId);
                }

                // إغلاق النافذة إذا كانت تابعة لفورم
                if (Parent is Form parentForm)
                {
                    parentForm.DialogResult = DialogResult.OK;
                    parentForm.Close();
                }
            }
            catch (DbUpdateException dbEx)
            {
                MessageBox.Show($"Database error: {dbEx.InnerException?.Message ?? dbEx.Message}",
                    "Save Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
                btnAddLocation.Enabled = true;
            }
        }

        private bool ValidateInputs()
        {
            bool isValid = true;

            // التحقق من البلد
            if (string.IsNullOrWhiteSpace(txtCountry.Text))
            {
                ShowFieldError(lblCountryError, "Country name is required");
                isValid = false;
            }
            else if (txtCountry.Text.Trim().Length < 2)
            {
                ShowFieldError(lblCountryError, "Country name is too short");
                isValid = false;
            }
            else
            {
                ClearFieldError(lblCountryError);
            }

            // التحقق من المدينة
            if (string.IsNullOrWhiteSpace(txtCity.Text))
            {
                ShowFieldError(lblCityError, "City name is required");
                isValid = false;
            }
            else if (txtCity.Text.Trim().Length < 2)
            {
                ShowFieldError(lblCityError, "City name is too short");
                isValid = false;
            }
            else
            {
                ClearFieldError(lblCityError);
            }

            // التحقق من الشارع
            if (string.IsNullOrWhiteSpace(txtStreet.Text))
            {
                ShowFieldError(lblStreetError, "Street name is required");
                isValid = false;
            }
            else if (txtStreet.Text.Trim().Length < 2)
            {
                ShowFieldError(lblStreetError, "Street name is too short");
                isValid = false;
            }
            else
            {
                ClearFieldError(lblStreetError);
            }

            // التحقق من رقم المبنى
            if (string.IsNullOrWhiteSpace(txtBuildingNo.Text))
            {
                ShowFieldError(lblBuildingNoError, "Building number is required");
                isValid = false;
            }
            else
            {
                ClearFieldError(lblBuildingNoError);
            }

            if (!isValid)
            {
                ShowStatusMessage("Please correct all errors", ErrorColor);
            }

            return isValid;
        }

        private void ShowFieldError(Label errorLabel, string message)
        {
            errorLabel.Text = message;
            errorLabel.ForeColor = ErrorColor;
            errorLabel.Visible = true;
        }

        private void ClearFieldError(Label errorLabel)
        {
            errorLabel.Text = "";
            errorLabel.Visible = false;
        }

        private string GenerateCode(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                return "XXX";

            // أخذ أول 3 أحرف وتحويلها لحروف كبيرة
            string code = name.Substring(0, Math.Min(3, name.Length)).ToUpper();

            // إضافة أرقام إذا كان الاسم أقل من 3 أحرف
            return code.PadRight(3, 'X');
        }

        private string CapitalizeFirstLetter(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                return text;

            return char.ToUpper(text[0]) + text.Substring(1).ToLower();
        }

        private void ShowSuccessMessage(int locationId, string action)
        {
            string message = $"✅ Location {action} successfully!\n\n" +
                           $"Location ID: {locationId}\n" +
                           $"Address: {txtStreet.Text} {txtBuildingNo.Text}, {txtCity.Text}, {txtCountry.Text}";

            MessageBox.Show(message,
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private async void ShowStatusMessage(string message, Color color)
        {
            lblStatus.Text = message;
            lblStatus.ForeColor = color;
            lblStatus.Visible = true;

            await Task.Delay(3000);
            lblStatus.Visible = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Clear all fields?",
                "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                txtCountry.Clear();
                txtCity.Clear();
                txtStreet.Clear();
                txtBuildingNo.Clear();

                ClearFieldError(lblCountryError);
                ClearFieldError(lblCityError);
                ClearFieldError(lblStreetError);
                ClearFieldError(lblBuildingNoError);

                txtCountry.Focus();
                ShowStatusMessage("All fields cleared", Color.FromArgb(149, 165, 166));
            }
        }

        private void LogLocationAction(int locationId, string action)
        {
            string logMessage = $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] Location {action} - " +
                               $"ID: {locationId}, Address: {txtStreet.Text} {txtBuildingNo.Text}, {txtCity.Text}, {txtCountry.Text}";

            System.Diagnostics.Debug.WriteLine(logMessage);
        }

        private void txtCountry_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblStreet_Click(object sender, EventArgs e)
        {

        }

        private void pnlForm_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}