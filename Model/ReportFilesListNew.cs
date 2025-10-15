using System;
using System.Collections.Generic;

namespace ZohoAPIProjectsInActive.Model
{
    public partial class ReportFilesListNew
    {
        public int ImportId { get; set; }
        public decimal? ExchangeRate { get; set; }
        public int? FileWeek { get; set; }
        public int? FileYear { get; set; }
        public string LineStatus { get; set; }
        public DateTime? UploadedDate { get; set; }
    }
}
