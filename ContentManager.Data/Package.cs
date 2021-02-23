using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContentManager.Data
{
    public class Package
    {

        public Package(string pkgName, int id)
        {
            this.PkgId = id;

            this.Name = pkgName;
        }

        public int PkgId { get; set; }

        public string Name { get; set; }

        public string Path { get; set; }

        public string[] Credits { get; set; }
    }

    public class PackageException : Exception
    {
        public PackageException(string message)
        : base(message)
        {
        }

        public PackageException(string message, Exception inner)
            : base(message, inner)
        {
        }

    }
}
