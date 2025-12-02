using SchoolSystem.Data;
using SchoolSystem.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Tools;
using System.Threading.Tasks;
namespace SchoolSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async Task Form1_Load(object sender, EventArgs e)
        {
            using (var context = new SchoolDbContext())
            {
                //var n = db.Countries.Count();
                await db.Database.EnsureCreatedAsync();
                var country  = await context.Countries.Count<>();
                //foreach(var country in Countries)
                //{
                //    //System.Console.WriteLine
                //}
                MessageBox.Show("Connection Successfull, number of countries: "+n, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
 