using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToolsManagerUI
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnRunXPwnTools_Click(object sender, EventArgs e)
        {
            ToolsManagerLib.XPwnTools XPwnToolsInstance;
            XPwnToolsInstance = new ToolsManagerLib.XPwnTools();
            XPwnToolsInstance.DecryptFirmwareImage("iBoot.n81ap.RELEASE.img3", "iBoot.n81ap.RELEASE_dec.img3", "16641c07fe97051c445d21258722f3d1", "d302a0ba7253453bce4431dd5a2a04fbf4da9868c340eae633a0202fe0995155");

        }

        private void btnRestoreDevice_Click(object sender, EventArgs e)
        {
            ToolsManagerLib.iDeviceRestore iDeviceRestoreInstance;
            iDeviceRestoreInstance = new ToolsManagerLib.iDeviceRestore();
            iDeviceRestoreInstance.EraseRestore("iPod4,1_5.1_9B176_Restore.ipsw");
        }
    }
}
