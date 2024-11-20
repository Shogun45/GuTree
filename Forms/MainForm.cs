using GuTree.Utils;
using GuTree.Helpers;
using System.Diagnostics;
using System.Windows.Forms;
using System;
using System.IO;

namespace GuTree
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainFormLoad(object sender, EventArgs e)
        {
            this.cbbDisk.DataSource = DriveHelper.GenerateDriverItems();
            this.cbbDisk.DisplayMember = "Text";
        }

        private void btnScanDiskClick(object sender, EventArgs e)
        {
            if (this.cbbDisk.SelectedItem is ComboboxItem selected && selected.Value is DriveInfo driveInfo)
            {
                completeInformation(driveInfo.Name, driveInfo.TotalSize, driveInfo.TotalSize - driveInfo.TotalFreeSpace, driveInfo.TotalFreeSpace);

                int fileCount, directoryCount;

                Stopwatch watch = new Stopwatch();
                //
                // TEST Parallel
                //
                watch.Start();
                this.treeView.Nodes.Clear();
                this.treeView.Nodes.Add(DirectoryHelper.ScanDirectoryParallel(driveInfo.Name, out directoryCount, out fileCount));
                watch.Stop();

                this.lblScanInfo.Text = $"Scan complete in {watch.Elapsed.Seconds},{watch.Elapsed.Milliseconds / 10} seconds";

                MessageBox.Show($"Nombre de dossier {directoryCount}, Nombre de fichier : {fileCount}, Time : {watch.ElapsedMilliseconds}");
            }
        }

        private void completeInformation(string selection, long totalSpace, long spaceUsed, long spaceFree)
        {
            this.lblSelectionInfo.Text = selection;
            this.lblTotalSpaceInfo.Text = totalSpace.ToString();
            this.lblSpaceUsedInfo.Text = spaceUsed.ToString();
            this.lblSpaceFreeInfo.Text = spaceFree.ToString();
        }
    }
}
