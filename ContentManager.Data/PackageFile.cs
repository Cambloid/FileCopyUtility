using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContentManager.Data
{
    public class PackageFile
    {
        public PackageFile()
        {
            this.FileId = -1;
            this.RelPath = string.Empty;
            this.Sha256 = string.Empty;
            this.PackageFK = -1;
        }
        public int FileId { get; set; }

        public string RelPath { get; set; }

        public string Sha256 { get; set; }

        public int PackageFK { get; set; }
    }
}
