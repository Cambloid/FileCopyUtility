using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileCopyUtility
{
    public class FileBackup
    {
        #region Enum

        public enum BackupLocation
        {
            None,
            GameRoot,
            Repository
        }

        #endregion

        #region Const

        private const string DEFAULT_BACKUP_ROOT_DIRECTORY_REPOSITORY = "Backup\\Repository";
        private const string DEFAULT_BACKUP_ROOT_DIRECTORY_GAMEROOT   = "Backup\\GameRoot";

        #endregion

        #region Private vars

        private BackupLocation location;

        #endregion

        #region Constructor

        public FileBackup(BackupLocation location)
        {
            this.location = location;
        }

        #endregion

        #region Public methods

        public void DoBackup(FilePair file)
        {
            this.DoBackup(new List<FilePair> { file });
        }

        public void DoBackup(List<FilePair> filesBackup)
        {
            string dateTimeStr = DateTime.Now.Day + "." + DateTime.Now.Month + "." + DateTime.Now.Year + "_" + DateTime.Now.Hour + "." + DateTime.Now.Minute + "." + DateTime.Now.Second;

            foreach (FilePair file in filesBackup)
            {
                try
                {

                    string relativePath = file.GetBaseRelativePath();
                    string fileToBackup = string.Empty;
                    string backupPath = string.Empty;
                    string newFileNameStr = string.Empty;


                    if (this.location == BackupLocation.GameRoot)
                    {
                        backupPath = FilePair.AdvancedPathCombine(Properties.Settings.Default.PathBackupDir, FilePair.AdvancedPathCombine(DEFAULT_BACKUP_ROOT_DIRECTORY_GAMEROOT, relativePath));
                        newFileNameStr = file.GetGameRootFileInfo().Name + "_" + dateTimeStr + file.GetGameRootFileInfo().Extension;
                        fileToBackup = file.GetGameRootFileInfo().FullName;

                    } else if (this.location == BackupLocation.Repository)
                    {
                        backupPath = FilePair.AdvancedPathCombine(Properties.Settings.Default.PathBackupDir, FilePair.AdvancedPathCombine(DEFAULT_BACKUP_ROOT_DIRECTORY_REPOSITORY, relativePath));
                        newFileNameStr = file.GetRepositoryFileInfo().Name + "_" + dateTimeStr + file.GetRepositoryFileInfo().Extension;
                        fileToBackup = file.GetRepositoryFileInfo().FullName;
                    }

                    string backupDirectoryPath = Path.GetDirectoryName(backupPath);

                    if (!Directory.Exists(backupDirectoryPath))
                    {
                        Directory.CreateDirectory(backupDirectoryPath);
                    }

                    // Check if the file to backup exists
                    if(!File.Exists(fileToBackup) )
                    {
                        return;
                    }

                    // Create backup
                    File.Copy(
                        fileToBackup,
                        FilePair.AdvancedPathCombine(backupDirectoryPath, newFileNameStr), 
                        false
                    );

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }


            }
        }

        #endregion
    }
}
