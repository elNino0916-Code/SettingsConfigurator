using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace SettingsConfigurator
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var client = new WebClient())
            {
                client.DownloadFile("https://github.com/elNino0916/ShutdownUI/releases/download/v.0.1.0/ShutdownUI.exe", "Extension-ShutdownUI.exe");
            }
            string strCmdText;
            strCmdText = "/C @echo off && title Launcher && echo Extension started && start Extension-ShutdownUI.exe && exit";
            System.Diagnostics.Process.Start("CMD.exe", strCmdText);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
