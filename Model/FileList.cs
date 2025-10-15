using System;
using System.Collections.Generic;

namespace ZohoAPIProjectsInActive.Model
{
    public partial class FileList
    {
        public string JsonFilePath { get; set; }
        public string FilePrefix { get; set; }
        public string FileType { get; set; }
        public double? FileCounter { get; set; }
        public string JsonFileName { get; set; }
        public string Branch { get; set; }
        public string TxnType { get; set; }
        public string JsonFileData { get; set; }
    }
}
