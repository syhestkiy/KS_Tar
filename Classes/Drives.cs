using System.IO;

namespace KS_Tar.Classes
{
   class Drive
    {
       public string Name { get; set; }
        public string Format { get; set; }
        public long AvailableFreeSpace { get; set; }
        public long TotalFreeSpace { get; set; }
        public long TotalSize { get; set; }

        public Drive(DriveInfo d)
        {
            Name = d.Name;
            Format = d.DriveFormat;
            AvailableFreeSpace = d.AvailableFreeSpace;
            TotalFreeSpace = d.TotalFreeSpace/(1024*1024*1024);
            TotalSize = d.TotalSize;
        }
    }
}
