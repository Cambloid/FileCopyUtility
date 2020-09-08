using LiteDB;
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
        public string RelPath { get; set; }

        public bool UseFile { get; set; }

        public byte[] Sha256Hash { get; set; }

        public string PackageId { get; set; }

        public Package Pkg { get; set; }
    }

    public struct Package
    {
        public string Name { get; set; }

        public string Path { get; set; }

        public string[] Credits { get; set; }

    }

    public class ProjectConfig
    {
        public string StoragePath { get; set; }

        public string RootPath { get; set; }

        public string BackupPath { get; set; }
    }
}
