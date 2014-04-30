using System;
using System.Collections.Generic;

namespace Sistema.Infantil.Models
{
    public partial class FamiliaCriancasLog
    {
        public int ID_FAMILIACRIANCASLOG { get; set; }
        public Nullable<int> ID_FAMILIACRIANCAS { get; set; }
        public Nullable<System.DateTime> DT_ENTRADA { get; set; }
        public Nullable<System.DateTime> DT_SAIDA { get; set; }
        public virtual FamiliaCrianca FamiliaCrianca { get; set; }
    }
}
