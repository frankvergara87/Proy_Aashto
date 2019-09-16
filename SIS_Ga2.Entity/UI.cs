using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace SIS_Ga2.Entity
{
    public class UI
    {

        public int IdUIElement { get; set; }
        public int IdUILanguage { get; set; }
        public string ElementCode { get; set; }
        public string ElementCaptionText { get; set; }
        public string ElementToolTipText { get; set; }
        public Boolean StateData { get; set; }
        public DataTable Tbl { get; set; }
        public List<UILanguage> Idioma { get; set; }
        public T Clone<T>() where T : UI
        {
            return (T)this.MemberwiseClone();
        }
    }
}
