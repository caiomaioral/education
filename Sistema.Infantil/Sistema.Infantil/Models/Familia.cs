using System;
using System.Collections.Generic;

namespace Sistema.Infantil.Models
{
    public partial class Familia
    {
        public Familia()
        {
            this.FamiliaCriancas = new List<FamiliaCrianca>();
            this.FamiliaMembros = new List<FamiliaMembro>();
        }

        public int ID_FAMILIA { get; set; }
        public string NM_FAMILIA { get; set; }
        public virtual ICollection<FamiliaCrianca> FamiliaCriancas { get; set; }
        public virtual ICollection<FamiliaMembro> FamiliaMembros { get; set; }
    }
}
