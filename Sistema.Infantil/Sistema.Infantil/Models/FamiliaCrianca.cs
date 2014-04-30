using System;
using System.Collections.Generic;

namespace Sistema.Infantil.Models
{
    public partial class FamiliaCrianca
    {
        public FamiliaCrianca()
        {
            this.FamiliaCriancasLogs = new List<FamiliaCriancasLog>();
        }

        public int ID_FAMILIACRIANCAS { get; set; }
        public Nullable<int> ID_FAMILIA { get; set; }
        public Nullable<int> ID_IGREJA { get; set; }
        public string NM_NOME { get; set; }
        public Nullable<System.DateTime> DT_NASCIMENTO { get; set; }
        public byte[] DS_FOTO { get; set; }
        public string DS_OBSERVACAO { get; set; }
        public virtual Familia Familia { get; set; }
        public virtual ICollection<FamiliaCriancasLog> FamiliaCriancasLogs { get; set; }
    }
}
