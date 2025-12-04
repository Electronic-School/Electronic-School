using Microsoft.EntityFrameworkCore;
using SchoolSystem.Controls;
using SchoolSystem.Data;
using SchoolSystem.Models;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolSystem
{
    public partial class Form1 : Form
    {
        //private Panel panelTopNav;
        //private Panel panelSidebar;
        //private Panel panelContent;

        public Form1()
        {
            InitializeComponent();
            TestDatabaseConnection();
            var parentControl = new ParentAddControl();
            var selectedParentId = 0;

            //  ”ÃÌ· «·ÕœÀ ·≈—Ã«⁄ ParentId »⁄œ «·≈÷«›…
            parentControl.ParentCreated += (parentId) =>
            {
                MessageBox.Show($"Parent ID received: {parentId}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                selectedParentId = parentId;
            };

            // ≈‰‘«¡ «·›Ê—„ «·–Ì ”ÌÕ ÊÌ «·‹ UserControl
            Form parentForm = new Form();
            parentForm.Text = "Add / Select Parent";
            parentForm.StartPosition = FormStartPosition.CenterParent;
            parentForm.Size = new System.Drawing.Size(420, 400);

            // «” ÷«›… «·‹ UserControl œ«Œ· «·›Ê—„
            parentControl.Dock = DockStyle.Fill;
            parentForm.Controls.Add(parentControl);

            // ⁄—÷ «·›Ê—„ ﬂ‹ Modal
            parentForm.ShowDialog();
        }

        private void TestDatabaseConnection()
        {
            string connectionString = "Server=.;Database=SchoolManagementDB;Integrated Security=True;TrustServerCertificate=True;MultipleActiveResultSets=true";

            try
            {
                var optionsBuilder = new DbContextOptionsBuilder<SchoolDbContext>();
                optionsBuilder.UseSqlServer(connectionString);

                using (var context = new SchoolDbContext(optionsBuilder.Options))
                {
                    context.Database.EnsureCreated();
                    int countryCount = context.Countries.Count();

                    MessageBox.Show(
                        $"Connected successfully to DB!\nNumber of countries: {countryCount}",
                        "Connection Succeeded",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(
                    $"Failed connecting to DB:\n{ex.Message}",
                    "Fatal Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void AddCountry(string countryName)
        {
            string connectionString = "Server=.;Database=SchoolManagementDB;Integrated Security=True;TrustServerCertificate=True;MultipleActiveResultSets=true";

            try
            {
                var optionsBuilder = new DbContextOptionsBuilder<SchoolDbContext>();
                optionsBuilder.UseSqlServer(connectionString);

                using (var context = new SchoolDbContext(optionsBuilder.Options))
                {
                    var country = new Country
                    {
                        CountryCode = countryName.Substring(0, Math.Min(3, countryName.Length)).ToUpper().PadRight(3),
                        CountryName = countryName
                    };

                    context.Countries.Add(country);
                    context.SaveChanges();

                    MessageBox.Show(
                        $"Country '{countryName}' added successfully!",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Failed to add country:\n{ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        //private void InitializeComponent()
        //{
        //    // ...
        //}
    }
}