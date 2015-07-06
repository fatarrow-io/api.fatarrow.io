using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api.fatarrow.io.Models
{
    public class Author
    {
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string twitter { get; set; }
        public string website { get; set; }
        public string bio { get; set; }
    }
}
