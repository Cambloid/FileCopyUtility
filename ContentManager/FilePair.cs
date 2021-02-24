using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContentManager
{
    public class FilePair
    {

        #region Private vars

        private string baseRelativePath;

        private FileInfo gamerootFile;
        private FileInfo repoFile;

        FileCoherentStatus status = FileCoherentStatus.None;

        #endregion

        #region Enum

        public enum FileCoherentStatus
        {
            None,

            GameRootIsNewer,
            GameRootIsMissing,

            RepositoryIsNewer,
            RepositoryIsMissing,

            GameRootAndRepoIsMissing,

            FilesAreEven
        }

        #endregion

        #region Constructor

        public FilePair(string baseRelativePath)
        {
            this.baseRelativePath = baseRelativePath;

            // Check if file is from gameroot or repository

            string gamerootDirectory = Properties.Settings.Default.GameRoot;
            string modSourceDir = Path.Combine(Properties.Settings.Default.ProjectRoot, "ModSource");

            this.gamerootFile = new FileInfo(FilePair.AdvancedPathCombine(gamerootDirectory, this.baseRelativePath));
            this.repoFile = new FileInfo(FilePair.AdvancedPathCombine(modSourceDir, this.baseRelativePath));

            this.updateFileCoherentStatus();
        }

        #endregion

        #region Public static methods

        public static string GetBaseRelativePath(string fullFilePath)
        {
            string baseRelPath = string.Empty;

            // Check if file is from gameroot or repo
            string gamerootPath = Properties.Settings.Default.GameRoot;
            string repoPath = Path.Combine(Properties.Settings.Default.ProjectRoot, "ModSource");

            if(fullFilePath.Contains(gamerootPath))
            {

                baseRelPath = fullFilePath.Substring(gamerootPath.Length, fullFilePath.Length - gamerootPath.Length);
            } else if (fullFilePath.Contains(repoPath))
            {
                baseRelPath = fullFilePath.Substring(repoPath.Length, fullFilePath.Length - repoPath.Length);
            }

            return baseRelPath;
        }

        public static string AdvancedPathCombine(string path1, string path2)
        {

            if(path1 ==string.Empty)
            {
                return path2;
            }

            // Ensure neither end of path1 or beginning of path2 have slashes
            path1 = path1.Trim().TrimEnd(System.IO.Path.DirectorySeparatorChar);
            path2 = path2.Trim().TrimStart(System.IO.Path.DirectorySeparatorChar);

            // Handle drive letters
            if (path1.Substring(path1.Length - 1, 1) == ":")
            {
                path1 += System.IO.Path.DirectorySeparatorChar;
            }

            return System.IO.Path.Combine(path1, path2);
        }

        #endregion

        #region Public methods

        public FileCoherentStatus GetFilePairStatus()
        {
            return this.status;
        }

        public FileInfo GetGameRootFileInfo()
        {
            return this.gamerootFile;
        }

        public FileInfo GetRepositoryFileInfo()
        {
            return this.repoFile;
        }

        public string GetBaseRelativePath()
        {
            return this.baseRelativePath;
        }

        #endregion

        #region Private methods

        private bool isFileEqual(FileInfo repoFile, FileInfo gamerootFile)
        {
            try
            {
                return repoFile.Length == gamerootFile.Length && (repoFile.Length == 0 || File.ReadAllBytes(repoFile.FullName).SequenceEqual(File.ReadAllBytes(gamerootFile.FullName)));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return false;
        }

        private bool isGameRootFileNewer(FileInfo repoFile, FileInfo gamerootFile)
        {
            return repoFile.LastWriteTime < gamerootFile.LastWriteTime;
        }

        private bool isRepoFileNewer(FileInfo repoFile, FileInfo gamerootFile)
        {
            return repoFile.LastWriteTime > gamerootFile.LastWriteTime;
        }

        private void updateFileCoherentStatus()
        {
            FileCoherentStatus status = FileCoherentStatus.None;

            if (!this.repoFile.Exists && !this.gamerootFile.Exists)
            {
                status = FileCoherentStatus.GameRootAndRepoIsMissing;
            }
            else if (!this.gamerootFile.Exists)
            {
                status = FileCoherentStatus.GameRootIsMissing;
            }
            else if (!this.repoFile.Exists)
            {
                status = FileCoherentStatus.RepositoryIsMissing;
            }
            else if (this.isGameRootFileNewer(this.repoFile, this.gamerootFile))
            {
                status = FileCoherentStatus.GameRootIsNewer;
            }
            else if (this.isRepoFileNewer(this.repoFile, this.gamerootFile))
            {
                status = FileCoherentStatus.RepositoryIsNewer;
            }
            else if (this.isFileEqual(this.repoFile, this.gamerootFile))
            {
                status = FileCoherentStatus.FilesAreEven;
            }

            this.status = status;
        }
        
        #endregion

    }
}
