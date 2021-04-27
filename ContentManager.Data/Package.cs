using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContentManager.Data
{
    public class Package
    {
        public enum PackageStatus
        {
            Installed,
            Not_Installed
        }

        public Package(string pkgName, int id)
        {
            this.PkgId = id;
            this.Name = pkgName;

            this.Status = PackageStatus.Not_Installed;

            this.FileCollection = new List<PackageFile>();
            this.Path = string.Empty;
            this.Credits = new string[0];

        }

        public int PkgId { get; set; }

        public long ByteSize { get; set; }

        public string Name { get; set; }

        public string Path { get; set; }

        public string[] Credits { get; set; }

        // Do not save this field in json
        [JsonIgnore]
        public PackageStatus Status {get; set;}

        [JsonProperty("Files")]
        public List<PackageFile> FileCollection { get; set; }
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
