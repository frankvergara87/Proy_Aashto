using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS_Ga2.Entity
{
    public class UIElement
    {

        public int IdUIElement { get; set; }
        public int IdUILanguage { get; set; }
        public string ElementCode { get; set; }
        public string ElementCaptionText { get; set; }
        public string ElementToolTipText { get; set; }
        public int StateData { get; set; }


    }
}
