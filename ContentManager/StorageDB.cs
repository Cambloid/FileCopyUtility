using ContentManager.Data;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ContentManager
{

    public class StorageDB
    {

        #region Private vars

        private static StorageDB instance;

        private FileInfo projectFilePath;

        private struct StorageJsonData {

            List<Package> packages;

        }
        StorageJsonData jsonData;

        #endregion

        #region Constructor

        private StorageDB() { }

        #endregion

        #region Static Methods

        public static StorageDB GetInstance(FileInfo projectFilePath)
        {

            if(!projectFilePath.Exists)
            {
                throw new FileNotFoundException("The file '" + projectFilePath + "' "  + "has not been found.");
            }

            if(StorageDB.instance == null)
            {
                StorageDB.instance = new StorageDB();
            }

            if(!StorageDB.instance.projectFilePath.Equals(projectFilePath))
            {
                StorageDB.instance.projectFilePath = projectFilePath;
                StorageDB.instance.updateStorage();
            }

            return StorageDB.instance;
        }

        #endregion

        #region Private Methods

        private void updateStorage()
        {
            // https://www.newtonsoft.com/json/help/html/SerializeWithJsonConverters.htm
            try
            {
                //List<Package> movie1 =
                //JsonConvert.DeserializeObject<List<Package>>(
                //    File.ReadAllText(this.projectFilePath)
                //    );
            } catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private StorageJsonData GetData()
        {
            return this.jsonData;
        }

        #endregion



    }

}
