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
        #region Const

        private const string JSON_PACKAGE = "Package";

        private const string JSON_PACKAGE_FILE = "PackageFile";

        #endregion

        #region Private vars

        private string rootDir = string.Empty;
        private const string JSON_DB_FILE_NAME = "PkgDatabase.json";

        private List<Package> pkgCollection;
        private Dictionary<Package, List<PackageFile>> filesByPackage;

        #endregion

        #region Constructor

        public Project(string rootDir)
        {
            this.rootDir = rootDir;

            string jsonPath = Path.Combine(rootDir, JSON_DB_FILE_NAME);
            if(File.Exists(jsonPath))
            {
                File.Create(jsonPath);
            }


        }

        #endregion

        #region Public methods

        public void CreatePkg(string pkgName)
        {
            if (this.GetPackageByName(pkgName) != null)
            {
                throw new PackageException("Package \"" + pkgName + "\" already exists.");
            }

            this.pkgCollection.Add(new Package(pkgName, this.pkgCollection.Count()));
        }

        #endregion

        #region Private methods

        private Package GetPackageByName(string pkgName)
        {
            return this.pkgCollection.Find(pkg => pkg.Name == pkgName);
        }

        private void loadJson()
        {
            // Load packages
            //JsonConvert.DeserializeObject<Package>()

            // Load files by package

        }

        #endregion

    }
}
