using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Base
{
    public class Utility
    {

        public static bool IsGameRootFolderValid(string gamerootDir)
        {
            bool isValid = false;

            isValid =
                Directory.Exists(Utility.AdvancedPathCombine(gamerootDir, "usermaps")) &&
                Directory.Exists(Utility.AdvancedPathCombine(gamerootDir, "share")) &&
                Directory.Exists(Utility.AdvancedPathCombine(gamerootDir, "model_export")) &&
                Directory.Exists(Utility.AdvancedPathCombine(gamerootDir, "xanim_export")) &&
                Directory.Exists(Utility.AdvancedPathCombine(gamerootDir, "source_data")) &&
                Directory.Exists(Utility.AdvancedPathCombine(gamerootDir, "texture_assets")) &&
                Directory.Exists(Utility.AdvancedPathCombine(gamerootDir, "sound_assets"));

            return isValid;
        }

        public static string AdvancedPathCombine(string path1, string path2)
        {

            if (path1 == string.Empty)
            {
                return path2;
            }

            // Ensure neither end of path1 or beginning of path2 have slashes
            path1 = path1.Trim().TrimEnd(System.IO.Path.DirectorySeparatorChar);
            path2 = path2.Trim().TrimStart(System.IO.Path.DirectorySeparatorChar);

            // Handle drive letters
            if (path1.Substring(path1.Length - 1, 1) == ":")
            {
                path1 += System.IO.Path.DirectorySeparatorChar;
            }

            return System.IO.Path.Combine(path1, path2);
        }

        public static string PickFile()
        {
            string path = string.Empty;
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                DialogResult res = dlg.ShowDialog();
                if (res == DialogResult.OK)
                {
                    path = dlg.FileName;
                }
            }
            return path;
        }

        public static string SaveFile(string filter)
        {
            string path = string.Empty;
            using (SaveFileDialog dlg = new SaveFileDialog())
            {
                dlg.Filter = filter;

                DialogResult res = dlg.ShowDialog();
                if (res == DialogResult.OK)
                {
                    path = dlg.FileName;
                }
            }
            return path;
        }


        public static string PickFolder()
        {
            string path = string.Empty;
            using (FolderBrowserDialog dlg = new FolderBrowserDialog())
            {
                DialogResult res = dlg.ShowDialog();
                if (res == DialogResult.OK)
                {
                    path = dlg.SelectedPath;
                }
            }
            return path;
        }

    }
}
