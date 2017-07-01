using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ToolsManagerLib
{
    public class XPwnTools
    {
        public void DecryptFirmwareImage(string InputImagePath, string OutputImagePath, string DecryptionIV, string DecryptionKey)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "xpwntool.exe";
            startInfo.Arguments = InputImagePath + " " + OutputImagePath + " -iv " + DecryptionIV + " -k " + DecryptionKey + " -decrypt";
            Process.Start(startInfo);
        }
    }

    public class iDeviceRestore
    {
        public void EraseRestore(string PathIPSW)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "idevicerestore.exe";
            startInfo.Arguments = "-e " + PathIPSW;
            Process.Start(startInfo);
        }
    }

    public class DmgUtility
    {
        public void DecryptImage(string EncryptedInputDmgImagePath, string DecryptedOutputDmgImagePath, string DecryptionKey)
        {
            Process DecryptImage = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "dmg.exe";
            startInfo.Arguments = "extract" + " " + EncryptedInputDmgImagePath + " " + DecryptedOutputDmgImagePath + " -k " + DecryptionKey;
            DecryptImage = Process.Start(startInfo);
            DecryptImage.WaitForExit();
        }
    }
}
