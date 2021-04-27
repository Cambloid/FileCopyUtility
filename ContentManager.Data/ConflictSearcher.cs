using Base;
using System;
using System.Collections.Generic;
using System.IO;
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

        public List<FileConflict> FindConflictsBetweenPkgs()
        {
            // TODO: Make this paralell

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

            var doublicateFiles = files
                .OrderBy(x => x.Item2.RelPath)
                .GroupBy(x => x.Item2.RelPath)
                .Where(x => x.Count() > 1)
                .ToList();

            List<FileConflict> conflicts = new List<FileConflict>();

            // process group of files with the same relative path
            foreach(var doublicate in doublicateFiles)
            {
                string hash = string.Empty;
                foreach(var file in doublicate)
                {
                    if(hash == string.Empty)
                    {
                        hash = file.Item2.Sha256;
                        continue;
                    }
                    if(hash == file.Item2.Sha256)
                    {

                        // Files are the same but generate a warning, check next file
                        conflicts.Add(new FileConflict(ConflictType.Files_same_hash, doublicate.ToList()));
                        continue;

                    } else {
                        // Files are not the same -> generate an attention message
                        conflicts.Add(new FileConflict(ConflictType.Files_different_hash, doublicate.ToList()));
                        continue;
                    }
                }
            }

            // check files in root dir
            {
                // Scope for benchmark (TODO)

                foreach (var file in files)
                {
                    string modSourceFile = Utility.AdvancedPathCombine(this.prj.ModSourceDir, file.Item2.RelPath);

                    string gameRootFile = Utility.AdvancedPathCombine(this.prj.GameRootDir, file.Item2.RelPath);

                    // Check if file exists in gameroot 
                    // if yes compare hash value
                    file.Item2.ExistsInGameRoot = File.Exists(gameRootFile);

                    if (file.Item2.ExistsInGameRoot)
                    {
                        bool isEqual = Utility.IsHashEqual(
                            Utility.GetFileHash(gameRootFile),
                            file.Item2.Sha256
                            );

                        // Files in package is different from gameroot
                        // Generate a conflict
                        if (!isEqual)
                        {
                            // Check if conflicting file already exists
                            List<FileConflict> conflictedFiles = conflicts.Where(x => x.ConflictFiles.Contains(file.Item2)).ToList();
                            if (conflictedFiles.Any())
                            {
                                conflictedFiles.ForEach(x => x.ConflictsInGameroot = true);

                            } else 
                            {
                                // Create a new conflict
                                conflicts.Add(
                                new FileConflict(
                                    ConflictType.Files_different_hash,
                                    new Tuple<Package, PackageFile>(file.Item1, file.Item2)
                                )
                                );
                            }
                        }
                    }
                }

            }

            return conflicts;
        }

        public List<FileConflict> FindConflictsPkgGameroot(Package p)
        {

            // TODO: Make this paralell
            List<FileConflict> fConflicts = new List<FileConflict>();
            p.FileCollection.ForEach(x =>
            {

                if (x.DoNotCopy)
                {
                    return;
                }

                string fileGameRootPath = Utility.AdvancedPathCombine(this.prj.GameRootDir, x.RelPath);
                string filePackagePath = Utility.AdvancedPathCombine(p.Path, x.RelPath);

                if (!Utility.AreFilesEqual(fileGameRootPath, filePackagePath) && File.Exists(fileGameRootPath))
                {
                    var fc = new FileConflict(
                            ConflictType.Files_different_hash,
                            new Tuple<Package, PackageFile>(p, x));
                    
                    fConflicts.Add(fc);
                }
            });

            return fConflicts;
        }

    }
}
