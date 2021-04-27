﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContentManager.Data
{
    public class PackageFile
    {
        public PackageFile()
        {
            this.FileId = -1;
            this.RelPath = string.Empty;
            this.Sha256 = string.Empty;
            this.PackageFK = -1;
            this.Name = string.Empty;
            this.DoNotCopy = false;
        }
        public int FileId { get; set; }

        public string RelPath { get; set; }

        public string Sha256 { get; set; }

        public int PackageFK { get; set; }

        public string Name { get; set; }

        public bool DoNotCopy { get; set; }

        [JsonIgnore]
        public bool ExistsInGameRoot { get; set; }
    }
}
