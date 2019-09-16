using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS_Ga2.Entity
{
    public class AuthorViewModel
    {
        public string id { get; set; }
        public string pid { get; set; }
        public string name { get; set; }
        public bool checked_ { get;set;}
        public string open { get; set; }
        public bool disabled { get; set; }        
    }
}
