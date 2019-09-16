using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS_Ga2.Entity
{
    public class UILanguage
    {

        public int IdUILanguage {get;set;}
        public string LangCode {get;set;}
        public string LangName { get;set;}
        public string Comments { get;set;}
        public int NroOrden { get; set; }
        public int  StateData { get;set;}
        public string ElementCaptionText { get; set; } //Campo Pivot
        public string ElementCode { get; set; }
    }
}
