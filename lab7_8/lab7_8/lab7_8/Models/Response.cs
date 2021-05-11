using System;
using System.Collections.Generic;
using System.Text;

namespace lab7_8.Models
{
    public class Response
    {
        public int status_code { get; set; }
        public bool success { get; set; }
        public string status_message { get; set; }
    }
}
