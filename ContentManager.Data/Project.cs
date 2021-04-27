using Base;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContentManager.Data
{
    public class Project
    {

        #region Private vars

        private string projectRootDir = string.Empty;
        private const string JSON_DB_FILE_NAME = "PkgDatabase.json";

        private JsonFileHandler jFile;
        private string gameRootDir = string.Empty;

        #endregion

        #region Constructor

        public Project(string projectRootDir, string gameRootDir)
        {
            this.projectRootDir = projectRootDir;
            this.gameRootDir = gameRootDir;

            string jsonPath = Path.Combine(projectRootDir, JSON_DB_FILE_NAME);
            
            if(!File.Exists(jsonPath))
            {
                File.Create(jsonPath);
            }

            this.jFile = new JsonFileHandler(jsonPath);
        }

        #endregion

        #region Public properties

        // Directory where the BlackOps3.exe is
        public string GameRootDir
        {
            get => this.gameRootDir;
        }

        // Directory where the project json file is
        public string ProjectRootDir
        {
            get => this.projectRootDir;
        }

        // Root directory where the mod files are stored,
        // same dir and file structure as the gameroot
        public string ModSourceDir
        {
            get => Utility.AdvancedPathCombine(this.projectRootDir, "ModSource");
        }

        #endregion

        #region Public methods

        public void CreatePkg(string pkgName)
        {
            if (this.GetPackageByName(pkgName) != null)
            {
                throw new PackageException("Package \"" + pkgName + "\" already exists.");
            }

            this.jFile.Content.PackageCollection.Add(new Package(pkgName, this.jFile.Content.PackageCollection.Count()));
        }

        public void AddPkg(Package pkg)
        {
            this.jFile.Content.PackageCollection.Add(pkg);
        }

        public void RemovePkg(int pkgId)
        {
            this.jFile.Content.PackageCollection.RemoveAll(x => x.PkgId == pkgId);
        }

        public List<Package> GetPackages()
        {
            return this.jFile.Content.PackageCollection;
        }

        public void Save()
        {
            this.jFile.Save();
        }

        public void UpdateConflicts(List<FileConflict> c)
        {
            this.jFile.Content.FileConflictCollection = c;
        }

        #endregion

        #region Private methods

        private Package GetPackageByName(string pkgName)
        {
            return this.jFile.Content.PackageCollection.Find(pkg => pkg.Name == pkgName);
        }

        #endregion

    }
}
