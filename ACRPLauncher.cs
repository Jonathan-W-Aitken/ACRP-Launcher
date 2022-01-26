using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace ACRP_Launcher
{
    public partial class ACRPLauncher : Form
    {
        public ACRPLauncher()
        {
            InitializeComponent();
        }

        private void ACRPLogo_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", "fivem://connect/9okxre");
        }
    }
}
