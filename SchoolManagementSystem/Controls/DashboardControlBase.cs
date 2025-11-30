namespace SchoolManagementSystem.Controls
{
    internal class DashboardControlBase
    {

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }
    }
}