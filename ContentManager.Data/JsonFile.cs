using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContentManager.Data
{
    
    public class JsonHeader
    {
        public JsonHeader()
        {
            this.PackageCollection = new List<Package>();
        }

        [JsonProperty("Packages")]
        public List<Package> PackageCollection;
    }
    public class JsonFile
    {
        #region Private vars

        private const string JSON_PACKAGE = "Package";

        private const string JSON_PACKAGE_FILE = "PackageFile";

        private string jsonFilePath = string.Empty;


        #endregion

        #region Constructor

        public JsonFile() {
            this.Header = new JsonHeader();
        }

        public JsonFile(string jsonFilePath)
        {
            this.Header = new JsonHeader();

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

        public JsonHeader Header {
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
                var header = JsonConvert.DeserializeObject<JsonHeader>(jsonContent);
                if(header != null)
                {
                    this.Header = header;
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
                if (this.Header == null)
                {
                    return;
                }
                string jsonContent = JsonConvert.SerializeObject(this.Header, Formatting.Indented);
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
