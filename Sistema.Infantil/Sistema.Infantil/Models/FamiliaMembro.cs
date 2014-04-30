using System;
using System.Collections.Generic;

namespace Sistema.Infantil.Models
{
    public partial class FamiliaMembro
    {
        public int ID_FAMILIAMEMBROS { get; set; }
        public Nullable<int> ID_FAMILIA { get; set; }
        public Nullable<int> ID_IGREJA { get; set; }
        public Nullable<byte> TP_RESPONSAVEL { get; set; }
        public string NM_NOME { get; set; }
        public Nullable<System.DateTime> DT_NASCIMENTO { get; set; }
        public Nullable<byte> TP_DOCUMENTO { get; set; }
        public string NR_DOCUMENTO { get; set; }
        public string NR_CEP { get; set; }
        public string NM_ENDERECO { get; set; }
        public string NR_NUMERO { get; set; }
        public string NM_COMPLEMENTO { get; set; }
        public string NM_BAIRRO { get; set; }
        public string NM_CIDADE { get; set; }
        public string NM_UF { get; set; }
        public Nullable<int> NR_MUNICIPIO { get; set; }
        public string NR_FONE { get; set; }
        public string NM_EMAIL { get; set; }
        public byte[] DS_FOTO { get; set; }
        public virtual Familia Familia { get; set; }
    }
}
