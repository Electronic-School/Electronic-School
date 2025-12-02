using System;
using System.Windows.Forms;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using SchoolManagementSystem.Data;
using SchoolManagementSystem.Forms;
using SchoolManagementSystem.Controls;

namespace SchoolManagementSystem.Forms
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // 1. ÅÚÏÇÏ ãÖíİ ÇáÊØÈíŞ (Host)
            var host = Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    // 2. ÅÚÏÇÏ ÓíÇŞ ŞÇÚÏÉ ÇáÈíÇäÇÊ (SchoolDbContext)
                    // íÌÈ Úáíß ÇÓÊÈÏÇá ÓáÓáÉ ÇáÇÊÕÇá åĞå ÈÓáÓáÉ ÇáÇÊÕÇá ÇáÍŞíŞíÉ ÇáÎÇÕÉ Èß
                    // Ãæ ÇÓÊÎÏÇã ØÑíŞÉ ÃÎÑì áÊßæíäåÇ (ãËá ãáİ appsettings.json)
                    // ÈãÇ Ãä ãáİ SchoolDbContext.cs ÇáĞí ÃÑÓáÊå íÍÊæí Úáì ÓáÓáÉ ÇÊÕÇá ËÇÈÊÉ¡ ÓäÓÊÎÏãåÇ ãÄŞÊÇğ

                    // ãáÇÍÙÉ: ÈãÇ ÃääÇ äÓÊÎÏã DI¡ íİÖá ÅÒÇáÉ ÓáÓáÉ ÇáÇÊÕÇá ÇáËÇÈÊÉ ãä SchoolDbContext.cs
                    // æÇÓÊÎÏÇã åĞÇ ÇáÃÓáæÈ:
                    services.AddDbContext<SchoolDbContext>(options =>
                        options.UseSqlServer("Server=.; Database=SchoolManagementDB; Trusted_Connection=True; Integrated Security=True; TrustServerCertificate=True; MultipleActiveResultSets=true;"));

                    // 3. ÊÓÌíá ÇáæÇÌåÉ ÇáÑÆíÓíÉ (SchoolManagementForm)
                    // íÊã ÊÓÌíáåÇ ßÜ Singleton áÃäåÇ ÇáæÇÌåÉ ÇáÑÆíÓíÉ ááÊØÈíŞ
                    services.AddSingleton<SchoolManagementForm>();

                    // 4. ÊÓÌíá ÇáæÇÌåÇÊ ÇáİÑÚíÉ (Forms) ßæÍÏÇÊ Transient
                    // åĞÇ íÖãä Ãä ßá ãÑÉ íÊã İíåÇ ØáÈ äãæĞÌ¡ íÊã ÅäÔÇÁ äÓÎÉ ÌÏíÏÉ ãÚ ÍŞä ÇáÊÈÚíÇÊ
                    services.AddTransient<StudentForm>();
                    services.AddTransient<TeacherForm>();
                    services.AddTransient<EmployeeForm>();
                    services.AddTransient<ParentForm>();
                    // íÌÈ Ãä Êßæä åĞå ÇáäãÇĞÌ ãæÌæÏÉ İí ãÌáÏ Forms
                    // ÅĞÇ ßÇäÊ LocationForm æ CourseManagementForm ãæÌæÏÉ İí ãÌáÏ Forms
                    services.AddTransient<LocationForm>();
                    services.AddTransient<CourseManagementForm>();

                    // 5. ÊÓÌíá æÍÏÇÊ ÇáÊÍßã (User Controls)
                    // íÌÈ ÊÓÌíá ÌãíÚ æÍÏÇÊ ÇáÊÍßã ÇáÊí ÓíÊã ÇÓÊÎÏÇãåÇ İí SchoolManagementForm
                    services.AddTransient<DashboardControl>();
                    // íÌÈ ÊÓÌíá ÌãíÚ ÇáÜ UserControls ÇáÃÎÑì ÇáÊí ÊÓÊÎÏã DbContext (ãËá BaseUserControl)
                    // services.AddTransient<BaseUserControl>(); 
                    // services.AddTransient<AddStudentControl>(); 
                    // ... ÅáÎ
                })
                .Build();

            // 6. ÊÔÛíá ÇáÊØÈíŞ
            ApplicationConfiguration.Initialize();

            // ÇáÍÕæá Úáì ÇáæÇÌåÉ ÇáÑÆíÓíÉ ãä ÍÇæíÉ ÇáÎÏãÇÊ æÊÔÛíáåÇ
            Application.Run(host.Services.GetRequiredService<SchoolManagementForm>());
        }
    }
}