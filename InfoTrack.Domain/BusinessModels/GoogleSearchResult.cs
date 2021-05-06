using System;
using System.Collections.Generic;
using System.Text;

namespace InfoTrack.Domain.BusinessModels
{
    public class GoogleSearchResult
    {
        public int Index { get; set; }
        public string Uri { get; set; }
        public string Title { get; set; }
        public string RelevantContent { get; set; }
    }
}
