using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContentManager
{
    public enum ConflictType
    {
        NoConflict,
        Resolved,
        FileIsDifferentInRoot,
        FileExistsInOtherPackage,
    }

    public enum ConflictResolveType
    {
        UseFileCurrPackage,
        UseFileOtherPackage,
    }

    public struct ConflictResolve
    {
        public ConflictResolveType Type;

        Guid File;
    }

    public struct Conflict
    {
        public ConflictType Type;

        public List<Guid> File;

        public ConflictResolve Solution;
    }

    public struct PackageFile
    {
        public string RelPath;

        public bool UseFile;

        public byte[] Sha256Hash;

        public Guid UniqueID;
    }

    public struct Package
    {
        public string Name;

        public string Path;

        public List<string> Credits;

        public string ID;

        public List<PackageFile> Files; 

    }

    public class ProjectConfig
    {

        public string StoragePath { get; set; }

        public string RootPath { get; set; }

        public string BackupPath { get; set; }

    }
}
