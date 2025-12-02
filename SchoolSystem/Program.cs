//using Microsoft.Data.SqlClient;
using SchoolSystem.Data;

namespace SchoolSystem
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //string connectionString = "Server=YourServerName;Database=YourDatabaseName;User Id=YourUsername;Password=YourPassword;";
            //try
            //{
                //using (var db = new SchoolDbContext())
                //{
                //    var n= db.Countries.Count();
                //    MessageBox.Show("Connection Successfull", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}
            //}
            //catch ( Exception ex)
            //{
            //    MessageBox.Show("Connection Successfull", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Connection Successfull", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}