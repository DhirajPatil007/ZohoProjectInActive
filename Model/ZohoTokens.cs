using System;
using System.Collections.Generic;

namespace ZohoAPIProjectsInActive.Model
{
    public partial class ZohoTokens
    {
        public int Id { get; set; }
        public string AccessToken { get; set; }
        public string ApiDomain { get; set; }
        public string TokenType { get; set; }
        public int? ExpiresIn { get; set; }
        public DateTime? ExpiredDate { get; set; }
    }
}
