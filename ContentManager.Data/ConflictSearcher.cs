using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContentManager.Data
{
    // Check all packages if there are conflicting files
    // specifically files which have the same name and in the 
    // same directory but differ in content
    public class ConflictSearcher
    {
        private Project prj;

        public ConflictSearcher(Project prj)
        {
            this.prj = prj;
        }

        public List<FileConflict> FindConflicts()
        {
            // 1. list all files
            // 2. sort list by path to check if they are in the same dir
            // 3. compare dublicate files by hash
            // 4. if the files have the same hash then create a "warning"
            //    if the files differ in hash then mark it as "attention"
            // 5. List conflicts

            List<Tuple<Package, PackageFile>> files = new List<Tuple<Package, PackageFile>>();
            
            
            foreach(Package pkg in this.prj.GetPackages())
            {
                foreach(PackageFile file in pkg.FileCollection)
                {
                    files.Add(new Tuple<Package, PackageFile>(pkg, file));
                }
            }

            var sortedFiles = files
                .OrderBy(x => x.Item2.RelPath)
                .GroupBy(x => x.Item2.RelPath)
                .Where(x => x.Count() > 1)
                .ToList();

            List<FileConflict> conflicts = new List<FileConflict>();

            // process group of files with the same relative path
            foreach(var group in sortedFiles)
            {
                string hash = string.Empty;
                foreach(var file in group)
                {
                    if(hash == string.Empty)
                    {
                        hash = file.Item2.Sha256;
                        continue;
                    }
                    if(hash == file.Item2.Sha256)
                    {
                        // Files are the same but generate a warning, check next file
                        conflicts.Add(new FileConflict(ConflictType.Files_same_hash, group.ToList()));
                        continue;
                    } else {
                        // Files are not the same -> generate an attention message
                        conflicts.Add(new FileConflict(ConflictType.Files_different_hash, group.ToList()));
                        continue;
                    }
                }
            }
            return conflicts;
        }

        private void analyseGroup(List<Tuple<Package, PackageFile>> similarFiles)
        {

        }

    }
}
