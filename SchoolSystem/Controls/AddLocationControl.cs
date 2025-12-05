using Microsoft.EntityFrameworkCore;
using SchoolSystem.Data;
using SchoolSystem.Models;
using System;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        private SchoolDbContext _context;

        public event Action<int> LocationCreated;

        public AddLocationControl(int locationId = 0)
        {
            _locationId = locationId;
            InitializeComponent();
            _context = new SchoolDbContext();
            ApplyModernDesign();
            LoadCountries();
            LoadLocationIfExists();
        }

        private void ApplyModernDesign()
        {
            this.BackColor = Color.White;

            // تصميم الكومبو بوكس
            StyleComboBox(cmbCountry);
            StyleComboBox(cmbCity);

            // تصميم حقول الإدخال الأخرى
            StyleTextBox(txtStreet);
            StyleTextBox(txtBuildingNo);

            // تصميم الأزرار
            StyleButton(btnAddLocation, _locationId == 0 ? PrimaryColor : Color.FromArgb(155, 89, 182), true);
            StyleButton(btnClear, Color.FromArgb(149, 165, 166));
            

            // إضافة ToolTips
            toolTip.SetToolTip(cmbCountry, "Select a country");
            toolTip.SetToolTip(cmbCity, "Select a city (depends on selected country)");
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

            // تعطيل اختيار المدن في البداية
            cmbCity.Enabled = false;
        }

        private void StyleComboBox(ComboBox comboBox)
        {
            comboBox.BackColor = Color.White;
            comboBox.Font = new Font("Segoe UI", 10);
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox.FlatStyle = FlatStyle.Flat;
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

        private void LoadCountries()
        {
            try
            {
                cmbCountry.Items.Clear();
                cmbCity.Items.Clear();
                cmbCity.Enabled = false;

                var countries = _context.Countries
                    .OrderBy(c => c.CountryName)
                    .ToList();

                if (countries.Any())
                {
                    cmbCountry.Items.Add(new ComboBoxItem { Text = "-- Select Country --", Value = 0 });

                    foreach (var country in countries)
                    {
                        // عرض اسم الدولة فقط بدون الكود
                        cmbCountry.Items.Add(new ComboBoxItem
                        {
                            Text = country.CountryName, // فقط اسم الدولة
                            Value = country.CountryID,
                            Tag = country.CountryCode // تخزين الكود في الـ Tag
                        });
                    }

                    cmbCountry.SelectedIndex = 0;
                    lblCountryError.Visible = false;
                }
                else
                {
                    cmbCountry.Items.Add("No countries available");
                    cmbCountry.SelectedIndex = 0;
                    cmbCountry.Enabled = false;
                    lblCountryError.Text = "Please add countries first";
                    lblCountryError.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading countries: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void LoadCitiesByCountryCode(string countryCode)
        {
            try
            {
                cmbCity.Items.Clear();
                cmbCity.Text = "";
                cmbCity.Enabled = false;

                if (string.IsNullOrEmpty(countryCode))
                    return;

                var cities = _context.Cities
                    .Where(c => c.CountryCode == countryCode)
                    .OrderBy(c => c.CityName)
                    .ToList();

                if (cities.Any())
                {
                    cmbCity.Items.Add(new ComboBoxItem { Text = "-- Select City --", Value = 0 });

                    foreach (var city in cities)
                    {
                        // عرض اسم المدينة فقط بدون الكود
                        cmbCity.Items.Add(new ComboBoxItem
                        {
                            Text = city.CityName, // فقط اسم المدينة
                            Value = city.CityId,
                            Tag = city.CityCode // تخزين الكود في الـ Tag للاستخدام لاحقاً إذا احتجنا
                        });
                    }

                    cmbCity.SelectedIndex = 0;
                    cmbCity.Enabled = true;
                    lblCityError.Visible = false;
                }
                else
                {
                    cmbCity.Items.Add("No cities available for this country");
                    cmbCity.SelectedIndex = 0;
                    cmbCity.Enabled = false;
                    lblCityError.Text = "No cities found for selected country";
                    lblCityError.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading cities: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void LoadLocationIfExists()
        {
            if (_locationId == 0)
                return;

            try
            {
                _loadedLocation = _context.Locations
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

                // البحث عن الدولة في القائمة
                bool countryFound = false;
                for (int i = 0; i < cmbCountry.Items.Count; i++)
                {
                    if (cmbCountry.Items[i] is ComboBoxItem item && item.Value == _loadedLocation.Country?.CountryID)
                    {
                        cmbCountry.SelectedIndex = i;
                        countryFound = true;
                        break;
                    }
                }

                if (!countryFound)
                {
                    MessageBox.Show($"Country '{_loadedLocation.Country?.CountryName}' not found in list.",
                        "Warning",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                // بعد اختيار الدولة، تحميل المدن
                if (_loadedLocation.Country != null)
                {
                    LoadCitiesByCountryCode(_loadedLocation.Country.CountryCode);

                    // البحث عن المدينة في القائمة
                    bool cityFound = false;
                    for (int i = 0; i < cmbCity.Items.Count; i++)
                    {
                        if (cmbCity.Items[i] is ComboBoxItem item && item.Value == _loadedLocation.City?.CityId)
                        {
                            cmbCity.SelectedIndex = i;
                            cityFound = true;
                            break;
                        }
                    }

                    if (!cityFound)
                    {
                        MessageBox.Show($"City '{_loadedLocation.City?.CityName}' not found in list.",
                            "Warning",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }
                }

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

                using var transaction = _context.Database.BeginTransaction();

                try
                {
                    var selectedCountryItem = cmbCountry.SelectedItem as ComboBoxItem;
                    var selectedCityItem = cmbCity.SelectedItem as ComboBoxItem;

                    if (selectedCountryItem == null || selectedCountryItem.Value == 0)
                    {
                        MessageBox.Show("Please select a country",
                            "Validation Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;
                    }

                    if (selectedCityItem == null || selectedCityItem.Value == 0)
                    {
                        MessageBox.Show("Please select a city",
                            "Validation Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;
                    }

                    string street = txtStreet.Text.Trim();
                    string buildingNo = txtBuildingNo.Text.Trim();

                    // الحصول على الدولة والمدينة المحددة
                    var country = _context.Countries.Find(selectedCountryItem.Value);
                    var city = _context.Cities.Find(selectedCityItem.Value);

                    if (country == null || city == null)
                    {
                        MessageBox.Show("Selected country or city not found",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        return;
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

                        _context.Locations.Add(newLocation);
                        _context.SaveChanges();

                        ShowSuccessMessage(newLocation.LocationId, "created");
                        LocationCreated?.Invoke(newLocation.LocationId);
                    }
                    else
                    {
                        // إعادة تحميل الموقع للتأكد من أن لدينا أحدث نسخة
                        var locationToUpdate = _context.Locations.Find(_locationId);
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

                        _context.SaveChanges();

                        ShowSuccessMessage(_locationId, "updated");
                        LocationCreated?.Invoke(_locationId);
                    }

                    transaction.Commit();

                    // إغلاق النافذة إذا كانت تابعة لفورم
                    if (Parent is Form parentForm)
                    {
                        parentForm.DialogResult = DialogResult.OK;
                        parentForm.Close();
                    }
                }
                catch
                {
                    transaction.Rollback();
                    throw;
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
            var selectedCountry = cmbCountry.SelectedItem as ComboBoxItem;
            if (selectedCountry == null || selectedCountry.Value == 0)
            {
                ShowFieldError(lblCountryError, "Please select a country");
                isValid = false;
            }
            else
            {
                ClearFieldError(lblCountryError);
            }

            // التحقق من المدينة
            var selectedCity = cmbCity.SelectedItem as ComboBoxItem;
            if (selectedCity == null || selectedCity.Value == 0)
            {
                ShowFieldError(lblCityError, "Please select a city");
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

        private void ShowSuccessMessage(int locationId, string action)
        {
            var selectedCountry = cmbCountry.SelectedItem as ComboBoxItem;
            var selectedCity = cmbCity.SelectedItem as ComboBoxItem;

            string countryName = selectedCountry?.Text ?? "Unknown";
            string cityName = selectedCity?.Text ?? "Unknown";

            string message = $"✅ Location {action} successfully!\n\n" +
                           $"Location ID: {locationId}\n" +
                           $"Address: {txtStreet.Text} {txtBuildingNo.Text}, {cityName}, {countryName}";

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
                cmbCountry.SelectedIndex = 0;
                cmbCity.Items.Clear();
                cmbCity.Enabled = false;
                txtStreet.Clear();
                txtBuildingNo.Clear();

                ClearFieldError(lblCountryError);
                ClearFieldError(lblCityError);
                ClearFieldError(lblStreetError);
                ClearFieldError(lblBuildingNoError);

                cmbCountry.Focus();
                ShowStatusMessage("All fields cleared", Color.FromArgb(149, 165, 166));
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadCountries();
            ShowStatusMessage("Countries list refreshed", SuccessColor);
        }

        private void cmbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItem = cmbCountry.SelectedItem as ComboBoxItem;
            if (selectedItem != null && selectedItem.Tag != null)
            {
                string countryCode = selectedItem.Tag.ToString();
                LoadCitiesByCountryCode(countryCode);
            }
            else
            {
                cmbCity.Items.Clear();
                cmbCity.Text = "";
                cmbCity.Enabled = false;
            }
        }

        // فئة مساعدة للكومبو بوكس
        private class ComboBoxItem
        {
            public string Text { get; set; }
            public int Value { get; set; }
            public object Tag { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context?.Dispose();
            }
            base.Dispose(disposing);
        }

        private void lblStreet_Click(object sender, EventArgs e)
        {
            // Empty handler
        }

        private void pnlForm_Paint(object sender, PaintEventArgs e)
        {
            // Empty handler
        }

        private void txtStreet_TextChanged(object sender, EventArgs e)
        {
            // Empty handler
        }
    }
}