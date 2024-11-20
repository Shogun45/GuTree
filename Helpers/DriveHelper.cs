using GuTree.Utils;
using System.Collections.Generic;
using System;
using System.IO;

namespace GuTree.Helpers
{
    public static class DriveHelper
    {
        /// <summary>
        /// Generate list of computer drive as List<ComboboxItem>
        /// </summary>
        /// <returns>List<ComboboxItem></returns>
        public static List<ComboboxItem> GenerateDriverItems()
        {
            List<ComboboxItem> drives = new List<ComboboxItem>();

            try
            {
                DriveInfo[] allDrives = DriveInfo.GetDrives();

                foreach (DriveInfo drive in allDrives)
                {
                    if (drive.IsReady)
                    {
                        ComboboxItem item = new ComboboxItem(
                            Text: string.Format("[{0}] {1}", drive.Name, drive.VolumeLabel),
                            Value: drive
                        );

                        drives.Add(item);
                    }
                }
            }
            catch (Exception exception) 
            { }

            return drives;
        }
    }
}
