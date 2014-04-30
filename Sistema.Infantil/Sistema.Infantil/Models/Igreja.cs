using System;
using System.Collections.Generic;

namespace Sistema.Infantil.Models
{
    public partial class Igreja
    {
        public int ID_IGREJA { get; set; }
        public Nullable<int> ID_GRUPOCONGREGACIONAL { get; set; }
        public string NM_NOME { get; set; }
        public string NR_CNPJ { get; set; }
        public string NR_CEP { get; set; }
        public int TP_LOGRADOURO { get; set; }
        public string NM_ENDERECO { get; set; }
        public string NR_NUMERO { get; set; }
        public string NM_COMPLEMENTO { get; set; }
        public string NM_BAIRRO { get; set; }
        public string NM_CIDADE { get; set; }
        public string NM_UF { get; set; }
        public Nullable<int> NR_MUNICIPIO { get; set; }
        public string NR_FONE { get; set; }
        public string NM_EMAIL { get; set; }
        public string NM_NOME_CONTRATANTE { get; set; }
        public string NR_CPF_CONTRATANTE { get; set; }
        public string NM_EMAIL_CONTRATANTE { get; set; }
        public virtual GrupoCongregacional GrupoCongregacional { get; set; }
    }
}
