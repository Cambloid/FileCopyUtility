using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContentManager.Data
{
    public class PackageFile
    {
        public int FileId { get; set; }

        public string RelPath { get; set; }

        public string Sha256Hash { get; set; }

        public int PackageFK { get; set; }
    }
}
