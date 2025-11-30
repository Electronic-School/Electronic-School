using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using SchoolManagementSystem.Data;

namespace SchoolManagementSystem.Controls
{
    public partial class BaseUserControl : UserControl
    {
        protected SchoolDbContext DbContext { get; private set; }
        public BaseUserControl()
        {
            try
            {
                var optionsBuilder = new DbContextOptionsBuilder<SchoolDbContext>();
                optionsBuilder.UseInMemoryDatabase("SchoolManagementDB");
                DbContext = new SchoolDbContext(optionsBuilder.Options);
                DbContext.Database.EnsureCreated();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to initialize database context: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //InitializeComponent();
        }
    }
}
