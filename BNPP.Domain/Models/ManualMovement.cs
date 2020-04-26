using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BNPP.Domain.Models
{
    public class ManualMovement
    {
        public int Dat_Mes { get; set; }
        public int Dat_Ano { get; set; }
        public int Num_Lancamento { get; set; }
        public string Cod_Produto { get; set; }
        public string Des_Produto { get; set; }
        [Browsable(false)]
        public string Cod_Cosif { get; set; }
        public double Val_Valor { get; set; }
        [Browsable(false)]
        public string Des_Descricao { get; set; }
        [Browsable(false)]
        public DateTime Dat_Movimento { get; set; }
        [Browsable(false)]
        public string Cod_Usuario { get; set; }
        
    }
}
