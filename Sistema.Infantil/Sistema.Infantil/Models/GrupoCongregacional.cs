using System;
using System.Collections.Generic;

namespace Sistema.Infantil.Models
{
    public partial class GrupoCongregacional
    {
        public GrupoCongregacional()
        {
            this.Igrejas = new List<Igreja>();
        }

        public int ID_GRUPOCONGREGACIONAL { get; set; }
        public string NM_NOME { get; set; }
        public virtual ICollection<Igreja> Igrejas { get; set; }
    }
}
