using System;
using System.Reflection;

namespace PocketNotepad
{
    /// <summary>
    /// Provides access to the attributes from the AssemblyInfo
    /// </summary>
    public static class ApplicationDetails
    {
        /// <summary>
        /// The Title attribute specified in the AssemblyInfo
        /// </summary>
        public static string Title
        {
            get
            {
                return ((AssemblyTitleAttribute)Attribute.GetCustomAttribute(Assembly.GetExecutingAssembly(), typeof(AssemblyTitleAttribute))).Title;
            }
        }

        /// <summary>
        /// The Description attribute specified in the AssemblyInfo
        /// </summary>
        public static string Description
        {
            get
            {
                return ((AssemblyDescriptionAttribute)Attribute.GetCustomAttribute(Assembly.GetExecutingAssembly(), typeof(AssemblyDescriptionAttribute))).Description;
            }
        }

        /// <summary>
        /// The Configuration attribute specified in the AssemblyInfo
        /// </summary>
        public static string Configuration
        {
            get
            {
                return ((AssemblyConfigurationAttribute)Attribute.GetCustomAttribute(Assembly.GetExecutingAssembly(), typeof(AssemblyConfigurationAttribute))).Configuration;
            }
        }

        /// <summary>
        /// The Company attribute specified in the AssemblyInfo
        /// </summary>
        public static string Company
        {
            get
            {
                return ((AssemblyCompanyAttribute)Attribute.GetCustomAttribute(Assembly.GetExecutingAssembly(), typeof(AssemblyCompanyAttribute))).Company;
            }
        }

        /// <summary>
        /// The Product attribute specified in the AssemblyInfo
        /// </summary>
        public static string Product
        {
            get
            {
                return ((AssemblyProductAttribute)Attribute.GetCustomAttribute(Assembly.GetExecutingAssembly(), typeof(AssemblyProductAttribute))).Product;
            }
        }

        /// <summary>
        /// The Copyright attribute specified in the AssemblyInfo
        /// </summary>
        public static string Copyright
        {
            get
            {
                return ((AssemblyCopyrightAttribute)Attribute.GetCustomAttribute(Assembly.GetExecutingAssembly(), typeof(AssemblyCopyrightAttribute))).Copyright;
            }
        }

        /// <summary>
        /// The Trademark attribute specified in the AssemblyInfo
        /// </summary>
        public static string Trademark
        {
            get
            {
                return ((AssemblyTrademarkAttribute)Attribute.GetCustomAttribute(Assembly.GetExecutingAssembly(), typeof(AssemblyTrademarkAttribute))).Trademark;
            }
        }

        /// <summary>
        /// The Culture attribute specified in the AssemblyInfo
        /// </summary>
        public static string Culture
        {
            get
            {
                return ((AssemblyCultureAttribute)Attribute.GetCustomAttribute(Assembly.GetExecutingAssembly(), typeof(AssemblyCultureAttribute))).Culture;
            }
        }

        /// <summary>
        /// The Version attribute specified in the AssemblyInfo
        /// </summary>
        public static string Version
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }
    }
}
