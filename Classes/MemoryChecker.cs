using System.Collections.Generic;
using System.IO;

namespace KS_Tar.Classes
{
    internal class MemoryChecker
    {
        public static List<Drive> GetListOfDrives()
        {
            var drives = new List<Drive>();
            DriveInfo[] driveInfos = DriveInfo.GetDrives();
            for (int i = 0; i < driveInfos.Length - 1; i++)
            {
                drives.Add(new Drive(driveInfos[i]));
            }
            return drives;
        }

        public static string[] ListOfDriveNames(List<Drive> drives)
        {
            var listOfDriveNames = new string[drives.Count];
            for (int i = 0; i < drives.Count; i++)
            {
                listOfDriveNames[i] = drives[i].Name;
            }
            return listOfDriveNames;
        }

        public static long GetFreeSpace(DriveInfo drive)
        {
            long variable = long.MaxValue;
            return variable;
        }
    }
}