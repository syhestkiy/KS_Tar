using System;
using System.IO;

namespace KS_Tar.Classes
{
   class Drive
    {
       public string Name { get; set; }
        public string Format { get; set; }
        public double AvailableFreeSpace { get; set; }
        public double TotalFreeSpace { get; set; }
        public long TotalSize { get; set; }

        public Drive(DriveInfo d)
        {
            Name = d.Name;
            Format = d.DriveFormat;
            AvailableFreeSpace = Math.Round((double)d.AvailableFreeSpace / (1024 * 1024 * 1024),1);
            TotalFreeSpace = Math.Round((double)d.TotalFreeSpace/(1024*1024*1024),1);
            TotalSize = d.TotalSize;
        }
    }
}
