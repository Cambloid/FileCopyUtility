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

        Use_file_current_package,

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
        #region Private vars

        private ConflictType type = ConflictType.Files_same_hash;

        private List<Tuple<Package, PackageFile>> files = new List<Tuple<Package, PackageFile>>();
        
        private PackageFile fileToUse = new PackageFile();

        #endregion

        #region Constructor

        public FileConflict()
        {
            this.Solution = ConflictSolution.Unresolved;
        }

        // Conflict in package
        public FileConflict(ConflictType t, List<Tuple<Package, PackageFile>> f)
        {
            this.type = t;
            this.files = f;
        }

        // Conflict package <-> gameroot
        public FileConflict(ConflictType t, Tuple<Package, PackageFile> f)
        {
            this.type = t;
            this.files.Add(f);
        }

        #endregion

        #region Public properties

        public ConflictSolution Solution { get; private set; }

        public PackageFile SolutionFile { get => this.fileToUse; }

        public ConflictType ConflictType
        {
            get => this.type;
        }

        public List<PackageFile> ConflictFiles { get => this.files.Select(x => x.Item2).ToList(); }

        public bool ConflictsInGameroot { get; set; }

        #endregion

        #region Public Methods

        public void SolveConflict(ConflictSolution s, PackageFile fileToUse)
        {
            this.Solution = s;
            this.fileToUse = fileToUse;
        }

        public List<Tuple<Package, PackageFile>> Group
        {
            get => this.files;
        }

        #endregion
    }
}
