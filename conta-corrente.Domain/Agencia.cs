using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ContaCorrente.Domain
{
    public class Agencia
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int32 IdAgencia { get; set; }
        public String Nome { get; set; }
        public String Endereco { get; set; }
        public Int32 Numero { get; set; }
    }
}
