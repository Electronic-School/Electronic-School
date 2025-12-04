using System;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using SchoolSystem.Data;
using SchoolSystem.Models;

namespace SchoolSystem.Controls
{
    public partial class AddLocationControl1 : UserControl
    {
        public event Action<int> LocationCreated;

        public AddLocationControl1()
        {
            InitializeComponent();
        }

        private void btnAddLocation_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=.;Database=SchoolManagementDB;Integrated Security=True;TrustServerCertificate=True;MultipleActiveResultSets=true";

            string countryName = txtCountry.Text.Trim();
            string cityName = txtCity.Text.Trim();
            string street = txtStreet.Text.Trim();
            string buildingNo = txtBuildingNo.Text.Trim();

            if (string.IsNullOrEmpty(countryName) || string.IsNullOrEmpty(cityName) ||
                string.IsNullOrEmpty(street) || string.IsNullOrEmpty(buildingNo))
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var optionsBuilder = new DbContextOptionsBuilder<SchoolDbContext>();
                optionsBuilder.UseSqlServer(connectionString);

                using (var context = new SchoolDbContext(optionsBuilder.Options))
                {
                    var country = context.Countries.FirstOrDefault(c => c.CountryName == countryName);
                    if (country == null)
                    {
                        country = new Country
                        {
                            CountryName = countryName,
                            CountryCode = countryName.Substring(0, Math.Min(3, countryName.Length)).ToUpper().PadRight(3)
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
                            CityCode = cityName.Substring(0, Math.Min(3, cityName.Length)).ToUpper().PadRight(3)
                        };
                        context.Cities.Add(city);
                        context.SaveChanges();
                    }

                    var location = new Location
                    {
                        Country = country,
                        City = city,
                        Street = street,
                        BuildingNo = buildingNo
                    };
                    context.Locations.Add(location);
                    context.SaveChanges();

                    MessageBox.Show($"Location created successfully with ID: {location.LocationId}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LocationCreated?.Invoke(location.LocationId);

                    // Close the parent form automatically after adding
                    if (this.Parent is Form parentForm)
                    {
                        parentForm.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to add location:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
