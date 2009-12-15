using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Win32;

namespace PocketNotepad
{
    public class Settings
    {
        RegistryKey settingsKey;
        public Settings()
        {
            this.settingsKey = Registry.CurrentUser.CreateSubKey("Software\\thebrent\\PocketNotepad");
        }

        public string FileTypes
        {
            get
            {
                return (string)this.settingsKey.GetValue("FileTypes","Text files|*.txt|All files|*.*");
            }
            set
            {
                this.settingsKey.SetValue("FileTypes", value,RegistryValueKind.String);
            }
        }

        public int TabWidth
        {
            get
            {
                return (int)this.settingsKey.GetValue("TabWidth",32);
            }
            set
            {
                this.settingsKey.SetValue("TabWidth", value,RegistryValueKind.DWord);
            }
        }

        public bool WordWrap
        {
            get
            {
                return Convert.ToBoolean(this.settingsKey.GetValue("WordWrap", 1));
            }
            set
            {
                this.settingsKey.SetValue("WordWrap", Convert.ToInt16(value),RegistryValueKind.DWord);
            }
        }
    }

}
