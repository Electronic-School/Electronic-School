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
    public partial class ParentAddControl : UserControl
    {
        // ألوان التصميم
        private readonly Color PrimaryColor = Color.FromArgb(41, 128, 185); // أزرق داكن
        private readonly Color SecondaryColor = Color.FromArgb(236, 240, 241); // رمادي فاتح
        private readonly Color SuccessColor = Color.FromArgb(46, 204, 113); // أخضر
        private readonly Color ErrorColor = Color.FromArgb(231, 76, 60); // أحمر

        public event Action<int> ParentCreated;
        private int _parentId = 0;
        private int selectedLocationId = 0;
        private Regex emailRegex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        private Regex phoneRegex = new Regex(@"^[\+]?[0-9\s\-\(\)]{7,10}$");

        public ParentAddControl(int parentId = 0)
        {
            _parentId = parentId;
            InitializeComponent();
            ApplyModernDesign();
            InitializeDatePicker();
            LoadParentIfExists();
        }

        private void ApplyModernDesign()
        {
            this.BackColor = Color.White;

            // تصميم حقول الإدخال
            StyleTextBox(txtFirstName);
            StyleTextBox(txtLastName);
            StyleTextBox(txtPhone);
            StyleTextBox(txtEmail);
            StyleTextBox(txtChildrenCount);

            // تصميم DatePicker
            dtpDateOfBirth.Font = new Font("Segoe UI", 10);
            dtpDateOfBirth.CalendarFont = new Font("Segoe UI", 9);

            // تصميم الأزرار
            StyleButton(btnSelectLocation, PrimaryColor);
            StyleButton(btnAddParent, _parentId == 0 ? PrimaryColor : Color.FromArgb(155, 89, 182), true);
            StyleButton(btnClear, Color.FromArgb(149, 165, 166));

            // إضافة ToolTips
            toolTip.SetToolTip(txtFirstName, "Enter parent's first name");
            toolTip.SetToolTip(txtLastName, "Enter parent's last name");
            toolTip.SetToolTip(txtPhone, "Enter phone number (10-15 digits)");
            toolTip.SetToolTip(txtEmail, "Enter email address");
            toolTip.SetToolTip(txtChildrenCount, "Enter number of children in school (optional)");
            toolTip.SetToolTip(dtpDateOfBirth, "Select parent's date of birth");
            toolTip.SetToolTip(btnSelectLocation, "Select location for parent");
            toolTip.SetToolTip(btnAddParent, _parentId == 0 ? "Add new parent" : "Update parent");
            toolTip.SetToolTip(btnClear, "Clear all fields");

            // تعيين النص المناسب للزر
            btnAddParent.Text = _parentId == 0 ? "➕ Add Parent" : "✏️ Update Parent";

            // إخفاء رسائل الخطأ
            lblFirstNameError.Visible = false;
            lblLastNameError.Visible = false;
            lblPhoneError.Visible = false;
            lblEmailError.Visible = false;
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

        private void InitializeDatePicker()
        {
            dtpDateOfBirth.MinDate = new DateTime(1900, 1, 1);
            dtpDateOfBirth.MaxDate = DateTime.Today;
            dtpDateOfBirth.Value = DateTime.Today.AddYears(-30); // قيمة افتراضية: عمر 30 سنة
            dtpDateOfBirth.Format = DateTimePickerFormat.Short;
        }

        private void LoadParentIfExists()
        {
            if (_parentId == 0) return;

            try
            {
                using var context = new SchoolDbContext();
                var parent = context.Parents
                    .Include(p => p.Location)
                    .AsNoTracking()
                    .FirstOrDefault(p => p.ParentsID == _parentId);

                if (parent != null)
                {
                    txtFirstName.Text = parent.FirstName ?? "";
                    txtLastName.Text = parent.LastName ?? "";
                    txtPhone.Text = parent.PhoneNumber ?? "";
                    txtEmail.Text = parent.Email ?? "";
                    dtpDateOfBirth.Value = parent.DateOfBirth ?? DateTime.Today.AddYears(-30);
                    txtChildrenCount.Text = parent.ChildrenInSchool?.ToString() ?? "";
                    selectedLocationId = parent.LocationId;

                    ShowStatusMessage($"Loaded parent ID: {_parentId}", SuccessColor);
                }
                else
                {
                    MessageBox.Show("Parent not found. Creating new one.",
                        "Info",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading parent: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnSelectLocation_Click(object sender, EventArgs e)
        {
            var locationControl = new AddLocationControl(selectedLocationId);
            locationControl.LocationCreated += (locationId) =>
            {
                selectedLocationId = locationId;
                ShowStatusMessage($"Location updated: ID {locationId}", SuccessColor);
            };

            Form locationForm = new Form
            {
                Text = "Select Location",
                Size = new Size(500, 500),
                StartPosition = FormStartPosition.CenterParent,
                MinimizeBox = false,
                MaximizeBox = false
            };

            locationControl.Dock = DockStyle.Fill;
            locationForm.Controls.Add(locationControl);
            locationForm.ShowDialog();
        }

        private void btnAddParent_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
                return;

            try
            {
                Cursor = Cursors.WaitCursor;
                btnAddParent.Enabled = false;

                using var context = new SchoolDbContext();

                string firstName = CapitalizeFirstLetter(txtFirstName.Text.Trim());
                string lastName = CapitalizeFirstLetter(txtLastName.Text.Trim());
                string phone = txtPhone.Text.Trim();
                string email = txtEmail.Text.Trim().ToLower();
                DateTime dob = dtpDateOfBirth.Value.Date;
                int? childrenCount = null;

                if (!string.IsNullOrWhiteSpace(txtChildrenCount.Text) &&
                    int.TryParse(txtChildrenCount.Text.Trim(), out int parsedCount))
                    childrenCount = parsedCount;

                if (_parentId == 0)
                {
                    // أولاً، الحصول على الـ Location من قاعدة البيانات أو من الاختيار
                    var selectedLocation = context.Locations
                        .FirstOrDefault(l => l.LocationId == selectedLocationId);

                    if (selectedLocation == null)
                    {
                        MessageBox.Show("Please select a valid location for the parent.",
                                        "Invalid Input",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                        return;
                    }


                    var parent = new Parent
                    {
                        FirstName = firstName,
                        LastName = lastName,
                        PhoneNumber = phone,
                        Email = email,
                        DateOfBirth = dob,
                        Location = selectedLocation,
                        ChildrenInSchool = childrenCount
                    };


                    context.Parents.Add(parent);
                    context.SaveChanges();


                    ShowSuccessMessage(parent.ParentsID, "added");
                    ParentCreated?.Invoke(parent.ParentsID);
                }
                else
                {
                    var parent = context.Parents.Find(_parentId);
                    if (parent == null)
                    {
                        MessageBox.Show("Parent no longer exists.",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        return;
                    }

                    parent.FirstName = firstName;
                    parent.LastName = lastName;
                    parent.PhoneNumber = phone;
                    parent.Email = email;
                    parent.DateOfBirth = dob;
                    parent.LocationId = selectedLocationId;
                    parent.ChildrenInSchool = childrenCount;


                    context.SaveChanges();

                    ShowSuccessMessage(_parentId, "updated");
                    ParentCreated?.Invoke(_parentId);
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
                btnAddParent.Enabled = true;
            }
        }

        private bool ValidateInputs()
        {
            bool isValid = true;

            // التحقق من الاسم الأول
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                ShowFieldError(lblFirstNameError, "First name is required");
                isValid = false;
            }
            else if (txtFirstName.Text.Trim().Length < 2)
            {
                ShowFieldError(lblFirstNameError, "First name is too short");
                isValid = false;
            }
            else
            {
                ClearFieldError(lblFirstNameError);
            }

            // التحقق من الاسم الأخير
            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                ShowFieldError(lblLastNameError, "Last name is required");
                isValid = false;
            }
            else if (txtLastName.Text.Trim().Length < 2)
            {
                ShowFieldError(lblLastNameError, "Last name is too short");
                isValid = false;
            }
            else
            {
                ClearFieldError(lblLastNameError);
            }

            // التحقق من الهاتف
            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                ShowFieldError(lblPhoneError, "Phone number is required");
                isValid = false;
            }
            else if (!phoneRegex.IsMatch(txtPhone.Text.Trim()))
            {
                ShowFieldError(lblPhoneError, "Invalid phone number format");
                isValid = false;
            }
            else
            {
                ClearFieldError(lblPhoneError);
            }

            // التحقق من البريد الإلكتروني
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                ShowFieldError(lblEmailError, "Email is required");
                isValid = false;
            }
            else if (!emailRegex.IsMatch(txtEmail.Text.Trim()))
            {
                ShowFieldError(lblEmailError, "Invalid email format");
                isValid = false;
            }
            else
            {
                ClearFieldError(lblEmailError);
            }

            // التحقق من عدد الأطفال
            if (!string.IsNullOrWhiteSpace(txtChildrenCount.Text) &&
                !int.TryParse(txtChildrenCount.Text.Trim(), out _))
            {
                ShowFieldError(lblChildrenCountError, "Must be a valid number");
                isValid = false;
            }
            else
            {
                ClearFieldError(lblChildrenCountError);
            }

            // التحقق من الموقع
            if (selectedLocationId == 0)
            {
                ShowStatusMessage("Please select a location", ErrorColor);
                isValid = false;
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

        private string CapitalizeFirstLetter(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                return text;

            return char.ToUpper(text[0]) + text.Substring(1).ToLower();
        }

        private void ShowSuccessMessage(int parentId, string action)
        {
            string message = $"✅ Parent {action} successfully!\n\n" +
                           $"Parent ID: {parentId}\n" +
                           $"Name: {txtFirstName.Text} {txtLastName.Text}\n" +
                           $"Phone: {txtPhone.Text}\n" +
                           $"Email: {txtEmail.Text}";

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
                txtFirstName.Clear();
                txtLastName.Clear();
                txtPhone.Clear();
                txtEmail.Clear();
                txtChildrenCount.Clear();
                dtpDateOfBirth.Value = DateTime.Today.AddYears(-30);
                selectedLocationId = 0;

                ClearFieldError(lblFirstNameError);
                ClearFieldError(lblLastNameError);
                ClearFieldError(lblPhoneError);
                ClearFieldError(lblEmailError);
                ClearFieldError(lblChildrenCountError);

                txtFirstName.Focus();
                ShowStatusMessage("All fields cleared", Color.FromArgb(149, 165, 166));
            }
        }

        private void LogParentAction(int parentId, string action)
        {
            string logMessage = $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] Parent {action} - " +
                               $"ID: {parentId}, Name: {txtFirstName.Text} {txtLastName.Text}";

            System.Diagnostics.Debug.WriteLine(logMessage);
        }

        private void lblFirstName_Click(object sender, EventArgs e)
        {

        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}