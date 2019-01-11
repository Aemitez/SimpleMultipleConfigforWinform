using System;
using System.Configuration;
using System.Windows.Forms;
using SimpleMultipleConfigforWinform.Properties;

namespace SimpleMultipleConfigforWinform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label2.Text = Settings.Default.Setting;
            label4.Text = ConfigurationManager.AppSettings["appSettings"];
            if (!string.IsNullOrEmpty(ConfigurationManager.AppSettings["Productionvalue"]))
            {
                label5.Visible = true;
                label6.Visible = true;
                label6.Text = ConfigurationManager.AppSettings["Productionvalue"];
            }
                
        }
    }
}