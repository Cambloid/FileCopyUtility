using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContentManager.Data
{

    public class JsonContent
    {

        public JsonContent()
        {
            this.PackageCollection = new List<Package>();
            this.FileConflictCollection = new List<FileConflict>();
        }

        [JsonProperty("Packages")]
        public List<Package> PackageCollection;

        [JsonProperty("Conflicts")]
        public List<FileConflict> FileConflictCollection;

    }

    public class JsonFileHandler
    {
        #region Private vars

        private string jsonFilePath = string.Empty;

        #endregion

        #region Constructor

        public JsonFileHandler() {
            this.Content = new JsonContent();
        }

        public JsonFileHandler(string jsonFilePath)
        {
            this.Content = new JsonContent();

            this.jsonFilePath = jsonFilePath;
            this.loadJson();
        }

        #endregion

        #region Public methods

        public void Save()
        {
            this.saveJson();
        }

        #endregion

        #region Public properties

        public JsonContent Content {
            get;
            set;
        }

        #endregion

        #region Private methods

        private void loadJson()
        {
            try
            {
                string jsonContent = File.ReadAllText(this.jsonFilePath);
                // Load packages
                var header = JsonConvert.DeserializeObject<JsonContent>(jsonContent);
                if(header != null)
                {
                    this.Content = header;
                }

            } catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void saveJson()
        {
            try
            {
                if (this.Content == null)
                {
                    return;
                }
                string jsonContent = JsonConvert.SerializeObject(this.Content, Formatting.Indented);
                File.WriteAllText(this.jsonFilePath, jsonContent);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        #endregion
    }
}
