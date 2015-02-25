using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using KS_Tar.Classes;

namespace KS_Tar.Forms
{
    

    public partial class ViewFreeMemoryForm : Form
    {
        public ViewFreeMemoryForm()
        {
            InitializeComponent();
            DGVFreeMemoryView.Columns.Add("driveName", "Drive");
            DGVFreeMemoryView.Columns.Add("driveFormat", "Drive format");
            DGVFreeMemoryView.Columns.Add("freeMemory", "Free memory");
            var drivesInfo=UpdateMemoryUsege();
            foreach (var shortDriveInfo in drivesInfo)
            {
                DGVFreeMemoryView.Rows.Add(shortDriveInfo.DriveName,shortDriveInfo.DriveFormat,shortDriveInfo.FreeMemory);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private static IEnumerable<ShortDriveInfo> UpdateMemoryUsege()
        {
            var drives=MemoryChecker.GetListOfDrives();
            var shortDriveInfos= drives.Select(drive => new ShortDriveInfo(drive.Name, drive.Format, drive.AvailableFreeSpace.ToString(CultureInfo.InvariantCulture))).ToList();
            return shortDriveInfos;
        }
    }

    class ShortDriveInfo
    {
        public string DriveName { get; set; }
        public string DriveFormat { get; set; }
        public string FreeMemory { get; set; }

        public ShortDriveInfo(string driveName, string driveFormat, string freeMemory)
        {
            DriveName = driveName;
            DriveFormat = driveFormat;
            FreeMemory = freeMemory;
        }
    }
}
