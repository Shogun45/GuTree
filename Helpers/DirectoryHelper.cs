using System.Collections.Concurrent;
using System.Windows.Forms;
using System;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace GuTree.Helpers
{
    public static class DirectoryHelper
    {
        /// <summary>
        /// Scans the given directory and its subdirectories in parallel using all available CPU cores. 
        /// The method constructs a hierarchical <see cref="TreeNode"/> representation of the directory structure 
        /// and provides the total count of directories and files.
        /// </summary>
        /// <param name="directory">
        /// The full path of the directory to scan. Must be a valid directory path.
        /// </param>
        /// <param name="directoryCount">
        /// Outputs the total number of directories found, including subdirectories.
        /// </param>
        /// <param name="fileCount">
        /// Outputs the total number of files found.
        /// </param>
        /// <returns>
        /// A <see cref="TreeNode"/> representing the hierarchical structure of the scanned directory and its contents.
        /// </returns>
        /// <exception cref="UnauthorizedAccessException">
        /// Thrown if the method encounters a directory or file it does not have permission to access.
        /// </exception>
        /// <exception cref="IOException">
        /// Thrown if an I/O error occurs during directory enumeration.
        /// </exception>
        public static TreeNode ScanDirectoryParallel(string directory, out int directoryCount, out int fileCount)
        {
            // Check if the path is root & create the node
            string nodeName = directory == Path.GetPathRoot(directory) ? directory : Path.GetFileName(directory);
            TreeNode node = new TreeNode(nodeName);

            int localDirCount = 0;
            int localFileCount = 0;

            try
            {   
                IEnumerable<string> entries = Directory.EnumerateFileSystemEntries(directory);

                ConcurrentBag<int> dirCountThreadSafe = new ConcurrentBag<int>();
                ConcurrentBag<int> fileCountThreadSafe = new ConcurrentBag<int>();
                ConcurrentBag<TreeNode> treeNodesThreadSafe = new ConcurrentBag<TreeNode>();

                Parallel.ForEach(entries, entry => 
                {
                    if (Directory.Exists(entry)) 
                    {
                        TreeNode subNode = ScanDirectoryParallel(entry, out int subDirCount, out int subFileCount);

                        dirCountThreadSafe.Add(subDirCount + 1);
                        fileCountThreadSafe.Add(subFileCount);

                        treeNodesThreadSafe.Add(subNode);
                    }
                    else if (File.Exists(entry)) 
                    {
                        treeNodesThreadSafe.Add(new TreeNode(Path.GetFileName(entry)));
                        fileCountThreadSafe.Add(1);
                    }
                });

                foreach (TreeNode nodeThreadSafe in treeNodesThreadSafe)
                    node.Nodes.Add(nodeThreadSafe);

                localDirCount = dirCountThreadSafe.Sum();
                localFileCount = fileCountThreadSafe.Sum();
            }
            catch (UnauthorizedAccessException exception) 
            { }
            catch (Exception exception)
            { }

            directoryCount = localDirCount;
            fileCount = localFileCount;

            return node;
        }

        /// <summary>
        /// Scans the given directory and its subdirectories sequentially. 
        /// The method constructs a hierarchical <see cref="TreeNode"/> representation of the directory structure 
        /// and provides the total count of directories and files.
        /// </summary>
        /// <param name="directory">
        /// The full path of the directory to scan. Must be a valid directory path.
        /// </param>
        /// <param name="directoryCount">
        /// Outputs the total number of directories found, including subdirectories.
        /// </param>
        /// <param name="fileCount">
        /// Outputs the total number of files found.
        /// </param>
        /// <returns>
        /// A <see cref="TreeNode"/> representing the hierarchical structure of the scanned directory and its contents.
        /// </returns>
        /// <exception cref="UnauthorizedAccessException">
        /// Thrown if the method encounters a directory or file it does not have permission to access.
        /// </exception>
        /// <exception cref="IOException">
        /// Thrown if an I/O error occurs during directory enumeration.
        /// </exception>
        public static TreeNode ScanDirectorySequential(string directory, out int directoryCount, out int fileCount) 
        {
            // Check if the path is root & create the node
            string nodeName = directory == Path.GetPathRoot(directory) ? directory : Path.GetFileName(directory);
            TreeNode node = new TreeNode(nodeName);

            directoryCount = 0;
            fileCount = 0;

            try
            {   
                IEnumerable<string> entries = Directory.EnumerateFileSystemEntries(directory);

                foreach (string entry in entries) 
                {
                    if (Directory.Exists(entry)) 
                    {
                        node.Nodes.Add(ScanDirectorySequential(entry, out int subDirCount, out int subFileCount));

                        directoryCount += subDirCount + 1;
                        fileCount += subFileCount;
                    }
                    else if (File.Exists(entry)) 
                    {
                        node.Nodes.Add(new TreeNode(Path.GetFileName(entry)));
                        fileCount++;
                    }
                }
            }
            catch (UnauthorizedAccessException exception) 
            { }
            catch (Exception exception)
            { }

            return node;
        }
    }
}
