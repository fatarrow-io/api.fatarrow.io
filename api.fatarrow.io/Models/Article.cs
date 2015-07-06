using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api.fatarrow.io.Models
{
    public class Article
    {
        public int id { get; set; }
        public string title { get; set; }
        public string titleFormattted { get; set; }
        public DateTime published { get; set; }
        public List<string> tags { get; set; }
        public List<Author> authors { get; set; }
    }
}
