using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ContaCorrente.Domain
{
    public class Conta
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int32 IdConta { get; set; }
        public Int32 NumeroConta { get; set; }
        public Double Saldo { get; set; }
    }
}
