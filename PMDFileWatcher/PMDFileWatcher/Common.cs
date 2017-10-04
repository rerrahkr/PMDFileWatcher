using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PMDFileWatcher
{
    public static class Common
    {
        public static string AssemblyTitle
        {
            get
            {
                var ata = (AssemblyTitleAttribute)Attribute.GetCustomAttribute(Assembly.GetExecutingAssembly(), typeof(AssemblyTitleAttribute), false);
                return ata.Title;
            }
        }

        public static string AssemblyDescription
        {
            get
            {
                var ada = (AssemblyDescriptionAttribute)Attribute.GetCustomAttribute(Assembly.GetExecutingAssembly(), typeof(AssemblyDescriptionAttribute), false);
                return ada.Description;
            }
        }

        public static string AssemblyCompany
        {
            get
            {
                var aca = (AssemblyCompanyAttribute)Attribute.GetCustomAttribute(Assembly.GetExecutingAssembly(), typeof(AssemblyCompanyAttribute), false);
                return aca.Company;
            }
        }

        public static string AssemblyCopyright
        {
            get
            {
                var aca = (AssemblyCopyrightAttribute)Attribute.GetCustomAttribute(Assembly.GetExecutingAssembly(), typeof(AssemblyCopyrightAttribute), false);
                return aca.Copyright;
            }
        }

        public static string AssemblyFileVersion
        {
            get
            {
                var afva = (AssemblyFileVersionAttribute)Attribute.GetCustomAttribute(Assembly.GetExecutingAssembly(), typeof(AssemblyFileVersionAttribute), false);
                return afva.Version;
            }
        }

        public static System.Drawing.Icon Icon
        {
            get
            {
                string path = Assembly.GetEntryAssembly().Location;
                return System.Drawing.Icon.ExtractAssociatedIcon(path);
            }
        }
    }
}

