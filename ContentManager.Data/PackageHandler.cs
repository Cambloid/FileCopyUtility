using Base;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContentManager.Data
{
    // Logic for package operations
    // - Check status (installed/not installed)
    // - Check conflicting files with the gameroot
    
    public class PackageHandler
    {

        #region Private vars

        private Project project;

        private List<FileConflict> fileConflicts = new List<FileConflict>();

        private bool statusChecked = false;

        #endregion

        #region Constructor

        public PackageHandler(Project p)
        {
            this.project = p;
        }

        #endregion

        #region Public properties

        public bool Installable
        {
            get => !this.fileConflicts.Any() && this.statusChecked;
        }

        public List<FileConflict> Conflicts
        {
            get => this.fileConflicts;
        }

        #endregion

        #region Public methods

        // Check if package is already installed and check for conflicts
        public void CheckStatusAndUpdate(Package p)
        {
            this.fileConflicts.Clear();
            bool statusInstalled = true;

            //ConflictSearcher searcher = new ConflictSearcher(this.project);
            //this.fileConflicts = searcher.FindConflictsPkgGameroot(p);

            // Check if all files are the same
            foreach (var file in p.FileCollection)
            {

                if (file.DoNotCopy)
                    continue;

                string fileGameRootPath = Utility.AdvancedPathCombine(this.project.GameRootDir, file.RelPath);
                string storagePath      = Utility.AdvancedPathCombine(p.Path, file.RelPath);

                if(!File.Exists(fileGameRootPath) || !Utility.AreFilesEqual(storagePath, fileGameRootPath))
                {
                    statusInstalled = false;
                }
            }

            if (statusInstalled)
                p.Status = Package.PackageStatus.Installed;
            else
                p.Status = Package.PackageStatus.Not_Installed;

            this.statusChecked = true;
        }


        // Install a package if there are no conflicts
        public bool Install(Package p)
        {
            // TODO: Make this paralell

            // No conflicts, and all files can be copied and evtl. override destination file
            if (this.Installable && p.Status == Package.PackageStatus.Not_Installed)
            {
                // Copy files over
                try
                {
                    p.FileCollection.ForEach(x =>
                    {

                        if(x.DoNotCopy)
                        {
                            return;
                        }

                        string sourceFile = Utility.AdvancedPathCombine(p.Path, x.RelPath);
                        string destinationFile = Utility.AdvancedPathCombine(this.project.GameRootDir, x.RelPath);
                        

                        // TODO create a FileCopyHandler to create backups and roll back in case something failes
                        File.Copy(sourceFile, destinationFile, true);

                    });
                    return true; // install successful
                }
                catch (Exception ex)
                {
                    Console.Write(ex.ToString());
                }

                return false;// install failed
            }
            else return false; // package not installable
        }

        // Remove a package if there are no conflicts
        // But there are following questions
        // - What if a file belongs to the mod tools installation? remove anyway?
        // - What if a file belongs to a different package? -> check hash
        public void Remove(Package p)
        {
            
        }

        #endregion

    }
}
