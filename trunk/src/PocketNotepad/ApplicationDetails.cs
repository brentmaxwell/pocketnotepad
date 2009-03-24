namespace PocketNotepad
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Reflection;

    public static class ApplicationDetails
    {
        public enum AttributeType
        {
            Title,
            Product,
            Description,
            Copyright,
            Company,
            Version,
        }

        public static string Get(AttributeType attr)
        {
            string output = "";
            switch (attr)
            {
                case AttributeType.Title:
                    AssemblyTitleAttribute title = (AssemblyTitleAttribute)Attribute.GetCustomAttribute(Assembly.GetExecutingAssembly(), typeof(AssemblyTitleAttribute));
                    output = title.Title;
                    break;
                case AttributeType.Product:
                    AssemblyProductAttribute product = (AssemblyProductAttribute)Attribute.GetCustomAttribute(Assembly.GetExecutingAssembly(), typeof(AssemblyProductAttribute));
                    output = product.Product;
                    break;
                case AttributeType.Description:
                    AssemblyDescriptionAttribute description = (AssemblyDescriptionAttribute)Attribute.GetCustomAttribute(Assembly.GetExecutingAssembly(), typeof(AssemblyDescriptionAttribute));
                    output = description.Description;
                    break;
                case AttributeType.Copyright:
                    AssemblyCopyrightAttribute copyright = (AssemblyCopyrightAttribute)Attribute.GetCustomAttribute(Assembly.GetExecutingAssembly(), typeof(AssemblyCopyrightAttribute));
                    output = copyright.Copyright;
                    break;
                case AttributeType.Company:
                    AssemblyCompanyAttribute company = (AssemblyCompanyAttribute)Attribute.GetCustomAttribute(Assembly.GetExecutingAssembly(), typeof(AssemblyCompanyAttribute));
                    output = company.Company;
                    break;
                case AttributeType.Version:
                    output = Assembly.GetExecutingAssembly().GetName().Version.ToString();
                    break;
            }
            return output;
        }
    }
}
