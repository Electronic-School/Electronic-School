using SchoolSystem.Data;
using SchoolSystem.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
namespace SchoolSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            TestDatabaseConnection();
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
                        $" Connected successfully to DB!\n Number of countries: {countryCount}",
                        "Connection Successeded",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(
                    $"Fialed connecting to DB:\n{ex.Message}",
                    "Fatal Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
 