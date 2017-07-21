using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestWCF
{
    public class Response
    {
        public bool success { get; set; }
        public string status { get; set; }

        public List<string> errors { get; set; }

        public object data { get; set; }
    }
}
