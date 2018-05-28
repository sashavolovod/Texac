using System;
using System.Drawing;
using System.Windows.Forms;
using System.Configuration;

namespace Texac
{
    public class MyForm : System.Windows.Forms.Form, IPersistComponentSettings
    {
        private bool _save = true;
        private MySettings _settings;
        public MyForm()
        {
            _settings = new MySettings(Name);
        }

        #region IPersistComponentSettings Members 
        public void LoadComponentSettings()
        {
            ResumeLayout(false);
            _settings.SettingsKey = this.Name;
            _settings.Reload();
            this.WindowState = _settings.WindowsState;

            if (_settings.FormSize.Height != 0 || _settings.FormSize.Width != 0)
            {
                this.Size = _settings.FormSize;
            }

            if (_settings.FormLocation.X != -1)
            {
                this.Location = _settings.FormLocation;
            }
        }

        public void ResetComponentSettings()
        {
            _settings.Reset();
        }

        public void SaveComponentSettings()
        {
            _settings.SettingsKey = this.Name;
            _settings.WindowsState = this.WindowState;

            if (this.WindowState == FormWindowState.Normal)
            {
                _settings.FormSize = this.Size;
                _settings.FormLocation = this.Location;
            }
            else
            {
                _settings.FormSize = this.RestoreBounds.Size;
                _settings.FormLocation = this.RestoreBounds.Location;
            }

            _settings.Save();
        }


        public bool SaveSettings
        {
            get { return _save; }
            set { _save = value; }
        }
        public string SettingsKey
        {
            get { return Name; }
            set { _settings.SettingsKey = value; }
        }
        #endregion

        protected override void Dispose(bool disposing)
        {
            //if (disposing && SaveSettings)
            //{
            //    SaveComponentSettings();
            //}
            base.Dispose(disposing);
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            if (SaveSettings)
            {
                SaveComponentSettings();
            }
            base.OnFormClosed(e);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            LoadComponentSettings();
        }

        //protected override void OnCreateControl()
        //{
        //    LoadComponentSettings();
        //    base.OnCreateControl();
        //}

        sealed class MySettings : ApplicationSettingsBase
        {
            public MySettings(string settingsKey) : base(settingsKey) { }

            [UserScopedSetting()]
            [DefaultSettingValueAttribute("-1, -1")]
            public Point FormLocation
            {
                get { return (Point)(this["FormLocation"]); }
                set { this["FormLocation"] = value; }
            }
            [UserScopedSetting()]
            [DefaultSettingValueAttribute("0, 0")]
            public Size FormSize
            {
                get { return (Size)this["FormSize"]; }
                set { this["FormSize"] = value; }
            }

            [UserScopedSetting()]
            [DefaultSettingValueAttribute("Normal")]
            public FormWindowState WindowsState
            {
                get { return (FormWindowState)this["WindowsState"]; }
                set { this["WindowsState"] = value; }
            }
        }
    }

}
