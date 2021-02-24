using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace ContentManager
{
    public class FileList
    {
        #region Public vars

        public List<string> Files;

        #endregion

        #region Constructor

        public FileList()
        {
            this.Files = new List<string>();
        }

        #endregion

        #region Public methods

        public void SaveToFile(string filePath)
        {
            try
            {

                this.removeDublicates();
                // Trim whitespaces
                this.Files.ForEach(str => str.Trim());

                // Sort alphabetically because sort order is visible in git file diff
                this.Files.Sort();

                File.WriteAllLines(filePath, this.Files, Encoding.UTF8);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }

        public void LoadFromFile(string filePath)
        {
            try
            {
                this.Files.Clear();
                this.Files = File.ReadAllLines(filePath, Encoding.UTF8).ToList<string>();

                //Check for dublicates and remove them
                this.removeDublicates();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public bool CheckIfFileExistsInList(string baseRelativePath)
        {
            return this.Files.Contains(baseRelativePath);
        }

        #endregion

        #region Private methods

        private void removeDublicates()
        {
            var duplicates = this.Files.GroupBy(x => x).Any(g => g.Count() > 1);
            if (duplicates)
            {
                int initialCount = this.Files.Count;
                this.Files = this.Files.Distinct().ToList<string>();
                Console.WriteLine("Doublicates removed from list:" + (initialCount - this.Files.Count).ToString());
            }
        }

        #endregion
    }


}
