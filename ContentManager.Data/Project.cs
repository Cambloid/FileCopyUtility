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

        private string rootDir = string.Empty;
        private const string JSON_DB_FILE_NAME = "PkgDatabase.json";

        private JsonFile jFile;

        #endregion

        #region Constructor

        public Project(string rootDir)
        {
            this.rootDir = rootDir;
            string jsonPath = Path.Combine(rootDir, JSON_DB_FILE_NAME);
            
            if(!File.Exists(jsonPath))
            {
                File.Create(jsonPath);
            }

            this.jFile = new JsonFile(jsonPath);
        }

        #endregion

        #region Public methods

        public void CreatePkg(string pkgName)
        {
            if (this.GetPackageByName(pkgName) != null)
            {
                throw new PackageException("Package \"" + pkgName + "\" already exists.");
            }

            this.jFile.Header.PackageCollection.Add(new Package(pkgName, this.jFile.Header.PackageCollection.Count()));
        }

        public void AddPkg(Package pkg)
        {
            this.jFile.Header.PackageCollection.Add(pkg);
        }

        public void RemovePkg(int pkgId)
        {
            this.jFile.Header.PackageCollection.RemoveAll(x => x.PkgId == pkgId);
        }

        public List<Package> GetPackages()
        {
            return this.jFile.Header.PackageCollection;
        }

        public void Save()
        {
            this.jFile.Save();
        }

        #endregion

        #region Private methods

        private Package GetPackageByName(string pkgName)
        {
            return this.jFile.Header.PackageCollection.Find(pkg => pkg.Name == pkgName);
        }

        #endregion

    }
}
