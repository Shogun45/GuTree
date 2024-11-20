using System.Windows.Forms;
using System.Drawing;

namespace GuTree
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            quitToolStripMenuItem = new ToolStripMenuItem();
            optionsToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            pnlDiskScan = new Panel();
            btnScanDisk = new Button();
            cbbDisk = new ComboBox();
            lblDisk = new Label();
            treeView = new TreeView();
            pnlDiskInfo = new Panel();
            lblSpaceFree = new Label();
            lblSpaceUsed = new Label();
            lblTotalSpace = new Label();
            lblSelection = new Label();
            lblSpaceFreeInfo = new Label();
            lblSpaceUsedInfo = new Label();
            lblTotalSpaceInfo = new Label();
            lblSelectionInfo = new Label();
            lblScanInfo = new Label();
            menuStrip1.SuspendLayout();
            pnlDiskScan.SuspendLayout();
            pnlDiskInfo.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, optionsToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { quitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // quitToolStripMenuItem
            // 
            quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            quitToolStripMenuItem.Size = new Size(97, 22);
            quitToolStripMenuItem.Text = "Quit";
            // 
            // optionsToolStripMenuItem
            // 
            optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            optionsToolStripMenuItem.Size = new Size(61, 20);
            optionsToolStripMenuItem.Text = "Options";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            // 
            // pnlDiskScan
            // 
            pnlDiskScan.AutoScroll = true;
            pnlDiskScan.BorderStyle = BorderStyle.FixedSingle;
            pnlDiskScan.Controls.Add(lblScanInfo);
            pnlDiskScan.Controls.Add(btnScanDisk);
            pnlDiskScan.Controls.Add(cbbDisk);
            pnlDiskScan.Controls.Add(lblDisk);
            pnlDiskScan.Location = new Point(12, 27);
            pnlDiskScan.Name = "pnlDiskScan";
            pnlDiskScan.Size = new Size(370, 85);
            pnlDiskScan.TabIndex = 2;
            // 
            // btnScanDisk
            // 
            btnScanDisk.Location = new Point(291, 2);
            btnScanDisk.Name = "btnScanDisk";
            btnScanDisk.Size = new Size(75, 23);
            btnScanDisk.TabIndex = 2;
            btnScanDisk.Text = "Scan";
            btnScanDisk.UseVisualStyleBackColor = true;
            btnScanDisk.Click += btnScanDiskClick;
            // 
            // cbbDisk
            // 
            cbbDisk.FormattingEnabled = true;
            cbbDisk.Location = new Point(143, 2);
            cbbDisk.Name = "cbbDisk";
            cbbDisk.Size = new Size(144, 23);
            cbbDisk.TabIndex = 1;
            // 
            // lblDisk
            // 
            lblDisk.AutoSize = true;
            lblDisk.Location = new Point(3, 5);
            lblDisk.Name = "lblDisk";
            lblDisk.Size = new Size(44, 15);
            lblDisk.TabIndex = 0;
            lblDisk.Text = "Select :";
            // 
            // treeView
            // 
            treeView.Location = new Point(12, 136);
            treeView.Name = "treeView";
            treeView.Size = new Size(776, 302);
            treeView.TabIndex = 3;
            // 
            // pnlDiskInfo
            // 
            pnlDiskInfo.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            pnlDiskInfo.BorderStyle = BorderStyle.FixedSingle;
            pnlDiskInfo.Controls.Add(lblSpaceFreeInfo);
            pnlDiskInfo.Controls.Add(lblSpaceUsedInfo);
            pnlDiskInfo.Controls.Add(lblTotalSpaceInfo);
            pnlDiskInfo.Controls.Add(lblSelectionInfo);
            pnlDiskInfo.Controls.Add(lblSpaceFree);
            pnlDiskInfo.Controls.Add(lblSpaceUsed);
            pnlDiskInfo.Controls.Add(lblTotalSpace);
            pnlDiskInfo.Controls.Add(lblSelection);
            pnlDiskInfo.Location = new Point(388, 27);
            pnlDiskInfo.Name = "pnlDiskInfo";
            pnlDiskInfo.Size = new Size(400, 85);
            pnlDiskInfo.TabIndex = 4;
            // 
            // lblSpaceFree
            // 
            lblSpaceFree.AutoSize = true;
            lblSpaceFree.Location = new Point(3, 65);
            lblSpaceFree.Name = "lblSpaceFree";
            lblSpaceFree.Size = new Size(69, 15);
            lblSpaceFree.TabIndex = 3;
            lblSpaceFree.Text = "Space Free :";
            // 
            // lblSpaceUsed
            // 
            lblSpaceUsed.AutoSize = true;
            lblSpaceUsed.Location = new Point(3, 45);
            lblSpaceUsed.Name = "lblSpaceUsed";
            lblSpaceUsed.Size = new Size(73, 15);
            lblSpaceUsed.TabIndex = 2;
            lblSpaceUsed.Text = "Space Used :";
            // 
            // lblTotalSpace
            // 
            lblTotalSpace.AutoSize = true;
            lblTotalSpace.Location = new Point(3, 25);
            lblTotalSpace.Name = "lblTotalSpace";
            lblTotalSpace.Size = new Size(72, 15);
            lblTotalSpace.TabIndex = 1;
            lblTotalSpace.Text = "Total Space :";
            // 
            // lblSelection
            // 
            lblSelection.AutoSize = true;
            lblSelection.Location = new Point(3, 5);
            lblSelection.Name = "lblSelection";
            lblSelection.Size = new Size(61, 15);
            lblSelection.TabIndex = 0;
            lblSelection.Text = "Selection :";
            // 
            // lblSpaceFreeInfo
            // 
            lblSpaceFreeInfo.AutoSize = true;
            lblSpaceFreeInfo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSpaceFreeInfo.Location = new Point(163, 65);
            lblSpaceFreeInfo.Name = "lblSpaceFreeInfo";
            lblSpaceFreeInfo.Size = new Size(25, 15);
            lblSpaceFreeInfo.TabIndex = 7;
            lblSpaceFreeInfo.Text = "n/a";
            // 
            // lblSpaceUsedInfo
            // 
            lblSpaceUsedInfo.AutoSize = true;
            lblSpaceUsedInfo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSpaceUsedInfo.Location = new Point(163, 45);
            lblSpaceUsedInfo.Name = "lblSpaceUsedInfo";
            lblSpaceUsedInfo.Size = new Size(25, 15);
            lblSpaceUsedInfo.TabIndex = 6;
            lblSpaceUsedInfo.Text = "n/a";
            // 
            // lblTotalSpaceInfo
            // 
            lblTotalSpaceInfo.AutoSize = true;
            lblTotalSpaceInfo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTotalSpaceInfo.Location = new Point(163, 25);
            lblTotalSpaceInfo.Name = "lblTotalSpaceInfo";
            lblTotalSpaceInfo.Size = new Size(25, 15);
            lblTotalSpaceInfo.TabIndex = 5;
            lblTotalSpaceInfo.Text = "n/a";
            // 
            // lblSelectionInfo
            // 
            lblSelectionInfo.AutoSize = true;
            lblSelectionInfo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSelectionInfo.Location = new Point(163, 5);
            lblSelectionInfo.Name = "lblSelectionInfo";
            lblSelectionInfo.Size = new Size(25, 15);
            lblSelectionInfo.TabIndex = 4;
            lblSelectionInfo.Text = "n/a";
            // 
            // lblScanInfo
            // 
            lblScanInfo.AutoSize = true;
            lblScanInfo.Location = new Point(3, 45);
            lblScanInfo.Name = "lblScanInfo";
            lblScanInfo.Size = new Size(0, 15);
            lblScanInfo.TabIndex = 3;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlDiskInfo);
            Controls.Add(treeView);
            Controls.Add(pnlDiskScan);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "Form1";
            Load += MainFormLoad;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            pnlDiskScan.ResumeLayout(false);
            pnlDiskScan.PerformLayout();
            pnlDiskInfo.ResumeLayout(false);
            pnlDiskInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem optionsToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem quitToolStripMenuItem;
        private Panel pnlDiskScan;
        private ComboBox cbbDisk;
        private Label lblDisk;
        private Button btnScanDisk;
        private TreeView treeView;
        private Panel pnlDiskInfo;
        private Label lblSelection;
        private Label lblSpaceFree;
        private Label lblSpaceUsed;
        private Label lblTotalSpace;
        private Label lblSpaceFreeInfo;
        private Label lblSpaceUsedInfo;
        private Label lblTotalSpaceInfo;
        private Label lblSelectionInfo;
        private Label lblScanInfo;
    }
}
