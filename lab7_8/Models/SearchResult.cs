using System;
using System.Collections.Generic;
using System.Text;

namespace lab7_8.Models
{
    public class SearchResult<T>
    {
        public int page { get; set; }
        public List<T> results { get; set; }
        public int total_results { get; set; }
        public int total_pages { get; set; }
    }
}
