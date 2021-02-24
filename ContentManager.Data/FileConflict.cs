using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContentManager.Data
{
    public enum ConflictSolution
    {
        Unresolved,

        Use_file_from_pkg_specified,

        Do_not_copy_File,

        Use_custom_file,
    }

    public enum ConflictType
    {
        Files_same_hash,
        Files_different_hash
    }

    public class FileConflict
    {
        private ConflictType type = ConflictType.Files_same_hash;
        
        private List<Tuple<Package, PackageFile>> files;
        
        private ConflictSolution solution = ConflictSolution.Unresolved;

        private PackageFile fileToUse;

        public FileConflict(ConflictType t, List<Tuple<Package, PackageFile>> f)
        {
            this.type = t;
            this.files = f;
        }

        public void SolveConflict(ConflictSolution s, PackageFile fileToUse)
        {
            this.solution = s;
            this.fileToUse = fileToUse;
        }

        public List<Tuple<Package, PackageFile>> Group
        {
            get => this.files;
        }
    }
}
